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
		txt_tit_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_eve_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_eve_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_qbr_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_qbr_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_foa_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_foa_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_cvf_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_cvf_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_eve_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_eve_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_qbr_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_qbr_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_foa_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_foa_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_cvf_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_cvf_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
	}

	protected void CarregaControles()
	{
        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "P"; //Somente POYs
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_inc);
        dsFornecedor.Dispose();

        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "P"; //Somente POYs
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
        dsTitulo.Dispose();
    }

	protected void CarregaDados()
	{
		if (!string.IsNullOrEmpty(rowId.Value))
		{
			lbAcao.Text = "Alterar";
			divCadastro.Visible = true;
			dvFiltro.Visible = false;

			txt_dat_inc.Focus();

			EspecificacaoDynafil EspecificacaoDynafil = new EspecificacaoDynafil();
			EspecificacaoDynafil.EDF_ID = Convert.ToInt32(rowId.Value);
			DataSet dsEspecificacaoDynafil = EspecificacaoDynafil.Consultar();
			if (dsEspecificacaoDynafil.Tables[0].Rows.Count > 0)
			{
				txt_dat_inc.Text = Convert.ToDateTime(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_DAT"].ToString()).ToString("dd/MM/yyyy");
                txt_mge_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_MGE"].ToString();				cbo_for_id_inc.SelectedValue = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOR_ID"].ToString();                cbo_tit_poy_id_inc.SelectedValue = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_POY_ID"].ToString();
				txt_vlc_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_VLC"].ToString();
				txt_tit_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MED"].ToString();
				txt_tnc_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MED"].ToString();
				txt_aon_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MED"].ToString();
				txt_eve_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MED"].ToString();
				txt_qbr_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MED"].ToString();
				txt_foa_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MED"].ToString();
				txt_cvf_med_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MED"].ToString();
                txt_tit_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_TLR"].ToString();
                txt_tnc_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_TLR"].ToString();
                txt_aon_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_TLR"].ToString();
                txt_eve_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_TLR"].ToString();
                txt_qbr_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_TLR"].ToString();
                txt_foa_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_TLR"].ToString();
                txt_cvf_tlr_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_TLR"].ToString();
                txt_tit_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MIN"].ToString();
                txt_tnc_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MIN"].ToString();
                txt_aon_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MIN"].ToString();
                txt_eve_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MIN"].ToString();
                txt_qbr_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MIN"].ToString();
                txt_foa_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MIN"].ToString();
                txt_cvf_min_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MIN"].ToString();
                txt_tit_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MAX"].ToString();
				txt_tnc_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MAX"].ToString();
				txt_aon_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MAX"].ToString();
				txt_eve_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MAX"].ToString();
				txt_qbr_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MAX"].ToString();
				txt_foa_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MAX"].ToString();
				txt_cvf_max_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MAX"].ToString();
				txt_obs_inc.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_OBS"].ToString();
				cbo_sts_inc.SelectedValue = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_STS"].ToString();
			}
			dsEspecificacaoDynafil.Dispose();
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
        txt_mge.Text = "";
        cbo_for_id.Text = "";
        cbo_tit_poy_id.Text = "";
        txt_vlc.Text = "";
        txt_dat.Text = "";
        cbo_sts.Text = "";
        txt_mge_inc.Text = "";
        cbo_for_id_inc.SelectedIndex = 0;
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        txt_vlc_inc.Text = "";
        txt_dat_inc.Text = "";
        
        txt_tit_med_inc.Text = "";
		txt_tnc_med_inc.Text = "";
		txt_aon_med_inc.Text = "";
		txt_eve_med_inc.Text = "";
		txt_qbr_med_inc.Text = "";
		txt_foa_med_inc.Text = "";
		txt_cvf_med_inc.Text = "";
        txt_tit_tlr_inc.Text = "";
        txt_tnc_tlr_inc.Text = "";
        txt_aon_tlr_inc.Text = "";
        txt_eve_tlr_inc.Text = "";
        txt_qbr_tlr_inc.Text = "";
        txt_foa_tlr_inc.Text = "";
        txt_cvf_tlr_inc.Text = "";
        txt_tit_min_inc.Text = "";
        txt_tnc_min_inc.Text = "";
        txt_aon_min_inc.Text = "";
        txt_eve_min_inc.Text = "";
        txt_qbr_min_inc.Text = "";
        txt_foa_min_inc.Text = "";
        txt_cvf_min_inc.Text = "";
        txt_tit_max_inc.Text = "";
		txt_tnc_max_inc.Text = "";
		txt_aon_max_inc.Text = "";
		txt_eve_max_inc.Text = "";
		txt_qbr_max_inc.Text = "";
		txt_foa_max_inc.Text = "";
		txt_cvf_max_inc.Text = "";
		txt_obs_inc.Text = "";
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

	protected string CriaFiltro(EspecificacaoDynafil EspecificacaoDynafil)
	{
		string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat.Text))
        {
            EspecificacaoDynafil.EDF_DAT = Convert.ToDateTime(txt_dat.Text);
            filtro = filtro + "Data= " + txt_dat.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            EspecificacaoDynafil.EDF_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id.Text))
        {
            EspecificacaoDynafil.EDF_FOR_ID = Convert.ToInt32(cbo_for_id.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            EspecificacaoDynafil.EDF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Titulo= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vlc.Text))
        {
            EspecificacaoDynafil.EDF_VLC = txt_vlc.Text;
            filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            EspecificacaoDynafil.EDF_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
	}

	protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		EspecificacaoDynafil EspecificacaoDynafil = new EspecificacaoDynafil();
		filtro = CriaFiltro(EspecificacaoDynafil);
		DataSet dsEspecificacaoDynafil = EspecificacaoDynafil.Consultar();

		gvEspecificacaoDynafil.DataSource = dsEspecificacaoDynafil;
		gvEspecificacaoDynafil.DataBind();
		dsEspecificacaoDynafil.Dispose();
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

	protected void gvEspecificacaoDynafil_RowDataBound(object sender, GridViewRowEventArgs e)
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
				e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvEspecificacaoDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvEspecificacaoDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "');");
			else
				e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'EspecificacaoDynafil.aspx?rowId=" + gvEspecificacaoDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
		foreach (DataControlField field in gvEspecificacaoDynafil.Columns)
		{
			if (field.SortExpression == (string)ViewState["SortExpression"])
			{
				return gvEspecificacaoDynafil.Columns.IndexOf(field);
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

	protected void gvEspecificacaoDynafil_RowCreated(object sender, GridViewRowEventArgs e)
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

	protected void gvEspecificacaoDynafil_Sorting(Object sender, GridViewSortEventArgs e)
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

		EspecificacaoDynafil EspecificacaoDynafil = new EspecificacaoDynafil();
		filtro = CriaFiltro(EspecificacaoDynafil);
		DataSet dsEspecificacaoDynafil = EspecificacaoDynafil.Consultar();

		DataTable dtEspecificacaoDynafil = dsEspecificacaoDynafil.Tables[0];
		DataView dvEspecificacaoDynafil = new DataView(dtEspecificacaoDynafil);
		dvEspecificacaoDynafil.Sort = e.SortExpression + Ordem;
		gvEspecificacaoDynafil.DataSource = dvEspecificacaoDynafil;
		gvEspecificacaoDynafil.DataBind();

		dvEspecificacaoDynafil.Dispose();
		dtEspecificacaoDynafil.Dispose();
		dsEspecificacaoDynafil.Dispose();
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

        if (txt_mge_inc.Text == "")
        {
            TratamentoErro("O campo Merge é obrigatório.");
            txt_mge_inc.Focus();
            return;
        }

        if (cbo_for_id_inc.Text == "")
        {
            TratamentoErro("O campo Fornecedor é obrigatório.");
            cbo_for_id_inc.Focus();
            return;
        }

        if (cbo_tit_poy_id_inc.Text == "")
        {
            TratamentoErro("O campo Titulo é obrigatório.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }
                
        /*
        if (txt_tit_med_inc.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            txt_tit_med_inc.Focus();
            return;
        }

        if (txt_tit_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            txt_tit_tlr_inc.Focus();
            return;
        }
        */

        if (txt_tit_min_inc.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            txt_tit_min_inc.Focus();
            return;
        }

        if (txt_tit_max_inc.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            txt_tit_max_inc.Focus();
            return;
        }

        /*
        if (txt_tnc_med_inc.Text == "")
        {
            TratamentoErro("O campo Tenacidade é obrigatório.");
            txt_tnc_med_inc.Focus();
            return;
        }

        if (txt_tnc_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Tenacidade é obrigatório.");
            txt_tnc_tlr_inc.Focus();
            return;
        }
        */

        if (txt_tnc_min_inc.Text == "")
        {
            TratamentoErro("O campo Tenacidade é obrigatório.");
            txt_tnc_min_inc.Focus();
            return;
        }

        if (txt_tnc_max_inc.Text == "")
        {
            TratamentoErro("O campo Tenacidade é obrigatório.");
            txt_tnc_max_inc.Focus();
            return;
        }

        /*
        if (txt_aon_med_inc.Text == "")
        {
            TratamentoErro("O campo Alongamento é obrigatório.");
            txt_aon_med_inc.Focus();
            return;
        }

        if (txt_aon_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Alongamento é obrigatório.");
            txt_aon_tlr_inc.Focus();
            return;
        }
        */

        if (txt_aon_min_inc.Text == "")
        {
            TratamentoErro("O campo Alongamento é obrigatório.");
            txt_aon_min_inc.Focus();
            return;
        }

        if (txt_aon_max_inc.Text == "")
        {
            TratamentoErro("O campo Alongamento é obrigatório.");
            txt_aon_max_inc.Focus();
            return;
        }

        /*
        if (txt_eve_med_inc.Text == "")
        {
            TratamentoErro("O campo CV - Eveness é obrigatório.");
            txt_eve_med_inc.Focus();
            return;
        }

        if (txt_eve_tlr_inc.Text == "")
        {
            TratamentoErro("O campo CV - Eveness é obrigatório.");
            txt_eve_tlr_inc.Focus();
            return;
        }

        if (txt_eve_min_inc.Text == "")
        {
            TratamentoErro("O campo CV - Eveness é obrigatório.");
            txt_eve_min_inc.Focus();
            return;
        }

        if (txt_eve_max_inc.Text == "")
        {
            TratamentoErro("O campo CV - Eveness é obrigatório.");
            txt_eve_max_inc.Focus();
            return;
        }
        */

        if (cbo_sts_inc.Text == "")
		{
			TratamentoErro("O campo Status é obrigatório.");
			cbo_sts_inc.Focus();
			return;
		}

        EspecificacaoDynafil EspecificacaoDynafil = new EspecificacaoDynafil();
		if (txt_dat_inc.Text != "")
		{
			EspecificacaoDynafil.EDF_DAT = Convert.ToDateTime(txt_dat_inc.Text);
		}
        if (txt_mge_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_MGE = txt_mge_inc.Text;
        }
        EspecificacaoDynafil.EDF_FOR_ID = Convert.ToInt32(cbo_for_id_inc.SelectedValue);
        if (cbo_tit_poy_id_inc.Text != "")
		{
			EspecificacaoDynafil.EDF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
		}
        EspecificacaoDynafil.EDF_VLC = txt_vlc_inc.Text;


        if (txt_tit_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_TIT_MED = Convert.ToDouble(txt_tit_med_inc.Text);
		}
        if (txt_tnc_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_TNC_MED = Convert.ToDouble(txt_tnc_med_inc.Text);
		}
        if (txt_aon_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_AON_MED = Convert.ToDouble(txt_aon_med_inc.Text);
		}
        if (txt_eve_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_EVE_MED = Convert.ToDouble(txt_eve_med_inc.Text);
		}
        if (txt_qbr_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_QBR_MED = Convert.ToDouble(txt_qbr_med_inc.Text);
		}
        if (txt_foa_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_FOA_MED = Convert.ToDouble(txt_foa_med_inc.Text);
		}
        if (txt_cvf_med_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_CVF_MED = Convert.ToDouble(txt_cvf_med_inc.Text);
		}

        if (txt_tit_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_TIT_TLR = Convert.ToDouble(txt_tit_tlr_inc.Text);
        }
        if (txt_tnc_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_TNC_TLR = Convert.ToDouble(txt_tnc_tlr_inc.Text);
        }
        if (txt_aon_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_AON_TLR = Convert.ToDouble(txt_aon_tlr_inc.Text);
        }
        if (txt_eve_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_EVE_TLR = Convert.ToDouble(txt_eve_tlr_inc.Text);
        }
        if (txt_qbr_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_QBR_TLR = Convert.ToDouble(txt_qbr_tlr_inc.Text);
        }
        if (txt_foa_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_FOA_TLR = Convert.ToDouble(txt_foa_tlr_inc.Text);
        }
        if (txt_cvf_tlr_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_CVF_TLR = Convert.ToDouble(txt_cvf_tlr_inc.Text);
        }

        if (txt_tit_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_TIT_MIN = Convert.ToDouble(txt_tit_min_inc.Text);
        }
        if (txt_tnc_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_TNC_MIN = Convert.ToDouble(txt_tnc_min_inc.Text);
        }
        if (txt_aon_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_AON_MIN = Convert.ToDouble(txt_aon_min_inc.Text);
        }
        if (txt_eve_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_EVE_MIN = Convert.ToDouble(txt_eve_min_inc.Text);
        }
        if (txt_qbr_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_QBR_MIN = Convert.ToDouble(txt_qbr_min_inc.Text);
        }
        if (txt_foa_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_FOA_MIN = Convert.ToDouble(txt_foa_min_inc.Text);
        }
        if (txt_cvf_min_inc.Text != "")
        {
            EspecificacaoDynafil.EDF_CVF_MIN = Convert.ToDouble(txt_cvf_min_inc.Text);
        }

        if (txt_tit_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_TIT_MAX = Convert.ToDouble(txt_tit_max_inc.Text);
		}
        if (txt_tnc_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_TNC_MAX = Convert.ToDouble(txt_tnc_max_inc.Text);
		}
        if (txt_aon_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_AON_MAX = Convert.ToDouble(txt_aon_max_inc.Text);
		}
        if (txt_eve_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_EVE_MAX = Convert.ToDouble(txt_eve_max_inc.Text);
		}
        if (txt_qbr_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_QBR_MAX = Convert.ToDouble(txt_qbr_max_inc.Text);
		}
        if (txt_foa_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_FOA_MAX = Convert.ToDouble(txt_foa_max_inc.Text);
		}
        if (txt_cvf_max_inc.Text != "")
		{
		    EspecificacaoDynafil.EDF_CVF_MAX = Convert.ToDouble(txt_cvf_max_inc.Text);
		}

        EspecificacaoDynafil.EDF_OBS = txt_obs_inc.Text;
		if (cbo_sts_inc.Text != "")
		{
			EspecificacaoDynafil.EDF_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
		}

        if (!string.IsNullOrEmpty(rowId.Value))
		{
			EspecificacaoDynafil.EDF_ID = Convert.ToInt32(rowId.Value);
			EspecificacaoDynafil.EDF_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = EspecificacaoDynafil.Alterar();
			if (sMsg != "")
			{
				Response.Redirect("Erro.aspx?Erro="+sMsg);
			}
			else
			{
				TratamentoErro("Especificação Dynafil alterada com sucesso.");
			}
		}
		else
		{
			EspecificacaoDynafil.EDF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = EspecificacaoDynafil.Inserir();

			if (sMsg.Substring(0, 1) == "E")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				rowId.Value = sMsg;

				TratamentoErro("Especificação Dynafil inserida com sucesso.");
				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);

			}
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
		if (gvEspecificacaoDynafil.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
			// Sem a opção de Salvar
			// Response.Cache.SetCacheability(HttpCacheability.NoCache);
			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvEspecificacaoDynafil.AllowSorting = false;
			gvEspecificacaoDynafil.AllowPaging = false;
			//gvEspecificacaoDynafil.DataBind();

			// Deixar cabeçalho em branco/preto, sem links e imagens
			for (int i = 0; i < gvEspecificacaoDynafil.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvEspecificacaoDynafil.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvEspecificacaoDynafil.RenderControl(htmlWrite);

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
		if (gvEspecificacaoDynafil.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/vnd.ms-excel";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
			//Sem a opção de Salvar
			//Response.Cache.SetCacheability(HttpCacheability.NoCache);

			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvEspecificacaoDynafil.AllowSorting = false;
			gvEspecificacaoDynafil.AllowPaging = false;

			// Deixar cabeçalho em branco/preto, sem links e imagens

			for (int i = 0; i < gvEspecificacaoDynafil.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvEspecificacaoDynafil.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvEspecificacaoDynafil.RenderControl(htmlWrite);

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

    protected void CalculaMinimoMaximo(object sender, EventArgs e)
    {
        TextBox cTlr = (TextBox)sender;

        string sNovoFoco = "";
        TextBox cMed = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "med"));
        TextBox cMin = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "min"));
        TextBox cMax = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "max"));

        cMin.Text = (Convert.ToDouble(cMed.Text) - Convert.ToDouble(cTlr.Text)).ToString("0.00");
        cMax.Text = (Convert.ToDouble(cMed.Text) + Convert.ToDouble(cTlr.Text)).ToString("0.00");

        sNovoFoco = cTlr.ID.ToString().Replace("tlr", "min");

        TextBox cNovo = (TextBox)FindControl(sNovoFoco);
        cNovo.Focus();

    }

}