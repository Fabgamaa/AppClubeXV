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
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_ini.Focus();
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "T"; //Somente Texturizados
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel);
        dsTitulo.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "T"; //Somente Texturizados
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_rel);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_rel);
        dsFornecedor.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_rel);
        dsApresentacao.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_rel);
        dsMaquinaTipo.Dispose();

        Maquina Maquina = new Maquina();
        DataSet dsMaquina = Maquina.Consultar();
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id);
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id_rel);
        dsMaquina.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id);
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_rel);
        dsEntrelacamento.Dispose();
    }

    protected string CriaFiltro(Afinidade Afinidade)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            Afinidade.AFN_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Afinidade.AFN_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_sem.Text))
        {
            Afinidade.AFN_SEM = txt_sem.Text;
            filtro = filtro + "Semana= " + txt_sem.Text + "; ";
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
        if (!String.IsNullOrEmpty(txt_mge_001.Text))
        {
            Afinidade.AFN_MGE_001 = txt_mge_001.Text;
            filtro = filtro + "Merge 1= " + txt_mge_001.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge_002.Text))
        {
            Afinidade.AFN_MGE_002 = txt_mge_002.Text;
            filtro = filtro + "Merge 2= " + txt_mge_002.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge_003.Text))
        {
            Afinidade.AFN_MGE_003 = txt_mge_003.Text;
            filtro = filtro + "Merge 3= " + txt_mge_003.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge_004.Text))
        {
            Afinidade.AFN_MGE_004 = txt_mge_004.Text;
            filtro = filtro + "Merge 4= " + txt_mge_004.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_001_id.Text))
        {
            Afinidade.AFN_FOR_001_ID = Convert.ToInt32(cbo_for_001_id.SelectedValue);
            filtro = filtro + "Fornecedor 1= " + cbo_for_001_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_002_id.Text))
        {
            Afinidade.AFN_FOR_002_ID = Convert.ToInt32(cbo_for_002_id.SelectedValue);
            filtro = filtro + "Fornecedor 2= " + cbo_for_002_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_003_id.Text))
        {
            Afinidade.AFN_FOR_003_ID = Convert.ToInt32(cbo_for_003_id.SelectedValue);
            filtro = filtro + "Fornecedor 3= " + cbo_for_003_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_004_id.Text))
        {
            Afinidade.AFN_FOR_004_ID = Convert.ToInt32(cbo_for_004_id.SelectedValue);
            filtro = filtro + "Fornecedor 4= " + cbo_for_004_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vlc.Text))
        {
            Afinidade.AFN_VLC = Convert.ToInt32(txt_vlc.Text);
            filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Afinidade.AFN_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Afinidade.AFN_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_id.Text))
        {
            Afinidade.AFN_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
        }
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
        if (!String.IsNullOrEmpty(txt_bbn.Text))
        {
            Afinidade.AFN_BBN = Convert.ToInt32(txt_bbn.Text);
            filtro = filtro + "Bobina= " + txt_bbn.Text + "; ";
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

        Afinidade AfinidadeMedia = new Afinidade();
        filtro = CriaFiltro(AfinidadeMedia);

        string [] afiltro = filtro.Split(';');
        if ((filtro == "") || ((txt_lot.Text == "") && ((afiltro.Length - 1) < 2)))
        {
            TratamentoErro("O Filtro deve possuir o Lote ou outros dois argumentos.");
            txt_dat_ini.Focus();
            return;
        }

        DataSet dsAfinidadeMedia = AfinidadeMedia.ConsultarMedia();

        //if ((dsAfinidadeMedia.Tables[0].Rows.Count > 0) && (dsAfinidadeMedia.Tables[0].Rows[0]["QTD"].ToString() != "0"))
        if (dsAfinidadeMedia.Tables[0].Rows.Count > 0)

        {
            txt_dat_ini_rel.Text = txt_dat_ini.Text;
            txt_dat_fim_rel.Text = txt_dat_fim.Text;
            txt_sem_rel.Text = txt_sem.Text;
            cbo_tip_rel.SelectedValue = cbo_tip.SelectedValue;
            ApresentaTipo();
            cbo_tit_poy_id_rel.SelectedValue = cbo_tit_poy_id.SelectedValue;
            txt_lot_rel.Text = txt_lot.Text;
            txt_mge_001_rel.Text = txt_mge_001.Text;
            txt_mge_002_rel.Text = txt_mge_002.Text;
            txt_mge_003_rel.Text = txt_mge_003.Text;
            txt_mge_004_rel.Text = txt_mge_004.Text;
            cbo_for_001_id_rel.SelectedValue = cbo_for_001_id.SelectedValue;
            cbo_for_002_id_rel.SelectedValue = cbo_for_002_id.SelectedValue;
            cbo_for_003_id_rel.SelectedValue = cbo_for_003_id.SelectedValue;
            cbo_for_004_id_rel.SelectedValue = cbo_for_004_id.SelectedValue;
            txt_vlc_rel.Text = txt_vlc.Text;
            cbo_aps_id_rel.SelectedValue = cbo_aps_id.SelectedValue;
            cbo_maq_tip_id_rel.SelectedValue = cbo_maq_tip_id.SelectedValue;
            cbo_maq_id_rel.SelectedValue = cbo_maq_id.SelectedValue;
            cbo_ert_id_rel.SelectedValue = cbo_ert_id.SelectedValue;
            txt_vrd_rel.Text = txt_vrd.Text;
            txt_bbn_rel.Text = txt_bbn.Text;

            lbl_num.Text = dsAfinidadeMedia.Tables[0].Rows[0]["NUM"].ToString();

            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MED"].ToString()))
            {
                txt_clo_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MED"].ToString()))
            {
                txt_esu_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MED"].ToString()))
            {
                txt_tmt_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MED"].ToString()))
            {
                txt_pmt_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MED"].ToString()))
            {
                txt_ppf_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MED"].ToString()))
            {
                txt_bbb_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MED"].ToString()))
            {
                txt_pfe_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MED"].ToString()))
            {
                txt_pse_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MED"].ToString()))
            {
                txt_lne_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MED"].ToString()))
            {
                txt_lnc_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MED"].ToString()))
            {
                txt_esl_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MED"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MED"].ToString()))
            {
                txt_tot_med.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MED"].ToString()).ToString("0.0");
            }

            txt_clo_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_DSV"].ToString()).ToString("0.0");
            txt_esu_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_DSV"].ToString()).ToString("0.0");
            txt_tmt_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_DSV"].ToString()).ToString("0.0");
            txt_pmt_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_DSV"].ToString()).ToString("0.0");
            txt_ppf_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_DSV"].ToString()).ToString("0.0");
            txt_bbb_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_DSV"].ToString()).ToString("0.0");
            txt_pfe_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_DSV"].ToString()).ToString("0.0");
            txt_pse_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_DSV"].ToString()).ToString("0.0");
            txt_lne_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_DSV"].ToString()).ToString("0.0");
            txt_lnc_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_DSV"].ToString()).ToString("0.0");
            txt_esl_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_DSV"].ToString()).ToString("0.0");
            txt_tot_dsv.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_DSV"].ToString()).ToString("0.0");

            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MIN"].ToString()))
            {
                txt_clo_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MIN"].ToString()))
            {
                txt_esu_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MIN"].ToString()))
            {
                txt_tmt_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MIN"].ToString()))
            {
                txt_pmt_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MIN"].ToString()))
            {
                txt_ppf_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MIN"].ToString()))
            {
                txt_bbb_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MIN"].ToString()))
            {
                txt_pfe_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MIN"].ToString()))
            {
                txt_pse_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MIN"].ToString()))
            {
                txt_lne_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MIN"].ToString()))
            {
                txt_lnc_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MIN"].ToString()))
            {
                txt_esl_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MIN"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MIN"].ToString()))
            {
                txt_tot_min.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MIN"].ToString()).ToString("0.0");
            }

            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MAX"].ToString()))
            {
                txt_clo_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["CLO_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MAX"].ToString()))
            {
                txt_esu_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESU_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MAX"].ToString()))
            {
                txt_tmt_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TMT_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MAX"].ToString()))
            {
                txt_pmt_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PMT_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MAX"].ToString()))
            {
                txt_ppf_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PPF_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MAX"].ToString()))
            {
                txt_bbb_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["BBB_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MAX"].ToString()))
            {
                txt_pfe_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PFE_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MAX"].ToString()))
            {
                txt_pse_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["PSE_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MAX"].ToString()))
            {
                txt_lne_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNE_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MAX"].ToString()))
            {
                txt_lnc_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["LNC_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MAX"].ToString()))
            {
                txt_esl_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["ESL_MAX"].ToString()).ToString("0.0");
            }
            if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MAX"].ToString()))
            {
                txt_tot_max.Text = Convert.ToDouble(dsAfinidadeMedia.Tables[0].Rows[0]["TOT_MAX"].ToString()).ToString("0.0");
            }
            //int ff = 0;
            //int i;
            //decimal x;
            //for (i = 0; i <= (dsAfinidadeMedia.Tables[0].Rows.Count) - 1; i++)
            //{
            //    if (i <= dsAfinidadeMedia.Tables[0].Rows.Count) ;
            //    {
            //        ff = ff + Convert.ToInt32(dsAfinidadeMedia.Tables[0].Rows[i]["QTD"]);

            //    }

            //}
            //txt_tot_med.Text = Convert.ToDouble(ff.ToString()).ToString("0.0");
        //    if (!string.IsNullOrEmpty(dsAfinidadeMedia.Tables[0].Rows[0]["DEF"].ToString()))
        //    {
        //        for (i = 0; i <= (dsAfinidadeMedia.Tables[0].Rows.Count) - 1; i++)
                   
        //        {
        //            x = (Convert.ToDecimal(dsAfinidadeMedia.Tables[0].Rows[i]["QTD"])) / ff;
        //            switch (dsAfinidadeMedia.Tables[0].Rows[i]["DEF"].ToString())
        //            {
        //                case "C":
        //                    txt_clo_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "E":
        //                    txt_esu_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "TMT":
        //                    txt_tmt_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "MT":
        //                    txt_pmt_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "PF":
        //                    txt_ppf_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "B":
        //                    txt_bbb_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "FE":
        //                    txt_pfe_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "SE":
        //                    txt_pse_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "LNE":
        //                    txt_lne_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "LNC":
        //                    txt_lnc_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                case "LNEsc":
        //                    txt_esl_med.Text = Convert.ToDouble(x.ToString()).ToString("0.00");
        //                    x = 0;
        //                    break;
        //                default:
        //                    x = 0;
        //                    break;

        //            }
        //        }
        //    }
        }

        //else
        //{
        //    lbl_num.Text = "0";
        //}

        dsAfinidadeMedia.Dispose();

        Afinidade Afinidade = new Afinidade();
        filtro = CriaFiltro(Afinidade);
        DataSet dsAfinidade = Afinidade.Consultar();
        gvAfinidade.DataSource = dsAfinidade;
        gvAfinidade.DataBind();
        dsAfinidade.Dispose();
        Dispose();

        dvFiltro.Visible = false;
        dvAfinidade.Visible = true;
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
        DataSet dsAfinidade = Afinidade.Consultar();

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

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void cbo_maq_tip_id_OnSelectedIndexChanged(Object sender, EventArgs e)
    {
        cbo_maq_id.Items.Clear();
        cbo_maq_id.Items.Insert(0, "");
        cbo_maq_id.AppendDataBoundItems = true;

        Maquina Maquina = new Maquina();
        if (cbo_maq_tip_id.SelectedValue != "")
        {
            Maquina.MAQ_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
        }
        DataSet dtMaquina = Maquina.Consultar();

        cbo_maq_id.DataTextField = "MAQ_DES";
        cbo_maq_id.DataValueField = "MAQ_ID";

        cbo_maq_id.DataSource = dtMaquina;
        cbo_maq_id.DataBind();

        dtMaquina.Dispose();
        Dispose();

    }

    protected void CarregaMaquina()
    {
        cbo_maq_id.Items.Clear();
        cbo_maq_id.Items.Insert(0, "");
        cbo_maq_id.AppendDataBoundItems = true;

        Maquina Maquina = new Maquina();
        Maquina.MAQ_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
        DataSet dtMaquina = Maquina.Consultar();

        cbo_maq_id.DataTextField = "MAQ_DES";
        cbo_maq_id.DataValueField = "MAQ_ID";

        cbo_maq_id.DataSource = dtMaquina;
        cbo_maq_id.DataBind();

        dtMaquina.Dispose();
        Dispose();

    }

    protected void ApresentaTipo()
    {
        if (cbo_tip_rel.SelectedValue == "")
            return;

        if (cbo_tip_rel.SelectedValue == "1")
        {
            //td_clo.Visible = true;
            //td_clo_med.Visible = true;
            //td_clo_dsv.Visible = true;
            //td_clo_min.Visible = true;
            //td_clo_max.Visible = true;
            gvAfinidade.Columns[8].Visible = true;

            td_esu.Visible = true;
            td_esu_med.Visible = true;
            td_esu_dsv.Visible = true;
            td_esu_min.Visible = true;
            td_esu_max.Visible = true;
            gvAfinidade.Columns[9].Visible = true;

            td_tmt.Visible = true;
            td_tmt_med.Visible = true;
            td_tmt_dsv.Visible = true;
            td_tmt_min.Visible = true;
            td_tmt_max.Visible = true;
            gvAfinidade.Columns[10].Visible = true;

            //td_pmt.Visible = true;
            //td_pmt_med.Visible = true;
            //td_pmt_dsv.Visible = true;
            //td_pmt_min.Visible = true;
            //td_pmt_max.Visible = true;
            //gvAfinidade.Columns[11].Visible = true;

            //td_ppf.Visible = true;
            //td_ppf_med.Visible = true;
            //td_ppf_dsv.Visible = true;
            //td_ppf_min.Visible = true;
            //td_ppf_max.Visible = true;
            //gvAfinidade.Columns[12].Visible = true;

            //td_bbb.Visible = true;
            //td_bbb_med.Visible = true;
            //td_bbb_dsv.Visible = true;
            //td_bbb_min.Visible = true;
            //td_bbb_max.Visible = true;
            //gvAfinidade.Columns[13].Visible = true;

            //td_pfe.Visible = true;
            //td_pfe_med.Visible = true;
            //td_pfe_dsv.Visible = true;
            //td_pfe_min.Visible = true;
            //td_pfe_max.Visible = true;
            //gvAfinidade.Columns[14].Visible = true;

            //td_pse.Visible = true;
            //td_pse_med.Visible = true;
            //td_pse_dsv.Visible = true;
            //td_pse_min.Visible = true;
            //td_pse_max.Visible = true;
            //gvAfinidade.Columns[15].Visible = true;

            //td_lne.Visible = false;
            //td_lne_med.Visible = false;
            //td_lne_dsv.Visible = false;
            //td_lne_min.Visible = false;
            //td_lne_max.Visible = false;
            //gvAfinidade.Columns[16].Visible = false;

            //td_lnc.Visible = false;
            //td_lnc_med.Visible = false;
            //td_lnc_dsv.Visible = false;
            //td_lnc_min.Visible = false;
            //td_lnc_max.Visible = false;
            //gvAfinidade.Columns[17].Visible = false;

            //td_esl.Visible = false;
            //td_esl_med.Visible = false;
            //td_esl_dsv.Visible = false;
            //td_esl_min.Visible = false;
            //td_esl_max.Visible = false;
            //gvAfinidade.Columns[18].Visible = false;

        }
        else
        {
            td_clo.Visible = false;
            td_clo_med.Visible = false;
            //td_clo_dsv.Visible = false;
            //td_clo_min.Visible = false;
            //td_clo_max.Visible = false;
            gvAfinidade.Columns[8].Visible = false;

            td_esu.Visible = false;
            td_esu_med.Visible = false;
            //td_esu_dsv.Visible = false;
            //td_esu_min.Visible = false;
            //td_esu_max.Visible = false;
            gvAfinidade.Columns[9].Visible = false;

            td_tmt.Visible = false;
            td_tmt_med.Visible = false;
            //td_tmt_dsv.Visible = false;
            //td_tmt_min.Visible = false;
            //td_tmt_max.Visible = false;
            gvAfinidade.Columns[10].Visible = false;

            td_pmt.Visible = false;
            td_pmt_med.Visible = false;
            //td_pmt_dsv.Visible = false;
            //td_pmt_min.Visible = false;
            //td_pmt_max.Visible = false;
            gvAfinidade.Columns[11].Visible = false;

            td_ppf.Visible = false;
            td_ppf_med.Visible = false;
            //td_ppf_dsv.Visible = false;
            //td_ppf_min.Visible = false;
            //td_ppf_max.Visible = false;
            //gvAfinidade.Columns[12].Visible = false;

            td_bbb.Visible = false;
            td_bbb_med.Visible = false;
            //td_bbb_dsv.Visible = false;
            //td_bbb_min.Visible = false;
            //td_bbb_max.Visible = false;
            //gvAfinidade.Columns[13].Visible = false;

            td_pfe.Visible = false;
            td_pfe_med.Visible = false;
            //td_pfe_dsv.Visible = false;
            //td_pfe_min.Visible = false;
            //td_pfe_max.Visible = false;
            //gvAfinidade.Columns[14].Visible = false;

            td_pse.Visible = false;
            td_pse_med.Visible = false;
            //td_pse_dsv.Visible = false;
            //td_pse_min.Visible = false;
            //td_pse_max.Visible = false;
            //gvAfinidade.Columns[15].Visible = false;

            td_lne.Visible = true;
            td_lne_med.Visible = true;
            //td_lne_dsv.Visible = true;
            //td_lne_min.Visible = true;
            //td_lne_max.Visible = true;
            //gvAfinidade.Columns[16].Visible = true;

            td_lnc.Visible = true;
            td_lnc_med.Visible = true;
            //td_lnc_dsv.Visible = true;
            //td_lnc_min.Visible = true;
            //td_lnc_max.Visible = true;
            //gvAfinidade.Columns[17].Visible = true;

            td_esl.Visible = true;
            td_esl_med.Visible = true;
            //td_esl_dsv.Visible = true;
            //td_esl_min.Visible = true;
            //td_esl_max.Visible = true;
            //gvAfinidade.Columns[18].Visible = true;

        }
    }

    protected void CarregaLote(object sender, EventArgs e)
    {
        Afinidade Afinidade = new Afinidade();

        if (!string.IsNullOrEmpty(txt_lot.Text))
        {
            Afinidade.AFN_LOT = txt_lot.Text;
            DataSet dsAfinidade = Afinidade.ConsultarLote();
            if (dsAfinidade.Tables[0].Rows.Count > 0)
            {
                //txt_lot.Text = dsAfinidade.Tables[0].Rows[0]["AFN_LOT"].ToString();
                cbo_tit_poy_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIT_POY_ID"].ToString();
                cbo_tip.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_TIP"].ToString();
                txt_mge_001.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_001"].ToString();
                txt_mge_002.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_002"].ToString();
                txt_mge_003.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_003"].ToString();
                txt_mge_004.Text = dsAfinidade.Tables[0].Rows[0]["AFN_MGE_004"].ToString();
                cbo_for_001_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_001_ID"].ToString();
                cbo_for_002_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_002_ID"].ToString();
                cbo_for_003_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_003_ID"].ToString();
                cbo_for_004_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_FOR_004_ID"].ToString();
                txt_vlc.Text = dsAfinidade.Tables[0].Rows[0]["AFN_VLC"].ToString();
                cbo_aps_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_APS_ID"].ToString();//AFN_APS_ID
                cbo_ert_id.SelectedValue = dsAfinidade.Tables[0].Rows[0]["AFN_ERT_ID"].ToString();
            }
            else
            {
                cbo_tit_poy_id.SelectedIndex = 0;
                cbo_tip.SelectedIndex = 0;
                txt_mge_001.Text = "";
                txt_mge_002.Text = "";
                txt_mge_003.Text = "";
                txt_mge_004.Text = "";
                cbo_for_001_id.SelectedIndex = 0;
                cbo_for_002_id.SelectedIndex = 0;
                cbo_for_003_id.SelectedIndex = 0;
                cbo_for_004_id.SelectedIndex = 0;
                txt_vlc.Text = "";
                cbo_aps_id.SelectedIndex = 0;
                cbo_ert_id.SelectedIndex = 0;
            }
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
    }

    protected void txt_lot_TextChanged(object sender, EventArgs e)
    {
        CarregaLote(sender, e);
    }

  }