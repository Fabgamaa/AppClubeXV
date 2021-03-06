using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
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
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_log_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_log_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_tit_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_sup_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_sup_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_efc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_efc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_prc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_prc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_tur_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_tur_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_kio_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_kio_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_pnv_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_pnv_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_dnv_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_dnv_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_car_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_car_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ped_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_ped_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dsv_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dsv_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_pjt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_pjt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

        //Desabilita campos de acordo com o perfil
        if (Session["PFL_ID"].ToString() == "51" || Session["PFL_ID"].ToString() == "52" || Session["PFL_ID"].ToString() == "53") //LOG?STICA, P&D e PCP
        {
            txt_rts_inc.Enabled = false;
            txt_dat_inc.Enabled = false;
            cbo_slt_usr_id_inc.Enabled = false;
            cbo_mtv_tst_id_inc.Enabled = false;
            cbo_cli_id_inc.Enabled = false;
            cbo_tit_poy_id_inc.Enabled = false;
            cbo_ert_id_inc.Enabled = false;
            cbo_aps_id_inc.Enabled = false;
            cbo_scc_trv_id_inc.Enabled = false;
            cbo_mtd_id_inc.Enabled = false;
            cbo_cor_id_inc.Enabled = false;
            cbo_fio_id_inc.Enabled = false;
            cbo_grp_mrl_id_inc.Enabled = false;
            txt_lot_ref_inc.Enabled = false;
            txt_vlc_inc.Enabled = false;
            cbo_mrc_id_inc.Enabled = false;
            cbo_esl_id_inc.Enabled = false;
            cbo_cxa_id_inc.Enabled = false;
            cbo_cst_inc.Enabled = false;
            txt_dmo_inc.Enabled = false;
            txt_pes_inc.Enabled = false;
            txt_spe_inc.Enabled = false;
            txt_obs_slt_inc.Enabled = false;
        }

        if (Session["PFL_ID"].ToString() == "50" || Session["PFL_ID"].ToString() == "52" || Session["PFL_ID"].ToString() == "53") //SOLICITANTE, P&D e PCP
        {
            cbo_for_001_id_inc.Enabled = false;
            cbo_for_002_id_inc.Enabled = false;
            cbo_for_003_id_inc.Enabled = false;
            cbo_for_004_id_inc.Enabled = false;
            cbo_maq_tip_id_inc.Enabled = false;
            txt_mge_inc.Enabled = false;
            txt_mge_002_inc.Enabled = false;
            txt_mge_003_inc.Enabled = false;
            txt_mge_004_inc.Enabled = false;
            txt_log_dat_inc.Enabled = false;
            cbo_log_usr_id_inc.Enabled = false;
            txt_obs_log_inc.Enabled = false;
        }

        if (Session["PFL_ID"].ToString() == "50" || Session["PFL_ID"].ToString() == "51" || Session["PFL_ID"].ToString() == "53" || Session["PFL_ID"].ToString() == "55") //SOLICITANTE, LOG?STICA, P&D, PCP e SOLICITANTE/LOG?STICA
        {
            cbo_vli_inc.Enabled = false;
            txt_jtf_inc.Enabled = false;
            txt_tit_inc.Enabled = false;
            txt_vel_inc.Enabled = false;
            txt_cbo_inc.Enabled = false;
            txt_prc_inc.Enabled = false;
            txt_qbr_tur_inc.Enabled = false;
            txt_qbr_kio_inc.Enabled = false;
            txt_pao_001_inc.Enabled = false;
            txt_pao_002_inc.Enabled = false;
            cbo_jet_001_inc.Enabled = false;
            cbo_jet_002_inc.Enabled = false;
            txt_car_inc.Enabled = false;
            txt_ole_inc.Enabled = false;
            txt_pes_sup_inc.Enabled = false;
            txt_efc_inc.Enabled = false;
            txt_qbr_pnv_inc.Enabled = false;
            txt_qbr_dnv_inc.Enabled = false;
            txt_ped_dat_inc.Enabled = false;
            cbo_ped_usr_id_inc.Enabled = false;
            txt_obs_ped_inc.Enabled = false;
        }

        if (Session["PFL_ID"].ToString() == "50" || Session["PFL_ID"].ToString() == "51" || Session["PFL_ID"].ToString() == "52" || Session["PFL_ID"].ToString() == "55") //SOLICITANTE, LOG?STICA, P&D e SOLICITANTE/LOG?STICA
        {
            txt_dsv_dat_inc.Enabled = false;
            cbo_maq_id_inc.Enabled = false;
            txt_pjt_dat_inc.Enabled = false;
            cbo_pjt_usr_id_inc.Enabled = false;
            txt_obs_pcp_inc.Enabled = false;
        }
    }

    protected void CarregaControles()
	{
		MotivoTeste MotivoTeste = new MotivoTeste();
		DataSet dsMotivoTeste = MotivoTeste.Consultar();
		FWGNR.VerificaStatus(dsMotivoTeste, "MTV_TST_ID", "MTV_TST_DES", "MTV_TST_STS", cbo_mtv_tst_id);
		FWGNR.VerificaStatus(dsMotivoTeste, "MTV_TST_ID", "MTV_TST_DES", "MTV_TST_STS", cbo_mtv_tst_id_inc);
		dsMotivoTeste.Dispose();

		Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "T"; //Somente Texturizados
        DataSet dsTitulo = Titulo.Consultar();
		FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
		dsTitulo.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_inc);
        dsEntrelacamento.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
		DataSet dsApresentacao = Apresentacao.Consultar();
		FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_inc);
		dsApresentacao.Dispose();

		SeccaoTransversal SeccaoTransversal = new SeccaoTransversal();
		DataSet dsSeccaoTransversal = SeccaoTransversal.Consultar();
		FWGNR.VerificaStatus(dsSeccaoTransversal, "SCC_TRV_ID", "SCC_TRV_DES", "SCC_TRV_STS", cbo_scc_trv_id_inc);
		dsSeccaoTransversal.Dispose();

		Maticidade Maticidade = new Maticidade();
		DataSet dsMaticidade = Maticidade.Consultar();
		FWGNR.VerificaStatus(dsMaticidade, "MTD_ID", "MTD_DES", "MTD_STS", cbo_mtd_id_inc);
		dsMaticidade.Dispose();

		Cor Cor = new Cor();
		DataSet dsCor = Cor.Consultar();
		FWGNR.VerificaStatus(dsCor, "COR_ID", "COR_DES", "COR_STS", cbo_cor_id_inc);
		dsCor.Dispose();

        Fio Fio = new Fio();
        DataSet dsFio = Fio.Consultar();
        FWGNR.VerificaStatus(dsFio, "FIO_ID", "FIO_DES", "FIO_STS", cbo_fio_id_inc);
        dsFio.Dispose();

        GrupoMaterial GrupoMaterial = new GrupoMaterial();
        DataSet dsGrupoMaterial = GrupoMaterial.Consultar();
        FWGNR.VerificaStatus(dsGrupoMaterial, "GRP_MRL_ID", "GRP_MRL_DES", "GRP_MRL_STS", cbo_grp_mrl_id_inc);
        dsGrupoMaterial.Dispose();

        Marca Marca = new Marca();
		DataSet dsMarca = Marca.Consultar();
		FWGNR.VerificaStatus(dsMarca, "MRC_ID", "MRC_DES", "MRC_STS", cbo_mrc_id_inc);
		dsMarca.Dispose();

		Escolha Escolha = new Escolha();
		DataSet dsEscolha = Escolha.Consultar();
		FWGNR.VerificaStatus(dsEscolha, "ESL_ID", "ESL_DES", "ESL_STS", cbo_esl_id_inc);
		dsEscolha.Dispose();

		Caixa Caixa = new Caixa();
		DataSet dsCaixa = Caixa.Consultar();
		FWGNR.VerificaStatus(dsCaixa, "CXA_ID", "CXA_DES", "CXA_STS", cbo_cxa_id_inc);
		dsCaixa.Dispose();

		Usuario SolicitanteUsuario = new Usuario();
		DataSet dsSolicitanteUsuario = SolicitanteUsuario.Consultar();
        FWGNR.VerificaStatus(dsSolicitanteUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_slt_usr_id);
        FWGNR.VerificaStatus(dsSolicitanteUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_slt_usr_id_inc);
        dsSolicitanteUsuario.Dispose();

        Cliente Cliente = new Cliente();
        DataSet dsCliente = Cliente.Consultar();
        FWGNR.VerificaStatus(dsCliente, "CLI_ID", "CLI_NOM", "CLI_STS", cbo_cli_id);
        FWGNR.VerificaStatus(dsCliente, "CLI_ID", "CLI_NOM", "CLI_STS", cbo_cli_id_inc);
        dsCliente.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "T"; //Somente Texturizados
        DataSet dsFornecedor = Fornecedor.Consultar();
		FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_inc);
        dsFornecedor.Dispose();

		MaquinaTipo MaquinaTipo = new MaquinaTipo();
		DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
		dsMaquinaTipo.Dispose();

        Usuario LogisticaUsuario = new Usuario();
        LogisticaUsuario.IN_USR_PFL_ID = "51, 55"; //Perfil Logistica e Solicitante/Logistica
		DataSet dsLogisticaUsuario = LogisticaUsuario.Consultar();
        FWGNR.VerificaStatus(dsLogisticaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_log_usr_id_inc);
		dsLogisticaUsuario.Dispose();

		Usuario PEDUsuario = new Usuario();
        PEDUsuario.USR_PFL_ID = 64; //Perfil SOLICITANTE/LOJISTICA/P&D/PCP
        PEDUsuario.USR_STS = 1; //Somente usuarios ativos
        DataSet dsPEDUsuario = PEDUsuario.Consultar();
        FWGNR.VerificaStatus(dsPEDUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ped_usr_id_inc);
		dsPEDUsuario.Dispose();

        Usuario PlanejamentoUsuario = new Usuario();
        PlanejamentoUsuario.USR_PFL_ID = 53; //Perfil PCP
        DataSet dsPlanejamentoUsuario = PlanejamentoUsuario.Consultar();
        FWGNR.VerificaStatus(dsPlanejamentoUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_pjt_usr_id_inc);
        dsPlanejamentoUsuario.Dispose();

    }

    protected void CarregaDados()
    {
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            lbAcao.Text = "Alterar";
            divCadastro.Visible = true;
            dvFiltro.Visible = false;

            txt_dat_inc.Focus();

            RTS RTS = new RTS();
            RTS.RTS_ID = Convert.ToInt32(rowId.Value);
            DataSet dsRTS = RTS.Consultar();
            if (dsRTS.Tables[0].Rows.Count > 0)
            {
                txt_rts_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_ID"].ToString();
                txt_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_DAT"].ToString()).ToString("dd/MM/yyyy");
                cbo_slt_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_SLT_USR_ID"].ToString();
                cbo_mtv_tst_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MTV_TST_ID"].ToString();
                cbo_cli_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_CLI_ID"].ToString();
                cbo_tit_poy_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_TIT_POY_ID"].ToString();
                cbo_ert_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_ERT_ID"].ToString();
                cbo_aps_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_APS_ID"].ToString();
                cbo_scc_trv_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_SCC_TRV_ID"].ToString();
                cbo_mtd_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MTD_ID"].ToString();
                cbo_cor_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_COR_ID"].ToString();
                cbo_fio_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FIO_ID"].ToString();
                cbo_grp_mrl_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_GRP_MRL_ID"].ToString();
                txt_lot_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT_REF"].ToString();
                txt_vlc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VLC"].ToString();
                cbo_mrc_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MRC_ID"].ToString();
                cbo_esl_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_ESL_ID"].ToString();
                cbo_cxa_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_CXA_ID"].ToString();
                cbo_cst_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_CST"].ToString();
                txt_dmo_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_DMO"].ToString();
                txt_pes_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PES"].ToString();
                txt_spe_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_SPE"].ToString();
                txt_obs_slt_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_SLT"].ToString();

                cbo_for_001_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_004_ID"].ToString();
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_SPA"].ToString()))
                {
                    chk_spa_inc.Checked = Convert.ToBoolean(Convert.ToInt32(dsRTS.Tables[0].Rows[0]["RTS_SPA"].ToString()));
                }
                cbo_maq_tip_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MAQ_TIP_ID"].ToString();
                txt_mge_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE"].ToString();
                txt_mge_002_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_003"].ToString();
                txt_mge_004_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_004"].ToString();
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_LOG_DAT"].ToString()))
                {
                    txt_log_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_LOG_DAT"].ToString()).ToString("dd/MM/yyyy");
                }
                cbo_log_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_LOG_USR_ID"].ToString();
                txt_obs_log_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_LOG"].ToString();

                cbo_vli_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VLI"].ToString();
                txt_jtf_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_JTF"].ToString();
                txt_lot_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT"].ToString();
                //Se Status ? P&D permite informar Lote
                if (dsRTS.Tables[0].Rows[0]["RTS_STS"].ToString() == "3" || dsRTS.Tables[0].Rows[0]["RTS_STS"].ToString() == "4")
                {
                    txt_lot_inc.ReadOnly = false;
                }
                else
                {
                    txt_lot_inc.ReadOnly = true;
                }
                txt_tit_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_TIT"].ToString();
                txt_vel_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VEL"].ToString();
                txt_cbo_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_CBO"].ToString();
                txt_prc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PRC"].ToString();
                txt_qbr_tur_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_TUR"].ToString();
                txt_qbr_kio_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_KIO"].ToString();
                txt_pao_001_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PAO_001"].ToString();
                txt_pao_002_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PAO_002"].ToString();
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_JET_001"].ToString()))
                {
                    cbo_jet_001_inc.SelectedValue = cbo_jet_001_inc.Items.FindByText(dsRTS.Tables[0].Rows[0]["RTS_JET_001"].ToString()).Value;
                }
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_JET_002"].ToString()))
                {
                    cbo_jet_002_inc.SelectedValue = cbo_jet_002_inc.Items.FindByText(dsRTS.Tables[0].Rows[0]["RTS_JET_002"].ToString()).Value;
                }
                txt_car_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_CAR"].ToString();
                txt_ole_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OLE"].ToString();
                txt_pes_sup_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PES_SUP"].ToString();
                txt_efc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_EFC"].ToString();
                txt_qbr_pnv_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_PNV"].ToString();
                txt_qbr_dnv_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_DNV"].ToString();
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_PED_DAT"].ToString()))
                {
                    txt_ped_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_PED_DAT"].ToString()).ToString("dd/MM/yyyy");
                }
                cbo_ped_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_PED_USR_ID"].ToString();
                txt_obs_ped_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_PED"].ToString();

                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_DAT_DSV"].ToString()))
                {
                    txt_dsv_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_DAT_DSV"].ToString()).ToString("dd/MM/yyyy");
                }
                CarregaMaquina();
                cbo_maq_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MAQ_ID"].ToString();
                if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_PJT_DAT"].ToString()))
                {
                    txt_pjt_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_PJT_DAT"].ToString()).ToString("dd/MM/yyyy");
                }
                cbo_pjt_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_PJT_USR_ID"].ToString();
                txt_obs_pcp_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_PCP"].ToString();

                cbo_sts_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_STS"].ToString();
            }
            dsRTS.Dispose();
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

                txt_rts.Focus();
            }

            //Seleciona usu?rio atual como Solicitante
            cbo_slt_usr_id_inc.SelectedValue = Session["USR_ID"].ToString();
        }
    }

    private void LimpaTela()
    {
        txt_dat_ini.Text = "";
        txt_dat_fim.Text = "";
        txt_rts.Text = "";
        cbo_slt_usr_id.Text = "";
        cbo_mtv_tst_id.Text = "";
        cbo_cli_id.Text = "";
        cbo_for_id.Text = "";
        cbo_maq_tip_id.Text = "";
        cbo_sts.Text = "";

        txt_rts_inc.Text = "";
        txt_dat_inc.Text = "";
        //Seleciona usu?rio atual como Solicitante
        cbo_slt_usr_id_inc.SelectedValue = Session["USR_ID"].ToString();
        cbo_mtv_tst_id_inc.SelectedIndex = 0;
        cbo_cli_id_inc.SelectedIndex = 0;
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        cbo_ert_id_inc.SelectedIndex = 0;
        cbo_aps_id_inc.SelectedIndex = 0;
        cbo_scc_trv_id_inc.SelectedIndex = 0;
        cbo_mtd_id_inc.SelectedIndex = 0;
        cbo_cor_id_inc.SelectedIndex = 0;
        cbo_fio_id_inc.SelectedIndex = 0;
        cbo_grp_mrl_id_inc.SelectedIndex = 0;
        txt_lot_ref_inc.Text = "";
        txt_vlc_inc.Text = "";
        cbo_mrc_id_inc.SelectedIndex = 0;
        cbo_esl_id_inc.SelectedIndex = 0;
        cbo_cxa_id_inc.SelectedIndex = 0;
        cbo_cst_inc.SelectedValue = "N";
        txt_dmo_inc.Text = "";
        txt_pes_inc.Text = "";
        txt_spe_inc.Text = "";
        txt_obs_slt_inc.Text = "";

        cbo_for_001_id_inc.SelectedIndex = 0;
        cbo_for_002_id_inc.SelectedIndex = 0;
        cbo_for_003_id_inc.SelectedIndex = 0;
        cbo_for_004_id_inc.SelectedIndex = 0;
        cbo_maq_tip_id_inc.SelectedIndex = 0;
        txt_mge_inc.Text = "";
        txt_mge_002_inc.Text = "";
        txt_mge_003_inc.Text = "";
        txt_mge_004_inc.Text = "";
        txt_log_dat_inc.Text = "";
        cbo_log_usr_id_inc.SelectedIndex = 0;
        txt_obs_log_inc.Text = "";

        cbo_vli_inc.SelectedValue = "S";
        txt_jtf_inc.Text = "";
        txt_lot_inc.Text = "";
        txt_tit_inc.Text = "";
        txt_vel_inc.Text = "";
        txt_cbo_inc.Text = "";
        txt_prc_inc.Text = "";
        txt_qbr_tur_inc.Text = "";
        txt_qbr_kio_inc.Text = "";
        txt_pao_001_inc.Text = "";
        txt_pao_002_inc.Text = "";
        cbo_jet_001_inc.SelectedIndex = 0;
        cbo_jet_002_inc.SelectedIndex = 0;
        txt_car_inc.Text = "";
        txt_ole_inc.Text = "";
        txt_pes_sup_inc.Text = "";
        txt_efc_inc.Text = "";
        txt_qbr_pnv_inc.Text = "";
        txt_qbr_dnv_inc.Text = "";
        txt_ped_dat_inc.Text = "";
        cbo_ped_usr_id_inc.SelectedIndex = 0;
        txt_obs_ped_inc.Text = "";

        txt_dsv_dat_inc.Text = "";
        cbo_maq_id_inc.SelectedIndex = 0;
        txt_pjt_dat_inc.Text = "";
        cbo_pjt_usr_id_inc.SelectedIndex = 0;
        txt_obs_pcp_inc.Text = "";

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
        txt_rts.Focus();
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_rts.Focus();
    }

    protected string CriaFiltro(RTS RTS)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_rts.Text))
        {
            RTS.RTS_ID = Convert.ToInt32(txt_rts.Text);
            filtro = filtro + "RTS= " + txt_rts.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            RTS.RTS_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            RTS.RTS_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            RTS.RTS_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_slt_usr_id.Text))
        {
            RTS.RTS_SLT_USR_ID = Convert.ToInt32(cbo_slt_usr_id.SelectedValue);
            filtro = filtro + "Respons?vel pela Solicita??o= " + cbo_slt_usr_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_mtv_tst_id.Text))
        {
            RTS.RTS_MTV_TST_ID = Convert.ToInt32(cbo_mtv_tst_id.SelectedValue);
            filtro = filtro + "Motivo Teste= " + cbo_mtv_tst_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_cli_id.Text))
        {
            RTS.RTS_CLI_ID = Convert.ToInt32(cbo_cli_id.SelectedValue);
            filtro = filtro + "Cliente= " + cbo_cli_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id.Text))
        {
            RTS.RTS_FOR_001_ID = Convert.ToInt32(cbo_for_id.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            RTS.RTS_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo M?quina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            RTS.RTS_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        RTS RTS = new RTS();
        filtro = CriaFiltro(RTS);
        DataSet dsRTS = RTS.Consultar();

        gvRTS.DataSource = dsRTS;
        gvRTS.DataBind();
        dsRTS.Dispose();
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

    protected void gvRTS_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvRTS.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvRTS.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'RTS.aspx?rowId=" + gvRTS.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvRTS.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvRTS.Columns.IndexOf(field);
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

    protected void gvRTS_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvRTS_Sorting(Object sender, GridViewSortEventArgs e)
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

        RTS RTS = new RTS();
        filtro = CriaFiltro(RTS);
        DataSet dsRTS = RTS.Consultar();

        DataTable dtRTS = dsRTS.Tables[0];
        DataView dvRTS = new DataView(dtRTS);
        dvRTS.Sort = e.SortExpression + Ordem;
        gvRTS.DataSource = dvRTS;
        gvRTS.DataBind();

        dvRTS.Dispose();
        dtRTS.Dispose();
        dsRTS.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg;

        if (txt_dat_inc.Text == "")
        {
            TratamentoErro("O campo Data da Solicita??o ? obrigat?rio.");
            txt_dat_inc.Focus();
            return;
        }

        if (cbo_slt_usr_id_inc.Text == "")
        {
            TratamentoErro("O campo Respons?vel Solicita??o ? obrigat?rio.");
            cbo_slt_usr_id_inc.Focus();
            return;
        }

        if (cbo_mtv_tst_id_inc.Text == "")
        {
            TratamentoErro("O campo Motivo do Teste ? obrigat?rio.");
            cbo_mtv_tst_id_inc.Focus();
            return;
        }

        if (cbo_cli_id_inc.Text == "")
        {
            TratamentoErro("O campo Cliente ? obrigat?rio.");
            cbo_cli_id_inc.Focus();
            return;
        }

        if (cbo_tit_poy_id_inc.Text == "")
        {
            TratamentoErro("O campo T?tulo ? obrigat?rio.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

        if (cbo_ert_id_inc.Text == "")
        {
            TratamentoErro("O campo Entrela?amento ? obrigat?rio.");
            cbo_ert_id_inc.Focus();
            return;
        }

        if (cbo_aps_id_inc.Text == "")
        {
            TratamentoErro("O campo Apresenta??o ? obrigat?rio.");
            cbo_aps_id_inc.Focus();
            return;
        }

        if (cbo_cor_id_inc.Text == "")
        {
            TratamentoErro("O campo Cor ? obrigat?rio.");
            cbo_cor_id_inc.Focus();
            return;
        }

        if (cbo_fio_id_inc.Text == "")
        {
            TratamentoErro("O campo Fio ? obrigat?rio.");
            cbo_fio_id_inc.Focus();
            return;
        }

        if (cbo_grp_mrl_id_inc.Text == "")
        {
            TratamentoErro("O campo Grupo de Material ? obrigat?rio.");
            cbo_grp_mrl_id_inc.Focus();
            return;
        }

        if (cbo_mrc_id_inc.Text == "")
        {
            TratamentoErro("O campo Marca ? obrigat?rio.");
            cbo_mrc_id_inc.Focus();
            return;
        }

        if (cbo_esl_id_inc.Text == "")
        {
            TratamentoErro("O campo Escolha ? obrigat?rio.");
            cbo_esl_id_inc.Focus();
            return;
        }

        if (cbo_cxa_id_inc.Text == "")
        {
            TratamentoErro("O campo Caixa ? obrigat?rio.");
            cbo_cxa_id_inc.Focus();
            return;
        }

        // Maior que P&d e n?o Cancelado
        if ((Convert.ToInt32(cbo_sts_inc.Text) >= 3) && (cbo_sts_inc.Text != "0"))
        {
            if (cbo_for_001_id_inc.Text == "")
            {
                TratamentoErro("O campo Fornecedor ? obrigat?rio.");
                cbo_for_001_id_inc.Focus();
                return;
            }

            if (cbo_maq_tip_id_inc.Text == "")
            {
                TratamentoErro("O campo Tipo de M?quina ? obrigat?rio.");
                cbo_maq_tip_id_inc.Focus();
                return;
            }

            if (txt_mge_inc.Text == "")
            {
                TratamentoErro("O campo Merge ? obrigat?rio.");
                txt_mge_inc.Focus();
                return;
            }

            if (txt_log_dat_inc.Text == "")
            {
                TratamentoErro("O campo Data Log?stica ? obrigat?rio.");
                txt_log_dat_inc.Focus();
                return;
            }

            if (cbo_log_usr_id_inc.Text == "")
            {
                TratamentoErro("O campo Respons?vel Log?stica ? obrigat?rio.");
                cbo_log_usr_id_inc.Focus();
                return;
            }
        }

        // Maior que P&D (P&D Finalizado) e n?o Cancelado
        if ((Convert.ToInt32(cbo_sts_inc.Text) > 3) && (cbo_sts_inc.Text != "0"))
        {
            // Se V?lido = N
            if (cbo_vli_inc.SelectedValue == "N")
            {
                if (txt_jtf_inc.Text == "")
                {
                    TratamentoErro("O campo Justificativa ? obrigat?rio.");
                    txt_jtf_inc.Focus();
                    return;
                }
            }

            // Se Calcula Custo = S 
            if (cbo_cst_inc.SelectedValue == "S")
            {
                if (txt_tit_inc.Text == "")
                {
                    TratamentoErro("O campo T?tulo ? obrigat?rio.");
                    txt_tit_inc.Focus();
                    return;
                }

                if (txt_ole_inc.Text == "")
                {
                    TratamentoErro("O campo % de ?leo ? obrigat?rio.");
                    txt_ole_inc.Focus();
                    return;
                }

                if (txt_pes_sup_inc.Text == "")
                {
                    TratamentoErro("O campo Peso por Suporte (Kg) ? obrigat?rio.");
                    txt_pes_sup_inc.Focus();
                    return;
                }

                if (txt_efc_inc.Text == "")
                {
                    TratamentoErro("O campo % de Efici?ncia ? obrigat?rio.");
                    txt_efc_inc.Focus();
                    return;
                }

                if (txt_prc_inc.Text == "")
                {
                    TratamentoErro("O campo Produ??o (Kg/M?q./dia) ? obrigat?rio.");
                    txt_prc_inc.Focus();
                    return;
                }

                if (txt_qbr_tur_inc.Text == "")
                {
                    TratamentoErro("O campo Quebra por Turno ? obrigat?rio.");
                    txt_qbr_tur_inc.Focus();
                    return;
                }

                if (txt_qbr_kio_inc.Text == "")
                {
                    TratamentoErro("O campo Quebra por Kg ? obrigat?rio.");
                    txt_qbr_kio_inc.Focus();
                    return;
                }

                if (txt_qbr_pnv_inc.Text == "")
                {
                    TratamentoErro("O campo Qualidade NV% ? obrigat?rio.");
                    txt_qbr_pnv_inc.Focus();
                    return;
                }

                if (txt_qbr_dnv_inc.Text == "")
                {
                    TratamentoErro("O campo Qualidade DV% ? obrigat?rio.");
                    txt_qbr_dnv_inc.Focus();
                    return;
                }

                if (txt_car_inc.Text == "")
                {
                    TratamentoErro("O campo Consumo de Ar ? obrigat?rio.");
                    txt_car_inc.Focus();
                    return;
                }

            }

            if (txt_ped_dat_inc.Text == "")
            {
                TratamentoErro("O campo Data Resposta ? obrigat?rio.");
                txt_ped_dat_inc.Focus();
                return;
            }

            if (cbo_ped_usr_id_inc.Text == "")
            {
                TratamentoErro("O campo Respons?vel P&D ? obrigat?rio.");
                cbo_ped_usr_id_inc.Focus();
                return;
            }
        }

        // Maior que PCP (PCP Finalizado) e n?o Cancelado
        if ((Convert.ToInt32(cbo_sts_inc.Text) > 4) && (cbo_sts_inc.Text != "0"))
        {
            if (txt_dsv_dat_inc.Text == "")
            {
                TratamentoErro("O campo Data de Desenvolvimento ? obrigat?rio.");
                txt_dsv_dat_inc.Focus();
                return;
            }

            if (cbo_maq_id_inc.Text == "")
            {
                TratamentoErro("O campo M?quina ? obrigat?rio.");
                cbo_maq_id_inc.Focus();
                return;
            }

            if (txt_pjt_dat_inc.Text == "")
            {
                TratamentoErro("O campo Data Resposta ? obrigat?rio.");
                txt_pjt_dat_inc.Focus();
                return;
            }

            if (cbo_pjt_usr_id_inc.Text == "")
            {
                TratamentoErro("O campo Respons?vel Planejamento ? obrigat?rio.");
                cbo_pjt_usr_id_inc.Focus();
                return;
            }
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status ? obrigat?rio.");
            cbo_sts_inc.Focus();
            return;
        }

        RTS RTS = new RTS();
        if (txt_dat_inc.Text != "")
        {
            RTS.RTS_DAT = Convert.ToDateTime(txt_dat_inc.Text);
        }
        if (cbo_slt_usr_id_inc.Text != "")
        {
            RTS.RTS_SLT_USR_ID = Convert.ToInt32(cbo_slt_usr_id_inc.SelectedValue);
        }
        RTS.RTS_MTV_TST_ID = Convert.ToInt32(cbo_mtv_tst_id_inc.SelectedValue);
        RTS.RTS_CLI_ID = Convert.ToInt32(cbo_cli_id_inc.SelectedValue);
        if (cbo_tit_poy_id_inc.Text != "")
        {
            RTS.RTS_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
        }
        if (cbo_ert_id_inc.Text != "")
        {
            RTS.RTS_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
        }
        if (cbo_aps_id_inc.Text != "")
        {
            RTS.RTS_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
        }
        if (cbo_scc_trv_id_inc.SelectedValue != "")
        {
            RTS.RTS_SCC_TRV_ID = Convert.ToInt32(cbo_scc_trv_id_inc.SelectedValue);
        }
        if (cbo_mtd_id_inc.SelectedValue != "")
        {
            RTS.RTS_MTD_ID = Convert.ToInt32(cbo_mtd_id_inc.SelectedValue);
        }
        if (cbo_cor_id_inc.SelectedValue != "")
        {
            RTS.RTS_COR_ID = Convert.ToInt32(cbo_cor_id_inc.SelectedValue);
        }
        if (cbo_fio_id_inc.SelectedValue != "")
        {
            RTS.RTS_FIO_ID = Convert.ToInt32(cbo_fio_id_inc.SelectedValue);
        }
        if (cbo_grp_mrl_id_inc.SelectedValue != "")
        {
            RTS.RTS_GRP_MRL_ID = Convert.ToInt32(cbo_grp_mrl_id_inc.SelectedValue);
        }
        RTS.RTS_LOT_REF = txt_lot_ref_inc.Text;
        RTS.RTS_VLC = txt_vlc_inc.Text;
        if (cbo_mrc_id_inc.SelectedValue != "")
        {
            RTS.RTS_MRC_ID = Convert.ToInt32(cbo_mrc_id_inc.SelectedValue);
        }
        if (cbo_esl_id_inc.Text != "")
        {
            RTS.RTS_ESL_ID = Convert.ToInt32(cbo_esl_id_inc.SelectedValue);
        }
        if (cbo_cxa_id_inc.Text != "")
        {
            RTS.RTS_CXA_ID = Convert.ToInt32(cbo_cxa_id_inc.SelectedValue);
        }
        RTS.RTS_CST = cbo_cst_inc.Text;
        RTS.RTS_DMO = txt_dmo_inc.Text;
        RTS.RTS_PES = txt_pes_inc.Text;
        RTS.RTS_SPE = txt_spe_inc.Text;
        RTS.RTS_OBS_SLT = txt_obs_slt_inc.Text;

        if (cbo_for_001_id_inc.SelectedValue != "")
        {
            RTS.RTS_FOR_001_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
        }
        if (cbo_for_002_id_inc.SelectedValue != "")
        {
            RTS.RTS_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
        }
        if (cbo_for_003_id_inc.SelectedValue != "")
        {
            RTS.RTS_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
        }
        if (cbo_for_004_id_inc.SelectedValue != "")
        {
            RTS.RTS_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
        }
        RTS.RTS_SPA = Convert.ToInt32(chk_spa_inc.Checked);
        if (cbo_maq_tip_id_inc.Text != "")
        {
            RTS.RTS_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
        }
        RTS.RTS_MGE = txt_mge_inc.Text;
        RTS.RTS_MGE_002 = txt_mge_002_inc.Text;
        RTS.RTS_MGE_003 = txt_mge_003_inc.Text;
        RTS.RTS_MGE_004 = txt_mge_004_inc.Text;
        if (txt_log_dat_inc.Text != "")
        {
            RTS.RTS_LOG_DAT = Convert.ToDateTime(txt_log_dat_inc.Text);
        }
        if (cbo_log_usr_id_inc.Text != "")
        {
            RTS.RTS_LOG_USR_ID = Convert.ToInt32(cbo_log_usr_id_inc.SelectedValue);
        }
        RTS.RTS_OBS_LOG = txt_obs_log_inc.Text;

        RTS.RTS_VLI = cbo_vli_inc.Text;
        RTS.RTS_JTF = txt_jtf_inc.Text;

        //Se Status ? P&D CriaLote
        if (cbo_sts_inc.SelectedValue == "3" || cbo_sts_inc.SelectedValue == "4")
        {
            CriaLote(sender, e);
        }
        RTS.RTS_LOT = txt_lot_inc.Text;

        if (txt_tit_inc.Text != "")
        {
            RTS.RTS_TIT = Convert.ToDouble(txt_tit_inc.Text);
        }
        if (txt_vel_inc.Text != "")
        {
            RTS.RTS_VEL = Convert.ToInt32(txt_vel_inc.Text);
        }
        if (txt_cbo_inc.Text != "")
        {
            RTS.RTS_CBO = Convert.ToInt32(txt_cbo_inc.Text);
        }
        if (txt_prc_inc.Text != "")
        {
            RTS.RTS_PRC = Convert.ToDouble(txt_prc_inc.Text);
        }
        if (txt_qbr_tur_inc.Text != "")
        {
            RTS.RTS_QBR_TUR = Convert.ToDouble(txt_qbr_tur_inc.Text);
        }
        if (txt_qbr_kio_inc.Text != "")
        {
            RTS.RTS_QBR_KIO = Convert.ToDouble(txt_qbr_kio_inc.Text);
        }
        if (txt_pao_001_inc.Text != "")
        {
            RTS.RTS_PAO_001 = Convert.ToDouble(txt_pao_001_inc.Text);
        }
        if (txt_pao_002_inc.Text != "")
        {
            RTS.RTS_PAO_002 = Convert.ToDouble(txt_pao_002_inc.Text);
        }
        if (cbo_jet_001_inc.Text != "")
        {
            RTS.RTS_JET_001 = cbo_jet_001_inc.SelectedItem.Text;
        }
        if (cbo_jet_002_inc.Text != "")
        {
            RTS.RTS_JET_002 = cbo_jet_002_inc.SelectedItem.Text;
        }
        if (txt_car_inc.Text != "")
        {
            RTS.RTS_QBR_CAR = Convert.ToDouble(txt_car_inc.Text);
        }
        if (txt_ole_inc.Text != "")
        {
            RTS.RTS_OLE = Convert.ToDouble(txt_ole_inc.Text);
        }
        if (txt_pes_sup_inc.Text != "")
        {
            RTS.RTS_PES_SUP = Convert.ToDouble(txt_pes_sup_inc.Text);
        }
        if (txt_efc_inc.Text != "")
        {
            RTS.RTS_EFC = Convert.ToDouble(txt_efc_inc.Text);
        }        
        if (txt_qbr_pnv_inc.Text != "")
        {
            RTS.RTS_QBR_PNV = Convert.ToDouble(txt_qbr_pnv_inc.Text);
        }
        if (txt_qbr_dnv_inc.Text != "")
        {
            RTS.RTS_QBR_DNV = Convert.ToDouble(txt_qbr_dnv_inc.Text);
        }
        if (txt_ped_dat_inc.Text != "")
        {
            RTS.RTS_PED_DAT = Convert.ToDateTime(txt_ped_dat_inc.Text);
        }
        if (cbo_ped_usr_id_inc.Text != "")
        {
            RTS.RTS_PED_USR_ID = Convert.ToInt32(cbo_ped_usr_id_inc.SelectedValue);
        }
        RTS.RTS_OBS_PED = txt_obs_ped_inc.Text;
        
        if (txt_dsv_dat_inc.Text != "")
        {
            RTS.RTS_DAT_DSV = Convert.ToDateTime(txt_dsv_dat_inc.Text);
        }
        if (cbo_maq_id_inc.Text != "")
        {
            RTS.RTS_MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
        }
        if (txt_pjt_dat_inc.Text != "")
        {
            RTS.RTS_PJT_DAT = Convert.ToDateTime(txt_pjt_dat_inc.Text);
        }
        if (cbo_pjt_usr_id_inc.Text != "")
        {
            RTS.RTS_PJT_USR_ID = Convert.ToInt32(cbo_pjt_usr_id_inc.SelectedValue);
        }
        RTS.RTS_OBS_PCP = txt_obs_pcp_inc.Text;

        if (cbo_sts_inc.Text != "")
        {
            RTS.RTS_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        if (!string.IsNullOrEmpty(rowId.Value))
        {
            RTS.RTS_ID = Convert.ToInt32(rowId.Value);
            RTS.RTS_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = RTS.Alterar();

            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                TratamentoErro("RTS alterado com sucesso.");
            }
        }
        else
        {
            /*
            RTS RTS = new RTS();
            //Verificar se j? n?o existe um cadastro consultando o: RTS_DES 
            RTS.RTS_DES = txt_des_inc.Text;
            DataSet dsRTS = RTS.Consultar();
            if (dsRTS.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse RTS j? est? cadastrado.");
                txt_dat_inc.Focus();

                return;
            }
            */ 
            RTS.RTS_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = RTS.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("RTS inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            //dsRTS.Dispose();
        }
        Dispose();

        if ((cbo_sts_inc.SelectedValue == "2") || (cbo_sts_inc.SelectedValue == "3") || (cbo_sts_inc.SelectedValue == "4"))
        {
            //Enviar email para 2- Logistica, 3 - P&D, 4 - PCP
            EnviaEmail();
        }

        if (cbo_sts_inc.SelectedValue == "5")
        {
            //Enviar Calend?rio para P&D
            EnviaCalendario();
        }

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
        if (gvRTS.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a op??o de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvRTS.AllowSorting = false;
            gvRTS.AllowPaging = false;
            //gvRTS.DataBind();

            // Deixar cabe?alho em branco/preto, sem links e imagens
            for (int i = 0; i < gvRTS.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvRTS.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }
            
            gvRTS.RenderControl(htmlWrite);

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
        if (gvRTS.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a op??o de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvRTS.AllowSorting = false;
            gvRTS.AllowPaging = false;

            // Deixar cabe?alho em branco/preto, sem links e imagens

            for (int i = 0; i < gvRTS.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvRTS.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvRTS.RenderControl(htmlWrite);

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

    protected void CriaLote(object sender, EventArgs e)
    {
        //Se RTS ? v?lida e Lote ainda n?o foi informado cria Lote
        if ((cbo_vli_inc.SelectedValue == "S") && (txt_lot_inc.Text == ""))
        {
            string sFornecedor = "";
            //SPANDEX = Z
            if (chk_spa_inc.Checked)
            {
                sFornecedor = "Z";
            }
            else
            {
                if (cbo_for_001_id_inc.Text != "")
                {
                    //Havendo segundo fornecedor e sendo diferente do primeiro = X
                    if ((cbo_for_002_id_inc.Text != "") && (cbo_for_001_id_inc.Text != cbo_for_002_id_inc.Text))
                    {
                        sFornecedor = "X";
                    }
                    else
                    {
                        Fornecedor Fornecedor = new Fornecedor();
                        Fornecedor.FOR_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
                        DataSet dsFornecedor = Fornecedor.Consultar();
                        DataTable dtFornecedor = dsFornecedor.Tables[0];
                        if (dtFornecedor.Rows.Count > 0)
                        {
                            DataRow drFornecedor = dtFornecedor.Rows[0];
                            sFornecedor = drFornecedor["FOR_SAP"].ToString();
                        }
                        dtFornecedor.Dispose();
                        dsFornecedor.Dispose();
                        Dispose();
                    }
                }
            }

            string sMaquinaTipo = "";
            if (cbo_maq_tip_id_inc.Text != "")
            {
                MaquinaTipo MaquinaTipo = new MaquinaTipo();
                MaquinaTipo.MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
                DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
                DataTable dtMaquinaTipo = dsMaquinaTipo.Tables[0];
                if (dtMaquinaTipo.Rows.Count > 0)
                {
                    DataRow drMaquinaTipo = dtMaquinaTipo.Rows[0];
                    sMaquinaTipo = drMaquinaTipo["MAQ_TIP_SAP"].ToString();
                }
                dtMaquinaTipo.Dispose();
                dsMaquinaTipo.Dispose();
                Dispose();
            }

            if (sFornecedor != "" && sMaquinaTipo != "")
            {

                string sAle = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string sPri = "";
                string sSeg = "";
                Random rnd = new Random();

                int i = 0;
                Boolean bOK = false;

                Standard Standard = new Standard();
                do
                {
                    sPri = sAle[Convert.ToInt16(rnd.NextDouble() * sAle.Length)].ToString();
                    sSeg = sAle[Convert.ToInt16(rnd.NextDouble() * sAle.Length)].ToString();
                    i++;

                    Standard.EPF_LOT = sFornecedor + sMaquinaTipo + sPri + sSeg;
                    DataSet dsStandard = Standard.Consultar();
                    if (dsStandard.Tables[0].Rows.Count == 0)
                    {
                        bOK = true;
                    }

                } while ((i <= 200) && (!bOK));

                if (bOK)
                {
                    txt_lot_inc.Text = sFornecedor + sMaquinaTipo + sPri + sSeg;
                }
                else
                {
                    TratamentoErro("Houve 200 tentativas de cria??o de Lote Aleat?rio sem sucesso, verifique no Standard se existe sequ?ncia Lotes dispon?veis");
                    txt_lot_inc.Focus();
                }
            }
        }

        Control c = (Control)sender;
        if (c.ID == "cbo_for_001_id_inc")
        {
            cbo_for_002_id_inc.Focus();
        }
        else if (c.ID == "cbo_for_002_id_inc")
        {
            cbo_for_003_id_inc.Focus();
        }
        else if (c.ID == "chk_spa")
        {
            cbo_maq_tip_id_inc.Focus();
        }
        else
        {
            txt_mge_inc.Focus();
        }
    }

    protected void VerificaLote(object sender, EventArgs e)
    {
        txt_tit_inc.Focus();

        if (txt_lot_inc.Text != "")
        {
            Standard Standard = new Standard();
            Standard.EPF_LOT = txt_lot_inc.Text;
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse Lote j? existe");
                txt_lot_inc.Focus();
            }

            dsStandard.Dispose();
            Dispose();
        }
    }

    protected void cbo_maq_tip_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Lote ser? criado ao Salvar Status P&D
        //CriaLote(sender, e);
        CarregaMaquina();
        CalculaProducaoConsumoAr(sender, e);
        txt_mge_inc.Focus();
    }
    
    protected void CarregaMaquina()
    {
        cbo_maq_id_inc.Items.Clear();
        cbo_maq_id_inc.AppendDataBoundItems = true;
        cbo_maq_id_inc.Items.Insert(0, "");

        if (cbo_maq_tip_id_inc.Text != "")
        {
            Maquina Maquina = new Maquina();
            Maquina.MAQ_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
            DataSet dtMaquina = Maquina.Consultar();

            cbo_maq_id_inc.DataTextField = "MAQ_DES";
            cbo_maq_id_inc.DataValueField = "MAQ_ID";

            cbo_maq_id_inc.DataSource = dtMaquina;
            cbo_maq_id_inc.DataBind();

            dtMaquina.Dispose();
            Dispose();
        }
    }

    protected void CalculaProducaoConsumoAr(object sender, EventArgs e)
    {
        CalculaProducaoQuebra(sender, e);
        CalculaConsumoAr(sender, e);
        txt_prc_inc.Focus();
    }

    protected void CalculaProducaoQuebra(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_tit_inc.Text) && !string.IsNullOrEmpty(txt_vel_inc.Text) && !string.IsNullOrEmpty(txt_efc_inc.Text))
        {
            //MAP24042012
            //Altera??o das formulas de c?lculo e inclus?o da ATF21
            //M?quinas que utilizam JET / AR
            if (cbo_maq_tip_id_inc.SelectedItem.Text == "SSM" || cbo_maq_tip_id_inc.SelectedItem.Text == "STAHLE")
            {
                //txt_prc_inc.Text = (0.00013525 * Convert.ToDouble(txt_tit_inc.Text) * Convert.ToDouble(txt_vel_inc.Text) * 24).ToString("0.00");
                //(((t?tulo*velocidade*24*24*60)/10000)/1000))*%efici?ncia)/100
                txt_prc_inc.Text = ((Convert.ToDouble(txt_tit_inc.Text) * Convert.ToDouble(txt_vel_inc.Text) * 24 * 24 * 60 / 10000 / 1000) * (Convert.ToDouble(txt_efc_inc.Text) / 100)).ToString("0.00");
            }
            //M?quinas ATF21
            else if (cbo_maq_tip_id_inc.SelectedItem.Text == "ATF21")
            {
                if (!string.IsNullOrEmpty(txt_cbo_inc.Text))
                {
                    //txt_prc_inc.Text = (0.00013525 * Convert.ToDouble(txt_tit_inc.Text) * Convert.ToDouble(txt_vel_inc.Text) * 24).ToString("0.00");
                    //(0,00013525*t?tulo*velocidade*(240/cabos)*%de efici?ncia)/100
                    txt_prc_inc.Text = (0.00013525 * Convert.ToDouble(txt_tit_inc.Text) * Convert.ToDouble(txt_vel_inc.Text) * (240 / Convert.ToDouble(txt_cbo_inc.Text)) * (Convert.ToDouble(txt_efc_inc.Text) / 100)).ToString("0.00");
                }
                else
                {
                    txt_prc_inc.Text = "";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_cbo_inc.Text))
                {
                    //(0,00013525*t?tulo*velocidade*(216/cabos)*%de efici?ncia)/100
                    txt_prc_inc.Text = (0.00013525 * Convert.ToDouble(txt_tit_inc.Text) * Convert.ToDouble(txt_vel_inc.Text) * (216 / Convert.ToDouble(txt_cbo_inc.Text)) * (Convert.ToDouble(txt_efc_inc.Text) / 100)).ToString("0.00");
                }
                else
                {
                    txt_prc_inc.Text = "";
                }
            }

            CalculaQuebra(sender, e);
        }
        else
        {
            txt_prc_inc.Text = "";
        }

        Control c = (Control)sender;
        if (c.ID == "txt_tit_inc")
        {
            txt_vel_inc.Focus();
        }
        else if (c.ID == "txt_vel_inc")
        {
            txt_efc_inc.Focus();
        }
        else
        {
            txt_cbo_inc.Focus();
        }
    }

    protected void CalculaConsumoAr(object sender, EventArgs e)
    {
        //Press?o 1 e Jet 1 ou Press?o 2 e Jet 2 prrenchidos
        if ((!string.IsNullOrEmpty(txt_pao_001_inc.Text) && !string.IsNullOrEmpty(cbo_jet_001_inc.Text)) || (!string.IsNullOrEmpty(txt_pao_002_inc.Text) && !string.IsNullOrEmpty(cbo_jet_002_inc.Text)))
        {
            if (cbo_jet_001_inc.SelectedValue.IndexOf("CBO") > 0 && string.IsNullOrEmpty(txt_cbo_inc.Text))
            {
                TratamentoErro("A quantidade de cabos ? obrigat?rio");
                txt_cbo_inc.Focus();
                return;
            }
            else
            {
                txt_car_inc.Text = "";
            }

            string sFormula = "";
            //Se informar Jet 1
            if (!string.IsNullOrEmpty(txt_pao_001_inc.Text) && !string.IsNullOrEmpty(cbo_jet_001_inc.Text))
            {
                sFormula = cbo_jet_001_inc.Text.Trim();
                sFormula = sFormula.Replace("PAO_001", txt_pao_001_inc.Text);
            }
            //Se informar Jet 2
            if (!string.IsNullOrEmpty(txt_pao_002_inc.Text) && !string.IsNullOrEmpty(cbo_jet_002_inc.Text))
            {
                //Se informou Jet 1 
                if (!string.IsNullOrEmpty(sFormula))
                {
                    sFormula += " + ";
                }

                sFormula = sFormula + cbo_jet_002_inc.Text.Trim();
                sFormula = sFormula.Replace("PAO_002", txt_pao_002_inc.Text);
            }
            sFormula = sFormula.Replace("CBO", txt_cbo_inc.Text);
            //N?o deixa com , troca para .
            sFormula = sFormula.Replace(",", ".");
            //Response.Write(sFormula);

            //M?quinas que utilizam JET / AR
            if (cbo_maq_tip_id_inc.SelectedItem.Text == "SSM" || cbo_maq_tip_id_inc.SelectedItem.Text == "STAHLE")
            {
                Type cstype = this.GetType();
                ClientScript.RegisterStartupScript(cstype, "EvaluateExpression", "<script>document.all(\"txt_car_inc\").value = (Math.round(eval(\"(" + sFormula + ") * 24" + "\")*100)/100).toString().replace(\".\", \",\");</script>");
            }
            //M?quinas ATF21
            else if (cbo_maq_tip_id_inc.SelectedItem.Text == "ATF21")
            {
                if (!string.IsNullOrEmpty(txt_cbo_inc.Text))
                {
                    Type cstype = this.GetType();
                    ClientScript.RegisterStartupScript(cstype, "EvaluateExpression", "<script>document.all(\"txt_car_inc\").value = (Math.round(eval(\"(" + sFormula + ") * (240 / " + txt_cbo_inc.Text + ")" + "\")*100)/100).toString().replace(\".\", \",\");</script>");
                }
                else
                {
                    txt_car_inc.Text = "";
                }
            }
            //Demais M?quinas
            else
            {
                if (!string.IsNullOrEmpty(txt_cbo_inc.Text))
                {
                    Type cstype = this.GetType();
                    ClientScript.RegisterStartupScript(cstype, "EvaluateExpression", "<script>document.all(\"txt_car_inc\").value = (Math.round(eval(\"(" + sFormula + ") * (216 / " + txt_cbo_inc.Text + ")" + "\")*100)/100).toString().replace(\".\", \",\");</script>");
                }
                else
                {
                    txt_car_inc.Text = "";
                }
            }
        }
        else
        {
            txt_car_inc.Text = "";
        }

        Control c = (Control)sender;
        if (c.ID == "txt_pao_001_inc")
        {
            cbo_jet_001_inc.Focus();
        }
        else if (c.ID == "cbo_jet_001_inc")
        {
            txt_pao_002_inc.Focus();
        }
        else if (c.ID == "txt_pao_002_inc")
        {
            cbo_jet_002_inc.Focus();
        }
        else
        {
            txt_car_inc.Focus();
        }
    }

    protected void CalculaQuebra(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_prc_inc.Text) && !string.IsNullOrEmpty(txt_qbr_tur_inc.Text))
        {
            //MAP24032012
            //Quebra n?o ? / 3 e sim * 3
            //txt_qbr_kio_inc.Text = (Convert.ToDouble(txt_qbr_tur_inc.Text) / Convert.ToDouble(txt_prc_inc.Text) / 3).ToString("0.00");
            txt_qbr_kio_inc.Text = (Convert.ToDouble(txt_qbr_tur_inc.Text) / Convert.ToDouble(txt_prc_inc.Text) * 3).ToString("0.00");
        }
        else
        {
            txt_qbr_kio_inc.Text = "";
        }

        Control c = (Control)sender;
        if (c.ID == "txt_qbr_tur_inc")
        {
            txt_qbr_kio_inc.Focus();
        }
        else if (c.ID == "txt_pao_inc")
        {
            cbo_jet_001_inc.Focus();
        }
        else if (c.ID == "cbo_jet_001_inc")
        {
            cbo_jet_002_inc.Focus();
        }
        else
        {
            txt_car_inc.Focus();
        }

    }

    protected void EnviaEmail()
    {
        string sRemetente = ConfigurationManager.AppSettings["EnderecoSMTP"];
        string sListaDestinatario = "";
        string sListaCopia = ConfigurationManager.AppSettings["EnderecoSMTP"];

        Usuario Usuario = new Usuario();

        //Perfil do Status atual
        if (cbo_sts_inc.SelectedValue == "2")
        {
            Usuario.USR_PFL_ID = 51;
        }
        else if (cbo_sts_inc.SelectedValue == "3") 
        {
            Usuario.USR_PFL_ID = 52;
        }
            else if(cbo_sts_inc.SelectedValue == "4")
        {
            Usuario.USR_PFL_ID = 53;
        }

        DataSet dsUsuario = Usuario.Consultar();
        foreach (DataRow drUsuario in dsUsuario.Tables[0].Rows)
        {
            sListaDestinatario += ";" + drUsuario["USR_EML"].ToString();
        }
        dsUsuario.Dispose();

        Usuario UsuarioAtual = new Usuario();
        UsuarioAtual.USR_PFL_ID = Convert.ToInt32(Session["PFL_ID"].ToString());
        DataSet dsUsuarioAtual = UsuarioAtual.Consultar();
        foreach (DataRow drUsuarioAtual in dsUsuarioAtual.Tables[0].Rows)
        {
            sListaCopia += ";" + drUsuarioAtual["USR_EML"].ToString();
        }
        dsUsuarioAtual.Dispose();

        string sListaCopiaOculta = "";
        bool bFormatoHTML = true;
        string sTitulo = cbo_sts_inc.SelectedItem.Text + " a RTS de n?mero " + rowId.Value + " est? dispon?vel para sua an?lise";
        string sAssunto = cbo_sts_inc.SelectedItem.Text + " a RTS de n?mero " + rowId.Value + " - " + cbo_tit_poy_id_inc.SelectedItem.Text + " - " + cbo_ert_id_inc.SelectedItem.Text + " - " + cbo_mtv_tst_id_inc.SelectedItem.Text + " - " + cbo_cli_id_inc.SelectedItem.Text + " est? dispon?vel para sua an?lise";
        sAssunto += "<br>";
        if (!string.IsNullOrEmpty(txt_dsv_dat_inc.Text))
        {
            sAssunto += "<br>";
            sAssunto += "Planejada para " + txt_dsv_dat_inc.Text + ".";
        }
        sAssunto += "<br>";
        sAssunto += "Solicitada por " + cbo_slt_usr_id_inc.SelectedItem.Text + " em " + txt_dat_inc.Text + ".";
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

        Response.Write("<script language=\"javascript\">alert('Email enviado com sucesso ao perfil " + cbo_sts_inc.SelectedItem.Text +".')</script>");

        Dispose();
    }

    protected void EnviaCalendario()
    {
        string sRemetente = ConfigurationManager.AppSettings["EnderecoSMTP"];
        string sListaDestinatario = "";

        Usuario Usuario = new Usuario();
        //Perfil P&D
        Usuario.USR_PFL_ID = 52;
        DataSet dsUsuario = Usuario.Consultar();
        foreach (DataRow drUsuario in dsUsuario.Tables[0].Rows)
        {
            sListaDestinatario += ";" + drUsuario["USR_EML"].ToString();
        }
        dsUsuario.Dispose();

        string sListaCopia = ConfigurationManager.AppSettings["EnderecoSMTP"];
        string sListaCopiaOculta = "";
        bool bFormatoHTML = true;
        string sTitulo = "Agendamento da RTS de n?mero " + rowId.Value;
        string sAssunto = "A RTS de n?mero " + rowId.Value + ", est? agendada para " + txt_dsv_dat_inc.Text;
        DateTime dtInicio = Convert.ToDateTime(txt_dsv_dat_inc.Text + " 09:00:00AM");
        DateTime dtTermino = Convert.ToDateTime(txt_dsv_dat_inc.Text + " 10:00:00AM");
        string sLocal = "UNIFI";
        string sListaCaminhoAnexo = "";
        string sServer = ConfigurationManager.AppSettings["ServidorSMTP"];
        string sUsuario = ConfigurationManager.AppSettings["UsuarioSMTP"];
        string sSenha = ConfigurationManager.AppSettings["SenhaSMTP"];
        bool bSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLSMTP"]);
        int iPortaSmtp = Convert.ToInt32(ConfigurationManager.AppSettings["PortaSMTP"]);

        Email Email = new Email();
        Email.EnviarCalendario(sRemetente, sListaDestinatario, sListaCopia, sListaCopiaOculta, bFormatoHTML, sTitulo, sAssunto, dtInicio, dtTermino, sLocal, sListaCaminhoAnexo, sServer, bSSL, iPortaSmtp, sUsuario, sSenha);

        Response.Write("<script language=\"javascript\">alert('Calend?rio enviado com sucesso ao perfil P&D.')</script>");
    }
}
