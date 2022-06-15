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
        {
            rowId.Value = Request["rowId"].ToString();
        }
        if (Request["Origem"] != null)
        {
            Origem.Value = Request["Origem"].ToString();
        }
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
    }

    protected void CarregaControles()
    {
        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
        dsMaquinaTipo.Dispose();

    }

    protected void CarregaDados()
    {
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            lbAcao.Text = "Alterar";
            divCadastro.Visible = true;
            dvFiltro.Visible = false;

            txt_nom_inc.Focus();

            Operador Operador = new Operador();
            Operador.OPD_ID = Convert.ToInt32(rowId.Value);
            DataSet dsOperador = Operador.Consultar();
            if (dsOperador.Tables[0].Rows.Count > 0)
            {
                cbo_maq_tip_id_inc.SelectedValue = dsOperador.Tables[0].Rows[0]["OPD_MAQ_TIP_ID"].ToString();
                txt_nom_inc.Text = dsOperador.Tables[0].Rows[0]["OPD_NOM"].ToString();
                txt_puo_inc.Text = dsOperador.Tables[0].Rows[0]["OPD_PUO"].ToString();
                ddl_tum_inc.SelectedValue = dsOperador.Tables[0].Rows[0]["OPD_TUM"].ToString();
                ddl_tur_inc.SelectedValue = dsOperador.Tables[0].Rows[0]["OPD_TUR"].ToString();
                cbo_sts_inc.SelectedValue = dsOperador.Tables[0].Rows[0]["OPD_STS"].ToString();
            }
            dsOperador.Dispose();
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

                txt_nom_inc.Focus();
            }
            else
            {
                divCadastro.Visible = false;
                dvFiltro.Visible = true;

                txt_nom.Focus();
            }
        }
    }

    private void LimpaTela()
    {
        cbo_maq_tip_id.Text = "";
        txt_nom.Text = "";
        txt_puo.Text = "";
        ddl_tum.SelectedIndex = 0; ;
        ddl_tur.SelectedIndex = 0;
        cbo_sts.Text = "";

        cbo_maq_tip_id_inc.SelectedIndex = 0;
        txt_nom_inc.Text = "";
        txt_puo_inc.Text = "";
        ddl_tum_inc.SelectedIndex = 0;
        ddl_tur_inc.SelectedIndex = 0;
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
        txt_nom_inc.Focus();
    }

    protected void btVoltar_Click(object sender, EventArgs e)
    {
        divCadastro.Visible = false;
        dvResultado.Visible = false;
        dvFiltro.Visible = true;
        txt_nom.Focus();
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_nom.Focus();
    }

    protected string CriaFiltro(Operador Operador)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Operador.OPD_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Maquina Tipo= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_nom.Text))
        {
            Operador.OPD_NOM = txt_nom.Text;
            filtro = filtro + "Nome= " + txt_nom.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_puo.Text))
        {
            Operador.OPD_PUO = txt_puo.Text;
            filtro = filtro + "Prontuario= " + txt_puo.Text + "; ";
        }
        if (!String.IsNullOrEmpty(ddl_tum.Text))
        {
            Operador.OPD_TUM = ddl_tum.SelectedValue;
            filtro = filtro + "Turma= " + ddl_tum.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(ddl_tur.Text))
        {
            Operador.OPD_TUR = ddl_tur.SelectedValue;
            filtro = filtro + "Turno= " + ddl_tur.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Operador.OPD_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Operador Operador = new Operador();
        filtro = CriaFiltro(Operador);
        DataSet dsOperador = Operador.Consultar();

        gvOperador.DataSource = dsOperador;
        gvOperador.DataBind();
        dsOperador.Dispose();
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

    protected void gvOperador_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvOperador.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvOperador.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Operador.aspx?rowId=" + gvOperador.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvOperador.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvOperador.Columns.IndexOf(field);
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

    protected void gvOperador_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvOperador_Sorting(Object sender, GridViewSortEventArgs e)
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

        Operador Operador = new Operador();
        filtro = CriaFiltro(Operador);
        DataSet dsOperador = Operador.Consultar();

        DataTable dtOperador = dsOperador.Tables[0];
        DataView dvOperador = new DataView(dtOperador);
        dvOperador.Sort = e.SortExpression + Ordem;
        gvOperador.DataSource = dvOperador;
        gvOperador.DataBind();

        dvOperador.Dispose();
        dtOperador.Dispose();
        dsOperador.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg;
        if (txt_nom_inc.Text == "")
        {
            TratamentoErro("O campo Nome é obrigatório.");
            txt_nom_inc.Focus();
            return;
        }

        if (txt_puo_inc.Text == "")
        {
            TratamentoErro("O campo Prontuario é obrigatório.");
            txt_puo_inc.Focus();
            return;
        }

        if (cbo_maq_tip_id_inc.Text == "")
        {
            TratamentoErro("O campo Maquina Tipo é obrigatório.");
            cbo_maq_tip_id_inc.Focus();
            return;
        }

        if (ddl_tum_inc.Text == "")
        {
            TratamentoErro("O campo Turma é obrigatório.");
            ddl_tum_inc.Focus();
            return;
        }

        if (ddl_tur_inc.Text == "")
        {
            TratamentoErro("O campo Turno é obrigatório.");
            ddl_tur_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }

        Operador Operador = new Operador();
        if (cbo_maq_tip_id_inc.Text != "")
        {
            Operador.OPD_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
        }
        if (txt_nom_inc.Text != "")
        {
            Operador.OPD_NOM = txt_nom_inc.Text;
        }
        if (txt_puo_inc.Text != "")
        {
            Operador.OPD_PUO = txt_puo_inc.Text;
        }
        if (ddl_tum_inc.Text != "")
        {
            Operador.OPD_TUM = ddl_tum_inc.SelectedValue;
        }
        if (ddl_tur_inc.Text != "")
        {
            Operador.OPD_TUR = ddl_tur_inc.SelectedValue;
        }
        if (cbo_sts_inc.Text != "")
        {
            Operador.OPD_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        if (!string.IsNullOrEmpty(rowId.Value))
        {
            Operador.OPD_ID = Convert.ToInt32(rowId.Value);
            Operador.OPD_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Operador.Alterar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg);
            }
            else
            {
                TratamentoErro("Operador alterado com sucesso.");
            }
        }
        else
        {
            Operador OPD = new Operador();
            //Verificar se já não existe um cadastro consultando o: OPD_NOM 
            OPD.OPD_NOM = txt_nom_inc.Text;
            DataSet dsOPD = OPD.Consultar();
            if (dsOPD.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse Operador já está cadastrado.");
                txt_nom_inc.Focus();

                return;
            }
            Operador.OPD_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Operador.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg);
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("Operador inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            dsOPD.Dispose();
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
        if (gvOperador.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Operador.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOperador.AllowSorting = false;
            gvOperador.AllowPaging = false;
            //gvOperador.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvOperador.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvOperador.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvOperador.RenderControl(htmlWrite);

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
        if (gvOperador.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Operador.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvOperador.AllowSorting = false;
            gvOperador.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvOperador.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvOperador.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvOperador.RenderControl(htmlWrite);

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

