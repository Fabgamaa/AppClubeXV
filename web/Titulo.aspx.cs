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
        txt_tit.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_fla.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cbo.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_tit_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_fla_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cbo_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
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

            txt_tit_inc.Focus();

            Titulo Titulo = new Titulo();
            Titulo.TIT_POY_ID = Convert.ToInt32(rowId.Value);
            DataSet dsTitulo = Titulo.Consultar();
            if (dsTitulo.Tables[0].Rows.Count > 0)
            {
                txt_des_inc.Text = dsTitulo.Tables[0].Rows[0]["TIT_POY_DES"].ToString();
                cbo_tip_inc.Text = dsTitulo.Tables[0].Rows[0]["TIT_POY_TIP"].ToString();
                txt_tit_inc.Text = dsTitulo.Tables[0].Rows[0]["TIT_POY_TIT"].ToString();
                txt_fla_inc.Text = dsTitulo.Tables[0].Rows[0]["TIT_POY_FLA"].ToString();
                txt_cbo_inc.Text = dsTitulo.Tables[0].Rows[0]["TIT_POY_CBO"].ToString();
                cbo_sts_inc.SelectedValue = dsTitulo.Tables[0].Rows[0]["TIT_POY_STS"].ToString();
            }
            dsTitulo.Dispose();
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

                txt_tit_inc.Focus();
            }
            else
            {
                divCadastro.Visible = false;
                dvFiltro.Visible = true;

                txt_des.Focus();
            }
        }
    }

    private void LimpaTela()
    {
        txt_des.Text = "";
        cbo_tip.SelectedIndex = 0;
        txt_tit.Text = "";
        txt_fla.Text = "";
        txt_cbo.Text = "";
        cbo_sts.Text = "";

        txt_des_inc.Text = "";
        cbo_tip_inc.SelectedIndex = 0;
        txt_tit_inc.Text = "";
        txt_fla_inc.Text = "";
        txt_cbo_inc.Text = "";
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
        txt_tit_inc.Focus();
    }

    protected void btVoltar_Click(object sender, EventArgs e)
    {
        divCadastro.Visible = false;
        dvResultado.Visible = false;
        dvFiltro.Visible = true;
        txt_des.Focus();
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_des.Focus();
    }

    protected string CriaFiltro(Titulo Titulo)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_des.Text))
        {
            Titulo.TIT_POY_DES = txt_des.Text;
            filtro = filtro + "Descricao= " + txt_des.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tip.Text))
        {
            Titulo.TIT_POY_TIP = cbo_tip.SelectedItem.Value;
            filtro = filtro + "Tipo= " + cbo_tip.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_tit.Text))
        {
            Titulo.TIT_POY_TIT = Convert.ToInt32(txt_tit.Text);
            filtro = filtro + "Título= " + txt_tit.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_fla.Text))
        {
            Titulo.TIT_POY_FLA = Convert.ToInt32(txt_fla.Text);
            filtro = filtro + "Filamento= " + txt_fla.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_cbo.Text))
        {
            Titulo.TIT_POY_CBO = Convert.ToInt32(txt_cbo.Text);
            filtro = filtro + "Cabo= " + txt_cbo.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Titulo.TIT_POY_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Titulo Titulo = new Titulo();
        filtro = CriaFiltro(Titulo);
        DataSet dsTitulo = Titulo.Consultar();

        gvTitulo.DataSource = dsTitulo;
        gvTitulo.DataBind();
        dsTitulo.Dispose();
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

    protected void gvTitulo_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvTitulo.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvTitulo.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Titulo.aspx?rowId=" + gvTitulo.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvTitulo.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvTitulo.Columns.IndexOf(field);
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

    protected void gvTitulo_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvTitulo_Sorting(Object sender, GridViewSortEventArgs e)
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

        Titulo Titulo = new Titulo();
        filtro = CriaFiltro(Titulo);
        DataSet dsTitulo = Titulo.Consultar();

        DataTable dtTitulo = dsTitulo.Tables[0];
        DataView dvTitulo = new DataView(dtTitulo);
        dvTitulo.Sort = e.SortExpression + Ordem;
        gvTitulo.DataSource = dvTitulo;
        gvTitulo.DataBind();

        dvTitulo.Dispose();
        dtTitulo.Dispose();
        dsTitulo.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg;
        if (txt_des_inc.Text == "")
        {
            TratamentoErro("O campo Descrição é obrigatório.");
            txt_des_inc.Focus();
            return;
        }

        if (txt_tit_inc.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            txt_tit_inc.Focus();
            return;
        }

        if (Convert.ToInt32(txt_tit_inc.Text) < 1 || Convert.ToInt32(txt_tit_inc.Text) > 8000)
        {
            TratamentoErro("O campo Título deve estar entre 1 e 8000.");
            txt_tit_inc.Focus();
            return;
        }

        if (txt_fla_inc.Text != "")
        {
            if (Convert.ToInt32(txt_fla_inc.Text) < 1)
            {
                TratamentoErro("O campo Filamento deve ser maior que 0.");
                txt_fla_inc.Focus();
                return;
            }
        }

        if (txt_cbo_inc.Text != "")
        {
            if (Convert.ToInt32(txt_cbo_inc.Text) < 1 || Convert.ToInt32(txt_cbo_inc.Text) > 15)
            {
                TratamentoErro("O campo Cabo deve estar entre 1 e 15.");
                txt_cbo_inc.Focus();
                return;
            }
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }

        Titulo Titulo = new Titulo();
        if (txt_des_inc.Text != "")
        {
            Titulo.TIT_POY_DES = txt_des_inc.Text;
        }
        Titulo.TIT_POY_TIP = cbo_tip_inc.Text;
        Titulo.TIT_POY_TIT = Convert.ToInt32(txt_tit_inc.Text);
        if (txt_fla_inc.Text != "")
        {
            Titulo.TIT_POY_FLA = Convert.ToInt32(txt_fla_inc.Text);
        }
        if (txt_cbo_inc.Text != "")
        {
            Titulo.TIT_POY_CBO = Convert.ToInt32(txt_cbo_inc.Text);
        }
        if (cbo_sts_inc.Text != "")
        {
            Titulo.TIT_POY_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        if (!string.IsNullOrEmpty(rowId.Value))
        {
            Titulo.TIT_POY_ID = Convert.ToInt32(rowId.Value);
            Titulo.TIT_POY_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Titulo.Alterar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg);
            }
            else
            {
                TratamentoErro("Título alterado com sucesso.");
            }
        }
        else
        {
            Titulo TIT_POY = new Titulo();
            //Verificar se já não existe um cadastro consultando o: TIT_POY_DES e TIT_POY_TIP
            TIT_POY.TIT_POY_DES = txt_des_inc.Text;
            TIT_POY.TIT_POY_TIP = cbo_tip_inc.Text;
            DataSet dsTIT_POY = TIT_POY.Consultar();
            if (dsTIT_POY.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse Título já está cadastrado.");
                txt_des_inc.Focus();

                return;
            }
            Titulo.TIT_POY_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Titulo.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg);
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("Título inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            dsTIT_POY.Dispose();
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
        if (gvTitulo.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTitulo.AllowSorting = false;
            gvTitulo.AllowPaging = false;
            //gvTitulo.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvTitulo.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTitulo.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTitulo.RenderControl(htmlWrite);

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
        if (gvTitulo.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTitulo.AllowSorting = false;
            gvTitulo.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvTitulo.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTitulo.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTitulo.RenderControl(htmlWrite);

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

    protected void FormataDescricao(object sender, EventArgs e)
    {
        txt_des_inc.Text = txt_tit_inc.Text;

        if (!string.IsNullOrEmpty(txt_fla_inc.Text))
        {
            txt_des_inc.Text += "F" + txt_fla_inc.Text;
        }

        if (!string.IsNullOrEmpty(txt_cbo_inc.Text))
        {
            txt_des_inc.Text += "X" + txt_cbo_inc.Text;
        }

        TextBox tb = (TextBox)sender;
        if (tb.ID == "txt_tit_inc")
        {
            txt_fla_inc.Focus();
        }
        else
        {
            txt_cbo_inc.Focus();
        }

    }
 }