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
		txt_tit_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tit_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_enm_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_enm_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_enm_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_enm_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_eee_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_eee_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_kkk_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_kkk_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_bbb_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_bbb_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_pue_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pue_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ole_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ole_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_trq_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_trq_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ert_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ert_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt3_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt3_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt5_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt5_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_pes_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pes_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_dmo_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dmo_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_dnd_inc_xxx.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dnd_inc_xxx.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pue_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pue_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_trq_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_inc_yyy.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_inc_yyy.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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

			txt_tit_inc_xxx.Focus();

			ParametroAnalise ParametroAnalise = new ParametroAnalise();
			ParametroAnalise.PRM_ANS_ID = Convert.ToInt32(rowId.Value);
			DataSet dsParametroAnalise = ParametroAnalise.Consultar();
			if (dsParametroAnalise.Tables[0].Rows.Count > 0)
			{
				txt_tit_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TIT_XXX"].ToString();
				txt_tnc_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TNC_XXX"].ToString();
				txt_aon_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_AON_XXX"].ToString();
				txt_enm_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_ENM_XXX"].ToString();
				txt_eee_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_EEE_XXX"].ToString();
				txt_kkk_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_KKK_XXX"].ToString();
				txt_bbb_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_BBB_XXX"].ToString();
				txt_pue_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_PUE_XXX"].ToString();
				txt_ole_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_OLE_XXX"].ToString();
				txt_trq_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TRQ_XXX"].ToString();
				txt_ert_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_ERT_XXX"].ToString();
				txt_rt3_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_RT3_XXX"].ToString();
				txt_rt5_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_RT5_XXX"].ToString();
				txt_pes_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_PES_XXX"].ToString();
				txt_dmo_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_DMO_XXX"].ToString();
				txt_dnd_inc_xxx.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_DND_XXX"].ToString();

                txt_tit_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TIT_YYY"].ToString();
                txt_tnc_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TNC_YYY"].ToString();
                txt_aon_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_AON_YYY"].ToString();
                txt_enm_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_ENM_YYY"].ToString();
                txt_eee_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_EEE_YYY"].ToString();
                txt_kkk_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_KKK_YYY"].ToString();
                txt_bbb_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_BBB_YYY"].ToString();
                txt_pue_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_PUE_YYY"].ToString();
                txt_ole_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_OLE_YYY"].ToString();
                txt_trq_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_TRQ_YYY"].ToString();
                txt_ert_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_ERT_YYY"].ToString();
                txt_rt3_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_RT3_YYY"].ToString();
                txt_rt5_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_RT5_YYY"].ToString();
                txt_pes_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_PES_YYY"].ToString();
                txt_dmo_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_DMO_YYY"].ToString();
                txt_dnd_inc_yyy.Text = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_DND_YYY"].ToString();
                
                cbo_sts_inc.SelectedValue = dsParametroAnalise.Tables[0].Rows[0]["PRM_ANS_STS"].ToString();
			}
			dsParametroAnalise.Dispose();
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

				txt_tit_inc_xxx.Focus();
		    }
		    else
		    {
		        divCadastro.Visible = false;
		        dvFiltro.Visible = true;

				txt_tit_xxx.Focus();
		    }
		}
	}

	private void LimpaTela()
	{
		txt_tit_xxx.Text = "";
		txt_tnc_xxx.Text = "";
		txt_aon_xxx.Text = "";
		txt_enm_xxx.Text = "";
        txt_tit_yyy.Text = "";
        txt_tnc_yyy.Text = "";
        txt_aon_yyy.Text = "";
        txt_enm_yyy.Text = "";
        cbo_sts.Text = "";

        txt_tit_inc_xxx.Text = "";
        txt_tnc_inc_xxx.Text = "";
        txt_aon_inc_xxx.Text = "";
        txt_enm_inc_xxx.Text = "";
        txt_eee_inc_xxx.Text = "";
        txt_kkk_inc_xxx.Text = "";
        txt_bbb_inc_xxx.Text = "";
        txt_pue_inc_xxx.Text = "";
        txt_ole_inc_xxx.Text = "";
        txt_trq_inc_xxx.Text = "";
        txt_ert_inc_xxx.Text = "";
        txt_rt3_inc_xxx.Text = "";
        txt_rt5_inc_xxx.Text = "";
        txt_pes_inc_xxx.Text = "";
        txt_dmo_inc_xxx.Text = "";
        txt_dnd_inc_xxx.Text = "";
        txt_tit_inc_yyy.Text = "";
        txt_tnc_inc_yyy.Text = "";
        txt_aon_inc_yyy.Text = "";
        txt_enm_inc_yyy.Text = "";
        txt_eee_inc_yyy.Text = "";
        txt_kkk_inc_yyy.Text = "";
        txt_bbb_inc_yyy.Text = "";
        txt_pue_inc_yyy.Text = "";
        txt_ole_inc_yyy.Text = "";
        txt_trq_inc_yyy.Text = "";
        txt_ert_inc_yyy.Text = "";
        txt_rt3_inc_yyy.Text = "";
        txt_rt5_inc_yyy.Text = "";
        txt_pes_inc_yyy.Text = "";
        txt_dmo_inc_yyy.Text = "";
        txt_dnd_inc_yyy.Text = "";
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
		txt_tit_inc_xxx.Focus();
	}

	protected void btVoltar_Click(object sender, EventArgs e)
	{
		divCadastro.Visible = false;
		dvResultado.Visible = false;
		dvFiltro.Visible = true;
		txt_tit_xxx.Focus();
	}

	protected void btLimpar_Click(object sender, EventArgs e)
	{
		LimpaTela();
	}

	protected void btFiltro_Click(object sender, EventArgs e)
	{
		dvFiltro.Visible = true;
		dvResultado.Visible = false;
		txt_tit_xxx.Focus();
	}

	protected string CriaFiltro(ParametroAnalise ParametroAnalise)
	{
		string filtro = "";
		if (!String.IsNullOrEmpty(txt_tit_xxx.Text))
		{
			ParametroAnalise.PRM_ANS_TIT_XXX = Convert.ToDouble(txt_tit_xxx.Text);
			filtro = filtro + "Titulo= " + txt_tit_xxx.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_tnc_xxx.Text))
		{
			ParametroAnalise.PRM_ANS_TNC_XXX = Convert.ToDouble(txt_tnc_xxx.Text);
			filtro = filtro + "Tenacidade= " + txt_tnc_xxx.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_aon_xxx.Text))
		{
			ParametroAnalise.PRM_ANS_AON_XXX = Convert.ToDouble(txt_aon_xxx.Text);
			filtro = filtro + "Alongamento= " + txt_aon_xxx.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_enm_xxx.Text))
		{
			ParametroAnalise.PRM_ANS_ENM_XXX = Convert.ToDouble(txt_enm_xxx.Text);
			filtro = filtro + "Encolhimento= " + txt_enm_xxx.Text + "; ";
		}
        if (!String.IsNullOrEmpty(txt_tit_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_TIT_YYY = Convert.ToDouble(txt_tit_yyy.Text);
            filtro = filtro + "Titulo= " + txt_tit_yyy.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_tnc_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_TNC_YYY = Convert.ToDouble(txt_tnc_yyy.Text);
            filtro = filtro + "Tenacidade= " + txt_tnc_yyy.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_aon_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_AON_YYY = Convert.ToDouble(txt_aon_yyy.Text);
            filtro = filtro + "Alongamento= " + txt_aon_yyy.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_enm_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_ENM_YYY = Convert.ToDouble(txt_enm_yyy.Text);
            filtro = filtro + "Encolhimento= " + txt_enm_yyy.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
		{
			ParametroAnalise.PRM_ANS_STS = Convert.ToInt32(cbo_sts.SelectedValue);
			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
		}
		return filtro;
	}

	protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		ParametroAnalise ParametroAnalise = new ParametroAnalise();
		filtro = CriaFiltro(ParametroAnalise);
		DataSet dsParametroAnalise = ParametroAnalise.Consultar();

		gvParametroAnalise.DataSource = dsParametroAnalise;
		gvParametroAnalise.DataBind();
		dsParametroAnalise.Dispose();
		Dispose();

		if (!String.IsNullOrEmpty(filtro))
		{
			lb_fil.Text = filtro;
		}
		else
		{
			lb_fil.Text = "N?o h? filtros.";
		}

		dvFiltro.Visible = false;
		dvResultado.Visible = true;
	}

	protected void gvParametroAnalise_RowDataBound(object sender, GridViewRowEventArgs e)
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
				e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvParametroAnalise.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvParametroAnalise.DataKeys[e.Row.RowIndex][0].ToString() + "');");
			else
				e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'ParametroAnalise.aspx?rowId=" + gvParametroAnalise.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
		foreach (DataControlField field in gvParametroAnalise.Columns)
		{
			if (field.SortExpression == (string)ViewState["SortExpression"])
			{
				return gvParametroAnalise.Columns.IndexOf(field);
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

	protected void gvParametroAnalise_RowCreated(object sender, GridViewRowEventArgs e)
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

	protected void gvParametroAnalise_Sorting(Object sender, GridViewSortEventArgs e)
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

		ParametroAnalise ParametroAnalise = new ParametroAnalise();
		filtro = CriaFiltro(ParametroAnalise);
		DataSet dsParametroAnalise = ParametroAnalise.Consultar();

		DataTable dtParametroAnalise = dsParametroAnalise.Tables[0];
		DataView dvParametroAnalise = new DataView(dtParametroAnalise);
		dvParametroAnalise.Sort = e.SortExpression + Ordem;
		gvParametroAnalise.DataSource = dvParametroAnalise;
		gvParametroAnalise.DataBind();

		dvParametroAnalise.Dispose();
		dtParametroAnalise.Dispose();
		dsParametroAnalise.Dispose();
		Dispose();
	}

	protected void btSalvar_Click(object sender, EventArgs e)
	{
		string sMsg;
        if (txt_tit_inc_xxx.Text == "")
        {
            TratamentoErro("O campo T?tulo X ? obrigat?rio.");
            txt_tit_inc_xxx.Focus();
            return;
        }
        if (txt_tnc_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Tenacidade X ? obrigat?rio.");
            txt_tnc_inc_xxx.Focus();
            return;
        }
        if (txt_aon_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Alongamento X ? obrigat?rio.");
            txt_aon_inc_xxx.Focus();
            return;
        }
        if (txt_enm_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Encolhimneto X ? obrigat?rio.");
            txt_enm_inc_xxx.Focus();
            return;
        }
        if (txt_eee_inc_xxx.Text == "")
        {
            TratamentoErro("O campo E X ? obrigat?rio.");
            txt_eee_inc_xxx.Focus();
            return;
        }
        if (txt_kkk_inc_xxx.Text == "")
        {
            TratamentoErro("O campo K X ? obrigat?rio.");
            txt_kkk_inc_xxx.Focus();
            return;
        }
        if (txt_bbb_inc_xxx.Text == "")
        {
            TratamentoErro("O campo B X ? obrigat?rio.");
            txt_bbb_inc_xxx.Focus();
            return;
        }
        if (txt_ole_inc_xxx.Text == "")
        {
            TratamentoErro("O campo ?leo X ? obrigat?rio.");
            txt_ole_inc_xxx.Focus();
            return;
        }
        if (txt_ert_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Entrela?amento X ? obrigat?rio.");
            txt_ert_inc_xxx.Focus();
            return;
        }
        if (txt_rt3_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Reten??o 1 X ? obrigat?rio.");
            txt_rt3_inc_xxx.Focus();
            return;
        }
        if (txt_rt5_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Reten??o 2 X ? obrigat?rio.");
            txt_rt5_inc_xxx.Focus();
            return;
        }
        if (txt_dnd_inc_xxx.Text == "")
        {
            TratamentoErro("O campo Densidade X ? obrigat?rio.");
            txt_dnd_inc_xxx.Focus();
            return;
        }

        if (txt_tit_inc_yyy.Text == "")
        {
            TratamentoErro("O campo T?tulo Y ? obrigat?rio.");
            txt_tit_inc_yyy.Focus();
            return;
        }
        if (txt_tnc_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Tenacidade Y ? obrigat?rio.");
            txt_tnc_inc_yyy.Focus();
            return;
        }
        if (txt_aon_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Alongamento Y ? obrigat?rio.");
            txt_aon_inc_yyy.Focus();
            return;
        }
        if (txt_enm_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Encolhimneto Y ? obrigat?rio.");
            txt_enm_inc_yyy.Focus();
            return;
        }
        if (txt_eee_inc_yyy.Text == "")
        {
            TratamentoErro("O campo E Y ? obrigat?rio.");
            txt_eee_inc_yyy.Focus();
            return;
        }
        if (txt_kkk_inc_yyy.Text == "")
        {
            TratamentoErro("O campo K Y ? obrigat?rio.");
            txt_kkk_inc_yyy.Focus();
            return;
        }
        if (txt_bbb_inc_yyy.Text == "")
        {
            TratamentoErro("O campo B Y ? obrigat?rio.");
            txt_bbb_inc_yyy.Focus();
            return;
        }
        if (txt_ole_inc_yyy.Text == "")
        {
            TratamentoErro("O campo ?leo Y ? obrigat?rio.");
            txt_ole_inc_yyy.Focus();
            return;
        }
        if (txt_ert_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Entrela?amento Y ? obrigat?rio.");
            txt_ert_inc_yyy.Focus();
            return;
        }
        if (txt_rt3_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Reten??o 1 Y ? obrigat?rio.");
            txt_rt3_inc_yyy.Focus();
            return;
        }
        if (txt_rt5_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Reten??o 2 Y ? obrigat?rio.");
            txt_rt5_inc_yyy.Focus();
            return;
        }
        if (txt_dnd_inc_yyy.Text == "")
        {
            TratamentoErro("O campo Densidade Y ? obrigat?rio.");
            txt_dnd_inc_yyy.Focus();
            return;
        } 

        if (cbo_sts_inc.Text == "")
		{
			TratamentoErro("O campo Status ? obrigat?rio.");
			cbo_sts_inc.Focus();
			return;
		}

		ParametroAnalise ParametroAnalise = new ParametroAnalise();
		ParametroAnalise.PRM_ANS_TIT_XXX = Convert.ToDouble(txt_tit_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_TNC_XXX = Convert.ToDouble(txt_tnc_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_AON_XXX = Convert.ToDouble(txt_aon_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_ENM_XXX = Convert.ToDouble(txt_enm_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_EEE_XXX = Convert.ToDouble(txt_eee_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_KKK_XXX = Convert.ToDouble(txt_kkk_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_BBB_XXX = Convert.ToDouble(txt_bbb_inc_xxx.Text);
        if (!string.IsNullOrEmpty(txt_pue_inc_xxx.Text))
        {
		    ParametroAnalise.PRM_ANS_PUE_XXX = Convert.ToDouble(txt_pue_inc_xxx.Text);
        }
		ParametroAnalise.PRM_ANS_OLE_XXX = Convert.ToDouble(txt_ole_inc_xxx.Text);
        if (!string.IsNullOrEmpty(txt_trq_inc_xxx.Text))
        {
            ParametroAnalise.PRM_ANS_TRQ_XXX = Convert.ToDouble(txt_trq_inc_xxx.Text);
        }
		ParametroAnalise.PRM_ANS_ERT_XXX = Convert.ToDouble(txt_ert_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_RT3_XXX = Convert.ToDouble(txt_rt3_inc_xxx.Text);
		ParametroAnalise.PRM_ANS_RT5_XXX = Convert.ToDouble(txt_rt5_inc_xxx.Text);
        if (!string.IsNullOrEmpty(txt_pes_inc_xxx.Text))
        {
            ParametroAnalise.PRM_ANS_PES_XXX = Convert.ToDouble(txt_pes_inc_xxx.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_inc_xxx.Text))
        {
            ParametroAnalise.PRM_ANS_DMO_XXX = Convert.ToDouble(txt_dmo_inc_xxx.Text);
        }
		ParametroAnalise.PRM_ANS_DND_XXX = Convert.ToDouble(txt_dnd_inc_xxx.Text);

        ParametroAnalise.PRM_ANS_TIT_YYY = Convert.ToDouble(txt_tit_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_TNC_YYY = Convert.ToDouble(txt_tnc_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_AON_YYY = Convert.ToDouble(txt_aon_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_ENM_YYY = Convert.ToDouble(txt_enm_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_EEE_YYY = Convert.ToDouble(txt_eee_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_KKK_YYY = Convert.ToDouble(txt_kkk_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_BBB_YYY = Convert.ToDouble(txt_bbb_inc_yyy.Text);
        if (!string.IsNullOrEmpty(txt_pue_inc_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_PUE_YYY = Convert.ToDouble(txt_pue_inc_yyy.Text);
        }
        ParametroAnalise.PRM_ANS_OLE_YYY = Convert.ToDouble(txt_ole_inc_yyy.Text);
        if (!string.IsNullOrEmpty(txt_trq_inc_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_TRQ_YYY = Convert.ToDouble(txt_trq_inc_yyy.Text);
        }
        ParametroAnalise.PRM_ANS_ERT_YYY = Convert.ToDouble(txt_ert_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_RT3_YYY = Convert.ToDouble(txt_rt3_inc_yyy.Text);
        ParametroAnalise.PRM_ANS_RT5_YYY = Convert.ToDouble(txt_rt5_inc_yyy.Text);
        if (!string.IsNullOrEmpty(txt_pes_inc_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_PES_YYY = Convert.ToDouble(txt_pes_inc_yyy.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_inc_yyy.Text))
        {
            ParametroAnalise.PRM_ANS_DMO_YYY = Convert.ToDouble(txt_dmo_inc_yyy.Text);
        }
        ParametroAnalise.PRM_ANS_DND_YYY = Convert.ToDouble(txt_dnd_inc_yyy.Text);
        if (cbo_sts_inc.Text != "")
		{
			ParametroAnalise.PRM_ANS_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
		}

		if (!string.IsNullOrEmpty(rowId.Value))
		{
			ParametroAnalise.PRM_ANS_ID = Convert.ToInt32(rowId.Value);
			ParametroAnalise.PRM_ANS_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = ParametroAnalise.Alterar();
			if (sMsg != "")
			{
				Response.Redirect("Erro.aspx?Erro="+sMsg);
			}
			else
			{
				TratamentoErro("Par?metro An?lise alterado com sucesso.");
			}
		}
		else
		{
            /*
			ParametroAnalise PRM_ANS = new ParametroAnalise();
			//Verificar se j? n?o existe um cadastro consultando o: PRM_ANS_DES 
			PRM_ANS.PRM_ANS_DES = txt_des_inc.Text;
			DataSet dsPRM_ANS = PRM_ANS.Consultar();
			if (dsPRM_ANS.Tables[0].Rows.Count > 0)
			{
				TratamentoErro("Esse ParametroAnalise j? est? cadastrado.");
				txt_tit_inc.Focus();

				return;
			}
            */ 

			ParametroAnalise.PRM_ANS_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = ParametroAnalise.Inserir();

			if (sMsg.Substring(0, 1) == "E")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				rowId.Value = sMsg;

				TratamentoErro("Par?metro An?lise inserido com sucesso.");
				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
			}
			//dsPRM_ANS.Dispose();
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
		if (gvParametroAnalise.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
			// Sem a op??o de Salvar
			// Response.Cache.SetCacheability(HttpCacheability.NoCache);
			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvParametroAnalise.AllowSorting = false;
			gvParametroAnalise.AllowPaging = false;
			//gvParametroAnalise.DataBind();

			// Deixar cabe?alho em branco/preto, sem links e imagens
			for (int i = 0; i < gvParametroAnalise.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvParametroAnalise.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvParametroAnalise.RenderControl(htmlWrite);

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
		if (gvParametroAnalise.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/vnd.ms-excel";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
			//Sem a op??o de Salvar
			//Response.Cache.SetCacheability(HttpCacheability.NoCache);

			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvParametroAnalise.AllowSorting = false;
			gvParametroAnalise.AllowPaging = false;

			// Deixar cabe?alho em branco/preto, sem links e imagens

			for (int i = 0; i < gvParametroAnalise.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvParametroAnalise.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvParametroAnalise.RenderControl(htmlWrite);

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
}