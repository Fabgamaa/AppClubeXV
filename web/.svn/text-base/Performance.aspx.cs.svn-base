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
    private double dPFM_QLD_001 = 0;
    private double dPFM_OUT = 0;
    private double dPFM_QLD_002 = 0;
    private double dPFM_QBR = 0;
    private double dPFM_AFN = 0;
    private double dPFM_UNT = 0;
    private double dPFM_PRC = 0;

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
        txt_dat.Attributes.Add("onBlur", "javascript:f_valida_data_pequena(this);");
        txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data_pequena(this);");
        txt_vlc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_qld_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qld_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_out_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_out_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qld_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qld_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_afn_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_afn_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_unt_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_unt_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_prc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_prc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
    }

    protected void CarregaControles()
    {
    }

    protected void CarregaDados()
    {
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            lbAcao.Text = "Alterar";
            divCadastro.Visible = true;
            dvFiltro.Visible = false;

            txt_dat_inc.Focus();

            Performance Performance = new Performance();
            Performance.PFM_ID = Convert.ToInt32(rowId.Value);
            DataSet dsPerformance = Performance.Consultar();
            if (dsPerformance.Tables[0].Rows.Count > 0)
            {
                txt_dat_inc.Text = Convert.ToDateTime(dsPerformance.Tables[0].Rows[0]["PFM_DAT"].ToString()).ToString("MM/yyyy");
                txt_lot_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_LOT"].ToString();
                txt_mge_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_MGE"].ToString();
                txt_vlc_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_VLC"].ToString();
                txt_tit_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_TIT"].ToString();
                txt_qld_001_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_QLD_001"].ToString();
                txt_out_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_OUT"].ToString();
                txt_qld_002_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_QLD_002"].ToString();
                txt_qbr_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_QBR"].ToString();
                txt_afn_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_AFN"].ToString();
                txt_unt_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_UNT"].ToString();
                txt_prc_inc.Text = dsPerformance.Tables[0].Rows[0]["PFM_PRC"].ToString();
                cbo_sts_inc.SelectedValue = dsPerformance.Tables[0].Rows[0]["PFM_STS"].ToString();
            }
            dsPerformance.Dispose();
            Dispose();
        }
        else
        {
            if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
            {
                divCadastro.Visible = true;
                dvFiltro.Visible = false;
                dvResultado.Visible = false;
                btVoltar.Enabled = false;

                txt_dat_inc.Focus();
            }
            else
            {
                divCadastro.Visible = false;
                dvFiltro.Visible = true;

                txt_dat.Focus();
            }
        }
    }

    private void LimpaTela()
    {
        txt_dat.Text = "";
        txt_lot.Text = "";
        txt_mge.Text = "";
        txt_tit.Text = "";
        cbo_sts.Text = "";

        txt_dat_inc.Text = "";
        txt_lot_inc.Text = "";
        txt_mge_inc.Text = "";
        txt_vlc_inc.Text = "";
        txt_tit_inc.Text = "";
        txt_qld_001_inc.Text = "";
        txt_out_inc.Text = "";
        txt_qld_002_inc.Text = "";
        txt_qbr_inc.Text = "";
        txt_afn_inc.Text = "";
        txt_unt_inc.Text = "";
        txt_prc_inc.Text = "";
        cbo_sts_inc.SelectedIndex = 0;
    }

    protected void btNovoFiltro_Click(object sender, EventArgs e)
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

    protected string CriaFiltro(Performance Performance)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat.Text))
        {
            Performance.PFM_DAT = Convert.ToDateTime(txt_dat.Text);
            filtro = filtro + "Data= " + txt_dat.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Performance.PFM_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Performance.PFM_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_tit.Text))
        {
            Performance.PFM_TIT = txt_tit.Text;
            filtro = filtro + "Titulo= " + txt_tit.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Performance.PFM_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Performance Performance = new Performance();
        filtro = CriaFiltro(Performance);
        DataSet dsPerformance = Performance.Consultar();

        gvPerformance.DataSource = dsPerformance;
        gvPerformance.DataBind();
        dsPerformance.Dispose();
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

    protected void gvPerformance_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvPerformance.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvPerformance.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Performance.aspx?rowId=" + gvPerformance.DataKeys[e.Row.RowIndex][0].ToString() + "'");

            dPFM_QLD_001 = (dPFM_QLD_001 + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_QLD_001").ToString())) / 2;
            dPFM_OUT = (dPFM_OUT + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_OUT").ToString())) / 2;
            dPFM_QLD_002 = (dPFM_QLD_002 + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_QLD_002").ToString())) / 2;
            dPFM_QBR = (dPFM_QBR + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_QBR").ToString())) / 2;
            dPFM_AFN = (dPFM_AFN + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_AFN").ToString())) / 2;
            dPFM_UNT =(dPFM_UNT + Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_UNT").ToString())) / 2;
            dPFM_PRC =+ Convert.ToDouble(DataBinder.Eval(e.Row.DataItem, "PFM_PRC").ToString());
        }
        else if (e.Row.RowType == DataControlRowType.Footer)
        {
            tb_resumo.Visible = true;
            lbPFM_QLD_001.Text = dPFM_QLD_001.ToString("#0.00");
            lbPFM_OUT.Text = dPFM_OUT.ToString("#0.00");
            lbPFM_QLD_002.Text = dPFM_QLD_002.ToString("#0.00");
            lbPFM_QBR.Text = dPFM_QBR.ToString("#0.00");
            lbPFM_AFN.Text = dPFM_AFN.ToString("#0.00");
            lbPFM_UNT.Text = dPFM_UNT.ToString("#0.00");
            lbPFM_PRC.Text = dPFM_PRC.ToString("#0.00");
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
        foreach (DataControlField field in gvPerformance.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvPerformance.Columns.IndexOf(field);
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

    protected void gvPerformance_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvPerformance_Sorting(Object sender, GridViewSortEventArgs e)
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

        Performance Performance = new Performance();
        filtro = CriaFiltro(Performance);
        DataSet dsPerformance = Performance.Consultar();

        DataTable dtPerformance = dsPerformance.Tables[0];
        DataView dvPerformance = new DataView(dtPerformance);
        dvPerformance.Sort = e.SortExpression + Ordem;
        gvPerformance.DataSource = dvPerformance;
        gvPerformance.DataBind();

        dvPerformance.Dispose();
        dtPerformance.Dispose();
        dsPerformance.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg;
        if (txt_dat_inc.Text == "")
        {
            TratamentoErro("O campo Data é obrigatório.");
            txt_dat_inc.Focus();
            return;
        }

        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote é obrigatório.");
            txt_lot_inc.Focus();
            return;
        }

        if (txt_mge_inc.Text == "")
        {
            TratamentoErro("O campo Merge é obrigatório.");
            txt_mge_inc.Focus();
            return;
        }

        if (txt_vlc_inc.Text == "")
        {
            TratamentoErro("O campo Velocidade é obrigatório.");
            txt_vlc_inc.Focus();
            return;
        }

        if (txt_tit_inc.Text == "")
        {
            TratamentoErro("O campo Titulo é obrigatório.");
            txt_tit_inc.Focus();
            return;
        }

        if (txt_qld_001_inc.Text == "")
        {
            TratamentoErro("O campo Qualidade é obrigatório.");
            txt_qld_001_inc.Focus();
            return;
        }

        if (txt_out_inc.Text == "")
        {
            TratamentoErro("O campo Outra é obrigatório.");
            txt_out_inc.Focus();
            return;
        }

        if (txt_qld_002_inc.Text == "")
        {
            TratamentoErro("O campo Qualidade é obrigatório.");
            txt_qld_002_inc.Focus();
            return;
        }

        if (txt_qbr_inc.Text == "")
        {
            TratamentoErro("O campo Quebra é obrigatório.");
            txt_qbr_inc.Focus();
            return;
        }

        if (txt_afn_inc.Text == "")
        {
            TratamentoErro("O campo Afinidade é obrigatório.");
            txt_afn_inc.Focus();
            return;
        }

        if (txt_unt_inc.Text == "")
        {
            TratamentoErro("O campo Unitario é obrigatório.");
            txt_unt_inc.Focus();
            return;
        }

        if (txt_prc_inc.Text == "")
        {
            TratamentoErro("O campo Produção é obrigatório.");
            txt_prc_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }

        Performance Performance = new Performance();
        if (txt_dat_inc.Text != "")
        {
            Performance.PFM_DAT = Convert.ToDateTime(txt_dat_inc.Text);
        }
        if (txt_lot_inc.Text != "")
        {
            Performance.PFM_LOT = txt_lot_inc.Text;
        }
        if (txt_mge_inc.Text != "")
        {
            Performance.PFM_MGE = txt_mge_inc.Text;
        }
        if (txt_vlc_inc.Text != "")
        {
            Performance.PFM_VLC = Convert.ToInt32(txt_vlc_inc.Text);
        }
        if (txt_tit_inc.Text != "")
        {
            Performance.PFM_TIT = txt_tit_inc.Text;
        }
        if (txt_qld_001_inc.Text != "")
        {
            Performance.PFM_QLD_001 = Convert.ToDouble(txt_qld_001_inc.Text);
        }
        if (txt_out_inc.Text != "")
        {
            Performance.PFM_OUT = Convert.ToDouble(txt_out_inc.Text);
        }
        if (txt_qld_002_inc.Text != "")
        {
            Performance.PFM_QLD_002 = Convert.ToDouble(txt_qld_002_inc.Text);
        }
        if (txt_qbr_inc.Text != "")
        {
            Performance.PFM_QBR = Convert.ToDouble(txt_qbr_inc.Text);
        }
        if (txt_afn_inc.Text != "")
        {
            Performance.PFM_AFN = Convert.ToDouble(txt_afn_inc.Text);
        }
        if (txt_unt_inc.Text != "")
        {
            Performance.PFM_UNT = Convert.ToDouble(txt_unt_inc.Text);
        }
        if (txt_prc_inc.Text != "")
        {
            Performance.PFM_PRC = Convert.ToDouble(txt_prc_inc.Text);
        }
        if (cbo_sts_inc.Text != "")
        {
            Performance.PFM_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        if (!string.IsNullOrEmpty(rowId.Value))
        {
            Performance.PFM_ID = Convert.ToInt32(rowId.Value);
            Performance.PFM_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Performance.Alterar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                TratamentoErro("Performance alterado com sucesso.");
            }
        }
        else
        {
            Performance PFM = new Performance();
            //Verificar se já não existe um cadastro consultando o: PFM_DAT 
            PFM.PFM_DAT = Convert.ToDateTime("01/" + txt_dat_inc.Text);
            DataSet dsPFM = PFM.Consultar();
            if (dsPFM.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Essa Performance já está cadastrado.");
                txt_dat_inc.Focus();
                return;
            }
            Performance.PFM_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Performance.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("Performance inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            dsPFM.Dispose();
        }
        Dispose();
        divCadastro.Visible = false;
        dvFiltro.Visible = true;

        rowId.Value = null;
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvPerformance.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvPerformance.AllowSorting = false;
            gvPerformance.AllowPaging = false;
            //gvPerformance.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvPerformance.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvPerformance.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvPerformance.RenderControl(htmlWrite);

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
        if (gvPerformance.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvPerformance.AllowSorting = false;
            gvPerformance.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvPerformance.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvPerformance.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvPerformance.RenderControl(htmlWrite);

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