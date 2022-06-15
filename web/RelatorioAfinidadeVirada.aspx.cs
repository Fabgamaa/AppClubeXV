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
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
        Maquina Maquina = new Maquina();
        DataSet dsMaquina = Maquina.Consultar();
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id);
        dsMaquina.Dispose();
    }

    protected string CriaFiltro(Afinidade Afinidade)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            Afinidade.AFN_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Afinidade.AFN_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tip.Text))
        {
            Afinidade.AFN_TIP = Convert.ToInt32(cbo_tip.SelectedValue);
            filtro = filtro + "Tipo= " + cbo_tip.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Afinidade.AFN_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_id.Text))
        {
            Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vrd.Text))
        {
            Afinidade.AFN_VRD = Convert.ToInt32(txt_vrd.Text);
            filtro = filtro + "Virada= " + txt_vrd.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Afinidade.AFN_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Afinidade Afinidade = new Afinidade();
        filtro = CriaFiltro(Afinidade);
        string[] afiltro = filtro.Split(';');
        if ((filtro == "") || ((txt_lot.Text == "") && ((afiltro.Length - 1) < 2)))
        {
            TratamentoErro("O Filtro deve possuir o Lote ou outros dois argumentos.");
            txt_dat_ini.Focus();
            return;
        }

        DataSet dsAfinidade = Afinidade.RelatorioAfinidadeVirada();
        gvAfinidade.DataSource = dsAfinidade;
        gvAfinidade.DataBind();
        dsAfinidade.Dispose();
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
        dvAfinidade.Visible = true;
    }
    
    protected void gvAfinidade_RowDataBound(object sender, GridViewRowEventArgs e)
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
        }
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
        foreach (DataControlField field in gvAfinidade.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvAfinidade.Columns.IndexOf(field);
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

    protected void gvAfinidade_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvAfinidade_Sorting(Object sender, GridViewSortEventArgs e)
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

        Afinidade Afinidade = new Afinidade();
        filtro = CriaFiltro(Afinidade);
        DataSet dsAfinidade = Afinidade.RelatorioAfinidadeVirada();

        DataTable dtAfinidade = dsAfinidade.Tables[0];
        DataView dvAfinidade = new DataView(dtAfinidade);
        dvAfinidade.Sort = e.SortExpression + Ordem;
        gvAfinidade.DataSource = dvAfinidade;
        gvAfinidade.DataBind();

        dvAfinidade.Dispose();
        dtAfinidade.Dispose();
        dsAfinidade.Dispose();
        Dispose();
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvAfinidade.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Lista.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvAfinidade.AllowSorting = false;
            gvAfinidade.AllowPaging = false;
            //gvAfinidade.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvAfinidade.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvAfinidade.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvAfinidade.RenderControl(htmlWrite);

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
        if (gvAfinidade.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=AfinidadeVirada.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvAfinidade.AllowSorting = false;
            gvAfinidade.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvAfinidade.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvAfinidade.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvAfinidade.RenderControl(htmlWrite);

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
}