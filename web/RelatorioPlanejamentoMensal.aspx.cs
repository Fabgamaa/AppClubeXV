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
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        dsTitulo.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        dsFornecedor.Dispose();

        Cliente Cliente = new Cliente();
        DataSet dsCliente = Cliente.Consultar();
        FWGNR.VerificaStatus(dsCliente, "CLI_ID", "CLI_NOM", "CLI_STS", cbo_cli_id);
        dsCliente.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        dsMaquinaTipo.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
        dsApresentacao.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id);
        dsEntrelacamento.Dispose();

    }
    
    private void LimpaTela()
    {
        txt_dat_ini.Text = "";
        txt_dat_fim.Text = "";
        txt_lot.Text = "";
        txt_lot_ref.Text = "";
        cbo_tit_poy_id.Text = "";
        txt_mge.Text = "";
        cbo_for_id.Text = "";
        cbo_cli_id.Text = "";
        cbo_aps_id.Text = "";
        cbo_ert_id.Text = "";
        cbo_sts.Text = "";

    }

    protected void btVoltar_Click(object sender, EventArgs e)
    {
        dvResultado.Visible = false;
        dvFiltro.Visible = true;
        txt_dat_ini.Focus();

    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_dat_ini.Focus();

    }

    protected string CriaFiltro(Teste Teste)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            Teste.TST_DAT_INI_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Teste.TST_DAT_FIM_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Teste.TST_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot_ref.Text))
        {
            Teste.TST_LOT_REF = txt_lot_ref.Text;
            filtro = filtro + "Lote Referência= " + txt_lot_ref.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Teste.TST_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Teste.TST_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id.Text))
        {
            Teste.TST_FOR_001_ID = Convert.ToInt32(cbo_for_id.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_cli_id.Text))
        {
            Teste.RTS_CLI_ID = Convert.ToInt32(cbo_cli_id.SelectedValue);
            filtro = filtro + "Cliente= " + cbo_cli_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Teste.TST_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo de Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Teste.TST_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id.Text))
        {
            Teste.TST_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
            filtro = filtro + "Entrelaçãmento= " + cbo_ert_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Teste.TST_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Teste Teste = new Teste();
        filtro = CriaFiltro(Teste);
        DataSet dsTeste = Teste.RelatorioPlanejamentoMensal();

        gvTeste.DataSource = dsTeste;
        gvTeste.DataBind();
        dsTeste.Dispose();
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

    protected void gvTeste_RowDataBound(object sender, GridViewRowEventArgs e)
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
        foreach (DataControlField field in gvTeste.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvTeste.Columns.IndexOf(field);
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

    protected void gvTeste_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvTeste_Sorting(Object sender, GridViewSortEventArgs e)
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

        Teste Teste = new Teste();
        filtro = CriaFiltro(Teste);
        DataSet dsTeste = Teste.RelatorioPlanejamentoMensal();

        DataTable dtTeste = dsTeste.Tables[0];
        DataView dvTeste = new DataView(dtTeste);
        dvTeste.Sort = e.SortExpression + Ordem;
        gvTeste.DataSource = dvTeste;
        gvTeste.DataBind();

        dvTeste.Dispose();
        dtTeste.Dispose();
        dsTeste.Dispose();
        Dispose();
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvTeste.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTeste.AllowSorting = false;
            gvTeste.AllowPaging = false;
            //gvTeste.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvTeste.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTeste.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTeste.RenderControl(htmlWrite);

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
        if (gvTeste.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTeste.AllowSorting = false;
            gvTeste.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvTeste.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTeste.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTeste.RenderControl(htmlWrite);

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