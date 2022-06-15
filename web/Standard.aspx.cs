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
        txt_vrs.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tit_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lcv_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lvc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        //TMT
        txt_per_mge_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_per_mge_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_per_mge_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_per_mge_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_per_mge_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_per_mge_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_per_mge_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_per_mge_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_hot_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
        dsTitulo.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_001_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_003_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_eor_004_id_inc);
        dsFornecedor.Dispose();

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

        Engrenagem_M900 Engrenagem_M900 = new Engrenagem_M900();
        DataSet dsEngrenagem_M900 = Engrenagem_M900.Consultar();
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_inc);
        dsEngrenagem_M900.Dispose();

        Overfeed_M900 Overfeed_M900 = new Overfeed_M900();
        DataSet dsOverfeed_M900 = Overfeed_M900.Consultar();
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_inc);
        dsOverfeed_M900.Dispose();

        Overfeed_Stahle Overfeed_Stahle = new Overfeed_Stahle();
        DataSet dsOverfeed_Stahle = Overfeed_Stahle.Consultar();
        FWGNR.VerificaStatus(dsOverfeed_Stahle, "COD", "OVERFEED_Z05_Z08_Z13", "", cbo_sta_z05_z08_z13_inc);
        //Z02 e Z04 são fixas 40
        FWGNR.VerificaStatus(dsOverfeed_Stahle, "COD", "OVERFEED_Z01_Z02_Z04_Z06_Z14", "", cbo_sta_z01_z02_z04_z06_z14_inc);
        dsOverfeed_Stahle.Dispose();

        Taxa_Stahle Taxa_Stahle = new Taxa_Stahle();
        DataSet dsTaxa_Stahle = Taxa_Stahle.Consultar();
        FWGNR.VerificaStatus(dsTaxa_Stahle, "COD", "TAXA_Z09_Z10", "", cbo_sta_z09_z10_inc);
        FWGNR.VerificaStatus(dsTaxa_Stahle, "COD", "TAXA_Z11_Z12", "", cbo_sta_z11_z12_inc);
        dsTaxa_Stahle.Dispose();

        Overfix_Stahle Overfix_Stahle = new Overfix_Stahle();
        DataSet dsOverfix_Stahle = Overfix_Stahle.Consultar();
        FWGNR.VerificaStatus(dsOverfix_Stahle, "COD", "OVERFIX_Z03", "", cbo_sta_z03_inc);
        dsOverfix_Stahle.Dispose();

        Tensao_Stahle Tensao_Stahle = new Tensao_Stahle();
        DataSet dsTensao_Stahle = Tensao_Stahle.Consultar();
        FWGNR.VerificaStatus(dsTensao_Stahle, "COD", "TENSAO_P1_P2", "", cbo_ctn_inc);
        dsTensao_Stahle.Dispose();

        Usuario Responsavel = new Usuario();
        Responsavel.USR_PFL_ID = 64;
        Responsavel.USR_STS = 1;
        DataSet dsResponsavel = Responsavel.Consultar();
        FWGNR.VerificaStatus(dsResponsavel, "USR_ID", "USR_NOM", "USR_STS", cbo_rsp_inc);
        dsResponsavel.Dispose();
    }

    protected void CarregaDados()
    {
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            lbAcao.Text = "Alterar";
            divCadastro.Visible = true;
            dvFiltro.Visible = false;

            txt_dat_inc.Focus();

            Standard Standard = new Standard();
            Standard.EPF_ID = Convert.ToInt32(rowId.Value);
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count > 0)
            {
                txt_dat_inc.Text = Convert.ToDateTime(dsStandard.Tables[0].Rows[0]["EPF_DAT"].ToString()).ToString("dd/MM/yyyy");
                txt_vrs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRS"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RSP_USR_ID"].ToString()))
                {
                    cbo_rsp_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_RSP_USR_ID"].ToString();
                }
                txt_lot_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_LOT"].ToString();
                txt_lot_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_LOT_REF"].ToString();
                cbo_tit_poy_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIT_POY_ID"].ToString();
                txt_des_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DES"].ToString();
                txt_mge_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
                txt_mge_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_003"].ToString();
                txt_mge_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_004"].ToString();
                txt_mge_des_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_001"].ToString();
                txt_mge_des_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_002"].ToString();
                txt_mge_des_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_003"].ToString();
                txt_mge_des_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_004"].ToString();
                cbo_for_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_004_ID"].ToString();
                txt_ege_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_001"].ToString();
                txt_ege_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_002"].ToString();
                txt_ege_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_003"].ToString();
                txt_ege_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_004"].ToString();
                txt_ege_des_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_001"].ToString();
                txt_ege_des_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_002"].ToString();
                txt_ege_des_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_003"].ToString();
                txt_ege_des_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_004"].ToString();
                cbo_eor_001_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_001_ID"].ToString();
                cbo_eor_002_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_002_ID"].ToString();
                cbo_eor_003_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_003_ID"].ToString();
                cbo_eor_004_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_004_ID"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_EOR_001_ID"].ToString()))
                {
                    cbo_eor_001_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_001_ID"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_EOR_002_ID"].ToString()))
                {
                    cbo_eor_002_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_002_ID"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_EOR_003_ID"].ToString()))
                {
                    cbo_eor_003_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_003_ID"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_EOR_004_ID"].ToString()))
                {
                    cbo_eor_004_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_004_ID"].ToString();
                }
                //Excluído por solicitação do Wagner 11/07/2011
                //txt_vlc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_MAQ_TIP_ID"].ToString();
                object sender = null;
                EventArgs e = null;
                cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
                cbo_ert_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_ERT_ID"].ToString();
                txt_vw2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VW2"].ToString();
                txt_egm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGM"].ToString();
                txt_dyy_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DYY"].ToString();
                txt_2wx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2WX"].ToString();
                txt_3w3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_3W3"].ToString();
                txt_4w4_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_4W4"].ToString();
                txt_agl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AGL"].ToString();
                txt_tup_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUP"].ToString();
                txt_veo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VEO"].ToString();
                txt_t1t_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1T"].ToString();
                txt_t1c_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1C"].ToString();
                txt_t1l_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1L"].ToString();
                txt_t2f_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T2F"].ToString();
                txt_sve_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVE"].ToString();
                txt_stf_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STF"].ToString();
                txt_stm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STM"].ToString();
                txt_sce_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCE"].ToString();
                txt_sco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCO"].ToString();
                txt_sch_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCH"].ToString();
                txt_scg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCG"].ToString();
                txt_see_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEE"].ToString();
                txt_seo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEO"].ToString();
                txt_seh_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEH"].ToString();
                txt_seg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEG"].ToString();
                txt_sjc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJC"].ToString();
                txt_sjt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJT"].ToString();
                txt_sjb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJB"].ToString();
                txt_spj_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPJ"].ToString();
                txt_sbc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SBC"].ToString();
                txt_spo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPO"].ToString();
                txt_sva_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVA"].ToString();
                txt_tgr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TGR"].ToString();
                txt_tip_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP"].ToString();
                txt_dsb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DSB"].ToString();
                txt_tca_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCA"].ToString();
                txt_fmc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FMC"].ToString();
                txt_1tb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1TB"].ToString();
                txt_1pp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1PP"].ToString();
                txt_2tb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2TB"].ToString();
                txt_2pp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2PP"].ToString();
                txt_cso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CSO"].ToString();
                txt_esp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESP"].ToString();
                txt_tol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TOL"].ToString();
                txt_p1c_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P1C"].ToString();
                txt_p2d_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P2D"].ToString();
                txt_p3d_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P3D"].ToString();
                txt_p4u_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P4U"].ToString();
                txt_mol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MOL"].ToString();
                txt_tpd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TPD"].ToString();
                txt_tt1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT1"].ToString();
                txt_tt2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT2"].ToString();
                txt_tt3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT3"].ToString();
                txt_t21_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T21"].ToString();
                txt_tun_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUN"].ToString();
                txt_tcv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCV"].ToString();
                txt_tss_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSS"].ToString();
                txt_tit_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIT"].ToString();
                txt_tnc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TNC"].ToString();
                txt_aon_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AON"].ToString();
                txt_enm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ENM"].ToString();
                txt_eee_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEE"].ToString();
                txt_kkk_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_KKK"].ToString();
                txt_bbb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBB"].ToString();
                txt_ole_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OLE"].ToString();
                txt_trq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRQ"].ToString();
                txt_ert_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERT"].ToString();
                txt_rt3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT3"].ToString();
                txt_rt5_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT5"].ToString();
                txt_dnd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DND"].ToString();
                txt_dmo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DMO"].ToString();
                txt_pes_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PES"].ToString();
                txt_vrr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRR"].ToString();
                txt_tre_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRE"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()))
                {
                    txt_lme_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()))
                {
                    txt_ume_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()))
                {
                    txt_lpe_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()))
                {
                    txt_upe_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()))
                {
                    txt_ucv_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()))
                {
                    txt_lcv_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()))
                {
                    txt_dur_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()))
                {
                    txt_dft_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()))
                {
                    txt_lmc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()))
                {
                    txt_umc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()))
                {
                    txt_lpc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()))
                {
                    txt_upc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()))
                {
                    txt_cvc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()))
                {
                    txt_lvc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()))
                {
                    txt_dfc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()))
                {
                    txt_tfs_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()))
                {
                    txt_fsw_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()))
                {
                    txt_wfw_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()))
                {
                    txt_ybt_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()).ToString("0.0");
                }
                txt_eco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECO"].ToString();
                //txt_spx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPX"].ToString();

                cbo_gft_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_GFT"].ToString();
                cbo_hem_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_HEM"].ToString();
                txt_vaz_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAZ"].ToString();
                txt_cot_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COT"].ToString();
                txt_co2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CO2"].ToString();
                txt_coc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COC"].ToString();
                txt_cov_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COV"].ToString();
                txt_dim_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIM"].ToString();
                txt_rsq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RSQ"].ToString();
                txt_rlq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RLQ"].ToString();
                txt_rrm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RRM"].ToString();
                txt_rmx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMX"].ToString();
                txt_rmn_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMN"].ToString();
                txt_rmh_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMH"].ToString();
                txt_rqs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RQS"].ToString();
                txt_rty_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RTY"].ToString();
                txt_rhy_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RHY"].ToString();
                txt_eoc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOC"].ToString();
                txt_eoe_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOE"].ToString();
                txt_etc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETC"].ToString();
                txt_ete_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETE"].ToString();
                txt_ptn_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PTN"].ToString();
                txt_eol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
                txt_etu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
                txt_etd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
                txt_ecu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
                txt_egd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
                txt_eec_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
                txt_ecd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
                txt_egu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
                txt_eso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
                txt_esi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
                txt_ecr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
                txt_eod_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
                txt_eaw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
                txt_eol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
                txt_etu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
                txt_etd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
                txt_ecu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
                txt_egd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
                txt_eec_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
                txt_ecd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
                txt_egu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
                txt_eso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
                txt_esi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
                txt_ecr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
                txt_eod_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
                txt_eaw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
                txt_ed1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED1"].ToString();
                txt_ed2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED2"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString()))
                {
                    cbo_idd_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString();
                }

                txt_eta_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETA"].ToString();
                txt_eth_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETH"].ToString();
                txt_etg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETG"].ToString();
                txt_edt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDT"].ToString();
                txt_efp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EFP"].ToString();
                txt_eyt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EYT"].ToString();
                txt_edl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDL"].ToString();
                txt_eab_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAB"].ToString();
                txt_eca_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECA"].ToString();
                txt_ecw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECW"].ToString();
                txt_etl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETL"].ToString();
                txt_ett_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETT"].ToString();
                txt_ere_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERE"].ToString();
                txt_ele_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ELE"].ToString();
                txt_ept_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPT"].ToString();
                txt_epl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPL"].ToString();
              
                txt_pco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCO"].ToString();
                txt_pcv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCV"].ToString();
                txt_drt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DRT"].ToString();
                txt_tal_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAL"].ToString();
                txt_val_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAL"].ToString();
                txt_sje_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJE"].ToString();

                if (cbo_maq_tip_id_inc.SelectedItem.Text == "M900" || cbo_maq_tip_id_inc.SelectedItem.Text == "V900")
                {
                    cbo_ez1_ez2_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CTX"].ToString();
                    cbo_ez3_ez4_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CVX"].ToString();
                    cbo_ez5_ez6_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CVR"].ToString();
                }

                if (cbo_maq_tip_id_inc.SelectedItem.Text == "STAHLE")
                {
                    cbo_sta_z05_z08_z13_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CRC"].ToString();
                    cbo_sta_z01_z02_z04_z06_z14_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CRE"].ToString();
                    cbo_sta_z09_z10_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CTC"].ToString();
                    cbo_sta_z11_z12_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CTE"].ToString();
                    cbo_sta_z03_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CTS"].ToString();

                    if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CTN"].ToString()))
                    {
                        cbo_ctn_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_CTN"].ToString();
                    }
                }

                //TMT
                txt_mat_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT"].ToString();
                txt_can_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN"].ToString();
                txt_epu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU"].ToString();
                txt_per_mge_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE"].ToString();
                txt_mat_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_002"].ToString();
                txt_can_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_002"].ToString();
                txt_epu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_002"].ToString();
                txt_per_mge_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_002"].ToString();
                txt_mat_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_003"].ToString();
                txt_can_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_003"].ToString();
                txt_epu_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_003"].ToString();
                txt_per_mge_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_003"].ToString();
                txt_mat_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_004"].ToString();
                txt_can_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_004"].ToString();
                txt_epu_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_004"].ToString();
                txt_per_mge_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_004"].ToString();
                txt_hot_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_HOT"].ToString();
                txt_vrd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRD"].ToString();
                txt_acr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ACR"].ToString();
                txt_pen_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PEN"].ToString();
                txt_cra_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA"].ToString();
                txt_cle_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CLE"].ToString();
                txt_afo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AFO"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString()))
                {
                    ddl_tcu_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString();
                }
                txt_tar_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAR"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString()))
                {
                    ddl_tam_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString();
                }
                ddl_tam_inc_OnSelectedIndexChanged(sender, e);
                txt_std_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STD"].ToString();
                txt_stp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STP"].ToString();
                txt_ttd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTD"].ToString();
                txt_ttp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTP"].ToString();
                txt_ftd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTD"].ToString();
                txt_ftp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTP"].ToString();
                txt_itd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITD"].ToString();
                txt_itp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITP"].ToString();
                txt_xtd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTD"].ToString();
                txt_xtp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTP"].ToString();
                txt_ttr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTR"].ToString();
                txt_dtu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DTU"].ToString();
                txt_dpa_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DPA"].ToString();
                txt_cin_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CIN"].ToString();
                ddl_fr2_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR2"].ToString();
                txt_fr2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR2"].ToString();
                ddl_fr1_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR1"].ToString();
                txt_fr1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR1"].ToString();
                ddl_fr0_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR0"].ToString();
                txt_fr0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR0"].ToString();
                txt_ato_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ATO"].ToString();
                txt_tp1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP1"].ToString();
                txt_tp2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP2"].ToString();
                txt_tcp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCP"].ToString();
                txt_jf2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF2"].ToString();
                txt_ps2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS2"].ToString();
                txt_jf0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF0"].ToString();
                txt_ps0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS0"].ToString();
                txt_bba_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBA"].ToString();
                txt_gro_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_GRO"].ToString();
                txt_tcs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCS"].ToString();
                txt_cvp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP"].ToString();
                txt_ssv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSV"].ToString();
                txt_ssp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSP"].ToString();
                txt_tte_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_001"].ToString();
                txt_tte_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_002"].ToString();
                cbo_wpo_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_001"].ToString();
                cbo_wpo_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_002"].ToString();
                txt_dir_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_001"].ToString();
                txt_dir_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_002"].ToString();
                txt_cra_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_001"].ToString();
                txt_cra_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString()))
                {
                    cbo_ced_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString()))
                {
                    cbo_ced_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString();
                }
                txt_ted_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_001"].ToString();
                txt_ted_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_002"].ToString();
                txt_dle_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_001"].ToString();
                txt_dle_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_002"].ToString();
                txt_cti_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_001"].ToString();
                txt_cti_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_002"].ToString();
                txt_g1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_001"].ToString();
                txt_g1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_002"].ToString();
                txt_g1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_001"].ToString();
                txt_g1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_002"].ToString();
                txt_g2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_001"].ToString();
                txt_g2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_002"].ToString();
                txt_g2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_001"].ToString();
                txt_g2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_002"].ToString();
                txt_cvp_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_001"].ToString();
                txt_cvp_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_002"].ToString();
                txt_ocu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_001"].ToString();
                txt_ocu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_002"].ToString();
                txt_ucu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_001"].ToString();
                txt_ucu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_002"].ToString();
                txt_c1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_001"].ToString();
                txt_c1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_002"].ToString();
                txt_l1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_001"].ToString();
                txt_l1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_002"].ToString();
                txt_c1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_001"].ToString();
                txt_c1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_002"].ToString();
                txt_l1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_001"].ToString();
                txt_l1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_002"].ToString();
                txt_c2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_001"].ToString();
                txt_c2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_002"].ToString();
                txt_l2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_001"].ToString();
                txt_l2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_002"].ToString();
                txt_c2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_001"].ToString();
                txt_c2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_002"].ToString();
                txt_l2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_001"].ToString();
                txt_l2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_002"].ToString();
                txt_tsu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_001"].ToString();
                txt_tsu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_002"].ToString();
                txt_cvc_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_001"].ToString();
                txt_cvc_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_002"].ToString();
                txt_cvl_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_001"].ToString();
                txt_cvl_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_002"].ToString();
                txt_tle_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_001"].ToString();
                txt_tle_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString()))
                {
                    cbo_roi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString()))
                {
                    cbo_rr0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString();
                }
                cbo_rr0_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString()))
                {
                    cbo_r01_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString();
                }
                cbo_r01_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString()))
                {
                    cbo_rr1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString()))
                {
                    cbo_rr2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString()))
                {
                    cbo_r2a_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString()))
                {
                    cbo_rr3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString()))
                {
                    cbo_rwr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLY"].ToString()))
                {
                    cbo_ply_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLY"].ToString();
                }
                cbo_ply_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLF"].ToString()))
                {
                    cbo_plf_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLF"].ToString();
                }
                cbo_plf_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLL"].ToString()))
                {
                    cbo_pll_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLL"].ToString();
                }
                cbo_pll_inc_OnSelectedIndexChanged(sender, e);

                txt_det_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DET"].ToString();

                txt_obs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OBS"].ToString();
                cbo_sts_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_STS"].ToString();
                // Não permite salvar se o standard não está ativo
                if (cbo_sts_inc.SelectedItem.Text == "ATIVO")
                {
                    btSalvar.Enabled = true;
                }
                else
                {
                    btSalvar.Enabled = false;
                }

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
                    lb_usr_atl.Text = dsUsuario.Tables[0].Rows[0]["USR_NOM"].ToString();
                }
                dsUsuario.Dispose();

                lb_tms_atl.Text = dsStandard.Tables[0].Rows[0]["EPF_TMS_ATL"].ToString();
            }
            dsStandard.Dispose();
            Dispose();

            txt_dat_inc.Focus();
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
                //Sempre começa com versão 1 um novo Standard
                txt_vrs_inc.Text = "1";

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
        txt_lot_ref.Text = "";
        cbo_tit_poy_id.SelectedIndex = 0;
        txt_mge.Text = "";
        cbo_for_id.SelectedIndex = 0;
        //Excluído por solicitação do Wagner 11/07/2011
        //txt_vlc.Text = "";
        cbo_aps_id.SelectedIndex = 0;
        cbo_maq_tip_id.Text = "";
        cbo_ert_id.SelectedIndex = 0;
        cbo_sts.Text = "";

        txt_dat_inc.Text = "";
        txt_vrs_inc.Text = "";
        cbo_rsp_inc.SelectedIndex = 0;
        txt_lot_inc.Text = "";
        txt_lot_ref_inc.Text = "";
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        txt_des_inc.Text = "";
        txt_mge_inc.Text = "";
        txt_mge_002_inc.Text = "";
        txt_mge_003_inc.Text = "";
        txt_mge_004_inc.Text = "";
        txt_mge_des_001_inc.Text = "";
        txt_mge_des_002_inc.Text = "";
        txt_mge_des_003_inc.Text = "";
        txt_mge_des_004_inc.Text = "";
        cbo_for_id_inc.SelectedIndex = 0;
        cbo_for_002_id_inc.SelectedIndex = 0;
        cbo_for_003_id_inc.SelectedIndex = 0;
        cbo_for_004_id_inc.SelectedIndex = 0;
        txt_ege_001_inc.Text = "";
        txt_ege_002_inc.Text = "";
        txt_ege_003_inc.Text = "";
        txt_ege_004_inc.Text = "";
        txt_ege_des_001_inc.Text = "";
        txt_ege_des_002_inc.Text = "";
        txt_ege_des_003_inc.Text = "";
        txt_ege_des_004_inc.Text = "";
        cbo_eor_001_id_inc.SelectedIndex = 0;
        cbo_eor_002_id_inc.SelectedIndex = 0;
        cbo_eor_003_id_inc.SelectedIndex = 0;
        cbo_eor_004_id_inc.SelectedIndex = 0;
        //Excluído por solicitação do Wagner 11/07/2011
        //txt_vlc_inc.Text = "";
        cbo_aps_id_inc.SelectedIndex = 0;
        cbo_maq_tip_id_inc.SelectedIndex = 0;
        cbo_ert_id_inc.SelectedIndex = 0;
        txt_vw2_inc.Text = "";
        txt_egm_inc.Text = "";
        txt_dyy_inc.Text = "";
        txt_2wx_inc.Text = "";
        txt_3w3_inc.Text = "";
        txt_4w4_inc.Text = "";
        txt_agl_inc.Text = "";
        txt_tup_inc.Text = "";
        txt_veo_inc.Text = "";
        txt_t1t_inc.Text = "";
        txt_t1c_inc.Text = "";
        txt_t1l_inc.Text = "";
        txt_t2f_inc.Text = "";
        txt_sve_inc.Text = "";
        txt_stf_inc.Text = "";
        txt_stm_inc.Text = "";
        txt_sce_inc.Text = "";
        txt_sco_inc.Text = "";
        txt_sch_inc.Text = "";
        txt_scg_inc.Text = "";
        txt_see_inc.Text = "";
        txt_seo_inc.Text = "";
        txt_seh_inc.Text = "";
        txt_seg_inc.Text = "";
        txt_sjc_inc.Text = "";
        txt_sjt_inc.Text = "";
        txt_sjb_inc.Text = "";
        txt_spj_inc.Text = "";
        txt_sbc_inc.Text = "";
        txt_spo_inc.Text = "";
        txt_sva_inc.Text = "";
        txt_tgr_inc.Text = "";
        txt_tip_inc.Text = "";
        txt_dsb_inc.Text = "";
        txt_tca_inc.Text = "";
        txt_fmc_inc.Text = "";
        txt_1tb_inc.Text = "";
        txt_1pp_inc.Text = "";
        txt_2tb_inc.Text = "";
        txt_2pp_inc.Text = "";
        txt_cso_inc.Text = "";
        txt_esp_inc.Text = "";
        txt_tol_inc.Text = "";
        txt_p1c_inc.Text = "";
        txt_p2d_inc.Text = "";
        txt_p3d_inc.Text = "";
        txt_p4u_inc.Text = "";
        txt_mol_inc.Text = "";
        txt_tpd_inc.Text = "";
        txt_tt1_inc.Text = "";
        txt_tt2_inc.Text = "";
        txt_tt3_inc.Text = "";
        txt_t21_inc.Text = "";
        txt_tun_inc.Text = "";
        txt_tcv_inc.Text = "";
        txt_tss_inc.Text = "";
        txt_tit_inc.Text = "";
        txt_tnc_inc.Text = "";
        txt_aon_inc.Text = "";
        txt_enm_inc.Text = "";
        txt_eee_inc.Text = "";
        txt_kkk_inc.Text = "";
        txt_bbb_inc.Text = "";
        txt_ole_inc.Text = "";
        txt_trq_inc.Text = "";
        txt_ert_inc.Text = "";
        txt_rt3_inc.Text = "";
        txt_rt5_inc.Text = "";
        txt_dnd_inc.Text = "";
        txt_dmo_inc.Text = "";
        txt_pes_inc.Text = "";
        txt_vrr_inc.Text = "";
        txt_tre_inc.Text = "";
        txt_lme_inc.Text = "";
        txt_ume_inc.Text = "";
        txt_lpe_inc.Text = "";
        txt_upe_inc.Text = "";
        txt_ucv_inc.Text = "";
        txt_lcv_inc.Text = "";
        txt_dur_inc.Text = "";
        txt_dft_inc.Text = "";
        txt_lmc_inc.Text = "";
        txt_umc_inc.Text = "";
        txt_lpc_inc.Text = "";
        txt_upc_inc.Text = "";
        txt_cvc_inc.Text = "";
        txt_lvc_inc.Text = "";
        txt_dfc_inc.Text = "";
        txt_tfs_inc.Text = "";
        txt_fsw_inc.Text = "";
        txt_wfw_inc.Text = "";
        txt_ybt_inc.Text = "";
        txt_eco_inc.Text = "";
        //txt_spx_inc.Text = "";

        cbo_gft_inc.Text = "";
        cbo_hem_inc.Text = "";
        txt_vaz_inc.Text = "";
        txt_cot_inc.Text = "";
        txt_co2_inc.Text = "";
        txt_coc_inc.Text = "";
        txt_cov_inc.Text = "";
        txt_dim_inc.Text = "";
        txt_rsq_inc.Text = "";
        txt_rlq_inc.Text = "";
        txt_rrm_inc.Text = "";
        txt_rmx_inc.Text = "";
        txt_rmn_inc.Text = "";
        txt_rmh_inc.Text = "";
        txt_rqs_inc.Text = "";
        txt_rty_inc.Text = "";
        txt_rhy_inc.Text = "";
        txt_eoc_inc.Text = "";
        txt_eoe_inc.Text = "";
        txt_etc_inc.Text = "";
        txt_ete_inc.Text = "";
        txt_ptn_inc.Text = "";
        txt_eol_inc.Text = "";
        txt_etu_inc.Text = "";
        txt_etd_inc.Text = "";
        txt_ecu_inc.Text = "";
        txt_egd_inc.Text = "";
        txt_eec_inc.Text = "";
        txt_ecd_inc.Text = "";
        txt_egu_inc.Text = "";
        txt_eso_inc.Text = "";
        txt_esi_inc.Text = "";
        txt_ecr_inc.Text = "";
        txt_eod_inc.Text = "";
        txt_eaw_inc.Text = "";
        txt_ed1_inc.Text = "";
        txt_ed2_inc.Text = "";
        cbo_idd_inc.SelectedIndex = 0;
        txt_eta_inc.Text = "";
        txt_eth_inc.Text = "";
        txt_etg_inc.Text = "";
        txt_edt_inc.Text = "";
        txt_efp_inc.Text = "";
        txt_eyt_inc.Text = "";
        txt_edl_inc.Text = "";
        txt_eab_inc.Text = "";
        txt_eca_inc.Text = "";
        txt_ecw_inc.Text = "";
        txt_etl_inc.Text = "";
        txt_ett_inc.Text = "";
        txt_ere_inc.Text = "";
        txt_ele_inc.Text = "";
        txt_ept_inc.Text = "";
        txt_epl_inc.Text = "";
        txt_pco_inc.Text = "";
        txt_pcv_inc.Text = "";
        txt_drt_inc.Text = "";
        txt_tal_inc.Text = "";
        txt_val_inc.Text = "";
        txt_sje_inc.Text = "";

        //TMT
        txt_mat_inc.Text = "";
        txt_can_inc.Text = "";
        txt_epu_inc.Text = "";
        txt_per_mge_inc.Text = "";
        txt_mat_002_inc.Text = "";
        txt_can_002_inc.Text = "";
        txt_epu_002_inc.Text = "";
        txt_per_mge_002_inc.Text = "";
        txt_mat_003_inc.Text = "";
        txt_can_003_inc.Text = "";
        txt_epu_003_inc.Text = "";
        txt_per_mge_003_inc.Text = "";
        txt_mat_004_inc.Text = "";
        txt_can_004_inc.Text = "";
        txt_epu_004_inc.Text = "";
        txt_per_mge_004_inc.Text = "";
        txt_hot_inc.Text = "";
        txt_vrd_inc.Text = "";
        txt_acr_inc.Text = "";
        txt_pen_inc.Text = "";
        txt_cra_inc.Text = "";
        txt_cle_inc.Text = "";
        txt_afo_inc.Text = "";
        ddl_tcu_inc.SelectedIndex = 0;
        txt_tar_inc.Text = "";
        ddl_tam_inc.Text = "";
        txt_std_inc.Text = "";
        txt_stp_inc.Text = "";
        txt_ttd_inc.Text = "";
        txt_ttp_inc.Text = "";
        txt_ftd_inc.Text = "";
        txt_ftp_inc.Text = "";
        txt_itd_inc.Text = "";
        txt_itp_inc.Text = "";
        txt_xtd_inc.Text = "";
        txt_xtp_inc.Text = "";
        txt_ttr_inc.Text = "";
        txt_dtu_inc.Text = "";
        txt_dpa_inc.Text = "";
        txt_cin_inc.Text = "";
        ddl_fr2_inc.SelectedIndex = 0;
        txt_fr2_inc.Text = "";
        ddl_fr1_inc.SelectedIndex = 0;
        txt_fr1_inc.Text = "";
        ddl_fr0_inc.SelectedIndex = 0;
        txt_fr0_inc.Text = "";
        txt_ato_inc.Text = "";
        txt_tp1_inc.Text = "";
        txt_tp2_inc.Text = "";
        txt_tcp_inc.Text = "";
        txt_jf2_inc.Text = "";
        txt_ps2_inc.Text = "";
        txt_jf0_inc.Text = "";
        txt_ps0_inc.Text = "";
        txt_bba_inc.Text = "";
        txt_gro_inc.Text = "";
        txt_tcs_inc.Text = "";
        txt_cvp_inc.Text = "";
        txt_ssv_inc.Text = "";
        txt_ssp_inc.Text = "";
        txt_tte_001_inc.Text = "";
        txt_tte_002_inc.Text = "";
        cbo_wpo_001_inc.Text = "";
        cbo_wpo_002_inc.Text = "";
        txt_dir_001_inc.Text = "";
        txt_dir_002_inc.Text = "";
        txt_cra_001_inc.Text = "";
        txt_cra_002_inc.Text = "";
        cbo_ced_001_inc.SelectedIndex = 0;
        cbo_ced_002_inc.SelectedIndex = 0;
        txt_ted_001_inc.Text = "";
        txt_ted_002_inc.Text = "";
        txt_dle_001_inc.Text = "";
        txt_dle_002_inc.Text = "";
        txt_cti_001_inc.Text = "";
        txt_cti_002_inc.Text = "";
        txt_g1o_001_inc.Text = "";
        txt_g1o_002_inc.Text = "";
        txt_g1u_001_inc.Text = "";
        txt_g1u_002_inc.Text = "";
        txt_g2o_001_inc.Text = "";
        txt_g2o_002_inc.Text = "";
        txt_g2u_001_inc.Text = "";
        txt_g2u_002_inc.Text = "";
        txt_cvp_001_inc.Text = "";
        txt_cvp_002_inc.Text = "";
        txt_ocu_001_inc.Text = "";
        txt_ocu_002_inc.Text = "";
        txt_ucu_001_inc.Text = "";
        txt_ucu_002_inc.Text = "";
        txt_c1o_001_inc.Text = "";
        txt_c1o_002_inc.Text = "";
        txt_l1o_001_inc.Text = "";
        txt_l1o_002_inc.Text = "";
        txt_c1u_001_inc.Text = "";
        txt_c1u_002_inc.Text = "";
        txt_l1u_001_inc.Text = "";
        txt_l1u_002_inc.Text = "";
        txt_c2o_001_inc.Text = "";
        txt_c2o_002_inc.Text = "";
        txt_l2o_001_inc.Text = "";
        txt_l2o_002_inc.Text = "";
        txt_c2u_001_inc.Text = "";
        txt_c2u_002_inc.Text = "";
        txt_l2u_001_inc.Text = "";
        txt_l2u_002_inc.Text = "";
        txt_tsu_001_inc.Text = "";
        txt_tsu_002_inc.Text = "";
        txt_cvc_001_inc.Text = "";
        txt_cvc_002_inc.Text = "";
        txt_cvl_001_inc.Text = "";
        txt_cvl_002_inc.Text = "";
        txt_tle_001_inc.Text = "";
        txt_tle_002_inc.Text = "";
        cbo_roi_inc.SelectedIndex = 0;
        cbo_rr0_inc.SelectedIndex = 0;
        cbo_r01_inc.SelectedIndex = 0;
        cbo_rr1_inc.SelectedIndex = 0;
        cbo_rr2_inc.SelectedIndex = 0;
        cbo_r2a_inc.SelectedIndex = 0;
        cbo_rr3_inc.SelectedIndex = 0;
        cbo_rwr_inc.SelectedIndex = 0;
        cbo_ply_inc.SelectedIndex = 0;
        cbo_plf_inc.SelectedIndex = 0;
        cbo_pll_inc.SelectedIndex = 0;

        txt_det_inc.Text = "";

        txt_obs_inc.Text = "";
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

        //Sempre começa com versão 1 um novo Standard
        txt_vrs_inc.Text = "1";

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
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Standard.EPF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Standard.EPF_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id.Text))
        {
            Standard.EPF_FOR_ID = Convert.ToInt32(cbo_for_id.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";
        }
        //Excluído por solicitação do Wagner 11/07/2011
        //
        /*
        if (!String.IsNullOrEmpty(txt_vlc.Text))
        {
            Standard.EPF_VLC = txt_vlc.Text;
            filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";
        }
        */
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Standard.EPF_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Standard.EPF_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id.Text))
        {
            Standard.EPF_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id.SelectedItem.Text + "; ";
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
        string[] afiltro = filtro.Split(';');
        if ((filtro == "") || ((txt_lot.Text == "") && ((afiltro.Length - 1) < 2)))
        {
            TratamentoErro("O Filtro deve possuir o Lote ou outros dois argumentos.");
            txt_dat.Focus();
            return;
        }

        DataSet dsStandard = Standard.Consultar();

        gvStandard.DataSource = dsStandard;
        gvStandard.DataBind();
        dsStandard.Dispose();
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

    protected void gvStandard_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvStandard.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvStandard.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Standard.aspx?rowId=" + gvStandard.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvStandard.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvStandard.Columns.IndexOf(field);
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

    protected void gvStandard_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvStandard_Sorting(Object sender, GridViewSortEventArgs e)
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

        Standard Standard = new Standard();
        filtro = CriaFiltro(Standard);
        DataSet dsStandard = Standard.Consultar();

        DataTable dtStandard = dsStandard.Tables[0];
        DataView dvStandard = new DataView(dtStandard);
        dvStandard.Sort = e.SortExpression + Ordem;
        gvStandard.DataSource = dvStandard;
        gvStandard.DataBind();

        dvStandard.Dispose();
        dtStandard.Dispose();
        dsStandard.Dispose();
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

        if (cbo_rsp_inc.Text == "")
        {
            TratamentoErro("O campo Responsável é obrigatório.");
            cbo_rsp_inc.Focus();
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
            TratamentoErro("O campo Título é obrigatório.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

        if (txt_des_inc.Text == "")
        {
            TratamentoErro("O campo Descrição é obrigatório.");
            txt_des_inc.Focus();
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
        //Excluído por solicitação do Wagner 11/07/2011
        /*
        if (txt_vlc_inc.Text == "")
        {
            TratamentoErro("O campo Velocidade é obrigatório.");
            txt_vlc_inc.Focus();
            return;
        }
        */
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

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }

        Standard Standard = new Standard();
        if (txt_dat_inc.Text != "")
        {
            Standard.EPF_DAT = Convert.ToDateTime(txt_dat_inc.Text);
        }
        Standard.EPF_VRS = Convert.ToInt32(txt_vrs_inc.Text);
        if (cbo_rsp_inc.Text != "")
        {
            Standard.EPF_RSP_USR_ID = Convert.ToInt32(cbo_rsp_inc.SelectedValue);
        }
        Standard.EPF_LOT = txt_lot_inc.Text;
        Standard.EPF_LOT_REF = txt_lot_ref_inc.Text;
        if (cbo_tit_poy_id_inc.Text != "")
        {
            Standard.EPF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
        }
        Standard.EPF_DES = txt_des_inc.Text;
        Standard.EPF_MGE = txt_mge_inc.Text;
        Standard.EPF_MGE_002 = txt_mge_002_inc.Text;
        Standard.EPF_MGE_003 = txt_mge_003_inc.Text;
        Standard.EPF_MGE_004 = txt_mge_004_inc.Text;
        Standard.EPF_MGE_DES_001 = txt_mge_des_001_inc.Text;
        Standard.EPF_MGE_DES_002 = txt_mge_des_002_inc.Text;
        Standard.EPF_MGE_DES_003 = txt_mge_des_003_inc.Text;
        Standard.EPF_MGE_DES_004 = txt_mge_des_004_inc.Text;
        if (cbo_for_id_inc.Text != "")
        {
            Standard.EPF_FOR_ID = Convert.ToInt32(cbo_for_id_inc.SelectedValue);
        }
        if (cbo_for_002_id_inc.Text != "")
        {
            Standard.EPF_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
        }
        if (cbo_for_003_id_inc.Text != "")
        {
            Standard.EPF_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
        }
        if (cbo_for_004_id_inc.Text != "")
        {
            Standard.EPF_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
        }
        Standard.EPF_EGE_001 = txt_ege_001_inc.Text;
        Standard.EPF_EGE_002 = txt_ege_002_inc.Text;
        Standard.EPF_EGE_003 = txt_ege_003_inc.Text;
        Standard.EPF_EGE_004 = txt_ege_004_inc.Text;
        Standard.EPF_EGE_DES_001 = txt_ege_des_001_inc.Text;
        Standard.EPF_EGE_DES_002 = txt_ege_des_002_inc.Text;
        Standard.EPF_EGE_DES_003 = txt_ege_des_003_inc.Text;
        Standard.EPF_EGE_DES_004 = txt_ege_des_004_inc.Text;
        if (cbo_eor_001_id_inc.Text != "")
        {
            Standard.EPF_EOR_001_ID = Convert.ToInt32(cbo_eor_001_id_inc.SelectedValue);
        }
        if (cbo_eor_002_id_inc.Text != "")
        {
            Standard.EPF_EOR_002_ID = Convert.ToInt32(cbo_eor_002_id_inc.SelectedValue);
        }
        if (cbo_eor_003_id_inc.Text != "")
        {
            Standard.EPF_EOR_003_ID = Convert.ToInt32(cbo_eor_003_id_inc.SelectedValue);
        }
        if (cbo_eor_004_id_inc.Text != "")
        {
            Standard.EPF_EOR_004_ID = Convert.ToInt32(cbo_eor_004_id_inc.SelectedValue);
        }
        //Excluído por solicitação do Wagner 11/07/2011
        //Standard.EPF_VLC = txt_vlc_inc.Text;
        if (cbo_aps_id_inc.Text != "")
        {
            Standard.EPF_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
        }
        if (cbo_maq_tip_id_inc.Text != "")
        {
            Standard.EPF_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
        }
        if (cbo_ert_id_inc.Text != "")
        {
            Standard.EPF_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
        }
        Standard.EPF_VW2 = txt_vw2_inc.Text;
        Standard.EPF_EGM = txt_egm_inc.Text;
        Standard.EPF_DYY = txt_dyy_inc.Text;
        Standard.EPF_2WX = txt_2wx_inc.Text;
        Standard.EPF_3W3 = txt_3w3_inc.Text;
        Standard.EPF_4W4 = txt_4w4_inc.Text;
        Standard.EPF_AGL = txt_agl_inc.Text;
        Standard.EPF_TUP = txt_tup_inc.Text;
        Standard.EPF_VEO = txt_veo_inc.Text;
        Standard.EPF_T1T = txt_t1t_inc.Text;
        Standard.EPF_T1C = txt_t1c_inc.Text;
        Standard.EPF_T1L = txt_t1l_inc.Text;
        Standard.EPF_T2F = txt_t2f_inc.Text;
        Standard.EPF_SVE = txt_sve_inc.Text;
        Standard.EPF_STF = txt_stf_inc.Text;
        Standard.EPF_STM = txt_stm_inc.Text;
        Standard.EPF_SCE = txt_sce_inc.Text;
        Standard.EPF_SCO = txt_sco_inc.Text;
        Standard.EPF_SCH = txt_sch_inc.Text;
        Standard.EPF_SCG = txt_scg_inc.Text;
        Standard.EPF_SEE = txt_see_inc.Text;
        Standard.EPF_SEO = txt_seo_inc.Text;
        Standard.EPF_SEH = txt_seh_inc.Text;
        Standard.EPF_SEG = txt_seg_inc.Text;
        Standard.EPF_SJC = txt_sjc_inc.Text;
        Standard.EPF_SJT = txt_sjt_inc.Text;
        Standard.EPF_SJB = txt_sjb_inc.Text;
        Standard.EPF_SPJ = txt_spj_inc.Text;
        Standard.EPF_SBC = txt_sbc_inc.Text;
        Standard.EPF_SPO = txt_spo_inc.Text;
        Standard.EPF_SVA = txt_sva_inc.Text;
        Standard.EPF_TGR = txt_tgr_inc.Text;
        Standard.EPF_TIP = txt_tip_inc.Text;
        Standard.EPF_DSB = txt_dsb_inc.Text;
        Standard.EPF_TCA = txt_tca_inc.Text;
        Standard.EPF_FMC = txt_fmc_inc.Text;
        Standard.EPF_1TB = txt_1tb_inc.Text;
        Standard.EPF_1PP = txt_1pp_inc.Text;
        Standard.EPF_2TB = txt_2tb_inc.Text;
        Standard.EPF_2PP = txt_2pp_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_inc.Text))
        {
            Standard.EPF_CSO = Convert.ToDouble(txt_cso_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_inc.Text))
        {
            Standard.EPF_ESP = Convert.ToDouble(txt_esp_inc.Text);
        }
        Standard.EPF_TOL = txt_tol_inc.Text;
        Standard.EPF_P1C = txt_p1c_inc.Text;
        Standard.EPF_P2D = txt_p2d_inc.Text;
        Standard.EPF_P3D = txt_p3d_inc.Text;
        Standard.EPF_P4U = txt_p4u_inc.Text;
        Standard.EPF_MOL = txt_mol_inc.Text;
        Standard.EPF_TPD = txt_tpd_inc.Text;
        Standard.EPF_TT1 = txt_tt1_inc.Text;
        Standard.EPF_TT2 = txt_tt2_inc.Text;
        Standard.EPF_TT3 = txt_tt3_inc.Text;
        Standard.EPF_T21 = txt_t21_inc.Text;
        Standard.EPF_TUN = txt_tun_inc.Text;
        Standard.EPF_TCV = txt_tcv_inc.Text;
        Standard.EPF_TSS = txt_tss_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_inc.Text))
        {
            Standard.EPF_TIT = Convert.ToDouble(txt_tit_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_inc.Text))
        {
            Standard.EPF_TNC = Convert.ToDouble(txt_tnc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_inc.Text))
        {
            Standard.EPF_AON = Convert.ToDouble(txt_aon_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_inc.Text))
        {
            Standard.EPF_ENM = Convert.ToDouble(txt_enm_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_inc.Text))
        {
            Standard.EPF_EEE = Convert.ToDouble(txt_eee_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_inc.Text))
        {
            Standard.EPF_KKK = Convert.ToDouble(txt_kkk_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_inc.Text))
        {
            Standard.EPF_BBB = Convert.ToDouble(txt_bbb_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_inc.Text))
        {
            Standard.EPF_OLE = Convert.ToDouble(txt_ole_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_inc.Text))
        {
            Standard.EPF_TRQ = Convert.ToDouble(txt_trq_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_inc.Text))
        {
            Standard.EPF_ERT = Convert.ToDouble(txt_ert_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_inc.Text))
        {
            Standard.EPF_RT3 = Convert.ToDouble(txt_rt3_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_inc.Text))
        {
            Standard.EPF_RT5 = Convert.ToDouble(txt_rt5_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_inc.Text))
        {
            Standard.EPF_DND = Convert.ToDouble(txt_dnd_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_inc.Text))
        {
            Standard.EPF_DMO = Convert.ToDouble(txt_dmo_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_inc.Text))
        {
            Standard.EPF_PES = Convert.ToDouble(txt_pes_inc.Text);
        }
        Standard.EPF_VRR = txt_vrr_inc.Text;

        Standard.EPF_TRE = txt_tre_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_inc.Text))
        {
            Standard.EPF_LME = Convert.ToDouble(txt_lme_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_inc.Text))
        {
            Standard.EPF_UME = Convert.ToDouble(txt_ume_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_inc.Text))
        {
            Standard.EPF_LPE = Convert.ToDouble(txt_lpe_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_inc.Text))
        {
            Standard.EPF_UPE = Convert.ToDouble(txt_upe_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_inc.Text))
        {
            Standard.EPF_UCV = Convert.ToDouble(txt_ucv_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lcv_inc.Text))
        {
            Standard.EPF_LCV = Convert.ToDouble(txt_lcv_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_inc.Text))
        {
            Standard.EPF_DUR = Convert.ToDouble(txt_dur_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_inc.Text))
        {
            Standard.EPF_DFT = Convert.ToDouble(txt_dft_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_inc.Text))
        {
            Standard.EPF_LMC = Convert.ToDouble(txt_lmc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_inc.Text))
        {
            Standard.EPF_UMC = Convert.ToDouble(txt_umc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_inc.Text))
        {
            Standard.EPF_LPC = Convert.ToDouble(txt_lpc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_inc.Text))
        {
            Standard.EPF_UPC = Convert.ToDouble(txt_upc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_inc.Text))
        {
            Standard.EPF_CVC = Convert.ToDouble(txt_cvc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lvc_inc.Text))
        {
            Standard.EPF_LVC = Convert.ToDouble(txt_lvc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_inc.Text))
        {
            Standard.EPF_DFC = Convert.ToDouble(txt_dfc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_inc.Text))
        {
            Standard.EPF_TFS = Convert.ToDouble(txt_tfs_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_inc.Text))
        {
            Standard.EPF_FSW = Convert.ToDouble(txt_fsw_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_inc.Text))
        {
            Standard.EPF_WFW = Convert.ToDouble(txt_wfw_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ybt_inc.Text))
        {
            Standard.EPF_YBT = Convert.ToDouble(txt_ybt_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_inc.Text))
        {
            Standard.EPF_ECO = Convert.ToDouble(txt_eco_inc.Text);
        }
        //if (!string.IsNullOrEmpty(txt_spx_inc.Text))
        //{
        //    Standard.EPF_SPX = Convert.ToDouble(txt_spx_inc.Text);
        //}

        Standard.EPF_GFT = cbo_gft_inc.Text;
        Standard.EPF_HEM = cbo_hem_inc.Text;
        if (!string.IsNullOrEmpty(txt_vaz_inc.Text))
        {
            Standard.EPF_VAZ = Convert.ToDouble(txt_vaz_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cot_inc.Text))
        {
            Standard.EPF_COT = txt_cot_inc.Text;
        }
        if (!string.IsNullOrEmpty(txt_co2_inc.Text))
        {
            Standard.EPF_CO2 = Convert.ToDouble(txt_co2_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_coc_inc.Text))
        {
            Standard.EPF_COC = Convert.ToDouble(txt_coc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cov_inc.Text))
        {
            Standard.EPF_COV = Convert.ToDouble(txt_cov_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dim_inc.Text))
        {
            Standard.EPF_DIM = Convert.ToDouble(txt_dim_inc.Text);
        }
        Standard.EPF_RSQ = txt_rsq_inc.Text;
        Standard.EPF_RLQ = txt_rlq_inc.Text;
        if (!string.IsNullOrEmpty(txt_rrm_inc.Text))
        {
            Standard.EPF_RRM = Convert.ToInt32(txt_rrm_inc.Text);
        }
        Standard.EPF_RMX = txt_rmx_inc.Text;
        Standard.EPF_RMN = txt_rmn_inc.Text;
        Standard.EPF_RMH = txt_rmh_inc.Text;
        Standard.EPF_RQS = txt_rqs_inc.Text;
        if (!string.IsNullOrEmpty(txt_rty_inc.Text))
        {
            Standard.EPF_RTY = Convert.ToInt32(txt_rty_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rhy_inc.Text))
        {
            Standard.EPF_RHY = Convert.ToInt32(txt_rhy_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eoc_inc.Text))
        {
            Standard.EPF_EOC = Convert.ToInt32(txt_eoc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eoe_inc.Text))
        {
            Standard.EPF_EOE = Convert.ToInt32(txt_eoe_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_etc_inc.Text))
        {
            Standard.EPF_ETC = Convert.ToInt32(txt_etc_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ete_inc.Text))
        {
            Standard.EPF_ETE = Convert.ToInt32(txt_ete_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ptn_inc.Text))
        {
            Standard.EPF_PTN = Convert.ToInt32(txt_ptn_inc.Text);
        }
        Standard.EPF_EOL = txt_eol_inc.Text;
        Standard.EPF_ETU = txt_etu_inc.Text;
        Standard.EPF_ETD = txt_etd_inc.Text;
        Standard.EPF_ECU = txt_ecu_inc.Text;
        Standard.EPF_EGD = txt_egd_inc.Text;
        Standard.EPF_EEC = txt_eec_inc.Text;
        Standard.EPF_ECD = txt_ecd_inc.Text;
        Standard.EPF_EGU = txt_egu_inc.Text;
        Standard.EPF_ESO = txt_eso_inc.Text;
        Standard.EPF_ESI = txt_esi_inc.Text;
        Standard.EPF_ECR = txt_ecr_inc.Text;
        Standard.EPF_EOD = txt_eod_inc.Text;
        Standard.EPF_EAW = txt_eaw_inc.Text;
        Standard.EPF_ED1 = txt_ed1_inc.Text;
        Standard.EPF_ED2 = txt_ed2_inc.Text;
        if (cbo_idd_inc.Text != "")
        {
            Standard.EPF_IDD = cbo_idd_inc.SelectedValue;
        }

        Standard.EPF_ETA = txt_eta_inc.Text;
        Standard.EPF_ETH = txt_eth_inc.Text;
        Standard.EPF_ETG = txt_etg_inc.Text;
        Standard.EPF_EDT = txt_edt_inc.Text;
        Standard.EPF_EFP = txt_efp_inc.Text;
        Standard.EPF_EYT = txt_eyt_inc.Text;
        Standard.EPF_EDL = txt_edl_inc.Text;
        Standard.EPF_EAB = txt_eab_inc.Text;
        Standard.EPF_ECA = txt_eca_inc.Text;
        Standard.EPF_ECW = txt_ecw_inc.Text;
        Standard.EPF_ETL = txt_etl_inc.Text;
        Standard.EPF_ETT = txt_ett_inc.Text;
        Standard.EPF_ERE = txt_ere_inc.Text;
        Standard.EPF_ELE = txt_ele_inc.Text;
        Standard.EPF_EPT = txt_ept_inc.Text;
        Standard.EPF_EPL = txt_epl_inc.Text;

        Standard.EPF_PCO = txt_pco_inc.Text;
        Standard.EPF_PCV = txt_pcv_inc.Text;
        Standard.EPF_DRT = txt_drt_inc.Text;
        Standard.EPF_TAL = txt_tal_inc.Text;
        Standard.EPF_VAL = txt_val_inc.Text;
        Standard.EPF_SJE = txt_sje_inc.Text;

        if (cbo_ez1_ez2_inc.Text != "")
        {
            Standard.EPF_CTX = Convert.ToInt32(cbo_ez1_ez2_inc.SelectedValue);
        }
        if (cbo_ez3_ez4_inc.Text != "")
        {
            Standard.EPF_CVX = Convert.ToInt32(cbo_ez3_ez4_inc.SelectedValue);
        }
        if (cbo_ez5_ez6_inc.Text != "")
        {
            Standard.EPF_CVR = Convert.ToInt32(cbo_ez5_ez6_inc.SelectedValue);
        }

        if (cbo_sta_z05_z08_z13_inc.Text != "")
        {
            Standard.EPF_CRC = Convert.ToInt32(cbo_sta_z05_z08_z13_inc.SelectedValue);
        }
        if (cbo_sta_z01_z02_z04_z06_z14_inc.Text != "")
        {
            Standard.EPF_CRE = Convert.ToInt32(cbo_sta_z01_z02_z04_z06_z14_inc.SelectedValue);
        }
        if (cbo_sta_z09_z10_inc.Text != "")
        {
            Standard.EPF_CTC = Convert.ToInt32(cbo_sta_z09_z10_inc.SelectedValue);
        }
        if (cbo_sta_z11_z12_inc.Text != "")
        {
            Standard.EPF_CTE = Convert.ToInt32(cbo_sta_z11_z12_inc.SelectedValue);
        }
        if (cbo_sta_z03_inc.Text != "")
        {
            Standard.EPF_CTS = Convert.ToInt32(cbo_sta_z03_inc.SelectedValue);
        }
        if (cbo_ctn_inc.Text != "")
        {
            Standard.EPF_CTN = Convert.ToInt32(cbo_ctn_inc.SelectedValue);
        }

        Standard.EPF_MAT = txt_mat_inc.Text;
        Standard.EPF_CAN = txt_can_inc.Text;
        Standard.EPF_EPU = txt_epu_inc.Text;
        if (!string.IsNullOrEmpty(txt_per_mge_inc.Text))
        {
            Standard.EPF_PER_MGE = Convert.ToDouble(txt_per_mge_inc.Text);
        }
        Standard.EPF_MAT_002 = txt_mat_002_inc.Text;
        Standard.EPF_CAN_002 = txt_can_002_inc.Text;
        Standard.EPF_EPU_002 = txt_epu_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_per_mge_002_inc.Text))
        {
            Standard.EPF_PER_MGE_002 = Convert.ToDouble(txt_per_mge_002_inc.Text);
        }
        Standard.EPF_MAT_003 = txt_mat_003_inc.Text;
        Standard.EPF_CAN_003 = txt_can_003_inc.Text;
        Standard.EPF_EPU_003 = txt_epu_003_inc.Text;
        if (!string.IsNullOrEmpty(txt_per_mge_003_inc.Text))
        {
            Standard.EPF_PER_MGE_003 = Convert.ToDouble(txt_per_mge_003_inc.Text);
        }
        Standard.EPF_MAT_004 = txt_mat_004_inc.Text;
        Standard.EPF_CAN_004 = txt_can_004_inc.Text;
        Standard.EPF_EPU_004 = txt_epu_004_inc.Text;
        if (!string.IsNullOrEmpty(txt_per_mge_004_inc.Text))
        {
            Standard.EPF_PER_MGE_004 = Convert.ToDouble(txt_per_mge_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_hot_inc.Text))
        {
            Standard.EPF_HOT = Convert.ToInt32(txt_hot_inc.Text);
        }
        Standard.EPF_VRD = txt_vrd_inc.Text;
        if (!string.IsNullOrEmpty(txt_acr_inc.Text))
        {
            Standard.EPF_ACR = Convert.ToInt32(txt_acr_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pen_inc.Text))
        {
            Standard.EPF_PEN = Convert.ToInt32(txt_pen_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cra_inc.Text))
        {
            Standard.EPF_CRA = Convert.ToInt32(txt_cra_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cle_inc.Text))
        {
            Standard.EPF_CLE = Convert.ToInt32(txt_cle_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_afo_inc.Text))
        {
            Standard.EPF_AFO = Convert.ToInt32(txt_afo_inc.Text);
        }
        Standard.EPF_TCU = ddl_tcu_inc.SelectedValue;
        Standard.EPF_TAR = txt_tar_inc.Text;
        Standard.EPF_TAM = ddl_tam_inc.SelectedValue;
        Standard.EPF_STD = txt_std_inc.Text;
        Standard.EPF_STP = txt_stp_inc.Text;
        Standard.EPF_TTD = txt_ttd_inc.Text;
        Standard.EPF_TTP = txt_ttp_inc.Text;
        Standard.EPF_FTD = txt_ftd_inc.Text;
        Standard.EPF_FTP = txt_ftp_inc.Text;
        Standard.EPF_ITD = txt_itd_inc.Text;
        Standard.EPF_ITP = txt_itp_inc.Text;
        Standard.EPF_XTD = txt_xtd_inc.Text;
        Standard.EPF_XTP = txt_xtp_inc.Text;
        Standard.EPF_TTR = txt_ttr_inc.Text;
        if (!string.IsNullOrEmpty(txt_dtu_inc.Text))
        {
            Standard.EPF_DTU = Convert.ToInt32(txt_dtu_inc.Text);
        }
            if (!string.IsNullOrEmpty(txt_dpa_inc.Text))
        {
            Standard.EPF_DPA = Convert.ToInt32(txt_dpa_inc.Text);
        }
            if (!string.IsNullOrEmpty(txt_cin_inc.Text))
        {
            Standard.EPF_CIN = Convert.ToInt32(txt_cin_inc.Text);
        }
        Standard.EPF_TIP_FR2 = ddl_fr2_inc.Text;
        Standard.EPF_FR2 = txt_fr2_inc.Text;
        Standard.EPF_TIP_FR1 = ddl_fr1_inc.Text;
        Standard.EPF_FR1 = txt_fr1_inc.Text;
        Standard.EPF_TIP_FR0 = ddl_fr0_inc.Text;
        Standard.EPF_FR0 = txt_fr0_inc.Text;
        if (!string.IsNullOrEmpty(txt_ato_inc.Text))
        {
            Standard.EPF_ATO = Convert.ToInt32(txt_ato_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tp1_inc.Text))
        {
            Standard.EPF_TP1 = Convert.ToDouble(txt_tp1_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tp2_inc.Text))
        {
            Standard.EPF_TP2 = Convert.ToDouble(txt_tp2_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tcp_inc.Text))
        {
            Standard.EPF_TCP = Convert.ToInt32(txt_tcp_inc.Text);
        }
        Standard.EPF_JF2 = txt_jf2_inc.Text;
        if (!string.IsNullOrEmpty(txt_ps2_inc.Text))
        {
            Standard.EPF_PS2 = Convert.ToInt32(txt_ps2_inc.Text);
        }
        Standard.EPF_JF0 = txt_jf0_inc.Text;
        if (!string.IsNullOrEmpty(txt_ps0_inc.Text))
        {
            Standard.EPF_PS0 = Convert.ToInt32(txt_ps0_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bba_inc.Text))
        {
            Standard.EPF_BBA = Convert.ToDouble(txt_bba_inc.Text);
        }
        Standard.EPF_GRO = txt_gro_inc.Text;
        Standard.EPF_TCS = txt_tcs_inc.Text;
        Standard.EPF_CVP = txt_cvp_inc.Text;
        if (!string.IsNullOrEmpty(txt_ssv_inc.Text))
        {
            Standard.EPF_SSV = Convert.ToInt32(txt_ssv_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ssp_inc.Text))
        {
            Standard.EPF_SSP = Convert.ToInt32(txt_ssp_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tte_001_inc.Text))
        {
            Standard.EPF_TTE_001 = Convert.ToDouble(txt_tte_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tte_002_inc.Text))
        {
            Standard.EPF_TTE_002 = Convert.ToDouble(txt_tte_002_inc.Text);
        }
        Standard.EPF_WPO_001 = cbo_wpo_001_inc.Text;
        Standard.EPF_WPO_002 = cbo_wpo_002_inc.Text;
        Standard.EPF_DIR_001 = txt_dir_001_inc.Text;
        Standard.EPF_DIR_002 = txt_dir_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_cra_001_inc.Text))
        {
            Standard.EPF_CRA_001 = Convert.ToInt32(txt_cra_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cra_002_inc.Text))
        {
            Standard.EPF_CRA_002 = Convert.ToInt32(txt_cra_002_inc.Text);
        }
        Standard.EPF_CED_001 = cbo_ced_001_inc.Text;
        Standard.EPF_CED_002 = cbo_ced_002_inc.Text;
        Standard.EPF_TED_001 = txt_ted_001_inc.Text;
        Standard.EPF_TED_002 = txt_ted_002_inc.Text;
        Standard.EPF_DLE_001 = txt_dle_001_inc.Text;
        Standard.EPF_DLE_002 = txt_dle_002_inc.Text;
        Standard.EPF_CTI_001 = txt_cti_001_inc.Text;
        Standard.EPF_CTI_002 = txt_cti_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_g1o_001_inc.Text))
        {
            Standard.EPF_G1O_001 = Convert.ToInt32(txt_g1o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g1o_002_inc.Text))
        {
            Standard.EPF_G1O_002 = Convert.ToInt32(txt_g1o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g1u_001_inc.Text))
        {
            Standard.EPF_G1U_001 = Convert.ToInt32(txt_g1u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g1u_002_inc.Text))
        {
            Standard.EPF_G1U_002 = Convert.ToInt32(txt_g1u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g2o_001_inc.Text))
        {
            Standard.EPF_G2O_001 = Convert.ToInt32(txt_g2o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g2o_002_inc.Text))
        {
            Standard.EPF_G2O_002 = Convert.ToInt32(txt_g2o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g2u_001_inc.Text))
        {
            Standard.EPF_G2U_001 = Convert.ToInt32(txt_g2u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_g2u_002_inc.Text))
        {
            Standard.EPF_G2U_002 = Convert.ToInt32(txt_g2u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvp_001_inc.Text))
        {
            Standard.EPF_CVP_001 = Convert.ToInt32(txt_cvp_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvp_002_inc.Text))
        {
            Standard.EPF_CVP_002 = Convert.ToInt32(txt_cvp_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ocu_001_inc.Text))
        {
            Standard.EPF_OCU_001 = Convert.ToInt32(txt_ocu_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ocu_002_inc.Text))
        {
            Standard.EPF_OCU_002 = Convert.ToInt32(txt_ocu_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucu_001_inc.Text))
        {
            Standard.EPF_UCU_001 = Convert.ToInt32(txt_ucu_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucu_002_inc.Text))
        {
            Standard.EPF_UCU_002 = Convert.ToInt32(txt_ucu_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c1o_001_inc.Text))
        {
            Standard.EPF_C1O_001 = Convert.ToInt32(txt_c1o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c1o_002_inc.Text))
        {
            Standard.EPF_C1O_002 = Convert.ToInt32(txt_c1o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l1o_001_inc.Text))
        {
            Standard.EPF_L1O_001 = Convert.ToInt32(txt_l1o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l1o_002_inc.Text))
        {
            Standard.EPF_L1O_002 = Convert.ToInt32(txt_l1o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c1u_001_inc.Text))
        {
            Standard.EPF_C1U_001 = Convert.ToInt32(txt_c1u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c1u_002_inc.Text))
        {
            Standard.EPF_C1U_002 = Convert.ToInt32(txt_c1u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l1u_001_inc.Text))
        {
            Standard.EPF_L1U_001 = Convert.ToInt32(txt_l1u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l1u_002_inc.Text))
        {
            Standard.EPF_L1U_002 = Convert.ToInt32(txt_l1u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c2o_001_inc.Text))
        {
            Standard.EPF_C2O_001 = Convert.ToInt32(txt_c2o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c2o_002_inc.Text))
        {
            Standard.EPF_C2O_002 = Convert.ToInt32(txt_c2o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l2o_001_inc.Text))
        {
            Standard.EPF_L2O_001 = Convert.ToInt32(txt_l2o_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l2o_002_inc.Text))
        {
            Standard.EPF_L2O_002 = Convert.ToInt32(txt_l2o_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c2u_001_inc.Text))
        {
            Standard.EPF_C2U_001 = Convert.ToInt32(txt_c2u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_c2u_002_inc.Text))
        {
            Standard.EPF_C2U_002 = Convert.ToInt32(txt_c2u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l2u_001_inc.Text))
        {
            Standard.EPF_L2U_001 = Convert.ToInt32(txt_l2u_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_l2u_002_inc.Text))
        {
            Standard.EPF_L2U_002 = Convert.ToInt32(txt_l2u_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tsu_001_inc.Text))
        {
            Standard.EPF_TSU_001 = Convert.ToInt32(txt_tsu_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tsu_002_inc.Text))
        {
            Standard.EPF_TSU_002 = Convert.ToInt32(txt_tsu_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_001_inc.Text))
        {
            Standard.EPF_CVC_001 = Convert.ToInt32(txt_cvc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_002_inc.Text))
        {
            Standard.EPF_CVC_002 = Convert.ToInt32(txt_cvc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvl_001_inc.Text))
        {
            Standard.EPF_CVL_001 = Convert.ToInt32(txt_cvl_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvl_002_inc.Text))
        {
            Standard.EPF_CVL_002 = Convert.ToInt32(txt_cvl_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tle_001_inc.Text))
        {
            Standard.EPF_TLE_001 = Convert.ToInt32(txt_tle_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tle_002_inc.Text))
        {
            Standard.EPF_TLE_002 = Convert.ToInt32(txt_tle_002_inc.Text);
        }
        Standard.EPF_ROI = cbo_roi_inc.Text;
        Standard.EPF_RR0 = cbo_rr0_inc.Text;
        Standard.EPF_R01 = cbo_r01_inc.Text;
        Standard.EPF_RR1 = cbo_rr1_inc.Text;
        Standard.EPF_RR2 = cbo_rr2_inc.Text;
        Standard.EPF_R2A = cbo_r2a_inc.Text;
        Standard.EPF_RR3 = cbo_rr3_inc.Text;
        Standard.EPF_RWR = cbo_rwr_inc.Text;
        if (!string.IsNullOrEmpty(cbo_ply_inc.SelectedValue))
        {
            Standard.EPF_PLY = Convert.ToInt32(cbo_ply_inc.SelectedValue);
        }
        Standard.EPF_PLF = cbo_plf_inc.SelectedValue;
        Standard.EPF_PLL = cbo_pll_inc.SelectedValue;

        Standard.EPF_DET = txt_det_inc.Text;

        Standard.EPF_OBS = txt_obs_inc.Text;
        if (cbo_sts_inc.Text != "")
        {
            Standard.EPF_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        // Nunca Atualiza, Inativa os Anteriores e Inclui um novo
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            /*
            Standard.EPF_ID = Convert.ToInt32(rowId.Value);
            Standard.EPF_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Standard.Alterar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                TratamentoErro("Standard alterado com sucesso.");
            }
            */
            Standard.EPF_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Standard.Inativar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                //MAP20032013
                //Se Status está como Inativo não gera nova versão
                if (cbo_sts_inc.SelectedValue == "0")
                {
                    TratamentoErro("Standard inativado com sucesso, não foi gerado nova versão.");
                    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                        ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
                }
                else
                {
                    //Salva o novo Standard com uma versão a mais.
                    Standard oEPF = new Standard();
                    oEPF.EPF_LOT = Standard.EPF_LOT;
                    DataSet dsEPF = oEPF.ConsultarUltimaVersao();
                    if (dsEPF.Tables[0].Rows.Count > 0)
                    {
                        Standard.EPF_VRS = Convert.ToInt32(dsEPF.Tables[0].Rows[0]["EPF_VRS"].ToString()) + 1;
                    }
                    else
                    {
                        Response.Redirect("Erro.aspx?Erro=Não foi localizado Standard Lote: " + Standard.EPF_LOT + " para geração de nova versão. " + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                        return;
                    }
                    Standard.EPF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
                    Standard.EPF_STS = 1; //Sempre Ativo
                    sMsg = Standard.Inserir();
                    if (sMsg.Substring(0, 1) == "E")
                    {
                        Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                    }
                    else
                    {
                        rowId.Value = sMsg;

                        TratamentoErro("Nova versão de Standard criada com sucesso.");
                        if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
                    }
                }
            }
        }
        else
        {
            /* Não verificar duplicidade de EPF
            Standard EPF = new Standard();
            //Verificar se já não existe um cadastro consultando o: EPF_DES 
            EPF.EPF_DES = txt_des_inc.Text;
            DataSet dsEPF = EPF.Consultar();
            if (dsEPF.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse Standard já está cadastrado.");
                txt_dat.Focus();

                return;
            }
            */
            Standard.EPF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Standard.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("Standard inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            //dsEPF.Dispose();
        }
        Dispose();
        divCadastro.Visible = false;
        dvFiltro.Visible = true;
        txt_dat.Focus();
        rowId.Value = null;
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvStandard.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvStandard.AllowSorting = false;
            gvStandard.AllowPaging = false;
            //gvStandard.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvStandard.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvStandard.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvStandard.RenderControl(htmlWrite);

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
        if (gvStandard.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvStandard.AllowSorting = false;
            gvStandard.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvStandard.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvStandard.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvStandard.RenderControl(htmlWrite);

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

    protected void txt_lot_ref_inc_OnTextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
        {
            Standard Standard = new Standard();
            Standard.EPF_LOT = txt_lot_ref_inc.Text;
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count > 0)
            {
                cbo_maq_tip_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_MAQ_TIP_ID"].ToString();
                cbo_aps_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_APS_ID"].ToString();
                cbo_ert_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_ERT_ID"].ToString();
                txt_des_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DES"].ToString();
                txt_mge_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
                txt_mge_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_003"].ToString();
                txt_mge_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_004"].ToString();
                txt_mge_des_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_001"].ToString();
                txt_mge_des_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_002"].ToString();
                txt_mge_des_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_003"].ToString();
                txt_mge_des_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_DES_004"].ToString();
                cbo_for_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_004_ID"].ToString();
                txt_ege_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_001"].ToString();
                txt_ege_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_002"].ToString();
                txt_ege_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_003"].ToString();
                txt_ege_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_004"].ToString();
                txt_ege_des_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_001"].ToString();
                txt_ege_des_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_002"].ToString();
                txt_ege_des_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_003"].ToString();
                txt_ege_des_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGE_DES_004"].ToString();
                cbo_eor_001_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_001_ID"].ToString();
                cbo_eor_002_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_002_ID"].ToString();
                cbo_eor_003_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_003_ID"].ToString();
                cbo_eor_004_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_EOR_004_ID"].ToString();
                txt_vw2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VW2"].ToString();
                txt_egm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGM"].ToString();
                txt_dyy_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DYY"].ToString();
                txt_2wx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2WX"].ToString();
                txt_3w3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_3W3"].ToString();
                txt_4w4_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_4W4"].ToString();
                txt_agl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AGL"].ToString();
                txt_tup_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUP"].ToString();
                txt_veo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VEO"].ToString();
                txt_t1t_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1T"].ToString();
                txt_t1c_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1C"].ToString();
                txt_t1l_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1L"].ToString();
                txt_t2f_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T2F"].ToString();
                txt_sve_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVE"].ToString();
                txt_stf_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STF"].ToString();
                txt_sce_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCE"].ToString();
                txt_sco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCO"].ToString();
                txt_sch_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCH"].ToString();
                txt_scg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCG"].ToString();
                txt_see_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEE"].ToString();
                txt_seo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEO"].ToString();
                txt_seh_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEH"].ToString();
                txt_seg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEG"].ToString();
                txt_sjc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJC"].ToString();
                txt_sjt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJT"].ToString();
                txt_sjb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJB"].ToString();
                txt_spj_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPJ"].ToString();
                txt_sbc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SBC"].ToString();
                txt_spo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPO"].ToString();
                txt_sva_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVA"].ToString();
                txt_tgr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TGR"].ToString();
                txt_tip_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP"].ToString();
                txt_dsb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DSB"].ToString();
                txt_tca_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCA"].ToString();
                txt_fmc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FMC"].ToString();
                txt_1tb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1TB"].ToString();
                txt_1pp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1PP"].ToString();
                txt_2tb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2TB"].ToString();
                txt_2pp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2PP"].ToString();
                txt_cso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CSO"].ToString();
                txt_esp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESP"].ToString();
                txt_tol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TOL"].ToString();
                txt_p1c_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P1C"].ToString();
                txt_p2d_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P2D"].ToString();
                txt_p3d_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P3D"].ToString();
                txt_p4u_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P4U"].ToString();
                txt_mol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MOL"].ToString();
                txt_tpd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TPD"].ToString();
                txt_tt1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT1"].ToString();
                txt_tt2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT2"].ToString();
                txt_tt3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT3"].ToString();
                txt_t21_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T21"].ToString();
                txt_tun_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUN"].ToString();
                txt_tcv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCV"].ToString();
                txt_tss_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSS"].ToString();
                txt_tit_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIT"].ToString();
                txt_tnc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TNC"].ToString();
                txt_aon_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AON"].ToString();
                txt_enm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ENM"].ToString();
                txt_eee_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEE"].ToString();
                txt_kkk_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_KKK"].ToString();
                txt_bbb_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBB"].ToString();
                txt_ole_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OLE"].ToString();
                txt_trq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRQ"].ToString();
                txt_ert_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERT"].ToString();
                txt_rt3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT3"].ToString();
                txt_rt5_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT5"].ToString();
                txt_dnd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DND"].ToString();
                txt_dmo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DMO"].ToString();
                txt_pes_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PES"].ToString();
                txt_vrr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRR"].ToString();
                txt_tre_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRE"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()))
                {
                    txt_lme_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()))
                {
                    txt_ume_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()))
                {
                    txt_lpe_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()))
                {
                    txt_upe_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()))
                {
                    txt_ucv_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()))
                {
                    txt_lcv_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()))
                {
                    txt_dur_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()))
                {
                    txt_dft_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()))
                {
                    txt_lmc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()))
                {
                    txt_umc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()))
                {
                    txt_lpc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()))
                {
                    txt_upc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()))
                {
                    txt_cvc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()))
                {
                    txt_lvc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()))
                {
                    txt_dfc_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()))
                {
                    txt_tfs_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()))
                {
                    txt_fsw_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()))
                {
                    txt_wfw_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()))
                {
                    txt_ybt_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()).ToString("0.0");
                }
                txt_eco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECO"].ToString();
                //txt_spx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPX"].ToString();

                cbo_gft_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_GFT"].ToString();
                cbo_hem_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_HEM"].ToString();
                txt_vaz_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAZ"].ToString();
                txt_cot_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COT"].ToString();
                txt_co2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CO2"].ToString();
                txt_coc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COC"].ToString();
                txt_cov_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_COV"].ToString();
                txt_dim_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIM"].ToString();
                txt_rsq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RSQ"].ToString();
                txt_rlq_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RLQ"].ToString();
                txt_rrm_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RRM"].ToString();
                txt_rmx_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMX"].ToString();
                txt_rmn_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMN"].ToString();
                txt_rmh_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RMH"].ToString();
                txt_rqs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RQS"].ToString();
                txt_rty_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RTY"].ToString();
                txt_rhy_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RHY"].ToString();
                txt_eoc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOC"].ToString();
                txt_eoe_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOE"].ToString();
                txt_etc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETC"].ToString();
                txt_ete_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETE"].ToString();
                txt_ptn_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PTN"].ToString();

                txt_eol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
                txt_etu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
                txt_etd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
                txt_ecu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
                txt_egd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
                txt_eec_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
                txt_ecd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
                txt_egu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
                txt_eso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
                txt_esi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
                txt_ecr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
                txt_eod_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
                txt_eaw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
                txt_eol_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
                txt_etu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
                txt_etd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
                txt_ecu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
                txt_egd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
                txt_eec_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
                txt_ecd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
                txt_egu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
                txt_eso_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
                txt_esi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
                txt_ecr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
                txt_eod_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
                txt_eaw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
                txt_ed1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED1"].ToString();
                txt_ed2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED2"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString()))
                {
                    cbo_idd_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString();
                }

                txt_eta_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETA"].ToString();
                txt_eth_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETH"].ToString();
                txt_etg_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETG"].ToString();
                txt_edt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDT"].ToString();
                txt_efp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EFP"].ToString();
                txt_eyt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EYT"].ToString();
                txt_edl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDL"].ToString();
                txt_eab_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAB"].ToString();
                txt_eca_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECA"].ToString();
                txt_ecw_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECW"].ToString();
                txt_etl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETL"].ToString();
                txt_ett_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETT"].ToString();
                txt_ere_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERE"].ToString();
                txt_ele_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ELE"].ToString();
                txt_ept_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPT"].ToString();
                txt_epl_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPL"].ToString();
                
                txt_pco_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCO"].ToString();
                txt_pcv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCV"].ToString();
                txt_drt_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DRT"].ToString();
                txt_tal_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAL"].ToString();
                txt_val_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAL"].ToString();
                txt_sje_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJE"].ToString();

                //TMT
                txt_mat_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT"].ToString();
                txt_can_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN"].ToString();
                txt_epu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU"].ToString();
                txt_per_mge_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE"].ToString();
                txt_mat_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_002"].ToString();
                txt_can_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_002"].ToString();
                txt_epu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_002"].ToString();
                txt_per_mge_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_002"].ToString();
                txt_mat_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_003"].ToString();
                txt_can_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_003"].ToString();
                txt_epu_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_003"].ToString();
                txt_per_mge_003_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_003"].ToString();
                txt_mat_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MAT_004"].ToString();
                txt_can_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CAN_004"].ToString();
                txt_epu_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPU_004"].ToString();
                txt_per_mge_004_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PER_MGE_004"].ToString();
                txt_hot_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_HOT"].ToString();
                txt_vrd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRD"].ToString();
                txt_acr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ACR"].ToString();
                txt_pen_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PEN"].ToString();
                txt_cra_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA"].ToString();
                txt_cle_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CLE"].ToString();
                txt_afo_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AFO"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString()))
                {
                    ddl_tcu_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString();
                }
                txt_tar_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAR"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString()))
                {
                    ddl_tam_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString();
                }
                ddl_tam_inc_OnSelectedIndexChanged(sender, e);
                txt_std_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STD"].ToString();
                txt_stp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STP"].ToString();
                txt_ttd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTD"].ToString();
                txt_ttp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTP"].ToString();
                txt_ftd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTD"].ToString();
                txt_ftp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTP"].ToString();
                txt_itd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITD"].ToString();
                txt_itp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITP"].ToString();
                txt_xtd_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTD"].ToString();
                txt_xtp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTP"].ToString();
                txt_ttr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTR"].ToString();
                txt_dtu_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DTU"].ToString();
                txt_dpa_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DPA"].ToString();
                txt_cin_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CIN"].ToString();
                ddl_fr2_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR2"].ToString();
                txt_fr2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR2"].ToString();
                ddl_fr1_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR1"].ToString();
                txt_fr1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR1"].ToString();
                ddl_fr0_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR0"].ToString();
                txt_fr0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR0"].ToString();
                txt_ato_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ATO"].ToString();
                txt_tp1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP1"].ToString();
                txt_tp2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP2"].ToString();
                txt_tcp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCP"].ToString();
                txt_jf2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF2"].ToString();
                txt_ps2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS2"].ToString();
                txt_jf0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF0"].ToString();
                txt_ps0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS0"].ToString();
                txt_bba_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBA"].ToString();
                txt_gro_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_GRO"].ToString();
                txt_tcs_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCS"].ToString();
                txt_cvp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP"].ToString();
                txt_ssv_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSV"].ToString();
                txt_ssp_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSP"].ToString();
                txt_tte_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_001"].ToString();
                txt_tte_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_002"].ToString();
                cbo_wpo_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_001"].ToString();
                cbo_wpo_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_002"].ToString();
                txt_dir_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_001"].ToString();
                txt_dir_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_002"].ToString();
                txt_cra_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_001"].ToString();
                txt_cra_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString()))
                {
                    cbo_ced_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString()))
                {
                    cbo_ced_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString();
                }
                txt_ted_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_001"].ToString();
                txt_ted_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_002"].ToString();
                txt_dle_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_001"].ToString();
                txt_dle_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_002"].ToString();
                txt_cti_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_001"].ToString();
                txt_cti_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_002"].ToString();
                txt_g1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_001"].ToString();
                txt_g1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_002"].ToString();
                txt_g1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_001"].ToString();
                txt_g1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_002"].ToString();
                txt_g2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_001"].ToString();
                txt_g2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_002"].ToString();
                txt_g2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_001"].ToString();
                txt_g2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_002"].ToString();
                txt_cvp_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_001"].ToString();
                txt_cvp_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_002"].ToString();
                txt_ocu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_001"].ToString();
                txt_ocu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_002"].ToString();
                txt_ucu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_001"].ToString();
                txt_ucu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_002"].ToString();
                txt_c1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_001"].ToString();
                txt_c1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_002"].ToString();
                txt_l1o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_001"].ToString();
                txt_l1o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_002"].ToString();
                txt_c1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_001"].ToString();
                txt_c1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_002"].ToString();
                txt_l1u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_001"].ToString();
                txt_l1u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_002"].ToString();
                txt_c2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_001"].ToString();
                txt_c2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_002"].ToString();
                txt_l2o_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_001"].ToString();
                txt_l2o_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_002"].ToString();
                txt_c2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_001"].ToString();
                txt_c2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_002"].ToString();
                txt_l2u_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_001"].ToString();
                txt_l2u_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_002"].ToString();
                txt_tsu_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_001"].ToString();
                txt_tsu_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_002"].ToString();
                txt_cvc_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_001"].ToString();
                txt_cvc_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_002"].ToString();
                txt_cvl_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_001"].ToString();
                txt_cvl_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_002"].ToString();
                txt_tle_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_001"].ToString();
                txt_tle_002_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString()))
                {
                    cbo_roi_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString()))
                {
                    cbo_rr0_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString();
                }
                cbo_rr0_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString()))
                {
                    cbo_r01_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString();
                }
                cbo_r01_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString()))
                {
                    cbo_rr1_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString()))
                {
                    cbo_rr2_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString()))
                {
                    cbo_r2a_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString()))
                {
                    cbo_rr3_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString()))
                {
                    cbo_rwr_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLY"].ToString()))
                {
                    cbo_ply_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLY"].ToString();
                }
                cbo_ply_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLF"].ToString()))
                {
                    cbo_plf_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLF"].ToString();
                }
                cbo_plf_inc_OnSelectedIndexChanged(sender, e);
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_PLL"].ToString()))
                {
                    cbo_pll_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PLL"].ToString();
                }
                cbo_pll_inc_OnSelectedIndexChanged(sender, e);

                txt_lot_ref_inc.Focus();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Lote Referência não existe !');", true);
                txt_lot_ref_inc.Focus();
            }
            dsStandard.Dispose();
            Dispose();
        }

    }

    protected void cbo_maq_tip_id_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(cbo_maq_tip_id_inc.SelectedValue))
        {
            if (cbo_maq_tip_id_inc.SelectedItem.Text == "STAHLE")
            {
                pnl_afk.Visible = false;
                pnl_sta.Visible = true;
                pnl_sta_poy.Visible = true;
                pnl_Stahle.Visible = true;
                pnl_sta_ctn.Visible = true;
            }
            else
            {
                pnl_afk.Visible = true;
                pnl_sta.Visible = false;
                pnl_sta_poy.Visible = false;
                pnl_Stahle.Visible = false;
                pnl_sta_ctn.Visible = false;
            }

            if ((cbo_maq_tip_id_inc.SelectedItem.Text == "AFK3") || (cbo_maq_tip_id_inc.SelectedItem.Text == "AFK3M"))
            {
                pnl_afk3.Visible = true;
            }
            else
            {
                pnl_afk3.Visible = false;
            }

            if (cbo_maq_tip_id_inc.SelectedItem.Text == "M900" || cbo_maq_tip_id_inc.SelectedItem.Text == "V900")
            {
                pnl_M900_V900.Visible = true;
            }
            else
            {
                pnl_M900_V900.Visible = false;
            }

            if (cbo_maq_tip_id_inc.SelectedItem.Text == "TMT")
            {
                lbl_edy.Text = "Relação VR(B/Y)";
                lbl_ewx.Text = "Overfeed do Jet(OF2A)";
                lbl_ew3.Text = "2º Overfeed(OF2)";
                lbl_ew4.Text = "3º Overfeed(OF3)";
                lbl_vw2.Text = "Velocidade YS(m/min)";

                pnl_ope.Visible = false;
                pnl_epu.Visible = false;
                pnl_reg.Visible = false;
                pnl_dad.Visible = false;
                pnl_eng_pol.Visible = false;
                pnl_reg_enc.Visible = false;
                pnl_reg_bar.Visible = false;
                pnl_reg_uni.Visible = false;
                pnl_dof.Visible = false;
                pnl_tup.Visible = false;
                pnl_t1e.Visible = false;
                pnl_drt.Visible = false;
                pnl_ten.Visible = false;


                pnl_tmt_poy.Visible = true;
                pnl_tmt_ope.Visible = true;
                pnl_tmt_reg.Visible = true;
                pnl_tmt_ten.Visible = true;
                pnl_tmt_tcs.Visible = true;
                pnl_tmt_rol.Visible = true;
            }
            else
            {
                lbl_edy.Text = "D/Y";
                lbl_ewx.Text = "2nd Overfeed  - WX(%)";
                lbl_ew3.Text = "3nd Overfeed  - W3(%)";
                lbl_ew4.Text = "4nd Overfeed  - W4(%)";
                lbl_vw2.Text = "Velocidade W2(m/min)";

                pnl_ope.Visible = true;
                pnl_epu.Visible = true;
                pnl_reg.Visible = true;
                pnl_dad.Visible = true;
                pnl_eng_pol.Visible = true;
                pnl_reg_enc.Visible = true;
                pnl_reg_bar.Visible = true;
                pnl_reg_uni.Visible = true;
                pnl_dof.Visible = true;
                pnl_tup.Visible = true;
                pnl_t1e.Visible = true;
                pnl_drt.Visible = true;
                pnl_ten.Visible = true;

                pnl_tmt_poy.Visible = false;
                pnl_tmt_ope.Visible = false;
                pnl_tmt_reg.Visible = false;
                pnl_tmt_ten.Visible = false;
                pnl_tmt_tcs.Visible = false;
                pnl_tmt_rol.Visible = false;
            }

        }
    }

    protected void cbo_rr0_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_rr0_inc.SelectedValue == "ON" || cbo_r01_inc.SelectedValue == "ON")
        {
            pnl_frs.Visible = true;
        }
        else
        {
            pnl_frs.Visible = false;
        }
    }

    protected void cbo_r01_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_rr0_inc.SelectedValue == "ON" || cbo_r01_inc.SelectedValue == "ON")
        {
            pnl_frs.Visible = true;
        }
        else
        {
            pnl_frs.Visible = false;
        }
    }

    protected void cbo_ply_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_ply_inc.SelectedValue == "1")
        {
            pnl_wpo_001.Visible = false;
            pnl_wpo_002.Visible = false;
        }
        else
        {
            pnl_wpo_001.Visible = true;
            pnl_wpo_002.Visible = true;
        }
    }

    protected void cbo_plf_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_plf_inc.SelectedValue == "ATIVO")
        {
            pnl_plf_001.Visible = true;
            pnl_plf_002.Visible = true;
        }
        else
        {
            pnl_plf_001.Visible = false;
            pnl_plf_002.Visible = false;
        }
    }

    protected void cbo_pll_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_pll_inc.SelectedValue == "ALL")
        {
            pnl_ply_002.Visible = false;
        }
        else
        {
            pnl_ply_002.Visible = true;
        }
    }

    protected void SelecionaEngrenagem(object sender, EventArgs e)
    {
        TextBox tb = (TextBox) sender;
        if (!string.IsNullOrEmpty(tb.Text))
        {
            string sEngrenagem = "";
            switch (tb.ID)
            {
                case "txt_stf_inc":
                    sEngrenagem = "cbo_sta_z03_inc";
                    break;

                case "txt_sco_inc":
                    sEngrenagem = "cbo_sta_z05_z08_z13_inc";
                    break;

                case "txt_seo_inc":
                    sEngrenagem = "cbo_sta_z01_z02_z04_z06_z14_inc";
                    break;

                case "txt_sce_inc":
                    sEngrenagem = "cbo_sta_z09_z10_inc";
                    break;

                case "txt_see_inc":
                    sEngrenagem = "cbo_sta_z11_z12_inc";
                    break;
            }

            DropDownList ddl = (DropDownList)FindControl(sEngrenagem);
            ddl.SelectedItem.Selected = false;
            foreach (System.Web.UI.WebControls.ListItem li in ddl.Items)
            {
                if (li.Text.StartsWith(tb.Text))
                {
                    li.Selected = true;
                    break;
                }
            }

            if (string.IsNullOrEmpty(ddl.Text))
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Taxa de Engrenagem não existe!');", true);
                tb.Focus();
            }
        }
    }

    protected void ddl_tam_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddl_tam_inc.SelectedValue == "1")
        {
            txt_std_inc.ReadOnly = false;
            txt_stp_inc.ReadOnly = false;
            txt_ttd_inc.ReadOnly = false;
            txt_ttp_inc.ReadOnly = false;
            txt_ftd_inc.ReadOnly = false;
            txt_ftp_inc.ReadOnly = false;
            txt_itd_inc.ReadOnly = false;
            txt_itp_inc.ReadOnly = false;
            txt_xtd_inc.ReadOnly = false;
            txt_xtp_inc.ReadOnly = false;
        }
        else
        {
            txt_std_inc.Text = "";
            txt_stp_inc.Text = "";
            txt_ttd_inc.Text = "";
            txt_ttp_inc.Text = "";
            txt_ftd_inc.Text = "";
            txt_ftp_inc.Text = "";
            txt_itd_inc.Text = "";
            txt_itp_inc.Text = "";
            txt_xtd_inc.Text = "";
            txt_xtp_inc.Text = "";

            txt_std_inc.ReadOnly = true;
            txt_stp_inc.ReadOnly = true;
            txt_ttd_inc.ReadOnly = true;
            txt_ttp_inc.ReadOnly = true;
            txt_ftd_inc.ReadOnly = true;
            txt_ftp_inc.ReadOnly = true;
            txt_itd_inc.ReadOnly = true;
            txt_itp_inc.ReadOnly = true;
            txt_xtd_inc.ReadOnly = true;
            txt_xtp_inc.ReadOnly = true;
        }

        ddl_tam_inc.Focus();

    }
 }