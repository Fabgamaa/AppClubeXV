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
    double dTOT = 0;
    double dPSL = 0;
    double dQTD = 0;
    int iQTD = 0;

    double dTOTTOT = 0;
    double dTOTPSL = 0;
    double dTOTQTD = 0;
    int iTOTQTD = 0;

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

    protected void CarregaControles()	{
	}

    protected string CriaFiltro(DOFF DOFF)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_dat_ini.Text))		{			DOFF.DOF_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);			filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";		}
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            DOFF.DOF_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            DOFF.DOF_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        /*
        if (!String.IsNullOrEmpty(txt_maquina.Text))
        {
            DOFF.DOF_MAQ = txt_maquina.Text;
            filtro = filtro + "Máquina= " + txt_maquina.Text + "; ";
        }
        */ 
        /*
        if (!String.IsNullOrEmpty(txt_merge.Text))
        {
            DOFF.DOF_MGE_001 = txt_merge.Text;
            filtro = filtro + "Merge= " + txt_merge.Text + "; ";
        }
        */ 
        DOFF.DOF_STS = 1; //Somente Ativos

        return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";		DOFF DOFF = new DOFF();
        filtro = CriaFiltro(DOFF);
        DataSet dsDOFF = DOFF.RelatorioFalhaOLT();

        gvDOFF.DataSource = dsDOFF;
        gvDOFF.DataBind();		dsDOFF.Dispose();		Dispose();		if (!String.IsNullOrEmpty(filtro))		{			lb_fil.Text = filtro;		}		else		{			lb_fil.Text = "Não há filtros.";		}		dvFiltro.Visible = false;		dvResultado.Visible = true;	}

    protected void gvDOFF_RowDataBound(object sender, GridViewRowEventArgs e)
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

            OLT OLT = new OLT();
            OLT.OLT_LOT = gvDOFF.DataKeys[e.Row.RowIndex]["DOF_LOT"].ToString();
            OLT.OLT_MAQ = gvDOFF.DataKeys[e.Row.RowIndex]["DOF_MAQ"].ToString();
            //Não consultar por Standard pois OLT podem ser feitas em versões de Standards diferentes
            //OLT.OLT_EPF_ID = Convert.ToInt32(gvDOFF.DataKeys[e.Row.RowIndex]["DOF_EPF_ID"].ToString());
            if (!String.IsNullOrEmpty(txt_dat_ini.Text))
            {
                OLT.OLT_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            }
            if (!String.IsNullOrEmpty(txt_dat_fim.Text))
            {
                OLT.OLT_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            }
            OLT.OLT_STS = 1; //Somente Ativos
            DataSet dsOLT = OLT.ConsultarQuantidade();
            
            if (dsOLT.Tables[0].Rows.Count > 0)
            {
                Label lbQTD = (Label)e.Row.FindControl("lbQTD");
                lbQTD.Text = dsOLT.Tables[0].Rows[0]["QTD"].ToString();

                Label lbDOF_TOT = (Label)e.Row.FindControl("lbDOF_TOT");
                Label lbPSL = (Label)e.Row.FindControl("lbPSL");
                if (lbDOF_TOT.Text != "0")
                {
                    lbPSL.Text = (Convert.ToDouble(lbQTD.Text) / Convert.ToDouble(lbDOF_TOT.Text) * 100).ToString("N2");
                }
                else
                {
                    lbPSL.Text = "0,00";
                }
            }

            Label lChave = (Label)e.Row.FindControl("lbDOF_LOT");

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
                    gvDOFF_SubTotal(sender, e, lChave);

                    dTOT = 0;
                    dPSL = 0;
                    dQTD = 0;

                    iQTD = 0;
                }
            }

            Label lTOT = (Label)e.Row.FindControl("lbDOF_TOT");
            dTOT += Convert.ToDouble(lTOT.Text);

            Label lPSL = (Label)e.Row.FindControl("lbPSL");
            dPSL += Convert.ToDouble(lPSL.Text);

            Label lQTD = (Label)e.Row.FindControl("lbQTD");
            dQTD += Convert.ToDouble(lQTD.Text);

            iQTD += 1;

            dTOTTOT += Convert.ToDouble(lTOT.Text);
            dTOTPSL += Convert.ToDouble(lPSL.Text);
            dTOTQTD += Convert.ToDouble(lQTD.Text);
            iTOTQTD += 1;
        }
        else if (e.Row.RowType == DataControlRowType.Footer)
        {
            //Ultima Linha
            Label lChave = new Label();
            lChave.Text = "";
            gvDOFF_SubTotal(sender, e, lChave);
            gvDOFF_Total(sender, e);
        }
    }

    private void gvDOFF_SubTotal(object sender, GridViewRowEventArgs e, Label lChave)
    {
        sChave = lChave.Text;

        Table tTotal = (Table)this.gvDOFF.Controls[0];
        int iIndex = tTotal.Rows.GetRowIndex(e.Row);
        GridViewRow gvTotal = new GridViewRow(iIndex, iIndex, DataControlRowType.Separator, DataControlRowState.Normal);

        TableCell tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 7; // Total é a coluna 7
        tcTotal.Text = "Total";
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dTOT.ToString();
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = (dPSL / iQTD).ToString("N2");
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dQTD.ToString();
        gvTotal.Cells.Add(tcTotal);

        tTotal.Controls.AddAt(iIndex, gvTotal);
    }

    private void gvDOFF_Total(object sender, GridViewRowEventArgs e)
    {
        Table tTotal = (Table)this.gvDOFF.Controls[0];
        int iIndex = tTotal.Rows.GetRowIndex(e.Row);
        GridViewRow gvTotal = new GridViewRow(iIndex, iIndex, DataControlRowType.Separator, DataControlRowState.Normal);

        TableCell tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.ColumnSpan = 7; // Total é a coluna 7
        tcTotal.Text = "Total Geral";
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dTOTTOT.ToString();
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = (dTOTQTD / dTOTTOT * 100).ToString("N2");
        gvTotal.Cells.Add(tcTotal);

        tcTotal = new TableCell();
        tcTotal.CssClass = "rodape_tabela";
        tcTotal.Text = dTOTQTD.ToString();
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
        foreach (DataControlField field in gvDOFF.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvDOFF.Columns.IndexOf(field);
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

    protected void gvDOFF_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvDOFF_Sorting(Object sender, GridViewSortEventArgs e)	{		string Ordem = " ASC ";		string sortExpression = e.SortExpression;		ViewState["SortExpression"] = sortExpression;		if (GridViewSortDirection == SortDirection.Ascending)		{			GridViewSortDirection = SortDirection.Descending;			Ordem = " DESC ";		}		else		{			GridViewSortDirection = SortDirection.Ascending;			Ordem = " ASC ";		}		string filtro = "";		DOFF DOFF = new DOFF();		filtro = CriaFiltro(DOFF);
        DataSet dsDOFF = DOFF.RelatorioFalhaOLT();

        DataTable dtDOFF = dsDOFF.Tables[0];
        DataView dvDOFF = new DataView(dtDOFF);
        dvDOFF.Sort = e.SortExpression + Ordem;
        gvDOFF.DataSource = dvDOFF;
        gvDOFF.DataBind();

        dvDOFF.Dispose();
        dtDOFF.Dispose();		dsDOFF.Dispose();		Dispose();	}

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvDOFF.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;
            //gvDOFF.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvDOFF.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvDOFF.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvDOFF.RenderControl(htmlWrite);

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
        if (gvDOFF.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvDOFF.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvDOFF.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvDOFF.RenderControl(htmlWrite);

            Response.Write(stringWrite.ToString());
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }
    protected void cbo_maq_id_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}