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

    protected void CarregaControles()	{	}

    protected void CarregaDados()	{		if (!string.IsNullOrEmpty(rowId.Value))		{			lbAcao.Text = "Alterar";			divCadastro.Visible = true;			dvFiltro.Visible = false;			txt_dat_inc.Focus();			DOFF DOFF = new DOFF();			DOFF.DOF_ID = Convert.ToInt32(rowId.Value);			DataSet dsDOFF = DOFF.Consultar();			if (dsDOFF.Tables[0].Rows.Count > 0)			{
                hid_epf_id.Value = dsDOFF.Tables[0].Rows[0]["DOF_EPF_ID"].ToString();				txt_dat_inc.Text = Convert.ToDateTime(dsDOFF.Tables[0].Rows[0]["DOF_DAT"].ToString()).ToString("dd/MM/yyyy");				txt_maq_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_MAQ"].ToString();				txt_rej_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_REJ"].ToString();				txt_lim_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_LIM"].ToString();				txt_tot_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_TOT"].ToString();				txt_lot_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_LOT"].ToString();				txt_mge_001_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_MGE_001"].ToString();				txt_mge_002_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_MGE_002"].ToString();				txt_mge_003_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_MGE_003"].ToString();				txt_mge_004_inc.Text = dsDOFF.Tables[0].Rows[0]["DOF_MGE_004"].ToString();				cbo_sts_inc.SelectedValue = dsDOFF.Tables[0].Rows[0]["DOF_STS"].ToString();			}			dsDOFF.Dispose();			Dispose();		}		else		{		    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")		    {		        divCadastro.Visible = true;		        dvFiltro.Visible = false;		        dvResultado.Visible = false;		        btVoltar.Enabled = false;				txt_dat_inc.Focus();		    }		    else		    {		        divCadastro.Visible = false;		        dvFiltro.Visible = true;				txt_dat.Focus();		    }		}	}

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

    protected string CriaFiltro(DOFF DOFF)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_dat.Text))		{			DOFF.DOF_DAT = Convert.ToDateTime(txt_dat.Text);			filtro = filtro + "Data= " + txt_dat.Text + "; ";		}		if (!String.IsNullOrEmpty(txt_maq.Text))		{			DOFF.DOF_MAQ = txt_maq.Text;			filtro = filtro + "Maquina= " + txt_maq.Text + "; ";		}		if (!String.IsNullOrEmpty(txt_lot.Text))		{			DOFF.DOF_LOT = txt_lot.Text;			filtro = filtro + "Lote= " + txt_lot.Text + "; ";		}
        if (!String.IsNullOrEmpty(txt_mge_001.Text))
        {
            DOFF.DOF_MGE_001 = txt_mge_001.Text;
            filtro = filtro + "Merge= " + txt_mge_001.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))		{			DOFF.DOF_STS = Convert.ToInt32(cbo_sts.SelectedValue);			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";		}		return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";        		DOFF DOFF = new DOFF();		filtro = CriaFiltro(DOFF);
        DataSet dsDOFF = DOFF.Consultar();		gvDOFF.DataSource = dsDOFF;		gvDOFF.DataBind();		dsDOFF.Dispose();		Dispose();		if (!String.IsNullOrEmpty(filtro))		{			lb_fil.Text = filtro;		}		else		{			lb_fil.Text = "N?o h? filtros.";		}		dvFiltro.Visible = false;		dvResultado.Visible = true;	}

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

    protected void gvDOFF_Sorting(Object sender, GridViewSortEventArgs e)	{		string Ordem = " ASC ";		string sortExpression = e.SortExpression;		ViewState["SortExpression"] = sortExpression;		if (GridViewSortDirection == SortDirection.Ascending)		{			GridViewSortDirection = SortDirection.Descending;			Ordem = " DESC ";		}		else		{			GridViewSortDirection = SortDirection.Ascending;			Ordem = " ASC ";		}		string filtro = "";		DOFF DOFF = new DOFF();
        filtro = CriaFiltro(DOFF);
        DataSet dsDOFF = DOFF.Consultar();		DataTable dt = dsDOFF.Tables[0];		DataView dv = new DataView(dt);		dv.Sort = e.SortExpression + Ordem;		gvDOFF.DataSource = dv;		gvDOFF.DataBind();		dv.Dispose();		dt.Dispose();		dsDOFF.Dispose();		Dispose();	}

    protected void btSalvar_Click(object sender, EventArgs e)	{		string sMsg;		if (txt_dat_inc.Text == "")		{			TratamentoErro("O campo Data ? obrigat?rio.");			txt_dat_inc.Focus();			return;		}		if (txt_maq_inc.Text == "")		{			TratamentoErro("O campo M?quina ? obrigat?rio.");			txt_maq_inc.Focus();			return;		}

        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote ? obrigat?rio.");
            txt_lot_inc.Focus();
            return;
        }

        if (txt_mge_001_inc.Text == "")
        {
            TratamentoErro("O campo Merge 1 ? obrigat?rio.");
            txt_mge_001_inc.Focus();
            return;
        }

        if (txt_rej_inc.Text == "")		{			TratamentoErro("O campo Fim de Evento ? obrigat?rio.");			txt_rej_inc.Focus();			return;		}		if (txt_lim_inc.Text == "")		{			TratamentoErro("O campo Limite  ? obrigat?rio.");			txt_lim_inc.Focus();			return;		}		if (txt_tot_inc.Text == "")		{			TratamentoErro("O campo Total ? obrigat?rio.");			txt_tot_inc.Focus();			return;		}		if (cbo_sts_inc.Text == "")		{			TratamentoErro("O campo Status ? obrigat?rio.");			cbo_sts_inc.Focus();			return;		}		DOFF DOFF = new DOFF();
        if (hid_epf_id.Value != "")
        {
            DOFF.DOF_EPF_ID = Convert.ToInt32(hid_epf_id.Value);
        }		if (txt_dat_inc.Text != "")		{			DOFF.DOF_DAT = Convert.ToDateTime(txt_dat_inc.Text);		}		if (txt_maq_inc.Text != "")		{			DOFF.DOF_MAQ = txt_maq_inc.Text;		}		if (txt_rej_inc.Text != "")		{			DOFF.DOF_REJ = Convert.ToInt32(txt_rej_inc.Text);		}		if (txt_lim_inc.Text != "")		{			DOFF.DOF_LIM = Convert.ToInt32(txt_lim_inc.Text);		}		if (txt_tot_inc.Text != "")		{			DOFF.DOF_TOT = Convert.ToInt32(txt_tot_inc.Text);		}		if (txt_lot_inc.Text != "")		{			DOFF.DOF_LOT = txt_lot_inc.Text;		}		if (txt_mge_001_inc.Text != "")		{			DOFF.DOF_MGE_001 = txt_mge_001_inc.Text;		}		DOFF.DOF_MGE_002 = txt_mge_002_inc.Text;		DOFF.DOF_MGE_003 = txt_mge_003_inc.Text;		DOFF.DOF_MGE_004 = txt_mge_004_inc.Text;		if (cbo_sts_inc.Text != "")		{			DOFF.DOF_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);		}        //MAP11042013        //Verificar se Existe OLT, sen?o n?o permitir salvar DOFF
        OLT OLT = new OLT();
	OLT.OLT_DAT = DOFF.DOF_DAT;
        OLT.OLT_MAQ = DOFF.DOF_MAQ;
        OLT.OLT_LOT = DOFF.DOF_LOT;        
