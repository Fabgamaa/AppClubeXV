using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    string sChave = "";
    double dQTD = 0;
    double dTOT = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["rowId"] != null)
            rowId.Value = Request["rowId"].ToString();

        if (Request["Origem"] != null)
            Origem.Value = Request["Origem"].ToString();

        if (!IsPostBack)
        {
            if (!String.IsNullOrEmpty(Origem.Value))
            {
                ucBarra.Visible = false;
                Form.Style.Add("width", "550");
                Form.Style.Add("height", "200");
            }

            FormataControles();
            CarregaControles();
        }
    }

    protected void FormataControles()
    {
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

        txt_dat_ini.Focus();
    }

    protected void CarregaControles()
	{
        CarregaMotivo();
	}

    protected string CriaFiltro(OLT OLT)
	{
		string filtro = "";
		if (!String.IsNullOrEmpty(txt_dat_ini.Text))
		{
			OLT.OLT_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
			filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
		}
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            OLT.OLT_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_mtv_id.Text))
        {
            OLT.OLT_MTV_ID = Convert.ToInt32(cbo_mtv_id.SelectedValue);
            filtro = filtro + "Motivo= " + cbo_mtv_id.SelectedItem.Text + "; ";
        }
        OLT.OLT_STS = 1; //Somente Ativos

        return filtro;
	}

    protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		OLT OLT = new OLT();
        filtro = CriaFiltro(OLT);
        DataSet dsOLT = OLT.RelatorioMotivoDesclassificacao();
        
        gvOLT.DataSource = dsOLT;
        gvOLT.DataBind();
		dsOLT.Dispose();
		Dispose();

		if (!String.IsNullOrEmpty(filtro))
		{
			lb_fil.Text = filtro;
		}
		else
		{
			lb_fil.Text = "Não há filtros.";
		}

		dvFiltro.Visible = false;
		dvResultado.Visible = true;
	}

    protected void gvOLT_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.className='selecionado';");
            if ((e.Row.RowIndex % 2) == 0)
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_par';");
            }
            else
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_impar';");
            }

            Label lChave = (Label)e.Row.FindControl("lbOLT_LOT");

            //Primeira Linha Salvo a Chave
            if (e.Row.RowIndex == 0)
            {
                sChave = lChave.Text;
            }
            else
            {
                //Se a Chave é Diferente Apresento o Total
                if (sChave != lChave.Text)
                {
                    gvOLT_SubTotal(sender, e, lChave);

                    dQTD = 0;
                }
            }

            Label lQTD = (Label)e.Row.FindControl("lbQTD");
            dQTD += Convert.ToDouble(lQTD.Text);
            dTOT += Convert.ToDouble(lQTD.Text);
        }
        else if (e.Row.RowType == DataControlRowType.Footer)
        {
            //Ultima Linha
            Label lChave = new Label();
            lChave.Text = "";
            gvOLT_SubTotal(sender, e, lChave);
            gvOLT_Total(sender, e);
        }
    }

    private void gvOLT_SubTotal(object sender, GridViewRowEventArgs e, Label lChave)
    {
        sChave = lChave.Text;

        Table tTotal = (Table)this.gvOLT.Controls[0];
        int iIndex = tTotal.Rows.GetRowIndex(e.Row);
        GridViewRow gvTotal = new GridViewRow(iIndex, iIndex, DataControlRowType.Separator, DataControlRowState.Normal);

        TableCell tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 2; // Total é a coluna 3
        tcTotal.Text = "Total";
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dQTD.ToString();
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 3; //Até o fim da tabela
        tcTotal.Text = "";
        gvTotal.Cells.Add(tcTotal);

        tTotal.Controls.AddAt(iIndex, gvTotal);
    }

    private void gvOLT_Total(object sender, GridViewRowEventArgs e)
    {
        Table tTotal = (Table)this.gvOLT.Controls[0];
        int iIndex = tTotal.Rows.GetRowIndex(e.Row);
        GridViewRow gvTotal = new GridViewRow(iIndex, iIndex, DataControlRowType.Separator, DataControlRowState.Normal);

        TableCell tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 2; // Total é a coluna 3
        tcTotal.Text = "Total Geral";
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dTOT.ToString();
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 3; //Até o fim da tabela
        tcTotal.Text = "";
        gvTotal.Cells.Add(tcTotal);

        tTotal.Controls.AddAt(iIndex, gvTotal);
    }

    private SortDirection GridViewSortDirection
    {
        get
        {
            if (ViewState["sortDirection"] == null)
                ViewState["sortDirection"] = SortDirection.Ascending;
            return (SortDirection)ViewState["sortDirection"];
        }
        set { ViewState["sortDirection"] = value; }
    }

    private int GetSortColumnIndex()
    {
        foreach (DataControlField field in gvOLT.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvOLT.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddSortImage(int columnIndex, GridViewRow headerRow)
    {
        System.Web.UI.WebControls.Image sortImage = new System.Web.UI.WebControls.Image();
        if (GridViewSortDirection == SortDirection.Ascending)
        {
            sortImage.ImageUrl = "img/arrow_down.gif";
            sortImage.AlternateText = "Ordem Ascendente";
        }
        else
        {
            sortImage.ImageUrl = "img/arrow_up.gif";
            sortImage.AlternateText = "Ordem Descendente";
        }
        headerRow.Cells[columnIndex].Controls.Add(sortImage);
    }

    protected void gvOLT_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            int sortColumnIndex = GetSortColumnIndex();
            if (sortColumnIndex != -1)
            {
                AddSortImage(sortColumnIndex, e.Row);
            }
        }
    }

    protected void gvOLT_Sorting(Object sender, GridViewSortEventArgs e)
	{
		string Ordem = " ASC ";
		string sortExpression = e.SortExpression;
		ViewState["SortExpression"] = sortExpression;
		if (GridViewSortDirection == SortDirection.Ascending)
		{
			GridViewSortDirection = SortDirection.Descending;
			Ordem = " DESC ";
		}
		else
		{
			GridViewSortDirection = SortDirection.Ascending;
			Ordem = " ASC ";
		}

		string filtro = "";

		OLT OLT = new OLT();
		filtro = CriaFiltro(OLT);
        DataSet dsOLT = OLT.RelatorioMotivoDesclassificacao();

        DataTable dtOLT = dsOLT.Tables[0];
        DataView dvOLT = new DataView(dtOLT);
        dvOLT.Sort = e.SortExpression + Ordem;
        gvOLT.DataSource = dvOLT;
        gvOLT.DataBind();

        dvOLT.Dispose();
        dtOLT.Dispose();
		dsOLT.Dispose();
		Dispose();
	}

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvOLT.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOLT.AllowSorting = false;
            gvOLT.AllowPaging = false;
            //gvOLT.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvOLT.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvOLT.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvOLT.RenderControl(htmlWrite);

            StringReader stringReader = new StringReader(stringWrite.ToString());
            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlParser = new HTMLWorker(pdfDocument);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);
            pdfDocument.Open();
            htmlParser.Parse(stringReader);
            pdfDocument.Close();
            Response.Write(pdfDocument);
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }

    protected void lkb_xls_Click(object sender, EventArgs e)
    {
        if (gvOLT.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOLT.AllowSorting = false;
            gvOLT.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvOLT.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvOLT.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvOLT.RenderControl(htmlWrite);

            Response.Write(stringWrite.ToString());
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }

    public void CarregaMotivo()
    {
        cbo_mtv_id.Items.Clear();
        cbo_mtv_id.Items.Add(new System.Web.UI.WebControls.ListItem("", ""));
        Motivo Motivo = new Motivo();
        DataSet dsMotivo = Motivo.Consultar();
        foreach (DataRow drMotivo in dsMotivo.Tables[0].Rows)
        {
            cbo_mtv_id.Items.Add(new System.Web.UI.WebControls.ListItem(drMotivo["MTV_ID"].ToString() + " - " + drMotivo["MTV_DES"].ToString(), drMotivo["MTV_ID"].ToString()));
        }
        dsMotivo.Dispose();
    }
}