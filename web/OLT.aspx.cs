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
        txt_pos_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
    }

    protected void CarregaControles()
        CarregaMotivo();

    protected void CarregaDados()
            DataSet dsOLT = OLT.Consultar();
                hid_epf_id.Value = dsOLT.Tables[0].Rows[0]["OLT_EPF_ID"].ToString();
                cbo_mtv_id_inc.SelectedValue = dsOLT.Tables[0].Rows[0]["OLT_MTV_ID"].ToString();

    private void LimpaTela()
    {
        hid_epf_id.Value = "";
        cbo_mtv_id.Text = "";
        txt_dat.Text = "";
        txt_maq.Text = "";
        txt_lot.Text = "";
        cbo_sts.Text = "";

        cbo_mtv_id_inc.SelectedIndex = 0;
        txt_dat_inc.Text = "";
        txt_maq_inc.Text = "";
        txt_pos_inc.Text = "";
        txt_lot_inc.Text = "";
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

    protected string CriaFiltro(OLT OLT)
        if (!String.IsNullOrEmpty(cbo_mtv_id.Text))
        {
            OLT.OLT_MTV_ID = Convert.ToInt32(cbo_mtv_id.SelectedValue);
            filtro = filtro + "Motivo= " + cbo_mtv_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_maq.Text))
            OLT.OLT_STS = Convert.ToInt32(cbo_sts.SelectedValue);

    protected void btProcurar_Click(object sender, EventArgs e)
        filtro = CriaFiltro(OLT);
        DataSet dsOLT = OLT.Consultar();

        gvOLT.DataSource = dsOLT;
        gvOLT.DataBind();

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
            if (!string.IsNullOrEmpty(Origem.Value))
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvOLT.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvOLT.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'OLT.aspx?rowId=" + gvOLT.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        DataSet dsOLT = OLT.Consultar();

        DataTable dtOLT = dsOLT.Tables[0];
        DataView dvOLT = new DataView(dtOLT);
        dvOLT.Sort = e.SortExpression + Ordem;
        gvOLT.DataSource = dvOLT;
        gvOLT.DataBind();

        dvOLT.Dispose();
        dtOLT.Dispose();

    protected void btSalvar_Click(object sender, EventArgs e)
        if (txt_dat_inc.Text == "")
        {
            TratamentoErro("O campo Data � obrigat�rio.");
            txt_dat_inc.Focus();
            return;
        }

        if (cbo_mtv_id_inc.Text == "")
            cbo_mtv_id_inc.Focus();

        if (txt_pos_inc.Text == "")
        {
            TratamentoErro("O campo Posi��o � obrigat�rio.");
            txt_pos_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")
        if (hid_epf_id.Value != "")
        {
            OLT.OLT_EPF_ID = Convert.ToInt32(hid_epf_id.Value);
        }
        if (cbo_mtv_id_inc.Text != "")
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }

            divCadastro.Visible = false;
            dvFiltro.Visible = true;
        }
            sMsg = OLT.Inserir();
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }

            //Ap�s o cadastro incluir limpar Motivo e Posi��o e permitir incluir outro
            cbo_mtv_id_inc.SelectedIndex = 0;
            txt_pos_inc.Text = "";
            cbo_mtv_id_inc.Focus();
            //divCadastro.Visible = false;
            //dvFiltro.Visible = true;
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
            // Sem a op��o de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOLT.AllowSorting = false;
            gvOLT.AllowPaging = false;
            //gvOLT.DataBind();

            // Deixar cabe�alho em branco/preto, sem links e imagens
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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N�o h� registros para exporta��o !');", true);
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
            //Sem a op��o de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOLT.AllowSorting = false;
            gvOLT.AllowPaging = false;

            // Deixar cabe�alho em branco/preto, sem links e imagens

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
                txt_pos_inc.Focus();
            }

            dsStandard.Dispose();
            Dispose();
        }
    }

    public void CarregaMotivo()
    {
        cbo_mtv_id.Items.Clear();
        cbo_mtv_id.Items.Add(new System.Web.UI.WebControls.ListItem("", ""));

        cbo_mtv_id_inc.Items.Clear();
        cbo_mtv_id_inc.Items.Add(new System.Web.UI.WebControls.ListItem("", ""));
        
        Motivo Motivo = new Motivo();
        DataSet dsMotivo = Motivo.Consultar();
        foreach (DataRow drMotivo in dsMotivo.Tables[0].Rows)
        {
            cbo_mtv_id.Items.Add(new System.Web.UI.WebControls.ListItem(drMotivo["MTV_ID"].ToString() + " - " + drMotivo["MTV_DES"].ToString(), drMotivo["MTV_ID"].ToString()));
            cbo_mtv_id_inc.Items.Add(new System.Web.UI.WebControls.ListItem(drMotivo["MTV_ID"].ToString() + " - " + drMotivo["MTV_DES"].ToString(), drMotivo["MTV_ID"].ToString()));
        }
        dsMotivo.Dispose();


    }

}