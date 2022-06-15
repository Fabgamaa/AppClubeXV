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
        if (!IsPostBack)
        {
            FormataControles();
            CarregaControles();
        }
    }

    protected void FormataControles()
    {
        txt_dat.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

        txt_vrs.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_dat.Focus();
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel);
        dsTitulo.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_rel);
        dsMaquinaTipo.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_rel);
        dsApresentacao.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_rel);
        dsEntrelacamento.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_001_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_002_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_003_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_004_id_rel);
        dsFornecedor.Dispose();
    }

    protected string CriaFiltro(Standard Standard)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat.Text))
        {
            Standard.EPF_DAT = Convert.ToDateTime(txt_dat.Text);
            filtro = filtro + "Data= " + txt_dat.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vrs.Text))
        {
            Standard.EPF_VRS = Convert.ToInt32(txt_vrs.Text);
            filtro = filtro + "Versão= " + txt_vrs.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Standard.EPF_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot_ref.Text))
        {
            Standard.EPF_LOT_REF = txt_lot_ref.Text;
            filtro = filtro + "Lote Referência= " + txt_lot_ref.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Standard.EPF_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Standard.EPF_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Standard.EPF_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Standard Standard = new Standard();
        filtro = CriaFiltro(Standard);
        DataSet dsStandard = Standard.Consultar();

        if (dsStandard.Tables[0].Rows.Count > 0)
        {
            txt_dat_rel.Text = Convert.ToDateTime(dsStandard.Tables[0].Rows[0]["EPF_DAT"].ToString()).ToString("dd/MM/yyyy");
            txt_dat_002_rel.Text = Convert.ToDateTime(dsStandard.Tables[0].Rows[0]["EPF_DAT"].ToString()).ToString("dd/MM/yyyy");
            txt_vrs_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VRS"].ToString();
            txt_vrs_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VRS"].ToString();
            cbo_tit_poy_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIT_POY_ID"].ToString();
            txt_tit_poy_id_rel.Text = cbo_tit_poy_id_rel.SelectedItem.Text;
            txt_des_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DES"].ToString();
            txt_lot_ref_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_LOT_REF"].ToString();
            txt_lot_ref_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_LOT_REF"].ToString();
            cbo_maq_tip_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_MAQ_TIP_ID"].ToString();
            txt_maq_tip_id_rel.Text = cbo_maq_tip_id_rel.SelectedItem.Text;
            txt_maq_tip_id_002_rel.Text = cbo_maq_tip_id_rel.SelectedItem.Text;
            cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
            txt_lot_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_LOT"].ToString();
            cbo_aps_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_APS_ID"].ToString();
            txt_aps_id_rel.Text = cbo_aps_id_rel.SelectedItem.Text;
            cbo_ert_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_ERT_ID"].ToString();
            txt_ert_id_rel.Text = cbo_ert_id_rel.SelectedItem.Text;
            cbo_for_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_ID"].ToString();
            txt_for_id_rel.Text = cbo_for_id_rel.SelectedItem.Text;
            cbo_for_002_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_002_ID"].ToString();
            txt_for_002_id_rel.Text = cbo_for_002_id_rel.SelectedItem.Text;
            cbo_for_003_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_003_ID"].ToString();
            txt_for_003_id_rel.Text = cbo_for_003_id_rel.SelectedItem.Text;
            cbo_for_004_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_004_ID"].ToString();
            txt_for_004_id_rel.Text = cbo_for_004_id_rel.SelectedItem.Text;
            cbo_eor_001_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_001_ID"].ToString();
            txt_eor_001_id_rel.Text = cbo_eor_001_id_rel.SelectedItem.Text;
            cbo_eor_002_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_002_ID"].ToString();
            txt_eor_002_id_rel.Text = cbo_eor_002_id_rel.SelectedItem.Text;
            cbo_eor_003_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_003_ID"].ToString();
            txt_eor_003_id_rel.Text = cbo_eor_003_id_rel.SelectedItem.Text;
            cbo_eor_004_id_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_004_ID"].ToString();
            txt_eor_004_id_rel.Text = cbo_eor_004_id_rel.SelectedItem.Text;
            txt_mge_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
            txt_mge_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_002"].ToString();
            txt_mge_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_003"].ToString();
            txt_mge_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_004"].ToString();
            txt_mge_des_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_001"].ToString();
            txt_mge_des_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_002"].ToString();
            txt_mge_des_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_003"].ToString();
            txt_mge_des_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_004"].ToString();
            txt_ege_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_001"].ToString();
            txt_ege_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_002"].ToString();
            txt_ege_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_003"].ToString();
            txt_ege_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_004"].ToString();
            txt_ege_des_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_001"].ToString();
            txt_ege_des_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_002"].ToString();
            txt_ege_des_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_003"].ToString();
            txt_ege_des_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_004"].ToString();
            txt_vw2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VW2"].ToString();
            txt_egm_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGM"].ToString();
            txt_dyy_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DYY"].ToString();
            txt_2wx_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_2WX"].ToString();
            txt_3w3_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_3W3"].ToString();
            txt_4w4_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_4W4"].ToString();
            txt_agl_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_AGL"].ToString();
            txt_tup_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TUP"].ToString();
            txt_veo_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VEO"].ToString();
            txt_t1t_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_T1T"].ToString();
            txt_t1c_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_T1C"].ToString();
            txt_t1l_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_T1L"].ToString();
            txt_t2f_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_T2F"].ToString();
            txt_sve_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SVE"].ToString();
            txt_stf_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_STF"].ToString();
            txt_stm_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_STM"].ToString();
            txt_sce_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SCE"].ToString();
            txt_sco_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SCO"].ToString();
            txt_sch_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SCH"].ToString();
            txt_scg_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SCG"].ToString();
            txt_see_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SEE"].ToString();
            txt_seo_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SEO"].ToString();
            txt_seh_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SEH"].ToString();
            txt_seg_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SEG"].ToString();
            txt_sjc_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SJC"].ToString();
            txt_sjt_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SJT"].ToString();
            txt_sjb_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SJB"].ToString();
            txt_spj_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SPJ"].ToString();
            txt_sbc_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SBC"].ToString();
            txt_spo_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SPO"].ToString();
            txt_sva_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SVA"].ToString();
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_COV"].ToString()))
            {
                txt_cov_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_COV"].ToString()).ToString("0.0000");
            }
            txt_tgr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TGR"].ToString();
            txt_tip_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP"].ToString();
            txt_dsb_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DSB"].ToString();
            txt_tca_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TCA"].ToString();
            txt_fmc_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FMC"].ToString();
            txt_fmc_sta_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FMC"].ToString();
            txt_1tb_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_1TB"].ToString();
            txt_1pp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_1PP"].ToString();
            txt_2tb_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_2TB"].ToString();
            txt_2pp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_2PP"].ToString();
            txt_cso_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CSO"].ToString();
            txt_esp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ESP"].ToString();
            txt_tol_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TOL"].ToString();
            txt_tol_sta_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TOL"].ToString();
            txt_coc_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_COC"].ToString();
            txt_p1c_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_P1C"].ToString();
            txt_p2d_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_P2D"].ToString();
            txt_p3d_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_P3D"].ToString();
            txt_p4u_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_P4U"].ToString();
            txt_mol_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MOL"].ToString();
            txt_tpd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TPD"].ToString();
            txt_tt1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TT1"].ToString();
            txt_tt2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TT2"].ToString();
            txt_tt3_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TT3"].ToString();
            txt_t21_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_T21"].ToString();
            txt_tun_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TUN"].ToString();
            txt_tcv_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TCV"].ToString();
            txt_tss_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TSS"].ToString();
            txt_tit_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TIT"].ToString();
            txt_tnc_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TNC"].ToString();
            txt_aon_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_AON"].ToString();
            txt_enm_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ENM"].ToString();
            txt_eee_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EEE"].ToString();
            txt_kkk_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_KKK"].ToString();
            txt_bbb_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_BBB"].ToString();
            txt_ole_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_OLE"].ToString();
            txt_trq_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TRQ"].ToString();
            txt_ert_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ERT"].ToString();
            txt_rt3_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RT3"].ToString();
            txt_rt5_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RT5"].ToString();
            txt_dnd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DND"].ToString();
            txt_dmo_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DMO"].ToString();
            txt_pes_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PES"].ToString();
            txt_vrr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VRR"].ToString();

            txt_rsq_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RSQ"].ToString();
            txt_rlq_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RLQ"].ToString();
            txt_rrm_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RRM"].ToString();
            txt_rmx_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RMX"].ToString();
            txt_rmn_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RMN"].ToString();
            txt_rmh_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RMH"].ToString();
            txt_rqs_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RQS"].ToString();
            txt_rty_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RTY"].ToString();
            txt_rhy_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RHY"].ToString();

            txt_tre_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TRE"].ToString();
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()))
            {
                txt_lme_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()))
            {
                txt_ume_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()))
            {
                txt_lpe_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()))
            {
                txt_upe_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()))
            {
                txt_ucv_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()))
            {
                txt_lcv_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()))
            {
                txt_dur_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()))
            {
                txt_dft_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()))
            {
                txt_lmc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()))
            {
                txt_umc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()))
            {
                txt_lpc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()))
            {
                txt_upc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()))
            {
                txt_cvc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()))
            {
                txt_lvc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()))
            {
                txt_dfc_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()))
            {
                txt_tfs_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()))
            {
                txt_fsw_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()))
            {
                txt_wfw_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()))
            {
                txt_ybt_rel.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()).ToString("0.0");
            }
            txt_eco_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECO"].ToString();

            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_GFT"].ToString()))
            {
                if (dsStandard.Tables[0].Rows[0]["EPF_GFT"].ToString() == "1")
                {
                    txt_gft_rel.Text = "SIM";
                }
                else
                {
                    txt_gft_rel.Text = "NÃO";
                }
            }

            if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_HEM"].ToString()))
            {
                if (dsStandard.Tables[0].Rows[0]["EPF_HEM"].ToString() == "1")
                {
                    txt_hem_rel.Text = "SIM";
                }
                else
                {
                    txt_hem_rel.Text = "NÃO";
                }
            }

            txt_dim_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DIM"].ToString();
            txt_vaz_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VAZ"].ToString();
            
            //txt_spx_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SPX"].ToString();
            txt_eol_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
            txt_etu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
            txt_etd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
            txt_ecu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
            txt_egd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
            txt_eec_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
            txt_ecd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
            txt_egu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
            txt_eso_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
            txt_esi_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
            txt_ecr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
            txt_eod_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
            txt_eaw_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
            txt_ed1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ED1"].ToString();
            txt_ed2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ED2"].ToString();
            cbo_idd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString();
            txt_eol_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
            txt_etu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
            txt_etd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
            txt_eta_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETA"].ToString();
            txt_eth_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETH"].ToString();
            txt_etg_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETG"].ToString();
            txt_edt_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EDT"].ToString();
            txt_efp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EFP"].ToString();
            txt_eyt_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EYT"].ToString();
            txt_edl_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EDL"].ToString();
            txt_eab_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EAB"].ToString();
            txt_eca_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECA"].ToString();
            txt_ecw_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ECW"].ToString();
            txt_etl_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETL"].ToString();
            txt_ett_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ETT"].ToString();
            txt_ere_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ERE"].ToString();
            txt_ele_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ELE"].ToString();
            txt_ept_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPT"].ToString();
            txt_epl_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPL"].ToString();
            txt_pco_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PCO"].ToString();
            txt_pcv_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PCV"].ToString();
            txt_drt_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DRT"].ToString();
            txt_tal_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TAL"].ToString();
            txt_val_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VAL"].ToString();
            txt_sje_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SJE"].ToString();

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "M900" || cbo_maq_tip_id_rel.SelectedItem.Text == "V900")
            {
                Engrenagem_M900 Engrenagem_M900 = new Engrenagem_M900();
                Engrenagem_M900.CODIGO = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CTX"].ToString());
                DataSet dsEngrenagem_M900 = Engrenagem_M900.Consultar();

                if (dsEngrenagem_M900.Tables[0].Rows.Count > 0)
                {
                    txt_ez1_rel.Text = dsEngrenagem_M900.Tables[0].Rows[0]["Z1"].ToString();
                    txt_ez2_rel.Text = dsEngrenagem_M900.Tables[0].Rows[0]["Z2"].ToString();
                }

                Overfeed_M900 Overfeed_M900 = new Overfeed_M900();
                Overfeed_M900.CODIGO = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CVX"].ToString());
                DataSet dsOverfeed_M900 = Overfeed_M900.Consultar();

                if (dsOverfeed_M900.Tables[0].Rows.Count > 0)
                {
                    txt_ez3_rel.Text = dsOverfeed_M900.Tables[0].Rows[0]["Z3Z5"].ToString();
                    txt_ez4_rel.Text = dsOverfeed_M900.Tables[0].Rows[0]["Z4Z6"].ToString();
                }

                Overfeed_M900.CODIGO = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CVR"].ToString());
                dsOverfeed_M900 = Overfeed_M900.Consultar();

                if (dsOverfeed_M900.Tables[0].Rows.Count > 0)
                {
                    txt_ez5_rel.Text = dsOverfeed_M900.Tables[0].Rows[0]["Z3Z5"].ToString();
                    txt_ez6_rel.Text = dsOverfeed_M900.Tables[0].Rows[0]["Z4Z6"].ToString();
                }
            }

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "STAHLE")
            {
                Overfeed_Stahle Overfeed_Stahle = new Overfeed_Stahle();
                Overfeed_Stahle.Cod = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CRC"].ToString());
                DataSet dsOverfeed_Stahle = Overfeed_Stahle.Consultar();

                if (dsOverfeed_Stahle.Tables[0].Rows.Count > 0)
                {
                    txt_sta_z05_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z5"].ToString();
                    txt_sta_z08_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z8"].ToString();
                    txt_sta_z13_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z13"].ToString();
                }

                Overfeed_Stahle.Cod = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CRE"].ToString());
                dsOverfeed_Stahle = Overfeed_Stahle.Consultar();

                if (dsOverfeed_Stahle.Tables[0].Rows.Count > 0)
                {
                    txt_sta_z01_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z1"].ToString();
                    txt_sta_z02_rel.Text = "40";
                    txt_sta_z04_rel.Text = "40";
                    txt_sta_z06_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z6"].ToString();
                    txt_sta_z07_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z7"].ToString();
                    txt_sta_z14_rel.Text = dsOverfeed_Stahle.Tables[0].Rows[0]["Z14"].ToString();
                }
                dsOverfeed_Stahle.Dispose();

                Taxa_Stahle Taxa_Stahle = new Taxa_Stahle();
                Taxa_Stahle.Cod = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CTC"].ToString());
                DataSet dsTaxa_Stahle = Taxa_Stahle.Consultar();
                if (dsTaxa_Stahle.Tables[0].Rows.Count > 0)
                {
                    txt_sta_z09_rel.Text = dsTaxa_Stahle.Tables[0].Rows[0]["Z9"].ToString();
                    txt_sta_z10_rel.Text = dsTaxa_Stahle.Tables[0].Rows[0]["Z10"].ToString();
                }

                Taxa_Stahle.Cod = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CTE"].ToString());
                dsTaxa_Stahle = Taxa_Stahle.Consultar();
                if (dsTaxa_Stahle.Tables[0].Rows.Count > 0)
                {
                    txt_sta_z11_rel.Text = dsTaxa_Stahle.Tables[0].Rows[0]["Z11"].ToString();
                    txt_sta_z12_rel.Text = dsTaxa_Stahle.Tables[0].Rows[0]["Z12"].ToString();
                }
                dsTaxa_Stahle.Dispose();

                Overfix_Stahle Overfix_Stahle = new Overfix_Stahle();
                Overfix_Stahle.Cod = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CTS"].ToString());
                DataSet dsOverfix_Stahle = Overfix_Stahle.Consultar();
                if (dsOverfix_Stahle.Tables[0].Rows.Count > 0)
                {
                    txt_sta_z03_rel.Text = dsOverfix_Stahle.Tables[0].Rows[0]["Z3"].ToString();
                }
                dsOverfix_Stahle.Dispose();

                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CTN"].ToString()))
                {
                    Tensao_Stahle Tensao_Stahle = new Tensao_Stahle();
                    Tensao_Stahle.COD = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_CTN"].ToString());
                    DataSet dsTensao_Stahle = Tensao_Stahle.Consultar();
                    if (dsTensao_Stahle.Tables[0].Rows.Count > 0)
                    {
                        txt_sta_sp1_rel.Text = dsTensao_Stahle.Tables[0].Rows[0]["P1"].ToString();
                        txt_sta_sp2_rel.Text = dsTensao_Stahle.Tables[0].Rows[0]["P2"].ToString();
                    }
                    dsTensao_Stahle.Dispose();            
                }
            }

            //TMT
            txt_mat_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT"].ToString();
            txt_can_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN"].ToString();
            txt_epu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU"].ToString();
            txt_per_mge_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE"].ToString();
            txt_mat_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_002"].ToString();
            txt_can_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_002"].ToString();
            txt_epu_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_002"].ToString();
            txt_per_mge_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_002"].ToString();
            txt_mat_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_003"].ToString();
            txt_can_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_003"].ToString();
            txt_epu_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_003"].ToString();
            txt_per_mge_003_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_003"].ToString();
            txt_mat_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_004"].ToString();
            txt_can_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_004"].ToString();
            txt_epu_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_004"].ToString();
            txt_per_mge_004_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_004"].ToString();
            txt_hot_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_HOT"].ToString();
            txt_vrd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_VRD"].ToString();
            txt_acr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ACR"].ToString();
            txt_pen_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PEN"].ToString();
            txt_cra_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA"].ToString();
            txt_cle_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CLE"].ToString();
            txt_afo_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_AFO"].ToString();
            txt_tcu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString();
            txt_tar_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TAR"].ToString();
            ddl_tam_rel.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString();
            txt_tam_rel.Text = ddl_tam_rel.SelectedItem.Text;
            txt_std_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_STD"].ToString();
            txt_stp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_STP"].ToString();
            txt_ttd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TTD"].ToString();
            txt_ttp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TTP"].ToString();
            txt_ftd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FTD"].ToString();
            txt_ftp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FTP"].ToString();
            txt_itd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ITD"].ToString();
            txt_itp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ITP"].ToString();
            txt_xtd_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_XTD"].ToString();
            txt_xtp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_XTP"].ToString();
            txt_ttr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TTR"].ToString();
            txt_dtu_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DTU"].ToString();
            txt_dpa_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DPA"].ToString();
            txt_cin_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CIN"].ToString();
            lbl_fr2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR2"].ToString();
            txt_fr2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FR2"].ToString();
            lbl_fr1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR1"].ToString();
            txt_fr1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FR1"].ToString();
            lbl_fr0_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR0"].ToString();
            txt_fr0_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_FR0"].ToString();
            txt_ato_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ATO"].ToString();
            txt_tp1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TP1"].ToString();
            txt_tp2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TP2"].ToString();
            txt_tcp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TCP"].ToString();
            txt_jf2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_JF2"].ToString();
            txt_ps2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PS2"].ToString();
            txt_jf0_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_JF0"].ToString();
            txt_ps0_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PS0"].ToString();
            txt_bba_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_BBA"].ToString();
            txt_gro_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_GRO"].ToString();
            txt_tcs_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TCS"].ToString();
            txt_cvp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP"].ToString();
            txt_ssv_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SSV"].ToString();
            txt_ssp_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_SSP"].ToString();
            txt_tte_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_001"].ToString();
            txt_tte_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_002"].ToString();
            cbo_wpo_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_001"].ToString();
            cbo_wpo_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_002"].ToString();
            txt_dir_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_001"].ToString();
            txt_dir_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_002"].ToString();
            txt_cra_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_001"].ToString();
            txt_cra_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_002"].ToString();
            cbo_ced_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString();
            cbo_ced_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString();
            txt_ted_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_001"].ToString();
            txt_ted_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_002"].ToString();
            txt_dle_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_001"].ToString();
            txt_dle_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_002"].ToString();
            txt_cti_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_001"].ToString();
            txt_cti_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_002"].ToString();
            txt_g1o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_001"].ToString();
            txt_g1o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_002"].ToString();
            txt_g1u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_001"].ToString();
            txt_g1u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_002"].ToString();
            txt_g2o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_001"].ToString();
            txt_g2o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_002"].ToString();
            txt_g2u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_001"].ToString();
            txt_g2u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_002"].ToString();
            txt_cvp_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_001"].ToString();
            txt_cvp_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_002"].ToString();
            txt_ocu_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_001"].ToString();
            txt_ocu_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_002"].ToString();
            txt_ucu_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_001"].ToString();
            txt_ucu_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_002"].ToString();
            txt_c1o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_001"].ToString();
            txt_c1o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_002"].ToString();
            txt_l1o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_001"].ToString();
            txt_l1o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_002"].ToString();
            txt_c1u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_001"].ToString();
            txt_c1u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_002"].ToString();
            txt_l1u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_001"].ToString();
            txt_l1u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_002"].ToString();
            txt_c2o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_001"].ToString();
            txt_c2o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_002"].ToString();
            txt_l2o_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_001"].ToString();
            txt_l2o_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_002"].ToString();
            txt_c2u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_001"].ToString();
            txt_c2u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_002"].ToString();
            txt_l2u_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_001"].ToString();
            txt_l2u_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_002"].ToString();
            txt_tsu_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_001"].ToString();
            txt_tsu_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_002"].ToString();
            txt_cvc_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_001"].ToString();
            txt_cvc_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_002"].ToString();
            txt_cvl_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_001"].ToString();
            txt_cvl_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_002"].ToString();
            txt_tle_001_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_001"].ToString();
            txt_tle_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_002"].ToString();
            cbo_roi_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString();
            cbo_rr0_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString();
            cbo_r01_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString();
            cbo_rr1_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString();
            cbo_rr2_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString();
            cbo_r2a_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString();
            cbo_rr3_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString();
            cbo_rwr_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString();
            cbo_ply_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PLY"].ToString();
            cbo_plf_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PLF"].ToString();
            cbo_pll_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_PLL"].ToString();

            if (cbo_rr0_rel.Text == "ON" || cbo_r01_rel.Text == "ON")
            {
                pnl_frs.Visible = true;
            }
            else
            {
                pnl_frs.Visible = false;
            }
            if (cbo_ply_rel.Text == "1")
            {
                pnl_wpo_001.Visible = true;
                pnl_wpo_002.Visible = true;
            }
            else
            {
                pnl_wpo_001.Visible = false;
                pnl_wpo_002.Visible = false;
            }
            if (cbo_plf_rel.Text == "ATIVO")
            {
                pnl_plf_001.Visible = false;
                pnl_plf_002.Visible = false;
            }
            else
            {
                pnl_plf_001.Visible = true;
                pnl_plf_002.Visible = true;
            }
            if (cbo_pll_rel.Text == "ALL")
            {
                pnl_ply_002.Visible = false;
            }
            else
            {
                pnl_ply_002.Visible = true;
            }

            txt_det_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DET"].ToString();
            txt_det_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_DET"].ToString();
            txt_obs_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_OBS"].ToString();
            txt_obs_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_OBS"].ToString();

            lb_rsp_rel.Text = dsStandard.Tables[0].Rows[0]["USR_NOM"].ToString();
            lb_rsp_002_rel.Text = dsStandard.Tables[0].Rows[0]["USR_NOM"].ToString();

            Usuario Usuario = new Usuario();
            //MAP16112012
            //Sempre carregar o Usuário de Inclusão
            //if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_USR_ALT_ID"].ToString()))
            //{
            //    Usuario.USR_ID = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_USR_ALT_ID"].ToString());
            //}
            //else
            //{
                Usuario.USR_ID = Convert.ToInt32(dsStandard.Tables[0].Rows[0]["EPF_USR_INC_ID"].ToString());
            //}
            DataSet dsUsuario = Usuario.Consultar();
            if (dsUsuario.Tables[0].Rows.Count > 0)
            {
                lb_usr_rel.Text = dsUsuario.Tables[0].Rows[0]["USR_NOM"].ToString();
                lb_usr_002_rel.Text = dsUsuario.Tables[0].Rows[0]["USR_NOM"].ToString();
            }
            dsUsuario.Dispose();

            lb_tms_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TMS_ATL"].ToString();
            lb_tms_002_rel.Text = dsStandard.Tables[0].Rows[0]["EPF_TMS_ATL"].ToString();

            cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
        }
        dsStandard.Dispose();
        Dispose();

        dvFiltro.Visible = false;
        dvResultado.Visible = true;
        dvBarra.Visible = false;
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }


    public override void VerifyRenderingInServerForm(Control control)
    {

    }

    protected void cbo_maq_tip_id_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(cbo_maq_tip_id_rel.SelectedValue))
        {
            pnl_pag.Visible = false;
            pnl_afk_001.Visible = true;
            pnl_afk_002.Visible = true;
            pnl_afk_003.Visible = true;
            pnl_afk_3.Visible = false;
            pnl_afk_d_t4_M900_V900.Visible = false;
            pnl_900_lnh.Visible = false;
            pnl_M900_V900.Visible = false;
            pnl_afk_dtx_2s_t2s_ds.Visible = false;
            pnl_afk_cop_2s_t2s_ds.Visible = false;
            pnl_sta.Visible = false;
            pnl_sta_002.Visible = false;
            pnl_sta_poy.Visible = false;
            pnl_Stahle.Visible = false;
            pnl_sta_ctn.Visible = false;
            pnl_epu.Visible = false;
            pnl_reg.Visible = false;
            pnl_ddi_sta.Visible = false;
            pnl_tmt_ssv.Visible = false;

            lb_mge_rel.Text = "Merge";
            lb_mge_des_001_rel.Text = "Descrição 1";
            lb_for_id_rel.Text = "Fornecedor";
            lb_mge_002_rel.Text = "Merge 2";
            lb_mge_des_002_rel.Text = "Descrição 2";
            lb_for_002_id_rel.Text = "Fornecedor 2";
            lb_mge_003_rel.Text = "Merge 3";
            lb_mge_des_003_rel.Text = "Descrição 3";
            lb_for_003_id_rel.Text = "Fornecedor 3";
            lb_mge_004_rel.Text = "Merge 4";
            lb_mge_des_004_rel.Text = "Descrição 4";
            lb_for_004_id_rel.Text = "Fornecedor 4";

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "STAHLE")
            {
                pnl_sta.Visible = true;
                pnl_sta_002.Visible = true;
                pnl_sta_poy.Visible = true;
                //lb_des_rel.Text = "C1-";
                lb_mge_rel.Text = "C1-Merge";
                lb_mge_des_001_rel.Text = "C1-Descrição";
                lb_for_id_rel.Text = "C1-Fornecedor";
                lb_mge_002_rel.Text = "C2-Merge";
                lb_mge_des_002_rel.Text = "C2-Descrição";
                lb_for_002_id_rel.Text = "C2-Fornecedor";
                lb_mge_003_rel.Text = "C3-Merge";
                lb_mge_des_003_rel.Text = "C3-Descrição";
                lb_for_003_id_rel.Text = "C3-Fornecedor";
                lb_mge_004_rel.Text = "C4-Merge";
                lb_mge_des_004_rel.Text = "C4-Descrição";
                lb_for_004_id_rel.Text = "C4-Fornecedor";
                pnl_Stahle.Visible = true;
                pnl_sta_ctn.Visible = true;

                pnl_afk_001.Visible = false;
                pnl_afk_002.Visible = false;
                pnl_afk_003.Visible = false;
                pnl_afk_d_t4_M900_V900.Visible = false;
                pnl_tns.Visible = false;
                pnl_ddi_pdr.Visible = false;
                pnl_tmt_ssv.Visible = false;
                pnl_ddi_sta.Visible = true;
                pnl_uni.Visible = false;
                pnl_agl_tup_veo.Visible = false;
                pnl_trq_ert_rt3_rt5.Visible = false;
                pnl_rmh_rel.Visible = false;
                pnl_t2f.Visible = false;
                pnl_rgm.Visible = false;
                pnl_epu.Visible = true;
                pnl_reg.Visible = true;

                pnl_ekb.Visible = false;
            }
