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

    protected void CarregaControles()	{
        CarregaMotivo();	}

    protected void CarregaDados()	{		if (!string.IsNullOrEmpty(rowId.Value))		{			lbAcao.Text = "Alterar";			divCadastro.Visible = true;			dvFiltro.Visible = false;			txt_dat_inc.Focus();			OLT OLT = new OLT();			OLT.OLT_ID = Convert.ToInt32(rowId.Value);
            DataSet dsOLT = OLT.Consultar();			if (dsOLT.Tables[0].Rows.Count > 0)			{
                hid_epf_id.Value = dsOLT.Tables[0].Rows[0]["OLT_EPF_ID"].ToString();
                cbo_mtv_id_inc.SelectedValue = dsOLT.Tables[0].Rows[0]["OLT_MTV_ID"].ToString();				txt_dat_inc.Text = Convert.ToDateTime(dsOLT.Tables[0].Rows[0]["OLT_DAT"].ToString()).ToString("dd/MM/yyyy");				txt_maq_inc.Text = dsOLT.Tables[0].Rows[0]["OLT_MAQ"].ToString();				txt_pos_inc.Text = dsOLT.Tables[0].Rows[0]["OLT_POS"].ToString();				txt_lot_inc.Text = dsOLT.Tables[0].Rows[0]["OLT_LOT"].ToString();				cbo_sts_inc.SelectedValue = dsOLT.Tables[0].Rows[0]["OLT_STS"].ToString();			}			dsOLT.Dispose();			Dispose();		}		else		{		    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")		    {		        divCadastro.Visible = true;		        dvFiltro.Visible = false;		        dvResultado.Visible = false;		        btVoltar.Enabled = false;				txt_dat_inc.Focus();		    }		    else		    {		        divCadastro.Visible = false;		        dvFiltro.Visible = true;				txt_dat.Focus();		    }		}	}

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

    protected string CriaFiltro(OLT OLT)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_dat.Text))		{			OLT.OLT_DAT = Convert.ToDateTime(txt_dat.Text);			filtro = filtro + "Data= " + txt_dat.Text + "; ";		}
        if (!String.IsNullOrEmpty(cbo_mtv_id.Text))
        {
            OLT.OLT_MTV_ID = Convert.ToInt32(cbo_mtv_id.SelectedValue);
            filtro = filtro + "Motivo= " + cbo_mtv_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_maq.Text))		{			OLT.OLT_MAQ = txt_maq.Text;			filtro = filtro + "Máquina= " + txt_maq.Text + "; ";		}		if (!String.IsNullOrEmpty(txt_lot.Text))		{			OLT.OLT_LOT = txt_lot.Text;			filtro = filtro + "Lote= " + txt_lot.Text + "; ";		}        if (!String.IsNullOrEmpty(cbo_sts.Text))		{
            OLT.OLT_STS = Convert.ToInt32(cbo_sts.SelectedValue);			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";		}		return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";		OLT OLT = new OLT();
        filtro = CriaFiltro(OLT);
        DataSet dsOLT = OLT.Consultar();

        gvOLT.DataSource = dsOLT;
        gvOLT.DataBind();		dsOLT.Dispose();		Dispose();		if (!String.IsNullOrEmpty(filtro))		{			lb_fil.Text = filtro;		}		else		{			lb_fil.Text = "Não há filtros.";		}		dvFiltro.Visible = false;		dvResultado.Visible = true;	}

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

    protected void gvOLT_Sorting(Object sender, GridViewSortEventArgs e)	{		string Ordem = " ASC ";		string sortExpression = e.SortExpression;		ViewState["SortExpression"] = sortExpression;		if (GridViewSortDirection == SortDirection.Ascending)		{			GridViewSortDirection = SortDirection.Descending;			Ordem = " DESC ";		}		else		{			GridViewSortDirection = SortDirection.Ascending;			Ordem = " ASC ";		}		string filtro = "";		OLT OLT = new OLT();		filtro = CriaFiltro(OLT);
        DataSet dsOLT = OLT.Consultar();

        DataTable dtOLT = dsOLT.Tables[0];
        DataView dvOLT = new DataView(dtOLT);
        dvOLT.Sort = e.SortExpression + Ordem;
        gvOLT.DataSource = dvOLT;
        gvOLT.DataBind();

        dvOLT.Dispose();
        dtOLT.Dispose();		dsOLT.Dispose();		Dispose();	}

    protected void btSalvar_Click(object sender, EventArgs e)	{		string sMsg;
        if (txt_dat_inc.Text == "")
        {
            TratamentoErro("O campo Data é obrigatório.");
            txt_dat_inc.Focus();
            return;
        }

        if (cbo_mtv_id_inc.Text == "")		{			TratamentoErro("O campo Motivo é obrigatório.");
            cbo_mtv_id_inc.Focus();			return;		}		if (txt_maq_inc.Text == "")		{			TratamentoErro("O campo Máquina é obrigatório.");			txt_maq_inc.Focus();			return;		}		if (txt_lot_inc.Text == "")		{			TratamentoErro("O campo Lote é obrigatório.");			txt_lot_inc.Focus();			return;		}

        if (txt_pos_inc.Text == "")
        {
            TratamentoErro("O campo Posição é obrigatório.");
            txt_pos_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")		{			TratamentoErro("O campo Status é obrigatório.");			cbo_sts_inc.Focus();			return;		}		OLT OLT = new OLT();
        if (hid_epf_id.Value != "")
        {
            OLT.OLT_EPF_ID = Convert.ToInt32(hid_epf_id.Value);
        }
        if (cbo_mtv_id_inc.Text != "")		{			OLT.OLT_MTV_ID = Convert.ToInt32(cbo_mtv_id_inc.SelectedValue);		}		if (txt_dat_inc.Text != "")		{			OLT.OLT_DAT = Convert.ToDateTime(txt_dat_inc.Text);		}		if (txt_maq_inc.Text != "")		{			OLT.OLT_MAQ = txt_maq_inc.Text;		}		if (txt_pos_inc.Text != "")		{			OLT.OLT_POS = Convert.ToInt32(txt_pos_inc.Text);		}		if (txt_lot_inc.Text != "")		{			OLT.OLT_LOT = txt_lot_inc.Text;		}		if (cbo_sts_inc.Text != "")		{			OLT.OLT_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);		}		if (!string.IsNullOrEmpty(rowId.Value))		{			OLT.OLT_ID = Convert.ToInt32(rowId.Value);			OLT.OLT_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());			sMsg = OLT.Alterar();			if (sMsg != "")			{
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }			else			{				TratamentoErro("OLT alterado com sucesso.");			}

            divCadastro.Visible = false;
            dvFiltro.Visible = true;
        }		else		{            /*			OLT oOLT = new OLT();			//Verificar se já não existe um cadastro consultando o: OLT_DES 			oOLT.OLT_DES = txt_des_inc.Text;			DataSet dsoOLT = oOLT.Consultar();			if (dsoOLT.Tables[0].Rows.Count > 0)			{				TratamentoErro("Esse  já está cadastrado.");				txt_dat_inc.Focus();				return;			}            */			OLT.OLT_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = OLT.Inserir();			if (sMsg.Substring(0, 1) == "E")			{
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }			else			{				rowId.Value = sMsg;				TratamentoErro("OLT inserido com sucesso.");				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);			}			//dsoOLT.Dispose();

            //Após o cadastro incluir limpar Motivo e Posição e permitir incluir outro
            cbo_mtv_id_inc.SelectedIndex = 0;
            txt_pos_inc.Text = "";
            cbo_mtv_id_inc.Focus();
            //divCadastro.Visible = false;
            //dvFiltro.Visible = true;
        }		Dispose();		rowId.Value = null;	}

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
                TratamentoErro("Lote não existe");
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