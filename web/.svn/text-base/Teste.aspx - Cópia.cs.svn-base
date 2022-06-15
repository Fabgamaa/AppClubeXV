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
        txt_rts.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_rts_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_ini_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_hor_ini_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        txt_hor_ini_inc.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_hor_fim_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
        txt_hor_fim_inc.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        txt_tit_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_tit_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_enm_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_enm_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eee_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eee_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_kkk_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_kkk_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_bbb_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bbb_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ole_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ole_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_trq_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moedanegativo();");
        txt_trq_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ert_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ert_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt3_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt3_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_rt5_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_rt5_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dnd_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dnd_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dmo_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dmo_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_pes_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_pes_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        txt_lme_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lme_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ume_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ume_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpe_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpe_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upe_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upe_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ucv_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ucv_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dur_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dur_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dft_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dft_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lmc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lmc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_umc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_umc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_lpc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lpc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_upc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_upc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
    }

    protected void CarregaControles()
    {
        MotivoTeste MotivoTeste = new MotivoTeste();
        DataSet dsMotivoTeste = MotivoTeste.Consultar();
        FWGNR.VerificaStatus(dsMotivoTeste, "MTV_TST_ID", "MTV_TST_DES", "MTV_TST_STS", cbo_mtv_tst_id_inc);
        dsMotivoTeste.Dispose();

        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
        dsTitulo.Dispose();

        Fornecedor Fornecedor = new Fornecedor();
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_001_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_002_id_inc);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_003_id_inc);
        dsFornecedor.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id_inc);
        dsApresentacao.Dispose();

        MaquinaTipo MaquinaTipo = new MaquinaTipo();
        DataSet dsMaquinaTipo = MaquinaTipo.Consultar();
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id);
        FWGNR.VerificaStatus(dsMaquinaTipo, "MAQ_TIP_ID", "MAQ_TIP_DES", "MAQ_TIP_STS", cbo_maq_tip_id_inc);
        dsMaquinaTipo.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
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

            txt_rts_inc.Focus();

            Teste Teste = new Teste();
            Teste.TST_ID = Convert.ToInt32(rowId.Value);
            DataSet dsTeste = Teste.Consultar();
            if (dsTeste.Tables[0].Rows.Count > 0)
            {
                txt_rts_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RTS_ID"].ToString();
                cbo_mtv_tst_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_RTS_MTV_TST_ID"].ToString();
                txt_lot_inc.Text = dsTeste.Tables[0].Rows[0]["TST_LOT"].ToString();
                txt_lot_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_LOT_REF"].ToString();
                txt_lot_epf_inc.Text = dsTeste.Tables[0].Rows[0]["TST_LOT_EPF"].ToString();
                txt_lot_ans_inc.Text = dsTeste.Tables[0].Rows[0]["TST_LOT_ANS"].ToString();
                if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
                {
                    txt_lot_ref_inc.ReadOnly = true;
                }
                cbo_tit_poy_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_TIT_POY_ID"].ToString();
                txt_des_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DES"].ToString();
                txt_mge_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE"].ToString();
                txt_mge_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_003"].ToString();
                txt_mge_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_REF"].ToString();
                txt_mge_002_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_002_REF"].ToString();
                txt_mge_003_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_003_REF"].ToString();
                cbo_for_001_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_003_ID"].ToString();
                //Excluído por solicitação do Wagner 11/07/2011
                //txt_vlc_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_MAQ_TIP_ID"].ToString();
                object sender = null;
                EventArgs e = null;
                cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
                cbo_ert_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_ERT_ID"].ToString();
                txt_dat_ini_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_INI"].ToString()).ToString("dd/MM/yyyy");
                txt_hor_ini_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_INI"].ToString()).ToString("HH:MM");
                txt_dat_fim_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_FIM"].ToString()).ToString("dd/MM/yyyy");
                txt_hor_fim_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_FIM"].ToString()).ToString("HH:MM");
                calculaTempoGasto(sender, e);
                txt_vw2_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_REF"].ToString();
                txt_egm_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_REF"].ToString();
                txt_dyy_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_REF"].ToString();
                txt_2wx_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_REF"].ToString();
                txt_3w3_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_REF"].ToString();
                txt_4w4_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_REF"].ToString();
                txt_agl_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_REF"].ToString();
                txt_tup_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_REF"].ToString();
                txt_veo_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_REF"].ToString();
                txt_t1t_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_REF"].ToString();
                txt_t1c_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_REF"].ToString();
                txt_t1l_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_REF"].ToString();
                txt_t2f_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_REF"].ToString();
                txt_sve_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_REF"].ToString();
                txt_stf_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_REF"].ToString();
                txt_sce_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_REF"].ToString();
                txt_sco_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_REF"].ToString();
                txt_sch_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_REF"].ToString();
                txt_scg_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_REF"].ToString();
                txt_see_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_REF"].ToString();
                txt_seo_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_REF"].ToString();
                txt_seh_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_REF"].ToString();
                txt_seg_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_REF"].ToString();
                txt_sjc_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_REF"].ToString();
                txt_sjt_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_REF"].ToString();
                txt_sjb_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_REF"].ToString();
                txt_spj_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_REF"].ToString();
                txt_sbc_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_REF"].ToString();
                txt_spo_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_REF"].ToString();
                txt_sva_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_REF"].ToString();
                txt_tgr_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_REF"].ToString();
                txt_tip_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_REF"].ToString();
                txt_dsb_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_REF"].ToString();
                txt_tca_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_REF"].ToString();
                txt_fmc_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_REF"].ToString();
                txt_1tb_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_REF"].ToString();
                txt_1pp_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_REF"].ToString();
                txt_2tb_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_REF"].ToString();
                txt_2pp_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_REF"].ToString();
                txt_cso_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_REF"].ToString();
                txt_esp_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_REF"].ToString();
                txt_tol_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_REF"].ToString();
                txt_p1c_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_REF"].ToString();
                txt_p2d_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_REF"].ToString();
                txt_p3d_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_REF"].ToString();
                txt_p4u_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_REF"].ToString();
                txt_mol_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_REF"].ToString();
                txt_tpd_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_REF"].ToString();
                txt_tt1_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_REF"].ToString();
                txt_tt2_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_REF"].ToString();
                txt_tt3_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_REF"].ToString();
                txt_t21_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_REF"].ToString();
                txt_tun_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_REF"].ToString();
                txt_tcv_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_REF"].ToString();
                txt_tss_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_REF"].ToString();
                txt_tit_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_REF"].ToString();
                txt_tnc_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_REF"].ToString();
                txt_aon_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_REF"].ToString();
                txt_enm_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_REF"].ToString();
                txt_eee_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_REF"].ToString();
                txt_kkk_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_REF"].ToString();
                txt_bbb_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_REF"].ToString();
                txt_ole_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_REF"].ToString();
                txt_trq_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_REF"].ToString();
                txt_ert_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_REF"].ToString();
                txt_rt3_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_REF"].ToString();
                txt_rt5_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_REF"].ToString();
                txt_dnd_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_REF"].ToString();
                txt_dmo_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_REF"].ToString();
                txt_pes_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_REF"].ToString();
                txt_vrr_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_REF"].ToString();

                txt_tre_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_REF"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_REF"].ToString()))
                {
                    txt_lme_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_REF"].ToString()))
                {
                    txt_ume_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_REF"].ToString()))
                {
                    txt_lpe_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_REF"].ToString()))
                {
                    txt_upe_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_REF"].ToString()))
                {
                    txt_ucv_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_REF"].ToString()))
                {
                    txt_dur_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_REF"].ToString()))
                {
                    txt_dft_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_REF"].ToString()))
                {
                    txt_lmc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_REF"].ToString()))
                {
                    txt_umc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_REF"].ToString()))
                {
                    txt_lpc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_REF"].ToString()))
                {
                    txt_upc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_REF"].ToString()))
                {
                    txt_cvc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_REF"].ToString()))
                {
                    txt_dfc_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_REF"].ToString()))
                {
                    txt_tfs_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_REF"].ToString()))
                {
                    txt_fsw_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_REF"].ToString()))
                {
                    txt_wfw_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_REF"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_REF"].ToString()))
                {
                    txt_eco_ref_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_REF"].ToString()).ToString("0.0");
                }

                txt_eol_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_REF"].ToString();
                txt_etu_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_REF"].ToString();
                txt_etd_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_REF"].ToString();
                txt_ecu_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_REF"].ToString();
                txt_egd_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_REF"].ToString();
                txt_eec_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_REF"].ToString();
                txt_ecd_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_REF"].ToString();
                txt_egu_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_REF"].ToString();
                txt_eso_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_REF"].ToString();
                txt_esi_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_REF"].ToString();
                txt_ecr_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_REF"].ToString();
                txt_eod_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_REF"].ToString();
                txt_eaw_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_REF"].ToString();
                txt_ed1_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_REF"].ToString();
                txt_ed2_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_REF"].ToString();

                txt_vw2_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_001"].ToString();
                txt_egm_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_001"].ToString();
                txt_dyy_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_001"].ToString();
                txt_2wx_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_001"].ToString();
                txt_3w3_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_001"].ToString();
                txt_4w4_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_001"].ToString();
                txt_agl_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_001"].ToString();
                txt_tup_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_001"].ToString();
                txt_veo_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_001"].ToString();
                txt_t1t_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_001"].ToString();
                txt_t1c_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_001"].ToString();
                txt_t1l_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_001"].ToString();
                txt_t2f_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_001"].ToString();
                txt_sve_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_001"].ToString();
                txt_stf_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_001"].ToString();
                txt_sce_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_001"].ToString();
                txt_sco_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_001"].ToString();
                txt_sch_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_001"].ToString();
                txt_scg_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_001"].ToString();
                txt_see_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_001"].ToString();
                txt_seo_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_001"].ToString();
                txt_seh_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_001"].ToString();
                txt_seg_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_001"].ToString();
                txt_sjc_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_001"].ToString();
                txt_sjt_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_001"].ToString();
                txt_sjb_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_001"].ToString();
                txt_spj_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_001"].ToString();
                txt_sbc_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_001"].ToString();
                txt_spo_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_001"].ToString();
                txt_sva_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_001"].ToString();
                txt_tgr_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_001"].ToString();
                txt_tip_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_001"].ToString();
                txt_dsb_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_001"].ToString();
                txt_tca_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_001"].ToString();
                txt_fmc_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_001"].ToString();
                txt_1tb_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_001"].ToString();
                txt_1pp_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_001"].ToString();
                txt_2tb_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_001"].ToString();
                txt_2pp_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_001"].ToString();
                txt_cso_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_001"].ToString();
                txt_esp_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_001"].ToString();
                txt_tol_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_001"].ToString();
                txt_p1c_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_001"].ToString();
                txt_p2d_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_001"].ToString();
                txt_p3d_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_001"].ToString();
                txt_p4u_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_001"].ToString();
                txt_mol_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_001"].ToString();
                txt_tpd_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_001"].ToString();
                txt_tt1_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_001"].ToString();
                txt_tt2_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_001"].ToString();
                txt_tt3_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_001"].ToString();
                txt_t21_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_001"].ToString();
                txt_tun_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_001"].ToString();
                txt_tcv_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_001"].ToString();
                txt_tss_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_001"].ToString();
                txt_tit_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_001"].ToString();
                txt_tnc_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_001"].ToString();
                txt_aon_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_001"].ToString();
                txt_enm_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_001"].ToString();
                txt_eee_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_001"].ToString();
                txt_kkk_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_001"].ToString();
                txt_bbb_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_001"].ToString();
                txt_ole_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_001"].ToString();
                txt_trq_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_001"].ToString();
                txt_ert_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_001"].ToString();
                txt_rt3_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_001"].ToString();
                txt_rt5_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_001"].ToString();
                txt_dnd_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_001"].ToString();
                txt_dmo_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_001"].ToString();
                txt_pes_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_001"].ToString();
                txt_vrr_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_001"].ToString();

                txt_tre_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_001"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_001"].ToString()))
                {
                    txt_lme_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_001"].ToString()))
                {
                    txt_ume_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_001"].ToString()))
                {
                    txt_lpe_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_001"].ToString()))
                {
                    txt_upe_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_001"].ToString()))
                {
                    txt_ucv_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_001"].ToString()))
                {
                    txt_dur_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_001"].ToString()))
                {
                    txt_dft_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_001"].ToString()))
                {
                    txt_lmc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_001"].ToString()))
                {
                    txt_umc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_001"].ToString()))
                {
                    txt_lpc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_001"].ToString()))
                {
                    txt_upc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_001"].ToString()))
                {
                    txt_cvc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_001"].ToString()))
                {
                    txt_dfc_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_001"].ToString()))
                {
                    txt_tfs_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_001"].ToString()))
                {
                    txt_fsw_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_001"].ToString()))
                {
                    txt_wfw_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_001"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_001"].ToString()))
                {
                    txt_eco_001_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_001"].ToString()).ToString("0.0");
                }

                txt_eol_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_001"].ToString();
                txt_etu_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_001"].ToString();
                txt_etd_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_001"].ToString();
                txt_ecu_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_001"].ToString();
                txt_egd_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_001"].ToString();
                txt_eec_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_001"].ToString();
                txt_ecd_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_001"].ToString();
                txt_egu_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_001"].ToString();
                txt_eso_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_001"].ToString();
                txt_esi_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_001"].ToString();
                txt_ecr_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_001"].ToString();
                txt_eod_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_001"].ToString();
                txt_eaw_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_001"].ToString();
                txt_ed1_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_001"].ToString();
                txt_ed2_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_001"].ToString();

                txt_vw2_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_002"].ToString();
                txt_egm_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_002"].ToString();
                txt_dyy_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_002"].ToString();
                txt_2wx_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_002"].ToString();
                txt_3w3_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_002"].ToString();
                txt_4w4_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_002"].ToString();
                txt_agl_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_002"].ToString();
                txt_tup_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_002"].ToString();
                txt_veo_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_002"].ToString();
                txt_t1t_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_002"].ToString();
                txt_t1c_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_002"].ToString();
                txt_t1l_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_002"].ToString();
                txt_t2f_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_002"].ToString();
                txt_sve_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_002"].ToString();
                txt_stf_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_002"].ToString();
                txt_sce_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_002"].ToString();
                txt_sco_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_002"].ToString();
                txt_sch_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_002"].ToString();
                txt_scg_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_002"].ToString();
                txt_see_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_002"].ToString();
                txt_seo_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_002"].ToString();
                txt_seh_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_002"].ToString();
                txt_seg_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_002"].ToString();
                txt_sjc_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_002"].ToString();
                txt_sjt_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_002"].ToString();
                txt_sjb_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_002"].ToString();
                txt_spj_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_002"].ToString();
                txt_sbc_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_002"].ToString();
                txt_spo_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_002"].ToString();
                txt_sva_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_002"].ToString();
                txt_tgr_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_002"].ToString();
                txt_tip_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_002"].ToString();
                txt_dsb_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_002"].ToString();
                txt_tca_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_002"].ToString();
                txt_fmc_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_002"].ToString();
                txt_1tb_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_002"].ToString();
                txt_1pp_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_002"].ToString();
                txt_2tb_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_002"].ToString();
                txt_2pp_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_002"].ToString();
                txt_cso_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_002"].ToString();
                txt_esp_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_002"].ToString();
                txt_tol_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_002"].ToString();
                txt_p1c_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_002"].ToString();
                txt_p2d_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_002"].ToString();
                txt_p3d_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_002"].ToString();
                txt_p4u_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_002"].ToString();
                txt_mol_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_002"].ToString();
                txt_tpd_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_002"].ToString();
                txt_tt1_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_002"].ToString();
                txt_tt2_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_002"].ToString();
                txt_tt3_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_002"].ToString();
                txt_t21_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_002"].ToString();
                txt_tun_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_002"].ToString();
                txt_tcv_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_002"].ToString();
                txt_tss_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_002"].ToString();
                txt_tit_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_002"].ToString();
                txt_tnc_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_002"].ToString();
                txt_aon_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_002"].ToString();
                txt_enm_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_002"].ToString();
                txt_eee_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_002"].ToString();
                txt_kkk_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_002"].ToString();
                txt_bbb_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_002"].ToString();
                txt_ole_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_002"].ToString();
                txt_trq_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_002"].ToString();
                txt_ert_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_002"].ToString();
                txt_rt3_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_002"].ToString();
                txt_rt5_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_002"].ToString();
                txt_dnd_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_002"].ToString();
                txt_dmo_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_002"].ToString();
                txt_pes_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_002"].ToString();
                txt_vrr_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_002"].ToString();

                txt_tre_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_002"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_002"].ToString()))
                {
                    txt_lme_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_002"].ToString()))
                {
                    txt_ume_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_002"].ToString()))
                {
                    txt_lpe_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_002"].ToString()))
                {
                    txt_upe_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_002"].ToString()))
                {
                    txt_ucv_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_002"].ToString()))
                {
                    txt_dur_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_002"].ToString()))
                {
                    txt_dft_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_002"].ToString()))
                {
                    txt_lmc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_002"].ToString()))
                {
                    txt_umc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_002"].ToString()))
                {
                    txt_lpc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_002"].ToString()))
                {
                    txt_upc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_002"].ToString()))
                {
                    txt_cvc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_002"].ToString()))
                {
                    txt_dfc_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_002"].ToString()))
                {
                    txt_tfs_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_002"].ToString()))
                {
                    txt_fsw_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_002"].ToString()))
                {
                    txt_wfw_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_002"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_002"].ToString()))
                {
                    txt_eco_002_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_002"].ToString()).ToString("0.0");
                }

                txt_eol_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_002"].ToString();
                txt_etu_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_002"].ToString();
                txt_etd_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_002"].ToString();
                txt_ecu_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_002"].ToString();
                txt_egd_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_002"].ToString();
                txt_eec_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_002"].ToString();
                txt_ecd_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_002"].ToString();
                txt_egu_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_002"].ToString();
                txt_eso_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_002"].ToString();
                txt_esi_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_002"].ToString();
                txt_ecr_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_002"].ToString();
                txt_eod_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_002"].ToString();
                txt_eaw_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_002"].ToString();
                txt_ed1_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_002"].ToString();
                txt_ed2_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_002"].ToString();

                txt_vw2_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_003"].ToString();
                txt_egm_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_003"].ToString();
                txt_dyy_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_003"].ToString();
                txt_2wx_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_003"].ToString();
                txt_3w3_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_003"].ToString();
                txt_4w4_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_003"].ToString();
                txt_agl_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_003"].ToString();
                txt_tup_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_003"].ToString();
                txt_veo_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_003"].ToString();
                txt_t1t_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_003"].ToString();
                txt_t1c_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_003"].ToString();
                txt_t1l_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_003"].ToString();
                txt_t2f_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_003"].ToString();
                txt_sve_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_003"].ToString();
                txt_stf_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_003"].ToString();
                txt_sce_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_003"].ToString();
                txt_sco_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_003"].ToString();
                txt_sch_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_003"].ToString();
                txt_scg_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_003"].ToString();
                txt_see_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_003"].ToString();
                txt_seo_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_003"].ToString();
                txt_seh_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_003"].ToString();
                txt_seg_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_003"].ToString();
                txt_sjc_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_003"].ToString();
                txt_sjt_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_003"].ToString();
                txt_sjb_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_003"].ToString();
                txt_spj_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_003"].ToString();
                txt_sbc_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_003"].ToString();
                txt_spo_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_003"].ToString();
                txt_sva_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_003"].ToString();
                txt_tgr_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_003"].ToString();
                txt_tip_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_003"].ToString();
                txt_dsb_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_003"].ToString();
                txt_tca_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_003"].ToString();
                txt_fmc_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_003"].ToString();
                txt_1tb_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_003"].ToString();
                txt_1pp_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_003"].ToString();
                txt_2tb_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_003"].ToString();
                txt_2pp_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_003"].ToString();
                txt_cso_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_003"].ToString();
                txt_esp_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_003"].ToString();
                txt_tol_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_003"].ToString();
                txt_p1c_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_003"].ToString();
                txt_p2d_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_003"].ToString();
                txt_p3d_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_003"].ToString();
                txt_p4u_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_003"].ToString();
                txt_mol_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_003"].ToString();
                txt_tpd_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_003"].ToString();
                txt_tt1_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_003"].ToString();
                txt_tt2_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_003"].ToString();
                txt_tt3_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_003"].ToString();
                txt_t21_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_003"].ToString();
                txt_tun_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_003"].ToString();
                txt_tcv_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_003"].ToString();
                txt_tss_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_003"].ToString();
                txt_tit_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_003"].ToString();
                txt_tnc_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_003"].ToString();
                txt_aon_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_003"].ToString();
                txt_enm_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_003"].ToString();
                txt_eee_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_003"].ToString();
                txt_kkk_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_003"].ToString();
                txt_bbb_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_003"].ToString();
                txt_ole_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_003"].ToString();
                txt_trq_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_003"].ToString();
                txt_ert_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_003"].ToString();
                txt_rt3_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_003"].ToString();
                txt_rt5_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_003"].ToString();
                txt_dnd_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_003"].ToString();
                txt_dmo_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_003"].ToString();
                txt_pes_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_003"].ToString();
                txt_vrr_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_003"].ToString();

                txt_tre_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_003"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_003"].ToString()))
                {
                    txt_lme_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_003"].ToString()))
                {
                    txt_ume_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_003"].ToString()))
                {
                    txt_lpe_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_003"].ToString()))
                {
                    txt_upe_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_003"].ToString()))
                {
                    txt_ucv_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_003"].ToString()))
                {
                    txt_dur_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_003"].ToString()))
                {
                    txt_dft_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_003"].ToString()))
                {
                    txt_lmc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_003"].ToString()))
                {
                    txt_umc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_003"].ToString()))
                {
                    txt_lpc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_003"].ToString()))
                {
                    txt_upc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_003"].ToString()))
                {
                    txt_cvc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_003"].ToString()))
                {
                    txt_dfc_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_003"].ToString()))
                {
                    txt_tfs_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_003"].ToString()))
                {
                    txt_fsw_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_003"].ToString()))
                {
                    txt_wfw_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_003"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_003"].ToString()))
                {
                    txt_eco_003_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_003"].ToString()).ToString("0.0");
                }

                txt_eol_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_003"].ToString();
                txt_etu_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_003"].ToString();
                txt_etd_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_003"].ToString();
                txt_ecu_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_003"].ToString();
                txt_egd_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_003"].ToString();
                txt_eec_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_003"].ToString();
                txt_ecd_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_003"].ToString();
                txt_egu_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_003"].ToString();
                txt_eso_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_003"].ToString();
                txt_esi_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_003"].ToString();
                txt_ecr_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_003"].ToString();
                txt_eod_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_003"].ToString();
                txt_eaw_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_003"].ToString();
                txt_ed1_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_003"].ToString();
                txt_ed2_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_003"].ToString();

                txt_vw2_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_004"].ToString();
                txt_egm_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_004"].ToString();
                txt_dyy_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_004"].ToString();
                txt_2wx_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_004"].ToString();
                txt_3w3_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_004"].ToString();
                txt_4w4_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_004"].ToString();
                txt_agl_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_004"].ToString();
                txt_tup_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_004"].ToString();
                txt_veo_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_004"].ToString();
                txt_t1t_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_004"].ToString();
                txt_t1c_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_004"].ToString();
                txt_t1l_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_004"].ToString();
                txt_t2f_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_004"].ToString();
                txt_sve_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_004"].ToString();
                txt_stf_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_004"].ToString();
                txt_sce_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_004"].ToString();
                txt_sco_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_004"].ToString();
                txt_sch_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_004"].ToString();
                txt_scg_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_004"].ToString();
                txt_see_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_004"].ToString();
                txt_seo_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_004"].ToString();
                txt_seh_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_004"].ToString();
                txt_seg_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_004"].ToString();
                txt_sjc_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_004"].ToString();
                txt_sjt_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_004"].ToString();
                txt_sjb_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_004"].ToString();
                txt_spj_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_004"].ToString();
                txt_sbc_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_004"].ToString();
                txt_spo_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_004"].ToString();
                txt_sva_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_004"].ToString();
                txt_tgr_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_004"].ToString();
                txt_tip_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_004"].ToString();
                txt_dsb_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_004"].ToString();
                txt_tca_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_004"].ToString();
                txt_fmc_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_004"].ToString();
                txt_1tb_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_004"].ToString();
                txt_1pp_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_004"].ToString();
                txt_2tb_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_004"].ToString();
                txt_2pp_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_004"].ToString();
                txt_cso_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_004"].ToString();
                txt_esp_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_004"].ToString();
                txt_tol_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_004"].ToString();
                txt_p1c_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_004"].ToString();
                txt_p2d_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_004"].ToString();
                txt_p3d_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_004"].ToString();
                txt_p4u_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_004"].ToString();
                txt_mol_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_004"].ToString();
                txt_tpd_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_004"].ToString();
                txt_tt1_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_004"].ToString();
                txt_tt2_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_004"].ToString();
                txt_tt3_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_004"].ToString();
                txt_t21_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_004"].ToString();
                txt_tun_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_004"].ToString();
                txt_tcv_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_004"].ToString();
                txt_tss_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_004"].ToString();
                txt_tit_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_004"].ToString();
                txt_tnc_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_004"].ToString();
                txt_aon_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_004"].ToString();
                txt_enm_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_004"].ToString();
                txt_eee_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_004"].ToString();
                txt_kkk_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_004"].ToString();
                txt_bbb_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_004"].ToString();
                txt_ole_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_004"].ToString();
                txt_trq_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_004"].ToString();
                txt_ert_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_004"].ToString();
                txt_rt3_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_004"].ToString();
                txt_rt5_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_004"].ToString();
                txt_dnd_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_004"].ToString();
                txt_dmo_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_004"].ToString();
                txt_pes_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_004"].ToString();
                txt_vrr_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_004"].ToString();

                txt_tre_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_004"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_004"].ToString()))
                {
                    txt_lme_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_004"].ToString()))
                {
                    txt_ume_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_004"].ToString()))
                {
                    txt_lpe_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_004"].ToString()))
                {
                    txt_upe_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_004"].ToString()))
                {
                    txt_ucv_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_004"].ToString()))
                {
                    txt_dur_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_004"].ToString()))
                {
                    txt_dft_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_004"].ToString()))
                {
                    txt_lmc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_004"].ToString()))
                {
                    txt_umc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_004"].ToString()))
                {
                    txt_lpc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_004"].ToString()))
                {
                    txt_upc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_004"].ToString()))
                {
                    txt_cvc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_004"].ToString()))
                {
                    txt_dfc_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_004"].ToString()))
                {
                    txt_tfs_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_004"].ToString()))
                {
                    txt_fsw_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_004"].ToString()))
                {
                    txt_wfw_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_004"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_004"].ToString()))
                {
                    txt_eco_004_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_004"].ToString()).ToString("0.0");
                }

                txt_eol_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_004"].ToString();
                txt_etu_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_004"].ToString();
                txt_etd_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_004"].ToString();
                txt_ecu_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_004"].ToString();
                txt_egd_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_004"].ToString();
                txt_eec_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_004"].ToString();
                txt_ecd_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_004"].ToString();
                txt_egu_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_004"].ToString();
                txt_eso_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_004"].ToString();
                txt_esi_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_004"].ToString();
                txt_ecr_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_004"].ToString();
                txt_eod_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_004"].ToString();
                txt_eaw_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_004"].ToString();
                txt_ed1_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_004"].ToString();
                txt_ed2_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_004"].ToString();

                txt_vw2_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_005"].ToString();
                txt_egm_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_005"].ToString();
                txt_dyy_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_005"].ToString();
                txt_2wx_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_005"].ToString();
                txt_3w3_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_005"].ToString();
                txt_4w4_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_005"].ToString();
                txt_agl_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_005"].ToString();
                txt_tup_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_005"].ToString();
                txt_veo_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_005"].ToString();
                txt_t1t_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_005"].ToString();
                txt_t1c_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_005"].ToString();
                txt_t1l_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_005"].ToString();
                txt_t2f_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_005"].ToString();
                txt_sve_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_005"].ToString();
                txt_stf_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_005"].ToString();
                txt_sce_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_005"].ToString();
                txt_sco_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_005"].ToString();
                txt_sch_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_005"].ToString();
                txt_scg_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_005"].ToString();
                txt_see_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_005"].ToString();
                txt_seo_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_005"].ToString();
                txt_seh_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_005"].ToString();
                txt_seg_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_005"].ToString();
                txt_sjc_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_005"].ToString();
                txt_sjt_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_005"].ToString();
                txt_sjb_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_005"].ToString();
                txt_spj_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_005"].ToString();
                txt_sbc_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_005"].ToString();
                txt_spo_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_005"].ToString();
                txt_sva_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_005"].ToString();
                txt_tgr_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_005"].ToString();
                txt_tip_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_005"].ToString();
                txt_dsb_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_005"].ToString();
                txt_tca_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_005"].ToString();
                txt_fmc_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_005"].ToString();
                txt_1tb_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_005"].ToString();
                txt_1pp_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_005"].ToString();
                txt_2tb_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_005"].ToString();
                txt_2pp_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_005"].ToString();
                txt_cso_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_005"].ToString();
                txt_esp_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_005"].ToString();
                txt_tol_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_005"].ToString();
                txt_p1c_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_005"].ToString();
                txt_p2d_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_005"].ToString();
                txt_p3d_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_005"].ToString();
                txt_p4u_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_005"].ToString();
                txt_mol_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_005"].ToString();
                txt_tpd_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_005"].ToString();
                txt_tt1_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_005"].ToString();
                txt_tt2_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_005"].ToString();
                txt_tt3_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_005"].ToString();
                txt_t21_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_005"].ToString();
                txt_tun_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_005"].ToString();
                txt_tcv_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_005"].ToString();
                txt_tss_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_005"].ToString();
                txt_tit_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_005"].ToString();
                txt_tnc_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_005"].ToString();
                txt_aon_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_005"].ToString();
                txt_enm_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_005"].ToString();
                txt_eee_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_005"].ToString();
                txt_kkk_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_005"].ToString();
                txt_bbb_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_005"].ToString();
                txt_ole_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_005"].ToString();
                txt_trq_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_005"].ToString();
                txt_ert_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_005"].ToString();
                txt_rt3_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_005"].ToString();
                txt_rt5_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_005"].ToString();
                txt_dnd_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_005"].ToString();
                txt_dmo_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_005"].ToString();
                txt_pes_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_005"].ToString();
                txt_vrr_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_005"].ToString();

                txt_tre_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_005"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_005"].ToString()))
                {
                    txt_lme_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_005"].ToString()))
                {
                    txt_ume_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_005"].ToString()))
                {
                    txt_lpe_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_005"].ToString()))
                {
                    txt_upe_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_005"].ToString()))
                {
                    txt_ucv_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_005"].ToString()))
                {
                    txt_dur_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_005"].ToString()))
                {
                    txt_dft_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_005"].ToString()))
                {
                    txt_lmc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_005"].ToString()))
                {
                    txt_umc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_005"].ToString()))
                {
                    txt_lpc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_005"].ToString()))
                {
                    txt_upc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_005"].ToString()))
                {
                    txt_cvc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_005"].ToString()))
                {
                    txt_dfc_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_005"].ToString()))
                {
                    txt_tfs_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_005"].ToString()))
                {
                    txt_fsw_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_005"].ToString()))
                {
                    txt_wfw_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_005"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_005"].ToString()))
                {
                    txt_eco_005_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_005"].ToString()).ToString("0.0");
                }

                txt_eol_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_005"].ToString();
                txt_etu_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_005"].ToString();
                txt_etd_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_005"].ToString();
                txt_ecu_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_005"].ToString();
                txt_egd_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_005"].ToString();
                txt_eec_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_005"].ToString();
                txt_ecd_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_005"].ToString();
                txt_egu_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_005"].ToString();
                txt_eso_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_005"].ToString();
                txt_esi_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_005"].ToString();
                txt_ecr_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_005"].ToString();
                txt_eod_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_005"].ToString();
                txt_eaw_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_005"].ToString();
                txt_ed1_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_005"].ToString();
                txt_ed2_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_005"].ToString();

                txt_vw2_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_006"].ToString();
                txt_egm_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_006"].ToString();
                txt_dyy_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_006"].ToString();
                txt_2wx_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_006"].ToString();
                txt_3w3_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_006"].ToString();
                txt_4w4_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_006"].ToString();
                txt_agl_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_006"].ToString();
                txt_tup_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_006"].ToString();
                txt_veo_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_006"].ToString();
                txt_t1t_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_006"].ToString();
                txt_t1c_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_006"].ToString();
                txt_t1l_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_006"].ToString();
                txt_t2f_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_006"].ToString();
                txt_sve_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_006"].ToString();
                txt_stf_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_006"].ToString();
                txt_sce_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_006"].ToString();
                txt_sco_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_006"].ToString();
                txt_sch_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_006"].ToString();
                txt_scg_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_006"].ToString();
                txt_see_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_006"].ToString();
                txt_seo_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_006"].ToString();
                txt_seh_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_006"].ToString();
                txt_seg_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_006"].ToString();
                txt_sjc_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_006"].ToString();
                txt_sjt_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_006"].ToString();
                txt_sjb_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_006"].ToString();
                txt_spj_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_006"].ToString();
                txt_sbc_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_006"].ToString();
                txt_spo_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_006"].ToString();
                txt_sva_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_006"].ToString();
                txt_tgr_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_006"].ToString();
                txt_tip_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_006"].ToString();
                txt_dsb_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_006"].ToString();
                txt_tca_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_006"].ToString();
                txt_fmc_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_006"].ToString();
                txt_1tb_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_006"].ToString();
                txt_1pp_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_006"].ToString();
                txt_2tb_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_006"].ToString();
                txt_2pp_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_006"].ToString();
                txt_cso_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_006"].ToString();
                txt_esp_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_006"].ToString();
                txt_tol_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_006"].ToString();
                txt_p1c_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_006"].ToString();
                txt_p2d_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_006"].ToString();
                txt_p3d_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_006"].ToString();
                txt_p4u_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_006"].ToString();
                txt_mol_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_006"].ToString();
                txt_tpd_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_006"].ToString();
                txt_tt1_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_006"].ToString();
                txt_tt2_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_006"].ToString();
                txt_tt3_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_006"].ToString();
                txt_t21_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_006"].ToString();
                txt_tun_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_006"].ToString();
                txt_tcv_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_006"].ToString();
                txt_tss_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_006"].ToString();
                txt_tit_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_006"].ToString();
                txt_tnc_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_006"].ToString();
                txt_aon_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_006"].ToString();
                txt_enm_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_006"].ToString();
                txt_eee_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_006"].ToString();
                txt_kkk_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_006"].ToString();
                txt_bbb_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_006"].ToString();
                txt_ole_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_006"].ToString();
                txt_trq_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_006"].ToString();
                txt_ert_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_006"].ToString();
                txt_rt3_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_006"].ToString();
                txt_rt5_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_006"].ToString();
                txt_dnd_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_006"].ToString();
                txt_dmo_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_006"].ToString();
                txt_pes_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_006"].ToString();
                txt_vrr_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_006"].ToString();

                txt_tre_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_006"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_006"].ToString()))
                {
                    txt_lme_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_006"].ToString()))
                {
                    txt_ume_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_006"].ToString()))
                {
                    txt_lpe_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_006"].ToString()))
                {
                    txt_upe_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_006"].ToString()))
                {
                    txt_ucv_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_006"].ToString()))
                {
                    txt_dur_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_006"].ToString()))
                {
                    txt_dft_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_006"].ToString()))
                {
                    txt_lmc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_006"].ToString()))
                {
                    txt_umc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_006"].ToString()))
                {
                    txt_lpc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_006"].ToString()))
                {
                    txt_upc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_006"].ToString()))
                {
                    txt_cvc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_006"].ToString()))
                {
                    txt_dfc_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_006"].ToString()))
                {
                    txt_tfs_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_006"].ToString()))
                {
                    txt_fsw_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_006"].ToString()))
                {
                    txt_wfw_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_006"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_006"].ToString()))
                {
                    txt_eco_006_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_006"].ToString()).ToString("0.0");
                }

                txt_eol_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_006"].ToString();
                txt_etu_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_006"].ToString();
                txt_etd_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_006"].ToString();
                txt_ecu_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_006"].ToString();
                txt_egd_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_006"].ToString();
                txt_eec_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_006"].ToString();
                txt_ecd_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_006"].ToString();
                txt_egu_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_006"].ToString();
                txt_eso_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_006"].ToString();
                txt_esi_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_006"].ToString();
                txt_ecr_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_006"].ToString();
                txt_eod_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_006"].ToString();
                txt_eaw_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_006"].ToString();
                txt_ed1_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_006"].ToString();
                txt_ed2_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_006"].ToString();

                txt_vw2_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VW2_007"].ToString();
                txt_egm_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGM_007"].ToString();
                txt_dyy_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DYY_007"].ToString();
                txt_2wx_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2WX_007"].ToString();
                txt_3w3_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_3W3_007"].ToString();
                txt_4w4_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_4W4_007"].ToString();
                txt_agl_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AGL_007"].ToString();
                txt_tup_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUP_007"].ToString();
                txt_veo_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VEO_007"].ToString();
                txt_t1t_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1T_007"].ToString();
                txt_t1c_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1C_007"].ToString();
                txt_t1l_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T1L_007"].ToString();
                txt_t2f_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T2F_007"].ToString();
                txt_sve_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVE_007"].ToString();
                txt_stf_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_STF_007"].ToString();
                txt_sce_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCE_007"].ToString();
                txt_sco_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCO_007"].ToString();
                txt_sch_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCH_007"].ToString();
                txt_scg_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SCG_007"].ToString();
                txt_see_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEE_007"].ToString();
                txt_seo_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEO_007"].ToString();
                txt_seh_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEH_007"].ToString();
                txt_seg_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SEG_007"].ToString();
                txt_sjc_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJC_007"].ToString();
                txt_sjt_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJT_007"].ToString();
                txt_sjb_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJB_007"].ToString();
                txt_spj_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPJ_007"].ToString();
                txt_sbc_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SBC_007"].ToString();
                txt_spo_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SPO_007"].ToString();
                txt_sva_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SVA_007"].ToString();
                txt_tgr_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TGR_007"].ToString();
                txt_tip_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIP_007"].ToString();
                txt_dsb_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DSB_007"].ToString();
                txt_tca_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCA_007"].ToString();
                txt_fmc_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_FMC_007"].ToString();
                txt_1tb_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1TB_007"].ToString();
                txt_1pp_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_1PP_007"].ToString();
                txt_2tb_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2TB_007"].ToString();
                txt_2pp_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_2PP_007"].ToString();
                txt_cso_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_CSO_007"].ToString();
                txt_esp_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESP_007"].ToString();
                txt_tol_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TOL_007"].ToString();
                txt_p1c_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P1C_007"].ToString();
                txt_p2d_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P2D_007"].ToString();
                txt_p3d_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P3D_007"].ToString();
                txt_p4u_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_P4U_007"].ToString();
                txt_mol_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MOL_007"].ToString();
                txt_tpd_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TPD_007"].ToString();
                txt_tt1_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT1_007"].ToString();
                txt_tt2_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT2_007"].ToString();
                txt_tt3_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TT3_007"].ToString();
                txt_t21_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_T21_007"].ToString();
                txt_tun_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TUN_007"].ToString();
                txt_tcv_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TCV_007"].ToString();
                txt_tss_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TSS_007"].ToString();
                txt_tit_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TIT_007"].ToString();
                txt_tnc_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TNC_007"].ToString();
                txt_aon_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_AON_007"].ToString();
                txt_enm_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ENM_007"].ToString();
                txt_eee_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEE_007"].ToString();
                txt_kkk_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_KKK_007"].ToString();
                txt_bbb_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_BBB_007"].ToString();
                txt_ole_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OLE_007"].ToString();
                txt_trq_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRQ_007"].ToString();
                txt_ert_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ERT_007"].ToString();
                txt_rt3_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT3_007"].ToString();
                txt_rt5_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_RT5_007"].ToString();
                txt_dnd_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DND_007"].ToString();
                txt_dmo_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DMO_007"].ToString();
                txt_pes_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PES_007"].ToString();
                txt_vrr_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VRR_007"].ToString();

                txt_tre_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TRE_007"].ToString();
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LME_007"].ToString()))
                {
                    txt_lme_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LME_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UME_007"].ToString()))
                {
                    txt_ume_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UME_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPE_007"].ToString()))
                {
                    txt_lpe_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPE_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPE_007"].ToString()))
                {
                    txt_upe_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPE_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UCV_007"].ToString()))
                {
                    txt_ucv_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UCV_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DUR_007"].ToString()))
                {
                    txt_dur_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DUR_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFT_007"].ToString()))
                {
                    txt_dft_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFT_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LMC_007"].ToString()))
                {
                    txt_lmc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LMC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UMC_007"].ToString()))
                {
                    txt_umc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UMC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_LPC_007"].ToString()))
                {
                    txt_lpc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_LPC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_UPC_007"].ToString()))
                {
                    txt_upc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_UPC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_CVC_007"].ToString()))
                {
                    txt_cvc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_CVC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_DFC_007"].ToString()))
                {
                    txt_dfc_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_DFC_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_TFS_007"].ToString()))
                {
                    txt_tfs_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_TFS_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_FSW_007"].ToString()))
                {
                    txt_fsw_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_FSW_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_WFW_007"].ToString()))
                {
                    txt_wfw_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_WFW_007"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[0]["TST_ECO_007"].ToString()))
                {
                    txt_eco_007_inc.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[0]["TST_ECO_007"].ToString()).ToString("0.0");
                }

                txt_eol_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOL_007"].ToString();
                txt_etu_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETU_007"].ToString();
                txt_etd_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ETD_007"].ToString();
                txt_ecu_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECU_007"].ToString();
                txt_egd_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGD_007"].ToString();
                txt_eec_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EEC_007"].ToString();
                txt_ecd_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECD_007"].ToString();
                txt_egu_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EGU_007"].ToString();
                txt_eso_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESO_007"].ToString();
                txt_esi_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ESI_007"].ToString();
                txt_ecr_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ECR_007"].ToString();
                txt_eod_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EOD_007"].ToString();
                txt_eaw_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_EAW_007"].ToString();
                txt_ed1_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED1_007"].ToString();
                txt_ed2_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_ED2_007"].ToString();
                txt_pco_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_REF"].ToString();
                txt_pcv_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_REF"].ToString();
                txt_drt_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_REF"].ToString();
                txt_tal_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_REF"].ToString();
                txt_val_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_REF"].ToString();
                txt_sje_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_REF"].ToString();
                txt_pco_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_001"].ToString();
                txt_pcv_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_001"].ToString();
                txt_drt_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_001"].ToString();
                txt_tal_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_001"].ToString();
                txt_val_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_001"].ToString();
                txt_sje_001_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_001"].ToString();
                txt_pco_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_002"].ToString();
                txt_pcv_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_002"].ToString();
                txt_drt_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_002"].ToString();
                txt_tal_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_002"].ToString();
                txt_val_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_002"].ToString();
                txt_sje_002_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_002"].ToString();
                txt_pco_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_003"].ToString();
                txt_pcv_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_003"].ToString();
                txt_drt_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_003"].ToString();
                txt_tal_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_003"].ToString();
                txt_val_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_003"].ToString();
                txt_sje_003_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_003"].ToString();
                txt_pco_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_004"].ToString();
                txt_pcv_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_004"].ToString();
                txt_drt_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_004"].ToString();
                txt_tal_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_004"].ToString();
                txt_val_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_004"].ToString();
                txt_sje_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_004"].ToString();
                txt_pco_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_005"].ToString();
                txt_pcv_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_005"].ToString();
                txt_drt_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_005"].ToString();
                txt_tal_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_005"].ToString();
                txt_val_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_005"].ToString();
                txt_sje_005_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_005"].ToString();
                txt_pco_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_006"].ToString();
                txt_pcv_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_006"].ToString();
                txt_drt_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_006"].ToString();
                txt_tal_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_006"].ToString();
                txt_val_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_006"].ToString();
                txt_sje_006_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_006"].ToString();
                txt_pco_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCO_007"].ToString();
                txt_pcv_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_PCV_007"].ToString();
                txt_drt_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DRT_007"].ToString();
                txt_tal_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_TAL_007"].ToString();
                txt_val_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VAL_007"].ToString();
                txt_sje_007_inc.Text = dsTeste.Tables[0].Rows[0]["TST_SJE_007"].ToString();
                
                txt_det_inc.Text = dsTeste.Tables[0].Rows[0]["TST_DET"].ToString();

                txt_obs_inc.Text = dsTeste.Tables[0].Rows[0]["TST_OBS"].ToString();
                cbo_sts_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_STS"].ToString();

                CarregaDynafil();
                CarregaPerformance();
            }
            dsTeste.Dispose();
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

                txt_rts_inc.Focus();

            }
            else
            {
                divCadastro.Visible = false;
                dvFiltro.Visible = true;

                txt_rts.Focus();

            }
        }
    }

    private void LimpaTela()
    {
        txt_rts.Text = "";
        txt_lot.Text = "";
        txt_mge.Text = "";
        cbo_maq_tip_id.Text = "";
        txt_dat_ini.Text = "";
        txt_dat_fim.Text = "";
        cbo_sts.Text = "";

        txt_rts_inc.Text = "";
        txt_lot_inc.Text = "";
        txt_lot_ref_inc.Text = "";
        txt_lot_ref_inc.ReadOnly = false;
        txt_lot_epf_inc.Text = "";
        txt_lot_ans_inc.Text = "";
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        txt_des_inc.Text = "";
        txt_mge_inc.Text = "";
        txt_mge_002_inc.Text = "";
        txt_mge_003_inc.Text = "";
        txt_mge_ref_inc.Text = "";
        txt_mge_002_ref_inc.Text = "";
        txt_mge_003_ref_inc.Text = "";
        cbo_for_001_id_inc.SelectedIndex = 0;
        cbo_for_002_id_inc.SelectedIndex = 0;
        cbo_for_003_id_inc.SelectedIndex = 0;
        //Excluído por solicitação do Wagner 11/07/2011
        //txt_vlc_inc.Text = "";
        cbo_aps_id_inc.SelectedIndex = 0;
        cbo_maq_tip_id_inc.SelectedIndex = 0;
        cbo_ert_id_inc.SelectedIndex = 0;
        txt_dat_ini_inc.Text = "";
        txt_hor_ini_inc.Text = "";
        txt_dat_fim_inc.Text = "";
        txt_hor_fim_inc.Text = "";
        txt_hor_gst_inc.Text = "";
        txt_vw2_ref_inc.Text = "";
        txt_egm_ref_inc.Text = "";
        txt_dyy_ref_inc.Text = "";
        txt_2wx_ref_inc.Text = "";
        txt_3w3_ref_inc.Text = "";
        txt_4w4_ref_inc.Text = "";
        txt_agl_ref_inc.Text = "";
        txt_tup_ref_inc.Text = "";
        txt_veo_ref_inc.Text = "";
        txt_t1t_ref_inc.Text = "";
        txt_t1c_ref_inc.Text = "";
        txt_t1l_ref_inc.Text = "";
        txt_t2f_ref_inc.Text = "";
        txt_sve_ref_inc.Text = "";
        txt_stf_ref_inc.Text = "";
        txt_stm_ref_inc.Text = "";
        txt_sce_ref_inc.Text = "";
        txt_sco_ref_inc.Text = "";
        txt_sch_ref_inc.Text = "";
        txt_scg_ref_inc.Text = "";
        txt_see_ref_inc.Text = "";
        txt_seo_ref_inc.Text = "";
        txt_seh_ref_inc.Text = "";
        txt_seg_ref_inc.Text = "";
        txt_sjc_ref_inc.Text = "";
        txt_sjt_ref_inc.Text = "";
        txt_sjb_ref_inc.Text = "";
        txt_spj_ref_inc.Text = "";
        txt_sbc_ref_inc.Text = "";
        txt_spo_ref_inc.Text = "";
        txt_sva_ref_inc.Text = "";
        txt_tgr_ref_inc.Text = "";
        txt_tip_ref_inc.Text = "";
        txt_dsb_ref_inc.Text = "";
        txt_tca_ref_inc.Text = "";
        txt_fmc_ref_inc.Text = "";
        txt_1tb_ref_inc.Text = "";
        txt_1pp_ref_inc.Text = "";
        txt_2tb_ref_inc.Text = "";
        txt_2pp_ref_inc.Text = "";
        txt_cso_ref_inc.Text = "";
        txt_esp_ref_inc.Text = "";
        txt_tol_ref_inc.Text = "";
        txt_p1c_ref_inc.Text = "";
        txt_p2d_ref_inc.Text = "";
        txt_p3d_ref_inc.Text = "";
        txt_p4u_ref_inc.Text = "";
        txt_mol_ref_inc.Text = "";
        txt_tpd_ref_inc.Text = "";
        txt_tt1_ref_inc.Text = "";
        txt_tt2_ref_inc.Text = "";
        txt_tt3_ref_inc.Text = "";
        txt_t21_ref_inc.Text = "";
        txt_tun_ref_inc.Text = "";
        txt_tcv_ref_inc.Text = "";
        txt_tss_ref_inc.Text = "";
        txt_tit_ref_inc.Text = "";
        txt_tnc_ref_inc.Text = "";
        txt_aon_ref_inc.Text = "";
        txt_enm_ref_inc.Text = "";
        txt_eee_ref_inc.Text = "";
        txt_kkk_ref_inc.Text = "";
        txt_bbb_ref_inc.Text = "";
        txt_ole_ref_inc.Text = "";
        txt_trq_ref_inc.Text = "";
        txt_ert_ref_inc.Text = "";
        txt_rt3_ref_inc.Text = "";
        txt_rt5_ref_inc.Text = "";
        txt_dnd_ref_inc.Text = "";
        txt_dmo_ref_inc.Text = "";
        txt_pes_ref_inc.Text = "";
        txt_vrr_ref_inc.Text = "";

        txt_tre_ref_inc.Text = "";
        txt_lme_ref_inc.Text = "";
        txt_ume_ref_inc.Text = "";
        txt_lpe_ref_inc.Text = "";
        txt_upe_ref_inc.Text = "";
        txt_ucv_ref_inc.Text = "";
        txt_dur_ref_inc.Text = "";
        txt_dft_ref_inc.Text = "";
        txt_lmc_ref_inc.Text = "";
        txt_umc_ref_inc.Text = "";
        txt_lpc_ref_inc.Text = "";
        txt_upc_ref_inc.Text = "";
        txt_cvc_ref_inc.Text = "";
        txt_dfc_ref_inc.Text = "";
        txt_tfs_ref_inc.Text = "";
        txt_fsw_ref_inc.Text = "";
        txt_wfw_ref_inc.Text = "";
        txt_eco_ref_inc.Text = "";
        txt_eol_ref_inc.Text = "";
        txt_etu_ref_inc.Text = "";
        txt_etd_ref_inc.Text = "";
        txt_ecu_ref_inc.Text = "";
        txt_egd_ref_inc.Text = "";
        txt_eec_ref_inc.Text = "";
        txt_ecd_ref_inc.Text = "";
        txt_egu_ref_inc.Text = "";
        txt_eso_ref_inc.Text = "";
        txt_esi_ref_inc.Text = "";
        txt_ecr_ref_inc.Text = "";
        txt_eod_ref_inc.Text = "";
        txt_eaw_ref_inc.Text = "";
        txt_ed1_ref_inc.Text = "";
        txt_ed2_ref_inc.Text = "";

        txt_vw2_001_inc.Text = "";
        txt_egm_001_inc.Text = "";
        txt_dyy_001_inc.Text = "";
        txt_2wx_001_inc.Text = "";
        txt_3w3_001_inc.Text = "";
        txt_4w4_001_inc.Text = "";
        txt_agl_001_inc.Text = "";
        txt_tup_001_inc.Text = "";
        txt_veo_001_inc.Text = "";
        txt_t1t_001_inc.Text = "";
        txt_t1c_001_inc.Text = "";
        txt_t1l_001_inc.Text = "";
        txt_t2f_001_inc.Text = "";
        txt_sve_001_inc.Text = "";
        txt_stf_001_inc.Text = "";
        txt_stm_001_inc.Text = "";
        txt_sce_001_inc.Text = "";
        txt_sco_001_inc.Text = "";
        txt_sch_001_inc.Text = "";
        txt_scg_001_inc.Text = "";
        txt_see_001_inc.Text = "";
        txt_seo_001_inc.Text = "";
        txt_seh_001_inc.Text = "";
        txt_seg_001_inc.Text = "";
        txt_sjc_001_inc.Text = "";
        txt_sjt_001_inc.Text = "";
        txt_sjb_001_inc.Text = "";
        txt_spj_001_inc.Text = "";
        txt_sbc_001_inc.Text = "";
        txt_spo_001_inc.Text = "";
        txt_sva_001_inc.Text = "";
        txt_tgr_001_inc.Text = "";
        txt_tip_001_inc.Text = "";
        txt_dsb_001_inc.Text = "";
        txt_tca_001_inc.Text = "";
        txt_fmc_001_inc.Text = "";
        txt_1tb_001_inc.Text = "";
        txt_1pp_001_inc.Text = "";
        txt_2tb_001_inc.Text = "";
        txt_2pp_001_inc.Text = "";
        txt_cso_001_inc.Text = "";
        txt_esp_001_inc.Text = "";
        txt_tol_001_inc.Text = "";
        txt_p1c_001_inc.Text = "";
        txt_p2d_001_inc.Text = "";
        txt_p3d_001_inc.Text = "";
        txt_p4u_001_inc.Text = "";
        txt_mol_001_inc.Text = "";
        txt_tpd_001_inc.Text = "";
        txt_tt1_001_inc.Text = "";
        txt_tt2_001_inc.Text = "";
        txt_tt3_001_inc.Text = "";
        txt_t21_001_inc.Text = "";
        txt_tun_001_inc.Text = "";
        txt_tcv_001_inc.Text = "";
        txt_tss_001_inc.Text = "";
        txt_tit_001_inc.Text = "";
        txt_tnc_001_inc.Text = "";
        txt_aon_001_inc.Text = "";
        txt_enm_001_inc.Text = "";
        txt_eee_001_inc.Text = "";
        txt_kkk_001_inc.Text = "";
        txt_bbb_001_inc.Text = "";
        txt_ole_001_inc.Text = "";
        txt_trq_001_inc.Text = "";
        txt_ert_001_inc.Text = "";
        txt_rt3_001_inc.Text = "";
        txt_rt5_001_inc.Text = "";
        txt_dnd_001_inc.Text = "";
        txt_dmo_001_inc.Text = "";
        txt_pes_001_inc.Text = "";
        txt_vrr_001_inc.Text = "";

        txt_tre_001_inc.Text = "";
        txt_lme_001_inc.Text = "";
        txt_ume_001_inc.Text = "";
        txt_lpe_001_inc.Text = "";
        txt_upe_001_inc.Text = "";
        txt_ucv_001_inc.Text = "";
        txt_dur_001_inc.Text = "";
        txt_dft_001_inc.Text = "";
        txt_lmc_001_inc.Text = "";
        txt_umc_001_inc.Text = "";
        txt_lpc_001_inc.Text = "";
        txt_upc_001_inc.Text = "";
        txt_cvc_001_inc.Text = "";
        txt_dfc_001_inc.Text = "";
        txt_tfs_001_inc.Text = "";
        txt_fsw_001_inc.Text = "";
        txt_wfw_001_inc.Text = "";
        txt_eco_001_inc.Text = "";
        txt_eol_001_inc.Text = "";
        txt_etu_001_inc.Text = "";
        txt_etd_001_inc.Text = "";
        txt_ecu_001_inc.Text = "";
        txt_egd_001_inc.Text = "";
        txt_eec_001_inc.Text = "";
        txt_ecd_001_inc.Text = "";
        txt_egu_001_inc.Text = "";
        txt_eso_001_inc.Text = "";
        txt_esi_001_inc.Text = "";
        txt_ecr_001_inc.Text = "";
        txt_eod_001_inc.Text = "";
        txt_eaw_001_inc.Text = "";
        txt_ed1_001_inc.Text = "";
        txt_ed2_001_inc.Text = "";

        txt_vw2_002_inc.Text = "";
        txt_egm_002_inc.Text = "";
        txt_dyy_002_inc.Text = "";
        txt_2wx_002_inc.Text = "";
        txt_3w3_002_inc.Text = "";
        txt_4w4_002_inc.Text = "";
        txt_agl_002_inc.Text = "";
        txt_tup_002_inc.Text = "";
        txt_veo_002_inc.Text = "";
        txt_t1t_002_inc.Text = "";
        txt_t1c_002_inc.Text = "";
        txt_t1l_002_inc.Text = "";
        txt_t2f_002_inc.Text = "";
        txt_sve_002_inc.Text = "";
        txt_stf_002_inc.Text = "";
        txt_stm_002_inc.Text = "";
        txt_sce_002_inc.Text = "";
        txt_sco_002_inc.Text = "";
        txt_sch_002_inc.Text = "";
        txt_scg_002_inc.Text = "";
        txt_see_002_inc.Text = "";
        txt_seo_002_inc.Text = "";
        txt_seh_002_inc.Text = "";
        txt_seg_002_inc.Text = "";
        txt_sjc_002_inc.Text = "";
        txt_sjt_002_inc.Text = "";
        txt_sjb_002_inc.Text = "";
        txt_spj_002_inc.Text = "";
        txt_sbc_002_inc.Text = "";
        txt_spo_002_inc.Text = "";
        txt_sva_002_inc.Text = "";
        txt_tgr_002_inc.Text = "";
        txt_tip_002_inc.Text = "";
        txt_dsb_002_inc.Text = "";
        txt_tca_002_inc.Text = "";
        txt_fmc_002_inc.Text = "";
        txt_1tb_002_inc.Text = "";
        txt_1pp_002_inc.Text = "";
        txt_2tb_002_inc.Text = "";
        txt_2pp_002_inc.Text = "";
        txt_cso_002_inc.Text = "";
        txt_esp_002_inc.Text = "";
        txt_tol_002_inc.Text = "";
        txt_p1c_002_inc.Text = "";
        txt_p2d_002_inc.Text = "";
        txt_p3d_002_inc.Text = "";
        txt_p4u_002_inc.Text = "";
        txt_mol_002_inc.Text = "";
        txt_tpd_002_inc.Text = "";
        txt_tt1_002_inc.Text = "";
        txt_tt2_002_inc.Text = "";
        txt_tt3_002_inc.Text = "";
        txt_t21_002_inc.Text = "";
        txt_tun_002_inc.Text = "";
        txt_tcv_002_inc.Text = "";
        txt_tss_002_inc.Text = "";
        txt_tit_002_inc.Text = "";
        txt_tnc_002_inc.Text = "";
        txt_aon_002_inc.Text = "";
        txt_enm_002_inc.Text = "";
        txt_eee_002_inc.Text = "";
        txt_kkk_002_inc.Text = "";
        txt_bbb_002_inc.Text = "";
        txt_ole_002_inc.Text = "";
        txt_trq_002_inc.Text = "";
        txt_ert_002_inc.Text = "";
        txt_rt3_002_inc.Text = "";
        txt_rt5_002_inc.Text = "";
        txt_dnd_002_inc.Text = "";
        txt_dmo_002_inc.Text = "";
        txt_pes_002_inc.Text = "";
        txt_vrr_002_inc.Text = "";

        txt_tre_002_inc.Text = "";
        txt_lme_002_inc.Text = "";
        txt_ume_002_inc.Text = "";
        txt_lpe_002_inc.Text = "";
        txt_upe_002_inc.Text = "";
        txt_ucv_002_inc.Text = "";
        txt_dur_002_inc.Text = "";
        txt_dft_002_inc.Text = "";
        txt_lmc_002_inc.Text = "";
        txt_umc_002_inc.Text = "";
        txt_lpc_002_inc.Text = "";
        txt_upc_002_inc.Text = "";
        txt_cvc_002_inc.Text = "";
        txt_dfc_002_inc.Text = "";
        txt_tfs_002_inc.Text = "";
        txt_fsw_002_inc.Text = "";
        txt_wfw_002_inc.Text = "";
        txt_eco_002_inc.Text = "";
        txt_eol_002_inc.Text = "";
        txt_etu_002_inc.Text = "";
        txt_etd_002_inc.Text = "";
        txt_ecu_002_inc.Text = "";
        txt_egd_002_inc.Text = "";
        txt_eec_002_inc.Text = "";
        txt_ecd_002_inc.Text = "";
        txt_egu_002_inc.Text = "";
        txt_eso_002_inc.Text = "";
        txt_esi_002_inc.Text = "";
        txt_ecr_002_inc.Text = "";
        txt_eod_002_inc.Text = "";
        txt_eaw_002_inc.Text = "";
        txt_ed1_002_inc.Text = "";
        txt_ed2_002_inc.Text = "";

        txt_vw2_003_inc.Text = "";
        txt_egm_003_inc.Text = "";
        txt_dyy_003_inc.Text = "";
        txt_2wx_003_inc.Text = "";
        txt_3w3_003_inc.Text = "";
        txt_4w4_003_inc.Text = "";
        txt_agl_003_inc.Text = "";
        txt_tup_003_inc.Text = "";
        txt_veo_003_inc.Text = "";
        txt_t1t_003_inc.Text = "";
        txt_t1c_003_inc.Text = "";
        txt_t1l_003_inc.Text = "";
        txt_t2f_003_inc.Text = "";
        txt_sve_003_inc.Text = "";
        txt_stf_003_inc.Text = "";
        txt_stm_003_inc.Text = "";
        txt_sce_003_inc.Text = "";
        txt_sco_003_inc.Text = "";
        txt_sch_003_inc.Text = "";
        txt_scg_003_inc.Text = "";
        txt_see_003_inc.Text = "";
        txt_seo_003_inc.Text = "";
        txt_seh_003_inc.Text = "";
        txt_seg_003_inc.Text = "";
        txt_sjc_003_inc.Text = "";
        txt_sjt_003_inc.Text = "";
        txt_sjb_003_inc.Text = "";
        txt_spj_003_inc.Text = "";
        txt_sbc_003_inc.Text = "";
        txt_spo_003_inc.Text = "";
        txt_sva_003_inc.Text = "";
        txt_tgr_003_inc.Text = "";
        txt_tip_003_inc.Text = "";
        txt_dsb_003_inc.Text = "";
        txt_tca_003_inc.Text = "";
        txt_fmc_003_inc.Text = "";
        txt_1tb_003_inc.Text = "";
        txt_1pp_003_inc.Text = "";
        txt_2tb_003_inc.Text = "";
        txt_2pp_003_inc.Text = "";
        txt_cso_003_inc.Text = "";
        txt_esp_003_inc.Text = "";
        txt_tol_003_inc.Text = "";
        txt_p1c_003_inc.Text = "";
        txt_p2d_003_inc.Text = "";
        txt_p3d_003_inc.Text = "";
        txt_p4u_003_inc.Text = "";
        txt_mol_003_inc.Text = "";
        txt_tpd_003_inc.Text = "";
        txt_tt1_003_inc.Text = "";
        txt_tt2_003_inc.Text = "";
        txt_tt3_003_inc.Text = "";
        txt_t21_003_inc.Text = "";
        txt_tun_003_inc.Text = "";
        txt_tcv_003_inc.Text = "";
        txt_tss_003_inc.Text = "";
        txt_tit_003_inc.Text = "";
        txt_tnc_003_inc.Text = "";
        txt_aon_003_inc.Text = "";
        txt_enm_003_inc.Text = "";
        txt_eee_003_inc.Text = "";
        txt_kkk_003_inc.Text = "";
        txt_bbb_003_inc.Text = "";
        txt_ole_003_inc.Text = "";
        txt_trq_003_inc.Text = "";
        txt_ert_003_inc.Text = "";
        txt_rt3_003_inc.Text = "";
        txt_rt5_003_inc.Text = "";
        txt_dnd_003_inc.Text = "";
        txt_dmo_003_inc.Text = "";
        txt_pes_003_inc.Text = "";
        txt_vrr_003_inc.Text = "";

        txt_tre_003_inc.Text = "";
        txt_lme_003_inc.Text = "";
        txt_ume_003_inc.Text = "";
        txt_lpe_003_inc.Text = "";
        txt_upe_003_inc.Text = "";
        txt_ucv_003_inc.Text = "";
        txt_dur_003_inc.Text = "";
        txt_dft_003_inc.Text = "";
        txt_lmc_003_inc.Text = "";
        txt_umc_003_inc.Text = "";
        txt_lpc_003_inc.Text = "";
        txt_upc_003_inc.Text = "";
        txt_cvc_003_inc.Text = "";
        txt_dfc_003_inc.Text = "";
        txt_tfs_003_inc.Text = "";
        txt_fsw_003_inc.Text = "";
        txt_wfw_003_inc.Text = "";
        txt_eco_003_inc.Text = "";
        txt_eol_003_inc.Text = "";
        txt_etu_003_inc.Text = "";
        txt_etd_003_inc.Text = "";
        txt_ecu_003_inc.Text = "";
        txt_egd_003_inc.Text = "";
        txt_eec_003_inc.Text = "";
        txt_ecd_003_inc.Text = "";
        txt_egu_003_inc.Text = "";
        txt_eso_003_inc.Text = "";
        txt_esi_003_inc.Text = "";
        txt_ecr_003_inc.Text = "";
        txt_eod_003_inc.Text = "";
        txt_eaw_003_inc.Text = "";
        txt_ed1_003_inc.Text = "";
        txt_ed2_003_inc.Text = "";

        txt_vw2_004_inc.Text = "";
        txt_egm_004_inc.Text = "";
        txt_dyy_004_inc.Text = "";
        txt_2wx_004_inc.Text = "";
        txt_3w3_004_inc.Text = "";
        txt_4w4_004_inc.Text = "";
        txt_agl_004_inc.Text = "";
        txt_tup_004_inc.Text = "";
        txt_veo_004_inc.Text = "";
        txt_t1t_004_inc.Text = "";
        txt_t1c_004_inc.Text = "";
        txt_t1l_004_inc.Text = "";
        txt_t2f_004_inc.Text = "";
        txt_sve_004_inc.Text = "";
        txt_stf_004_inc.Text = "";
        txt_stm_004_inc.Text = "";
        txt_sce_004_inc.Text = "";
        txt_sco_004_inc.Text = "";
        txt_sch_004_inc.Text = "";
        txt_scg_004_inc.Text = "";
        txt_see_004_inc.Text = "";
        txt_seo_004_inc.Text = "";
        txt_seh_004_inc.Text = "";
        txt_seg_004_inc.Text = "";
        txt_sjc_004_inc.Text = "";
        txt_sjt_004_inc.Text = "";
        txt_sjb_004_inc.Text = "";
        txt_spj_004_inc.Text = "";
        txt_sbc_004_inc.Text = "";
        txt_spo_004_inc.Text = "";
        txt_sva_004_inc.Text = "";
        txt_tgr_004_inc.Text = "";
        txt_tip_004_inc.Text = "";
        txt_dsb_004_inc.Text = "";
        txt_tca_004_inc.Text = "";
        txt_fmc_004_inc.Text = "";
        txt_1tb_004_inc.Text = "";
        txt_1pp_004_inc.Text = "";
        txt_2tb_004_inc.Text = "";
        txt_2pp_004_inc.Text = "";
        txt_cso_004_inc.Text = "";
        txt_esp_004_inc.Text = "";
        txt_tol_004_inc.Text = "";
        txt_p1c_004_inc.Text = "";
        txt_p2d_004_inc.Text = "";
        txt_p3d_004_inc.Text = "";
        txt_p4u_004_inc.Text = "";
        txt_mol_004_inc.Text = "";
        txt_tpd_004_inc.Text = "";
        txt_tt1_004_inc.Text = "";
        txt_tt2_004_inc.Text = "";
        txt_tt3_004_inc.Text = "";
        txt_t21_004_inc.Text = "";
        txt_tun_004_inc.Text = "";
        txt_tcv_004_inc.Text = "";
        txt_tss_004_inc.Text = "";
        txt_tit_004_inc.Text = "";
        txt_tnc_004_inc.Text = "";
        txt_aon_004_inc.Text = "";
        txt_enm_004_inc.Text = "";
        txt_eee_004_inc.Text = "";
        txt_kkk_004_inc.Text = "";
        txt_bbb_004_inc.Text = "";
        txt_ole_004_inc.Text = "";
        txt_trq_004_inc.Text = "";
        txt_ert_004_inc.Text = "";
        txt_rt3_004_inc.Text = "";
        txt_rt5_004_inc.Text = "";
        txt_dnd_004_inc.Text = "";
        txt_dmo_004_inc.Text = "";
        txt_pes_004_inc.Text = "";
        txt_vrr_004_inc.Text = "";

        txt_tre_004_inc.Text = "";
        txt_lme_004_inc.Text = "";
        txt_ume_004_inc.Text = "";
        txt_lpe_004_inc.Text = "";
        txt_upe_004_inc.Text = "";
        txt_ucv_004_inc.Text = "";
        txt_dur_004_inc.Text = "";
        txt_dft_004_inc.Text = "";
        txt_lmc_004_inc.Text = "";
        txt_umc_004_inc.Text = "";
        txt_lpc_004_inc.Text = "";
        txt_upc_004_inc.Text = "";
        txt_cvc_004_inc.Text = "";
        txt_dfc_004_inc.Text = "";
        txt_tfs_004_inc.Text = "";
        txt_fsw_004_inc.Text = "";
        txt_wfw_004_inc.Text = "";
        txt_eco_004_inc.Text = "";
        txt_eol_004_inc.Text = "";
        txt_etu_004_inc.Text = "";
        txt_etd_004_inc.Text = "";
        txt_ecu_004_inc.Text = "";
        txt_egd_004_inc.Text = "";
        txt_eec_004_inc.Text = "";
        txt_ecd_004_inc.Text = "";
        txt_egu_004_inc.Text = "";
        txt_eso_004_inc.Text = "";
        txt_esi_004_inc.Text = "";
        txt_ecr_004_inc.Text = "";
        txt_eod_004_inc.Text = "";
        txt_eaw_004_inc.Text = "";
        txt_ed1_004_inc.Text = "";
        txt_ed2_004_inc.Text = "";

        txt_vw2_005_inc.Text = "";
        txt_egm_005_inc.Text = "";
        txt_dyy_005_inc.Text = "";
        txt_2wx_005_inc.Text = "";
        txt_3w3_005_inc.Text = "";
        txt_4w4_005_inc.Text = "";
        txt_agl_005_inc.Text = "";
        txt_tup_005_inc.Text = "";
        txt_veo_005_inc.Text = "";
        txt_t1t_005_inc.Text = "";
        txt_t1c_005_inc.Text = "";
        txt_t1l_005_inc.Text = "";
        txt_t2f_005_inc.Text = "";
        txt_sve_005_inc.Text = "";
        txt_stf_005_inc.Text = "";
        txt_stm_005_inc.Text = "";
        txt_sce_005_inc.Text = "";
        txt_sco_005_inc.Text = "";
        txt_sch_005_inc.Text = "";
        txt_scg_005_inc.Text = "";
        txt_see_005_inc.Text = "";
        txt_seo_005_inc.Text = "";
        txt_seh_005_inc.Text = "";
        txt_seg_005_inc.Text = "";
        txt_sjc_005_inc.Text = "";
        txt_sjt_005_inc.Text = "";
        txt_sjb_005_inc.Text = "";
        txt_spj_005_inc.Text = "";
        txt_sbc_005_inc.Text = "";
        txt_spo_005_inc.Text = "";
        txt_sva_005_inc.Text = "";
        txt_tgr_005_inc.Text = "";
        txt_tip_005_inc.Text = "";
        txt_dsb_005_inc.Text = "";
        txt_tca_005_inc.Text = "";
        txt_fmc_005_inc.Text = "";
        txt_1tb_005_inc.Text = "";
        txt_1pp_005_inc.Text = "";
        txt_2tb_005_inc.Text = "";
        txt_2pp_005_inc.Text = "";
        txt_cso_005_inc.Text = "";
        txt_esp_005_inc.Text = "";
        txt_tol_005_inc.Text = "";
        txt_p1c_005_inc.Text = "";
        txt_p2d_005_inc.Text = "";
        txt_p3d_005_inc.Text = "";
        txt_p4u_005_inc.Text = "";
        txt_mol_005_inc.Text = "";
        txt_tpd_005_inc.Text = "";
        txt_tt1_005_inc.Text = "";
        txt_tt2_005_inc.Text = "";
        txt_tt3_005_inc.Text = "";
        txt_t21_005_inc.Text = "";
        txt_tun_005_inc.Text = "";
        txt_tcv_005_inc.Text = "";
        txt_tss_005_inc.Text = "";
        txt_tit_005_inc.Text = "";
        txt_tnc_005_inc.Text = "";
        txt_aon_005_inc.Text = "";
        txt_enm_005_inc.Text = "";
        txt_eee_005_inc.Text = "";
        txt_kkk_005_inc.Text = "";
        txt_bbb_005_inc.Text = "";
        txt_ole_005_inc.Text = "";
        txt_trq_005_inc.Text = "";
        txt_ert_005_inc.Text = "";
        txt_rt3_005_inc.Text = "";
        txt_rt5_005_inc.Text = "";
        txt_dnd_005_inc.Text = "";
        txt_dmo_005_inc.Text = "";
        txt_pes_005_inc.Text = "";
        txt_vrr_005_inc.Text = "";

        txt_tre_005_inc.Text = "";
        txt_lme_005_inc.Text = "";
        txt_ume_005_inc.Text = "";
        txt_lpe_005_inc.Text = "";
        txt_upe_005_inc.Text = "";
        txt_ucv_005_inc.Text = "";
        txt_dur_005_inc.Text = "";
        txt_dft_005_inc.Text = "";
        txt_lmc_005_inc.Text = "";
        txt_umc_005_inc.Text = "";
        txt_lpc_005_inc.Text = "";
        txt_upc_005_inc.Text = "";
        txt_cvc_005_inc.Text = "";
        txt_dfc_005_inc.Text = "";
        txt_tfs_005_inc.Text = "";
        txt_fsw_005_inc.Text = "";
        txt_wfw_005_inc.Text = "";
        txt_eco_005_inc.Text = "";
        txt_eol_005_inc.Text = "";
        txt_etu_005_inc.Text = "";
        txt_etd_005_inc.Text = "";
        txt_ecu_005_inc.Text = "";
        txt_egd_005_inc.Text = "";
        txt_eec_005_inc.Text = "";
        txt_ecd_005_inc.Text = "";
        txt_egu_005_inc.Text = "";
        txt_eso_005_inc.Text = "";
        txt_esi_005_inc.Text = "";
        txt_ecr_005_inc.Text = "";
        txt_eod_005_inc.Text = "";
        txt_eaw_005_inc.Text = "";
        txt_ed1_005_inc.Text = "";
        txt_ed2_005_inc.Text = "";

        txt_vw2_006_inc.Text = "";
        txt_egm_006_inc.Text = "";
        txt_dyy_006_inc.Text = "";
        txt_2wx_006_inc.Text = "";
        txt_3w3_006_inc.Text = "";
        txt_4w4_006_inc.Text = "";
        txt_agl_006_inc.Text = "";
        txt_tup_006_inc.Text = "";
        txt_veo_006_inc.Text = "";
        txt_t1t_006_inc.Text = "";
        txt_t1c_006_inc.Text = "";
        txt_t1l_006_inc.Text = "";
        txt_t2f_006_inc.Text = "";
        txt_sve_006_inc.Text = "";
        txt_stf_006_inc.Text = "";
        txt_stm_006_inc.Text = "";
        txt_sce_006_inc.Text = "";
        txt_sco_006_inc.Text = "";
        txt_sch_006_inc.Text = "";
        txt_scg_006_inc.Text = "";
        txt_see_006_inc.Text = "";
        txt_seo_006_inc.Text = "";
        txt_seh_006_inc.Text = "";
        txt_seg_006_inc.Text = "";
        txt_sjc_006_inc.Text = "";
        txt_sjt_006_inc.Text = "";
        txt_sjb_006_inc.Text = "";
        txt_spj_006_inc.Text = "";
        txt_sbc_006_inc.Text = "";
        txt_spo_006_inc.Text = "";
        txt_sva_006_inc.Text = "";
        txt_tgr_006_inc.Text = "";
        txt_tip_006_inc.Text = "";
        txt_dsb_006_inc.Text = "";
        txt_tca_006_inc.Text = "";
        txt_fmc_006_inc.Text = "";
        txt_1tb_006_inc.Text = "";
        txt_1pp_006_inc.Text = "";
        txt_2tb_006_inc.Text = "";
        txt_2pp_006_inc.Text = "";
        txt_cso_006_inc.Text = "";
        txt_esp_006_inc.Text = "";
        txt_tol_006_inc.Text = "";
        txt_p1c_006_inc.Text = "";
        txt_p2d_006_inc.Text = "";
        txt_p3d_006_inc.Text = "";
        txt_p4u_006_inc.Text = "";
        txt_mol_006_inc.Text = "";
        txt_tpd_006_inc.Text = "";
        txt_tt1_006_inc.Text = "";
        txt_tt2_006_inc.Text = "";
        txt_tt3_006_inc.Text = "";
        txt_t21_006_inc.Text = "";
        txt_tun_006_inc.Text = "";
        txt_tcv_006_inc.Text = "";
        txt_tss_006_inc.Text = "";
        txt_tit_006_inc.Text = "";
        txt_tnc_006_inc.Text = "";
        txt_aon_006_inc.Text = "";
        txt_enm_006_inc.Text = "";
        txt_eee_006_inc.Text = "";
        txt_kkk_006_inc.Text = "";
        txt_bbb_006_inc.Text = "";
        txt_ole_006_inc.Text = "";
        txt_trq_006_inc.Text = "";
        txt_ert_006_inc.Text = "";
        txt_rt3_006_inc.Text = "";
        txt_rt5_006_inc.Text = "";
        txt_dnd_006_inc.Text = "";
        txt_dmo_006_inc.Text = "";
        txt_pes_006_inc.Text = "";
        txt_vrr_006_inc.Text = "";

        txt_tre_006_inc.Text = "";
        txt_lme_006_inc.Text = "";
        txt_ume_006_inc.Text = "";
        txt_lpe_006_inc.Text = "";
        txt_upe_006_inc.Text = "";
        txt_ucv_006_inc.Text = "";
        txt_dur_006_inc.Text = "";
        txt_dft_006_inc.Text = "";
        txt_lmc_006_inc.Text = "";
        txt_umc_006_inc.Text = "";
        txt_lpc_006_inc.Text = "";
        txt_upc_006_inc.Text = "";
        txt_cvc_006_inc.Text = "";
        txt_dfc_006_inc.Text = "";
        txt_tfs_006_inc.Text = "";
        txt_fsw_006_inc.Text = "";
        txt_wfw_006_inc.Text = "";
        txt_eol_006_inc.Text = "";
        txt_etu_006_inc.Text = "";
        txt_etd_006_inc.Text = "";
        txt_ecu_006_inc.Text = "";
        txt_egd_006_inc.Text = "";
        txt_eec_006_inc.Text = "";
        txt_ecd_006_inc.Text = "";
        txt_egu_006_inc.Text = "";
        txt_eso_006_inc.Text = "";
        txt_esi_006_inc.Text = "";
        txt_ecr_006_inc.Text = "";
        txt_eod_006_inc.Text = "";
        txt_eaw_006_inc.Text = "";
        txt_ed1_006_inc.Text = "";
        txt_ed2_006_inc.Text = "";

        txt_vw2_007_inc.Text = "";
        txt_egm_007_inc.Text = "";
        txt_dyy_007_inc.Text = "";
        txt_2wx_007_inc.Text = "";
        txt_3w3_007_inc.Text = "";
        txt_4w4_007_inc.Text = "";
        txt_agl_007_inc.Text = "";
        txt_tup_007_inc.Text = "";
        txt_veo_007_inc.Text = "";
        txt_t1t_007_inc.Text = "";
        txt_t1c_007_inc.Text = "";
        txt_t1l_007_inc.Text = "";
        txt_t2f_007_inc.Text = "";
        txt_sve_007_inc.Text = "";
        txt_stf_007_inc.Text = "";
        txt_stm_007_inc.Text = "";
        txt_sce_007_inc.Text = "";
        txt_sco_007_inc.Text = "";
        txt_sch_007_inc.Text = "";
        txt_scg_007_inc.Text = "";
        txt_see_007_inc.Text = "";
        txt_seo_007_inc.Text = "";
        txt_seh_007_inc.Text = "";
        txt_seg_007_inc.Text = "";
        txt_sjc_007_inc.Text = "";
        txt_sjt_007_inc.Text = "";
        txt_sjb_007_inc.Text = "";
        txt_spj_007_inc.Text = "";
        txt_sbc_007_inc.Text = "";
        txt_spo_007_inc.Text = "";
        txt_sva_007_inc.Text = "";
        txt_tgr_007_inc.Text = "";
        txt_tip_007_inc.Text = "";
        txt_dsb_007_inc.Text = "";
        txt_tca_007_inc.Text = "";
        txt_fmc_007_inc.Text = "";
        txt_1tb_007_inc.Text = "";
        txt_1pp_007_inc.Text = "";
        txt_2tb_007_inc.Text = "";
        txt_2pp_007_inc.Text = "";
        txt_cso_007_inc.Text = "";
        txt_esp_007_inc.Text = "";
        txt_tol_007_inc.Text = "";
        txt_p1c_007_inc.Text = "";
        txt_p2d_007_inc.Text = "";
        txt_p3d_007_inc.Text = "";
        txt_p4u_007_inc.Text = "";
        txt_mol_007_inc.Text = "";
        txt_tpd_007_inc.Text = "";
        txt_tt1_007_inc.Text = "";
        txt_tt2_007_inc.Text = "";
        txt_tt3_007_inc.Text = "";
        txt_t21_007_inc.Text = "";
        txt_tun_007_inc.Text = "";
        txt_tcv_007_inc.Text = "";
        txt_tss_007_inc.Text = "";
        txt_tit_007_inc.Text = "";
        txt_tnc_007_inc.Text = "";
        txt_aon_007_inc.Text = "";
        txt_enm_007_inc.Text = "";
        txt_eee_007_inc.Text = "";
        txt_kkk_007_inc.Text = "";
        txt_bbb_007_inc.Text = "";
        txt_ole_007_inc.Text = "";
        txt_trq_007_inc.Text = "";
        txt_ert_007_inc.Text = "";
        txt_rt3_007_inc.Text = "";
        txt_rt5_007_inc.Text = "";
        txt_dnd_007_inc.Text = "";
        txt_dmo_007_inc.Text = "";
        txt_pes_007_inc.Text = "";
        txt_vrr_007_inc.Text = "";

        txt_tre_007_inc.Text = "";
        txt_lme_007_inc.Text = "";
        txt_ume_007_inc.Text = "";
        txt_lpe_007_inc.Text = "";
        txt_upe_007_inc.Text = "";
        txt_ucv_007_inc.Text = "";
        txt_dur_007_inc.Text = "";
        txt_dft_007_inc.Text = "";
        txt_lmc_007_inc.Text = "";
        txt_umc_007_inc.Text = "";
        txt_lpc_007_inc.Text = "";
        txt_upc_007_inc.Text = "";
        txt_cvc_007_inc.Text = "";
        txt_dfc_007_inc.Text = "";
        txt_tfs_007_inc.Text = "";
        txt_fsw_007_inc.Text = "";
        txt_wfw_007_inc.Text = "";
        txt_eco_007_inc.Text = "";
        txt_eol_007_inc.Text = "";
        txt_etu_007_inc.Text = "";
        txt_etd_007_inc.Text = "";
        txt_ecu_007_inc.Text = "";
        txt_egd_007_inc.Text = "";
        txt_eec_007_inc.Text = "";
        txt_ecd_007_inc.Text = "";
        txt_egu_007_inc.Text = "";
        txt_eso_007_inc.Text = "";
        txt_esi_007_inc.Text = "";
        txt_ecr_007_inc.Text = "";
        txt_eod_007_inc.Text = "";
        txt_eaw_007_inc.Text = "";
        txt_ed1_007_inc.Text = "";
        txt_ed2_007_inc.Text = "";
        txt_pco_ref_inc.Text = "";
        txt_pcv_ref_inc.Text = "";
        txt_drt_ref_inc.Text = "";
        txt_tal_ref_inc.Text = "";
        txt_val_ref_inc.Text = "";
        txt_sje_ref_inc.Text = "";
        txt_pco_001_inc.Text = "";
        txt_pcv_001_inc.Text = "";
        txt_drt_001_inc.Text = "";
        txt_tal_001_inc.Text = "";
        txt_val_001_inc.Text = "";
        txt_sje_001_inc.Text = "";
        txt_pco_002_inc.Text = "";
        txt_pcv_002_inc.Text = "";
        txt_drt_002_inc.Text = "";
        txt_tal_002_inc.Text = "";
        txt_val_002_inc.Text = "";
        txt_sje_002_inc.Text = "";
        txt_pco_003_inc.Text = "";
        txt_pcv_003_inc.Text = "";
        txt_drt_003_inc.Text = "";
        txt_tal_003_inc.Text = "";
        txt_val_003_inc.Text = "";
        txt_sje_003_inc.Text = "";
        txt_pco_004_inc.Text = "";
        txt_pcv_004_inc.Text = "";
        txt_drt_004_inc.Text = "";
        txt_tal_004_inc.Text = "";
        txt_val_004_inc.Text = "";
        txt_sje_004_inc.Text = "";
        txt_pco_005_inc.Text = "";
        txt_pcv_005_inc.Text = "";
        txt_drt_005_inc.Text = "";
        txt_tal_005_inc.Text = "";
        txt_val_005_inc.Text = "";
        txt_sje_005_inc.Text = "";
        txt_pco_006_inc.Text = "";
        txt_pcv_006_inc.Text = "";
        txt_drt_006_inc.Text = "";
        txt_tal_006_inc.Text = "";
        txt_val_006_inc.Text = "";
        txt_sje_006_inc.Text = "";
        txt_pco_007_inc.Text = "";
        txt_pcv_007_inc.Text = "";
        txt_drt_007_inc.Text = "";
        txt_tal_007_inc.Text = "";
        txt_val_007_inc.Text = "";
        txt_sje_007_inc.Text = "";
        txt_det_inc.Text = "";

        txt_obs_inc.Text = "";
        cbo_sts_inc.SelectedIndex = 0;

        gvDynafil.DataBind();
        gvPerformance.DataBind();
    }

    protected void btNovoFiltro_Click(object sender, EventArgs e)
    {
        dvResultado.Visible = false;
        lbAcao.Text = "Novo";
        rowId.Value = null;
        LimpaTela();
        divCadastro.Visible = true;
        dvFiltro.Visible = false;
        txt_rts_inc.Focus();

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

    protected string CriaFiltro(Teste Teste)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_rts.Text))
        {
            Teste.TST_RTS_ID = Convert.ToInt32(txt_rts.Text);
            filtro = filtro + "RTS= " + txt_rts.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Teste.TST_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Teste.TST_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_maq_tip_id.Text))
        {
            Teste.TST_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id.SelectedValue);
            filtro = filtro + "Tipo Máquina= " + cbo_maq_tip_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            Teste.TST_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Início= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Teste.TST_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Fim= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Teste.TST_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Teste Teste = new Teste();
        filtro = CriaFiltro(Teste);
        DataSet dsTeste = Teste.Consultar();

        gvTeste.DataSource = dsTeste;
        gvTeste.DataBind();
        dsTeste.Dispose();
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

    protected void gvTeste_RowDataBound(object sender, GridViewRowEventArgs e)
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
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvTeste.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvTeste.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Teste.aspx?rowId=" + gvTeste.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvTeste.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvTeste.Columns.IndexOf(field);
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

    protected void gvTeste_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvTeste_Sorting(Object sender, GridViewSortEventArgs e)
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

        Teste Teste = new Teste();
        filtro = CriaFiltro(Teste);
        DataSet dsTeste = Teste.Consultar();

        DataTable dtTeste = dsTeste.Tables[0];
        DataView dvTeste = new DataView(dtTeste);
        dvTeste.Sort = e.SortExpression + Ordem;
        gvTeste.DataSource = dvTeste;
        gvTeste.DataBind();

        dvTeste.Dispose();
        dtTeste.Dispose();
        dsTeste.Dispose();
        Dispose();
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg;
        if (txt_rts_inc.Text == "")
        {
            TratamentoErro("O campo RTS é obrigatório.");
            txt_rts_inc.Focus();
            return;
        }

        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote é obrigatório.");
            txt_lot_inc.Focus();
            return;
        }

        if (txt_lot_ref_inc.Text == "")
        {
            TratamentoErro("O campo Lote Referência é obrigatório.");
            txt_lot_ref_inc.Focus();
            return;
        }
        /*
        if (txt_lot_epf_inc.Text == "")
        {
            TratamentoErro("O campo Lote Standard é obrigatório.");
            txt_lot_epf_inc.Focus();
            return;
        }

        if (txt_lot_ans_inc.Text == "")
        {
            TratamentoErro("O campo Lote Serimetria é obrigatório.");
            txt_lot_ans_inc.Focus();
            return;
        }
        */
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

        if (txt_mge_ref_inc.Text == "")
        {
            TratamentoErro("O campo Merge Referência é obrigatório.");
            txt_mge_ref_inc.Focus();
            return;
        }

        if (cbo_for_001_id_inc.Text == "")
        {
            TratamentoErro("O campo Fornecedor 1 é obrigatório.");
            cbo_for_001_id_inc.Focus();
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

        if (txt_dat_ini_inc.Text == "")
        {
            TratamentoErro("O campo Data Início é obrigatório.");
            txt_dat_ini_inc.Focus();
            return;
        }

        if (txt_hor_ini_inc.Text == "")
        {
            TratamentoErro("O campo Hora Início é obrigatório.");
            txt_hor_ini_inc.Focus();
            return;
        }

        if (txt_dat_fim_inc.Text == "")
        {
            TratamentoErro("O campo Data Fim é obrigatório.");
            txt_dat_fim_inc.Focus();
            return;
        }

        if (txt_hor_fim_inc.Text == "")
        {
            TratamentoErro("O campo Hora Fim é obrigatório.");
            txt_hor_fim_inc.Focus();
            return;
        }

        if (cbo_sts_inc.Text == "")
        {
            TratamentoErro("O campo Status é obrigatório.");
            cbo_sts_inc.Focus();
            return;
        }

        Teste Teste = new Teste();
        Teste.TST_RTS_ID = Convert.ToInt32(txt_rts_inc.Text);
        if (!string.IsNullOrEmpty(cbo_mtv_tst_id_inc.SelectedValue))
        {
            Teste.TST_RTS_MTV_TST_ID = Convert.ToInt32(cbo_mtv_tst_id_inc.SelectedValue);
        }
        Teste.TST_LOT = txt_lot_inc.Text;
        Teste.TST_LOT_REF = txt_lot_ref_inc.Text;
        Teste.TST_LOT_EPF = txt_lot_epf_inc.Text;
        Teste.TST_LOT_ANS = txt_lot_ans_inc.Text;
        if (cbo_tit_poy_id_inc.Text != "")
        {
            Teste.TST_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);
        }
        Teste.TST_DES = txt_des_inc.Text;
        Teste.TST_MGE = txt_mge_inc.Text;
        if (txt_mge_002_inc.Text != "")
        {
            Teste.TST_MGE_002 = txt_mge_002_inc.Text;
        }
        if (txt_mge_003_inc.Text != "")
        {
            Teste.TST_MGE_003 = txt_mge_003_inc.Text;
        }
        Teste.TST_MGE_REF = txt_mge_ref_inc.Text;
        if (txt_mge_002_ref_inc.Text != "")
        {
            Teste.TST_MGE_002_REF = txt_mge_002_ref_inc.Text;
        }
        if (txt_mge_003_ref_inc.Text != "")
        {
            Teste.TST_MGE_003_REF = txt_mge_003_ref_inc.Text;
        }
        if (cbo_for_001_id_inc.Text != "")
        {
            Teste.TST_FOR_001_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
        }
        if (cbo_for_002_id_inc.Text != "")
        {
            Teste.TST_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
        }
        if (cbo_for_003_id_inc.Text != "")
        {
            Teste.TST_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
        }
        //Excluído por solicitação do Wagner 11/07/2011
        //Teste.TST_VLC = txt_vlc_inc.Text;
        if (cbo_aps_id_inc.Text != "")
        {
            Teste.TST_APS_ID = Convert.ToInt32(cbo_aps_id_inc.SelectedValue);
        }
        if (cbo_maq_tip_id_inc.Text != "")
        {
            Teste.TST_MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
        }
        if (cbo_ert_id_inc.Text != "")
        {
            Teste.TST_ERT_ID = Convert.ToInt32(cbo_ert_id_inc.SelectedValue);
        }
        Teste.TST_DAT_INI = Convert.ToDateTime(txt_dat_ini_inc.Text + " " + txt_hor_ini_inc.Text);
        Teste.TST_DAT_FIM = Convert.ToDateTime(txt_dat_fim_inc.Text + " " + txt_hor_fim_inc.Text);
        Teste.TST_VW2_REF = txt_vw2_ref_inc.Text;
        Teste.TST_EGM_REF = txt_egm_ref_inc.Text;
        Teste.TST_DYY_REF = txt_dyy_ref_inc.Text;
        Teste.TST_2WX_REF = txt_2wx_ref_inc.Text;
        Teste.TST_3W3_REF = txt_3w3_ref_inc.Text;
        Teste.TST_4W4_REF = txt_4w4_ref_inc.Text;
        Teste.TST_AGL_REF = txt_agl_ref_inc.Text;
        Teste.TST_TUP_REF = txt_tup_ref_inc.Text;
        Teste.TST_VEO_REF = txt_veo_ref_inc.Text;
        Teste.TST_T1T_REF = txt_t1t_ref_inc.Text;
        Teste.TST_T1C_REF = txt_t1c_ref_inc.Text;
        Teste.TST_T1L_REF = txt_t1l_ref_inc.Text;
        Teste.TST_T2F_REF = txt_t2f_ref_inc.Text;
        Teste.TST_SVE_REF = txt_sve_ref_inc.Text;
        Teste.TST_STF_REF = txt_stf_ref_inc.Text;
        Teste.TST_STM_REF = txt_stm_ref_inc.Text;
        Teste.TST_SCE_REF = txt_sce_ref_inc.Text;
        Teste.TST_SCO_REF = txt_sco_ref_inc.Text;
        Teste.TST_SCH_REF = txt_sch_ref_inc.Text;
        Teste.TST_SCG_REF = txt_scg_ref_inc.Text;
        Teste.TST_SEE_REF = txt_see_ref_inc.Text;
        Teste.TST_SEO_REF = txt_seo_ref_inc.Text;
        Teste.TST_SEH_REF = txt_seh_ref_inc.Text;
        Teste.TST_SEG_REF = txt_seg_ref_inc.Text;
        Teste.TST_SJC_REF = txt_sjc_ref_inc.Text;
        Teste.TST_SJT_REF = txt_sjt_ref_inc.Text;
        Teste.TST_SJB_REF = txt_sjb_ref_inc.Text;
        Teste.TST_SPJ_REF = txt_spj_ref_inc.Text;
        Teste.TST_SBC_REF = txt_sbc_ref_inc.Text;
        Teste.TST_SPO_REF = txt_spo_ref_inc.Text;
        Teste.TST_SVA_REF = txt_sva_ref_inc.Text;
        Teste.TST_TGR_REF = txt_tgr_ref_inc.Text;
        Teste.TST_TIP_REF = txt_tip_ref_inc.Text;
        Teste.TST_DSB_REF = txt_dsb_ref_inc.Text;
        Teste.TST_TCA_REF = txt_tca_ref_inc.Text;
        Teste.TST_FMC_REF = txt_fmc_ref_inc.Text;
        Teste.TST_1TB_REF = txt_1tb_ref_inc.Text;
        Teste.TST_1PP_REF = txt_1pp_ref_inc.Text;
        Teste.TST_2TB_REF = txt_2tb_ref_inc.Text;
        Teste.TST_2PP_REF = txt_2pp_ref_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_ref_inc.Text))
        {
            Teste.TST_CSO_REF = Convert.ToDouble(txt_cso_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_ref_inc.Text))
        {
            Teste.TST_ESP_REF = Convert.ToDouble(txt_esp_ref_inc.Text);
        }
        Teste.TST_TOL_REF = txt_tol_ref_inc.Text;
        Teste.TST_P1C_REF = txt_p1c_ref_inc.Text;
        Teste.TST_P2D_REF = txt_p2d_ref_inc.Text;
        Teste.TST_P3D_REF = txt_p3d_ref_inc.Text;
        Teste.TST_P4U_REF = txt_p4u_ref_inc.Text;
        Teste.TST_MOL_REF = txt_mol_ref_inc.Text;
        Teste.TST_TPD_REF = txt_tpd_ref_inc.Text;
        Teste.TST_TT1_REF = txt_tt1_ref_inc.Text;
        Teste.TST_TT2_REF = txt_tt2_ref_inc.Text;
        Teste.TST_TT3_REF = txt_tt3_ref_inc.Text;
        Teste.TST_T21_REF = txt_t21_ref_inc.Text;
        Teste.TST_TUN_REF = txt_tun_ref_inc.Text;
        Teste.TST_TCV_REF = txt_tcv_ref_inc.Text;
        Teste.TST_TSS_REF = txt_tss_ref_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_ref_inc.Text))
        {
            Teste.TST_TIT_REF = Convert.ToDouble(txt_tit_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_ref_inc.Text))
        {
            Teste.TST_TNC_REF = Convert.ToDouble(txt_tnc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_ref_inc.Text))
        {
            Teste.TST_AON_REF = Convert.ToDouble(txt_aon_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_ref_inc.Text))
        {
            Teste.TST_ENM_REF = Convert.ToDouble(txt_enm_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_ref_inc.Text))
        {
            Teste.TST_EEE_REF = Convert.ToDouble(txt_eee_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_ref_inc.Text))
        {
            Teste.TST_KKK_REF = Convert.ToDouble(txt_kkk_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_ref_inc.Text))
        {
            Teste.TST_BBB_REF = Convert.ToDouble(txt_bbb_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_ref_inc.Text))
        {
            Teste.TST_OLE_REF = Convert.ToDouble(txt_ole_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_ref_inc.Text))
        {
            Teste.TST_TRQ_REF = Convert.ToDouble(txt_trq_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_ref_inc.Text))
        {
            Teste.TST_ERT_REF = Convert.ToDouble(txt_ert_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_ref_inc.Text))
        {
            Teste.TST_RT3_REF = Convert.ToDouble(txt_rt3_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_ref_inc.Text))
        {
            Teste.TST_RT5_REF = Convert.ToDouble(txt_rt5_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_ref_inc.Text))
        {
            Teste.TST_DND_REF = Convert.ToDouble(txt_dnd_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_ref_inc.Text))
        {
            Teste.TST_DMO_REF = Convert.ToDouble(txt_dmo_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_ref_inc.Text))
        {
            Teste.TST_PES_REF = Convert.ToDouble(txt_pes_ref_inc.Text);
        }
        Teste.TST_VRR_REF = txt_vrr_ref_inc.Text;

        Teste.TST_TRE_REF = txt_tre_ref_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_ref_inc.Text))
        {
            Teste.TST_LME_REF = Convert.ToDouble(txt_lme_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_ref_inc.Text))
        {
            Teste.TST_UME_REF = Convert.ToDouble(txt_ume_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_ref_inc.Text))
        {
            Teste.TST_LPE_REF = Convert.ToDouble(txt_lpe_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_ref_inc.Text))
        {
            Teste.TST_UPE_REF = Convert.ToDouble(txt_upe_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_ref_inc.Text))
        {
            Teste.TST_UCV_REF = Convert.ToDouble(txt_ucv_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_ref_inc.Text))
        {
            Teste.TST_DUR_REF = Convert.ToDouble(txt_dur_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_ref_inc.Text))
        {
            Teste.TST_DFT_REF = Convert.ToDouble(txt_dft_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_ref_inc.Text))
        {
            Teste.TST_LMC_REF = Convert.ToDouble(txt_lmc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_ref_inc.Text))
        {
            Teste.TST_UMC_REF = Convert.ToDouble(txt_umc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_ref_inc.Text))
        {
            Teste.TST_LPC_REF = Convert.ToDouble(txt_lpc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_ref_inc.Text))
        {
            Teste.TST_UPC_REF = Convert.ToDouble(txt_upc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_ref_inc.Text))
        {
            Teste.TST_CVC_REF = Convert.ToDouble(txt_cvc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_ref_inc.Text))
        {
            Teste.TST_DFC_REF = Convert.ToDouble(txt_dfc_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_ref_inc.Text))
        {
            Teste.TST_TFS_REF = Convert.ToDouble(txt_tfs_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_ref_inc.Text))
        {
            Teste.TST_FSW_REF = Convert.ToDouble(txt_fsw_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_ref_inc.Text))
        {
            Teste.TST_WFW_REF = Convert.ToDouble(txt_wfw_ref_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_ref_inc.Text))
        {
            Teste.TST_ECO_REF = Convert.ToDouble(txt_eco_ref_inc.Text);
        }
        Teste.TST_EOL_REF = txt_eol_ref_inc.Text;
        Teste.TST_ETU_REF = txt_etu_ref_inc.Text;
        Teste.TST_ETD_REF = txt_etd_ref_inc.Text;
        Teste.TST_ECU_REF = txt_ecu_ref_inc.Text;
        Teste.TST_EGD_REF = txt_egd_ref_inc.Text;
        Teste.TST_EEC_REF = txt_eec_ref_inc.Text;
        Teste.TST_ECD_REF = txt_ecd_ref_inc.Text;
        Teste.TST_EGU_REF = txt_egu_ref_inc.Text;
        Teste.TST_ESO_REF = txt_eso_ref_inc.Text;
        Teste.TST_ESI_REF = txt_esi_ref_inc.Text;
        Teste.TST_ECR_REF = txt_ecr_ref_inc.Text;
        Teste.TST_EOD_REF = txt_eod_ref_inc.Text;
        Teste.TST_EAW_REF = txt_eaw_ref_inc.Text;
        Teste.TST_ED1_REF = txt_ed1_ref_inc.Text;
        Teste.TST_ED2_REF = txt_ed2_ref_inc.Text;

        Teste.TST_VW2_001 = txt_vw2_001_inc.Text;
        Teste.TST_EGM_001 = txt_egm_001_inc.Text;
        Teste.TST_DYY_001 = txt_dyy_001_inc.Text;
        Teste.TST_2WX_001 = txt_2wx_001_inc.Text;
        Teste.TST_3W3_001 = txt_3w3_001_inc.Text;
        Teste.TST_4W4_001 = txt_4w4_001_inc.Text;
        Teste.TST_AGL_001 = txt_agl_001_inc.Text;
        Teste.TST_TUP_001 = txt_tup_001_inc.Text;
        Teste.TST_VEO_001 = txt_veo_001_inc.Text;
        Teste.TST_T1T_001 = txt_t1t_001_inc.Text;
        Teste.TST_T1C_001 = txt_t1c_001_inc.Text;
        Teste.TST_T1L_001 = txt_t1l_001_inc.Text;
        Teste.TST_T2F_001 = txt_t2f_001_inc.Text;
        Teste.TST_SVE_001 = txt_sve_001_inc.Text;
        Teste.TST_STF_001 = txt_stf_001_inc.Text;
        Teste.TST_STM_001 = txt_stm_001_inc.Text;
        Teste.TST_SCE_001 = txt_sce_001_inc.Text;
        Teste.TST_SCO_001 = txt_sco_001_inc.Text;
        Teste.TST_SCH_001 = txt_sch_001_inc.Text;
        Teste.TST_SCG_001 = txt_scg_001_inc.Text;
        Teste.TST_SEE_001 = txt_see_001_inc.Text;
        Teste.TST_SEO_001 = txt_seo_001_inc.Text;
        Teste.TST_SEH_001 = txt_seh_001_inc.Text;
        Teste.TST_SEG_001 = txt_seg_001_inc.Text;
        Teste.TST_SJC_001 = txt_sjc_001_inc.Text;
        Teste.TST_SJT_001 = txt_sjt_001_inc.Text;
        Teste.TST_SJB_001 = txt_sjb_001_inc.Text;
        Teste.TST_SPJ_001 = txt_spj_001_inc.Text;
        Teste.TST_SBC_001 = txt_sbc_001_inc.Text;
        Teste.TST_SPO_001 = txt_spo_001_inc.Text;
        Teste.TST_SVA_001 = txt_sva_001_inc.Text;
        Teste.TST_TGR_001 = txt_tgr_001_inc.Text;
        Teste.TST_TIP_001 = txt_tip_001_inc.Text;
        Teste.TST_DSB_001 = txt_dsb_001_inc.Text;
        Teste.TST_TCA_001 = txt_tca_001_inc.Text;
        Teste.TST_FMC_001 = txt_fmc_001_inc.Text;
        Teste.TST_1TB_001 = txt_1tb_001_inc.Text;
        Teste.TST_1PP_001 = txt_1pp_001_inc.Text;
        Teste.TST_2TB_001 = txt_2tb_001_inc.Text;
        Teste.TST_2PP_001 = txt_2pp_001_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_001_inc.Text))
        {
            Teste.TST_CSO_001 = Convert.ToDouble(txt_cso_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_001_inc.Text))
        {
            Teste.TST_ESP_001 = Convert.ToDouble(txt_esp_001_inc.Text);
        }
        Teste.TST_TOL_001 = txt_tol_001_inc.Text;
        Teste.TST_P1C_001 = txt_p1c_001_inc.Text;
        Teste.TST_P2D_001 = txt_p2d_001_inc.Text;
        Teste.TST_P3D_001 = txt_p3d_001_inc.Text;
        Teste.TST_P4U_001 = txt_p4u_001_inc.Text;
        Teste.TST_MOL_001 = txt_mol_001_inc.Text;
        Teste.TST_TPD_001 = txt_tpd_001_inc.Text;
        Teste.TST_TT1_001 = txt_tt1_001_inc.Text;
        Teste.TST_TT2_001 = txt_tt2_001_inc.Text;
        Teste.TST_TT3_001 = txt_tt3_001_inc.Text;
        Teste.TST_T21_001 = txt_t21_001_inc.Text;
        Teste.TST_TUN_001 = txt_tun_001_inc.Text;
        Teste.TST_TCV_001 = txt_tcv_001_inc.Text;
        Teste.TST_TSS_001 = txt_tss_001_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_001_inc.Text))
        {
            Teste.TST_TIT_001 = Convert.ToDouble(txt_tit_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_001_inc.Text))
        {
            Teste.TST_TNC_001 = Convert.ToDouble(txt_tnc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_001_inc.Text))
        {
            Teste.TST_AON_001 = Convert.ToDouble(txt_aon_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_001_inc.Text))
        {
            Teste.TST_ENM_001 = Convert.ToDouble(txt_enm_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_001_inc.Text))
        {
            Teste.TST_EEE_001 = Convert.ToDouble(txt_eee_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_001_inc.Text))
        {
            Teste.TST_KKK_001 = Convert.ToDouble(txt_kkk_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_001_inc.Text))
        {
            Teste.TST_BBB_001 = Convert.ToDouble(txt_bbb_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_001_inc.Text))
        {
            Teste.TST_OLE_001 = Convert.ToDouble(txt_ole_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_001_inc.Text))
        {
            Teste.TST_TRQ_001 = Convert.ToDouble(txt_trq_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_001_inc.Text))
        {
            Teste.TST_ERT_001 = Convert.ToDouble(txt_ert_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_001_inc.Text))
        {
            Teste.TST_RT3_001 = Convert.ToDouble(txt_rt3_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_001_inc.Text))
        {
            Teste.TST_RT5_001 = Convert.ToDouble(txt_rt5_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_001_inc.Text))
        {
            Teste.TST_DND_001 = Convert.ToDouble(txt_dnd_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_001_inc.Text))
        {
            Teste.TST_DMO_001 = Convert.ToDouble(txt_dmo_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_001_inc.Text))
        {
            Teste.TST_PES_001 = Convert.ToDouble(txt_pes_001_inc.Text);
        }
        Teste.TST_VRR_001 = txt_vrr_001_inc.Text;

        Teste.TST_TRE_001 = txt_tre_001_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_001_inc.Text))
        {
            Teste.TST_LME_001 = Convert.ToDouble(txt_lme_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_001_inc.Text))
        {
            Teste.TST_UME_001 = Convert.ToDouble(txt_ume_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_001_inc.Text))
        {
            Teste.TST_LPE_001 = Convert.ToDouble(txt_lpe_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_001_inc.Text))
        {
            Teste.TST_UPE_001 = Convert.ToDouble(txt_upe_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_001_inc.Text))
        {
            Teste.TST_UCV_001 = Convert.ToDouble(txt_ucv_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_001_inc.Text))
        {
            Teste.TST_DUR_001 = Convert.ToDouble(txt_dur_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_001_inc.Text))
        {
            Teste.TST_DFT_001 = Convert.ToDouble(txt_dft_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_001_inc.Text))
        {
            Teste.TST_LMC_001 = Convert.ToDouble(txt_lmc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_001_inc.Text))
        {
            Teste.TST_UMC_001 = Convert.ToDouble(txt_umc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_001_inc.Text))
        {
            Teste.TST_LPC_001 = Convert.ToDouble(txt_lpc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_001_inc.Text))
        {
            Teste.TST_UPC_001 = Convert.ToDouble(txt_upc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_001_inc.Text))
        {
            Teste.TST_CVC_001 = Convert.ToDouble(txt_cvc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_001_inc.Text))
        {
            Teste.TST_DFC_001 = Convert.ToDouble(txt_dfc_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_001_inc.Text))
        {
            Teste.TST_TFS_001 = Convert.ToDouble(txt_tfs_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_001_inc.Text))
        {
            Teste.TST_FSW_001 = Convert.ToDouble(txt_fsw_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_001_inc.Text))
        {
            Teste.TST_WFW_001 = Convert.ToDouble(txt_wfw_001_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_001_inc.Text))
        {
            Teste.TST_ECO_001 = Convert.ToDouble(txt_eco_001_inc.Text);
        }
        Teste.TST_EOL_001 = txt_eol_001_inc.Text;
        Teste.TST_ETU_001 = txt_etu_001_inc.Text;
        Teste.TST_ETD_001 = txt_etd_001_inc.Text;
        Teste.TST_ECU_001 = txt_ecu_001_inc.Text;
        Teste.TST_EGD_001 = txt_egd_001_inc.Text;
        Teste.TST_EEC_001 = txt_eec_001_inc.Text;
        Teste.TST_ECD_001 = txt_ecd_001_inc.Text;
        Teste.TST_EGU_001 = txt_egu_001_inc.Text;
        Teste.TST_ESO_001 = txt_eso_001_inc.Text;
        Teste.TST_ESI_001 = txt_esi_001_inc.Text;
        Teste.TST_ECR_001 = txt_ecr_001_inc.Text;
        Teste.TST_EOD_001 = txt_eod_001_inc.Text;
        Teste.TST_EAW_001 = txt_eaw_001_inc.Text;
        Teste.TST_ED1_001 = txt_ed1_001_inc.Text;
        Teste.TST_ED2_001 = txt_ed2_001_inc.Text;

        Teste.TST_VW2_002 = txt_vw2_002_inc.Text;
        Teste.TST_EGM_002 = txt_egm_002_inc.Text;
        Teste.TST_DYY_002 = txt_dyy_002_inc.Text;
        Teste.TST_2WX_002 = txt_2wx_002_inc.Text;
        Teste.TST_3W3_002 = txt_3w3_002_inc.Text;
        Teste.TST_4W4_002 = txt_4w4_002_inc.Text;
        Teste.TST_AGL_002 = txt_agl_002_inc.Text;
        Teste.TST_TUP_002 = txt_tup_002_inc.Text;
        Teste.TST_VEO_002 = txt_veo_002_inc.Text;
        Teste.TST_T1T_002 = txt_t1t_002_inc.Text;
        Teste.TST_T1C_002 = txt_t1c_002_inc.Text;
        Teste.TST_T1L_002 = txt_t1l_002_inc.Text;
        Teste.TST_T2F_002 = txt_t2f_002_inc.Text;
        Teste.TST_SVE_002 = txt_sve_002_inc.Text;
        Teste.TST_STF_002 = txt_stf_002_inc.Text;
        Teste.TST_STM_002 = txt_stm_002_inc.Text;
        Teste.TST_SCE_002 = txt_sce_002_inc.Text;
        Teste.TST_SCO_002 = txt_sco_002_inc.Text;
        Teste.TST_SCH_002 = txt_sch_002_inc.Text;
        Teste.TST_SCG_002 = txt_scg_002_inc.Text;
        Teste.TST_SEE_002 = txt_see_002_inc.Text;
        Teste.TST_SEO_002 = txt_seo_002_inc.Text;
        Teste.TST_SEH_002 = txt_seh_002_inc.Text;
        Teste.TST_SEG_002 = txt_seg_002_inc.Text;
        Teste.TST_SJC_002 = txt_sjc_002_inc.Text;
        Teste.TST_SJT_002 = txt_sjt_002_inc.Text;
        Teste.TST_SJB_002 = txt_sjb_002_inc.Text;
        Teste.TST_SPJ_002 = txt_spj_002_inc.Text;
        Teste.TST_SBC_002 = txt_sbc_002_inc.Text;
        Teste.TST_SPO_002 = txt_spo_002_inc.Text;
        Teste.TST_SVA_002 = txt_sva_002_inc.Text;
        Teste.TST_TGR_002 = txt_tgr_002_inc.Text;
        Teste.TST_TIP_002 = txt_tip_002_inc.Text;
        Teste.TST_DSB_002 = txt_dsb_002_inc.Text;
        Teste.TST_TCA_002 = txt_tca_002_inc.Text;
        Teste.TST_FMC_002 = txt_fmc_002_inc.Text;
        Teste.TST_1TB_002 = txt_1tb_002_inc.Text;
        Teste.TST_1PP_002 = txt_1pp_002_inc.Text;
        Teste.TST_2TB_002 = txt_2tb_002_inc.Text;
        Teste.TST_2PP_002 = txt_2pp_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_002_inc.Text))
        {
            Teste.TST_CSO_002 = Convert.ToDouble(txt_cso_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_002_inc.Text))
        {
            Teste.TST_ESP_002 = Convert.ToDouble(txt_esp_002_inc.Text);
        }
        Teste.TST_TOL_002 = txt_tol_002_inc.Text;
        Teste.TST_P1C_002 = txt_p1c_002_inc.Text;
        Teste.TST_P2D_002 = txt_p2d_002_inc.Text;
        Teste.TST_P3D_002 = txt_p3d_002_inc.Text;
        Teste.TST_P4U_002 = txt_p4u_002_inc.Text;
        Teste.TST_MOL_002 = txt_mol_002_inc.Text;
        Teste.TST_TPD_002 = txt_tpd_002_inc.Text;
        Teste.TST_TT1_002 = txt_tt1_002_inc.Text;
        Teste.TST_TT2_002 = txt_tt2_002_inc.Text;
        Teste.TST_TT3_002 = txt_tt3_002_inc.Text;
        Teste.TST_T21_002 = txt_t21_002_inc.Text;
        Teste.TST_TUN_002 = txt_tun_002_inc.Text;
        Teste.TST_TCV_002 = txt_tcv_002_inc.Text;
        Teste.TST_TSS_002 = txt_tss_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_002_inc.Text))
        {
            Teste.TST_TIT_002 = Convert.ToDouble(txt_tit_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_002_inc.Text))
        {
            Teste.TST_TNC_002 = Convert.ToDouble(txt_tnc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_002_inc.Text))
        {
            Teste.TST_AON_002 = Convert.ToDouble(txt_aon_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_002_inc.Text))
        {
            Teste.TST_ENM_002 = Convert.ToDouble(txt_enm_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_002_inc.Text))
        {
            Teste.TST_EEE_002 = Convert.ToDouble(txt_eee_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_002_inc.Text))
        {
            Teste.TST_KKK_002 = Convert.ToDouble(txt_kkk_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_002_inc.Text))
        {
            Teste.TST_BBB_002 = Convert.ToDouble(txt_bbb_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_002_inc.Text))
        {
            Teste.TST_OLE_002 = Convert.ToDouble(txt_ole_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_002_inc.Text))
        {
            Teste.TST_TRQ_002 = Convert.ToDouble(txt_trq_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_002_inc.Text))
        {
            Teste.TST_ERT_002 = Convert.ToDouble(txt_ert_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_002_inc.Text))
        {
            Teste.TST_RT3_002 = Convert.ToDouble(txt_rt3_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_002_inc.Text))
        {
            Teste.TST_RT5_002 = Convert.ToDouble(txt_rt5_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_002_inc.Text))
        {
            Teste.TST_DND_002 = Convert.ToDouble(txt_dnd_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_002_inc.Text))
        {
            Teste.TST_DMO_002 = Convert.ToDouble(txt_dmo_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_002_inc.Text))
        {
            Teste.TST_PES_002 = Convert.ToDouble(txt_pes_002_inc.Text);
        }
        Teste.TST_VRR_002 = txt_vrr_002_inc.Text;

        Teste.TST_TRE_002 = txt_tre_002_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_002_inc.Text))
        {
            Teste.TST_LME_002 = Convert.ToDouble(txt_lme_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_002_inc.Text))
        {
            Teste.TST_UME_002 = Convert.ToDouble(txt_ume_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_002_inc.Text))
        {
            Teste.TST_LPE_002 = Convert.ToDouble(txt_lpe_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_002_inc.Text))
        {
            Teste.TST_UPE_002 = Convert.ToDouble(txt_upe_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_002_inc.Text))
        {
            Teste.TST_UCV_002 = Convert.ToDouble(txt_ucv_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_002_inc.Text))
        {
            Teste.TST_DUR_002 = Convert.ToDouble(txt_dur_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_002_inc.Text))
        {
            Teste.TST_DFT_002 = Convert.ToDouble(txt_dft_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_002_inc.Text))
        {
            Teste.TST_LMC_002 = Convert.ToDouble(txt_lmc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_002_inc.Text))
        {
            Teste.TST_UMC_002 = Convert.ToDouble(txt_umc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_002_inc.Text))
        {
            Teste.TST_LPC_002 = Convert.ToDouble(txt_lpc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_002_inc.Text))
        {
            Teste.TST_UPC_002 = Convert.ToDouble(txt_upc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_002_inc.Text))
        {
            Teste.TST_CVC_002 = Convert.ToDouble(txt_cvc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_002_inc.Text))
        {
            Teste.TST_DFC_002 = Convert.ToDouble(txt_dfc_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_002_inc.Text))
        {
            Teste.TST_TFS_002 = Convert.ToDouble(txt_tfs_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_002_inc.Text))
        {
            Teste.TST_FSW_002 = Convert.ToDouble(txt_fsw_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_002_inc.Text))
        {
            Teste.TST_WFW_002 = Convert.ToDouble(txt_wfw_002_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_002_inc.Text))
        {
            Teste.TST_ECO_002 = Convert.ToDouble(txt_eco_002_inc.Text);
        }
        Teste.TST_EOL_002 = txt_eol_002_inc.Text;
        Teste.TST_ETU_002 = txt_etu_002_inc.Text;
        Teste.TST_ETD_002 = txt_etd_002_inc.Text;
        Teste.TST_ECU_002 = txt_ecu_002_inc.Text;
        Teste.TST_EGD_002 = txt_egd_002_inc.Text;
        Teste.TST_EEC_002 = txt_eec_002_inc.Text;
        Teste.TST_ECD_002 = txt_ecd_002_inc.Text;
        Teste.TST_EGU_002 = txt_egu_002_inc.Text;
        Teste.TST_ESO_002 = txt_eso_002_inc.Text;
        Teste.TST_ESI_002 = txt_esi_002_inc.Text;
        Teste.TST_ECR_002 = txt_ecr_002_inc.Text;
        Teste.TST_EOD_002 = txt_eod_002_inc.Text;
        Teste.TST_EAW_002 = txt_eaw_002_inc.Text;
        Teste.TST_ED1_002 = txt_ed1_002_inc.Text;
        Teste.TST_ED2_002 = txt_ed2_002_inc.Text;

        Teste.TST_VW2_003 = txt_vw2_003_inc.Text;
        Teste.TST_EGM_003 = txt_egm_003_inc.Text;
        Teste.TST_DYY_003 = txt_dyy_003_inc.Text;
        Teste.TST_2WX_003 = txt_2wx_003_inc.Text;
        Teste.TST_3W3_003 = txt_3w3_003_inc.Text;
        Teste.TST_4W4_003 = txt_4w4_003_inc.Text;
        Teste.TST_AGL_003 = txt_agl_003_inc.Text;
        Teste.TST_TUP_003 = txt_tup_003_inc.Text;
        Teste.TST_VEO_003 = txt_veo_003_inc.Text;
        Teste.TST_T1T_003 = txt_t1t_003_inc.Text;
        Teste.TST_T1C_003 = txt_t1c_003_inc.Text;
        Teste.TST_T1L_003 = txt_t1l_003_inc.Text;
        Teste.TST_T2F_003 = txt_t2f_003_inc.Text;
        Teste.TST_SVE_003 = txt_sve_003_inc.Text;
        Teste.TST_STF_003 = txt_stf_003_inc.Text;
        Teste.TST_STM_003 = txt_stm_003_inc.Text;
        Teste.TST_SCE_003 = txt_sce_003_inc.Text;
        Teste.TST_SCO_003 = txt_sco_003_inc.Text;
        Teste.TST_SCH_003 = txt_sch_003_inc.Text;
        Teste.TST_SCG_003 = txt_scg_003_inc.Text;
        Teste.TST_SEE_003 = txt_see_003_inc.Text;
        Teste.TST_SEO_003 = txt_seo_003_inc.Text;
        Teste.TST_SEH_003 = txt_seh_003_inc.Text;
        Teste.TST_SEG_003 = txt_seg_003_inc.Text;
        Teste.TST_SJC_003 = txt_sjc_003_inc.Text;
        Teste.TST_SJT_003 = txt_sjt_003_inc.Text;
        Teste.TST_SJB_003 = txt_sjb_003_inc.Text;
        Teste.TST_SPJ_003 = txt_spj_003_inc.Text;
        Teste.TST_SBC_003 = txt_sbc_003_inc.Text;
        Teste.TST_SPO_003 = txt_spo_003_inc.Text;
        Teste.TST_SVA_003 = txt_sva_003_inc.Text;
        Teste.TST_TGR_003 = txt_tgr_003_inc.Text;
        Teste.TST_TIP_003 = txt_tip_003_inc.Text;
        Teste.TST_DSB_003 = txt_dsb_003_inc.Text;
        Teste.TST_TCA_003 = txt_tca_003_inc.Text;
        Teste.TST_FMC_003 = txt_fmc_003_inc.Text;
        Teste.TST_1TB_003 = txt_1tb_003_inc.Text;
        Teste.TST_1PP_003 = txt_1pp_003_inc.Text;
        Teste.TST_2TB_003 = txt_2tb_003_inc.Text;
        Teste.TST_2PP_003 = txt_2pp_003_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_003_inc.Text))
        {
            Teste.TST_CSO_003 = Convert.ToDouble(txt_cso_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_003_inc.Text))
        {
            Teste.TST_ESP_003 = Convert.ToDouble(txt_esp_003_inc.Text);
        }
        Teste.TST_TOL_003 = txt_tol_003_inc.Text;
        Teste.TST_P1C_003 = txt_p1c_003_inc.Text;
        Teste.TST_P2D_003 = txt_p2d_003_inc.Text;
        Teste.TST_P3D_003 = txt_p3d_003_inc.Text;
        Teste.TST_P4U_003 = txt_p4u_003_inc.Text;
        Teste.TST_MOL_003 = txt_mol_003_inc.Text;
        Teste.TST_TPD_003 = txt_tpd_003_inc.Text;
        Teste.TST_TT1_003 = txt_tt1_003_inc.Text;
        Teste.TST_TT2_003 = txt_tt2_003_inc.Text;
        Teste.TST_TT3_003 = txt_tt3_003_inc.Text;
        Teste.TST_T21_003 = txt_t21_003_inc.Text;
        Teste.TST_TUN_003 = txt_tun_003_inc.Text;
        Teste.TST_TCV_003 = txt_tcv_003_inc.Text;
        Teste.TST_TSS_003 = txt_tss_003_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_003_inc.Text))
        {
            Teste.TST_TIT_003 = Convert.ToDouble(txt_tit_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_003_inc.Text))
        {
            Teste.TST_TNC_003 = Convert.ToDouble(txt_tnc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_003_inc.Text))
        {
            Teste.TST_AON_003 = Convert.ToDouble(txt_aon_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_003_inc.Text))
        {
            Teste.TST_ENM_003 = Convert.ToDouble(txt_enm_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_003_inc.Text))
        {
            Teste.TST_EEE_003 = Convert.ToDouble(txt_eee_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_003_inc.Text))
        {
            Teste.TST_KKK_003 = Convert.ToDouble(txt_kkk_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_003_inc.Text))
        {
            Teste.TST_BBB_003 = Convert.ToDouble(txt_bbb_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_003_inc.Text))
        {
            Teste.TST_OLE_003 = Convert.ToDouble(txt_ole_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_003_inc.Text))
        {
            Teste.TST_TRQ_003 = Convert.ToDouble(txt_trq_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_003_inc.Text))
        {
            Teste.TST_ERT_003 = Convert.ToDouble(txt_ert_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_003_inc.Text))
        {
            Teste.TST_RT3_003 = Convert.ToDouble(txt_rt3_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_003_inc.Text))
        {
            Teste.TST_RT5_003 = Convert.ToDouble(txt_rt5_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_003_inc.Text))
        {
            Teste.TST_DND_003 = Convert.ToDouble(txt_dnd_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_003_inc.Text))
        {
            Teste.TST_DMO_003 = Convert.ToDouble(txt_dmo_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_003_inc.Text))
        {
            Teste.TST_PES_003 = Convert.ToDouble(txt_pes_003_inc.Text);
        }
        Teste.TST_VRR_003 = txt_vrr_003_inc.Text;

        Teste.TST_TRE_003 = txt_tre_003_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_003_inc.Text))
        {
            Teste.TST_LME_003 = Convert.ToDouble(txt_lme_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_003_inc.Text))
        {
            Teste.TST_UME_003 = Convert.ToDouble(txt_ume_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_003_inc.Text))
        {
            Teste.TST_LPE_003 = Convert.ToDouble(txt_lpe_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_003_inc.Text))
        {
            Teste.TST_UPE_003 = Convert.ToDouble(txt_upe_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_003_inc.Text))
        {
            Teste.TST_UCV_003 = Convert.ToDouble(txt_ucv_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_003_inc.Text))
        {
            Teste.TST_DUR_003 = Convert.ToDouble(txt_dur_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_003_inc.Text))
        {
            Teste.TST_DFT_003 = Convert.ToDouble(txt_dft_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_003_inc.Text))
        {
            Teste.TST_LMC_003 = Convert.ToDouble(txt_lmc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_003_inc.Text))
        {
            Teste.TST_UMC_003 = Convert.ToDouble(txt_umc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_003_inc.Text))
        {
            Teste.TST_LPC_003 = Convert.ToDouble(txt_lpc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_003_inc.Text))
        {
            Teste.TST_UPC_003 = Convert.ToDouble(txt_upc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_003_inc.Text))
        {
            Teste.TST_CVC_003 = Convert.ToDouble(txt_cvc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_003_inc.Text))
        {
            Teste.TST_DFC_003 = Convert.ToDouble(txt_dfc_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_003_inc.Text))
        {
            Teste.TST_TFS_003 = Convert.ToDouble(txt_tfs_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_003_inc.Text))
        {
            Teste.TST_FSW_003 = Convert.ToDouble(txt_fsw_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_003_inc.Text))
        {
            Teste.TST_WFW_003 = Convert.ToDouble(txt_wfw_003_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_003_inc.Text))
        {
            Teste.TST_ECO_003 = Convert.ToDouble(txt_eco_003_inc.Text);
        }
        Teste.TST_EOL_003 = txt_eol_003_inc.Text;
        Teste.TST_ETU_003 = txt_etu_003_inc.Text;
        Teste.TST_ETD_003 = txt_etd_003_inc.Text;
        Teste.TST_ECU_003 = txt_ecu_003_inc.Text;
        Teste.TST_EGD_003 = txt_egd_003_inc.Text;
        Teste.TST_EEC_003 = txt_eec_003_inc.Text;
        Teste.TST_ECD_003 = txt_ecd_003_inc.Text;
        Teste.TST_EGU_003 = txt_egu_003_inc.Text;
        Teste.TST_ESO_003 = txt_eso_003_inc.Text;
        Teste.TST_ESI_003 = txt_esi_003_inc.Text;
        Teste.TST_ECR_003 = txt_ecr_003_inc.Text;
        Teste.TST_EOD_003 = txt_eod_003_inc.Text;
        Teste.TST_EAW_003 = txt_eaw_003_inc.Text;
        Teste.TST_ED1_003 = txt_ed1_003_inc.Text;
        Teste.TST_ED2_003 = txt_ed2_003_inc.Text;

        Teste.TST_VW2_004 = txt_vw2_004_inc.Text;
        Teste.TST_EGM_004 = txt_egm_004_inc.Text;
        Teste.TST_DYY_004 = txt_dyy_004_inc.Text;
        Teste.TST_2WX_004 = txt_2wx_004_inc.Text;
        Teste.TST_3W3_004 = txt_3w3_004_inc.Text;
        Teste.TST_4W4_004 = txt_4w4_004_inc.Text;
        Teste.TST_AGL_004 = txt_agl_004_inc.Text;
        Teste.TST_TUP_004 = txt_tup_004_inc.Text;
        Teste.TST_VEO_004 = txt_veo_004_inc.Text;
        Teste.TST_T1T_004 = txt_t1t_004_inc.Text;
        Teste.TST_T1C_004 = txt_t1c_004_inc.Text;
        Teste.TST_T1L_004 = txt_t1l_004_inc.Text;
        Teste.TST_T2F_004 = txt_t2f_004_inc.Text;
        Teste.TST_SVE_004 = txt_sve_004_inc.Text;
        Teste.TST_STF_004 = txt_stf_004_inc.Text;
        Teste.TST_STM_004 = txt_stm_004_inc.Text;
        Teste.TST_SCE_004 = txt_sce_004_inc.Text;
        Teste.TST_SCO_004 = txt_sco_004_inc.Text;
        Teste.TST_SCH_004 = txt_sch_004_inc.Text;
        Teste.TST_SCG_004 = txt_scg_004_inc.Text;
        Teste.TST_SEE_004 = txt_see_004_inc.Text;
        Teste.TST_SEO_004 = txt_seo_004_inc.Text;
        Teste.TST_SEH_004 = txt_seh_004_inc.Text;
        Teste.TST_SEG_004 = txt_seg_004_inc.Text;
        Teste.TST_SJC_004 = txt_sjc_004_inc.Text;
        Teste.TST_SJT_004 = txt_sjt_004_inc.Text;
        Teste.TST_SJB_004 = txt_sjb_004_inc.Text;
        Teste.TST_SPJ_004 = txt_spj_004_inc.Text;
        Teste.TST_SBC_004 = txt_sbc_004_inc.Text;
        Teste.TST_SPO_004 = txt_spo_004_inc.Text;
        Teste.TST_SVA_004 = txt_sva_004_inc.Text;
        Teste.TST_TGR_004 = txt_tgr_004_inc.Text;
        Teste.TST_TIP_004 = txt_tip_004_inc.Text;
        Teste.TST_DSB_004 = txt_dsb_004_inc.Text;
        Teste.TST_TCA_004 = txt_tca_004_inc.Text;
        Teste.TST_FMC_004 = txt_fmc_004_inc.Text;
        Teste.TST_1TB_004 = txt_1tb_004_inc.Text;
        Teste.TST_1PP_004 = txt_1pp_004_inc.Text;
        Teste.TST_2TB_004 = txt_2tb_004_inc.Text;
        Teste.TST_2PP_004 = txt_2pp_004_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_004_inc.Text))
        {
            Teste.TST_CSO_004 = Convert.ToDouble(txt_cso_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_004_inc.Text))
        {
            Teste.TST_ESP_004 = Convert.ToDouble(txt_esp_004_inc.Text);
        }
        Teste.TST_TOL_004 = txt_tol_004_inc.Text;
        Teste.TST_P1C_004 = txt_p1c_004_inc.Text;
        Teste.TST_P2D_004 = txt_p2d_004_inc.Text;
        Teste.TST_P3D_004 = txt_p3d_004_inc.Text;
        Teste.TST_P4U_004 = txt_p4u_004_inc.Text;
        Teste.TST_MOL_004 = txt_mol_004_inc.Text;
        Teste.TST_TPD_004 = txt_tpd_004_inc.Text;
        Teste.TST_TT1_004 = txt_tt1_004_inc.Text;
        Teste.TST_TT2_004 = txt_tt2_004_inc.Text;
        Teste.TST_TT3_004 = txt_tt3_004_inc.Text;
        Teste.TST_T21_004 = txt_t21_004_inc.Text;
        Teste.TST_TUN_004 = txt_tun_004_inc.Text;
        Teste.TST_TCV_004 = txt_tcv_004_inc.Text;
        Teste.TST_TSS_004 = txt_tss_004_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_004_inc.Text))
        {
            Teste.TST_TIT_004 = Convert.ToDouble(txt_tit_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_004_inc.Text))
        {
            Teste.TST_TNC_004 = Convert.ToDouble(txt_tnc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_004_inc.Text))
        {
            Teste.TST_AON_004 = Convert.ToDouble(txt_aon_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_004_inc.Text))
        {
            Teste.TST_ENM_004 = Convert.ToDouble(txt_enm_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_004_inc.Text))
        {
            Teste.TST_EEE_004 = Convert.ToDouble(txt_eee_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_004_inc.Text))
        {
            Teste.TST_KKK_004 = Convert.ToDouble(txt_kkk_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_004_inc.Text))
        {
            Teste.TST_BBB_004 = Convert.ToDouble(txt_bbb_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_004_inc.Text))
        {
            Teste.TST_OLE_004 = Convert.ToDouble(txt_ole_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_004_inc.Text))
        {
            Teste.TST_TRQ_004 = Convert.ToDouble(txt_trq_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_004_inc.Text))
        {
            Teste.TST_ERT_004 = Convert.ToDouble(txt_ert_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_004_inc.Text))
        {
            Teste.TST_RT3_004 = Convert.ToDouble(txt_rt3_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_004_inc.Text))
        {
            Teste.TST_RT5_004 = Convert.ToDouble(txt_rt5_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_004_inc.Text))
        {
            Teste.TST_DND_004 = Convert.ToDouble(txt_dnd_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_004_inc.Text))
        {
            Teste.TST_DMO_004 = Convert.ToDouble(txt_dmo_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_004_inc.Text))
        {
            Teste.TST_PES_004 = Convert.ToDouble(txt_pes_004_inc.Text);
        }
        Teste.TST_VRR_004 = txt_vrr_004_inc.Text;

        Teste.TST_TRE_004 = txt_tre_004_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_004_inc.Text))
        {
            Teste.TST_LME_004 = Convert.ToDouble(txt_lme_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_004_inc.Text))
        {
            Teste.TST_UME_004 = Convert.ToDouble(txt_ume_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_004_inc.Text))
        {
            Teste.TST_LPE_004 = Convert.ToDouble(txt_lpe_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_004_inc.Text))
        {
            Teste.TST_UPE_004 = Convert.ToDouble(txt_upe_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_004_inc.Text))
        {
            Teste.TST_UCV_004 = Convert.ToDouble(txt_ucv_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_004_inc.Text))
        {
            Teste.TST_DUR_004 = Convert.ToDouble(txt_dur_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_004_inc.Text))
        {
            Teste.TST_DFT_004 = Convert.ToDouble(txt_dft_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_004_inc.Text))
        {
            Teste.TST_LMC_004 = Convert.ToDouble(txt_lmc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_004_inc.Text))
        {
            Teste.TST_UMC_004 = Convert.ToDouble(txt_umc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_004_inc.Text))
        {
            Teste.TST_LPC_004 = Convert.ToDouble(txt_lpc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_004_inc.Text))
        {
            Teste.TST_UPC_004 = Convert.ToDouble(txt_upc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_004_inc.Text))
        {
            Teste.TST_CVC_004 = Convert.ToDouble(txt_cvc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_004_inc.Text))
        {
            Teste.TST_DFC_004 = Convert.ToDouble(txt_dfc_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_004_inc.Text))
        {
            Teste.TST_TFS_004 = Convert.ToDouble(txt_tfs_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_004_inc.Text))
        {
            Teste.TST_FSW_004 = Convert.ToDouble(txt_fsw_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_004_inc.Text))
        {
            Teste.TST_WFW_004 = Convert.ToDouble(txt_wfw_004_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_004_inc.Text))
        {
            Teste.TST_ECO_004 = Convert.ToDouble(txt_eco_004_inc.Text);
        }
        Teste.TST_EOL_004 = txt_eol_004_inc.Text;
        Teste.TST_ETU_004 = txt_etu_004_inc.Text;
        Teste.TST_ETD_004 = txt_etd_004_inc.Text;
        Teste.TST_ECU_004 = txt_ecu_004_inc.Text;
        Teste.TST_EGD_004 = txt_egd_004_inc.Text;
        Teste.TST_EEC_004 = txt_eec_004_inc.Text;
        Teste.TST_ECD_004 = txt_ecd_004_inc.Text;
        Teste.TST_EGU_004 = txt_egu_004_inc.Text;
        Teste.TST_ESO_004 = txt_eso_004_inc.Text;
        Teste.TST_ESI_004 = txt_esi_004_inc.Text;
        Teste.TST_ECR_004 = txt_ecr_004_inc.Text;
        Teste.TST_EOD_004 = txt_eod_004_inc.Text;
        Teste.TST_EAW_004 = txt_eaw_004_inc.Text;
        Teste.TST_ED1_004 = txt_ed1_004_inc.Text;
        Teste.TST_ED2_004 = txt_ed2_004_inc.Text;

        Teste.TST_VW2_005 = txt_vw2_005_inc.Text;
        Teste.TST_EGM_005 = txt_egm_005_inc.Text;
        Teste.TST_DYY_005 = txt_dyy_005_inc.Text;
        Teste.TST_2WX_005 = txt_2wx_005_inc.Text;
        Teste.TST_3W3_005 = txt_3w3_005_inc.Text;
        Teste.TST_4W4_005 = txt_4w4_005_inc.Text;
        Teste.TST_AGL_005 = txt_agl_005_inc.Text;
        Teste.TST_TUP_005 = txt_tup_005_inc.Text;
        Teste.TST_VEO_005 = txt_veo_005_inc.Text;
        Teste.TST_T1T_005 = txt_t1t_005_inc.Text;
        Teste.TST_T1C_005 = txt_t1c_005_inc.Text;
        Teste.TST_T1L_005 = txt_t1l_005_inc.Text;
        Teste.TST_T2F_005 = txt_t2f_005_inc.Text;
        Teste.TST_SVE_005 = txt_sve_005_inc.Text;
        Teste.TST_STF_005 = txt_stf_005_inc.Text;
        Teste.TST_STM_005 = txt_stm_005_inc.Text;
        Teste.TST_SCE_005 = txt_sce_005_inc.Text;
        Teste.TST_SCO_005 = txt_sco_005_inc.Text;
        Teste.TST_SCH_005 = txt_sch_005_inc.Text;
        Teste.TST_SCG_005 = txt_scg_005_inc.Text;
        Teste.TST_SEE_005 = txt_see_005_inc.Text;
        Teste.TST_SEO_005 = txt_seo_005_inc.Text;
        Teste.TST_SEH_005 = txt_seh_005_inc.Text;
        Teste.TST_SEG_005 = txt_seg_005_inc.Text;
        Teste.TST_SJC_005 = txt_sjc_005_inc.Text;
        Teste.TST_SJT_005 = txt_sjt_005_inc.Text;
        Teste.TST_SJB_005 = txt_sjb_005_inc.Text;
        Teste.TST_SPJ_005 = txt_spj_005_inc.Text;
        Teste.TST_SBC_005 = txt_sbc_005_inc.Text;
        Teste.TST_SPO_005 = txt_spo_005_inc.Text;
        Teste.TST_SVA_005 = txt_sva_005_inc.Text;
        Teste.TST_TGR_005 = txt_tgr_005_inc.Text;
        Teste.TST_TIP_005 = txt_tip_005_inc.Text;
        Teste.TST_DSB_005 = txt_dsb_005_inc.Text;
        Teste.TST_TCA_005 = txt_tca_005_inc.Text;
        Teste.TST_FMC_005 = txt_fmc_005_inc.Text;
        Teste.TST_1TB_005 = txt_1tb_005_inc.Text;
        Teste.TST_1PP_005 = txt_1pp_005_inc.Text;
        Teste.TST_2TB_005 = txt_2tb_005_inc.Text;
        Teste.TST_2PP_005 = txt_2pp_005_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_005_inc.Text))
        {
            Teste.TST_CSO_005 = Convert.ToDouble(txt_cso_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_005_inc.Text))
        {
            Teste.TST_ESP_005 = Convert.ToDouble(txt_esp_005_inc.Text);
        }
        Teste.TST_TOL_005 = txt_tol_005_inc.Text;
        Teste.TST_P1C_005 = txt_p1c_005_inc.Text;
        Teste.TST_P2D_005 = txt_p2d_005_inc.Text;
        Teste.TST_P3D_005 = txt_p3d_005_inc.Text;
        Teste.TST_P4U_005 = txt_p4u_005_inc.Text;
        Teste.TST_MOL_005 = txt_mol_005_inc.Text;
        Teste.TST_TPD_005 = txt_tpd_005_inc.Text;
        Teste.TST_TT1_005 = txt_tt1_005_inc.Text;
        Teste.TST_TT2_005 = txt_tt2_005_inc.Text;
        Teste.TST_TT3_005 = txt_tt3_005_inc.Text;
        Teste.TST_T21_005 = txt_t21_005_inc.Text;
        Teste.TST_TUN_005 = txt_tun_005_inc.Text;
        Teste.TST_TCV_005 = txt_tcv_005_inc.Text;
        Teste.TST_TSS_005 = txt_tss_005_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_005_inc.Text))
        {
            Teste.TST_TIT_005 = Convert.ToDouble(txt_tit_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_005_inc.Text))
        {
            Teste.TST_TNC_005 = Convert.ToDouble(txt_tnc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_005_inc.Text))
        {
            Teste.TST_AON_005 = Convert.ToDouble(txt_aon_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_005_inc.Text))
        {
            Teste.TST_ENM_005 = Convert.ToDouble(txt_enm_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_005_inc.Text))
        {
            Teste.TST_EEE_005 = Convert.ToDouble(txt_eee_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_005_inc.Text))
        {
            Teste.TST_KKK_005 = Convert.ToDouble(txt_kkk_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_005_inc.Text))
        {
            Teste.TST_BBB_005 = Convert.ToDouble(txt_bbb_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_005_inc.Text))
        {
            Teste.TST_OLE_005 = Convert.ToDouble(txt_ole_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_005_inc.Text))
        {
            Teste.TST_TRQ_005 = Convert.ToDouble(txt_trq_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_005_inc.Text))
        {
            Teste.TST_ERT_005 = Convert.ToDouble(txt_ert_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_005_inc.Text))
        {
            Teste.TST_RT3_005 = Convert.ToDouble(txt_rt3_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_005_inc.Text))
        {
            Teste.TST_RT5_005 = Convert.ToDouble(txt_rt5_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_005_inc.Text))
        {
            Teste.TST_DND_005 = Convert.ToDouble(txt_dnd_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_005_inc.Text))
        {
            Teste.TST_DMO_005 = Convert.ToDouble(txt_dmo_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_005_inc.Text))
        {
            Teste.TST_PES_005 = Convert.ToDouble(txt_pes_005_inc.Text);
        }
        Teste.TST_VRR_005 = txt_vrr_005_inc.Text;

        Teste.TST_TRE_005 = txt_tre_005_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_005_inc.Text))
        {
            Teste.TST_LME_005 = Convert.ToDouble(txt_lme_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_005_inc.Text))
        {
            Teste.TST_UME_005 = Convert.ToDouble(txt_ume_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_005_inc.Text))
        {
            Teste.TST_LPE_005 = Convert.ToDouble(txt_lpe_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_005_inc.Text))
        {
            Teste.TST_UPE_005 = Convert.ToDouble(txt_upe_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_005_inc.Text))
        {
            Teste.TST_UCV_005 = Convert.ToDouble(txt_ucv_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_005_inc.Text))
        {
            Teste.TST_DUR_005 = Convert.ToDouble(txt_dur_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_005_inc.Text))
        {
            Teste.TST_DFT_005 = Convert.ToDouble(txt_dft_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_005_inc.Text))
        {
            Teste.TST_LMC_005 = Convert.ToDouble(txt_lmc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_005_inc.Text))
        {
            Teste.TST_UMC_005 = Convert.ToDouble(txt_umc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_005_inc.Text))
        {
            Teste.TST_LPC_005 = Convert.ToDouble(txt_lpc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_005_inc.Text))
        {
            Teste.TST_UPC_005 = Convert.ToDouble(txt_upc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_005_inc.Text))
        {
            Teste.TST_CVC_005 = Convert.ToDouble(txt_cvc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_005_inc.Text))
        {
            Teste.TST_DFC_005 = Convert.ToDouble(txt_dfc_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_005_inc.Text))
        {
            Teste.TST_TFS_005 = Convert.ToDouble(txt_tfs_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_005_inc.Text))
        {
            Teste.TST_FSW_005 = Convert.ToDouble(txt_fsw_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_005_inc.Text))
        {
            Teste.TST_WFW_005 = Convert.ToDouble(txt_wfw_005_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_005_inc.Text))
        {
            Teste.TST_ECO_005 = Convert.ToDouble(txt_eco_005_inc.Text);
        }
        Teste.TST_EOL_005 = txt_eol_005_inc.Text;
        Teste.TST_ETU_005 = txt_etu_005_inc.Text;
        Teste.TST_ETD_005 = txt_etd_005_inc.Text;
        Teste.TST_ECU_005 = txt_ecu_005_inc.Text;
        Teste.TST_EGD_005 = txt_egd_005_inc.Text;
        Teste.TST_EEC_005 = txt_eec_005_inc.Text;
        Teste.TST_ECD_005 = txt_ecd_005_inc.Text;
        Teste.TST_EGU_005 = txt_egu_005_inc.Text;
        Teste.TST_ESO_005 = txt_eso_005_inc.Text;
        Teste.TST_ESI_005 = txt_esi_005_inc.Text;
        Teste.TST_ECR_005 = txt_ecr_005_inc.Text;
        Teste.TST_EOD_005 = txt_eod_005_inc.Text;
        Teste.TST_EAW_005 = txt_eaw_005_inc.Text;
        Teste.TST_ED1_005 = txt_ed1_005_inc.Text;
        Teste.TST_ED2_005 = txt_ed2_005_inc.Text;

        Teste.TST_VW2_006 = txt_vw2_006_inc.Text;
        Teste.TST_EGM_006 = txt_egm_006_inc.Text;
        Teste.TST_DYY_006 = txt_dyy_006_inc.Text;
        Teste.TST_2WX_006 = txt_2wx_006_inc.Text;
        Teste.TST_3W3_006 = txt_3w3_006_inc.Text;
        Teste.TST_4W4_006 = txt_4w4_006_inc.Text;
        Teste.TST_AGL_006 = txt_agl_006_inc.Text;
        Teste.TST_TUP_006 = txt_tup_006_inc.Text;
        Teste.TST_VEO_006 = txt_veo_006_inc.Text;
        Teste.TST_T1T_006 = txt_t1t_006_inc.Text;
        Teste.TST_T1C_006 = txt_t1c_006_inc.Text;
        Teste.TST_T1L_006 = txt_t1l_006_inc.Text;
        Teste.TST_T2F_006 = txt_t2f_006_inc.Text;
        Teste.TST_SVE_006 = txt_sve_006_inc.Text;
        Teste.TST_STF_006 = txt_stf_006_inc.Text;
        Teste.TST_STM_006 = txt_stm_006_inc.Text;
        Teste.TST_SCE_006 = txt_sce_006_inc.Text;
        Teste.TST_SCO_006 = txt_sco_006_inc.Text;
        Teste.TST_SCH_006 = txt_sch_006_inc.Text;
        Teste.TST_SCG_006 = txt_scg_006_inc.Text;
        Teste.TST_SEE_006 = txt_see_006_inc.Text;
        Teste.TST_SEO_006 = txt_seo_006_inc.Text;
        Teste.TST_SEH_006 = txt_seh_006_inc.Text;
        Teste.TST_SEG_006 = txt_seg_006_inc.Text;
        Teste.TST_SJC_006 = txt_sjc_006_inc.Text;
        Teste.TST_SJT_006 = txt_sjt_006_inc.Text;
        Teste.TST_SJB_006 = txt_sjb_006_inc.Text;
        Teste.TST_SPJ_006 = txt_spj_006_inc.Text;
        Teste.TST_SBC_006 = txt_sbc_006_inc.Text;
        Teste.TST_SPO_006 = txt_spo_006_inc.Text;
        Teste.TST_SVA_006 = txt_sva_006_inc.Text;
        Teste.TST_TGR_006 = txt_tgr_006_inc.Text;
        Teste.TST_TIP_006 = txt_tip_006_inc.Text;
        Teste.TST_DSB_006 = txt_dsb_006_inc.Text;
        Teste.TST_TCA_006 = txt_tca_006_inc.Text;
        Teste.TST_FMC_006 = txt_fmc_006_inc.Text;
        Teste.TST_1TB_006 = txt_1tb_006_inc.Text;
        Teste.TST_1PP_006 = txt_1pp_006_inc.Text;
        Teste.TST_2TB_006 = txt_2tb_006_inc.Text;
        Teste.TST_2PP_006 = txt_2pp_006_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_006_inc.Text))
        {
            Teste.TST_CSO_006 = Convert.ToDouble(txt_cso_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_006_inc.Text))
        {
            Teste.TST_ESP_006 = Convert.ToDouble(txt_esp_006_inc.Text);
        }
        Teste.TST_TOL_006 = txt_tol_006_inc.Text;
        Teste.TST_P1C_006 = txt_p1c_006_inc.Text;
        Teste.TST_P2D_006 = txt_p2d_006_inc.Text;
        Teste.TST_P3D_006 = txt_p3d_006_inc.Text;
        Teste.TST_P4U_006 = txt_p4u_006_inc.Text;
        Teste.TST_MOL_006 = txt_mol_006_inc.Text;
        Teste.TST_TPD_006 = txt_tpd_006_inc.Text;
        Teste.TST_TT1_006 = txt_tt1_006_inc.Text;
        Teste.TST_TT2_006 = txt_tt2_006_inc.Text;
        Teste.TST_TT3_006 = txt_tt3_006_inc.Text;
        Teste.TST_T21_006 = txt_t21_006_inc.Text;
        Teste.TST_TUN_006 = txt_tun_006_inc.Text;
        Teste.TST_TCV_006 = txt_tcv_006_inc.Text;
        Teste.TST_TSS_006 = txt_tss_006_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_006_inc.Text))
        {
            Teste.TST_TIT_006 = Convert.ToDouble(txt_tit_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_006_inc.Text))
        {
            Teste.TST_TNC_006 = Convert.ToDouble(txt_tnc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_006_inc.Text))
        {
            Teste.TST_AON_006 = Convert.ToDouble(txt_aon_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_006_inc.Text))
        {
            Teste.TST_ENM_006 = Convert.ToDouble(txt_enm_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_006_inc.Text))
        {
            Teste.TST_EEE_006 = Convert.ToDouble(txt_eee_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_006_inc.Text))
        {
            Teste.TST_KKK_006 = Convert.ToDouble(txt_kkk_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_006_inc.Text))
        {
            Teste.TST_BBB_006 = Convert.ToDouble(txt_bbb_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_006_inc.Text))
        {
            Teste.TST_OLE_006 = Convert.ToDouble(txt_ole_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_006_inc.Text))
        {
            Teste.TST_TRQ_006 = Convert.ToDouble(txt_trq_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_006_inc.Text))
        {
            Teste.TST_ERT_006 = Convert.ToDouble(txt_ert_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_006_inc.Text))
        {
            Teste.TST_RT3_006 = Convert.ToDouble(txt_rt3_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_006_inc.Text))
        {
            Teste.TST_RT5_006 = Convert.ToDouble(txt_rt5_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_006_inc.Text))
        {
            Teste.TST_DND_006 = Convert.ToDouble(txt_dnd_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_006_inc.Text))
        {
            Teste.TST_DMO_006 = Convert.ToDouble(txt_dmo_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_006_inc.Text))
        {
            Teste.TST_PES_006 = Convert.ToDouble(txt_pes_006_inc.Text);
        }
        Teste.TST_VRR_006 = txt_vrr_006_inc.Text;

        Teste.TST_TRE_006 = txt_tre_006_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_006_inc.Text))
        {
            Teste.TST_LME_006 = Convert.ToDouble(txt_lme_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_006_inc.Text))
        {
            Teste.TST_UME_006 = Convert.ToDouble(txt_ume_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_006_inc.Text))
        {
            Teste.TST_LPE_006 = Convert.ToDouble(txt_lpe_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_006_inc.Text))
        {
            Teste.TST_UPE_006 = Convert.ToDouble(txt_upe_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_006_inc.Text))
        {
            Teste.TST_UCV_006 = Convert.ToDouble(txt_ucv_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_006_inc.Text))
        {
            Teste.TST_DUR_006 = Convert.ToDouble(txt_dur_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_006_inc.Text))
        {
            Teste.TST_DFT_006 = Convert.ToDouble(txt_dft_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_006_inc.Text))
        {
            Teste.TST_LMC_006 = Convert.ToDouble(txt_lmc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_006_inc.Text))
        {
            Teste.TST_UMC_006 = Convert.ToDouble(txt_umc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_006_inc.Text))
        {
            Teste.TST_LPC_006 = Convert.ToDouble(txt_lpc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_006_inc.Text))
        {
            Teste.TST_UPC_006 = Convert.ToDouble(txt_upc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_006_inc.Text))
        {
            Teste.TST_CVC_006 = Convert.ToDouble(txt_cvc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_006_inc.Text))
        {
            Teste.TST_DFC_006 = Convert.ToDouble(txt_dfc_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_006_inc.Text))
        {
            Teste.TST_TFS_006 = Convert.ToDouble(txt_tfs_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_006_inc.Text))
        {
            Teste.TST_FSW_006 = Convert.ToDouble(txt_fsw_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_006_inc.Text))
        {
            Teste.TST_WFW_006 = Convert.ToDouble(txt_wfw_006_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_006_inc.Text))
        {
            Teste.TST_ECO_006 = Convert.ToDouble(txt_eco_006_inc.Text);
        }
        Teste.TST_EOL_006 = txt_eol_006_inc.Text;
        Teste.TST_ETU_006 = txt_etu_006_inc.Text;
        Teste.TST_ETD_006 = txt_etd_006_inc.Text;
        Teste.TST_ECU_006 = txt_ecu_006_inc.Text;
        Teste.TST_EGD_006 = txt_egd_006_inc.Text;
        Teste.TST_EEC_006 = txt_eec_006_inc.Text;
        Teste.TST_ECD_006 = txt_ecd_006_inc.Text;
        Teste.TST_EGU_006 = txt_egu_006_inc.Text;
        Teste.TST_ESO_006 = txt_eso_006_inc.Text;
        Teste.TST_ESI_006 = txt_esi_006_inc.Text;
        Teste.TST_ECR_006 = txt_ecr_006_inc.Text;
        Teste.TST_EOD_006 = txt_eod_006_inc.Text;
        Teste.TST_EAW_006 = txt_eaw_006_inc.Text;
        Teste.TST_ED1_006 = txt_ed1_006_inc.Text;
        Teste.TST_ED2_006 = txt_ed2_006_inc.Text;

        Teste.TST_VW2_007 = txt_vw2_007_inc.Text;
        Teste.TST_EGM_007 = txt_egm_007_inc.Text;
        Teste.TST_DYY_007 = txt_dyy_007_inc.Text;
        Teste.TST_2WX_007 = txt_2wx_007_inc.Text;
        Teste.TST_3W3_007 = txt_3w3_007_inc.Text;
        Teste.TST_4W4_007 = txt_4w4_007_inc.Text;
        Teste.TST_AGL_007 = txt_agl_007_inc.Text;
        Teste.TST_TUP_007 = txt_tup_007_inc.Text;
        Teste.TST_VEO_007 = txt_veo_007_inc.Text;
        Teste.TST_T1T_007 = txt_t1t_007_inc.Text;
        Teste.TST_T1C_007 = txt_t1c_007_inc.Text;
        Teste.TST_T1L_007 = txt_t1l_007_inc.Text;
        Teste.TST_T2F_007 = txt_t2f_007_inc.Text;
        Teste.TST_SVE_007 = txt_sve_007_inc.Text;
        Teste.TST_STF_007 = txt_stf_007_inc.Text;
        Teste.TST_STM_007 = txt_stm_007_inc.Text;
        Teste.TST_SCE_007 = txt_sce_007_inc.Text;
        Teste.TST_SCO_007 = txt_sco_007_inc.Text;
        Teste.TST_SCH_007 = txt_sch_007_inc.Text;
        Teste.TST_SCG_007 = txt_scg_007_inc.Text;
        Teste.TST_SEE_007 = txt_see_007_inc.Text;
        Teste.TST_SEO_007 = txt_seo_007_inc.Text;
        Teste.TST_SEH_007 = txt_seh_007_inc.Text;
        Teste.TST_SEG_007 = txt_seg_007_inc.Text;
        Teste.TST_SJC_007 = txt_sjc_007_inc.Text;
        Teste.TST_SJT_007 = txt_sjt_007_inc.Text;
        Teste.TST_SJB_007 = txt_sjb_007_inc.Text;
        Teste.TST_SPJ_007 = txt_spj_007_inc.Text;
        Teste.TST_SBC_007 = txt_sbc_007_inc.Text;
        Teste.TST_SPO_007 = txt_spo_007_inc.Text;
        Teste.TST_SVA_007 = txt_sva_007_inc.Text;
        Teste.TST_TGR_007 = txt_tgr_007_inc.Text;
        Teste.TST_TIP_007 = txt_tip_007_inc.Text;
        Teste.TST_DSB_007 = txt_dsb_007_inc.Text;
        Teste.TST_TCA_007 = txt_tca_007_inc.Text;
        Teste.TST_FMC_007 = txt_fmc_007_inc.Text;
        Teste.TST_1TB_007 = txt_1tb_007_inc.Text;
        Teste.TST_1PP_007 = txt_1pp_007_inc.Text;
        Teste.TST_2TB_007 = txt_2tb_007_inc.Text;
        Teste.TST_2PP_007 = txt_2pp_007_inc.Text;
        if (!string.IsNullOrEmpty(txt_cso_007_inc.Text))
        {
            Teste.TST_CSO_007 = Convert.ToDouble(txt_cso_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_esp_007_inc.Text))
        {
            Teste.TST_ESP_007 = Convert.ToDouble(txt_esp_007_inc.Text);
        }
        Teste.TST_TOL_007 = txt_tol_007_inc.Text;
        Teste.TST_P1C_007 = txt_p1c_007_inc.Text;
        Teste.TST_P2D_007 = txt_p2d_007_inc.Text;
        Teste.TST_P3D_007 = txt_p3d_007_inc.Text;
        Teste.TST_P4U_007 = txt_p4u_007_inc.Text;
        Teste.TST_MOL_007 = txt_mol_007_inc.Text;
        Teste.TST_TPD_007 = txt_tpd_007_inc.Text;
        Teste.TST_TT1_007 = txt_tt1_007_inc.Text;
        Teste.TST_TT2_007 = txt_tt2_007_inc.Text;
        Teste.TST_TT3_007 = txt_tt3_007_inc.Text;
        Teste.TST_T21_007 = txt_t21_007_inc.Text;
        Teste.TST_TUN_007 = txt_tun_007_inc.Text;
        Teste.TST_TCV_007 = txt_tcv_007_inc.Text;
        Teste.TST_TSS_007 = txt_tss_007_inc.Text;
        if (!string.IsNullOrEmpty(txt_tit_007_inc.Text))
        {
            Teste.TST_TIT_007 = Convert.ToDouble(txt_tit_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tnc_007_inc.Text))
        {
            Teste.TST_TNC_007 = Convert.ToDouble(txt_tnc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_aon_007_inc.Text))
        {
            Teste.TST_AON_007 = Convert.ToDouble(txt_aon_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_enm_007_inc.Text))
        {
            Teste.TST_ENM_007 = Convert.ToDouble(txt_enm_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eee_007_inc.Text))
        {
            Teste.TST_EEE_007 = Convert.ToDouble(txt_eee_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_kkk_007_inc.Text))
        {
            Teste.TST_KKK_007 = Convert.ToDouble(txt_kkk_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_bbb_007_inc.Text))
        {
            Teste.TST_BBB_007 = Convert.ToDouble(txt_bbb_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ole_007_inc.Text))
        {
            Teste.TST_OLE_007 = Convert.ToDouble(txt_ole_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_trq_007_inc.Text))
        {
            Teste.TST_TRQ_007 = Convert.ToDouble(txt_trq_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ert_007_inc.Text))
        {
            Teste.TST_ERT_007 = Convert.ToDouble(txt_ert_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt3_007_inc.Text))
        {
            Teste.TST_RT3_007 = Convert.ToDouble(txt_rt3_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_rt5_007_inc.Text))
        {
            Teste.TST_RT5_007 = Convert.ToDouble(txt_rt5_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dnd_007_inc.Text))
        {
            Teste.TST_DND_007 = Convert.ToDouble(txt_dnd_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dmo_007_inc.Text))
        {
            Teste.TST_DMO_007 = Convert.ToDouble(txt_dmo_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_pes_007_inc.Text))
        {
            Teste.TST_PES_007 = Convert.ToDouble(txt_pes_007_inc.Text);
        }
        Teste.TST_VRR_007 = txt_vrr_007_inc.Text;

        Teste.TST_TRE_007 = txt_tre_007_inc.Text;
        if (!string.IsNullOrEmpty(txt_lme_007_inc.Text))
        {
            Teste.TST_LME_007 = Convert.ToDouble(txt_lme_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ume_007_inc.Text))
        {
            Teste.TST_UME_007 = Convert.ToDouble(txt_ume_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpe_007_inc.Text))
        {
            Teste.TST_LPE_007 = Convert.ToDouble(txt_lpe_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upe_007_inc.Text))
        {
            Teste.TST_UPE_007 = Convert.ToDouble(txt_upe_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_ucv_007_inc.Text))
        {
            Teste.TST_UCV_007 = Convert.ToDouble(txt_ucv_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dur_007_inc.Text))
        {
            Teste.TST_DUR_007 = Convert.ToDouble(txt_dur_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dft_007_inc.Text))
        {
            Teste.TST_DFT_007 = Convert.ToDouble(txt_dft_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lmc_007_inc.Text))
        {
            Teste.TST_LMC_007 = Convert.ToDouble(txt_lmc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_umc_007_inc.Text))
        {
            Teste.TST_UMC_007 = Convert.ToDouble(txt_umc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_lpc_007_inc.Text))
        {
            Teste.TST_LPC_007 = Convert.ToDouble(txt_lpc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_upc_007_inc.Text))
        {
            Teste.TST_UPC_007 = Convert.ToDouble(txt_upc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_cvc_007_inc.Text))
        {
            Teste.TST_CVC_007 = Convert.ToDouble(txt_cvc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_dfc_007_inc.Text))
        {
            Teste.TST_DFC_007 = Convert.ToDouble(txt_dfc_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_tfs_007_inc.Text))
        {
            Teste.TST_TFS_007 = Convert.ToDouble(txt_tfs_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_fsw_007_inc.Text))
        {
            Teste.TST_FSW_007 = Convert.ToDouble(txt_fsw_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_wfw_007_inc.Text))
        {
            Teste.TST_WFW_007 = Convert.ToDouble(txt_wfw_007_inc.Text);
        }
        if (!string.IsNullOrEmpty(txt_eco_007_inc.Text))
        {
            Teste.TST_ECO_007 = Convert.ToDouble(txt_eco_007_inc.Text);
        }
        Teste.TST_EOL_007 = txt_eol_007_inc.Text;
        Teste.TST_ETU_007 = txt_etu_007_inc.Text;
        Teste.TST_ETD_007 = txt_etd_007_inc.Text;
        Teste.TST_ECU_007 = txt_ecu_007_inc.Text;
        Teste.TST_EGD_007 = txt_egd_007_inc.Text;
        Teste.TST_EEC_007 = txt_eec_007_inc.Text;
        Teste.TST_ECD_007 = txt_ecd_007_inc.Text;
        Teste.TST_EGU_007 = txt_egu_007_inc.Text;
        Teste.TST_ESO_007 = txt_eso_007_inc.Text;
        Teste.TST_ESI_007 = txt_esi_007_inc.Text;
        Teste.TST_ECR_007 = txt_ecr_007_inc.Text;
        Teste.TST_EOD_007 = txt_eod_007_inc.Text;
        Teste.TST_EAW_007 = txt_eaw_007_inc.Text;
        Teste.TST_ED1_007 = txt_ed1_007_inc.Text;
        Teste.TST_ED2_007 = txt_ed2_007_inc.Text;
        Teste.TST_PCO_REF = txt_pco_ref_inc.Text;
        Teste.TST_PCV_REF = txt_pcv_ref_inc.Text;
        Teste.TST_DRT_REF = txt_drt_ref_inc.Text;
        Teste.TST_TAL_REF = txt_tal_ref_inc.Text;
        Teste.TST_VAL_REF = txt_val_ref_inc.Text;
        Teste.TST_SJE_REF = txt_sje_ref_inc.Text;
        Teste.TST_PCO_001 = txt_pco_001_inc.Text;
        Teste.TST_PCV_001 = txt_pcv_001_inc.Text;
        Teste.TST_DRT_001 = txt_drt_001_inc.Text;
        Teste.TST_TAL_001 = txt_tal_001_inc.Text;
        Teste.TST_VAL_001 = txt_val_001_inc.Text;
        Teste.TST_SJE_001 = txt_sje_001_inc.Text;
        Teste.TST_PCO_002 = txt_pco_002_inc.Text;
        Teste.TST_PCV_002 = txt_pcv_002_inc.Text;
        Teste.TST_DRT_002 = txt_drt_002_inc.Text;
        Teste.TST_TAL_002 = txt_tal_002_inc.Text;
        Teste.TST_VAL_002 = txt_val_002_inc.Text;
        Teste.TST_SJE_002 = txt_sje_002_inc.Text;
        Teste.TST_PCO_003 = txt_pco_003_inc.Text;
        Teste.TST_PCV_003 = txt_pcv_003_inc.Text;
        Teste.TST_DRT_003 = txt_drt_003_inc.Text;
        Teste.TST_TAL_003 = txt_tal_003_inc.Text;
        Teste.TST_VAL_003 = txt_val_003_inc.Text;
        Teste.TST_SJE_003 = txt_sje_003_inc.Text;
        Teste.TST_PCO_004 = txt_pco_004_inc.Text;
        Teste.TST_PCV_004 = txt_pcv_004_inc.Text;
        Teste.TST_DRT_004 = txt_drt_004_inc.Text;
        Teste.TST_TAL_004 = txt_tal_004_inc.Text;
        Teste.TST_VAL_004 = txt_val_004_inc.Text;
        Teste.TST_SJE_004 = txt_sje_004_inc.Text;
        Teste.TST_PCO_005 = txt_pco_005_inc.Text;
        Teste.TST_PCV_005 = txt_pcv_005_inc.Text;
        Teste.TST_DRT_005 = txt_drt_005_inc.Text;
        Teste.TST_TAL_005 = txt_tal_005_inc.Text;
        Teste.TST_VAL_005 = txt_val_005_inc.Text;
        Teste.TST_SJE_005 = txt_sje_005_inc.Text;
        Teste.TST_PCO_006 = txt_pco_006_inc.Text;
        Teste.TST_PCV_006 = txt_pcv_006_inc.Text;
        Teste.TST_DRT_006 = txt_drt_006_inc.Text;
        Teste.TST_TAL_006 = txt_tal_006_inc.Text;
        Teste.TST_VAL_006 = txt_val_006_inc.Text;
        Teste.TST_SJE_006 = txt_sje_006_inc.Text;
        Teste.TST_PCO_007 = txt_pco_007_inc.Text;
        Teste.TST_PCV_007 = txt_pcv_007_inc.Text;
        Teste.TST_DRT_007 = txt_drt_007_inc.Text;
        Teste.TST_TAL_007 = txt_tal_007_inc.Text;
        Teste.TST_VAL_007 = txt_val_007_inc.Text;
        Teste.TST_SJE_007 = txt_sje_007_inc.Text;

        Teste.TST_DET = txt_det_inc.Text;

        Teste.TST_OBS = txt_obs_inc.Text;
        if (cbo_sts_inc.Text != "")
        {
            Teste.TST_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
        }

        if (!string.IsNullOrEmpty(rowId.Value))
        {
            Teste.TST_ID = Convert.ToInt32(rowId.Value);
            Teste.TST_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Teste.Alterar();
            if (sMsg != "")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                TratamentoErro("Teste alterado com sucesso.");
            }
        }
        else
        {
            /* Não verificar duplicidade de TST
            Teste TST = new Teste();
            //Verificar se já não existe um cadastro consultando o: TST_DES 
            TST.TST_DES = txt_des_inc.Text;
            DataSet dsTST = TST.Consultar();
            if (dsTST.Tables[0].Rows.Count > 0)
            {
                TratamentoErro("Esse Teste já está cadastrado.");
                txt_rts.Focus();

                return;
            }
            */
            Teste.TST_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Teste.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                rowId.Value = sMsg;

                TratamentoErro("Teste inserido com sucesso.");
                if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
            }
            //dsTST.Dispose();
        }
        Dispose();
        divCadastro.Visible = false;
        dvFiltro.Visible = true;

        rowId.Value = null;
    }

    protected void gvDynafil_RowDataBound(object sender, GridViewRowEventArgs e)
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

    protected void gvDynafil_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void CarregaDynafil()
    {
        if (!string.IsNullOrEmpty(txt_mge_inc.Text))
        {
            Dynafil Dynafil = new Dynafil();
            Dynafil.LST_DNF_MGE = "'" + txt_mge_inc.Text + "'";
            if (!string.IsNullOrEmpty(txt_mge_002_inc.Text))
            {
                Dynafil.LST_DNF_MGE += ", '" + txt_mge_002_inc.Text + "'";
            }
            if (!string.IsNullOrEmpty(txt_mge_003_inc.Text))
            {
                Dynafil.LST_DNF_MGE += ", '" + txt_mge_003_inc.Text + "'";
            }

            if (!string.IsNullOrEmpty(txt_mge_ref_inc.Text))
            {
                Dynafil.LST_DNF_MGE += ", '" + txt_mge_ref_inc.Text + "'";
            }
            if (!string.IsNullOrEmpty(txt_mge_002_ref_inc.Text))
            {
                Dynafil.LST_DNF_MGE += ", '" + txt_mge_002_ref_inc.Text + "'";
            }
            if (!string.IsNullOrEmpty(txt_mge_003_ref_inc.Text))
            {
                Dynafil.LST_DNF_MGE += ", '" + txt_mge_003_ref_inc.Text + "'";
            }
            DataSet dsDynafil = Dynafil.ConsultarMediaMergeTotal();

            gvDynafil.DataSource = dsDynafil;
            gvDynafil.DataBind();
            dsDynafil.Dispose();
            Dispose();
        }
    }

    protected void gvPerformance_RowDataBound(object sender, GridViewRowEventArgs e)
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

    protected void gvPerformance_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void CarregaPerformance()
    {
        if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
        {
            Performance Performance = new Performance();
            Performance.PFM_LOT = txt_lot_ref_inc.Text;
            DataSet dsPerformance = Performance.Consultar();

            gvPerformance.DataSource = dsPerformance;
            gvPerformance.DataBind();
            dsPerformance.Dispose();
            Dispose();
        }
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvTeste.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTeste.AllowSorting = false;
            gvTeste.AllowPaging = false;
            //gvTeste.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvTeste.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTeste.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTeste.RenderControl(htmlWrite);

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
        if (gvTeste.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvTeste.AllowSorting = false;
            gvTeste.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvTeste.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvTeste.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvTeste.RenderControl(htmlWrite);

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

    protected void txt_mge_inc_OnTextChanged(object sender, EventArgs e)
    {
        CarregaDynafil();

        cbo_for_001_id_inc.Focus();
    }

    protected void calculaTempoGasto(object sender, EventArgs e)
    {
        txt_hor_gst_inc.Text = "";

        TextBox tb = (TextBox)sender;
        if (tb != null)
        {
            switch (tb.ID)
            {
                case "txt_dat_ini_inc":
                    txt_hor_ini_inc.Focus();
                    break;
                case "txt_hor_ini_inc":
                    txt_dat_fim_inc.Focus();
                    break;
                case "txt_dat_fim_inc":
                    txt_hor_fim_inc.Focus();
                    break;
                case "txt_hor_fim_inc":
                    txt_hor_gst_inc.Focus();
                    break;
            }
        }

        if (!string.IsNullOrEmpty(txt_dat_ini_inc.Text) && !string.IsNullOrEmpty(txt_hor_ini_inc.Text) && !string.IsNullOrEmpty(txt_dat_fim_inc.Text) && !string.IsNullOrEmpty(txt_hor_fim_inc.Text))
        {
            DateTime dtIni;
            try
            {
                dtIni = DateTime.Parse(txt_dat_ini_inc.Text + " " + txt_hor_ini_inc.Text);
            }
            catch
            {
                txt_dat_ini_inc.Focus();
                return;
            }

            DateTime dtFim;
            try
            {
                dtFim = DateTime.Parse(txt_dat_fim_inc.Text + " " + txt_hor_fim_inc.Text);
            }
            catch
            {
                txt_dat_fim_inc.Focus();
                return;
            }

            TimeSpan tsGst = dtFim.Subtract(dtIni);
            txt_hor_gst_inc.Text = Math.Truncate(tsGst.TotalHours).ToString("00") + ":" + tsGst.Minutes.ToString("00");
        }
    }

    protected void txt_rts_inc_OnTextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_rts_inc.Text))
        {
            RTS RTS = new RTS();
            RTS.RTS_ID = Convert.ToInt32(txt_rts_inc.Text);
            DataSet dsRTS = RTS.Consultar();
            if (dsRTS.Tables[0].Rows.Count > 0)
            {
                cbo_mtv_tst_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MTV_TST_ID"].ToString();
                txt_lot_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT"].ToString();
                txt_lot_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_LOT_REF"].ToString();
                if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
                {
                    txt_lot_ref_inc.ReadOnly = true;
                }
                CarregaLoteReferencia();

                cbo_tit_poy_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_TIT_POY_ID"].ToString();
                txt_mge_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE"].ToString();
                txt_mge_002_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_002"].ToString();
                txt_mge_003_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_003"].ToString();
                cbo_for_001_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_003_ID"].ToString();
                //Excluído por solicitação do Wagner 11/07/2011
                //txt_vlc_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_MAQ_TIP_ID"].ToString();
                cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
                cbo_ert_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_ERT_ID"].ToString();

                CarregaDynafil();
                CarregaPerformance();
            }
        }

        txt_lot_inc.Focus();
    }

    protected void txt_lot_ref_inc_OnTextChanged(object sender, EventArgs e)
    {
        CarregaLoteReferencia();

        CarregaDynafil();
        CarregaPerformance();

        txt_lot_epf_inc.Focus();
    }

    protected void CarregaLoteReferencia()
    {
        if (!string.IsNullOrEmpty(txt_lot_ref_inc.Text))
        {
            //Carrega do Standard em vez do RTS
            /*
            RTS RTS = new RTS();
            RTS.RTS_LOT = txt_lot_ref_inc.Text;
            DataSet dsRTS = RTS.Consultar();
            if (dsRTS.Tables[0].Rows.Count > 0)
            {
                txt_mge_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE"].ToString();
                txt_mge_002_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_002"].ToString();
                txt_mge_003_ref_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_003"].ToString();
            }
            */
            Standard Standard = new Standard();
            Standard.EPF_LOT = txt_lot_ref_inc.Text;
            Standard.EPF_STS = 1; //Ativo
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count > 0)
            {
                txt_mge_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
                txt_mge_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_002"].ToString();
                txt_mge_003_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_003"].ToString();
            }
            else
            {
                txt_mge_ref_inc.Text = "";
                txt_mge_002_ref_inc.Text = "";
                txt_mge_003_ref_inc.Text = "";
            }
        }
    }

    protected void txt_lot_epf_inc_OnTextChanged(object sender, EventArgs e)
    {
        txt_lot_ans_inc.Focus();

        if (!string.IsNullOrEmpty(txt_lot_epf_inc.Text))
        {
            Standard Standard = new Standard();
            Standard.EPF_LOT = txt_lot_epf_inc.Text;
            Standard.EPF_STS = 1; //Ativo
            DataSet dsStandard = Standard.Consultar();
            if (dsStandard.Tables[0].Rows.Count > 0)
            {
                //Manter dados da RTS 11/07/2011
                /*
                cbo_tit_poy_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIT_POY_ID"].ToString();
                txt_mge_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE"].ToString();
                cbo_for_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_FOR_ID"].ToString();
                txt_vlc_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_MAQ_TIP_ID"].ToString();
                cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
                cbo_ert_id_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_ERT_ID"].ToString();
                */

                txt_vw2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VW2"].ToString();
                txt_egm_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGM"].ToString();
                txt_dyy_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DYY"].ToString();
                txt_2wx_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2WX"].ToString();
                txt_3w3_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_3W3"].ToString();
                txt_4w4_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_4W4"].ToString();
                txt_agl_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AGL"].ToString();
                txt_tup_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUP"].ToString();
                txt_veo_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VEO"].ToString();
                txt_t1t_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1T"].ToString();
                txt_t1c_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1C"].ToString();
                txt_t1l_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T1L"].ToString();
                txt_t2f_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T2F"].ToString();
                txt_sve_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVE"].ToString();
                txt_stf_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STF"].ToString();
                txt_stm_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STM"].ToString();
                txt_sce_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCE"].ToString();
                txt_sco_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCO"].ToString();
                txt_sch_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCH"].ToString();
                txt_scg_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SCG"].ToString();
                txt_see_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEE"].ToString();
                txt_seo_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEO"].ToString();
                txt_seh_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEH"].ToString();
                txt_seg_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SEG"].ToString();
                txt_sjc_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJC"].ToString();
                txt_sjt_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJT"].ToString();
                txt_sjb_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJB"].ToString();
                txt_spj_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPJ"].ToString();
                txt_sbc_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SBC"].ToString();
                txt_spo_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SPO"].ToString();
                txt_sva_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SVA"].ToString();
                txt_tgr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TGR"].ToString();
                txt_tip_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIP"].ToString();
                txt_dsb_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DSB"].ToString();
                txt_tca_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCA"].ToString();
                txt_fmc_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FMC"].ToString();
                txt_1tb_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1TB"].ToString();
                txt_1pp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_1PP"].ToString();
                txt_2tb_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2TB"].ToString();
                txt_2pp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_2PP"].ToString();
                txt_cso_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CSO"].ToString();
                txt_esp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESP"].ToString();
                txt_tol_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TOL"].ToString();
                txt_p1c_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P1C"].ToString();
                txt_p2d_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P2D"].ToString();
                txt_p3d_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P3D"].ToString();
                txt_p4u_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_P4U"].ToString();
                txt_mol_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MOL"].ToString();
                txt_tpd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TPD"].ToString();
                txt_tt1_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT1"].ToString();
                txt_tt2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT2"].ToString();
                txt_tt3_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TT3"].ToString();
                txt_t21_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_T21"].ToString();
                txt_tun_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TUN"].ToString();
                txt_tcv_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCV"].ToString();
                txt_tss_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSS"].ToString();

                txt_tit_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TIT"].ToString();
                txt_tnc_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TNC"].ToString();
                txt_aon_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AON"].ToString();
                txt_enm_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ENM"].ToString();
                txt_eee_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEE"].ToString();
                txt_kkk_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_KKK"].ToString();
                txt_bbb_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBB"].ToString();
                txt_ole_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OLE"].ToString();
                txt_trq_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRQ"].ToString();
                txt_ert_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERT"].ToString();
                txt_rt3_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT3"].ToString();
                txt_rt5_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RT5"].ToString();
                txt_dnd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DND"].ToString();
                txt_dmo_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DMO"].ToString();
                txt_pes_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PES"].ToString();
                txt_vrr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRR"].ToString();

                txt_tre_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TRE"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()))
                {
                    txt_lme_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()))
                {
                    txt_ume_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UME"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()))
                {
                    txt_lpe_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()))
                {
                    txt_upe_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPE"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()))
                {
                    txt_ucv_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UCV"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()))
                {
                    txt_dur_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DUR"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()))
                {
                    txt_dft_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFT"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()))
                {
                    txt_lmc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()))
                {
                    txt_umc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UMC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()))
                {
                    txt_lpc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()))
                {
                    txt_upc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_UPC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()))
                {
                    txt_cvc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_CVC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()))
                {
                    txt_dfc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_DFC"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()))
                {
                    txt_tfs_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_TFS"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()))
                {
                    txt_fsw_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_FSW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()))
                {
                    txt_wfw_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_WFW"].ToString()).ToString("0.0");
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_ECO"].ToString()))
                {
                    txt_eco_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_ECO"].ToString()).ToString("0.0");
                }

                txt_eol_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOL"].ToString();
                txt_etu_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETU"].ToString();
                txt_etd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETD"].ToString();
                txt_ecu_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECU"].ToString();
                txt_egd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGD"].ToString();
                txt_eec_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EEC"].ToString();
                txt_ecd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECD"].ToString();
                txt_egu_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EGU"].ToString();
                txt_eso_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESO"].ToString();
                txt_esi_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ESI"].ToString();
                txt_ecr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECR"].ToString();
                txt_eod_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EOD"].ToString();
                txt_eaw_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAW"].ToString();
                txt_ed1_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED1"].ToString();
                txt_ed2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ED2"].ToString();

                txt_pco_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCO"].ToString();
                txt_pcv_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCV"].ToString();
                txt_drt_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DRT"].ToString();
                txt_tal_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAL"].ToString();
                txt_val_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAL"].ToString();
                txt_sje_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJE"].ToString();
                //CarregaDynafil();
                //CarregaPerformance();
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Lote de Standard não existe !');", true);
                txt_lot_epf_inc.Focus();
            }
            dsStandard.Dispose();
            Dispose();
        }

    }

    protected void txt_lot_ans_inc_OnTextChanged(object sender, EventArgs e)
    {
        cbo_tit_poy_id_inc.Focus();

        if (!string.IsNullOrEmpty(txt_lot_ans_inc.Text))
        {
            Analise Analise = new Analise();
            Analise.ANS_LOT = txt_lot_ans_inc.Text;
            DataSet dsAnalise = Analise.ConsultarMedia();
            if (dsAnalise.Tables[0].Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["TIT_MED"].ToString()))
                {
                    txt_tit_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["TNC_MED"].ToString()))
                {
                    txt_tnc_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["AON_MED"].ToString()))
                {
                    txt_aon_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["ENM_MED"].ToString()))
                {
                    txt_enm_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["ENM_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["EEE_MED"].ToString()))
                {
                    txt_eee_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["EEE_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["KKK_MED"].ToString()))
                {
                    txt_kkk_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["KKK_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["BBB_MED"].ToString()))
                {
                    txt_bbb_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["BBB_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["OLE_MED"].ToString()))
                {
                    txt_ole_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["OLE_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["TRQ_MED"].ToString()))
                {
                    txt_trq_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["TRQ_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["ERT_MED"].ToString()))
                {
                    txt_ert_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["ERT_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["RT3_MED"].ToString()))
                {
                    txt_rt3_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["RT3_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["RT5_MED"].ToString()))
                {
                    txt_rt5_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["RT5_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["DND_MED"].ToString()))
                {
                    txt_dnd_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["DND_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["DMO_MED"].ToString()))
                {
                    txt_dmo_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["DMO_MED"].ToString()).ToString("0.00");
                }
                if (!string.IsNullOrEmpty(dsAnalise.Tables[0].Rows[0]["PES_MED"].ToString()))
                {
                    txt_pes_ref_inc.Text = Convert.ToDouble(dsAnalise.Tables[0].Rows[0]["PES_MED"].ToString()).ToString("0.00");
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Lote de Serimetria não existe !');", true);
                txt_lot_ans_inc.Focus();
            }
            dsAnalise.Dispose();
            Dispose();
        }

    }

    protected void cbo_maq_tip_id_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(cbo_maq_tip_id_inc.SelectedValue))
        {
            MaquinaTipo MAQTIP = new MaquinaTipo();
            MAQTIP.MAQ_TIP_ID = Convert.ToInt32(cbo_maq_tip_id_inc.SelectedValue);
            DataSet dsMAQTIP = MAQTIP.Consultar();
            if (dsMAQTIP.Tables[0].Rows.Count > 0)
            {
                if (dsMAQTIP.Tables[0].Rows[0]["MAQ_TIP_DES"].ToString() == "STAHLE")
                {
                    pnl_afk.Visible = false;
                    pnl_sta.Visible = true;
                }
                else
                {
                    pnl_afk.Visible = true;
                    pnl_sta.Visible = false;
                }

            }
            dsMAQTIP.Dispose();
            Dispose();
        }

        cbo_ert_id_inc.Focus();
    }

    protected void btAtualizarStandard_Click(object sender, EventArgs e)
    {

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

        if (cbo_for_001_id_inc.Text == "")
        {
            TratamentoErro("O campo Fornecedor é obrigatório.");
            cbo_for_001_id_inc.Focus();
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

        Standard Standard = new Standard();
        Standard.EPF_DAT = DateTime.Now;
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
        //Standard.EPF_MGE_004 = txt_mge_004_inc.Text;
        if (cbo_for_001_id_inc.Text != "")
        {
            Standard.EPF_FOR_ID = Convert.ToInt32(cbo_for_001_id_inc.SelectedValue);
        }
        if (cbo_for_002_id_inc.Text != "")
        {
            Standard.EPF_FOR_002_ID = Convert.ToInt32(cbo_for_002_id_inc.SelectedValue);
        }
        if (cbo_for_003_id_inc.Text != "")
        {
            Standard.EPF_FOR_003_ID = Convert.ToInt32(cbo_for_003_id_inc.SelectedValue);
        }
        //if (cbo_for_004_id_inc.Text != "")
        //{
        //    Standard.EPF_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
        //}
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
        Standard.EPF_VW2 = !string.IsNullOrEmpty(txt_vw2_007_inc.Text) ? txt_vw2_007_inc.Text : !string.IsNullOrEmpty(txt_vw2_006_inc.Text) ? txt_vw2_006_inc.Text : !string.IsNullOrEmpty(txt_vw2_005_inc.Text) ? txt_vw2_005_inc.Text : !string.IsNullOrEmpty(txt_vw2_004_inc.Text) ? txt_vw2_004_inc.Text : !string.IsNullOrEmpty(txt_vw2_003_inc.Text) ? txt_vw2_003_inc.Text : !string.IsNullOrEmpty(txt_vw2_002_inc.Text) ? txt_vw2_002_inc.Text : !string.IsNullOrEmpty(txt_vw2_001_inc.Text) ? txt_vw2_001_inc.Text : txt_vw2_ref_inc.Text;
        Standard.EPF_EGM = !string.IsNullOrEmpty(txt_egm_007_inc.Text) ? txt_egm_007_inc.Text : !string.IsNullOrEmpty(txt_egm_006_inc.Text) ? txt_egm_006_inc.Text : !string.IsNullOrEmpty(txt_egm_005_inc.Text) ? txt_egm_005_inc.Text : !string.IsNullOrEmpty(txt_egm_004_inc.Text) ? txt_egm_004_inc.Text : !string.IsNullOrEmpty(txt_egm_003_inc.Text) ? txt_egm_003_inc.Text : !string.IsNullOrEmpty(txt_egm_002_inc.Text) ? txt_egm_002_inc.Text : !string.IsNullOrEmpty(txt_egm_001_inc.Text) ? txt_egm_001_inc.Text : txt_egm_ref_inc.Text;
        Standard.EPF_DYY = !string.IsNullOrEmpty(txt_dyy_007_inc.Text) ? txt_dyy_007_inc.Text : !string.IsNullOrEmpty(txt_dyy_006_inc.Text) ? txt_dyy_006_inc.Text : !string.IsNullOrEmpty(txt_dyy_005_inc.Text) ? txt_dyy_005_inc.Text : !string.IsNullOrEmpty(txt_dyy_004_inc.Text) ? txt_dyy_004_inc.Text : !string.IsNullOrEmpty(txt_dyy_003_inc.Text) ? txt_dyy_003_inc.Text : !string.IsNullOrEmpty(txt_dyy_002_inc.Text) ? txt_dyy_002_inc.Text : !string.IsNullOrEmpty(txt_dyy_001_inc.Text) ? txt_dyy_001_inc.Text : txt_dyy_ref_inc.Text;
        Standard.EPF_2WX = !string.IsNullOrEmpty(txt_2wx_007_inc.Text) ? txt_2wx_007_inc.Text : !string.IsNullOrEmpty(txt_2wx_006_inc.Text) ? txt_2wx_006_inc.Text : !string.IsNullOrEmpty(txt_2wx_005_inc.Text) ? txt_2wx_005_inc.Text : !string.IsNullOrEmpty(txt_2wx_004_inc.Text) ? txt_2wx_004_inc.Text : !string.IsNullOrEmpty(txt_2wx_003_inc.Text) ? txt_2wx_003_inc.Text : !string.IsNullOrEmpty(txt_2wx_002_inc.Text) ? txt_2wx_002_inc.Text : !string.IsNullOrEmpty(txt_2wx_001_inc.Text) ? txt_2wx_001_inc.Text : txt_2wx_ref_inc.Text;
        Standard.EPF_3W3 = !string.IsNullOrEmpty(txt_3w3_007_inc.Text) ? txt_3w3_007_inc.Text : !string.IsNullOrEmpty(txt_3w3_006_inc.Text) ? txt_3w3_006_inc.Text : !string.IsNullOrEmpty(txt_3w3_005_inc.Text) ? txt_3w3_005_inc.Text : !string.IsNullOrEmpty(txt_3w3_004_inc.Text) ? txt_3w3_004_inc.Text : !string.IsNullOrEmpty(txt_3w3_003_inc.Text) ? txt_3w3_003_inc.Text : !string.IsNullOrEmpty(txt_3w3_002_inc.Text) ? txt_3w3_002_inc.Text : !string.IsNullOrEmpty(txt_3w3_001_inc.Text) ? txt_3w3_001_inc.Text : txt_3w3_ref_inc.Text;
        Standard.EPF_4W4 = !string.IsNullOrEmpty(txt_4w4_007_inc.Text) ? txt_4w4_007_inc.Text : !string.IsNullOrEmpty(txt_4w4_006_inc.Text) ? txt_4w4_006_inc.Text : !string.IsNullOrEmpty(txt_4w4_005_inc.Text) ? txt_4w4_005_inc.Text : !string.IsNullOrEmpty(txt_4w4_004_inc.Text) ? txt_4w4_004_inc.Text : !string.IsNullOrEmpty(txt_4w4_003_inc.Text) ? txt_4w4_003_inc.Text : !string.IsNullOrEmpty(txt_4w4_002_inc.Text) ? txt_4w4_002_inc.Text : !string.IsNullOrEmpty(txt_4w4_001_inc.Text) ? txt_4w4_001_inc.Text : txt_4w4_ref_inc.Text;
        Standard.EPF_AGL = !string.IsNullOrEmpty(txt_agl_007_inc.Text) ? txt_agl_007_inc.Text : !string.IsNullOrEmpty(txt_agl_006_inc.Text) ? txt_agl_006_inc.Text : !string.IsNullOrEmpty(txt_agl_005_inc.Text) ? txt_agl_005_inc.Text : !string.IsNullOrEmpty(txt_agl_004_inc.Text) ? txt_agl_004_inc.Text : !string.IsNullOrEmpty(txt_agl_003_inc.Text) ? txt_agl_003_inc.Text : !string.IsNullOrEmpty(txt_agl_002_inc.Text) ? txt_agl_002_inc.Text : !string.IsNullOrEmpty(txt_agl_001_inc.Text) ? txt_agl_001_inc.Text : txt_agl_ref_inc.Text;
        Standard.EPF_TUP = !string.IsNullOrEmpty(txt_tup_007_inc.Text) ? txt_tup_007_inc.Text : !string.IsNullOrEmpty(txt_tup_006_inc.Text) ? txt_tup_006_inc.Text : !string.IsNullOrEmpty(txt_tup_005_inc.Text) ? txt_tup_005_inc.Text : !string.IsNullOrEmpty(txt_tup_004_inc.Text) ? txt_tup_004_inc.Text : !string.IsNullOrEmpty(txt_tup_003_inc.Text) ? txt_tup_003_inc.Text : !string.IsNullOrEmpty(txt_tup_002_inc.Text) ? txt_tup_002_inc.Text : !string.IsNullOrEmpty(txt_tup_001_inc.Text) ? txt_tup_001_inc.Text : txt_tup_ref_inc.Text;
        Standard.EPF_VEO = !string.IsNullOrEmpty(txt_veo_007_inc.Text) ? txt_veo_007_inc.Text : !string.IsNullOrEmpty(txt_veo_006_inc.Text) ? txt_veo_006_inc.Text : !string.IsNullOrEmpty(txt_veo_005_inc.Text) ? txt_veo_005_inc.Text : !string.IsNullOrEmpty(txt_veo_004_inc.Text) ? txt_veo_004_inc.Text : !string.IsNullOrEmpty(txt_veo_003_inc.Text) ? txt_veo_003_inc.Text : !string.IsNullOrEmpty(txt_veo_002_inc.Text) ? txt_veo_002_inc.Text : !string.IsNullOrEmpty(txt_veo_001_inc.Text) ? txt_veo_001_inc.Text : txt_veo_ref_inc.Text;
        Standard.EPF_T1T = !string.IsNullOrEmpty(txt_t1t_007_inc.Text) ? txt_t1t_007_inc.Text : !string.IsNullOrEmpty(txt_t1t_006_inc.Text) ? txt_t1t_006_inc.Text : !string.IsNullOrEmpty(txt_t1t_005_inc.Text) ? txt_t1t_005_inc.Text : !string.IsNullOrEmpty(txt_t1t_004_inc.Text) ? txt_t1t_004_inc.Text : !string.IsNullOrEmpty(txt_t1t_003_inc.Text) ? txt_t1t_003_inc.Text : !string.IsNullOrEmpty(txt_t1t_002_inc.Text) ? txt_t1t_002_inc.Text : !string.IsNullOrEmpty(txt_t1t_001_inc.Text) ? txt_t1t_001_inc.Text : txt_t1t_ref_inc.Text;
        Standard.EPF_T1C = !string.IsNullOrEmpty(txt_t1c_007_inc.Text) ? txt_t1c_007_inc.Text : !string.IsNullOrEmpty(txt_t1c_006_inc.Text) ? txt_t1c_006_inc.Text : !string.IsNullOrEmpty(txt_t1c_005_inc.Text) ? txt_t1c_005_inc.Text : !string.IsNullOrEmpty(txt_t1c_004_inc.Text) ? txt_t1c_004_inc.Text : !string.IsNullOrEmpty(txt_t1c_003_inc.Text) ? txt_t1c_003_inc.Text : !string.IsNullOrEmpty(txt_t1c_002_inc.Text) ? txt_t1c_002_inc.Text : !string.IsNullOrEmpty(txt_t1c_001_inc.Text) ? txt_t1c_001_inc.Text : txt_t1c_ref_inc.Text;
        Standard.EPF_T1L = !string.IsNullOrEmpty(txt_t1l_007_inc.Text) ? txt_t1l_007_inc.Text : !string.IsNullOrEmpty(txt_t1l_006_inc.Text) ? txt_t1l_006_inc.Text : !string.IsNullOrEmpty(txt_t1l_005_inc.Text) ? txt_t1l_005_inc.Text : !string.IsNullOrEmpty(txt_t1l_004_inc.Text) ? txt_t1l_004_inc.Text : !string.IsNullOrEmpty(txt_t1l_003_inc.Text) ? txt_t1l_003_inc.Text : !string.IsNullOrEmpty(txt_t1l_002_inc.Text) ? txt_t1l_002_inc.Text : !string.IsNullOrEmpty(txt_t1l_001_inc.Text) ? txt_t1l_001_inc.Text : txt_t1l_ref_inc.Text;
        Standard.EPF_T2F = !string.IsNullOrEmpty(txt_t2f_007_inc.Text) ? txt_t2f_007_inc.Text : !string.IsNullOrEmpty(txt_t2f_006_inc.Text) ? txt_t2f_006_inc.Text : !string.IsNullOrEmpty(txt_t2f_005_inc.Text) ? txt_t2f_005_inc.Text : !string.IsNullOrEmpty(txt_t2f_004_inc.Text) ? txt_t2f_004_inc.Text : !string.IsNullOrEmpty(txt_t2f_003_inc.Text) ? txt_t2f_003_inc.Text : !string.IsNullOrEmpty(txt_t2f_002_inc.Text) ? txt_t2f_002_inc.Text : !string.IsNullOrEmpty(txt_t2f_001_inc.Text) ? txt_t2f_001_inc.Text : txt_t2f_ref_inc.Text;
        Standard.EPF_SVE = !string.IsNullOrEmpty(txt_sve_007_inc.Text) ? txt_sve_007_inc.Text : !string.IsNullOrEmpty(txt_sve_006_inc.Text) ? txt_sve_006_inc.Text : !string.IsNullOrEmpty(txt_sve_005_inc.Text) ? txt_sve_005_inc.Text : !string.IsNullOrEmpty(txt_sve_004_inc.Text) ? txt_sve_004_inc.Text : !string.IsNullOrEmpty(txt_sve_003_inc.Text) ? txt_sve_003_inc.Text : !string.IsNullOrEmpty(txt_sve_002_inc.Text) ? txt_sve_002_inc.Text : !string.IsNullOrEmpty(txt_sve_001_inc.Text) ? txt_sve_001_inc.Text : txt_sve_ref_inc.Text;
        Standard.EPF_STF = !string.IsNullOrEmpty(txt_stf_007_inc.Text) ? txt_stf_007_inc.Text : !string.IsNullOrEmpty(txt_stf_006_inc.Text) ? txt_stf_006_inc.Text : !string.IsNullOrEmpty(txt_stf_005_inc.Text) ? txt_stf_005_inc.Text : !string.IsNullOrEmpty(txt_stf_004_inc.Text) ? txt_stf_004_inc.Text : !string.IsNullOrEmpty(txt_stf_003_inc.Text) ? txt_stf_003_inc.Text : !string.IsNullOrEmpty(txt_stf_002_inc.Text) ? txt_stf_002_inc.Text : !string.IsNullOrEmpty(txt_stf_001_inc.Text) ? txt_stf_001_inc.Text : txt_stf_ref_inc.Text;
        Standard.EPF_STM = !string.IsNullOrEmpty(txt_stm_007_inc.Text) ? txt_stm_007_inc.Text : !string.IsNullOrEmpty(txt_stm_006_inc.Text) ? txt_stm_006_inc.Text : !string.IsNullOrEmpty(txt_stm_005_inc.Text) ? txt_stm_005_inc.Text : !string.IsNullOrEmpty(txt_stm_004_inc.Text) ? txt_stm_004_inc.Text : !string.IsNullOrEmpty(txt_stm_003_inc.Text) ? txt_stm_003_inc.Text : !string.IsNullOrEmpty(txt_stm_002_inc.Text) ? txt_stm_002_inc.Text : !string.IsNullOrEmpty(txt_stm_001_inc.Text) ? txt_stm_001_inc.Text : txt_stm_ref_inc.Text;
        Standard.EPF_SCE = !string.IsNullOrEmpty(txt_sce_007_inc.Text) ? txt_sce_007_inc.Text : !string.IsNullOrEmpty(txt_sce_006_inc.Text) ? txt_sce_006_inc.Text : !string.IsNullOrEmpty(txt_sce_005_inc.Text) ? txt_sce_005_inc.Text : !string.IsNullOrEmpty(txt_sce_004_inc.Text) ? txt_sce_004_inc.Text : !string.IsNullOrEmpty(txt_sce_003_inc.Text) ? txt_sce_003_inc.Text : !string.IsNullOrEmpty(txt_sce_002_inc.Text) ? txt_sce_002_inc.Text : !string.IsNullOrEmpty(txt_sce_001_inc.Text) ? txt_sce_001_inc.Text : txt_sce_ref_inc.Text;
        Standard.EPF_SCO = !string.IsNullOrEmpty(txt_sco_007_inc.Text) ? txt_sco_007_inc.Text : !string.IsNullOrEmpty(txt_sco_006_inc.Text) ? txt_sco_006_inc.Text : !string.IsNullOrEmpty(txt_sco_005_inc.Text) ? txt_sco_005_inc.Text : !string.IsNullOrEmpty(txt_sco_004_inc.Text) ? txt_sco_004_inc.Text : !string.IsNullOrEmpty(txt_sco_003_inc.Text) ? txt_sco_003_inc.Text : !string.IsNullOrEmpty(txt_sco_002_inc.Text) ? txt_sco_002_inc.Text : !string.IsNullOrEmpty(txt_sco_001_inc.Text) ? txt_sco_001_inc.Text : txt_sco_ref_inc.Text;
        Standard.EPF_SCH = !string.IsNullOrEmpty(txt_sch_007_inc.Text) ? txt_sch_007_inc.Text : !string.IsNullOrEmpty(txt_sch_006_inc.Text) ? txt_sch_006_inc.Text : !string.IsNullOrEmpty(txt_sch_005_inc.Text) ? txt_sch_005_inc.Text : !string.IsNullOrEmpty(txt_sch_004_inc.Text) ? txt_sch_004_inc.Text : !string.IsNullOrEmpty(txt_sch_003_inc.Text) ? txt_sch_003_inc.Text : !string.IsNullOrEmpty(txt_sch_002_inc.Text) ? txt_sch_002_inc.Text : !string.IsNullOrEmpty(txt_sch_001_inc.Text) ? txt_sch_001_inc.Text : txt_sch_ref_inc.Text;
        Standard.EPF_SCG = !string.IsNullOrEmpty(txt_scg_007_inc.Text) ? txt_scg_007_inc.Text : !string.IsNullOrEmpty(txt_scg_006_inc.Text) ? txt_scg_006_inc.Text : !string.IsNullOrEmpty(txt_scg_005_inc.Text) ? txt_scg_005_inc.Text : !string.IsNullOrEmpty(txt_scg_004_inc.Text) ? txt_scg_004_inc.Text : !string.IsNullOrEmpty(txt_scg_003_inc.Text) ? txt_scg_003_inc.Text : !string.IsNullOrEmpty(txt_scg_002_inc.Text) ? txt_scg_002_inc.Text : !string.IsNullOrEmpty(txt_scg_001_inc.Text) ? txt_scg_001_inc.Text : txt_scg_ref_inc.Text;
        Standard.EPF_SEE = !string.IsNullOrEmpty(txt_see_007_inc.Text) ? txt_see_007_inc.Text : !string.IsNullOrEmpty(txt_see_006_inc.Text) ? txt_see_006_inc.Text : !string.IsNullOrEmpty(txt_see_005_inc.Text) ? txt_see_005_inc.Text : !string.IsNullOrEmpty(txt_see_004_inc.Text) ? txt_see_004_inc.Text : !string.IsNullOrEmpty(txt_see_003_inc.Text) ? txt_see_003_inc.Text : !string.IsNullOrEmpty(txt_see_002_inc.Text) ? txt_see_002_inc.Text : !string.IsNullOrEmpty(txt_see_001_inc.Text) ? txt_see_001_inc.Text : txt_see_ref_inc.Text;
        Standard.EPF_SEO = !string.IsNullOrEmpty(txt_seo_007_inc.Text) ? txt_seo_007_inc.Text : !string.IsNullOrEmpty(txt_seo_006_inc.Text) ? txt_seo_006_inc.Text : !string.IsNullOrEmpty(txt_seo_005_inc.Text) ? txt_seo_005_inc.Text : !string.IsNullOrEmpty(txt_seo_004_inc.Text) ? txt_seo_004_inc.Text : !string.IsNullOrEmpty(txt_seo_003_inc.Text) ? txt_seo_003_inc.Text : !string.IsNullOrEmpty(txt_seo_002_inc.Text) ? txt_seo_002_inc.Text : !string.IsNullOrEmpty(txt_seo_001_inc.Text) ? txt_seo_001_inc.Text : txt_seo_ref_inc.Text;
        Standard.EPF_SEH = !string.IsNullOrEmpty(txt_seh_007_inc.Text) ? txt_seh_007_inc.Text : !string.IsNullOrEmpty(txt_seh_006_inc.Text) ? txt_seh_006_inc.Text : !string.IsNullOrEmpty(txt_seh_005_inc.Text) ? txt_seh_005_inc.Text : !string.IsNullOrEmpty(txt_seh_004_inc.Text) ? txt_seh_004_inc.Text : !string.IsNullOrEmpty(txt_seh_003_inc.Text) ? txt_seh_003_inc.Text : !string.IsNullOrEmpty(txt_seh_002_inc.Text) ? txt_seh_002_inc.Text : !string.IsNullOrEmpty(txt_seh_001_inc.Text) ? txt_seh_001_inc.Text : txt_seh_ref_inc.Text;
        Standard.EPF_SEG = !string.IsNullOrEmpty(txt_seg_007_inc.Text) ? txt_seg_007_inc.Text : !string.IsNullOrEmpty(txt_seg_006_inc.Text) ? txt_seg_006_inc.Text : !string.IsNullOrEmpty(txt_seg_005_inc.Text) ? txt_seg_005_inc.Text : !string.IsNullOrEmpty(txt_seg_004_inc.Text) ? txt_seg_004_inc.Text : !string.IsNullOrEmpty(txt_seg_003_inc.Text) ? txt_seg_003_inc.Text : !string.IsNullOrEmpty(txt_seg_002_inc.Text) ? txt_seg_002_inc.Text : !string.IsNullOrEmpty(txt_seg_001_inc.Text) ? txt_seg_001_inc.Text : txt_seg_ref_inc.Text;
        Standard.EPF_SJC = !string.IsNullOrEmpty(txt_sjc_007_inc.Text) ? txt_sjc_007_inc.Text : !string.IsNullOrEmpty(txt_sjc_006_inc.Text) ? txt_sjc_006_inc.Text : !string.IsNullOrEmpty(txt_sjc_005_inc.Text) ? txt_sjc_005_inc.Text : !string.IsNullOrEmpty(txt_sjc_004_inc.Text) ? txt_sjc_004_inc.Text : !string.IsNullOrEmpty(txt_sjc_003_inc.Text) ? txt_sjc_003_inc.Text : !string.IsNullOrEmpty(txt_sjc_002_inc.Text) ? txt_sjc_002_inc.Text : !string.IsNullOrEmpty(txt_sjc_001_inc.Text) ? txt_sjc_001_inc.Text : txt_sjc_ref_inc.Text;
        Standard.EPF_SJT = !string.IsNullOrEmpty(txt_sjt_007_inc.Text) ? txt_sjt_007_inc.Text : !string.IsNullOrEmpty(txt_sjt_006_inc.Text) ? txt_sjt_006_inc.Text : !string.IsNullOrEmpty(txt_sjt_005_inc.Text) ? txt_sjt_005_inc.Text : !string.IsNullOrEmpty(txt_sjt_004_inc.Text) ? txt_sjt_004_inc.Text : !string.IsNullOrEmpty(txt_sjt_003_inc.Text) ? txt_sjt_003_inc.Text : !string.IsNullOrEmpty(txt_sjt_002_inc.Text) ? txt_sjt_002_inc.Text : !string.IsNullOrEmpty(txt_sjt_001_inc.Text) ? txt_sjt_001_inc.Text : txt_sjt_ref_inc.Text;
        Standard.EPF_SJB = !string.IsNullOrEmpty(txt_sjb_007_inc.Text) ? txt_sjb_007_inc.Text : !string.IsNullOrEmpty(txt_sjb_006_inc.Text) ? txt_sjb_006_inc.Text : !string.IsNullOrEmpty(txt_sjb_005_inc.Text) ? txt_sjb_005_inc.Text : !string.IsNullOrEmpty(txt_sjb_004_inc.Text) ? txt_sjb_004_inc.Text : !string.IsNullOrEmpty(txt_sjb_003_inc.Text) ? txt_sjb_003_inc.Text : !string.IsNullOrEmpty(txt_sjb_002_inc.Text) ? txt_sjb_002_inc.Text : !string.IsNullOrEmpty(txt_sjb_001_inc.Text) ? txt_sjb_001_inc.Text : txt_sjb_ref_inc.Text;
        Standard.EPF_SPJ = !string.IsNullOrEmpty(txt_spj_007_inc.Text) ? txt_spj_007_inc.Text : !string.IsNullOrEmpty(txt_spj_006_inc.Text) ? txt_spj_006_inc.Text : !string.IsNullOrEmpty(txt_spj_005_inc.Text) ? txt_spj_005_inc.Text : !string.IsNullOrEmpty(txt_spj_004_inc.Text) ? txt_spj_004_inc.Text : !string.IsNullOrEmpty(txt_spj_003_inc.Text) ? txt_spj_003_inc.Text : !string.IsNullOrEmpty(txt_spj_002_inc.Text) ? txt_spj_002_inc.Text : !string.IsNullOrEmpty(txt_spj_001_inc.Text) ? txt_spj_001_inc.Text : txt_spj_ref_inc.Text;
        Standard.EPF_SBC = !string.IsNullOrEmpty(txt_sbc_007_inc.Text) ? txt_sbc_007_inc.Text : !string.IsNullOrEmpty(txt_sbc_006_inc.Text) ? txt_sbc_006_inc.Text : !string.IsNullOrEmpty(txt_sbc_005_inc.Text) ? txt_sbc_005_inc.Text : !string.IsNullOrEmpty(txt_sbc_004_inc.Text) ? txt_sbc_004_inc.Text : !string.IsNullOrEmpty(txt_sbc_003_inc.Text) ? txt_sbc_003_inc.Text : !string.IsNullOrEmpty(txt_sbc_002_inc.Text) ? txt_sbc_002_inc.Text : !string.IsNullOrEmpty(txt_sbc_001_inc.Text) ? txt_sbc_001_inc.Text : txt_sbc_ref_inc.Text;
        Standard.EPF_SPO = !string.IsNullOrEmpty(txt_spo_007_inc.Text) ? txt_spo_007_inc.Text : !string.IsNullOrEmpty(txt_spo_006_inc.Text) ? txt_spo_006_inc.Text : !string.IsNullOrEmpty(txt_spo_005_inc.Text) ? txt_spo_005_inc.Text : !string.IsNullOrEmpty(txt_spo_004_inc.Text) ? txt_spo_004_inc.Text : !string.IsNullOrEmpty(txt_spo_003_inc.Text) ? txt_spo_003_inc.Text : !string.IsNullOrEmpty(txt_spo_002_inc.Text) ? txt_spo_002_inc.Text : !string.IsNullOrEmpty(txt_spo_001_inc.Text) ? txt_spo_001_inc.Text : txt_spo_ref_inc.Text;
        Standard.EPF_SVA = !string.IsNullOrEmpty(txt_sva_007_inc.Text) ? txt_sva_007_inc.Text : !string.IsNullOrEmpty(txt_sva_006_inc.Text) ? txt_sva_006_inc.Text : !string.IsNullOrEmpty(txt_sva_005_inc.Text) ? txt_sva_005_inc.Text : !string.IsNullOrEmpty(txt_sva_004_inc.Text) ? txt_sva_004_inc.Text : !string.IsNullOrEmpty(txt_sva_003_inc.Text) ? txt_sva_003_inc.Text : !string.IsNullOrEmpty(txt_sva_002_inc.Text) ? txt_sva_002_inc.Text : !string.IsNullOrEmpty(txt_sva_001_inc.Text) ? txt_sva_001_inc.Text : txt_sva_ref_inc.Text;
        Standard.EPF_TGR = !string.IsNullOrEmpty(txt_tgr_007_inc.Text) ? txt_tgr_007_inc.Text : !string.IsNullOrEmpty(txt_tgr_006_inc.Text) ? txt_tgr_006_inc.Text : !string.IsNullOrEmpty(txt_tgr_005_inc.Text) ? txt_tgr_005_inc.Text : !string.IsNullOrEmpty(txt_tgr_004_inc.Text) ? txt_tgr_004_inc.Text : !string.IsNullOrEmpty(txt_tgr_003_inc.Text) ? txt_tgr_003_inc.Text : !string.IsNullOrEmpty(txt_tgr_002_inc.Text) ? txt_tgr_002_inc.Text : !string.IsNullOrEmpty(txt_tgr_001_inc.Text) ? txt_tgr_001_inc.Text : txt_tgr_ref_inc.Text;
        Standard.EPF_TIP = !string.IsNullOrEmpty(txt_tip_007_inc.Text) ? txt_tip_007_inc.Text : !string.IsNullOrEmpty(txt_tip_006_inc.Text) ? txt_tip_006_inc.Text : !string.IsNullOrEmpty(txt_tip_005_inc.Text) ? txt_tip_005_inc.Text : !string.IsNullOrEmpty(txt_tip_004_inc.Text) ? txt_tip_004_inc.Text : !string.IsNullOrEmpty(txt_tip_003_inc.Text) ? txt_tip_003_inc.Text : !string.IsNullOrEmpty(txt_tip_002_inc.Text) ? txt_tip_002_inc.Text : !string.IsNullOrEmpty(txt_tip_001_inc.Text) ? txt_tip_001_inc.Text : txt_tip_ref_inc.Text;
        Standard.EPF_DSB = !string.IsNullOrEmpty(txt_dsb_007_inc.Text) ? txt_dsb_007_inc.Text : !string.IsNullOrEmpty(txt_dsb_006_inc.Text) ? txt_dsb_006_inc.Text : !string.IsNullOrEmpty(txt_dsb_005_inc.Text) ? txt_dsb_005_inc.Text : !string.IsNullOrEmpty(txt_dsb_004_inc.Text) ? txt_dsb_004_inc.Text : !string.IsNullOrEmpty(txt_dsb_003_inc.Text) ? txt_dsb_003_inc.Text : !string.IsNullOrEmpty(txt_dsb_002_inc.Text) ? txt_dsb_002_inc.Text : !string.IsNullOrEmpty(txt_dsb_001_inc.Text) ? txt_dsb_001_inc.Text : txt_dsb_ref_inc.Text;
        Standard.EPF_TCA = !string.IsNullOrEmpty(txt_tca_007_inc.Text) ? txt_tca_007_inc.Text : !string.IsNullOrEmpty(txt_tca_006_inc.Text) ? txt_tca_006_inc.Text : !string.IsNullOrEmpty(txt_tca_005_inc.Text) ? txt_tca_005_inc.Text : !string.IsNullOrEmpty(txt_tca_004_inc.Text) ? txt_tca_004_inc.Text : !string.IsNullOrEmpty(txt_tca_003_inc.Text) ? txt_tca_003_inc.Text : !string.IsNullOrEmpty(txt_tca_002_inc.Text) ? txt_tca_002_inc.Text : !string.IsNullOrEmpty(txt_tca_001_inc.Text) ? txt_tca_001_inc.Text : txt_tca_ref_inc.Text;
        Standard.EPF_FMC = !string.IsNullOrEmpty(txt_fmc_007_inc.Text) ? txt_fmc_007_inc.Text : !string.IsNullOrEmpty(txt_fmc_006_inc.Text) ? txt_fmc_006_inc.Text : !string.IsNullOrEmpty(txt_fmc_005_inc.Text) ? txt_fmc_005_inc.Text : !string.IsNullOrEmpty(txt_fmc_004_inc.Text) ? txt_fmc_004_inc.Text : !string.IsNullOrEmpty(txt_fmc_003_inc.Text) ? txt_fmc_003_inc.Text : !string.IsNullOrEmpty(txt_fmc_002_inc.Text) ? txt_fmc_002_inc.Text : !string.IsNullOrEmpty(txt_fmc_001_inc.Text) ? txt_fmc_001_inc.Text : txt_fmc_ref_inc.Text;
        Standard.EPF_1TB = !string.IsNullOrEmpty(txt_1tb_007_inc.Text) ? txt_1tb_007_inc.Text : !string.IsNullOrEmpty(txt_1tb_006_inc.Text) ? txt_1tb_006_inc.Text : !string.IsNullOrEmpty(txt_1tb_005_inc.Text) ? txt_1tb_005_inc.Text : !string.IsNullOrEmpty(txt_1tb_004_inc.Text) ? txt_1tb_004_inc.Text : !string.IsNullOrEmpty(txt_1tb_003_inc.Text) ? txt_1tb_003_inc.Text : !string.IsNullOrEmpty(txt_1tb_002_inc.Text) ? txt_1tb_002_inc.Text : !string.IsNullOrEmpty(txt_1tb_001_inc.Text) ? txt_1tb_001_inc.Text : txt_1tb_ref_inc.Text;
        Standard.EPF_1PP = !string.IsNullOrEmpty(txt_1pp_007_inc.Text) ? txt_1pp_007_inc.Text : !string.IsNullOrEmpty(txt_1pp_006_inc.Text) ? txt_1pp_006_inc.Text : !string.IsNullOrEmpty(txt_1pp_005_inc.Text) ? txt_1pp_005_inc.Text : !string.IsNullOrEmpty(txt_1pp_004_inc.Text) ? txt_1pp_004_inc.Text : !string.IsNullOrEmpty(txt_1pp_003_inc.Text) ? txt_1pp_003_inc.Text : !string.IsNullOrEmpty(txt_1pp_002_inc.Text) ? txt_1pp_002_inc.Text : !string.IsNullOrEmpty(txt_1pp_001_inc.Text) ? txt_1pp_001_inc.Text : txt_1pp_ref_inc.Text;
        Standard.EPF_2TB = !string.IsNullOrEmpty(txt_2tb_007_inc.Text) ? txt_2tb_007_inc.Text : !string.IsNullOrEmpty(txt_2tb_006_inc.Text) ? txt_2tb_006_inc.Text : !string.IsNullOrEmpty(txt_2tb_005_inc.Text) ? txt_2tb_005_inc.Text : !string.IsNullOrEmpty(txt_2tb_004_inc.Text) ? txt_2tb_004_inc.Text : !string.IsNullOrEmpty(txt_2tb_003_inc.Text) ? txt_2tb_003_inc.Text : !string.IsNullOrEmpty(txt_2tb_002_inc.Text) ? txt_2tb_002_inc.Text : !string.IsNullOrEmpty(txt_2tb_001_inc.Text) ? txt_2tb_001_inc.Text : txt_2tb_ref_inc.Text;
        Standard.EPF_2PP = !string.IsNullOrEmpty(txt_2pp_007_inc.Text) ? txt_2pp_007_inc.Text : !string.IsNullOrEmpty(txt_2pp_006_inc.Text) ? txt_2pp_006_inc.Text : !string.IsNullOrEmpty(txt_2pp_005_inc.Text) ? txt_2pp_005_inc.Text : !string.IsNullOrEmpty(txt_2pp_004_inc.Text) ? txt_2pp_004_inc.Text : !string.IsNullOrEmpty(txt_2pp_003_inc.Text) ? txt_2pp_003_inc.Text : !string.IsNullOrEmpty(txt_2pp_002_inc.Text) ? txt_2pp_002_inc.Text : !string.IsNullOrEmpty(txt_2pp_001_inc.Text) ? txt_2pp_001_inc.Text : txt_2pp_ref_inc.Text;
        string sCSO = !string.IsNullOrEmpty(txt_cso_007_inc.Text) ? txt_cso_007_inc.Text : !string.IsNullOrEmpty(txt_cso_006_inc.Text) ? txt_cso_006_inc.Text : !string.IsNullOrEmpty(txt_cso_005_inc.Text) ? txt_cso_005_inc.Text : !string.IsNullOrEmpty(txt_cso_004_inc.Text) ? txt_cso_004_inc.Text : !string.IsNullOrEmpty(txt_cso_003_inc.Text) ? txt_cso_003_inc.Text : !string.IsNullOrEmpty(txt_cso_002_inc.Text) ? txt_cso_002_inc.Text : !string.IsNullOrEmpty(txt_cso_001_inc.Text) ? txt_cso_001_inc.Text : txt_cso_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCSO))
        {
            Standard.EPF_CSO = Convert.ToDouble(sCSO);
        }
        string sESP = !string.IsNullOrEmpty(txt_esp_007_inc.Text) ? txt_esp_007_inc.Text : !string.IsNullOrEmpty(txt_esp_006_inc.Text) ? txt_esp_006_inc.Text : !string.IsNullOrEmpty(txt_esp_005_inc.Text) ? txt_esp_005_inc.Text : !string.IsNullOrEmpty(txt_esp_004_inc.Text) ? txt_esp_004_inc.Text : !string.IsNullOrEmpty(txt_esp_003_inc.Text) ? txt_esp_003_inc.Text : !string.IsNullOrEmpty(txt_esp_002_inc.Text) ? txt_esp_002_inc.Text : !string.IsNullOrEmpty(txt_esp_001_inc.Text) ? txt_esp_001_inc.Text : txt_esp_ref_inc.Text;
        if (!string.IsNullOrEmpty(sESP))
        {
            Standard.EPF_ESP = Convert.ToDouble(sESP);
        }
        Standard.EPF_TOL = !string.IsNullOrEmpty(txt_tol_007_inc.Text) ? txt_tol_007_inc.Text : !string.IsNullOrEmpty(txt_tol_006_inc.Text) ? txt_tol_006_inc.Text : !string.IsNullOrEmpty(txt_tol_005_inc.Text) ? txt_tol_005_inc.Text : !string.IsNullOrEmpty(txt_tol_004_inc.Text) ? txt_tol_004_inc.Text : !string.IsNullOrEmpty(txt_tol_003_inc.Text) ? txt_tol_003_inc.Text : !string.IsNullOrEmpty(txt_tol_002_inc.Text) ? txt_tol_002_inc.Text : !string.IsNullOrEmpty(txt_tol_001_inc.Text) ? txt_tol_001_inc.Text : txt_tol_ref_inc.Text;
        Standard.EPF_P1C = !string.IsNullOrEmpty(txt_p1c_007_inc.Text) ? txt_p1c_007_inc.Text : !string.IsNullOrEmpty(txt_p1c_006_inc.Text) ? txt_p1c_006_inc.Text : !string.IsNullOrEmpty(txt_p1c_005_inc.Text) ? txt_p1c_005_inc.Text : !string.IsNullOrEmpty(txt_p1c_004_inc.Text) ? txt_p1c_004_inc.Text : !string.IsNullOrEmpty(txt_p1c_003_inc.Text) ? txt_p1c_003_inc.Text : !string.IsNullOrEmpty(txt_p1c_002_inc.Text) ? txt_p1c_002_inc.Text : !string.IsNullOrEmpty(txt_p1c_001_inc.Text) ? txt_p1c_001_inc.Text : txt_p1c_ref_inc.Text;
        Standard.EPF_P2D = !string.IsNullOrEmpty(txt_p2d_007_inc.Text) ? txt_p2d_007_inc.Text : !string.IsNullOrEmpty(txt_p2d_006_inc.Text) ? txt_p2d_006_inc.Text : !string.IsNullOrEmpty(txt_p2d_005_inc.Text) ? txt_p2d_005_inc.Text : !string.IsNullOrEmpty(txt_p2d_004_inc.Text) ? txt_p2d_004_inc.Text : !string.IsNullOrEmpty(txt_p2d_003_inc.Text) ? txt_p2d_003_inc.Text : !string.IsNullOrEmpty(txt_p2d_002_inc.Text) ? txt_p2d_002_inc.Text : !string.IsNullOrEmpty(txt_p2d_001_inc.Text) ? txt_p2d_001_inc.Text : txt_p2d_ref_inc.Text;
        Standard.EPF_P3D = !string.IsNullOrEmpty(txt_p3d_007_inc.Text) ? txt_p3d_007_inc.Text : !string.IsNullOrEmpty(txt_p3d_006_inc.Text) ? txt_p3d_006_inc.Text : !string.IsNullOrEmpty(txt_p3d_005_inc.Text) ? txt_p3d_005_inc.Text : !string.IsNullOrEmpty(txt_p3d_004_inc.Text) ? txt_p3d_004_inc.Text : !string.IsNullOrEmpty(txt_p3d_003_inc.Text) ? txt_p3d_003_inc.Text : !string.IsNullOrEmpty(txt_p3d_002_inc.Text) ? txt_p3d_002_inc.Text : !string.IsNullOrEmpty(txt_p3d_001_inc.Text) ? txt_p3d_001_inc.Text : txt_p3d_ref_inc.Text;
        Standard.EPF_P4U = !string.IsNullOrEmpty(txt_p4u_007_inc.Text) ? txt_p4u_007_inc.Text : !string.IsNullOrEmpty(txt_p4u_006_inc.Text) ? txt_p4u_006_inc.Text : !string.IsNullOrEmpty(txt_p4u_005_inc.Text) ? txt_p4u_005_inc.Text : !string.IsNullOrEmpty(txt_p4u_004_inc.Text) ? txt_p4u_004_inc.Text : !string.IsNullOrEmpty(txt_p4u_003_inc.Text) ? txt_p4u_003_inc.Text : !string.IsNullOrEmpty(txt_p4u_002_inc.Text) ? txt_p4u_002_inc.Text : !string.IsNullOrEmpty(txt_p4u_001_inc.Text) ? txt_p4u_001_inc.Text : txt_p4u_ref_inc.Text;
        Standard.EPF_MOL = !string.IsNullOrEmpty(txt_mol_007_inc.Text) ? txt_mol_007_inc.Text : !string.IsNullOrEmpty(txt_mol_006_inc.Text) ? txt_mol_006_inc.Text : !string.IsNullOrEmpty(txt_mol_005_inc.Text) ? txt_mol_005_inc.Text : !string.IsNullOrEmpty(txt_mol_004_inc.Text) ? txt_mol_004_inc.Text : !string.IsNullOrEmpty(txt_mol_003_inc.Text) ? txt_mol_003_inc.Text : !string.IsNullOrEmpty(txt_mol_002_inc.Text) ? txt_mol_002_inc.Text : !string.IsNullOrEmpty(txt_mol_001_inc.Text) ? txt_mol_001_inc.Text : txt_mol_ref_inc.Text;
        Standard.EPF_TPD = !string.IsNullOrEmpty(txt_tpd_007_inc.Text) ? txt_tpd_007_inc.Text : !string.IsNullOrEmpty(txt_tpd_006_inc.Text) ? txt_tpd_006_inc.Text : !string.IsNullOrEmpty(txt_tpd_005_inc.Text) ? txt_tpd_005_inc.Text : !string.IsNullOrEmpty(txt_tpd_004_inc.Text) ? txt_tpd_004_inc.Text : !string.IsNullOrEmpty(txt_tpd_003_inc.Text) ? txt_tpd_003_inc.Text : !string.IsNullOrEmpty(txt_tpd_002_inc.Text) ? txt_tpd_002_inc.Text : !string.IsNullOrEmpty(txt_tpd_001_inc.Text) ? txt_tpd_001_inc.Text : txt_tpd_ref_inc.Text;
        Standard.EPF_TT1 = !string.IsNullOrEmpty(txt_tt1_007_inc.Text) ? txt_tt1_007_inc.Text : !string.IsNullOrEmpty(txt_tt1_006_inc.Text) ? txt_tt1_006_inc.Text : !string.IsNullOrEmpty(txt_tt1_005_inc.Text) ? txt_tt1_005_inc.Text : !string.IsNullOrEmpty(txt_tt1_004_inc.Text) ? txt_tt1_004_inc.Text : !string.IsNullOrEmpty(txt_tt1_003_inc.Text) ? txt_tt1_003_inc.Text : !string.IsNullOrEmpty(txt_tt1_002_inc.Text) ? txt_tt1_002_inc.Text : !string.IsNullOrEmpty(txt_tt1_001_inc.Text) ? txt_tt1_001_inc.Text : txt_tt1_ref_inc.Text;
        Standard.EPF_TT2 = !string.IsNullOrEmpty(txt_tt2_007_inc.Text) ? txt_tt2_007_inc.Text : !string.IsNullOrEmpty(txt_tt2_006_inc.Text) ? txt_tt2_006_inc.Text : !string.IsNullOrEmpty(txt_tt2_005_inc.Text) ? txt_tt2_005_inc.Text : !string.IsNullOrEmpty(txt_tt2_004_inc.Text) ? txt_tt2_004_inc.Text : !string.IsNullOrEmpty(txt_tt2_003_inc.Text) ? txt_tt2_003_inc.Text : !string.IsNullOrEmpty(txt_tt2_002_inc.Text) ? txt_tt2_002_inc.Text : !string.IsNullOrEmpty(txt_tt2_001_inc.Text) ? txt_tt2_001_inc.Text : txt_tt2_ref_inc.Text;
        Standard.EPF_TT3 = !string.IsNullOrEmpty(txt_tt3_007_inc.Text) ? txt_tt3_007_inc.Text : !string.IsNullOrEmpty(txt_tt3_006_inc.Text) ? txt_tt3_006_inc.Text : !string.IsNullOrEmpty(txt_tt3_005_inc.Text) ? txt_tt3_005_inc.Text : !string.IsNullOrEmpty(txt_tt3_004_inc.Text) ? txt_tt3_004_inc.Text : !string.IsNullOrEmpty(txt_tt3_003_inc.Text) ? txt_tt3_003_inc.Text : !string.IsNullOrEmpty(txt_tt3_002_inc.Text) ? txt_tt3_002_inc.Text : !string.IsNullOrEmpty(txt_tt3_001_inc.Text) ? txt_tt3_001_inc.Text : txt_tt3_ref_inc.Text;
        Standard.EPF_T21 = !string.IsNullOrEmpty(txt_t21_007_inc.Text) ? txt_t21_007_inc.Text : !string.IsNullOrEmpty(txt_t21_006_inc.Text) ? txt_t21_006_inc.Text : !string.IsNullOrEmpty(txt_t21_005_inc.Text) ? txt_t21_005_inc.Text : !string.IsNullOrEmpty(txt_t21_004_inc.Text) ? txt_t21_004_inc.Text : !string.IsNullOrEmpty(txt_t21_003_inc.Text) ? txt_t21_003_inc.Text : !string.IsNullOrEmpty(txt_t21_002_inc.Text) ? txt_t21_002_inc.Text : !string.IsNullOrEmpty(txt_t21_001_inc.Text) ? txt_t21_001_inc.Text : txt_t21_ref_inc.Text;
        Standard.EPF_TUN = !string.IsNullOrEmpty(txt_tun_007_inc.Text) ? txt_tun_007_inc.Text : !string.IsNullOrEmpty(txt_tun_006_inc.Text) ? txt_tun_006_inc.Text : !string.IsNullOrEmpty(txt_tun_005_inc.Text) ? txt_tun_005_inc.Text : !string.IsNullOrEmpty(txt_tun_004_inc.Text) ? txt_tun_004_inc.Text : !string.IsNullOrEmpty(txt_tun_003_inc.Text) ? txt_tun_003_inc.Text : !string.IsNullOrEmpty(txt_tun_002_inc.Text) ? txt_tun_002_inc.Text : !string.IsNullOrEmpty(txt_tun_001_inc.Text) ? txt_tun_001_inc.Text : txt_tun_ref_inc.Text;
        Standard.EPF_TCV = !string.IsNullOrEmpty(txt_tcv_007_inc.Text) ? txt_tcv_007_inc.Text : !string.IsNullOrEmpty(txt_tcv_006_inc.Text) ? txt_tcv_006_inc.Text : !string.IsNullOrEmpty(txt_tcv_005_inc.Text) ? txt_tcv_005_inc.Text : !string.IsNullOrEmpty(txt_tcv_004_inc.Text) ? txt_tcv_004_inc.Text : !string.IsNullOrEmpty(txt_tcv_003_inc.Text) ? txt_tcv_003_inc.Text : !string.IsNullOrEmpty(txt_tcv_002_inc.Text) ? txt_tcv_002_inc.Text : !string.IsNullOrEmpty(txt_tcv_001_inc.Text) ? txt_tcv_001_inc.Text : txt_tcv_ref_inc.Text;
        Standard.EPF_TSS = !string.IsNullOrEmpty(txt_tss_007_inc.Text) ? txt_tss_007_inc.Text : !string.IsNullOrEmpty(txt_tss_006_inc.Text) ? txt_tss_006_inc.Text : !string.IsNullOrEmpty(txt_tss_005_inc.Text) ? txt_tss_005_inc.Text : !string.IsNullOrEmpty(txt_tss_004_inc.Text) ? txt_tss_004_inc.Text : !string.IsNullOrEmpty(txt_tss_003_inc.Text) ? txt_tss_003_inc.Text : !string.IsNullOrEmpty(txt_tss_002_inc.Text) ? txt_tss_002_inc.Text : !string.IsNullOrEmpty(txt_tss_001_inc.Text) ? txt_tss_001_inc.Text : txt_tss_ref_inc.Text;
        string sTIT = !string.IsNullOrEmpty(txt_tit_007_inc.Text) ? txt_tit_007_inc.Text : !string.IsNullOrEmpty(txt_tit_006_inc.Text) ? txt_tit_006_inc.Text : !string.IsNullOrEmpty(txt_tit_005_inc.Text) ? txt_tit_005_inc.Text : !string.IsNullOrEmpty(txt_tit_004_inc.Text) ? txt_tit_004_inc.Text : !string.IsNullOrEmpty(txt_tit_003_inc.Text) ? txt_tit_003_inc.Text : !string.IsNullOrEmpty(txt_tit_002_inc.Text) ? txt_tit_002_inc.Text : !string.IsNullOrEmpty(txt_tit_001_inc.Text) ? txt_tit_001_inc.Text : txt_tit_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTIT))
        {
            Standard.EPF_TIT = Convert.ToDouble(sTIT);
        }
        string sTNC = !string.IsNullOrEmpty(txt_tnc_007_inc.Text) ? txt_tnc_007_inc.Text : !string.IsNullOrEmpty(txt_tnc_006_inc.Text) ? txt_tnc_006_inc.Text : !string.IsNullOrEmpty(txt_tnc_005_inc.Text) ? txt_tnc_005_inc.Text : !string.IsNullOrEmpty(txt_tnc_004_inc.Text) ? txt_tnc_004_inc.Text : !string.IsNullOrEmpty(txt_tnc_003_inc.Text) ? txt_tnc_003_inc.Text : !string.IsNullOrEmpty(txt_tnc_002_inc.Text) ? txt_tnc_002_inc.Text : !string.IsNullOrEmpty(txt_tnc_001_inc.Text) ? txt_tnc_001_inc.Text : txt_tnc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTNC))
        {
            Standard.EPF_TNC = Convert.ToDouble(sTNC);
        }
        string sAON = !string.IsNullOrEmpty(txt_aon_007_inc.Text) ? txt_aon_007_inc.Text : !string.IsNullOrEmpty(txt_aon_006_inc.Text) ? txt_aon_006_inc.Text : !string.IsNullOrEmpty(txt_aon_005_inc.Text) ? txt_aon_005_inc.Text : !string.IsNullOrEmpty(txt_aon_004_inc.Text) ? txt_aon_004_inc.Text : !string.IsNullOrEmpty(txt_aon_003_inc.Text) ? txt_aon_003_inc.Text : !string.IsNullOrEmpty(txt_aon_002_inc.Text) ? txt_aon_002_inc.Text : !string.IsNullOrEmpty(txt_aon_001_inc.Text) ? txt_aon_001_inc.Text : txt_aon_ref_inc.Text;
        if (!string.IsNullOrEmpty(sAON))
        {
            Standard.EPF_AON = Convert.ToDouble(sAON);
        }
        string sENM = !string.IsNullOrEmpty(txt_enm_007_inc.Text) ? txt_enm_007_inc.Text : !string.IsNullOrEmpty(txt_enm_006_inc.Text) ? txt_enm_006_inc.Text : !string.IsNullOrEmpty(txt_enm_005_inc.Text) ? txt_enm_005_inc.Text : !string.IsNullOrEmpty(txt_enm_004_inc.Text) ? txt_enm_004_inc.Text : !string.IsNullOrEmpty(txt_enm_003_inc.Text) ? txt_enm_003_inc.Text : !string.IsNullOrEmpty(txt_enm_002_inc.Text) ? txt_enm_002_inc.Text : !string.IsNullOrEmpty(txt_enm_001_inc.Text) ? txt_enm_001_inc.Text : txt_enm_ref_inc.Text;
        if (!string.IsNullOrEmpty(sENM))
        {
            Standard.EPF_ENM = Convert.ToDouble(sENM);
        }
        string sEEE = !string.IsNullOrEmpty(txt_eee_007_inc.Text) ? txt_eee_007_inc.Text : !string.IsNullOrEmpty(txt_eee_006_inc.Text) ? txt_eee_006_inc.Text : !string.IsNullOrEmpty(txt_eee_005_inc.Text) ? txt_eee_005_inc.Text : !string.IsNullOrEmpty(txt_eee_004_inc.Text) ? txt_eee_004_inc.Text : !string.IsNullOrEmpty(txt_eee_003_inc.Text) ? txt_eee_003_inc.Text : !string.IsNullOrEmpty(txt_eee_002_inc.Text) ? txt_eee_002_inc.Text : !string.IsNullOrEmpty(txt_eee_001_inc.Text) ? txt_eee_001_inc.Text : txt_eee_ref_inc.Text;
        if (!string.IsNullOrEmpty(sEEE))
        {
            Standard.EPF_EEE = Convert.ToDouble(sEEE);
        }
        string sKKK = !string.IsNullOrEmpty(txt_kkk_007_inc.Text) ? txt_kkk_007_inc.Text : !string.IsNullOrEmpty(txt_kkk_006_inc.Text) ? txt_kkk_006_inc.Text : !string.IsNullOrEmpty(txt_kkk_005_inc.Text) ? txt_kkk_005_inc.Text : !string.IsNullOrEmpty(txt_kkk_004_inc.Text) ? txt_kkk_004_inc.Text : !string.IsNullOrEmpty(txt_kkk_003_inc.Text) ? txt_kkk_003_inc.Text : !string.IsNullOrEmpty(txt_kkk_002_inc.Text) ? txt_kkk_002_inc.Text : !string.IsNullOrEmpty(txt_kkk_001_inc.Text) ? txt_kkk_001_inc.Text : txt_kkk_ref_inc.Text;
        if (!string.IsNullOrEmpty(sKKK))
        {
            Standard.EPF_KKK = Convert.ToDouble(sKKK);
        }
        string sBBB = !string.IsNullOrEmpty(txt_bbb_007_inc.Text) ? txt_bbb_007_inc.Text : !string.IsNullOrEmpty(txt_bbb_006_inc.Text) ? txt_bbb_006_inc.Text : !string.IsNullOrEmpty(txt_bbb_005_inc.Text) ? txt_bbb_005_inc.Text : !string.IsNullOrEmpty(txt_bbb_004_inc.Text) ? txt_bbb_004_inc.Text : !string.IsNullOrEmpty(txt_bbb_003_inc.Text) ? txt_bbb_003_inc.Text : !string.IsNullOrEmpty(txt_bbb_002_inc.Text) ? txt_bbb_002_inc.Text : !string.IsNullOrEmpty(txt_bbb_001_inc.Text) ? txt_bbb_001_inc.Text : txt_bbb_ref_inc.Text;
        if (!string.IsNullOrEmpty(sBBB))
        {
            Standard.EPF_BBB = Convert.ToDouble(sBBB);
        }
        string sOLE = !string.IsNullOrEmpty(txt_ole_007_inc.Text) ? txt_ole_007_inc.Text : !string.IsNullOrEmpty(txt_ole_006_inc.Text) ? txt_ole_006_inc.Text : !string.IsNullOrEmpty(txt_ole_005_inc.Text) ? txt_ole_005_inc.Text : !string.IsNullOrEmpty(txt_ole_004_inc.Text) ? txt_ole_004_inc.Text : !string.IsNullOrEmpty(txt_ole_003_inc.Text) ? txt_ole_003_inc.Text : !string.IsNullOrEmpty(txt_ole_002_inc.Text) ? txt_ole_002_inc.Text : !string.IsNullOrEmpty(txt_ole_001_inc.Text) ? txt_ole_001_inc.Text : txt_ole_ref_inc.Text;
        if (!string.IsNullOrEmpty(sOLE))
        {
            Standard.EPF_OLE = Convert.ToDouble(sOLE);
        }
        string sTRQ = !string.IsNullOrEmpty(txt_trq_007_inc.Text) ? txt_trq_007_inc.Text : !string.IsNullOrEmpty(txt_trq_006_inc.Text) ? txt_trq_006_inc.Text : !string.IsNullOrEmpty(txt_trq_005_inc.Text) ? txt_trq_005_inc.Text : !string.IsNullOrEmpty(txt_trq_004_inc.Text) ? txt_trq_004_inc.Text : !string.IsNullOrEmpty(txt_trq_003_inc.Text) ? txt_trq_003_inc.Text : !string.IsNullOrEmpty(txt_trq_002_inc.Text) ? txt_trq_002_inc.Text : !string.IsNullOrEmpty(txt_trq_001_inc.Text) ? txt_trq_001_inc.Text : txt_trq_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTRQ))
        {
            Standard.EPF_TRQ = Convert.ToDouble(sTRQ);
        }
        string sERT = !string.IsNullOrEmpty(txt_ert_007_inc.Text) ? txt_ert_007_inc.Text : !string.IsNullOrEmpty(txt_ert_006_inc.Text) ? txt_ert_006_inc.Text : !string.IsNullOrEmpty(txt_ert_005_inc.Text) ? txt_ert_005_inc.Text : !string.IsNullOrEmpty(txt_ert_004_inc.Text) ? txt_ert_004_inc.Text : !string.IsNullOrEmpty(txt_ert_003_inc.Text) ? txt_ert_003_inc.Text : !string.IsNullOrEmpty(txt_ert_002_inc.Text) ? txt_ert_002_inc.Text : !string.IsNullOrEmpty(txt_ert_001_inc.Text) ? txt_ert_001_inc.Text : txt_ert_ref_inc.Text;
        if (!string.IsNullOrEmpty(sERT))
        {
            Standard.EPF_ERT = Convert.ToDouble(sERT);
        }
        string sRT3 = !string.IsNullOrEmpty(txt_rt3_007_inc.Text) ? txt_rt3_007_inc.Text : !string.IsNullOrEmpty(txt_rt3_006_inc.Text) ? txt_rt3_006_inc.Text : !string.IsNullOrEmpty(txt_rt3_005_inc.Text) ? txt_rt3_005_inc.Text : !string.IsNullOrEmpty(txt_rt3_004_inc.Text) ? txt_rt3_004_inc.Text : !string.IsNullOrEmpty(txt_rt3_003_inc.Text) ? txt_rt3_003_inc.Text : !string.IsNullOrEmpty(txt_rt3_002_inc.Text) ? txt_rt3_002_inc.Text : !string.IsNullOrEmpty(txt_rt3_001_inc.Text) ? txt_rt3_001_inc.Text : txt_rt3_ref_inc.Text;
        if (!string.IsNullOrEmpty(sRT3))
        {
            Standard.EPF_RT3 = Convert.ToDouble(sRT3);
        }
        string sRT5 = !string.IsNullOrEmpty(txt_rt5_007_inc.Text) ? txt_rt5_007_inc.Text : !string.IsNullOrEmpty(txt_rt5_006_inc.Text) ? txt_rt5_006_inc.Text : !string.IsNullOrEmpty(txt_rt5_005_inc.Text) ? txt_rt5_005_inc.Text : !string.IsNullOrEmpty(txt_rt5_004_inc.Text) ? txt_rt5_004_inc.Text : !string.IsNullOrEmpty(txt_rt5_003_inc.Text) ? txt_rt5_003_inc.Text : !string.IsNullOrEmpty(txt_rt5_002_inc.Text) ? txt_rt5_002_inc.Text : !string.IsNullOrEmpty(txt_rt5_001_inc.Text) ? txt_rt5_001_inc.Text : txt_rt5_ref_inc.Text;
        if (!string.IsNullOrEmpty(sRT5))
        {
            Standard.EPF_RT5 = Convert.ToDouble(sRT5);
        }
        string sDND = !string.IsNullOrEmpty(txt_dnd_007_inc.Text) ? txt_dnd_007_inc.Text : !string.IsNullOrEmpty(txt_dnd_006_inc.Text) ? txt_dnd_006_inc.Text : !string.IsNullOrEmpty(txt_dnd_005_inc.Text) ? txt_dnd_005_inc.Text : !string.IsNullOrEmpty(txt_dnd_004_inc.Text) ? txt_dnd_004_inc.Text : !string.IsNullOrEmpty(txt_dnd_003_inc.Text) ? txt_dnd_003_inc.Text : !string.IsNullOrEmpty(txt_dnd_002_inc.Text) ? txt_dnd_002_inc.Text : !string.IsNullOrEmpty(txt_dnd_001_inc.Text) ? txt_dnd_001_inc.Text : txt_dnd_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDND))
        {
            Standard.EPF_DND = Convert.ToDouble(sDND);
        }
        string sDMO = !string.IsNullOrEmpty(txt_dmo_007_inc.Text) ? txt_dmo_007_inc.Text : !string.IsNullOrEmpty(txt_dmo_006_inc.Text) ? txt_dmo_006_inc.Text : !string.IsNullOrEmpty(txt_dmo_005_inc.Text) ? txt_dmo_005_inc.Text : !string.IsNullOrEmpty(txt_dmo_004_inc.Text) ? txt_dmo_004_inc.Text : !string.IsNullOrEmpty(txt_dmo_003_inc.Text) ? txt_dmo_003_inc.Text : !string.IsNullOrEmpty(txt_dmo_002_inc.Text) ? txt_dmo_002_inc.Text : !string.IsNullOrEmpty(txt_dmo_001_inc.Text) ? txt_dmo_001_inc.Text : txt_dmo_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDMO))
        {
            Standard.EPF_DMO = Convert.ToDouble(sDMO);
        }
        string sPES = !string.IsNullOrEmpty(txt_pes_007_inc.Text) ? txt_pes_007_inc.Text : !string.IsNullOrEmpty(txt_pes_006_inc.Text) ? txt_pes_006_inc.Text : !string.IsNullOrEmpty(txt_pes_005_inc.Text) ? txt_pes_005_inc.Text : !string.IsNullOrEmpty(txt_pes_004_inc.Text) ? txt_pes_004_inc.Text : !string.IsNullOrEmpty(txt_pes_003_inc.Text) ? txt_pes_003_inc.Text : !string.IsNullOrEmpty(txt_pes_002_inc.Text) ? txt_pes_002_inc.Text : !string.IsNullOrEmpty(txt_pes_001_inc.Text) ? txt_pes_001_inc.Text : txt_pes_ref_inc.Text;
        if (!string.IsNullOrEmpty(sPES))
        {
            Standard.EPF_PES = Convert.ToDouble(sPES);
        }
        Standard.EPF_VRR = !string.IsNullOrEmpty(txt_vrr_007_inc.Text) ? txt_vrr_007_inc.Text : !string.IsNullOrEmpty(txt_vrr_006_inc.Text) ? txt_vrr_006_inc.Text : !string.IsNullOrEmpty(txt_vrr_005_inc.Text) ? txt_vrr_005_inc.Text : !string.IsNullOrEmpty(txt_vrr_004_inc.Text) ? txt_vrr_004_inc.Text : !string.IsNullOrEmpty(txt_vrr_003_inc.Text) ? txt_vrr_003_inc.Text : !string.IsNullOrEmpty(txt_vrr_002_inc.Text) ? txt_vrr_002_inc.Text : !string.IsNullOrEmpty(txt_vrr_001_inc.Text) ? txt_vrr_001_inc.Text : txt_vrr_ref_inc.Text;

        Standard.EPF_TRE = !string.IsNullOrEmpty(txt_tre_007_inc.Text) ? txt_tre_007_inc.Text : !string.IsNullOrEmpty(txt_tre_006_inc.Text) ? txt_tre_006_inc.Text : !string.IsNullOrEmpty(txt_tre_005_inc.Text) ? txt_tre_005_inc.Text : !string.IsNullOrEmpty(txt_tre_004_inc.Text) ? txt_tre_004_inc.Text : !string.IsNullOrEmpty(txt_tre_003_inc.Text) ? txt_tre_003_inc.Text : !string.IsNullOrEmpty(txt_tre_002_inc.Text) ? txt_tre_002_inc.Text : !string.IsNullOrEmpty(txt_tre_001_inc.Text) ? txt_tre_001_inc.Text : txt_tre_ref_inc.Text;

        string sLME = !string.IsNullOrEmpty(txt_lme_007_inc.Text) ? txt_lme_007_inc.Text : !string.IsNullOrEmpty(txt_lme_006_inc.Text) ? txt_lme_006_inc.Text : !string.IsNullOrEmpty(txt_lme_005_inc.Text) ? txt_lme_005_inc.Text : !string.IsNullOrEmpty(txt_lme_004_inc.Text) ? txt_lme_004_inc.Text : !string.IsNullOrEmpty(txt_lme_003_inc.Text) ? txt_lme_003_inc.Text : !string.IsNullOrEmpty(txt_lme_002_inc.Text) ? txt_lme_002_inc.Text : !string.IsNullOrEmpty(txt_lme_001_inc.Text) ? txt_lme_001_inc.Text : txt_lme_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLME))
        {
            Standard.EPF_LME = Convert.ToDouble(sLME);
        }
        string sUME = !string.IsNullOrEmpty(txt_ume_007_inc.Text) ? txt_ume_007_inc.Text : !string.IsNullOrEmpty(txt_ume_006_inc.Text) ? txt_ume_006_inc.Text : !string.IsNullOrEmpty(txt_ume_005_inc.Text) ? txt_ume_005_inc.Text : !string.IsNullOrEmpty(txt_ume_004_inc.Text) ? txt_ume_004_inc.Text : !string.IsNullOrEmpty(txt_ume_003_inc.Text) ? txt_ume_003_inc.Text : !string.IsNullOrEmpty(txt_ume_002_inc.Text) ? txt_ume_002_inc.Text : !string.IsNullOrEmpty(txt_ume_001_inc.Text) ? txt_ume_001_inc.Text : txt_ume_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUME))
        {
            Standard.EPF_UME = Convert.ToDouble(sUME);
        }
        string sLPE = !string.IsNullOrEmpty(txt_lpe_007_inc.Text) ? txt_lpe_007_inc.Text : !string.IsNullOrEmpty(txt_lpe_006_inc.Text) ? txt_lpe_006_inc.Text : !string.IsNullOrEmpty(txt_lpe_005_inc.Text) ? txt_lpe_005_inc.Text : !string.IsNullOrEmpty(txt_lpe_004_inc.Text) ? txt_lpe_004_inc.Text : !string.IsNullOrEmpty(txt_lpe_003_inc.Text) ? txt_lpe_003_inc.Text : !string.IsNullOrEmpty(txt_lpe_002_inc.Text) ? txt_lpe_002_inc.Text : !string.IsNullOrEmpty(txt_lpe_001_inc.Text) ? txt_lpe_001_inc.Text : txt_lpe_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLPE))
        {
            Standard.EPF_LPE = Convert.ToDouble(sLPE);
        }
        string sUPE = !string.IsNullOrEmpty(txt_upe_007_inc.Text) ? txt_upe_007_inc.Text : !string.IsNullOrEmpty(txt_upe_006_inc.Text) ? txt_upe_006_inc.Text : !string.IsNullOrEmpty(txt_upe_005_inc.Text) ? txt_upe_005_inc.Text : !string.IsNullOrEmpty(txt_upe_004_inc.Text) ? txt_upe_004_inc.Text : !string.IsNullOrEmpty(txt_upe_003_inc.Text) ? txt_upe_003_inc.Text : !string.IsNullOrEmpty(txt_upe_002_inc.Text) ? txt_upe_002_inc.Text : !string.IsNullOrEmpty(txt_upe_001_inc.Text) ? txt_upe_001_inc.Text : txt_upe_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUPE))
        {
            Standard.EPF_UPE = Convert.ToDouble(sUPE);
        }
        string sUCV = !string.IsNullOrEmpty(txt_ucv_007_inc.Text) ? txt_ucv_007_inc.Text : !string.IsNullOrEmpty(txt_ucv_006_inc.Text) ? txt_ucv_006_inc.Text : !string.IsNullOrEmpty(txt_ucv_005_inc.Text) ? txt_ucv_005_inc.Text : !string.IsNullOrEmpty(txt_ucv_004_inc.Text) ? txt_ucv_004_inc.Text : !string.IsNullOrEmpty(txt_ucv_003_inc.Text) ? txt_ucv_003_inc.Text : !string.IsNullOrEmpty(txt_ucv_002_inc.Text) ? txt_ucv_002_inc.Text : !string.IsNullOrEmpty(txt_ucv_001_inc.Text) ? txt_ucv_001_inc.Text : txt_ucv_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUCV))
        {
            Standard.EPF_UCV = Convert.ToDouble(sUCV);
        }
        string sDUR = !string.IsNullOrEmpty(txt_dur_007_inc.Text) ? txt_dur_007_inc.Text : !string.IsNullOrEmpty(txt_dur_006_inc.Text) ? txt_dur_006_inc.Text : !string.IsNullOrEmpty(txt_dur_005_inc.Text) ? txt_dur_005_inc.Text : !string.IsNullOrEmpty(txt_dur_004_inc.Text) ? txt_dur_004_inc.Text : !string.IsNullOrEmpty(txt_dur_003_inc.Text) ? txt_dur_003_inc.Text : !string.IsNullOrEmpty(txt_dur_002_inc.Text) ? txt_dur_002_inc.Text : !string.IsNullOrEmpty(txt_dur_001_inc.Text) ? txt_dur_001_inc.Text : txt_dur_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDUR))
        {
            Standard.EPF_DUR = Convert.ToDouble(sDUR);
        }
        string sDFT = !string.IsNullOrEmpty(txt_dft_007_inc.Text) ? txt_dft_007_inc.Text : !string.IsNullOrEmpty(txt_dft_006_inc.Text) ? txt_dft_006_inc.Text : !string.IsNullOrEmpty(txt_dft_005_inc.Text) ? txt_dft_005_inc.Text : !string.IsNullOrEmpty(txt_dft_004_inc.Text) ? txt_dft_004_inc.Text : !string.IsNullOrEmpty(txt_dft_003_inc.Text) ? txt_dft_003_inc.Text : !string.IsNullOrEmpty(txt_dft_002_inc.Text) ? txt_dft_002_inc.Text : !string.IsNullOrEmpty(txt_dft_001_inc.Text) ? txt_dft_001_inc.Text : txt_dft_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDFT))
        {
            Standard.EPF_DFT = Convert.ToDouble(sDFT);
        }
        string sLMC = !string.IsNullOrEmpty(txt_lmc_007_inc.Text) ? txt_lmc_007_inc.Text : !string.IsNullOrEmpty(txt_lmc_006_inc.Text) ? txt_lmc_006_inc.Text : !string.IsNullOrEmpty(txt_lmc_005_inc.Text) ? txt_lmc_005_inc.Text : !string.IsNullOrEmpty(txt_lmc_004_inc.Text) ? txt_lmc_004_inc.Text : !string.IsNullOrEmpty(txt_lmc_003_inc.Text) ? txt_lmc_003_inc.Text : !string.IsNullOrEmpty(txt_lmc_002_inc.Text) ? txt_lmc_002_inc.Text : !string.IsNullOrEmpty(txt_lmc_001_inc.Text) ? txt_lmc_001_inc.Text : txt_lmc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLMC))
        {
            Standard.EPF_LMC = Convert.ToDouble(sLMC);
        }
        string sUMC = !string.IsNullOrEmpty(txt_umc_007_inc.Text) ? txt_umc_007_inc.Text : !string.IsNullOrEmpty(txt_umc_006_inc.Text) ? txt_umc_006_inc.Text : !string.IsNullOrEmpty(txt_umc_005_inc.Text) ? txt_umc_005_inc.Text : !string.IsNullOrEmpty(txt_umc_004_inc.Text) ? txt_umc_004_inc.Text : !string.IsNullOrEmpty(txt_umc_003_inc.Text) ? txt_umc_003_inc.Text : !string.IsNullOrEmpty(txt_umc_002_inc.Text) ? txt_umc_002_inc.Text : !string.IsNullOrEmpty(txt_umc_001_inc.Text) ? txt_umc_001_inc.Text : txt_umc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUMC))
        {
            Standard.EPF_UMC = Convert.ToDouble(sUMC);
        }
        string sLPC = !string.IsNullOrEmpty(txt_lpc_007_inc.Text) ? txt_lpc_007_inc.Text : !string.IsNullOrEmpty(txt_lpc_006_inc.Text) ? txt_lpc_006_inc.Text : !string.IsNullOrEmpty(txt_lpc_005_inc.Text) ? txt_lpc_005_inc.Text : !string.IsNullOrEmpty(txt_lpc_004_inc.Text) ? txt_lpc_004_inc.Text : !string.IsNullOrEmpty(txt_lpc_003_inc.Text) ? txt_lpc_003_inc.Text : !string.IsNullOrEmpty(txt_lpc_002_inc.Text) ? txt_lpc_002_inc.Text : !string.IsNullOrEmpty(txt_lpc_001_inc.Text) ? txt_lpc_001_inc.Text : txt_lpc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLPC))
        {
            Standard.EPF_LPC = Convert.ToDouble(sLPC);
        }
        string sUPC = !string.IsNullOrEmpty(txt_upc_007_inc.Text) ? txt_upc_007_inc.Text : !string.IsNullOrEmpty(txt_upc_006_inc.Text) ? txt_upc_006_inc.Text : !string.IsNullOrEmpty(txt_upc_005_inc.Text) ? txt_upc_005_inc.Text : !string.IsNullOrEmpty(txt_upc_004_inc.Text) ? txt_upc_004_inc.Text : !string.IsNullOrEmpty(txt_upc_003_inc.Text) ? txt_upc_003_inc.Text : !string.IsNullOrEmpty(txt_upc_002_inc.Text) ? txt_upc_002_inc.Text : !string.IsNullOrEmpty(txt_upc_001_inc.Text) ? txt_upc_001_inc.Text : txt_upc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUPC))
        {
            Standard.EPF_UPC = Convert.ToDouble(sUPC);
        }
        string sCVC = !string.IsNullOrEmpty(txt_cvc_007_inc.Text) ? txt_cvc_007_inc.Text : !string.IsNullOrEmpty(txt_cvc_006_inc.Text) ? txt_cvc_006_inc.Text : !string.IsNullOrEmpty(txt_cvc_005_inc.Text) ? txt_cvc_005_inc.Text : !string.IsNullOrEmpty(txt_cvc_004_inc.Text) ? txt_cvc_004_inc.Text : !string.IsNullOrEmpty(txt_cvc_003_inc.Text) ? txt_cvc_003_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_inc.Text) ? txt_cvc_002_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_inc.Text) ? txt_cvc_001_inc.Text : txt_cvc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVC))
        {
            Standard.EPF_CVC = Convert.ToDouble(sCVC);
        }
        string sDFC = !string.IsNullOrEmpty(txt_dfc_007_inc.Text) ? txt_dfc_007_inc.Text : !string.IsNullOrEmpty(txt_dfc_006_inc.Text) ? txt_dfc_006_inc.Text : !string.IsNullOrEmpty(txt_dfc_005_inc.Text) ? txt_dfc_005_inc.Text : !string.IsNullOrEmpty(txt_dfc_004_inc.Text) ? txt_dfc_004_inc.Text : !string.IsNullOrEmpty(txt_dfc_003_inc.Text) ? txt_dfc_003_inc.Text : !string.IsNullOrEmpty(txt_dfc_002_inc.Text) ? txt_dfc_002_inc.Text : !string.IsNullOrEmpty(txt_dfc_001_inc.Text) ? txt_dfc_001_inc.Text : txt_dfc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDFC))
        {
            Standard.EPF_DFC = Convert.ToDouble(sDFC);
        }
        string sTFS = !string.IsNullOrEmpty(txt_tfs_007_inc.Text) ? txt_tfs_007_inc.Text : !string.IsNullOrEmpty(txt_tfs_006_inc.Text) ? txt_tfs_006_inc.Text : !string.IsNullOrEmpty(txt_tfs_005_inc.Text) ? txt_tfs_005_inc.Text : !string.IsNullOrEmpty(txt_tfs_004_inc.Text) ? txt_tfs_004_inc.Text : !string.IsNullOrEmpty(txt_tfs_003_inc.Text) ? txt_tfs_003_inc.Text : !string.IsNullOrEmpty(txt_tfs_002_inc.Text) ? txt_tfs_002_inc.Text : !string.IsNullOrEmpty(txt_tfs_001_inc.Text) ? txt_tfs_001_inc.Text : txt_tfs_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTFS))
        {
            Standard.EPF_TFS = Convert.ToDouble(sTFS);
        }
        string sFSW = !string.IsNullOrEmpty(txt_fsw_007_inc.Text) ? txt_fsw_007_inc.Text : !string.IsNullOrEmpty(txt_fsw_006_inc.Text) ? txt_fsw_006_inc.Text : !string.IsNullOrEmpty(txt_fsw_005_inc.Text) ? txt_fsw_005_inc.Text : !string.IsNullOrEmpty(txt_fsw_004_inc.Text) ? txt_fsw_004_inc.Text : !string.IsNullOrEmpty(txt_fsw_003_inc.Text) ? txt_fsw_003_inc.Text : !string.IsNullOrEmpty(txt_fsw_002_inc.Text) ? txt_fsw_002_inc.Text : !string.IsNullOrEmpty(txt_fsw_001_inc.Text) ? txt_fsw_001_inc.Text : txt_fsw_ref_inc.Text;
        if (!string.IsNullOrEmpty(sFSW))
        {
            Standard.EPF_FSW = Convert.ToDouble(sFSW);
        }
        string sWFW = !string.IsNullOrEmpty(txt_wfw_007_inc.Text) ? txt_wfw_007_inc.Text : !string.IsNullOrEmpty(txt_wfw_006_inc.Text) ? txt_wfw_006_inc.Text : !string.IsNullOrEmpty(txt_wfw_005_inc.Text) ? txt_wfw_005_inc.Text : !string.IsNullOrEmpty(txt_wfw_004_inc.Text) ? txt_wfw_004_inc.Text : !string.IsNullOrEmpty(txt_wfw_003_inc.Text) ? txt_wfw_003_inc.Text : !string.IsNullOrEmpty(txt_wfw_002_inc.Text) ? txt_wfw_002_inc.Text : !string.IsNullOrEmpty(txt_wfw_001_inc.Text) ? txt_wfw_001_inc.Text : txt_wfw_ref_inc.Text;
        if (!string.IsNullOrEmpty(sWFW))
        {
            Standard.EPF_WFW = Convert.ToDouble(sWFW);
        }
        string sECO = !string.IsNullOrEmpty(txt_eco_007_inc.Text) ? txt_eco_007_inc.Text : !string.IsNullOrEmpty(txt_eco_006_inc.Text) ? txt_eco_006_inc.Text : !string.IsNullOrEmpty(txt_eco_005_inc.Text) ? txt_eco_005_inc.Text : !string.IsNullOrEmpty(txt_eco_004_inc.Text) ? txt_eco_004_inc.Text : !string.IsNullOrEmpty(txt_eco_003_inc.Text) ? txt_eco_003_inc.Text : !string.IsNullOrEmpty(txt_eco_002_inc.Text) ? txt_eco_002_inc.Text : !string.IsNullOrEmpty(txt_eco_001_inc.Text) ? txt_eco_001_inc.Text : txt_eco_ref_inc.Text;
        if (!string.IsNullOrEmpty(sECO))
        {
            Standard.EPF_ECO = Convert.ToDouble(sECO);
        }
        Standard.EPF_EOL = !string.IsNullOrEmpty(txt_eol_007_inc.Text) ? txt_eol_007_inc.Text : !string.IsNullOrEmpty(txt_eol_006_inc.Text) ? txt_eol_006_inc.Text : !string.IsNullOrEmpty(txt_eol_005_inc.Text) ? txt_eol_005_inc.Text : !string.IsNullOrEmpty(txt_eol_004_inc.Text) ? txt_eol_004_inc.Text : !string.IsNullOrEmpty(txt_eol_003_inc.Text) ? txt_eol_003_inc.Text : !string.IsNullOrEmpty(txt_eol_002_inc.Text) ? txt_eol_002_inc.Text : !string.IsNullOrEmpty(txt_eol_001_inc.Text) ? txt_eol_001_inc.Text : txt_eol_ref_inc.Text;
        Standard.EPF_ETU = !string.IsNullOrEmpty(txt_etu_007_inc.Text) ? txt_etu_007_inc.Text : !string.IsNullOrEmpty(txt_etu_006_inc.Text) ? txt_etu_006_inc.Text : !string.IsNullOrEmpty(txt_etu_005_inc.Text) ? txt_etu_005_inc.Text : !string.IsNullOrEmpty(txt_etu_004_inc.Text) ? txt_etu_004_inc.Text : !string.IsNullOrEmpty(txt_etu_003_inc.Text) ? txt_etu_003_inc.Text : !string.IsNullOrEmpty(txt_etu_002_inc.Text) ? txt_etu_002_inc.Text : !string.IsNullOrEmpty(txt_etu_001_inc.Text) ? txt_etu_001_inc.Text : txt_etu_ref_inc.Text;
        Standard.EPF_ETD = !string.IsNullOrEmpty(txt_etd_007_inc.Text) ? txt_etd_007_inc.Text : !string.IsNullOrEmpty(txt_etd_006_inc.Text) ? txt_etd_006_inc.Text : !string.IsNullOrEmpty(txt_etd_005_inc.Text) ? txt_etd_005_inc.Text : !string.IsNullOrEmpty(txt_etd_004_inc.Text) ? txt_etd_004_inc.Text : !string.IsNullOrEmpty(txt_etd_003_inc.Text) ? txt_etd_003_inc.Text : !string.IsNullOrEmpty(txt_etd_002_inc.Text) ? txt_etd_002_inc.Text : !string.IsNullOrEmpty(txt_etd_001_inc.Text) ? txt_etd_001_inc.Text : txt_etd_ref_inc.Text;
        Standard.EPF_ECU = !string.IsNullOrEmpty(txt_ecu_007_inc.Text) ? txt_ecu_007_inc.Text : !string.IsNullOrEmpty(txt_ecu_006_inc.Text) ? txt_ecu_006_inc.Text : !string.IsNullOrEmpty(txt_ecu_005_inc.Text) ? txt_ecu_005_inc.Text : !string.IsNullOrEmpty(txt_ecu_004_inc.Text) ? txt_ecu_004_inc.Text : !string.IsNullOrEmpty(txt_ecu_003_inc.Text) ? txt_ecu_003_inc.Text : !string.IsNullOrEmpty(txt_ecu_002_inc.Text) ? txt_ecu_002_inc.Text : !string.IsNullOrEmpty(txt_ecu_001_inc.Text) ? txt_ecu_001_inc.Text : txt_ecu_ref_inc.Text;
        Standard.EPF_EGD = !string.IsNullOrEmpty(txt_egd_007_inc.Text) ? txt_egd_007_inc.Text : !string.IsNullOrEmpty(txt_egd_006_inc.Text) ? txt_egd_006_inc.Text : !string.IsNullOrEmpty(txt_egd_005_inc.Text) ? txt_egd_005_inc.Text : !string.IsNullOrEmpty(txt_egd_004_inc.Text) ? txt_egd_004_inc.Text : !string.IsNullOrEmpty(txt_egd_003_inc.Text) ? txt_egd_003_inc.Text : !string.IsNullOrEmpty(txt_egd_002_inc.Text) ? txt_egd_002_inc.Text : !string.IsNullOrEmpty(txt_egd_001_inc.Text) ? txt_egd_001_inc.Text : txt_egd_ref_inc.Text;
        Standard.EPF_EEC = !string.IsNullOrEmpty(txt_eec_007_inc.Text) ? txt_eec_007_inc.Text : !string.IsNullOrEmpty(txt_eec_006_inc.Text) ? txt_eec_006_inc.Text : !string.IsNullOrEmpty(txt_eec_005_inc.Text) ? txt_eec_005_inc.Text : !string.IsNullOrEmpty(txt_eec_004_inc.Text) ? txt_eec_004_inc.Text : !string.IsNullOrEmpty(txt_eec_003_inc.Text) ? txt_eec_003_inc.Text : !string.IsNullOrEmpty(txt_eec_002_inc.Text) ? txt_eec_002_inc.Text : !string.IsNullOrEmpty(txt_eec_001_inc.Text) ? txt_eec_001_inc.Text : txt_eec_ref_inc.Text;
        Standard.EPF_ECD = !string.IsNullOrEmpty(txt_ecd_007_inc.Text) ? txt_ecd_007_inc.Text : !string.IsNullOrEmpty(txt_ecd_006_inc.Text) ? txt_ecd_006_inc.Text : !string.IsNullOrEmpty(txt_ecd_005_inc.Text) ? txt_ecd_005_inc.Text : !string.IsNullOrEmpty(txt_ecd_004_inc.Text) ? txt_ecd_004_inc.Text : !string.IsNullOrEmpty(txt_ecd_003_inc.Text) ? txt_ecd_003_inc.Text : !string.IsNullOrEmpty(txt_ecd_002_inc.Text) ? txt_ecd_002_inc.Text : !string.IsNullOrEmpty(txt_ecd_001_inc.Text) ? txt_ecd_001_inc.Text : txt_ecd_ref_inc.Text;
        Standard.EPF_EGD = !string.IsNullOrEmpty(txt_egd_007_inc.Text) ? txt_egd_007_inc.Text : !string.IsNullOrEmpty(txt_egd_006_inc.Text) ? txt_egd_006_inc.Text : !string.IsNullOrEmpty(txt_egd_005_inc.Text) ? txt_egd_005_inc.Text : !string.IsNullOrEmpty(txt_egd_004_inc.Text) ? txt_egd_004_inc.Text : !string.IsNullOrEmpty(txt_egd_003_inc.Text) ? txt_egd_003_inc.Text : !string.IsNullOrEmpty(txt_egd_002_inc.Text) ? txt_egd_002_inc.Text : !string.IsNullOrEmpty(txt_egd_001_inc.Text) ? txt_egd_001_inc.Text : txt_egd_ref_inc.Text;
        Standard.EPF_EGU = !string.IsNullOrEmpty(txt_egu_007_inc.Text) ? txt_egu_007_inc.Text : !string.IsNullOrEmpty(txt_egu_006_inc.Text) ? txt_egu_006_inc.Text : !string.IsNullOrEmpty(txt_egu_005_inc.Text) ? txt_egu_005_inc.Text : !string.IsNullOrEmpty(txt_egu_004_inc.Text) ? txt_egu_004_inc.Text : !string.IsNullOrEmpty(txt_egu_003_inc.Text) ? txt_egu_003_inc.Text : !string.IsNullOrEmpty(txt_egu_002_inc.Text) ? txt_egu_002_inc.Text : !string.IsNullOrEmpty(txt_egu_001_inc.Text) ? txt_egu_001_inc.Text : txt_egu_ref_inc.Text;
        Standard.EPF_ESO = !string.IsNullOrEmpty(txt_eso_007_inc.Text) ? txt_eso_007_inc.Text : !string.IsNullOrEmpty(txt_eso_006_inc.Text) ? txt_eso_006_inc.Text : !string.IsNullOrEmpty(txt_eso_005_inc.Text) ? txt_eso_005_inc.Text : !string.IsNullOrEmpty(txt_eso_004_inc.Text) ? txt_eso_004_inc.Text : !string.IsNullOrEmpty(txt_eso_003_inc.Text) ? txt_eso_003_inc.Text : !string.IsNullOrEmpty(txt_eso_002_inc.Text) ? txt_eso_002_inc.Text : !string.IsNullOrEmpty(txt_eso_001_inc.Text) ? txt_eso_001_inc.Text : txt_eso_ref_inc.Text;
        Standard.EPF_ESI = !string.IsNullOrEmpty(txt_esi_007_inc.Text) ? txt_esi_007_inc.Text : !string.IsNullOrEmpty(txt_esi_006_inc.Text) ? txt_esi_006_inc.Text : !string.IsNullOrEmpty(txt_esi_005_inc.Text) ? txt_esi_005_inc.Text : !string.IsNullOrEmpty(txt_esi_004_inc.Text) ? txt_esi_004_inc.Text : !string.IsNullOrEmpty(txt_esi_003_inc.Text) ? txt_esi_003_inc.Text : !string.IsNullOrEmpty(txt_esi_002_inc.Text) ? txt_esi_002_inc.Text : !string.IsNullOrEmpty(txt_esi_001_inc.Text) ? txt_esi_001_inc.Text : txt_esi_ref_inc.Text;
        Standard.EPF_ECR = !string.IsNullOrEmpty(txt_ecr_007_inc.Text) ? txt_ecr_007_inc.Text : !string.IsNullOrEmpty(txt_ecr_006_inc.Text) ? txt_ecr_006_inc.Text : !string.IsNullOrEmpty(txt_ecr_005_inc.Text) ? txt_ecr_005_inc.Text : !string.IsNullOrEmpty(txt_ecr_004_inc.Text) ? txt_ecr_004_inc.Text : !string.IsNullOrEmpty(txt_ecr_003_inc.Text) ? txt_ecr_003_inc.Text : !string.IsNullOrEmpty(txt_ecr_002_inc.Text) ? txt_ecr_002_inc.Text : !string.IsNullOrEmpty(txt_ecr_001_inc.Text) ? txt_ecr_001_inc.Text : txt_ecr_ref_inc.Text;
        Standard.EPF_EOD = !string.IsNullOrEmpty(txt_eod_007_inc.Text) ? txt_eod_007_inc.Text : !string.IsNullOrEmpty(txt_eod_006_inc.Text) ? txt_eod_006_inc.Text : !string.IsNullOrEmpty(txt_eod_005_inc.Text) ? txt_eod_005_inc.Text : !string.IsNullOrEmpty(txt_eod_004_inc.Text) ? txt_eod_004_inc.Text : !string.IsNullOrEmpty(txt_eod_003_inc.Text) ? txt_eod_003_inc.Text : !string.IsNullOrEmpty(txt_eod_002_inc.Text) ? txt_eod_002_inc.Text : !string.IsNullOrEmpty(txt_eod_001_inc.Text) ? txt_eod_001_inc.Text : txt_eod_ref_inc.Text;
        Standard.EPF_EAW = !string.IsNullOrEmpty(txt_eaw_007_inc.Text) ? txt_eaw_007_inc.Text : !string.IsNullOrEmpty(txt_eaw_006_inc.Text) ? txt_eaw_006_inc.Text : !string.IsNullOrEmpty(txt_eaw_005_inc.Text) ? txt_eaw_005_inc.Text : !string.IsNullOrEmpty(txt_eaw_004_inc.Text) ? txt_eaw_004_inc.Text : !string.IsNullOrEmpty(txt_eaw_003_inc.Text) ? txt_eaw_003_inc.Text : !string.IsNullOrEmpty(txt_eaw_002_inc.Text) ? txt_eaw_002_inc.Text : !string.IsNullOrEmpty(txt_eaw_001_inc.Text) ? txt_eaw_001_inc.Text : txt_eaw_ref_inc.Text;
        Standard.EPF_ED1 = !string.IsNullOrEmpty(txt_ed1_007_inc.Text) ? txt_ed1_007_inc.Text : !string.IsNullOrEmpty(txt_ed1_006_inc.Text) ? txt_ed1_006_inc.Text : !string.IsNullOrEmpty(txt_ed1_005_inc.Text) ? txt_ed1_005_inc.Text : !string.IsNullOrEmpty(txt_ed1_004_inc.Text) ? txt_ed1_004_inc.Text : !string.IsNullOrEmpty(txt_ed1_003_inc.Text) ? txt_ed1_003_inc.Text : !string.IsNullOrEmpty(txt_ed1_002_inc.Text) ? txt_ed1_002_inc.Text : !string.IsNullOrEmpty(txt_ed1_001_inc.Text) ? txt_ed1_001_inc.Text : txt_ed1_ref_inc.Text;
        Standard.EPF_ED2 = !string.IsNullOrEmpty(txt_ed2_007_inc.Text) ? txt_ed2_007_inc.Text : !string.IsNullOrEmpty(txt_ed2_006_inc.Text) ? txt_ed2_006_inc.Text : !string.IsNullOrEmpty(txt_ed2_005_inc.Text) ? txt_ed2_005_inc.Text : !string.IsNullOrEmpty(txt_ed2_004_inc.Text) ? txt_ed2_004_inc.Text : !string.IsNullOrEmpty(txt_ed2_003_inc.Text) ? txt_ed2_003_inc.Text : !string.IsNullOrEmpty(txt_ed2_002_inc.Text) ? txt_ed2_002_inc.Text : !string.IsNullOrEmpty(txt_ed2_001_inc.Text) ? txt_ed2_001_inc.Text : txt_ed2_ref_inc.Text;

        Standard.EPF_PCO = !string.IsNullOrEmpty(txt_pco_007_inc.Text) ? txt_pco_007_inc.Text : !string.IsNullOrEmpty(txt_pco_006_inc.Text) ? txt_pco_006_inc.Text : !string.IsNullOrEmpty(txt_pco_005_inc.Text) ? txt_pco_005_inc.Text : !string.IsNullOrEmpty(txt_pco_004_inc.Text) ? txt_pco_004_inc.Text : !string.IsNullOrEmpty(txt_pco_003_inc.Text) ? txt_pco_003_inc.Text : !string.IsNullOrEmpty(txt_pco_002_inc.Text) ? txt_pco_002_inc.Text : !string.IsNullOrEmpty(txt_pco_001_inc.Text) ? txt_pco_001_inc.Text : txt_pco_ref_inc.Text;
        Standard.EPF_PCV = !string.IsNullOrEmpty(txt_pcv_007_inc.Text) ? txt_pcv_007_inc.Text : !string.IsNullOrEmpty(txt_pcv_006_inc.Text) ? txt_pcv_006_inc.Text : !string.IsNullOrEmpty(txt_pcv_005_inc.Text) ? txt_pcv_005_inc.Text : !string.IsNullOrEmpty(txt_pcv_004_inc.Text) ? txt_pcv_004_inc.Text : !string.IsNullOrEmpty(txt_pcv_003_inc.Text) ? txt_pcv_003_inc.Text : !string.IsNullOrEmpty(txt_pcv_002_inc.Text) ? txt_pcv_002_inc.Text : !string.IsNullOrEmpty(txt_pcv_001_inc.Text) ? txt_pcv_001_inc.Text : txt_pcv_ref_inc.Text;
        Standard.EPF_DRT = !string.IsNullOrEmpty(txt_drt_007_inc.Text) ? txt_drt_007_inc.Text : !string.IsNullOrEmpty(txt_drt_006_inc.Text) ? txt_drt_006_inc.Text : !string.IsNullOrEmpty(txt_drt_005_inc.Text) ? txt_drt_005_inc.Text : !string.IsNullOrEmpty(txt_drt_004_inc.Text) ? txt_drt_004_inc.Text : !string.IsNullOrEmpty(txt_drt_003_inc.Text) ? txt_drt_003_inc.Text : !string.IsNullOrEmpty(txt_drt_002_inc.Text) ? txt_drt_002_inc.Text : !string.IsNullOrEmpty(txt_drt_001_inc.Text) ? txt_drt_001_inc.Text : txt_drt_ref_inc.Text;
        Standard.EPF_TAL = !string.IsNullOrEmpty(txt_tal_007_inc.Text) ? txt_tal_007_inc.Text : !string.IsNullOrEmpty(txt_tal_006_inc.Text) ? txt_tal_006_inc.Text : !string.IsNullOrEmpty(txt_tal_005_inc.Text) ? txt_tal_005_inc.Text : !string.IsNullOrEmpty(txt_tal_004_inc.Text) ? txt_tal_004_inc.Text : !string.IsNullOrEmpty(txt_tal_003_inc.Text) ? txt_tal_003_inc.Text : !string.IsNullOrEmpty(txt_tal_002_inc.Text) ? txt_tal_002_inc.Text : !string.IsNullOrEmpty(txt_tal_001_inc.Text) ? txt_tal_001_inc.Text : txt_tal_ref_inc.Text;
        Standard.EPF_VAL = !string.IsNullOrEmpty(txt_val_007_inc.Text) ? txt_val_007_inc.Text : !string.IsNullOrEmpty(txt_val_006_inc.Text) ? txt_val_006_inc.Text : !string.IsNullOrEmpty(txt_val_005_inc.Text) ? txt_val_005_inc.Text : !string.IsNullOrEmpty(txt_val_004_inc.Text) ? txt_val_004_inc.Text : !string.IsNullOrEmpty(txt_val_003_inc.Text) ? txt_val_003_inc.Text : !string.IsNullOrEmpty(txt_val_002_inc.Text) ? txt_val_002_inc.Text : !string.IsNullOrEmpty(txt_val_001_inc.Text) ? txt_val_001_inc.Text : txt_val_ref_inc.Text;
        Standard.EPF_SJE = !string.IsNullOrEmpty(txt_sje_007_inc.Text) ? txt_sje_007_inc.Text : !string.IsNullOrEmpty(txt_sje_006_inc.Text) ? txt_sje_006_inc.Text : !string.IsNullOrEmpty(txt_sje_005_inc.Text) ? txt_sje_005_inc.Text : !string.IsNullOrEmpty(txt_sje_004_inc.Text) ? txt_sje_004_inc.Text : !string.IsNullOrEmpty(txt_sje_003_inc.Text) ? txt_sje_003_inc.Text : !string.IsNullOrEmpty(txt_sje_002_inc.Text) ? txt_sje_002_inc.Text : !string.IsNullOrEmpty(txt_sje_001_inc.Text) ? txt_sje_001_inc.Text : txt_sje_ref_inc.Text;
        Standard.EPF_DET = txt_det_inc.Text;

        Standard.EPF_STS = 1; //Ativo
        Standard.EPF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());

        string sMsg = "";
        sMsg = Standard.Inserir();

        if (sMsg.Substring(0, 1) == "E")
        {
            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
        }
        else
        {
            TratamentoErro("Standard Atualizado com sucesso.");
        }

    }

}