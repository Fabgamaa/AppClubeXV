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

using System.Web.UI.DataVisualization.Charting;
using MathNet.Numerics.Distributions;
 
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
        txt_lot.Focus();
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel);
        dsTitulo.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_rel);
        dsApresentacao.Dispose();

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

    protected string CriaFiltro(Analise Analise)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Analise.ANS_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Analise.ANS_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Analise.ANS_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_id.Text))
        {
            Analise.ANS_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id.Text))
        {
            Analise.ANS_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Analise.ANS_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected string CriaFiltroStandard(Standard Standard)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Standard.EPF_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Standard.EPF_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_id.Text))
        {
            //Verificar se será usado MAQ ou MAQ_TIP
            //Standard.EPF_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
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

        Analise AnaliseMediaDetalhe = new Analise();
        filtro = CriaFiltro(AnaliseMediaDetalhe);
        DataSet dsAnaliseMediaDetalhe = AnaliseMediaDetalhe.ConsultarMediaDetalhe();
        if (dsAnaliseMediaDetalhe.Tables[0].Rows.Count > 0)
        {
            txt_lot_rel.Text = dsAnaliseMediaDetalhe.Tables[0].Rows[0]["ANS_LOT"].ToString();
            cbo_tit_poy_id_rel.SelectedValue = dsAnaliseMediaDetalhe.Tables[0].Rows[0]["ANS_TIT_POY_ID"].ToString();
            cbo_aps_id_rel.SelectedValue = dsAnaliseMediaDetalhe.Tables[0].Rows[0]["ANS_APS_ID"].ToString();
            cbo_maq_id_rel.SelectedValue = dsAnaliseMediaDetalhe.Tables[0].Rows[0]["ANS_MAQ_ID"].ToString();
            cbo_ert_id_rel.SelectedValue = dsAnaliseMediaDetalhe.Tables[0].Rows[0]["ANS_ERT_ID"].ToString();
        }

        Analise AnaliseMediaAgrupada = new Analise();
        filtro = CriaFiltro(AnaliseMediaAgrupada);
        //DataSet dsAnaliseMediaAgrupada = AnaliseMediaAgrupada.ConsultarMediaAgrupada();
        //MAP01022012
        //Só temos o método média devido a restruturação da tabela
        DataSet dsAnaliseMediaAgrupada = AnaliseMediaAgrupada.ConsultarMedia();
        if ((dsAnaliseMediaAgrupada.Tables[0].Rows.Count > 0) && (dsAnaliseMediaAgrupada.Tables[0].Rows[0]["NUM"].ToString() != "0"))
        {
            lbl_med_num.Text = dsAnaliseMediaAgrupada.Tables[0].Rows[0]["NUM"].ToString();

            CarregaMediaAgrupada(dsAnaliseMediaAgrupada);
            CarregaDesvioAgrupada(dsAnaliseMediaAgrupada);
        }
        dsAnaliseMediaAgrupada.Dispose();

        Analise AnaliseMedia = new Analise();
        filtro = CriaFiltro(AnaliseMedia);
        DataSet dsAnaliseMedia = AnaliseMedia.ConsultarMedia();
        if ((dsAnaliseMedia.Tables[0].Rows.Count > 0) && (dsAnaliseMedia.Tables[0].Rows[0]["NUM"].ToString() != "0"))
        {
            CarregaMedia(dsAnaliseMedia);
            CarregaDesvio();
        }
        dsAnaliseMedia.Dispose();

        Standard StandardMedia = new Standard();
        filtro = CriaFiltroStandard(StandardMedia);
        DataSet dsStandardMedia = StandardMedia.MediaStandard();
        if ((dsStandardMedia.Tables[0].Rows.Count > 0) && (dsStandardMedia.Tables[0].Rows[0]["NUM"].ToString() != "0"))
        {
            CarregaStandardMedia(dsStandardMedia);
            CarregaStandardDesvio();
        }
        dsStandardMedia.Dispose();

        CarregaGraficoMedia(dsAnaliseMediaDetalhe);
        CarregaGraficoDesvio(dsAnaliseMediaDetalhe);

        dsAnaliseMediaDetalhe.Dispose();
        Dispose();

        dvFiltro.Visible = false;
        dvResultado.Visible = true;
    }

    protected void CarregaMedia(DataSet dsAnaliseMedia)
    {
        string sTipo = cbo_tip.SelectedValue;
        string filtro = "";

        lbl_med_pcs_med.Text = Convert.ToDouble(dsAnaliseMedia.Tables[0].Rows[0][sTipo + "_MED"].ToString()).ToString("0.000");
        lbl_med_pcs_ini.Text = (Convert.ToDouble(lbl_med_pcs_med.Text) - Convert.ToDouble(lbl_dsv_pcs_med.Text) * 2.6590).ToString("0.000");
        lbl_med_pcs_fim.Text = (Convert.ToDouble(lbl_med_pcs_med.Text) + Convert.ToDouble(lbl_dsv_pcs_med.Text) * 2.6590).ToString("0.000");

        Analise AnaliseForaLimiteInferior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteInferior.ANS_TIT_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "TNC":
                AnaliseForaLimiteInferior.ANS_TNC_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "AON":
                AnaliseForaLimiteInferior.ANS_AON_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "ENM":
                AnaliseForaLimiteInferior.ANS_ENM_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "EEE":
                AnaliseForaLimiteInferior.ANS_EEE_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "KKK":
                AnaliseForaLimiteInferior.ANS_KKK_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "BBB":
                AnaliseForaLimiteInferior.ANS_BBB_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "PUE":
                AnaliseForaLimiteInferior.ANS_PUE_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "OLE":
                AnaliseForaLimiteInferior.ANS_OLE_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteInferior.ANS_TRQ_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "ERT":
                AnaliseForaLimiteInferior.ANS_ERT_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "RT3":
                AnaliseForaLimiteInferior.ANS_RT3_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "RT5":
                AnaliseForaLimiteInferior.ANS_RT5_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "PES":
                AnaliseForaLimiteInferior.ANS_PES_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "DMO":
                AnaliseForaLimiteInferior.ANS_DMO_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
            case "DND":
                AnaliseForaLimiteInferior.ANS_DND_INF = Convert.ToDouble(lbl_med_pcs_ini.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteInferior);
        AnaliseForaLimiteInferior.ANS_MED = "S"; //Consultar Média
        DataSet dsAnaliseForaLimiteInferior = AnaliseForaLimiteInferior.ConsultarForaLimites();
        lbl_med_pcs_lic.Text = "0,000";
        if (dsAnaliseForaLimiteInferior.Tables[0].Rows.Count > 0)
        {
            lbl_med_pcs_lic.Text = (Convert.ToDouble(dsAnaliseForaLimiteInferior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text) * 100).ToString("0.000");
        }
        dsAnaliseForaLimiteInferior.Dispose();

        Analise AnaliseForaLimiteSuperior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteSuperior.ANS_TIT_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "TNC":
                AnaliseForaLimiteSuperior.ANS_TNC_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "AON":
                AnaliseForaLimiteSuperior.ANS_AON_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "ENM":
                AnaliseForaLimiteSuperior.ANS_ENM_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "EEE":
                AnaliseForaLimiteSuperior.ANS_EEE_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "KKK":
                AnaliseForaLimiteSuperior.ANS_KKK_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "BBB":
                AnaliseForaLimiteSuperior.ANS_BBB_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "PUE":
                AnaliseForaLimiteSuperior.ANS_PUE_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "OLE":
                AnaliseForaLimiteSuperior.ANS_OLE_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteSuperior.ANS_TRQ_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "ERT":
                AnaliseForaLimiteSuperior.ANS_ERT_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "RT3":
                AnaliseForaLimiteSuperior.ANS_RT3_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "RT5":
                AnaliseForaLimiteSuperior.ANS_RT5_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "PES":
                AnaliseForaLimiteSuperior.ANS_PES_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "DMO":
                AnaliseForaLimiteSuperior.ANS_DMO_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
            case "DND":
                AnaliseForaLimiteSuperior.ANS_DND_SUP = Convert.ToDouble(lbl_med_pcs_fim.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteSuperior);
        AnaliseForaLimiteSuperior.ANS_MED = "S"; //Consultar Média
        DataSet dsAnaliseForaLimiteSuperior = AnaliseForaLimiteSuperior.ConsultarForaLimites();
        if (dsAnaliseForaLimiteSuperior.Tables[0].Rows.Count > 0)
        {
            lbl_med_pcs_lsc.Text = (Convert.ToDouble(dsAnaliseForaLimiteSuperior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text) * 100).ToString("0.000");
        }
        dsAnaliseForaLimiteSuperior.Dispose();

        if (Convert.ToDouble(lbl_med_pcs_dsv.Text) > 0)
        {
            lbl_med_pcs_teo_lic.Text = (NORMDIST(Convert.ToDouble(lbl_med_pcs_ini.Text), Convert.ToDouble(lbl_med_pcs_med.Text), Convert.ToDouble(lbl_med_pcs_dsv.Text), true) * 100).ToString("0.000");
            lbl_med_pcs_teo_lsc.Text = (Math.Abs(1 - NORMDIST(Convert.ToDouble(lbl_med_pcs_fim.Text), Convert.ToDouble(lbl_med_pcs_med.Text), Convert.ToDouble(lbl_med_pcs_dsv.Text), true)) * 100).ToString("0.000");
        }
        else
        {
            lbl_med_pcs_teo_lic.Text = "0,000";
            lbl_med_pcs_teo_lsc.Text = "0,000";
        }
    }

    protected void CarregaDesvio()
    {
        string sTipo = cbo_tip.SelectedValue;
        string filtro = "";

        Analise AnaliseForaLimiteSuperior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteSuperior.ANS_TIT_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "TNC":
                AnaliseForaLimiteSuperior.ANS_TNC_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "AON":
                AnaliseForaLimiteSuperior.ANS_AON_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "ENM":
                AnaliseForaLimiteSuperior.ANS_ENM_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "EEE":
                AnaliseForaLimiteSuperior.ANS_EEE_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "KKK":
                AnaliseForaLimiteSuperior.ANS_KKK_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "BBB":
                AnaliseForaLimiteSuperior.ANS_BBB_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "PUE":
                AnaliseForaLimiteSuperior.ANS_PUE_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "OLE":
                AnaliseForaLimiteSuperior.ANS_OLE_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteSuperior.ANS_TRQ_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "ERT":
                AnaliseForaLimiteSuperior.ANS_ERT_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "RT3":
                AnaliseForaLimiteSuperior.ANS_RT3_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "RT5":
                AnaliseForaLimiteSuperior.ANS_RT5_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "PES":
                AnaliseForaLimiteSuperior.ANS_PES_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "DMO":
                AnaliseForaLimiteSuperior.ANS_DMO_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
            case "DND":
                AnaliseForaLimiteSuperior.ANS_DND_SUP = Convert.ToDouble(lbl_dsv_pcs_fim.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteSuperior);
        AnaliseForaLimiteSuperior.ANS_MED = "N"; //Consultar Desvio
        DataSet dsAnaliseForaLimiteSuperior = AnaliseForaLimiteSuperior.ConsultarForaLimites();
        lbl_dsv_pcs_lsc.Text = "0,000";
        if (dsAnaliseForaLimiteSuperior.Tables[0].Rows.Count > 0)
        {
            // Dividir pelo Total ou só pela quantidade de desvios que são diferentes da média de desvios? (lbl_dsv_pcs_med)
            // Está dividindo por todos, para fazer pelos diferentes criar ANS_TIT = , ANS_TNC = e etc... em vez de >< no ConsultarForaLimites
            lbl_dsv_pcs_lsc.Text = (Convert.ToDouble(dsAnaliseForaLimiteSuperior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text) * 100).ToString("0.000");
        }
        dsAnaliseForaLimiteSuperior.Dispose();
        
        if (Convert.ToDouble(lbl_dsv_pcs_dsv.Text) > 0)
        {
            lbl_dsv_pcs_teo_lic.Text = "0,000";

            double dAlfa = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_med.Text), 2) / Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2));
            double dTheta = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2) / Convert.ToDouble(lbl_dsv_pcs_med.Text));

            GammaDistribution GD = new GammaDistribution();
            GD.Alpha = dAlfa;
            GD.Theta = dTheta;
            lbl_dsv_pcs_teo_lsc.Text = (Math.Abs(1 - GD.CumulativeDistribution(Convert.ToDouble(lbl_dsv_pcs_fim.Text)))).ToString("0.000");
        }
        else
        {
            lbl_dsv_pcs_teo_lsc.Text = "0,000";
        }
    }

    protected void CarregaMediaAgrupada(DataSet dsAnaliseMediaAgrupada)
    {
        string sTipo = cbo_tip.SelectedValue;

        lbl_med_pcs_dsv.Text = Convert.ToDouble(dsAnaliseMediaAgrupada.Tables[0].Rows[0][sTipo + "_MED_DSV"].ToString()).ToString("0.000");
    }

    protected void CarregaDesvioAgrupada(DataSet dsAnaliseMediaAgrupada)
    {
        string sTipo = cbo_tip.SelectedValue;

        lbl_dsv_pcs_med.Text = Convert.ToDouble(dsAnaliseMediaAgrupada.Tables[0].Rows[0][sTipo + "_DSV_AVG"].ToString()).ToString("0.000");
        lbl_dsv_pcs_dsv.Text = Convert.ToDouble(dsAnaliseMediaAgrupada.Tables[0].Rows[0][sTipo + "_DSV"].ToString()).ToString("0.000");

        lbl_dsv_pcs_ini.Text = (Convert.ToDouble(lbl_dsv_pcs_med.Text) * 0).ToString("0.000");
        lbl_dsv_pcs_fim.Text = (Convert.ToDouble(lbl_dsv_pcs_med.Text) * 3.267).ToString("0.000");
    }

    protected void CarregaStandardMedia(DataSet dsStandardMedia)
    {
        string filtro = "";
        string sTipo = cbo_tip.SelectedValue;

        //Consulta a Média sem Lote
        Analise AnaliseMediaAgrupada = new Analise();
        AnaliseMediaAgrupada.ANS_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_rel.SelectedValue);
        AnaliseMediaAgrupada.ANS_APS_ID = Convert.ToInt32(cbo_aps_id_rel.SelectedValue);
        AnaliseMediaAgrupada.ANS_MAQ_ID = Convert.ToInt32(cbo_maq_id_rel.SelectedValue);
        AnaliseMediaAgrupada.ANS_ERT_ID = Convert.ToInt32(cbo_ert_id_rel.SelectedValue);
        //DataSet dsAnaliseMediaAgrupada = AnaliseMediaAgrupada.ConsultarMediaAgrupada();
        //MAP01022012
        //Só temos o método média devido a restruturação da tabela
        DataSet dsAnaliseMediaAgrupada = AnaliseMediaAgrupada.ConsultarMedia();
        if ((dsAnaliseMediaAgrupada.Tables[0].Rows.Count > 0) && (dsAnaliseMediaAgrupada.Tables[0].Rows[0]["NUM"].ToString() != "0"))
        {
            lbl_med_epf_med.Text = Convert.ToDouble(dsAnaliseMediaAgrupada.Tables[0].Rows[0][sTipo + "_MED"].ToString()).ToString("0.000");
            lbl_med_epf_dsv.Text = Convert.ToDouble(dsAnaliseMediaAgrupada.Tables[0].Rows[0][sTipo + "_MED_DSV"].ToString()).ToString("0.000");
        }
        else
        {
            lbl_med_epf_med.Text = "0,000";
            lbl_med_epf_dsv.Text = "0,000";
        }
        dsAnaliseMediaAgrupada.Dispose();

        if (!string.IsNullOrEmpty(dsStandardMedia.Tables[0].Rows[0]["MIN_" + sTipo].ToString()))
        {
            lbl_med_epf_ini.Text = Convert.ToDouble(dsStandardMedia.Tables[0].Rows[0]["MIN_" + sTipo].ToString()).ToString("0.0");
        }
        else
        {
            lbl_med_epf_ini.Text = "0,0";
        }
        if (!string.IsNullOrEmpty(dsStandardMedia.Tables[0].Rows[0]["MAX_" + sTipo].ToString()))
        {
            lbl_med_epf_fim.Text = Convert.ToDouble(dsStandardMedia.Tables[0].Rows[0]["MAX_" + sTipo].ToString()).ToString("0.0");
        }
        else
        {
            lbl_med_epf_fim.Text = "0,0";
        }

        Analise AnaliseForaLimiteInferior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteInferior.ANS_TIT_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "TNC":
                AnaliseForaLimiteInferior.ANS_TNC_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "AON":
                AnaliseForaLimiteInferior.ANS_AON_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "ENM":
                AnaliseForaLimiteInferior.ANS_ENM_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "EEE":
                AnaliseForaLimiteInferior.ANS_EEE_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "KKK":
                AnaliseForaLimiteInferior.ANS_KKK_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "BBB":
                AnaliseForaLimiteInferior.ANS_BBB_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "PUE":
                AnaliseForaLimiteInferior.ANS_PUE_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "OLE":
                AnaliseForaLimiteInferior.ANS_OLE_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteInferior.ANS_TRQ_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "ERT":
                AnaliseForaLimiteInferior.ANS_ERT_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "RT3":
                AnaliseForaLimiteInferior.ANS_RT3_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "RT5":
                AnaliseForaLimiteInferior.ANS_RT5_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "PES":
                AnaliseForaLimiteInferior.ANS_PES_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "DMO":
                AnaliseForaLimiteInferior.ANS_DMO_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
            case "DND":
                AnaliseForaLimiteInferior.ANS_DND_INF = Convert.ToDouble(lbl_med_epf_ini.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteInferior);
        AnaliseForaLimiteInferior.ANS_MED = "S"; //Consultar Média
        DataSet dsAnaliseForaLimiteInferior = AnaliseForaLimiteInferior.ConsultarForaLimites();
        lbl_med_epf_lic.Text = "0,000";
        if (dsAnaliseForaLimiteInferior.Tables[0].Rows.Count > 0)
        {
            lbl_med_epf_lic.Text = (Convert.ToDouble(dsAnaliseForaLimiteInferior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text)).ToString("0.000");
        }
        dsAnaliseForaLimiteInferior.Dispose();

        Analise AnaliseForaLimiteSuperior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteSuperior.ANS_TIT_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "TNC":
                AnaliseForaLimiteSuperior.ANS_TNC_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "AON":
                AnaliseForaLimiteSuperior.ANS_AON_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "ENM":
                AnaliseForaLimiteSuperior.ANS_ENM_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "EEE":
                AnaliseForaLimiteSuperior.ANS_EEE_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "KKK":
                AnaliseForaLimiteSuperior.ANS_KKK_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "BBB":
                AnaliseForaLimiteSuperior.ANS_BBB_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "PUE":
                AnaliseForaLimiteSuperior.ANS_PUE_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "OLE":
                AnaliseForaLimiteSuperior.ANS_OLE_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteSuperior.ANS_TRQ_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "ERT":
                AnaliseForaLimiteSuperior.ANS_ERT_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "RT3":
                AnaliseForaLimiteSuperior.ANS_RT3_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "RT5":
                AnaliseForaLimiteSuperior.ANS_RT5_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "PES":
                AnaliseForaLimiteSuperior.ANS_PES_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "DMO":
                AnaliseForaLimiteSuperior.ANS_DMO_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
            case "DND":
                AnaliseForaLimiteSuperior.ANS_DND_SUP = Convert.ToDouble(lbl_med_epf_fim.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteSuperior);
        AnaliseForaLimiteSuperior.ANS_MED = "S"; //Consultar Média
        DataSet dsAnaliseForaLimiteSuperior = AnaliseForaLimiteSuperior.ConsultarForaLimites();
        lbl_med_epf_lsc.Text = "0,000";
        if (dsAnaliseForaLimiteSuperior.Tables[0].Rows.Count > 0)
        {
            lbl_med_epf_lsc.Text = (Convert.ToDouble(dsAnaliseForaLimiteSuperior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text)).ToString("0.000");
        }
        dsAnaliseForaLimiteSuperior.Dispose();

        if (Convert.ToDouble(lbl_med_pcs_dsv.Text) > 0)
        {
            lbl_med_epf_teo_lic.Text = (NORMDIST(Convert.ToDouble(lbl_med_epf_ini.Text), Convert.ToDouble(lbl_med_pcs_med.Text), Convert.ToDouble(lbl_med_pcs_dsv.Text), true) * 100).ToString("0.000");
            lbl_med_epf_teo_lsc.Text = (Math.Abs(1 - NORMDIST(Convert.ToDouble(lbl_med_epf_fim.Text), Convert.ToDouble(lbl_med_pcs_med.Text), Convert.ToDouble(lbl_med_pcs_dsv.Text), true)) * 100).ToString("0.000");
        }
        else
        {
            lbl_med_epf_teo_lic.Text = "0,000";
            lbl_med_epf_teo_lsc.Text = "0,000";
        }
    }

    protected void CarregaStandardDesvio()
    {
        string filtro = "";
        string sTipo = cbo_tip.SelectedValue;

        lbl_dsv_epf_ini.Text = (Convert.ToDouble(lbl_med_epf_med.Text) - Convert.ToDouble(lbl_med_epf_ini.Text)).ToString("0.000");

        Analise AnaliseForaLimiteSuperior = new Analise();
        switch (sTipo)
        {
            case "TIT":
                AnaliseForaLimiteSuperior.ANS_TIT_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "TNC":
                AnaliseForaLimiteSuperior.ANS_TNC_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "AON":
                AnaliseForaLimiteSuperior.ANS_AON_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "ENM":
                AnaliseForaLimiteSuperior.ANS_ENM_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "EEE":
                AnaliseForaLimiteSuperior.ANS_EEE_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "KKK":
                AnaliseForaLimiteSuperior.ANS_KKK_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "BBB":
                AnaliseForaLimiteSuperior.ANS_BBB_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "PUE":
                AnaliseForaLimiteSuperior.ANS_PUE_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "OLE":
                AnaliseForaLimiteSuperior.ANS_OLE_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "TRQ":
                AnaliseForaLimiteSuperior.ANS_TRQ_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "ERT":
                AnaliseForaLimiteSuperior.ANS_ERT_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "RT3":
                AnaliseForaLimiteSuperior.ANS_RT3_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "RT5":
                AnaliseForaLimiteSuperior.ANS_RT5_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "PES":
                AnaliseForaLimiteSuperior.ANS_PES_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "DMO":
                AnaliseForaLimiteSuperior.ANS_DMO_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
            case "DND":
                AnaliseForaLimiteSuperior.ANS_DND_SUP = Convert.ToDouble(lbl_dsv_epf_ini.Text);
                break;
        }
        filtro = CriaFiltro(AnaliseForaLimiteSuperior);
        AnaliseForaLimiteSuperior.ANS_MED = "N"; //Consultar Desvio
        DataSet dsAnaliseForaLimiteSuperior = AnaliseForaLimiteSuperior.ConsultarForaLimites();
        if (dsAnaliseForaLimiteSuperior.Tables[0].Rows.Count > 0)
        {
            // Dividir pelo Total ou só pela quantidade de desvios que são diferentes da média de desvios? (lbl_dsv_pcs_med)
            // Está dividindo por todos, para fazer pelos diferentes criar ANS_TIT = , ANS_TNC = e etc... em vez de >< no ConsultarForaLimites
            lbl_dsv_epf_lsc.Text = (Convert.ToDouble(dsAnaliseForaLimiteSuperior.Tables[0].Rows[0]["NUM"].ToString()) / Convert.ToDouble(lbl_med_num.Text) * 100).ToString("0.000");
        }
        dsAnaliseForaLimiteSuperior.Dispose();

        double dAlfa = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_med.Text), 2) / Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2));
        double dTheta = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2) / Convert.ToDouble(lbl_dsv_pcs_med.Text));

        GammaDistribution GD = new GammaDistribution();
        GD.Alpha = dAlfa;
        GD.Theta = dTheta;
        lbl_dsv_epf_teo_lsc.Text = (Math.Abs(1 - GD.CumulativeDistribution(Convert.ToDouble(lbl_dsv_epf_ini.Text)))).ToString("0.000");
    }

    protected void CarregaGraficoMedia(DataSet dsAnaliseMediaDetalhe)
    {
        if ((lbl_med_pcs_ini.Text != "") && (lbl_med_epf_ini.Text != ""))
        {
            //Gráfico Média
            for (int i = 0; i < dsAnaliseMediaDetalhe.Tables[0].Rows.Count; i++)
            {
                DateTime dtData = Convert.ToDateTime(dsAnaliseMediaDetalhe.Tables[0].Rows[i]["ANS_DAT"].ToString());
                if (!string.IsNullOrEmpty(dsAnaliseMediaDetalhe.Tables[0].Rows[i][cbo_tip.SelectedValue + "_MED"].ToString()))
                {
                    cht_med_lnh.Series["Medida"].Points.AddXY(dtData, Convert.ToDouble(Convert.ToDouble(dsAnaliseMediaDetalhe.Tables[0].Rows[i][cbo_tip.SelectedValue + "_MED"].ToString()).ToString("0.00")));
                }
                else
                {
                    cht_med_lnh.Series["Medida"].Points.AddXY(dtData, 0.00);
                }
                cht_med_lnh.Series["Media"].Points.AddXY(dtData, Convert.ToDouble(lbl_med_pcs_med.Text));
                cht_med_lnh.Series["LIC"].Points.AddXY(dtData, Convert.ToDouble(lbl_med_pcs_ini.Text));
                cht_med_lnh.Series["LSC"].Points.AddXY(dtData, Convert.ToDouble(lbl_med_pcs_fim.Text));
                cht_med_lnh.Series["LIE"].Points.AddXY(dtData, Convert.ToDouble(lbl_med_epf_ini.Text));
                cht_med_lnh.Series["LSE"].Points.AddXY(dtData, Convert.ToDouble(lbl_med_epf_fim.Text));
            }

            //Gráfico Distribuição
            double dMedia = Convert.ToDouble(lbl_med_pcs_med.Text);
            double dDesvio = Convert.ToDouble(lbl_med_pcs_dsv.Text);
            double dEscala = 0;
            double dValor = 0;
            double dDistribuicao = 0;
            double dDistribuicaoMaxima = 0;
            // Distribuição Normal
            for (int i = 0; i < 29; i++)
            {
                dEscala = 0.4 * (i - 14);

                dValor = dMedia + dEscala * dDesvio;
                dDistribuicao = NORMDIST(dValor, dMedia, dDesvio, false);
                cht_med_bar.Series["Distribuicao"].Points.AddXY(Convert.ToDouble(dValor.ToString("0.000")), Convert.ToDouble(dDistribuicao.ToString("0.000000")));
                //Response.Write(dValor.ToString("0.0") + ";" + dDistribuicao.ToString("0.00") + "<br/>");

                if (dDistribuicaoMaxima < dDistribuicao)
                {
                    dDistribuicaoMaxima = dDistribuicao;
                }
            }

            // LE
            cht_med_bar.Series["LIE"].Points.AddXY(Convert.ToDouble(Convert.ToDouble(lbl_med_epf_ini.Text).ToString("0.000")), Convert.ToDouble(dDistribuicaoMaxima.ToString("0.000000")));
            cht_med_bar.Series["LSE"].Points.AddXY(Convert.ToDouble(Convert.ToDouble(lbl_med_epf_fim.Text).ToString("0.000")), Convert.ToDouble(dDistribuicaoMaxima.ToString("0.000000")));

            // Histograma
            cht_med_bar.Series["Histograma"]["PointWidth"] = "3";
            for (int i = 0; i < 29; i++)
            {
                //Response.Write(cht_med_bar.Series["Distribuicao"].Points[i].XValue + ";");
                if ((i == 0) || (i == 28))
                {
                    //Response.Write("[" + cht_med_bar.Series["Distribuicao"].Points[i].XValue + ";0]");
                    cht_med_bar.Series["Histograma"].Points.AddXY(cht_med_bar.Series["Distribuicao"].Points[i].XValue, 0);
                }
                else
                {
                    int iInicial = (((i - 1) / 3) * 3) + 1;
                    int iFinal = (((i - 1) / 3) * 3) + 4;
                    double dMedida = 0;
                    int iCount = 0;
                    for (int j = 0; j < dsAnaliseMediaDetalhe.Tables[0].Rows.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(dsAnaliseMediaDetalhe.Tables[0].Rows[j][cbo_tip.SelectedValue + "_MED"].ToString()))
                        {
                            dMedida = Convert.ToDouble(Convert.ToDouble(dsAnaliseMediaDetalhe.Tables[0].Rows[j][cbo_tip.SelectedValue + "_MED"].ToString()).ToString("0.00"));
                        }
                        else
                        {
                            dMedia = 0.00;
                        }
                        if ((dMedida > Convert.ToDouble(cht_med_bar.Series["Distribuicao"].Points[iInicial].XValue)) && (dMedida <= Convert.ToDouble(cht_med_bar.Series["Distribuicao"].Points[iFinal].XValue)))
                        {
                            iCount = iCount + 1;
                            //Response.Write(i + ";" + j + ";" + iInicial + ";" + iFinal + ";" + iCount + "; " + dMedida + "; " + cht_med_bar.Series["Distribuicao"].Points[iInicial].XValue + "; " + cht_med_bar.Series["Distribuicao"].Points[iFinal].XValue + ";<br/>");
                        }
                    }
                    
                    cht_med_bar.Series["Histograma"].Points.AddXY(cht_med_bar.Series["Distribuicao"].Points[i].XValue, iCount);
                    //Response.Write(cht_med_bar.Series["Distribuicao"].Points[i].XValue + ";" + iCount + "<br/>");
                }
            }
        }
    }

    protected void CarregaGraficoDesvio(DataSet dsAnaliseMediaDetalhe)
    {
        if ((lbl_med_pcs_ini.Text != "") && (lbl_med_epf_ini.Text != ""))
        {
            //Gráfico Média
            for (int i = 0; i < dsAnaliseMediaDetalhe.Tables[0].Rows.Count; i++)
            {
                DateTime dtData = Convert.ToDateTime(dsAnaliseMediaDetalhe.Tables[0].Rows[i]["ANS_DAT"].ToString());                
                //Response.Write(dtData + ";" + dsAnaliseMediaDetalhe.Tables[0].Rows[i][cbo_tip.SelectedValue + "_DSV"].ToString() + "<br/>");
                if (!string.IsNullOrEmpty(dsAnaliseMediaDetalhe.Tables[0].Rows[i][cbo_tip.SelectedValue + "_DSV"].ToString()))
                {
                    cht_dsv_lnh.Series["Desvio"].Points.AddXY(dtData, Convert.ToDouble(Convert.ToDouble(dsAnaliseMediaDetalhe.Tables[0].Rows[i][cbo_tip.SelectedValue + "_DSV"].ToString()).ToString("0.00")));
                }
                else
                {
                    cht_dsv_lnh.Series["Desvio"].Points.AddXY(dtData, 0.00);
                }
                cht_dsv_lnh.Series["Media"].Points.AddXY(dtData, Convert.ToDouble(lbl_dsv_pcs_med.Text));
                cht_dsv_lnh.Series["LIC"].Points.AddXY(dtData, Convert.ToDouble(lbl_dsv_pcs_ini.Text));
                cht_dsv_lnh.Series["LSC"].Points.AddXY(dtData, Convert.ToDouble(lbl_dsv_pcs_fim.Text));
                cht_dsv_lnh.Series["LSE"].Points.AddXY(dtData, Convert.ToDouble(lbl_dsv_epf_ini.Text));
            }

            //Gráfico Distribuição
            double dDesvio = Convert.ToDouble(lbl_dsv_epf_ini.Text);
            double dEscala = 0.05;
            double dValor = 0;
            double dDistribuicao = 0;
            double dDistribuicaoMaxima = 0;

            double dAlfa = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_med.Text), 2) / Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2));
            double dTheta = (Math.Pow(Convert.ToDouble(lbl_dsv_pcs_dsv.Text), 2) / Convert.ToDouble(lbl_dsv_pcs_med.Text));

            GammaDistribution GD = new GammaDistribution();
            GD.Alpha = dAlfa;
            GD.Theta = dTheta;

            // Distribuição Gama
            for (int i = 0; i < 29; i++)
            {
                if (i > 0)
                {
                    dValor = dValor + dEscala * dDesvio;
                }
                dDistribuicao = GD.ProbabilityDensity(dValor);
                cht_dsv_bar.Series["Distribuicao"].Points.AddXY(Convert.ToDouble(dValor.ToString("0.000")), Convert.ToDouble(dDistribuicao.ToString("0.000000")));
                //Response.Write(dValor.ToString("0.0") + ";" + dDistribuicao.ToString("0.00") + "<br/>");

                if (dDistribuicaoMaxima < dDistribuicao)
                {
                    dDistribuicaoMaxima = dDistribuicao;
                }
            }

            // LE
            cht_dsv_bar.Series["LSE"].Points.AddXY(Convert.ToDouble(Convert.ToDouble(lbl_dsv_epf_ini.Text).ToString("0.000")), Convert.ToDouble(dDistribuicaoMaxima.ToString("0.000000")));

            // Histograma
            cht_dsv_bar.Series["Histograma"]["PointWidth"] = "3";
            for (int i = 0; i < 29; i++)
            {
                //Response.Write(cht_dsv_bar.Series["Distribuicao"].Points[i].XValue + ";");
                if ((i == 0) || (i == 28))
                {
                    //Response.Write("[" + cht_dsv_bar.Series["Distribuicao"].Points[i].XValue + ";0]");
                    cht_dsv_bar.Series["Histograma"].Points.AddXY(cht_dsv_bar.Series["Distribuicao"].Points[i].XValue, 0);
                }
                else
                {
                    int iInicial = (((i - 1) / 3) * 3) + 0;
                    int iFinal = (((i - 1) / 3) * 3) + 3;
                    double dMedida = 0;
                    int iCount = 0;
                    for (int j = 0; j < dsAnaliseMediaDetalhe.Tables[0].Rows.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(dsAnaliseMediaDetalhe.Tables[0].Rows[j][cbo_tip.SelectedValue + "_DSV"].ToString()))
                        {
                            dMedida = Convert.ToDouble(Convert.ToDouble(dsAnaliseMediaDetalhe.Tables[0].Rows[j][cbo_tip.SelectedValue + "_DSV"].ToString()).ToString("0.00"));
                        }
                        else
                        {
                            dMedida = 0.00;
                        }
                        if ((dMedida > Convert.ToDouble(cht_dsv_bar.Series["Distribuicao"].Points[iInicial].XValue)) && (dMedida <= Convert.ToDouble(cht_dsv_bar.Series["Distribuicao"].Points[iFinal].XValue)))
                        {
                            iCount = iCount + 1;
                            //Response.Write("[" + i + ";" + j + "]; [" + iInicial + ";" + iFinal + ";" + iCount + "]; [" + dMedida + "; " + cht_dsv_bar.Series["Distribuicao"].Points[iInicial].XValue + "; " + cht_dsv_bar.Series["Distribuicao"].Points[iFinal].XValue + "];<br/>");
                        }
                    }

                    cht_dsv_bar.Series["Histograma"].Points.AddXY(cht_dsv_bar.Series["Distribuicao"].Points[i].XValue, iCount);
                    //Response.Write(cht_dsv_bar.Series["Distribuicao"].Points[i].XValue + ";" + iCount + "<br/>");
                }
            }
        }
    }
    
    protected void cbo_tip_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        btProcurar_Click(sender, e);
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }
   
    public static double NORMDIST(double x, double media, double desvio, bool Acumulativa)
    {
        if ( Acumulativa ) 
        {
            return Phi( x, media, desvio );
        } 
        else 
        {
        double tmp = 1/((Math.Sqrt(2*Math.PI)*desvio));
        return tmp * Math.Exp(-.5 * Math.Pow((x-media)/desvio,2));
        }
    }

    static double erf(double z) 
    {
        double t = 1.0 / (1.0 + 0.5 * Math.Abs(z));

        double ans = 1 - t * Math.Exp( -z*z - 1.26551223 +
        t * ( 1.00002368 +
        t * ( 0.37409196 +
        t * ( 0.09678418 +
        t * (-0.18628806 +
        t * ( 0.27886807 +
        t * (-1.13520398 +
        t * ( 1.48851587 +
        t * (-0.82215223 +
        t * ( 0.17087277))))))))));

        if (z >= 0) 
            return ans;
        else 
            return -ans;
    }

    static double Phi(double z) 
    {
        return 0.5 * (1.0 + erf(z / (Math.Sqrt(2.0))));
    }

    static double Phi(double z, double mu, double sigma) 
    {
        return Phi((z - mu) / sigma);
    }  


}