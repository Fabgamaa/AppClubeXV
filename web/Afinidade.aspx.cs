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
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public interface IWin32Window
{ 
}


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
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_vlc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        //txt_vlc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_vrd_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        //txt_bbn_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        //txt_dat_meia.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        //txt_dat_meia.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_hr_meia.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        //txt_hr_meia.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        //txt_dat_tin.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        //txt_dat_tin.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_hr_tin.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        //txt_hr_tin.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        //txt_dat_lei.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        //txt_dat_lei.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_hr_lei.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        //txt_hr_lei.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        //txt_dat_lib.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        //txt_dat_lib.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        //txt_hr_lib.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        //txt_hr_lib.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");

        //Comentado por TI Unifi
        //txt_clo_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_clo_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_esu_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_esu_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_tmt_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_tmt_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_pmt_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_pmt_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_ppf_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_ppf_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_bbb_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_bbb_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_pfe_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_pfe_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_pse_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_pse_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lne_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lne_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_lnc_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_lnc_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_esl_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_esl_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        //txt_tot_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        //txt_tot_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        

    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "T"; //Somente Texturizados
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
        dsTitulo.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "T"; //Somente Texturizados
        DataSet dsFornecedor = Fornecedor.Consultar();
        //FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id);
        //FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id);
        //FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id);
        //FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_inc);
        dsFornecedor.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_inc);
        dsApresentacao.Dispose();

        Maquina Maquina = new Maquina();
        DataSet dsMaquina = Maquina.Consultar();
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id);
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id_inc);
        dsMaquina.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        //FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
        dsMaquinaTipo.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id);
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_inc);
        dsEntrelacamento.Dispose();


        //Defeito Defeito = new Defeito();
        //DataSet dsDefeito = Defeito.ConsultarD();
        //FWGNR.VerificaStatus2(dsDefeito, "DEF_DES", cbo_def_teste);
        ////FWGNR.VerificaStatus2(dsDefeito, "DEF_DES", Dd_Teste);
        //dsDefeito.Dispose();







        Usuario AnalistaUsuario = new Usuario();
        int? filtroperfil ;
        int? filtrostatus ;
        filtrostatus = AnalistaUsuario.USR_STS = 1;
        filtroperfil = AnalistaUsuario.USR_PFL_ID = 5;
        DataSet dsAnalistaUsuario = AnalistaUsuario.Consultar();
        //FWGNR.VerificaStatus(dsAnalistaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ana_usr_id_tin);
        FWGNR.VerificaStatus(dsAnalistaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ana_lei_id_inc);
        FWGNR.VerificaStatus(dsAnalistaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ana_lib_id_inc);
        FWGNR.VerificaStatus(dsAnalistaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ana_lei_id);
        FWGNR.VerificaStatus(dsAnalistaUsuario, "USR_ID", "USR_NOM", "USR_STS", cbo_ana_lib_id);
        dsAnalistaUsuario.Dispose();

    }


    //protected string CriaFiltro(Usuario Usuario)
    //{
    //    string filtro = "";
    //    if (!String.IsNullOrEmpty(txt_cod.Text))
    //    {
    //        Usuario.USR_COD = txt_cod.Text;
    //        filtro = filtro + "Login= " + txt_cod.Text.ToUpper() + "; ";
    //    }
    //    if (!String.IsNullOrEmpty(txt_nom.Text))
    //    {
    //        Usuario.USR_NOM = txt_nom.Text;
    //        filtro = filtro + "Nome= " + txt_nom.Text.ToUpper() + "; ";
    //    }
    //    return filtro;
    //}





    protected void CarregaDados()
    {
        DateTime mydt = DateTime.Now;
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            lbAcao.Text = "Alterar";
            divCadastro.Visible = true;
            dvFiltro.Visible = false;

            txt_lot_inc.Focus();

            Afinidade Afinidade = new Afinidade();
            Afinidade.AFN_ID = Convert.ToInt32(rowId.Value);
            DataSet dsAfinidade = Afinidade.Consultar();
            Defeito Defeito = new Defeito();
            Defeito.DEF_ID = Convert.ToInt32(rowId.Value);
            DataSet dsDefeito = Defeito.Consultar();
            if (dsDefeito.Tables[0].Rows.Count > 0)
            {

                txt_dat_inc.Text = Convert.ToDateTime(mydt.ToString()).ToString("dd/MM/yyyy");
                txt_afn_id.Text = dsDefeito.Tables[0].Rows[0]["AFN_ID"].ToString();
                //txt_dat_inc.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT"].ToString()).ToString("dd/MM/yyyy");
                txt_sem_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_SEM"].ToString();
                //cbo_def_id_inc.Text = dsDefeito.Tables[0].Rows[0]["DEF_DES"].ToString(); 
                //Comentado por TI Unifi
                //cbo_tip_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_TIP"].ToString();
                cbo_tit_poy_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_TIT_POY_ID"].ToString();
                txt_lot_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_LOT"].ToString();
                txt_mge_001_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_MGE_001"].ToString();
                txt_mge_002_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_MGE_003"].ToString();
                txt_mge_004_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_MGE_004"].ToString();
                cbo_for_001_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_FOR_004_ID"].ToString();
                //txt_vlc_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_MAQ_TIP_ID"].ToString();
                cbo_maq_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_MAQ_ID"].ToString();
                cbo_ert_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_ERT_ID"].ToString();
                txt_vrd_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_VRD"].ToString();
                txt_bbn_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_BBN"].ToString();
                //cbo_ana_lei_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_ANA_USR_ID"].ToString();
                //Comentado por TI Unifi
                /*txt_clo_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_CLO"].ToString();
                txt_esu_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_ESU"].ToString();
                txt_tmt_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_TMT"].ToString();
                txt_pmt_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_PMT"].ToString();
                txt_ppf_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_PPF"].ToString();
                txt_bbb_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_BBB"].ToString();
                txt_pfe_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_PFE"].ToString();
                txt_pse_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_PSE"].ToString();
                txt_lne_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_LNE"].ToString();
                txt_lnc_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_LNC"].ToString();
                txt_esl_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_ESL"].ToString();
                txt_tot_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_TOT"].ToString();*/
                //if (dsDefeito.Tables[0].Rows[0]["DEF_TIP"].ToString() == "LUZ NEGRA")
                //{
                //    Chk_Luz_Negra.Checked = true;
                //    txt_lne_inc.Text = dsDefeito.Tables[0].Rows[0]["AFN_LNE"].ToString();
                //}
                cbo_sts_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_STS"].ToString();
                txt_pos.Text = dsDefeito.Tables[0].Rows[0]["DEF_POS"].ToString();
                cbo_def_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["DEF_DES"].ToString();
                //txt_pos0.Text = dsDefeito.Tables[0].Rows[0]["AFN_ID"].ToString();
                //txt_dat_meia.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_MEIA"].ToString()).ToString("dd/MM/yyyy");
                //txt_hr_meia.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_MEIA"].ToString()).ToString("hh:mm tt",CultureInfo.InvariantCulture);
                //txt_res_meia.Text = dsDefeito.Tables[0].Rows[0]["AFN_RES_MEIA"].ToString();
                //txt_dat_tin.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_TIN"].ToString()).ToString("dd/MM/yyyy");
                //txt_hr_tin.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_TIN"].ToString()).ToString("hh:mm tt",CultureInfo.InvariantCulture);
                //cbo_ana_usr_id_tin.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_ANA_TIN_ID"].ToString();
                //txt_dat_lei.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_LEI"].ToString()).ToString("dd/MM/yyyy");
                //txt_hr_lei.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_LEI"].ToString()).ToString("hh:mm tt",CultureInfo.InvariantCulture);
                cbo_ana_lei_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_ANA_LEI_ID"].ToString();
                //txt_dat_lib.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_LIB"].ToString()).ToString("dd/MM/yyyy");
                //txt_hr_lib.Text = Convert.ToDateTime(dsDefeito.Tables[0].Rows[0]["AFN_DAT_LIB"].ToString()).ToString("hh:mm tt",CultureInfo.InvariantCulture);
                cbo_ana_lib_id_inc.SelectedValue = dsDefeito.Tables[0].Rows[0]["AFN_ANA_LIB_ID"].ToString();
                if (!string.IsNullOrEmpty(dsDefeito.Tables[0].Rows[0]["AFN_GLA"].ToString()))
                {
                    if (Convert.ToInt32(dsDefeito.Tables[0].Rows[0]["AFN_GLA"].ToString()) == 54)
                    {
                        Chk_54.Checked = true;
                    }
                    if (Convert.ToInt32(dsDefeito.Tables[0].Rows[0]["AFN_GLA"].ToString()) == 72)
                    {
                        Chk_72.Checked = true;
                    }
                    if (Convert.ToInt32(dsDefeito.Tables[0].Rows[0]["AFN_GLA"].ToString()) == 108)
                    {
                        Chk_108.Checked = true;
                    }
                }
            }
            dsDefeito.Dispose();
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

                txt_lot_inc.Focus();
            }
            else
            {
                divCadastro.Visible = false;
                dvFiltro.Visible = true;

                txt_dat.Focus();
            }
        }
        //object s = null;
        //EventArgs e = null;
        //ApresentaTipo(s, e);
    }

    private void LimpaTela()
    {
        txt_dat.Text = "";
        txt_dat_fim.Text = "";
        cbo_tip.SelectedIndex = 0;
        cbo_tit_poy_id.SelectedIndex = 0;
        cbo_def_id_inc.SelectedIndex = 0;
        cbo_def_id_inc0.SelectedIndex = 0;
        cbo_def_id_inc1.SelectedIndex = 0;
        cbo_def_id_inc2.SelectedIndex = 0;
        cbo_def_id_inc3.SelectedIndex = 0;
        cbo_def_id_inc4.SelectedIndex = 0;
        cbo_def_id_inc5.SelectedIndex = 0;
        cbo_def_id_inc6.SelectedIndex = 0;
        cbo_def_id_inc7.SelectedIndex = 0;
        cbo_def_id_inc8.SelectedIndex = 0;
        cbo_def_id_inc9.SelectedIndex = 0;
        cbo_def_id_inc10.SelectedIndex = 0;
        cbo_def_id_inc11.SelectedIndex = 0;
        cbo_def_id_inc12.SelectedIndex = 0;
        cbo_def_id_inc13.SelectedIndex = 0;
        cbo_def_id_inc14.SelectedIndex = 0;
        cbo_def_id_inc15.SelectedIndex = 0;
        cbo_def_id_inc16.SelectedIndex = 0;
        cbo_def_id_inc17.SelectedIndex = 0;
        cbo_def_id_inc18.SelectedIndex = 0;
        cbo_def_id_inc19.SelectedIndex = 0;
        cbo_def_id_inc20.SelectedIndex = 0;
        cbo_def_id_inc21.SelectedIndex = 0;
        cbo_def_id_inc22.SelectedIndex = 0;
        cbo_def_id_inc23.SelectedIndex = 0;
        cbo_def_id_inc24.SelectedIndex = 0;
        cbo_def_id_inc25.SelectedIndex = 0;
        cbo_def_id_inc26.SelectedIndex = 0;
        cbo_def_id_inc27.SelectedIndex = 0;
        cbo_def_id_inc28.SelectedIndex = 0;
        cbo_def_id_inc29.SelectedIndex = 0;
        cbo_def_id_inc30.SelectedIndex = 0;
        cbo_def_id_inc31.SelectedIndex = 0;
        cbo_def_id_inc32.SelectedIndex = 0;
        cbo_def_id_inc33.SelectedIndex = 0;
        cbo_def_id_inc34.SelectedIndex = 0;
        cbo_def_id_inc35.SelectedIndex = 0;
        cbo_def_id_inc36.SelectedIndex = 0;
        cbo_def_id_inc37.SelectedIndex = 0;
        cbo_def_id_inc38.SelectedIndex = 0;
        cbo_def_id_inc39.SelectedIndex = 0;
        cbo_def_id_inc40.SelectedIndex = 0;
        cbo_def_id_inc41.SelectedIndex = 0;
        cbo_def_id_inc42.SelectedIndex = 0;
        cbo_def_id_inc43.SelectedIndex = 0;
        cbo_def_id_inc44.SelectedIndex = 0;
        cbo_def_id_inc45.SelectedIndex = 0;
        cbo_def_id_inc46.SelectedIndex = 0;
        cbo_def_id_inc47.SelectedIndex = 0;
        cbo_def_id_inc48.SelectedIndex = 0;
        cbo_def_id_inc49.SelectedIndex = 0;
        cbo_def_id_inc50.SelectedIndex = 0;
        cbo_def_id_inc51.SelectedIndex = 0;
        cbo_def_id_inc52.SelectedIndex = 0;
        cbo_def_id_inc53.SelectedIndex = 0;
        cbo_def_id_inc54.SelectedIndex = 0;
        txt_lot.Text = "";
        //txt_mge_001.Text = "";
        //txt_mge_002.Text = "";
        //txt_mge_003.Text = "";
        //txt_mge_004.Text = "";
        //cbo_for_001_id.SelectedIndex = 0;
        //cbo_for_002_id.SelectedIndex = 0;
        //cbo_for_003_id.SelectedIndex = 0;
        //cbo_for_004_id.SelectedIndex = 0;
        //txt_vlc.Text = "";
        //cbo_aps_id.SelectedIndex = 0;
        //cbo_maq_id.SelectedIndex = 0;
        //cbo_maq_tip_id.SelectedIndex = 0;
        //cbo_ert_id.SelectedIndex = 0;
        txt_vrd.Text = "";
        //txt_bbn.Text = "";
        //cbo_ana_usr_id.SelectedIndex = 0;
        cbo_sts.SelectedIndex = 0;
        //txt_dat_inc.Text = "";
        //txt_sem_inc.Text = "";
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        txt_lot_inc.Text = "";
        txt_mge_001_inc.Text = "";
        txt_mge_002_inc.Text = "";
        txt_mge_003_inc.Text = "";
        txt_mge_004_inc.Text = "";
        cbo_for_001_id_inc.SelectedIndex = 0;
        cbo_for_002_id_inc.SelectedIndex = 0;
        cbo_for_003_id_inc.SelectedIndex = 0;
        cbo_for_004_id_inc.SelectedIndex = 0;
        //txt_vlc_inc.Text = "";
        cbo_aps_id_inc.SelectedIndex = 0;
        cbo_maq_id_inc.SelectedIndex = 0;
        cbo_maq_tip_id_inc.SelectedIndex = 0;
        cbo_ert_id_inc.SelectedIndex = 0;
        txt_vrd_inc.Text = "";
        txt_bbn_inc.Text = "";
        //cbo_ana_usr_id_inc.SelectedIndex = 0;
        //Comentado por TI Unifi
        /*txt_clo_inc.Text = "";
        txt_esu_inc.Text = "";
        txt_tmt_inc.Text = "";
        txt_pmt_inc.Text = "";
        txt_ppf_inc.Text = "";
        txt_bbb_inc.Text = "";
        txt_pfe_inc.Text = "";
        txt_pse_inc.Text = "";
        txt_lnc_inc.Text = "";
        txt_esl_inc.Text = "";
        txt_tot_inc.Text = "";*/
        txt_lne_inc.Text = "";
        cbo_sts_inc.SelectedIndex = 0;
        //txt_pos.Text = "0";
        //txt_dat_meia.Text = "";
        //txt_res_meia.Text = "";
        //txt_dat_tin.Text = "";
        //cbo_ana_usr_id_tin.SelectedIndex = 0;
        //txt_dat_lei.Text = "";
        //cbo_ana_usr_id_lei.SelectedIndex = 0;
        //txt_dat_lib.Text = "";
        //cbo_ana_usr_id_lib.SelectedIndex = 0;
        cbo_ana_lei_id.SelectedIndex = 0;
        cbo_ana_lib_id.SelectedIndex = 0;
        txt_pos.Text = "";
        txt_pos0.Text = "";
        txt_pos1.Text = "";
        txt_pos2.Text = "";
        txt_pos3.Text = "";
        txt_pos4.Text = "";
        txt_pos5.Text = "";
        txt_pos6.Text = "";
        txt_pos7.Text = "";
        txt_pos8.Text = "";
        txt_pos9.Text = "";
        txt_pos10.Text = "";
        txt_pos11.Text = "";
        txt_pos12.Text = "";
        txt_pos13.Text = "";
        txt_pos14.Text = ""; 
        txt_pos15.Text = "";
        txt_pos16.Text = "";
        txt_pos17.Text = "";
        txt_pos18.Text = "";
        txt_pos19.Text = "";
        txt_pos20.Text = "";
        txt_pos21.Text = "";
        txt_pos22.Text = "";
        txt_pos23.Text = "";
        txt_pos24.Text = "";
        txt_pos25.Text = "";
        txt_pos26.Text = "";
        txt_pos27.Text = "";
        txt_pos28.Text = "";
        txt_pos29.Text = "";
        txt_pos30.Text = "";
        txt_pos31.Text = "";
        txt_pos32.Text = "";
        txt_pos33.Text = "";
        txt_pos34.Text = "";
        txt_pos35.Text = "";
        txt_pos36.Text = "";
        txt_pos37.Text = "";
        txt_pos38.Text = "";
        txt_pos39.Text = "";
        txt_pos40.Text = "";
        txt_pos41.Text = "";
        txt_pos42.Text = "";
        txt_pos43.Text = "";
        txt_pos44.Text = "";
        txt_pos45.Text = "";
        txt_pos46.Text = "";
        txt_pos47.Text = "";
        txt_pos48.Text = "";
        txt_pos49.Text = "";
        txt_pos50.Text = "";
        txt_pos51.Text = "";
        txt_pos52.Text = "";
        txt_pos53.Text = "";
        txt_pos54.Text = "";
        Chk_Luz_Negra.Checked = false;
        Chk_54.Checked = false;
        Chk_72.Checked = false;
        Chk_108.Checked = false;
        txt_obs_inc.Text = "";
        txt_afn_id.Text = "";
    }

    protected void btNovo_Click(object sender, EventArgs e)
    {
        dvResultado.Visible = false;
        lbAcao.Text = "Novo";
        rowId.Value = null;
        string mhora = DateTime.Now.ToString("hh:mm");
        string sData = DateTime.Now.ToString("dd/MM/yyyy");
        
        //int iAnalista = cbo_ana_usr_id_inc.SelectedIndex;
        LimpaTela();
        //btNovoDef.Visible = false;
        //Mantem Data e Analista anteriormente informados
        //if (string.IsNullOrEmpty(sData))
        //{
        //    txt_dat_inc.Text = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy");
        //}
        //else
        //{
        //    txt_dat_inc.Text = sData;
        //}
        //CalculaSemana(sender, e);
        //cbo_ana_usr_id_inc.SelectedIndex = iAnalista;
        //Comentado por TI Unifi
        /*txt_clo_inc.Text = "0,00";
        txt_esu_inc.Text = "0,00";
        txt_tmt_inc.Text = "0,00";
        txt_pmt_inc.Text = "0,00";
        txt_ppf_inc.Text = "0,0000";
        txt_bbb_inc.Text = "0,0000";
        txt_pfe_inc.Text = "0,00";
        txt_pse_inc.Text = "0,00"
        txt_lne_inc.Text = "0,00";
        txt_lnc_inc.Text = "0,00";
        txt_esl_inc.Text = "0,00";*/

        divCadastro.Visible = true;
        dvFiltro.Visible = false;
        //txt_dat_meia.Text = txt_dat_inc.Text;
        //txt_hr_meia.Text = mhora;
        //txt_dat_tin.Text = txt_dat_inc.Text;
        //txt_hr_tin.Text = mhora;
        //txt_dat_lei.Text = txt_dat_inc.Text;
        //txt_hr_lei.Text = mhora;
        //txt_dat_lib.Text = txt_dat_inc.Text;
        //txt_hr_lib.Text = mhora;
        txt_lot_inc.Focus();
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
        divCadastro.Visible = false;

        txt_dat.Focus();
    }

    protected string CriaFiltro(Afinidade Afinidade)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat.Text))
        {
            Afinidade.AFN_DAT = Convert.ToDateTime(txt_dat.Text);
            filtro = filtro + "Data= " + txt_dat.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Afinidade.AFN_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Datafim= " + txt_dat_fim.Text + "; ";
        }

        if (!String.IsNullOrEmpty(cbo_tip.Text))
        {
            Afinidade.AFN_TIP = Convert.ToInt32(cbo_tip.SelectedValue);
            filtro = filtro + "Tipo= " + cbo_tip.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Afinidade.AFN_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Titulo= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Afinidade.AFN_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        //if (!String.IsNullOrEmpty(txt_mge_001.Text))
        //{
        //    Afinidade.AFN_MGE_001 = txt_mge_001.Text;
        //    filtro = filtro + "Merge 1= " + txt_mge_001.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(txt_mge_002.Text))
        //{
        //    Afinidade.AFN_MGE_002 = txt_mge_002.Text;
        //    filtro = filtro + "Merge 2= " + txt_mge_002.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(txt_mge_003.Text))
        //{
        //    Afinidade.AFN_MGE_003 = txt_mge_003.Text;
        //    filtro = filtro + "Merge 3= " + txt_mge_003.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(txt_mge_004.Text))
        //{
        //    Afinidade.AFN_MGE_004 = txt_mge_004.Text;
        //    filtro = filtro + "Merge 4= " + txt_mge_004.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(cbo_for_001_id.Text))
        //{
        //    Afinidade.AFN_FOR_001_ID = Convert.ToInt32(cbo_for_001_id.SelectedValue);
        //    filtro = filtro + "Fornecedor 1= " + cbo_for_001_id.SelectedItem.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(cbo_for_002_id.Text))
        //{
        //    Afinidade.AFN_FOR_002_ID = Convert.ToInt32(cbo_for_002_id.SelectedValue);
        //    filtro = filtro + "Fornecedor 2= " + cbo_for_002_id.SelectedItem.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(cbo_for_003_id.Text))
        //{
        //    Afinidade.AFN_FOR_003_ID = Convert.ToInt32(cbo_for_003_id.SelectedValue);
        //    filtro = filtro + "Fornecedor 3= " + cbo_for_003_id.SelectedItem.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(cbo_for_004_id.Text))
        //{
        //    Afinidade.AFN_FOR_004_ID = Convert.ToInt32(cbo_for_004_id.SelectedValue);
        //    filtro = filtro + "Fornecedor 4= " + cbo_for_004_id.SelectedItem.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(txt_vlc.Text))
        //{
        //    Afinidade.AFN_VLC = Convert.ToInt32(txt_vlc.Text);
        //    filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";
        //}
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Afinidade.AFN_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_id.Text))
        {
            Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
        }
        //if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        //{
        //    Afinidade.AFN_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
        //    filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        //}
        if (!String.IsNullOrEmpty(cbo_ert_id.Text))
        {
            Afinidade.AFN_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vrd.Text))
        {
            Afinidade.AFN_VRD = Convert.ToInt32(txt_vrd.Text);
            filtro = filtro + "Virada= " + txt_vrd.Text + "; ";
        }
        //if (!String.IsNullOrEmpty(txt_bbn.Text))
        //{
        //    Afinidade.AFN_BBN = Convert.ToInt32(txt_bbn.Text);
        //    filtro = filtro + "Bobina= " + txt_bbn.Text + "; ";
        //}
        //if (!String.IsNullOrEmpty(cbo_ana_usr_id.Text))
        //{
        //    Afinidade.AFN_ANA_USR_ID = Convert.ToInt32(cbo_ana_usr_id.SelectedValue);
        //    filtro = filtro + "Analista Usuario= " + cbo_ana_usr_id.SelectedItem.Text + "; ";
        //}
        if (!String.IsNullOrEmpty(cbo_def_id.Text))
        {
            Afinidade.AFN_DEF = cbo_def_id.Text;
        }

        if (!String.IsNullOrEmpty(cbo_ana_lei_id.Text))
        {
            Afinidade.AFN_ANA_LEI_ID = Convert.ToInt32(cbo_ana_lei_id.SelectedValue);
            filtro = filtro + "Resp. Leitura= " + cbo_ana_lei_id.SelectedItem.Text + "; ";
        }

        if (!String.IsNullOrEmpty(cbo_ana_lib_id.Text))
        {
            Afinidade.AFN_ANA_LIB_ID = Convert.ToInt32(cbo_ana_lib_id.SelectedValue);
            filtro = filtro + "Resp. Liberação= " + cbo_ana_lib_id.SelectedItem.Text + "; ";
        }

        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Afinidade.AFN_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }

        return filtro;
    }



    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";
        DateTime mydate = new DateTime(2013,11,01);

        Afinidade Afinidade = new Afinidade();
        filtro = CriaFiltro(Afinidade);
        string[] afiltro = filtro.Split(';');
        if ((filtro == "") || ((txt_lot.Text == "") && ((afiltro.Length - 1) < 2)))
        {
            TratamentoErro("O Filtro deve possuir o Lote ou outros dois argumentos.");
            txt_dat.Focus();
            return;
        }
        //if (cbo_tip.Text == "0")
        //{
        //    Afinidade.AFN_TIP = null;
        //}
        //if (!String.IsNullOrEmpty(cbo_def_id.Text))
        //{
        //    Afinidade.AFN_DEF = cbo_def_id.Text;
        //}
        if (Afinidade.AFN_DAT >= mydate || Afinidade.AFN_DAT == null)
        {
            DataSet dsAfinidade = Afinidade.Consultar3();
            gvAfinidade.DataSource = dsAfinidade;
            gvAfinidade.DataBind();
            dsAfinidade.Dispose();
            Dispose();
        }
        else
        {
            DataSet dsAfinidade = Afinidade.Consultar();
            gvAfinidade.DataSource = dsAfinidade;
            gvAfinidade.DataBind();
            dsAfinidade.Dispose();
            Dispose();

        }

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

    protected void gvAfinidade_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvAfinidade.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvAfinidade.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Afinidade.aspx?rowId=" + gvAfinidade.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvAfinidade.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvAfinidade.Columns.IndexOf(field);
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

    protected void gvAfinidade_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvAfinidade_Sorting(Object sender, GridViewSortEventArgs e)
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

        Afinidade Afinidade = new Afinidade();
        filtro = CriaFiltro(Afinidade);
        DataSet dsAfinidade = Afinidade.Consultar3();

        DataTable dtAfinidade = dsAfinidade.Tables[0];
        DataView dvAfinidade = new DataView(dtAfinidade);
        dvAfinidade.Sort = e.SortExpression + Ordem;
        gvAfinidade.DataSource = dvAfinidade;
        gvAfinidade.DataBind();

        dvAfinidade.Dispose();
        dtAfinidade.Dispose();
        dsAfinidade.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        //    string sMsg;
        //    if (txt_dat_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Data é obrigatório.");
        //        txt_lot_inc.Focus();
        //        return;
        //    }
        if (txt_afn_id.Text != "")
        {
            Afinidade AfinidadeExcluir = new Afinidade();
            AfinidadeExcluir.AFN_ID = Convert.ToInt32(txt_afn_id.Text);
            AfinidadeExcluir.Excluir();
            Defeito Def_Afn_Excluir = new Defeito();
            Def_Afn_Excluir.DEF_AFN_ID = Convert.ToInt32(txt_afn_id.Text);
            Def_Afn_Excluir.Excluir();
        }
        
        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote é obrigatório.");
            txt_lot_inc.Focus();
            return;
        }

        //    if (cbo_tit_poy_id_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Título é obrigatório.");
        //        cbo_tit_poy_id_inc.Focus();
        //        return;
        //    }

        //    if (cbo_for_001_id_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Fornecedor 1 é obrigatório.");
        //        cbo_for_001_id_inc.Focus();
        //        return;
        //    }

        //    if (cbo_aps_id_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Apresentação é obrigatório.");
        //        cbo_aps_id_inc.Focus();
        //        return;
        //    }

        //if (cbo_maq_id_inc.Text == "")
        //{
        //    TratamentoErro("O campo Máquina é obrigatório.");
        //    cbo_maq_id_inc.Focus();
        //    return;
        //}

        //    if (cbo_maq_tip_id_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Tipo Máquina é obrigatório.");
        //        cbo_maq_tip_id_inc.Focus();
        //        return;
        //    }

        //    if (txt_vrd_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Virada é obrigatório.");
        //        txt_vrd_inc.Focus();
        //        return;
        //    }

        if (txt_bbn_inc.Text == "")
        {
            TratamentoErro("O campo Bobina é obrigatório.");
            txt_bbn_inc.Focus();
            return;
        }
        if (Convert.ToInt16(txt_bbn_inc.Text) > 240)
        {
            TratamentoErro("O campo Qtd.Bobina deve ser menor que 240.");
            txt_bbn_inc.Focus();
            return;
        }
        if (Convert.ToInt16(txt_bbn_inc.Text) < 1)
        {
            TratamentoErro("O campo Qtd.Bobina deve ser maior que 1.");
            txt_bbn_inc.Focus();
            return;
        }
        //    //if (cbo_ana_usr_id_inc.Text == "")
        //    //{
        //    //    TratamentoErro("O campo Analista é obrigatório.");
        //    //    cbo_ana_usr_id_inc.Focus();
        //    //    return;
        //    //}
        //    //Comentado por TI Unifi
        //    /*if (txt_clo_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Claro é obrigatório.");
        //        txt_clo_inc.Focus();
        //        return;
        //    }

        //    if (txt_esu_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Escuro é obrigatório.");
        //        txt_esu_inc.Focus();
        //        return;
        //    }

        //    if (txt_tmt_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % TMT é obrigatório.");
        //        txt_tmt_inc.Focus();
        //        return;
        //    }

        //    if (txt_pmt_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % MT é obrigatório.");
        //        txt_pmt_inc.Focus();
        //        return;
        //    }

        //    if (txt_ppf_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % PF é obrigatório.");
        //        txt_ppf_inc.Focus();
        //        return;
        //    }

        //    if (txt_bbb_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % B é obrigatório.");
        //        txt_bbb_inc.Focus();
        //        return;
        //    }

        //    if (txt_pfe_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % FE é obrigatório.");
        //        txt_pfe_inc.Focus();
        //        return;
        //    }

        //    if (txt_pse_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % SE é obrigatório.");
        //        txt_pse_inc.Focus();
        //        return;
        //    }

        //    if (txt_lne_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % LNE é obrigatório.");
        //        txt_lne_inc.Focus();
        //        return;
        //    }

        //    if (txt_lnc_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % LNC é obrigatório.");
        //        txt_lnc_inc.Focus();
        //        return;
        //    }

        //    if (txt_esl_inc.Text == "")
        //    {
        //        TratamentoErro("O campo % Escolha é obrigatório.");
        //        txt_esl_inc.Focus();
        //        return;
        //    }*/


        //    //if (txt_res_meia.Text == "")
        //    //{
        //    //    TratamentoErro("O campo Analista da meia é obrigatório.");
        //    //    txt_res_meia.Focus();
        //    //    return;
        //    //}
        //    //if (txt_res_tin.Text == "")
        //    //{
        //    //    TratamentoErro("O campo Analista do tingimento é obrigatório.");
        //    //    txt_res_tin.Focus();
        //    //    return;
        //    //}
        if (cbo_ana_lei_id_inc.Text == "")
        {
            TratamentoErro("O campo Analista da leitura é obrigatório.");
            cbo_ana_lei_id_inc.Focus();
            return;
        }
        if (cbo_ana_lib_id_inc.Text == "")
        {
            TratamentoErro("O campo Analista da liberação é obrigatório.");
            cbo_ana_lib_id_inc.Focus();
            return;
        }

        //    if (cbo_sts_inc.Text == "")
        //    {
        //        TratamentoErro("O campo Status é obrigatório.");
        //        cbo_sts_inc.Focus();
        //        return;
        //    }
        Afinidade Afinidade = new Afinidade();
        if (txt_dat_inc.Text != "")
        {
            Afinidade.AFN_DAT = Convert.ToDateTime(txt_dat_inc.Text);
        }
        if (txt_sem_inc.Text != "")
        {
            Afinidade.AFN_SEM = txt_sem_inc.Text;
        }
        Afinidade.AFN_LOT = txt_lot_inc.Text.Trim();
        if (txt_obs_inc.Text != "")
        {
            Afinidade.AFN_OBS = txt_obs_inc.Text;
        }
        //    //Comenado por TI Unifi
        //    /*if (cbo_tip_inc.Text != "")
        //    {
        //        Afinidade.AFN_TIP = Convert.ToInt32(cbo_tip_inc.SelectedValue);
        //    }*/

        if (Chk_Luz_Negra.Checked)
        {
            //Afinidade.AFN_TIP = "LUZ NEGRA";
            Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
        }
        Afinidade.AFN_TIP = 1;
        if (Chk_54.Checked)
        {
            Afinidade.AFN_GLA = 54;
        }
        if (Chk_72.Checked)
        {
            Afinidade.AFN_GLA = 72;
        }
        if (Chk_108.Checked)
        {
            Afinidade.AFN_GLA = 108;
        }
        if (cbo_tit_poy_id_inc.Text != "")
        {
            Afinidade.AFN_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
        }
        Afinidade.AFN_MGE_001 = txt_mge_001_inc.Text;
        Afinidade.AFN_MGE_002 = txt_mge_002_inc.Text;
        Afinidade.AFN_MGE_003 = txt_mge_003_inc.Text;
        Afinidade.AFN_MGE_004 = txt_mge_004_inc.Text;
        if (cbo_for_001_id_inc.Text != "")
        {
            Afinidade.AFN_FOR_001_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
        }
        if (cbo_for_002_id_inc.Text != "")
        {
            Afinidade.AFN_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
        }
        if (cbo_for_003_id_inc.Text != "")
        {
            Afinidade.AFN_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
        }
        if (cbo_for_004_id_inc.Text != "")
        {
            Afinidade.AFN_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
        }
        //if (txt_vlc_inc.Text != "")
        //{
        //    Afinidade.AFN_VLC = Convert.ToInt32(txt_vlc_inc.Text);
        //}
        if (cbo_aps_id_inc.Text != "")
        {
            Afinidade.AFN_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
        }
        if (cbo_maq_id_inc.Text != "")
        {
            Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
        }
        if (cbo_maq_tip_id_inc.Text != "")
        {
            Afinidade.AFN_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
        }
        if (cbo_ert_id_inc.Text != "")
        {
            Afinidade.AFN_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
        }
        if (txt_vrd_inc.Text != "")
        {
            Afinidade.AFN_VRD = Convert.ToInt32(txt_vrd_inc.Text);
        }
        if (txt_bbn_inc.Text != "")
        {
            Afinidade.AFN_BBN = Convert.ToInt32(txt_bbn_inc.Text);
        }


        //    //Comentado por TI Unifi
        //    /*Afinidade.AFN_CLO = Convert.ToDouble(txt_clo_inc.Text);
        //    Afinidade.AFN_ESU = Convert.ToDouble(txt_esu_inc.Text);
        //    Afinidade.AFN_TMT = Convert.ToDouble(txt_tmt_inc.Text);
        //    Afinidade.AFN_PMT = Convert.ToDouble(txt_pmt_inc.Text);
        //    Afinidade.AFN_PPF = Convert.ToDouble(txt_ppf_inc.Text);
        //    Afinidade.AFN_BBB = Convert.ToDouble(txt_bbb_inc.Text);
        //    Afinidade.AFN_PFE = Convert.ToDouble(txt_pfe_inc.Text);
        //    Afinidade.AFN_PSE = Convert.ToDouble(txt_pse_inc.Text);
        //    Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
        //    Afinidade.AFN_LNC = Convert.ToDouble(txt_lnc_inc.Text);
        //    Afinidade.AFN_ESL = Convert.ToDouble(txt_esl_inc.Text);*/
        //    //Afinidade.AFN_TOT = Afinidade.AFN_CLO + Afinidade.AFN_ESU + Afinidade.AFN_TMT + Afinidade.AFN_PMT + Afinidade.AFN_PPF + Afinidade.AFN_BBB + Afinidade.AFN_PFE + Afinidade.AFN_PSE + Afinidade.AFN_LNE + Afinidade.AFN_LNC + Afinidade.AFN_ESL;
        //    // Novas linhas Unifi - 03/07/13

        //    if (txt_dat_meia.Text != "")
        //    {
        //        Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text);
        //    }
        //    if (txt_hr_meia.Text != "")
        //    {
        //        Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text + " " + txt_hr_meia.Text);
        //    }
        //    if (txt_res_meia.Text != "")
        //    {
        //        Afinidade.AFN_RES_MEIA = txt_res_meia.Text;
        //    }
        //    if (txt_dat_tin.Text != "")
        //    {
        //        Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text);
        //    }
        //    if (txt_hr_tin.Text != "")
        //    {
        //        Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text + " " + txt_hr_tin.Text);
        //    }
        //if (cbo_ana_usr_id_tin.Text != "")
        //{
        //    Afinidade.AFN_ANA_TIN_ID = Convert.ToInt32(cbo_ana_usr_id_tin.SelectedValue);
        //}
        //    if (txt_dat_lei.Text != "")
        //    {
        //        Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text);
        //    }
        //    if (txt_hr_lei.Text != "")
        //    {
        //        Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text + " " + txt_hr_lei.Text);
        //    }
        if (cbo_ana_lei_id_inc.Text != "")
        {
            Afinidade.AFN_ANA_LEI_ID = Convert.ToInt32(cbo_ana_lei_id_inc.SelectedValue);
        }
        //    if (txt_dat_lib.Text != "")
        //    {
        //        Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text);
        //    }
        //    if (txt_hr_lib.Text != "")
        //    {
        //        Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text + " " + txt_hr_lib.Text);
        //    }
        if (cbo_ana_lib_id_inc.Text != "")
        {
            Afinidade.AFN_ANA_LIB_ID = Convert.ToInt32(cbo_ana_lib_id_inc.SelectedValue);
        }

        //    // Fim novas linhas
        if (cbo_sts_inc.Text != "")
        {
            Afinidade.AFN_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }
        string sMsg = "";
        string AFNExclui = "";
        //    if (!string.IsNullOrEmpty(rowId.Value))
        //    {
        //        Defeito Def_Afn = new Defeito();
        //        Def_Afn.DEF_ID = Convert.ToInt32(rowId.Value);
        //        Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
        //        Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
        //        Def_Afn.DEF_AFN_ID = Convert.ToInt32(txt_pos0.Text);
        //        sMsg = Def_Afn.Alterar();
        //        if (sMsg != "")
        //        {
        //            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
        //        }
        //        else
        //        {
        //            Afinidade.AFN_ID = Convert.ToInt32(Def_Afn.DEF_AFN_ID);
        //            Afinidade.AFN_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        //            sMsg = Afinidade.Alterar();
        //            if (sMsg != "")
        //            {
        //                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
        //            }
        //            else
        //            {
        //                TratamentoErro("Afinidade alterado com sucesso.");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Afinidade AFN = new Afinidade();
        //        //Verificar se já não existe um cadastro consultando o: AFN_DES 
        //        /*
        //        AFN.AFN_DES = txt_des_inc.Text;
        //        DataSet dsAFN = AFN.Consultar();
        //        if (dsAFN.Tables[0].Rows.Count > 0)
        //        {
        //            TratamentoErro("Esse Afinidade já está cadastrado.");
        //            txt_lot_inc.Focus();

        //            return;
        //        }
        //        */
        Afinidade.AFN_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        sMsg = Afinidade.Inserir();
        string afnid = sMsg;
        if (sMsg.Substring(0, 1) == "E")
        {
            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
        }
        else
        {
            if (txt_pos.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
                if (txt_pos.Text == "0")
                {
                    TratamentoErro("Afinidade inserido com sucesso.");
                    //EnviaEmail();
                    btNovo_Click(sender, e);
                    return;
                }
            }
            if (txt_pos0.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos0.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc0.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos1.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos1.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc1.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos2.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos2.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc2.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos3.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos3.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc3.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos4.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos4.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc4.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos5.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos5.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc5.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos6.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos6.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc6.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos7.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos7.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc7.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos8.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos8.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc8.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos9.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos9.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc9.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos10.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos10.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc10.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos11.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos11.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc11.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos12.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos12.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc12.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos13.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos13.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc13.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos14.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos14.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc14.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos15.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos15.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc15.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos16.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos16.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc16.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos17.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos17.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc17.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos18.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos18.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc18.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos19.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos19.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc19.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos20.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos20.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc20.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos21.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos21.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc21.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos22.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos22.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc22.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos23.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos23.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc23.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos24.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos24.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc24.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos25.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos25.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc25.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos26.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos26.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc26.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos27.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos27.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc27.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos28.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos28.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc28.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos29.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos29.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc29.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos30.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos30.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc30.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos31.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos31.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc31.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos32.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos32.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc32.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos33.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos33.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc33.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos34.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos34.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc34.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos35.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos35.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc35.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos36.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos36.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc36.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos37.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos37.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc37.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos38.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos38.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc38.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos39.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos39.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc39.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos40.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos40.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc40.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos41.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos41.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc41.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos42.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos42.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc42.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos43.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos43.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc43.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos44.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos44.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc44.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos45.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos45.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc45.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos46.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos46.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc46.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos47.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos47.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc47.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos48.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos48.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc48.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos49.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos49.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc49.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos50.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos50.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc50.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos51.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos51.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc51.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos52.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos52.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc52.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos53.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos53.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc53.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }
            if (txt_pos54.Text != "")
            {
                Defeito Def_Afn = new Defeito();
                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos54.Text);
                Def_Afn.DEF_DES = cbo_def_id_inc54.SelectedValue;
                Def_Afn.DEF_AFN_ID = Convert.ToInt32(afnid);
                sMsg = Def_Afn.Inserir();
                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                }
            }

            Dispose();
        }
        TratamentoErro("Afinidade inserido com sucesso.");
        if (txt_afn_id.Text != "")
        {
            Defeito Def_Afn = new Defeito();
            Def_Afn.DEF_AFN_ID = Convert.ToInt32(txt_afn_id.Text);
            Def_Afn.Excluir();
            Afinidade.AFN_ID = Convert.ToInt32(txt_afn_id.Text);
            AFNExclui = Afinidade.Excluir();
        }

        //    //Prepara para nova inclusão
        if (txt_pos.Text != "")
        {
            //EnviaEmail();
        }

        btNovo_Click(sender, e);
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvAfinidade.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvAfinidade.AllowSorting = false;
            gvAfinidade.AllowPaging = false;
            //gvAfinidade.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvAfinidade.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvAfinidade.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvAfinidade.RenderControl(htmlWrite);

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
        if (gvAfinidade.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvAfinidade.AllowSorting = false;
            gvAfinidade.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvAfinidade.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvAfinidade.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvAfinidade.RenderControl(htmlWrite);
            Response.Write(stringWrite.ToString());
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }


    protected void CalculaSemana(object sender, EventArgs e)
    {
        txt_sem_inc.Text = "";

        if (!string.IsNullOrEmpty(txt_dat_inc.Text))
        {
            DateTime dDataI = Convert.ToDateTime("01/01/" + txt_dat_inc.Text.Substring(txt_dat_inc.Text.Length - 4));
            DateTime dDataF = Convert.ToDateTime(txt_dat_inc.Text);
            int iSegundas = 0;
            for (DateTime dData = dDataI; dData <= dDataF; dData = dData.AddDays(1))
            {
                if (dData.DayOfWeek == DayOfWeek.Monday)
                {
                    iSegundas++;
                }
            }

            //MAP02012012
            //Caso não haja segundas feiras no começo do Ano, no caso de clicar em Novo em 02/01/2012 volta 00_12 em vez de 01_12
            if (iSegundas == 0)
            {
                iSegundas = 1;
            }

            txt_sem_inc.Text = iSegundas.ToString().PadLeft(2, '0') + "_" + txt_dat_inc.Text.Substring(txt_dat_inc.Text.Length - 2);
        }
        //txt_dat_meia.Text = txt_dat_inc.Text;
        //txt_dat_tin.Text = txt_dat_inc.Text;
        //txt_dat_lei.Text = txt_dat_inc.Text;
        //txt_dat_lib.Text = txt_dat_inc.Text;
        txt_lot_inc.Focus();
    }

    protected void CarregaMaquinaTipo(object sender, EventArgs e)
    {
        Maquina Maquina = new Maquina();
        Maquina.MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
        DataSet dsMaquina = Maquina.Consultar();

        if (dsMaquina.Tables[0].Rows.Count > 0)
        {
            cbo_maq_tip_id_inc.SelectedValue = dsMaquina.Tables[0].Rows[0]["MAQ_MAQ_TIP_ID"].ToString();
        }

        dsMaquina.Dispose();
        Dispose();

        //cbo_ert_id_inc.Focus();
        txt_vrd_inc.Focus();
    }

    protected void CarregaLote(object sender, EventArgs e)
    {
        //Afinidade Afinidade = new Afinidade();
        Especificacao Especificacao = new Especificacao();
        Especificacao.ANE_LOT = txt_lot_inc.Text;
        DataSet dsEspecificacao = Especificacao.Consultar();

        //if (!string.IsNullOrEmpty(txt_lot.Text))
        //{
        //    //Afinidade.AFN_LOT = txt_lot.Text;
        //    //Afinidade.ANE_LOT = txt_lot.Text;
        //    //DataSet dsAfinidade = Afinidade.ConsultarLote();
        //    //if (dsAfinidade.Tables[0].Rows.Count > 0)
        //    if (dsEspecificacao.Tables[0].Rows.Count > 0)
        //    {

        //        //txt_lot.Text = dsAfinidade.Tables[0].Rows[0]["AFN_LOT"].ToString();
        //        //cbo_tit_poy_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIT_POY_ID"].ToString();
        //        //cbo_tip.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIP"].ToString();
        //        //txt_mge_001.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_001"].ToString();
        //        //txt_mge_002.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_002"].ToString();
        //        //txt_mge_003.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_003"].ToString();
        //        //txt_mge_004.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_004"].ToString();
        //        //cbo_for_001_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_001_ID"].ToString();
        //        //cbo_for_002_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_002_ID"].ToString();
        //        //cbo_for_003_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_003_ID"].ToString();
        //        //cbo_for_004_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_004_ID"].ToString();
        //        //txt_vlc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_VLC"].ToString();
        //        cbo_aps_id.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_APS_ID"].ToString();//AFN_APS_ID
        //        //cbo_aps_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["ANE_APS_ID"].ToString();//AFN_APS_ID
        //        cbo_ert_id.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_ID"].ToString();
        //        //cbo_ert_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["ANE_ERT_ID"].ToString();
        //        //txt_dat.Text = Convert.ToDateTime(dsAfinidade.Tables[0].Rows[0]["AFN_DAT"].ToString()).ToString("dd/MM/yyyy");

        //    }
        //    else
        //    {
        //        //cbo_tit_poy_id.SelectedIndex = 0;
        //        cbo_tip.SelectedIndex = 0;
        //        //txt_mge_001.Text = "";
        //        //txt_mge_002.Text = "";
        //        //txt_mge_003.Text = "";
        //        //txt_mge_004.Text = "";
        //        //cbo_for_001_id.SelectedIndex = 0;
        //        //cbo_for_002_id.SelectedIndex = 0;
        //        //cbo_for_003_id.SelectedIndex = 0;
        //        //cbo_for_004_id.SelectedIndex = 0;
        //        //txt_vlc.Text = "";
        //        cbo_aps_id.SelectedIndex = 0;
        //        cbo_ert_id.SelectedIndex = 0;
        //    }
        //}
        //else if (!string.IsNullOrEmpty(txt_lot_inc.Text))
        if (!string.IsNullOrEmpty(txt_lot_inc.Text))
        {
            //Afinidade.AFN_LOT = txt_lot_inc.Text;
            //DataSet dsAfinidade = Afinidade.ConsultarLote();

            //if (dsAfinidade.Tables[0].Rows.Count > 0)
            if (dsEspecificacao.Tables[0].Rows.Count > 0)
            {
                //cbo_tit_poy_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIT_POY_ID"].ToString();
                cbo_tit_poy_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_POY_ID"].ToString();
                //Comentado por TI Unifi
                //cbo_tip_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIP"].ToString();
                //txt_mge_001_inc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_001"].ToString();
                //txt_mge_002_inc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_002"].ToString();
                //txt_mge_003_inc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_003"].ToString();
                //txt_mge_004_inc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_004"].ToString();
                //cbo_for_001_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_001_ID"].ToString();
                //cbo_for_002_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_002_ID"].ToString();
                //cbo_for_003_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_003_ID"].ToString();
                //cbo_for_004_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_004_ID"].ToString();
                //txt_vlc_inc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_VLC"].ToString();
                //cbo_aps_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_APS_ID"].ToString();
                //cbo_ert_id_inc.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_ERT_ID"].ToString();
                cbo_aps_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_APS_ID"].ToString();
                cbo_ert_id_inc.SelectedValue = dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_ID"].ToString();

                //AFN_APS_ID
            }
            //else
            //{
                //cbo_tit_poy_id_inc.SelectedIndex = 0;
                //Comentado por TI Unifi
                //cbo_tip_inc.SelectedIndex = 0;
                //txt_mge_001_inc.Text = "";
                //txt_mge_002_inc.Text = "";
                //txt_mge_003_inc.Text = "";
                //txt_mge_004_inc.Text = "";
                //cbo_for_001_id_inc.SelectedIndex = 0;
                //cbo_for_002_id_inc.SelectedIndex = 0;
                //cbo_for_003_id_inc.SelectedIndex = 0;
                //cbo_for_004_id_inc.SelectedIndex = 0;
                //txt_vlc_inc.Text = "";
                //cbo_aps_id_inc.SelectedIndex = 0;
                //cbo_ert_id_inc.SelectedIndex = 0;
            //}
        }

        //cbo_tit_poy_id_inc.Focus();

        ////inibido até a base de Standard estar devidamente carregada
        //return;

        //if (!string.IsNullOrEmpty(txt_lot_inc.Text))
        //{
        //    Standard Standard = new Standard();
        //    Standard.EPF_LOT = txt_lot_inc.Text;
        //    DataSet dsStandard = Standard.Consultar();

        //    if (dsStandard.Tables[0].Rows.Count > 0)
        //    {
        //        cbo_tit_poy_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIT_POY_ID"].ToString();
        //        txt_mge_001_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
        //        cbo_for_001_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_ID"].ToString();
        //        txt_vlc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VLC"].ToString();
        //        cbo_aps_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_APS_ID"].ToString();
        //        cbo_maq_tip_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_MAQ_TIP_ID"].ToString();
        //        cbo_ert_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_ERT_ID"].ToString();
        //    }
        //    dsStandard.Dispose();
        //    Dispose();
        //}
        cbo_maq_id_inc.Focus();
    }

    //protected void txt_dat_incChanged(object sender, EventArgs e)
    //{
    //    //txt_dat_meia.Text = Convert.ToDateTime(txt_dat_inc.text.Tostring()).ToString("dd/MM/yyyy");
    //    txt_dat_meia.Text = txt_dat_inc.Text;
    //    txt_dat_tin.Text = Convert.ToDateTime(txt_dat_inc.ToString()).ToString("dd/MM/yyyy");
    //    txt_dat_lei.Text = Convert.ToDateTime(txt_dat_inc.ToString()).ToString("dd/MM/yyyy");
    //    txt_dat_lib.Text = Convert.ToDateTime(txt_dat_inc.ToString()).ToString("dd/MM/yyyy");
    //}

    
    
    
    protected void txt_lot_TextChanged(object sender, EventArgs e)
    {
        /*CarregaLote(sender, e);*/
    }

    /*protected void ApresentaTipo(object sender, EventArgs e)
    {
        if (cbo_tip_inc.SelectedValue == "1")
        {
            //Comentado por TI Unifi
            //pnl_afn.Visible = true;
            pnl_luz_neg.Visible = false;
        }
        else
        {
            //Comentado por TI Unifi
            //pnl_afn.Visible = false;
            pnl_luz_neg.Visible = true;
        }

    }*/








    //protected void btNovoDef_Click(object sender, EventArgs e)
    //{
    //    string sMsg;
    //    rowId.Value = null;
    //    if (txt_dat_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Data é obrigatório.");
    //        txt_lot_inc.Focus();
    //        return;
    //    }

    //    if (txt_lot_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Lote é obrigatório.");
    //        txt_lot_inc.Focus();
    //        return;
    //    }

    //    //if (cbo_tit_poy_id_inc.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Título é obrigatório.");
    //    //    cbo_tit_poy_id_inc.Focus();
    //    //    return;
    //    //}

    //    //if (cbo_for_001_id_inc.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Fornecedor 1 é obrigatório.");
    //    //    cbo_for_001_id_inc.Focus();
    //    //    return;
    //    //}

    //    //if (cbo_aps_id_inc.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Apresentação é obrigatório.");
    //    //    cbo_aps_id_inc.Focus();
    //    //    return;
    //    //}

    //    if (cbo_maq_id_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Máquina é obrigatório.");
    //        cbo_maq_id_inc.Focus();
    //        return;
    //    }

    //    //if (cbo_maq_tip_id_inc.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Tipo Máquina é obrigatório.");
    //    //    cbo_maq_tip_id_inc.Focus();
    //    //    return;
    //    //}

    //    if (txt_vrd_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Virada é obrigatório.");
    //        txt_vrd_inc.Focus();
    //        return;
    //    }

    //    if (txt_bbn_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Bobina é obrigatório.");
    //        txt_bbn_inc.Focus();
    //        return;
    //    }



    //    //if (txt_res_meia.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Analista da meia é obrigatório.");
    //    //    txt_res_meia.Focus();
    //    //    return;
    //    //}
    //    //if (txt_res_tin.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Analista do tingimento é obrigatório.");
    //    //    txt_res_tin.Focus();
    //    //    return;
    //    //}
    //    //if (txt_res_lei.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Analista da leitura é obrigatório.");
    //    //    txt_res_lei.Focus();
    //    //    return;
    //    //}
    //    //if (txt_res_lib.Text == "")
    //    //{
    //    //    TratamentoErro("O campo Analista da liberação é obrigatório.");
    //    //    txt_res_lib.Focus();
    //    //    return;
    //    //}

    //    if (cbo_sts_inc.Text == "")
    //    {
    //        TratamentoErro("O campo Status é obrigatório.");
    //        cbo_sts_inc.Focus();
    //        return;
    //    }

    //    Afinidade Afinidade = new Afinidade();


    //    if (txt_dat_inc.Text != "")
    //    {
    //        Afinidade.AFN_DAT = Convert.ToDateTime(txt_dat_inc.Text);
    //    }
    //    //if (txt_sem_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_SEM = txt_sem_inc.Text;
    //    //}
    //    //Afinidade.AFN_LOT = txt_lot_inc.Text.Trim();

    //    //if (Chk_Luz_Negra.Checked)
    //    //{
    //    //    Afinidade.AFN_TIP = 2;
    //    //    Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
    //    //}
    //    //else
    //    //{
    //    //    Afinidade.AFN_TIP = 1;
    //    //}
    //    //if (cbo_tit_poy_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
    //    //}
    //    //Afinidade.AFN_MGE_001 = txt_mge_001_inc.Text;
    //    //Afinidade.AFN_MGE_002 = txt_mge_002_inc.Text;
    //    //Afinidade.AFN_MGE_003 = txt_mge_003_inc.Text;
    //    //Afinidade.AFN_MGE_004 = txt_mge_004_inc.Text;
    //    //Afinidade.AFN_FOR_001_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
    //    //if (cbo_for_002_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
    //    //}
    //    //if (cbo_for_003_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
    //    //}
    //    //if (cbo_for_004_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
    //    //}
    //    //if (txt_vlc_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_VLC = Convert.ToInt32(txt_vlc_inc.Text);
    //    //}
    //    //if (cbo_aps_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
    //    //}
    //    if (cbo_maq_id_inc.Text != "")
    //    {
    //        Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
    //    }
    //    //if (cbo_maq_tip_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
    //    //}
    //    //if (cbo_ert_id_inc.Text != "")
    //    //{
    //    //    Afinidade.AFN_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
    //    //}
    //    if (txt_vrd_inc.Text != "")
    //    {
    //        Afinidade.AFN_VRD = Convert.ToInt32(txt_vrd_inc.Text);
    //    }
    //    if (txt_bbn_inc.Text != "")
    //    {
    //        Afinidade.AFN_BBN = Convert.ToInt32(txt_bbn_inc.Text);
    //    //}
    //    //if (txt_dat_meia.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text);
    //    //}
    //    //if (txt_hr_meia.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text + " " + txt_hr_meia.Text);
    //    //}
    //    //if (txt_res_meia.Text != "")
    //    //{
    //    //    Afinidade.AFN_RES_MEIA = txt_res_meia.Text;
    //    //}
    //    //if (txt_dat_tin.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text);
    //    //}
    //    //if (txt_hr_tin.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text + " " + txt_hr_tin.Text);
    //    //}
    //    //if (cbo_ana_usr_id_tin.Text != "")
    //    //{
    //    //    Afinidade.AFN_ANA_TIN_ID = Convert.ToInt32(cbo_ana_usr_id_tin.SelectedValue);
    //    //}
    //    //if (txt_dat_lei.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text);
    //    //}
    //    //if (txt_hr_lei.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text + " " + txt_hr_lei.Text);
    //    //}
    //    //if (cbo_ana_usr_id_lei.Text != "")
    //    //{
    //    //    Afinidade.AFN_ANA_LEI_ID = Convert.ToInt32(cbo_ana_usr_id_lei.SelectedValue);
    //    //}
    //    //if (txt_dat_lib.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text);
    //    //}
    //    //if (txt_hr_lib.Text != "")
    //    //{
    //    //    Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text + " " + txt_hr_lib.Text);
    //    //}
    //    //if (cbo_ana_usr_id_lib.Text != "")
    //    //{
    //    //    Afinidade.AFN_ANA_LIB_ID = Convert.ToInt32(cbo_ana_usr_id_lib.SelectedValue);
    //    //}
    //    if (cbo_sts_inc.Text != "")
    //    {
    //        Afinidade.AFN_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
    //    }
    //    if (!string.IsNullOrEmpty(rowId.Value))
    //    {
    //        Afinidade.AFN_ID = Convert.ToInt32(rowId.Value);
    //        Afinidade.AFN_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
    //        sMsg = Afinidade.Alterar();
    //        if (sMsg != "")
    //        {
    //            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //        }
    //        else
    //        {
    //            if (txt_pos.Text != "")
    //            {
    //                Defeito Def_Afn = new Defeito();
    //                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
    //                Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
    //                Def_Afn.DEF_AFN_ID = Afinidade.AFN_ID;
    //                Afinidade.AFN_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
    //                //if (Chk_Luz_Negra.Checked)
    //                //{
    //                //    Def_Afn.DEF_TIP = 2;
    //                //    Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
    //                //}
    //                //else
    //                //{
    //                //    Def_Afn.DEF_TIP = 1;
    //                //}
    //                sMsg = Def_Afn.Inserir();
    //                if (sMsg.Substring(0, 1) == "E")
    //                {
    //                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //                }
    //            }
    //            TratamentoErro("Afinidade alterado com sucesso.");
    //        }
    //    }
    //    else
    //    {
            
    //        //DataSet ds = new DataSet("myDataSet");
    //        //ds=Afinidade.ConsultarRepetiçao();
    //        //if (ds.Tables[0].Rows.Count > 0)
    //        //{
    //        //    sMsg = "Virada: " + txt_vrd.Text + "do lote " + txt_lot.Text + "já teve lançamento pode ser duplicidade...verifique.";
    //        //    string message = sMsg + "Gostaria de continuar com o lançamento?";
    //        //    string caption = "Atenção!";
    //        //    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
    //        //    DialogResult result;
               
    //        //    // Displays the MessageBox.

    //        //    result = MessageBox.Show(message, caption, buttons);
    //        //    if (txt_pos0.Text == "" & (result == System.Windows.Forms.DialogResult.Yes))
    //        //    {
    //                Afinidade AFN = new Afinidade();
    //                Afinidade.AFN_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
    //                sMsg = Afinidade.Inserir();
    //                if (sMsg.Substring(0, 1) == "E")
    //                {
    //                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //                }
    //                txt_pos0.Text = sMsg;

    //                Defeito Def_Afn = new Defeito();
    //                Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
    //                Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
    //                Def_Afn.DEF_AFN_ID = Convert.ToInt32(txt_pos0.Text);
    //                //if (Chk_Luz_Negra.Checked)
    //                //{
    //                //    Def_Afn.DEF_TIP = 2;
    //                //    Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
    //                //}
    //                //else
    //                //{
    //                //    Def_Afn.DEF_TIP = 1;
    //                //}

    //                sMsg = Def_Afn.Inserir();
    //                if (sMsg.Substring(0, 1) == "E")
    //                {
    //                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //                }
    //                TratamentoErro("Afinidade inserido com sucesso.");
    //            //}
    //            //else
    //            //{
    //            //    TratamentoErro("Lançamento cancelado...");
    //            //    LimpaTela();
    //            //}

    //        //}
    //        //else
    //        //{
    //        //    if (txt_pos0.Text == "")
    //        //    {
    //        //        Afinidade AFN = new Afinidade();
    //        //        Afinidade.AFN_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
    //        //        sMsg = Afinidade.Inserir();
    //        //        if (sMsg.Substring(0, 1) == "E")
    //        //        {
    //        //            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //        //        }
    //        //        txt_pos0.Text = sMsg;
    //        //    }
    //        //    Defeito Def_Afn = new Defeito();
    //        //    Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
    //        //    Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
    //        //    Def_Afn.DEF_AFN_ID = Convert.ToInt32(txt_pos0.Text);
    //        //    if (Chk_Luz_Negra.Checked)
    //        //    {
    //        //        Def_Afn.DEF_TIP = 2;
    //        //        Afinidade.AFN_LNE = Convert.ToDouble(txt_lne_inc.Text);
    //        //    }
    //        //    else
    //        //    {
    //        //        Def_Afn.DEF_TIP = 1;
    //        //    }

    //        //    sMsg = Def_Afn.Inserir();
    //        //    if (sMsg.Substring(0, 1) == "E")
    //        //    {
    //        //        Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
    //        //    }
    //        //    TratamentoErro("Afinidade inserido com sucesso.");
    //        //}
    //    }
    //    txt_pos.Text = "";
    //    txt_bbn_inc.Text = "0";
    //    txt_pos.Focus();
    //    //Chk_Luz_Negra.Checked = false;
    //    //txt_lne_inc.Text = "";
    //    Dispose();
    //}
    protected void btAlterar_Click(object sender, EventArgs e)
    {
            string sMsg;
            //rowId.Value = null;
            //if (txt_dat_inc.Text == "")
            //{
            //    TratamentoErro("O campo Data é obrigatório.");
            //    txt_lot_inc.Focus();
            //    return;
            //}

            if (txt_lot_inc.Text == "")
            {
                TratamentoErro("O campo Lote é obrigatório.");
                txt_lot_inc.Focus();
                return;
            }

            //if (cbo_tit_poy_id_inc.Text == "")
            //{
            //    TratamentoErro("O campo Título é obrigatório.");
            //    cbo_tit_poy_id_inc.Focus();
            //    return;
            //}

            //if (cbo_for_001_id_inc.Text == "")
            //{
            //    TratamentoErro("O campo Fornecedor 1 é obrigatório.");
            //    cbo_for_001_id_inc.Focus();
            //    return;
            //}

            //if (cbo_aps_id_inc.Text == "")
            //{
            //    TratamentoErro("O campo Apresentação é obrigatório.");
            //    cbo_aps_id_inc.Focus();
            //    return;
            //}

            //if (cbo_maq_id_inc.Text == "")
            //{
            //    TratamentoErro("O campo Máquina é obrigatório.");
            //    cbo_maq_id_inc.Focus();
            //    return;
            //}

            //if (cbo_maq_tip_id_inc.Text == "")
            //{
            //    TratamentoErro("O campo Tipo Máquina é obrigatório.");
            //    cbo_maq_tip_id_inc.Focus();
            //    return;
            //}

            if (txt_vrd_inc.Text == "")
            {
                TratamentoErro("O campo Virada é obrigatório.");
                txt_vrd_inc.Focus();
                return;
            }

            if (txt_bbn_inc.Text == "")
            {
                TratamentoErro("O campo Bobina é obrigatório.");
                txt_bbn_inc.Focus();
                return;
            }


            if (cbo_sts_inc.Text == "")
            {
                TratamentoErro("O campo Status é obrigatório.");
                cbo_sts_inc.Focus();
                return;
            }

            Afinidade Afinidade = new Afinidade();


            //if (txt_dat_inc.Text != "")
            //{
            //    Afinidade.AFN_DAT = Convert.ToDateTime(txt_dat_inc.Text);
            //}
            //if (txt_sem_inc.Text != "")
            //{
            //    Afinidade.AFN_SEM = txt_sem_inc.Text;
            //}
            Afinidade.AFN_LOT = txt_lot_inc.Text.Trim();

            //if (cbo_tit_poy_id_inc.Text != "")
            //{
            //    Afinidade.AFN_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
            //}
            //Afinidade.AFN_MGE_001 = txt_mge_001_inc.Text;
            //Afinidade.AFN_MGE_002 = txt_mge_002_inc.Text;
            //Afinidade.AFN_MGE_003 = txt_mge_003_inc.Text;
            //Afinidade.AFN_MGE_004 = txt_mge_004_inc.Text;
            //Afinidade.AFN_FOR_001_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
            //if (cbo_for_002_id_inc.Text != "")
            //{
            //    Afinidade.AFN_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
            //}
            //if (cbo_for_003_id_inc.Text != "")
            //{
            //    Afinidade.AFN_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
            //}
            //if (cbo_for_004_id_inc.Text != "")
            //{
            //    Afinidade.AFN_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
            //}
            //if (txt_vlc_inc.Text != "")
            //{
            //    Afinidade.AFN_VLC = Convert.ToInt32(txt_vlc_inc.Text);
            //}
            //if (cbo_aps_id_inc.Text != "")
            //{
            //    Afinidade.AFN_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
            //}
            //if (cbo_maq_id_inc.Text != "")
            //{
            //    Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
            //}
            //if (cbo_maq_tip_id_inc.Text != "")
            //{
            //    Afinidade.AFN_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
            //}
            //if (cbo_ert_id_inc.Text != "")
            //{
            //    Afinidade.AFN_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
            //}
            if (txt_vrd_inc.Text != "")
            {
                Afinidade.AFN_VRD = Convert.ToInt32(txt_vrd_inc.Text);
            }
            if (txt_bbn_inc.Text != "")
            {
                Afinidade.AFN_BBN = Convert.ToInt32(txt_bbn_inc.Text);
            }
            //if (txt_dat_meia.Text != "")
            //{
            //    Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text);
            //}
            //if (txt_hr_meia.Text != "")
            //{
            //    Afinidade.AFN_DAT_MEIA = Convert.ToDateTime(txt_dat_meia.Text + " " + txt_hr_meia.Text);
            //}
            //if (txt_res_meia.Text != "")
            //{
            //    Afinidade.AFN_RES_MEIA = txt_res_meia.Text;
            //}
            //if (txt_dat_tin.Text != "")
            //{
            //    Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text);
            //}
            //if (txt_hr_tin.Text != "")
            //{
            //    Afinidade.AFN_DAT_TIN = Convert.ToDateTime(txt_dat_tin.Text + " " + txt_hr_tin.Text);
            //}
            //if (cbo_ana_usr_id_tin.Text != "")
            //{
            //    Afinidade.AFN_ANA_TIN_ID = Convert.ToInt32(cbo_ana_usr_id_tin.SelectedValue);
            //}
            //if (txt_dat_lei.Text != "")
            //{
            //    Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text);
            //}
            //if (txt_hr_lei.Text != "")
            //{
            //    Afinidade.AFN_DAT_LEI = Convert.ToDateTime(txt_dat_lei.Text + " " + txt_hr_lei.Text);
            //}
            //if (cbo_ana_usr_id_lei.Text != "")
            //{
            //    Afinidade.AFN_ANA_LEI_ID = Convert.ToInt32(cbo_ana_usr_id_lei.SelectedValue);
            //}
            //if (txt_dat_lib.Text != "")
            //{
            //    Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text);
            //}
            //if (txt_hr_lib.Text != "")
            //{
            //    Afinidade.AFN_DAT_LIB = Convert.ToDateTime(txt_dat_lib.Text + " " + txt_hr_lib.Text);
            //}
            //if (cbo_ana_usr_id_lib.Text != "")
            //{
            //    Afinidade.AFN_ANA_LIB_ID = Convert.ToInt32(cbo_ana_usr_id_lib.SelectedValue);
            //}
            if (cbo_sts_inc.Text != "")
            {
                Afinidade.AFN_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
            }
            Afinidade.AFN_ID = Convert.ToInt32(txt_afn_id.Text.ToString());
            Afinidade.AFN_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Afinidade.Alterar();
            Defeito Def_Afn = new Defeito();
            Def_Afn.DEF_POS = Convert.ToInt32(txt_pos.Text);
            Def_Afn.DEF_DES = cbo_def_id_inc.SelectedValue;
            Def_Afn.DEF_AFN_ID = Convert.ToInt32(txt_afn_id.Text.ToString());
            Def_Afn.DEF_ID = Convert.ToInt32(rowId.Value);
            Afinidade.AFN_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            //if (Chk_Luz_Negra.Checked)
            //    {
            //        Def_Afn.DEF_TIP = 2;
            //    }
            //else
            //    {
            //        Def_Afn.DEF_TIP = 1;
            //    }
            sMsg = Def_Afn.Alterar();
            //if (sMsg.Substring(0, 1) == "E")
            //    {
            //        Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            //    }
            TratamentoErro("Afinidade alterada com sucesso.");
            txt_pos.Text = "";
            txt_pos.Focus();
            Dispose();
            btFiltro_Click(sender,e);

    }

    protected void EnviaEmail()
    {
       Afinidade AFN = new Afinidade();
        AFN.AFN_LOT = txt_lot_inc.Text;
        AFN.AFN_DAT = Convert.ToDateTime(txt_dat_inc.Text);
        AFN.AFN_VRD = Convert.ToInt32(txt_vrd_inc.Text);
        DataSet dsAFN = AFN.ConsultaDefeito();
        if (dsAFN.Tables[0].Rows.Count > 0)
        {
            //string sAFN = "";
            //sAFN = dsAFN.Tables[0].Rows[0]["AFN_ID"].ToString();
            //string sMotivoTeste = "";
            //sMotivoTeste = dsRTS.Tables[0].Rows[0]["MTV_TST_DES"].ToString();
            //string sUsuarioSolicitante = "";
            //sUsuarioSolicitante = dsRTS.Tables[0].Rows[0]["USR_NOM"].ToString();
            //string sEntrelacamento = "";
            //sEntrelacamento = dsRTS.Tables[0].Rows[0]["ERT_DES"].ToString();

            string sRemetente = ConfigurationManager.AppSettings["EnderecoSMTP"];
            string sListaDestinatario = "";
            //string sListaCopia = ConfigurationManager.AppSettings["EnderecoSMTP"];
            string sListaCopia = "";

            Usuario Usuario = new Usuario();
            //Perfil Área Técnia
            Usuario.USR_PFL_ID = 1;
            //Usuario.USR_PFL_ID = 72;
            DataSet dsUsuario = Usuario.Consultar();
            foreach (DataRow drUsuario in dsUsuario.Tables[0].Rows)
            {
                sListaDestinatario += ";" + drUsuario["USR_EML"].ToString();
            }
            dsUsuario.Dispose();

            //Usuario UsuarioAtual = new Usuario();
            //UsuarioAtual.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            //DataSet dsUsuarioAtual = UsuarioAtual.Consultar();
            //foreach (DataRow drUsuarioAtual in dsUsuarioAtual.Tables[0].Rows)
            //{
            //    sListaCopia += ";" + drUsuarioAtual["USR_EML"].ToString();
            //}
            //dsUsuarioAtual.Dispose();

            //string sCliente = "";
            //if (!string.IsNullOrEmpty(dsAFN.Tables[0].Rows[0]["RTS_CLI_ID"].ToString()))
            //{
            //    Cliente Cliente = new Cliente();
            //    Cliente.CLI_ID = Convert.ToInt32(dsRTS.Tables[0].Rows[0]["RTS_CLI_ID"].ToString());
            //    DataSet dsCliente = Cliente.Consultar();
            //    if (dsCliente.Tables[0].Rows.Count > 0)
            //    {
            //        sCliente = dsCliente.Tables[0].Rows[0]["CLI_NOM"].ToString();
            //    }
            //    dsCliente.Dispose();
            //}

            string sDataInclusao = "";
            if (!string.IsNullOrEmpty(dsAFN.Tables[0].Rows[0]["AFN_DAT"].ToString()))
            {
                sDataInclusao = Convert.ToDateTime(dsAFN.Tables[0].Rows[0]["AFN_DAT"].ToString()).ToString("dd/MM/yyyy");
            }

            string sListaCopiaOculta = "";
            bool bFormatoHTML = true;
            string sTitulo = "Liberação Afinidade ";
            string sAssunto = "";
            sAssunto += "<br>";
            sAssunto += "<br>";
            sAssunto += "Data: " +  sDataInclusao + ".";
            sAssunto += "<br>";
            sAssunto += "Lote: " + dsAFN.Tables[0].Rows[0]["AFN_LOT"].ToString();
            sAssunto += "<br>";
            sAssunto += "Título: " + dsAFN.Tables[0].Rows[0]["TIT_POY_DES"].ToString();
            sAssunto += "<br>";
            sAssunto += "Apresentação: " + dsAFN.Tables[0].Rows[0]["APS_DES"].ToString();
            sAssunto += "<br>";
            sAssunto += "Máquina: " + dsAFN.Tables[0].Rows[0]["MAQ_DES"].ToString();
            sAssunto += "<br>";
            sAssunto += "Entrelaçamento: " + dsAFN.Tables[0].Rows[0]["ERT_DES"].ToString();
            sAssunto += "<br>";
            sAssunto += "Virada: " + dsAFN.Tables[0].Rows[0]["AFN_VRD"].ToString();
            sAssunto += "<br>";
            sAssunto += "<br>";
            sAssunto += "Gaiola de " + dsAFN.Tables[0].Rows[0]["AFN_GLA"].ToString();
            sAssunto += "<br>";
            sAssunto += "<br>";
            sAssunto += "Observação: " + dsAFN.Tables[0].Rows[0]["AFN_OBS"].ToString();
            sAssunto += "<br>";
            sAssunto += "<br>";
            sAssunto += "<br>";
            if (txt_pos.Text != "" && txt_pos.Text != "0")
            {
                sAssunto += "Posição: " + txt_pos.Text;
                sAssunto += " /";
                if (cbo_def_id_inc.Text == "E" || cbo_def_id_inc.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc.Text == "LNE" || cbo_def_id_inc.Text == "LNC" || cbo_def_id_inc.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            else
            {
                sAssunto += "AFINIDADE SEM DEFEITO";
                return;
            }

            if (txt_pos0.Text != "")
            {
                sAssunto += "Posição: " + txt_pos0.Text;
                sAssunto += " /";
                if (cbo_def_id_inc0.Text == "E" || cbo_def_id_inc0.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc0.Text == "LNE" || cbo_def_id_inc0.Text == "LNC" || cbo_def_id_inc0.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos1.Text != "")
            {
                sAssunto += "Posição: " + txt_pos1.Text;
                sAssunto += " /";
                if (cbo_def_id_inc1.Text == "E" || cbo_def_id_inc1.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc1.Text == "LNE" || cbo_def_id_inc1.Text == "LNC" || cbo_def_id_inc1.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos2.Text != "")
            {
                sAssunto += "Posição: " + txt_pos2.Text;
                sAssunto += " /";
                if (cbo_def_id_inc2.Text == "E" || cbo_def_id_inc2.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc2.Text == "LNE" || cbo_def_id_inc2.Text == "LNC" || cbo_def_id_inc2.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos3.Text != "")
            {
                sAssunto += "Posição: " + txt_pos3.Text;
                sAssunto += " /";
                if (cbo_def_id_inc3.Text == "E" || cbo_def_id_inc3.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc3.Text == "LNE" || cbo_def_id_inc3.Text == "LNC" || cbo_def_id_inc3.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos4.Text != "")
            {
                sAssunto += "Posição: " + txt_pos4.Text;
                sAssunto += " /";
                if (cbo_def_id_inc4.Text == "E" || cbo_def_id_inc4.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc4.Text == "LNE" || cbo_def_id_inc4.Text == "LNC" || cbo_def_id_inc4.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos5.Text != "")
            {
                sAssunto += "Posição: " + txt_pos5.Text;
                sAssunto += " /";
                if (cbo_def_id_inc5.Text == "E" || cbo_def_id_inc5.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc5.Text == "LNE" || cbo_def_id_inc5.Text == "LNC" || cbo_def_id_inc5.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos6.Text != "")
            {
                sAssunto += "Posição: " + txt_pos6.Text;
                sAssunto += " /";
                if (cbo_def_id_inc6.Text == "E" || cbo_def_id_inc6.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc6.Text == "LNE" || cbo_def_id_inc6.Text == "LNC" || cbo_def_id_inc6.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos7.Text != "")
            {
                sAssunto += "Posição: " + txt_pos7.Text;
                sAssunto += " /";
                if (cbo_def_id_inc7.Text == "E" || cbo_def_id_inc7.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc7.Text == "LNE" || cbo_def_id_inc7.Text == "LNC" || cbo_def_id_inc7.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos8.Text != "")
            {
                sAssunto += "Posição: " + txt_pos8.Text;
                sAssunto += " /";
                if (cbo_def_id_inc8.Text == "E" || cbo_def_id_inc8.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc8.Text == "LNE" || cbo_def_id_inc8.Text == "LNC" || cbo_def_id_inc8.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos9.Text != "")
            {
                sAssunto += "Posição: " + txt_pos9.Text;
                sAssunto += " /";
                if (cbo_def_id_inc9.Text == "E" || cbo_def_id_inc9.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc9.Text == "LNE" || cbo_def_id_inc9.Text == "LNC" || cbo_def_id_inc9.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos10.Text != "")
            {
                sAssunto += "Posição: " + txt_pos10.Text;
                sAssunto += " /";
                if (cbo_def_id_inc10.Text == "E" || cbo_def_id_inc10.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc10.Text == "LNE" || cbo_def_id_inc10.Text == "LNC" || cbo_def_id_inc10.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos11.Text != "")
            {
                sAssunto += "Posição: " + txt_pos11.Text;
                sAssunto += " /";
                if (cbo_def_id_inc11.Text == "E" || cbo_def_id_inc11.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc11.Text == "LNE" || cbo_def_id_inc11.Text == "LNC" || cbo_def_id_inc11.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos12.Text != "")
            {
                sAssunto += "Posição: " + txt_pos12.Text;
                sAssunto += " /";
                if (cbo_def_id_inc12.Text == "E" || cbo_def_id_inc12.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc12.Text == "LNE" || cbo_def_id_inc12.Text == "LNC" || cbo_def_id_inc12.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos13.Text != "")
            {
                sAssunto += "Posição: " + txt_pos13.Text;
                sAssunto += " /";
                if (cbo_def_id_inc13.Text == "E" || cbo_def_id_inc13.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc13.Text == "LNE" || cbo_def_id_inc13.Text == "LNC" || cbo_def_id_inc13.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos14.Text != "")
            {
                sAssunto += "Posição: " + txt_pos14.Text;
                sAssunto += " /";
                if (cbo_def_id_inc14.Text == "E" || cbo_def_id_inc14.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc14.Text == "LNE" || cbo_def_id_inc14.Text == "LNC" || cbo_def_id_inc14.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos15.Text != "")
            {
                sAssunto += "Posição: " + txt_pos15.Text;
                sAssunto += " /";
                if (cbo_def_id_inc15.Text == "E" || cbo_def_id_inc15.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc15.Text == "LNE" || cbo_def_id_inc15.Text == "LNC" || cbo_def_id_inc15.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos16.Text != "")
            {
                sAssunto += "Posição: " + txt_pos16.Text;
                sAssunto += " /";
                if (cbo_def_id_inc16.Text == "E" || cbo_def_id_inc16.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc16.Text == "LNE" || cbo_def_id_inc16.Text == "LNC" || cbo_def_id_inc16.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos17.Text != "")
            {
                sAssunto += "Posição: " + txt_pos17.Text;
                sAssunto += " /";
                if (cbo_def_id_inc17.Text == "E" || cbo_def_id_inc17.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc17.Text == "LNE" || cbo_def_id_inc17.Text == "LNC" || cbo_def_id_inc17.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos18.Text != "")
            {
                sAssunto += "Posição: " + txt_pos18.Text;
                sAssunto += " /";
                if (cbo_def_id_inc18.Text == "E" || cbo_def_id_inc18.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc18.Text == "LNE" || cbo_def_id_inc18.Text == "LNC" || cbo_def_id_inc18.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos19.Text != "")
            {
                sAssunto += "Posição: " + txt_pos19.Text;
                sAssunto += " /";
                if (cbo_def_id_inc19.Text == "E" || cbo_def_id_inc19.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc19.Text == "LNE" || cbo_def_id_inc19.Text == "LNC" || cbo_def_id_inc19.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos20.Text != "")
            {
                sAssunto += "Posição: " + txt_pos20.Text;
                sAssunto += " /";
                if (cbo_def_id_inc20.Text == "E" || cbo_def_id_inc20.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc20.Text == "LNE" || cbo_def_id_inc20.Text == "LNC" || cbo_def_id_inc20.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos21.Text != "")
            {
                sAssunto += "Posição: " + txt_pos21.Text;
                sAssunto += " /";
                if (cbo_def_id_inc21.Text == "E" || cbo_def_id_inc21.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc21.Text == "LNE" || cbo_def_id_inc21.Text == "LNC" || cbo_def_id_inc21.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos22.Text != "")
            {
                sAssunto += "Posição: " + txt_pos22.Text;
                sAssunto += " /";
                if (cbo_def_id_inc22.Text == "E" || cbo_def_id_inc22.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc22.Text == "LNE" || cbo_def_id_inc22.Text == "LNC" || cbo_def_id_inc22.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos23.Text != "")
            {
                sAssunto += "Posição: " + txt_pos23.Text;
                sAssunto += " /";
                if (cbo_def_id_inc23.Text == "E" || cbo_def_id_inc23.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc23.Text == "LNE" || cbo_def_id_inc23.Text == "LNC" || cbo_def_id_inc23.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos24.Text != "")
            {
                sAssunto += "Posição: " + txt_pos24.Text;
                sAssunto += " /";
                if (cbo_def_id_inc24.Text == "E" || cbo_def_id_inc24.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc24.Text == "LNE" || cbo_def_id_inc24.Text == "LNC" || cbo_def_id_inc24.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos25.Text != "")
            {
                sAssunto += "Posição: " + txt_pos25.Text;
                sAssunto += " /";
                if (cbo_def_id_inc25.Text == "E" || cbo_def_id_inc25.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc25.Text == "LNE" || cbo_def_id_inc25.Text == "LNC" || cbo_def_id_inc25.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos26.Text != "")
            {
                sAssunto += "Posição: " + txt_pos26.Text;
                sAssunto += " /";
                if (cbo_def_id_inc26.Text == "E" || cbo_def_id_inc26.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc26.Text == "LNE" || cbo_def_id_inc26.Text == "LNC" || cbo_def_id_inc26.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos27.Text != "")
            {
                sAssunto += "Posição: " + txt_pos27.Text;
                sAssunto += " /";
                if (cbo_def_id_inc27.Text == "E" || cbo_def_id_inc27.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc27.Text == "LNE" || cbo_def_id_inc27.Text == "LNC" || cbo_def_id_inc27.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos28.Text != "")
            {
                sAssunto += "Posição: " + txt_pos28.Text;
                sAssunto += " /";
                if (cbo_def_id_inc28.Text == "E" || cbo_def_id_inc28.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc28.Text == "LNE" || cbo_def_id_inc28.Text == "LNC" || cbo_def_id_inc28.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos29.Text != "")
            {
                sAssunto += "Posição: " + txt_pos29.Text;
                sAssunto += " /";
                if (cbo_def_id_inc29.Text == "E" || cbo_def_id_inc29.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc29.Text == "LNE" || cbo_def_id_inc29.Text == "LNC" || cbo_def_id_inc29.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos30.Text != "")
            {
                sAssunto += "Posição: " + txt_pos30.Text;
                sAssunto += " /";
                if (cbo_def_id_inc30.Text == "E" || cbo_def_id_inc30.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc30.Text == "LNE" || cbo_def_id_inc30.Text == "LNC" || cbo_def_id_inc30.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos31.Text != "")
            {
                sAssunto += "Posição: " + txt_pos31.Text;
                sAssunto += " /";
                if (cbo_def_id_inc31.Text == "E" || cbo_def_id_inc31.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc31.Text == "LNE" || cbo_def_id_inc31.Text == "LNC" || cbo_def_id_inc31.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos32.Text != "")
            {
                sAssunto += "Posição: " + txt_pos32.Text;
                sAssunto += " /";
                if (cbo_def_id_inc32.Text == "E" || cbo_def_id_inc32.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc32.Text == "LNE" || cbo_def_id_inc32.Text == "LNC" || cbo_def_id_inc32.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos33.Text != "")
            {
                sAssunto += "Posição: " + txt_pos33.Text;
                sAssunto += " /";
                if (cbo_def_id_inc33.Text == "E" || cbo_def_id_inc33.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc33.Text == "LNE" || cbo_def_id_inc33.Text == "LNC" || cbo_def_id_inc33.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos34.Text != "")
            {
                sAssunto += "Posição: " + txt_pos34.Text;
                sAssunto += " /";
                if (cbo_def_id_inc34.Text == "E" || cbo_def_id_inc34.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc34.Text == "LNE" || cbo_def_id_inc34.Text == "LNC" || cbo_def_id_inc34.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos35.Text != "")
            {
                sAssunto += "Posição: " + txt_pos35.Text;
                sAssunto += " /";
                if (cbo_def_id_inc35.Text == "E" || cbo_def_id_inc35.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc35.Text == "LNE" || cbo_def_id_inc35.Text == "LNC" || cbo_def_id_inc35.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos36.Text != "")
            {
                sAssunto += "Posição: " + txt_pos36.Text;
                sAssunto += " /";
                if (cbo_def_id_inc36.Text == "E" || cbo_def_id_inc36.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc36.Text == "LNE" || cbo_def_id_inc36.Text == "LNC" || cbo_def_id_inc36.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos37.Text != "")
            {
                sAssunto += "Posição: " + txt_pos37.Text;
                sAssunto += " /";
                if (cbo_def_id_inc37.Text == "E" || cbo_def_id_inc37.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc37.Text == "LNE" || cbo_def_id_inc37.Text == "LNC" || cbo_def_id_inc37.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos38.Text != "")
            {
                sAssunto += "Posição: " + txt_pos38.Text;
                sAssunto += " /";
                if (cbo_def_id_inc38.Text == "E" || cbo_def_id_inc38.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc38.Text == "LNE" || cbo_def_id_inc38.Text == "LNC" || cbo_def_id_inc38.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos39.Text != "")
            {
                sAssunto += "Posição: " + txt_pos39.Text;
                sAssunto += " /";
                if (cbo_def_id_inc39.Text == "E" || cbo_def_id_inc39.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc39.Text == "LNE" || cbo_def_id_inc39.Text == "LNC" || cbo_def_id_inc39.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos40.Text != "")
            {
                sAssunto += "Posição: " + txt_pos40.Text;
                sAssunto += " /";
                if (cbo_def_id_inc40.Text == "E" || cbo_def_id_inc40.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc40.Text == "LNE" || cbo_def_id_inc40.Text == "LNC" || cbo_def_id_inc40.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos41.Text != "")
            {
                sAssunto += "Posição: " + txt_pos41.Text;
                sAssunto += " /";
                if (cbo_def_id_inc41.Text == "E" || cbo_def_id_inc41.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc41.Text == "LNE" || cbo_def_id_inc41.Text == "LNC" || cbo_def_id_inc41.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos42.Text != "")
            {
                sAssunto += "Posição: " + txt_pos42.Text;
                sAssunto += " /";
                if (cbo_def_id_inc42.Text == "E" || cbo_def_id_inc42.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc42.Text == "LNE" || cbo_def_id_inc42.Text == "LNC" || cbo_def_id_inc42.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos43.Text != "")
            {
                sAssunto += "Posição: " + txt_pos43.Text;
                sAssunto += " /";
                if (cbo_def_id_inc43.Text == "E" || cbo_def_id_inc43.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc43.Text == "LNE" || cbo_def_id_inc43.Text == "LNC" || cbo_def_id_inc43.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos44.Text != "")
            {
                sAssunto += "Posição: " + txt_pos44.Text;
                sAssunto += " /";
                if (cbo_def_id_inc44.Text == "E" || cbo_def_id_inc44.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc44.Text == "LNE" || cbo_def_id_inc44.Text == "LNC" || cbo_def_id_inc44.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos45.Text != "")
            {
                sAssunto += "Posição: " + txt_pos45.Text;
                sAssunto += " /";
                if (cbo_def_id_inc45.Text == "E" || cbo_def_id_inc45.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc45.Text == "LNE" || cbo_def_id_inc45.Text == "LNC" || cbo_def_id_inc45.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos46.Text != "")
            {
                sAssunto += "Posição: " + txt_pos46.Text;
                sAssunto += " /";
                if (cbo_def_id_inc46.Text == "E" || cbo_def_id_inc46.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc46.Text == "LNE" || cbo_def_id_inc46.Text == "LNC" || cbo_def_id_inc46.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos47.Text != "")
            {
                sAssunto += "Posição: " + txt_pos47.Text;
                sAssunto += " /";
                if (cbo_def_id_inc47.Text == "E" || cbo_def_id_inc47.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc47.Text == "LNE" || cbo_def_id_inc47.Text == "LNC" || cbo_def_id_inc47.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos48.Text != "")
            {
                sAssunto += "Posição: " + txt_pos48.Text;
                sAssunto += " /";
                if (cbo_def_id_inc48.Text == "E" || cbo_def_id_inc48.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc48.Text == "LNE" || cbo_def_id_inc48.Text == "LNC" || cbo_def_id_inc48.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos49.Text != "")
            {
                sAssunto += "Posição: " + txt_pos49.Text;
                sAssunto += " /";
                if (cbo_def_id_inc49.Text == "E" || cbo_def_id_inc49.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc49.Text == "LNE" || cbo_def_id_inc49.Text == "LNC" || cbo_def_id_inc49.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos50.Text != "")
            {
                sAssunto += "Posição: " + txt_pos50.Text;
                sAssunto += " /";
                if (cbo_def_id_inc50.Text == "E" || cbo_def_id_inc50.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc50.Text == "LNE" || cbo_def_id_inc50.Text == "LNC" || cbo_def_id_inc50.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos51.Text != "")
            {
                sAssunto += "Posição: " + txt_pos51.Text;
                sAssunto += " /";
                if (cbo_def_id_inc51.Text == "E" || cbo_def_id_inc51.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc51.Text == "LNE" || cbo_def_id_inc51.Text == "LNC" || cbo_def_id_inc51.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos52.Text != "")
            {
                sAssunto += "Posição: " + txt_pos52.Text;
                sAssunto += " /";
                if (cbo_def_id_inc52.Text == "E" || cbo_def_id_inc52.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc52.Text == "LNE" || cbo_def_id_inc52.Text == "LNC" || cbo_def_id_inc52.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos53.Text != "")
            {
                sAssunto += "Posição: " + txt_pos53.Text;
                sAssunto += " /";
                if (cbo_def_id_inc53.Text == "E" || cbo_def_id_inc53.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc53.Text == "LNE" || cbo_def_id_inc53.Text == "LNC" || cbo_def_id_inc53.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }
            if (txt_pos54.Text != "")
            {
                sAssunto += "Posição: " + txt_pos54.Text;
                sAssunto += " /";
                if (cbo_def_id_inc54.Text == "E" || cbo_def_id_inc54.Text == "C")
                {
                    sAssunto += "NV";
                }
                else if (cbo_def_id_inc54.Text == "LNE" || cbo_def_id_inc54.Text == "LNC" || cbo_def_id_inc54.Text == "LNEsc")
                {
                    sAssunto += "LUZ NEGRA";
                }
                else
                {
                    sAssunto += "DV";
                }
                sAssunto += "<br>";
                sAssunto += "<br>";
            }

            //sAssunto += "Alterada por " + Session["USR"].ToString() + " em " + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + ".";
            string sListaCaminhoAnexo = "";
            string sServer = ConfigurationManager.AppSettings["ServidorSMTP"];
            string sUsuario = ConfigurationManager.AppSettings["UsuarioSMTP"];
            string sSenha = ConfigurationManager.AppSettings["SenhaSMTP"];
            bool bSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["SSLSMTP"]);
            int iPortaSmtp = Convert.ToInt32(ConfigurationManager.AppSettings["PortaSMTP"]);

            Email Email = new Email();
            Email.EnviarEmail(sRemetente, sListaDestinatario, sListaCopia, sListaCopiaOculta, bFormatoHTML, sTitulo, sAssunto, sListaCaminhoAnexo, sServer, bSSL, iPortaSmtp, sUsuario, sSenha);

            //Response.Write("<script language=\"javascript\">alert('Email enviado com sucesso aos Supervisores da Escolha.')</script>");

            Dispose();
        }
        //else
        //{
        //    Response.Write("<script language=\"javascript\">alert('Email não enviado pois não existe defeito para o Lote: " + txt_lot_inc.Text + ".')</script>");
        //}
    }

    protected void txt_dat_inc_TextChanged(object sender, EventArgs e)
    {
        CalculaSemana(sender, e);
    }
    protected void gvAfinidade_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}