/*
            else
            {
                pnl_afk_001.Visible = true;
                pnl_afk_002.Visible = true;
                pnl_afk_003.Visible = true;
                pnl_sta.Visible = false;
                pnl_sta_poy.Visible = false;
                pnl_Stahle.Visible = false;
            }
*/

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "M900" || cbo_maq_tip_id_rel.SelectedItem.Text == "V900")
            {
                pnl_900_lnh.Visible = true;
                pnl_M900_V900.Visible = true;
                pnl_afk_002.Visible = false;
                pnl_afk_003.Visible = false;
                pnl_overfeed_wx_M900_V900.Visible = false;
            }
/*
            else
            {
                pnl_afk_003.Visible = true;
                pnl_M900_V900.Visible = false;
            }
*/

            if ((cbo_maq_tip_id_rel.SelectedItem.Text == "AFK3") || (cbo_maq_tip_id_rel.SelectedItem.Text == "AFK3M"))
            {
                pnl_pag.Visible = true;
                pnl_afk_3.Visible = true;
            }
/*
            else
            {
                pnl_afk_3.Visible = false;
            }
*/

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "AFKD" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKDS" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKT4" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKT4S" || cbo_maq_tip_id_rel.SelectedItem.Text == "M900" || cbo_maq_tip_id_rel.SelectedItem.Text == "V900") 
            {
                pnl_afk_002.Visible = false; 
                pnl_afk_d_t4_M900_V900.Visible = true;
            }