/*
	DataSet dsOLT = OLT.Consultar();
        if (dsOLT.Tables[0].Rows.Count == 0)
        {
            TratamentoErro("N?o existe OLT cadastrada para o Lote: " + OLT.OLT_LOT + ", M?quina: " + OLT.OLT_MAQ + " e Data: " + Convert.ToDateTime(OLT.OLT_DAT.ToString()).ToShortDateString() + ". Cadastre primeiro a OLT.");
            txt_tot_inc.Focus();
            return;
        }
*/
		if (!string.IsNullOrEmpty(rowId.Value))		{			DOFF.DOF_ID = Convert.ToInt32(rowId.Value);			DOFF.DOF_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = DOFF.Alterar();			if (sMsg != "")			{				Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r","").Replace("\n",""));			}			else			{				TratamentoErro(" DOFF alterado com sucesso.");			}		}		else		{            /*			DOFF oDOFF = new DOFF();			//Verificar se j? n?o existe um cadastro consultando o: DOF_DES 			oDOFF.DOF_DES = txt_des_inc.Text;			DataSet dsoDOFF = oDOFF.Consultar();			if (dsoDOFF.Tables[0].Rows.Count > 0)			{				TratamentoErro("Esse  j? est? cadastrado.");				txt_dat_inc.Focus();				return;			}            */ 			DOFF.DOF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());			sMsg = DOFF.Inserir();			if (sMsg.Substring(0, 1) == "E")			{
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r", "").Replace("\n", ""));
            }			else			{				rowId.Value = sMsg;				TratamentoErro("DOFF inserido com sucesso.");				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);			}			//dsoDOFF.Dispose();		}		Dispose();		divCadastro.Visible = false;		dvFiltro.Visible = true;		rowId.Value = null;	}

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
            // Sem a op??o de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;
            //gvDOFF.DataBind();

            // Deixar cabe?alho em branco/preto, sem links e imagens
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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N?o h? registros para exporta??o !');", true);
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
            //Sem a op??o de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDOFF.AllowSorting = false;
            gvDOFF.AllowPaging = false;

            // Deixar cabe?alho em branco/preto, sem links e imagens

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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N?o h? registros para exporta??o !');", true);
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
                TratamentoErro("Lote n?o existe");
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