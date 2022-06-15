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
using System.Drawing;

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
        txt_rts.Focus();
        /*
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

                txt_dsv_dat_inc.Enabled = false;
                cbo_maq_id_inc.Enabled = false;
                txt_pjt_dat_inc.Enabled = false;
                cbo_pjt_usr_id_inc.Enabled = false;

                txt_tit_inc.Enabled = false;
                txt_vel_inc.Enabled = false;
                txt_cbo_inc.Enabled = false;
                txt_prc_inc.Enabled = false;
                txt_qbr_tur_inc.Enabled = false;
                txt_qbr_kio_inc.Enabled = false;
                txt_ole_inc.Enabled = false;
                txt_pes_sup_inc.Enabled = false;
                txt_efc_inc.Enabled = false;
                txt_ped_dat_inc.Enabled = false;
                cbo_ped_usr_id_inc.Enabled = false;
                txt_obs_ped_inc.Enabled = false;

                cbo_sts_inc.Enabled = false;
        */
    }

    protected void CarregaControles()
	{
		MotivoTeste MotivoTeste = new MotivoTeste();
		DataSet dsMotivoTeste = MotivoTeste.Consultar();
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
        FWGNR.VerificaStatus(dsSolicitanteUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_slt_usr_id_inc);
        dsSolicitanteUsuario.Dispose();

        Cliente Cliente = new Cliente();
        DataSet dsCliente = Cliente.Consultar();
        FWGNR.VerificaStatus(dsCliente, "CLI_ID", "CLI_NOM", "CLI_STS", cbo_cli_id_inc);
        dsCliente.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "T"; //Somente Texturizados
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_inc);
        dsFornecedor.Dispose();

		MaquinaTipo MaquinaTipo = new MaquinaTipo();
		DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
		dsMaquinaTipo.Dispose();

        Usuario LogisticaUsuario = new Usuario();
        LogisticaUsuario.IN_USR_PFL_ID = "51, 55"; //Perfil Logistica e Solicitante/Logistica
		DataSet dsLogisticaUsuario = LogisticaUsuario.Consultar();
        FWGNR.VerificaStatus(dsLogisticaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_log_usr_id_inc);
		dsLogisticaUsuario.Dispose();

		Usuario PEDUsuario = new Usuario();
        PEDUsuario.USR_PFL_ID = 52; //Perfil P&D
        DataSet dsPEDUsuario = PEDUsuario.Consultar();
        FWGNR.VerificaStatus(dsPEDUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ped_usr_id_inc);
		dsPEDUsuario.Dispose();

        Usuario PlanejamentoUsuario = new Usuario();
        PlanejamentoUsuario.USR_PFL_ID = 53; //Perfil PCP
        DataSet dsPlanejamentoUsuario = PlanejamentoUsuario.Consultar();
        FWGNR.VerificaStatus(dsPlanejamentoUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_pjt_usr_id_inc);
        dsPlanejamentoUsuario.Dispose();

    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        RTS RTS = new RTS();
        filtro = CriaFiltro(RTS);
        DataSet dsRTS = RTS.Consultar();
        dvResultado.Visible = true;
        dvFiltro.Visible = false;
        if (dsRTS.Tables[0].Rows.Count > 0)
        {
            txt_rts_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_ID"].ToString();
            txt_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_DAT"].ToString()).ToString("dd/MM/yyyy");
            cbo_slt_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_SLT_USR_ID"].ToString();
            txt_slt_usr_id_inc.Text = cbo_slt_usr_id_inc.SelectedItem.Text;
            cbo_mtv_tst_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MTV_TST_ID"].ToString();
            txt_mtv_tst_id_inc.Text = cbo_mtv_tst_id_inc.SelectedItem.Text;
            cbo_cli_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_CLI_ID"].ToString();
            txt_cli_id_inc.Text = cbo_cli_id_inc.SelectedItem.Text;
            cbo_tit_poy_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_TIT_POY_ID"].ToString();
            txt_tit_poy_id_inc.Text = cbo_tit_poy_id_inc.SelectedItem.Text;
            cbo_ert_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_ERT_ID"].ToString();
            txt_ert_id_inc.Text = cbo_ert_id_inc.SelectedItem.Text;
            cbo_aps_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_APS_ID"].ToString();
            txt_aps_id_inc.Text = cbo_aps_id_inc.SelectedItem.Text;
            cbo_scc_trv_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_SCC_TRV_ID"].ToString();
            txt_scc_trv_id_inc.Text = cbo_scc_trv_id_inc.SelectedItem.Text;
            cbo_mtd_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MTD_ID"].ToString();
            txt_mtd_id_inc.Text = cbo_mtd_id_inc.SelectedItem.Text;
            cbo_cor_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_COR_ID"].ToString();
            txt_cor_id_inc.Text = cbo_cor_id_inc.SelectedItem.Text;
            cbo_fio_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FIO_ID"].ToString();
            txt_fio_id_inc.Text = cbo_fio_id_inc.SelectedItem.Text;
            txt_lot_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT_REF"].ToString();
            txt_vlc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VLC"].ToString();
            cbo_mrc_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MRC_ID"].ToString();
            txt_mrc_id_inc.Text = cbo_mrc_id_inc.SelectedItem.Text;
            cbo_esl_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_ESL_ID"].ToString();
            txt_esl_id_inc.Text = cbo_esl_id_inc.SelectedItem.Text;
            cbo_cxa_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_CXA_ID"].ToString();
            txt_cxa_id_inc.Text = cbo_cxa_id_inc.SelectedItem.Text;
            cbo_cst_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_CST"].ToString();
            txt_cst_inc.Text = cbo_cst_inc.SelectedItem.Text;
            txt_dmo_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_DMO"].ToString();
            txt_pes_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PES"].ToString();
            txt_spe_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_SPE"].ToString();
            txt_obs_slt_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_SLT"].ToString();

            cbo_for_001_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_001_ID"].ToString();
            txt_for_001_id_inc.Text = cbo_for_001_id_inc.SelectedItem.Text;
            cbo_for_002_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_002_ID"].ToString();
            txt_for_002_id_inc.Text = cbo_for_002_id_inc.SelectedItem.Text;
            cbo_for_003_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_003_ID"].ToString();
            txt_for_003_id_inc.Text = cbo_for_003_id_inc.SelectedItem.Text;
            cbo_for_004_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_004_ID"].ToString();
            txt_for_004_id_inc.Text = cbo_for_004_id_inc.SelectedItem.Text;
            cbo_maq_tip_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MAQ_TIP_ID"].ToString();
            txt_maq_tip_id_inc.Text = cbo_maq_tip_id_inc.SelectedItem.Text;
            txt_mge_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE"].ToString();
            txt_mge_002_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_002"].ToString();
            txt_mge_003_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_003"].ToString();
            txt_mge_004_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_004"].ToString();
            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_LOG_DAT"].ToString()))
            {
                txt_log_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_LOG_DAT"].ToString()).ToString("dd/MM/yyyy");
            }
            cbo_log_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_LOG_USR_ID"].ToString();
            txt_log_usr_id_inc.Text = cbo_log_usr_id_inc.SelectedItem.Text;

            CarregaMaquina();
            cbo_maq_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MAQ_ID"].ToString();
            txt_maq_id_inc.Text = cbo_maq_id_inc.SelectedItem.Text;
            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_PJT_DAT"].ToString()))
            {
                txt_pjt_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_PJT_DAT"].ToString()).ToString("dd/MM/yyyy");
            }
            cbo_pjt_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_PJT_USR_ID"].ToString();
            txt_pjt_usr_id_inc.Text = cbo_pjt_usr_id_inc.SelectedItem.Text;

            txt_lot_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT"].ToString();
            txt_tit_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_TIT"].ToString();
            txt_vel_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VEL"].ToString();
            txt_cbo_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_CBO"].ToString();
            txt_prc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PRC"].ToString();
            txt_qbr_tur_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_TUR"].ToString();
            txt_qbr_kio_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_QBR_KIO"].ToString();
            txt_ole_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OLE"].ToString();
            txt_pes_sup_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_PES_SUP"].ToString();
            txt_efc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_EFC"].ToString();
            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_PED_DAT"].ToString()))
            {
                txt_ped_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_PED_DAT"].ToString()).ToString("dd/MM/yyyy");
            }
            cbo_ped_usr_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_PED_USR_ID"].ToString();
            txt_ped_usr_id_inc.Text = cbo_ped_usr_id_inc.SelectedItem.Text;
            txt_obs_ped_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_OBS_PED"].ToString();

            if (!string.IsNullOrEmpty(dsRTS.Tables[0].Rows[0]["RTS_DAT_DSV"].ToString()))
            {
                txt_dsv_dat_inc.Text = Convert.ToDateTime(dsRTS.Tables[0].Rows[0]["RTS_DAT_DSV"].ToString()).ToString("dd/MM/yyyy");
            }

            cbo_sts_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_STS"].ToString();
            txt_sts_inc.Text = cbo_sts_inc.SelectedItem.Text;
        }
        dsRTS.Dispose();
        Dispose();

        dvResultado.Visible = true;
        dvFiltro.Visible = false;
    }

    private void LimpaTela()
    {
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
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            RTS.RTS_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

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
}
