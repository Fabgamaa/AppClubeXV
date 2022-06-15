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
        txt_lot_001.Focus();
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_001);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel_001);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_002);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel_002);
        dsTitulo.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_001);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_rel_001);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_002);
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_rel_002);
        dsApresentacao.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_001);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_rel_001);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_002);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_rel_002);
        dsMaquinaTipo.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_001);
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_rel_001);
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_002);
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id_rel_002);
        dsEntrelacamento.Dispose();
    }

    protected string CriaFiltro001(Analise Analise)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_lot_001.Text))
        {
            Analise.ANS_LOT = txt_lot_001.Text;
            filtro = filtro + "Lote= " + txt_lot_001.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id_001.Text))
        {
            Analise.ANS_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_001.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id_001.Text))
        {
            Analise.ANS_APS_ID = Convert.ToInt32(cbo_aps_id_001.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id_001.Text))
        {
            Analise.MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_001.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_tip_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id_001.Text))
        {
            Analise.ANS_ERT_ID = Convert.ToInt32(cbo_ert_id_001.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts_001.Text))
        {
            Analise.ANS_STS = Convert.ToInt32(cbo_sts_001.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts_001.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected string CriaFiltro002(Analise Analise)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_lot_002.Text))
        {
            Analise.ANS_LOT = txt_lot_002.Text;
            filtro = filtro + "Lote= " + txt_lot_002.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id_002.Text))
        {
            Analise.ANS_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_002.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id_002.Text))
        {
            Analise.ANS_APS_ID = Convert.ToInt32(cbo_aps_id_002.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id_002.Text))
        {
            Analise.MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_002.SelectedValue);
            filtro = filtro + "Tipo de Máquina= " + cbo_maq_tip_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id_002.Text))
        {
            Analise.ANS_ERT_ID = Convert.ToInt32(cbo_ert_id_002.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts_002.Text))
        {
            Analise.ANS_STS = Convert.ToInt32(cbo_sts_002.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts_002.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Analise AnaliseMedia001 = new Analise();
        filtro = CriaFiltro001(AnaliseMedia001);
        DataSet dsAnaliseMedia001 = AnaliseMedia001.ConsultarMedia();

        if (dsAnaliseMedia001.Tables[0].Rows.Count > 0)
        {
            txt_lot_rel_001.Text = txt_lot_001.Text;
            cbo_tit_poy_id_rel_001.SelectedValue = cbo_tit_poy_id_001.SelectedValue;
            cbo_aps_id_rel_001.SelectedValue = cbo_aps_id_001.SelectedValue;
            cbo_maq_tip_id_rel_001.SelectedValue = cbo_maq_tip_id_001.SelectedValue;
            cbo_ert_id_rel_001.SelectedValue = cbo_ert_id_001.SelectedValue;

            lbl_num_001.Text = dsAnaliseMedia001.Tables[0].Rows[0]["NUM"].ToString();

            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MED"].ToString()))
            {
                txt_tit_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MED"].ToString()))
            {
                txt_tnc_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MED"].ToString()))
            {
                txt_aon_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MED"].ToString()))
            {
                txt_enm_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MED"].ToString()))
            {
                txt_eee_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MED"].ToString()))
            {
                txt_kkk_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MED"].ToString()))
            {
                txt_bbb_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MED"].ToString()))
            {
                txt_pue_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MED"].ToString()))
            {
                txt_ole_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MED"].ToString()))
            {
                txt_trq_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MED"].ToString()))
            {
                txt_ert_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MED"].ToString()))
            {
                txt_rt3_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MED"].ToString()))
            {
                txt_rt5_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MED"].ToString()))
            {
                txt_pes_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MED"].ToString()))
            {
                txt_dmo_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MED"].ToString()))
            {
                txt_dnd_med_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MED"].ToString()).ToString("0.0000");
            }
 
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MIN"].ToString()))
            {
                txt_tit_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MIN"].ToString()))
            {
                txt_tnc_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MIN"].ToString()))
            {
                txt_aon_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MIN"].ToString()))
            {
                txt_enm_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MIN"].ToString()))
            {
                txt_eee_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MIN"].ToString()))
            {
                txt_kkk_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MIN"].ToString()))
            {
                txt_bbb_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MIN"].ToString()))
            {
                txt_pue_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MIN"].ToString()))
            {
                txt_ole_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MIN"].ToString()))
            {
                txt_trq_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MIN"].ToString()))
            {
                txt_ert_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MIN"].ToString()))
            {
                txt_rt3_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MIN"].ToString()))
            {
                txt_rt5_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MIN"].ToString()))
            {
                txt_pes_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MIN"].ToString()))
            {
                txt_dmo_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MIN"].ToString()))
            {
                txt_dnd_min_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MIN"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MAX"].ToString()))
            {
                txt_tit_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MAX"].ToString()))
            {
                txt_tnc_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MAX"].ToString()))
            {
                txt_aon_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["AON_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MAX"].ToString()))
            {
                txt_enm_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MAX"].ToString()))
            {
                txt_eee_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MAX"].ToString()))
            {
                txt_kkk_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MAX"].ToString()))
            {
                txt_bbb_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MAX"].ToString()))
            {
                txt_pue_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MAX"].ToString()))
            {
                txt_ole_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MAX"].ToString()))
            {
                txt_trq_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MAX"].ToString()))
            {
                txt_ert_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MAX"].ToString()))
            {
                txt_rt3_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MAX"].ToString()))
            {
                txt_rt5_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MAX"].ToString()))
            {
                txt_pes_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PES_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MAX"].ToString()))
            {
                txt_dmo_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MAX"].ToString()))
            {
                txt_dnd_max_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DND_MAX"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_DSV"].ToString()))
            {
                txt_tit_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TIT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_DSV"].ToString()))
            {
                txt_tnc_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TNC_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["AON_DSV"].ToString()))
            {
                txt_aon_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["AON_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_DSV"].ToString()))
            {
                txt_enm_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ENM_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_DSV"].ToString()))
            {
                txt_eee_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["EEE_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_DSV"].ToString()))
            {
                txt_kkk_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["KKK_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_DSV"].ToString()))
            {
                txt_bbb_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["BBB_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_DSV"].ToString()))
            {
                txt_pue_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PUE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_DSV"].ToString()))
            {
                txt_ole_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["OLE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_DSV"].ToString()))
            {
                txt_trq_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["TRQ_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_DSV"].ToString()))
            {
                txt_ert_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["ERT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_DSV"].ToString()))
            {
                txt_rt3_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT3_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_DSV"].ToString()))
            {
                txt_rt5_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["RT5_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["PES_DSV"].ToString()))
            {
                txt_pes_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["PES_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_DSV"].ToString()))
            {
                txt_dmo_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DMO_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia001.Tables[0].Rows[0]["DND_DSV"].ToString()))
            {
                txt_dnd_dsv_001.Text = Convert.ToDouble(dsAnaliseMedia001.Tables[0].Rows[0]["DND_DSV"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_001.Text) && !string.IsNullOrEmpty(txt_tit_dsv_001.Text))
            {
                txt_tit_int_inf_001.Text = (Convert.ToDouble(txt_tit_med_001.Text) - (1.96 * (Convert.ToDouble(txt_tit_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_001.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_001.Text))
            {
                txt_tnc_int_inf_001.Text = (Convert.ToDouble(txt_tnc_med_001.Text) - (1.96 * (Convert.ToDouble(txt_tnc_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_001.Text) && !string.IsNullOrEmpty(txt_aon_dsv_001.Text))
            {
                txt_aon_int_inf_001.Text = (Convert.ToDouble(txt_aon_med_001.Text) - (1.96 * (Convert.ToDouble(txt_aon_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_enm_med_001.Text) && !string.IsNullOrEmpty(txt_enm_dsv_001.Text))
            {
                txt_enm_int_inf_001.Text = (Convert.ToDouble(txt_enm_med_001.Text) - (1.96 * (Convert.ToDouble(txt_enm_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eee_med_001.Text) && !string.IsNullOrEmpty(txt_eee_dsv_001.Text))
            {
                txt_eee_int_inf_001.Text = (Convert.ToDouble(txt_eee_med_001.Text) - (1.96 * (Convert.ToDouble(txt_eee_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_kkk_med_001.Text) && !string.IsNullOrEmpty(txt_kkk_dsv_001.Text))
            {
                txt_kkk_int_inf_001.Text = (Convert.ToDouble(txt_kkk_med_001.Text) - (1.96 * (Convert.ToDouble(txt_kkk_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_bbb_med_001.Text) && !string.IsNullOrEmpty(txt_bbb_dsv_001.Text))
            {
                txt_bbb_int_inf_001.Text = (Convert.ToDouble(txt_bbb_med_001.Text) - (1.96 * (Convert.ToDouble(txt_bbb_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pue_med_001.Text) && !string.IsNullOrEmpty(txt_pue_dsv_001.Text))
            {
                txt_pue_int_inf_001.Text = (Convert.ToDouble(txt_pue_med_001.Text) - (1.96 * (Convert.ToDouble(txt_pue_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ole_med_001.Text) && !string.IsNullOrEmpty(txt_ole_dsv_001.Text))
            {
                txt_ole_int_inf_001.Text = (Convert.ToDouble(txt_ole_med_001.Text) - (1.96 * (Convert.ToDouble(txt_ole_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_trq_med_001.Text) && !string.IsNullOrEmpty(txt_trq_dsv_001.Text))
            {
                txt_trq_int_inf_001.Text = (Convert.ToDouble(txt_trq_med_001.Text) - (1.96 * (Convert.ToDouble(txt_trq_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ert_med_001.Text) && !string.IsNullOrEmpty(txt_ert_dsv_001.Text))
            {
                txt_ert_int_inf_001.Text = (Convert.ToDouble(txt_ert_med_001.Text) - (1.96 * (Convert.ToDouble(txt_ert_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt3_med_001.Text) && !string.IsNullOrEmpty(txt_rt3_dsv_001.Text))
            {
                txt_rt3_int_inf_001.Text = (Convert.ToDouble(txt_rt3_med_001.Text) - (1.96 * (Convert.ToDouble(txt_rt3_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt5_med_001.Text) && !string.IsNullOrEmpty(txt_rt5_dsv_001.Text))
            {
                txt_rt5_int_inf_001.Text = (Convert.ToDouble(txt_rt5_med_001.Text) - (1.96 * (Convert.ToDouble(txt_rt5_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pes_med_001.Text) && !string.IsNullOrEmpty(txt_pes_dsv_001.Text))
            {
                txt_pes_int_inf_001.Text = (Convert.ToDouble(txt_pes_med_001.Text) - (1.96 * (Convert.ToDouble(txt_pes_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dmo_med_001.Text) && !string.IsNullOrEmpty(txt_dmo_dsv_001.Text))
            {
                txt_dmo_int_inf_001.Text = (Convert.ToDouble(txt_dmo_med_001.Text) - (1.96 * (Convert.ToDouble(txt_dmo_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dnd_med_001.Text) && !string.IsNullOrEmpty(txt_dnd_dsv_001.Text))
            {
                txt_dnd_int_inf_001.Text = (Convert.ToDouble(txt_dnd_med_001.Text) - (1.96 * (Convert.ToDouble(txt_dnd_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_001.Text) && !string.IsNullOrEmpty(txt_tit_dsv_001.Text))
            {
                txt_tit_int_sup_001.Text = (Convert.ToDouble(txt_tit_med_001.Text) + (1.96 * (Convert.ToDouble(txt_tit_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_001.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_001.Text))
            {
                txt_tnc_int_sup_001.Text = (Convert.ToDouble(txt_tnc_med_001.Text) + (1.96 * (Convert.ToDouble(txt_tnc_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_001.Text) && !string.IsNullOrEmpty(txt_aon_dsv_001.Text))
            {
                txt_aon_int_sup_001.Text = (Convert.ToDouble(txt_aon_med_001.Text) + (1.96 * (Convert.ToDouble(txt_aon_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_enm_med_001.Text) && !string.IsNullOrEmpty(txt_enm_dsv_001.Text))
            {
                txt_enm_int_sup_001.Text = (Convert.ToDouble(txt_enm_med_001.Text) + (1.96 * (Convert.ToDouble(txt_enm_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eee_med_001.Text) && !string.IsNullOrEmpty(txt_eee_dsv_001.Text))
            {
                txt_eee_int_sup_001.Text = (Convert.ToDouble(txt_eee_med_001.Text) + (1.96 * (Convert.ToDouble(txt_eee_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_kkk_med_001.Text) && !string.IsNullOrEmpty(txt_kkk_dsv_001.Text))
            {
                txt_kkk_int_sup_001.Text = (Convert.ToDouble(txt_kkk_med_001.Text) + (1.96 * (Convert.ToDouble(txt_kkk_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_bbb_med_001.Text) && !string.IsNullOrEmpty(txt_bbb_dsv_001.Text))
            {
                txt_bbb_int_sup_001.Text = (Convert.ToDouble(txt_bbb_med_001.Text) + (1.96 * (Convert.ToDouble(txt_bbb_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pue_med_001.Text) && !string.IsNullOrEmpty(txt_pue_dsv_001.Text))
            {
                txt_pue_int_sup_001.Text = (Convert.ToDouble(txt_pue_med_001.Text) + (1.96 * (Convert.ToDouble(txt_pue_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ole_med_001.Text) && !string.IsNullOrEmpty(txt_ole_dsv_001.Text))
            {
                txt_ole_int_sup_001.Text = (Convert.ToDouble(txt_ole_med_001.Text) + (1.96 * (Convert.ToDouble(txt_ole_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_trq_med_001.Text) && !string.IsNullOrEmpty(txt_trq_dsv_001.Text))
            {
                txt_trq_int_sup_001.Text = (Convert.ToDouble(txt_trq_med_001.Text) + (1.96 * (Convert.ToDouble(txt_trq_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ert_med_001.Text) && !string.IsNullOrEmpty(txt_ert_dsv_001.Text))
            {
                txt_ert_int_sup_001.Text = (Convert.ToDouble(txt_ert_med_001.Text) + (1.96 * (Convert.ToDouble(txt_ert_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt3_med_001.Text) && !string.IsNullOrEmpty(txt_rt3_dsv_001.Text))
            {
                txt_rt3_int_sup_001.Text = (Convert.ToDouble(txt_rt3_med_001.Text) + (1.96 * (Convert.ToDouble(txt_rt3_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt5_med_001.Text) && !string.IsNullOrEmpty(txt_rt5_dsv_001.Text))
            {
                txt_rt5_int_sup_001.Text = (Convert.ToDouble(txt_rt5_med_001.Text) + (1.96 * (Convert.ToDouble(txt_rt5_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pes_med_001.Text) && !string.IsNullOrEmpty(txt_pes_dsv_001.Text))
            {
                txt_pes_int_sup_001.Text = (Convert.ToDouble(txt_pes_med_001.Text) + (1.96 * (Convert.ToDouble(txt_pes_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dmo_med_001.Text) && !string.IsNullOrEmpty(txt_dmo_dsv_001.Text))
            {
                txt_dmo_int_sup_001.Text = (Convert.ToDouble(txt_dmo_med_001.Text) + (1.96 * (Convert.ToDouble(txt_dmo_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dnd_med_001.Text) && !string.IsNullOrEmpty(txt_dnd_dsv_001.Text))
            {
                txt_dnd_int_sup_001.Text = (Convert.ToDouble(txt_dnd_med_001.Text) + (1.96 * (Convert.ToDouble(txt_dnd_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
        }
        else
        {
            lbl_num_001.Text = "0";
        }
        dsAnaliseMedia001.Dispose();

        Analise AnaliseMedia002 = new Analise();
        filtro = CriaFiltro002(AnaliseMedia002);
        DataSet dsAnaliseMedia002 = AnaliseMedia002.ConsultarMedia();

        if (dsAnaliseMedia002.Tables[0].Rows.Count > 0)
        {
            txt_lot_rel_002.Text = txt_lot_002.Text;
            cbo_tit_poy_id_rel_002.SelectedValue = cbo_tit_poy_id_002.SelectedValue;
            cbo_aps_id_rel_002.SelectedValue = cbo_aps_id_002.SelectedValue;
            cbo_maq_tip_id_rel_002.SelectedValue = cbo_maq_tip_id_002.SelectedValue;
            cbo_ert_id_rel_002.SelectedValue = cbo_ert_id_002.SelectedValue;

            lbl_num_002.Text = dsAnaliseMedia002.Tables[0].Rows[0]["NUM"].ToString();


            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MED"].ToString()))
            {
                txt_tit_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MED"].ToString()))
            {
                txt_tnc_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MED"].ToString()))
            {
                txt_aon_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MED"].ToString()))
            {
                txt_enm_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MED"].ToString()))
            {
                txt_eee_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MED"].ToString()))
            {
                txt_kkk_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MED"].ToString()))
            {
                txt_bbb_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MED"].ToString()))
            {
                txt_pue_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MED"].ToString()))
            {
                txt_ole_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MED"].ToString()))
            {
                txt_trq_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MED"].ToString()))
            {
                txt_ert_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MED"].ToString()))
            {
                txt_rt3_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MED"].ToString()))
            {
                txt_rt5_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MED"].ToString()))
            {
                txt_pes_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MED"].ToString()))
            {
                txt_dmo_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MED"].ToString()))
            {
                txt_dnd_med_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MED"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MIN"].ToString()))
            {
                txt_tit_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MIN"].ToString()))
            {
                txt_tnc_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MIN"].ToString()))
            {
                txt_aon_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MIN"].ToString()))
            {
                txt_enm_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MIN"].ToString()))
            {
                txt_eee_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MIN"].ToString()))
            {
                txt_kkk_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MIN"].ToString()))
            {
                txt_bbb_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MIN"].ToString()))
            {
                txt_pue_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MIN"].ToString()))
            {
                txt_ole_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MIN"].ToString()))
            {
                txt_trq_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MIN"].ToString()))
            {
                txt_ert_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MIN"].ToString()))
            {
                txt_rt3_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MIN"].ToString()))
            {
                txt_rt5_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MIN"].ToString()))
            {
                txt_pes_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MIN"].ToString()))
            {
                txt_dmo_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MIN"].ToString()))
            {
                txt_dnd_min_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MIN"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MAX"].ToString()))
            {
                txt_tit_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MAX"].ToString()))
            {
                txt_tnc_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MAX"].ToString()))
            {
                txt_aon_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["AON_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MAX"].ToString()))
            {
                txt_enm_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MAX"].ToString()))
            {
                txt_eee_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MAX"].ToString()))
            {
                txt_kkk_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MAX"].ToString()))
            {
                txt_bbb_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MAX"].ToString()))
            {
                txt_pue_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MAX"].ToString()))
            {
                txt_ole_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MAX"].ToString()))
            {
                txt_trq_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MAX"].ToString()))
            {
                txt_ert_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MAX"].ToString()))
            {
                txt_rt3_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MAX"].ToString()))
            {
                txt_rt5_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MAX"].ToString()))
            {
                txt_pes_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PES_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MAX"].ToString()))
            {
                txt_dmo_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MAX"].ToString()))
            {
                txt_dnd_max_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DND_MAX"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_DSV"].ToString()))
            {
                txt_tit_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TIT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_DSV"].ToString()))
            {
                txt_tnc_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TNC_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["AON_DSV"].ToString()))
            {
                txt_aon_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["AON_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_DSV"].ToString()))
            {
                txt_enm_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ENM_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_DSV"].ToString()))
            {
                txt_eee_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["EEE_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_DSV"].ToString()))
            {
                txt_kkk_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["KKK_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_DSV"].ToString()))
            {
                txt_bbb_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["BBB_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_DSV"].ToString()))
            {
                txt_pue_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PUE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_DSV"].ToString()))
            {
                txt_ole_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["OLE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_DSV"].ToString()))
            {
                txt_trq_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["TRQ_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_DSV"].ToString()))
            {
                txt_ert_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["ERT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_DSV"].ToString()))
            {
                txt_rt3_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT3_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_DSV"].ToString()))
            {
                txt_rt5_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["RT5_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["PES_DSV"].ToString()))
            {
                txt_pes_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["PES_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_DSV"].ToString()))
            {
                txt_dmo_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DMO_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsAnaliseMedia002.Tables[0].Rows[0]["DND_DSV"].ToString()))
            {
                txt_dnd_dsv_002.Text = Convert.ToDouble(dsAnaliseMedia002.Tables[0].Rows[0]["DND_DSV"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_002.Text) && !string.IsNullOrEmpty(txt_tit_dsv_002.Text))
            {
                txt_tit_int_inf_002.Text = (Convert.ToDouble(txt_tit_med_002.Text) - (1.96 * (Convert.ToDouble(txt_tit_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_002.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_002.Text))
            {
                txt_tnc_int_inf_002.Text = (Convert.ToDouble(txt_tnc_med_002.Text) - (1.96 * (Convert.ToDouble(txt_tnc_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_002.Text) && !string.IsNullOrEmpty(txt_aon_dsv_002.Text))
            {
                txt_aon_int_inf_002.Text = (Convert.ToDouble(txt_aon_med_002.Text) - (1.96 * (Convert.ToDouble(txt_aon_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_enm_med_002.Text) && !string.IsNullOrEmpty(txt_enm_dsv_002.Text))
            {
                txt_enm_int_inf_002.Text = (Convert.ToDouble(txt_enm_med_002.Text) - (1.96 * (Convert.ToDouble(txt_enm_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eee_med_002.Text) && !string.IsNullOrEmpty(txt_eee_dsv_002.Text))
            {
                txt_eee_int_inf_002.Text = (Convert.ToDouble(txt_eee_med_002.Text) - (1.96 * (Convert.ToDouble(txt_eee_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_kkk_med_002.Text) && !string.IsNullOrEmpty(txt_kkk_dsv_002.Text))
            {
                txt_kkk_int_inf_002.Text = (Convert.ToDouble(txt_kkk_med_002.Text) - (1.96 * (Convert.ToDouble(txt_kkk_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_bbb_med_002.Text) && !string.IsNullOrEmpty(txt_bbb_dsv_002.Text))
            {
                txt_bbb_int_inf_002.Text = (Convert.ToDouble(txt_bbb_med_002.Text) - (1.96 * (Convert.ToDouble(txt_bbb_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pue_med_002.Text) && !string.IsNullOrEmpty(txt_pue_dsv_002.Text))
            {
                txt_pue_int_inf_002.Text = (Convert.ToDouble(txt_pue_med_002.Text) - (1.96 * (Convert.ToDouble(txt_pue_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ole_med_002.Text) && !string.IsNullOrEmpty(txt_ole_dsv_002.Text))
            {
                txt_ole_int_inf_002.Text = (Convert.ToDouble(txt_ole_med_002.Text) - (1.96 * (Convert.ToDouble(txt_ole_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_trq_med_002.Text) && !string.IsNullOrEmpty(txt_trq_dsv_002.Text))
            {
                txt_trq_int_inf_002.Text = (Convert.ToDouble(txt_trq_med_002.Text) - (1.96 * (Convert.ToDouble(txt_trq_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ert_med_002.Text) && !string.IsNullOrEmpty(txt_ert_dsv_002.Text))
            {
                txt_ert_int_inf_002.Text = (Convert.ToDouble(txt_ert_med_002.Text) - (1.96 * (Convert.ToDouble(txt_ert_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt3_med_002.Text) && !string.IsNullOrEmpty(txt_rt3_dsv_002.Text))
            {
                txt_rt3_int_inf_002.Text = (Convert.ToDouble(txt_rt3_med_002.Text) - (1.96 * (Convert.ToDouble(txt_rt3_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt5_med_002.Text) && !string.IsNullOrEmpty(txt_rt5_dsv_002.Text))
            {
                txt_rt5_int_inf_002.Text = (Convert.ToDouble(txt_rt5_med_002.Text) - (1.96 * (Convert.ToDouble(txt_rt5_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pes_med_002.Text) && !string.IsNullOrEmpty(txt_pes_dsv_002.Text))
            {
                txt_pes_int_inf_002.Text = (Convert.ToDouble(txt_pes_med_002.Text) - (1.96 * (Convert.ToDouble(txt_pes_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dmo_med_002.Text) && !string.IsNullOrEmpty(txt_dmo_dsv_002.Text))
            {
                txt_dmo_int_inf_002.Text = (Convert.ToDouble(txt_dmo_med_002.Text) - (1.96 * (Convert.ToDouble(txt_dmo_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dnd_med_002.Text) && !string.IsNullOrEmpty(txt_dnd_dsv_002.Text))
            {
                txt_dnd_int_inf_002.Text = (Convert.ToDouble(txt_dnd_med_002.Text) - (1.96 * (Convert.ToDouble(txt_dnd_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_002.Text) && !string.IsNullOrEmpty(txt_tit_dsv_002.Text))
            {
                txt_tit_int_sup_002.Text = (Convert.ToDouble(txt_tit_med_002.Text) + (1.96 * (Convert.ToDouble(txt_tit_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_002.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_002.Text))
            {
                txt_tnc_int_sup_002.Text = (Convert.ToDouble(txt_tnc_med_002.Text) + (1.96 * (Convert.ToDouble(txt_tnc_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_002.Text) && !string.IsNullOrEmpty(txt_aon_dsv_002.Text))
            {
                txt_aon_int_sup_002.Text = (Convert.ToDouble(txt_aon_med_002.Text) + (1.96 * (Convert.ToDouble(txt_aon_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_enm_med_002.Text) && !string.IsNullOrEmpty(txt_enm_dsv_002.Text))
            {
                txt_enm_int_sup_002.Text = (Convert.ToDouble(txt_enm_med_002.Text) + (1.96 * (Convert.ToDouble(txt_enm_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eee_med_002.Text) && !string.IsNullOrEmpty(txt_eee_dsv_002.Text))
            {
                txt_eee_int_sup_002.Text = (Convert.ToDouble(txt_eee_med_002.Text) + (1.96 * (Convert.ToDouble(txt_eee_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_kkk_med_002.Text) && !string.IsNullOrEmpty(txt_kkk_dsv_002.Text))
            {
                txt_kkk_int_sup_002.Text = (Convert.ToDouble(txt_kkk_med_002.Text) + (1.96 * (Convert.ToDouble(txt_kkk_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_bbb_med_002.Text) && !string.IsNullOrEmpty(txt_bbb_dsv_002.Text))
            {
                txt_bbb_int_sup_002.Text = (Convert.ToDouble(txt_bbb_med_002.Text) + (1.96 * (Convert.ToDouble(txt_bbb_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pue_med_002.Text) && !string.IsNullOrEmpty(txt_pue_dsv_002.Text))
            {
                txt_pue_int_sup_002.Text = (Convert.ToDouble(txt_pue_med_002.Text) + (1.96 * (Convert.ToDouble(txt_pue_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ole_med_002.Text) && !string.IsNullOrEmpty(txt_ole_dsv_002.Text))
            {
                txt_ole_int_sup_002.Text = (Convert.ToDouble(txt_ole_med_002.Text) + (1.96 * (Convert.ToDouble(txt_ole_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_trq_med_002.Text) && !string.IsNullOrEmpty(txt_trq_dsv_002.Text))
            {
                txt_trq_int_sup_002.Text = (Convert.ToDouble(txt_trq_med_002.Text) + (1.96 * (Convert.ToDouble(txt_trq_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_ert_med_002.Text) && !string.IsNullOrEmpty(txt_ert_dsv_002.Text))
            {
                txt_ert_int_sup_002.Text = (Convert.ToDouble(txt_ert_med_002.Text) + (1.96 * (Convert.ToDouble(txt_ert_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt3_med_002.Text) && !string.IsNullOrEmpty(txt_rt3_dsv_002.Text))
            {
                txt_rt3_int_sup_002.Text = (Convert.ToDouble(txt_rt3_med_002.Text) + (1.96 * (Convert.ToDouble(txt_rt3_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_rt5_med_002.Text) && !string.IsNullOrEmpty(txt_rt5_dsv_002.Text))
            {
                txt_rt5_int_sup_002.Text = (Convert.ToDouble(txt_rt5_med_002.Text) + (1.96 * (Convert.ToDouble(txt_rt5_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_pes_med_002.Text) && !string.IsNullOrEmpty(txt_pes_dsv_002.Text))
            {
                txt_pes_int_sup_002.Text = (Convert.ToDouble(txt_pes_med_002.Text) + (1.96 * (Convert.ToDouble(txt_pes_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dmo_med_002.Text) && !string.IsNullOrEmpty(txt_dmo_dsv_002.Text))
            {
                txt_dmo_int_sup_002.Text = (Convert.ToDouble(txt_dmo_med_002.Text) + (1.96 * (Convert.ToDouble(txt_dmo_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_dnd_med_002.Text) && !string.IsNullOrEmpty(txt_dnd_dsv_002.Text))
            {
                txt_dnd_int_sup_002.Text = (Convert.ToDouble(txt_dnd_med_002.Text) + (1.96 * (Convert.ToDouble(txt_dnd_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
        }
        else
        {
            lbl_num_002.Text = "0";
        }
        dsAnaliseMedia002.Dispose();

        if (!string.IsNullOrEmpty(txt_tit_int_inf_001.Text) && !string.IsNullOrEmpty(txt_tit_int_sup_001.Text) && !string.IsNullOrEmpty(txt_tit_int_inf_002.Text) && !string.IsNullOrEmpty(txt_tit_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_tit_int_inf_001.Text) >= Convert.ToDouble(txt_tit_int_inf_002.Text) && Convert.ToDouble(txt_tit_int_inf_001.Text) <= Convert.ToDouble(txt_tit_int_sup_002.Text))
            {
                txt_tit_com.ForeColor = Color.Green; 
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_sup_001.Text) >= Convert.ToDouble(txt_tit_int_inf_002.Text) && Convert.ToDouble(txt_tit_int_sup_001.Text) <= Convert.ToDouble(txt_tit_int_sup_002.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_inf_002.Text) >= Convert.ToDouble(txt_tit_int_inf_001.Text) && Convert.ToDouble(txt_tit_int_inf_002.Text) <= Convert.ToDouble(txt_tit_int_sup_001.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_sup_002.Text) >= Convert.ToDouble(txt_tit_int_inf_001.Text) && Convert.ToDouble(txt_tit_int_sup_002.Text) <= Convert.ToDouble(txt_tit_int_sup_001.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else
            {
                txt_tit_com.ForeColor = Color.Red;
                txt_tit_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_tnc_int_inf_001.Text) && !string.IsNullOrEmpty(txt_tnc_int_sup_001.Text) && !string.IsNullOrEmpty(txt_tnc_int_inf_002.Text) && !string.IsNullOrEmpty(txt_tnc_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_tnc_int_inf_001.Text) >= Convert.ToDouble(txt_tnc_int_inf_002.Text) && Convert.ToDouble(txt_tnc_int_inf_001.Text) <= Convert.ToDouble(txt_tnc_int_sup_002.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_sup_001.Text) >= Convert.ToDouble(txt_tnc_int_inf_002.Text) && Convert.ToDouble(txt_tnc_int_sup_001.Text) <= Convert.ToDouble(txt_tnc_int_sup_002.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_inf_002.Text) >= Convert.ToDouble(txt_tnc_int_inf_001.Text) && Convert.ToDouble(txt_tnc_int_inf_002.Text) <= Convert.ToDouble(txt_tnc_int_sup_001.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_sup_002.Text) >= Convert.ToDouble(txt_tnc_int_inf_001.Text) && Convert.ToDouble(txt_tnc_int_sup_002.Text) <= Convert.ToDouble(txt_tnc_int_sup_001.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else
            {
                txt_tnc_com.ForeColor = Color.Red;
                txt_tnc_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_aon_int_inf_001.Text) && !string.IsNullOrEmpty(txt_aon_int_sup_001.Text) && !string.IsNullOrEmpty(txt_aon_int_inf_002.Text) && !string.IsNullOrEmpty(txt_aon_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_aon_int_inf_001.Text) >= Convert.ToDouble(txt_aon_int_inf_002.Text) && Convert.ToDouble(txt_aon_int_inf_001.Text) <= Convert.ToDouble(txt_aon_int_sup_002.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_sup_001.Text) >= Convert.ToDouble(txt_aon_int_inf_002.Text) && Convert.ToDouble(txt_aon_int_sup_001.Text) <= Convert.ToDouble(txt_aon_int_sup_002.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_inf_002.Text) >= Convert.ToDouble(txt_aon_int_inf_001.Text) && Convert.ToDouble(txt_aon_int_inf_002.Text) <= Convert.ToDouble(txt_aon_int_sup_001.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_sup_002.Text) >= Convert.ToDouble(txt_aon_int_inf_001.Text) && Convert.ToDouble(txt_aon_int_sup_002.Text) <= Convert.ToDouble(txt_aon_int_sup_001.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else
            {
                txt_aon_com.ForeColor = Color.Red;
                txt_aon_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_enm_int_inf_001.Text) && !string.IsNullOrEmpty(txt_enm_int_sup_001.Text) && !string.IsNullOrEmpty(txt_enm_int_inf_002.Text) && !string.IsNullOrEmpty(txt_enm_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_enm_int_inf_001.Text) >= Convert.ToDouble(txt_enm_int_inf_002.Text) && Convert.ToDouble(txt_enm_int_inf_001.Text) <= Convert.ToDouble(txt_enm_int_sup_002.Text))
            {
                txt_enm_com.ForeColor = Color.Green;
                txt_enm_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_enm_int_sup_001.Text) >= Convert.ToDouble(txt_enm_int_inf_002.Text) && Convert.ToDouble(txt_enm_int_sup_001.Text) <= Convert.ToDouble(txt_enm_int_sup_002.Text))
            {
                txt_enm_com.ForeColor = Color.Green;
                txt_enm_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_enm_int_inf_002.Text) >= Convert.ToDouble(txt_enm_int_inf_001.Text) && Convert.ToDouble(txt_enm_int_inf_002.Text) <= Convert.ToDouble(txt_enm_int_sup_001.Text))
            {
                txt_enm_com.ForeColor = Color.Green;
                txt_enm_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_enm_int_sup_002.Text) >= Convert.ToDouble(txt_enm_int_inf_001.Text) && Convert.ToDouble(txt_enm_int_sup_002.Text) <= Convert.ToDouble(txt_enm_int_sup_001.Text))
            {
                txt_enm_com.ForeColor = Color.Green;
                txt_enm_com.Text = "=";
            }
            else
            {
                txt_enm_com.ForeColor = Color.Red;
                txt_enm_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_eee_int_inf_001.Text) && !string.IsNullOrEmpty(txt_eee_int_sup_001.Text) && !string.IsNullOrEmpty(txt_eee_int_inf_002.Text) && !string.IsNullOrEmpty(txt_eee_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_eee_int_inf_001.Text) >= Convert.ToDouble(txt_eee_int_inf_002.Text) && Convert.ToDouble(txt_eee_int_inf_001.Text) <= Convert.ToDouble(txt_eee_int_sup_002.Text))
            {
                txt_eee_com.ForeColor = Color.Green;
                txt_eee_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eee_int_sup_001.Text) >= Convert.ToDouble(txt_eee_int_inf_002.Text) && Convert.ToDouble(txt_eee_int_sup_001.Text) <= Convert.ToDouble(txt_eee_int_sup_002.Text))
            {
                txt_eee_com.ForeColor = Color.Green;
                txt_eee_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eee_int_inf_002.Text) >= Convert.ToDouble(txt_eee_int_inf_001.Text) && Convert.ToDouble(txt_eee_int_inf_002.Text) <= Convert.ToDouble(txt_eee_int_sup_001.Text))
            {
                txt_eee_com.ForeColor = Color.Green;
                txt_eee_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eee_int_sup_002.Text) >= Convert.ToDouble(txt_eee_int_inf_001.Text) && Convert.ToDouble(txt_eee_int_sup_002.Text) <= Convert.ToDouble(txt_eee_int_sup_001.Text))
            {
                txt_eee_com.ForeColor = Color.Green;
                txt_eee_com.Text = "=";
            }
            else
            {
                txt_eee_com.ForeColor = Color.Red;
                txt_eee_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_kkk_int_inf_001.Text) && !string.IsNullOrEmpty(txt_kkk_int_sup_001.Text) && !string.IsNullOrEmpty(txt_kkk_int_inf_002.Text) && !string.IsNullOrEmpty(txt_kkk_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_kkk_int_inf_001.Text) >= Convert.ToDouble(txt_kkk_int_inf_002.Text) && Convert.ToDouble(txt_kkk_int_inf_001.Text) <= Convert.ToDouble(txt_kkk_int_sup_002.Text))
            {
                txt_kkk_com.ForeColor = Color.Green;
                txt_kkk_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_kkk_int_sup_001.Text) >= Convert.ToDouble(txt_kkk_int_inf_002.Text) && Convert.ToDouble(txt_kkk_int_sup_001.Text) <= Convert.ToDouble(txt_kkk_int_sup_002.Text))
            {
                txt_kkk_com.ForeColor = Color.Green;
                txt_kkk_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_kkk_int_inf_002.Text) >= Convert.ToDouble(txt_kkk_int_inf_001.Text) && Convert.ToDouble(txt_kkk_int_inf_002.Text) <= Convert.ToDouble(txt_kkk_int_sup_001.Text))
            {
                txt_kkk_com.ForeColor = Color.Green;
                txt_kkk_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_kkk_int_sup_002.Text) >= Convert.ToDouble(txt_kkk_int_inf_001.Text) && Convert.ToDouble(txt_kkk_int_sup_002.Text) <= Convert.ToDouble(txt_kkk_int_sup_001.Text))
            {
                txt_kkk_com.ForeColor = Color.Green;
                txt_kkk_com.Text = "=";
            }
            else
            {
                txt_kkk_com.ForeColor = Color.Red;
                txt_kkk_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_bbb_int_inf_001.Text) && !string.IsNullOrEmpty(txt_bbb_int_sup_001.Text) && !string.IsNullOrEmpty(txt_bbb_int_inf_002.Text) && !string.IsNullOrEmpty(txt_bbb_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_bbb_int_inf_001.Text) >= Convert.ToDouble(txt_bbb_int_inf_002.Text) && Convert.ToDouble(txt_bbb_int_inf_001.Text) <= Convert.ToDouble(txt_bbb_int_sup_002.Text))
            {
                txt_bbb_com.ForeColor = Color.Green;
                txt_bbb_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_bbb_int_sup_001.Text) >= Convert.ToDouble(txt_bbb_int_inf_002.Text) && Convert.ToDouble(txt_bbb_int_sup_001.Text) <= Convert.ToDouble(txt_bbb_int_sup_002.Text))
            {
                txt_bbb_com.ForeColor = Color.Green;
                txt_bbb_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_bbb_int_inf_002.Text) >= Convert.ToDouble(txt_bbb_int_inf_001.Text) && Convert.ToDouble(txt_bbb_int_inf_002.Text) <= Convert.ToDouble(txt_bbb_int_sup_001.Text))
            {
                txt_bbb_com.ForeColor = Color.Green;
                txt_bbb_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_bbb_int_sup_002.Text) >= Convert.ToDouble(txt_bbb_int_inf_001.Text) && Convert.ToDouble(txt_bbb_int_sup_002.Text) <= Convert.ToDouble(txt_bbb_int_sup_001.Text))
            {
                txt_bbb_com.ForeColor = Color.Green;
                txt_bbb_com.Text = "=";
            }
            else
            {
                txt_bbb_com.ForeColor = Color.Red;
                txt_bbb_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_pue_int_inf_001.Text) && !string.IsNullOrEmpty(txt_pue_int_sup_001.Text) && !string.IsNullOrEmpty(txt_pue_int_inf_002.Text) && !string.IsNullOrEmpty(txt_pue_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_pue_int_inf_001.Text) >= Convert.ToDouble(txt_pue_int_inf_002.Text) && Convert.ToDouble(txt_pue_int_inf_001.Text) <= Convert.ToDouble(txt_pue_int_sup_002.Text))
            {
                txt_pue_com.ForeColor = Color.Green;
                txt_pue_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pue_int_sup_001.Text) >= Convert.ToDouble(txt_pue_int_inf_002.Text) && Convert.ToDouble(txt_pue_int_sup_001.Text) <= Convert.ToDouble(txt_pue_int_sup_002.Text))
            {
                txt_pue_com.ForeColor = Color.Green;
                txt_pue_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pue_int_inf_002.Text) >= Convert.ToDouble(txt_pue_int_inf_001.Text) && Convert.ToDouble(txt_pue_int_inf_002.Text) <= Convert.ToDouble(txt_pue_int_sup_001.Text))
            {
                txt_pue_com.ForeColor = Color.Green;
                txt_pue_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pue_int_sup_002.Text) >= Convert.ToDouble(txt_pue_int_inf_001.Text) && Convert.ToDouble(txt_pue_int_sup_002.Text) <= Convert.ToDouble(txt_pue_int_sup_001.Text))
            {
                txt_pue_com.ForeColor = Color.Green;
                txt_pue_com.Text = "=";
            }
            else
            {
                txt_pue_com.ForeColor = Color.Red;
                txt_pue_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_ole_int_inf_001.Text) && !string.IsNullOrEmpty(txt_ole_int_sup_001.Text) && !string.IsNullOrEmpty(txt_ole_int_inf_002.Text) && !string.IsNullOrEmpty(txt_ole_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_ole_int_inf_001.Text) >= Convert.ToDouble(txt_ole_int_inf_002.Text) && Convert.ToDouble(txt_ole_int_inf_001.Text) <= Convert.ToDouble(txt_ole_int_sup_002.Text))
            {
                txt_ole_com.ForeColor = Color.Green;
                txt_ole_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ole_int_sup_001.Text) >= Convert.ToDouble(txt_ole_int_inf_002.Text) && Convert.ToDouble(txt_ole_int_sup_001.Text) <= Convert.ToDouble(txt_ole_int_sup_002.Text))
            {
                txt_ole_com.ForeColor = Color.Green;
                txt_ole_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ole_int_inf_002.Text) >= Convert.ToDouble(txt_ole_int_inf_001.Text) && Convert.ToDouble(txt_ole_int_inf_002.Text) <= Convert.ToDouble(txt_ole_int_sup_001.Text))
            {
                txt_ole_com.ForeColor = Color.Green;
                txt_ole_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ole_int_sup_002.Text) >= Convert.ToDouble(txt_ole_int_inf_001.Text) && Convert.ToDouble(txt_ole_int_sup_002.Text) <= Convert.ToDouble(txt_ole_int_sup_001.Text))
            {
                txt_ole_com.ForeColor = Color.Green;
                txt_ole_com.Text = "=";
            }
            else
            {
                txt_ole_com.ForeColor = Color.Red;
                txt_ole_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_trq_int_inf_001.Text) && !string.IsNullOrEmpty(txt_trq_int_sup_001.Text) && !string.IsNullOrEmpty(txt_trq_int_inf_002.Text) && !string.IsNullOrEmpty(txt_trq_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_trq_int_inf_001.Text) >= Convert.ToDouble(txt_trq_int_inf_002.Text) && Convert.ToDouble(txt_trq_int_inf_001.Text) <= Convert.ToDouble(txt_trq_int_sup_002.Text))
            {
                txt_trq_com.ForeColor = Color.Green;
                txt_trq_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_trq_int_sup_001.Text) >= Convert.ToDouble(txt_trq_int_inf_002.Text) && Convert.ToDouble(txt_trq_int_sup_001.Text) <= Convert.ToDouble(txt_trq_int_sup_002.Text))
            {
                txt_trq_com.ForeColor = Color.Green;
                txt_trq_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_trq_int_inf_002.Text) >= Convert.ToDouble(txt_trq_int_inf_001.Text) && Convert.ToDouble(txt_trq_int_inf_002.Text) <= Convert.ToDouble(txt_trq_int_sup_001.Text))
            {
                txt_trq_com.ForeColor = Color.Green;
                txt_trq_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_trq_int_sup_002.Text) >= Convert.ToDouble(txt_trq_int_inf_001.Text) && Convert.ToDouble(txt_trq_int_sup_002.Text) <= Convert.ToDouble(txt_trq_int_sup_001.Text))
            {
                txt_trq_com.ForeColor = Color.Green;
                txt_trq_com.Text = "=";
            }
            else
            {
                txt_trq_com.ForeColor = Color.Red;
                txt_trq_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_ert_int_inf_001.Text) && !string.IsNullOrEmpty(txt_ert_int_sup_001.Text) && !string.IsNullOrEmpty(txt_ert_int_inf_002.Text) && !string.IsNullOrEmpty(txt_ert_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_ert_int_inf_001.Text) >= Convert.ToDouble(txt_ert_int_inf_002.Text) && Convert.ToDouble(txt_ert_int_inf_001.Text) <= Convert.ToDouble(txt_ert_int_sup_002.Text))
            {
                txt_ert_com.ForeColor = Color.Green;
                txt_ert_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ert_int_sup_001.Text) >= Convert.ToDouble(txt_ert_int_inf_002.Text) && Convert.ToDouble(txt_ert_int_sup_001.Text) <= Convert.ToDouble(txt_ert_int_sup_002.Text))
            {
                txt_ert_com.ForeColor = Color.Green;
                txt_ert_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ert_int_inf_002.Text) >= Convert.ToDouble(txt_ert_int_inf_001.Text) && Convert.ToDouble(txt_ert_int_inf_002.Text) <= Convert.ToDouble(txt_ert_int_sup_001.Text))
            {
                txt_ert_com.ForeColor = Color.Green;
                txt_ert_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_ert_int_sup_002.Text) >= Convert.ToDouble(txt_ert_int_inf_001.Text) && Convert.ToDouble(txt_ert_int_sup_002.Text) <= Convert.ToDouble(txt_ert_int_sup_001.Text))
            {
                txt_ert_com.ForeColor = Color.Green;
                txt_ert_com.Text = "=";
            }
            else
            {
                txt_ert_com.ForeColor = Color.Red;
                txt_ert_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_rt3_int_inf_001.Text) && !string.IsNullOrEmpty(txt_rt3_int_sup_001.Text) && !string.IsNullOrEmpty(txt_rt3_int_inf_002.Text) && !string.IsNullOrEmpty(txt_rt3_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_rt3_int_inf_001.Text) >= Convert.ToDouble(txt_rt3_int_inf_002.Text) && Convert.ToDouble(txt_rt3_int_inf_001.Text) <= Convert.ToDouble(txt_rt3_int_sup_002.Text))
            {
                txt_rt3_com.ForeColor = Color.Green;
                txt_rt3_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt3_int_sup_001.Text) >= Convert.ToDouble(txt_rt3_int_inf_002.Text) && Convert.ToDouble(txt_rt3_int_sup_001.Text) <= Convert.ToDouble(txt_rt3_int_sup_002.Text))
            {
                txt_rt3_com.ForeColor = Color.Green;
                txt_rt3_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt3_int_inf_002.Text) >= Convert.ToDouble(txt_rt3_int_inf_001.Text) && Convert.ToDouble(txt_rt3_int_inf_002.Text) <= Convert.ToDouble(txt_rt3_int_sup_001.Text))
            {
                txt_rt3_com.ForeColor = Color.Green;
                txt_rt3_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt3_int_sup_002.Text) >= Convert.ToDouble(txt_rt3_int_inf_001.Text) && Convert.ToDouble(txt_rt3_int_sup_002.Text) <= Convert.ToDouble(txt_rt3_int_sup_001.Text))
            {
                txt_rt3_com.ForeColor = Color.Green;
                txt_rt3_com.Text = "=";
            }
            else
            {
                txt_rt3_com.ForeColor = Color.Red;
                txt_rt3_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_rt5_int_inf_001.Text) && !string.IsNullOrEmpty(txt_rt5_int_sup_001.Text) && !string.IsNullOrEmpty(txt_rt5_int_inf_002.Text) && !string.IsNullOrEmpty(txt_rt5_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_rt5_int_inf_001.Text) >= Convert.ToDouble(txt_rt5_int_inf_002.Text) && Convert.ToDouble(txt_rt5_int_inf_001.Text) <= Convert.ToDouble(txt_rt5_int_sup_002.Text))
            {
                txt_rt5_com.ForeColor = Color.Green;
                txt_rt5_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt5_int_sup_001.Text) >= Convert.ToDouble(txt_rt5_int_inf_002.Text) && Convert.ToDouble(txt_rt5_int_sup_001.Text) <= Convert.ToDouble(txt_rt5_int_sup_002.Text))
            {
                txt_rt5_com.ForeColor = Color.Green;
                txt_rt5_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt5_int_inf_002.Text) >= Convert.ToDouble(txt_rt5_int_inf_001.Text) && Convert.ToDouble(txt_rt5_int_inf_002.Text) <= Convert.ToDouble(txt_rt5_int_sup_001.Text))
            {
                txt_rt5_com.ForeColor = Color.Green;
                txt_rt5_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_rt5_int_sup_002.Text) >= Convert.ToDouble(txt_rt5_int_inf_001.Text) && Convert.ToDouble(txt_rt5_int_sup_002.Text) <= Convert.ToDouble(txt_rt5_int_sup_001.Text))
            {
                txt_rt5_com.ForeColor = Color.Green;
                txt_rt5_com.Text = "=";
            }
            else
            {
                txt_rt5_com.ForeColor = Color.Red;
                txt_rt5_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_pes_int_inf_001.Text) && !string.IsNullOrEmpty(txt_pes_int_sup_001.Text) && !string.IsNullOrEmpty(txt_pes_int_inf_002.Text) && !string.IsNullOrEmpty(txt_pes_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_pes_int_inf_001.Text) >= Convert.ToDouble(txt_pes_int_inf_002.Text) && Convert.ToDouble(txt_pes_int_inf_001.Text) <= Convert.ToDouble(txt_pes_int_sup_002.Text))
            {
                txt_pes_com.ForeColor = Color.Green;
                txt_pes_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pes_int_sup_001.Text) >= Convert.ToDouble(txt_pes_int_inf_002.Text) && Convert.ToDouble(txt_pes_int_sup_001.Text) <= Convert.ToDouble(txt_pes_int_sup_002.Text))
            {
                txt_pes_com.ForeColor = Color.Green;
                txt_pes_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pes_int_inf_002.Text) >= Convert.ToDouble(txt_pes_int_inf_001.Text) && Convert.ToDouble(txt_pes_int_inf_002.Text) <= Convert.ToDouble(txt_pes_int_sup_001.Text))
            {
                txt_pes_com.ForeColor = Color.Green;
                txt_pes_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_pes_int_sup_002.Text) >= Convert.ToDouble(txt_pes_int_inf_001.Text) && Convert.ToDouble(txt_pes_int_sup_002.Text) <= Convert.ToDouble(txt_pes_int_sup_001.Text))
            {
                txt_pes_com.ForeColor = Color.Green;
                txt_pes_com.Text = "=";
            }
            else
            {
                txt_pes_com.ForeColor = Color.Red;
                txt_pes_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_dmo_int_inf_001.Text) && !string.IsNullOrEmpty(txt_dmo_int_sup_001.Text) && !string.IsNullOrEmpty(txt_dmo_int_inf_002.Text) && !string.IsNullOrEmpty(txt_dmo_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_dmo_int_inf_001.Text) >= Convert.ToDouble(txt_dmo_int_inf_002.Text) && Convert.ToDouble(txt_dmo_int_inf_001.Text) <= Convert.ToDouble(txt_dmo_int_sup_002.Text))
            {
                txt_dmo_com.ForeColor = Color.Green;
                txt_dmo_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dmo_int_sup_001.Text) >= Convert.ToDouble(txt_dmo_int_inf_002.Text) && Convert.ToDouble(txt_dmo_int_sup_001.Text) <= Convert.ToDouble(txt_dmo_int_sup_002.Text))
            {
                txt_dmo_com.ForeColor = Color.Green;
                txt_dmo_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dmo_int_inf_002.Text) >= Convert.ToDouble(txt_dmo_int_inf_001.Text) && Convert.ToDouble(txt_dmo_int_inf_002.Text) <= Convert.ToDouble(txt_dmo_int_sup_001.Text))
            {
                txt_dmo_com.ForeColor = Color.Green;
                txt_dmo_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dmo_int_sup_002.Text) >= Convert.ToDouble(txt_dmo_int_inf_001.Text) && Convert.ToDouble(txt_dmo_int_sup_002.Text) <= Convert.ToDouble(txt_dmo_int_sup_001.Text))
            {
                txt_dmo_com.ForeColor = Color.Green;
                txt_dmo_com.Text = "=";
            }
            else
            {
                txt_dmo_com.ForeColor = Color.Red;
                txt_dmo_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_dnd_int_inf_001.Text) && !string.IsNullOrEmpty(txt_dnd_int_sup_001.Text) && !string.IsNullOrEmpty(txt_dnd_int_inf_002.Text) && !string.IsNullOrEmpty(txt_dnd_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_dnd_int_inf_001.Text) >= Convert.ToDouble(txt_dnd_int_inf_002.Text) && Convert.ToDouble(txt_dnd_int_inf_001.Text) <= Convert.ToDouble(txt_dnd_int_sup_002.Text))
            {
                txt_dnd_com.ForeColor = Color.Green;
                txt_dnd_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dnd_int_sup_001.Text) >= Convert.ToDouble(txt_dnd_int_inf_002.Text) && Convert.ToDouble(txt_dnd_int_sup_001.Text) <= Convert.ToDouble(txt_dnd_int_sup_002.Text))
            {
                txt_dnd_com.ForeColor = Color.Green;
                txt_dnd_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dnd_int_inf_002.Text) >= Convert.ToDouble(txt_dnd_int_inf_001.Text) && Convert.ToDouble(txt_dnd_int_inf_002.Text) <= Convert.ToDouble(txt_dnd_int_sup_001.Text))
            {
                txt_dnd_com.ForeColor = Color.Green;
                txt_dnd_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_dnd_int_sup_002.Text) >= Convert.ToDouble(txt_dnd_int_inf_001.Text) && Convert.ToDouble(txt_dnd_int_sup_002.Text) <= Convert.ToDouble(txt_dnd_int_sup_001.Text))
            {
                txt_dnd_com.ForeColor = Color.Green;
                txt_dnd_com.Text = "=";
            }
            else
            {
                txt_dnd_com.ForeColor = Color.Red;
                txt_dnd_com.Text = "<>";
            }
        }

        if ((txt_tit_med_001.Text != txt_tit_med_002.Text) && (!string.IsNullOrEmpty(txt_tit_med_002.Text)) && (!string.IsNullOrEmpty(txt_tit_med_001.Text)))
        {
            txt_tit_dif.Text = ((Convert.ToDouble(txt_tit_med_002.Text) - Convert.ToDouble(txt_tit_med_001.Text)) / Convert.ToDouble(txt_tit_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_tnc_med_001.Text != txt_tnc_med_002.Text) && (!string.IsNullOrEmpty(txt_tnc_med_002.Text)) && (!string.IsNullOrEmpty(txt_tnc_med_001.Text)))
        {
            txt_tnc_dif.Text = ((Convert.ToDouble(txt_tnc_med_002.Text) - Convert.ToDouble(txt_tnc_med_001.Text)) / Convert.ToDouble(txt_tnc_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_aon_med_001.Text != txt_aon_med_002.Text) && (!string.IsNullOrEmpty(txt_aon_med_002.Text)) && (!string.IsNullOrEmpty(txt_aon_med_001.Text)))
        {
            txt_aon_dif.Text = ((Convert.ToDouble(txt_aon_med_002.Text) - Convert.ToDouble(txt_aon_med_001.Text)) / Convert.ToDouble(txt_aon_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_enm_med_001.Text != txt_enm_med_002.Text) && (!string.IsNullOrEmpty(txt_enm_med_002.Text)) && (!string.IsNullOrEmpty(txt_enm_med_001.Text)))
        {
            txt_enm_dif.Text = ((Convert.ToDouble(txt_enm_med_002.Text) - Convert.ToDouble(txt_enm_med_001.Text)) / Convert.ToDouble(txt_enm_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_eee_med_001.Text != txt_eee_med_002.Text) && (!string.IsNullOrEmpty(txt_eee_med_002.Text)) && (!string.IsNullOrEmpty(txt_eee_med_001.Text)))
        {
            txt_eee_dif.Text = ((Convert.ToDouble(txt_eee_med_002.Text) - Convert.ToDouble(txt_eee_med_001.Text)) / Convert.ToDouble(txt_eee_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_kkk_med_001.Text != txt_kkk_med_002.Text) && (!string.IsNullOrEmpty(txt_kkk_med_002.Text)) && (!string.IsNullOrEmpty(txt_kkk_med_001.Text)))
        {
            txt_kkk_dif.Text = ((Convert.ToDouble(txt_kkk_med_002.Text) - Convert.ToDouble(txt_kkk_med_001.Text)) / Convert.ToDouble(txt_kkk_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_bbb_med_001.Text != txt_bbb_med_002.Text) && (!string.IsNullOrEmpty(txt_bbb_med_002.Text)) && (!string.IsNullOrEmpty(txt_bbb_med_001.Text)))
        {
            txt_bbb_dif.Text = ((Convert.ToDouble(txt_bbb_med_002.Text) - Convert.ToDouble(txt_bbb_med_001.Text)) / Convert.ToDouble(txt_bbb_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_pue_med_001.Text != txt_pue_med_002.Text) && (!string.IsNullOrEmpty(txt_pue_med_002.Text)) && (!string.IsNullOrEmpty(txt_pue_med_001.Text)))
        {
            txt_pue_dif.Text = ((Convert.ToDouble(txt_pue_med_002.Text) - Convert.ToDouble(txt_pue_med_001.Text)) / Convert.ToDouble(txt_pue_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_ole_med_001.Text != txt_ole_med_002.Text) && (!string.IsNullOrEmpty(txt_ole_med_002.Text)) && (!string.IsNullOrEmpty(txt_ole_med_001.Text)))
        {
            txt_ole_dif.Text = ((Convert.ToDouble(txt_ole_med_002.Text) - Convert.ToDouble(txt_ole_med_001.Text)) / Convert.ToDouble(txt_ole_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_trq_med_001.Text != txt_trq_med_002.Text) && (!string.IsNullOrEmpty(txt_trq_med_002.Text)) && (!string.IsNullOrEmpty(txt_trq_med_001.Text)))
        {
            txt_trq_dif.Text = ((Convert.ToDouble(txt_trq_med_002.Text) - Convert.ToDouble(txt_trq_med_001.Text)) / Convert.ToDouble(txt_trq_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_ert_med_001.Text != txt_ert_med_002.Text) && (!string.IsNullOrEmpty(txt_ert_med_002.Text)) && (!string.IsNullOrEmpty(txt_ert_med_001.Text)))
        {
            txt_ert_dif.Text = ((Convert.ToDouble(txt_ert_med_002.Text) - Convert.ToDouble(txt_ert_med_001.Text)) / Convert.ToDouble(txt_ert_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_rt3_med_001.Text != txt_rt3_med_002.Text) && (!string.IsNullOrEmpty(txt_rt3_med_002.Text)) && (!string.IsNullOrEmpty(txt_rt3_med_001.Text)))
        {
            txt_rt3_dif.Text = ((Convert.ToDouble(txt_rt3_med_002.Text) - Convert.ToDouble(txt_rt3_med_001.Text)) / Convert.ToDouble(txt_rt3_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_rt5_med_001.Text != txt_rt5_med_002.Text) && (!string.IsNullOrEmpty(txt_rt5_med_002.Text)) && (!string.IsNullOrEmpty(txt_rt5_med_001.Text)))
        {
            txt_rt5_dif.Text = ((Convert.ToDouble(txt_rt5_med_002.Text) - Convert.ToDouble(txt_rt5_med_001.Text)) / Convert.ToDouble(txt_rt5_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_pes_med_001.Text != txt_pes_med_002.Text) && (!string.IsNullOrEmpty(txt_pes_med_002.Text)) && (!string.IsNullOrEmpty(txt_pes_med_001.Text)))
        {
            txt_pes_dif.Text = ((Convert.ToDouble(txt_pes_med_002.Text) - Convert.ToDouble(txt_pes_med_001.Text)) / Convert.ToDouble(txt_pes_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_dmo_med_001.Text != txt_dmo_med_002.Text) && (!string.IsNullOrEmpty(txt_dmo_med_002.Text)) && (!string.IsNullOrEmpty(txt_dmo_med_001.Text)))
        {
            txt_dmo_dif.Text = ((Convert.ToDouble(txt_dmo_med_002.Text) - Convert.ToDouble(txt_dmo_med_001.Text)) / Convert.ToDouble(txt_dmo_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_dnd_med_001.Text != txt_dnd_med_002.Text) && (!string.IsNullOrEmpty(txt_dnd_med_002.Text)) && (!string.IsNullOrEmpty(txt_dnd_med_001.Text)))
        {
            txt_dnd_dif.Text = ((Convert.ToDouble(txt_dnd_med_002.Text) - Convert.ToDouble(txt_dnd_med_001.Text)) / Convert.ToDouble(txt_dnd_med_002.Text)).ToString("0.00 %");
        }

        Dispose();

        ///* Não apresentar filtros e barra de identificação 
        // * pois o relatório é impresso e enviado ao cliente

        /*        
        if (!String.IsNullOrEmpty(filtro))
        {
            lb_fil.Text = filtro;
        }
        else
        {
            lb_fil.Text = "Não há filtros.";
        }      
        */

        Body.Attributes.Remove("class");

        ucBarra.Visible = false;

        dvFiltro.Visible = false;
        dvComparacaoProdutos.Visible = true;
    }
    

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void txt_lot_001_OnTextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_lot_001.Text))
        {
            Analise Analise = new Analise();
            Analise.ANS_LOT = txt_lot_001.Text;
            DataSet dsAnalise = Analise.Consultar();
            if (dsAnalise.Tables[0].Rows.Count > 0)
            {
                txt_lot_001.Text = dsAnalise.Tables[0].Rows[0]["ANS_LOT"].ToString();
                cbo_tit_poy_id_001.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_TIT_POY_ID"].ToString();
                cbo_aps_id_001.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_APS_ID"].ToString();
                cbo_maq_tip_id_001.SelectedValue = dsAnalise.Tables[0].Rows[0]["MAQ_TIP_ID"].ToString();
                cbo_ert_id_001.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_ERT_ID"].ToString();
            }
        }
    }

    protected void txt_lot_002_OnTextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_lot_002.Text))
        {
            Analise Analise = new Analise();
            Analise.ANS_LOT = txt_lot_002.Text;
            DataSet dsAnalise = Analise.Consultar();
            if (dsAnalise.Tables[0].Rows.Count > 0)
            {
                txt_lot_002.Text = dsAnalise.Tables[0].Rows[0]["ANS_LOT"].ToString();
                cbo_tit_poy_id_002.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_TIT_POY_ID"].ToString();
                cbo_aps_id_002.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_APS_ID"].ToString();
                cbo_maq_tip_id_002.SelectedValue = dsAnalise.Tables[0].Rows[0]["MAQ_TIP_ID"].ToString();
                cbo_ert_id_002.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_ERT_ID"].ToString();
            }
        }
    }

}