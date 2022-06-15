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
		txt_tit_con_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_con_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tit_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_enm_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_enm_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_eee_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_eee_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_kkk_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_kkk_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_bbb_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_bbb_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_pue_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pue_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ole_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ole_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
		txt_trq_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ert_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ert_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt3_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt3_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt5_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt5_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        /*
		txt_pes_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pes_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_dmo_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dmo_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        */
		txt_dnd_med_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dnd_med_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pue_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pue_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        /*
        txt_pes_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        */
        txt_dnd_tlr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_tlr_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pue_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pue_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        /*
        txt_pes_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        */
        txt_dnd_min_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_min_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tit_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_tnc_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_tnc_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_aon_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_aon_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_enm_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_enm_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_eee_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_eee_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_kkk_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_kkk_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_bbb_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_bbb_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_pue_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pue_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ole_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ole_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
		txt_trq_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_ert_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_ert_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt3_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt3_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_rt5_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_rt5_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        /*
		txt_pes_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_pes_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
		txt_dmo_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dmo_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        */
		txt_dnd_max_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
		txt_dnd_max_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
	}

	protected void CarregaControles()
	{
		Titulo Titulo = new Titulo();
		DataSet dsTitulo = Titulo.Consultar();
		FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
		FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
		dsTitulo.Dispose();

		Apresentacao Apresentacao = new Apresentacao();
		DataSet dsApresentacao = Apresentacao.Consultar();
		FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
		FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_inc);
		dsApresentacao.Dispose();

		MaquinaTipo MaquinaTipo = new MaquinaTipo();
		DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
		FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
		FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
		dsMaquinaTipo.Dispose();

		Entrelacamento Entrelacamento = new Entrelacamento();
		DataSet dsEntrelacamento = Entrelacamento.Consultar();
		FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id);
		FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_inc);
		dsEntrelacamento.Dispose();
    }

	protected void CarregaDados()
	{
		if (!string.IsNullOrEmpty(rowId.Value))
		{
			lbAcao.Text = "Alterar";
			divCadastro.Visible = true;
			dvFiltro.Visible = false;

			txt_dat_inc.Focus();

			Especificacao Especificacao = new Especificacao();
			Especificacao.ANE_ID = Convert.ToInt32(rowId.Value);
			DataSet dsEspecificacao = Especificacao.Consultar();
			if (dsEspecificacao.Tables[0].Rows.Count > 0)
			{
				txt_dat_inc.Text = Convert.ToDateTime(dsEspecificacao.Tables[0].Rows[0]["ANE_DAT"].ToString()).ToString("dd/MM/yyyy");
                txt_lot_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_LOT"].ToString();
                txt_lot_ref_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_LOT_REF"].ToString();
                cbo_tit_poy_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_POY_ID"].ToString();
				cbo_aps_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_APS_ID"].ToString();
				cbo_maq_tip_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_MAQ_TIP_ID"].ToString();
				cbo_ert_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_ID"].ToString();
				txt_tit_con_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_CON"].ToString();
				txt_tit_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MED"].ToString();
				txt_tnc_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MED"].ToString();
				txt_aon_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MED"].ToString();
				txt_enm_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MED"].ToString();
				txt_eee_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MED"].ToString();
				txt_kkk_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MED"].ToString();
				txt_bbb_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MED"].ToString();
				txt_pue_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MED"].ToString();
				txt_ole_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MED"].ToString();
				txt_trq_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString();
				txt_ert_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MED"].ToString();
				txt_rt3_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MED"].ToString();
				txt_rt5_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MED"].ToString();
                /*
				txt_pes_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MED"].ToString();
				txt_dmo_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MED"].ToString();
                */
				txt_dnd_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MED"].ToString();
                txt_tit_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_TLR"].ToString();
                txt_tnc_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_TLR"].ToString();
                txt_aon_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_TLR"].ToString();
                txt_enm_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_TLR"].ToString();
                txt_eee_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_TLR"].ToString();
                txt_kkk_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_TLR"].ToString();
                txt_bbb_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_TLR"].ToString();
                txt_pue_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_TLR"].ToString();
                txt_ole_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_TLR"].ToString();
                txt_trq_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_TLR"].ToString();
                txt_ert_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_TLR"].ToString();
                txt_rt3_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_TLR"].ToString();
                txt_rt5_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_TLR"].ToString();
                /*
                txt_pes_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_TLR"].ToString();
                txt_dmo_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_TLR"].ToString();
                */
                txt_dnd_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_TLR"].ToString();
                txt_tit_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString();
                txt_tnc_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString();
                txt_aon_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MIN"].ToString();
                txt_enm_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString();
                txt_eee_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MIN"].ToString();
                txt_kkk_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MIN"].ToString();
                txt_bbb_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MIN"].ToString();
                txt_pue_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MIN"].ToString();
                txt_ole_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString();
                txt_trq_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString();
                txt_ert_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString();
                txt_rt3_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MIN"].ToString();
                txt_rt5_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MIN"].ToString();
                /*
                txt_pes_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MIN"].ToString();
                txt_dmo_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MIN"].ToString();
                */
                txt_dnd_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MIN"].ToString();
                txt_tit_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString();
				txt_tnc_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString();
				txt_aon_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MAX"].ToString();
				txt_enm_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString();
				txt_eee_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MAX"].ToString();
				txt_kkk_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MAX"].ToString();
				txt_bbb_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MAX"].ToString();
				txt_pue_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MAX"].ToString();
				txt_ole_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString();
				txt_trq_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString();
				txt_ert_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString();
				txt_rt3_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MAX"].ToString();
				txt_rt5_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MAX"].ToString();
                /*
				txt_pes_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MAX"].ToString();
				txt_dmo_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MAX"].ToString();
                */
				txt_dnd_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MAX"].ToString();
				txt_obs_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OBS"].ToString();
				cbo_sts_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_STS"].ToString();
			}
			dsEspecificacao.Dispose();
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
        cbo_tit_poy_id.Text = "";
		cbo_aps_id.Text = "";
		cbo_maq_tip_id.Text = "";
		cbo_ert_id.Text = "";
		cbo_sts.Text = "";

		txt_dat_inc.Text = "";
		txt_lot_inc.Text = "";
        txt_lot_ref_inc.Text = "";
        cbo_tit_poy_id_inc.SelectedIndex = 0;
		cbo_aps_id_inc.SelectedIndex = 0;
		cbo_maq_tip_id_inc.SelectedIndex = 0;
		cbo_ert_id_inc.SelectedIndex = 0;
		txt_tit_con_inc.Text = "";
		txt_tit_med_inc.Text = "";
		txt_tnc_med_inc.Text = "";
		txt_aon_med_inc.Text = "";
		txt_enm_med_inc.Text = "";
		txt_eee_med_inc.Text = "";
		txt_kkk_med_inc.Text = "";
		txt_bbb_med_inc.Text = "";
		txt_pue_med_inc.Text = "";
		txt_ole_med_inc.Text = "";
		txt_trq_med_inc.Text = "";
		txt_ert_med_inc.Text = "";
		txt_rt3_med_inc.Text = "";
		txt_rt5_med_inc.Text = "";
        /*
		txt_pes_med_inc.Text = "";
		txt_dmo_med_inc.Text = "";
        */
		txt_dnd_med_inc.Text = "";
        txt_tit_tlr_inc.Text = "";
        txt_tnc_tlr_inc.Text = "";
        txt_aon_tlr_inc.Text = "";
        txt_enm_tlr_inc.Text = "";
        txt_eee_tlr_inc.Text = "";
        txt_kkk_tlr_inc.Text = "";
        txt_bbb_tlr_inc.Text = "";
        txt_pue_tlr_inc.Text = "";
        txt_ole_tlr_inc.Text = "";
        txt_trq_tlr_inc.Text = "";
        txt_ert_tlr_inc.Text = "";
        txt_rt3_tlr_inc.Text = "";
        txt_rt5_tlr_inc.Text = "";
        /*
        txt_pes_tlr_inc.Text = "";
        txt_dmo_tlr_inc.Text = "";
        */
        txt_dnd_tlr_inc.Text = "";
        txt_tit_min_inc.Text = "";
        txt_tnc_min_inc.Text = "";
        txt_aon_min_inc.Text = "";
        txt_enm_min_inc.Text = "";
        txt_eee_min_inc.Text = "";
        txt_kkk_min_inc.Text = "";
        txt_bbb_min_inc.Text = "";
        txt_pue_min_inc.Text = "";
        txt_ole_min_inc.Text = "";
        txt_trq_min_inc.Text = "";
        txt_ert_min_inc.Text = "";
        txt_rt3_min_inc.Text = "";
        txt_rt5_min_inc.Text = "";
        /*
        txt_pes_min_inc.Text = "";
        txt_dmo_min_inc.Text = "";
        */
        txt_dnd_min_inc.Text = "";
        txt_tit_max_inc.Text = "";
		txt_tnc_max_inc.Text = "";
		txt_aon_max_inc.Text = "";
		txt_enm_max_inc.Text = "";
		txt_eee_max_inc.Text = "";
		txt_kkk_max_inc.Text = "";
		txt_bbb_max_inc.Text = "";
		txt_pue_max_inc.Text = "";
		txt_ole_max_inc.Text = "";
		txt_trq_max_inc.Text = "";
		txt_ert_max_inc.Text = "";
		txt_rt3_max_inc.Text = "";
		txt_rt5_max_inc.Text = "";
        /*
		txt_pes_max_inc.Text = "";
		txt_dmo_max_inc.Text = "";
        */
		txt_dnd_max_inc.Text = "";
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

	protected string CriaFiltro(Especificacao Especificacao)
	{
		string filtro = "";
		if (!String.IsNullOrEmpty(txt_dat.Text))
		{
			Especificacao.ANE_DAT = Convert.ToDateTime(txt_dat.Text);
			filtro = filtro + "Data= " + txt_dat.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_lot.Text))
		{
			Especificacao.ANE_LOT = txt_lot.Text;
			filtro = filtro + "Lote= " + txt_lot.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
		{
			Especificacao.ANE_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
			filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_aps_id.Text))
		{
			Especificacao.ANE_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
			filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
		{
			Especificacao.ANE_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
			filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_ert_id.Text))
		{
			Especificacao.ANE_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
			filtro = filtro + "Entrelaçamento= " + cbo_ert_id.SelectedItem.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_sts.Text))
		{
			Especificacao.ANE_STS = Convert.ToInt32(cbo_sts.SelectedValue);
			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
		}
		return filtro;
	}

	protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		Especificacao Especificacao = new Especificacao();
		filtro = CriaFiltro(Especificacao);
		DataSet dsEspecificacao = Especificacao.Consultar();

		gvEspecificacao.DataSource = dsEspecificacao;
		gvEspecificacao.DataBind();
		dsEspecificacao.Dispose();
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

	protected void gvEspecificacao_RowDataBound(object sender, GridViewRowEventArgs e)
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
				e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvEspecificacao.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvEspecificacao.DataKeys[e.Row.RowIndex][0].ToString() + "');");
			else
				e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Especificacao.aspx?rowId=" + gvEspecificacao.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
		foreach (DataControlField field in gvEspecificacao.Columns)
		{
			if (field.SortExpression == (string)ViewState["SortExpression"])
			{
				return gvEspecificacao.Columns.IndexOf(field);
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

	protected void gvEspecificacao_RowCreated(object sender, GridViewRowEventArgs e)
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

	protected void gvEspecificacao_Sorting(Object sender, GridViewSortEventArgs e)
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

		Especificacao Especificacao = new Especificacao();
		filtro = CriaFiltro(Especificacao);
		DataSet dsEspecificacao = Especificacao.Consultar();

		DataTable dtEspecificacao = dsEspecificacao.Tables[0];
		DataView dvEspecificacao = new DataView(dtEspecificacao);
		dvEspecificacao.Sort = e.SortExpression + Ordem;
		gvEspecificacao.DataSource = dvEspecificacao;
		gvEspecificacao.DataBind();

		dvEspecificacao.Dispose();
		dtEspecificacao.Dispose();
		dsEspecificacao.Dispose();
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

        if (cbo_tit_poy_id_inc.Text == "")
        {
            TratamentoErro("O campo Titulo é obrigatório.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

        if (cbo_aps_id_inc.Text == "")
		{
			TratamentoErro("O campo Apresentação é obrigatório.");
			cbo_aps_id_inc.Focus();
			return;
		}

		if (cbo_maq_tip_id_inc.Text == "")
		{
			TratamentoErro("O campo Tipo Máquina é obrigatório.");
			cbo_maq_tip_id_inc.Focus();
			return;
		}

		if (cbo_ert_id_inc.Text == "")
		{
			TratamentoErro("O campo Entrelaçamento é obrigatório.");
			cbo_ert_id_inc.Focus();
			return;
		}

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

        if (txt_ole_med_inc.Text == "")
        {
            TratamentoErro("O campo Óleo é obrigatório.");
            txt_ole_med_inc.Focus();
            return;
        }

        if (txt_ole_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Óleo é obrigatório.");
            txt_ole_tlr_inc.Focus();
            return;
        }

        if (txt_ole_min_inc.Text == "")
        {
            TratamentoErro("O campo Óleo é obrigatório.");
            txt_ole_min_inc.Focus();
            return;
        }

        if (txt_ole_max_inc.Text == "")
        {
            TratamentoErro("O campo Óleo é obrigatório.");
            txt_ole_max_inc.Focus();
            return;
        }

        if (txt_enm_med_inc.Text == "")
        {
            TratamentoErro("O campo Encolhimento é obrigatório.");
            txt_enm_med_inc.Focus();
            return;
        }

        if (txt_enm_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Encolhimento é obrigatório.");
            txt_enm_tlr_inc.Focus();
            return;
        }

        if (txt_enm_min_inc.Text == "")
        {
            TratamentoErro("O campo Encolhimento é obrigatório.");
            txt_enm_min_inc.Focus();
            return;
        }

        if (txt_enm_max_inc.Text == "")
        {
            TratamentoErro("O campo Encolhimento é obrigatório.");
            txt_enm_max_inc.Focus();
            return;
        }
        /*
        if (txt_eee_med_inc.Text == "")
        {
            TratamentoErro("O campo E (%) é obrigatório.");
            txt_eee_med_inc.Focus();
            return;
        }

        if (txt_eee_tlr_inc.Text == "")
        {
            TratamentoErro("O campo E (%) é obrigatório.");
            txt_eee_tlr_inc.Focus();
            return;
        }

        if (txt_eee_min_inc.Text == "")
        {
            TratamentoErro("O campo E (%) é obrigatório.");
            txt_eee_min_inc.Focus();
            return;
        }

        if (txt_eee_max_inc.Text == "")
        {
            TratamentoErro("O campo E (%) é obrigatório.");
            txt_eee_max_inc.Focus();
            return;
        }

        if (txt_kkk_med_inc.Text == "")
        {
            TratamentoErro("O campo K (%) é obrigatório.");
            txt_kkk_med_inc.Focus();
            return;
        }

        if (txt_kkk_tlr_inc.Text == "")
        {
            TratamentoErro("O campo K (%) é obrigatório.");
            txt_kkk_tlr_inc.Focus();
            return;
        }

        if (txt_kkk_min_inc.Text == "")
        {
            TratamentoErro("O campo K (%) é obrigatório.");
            txt_kkk_min_inc.Focus();
            return;
        }

        if (txt_kkk_max_inc.Text == "")
        {
            TratamentoErro("O campo K (%) é obrigatório.");
            txt_kkk_max_inc.Focus();
            return;
        }

        if (txt_bbb_med_inc.Text == "")
        {
            TratamentoErro("O campo B (%) é obrigatório.");
            txt_bbb_med_inc.Focus();
            return;
        }

        if (txt_bbb_tlr_inc.Text == "")
        {
            TratamentoErro("O campo B (%) é obrigatório.");
            txt_bbb_tlr_inc.Focus();
            return;
        }

        if (txt_bbb_min_inc.Text == "")
        {
            TratamentoErro("O campo B (%) é obrigatório.");
            txt_bbb_min_inc.Focus();
            return;
        }

        if (txt_bbb_max_inc.Text == "")
        {
            TratamentoErro("O campo B (%) é obrigatório.");
            txt_bbb_max_inc.Focus();
            return;
        }

        if (txt_pue_med_inc.Text == "")
        {
            TratamentoErro("O campo PUE é obrigatório.");
            txt_pue_med_inc.Focus();
            return;
        }

        if (txt_pue_tlr_inc.Text == "")
        {
            TratamentoErro("O campo PUE é obrigatório.");
            txt_pue_tlr_inc.Focus();
            return;
        }

        if (txt_pue_min_inc.Text == "")
        {
            TratamentoErro("O campo PUE é obrigatório.");
            txt_pue_min_inc.Focus();
            return;
        }

        if (txt_pue_max_inc.Text == "")
        {
            TratamentoErro("O campo PUE é obrigatório.");
            txt_pue_max_inc.Focus();
            return;
        }
        if (txt_trq_med_inc.Text == "")
        {
            TratamentoErro("O campo Torque é obrigatório.");
            txt_trq_med_inc.Focus();
            return;
        }

        if (txt_trq_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Torque é obrigatório.");
            txt_trq_tlr_inc.Focus();
            return;
        }

        if (txt_trq_min_inc.Text == "")
        {
            TratamentoErro("O campo Torque é obrigatório.");
            txt_trq_min_inc.Focus();
            return;
        }

        if (txt_trq_max_inc.Text == "")
        {
            TratamentoErro("O campo Torque é obrigatório.");
            txt_trq_max_inc.Focus();
            return;
        }
        */

        if (cbo_ert_id_inc.SelectedItem.Text != "0T")
        {
            if (txt_ert_med_inc.Text == "")
            {
                TratamentoErro("O campo Entrelaçamento é obrigatório.");
                txt_ert_med_inc.Focus();
                return;
            }

            if (txt_ert_tlr_inc.Text == "")
            {
                TratamentoErro("O campo Entrelaçamento é obrigatório.");
                txt_ert_tlr_inc.Focus();
                return;
            }

            if (txt_ert_min_inc.Text == "")
            {
                TratamentoErro("O campo Entrelaçamento é obrigatório.");
                txt_ert_min_inc.Focus();
                return;
            }

            if (txt_ert_max_inc.Text == "")
            {
                TratamentoErro("O campo Entrelaçamento é obrigatório.");
                txt_ert_max_inc.Focus();
                return;
            }

            if (txt_rt3_med_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 3% é obrigatório.");
                txt_rt3_med_inc.Focus();
                return;
            }

            if (txt_rt3_tlr_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 3% é obrigatório.");
                txt_rt3_tlr_inc.Focus();
                return;
            }

            if (txt_rt3_min_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 3% é obrigatório.");
                txt_rt3_min_inc.Focus();
                return;
            }

            if (txt_rt3_max_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 3% é obrigatório.");
                txt_rt3_max_inc.Focus();
                return;
            }

            if (txt_rt5_med_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 5% é obrigatório.");
                txt_rt5_med_inc.Focus();
                return;
            }

            if (txt_rt5_tlr_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 5% é obrigatório.");
                txt_rt5_tlr_inc.Focus();
                return;
            }

            if (txt_rt5_min_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 5% é obrigatório.");
                txt_rt5_min_inc.Focus();
                return;
            }

            if (txt_rt5_max_inc.Text == "")
            {
                TratamentoErro("O campo Retenção 5% é obrigatório.");
                txt_rt5_max_inc.Focus();
                return;
            }
        }
        /*
        if (txt_pes_med_inc.Text == "")
        {
            TratamentoErro("O campo Peso é obrigatório.");
            txt_pes_med_inc.Focus();
            return;
        }

        if (txt_pes_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Peso é obrigatório.");
            txt_pes_tlr_inc.Focus();
            return;
        }

        if (txt_pes_min_inc.Text == "")
        {
            TratamentoErro("O campo Peso é obrigatório.");
            txt_pes_min_inc.Focus();
            return;
        }

        if (txt_pes_max_inc.Text == "")
        {
            TratamentoErro("O campo Peso é obrigatório.");
            txt_pes_max_inc.Focus();
            return;
        }

        if (txt_dmo_med_inc.Text == "")
        {
            TratamentoErro("O campo Diâmentro é obrigatório.");
            txt_dmo_med_inc.Focus();
            return;
        }

        if (txt_dmo_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Diâmentro é obrigatório.");
            txt_dmo_tlr_inc.Focus();
            return;
        }

        if (txt_dmo_min_inc.Text == "")
        {
            TratamentoErro("O campo Diâmentro é obrigatório.");
            txt_dmo_min_inc.Focus();
            return;
        }

        if (txt_dmo_max_inc.Text == "")
        {
            TratamentoErro("O campo Diâmentro é obrigatório.");
            txt_dmo_max_inc.Focus();
            return;
        }

        if (txt_dnd_med_inc.Text == "")
        {
            TratamentoErro("O campo Densidade é obrigatório.");
            txt_dnd_med_inc.Focus();
            return;
        }

        if (txt_dnd_tlr_inc.Text == "")
        {
            TratamentoErro("O campo Densidade é obrigatório.");
            txt_dnd_tlr_inc.Focus();
            return;
        }

        if (txt_dnd_min_inc.Text == "")
        {
            TratamentoErro("O campo Densidade é obrigatório.");
            txt_dnd_min_inc.Focus();
            return;
        }

        if (txt_dnd_max_inc.Text == "")
        {
            TratamentoErro("O campo Densidade é obrigatório.");
            txt_dnd_max_inc.Focus();
            return;
        }
        */

        if (cbo_sts_inc.Text == "")
		{
			TratamentoErro("O campo Status é obrigatório.");
			cbo_sts_inc.Focus();
			return;
		}

        /*
        //Não Recalcular Mínimo e Máximo, somente se foi alterado a Média
        //CalculaMinimoMaximo();

        double dtitMed = Convert.ToDouble(txt_tit_med_inc.Text);
        double dtncMed = Convert.ToDouble(txt_tnc_med_inc.Text);
        double daonMed = Convert.ToDouble(txt_aon_med_inc.Text);
        double denmMed = Convert.ToDouble(txt_enm_med_inc.Text);
        double deeeMed = 0;
        double dkkkMed = 0;
        double dbbbMed = 0;
        double dpueMed = 0;
        if (!string.IsNullOrEmpty(txt_eee_med_inc.Text))
        {
            deeeMed = Convert.ToDouble(txt_eee_med_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_med_inc.Text))
        {
            dkkkMed = Convert.ToDouble(txt_kkk_med_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_med_inc.Text))
        {
            dbbbMed = Convert.ToDouble(txt_bbb_med_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pue_med_inc.Text))
        {
            dpueMed = Convert.ToDouble(txt_pue_med_inc.Text);
        }
        double doleMed = Convert.ToDouble(txt_ole_med_inc.Text);
        double dtrqMed = Convert.ToDouble(txt_trq_med_inc.Text);
        double dertMed = 0;
        double drt3Med = 0;
        double drt5Med = 0;
        if (cbo_ert_id_inc.SelectedItem.Text != "0T")
        {
            dertMed = Convert.ToDouble(txt_ert_med_inc.Text);
            drt3Med = Convert.ToDouble(txt_rt3_med_inc.Text);
            drt5Med = Convert.ToDouble(txt_rt5_med_inc.Text);
        }
        double ddndMed = Convert.ToDouble(txt_dnd_med_inc.Text);

        //Padrão caso não encontre Limite
        double dtitMin = 0.025;
        double dtitMax = 0.050;
        double dtncMin = 0.15;
        double dtncMax = 0.25;
        double daonMin = 0.15;
        double daonMax = 0.3;
        double denmMin = 0.25;
        double denmMax = 0.5;
        double deeeMin = 0.25;
        double deeeMax = 0.5;
        double dkkkMin = 0.25;
        double dkkkMax = 0.5;
        double dbbbMin = 0.15;
        double dbbbMax = 0.3;
        double dpueMin = 0;
        double dpueMax = 0.8;
        double doleMin = 0.3;
        double doleMax = 0.8;
        double dtrqMin = 0.25;
        double dtrqMax = 0.5;
        double dertMin = 0.2;
        double dertMax = 0.3;
        double drt3Min = 0.2;
        double drt3Max = 0.4;
        double drt5Min = 0.2;
        double drt5Max = 0.4;
        double ddndMin = 0.05;
        double ddndMax = 0.1;

        EspecificacaoLimite EspecificacaoLimite = new EspecificacaoLimite();
        DataSet dsEspecificacaoLimite = EspecificacaoLimite.Consultar();

        if (dsEspecificacaoLimite.Tables[0].Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TIT_MIN"].ToString()))
            {
                dtitMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TIT_MIN"].ToString());
            }
            else
            {
                dtitMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TNC_MIN"].ToString()))
            {
                dtncMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TNC_MIN"].ToString());
            }
            else
            {
                dtncMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_AON_MIN"].ToString()))
            {
                daonMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_AON_MIN"].ToString());
            }
            else
            {
                daonMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_ENM_MIN"].ToString()))
            {
                denmMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_ENM_MIN"].ToString());
            }
            else
            {
                denmMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_EEE_MIN"].ToString()))
            {
                deeeMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_EEE_MIN"].ToString());
            }
            else
            {
                deeeMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_KKK_MIN"].ToString()))
            {
                dkkkMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_KKK_MIN"].ToString());
            }
            else
            {
                dkkkMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_BBB_MIN"].ToString()))
            {
                dbbbMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_BBB_MIN"].ToString());
            }
            else
            {
                dbbbMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_PUE_MIN"].ToString()))
            {
                dpueMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_PUE_MIN"].ToString());
            }
            else
            {
                dpueMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_OLE_MIN"].ToString()))
            {
                doleMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_OLE_MIN"].ToString());
            }
            else
            {
                doleMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TRQ_MIN"].ToString()))
            {
                dtrqMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_TRQ_MIN"].ToString());
            }
            else
            {
                dtrqMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_ERT_MIN"].ToString()))
            {
                dertMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_ERT_MIN"].ToString());
            }
            else
            {
                dertMin = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_RT3_MIN"].ToString()))
            {
                drt3Min = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_RT3_MIN"].ToString());
            }
            else
            {
                drt3Min = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_RT5_MIN"].ToString()))
            {
                drt5Min = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_RT5_MIN"].ToString());
            }
            else
            {
                drt5Min = 0;
            }
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_DND_MIN"].ToString()))
            {
                ddndMin = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_DND_MIN"].ToString());
            }
            else
            {
                ddndMin = 0;
            }
        }
        dsEspecificacaoLimite.Dispose();
        */

        /*
        //Não carregar Médias da ANE
        if (txt_lot_ref_inc.Text != "")
        {
			Especificacao ANE = new Especificacao();
            ANE.ANE_LOT = txt_lot_ref_inc.Text;
            DataSet dsANE = ANE.Consultar();

            if (dsANE.Tables[0].Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TIT_MED"].ToString()))
                {
                    dtitMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TIT_MED"].ToString());
                }
                else
                {
                    dtitMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TNC_MED"].ToString()))
                {
                    dtncMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TNC_MED"].ToString());
                }
                else
                {
                    dtncMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_AON_MED"].ToString()))
                {
                    daonMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_AON_MED"].ToString());
                }
                else
                {
                    daonMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ENM_MED"].ToString()))
                {
                    denmMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ENM_MED"].ToString());
                }
                else
                {
                    denmMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_EEE_MED"].ToString()))
                {
                    deeeMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_EEE_MED"].ToString());
                }
                else
                {
                    deeeMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_KKK_MED"].ToString()))
                {
                    dkkkMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_KKK_MED"].ToString());
                }
                else
                {
                    dkkkMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_BBB_MED"].ToString()))
                {
                    dbbbMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_BBB_MED"].ToString());
                }
                else
                {
                    dbbbMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_PUE_MED"].ToString()))
                {
                    dpueMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_PUE_MED"].ToString());
                }
                else
                {
                    dpueMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_OLE_MED"].ToString()))
                {
                    doleMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_OLE_MED"].ToString());
                }
                else
                {
                    doleMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString()))
                {
                    dtrqMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString());
                }
                else
                {
                    dtrqMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ERT_MED"].ToString()))
                {
                    dertMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ERT_MED"].ToString());
                }
                else
                {
                    dertMed = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT3_MED"].ToString()))
                {
                    drt3Med = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT3_MED"].ToString());
                }
                else
                {
                    drt3Med = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT5_MED"].ToString()))
                {
                    drt5Med = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT5_MED"].ToString());
                }
                else
                {
                    drt5Med = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_DND_MED"].ToString()))
                {
                    ddndMed = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_DND_MED"].ToString());
                }
                else
                {
                    ddndMed = 0;
                }

                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString()))
                {
                    dtitMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString());
                }
                else
                {
                    dtitMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString()))
                {
                    dtncMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString());
                }
                else
                {
                    dtncMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_AON_MIN"].ToString()))
                {
                    daonMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_AON_MIN"].ToString());
                }
                else
                {
                    daonMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString()))
                {
                    denmMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString());
                }
                else
                {
                    denmMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_EEE_MIN"].ToString()))
                {
                    deeeMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_EEE_MIN"].ToString());
                }
                else
                {
                    deeeMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_KKK_MIN"].ToString()))
                {
                    dkkkMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_KKK_MIN"].ToString());
                }
                else
                {
                    dkkkMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_BBB_MIN"].ToString()))
                {
                    dbbbMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_BBB_MIN"].ToString());
                }
                else
                {
                    dbbbMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_PUE_MIN"].ToString()))
                {
                    dpueMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_PUE_MIN"].ToString());
                }
                else
                {
                    dpueMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString()))
                {
                    doleMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString());
                }
                else
                {
                    doleMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString()))
                {
                    dtrqMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString());
                }
                else
                {
                    dtrqMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString()))
                {
                    dertMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString());
                }
                else
                {
                    dertMin = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT3_MIN"].ToString()))
                {
                    drt3Min = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT3_MIN"].ToString());
                }
                else
                {
                    drt3Min = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT5_MIN"].ToString()))
                {
                    drt5Min = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT5_MIN"].ToString());
                }
                else
                {
                    drt5Min = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_DND_MIN"].ToString()))
                {
                    ddndMin = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_DND_MIN"].ToString());
                }
                else
                {
                    ddndMin = 0;
                }

                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString()))
                {
                    dtitMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString());
                }
                else
                {
                    dtitMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString()))
                {
                    dtncMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString());
                }
                else
                {
                    dtncMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_AON_MAX"].ToString()))
                {
                    daonMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_AON_MAX"].ToString());
                }
                else
                {
                    daonMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString()))
                {
                    denmMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString());
                }
                else
                {
                    denmMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_EEE_MAX"].ToString()))
                {
                    deeeMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_EEE_MAX"].ToString());
                }
                else
                {
                    deeeMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_KKK_MAX"].ToString()))
                {
                    dkkkMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_KKK_MAX"].ToString());
                }
                else
                {
                    dkkkMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_BBB_MAX"].ToString()))
                {
                    dbbbMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_BBB_MAX"].ToString());
                }
                else
                {
                    dbbbMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_PUE_MAX"].ToString()))
                {
                    dpueMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_PUE_MAX"].ToString());
                }
                else
                {
                    dpueMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString()))
                {
                    doleMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString());
                }
                else
                {
                    doleMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString()))
                {
                    dtrqMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString());
                }
                else
                {
                    dtrqMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString()))
                {
                    dertMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString());
                }
                else
                {
                    dertMax = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT3_MAX"].ToString()))
                {
                    drt3Max = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT3_MAX"].ToString());
                }
                else
                {
                    drt3Max = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_RT5_MAX"].ToString()))
                {
                    drt5Max = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_RT5_MAX"].ToString());
                }
                else
                {   
                    drt5Max = 0;
                }
                if (!string.IsNullOrEmpty(dsANE.Tables[0].Rows[0]["ANE_DND_MAX"].ToString()))
                {
                    ddndMax = Convert.ToDouble(dsANE.Tables[0].Rows[0]["ANE_DND_MAX"].ToString());
                }
                else
                {
                    ddndMax = 0;
                }
            }
            dsANE.Dispose();
        }
        */

        /*
        //Não será mais consistido os valores pelos Limites de Especificação
        
        if (Convert.ToDouble(txt_tit_tlr_inc.Text) < (dtitMed * dtitMin) || Convert.ToDouble(txt_tit_tlr_inc.Text) > (dtitMed * dtitMax))
        {
            TratamentoErro("O campo Título Tolerância deve ser maior que " + (dtitMed * dtitMin).ToString("0.00") + " e menor que " + (dtitMed * dtitMax).ToString("0.00") + ".");
            txt_tit_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_tit_min_inc.Text) < (dtitMed - (dtitMed * dtitMax)) || Convert.ToDouble(txt_tit_min_inc.Text) > ((dtitMed * dtitMin) + (dtitMed - (dtitMed * dtitMax))))
        {
            TratamentoErro("O campo Título Mínimo deve ser maior que " + (dtitMed - (dtitMed * dtitMax)).ToString("0.00") + " e menor que " + ((dtitMed * dtitMin) + (dtitMed - (dtitMed * dtitMax))).ToString("0.00") + ".");
            txt_tit_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_tit_max_inc.Text) < ((dtitMed + (dtitMed * dtitMax)) - (dtitMed * dtitMin)) || Convert.ToDouble(txt_tit_max_inc.Text) > (dtitMed + (dtitMed * dtitMax)))
        {
            TratamentoErro("O campo Título Máximo deve ser maior que " + ((dtitMed + (dtitMed * dtitMax)) - (dtitMed * dtitMin)).ToString("0.00") + " e menor que " + (dtitMed + (dtitMed * dtitMax)).ToString("0.00") + ".");
            txt_tit_max_inc.Focus();
            return;
        }

        if (Convert.ToDouble(txt_tnc_tlr_inc.Text) < (dtncMed * dtncMin) || Convert.ToDouble(txt_tnc_tlr_inc.Text) > (dtncMed * dtncMax))
        {
            TratamentoErro("O campo Tenacidade Tolerância deve ser maior que " + (dtncMed * dtncMin).ToString("0.00") + " e menor que " + (dtncMed * dtncMax).ToString("0.00") + ".");
            txt_tnc_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_tnc_min_inc.Text) < (dtncMed - (dtncMed * dtncMax)) || Convert.ToDouble(txt_tnc_min_inc.Text) > ((dtncMed * dtncMin) + (dtncMed - (dtncMed * dtncMax))))
        {
            TratamentoErro("O campo Tenacidade Mínimo deve ser maior que " + (dtncMed - (dtncMed * dtncMax)).ToString("0.00") + " e menor que " + ((dtncMed * dtncMin) + (dtncMed - (dtncMed * dtncMax))).ToString("0.00") + ".");
            txt_tnc_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_tnc_max_inc.Text) < ((dtncMed + (dtncMed * dtncMax)) - (dtncMed * dtncMin)) || Convert.ToDouble(txt_tnc_max_inc.Text) > (dtncMed + (dtncMed * dtncMax)))
        {
            TratamentoErro("O campo Tenacidade Máximo deve ser maior que " + ((dtncMed + (dtncMed * dtncMax)) - (dtncMed * dtncMin)).ToString("0.00") + " e menor que " + (dtncMed + (dtncMed * dtncMax)).ToString("0.00") + ".");
            txt_tnc_max_inc.Focus();
            return;
        }

        if (Convert.ToDouble(txt_aon_tlr_inc.Text) < (daonMed * daonMin) || Convert.ToDouble(txt_aon_tlr_inc.Text) > (daonMed * daonMax))
        {
            TratamentoErro("O campo Alongamento Tolerância deve ser maior que " + (daonMed * daonMin).ToString("0.00") + " e menor que " + (daonMed * daonMax).ToString("0.00") + ".");
            txt_aon_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_aon_min_inc.Text) < (daonMed - (daonMed * daonMax)) || Convert.ToDouble(txt_aon_min_inc.Text) > ((daonMed * daonMin) + (daonMed - (daonMed * daonMax))))
        {
            TratamentoErro("O campo Alongamento Mínimo deve ser maior que " + (daonMed - (daonMed * daonMax)).ToString("0.00") + " e menor que " + ((daonMed * daonMin) + (daonMed - (daonMed * daonMax))).ToString("0.00") + ".");
            txt_aon_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_aon_max_inc.Text) < ((daonMed + (daonMed * daonMax)) - (daonMed * daonMin)) || Convert.ToDouble(txt_aon_max_inc.Text) > (daonMed + (daonMed * daonMax)))
        {
            TratamentoErro("O campo Alongamento Máximo deve ser maior que " + ((daonMed + (daonMed * daonMax)) - (daonMed * daonMin)).ToString("0.00") + " e menor que " + (daonMed + (daonMed * daonMax)).ToString("0.00") + ".");
            txt_aon_max_inc.Focus();
            return;
        }

        //Response.Write(txt_ole_min_inc.Text + ";" + doleMed + ";" + doleMed + ";" + doleMax + ";<br/>");
        //Response.Write(txt_ole_min_inc.Text + ";" + doleMed + ";" + doleMin + ";" + doleMed + ";" + doleMed + ";" + doleMax);
        if (Convert.ToDouble(txt_ole_tlr_inc.Text) < (doleMed * doleMin) || Convert.ToDouble(txt_ole_tlr_inc.Text) > (doleMed * doleMax))
        {
            TratamentoErro("O campo Óleo Tolerância deve ser maior que " + (doleMed * doleMin).ToString("0.00") + " e menor que " + (doleMed * doleMax).ToString("0.00") + ".");
            txt_ole_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_ole_min_inc.Text) < (doleMed - (doleMed * doleMax)) || Convert.ToDouble(txt_ole_min_inc.Text) > ((doleMed * doleMin) + (doleMed - (doleMed * doleMax))))
        {
            TratamentoErro("O campo Óleo Mínimo deve ser maior que " + (doleMed - (doleMed * doleMax)).ToString("0.00") + " e menor que " + ((doleMed * doleMin) + (doleMed - (doleMed * doleMax))).ToString("0.00") + ".");
            txt_ole_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_ole_max_inc.Text) < ((doleMed + (doleMed * doleMax)) - (doleMed * doleMin)) || Convert.ToDouble(txt_ole_max_inc.Text) > (doleMed + (doleMed * doleMax)))
        {
            TratamentoErro("O campo Óleo Máximo deve ser maior que " + ((doleMed + (doleMed * doleMax)) - (doleMed * doleMin)).ToString("0.00") + " e menor que " + (doleMed + (doleMed * doleMax)).ToString("0.00") + ".");
            txt_ole_max_inc.Focus();
            return;
        }

        if (Convert.ToDouble(txt_enm_tlr_inc.Text) < (denmMed * denmMin) || Convert.ToDouble(txt_enm_tlr_inc.Text) > (denmMed * denmMax))
        {
            TratamentoErro("O campo Encolhimento Tolerância deve ser maior que " + (denmMed * denmMin).ToString("0.00") + " e menor que " + (denmMed * denmMax).ToString("0.00") + ".");
            txt_enm_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_enm_min_inc.Text) < (denmMed - (denmMed * denmMax)) || Convert.ToDouble(txt_enm_min_inc.Text) > ((denmMed * denmMin) + (denmMed - (denmMed * denmMax))))
        {
            TratamentoErro("O campo Encolhimento Mínimo deve ser maior que " + (denmMed - (denmMed * denmMax)).ToString("0.00") + " e menor que " + ((denmMed * denmMin) + (denmMed - (denmMed * denmMax))).ToString("0.00") + ".");
            txt_enm_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_enm_max_inc.Text) < ((denmMed + (denmMed * denmMax)) - (denmMed * denmMin)) || Convert.ToDouble(txt_enm_max_inc.Text) > (denmMed + (denmMed * denmMax)))
        {
            TratamentoErro("O campo Encolhimento Máximo deve ser maior que " + ((denmMed + (denmMed * denmMax)) - (denmMed * denmMin)).ToString("0.00") + " e menor que " + (denmMed + (denmMed * denmMax)).ToString("0.00") + ".");
            txt_enm_max_inc.Focus();
            return;
        }

        if (!string.IsNullOrEmpty(txt_eee_med_inc.Text))
        {
            if (Convert.ToDouble(txt_eee_tlr_inc.Text) < (deeeMed * deeeMin) || Convert.ToDouble(txt_eee_tlr_inc.Text) > (deeeMed * deeeMax))
            {
                TratamentoErro("O campo E (%) Tolerância deve ser maior que " + (deeeMed * deeeMin).ToString("0.00") + " e menor que " + (deeeMed * deeeMax).ToString("0.00") + ".");
                txt_eee_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_eee_min_inc.Text) < (deeeMed - (deeeMed * deeeMax)) || Convert.ToDouble(txt_eee_min_inc.Text) > ((deeeMed * deeeMin) + (deeeMed - (deeeMed * deeeMax))))
            {
                TratamentoErro("O campo E (%) Mínimo deve ser maior que " + (deeeMed - (deeeMed * deeeMax)).ToString("0.00") + " e menor que " + ((deeeMed * deeeMin) + (deeeMed - (deeeMed * deeeMax))).ToString("0.00") + ".");
                txt_eee_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_eee_max_inc.Text) < ((deeeMed + (deeeMed * deeeMax)) - (deeeMed * deeeMin)) || Convert.ToDouble(txt_eee_max_inc.Text) > (deeeMed + (deeeMed * deeeMax)))
            {
                TratamentoErro("O campo E (%) Máximo deve ser maior que " + ((deeeMed + (deeeMed * deeeMax)) - (deeeMed * deeeMin)).ToString("0.00") + " e menor que " + (deeeMed + (deeeMed * deeeMax)).ToString("0.00") + ".");
                txt_eee_max_inc.Focus();
                return;
            }
        }

        if (!string.IsNullOrEmpty(txt_kkk_med_inc.Text))
        {
            if (Convert.ToDouble(txt_kkk_tlr_inc.Text) < (dkkkMed * dkkkMin) || Convert.ToDouble(txt_kkk_tlr_inc.Text) > (dkkkMed * dkkkMax))
            {
                TratamentoErro("O campo K (%) Tolerância deve ser maior que " + (dkkkMed * dkkkMin).ToString("0.00") + " e menor que " + (dkkkMed * dkkkMax).ToString("0.00") + ".");
                txt_kkk_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_kkk_min_inc.Text) < (dkkkMed - (dkkkMed * dkkkMax)) || Convert.ToDouble(txt_kkk_min_inc.Text) > ((dkkkMed * dkkkMin) + (dkkkMed - (dkkkMed * dkkkMax))))
            {
                TratamentoErro("O campo K (%) Mínimo deve ser maior que " + (dkkkMed - (dkkkMed * dkkkMax)).ToString("0.00") + " e menor que " + ((dkkkMed * dkkkMin) + (dkkkMed - (dkkkMed * dkkkMax))).ToString("0.00") + ".");
                txt_kkk_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_kkk_max_inc.Text) < ((dkkkMed + (dkkkMed * dkkkMax)) - (dkkkMed * dkkkMin)) || Convert.ToDouble(txt_kkk_max_inc.Text) > (dkkkMed + (dkkkMed * dkkkMax)))
            {
                TratamentoErro("O campo K (%) Máximo deve ser maior que " + ((dkkkMed + (dkkkMed * dkkkMax)) - (dkkkMed * dkkkMin)).ToString("0.00") + " e menor que " + (dkkkMed + (dkkkMed * dkkkMax)).ToString("0.00") + ".");
                txt_kkk_max_inc.Focus();
                return;
            }
        }

        if (!string.IsNullOrEmpty(txt_bbb_med_inc.Text))
        {
            if (Convert.ToDouble(txt_bbb_tlr_inc.Text) < (dbbbMed * dbbbMin) || Convert.ToDouble(txt_bbb_tlr_inc.Text) > (dbbbMed * dbbbMax))
            {
                TratamentoErro("O campo B (%) Tolerância deve ser maior que " + (dbbbMed * dbbbMin).ToString("0.00") + " e menor que " + (dbbbMed * dbbbMax).ToString("0.00") + ".");
                txt_bbb_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_bbb_min_inc.Text) < (dbbbMed - (dbbbMed * dbbbMax)) || Convert.ToDouble(txt_bbb_min_inc.Text) > ((dbbbMed * dbbbMin) + (dbbbMed - (dbbbMed * dbbbMax))))
            {
                TratamentoErro("O campo B (%) Mínimo deve ser maior que " + (dbbbMed - (dbbbMed * dbbbMax)).ToString("0.00") + " e menor que " + ((dbbbMed * dbbbMin) + (dbbbMed - (dbbbMed * dbbbMax))).ToString("0.00") + ".");
                txt_bbb_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_bbb_max_inc.Text) < ((dbbbMed + (dbbbMed * dbbbMax)) - (dbbbMed * dbbbMin)) || Convert.ToDouble(txt_bbb_max_inc.Text) > (dbbbMed + (dbbbMed * dbbbMax)))
            {
                TratamentoErro("O campo B (%) Máximo deve ser maior que " + ((dbbbMed + (dbbbMed * dbbbMax)) - (dbbbMed * dbbbMin)).ToString("0.00") + " e menor que " + (dbbbMed + (dbbbMed * dbbbMax)).ToString("0.00") + ".");
                txt_bbb_max_inc.Focus();
                return;
            }
        }

        //PUE somente limite máximo
        if (!string.IsNullOrEmpty(txt_pue_med_inc.Text))
        {
            if (Convert.ToDouble(txt_pue_tlr_inc.Text) > (dpueMed * dpueMax))
            {
                TratamentoErro("O campo PUE Tolerância deve ser menor que " + (dpueMed * dpueMax).ToString("0.00") + ".");
                txt_pue_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_pue_min_inc.Text) > ((dpueMed * dpueMin) + (dpueMed - (dpueMed * dpueMax))))
            {
                TratamentoErro("O campo PUE Mínimo deve ser menor que " + ((dpueMed * dpueMin) + (dpueMed - (dpueMed * dpueMax))).ToString("0.00") + ".");
                txt_pue_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_pue_max_inc.Text) > (dpueMed + (dpueMed * dpueMax)))
            {
                TratamentoErro("O campo PUE Máximo deve ser menor que " + (dpueMed + (dpueMed * dpueMax)).ToString("0.00") + ".");
                txt_pue_max_inc.Focus();
                return;
            }
        }

        if (Convert.ToDouble(txt_trq_tlr_inc.Text) < (dtrqMed * dtrqMin) || Convert.ToDouble(txt_trq_tlr_inc.Text) > (dtrqMed * dtrqMax))
        {
            TratamentoErro("O campo Torque Tolerância deve ser maior que " + (dtrqMed * dtrqMin).ToString("0.00") + " e menor que " + (dtrqMed * dtrqMax).ToString("0.00") + ".");
            txt_trq_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_trq_min_inc.Text) < (dtrqMed - (dtrqMed * dtrqMax)) || Convert.ToDouble(txt_trq_min_inc.Text) > ((dtrqMed * dtrqMin) + (dtrqMed - (dtrqMed * dtrqMax))))
        {
            TratamentoErro("O campo Torque Mínimo deve ser maior que " + (dtrqMed - (dtrqMed * dtrqMax)).ToString("0.00") + " e menor que " + ((dtrqMed * dtrqMin) + (dtrqMed - (dtrqMed * dtrqMax))).ToString("0.00") + ".");
            txt_trq_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_trq_max_inc.Text) < ((dtrqMed + (dtrqMed * dtrqMax)) - (dtrqMed * dtrqMin)) || Convert.ToDouble(txt_trq_max_inc.Text) > (dtrqMed + (dtrqMed * dtrqMax)))
        {
            TratamentoErro("O campo Torque Máximo deve ser maior que " + ((dtrqMed + (dtrqMed * dtrqMax)) - (dtrqMed * dtrqMin)).ToString("0.00") + " e menor que " + (dtrqMed + (dtrqMed * dtrqMax)).ToString("0.00") + ".");
            txt_trq_max_inc.Focus();
            return;
        }

        if (cbo_ert_id_inc.SelectedItem.Text != "0T")
        {
            if (Convert.ToDouble(txt_ert_tlr_inc.Text) < (dertMed * dertMin) || Convert.ToDouble(txt_ert_tlr_inc.Text) > (dertMed * dertMax))
            {
                TratamentoErro("O campo Entrelaçamento Tolerância deve ser maior que " + (dertMed * dertMin).ToString("0.00") + " e menor que " + (dertMed * dertMax).ToString("0.00") + ".");
                txt_ert_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_ert_min_inc.Text) < (dertMed - (dertMed * dertMax)) || Convert.ToDouble(txt_ert_min_inc.Text) > ((dertMed * dertMin) + (dertMed - (dertMed * dertMax))))
            {
                TratamentoErro("O campo Entrelaçamento Mínimo deve ser maior que " + (dertMed - (dertMed * dertMax)).ToString("0.00") + " e menor que " + ((dertMed * dertMin) + (dertMed - (dertMed * dertMax))).ToString("0.00") + ".");
                txt_ert_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_ert_max_inc.Text) < ((dertMed + (dertMed * dertMax)) - (dertMed * dertMin)) || Convert.ToDouble(txt_ert_max_inc.Text) > (dertMed + (dertMed * dertMax)))
            {
                TratamentoErro("O campo Entrelaçamento Máximo deve ser maior que " + ((dertMed + (dertMed * dertMax)) - (dertMed * dertMin)).ToString("0.00") + " e menor que " + (dertMed + (dertMed * dertMax)).ToString("0.00") + ".");
                txt_ert_max_inc.Focus();
                return;
            }

            if (Convert.ToDouble(txt_rt3_tlr_inc.Text) < (drt3Med * drt3Min) || Convert.ToDouble(txt_rt3_tlr_inc.Text) > (drt3Med * drt3Max))
            {
                TratamentoErro("O campo Retenção 3% Tolerância deve ser maior que " + (drt3Med * drt3Min).ToString("0.00") + " e menor que " + (drt3Med * drt3Max).ToString("0.00") + ".");
                txt_rt3_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_rt3_min_inc.Text) < (drt3Med - (drt3Med * drt3Max)) || Convert.ToDouble(txt_rt3_min_inc.Text) > ((drt3Med * drt3Min) + (drt3Med - (drt3Med * drt3Max))))
            {
                TratamentoErro("O campo Retenção 3% Mínimo deve ser maior que " + (drt3Med - (drt3Med * drt3Max)).ToString("0.00") + " e menor que " + ((drt3Med * drt3Min) + (drt3Med - (drt3Med * drt3Max))).ToString("0.00") + ".");
                txt_rt3_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_rt3_max_inc.Text) < ((drt3Med + (drt3Med * drt3Max)) - (drt3Med * drt3Min)) || Convert.ToDouble(txt_rt3_max_inc.Text) > (drt3Med + (drt3Med * drt3Max)))
            {
                TratamentoErro("O campo Retenção 3% Máximo deve ser maior que " + ((drt3Med + (drt3Med * drt3Max)) - (drt3Med * drt3Min)).ToString("0.00") + " e menor que " + (drt3Med + (drt3Med * drt3Max)).ToString("0.00") + ".");
                txt_rt3_max_inc.Focus();
                return;
            }

            if (Convert.ToDouble(txt_rt5_tlr_inc.Text) < (drt5Med * drt5Min) || Convert.ToDouble(txt_rt5_tlr_inc.Text) > (drt5Med * drt5Max))
            {
                TratamentoErro("O campo Renteção 5% Tolerância deve ser maior que " + (drt5Med * drt5Min).ToString("0.00") + " e menor que " + (drt5Med * drt5Max).ToString("0.00") + ".");
                txt_rt5_tlr_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_rt5_min_inc.Text) < (drt5Med - (drt5Med * drt5Max)) || Convert.ToDouble(txt_rt5_min_inc.Text) > ((drt5Med * drt5Min) + (drt5Med - (drt5Med * drt5Max))))
            {
                TratamentoErro("O campo Renteção 5% Mínimo deve ser maior que " + (drt5Med - (drt5Med * drt5Max)).ToString("0.00") + " e menor que " + ((drt5Med * drt5Min) + (drt5Med - (drt5Med * drt5Max))).ToString("0.00") + ".");
                txt_rt5_min_inc.Focus();
                return;
            }
            if (Convert.ToDouble(txt_rt5_max_inc.Text) < ((drt5Med + (drt5Med * drt5Max)) - (drt5Med * drt5Min)) || Convert.ToDouble(txt_rt5_max_inc.Text) > (drt5Med + (drt5Med * drt5Max)))
            {
                TratamentoErro("O campo Renteção 5% Máximo deve ser maior que " + ((drt5Med + (drt5Med * drt5Max)) - (drt5Med * drt5Min)).ToString("0.00") + " e menor que " + (drt5Med + (drt5Med * drt5Max)).ToString("0.00") + ".");
                txt_rt5_max_inc.Focus();
                return;
            }
        }

        if (Convert.ToDouble(txt_dnd_tlr_inc.Text) < (ddndMed * ddndMin) || Convert.ToDouble(txt_dnd_tlr_inc.Text) > (ddndMed * ddndMax))
        {
            TratamentoErro("O campo Densidade Tolerância deve ser maior que " + (ddndMed * ddndMin).ToString("0.00") + " e menor que " + (ddndMed * ddndMax).ToString("0.00") + ".");
            txt_dnd_tlr_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_dnd_min_inc.Text) < (ddndMed - (ddndMed * ddndMax)) || Convert.ToDouble(txt_dnd_min_inc.Text) > ((ddndMed * ddndMin) + (ddndMed - (ddndMed * ddndMax))))
        {
            TratamentoErro("O campo Densidade Mínimo deve ser maior que " + (ddndMed - (ddndMed * ddndMax)).ToString("0.00") + " e menor que " + ((ddndMed * ddndMin) + (ddndMed - (ddndMed * ddndMax))).ToString("0.00") + ".");
            txt_dnd_min_inc.Focus();
            return;
        }
        if (Convert.ToDouble(txt_dnd_max_inc.Text) < ((ddndMed + (ddndMed * ddndMax)) - (ddndMed * ddndMin)) || Convert.ToDouble(txt_dnd_max_inc.Text) > (ddndMed + (ddndMed * ddndMax)))
        {
            TratamentoErro("O campo Densidade Máximo deve ser maior que " + ((ddndMed + (ddndMed * ddndMax)) - (ddndMed * ddndMin)).ToString("0.00") + " e menor que " + (ddndMed + (ddndMed * ddndMax)).ToString("0.00") + ".");
            txt_dnd_max_inc.Focus();
            return;
        }
        */

        Especificacao Especificacao = new Especificacao();
		if (txt_dat_inc.Text != "")
		{
			Especificacao.ANE_DAT = Convert.ToDateTime(txt_dat_inc.Text);
		}
        Especificacao.ANE_LOT = txt_lot_inc.Text;
        Especificacao.ANE_LOT_REF = txt_lot_ref_inc.Text;
        if (cbo_tit_poy_id_inc.Text != "")
		{
			Especificacao.ANE_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
		}
		if (cbo_aps_id_inc.Text != "")
		{
			Especificacao.ANE_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
		}
		if (cbo_maq_tip_id_inc.Text != "")
		{
			Especificacao.ANE_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
		}
		if (cbo_ert_id_inc.Text != "")
		{
			Especificacao.ANE_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
		}
        if (txt_tit_con_inc.Text != "")
		{
    		Especificacao.ANE_TIT_CON = Convert.ToDouble(txt_tit_con_inc.Text);
		}
        if (txt_tit_med_inc.Text != "")
		{
		    Especificacao.ANE_TIT_MED = Convert.ToDouble(txt_tit_med_inc.Text);
		}
        if (txt_tnc_med_inc.Text != "")
		{
		    Especificacao.ANE_TNC_MED = Convert.ToDouble(txt_tnc_med_inc.Text);
		}
        if (txt_aon_med_inc.Text != "")
		{
		    Especificacao.ANE_AON_MED = Convert.ToDouble(txt_aon_med_inc.Text);
		}
        if (txt_enm_med_inc.Text != "")
		{
		    Especificacao.ANE_ENM_MED = Convert.ToDouble(txt_enm_med_inc.Text);
		}
        if (txt_eee_med_inc.Text != "")
		{
		    Especificacao.ANE_EEE_MED = Convert.ToDouble(txt_eee_med_inc.Text);
		}
        if (txt_kkk_med_inc.Text != "")
		{
		    Especificacao.ANE_KKK_MED = Convert.ToDouble(txt_kkk_med_inc.Text);
		}
        if (txt_bbb_med_inc.Text != "")
		{
		    Especificacao.ANE_BBB_MED = Convert.ToDouble(txt_bbb_med_inc.Text);
		}
        if (txt_pue_med_inc.Text != "")
		{
		    Especificacao.ANE_PUE_MED = Convert.ToDouble(txt_pue_med_inc.Text);
		}
        if (txt_ole_med_inc.Text != "")
		{
		    Especificacao.ANE_OLE_MED = Convert.ToDouble(txt_ole_med_inc.Text);
		}
        if (txt_trq_med_inc.Text != "")
		{
		    Especificacao.ANE_TRQ_MED = Convert.ToDouble(txt_trq_med_inc.Text);
		}
        if (txt_ert_med_inc.Text != "")
		{
		    Especificacao.ANE_ERT_MED = Convert.ToDouble(txt_ert_med_inc.Text);
		}
        if (txt_rt3_med_inc.Text != "")
		{
		    Especificacao.ANE_RT3_MED = Convert.ToDouble(txt_rt3_med_inc.Text);
		}
        if (txt_rt5_med_inc.Text != "")
		{
		    Especificacao.ANE_RT5_MED = Convert.ToDouble(txt_rt5_med_inc.Text);
		}
        /*
        if (txt_pes_med_inc.Text != "")
		{
		    Especificacao.ANE_PES_MED = Convert.ToDouble(txt_pes_med_inc.Text);
		}
        if (txt_dmo_med_inc.Text != "")
		{
		    Especificacao.ANE_DMO_MED = Convert.ToDouble(txt_dmo_med_inc.Text);
		}
        */
        if (txt_dnd_med_inc.Text != "")
		{
		    Especificacao.ANE_DND_MED = Convert.ToDouble(txt_dnd_med_inc.Text);
		}
        if (txt_tit_tlr_inc.Text != "")
        {
            Especificacao.ANE_TIT_TLR = Convert.ToDouble(txt_tit_tlr_inc.Text);
        }
        if (txt_tnc_tlr_inc.Text != "")
        {
            Especificacao.ANE_TNC_TLR = Convert.ToDouble(txt_tnc_tlr_inc.Text);
        }
        if (txt_aon_tlr_inc.Text != "")
        {
            Especificacao.ANE_AON_TLR = Convert.ToDouble(txt_aon_tlr_inc.Text);
        }
        if (txt_enm_tlr_inc.Text != "")
        {
            Especificacao.ANE_ENM_TLR = Convert.ToDouble(txt_enm_tlr_inc.Text);
        }
        if (txt_eee_tlr_inc.Text != "")
        {
            Especificacao.ANE_EEE_TLR = Convert.ToDouble(txt_eee_tlr_inc.Text);
        }
        if (txt_kkk_tlr_inc.Text != "")
        {
            Especificacao.ANE_KKK_TLR = Convert.ToDouble(txt_kkk_tlr_inc.Text);
        }
        if (txt_bbb_tlr_inc.Text != "")
        {
            Especificacao.ANE_BBB_TLR = Convert.ToDouble(txt_bbb_tlr_inc.Text);
        }
        if (txt_pue_tlr_inc.Text != "")
        {
            Especificacao.ANE_PUE_TLR = Convert.ToDouble(txt_pue_tlr_inc.Text);
        }
        if (txt_ole_tlr_inc.Text != "")
        {
            Especificacao.ANE_OLE_TLR = Convert.ToDouble(txt_ole_tlr_inc.Text);
        }
        if (txt_trq_tlr_inc.Text != "")
        {
            Especificacao.ANE_TRQ_TLR = Convert.ToDouble(txt_trq_tlr_inc.Text);
        }
        if (txt_ert_tlr_inc.Text != "")
        {
            Especificacao.ANE_ERT_TLR = Convert.ToDouble(txt_ert_tlr_inc.Text);
        }
        if (txt_rt3_tlr_inc.Text != "")
        {
            Especificacao.ANE_RT3_TLR = Convert.ToDouble(txt_rt3_tlr_inc.Text);
        }
        if (txt_rt5_tlr_inc.Text != "")
        {
            Especificacao.ANE_RT5_TLR = Convert.ToDouble(txt_rt5_tlr_inc.Text);
        }
        /*
        if (txt_pes_tlr_inc.Text != "")
        {
            Especificacao.ANE_PES_TLR = Convert.ToDouble(txt_pes_tlr_inc.Text);
        }
        if (txt_dmo_tlr_inc.Text != "")
        {
            Especificacao.ANE_DMO_TLR = Convert.ToDouble(txt_dmo_tlr_inc.Text);
        }
        */
        if (txt_dnd_tlr_inc.Text != "")
        {
            Especificacao.ANE_DND_TLR = Convert.ToDouble(txt_dnd_tlr_inc.Text);
        }
        if (txt_tit_min_inc.Text != "")
        {
            Especificacao.ANE_TIT_MIN = Convert.ToDouble(txt_tit_min_inc.Text);
        }
        if (txt_tnc_min_inc.Text != "")
        {
            Especificacao.ANE_TNC_MIN = Convert.ToDouble(txt_tnc_min_inc.Text);
        }
        if (txt_aon_min_inc.Text != "")
        {
            Especificacao.ANE_AON_MIN = Convert.ToDouble(txt_aon_min_inc.Text);
        }
        if (txt_enm_min_inc.Text != "")
        {
            Especificacao.ANE_ENM_MIN = Convert.ToDouble(txt_enm_min_inc.Text);
        }
        if (txt_eee_min_inc.Text != "")
        {
            Especificacao.ANE_EEE_MIN = Convert.ToDouble(txt_eee_min_inc.Text);
        }
        if (txt_kkk_min_inc.Text != "")
        {
            Especificacao.ANE_KKK_MIN = Convert.ToDouble(txt_kkk_min_inc.Text);
        }
        if (txt_bbb_min_inc.Text != "")
        {
            Especificacao.ANE_BBB_MIN = Convert.ToDouble(txt_bbb_min_inc.Text);
        }
        if (txt_pue_min_inc.Text != "")
        {
            Especificacao.ANE_PUE_MIN = Convert.ToDouble(txt_pue_min_inc.Text);
        }
        if (txt_ole_min_inc.Text != "")
        {
            Especificacao.ANE_OLE_MIN = Convert.ToDouble(txt_ole_min_inc.Text);
        }
        if (txt_trq_min_inc.Text != "")
        {
            Especificacao.ANE_TRQ_MIN = Convert.ToDouble(txt_trq_min_inc.Text);
        }
        if (txt_ert_min_inc.Text != "")
        {
            Especificacao.ANE_ERT_MIN = Convert.ToDouble(txt_ert_min_inc.Text);
        }
        if (txt_rt3_min_inc.Text != "")
        {
            Especificacao.ANE_RT3_MIN = Convert.ToDouble(txt_rt3_min_inc.Text);
        }
        if (txt_rt5_min_inc.Text != "")
        {
            Especificacao.ANE_RT5_MIN = Convert.ToDouble(txt_rt5_min_inc.Text);
        }
        /*
        if (txt_pes_min_inc.Text != "")
        {
            Especificacao.ANE_PES_MIN = Convert.ToDouble(txt_pes_min_inc.Text);
        }
        if (txt_dmo_min_inc.Text != "")
        {
            Especificacao.ANE_DMO_MIN = Convert.ToDouble(txt_dmo_min_inc.Text);
        }
        */
        if (txt_dnd_min_inc.Text != "")
        {
            Especificacao.ANE_DND_MIN = Convert.ToDouble(txt_dnd_min_inc.Text);
        }
        if (txt_tit_max_inc.Text != "")
		{
		    Especificacao.ANE_TIT_MAX = Convert.ToDouble(txt_tit_max_inc.Text);
		}
        if (txt_tnc_max_inc.Text != "")
		{
		    Especificacao.ANE_TNC_MAX = Convert.ToDouble(txt_tnc_max_inc.Text);
		}
        if (txt_aon_max_inc.Text != "")
		{
		    Especificacao.ANE_AON_MAX = Convert.ToDouble(txt_aon_max_inc.Text);
		}
        if (txt_enm_max_inc.Text != "")
		{
		    Especificacao.ANE_ENM_MAX = Convert.ToDouble(txt_enm_max_inc.Text);
		}
        if (txt_eee_max_inc.Text != "")
		{
		    Especificacao.ANE_EEE_MAX = Convert.ToDouble(txt_eee_max_inc.Text);
		}
        if (txt_kkk_max_inc.Text != "")
		{
		    Especificacao.ANE_KKK_MAX = Convert.ToDouble(txt_kkk_max_inc.Text);
		}
        if (txt_bbb_max_inc.Text != "")
		{
		    Especificacao.ANE_BBB_MAX = Convert.ToDouble(txt_bbb_max_inc.Text);
		}
        if (txt_pue_max_inc.Text != "")
		{
		    Especificacao.ANE_PUE_MAX = Convert.ToDouble(txt_pue_max_inc.Text);
		}
        if (txt_ole_max_inc.Text != "")
		{
		    Especificacao.ANE_OLE_MAX = Convert.ToDouble(txt_ole_max_inc.Text);
		}
        if (txt_trq_max_inc.Text != "")
		{
		    Especificacao.ANE_TRQ_MAX = Convert.ToDouble(txt_trq_max_inc.Text);
		}
        if (txt_ert_max_inc.Text != "")
		{
		    Especificacao.ANE_ERT_MAX = Convert.ToDouble(txt_ert_max_inc.Text);
		}
        if (txt_rt3_max_inc.Text != "")
		{
		    Especificacao.ANE_RT3_MAX = Convert.ToDouble(txt_rt3_max_inc.Text);
		}
        if (txt_rt5_max_inc.Text != "")
		{
		    Especificacao.ANE_RT5_MAX = Convert.ToDouble(txt_rt5_max_inc.Text);
		}
        /*
        if (txt_pes_max_inc.Text != "")
		{
		    Especificacao.ANE_PES_MAX = Convert.ToDouble(txt_pes_max_inc.Text);
		}
        if (txt_dmo_max_inc.Text != "")
		{
		    Especificacao.ANE_DMO_MAX = Convert.ToDouble(txt_dmo_max_inc.Text);
		}
        */
        if (txt_dnd_max_inc.Text != "")
		{
		    Especificacao.ANE_DND_MAX = Convert.ToDouble(txt_dnd_max_inc.Text);
		}
		Especificacao.ANE_OBS = txt_obs_inc.Text;
		if (cbo_sts_inc.Text != "")
		{
			Especificacao.ANE_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
		}

        if (!string.IsNullOrEmpty(rowId.Value))
		{
			Especificacao.ANE_ID = Convert.ToInt32(rowId.Value);
			Especificacao.ANE_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = Especificacao.Alterar();
			if (sMsg != "")
			{
				Response.Redirect("Erro.aspx?Erro="+sMsg);
			}
			else
			{
				TratamentoErro("Especificação alterada com sucesso.");
			}
		}
		else
		{
			Especificacao ANE = new Especificacao();
			//Verificar se já não existe um cadastro consultando o: ANE_DES 
			ANE.ANE_LOT = txt_lot_inc.Text;
			DataSet dsANE = ANE.Consultar();
			if (dsANE.Tables[0].Rows.Count > 0)
			{
				TratamentoErro("Essa Especificação já está cadastrada.");
				txt_dat_inc.Focus();

				return;
			}
			Especificacao.ANE_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = Especificacao.Inserir();

			if (sMsg.Substring(0, 1) == "E")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				rowId.Value = sMsg;

				TratamentoErro("Especificação inserida com sucesso.");
				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);

                EnviaEmail();
			}
			dsANE.Dispose();
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
		if (gvEspecificacao.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
			// Sem a opção de Salvar
			// Response.Cache.SetCacheability(HttpCacheability.NoCache);
			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvEspecificacao.AllowSorting = false;
			gvEspecificacao.AllowPaging = false;
			//gvEspecificacao.DataBind();

			// Deixar cabeçalho em branco/preto, sem links e imagens
			for (int i = 0; i < gvEspecificacao.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvEspecificacao.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvEspecificacao.RenderControl(htmlWrite);

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
		if (gvEspecificacao.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/vnd.ms-excel";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
			//Sem a opção de Salvar
			//Response.Cache.SetCacheability(HttpCacheability.NoCache);

			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvEspecificacao.AllowSorting = false;
			gvEspecificacao.AllowPaging = false;

			// Deixar cabeçalho em branco/preto, sem links e imagens

			for (int i = 0; i < gvEspecificacao.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvEspecificacao.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvEspecificacao.RenderControl(htmlWrite);

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

    protected void CarregaLote(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
        {
			Especificacao Especificacao = new Especificacao();
            Especificacao.ANE_LOT = txt_lot_ref_inc.Text;
			DataSet dsEspecificacao = Especificacao.Consultar();
            if (dsEspecificacao.Tables[0].Rows.Count > 0)
            {
                cbo_tit_poy_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_POY_ID"].ToString();
                cbo_aps_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_MAQ_TIP_ID"].ToString();
                cbo_ert_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_ID"].ToString();
                txt_tit_con_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_CON"].ToString();
                txt_tit_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MED"].ToString();
                txt_tnc_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MED"].ToString();
                txt_aon_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MED"].ToString();
                txt_enm_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MED"].ToString();
                txt_eee_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MED"].ToString();
                txt_kkk_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MED"].ToString();
                txt_bbb_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MED"].ToString();
                txt_pue_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MED"].ToString();
                txt_ole_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MED"].ToString();
                txt_trq_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString();
                txt_ert_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MED"].ToString();
                txt_rt3_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MED"].ToString();
                txt_rt5_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MED"].ToString();
                /*
                txt_pes_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MED"].ToString();
                txt_dmo_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MED"].ToString();
                */
                txt_dnd_med_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MED"].ToString();

                txt_tit_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_TLR"].ToString();
                txt_tnc_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_TLR"].ToString();
                txt_aon_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_TLR"].ToString();
                txt_enm_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_TLR"].ToString();
                txt_eee_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_TLR"].ToString();
                txt_kkk_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_TLR"].ToString();
                txt_bbb_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_TLR"].ToString();
                txt_pue_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_TLR"].ToString();
                txt_ole_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_TLR"].ToString();
                txt_trq_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_TLR"].ToString();
                txt_ert_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_TLR"].ToString();
                txt_rt3_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_TLR"].ToString();
                txt_rt5_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_TLR"].ToString();
                /*
                txt_pes_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_TLR"].ToString();
                txt_dmo_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_TLR"].ToString();
                */
                txt_dnd_tlr_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_TLR"].ToString();

                txt_tit_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString();
                txt_tnc_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString();
                txt_aon_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MIN"].ToString();
                txt_enm_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString();
                txt_eee_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MIN"].ToString();
                txt_kkk_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MIN"].ToString();
                txt_bbb_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MIN"].ToString();
                txt_pue_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MIN"].ToString();
                txt_ole_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString();
                txt_trq_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString();
                txt_ert_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString();
                txt_rt3_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MIN"].ToString();
                txt_rt5_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MIN"].ToString();
                /*
                txt_pes_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MIN"].ToString();
                txt_dmo_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MIN"].ToString();
                */
                txt_dnd_min_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MIN"].ToString();

                txt_tit_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString();
                txt_tnc_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString();
                txt_aon_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MAX"].ToString();
                txt_enm_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString();
                txt_eee_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_EEE_MAX"].ToString();
                txt_kkk_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_KKK_MAX"].ToString();
                txt_bbb_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_BBB_MAX"].ToString();
                txt_pue_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PUE_MAX"].ToString();
                txt_ole_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString();
                txt_trq_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString();
                txt_ert_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString();
                txt_rt3_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT3_MAX"].ToString();
                txt_rt5_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_RT5_MAX"].ToString();
                /*
                txt_pes_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_PES_MAX"].ToString();
                txt_dmo_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DMO_MAX"].ToString();
                */
                txt_dnd_max_inc.Text = dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MAX"].ToString();
            }
            dsEspecificacao.Dispose();
            Dispose();

            cbo_tit_poy_id_inc.Focus();
        }
    }

    protected void CalculaToleranciaMinimoMaximo(object sender, EventArgs e)
    {

                
        TextBox c = (TextBox)sender;

        string sAne = "";
        sAne = c.ID.ToString().Substring(4, 3);

        double dAneLmt = 0;
        EspecificacaoLimite EspecificacaoLimite = new EspecificacaoLimite();
        DataSet dsEspecificacaoLimite = EspecificacaoLimite.Consultar();

        if (dsEspecificacaoLimite.Tables[0].Rows.Count > 0)
        {
            if (!string.IsNullOrEmpty(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_" + sAne + "_MIN"].ToString()))
            {
                dAneLmt = Convert.ToDouble(dsEspecificacaoLimite.Tables[0].Rows[0]["ANE_LMT_" + sAne + "_MIN"].ToString());
            }
        }
        dsEspecificacaoLimite.Dispose();

        string sNovoFoco = "";
        //Alterado Média 
        //if (c.ID.ToString().IndexOf("med") > 0)
        //{
        //    if (!string.IsNullOrEmpty(c.Text))
        //    {
                TextBox cTlr = (TextBox) FindControl(c.ID.ToString().Replace("med", "tlr"));
                TextBox cMin = (TextBox) FindControl(c.ID.ToString().Replace("med", "min"));
                TextBox cMax = (TextBox) FindControl(c.ID.ToString().Replace("med", "max"));

                if (!string.IsNullOrEmpty(c.Text) && !string.IsNullOrEmpty(cTlr.Text))
                {
                    cTlr.Text = (Convert.ToDouble(c.Text) * dAneLmt).ToString("0.00");
                    cMin.Text = (Convert.ToDouble(c.Text) - Convert.ToDouble(cTlr.Text)).ToString("0.00");
                    cMax.Text = (Convert.ToDouble(c.Text) + Convert.ToDouble(cTlr.Text)).ToString("0.00");
                }
        //    }

            sNovoFoco = c.ID.ToString().Replace("med", "tlr");
        //}
        /*
        //Alterado Tolerância 
        else
        {
            if (!string.IsNullOrEmpty(c.Text))
            {
                TextBox cMed = (TextBox) FindControl(c.ID.ToString().Replace("tlr", "med"));
                TextBox cMin = (TextBox) FindControl(c.ID.ToString().Replace("tlr", "min"));
                TextBox cMax = (TextBox) FindControl(c.ID.ToString().Replace("tlr", "max"));

                cMin.Text = (Convert.ToDouble(cMed.Text) - Convert.ToDouble(c.Text)).ToString("0.00");
                cMax.Text = (Convert.ToDouble(cMed.Text) + Convert.ToDouble(c.Text)).ToString("0.00");
            }

            sNovoFoco = c.ID.ToString().Replace("tlr", "min");
        }
        */

            if (cbo_maq_tip_id_inc.SelectedItem.Text.EndsWith("S"))
            {
                txt_eee_tlr_inc.Text = "2,00";
                //Response.Write("<script language=\"javascript\">alert('Para fios NGAC tolerância especificação de E% deverá ser sempre +/- 2.')</script>");
            }

        TextBox cNovo = (TextBox) FindControl(sNovoFoco);
        cNovo.Focus();
        
    }

    protected void CalculaMinimoMaximo(object sender, EventArgs e)
    {
        TextBox cTlr = (TextBox)sender;

        string sNovoFoco = "";
        TextBox cMed = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "med"));
        TextBox cMin = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "min"));
        TextBox cMax = (TextBox)FindControl(cTlr.ID.ToString().Replace("tlr", "max"));

        if (!string.IsNullOrEmpty(cMed.Text) && !string.IsNullOrEmpty(cTlr.Text))
        {
            cMin.Text = (Convert.ToDouble(cMed.Text) - Convert.ToDouble(cTlr.Text)).ToString("0.00");
            cMax.Text = (Convert.ToDouble(cMed.Text) + Convert.ToDouble(cTlr.Text)).ToString("0.00");
        }

        sNovoFoco = cTlr.ID.ToString().Replace("tlr", "min");

        TextBox cNovo = (TextBox)FindControl(sNovoFoco);
        cNovo.Focus();

    }

    protected void ToleranciaE(object sender, EventArgs e)
    {
        if (cbo_maq_tip_id_inc.SelectedItem.Text.EndsWith("S"))
        {
            txt_eee_tlr_inc.Text = "2,00";
            Response.Write("<script language=\"javascript\">alert('Para fios NGAC tolerância especificação de E% deverá ser sempre +/- 2.')</script>");
        }
    }


    protected void EnviaEmail()
    {
        RTS RTS = new RTS();
        RTS.RTS_LOT = txt_lot_inc.Text;
        DataSet dsRTS = RTS.Consultar();
        if (dsRTS.Tables[0].Rows.Count > 0)
        {
            string sRTS = "";
            sRTS = dsRTS.Tables[0].Rows[0]["RTS_ID"].ToString();
            string sMotivoTeste = "";
            sMotivoTeste = dsRTS.Tables[0].Rows[0]["MTV_TST_DES"].ToString();
            string sUsuarioSolicitante = "";
            sUsuarioSolicitante = dsRTS.Tables[0].Rows[0]["USR_NOM"].ToString();
            string sEntrelacamento = "";
            sEntrelacamento = dsRTS.Tables[0].Rows[0]["ERT_DES"].ToString();

            string sRemetente = ConfigurationManager.AppSettings["EnderecoSMTP"];
            string sListaDestinatario = "";
            string sListaCopia = ConfigurationManager.AppSettings["EnderecoSMTP"];

            Usuario Usuario = new Usuario();
            //Perfil Área Técnia
            Usuario.USR_PFL_ID = 68;
            DataSet dsUsuario = Usuario.Consultar();
            foreach (DataRow drUsuario in dsUsuario.Tables[0].Rows)
            {
                sListaDestinatario += ";" + drUsuario["USR_EML"].ToString();
            }
            dsUsuario.Dispose();

            Usuario UsuarioAtual = new Usuario();
            UsuarioAtual.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            DataSet dsUsuarioAtual = UsuarioAtual.Consultar();
            foreach (DataRow drUsuarioAtual in dsUsuarioAtual.Tables[0].Rows)
            {
                sListaCopia += ";" + drUsuarioAtual["USR_EML"].ToString();
            }
            dsUsuarioAtual.Dispose();

            string sCliente = "";
            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_CLI_ID"].ToString()))
            {
                Cliente Cliente = new Cliente();
                Cliente.CLI_ID = Convert.ToInt32(dsRTS.Tables[0].Rows[0]["RTS_CLI_ID"].ToString());
                DataSet dsCliente = Cliente.Consultar();
                if (dsCliente.Tables[0].Rows.Count > 0)
                {
                    sCliente = dsCliente.Tables[0].Rows[0]["CLI_NOM"].ToString();
                }
                dsCliente.Dispose();
            }

            string sDataInclusao = "";
            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_DAT"].ToString()))
            {
                sDataInclusao = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_DAT"].ToString()).ToString("dd/MM/yyyy");
            }

            string sListaCopiaOculta = "";
            bool bFormatoHTML = true;
            string sTitulo = "Área Técnica o Relatório Parcial referente a RTS de número " + sRTS + " está disponível para sua análise";
            string sAssunto = "Área Técnica o Relatório Parcial referente a RTS de número " + sRTS + " - " + cbo_tit_poy_id_inc.SelectedItem.Text + " - " + sEntrelacamento + " - " + sMotivoTeste + " - " + sCliente + " está disponível para sua análise";
            sAssunto += "<br>";
            sAssunto += "<br>";
            sAssunto += "Solicitada por " + sUsuarioSolicitante + " em " + sDataInclusao + ".";
            sAssunto += "<br>";
            sAssunto += "Alterada por " + Session["USR"].ToString() + " em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ".";
            string sListaCaminhoAnexo = "";
            string sServer = ConfigurationManager.AppSettings["ServidorSMTP"];
            string sUsuario = ConfigurationManager.AppSettings["UsuarioSMTP"];
            string sSenha = ConfigurationManager.AppSettings["SenhaSMTP"];
            bool bSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLSMTP"]);
            int iPortaSmtp = Convert.ToInt32(ConfigurationManager.AppSettings["PortaSMTP"]);

            Email Email = new Email();
            Email.EnviarEmail(sRemetente, sListaDestinatario, sListaCopia, sListaCopiaOculta, bFormatoHTML, sTitulo, sAssunto, sListaCaminhoAnexo, sServer, bSSL, iPortaSmtp, sUsuario, sSenha);

            Response.Write("<script language=\"javascript\">alert('Email enviado com sucesso ao perfil Área Técnica.')</script>");

            Dispose();
        }
        else
        {
            Response.Write("<script language=\"javascript\">alert('Email não enviado pois não existe RTS para o Lote: " + txt_lot_inc.Text + ".')</script>");
        }
    }

}