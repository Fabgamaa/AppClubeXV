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
        
         if (Request["rowId"] != null)
            rowId.Value = Request["rowId"].ToString();

        if (Request["Origem"] != null)
            Origem.Value = Request["Origem"].ToString();

        if (!IsPostBack)
        {
            if (!String.IsNullOrEmpty(Origem.Value))
            {
                ucBarra.Visible = false;
                btNovoFiltro.Visible = false;
                btNovoFiltroGrid.Visible = false;
                Form.Style.Add("width", "550");
                Form.Style.Add("height", "200");
            }

            FormataControles();
            CarregaControles();
            CarregaDados();
        }
    }

    protected void FormataControles()
    {
        txt_dat.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_rej_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_lim_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tot_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
    }

    protected void CarregaControles()

    protected void CarregaDados()
                hid_epf_id.Value = dsDOFF.Tables[0].Rows[0]["DOF_EPF_ID"].ToString();

    private void LimpaTela()
    {
        txt_dat.Text = "";
        txt_maq.Text = "";
        txt_lot.Text = "";
        cbo_sts.Text = "";

        hid_epf_id.Value = "";
        txt_dat_inc.Text = "";
        txt_maq_inc.Text = "";
        txt_rej_inc.Text = "";
        txt_lim_inc.Text = "";
        txt_tot_inc.Text = "";
        txt_lot_inc.Text = "";
        txt_mge_001_inc.Text = "";
        txt_mge_002_inc.Text = "";
        txt_mge_003_inc.Text = "";
        txt_mge_004_inc.Text = "";
        cbo_sts_inc.SelectedIndex = 0;
    }

    protected void btNovo_Click(object sender, EventArgs e)
    {
        dvResultado.Visible = false;
        lbAcao.Text = "Novo";
        rowId.Value = null;
        LimpaTela();
        divCadastro.Visible = true;
        dvFiltro.Visible = false;
        txt_dat_inc.Focus();
    }

    protected void btVoltar_Click(object sender, EventArgs e)
    {
        divCadastro.Visible = false;
        dvResultado.Visible = false;
        dvFiltro.Visible = true;
        txt_dat.Focus();
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_dat.Focus();
    }

    protected string CriaFiltro(DOFF DOFF)
        if (!String.IsNullOrEmpty(txt_mge_001.Text))
        {
            DOFF.DOF_MGE_001 = txt_mge_001.Text;
            filtro = filtro + "Merge= " + txt_mge_001.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))

    protected void btProcurar_Click(object sender, EventArgs e)
        DataSet dsDOFF = DOFF.Consultar();

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
            if (!string.IsNullOrEmpty(Origem.Value))
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvDOFF.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvDOFF.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'DOFF.aspx?rowId=" + gvDOFF.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvDOFF.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvDOFF.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddsDOFFortImage(int columnIndex, GridViewRow headerRow)
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
                AddsDOFFortImage(sortColumnIndex, e.Row);
            }
        }
    }

    protected void gvDOFF_Sorting(Object sender, GridViewSortEventArgs e)
        filtro = CriaFiltro(DOFF);
        DataSet dsDOFF = DOFF.Consultar();

    protected void btSalvar_Click(object sender, EventArgs e)

        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote � obrigat�rio.");
            txt_lot_inc.Focus();
            return;
        }

        if (txt_mge_001_inc.Text == "")
        {
            TratamentoErro("O campo Merge 1 � obrigat�rio.");
            txt_mge_001_inc.Focus();
            return;
        }

        if (txt_rej_inc.Text == "")
        if (hid_epf_id.Value != "")
        {
            DOFF.DOF_EPF_ID = Convert.ToInt32(hid_epf_id.Value);
        }
        OLT OLT = new OLT();
	OLT.OLT_DAT = DOFF.DOF_DAT;
        OLT.OLT_MAQ = DOFF.DOF_MAQ;
        OLT.OLT_LOT = DOFF.DOF_LOT;
/*
	DataSet dsOLT = OLT.Consultar();
        if (dsOLT.Tables[0].Rows.Count == 0)
        {
            TratamentoErro("N�o existe OLT cadastrada para o Lote: " + OLT.OLT_LOT + ", M�quina: " + OLT.OLT_MAQ + " e Data: " + Convert.ToDateTime(OLT.OLT_DAT.ToString()).ToShortDateString() + ". Cadastre primeiro a OLT.");
            txt_tot_inc.Focus();
            return;
        }
*/

            sMsg = DOFF.Alterar();
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }

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
            // Sem a op��o de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;
            //gvDOFF.DataBind();

            // Deixar cabe�alho em branco/preto, sem links e imagens
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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N�o h� registros para exporta��o !');", true);
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
            //Sem a op��o de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;

            // Deixar cabe�alho em branco/preto, sem links e imagens

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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N�o h� registros para exporta��o !');", true);
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void VerificaLote(object sender, EventArgs e)
    {
        if (txt_lot_inc.Text != "")
        {
            Standard Standard = new Standard();
            Standard.EPF_LOT = txt_lot_inc.Text;
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count == 0)
            {
                TratamentoErro("Lote n�o existe");
                hid_epf_id.Value = "";
                txt_lot_inc.Focus();
            }
            else
            {
                hid_epf_id.Value = dsStandard.Tables[0].Rows[0]["EPF_ID"].ToString();
                txt_mge_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
                txt_mge_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_003"].ToString();
                txt_mge_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_004"].ToString();
                txt_mge_001_inc.Focus();
            }

            dsStandard.Dispose();
            Dispose();
        }
    }

}