/*
            else
            {
                pnl_afk_d_t4_M900_V900.Visible = false;
                pnl_afk_002.Visible = true;
            }
*/

            if (cbo_maq_tip_id_rel.SelectedItem.Text == "AFK2S" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKT2S" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKT4S" || cbo_maq_tip_id_rel.SelectedItem.Text == "AFKDS")
            {
                pnl_pag.Visible = true;
                pnl_afk_dtx_2s_t2s_ds.Visible = true;
                pnl_afk_cop_2s_t2s_ds.Visible = true;
            }
/*
            else
            {
                pnl_afk_dtx_2s_t2s_ds.Visible = false;
                pnl_afk_cop_2s_t2s_ds.Visible = false;
            }
*/
            if (cbo_maq_tip_id_rel.SelectedItem.Text == "TMT")
            {
                lbl_edy.Text = "Relação VR(B/Y)";
                lbl_ewx.Text = "Overfeed do Jet(OF2A) (%)";
                lbl_ew3.Text = "2º Overfeed(OF2) (%)";
                lbl_ew4.Text = "3º Overfeed(OF3) (%)";
                lbl_vw2.Text = "Velocidade YS(m/min)";

                //pnl_ope.Visible = false;
                pnl_epu.Visible = false;
                pnl_reg.Visible = false;
                pnl_rgm.Visible = false;
                /*
                pnl_dad.Visible = false;
                pnl_eng_pol.Visible = false;
                pnl_reg_enc.Visible = false;
                pnl_reg_bar.Visible = false;
                pnl_reg_uni.Visible = false;
                pnl_dof.Visible = false;
                */
                pnl_agl_tup_veo.Visible = true;
                pnl_agl.Visible = false;
                /*
                pnl_t1e.Visible = false;
                pnl_drt.Visible = false;
                */
                pnl_ten.Visible = false;
                pnl_afk_002.Visible = false;
                pnl_afk_d_t4_M900_V900.Visible = true;
                pnl_t2f.Visible = true;
                pnl_afk_003.Visible = false;
                pnl_uni.Visible = false;
                pnl_ddi.Visible = true;
                pnl_tmt_tss.Visible = false;
                pnl_tmt_ssv.Visible = true;

                pnl_tmt_poy.Visible = true;
                pnl_tmt_ope.Visible = true;
                if (txt_tam_rel.Text == "ATIVO")
                {
                    pnl_pag.Visible = true;
                    pnl_tam.Visible = true;
                }
                else
                {
                    pnl_pag.Visible = false;
                    pnl_tam.Visible = false;
                }
                pnl_tmt_reg.Visible = true;
                pnl_tmt_ten.Visible = true;
                pnl_tmt_tcs.Visible = true;
                pnl_tmt_rol.Visible = true;
            }

        }
    }

    protected void cbo_sts_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_sts.SelectedItem.Text == "INATIVO")
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Selecionando Status Inativos, serão apresentados Standard que não estão mais em produção.');", true);
        }
    }

}