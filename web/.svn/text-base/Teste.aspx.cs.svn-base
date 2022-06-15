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
        txt_lcv_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

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
        txt_lcv_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lcv_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
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
        txt_lvc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_lvc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_dfc_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_dfc_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tfs_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tfs_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_fsw_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_fsw_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_wfw_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_wfw_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ybt_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_ybt_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");

        //TMT
        txt_hot_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_ref_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_ref_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

        txt_hot_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_acr_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_pen_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cle_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_afo_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tar_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dtu_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_dpa_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cin_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ato_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tp1_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp1_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tp2_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tp2_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tcp_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps2_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ps0_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_bba_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_bba_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_ssv_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ssp_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tte_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_001_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tte_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tte_002_007_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cra_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cra_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g1u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_g2u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvp_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ocu_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_ucu_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c1u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l1u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2o_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_c2u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_l2u_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tsu_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvc_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_cvl_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_001_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
        txt_tle_002_007_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
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
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_004_id_inc);
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

        Engrenagem_M900 Engrenagem_M900 = new Engrenagem_M900();
        DataSet dsEngrenagem_M900 = Engrenagem_M900.Consultar();
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_ref_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_001_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_002_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_003_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_004_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_005_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_006_inc);
        FWGNR.VerificaStatus(dsEngrenagem_M900, "CODIGO", "TAXA_Z1_Z2", "", cbo_ez1_ez2_007_inc);
        dsEngrenagem_M900.Dispose();

        Overfeed_M900 Overfeed_M900 = new Overfeed_M900();
        DataSet dsOverfeed_M900 = Overfeed_M900.Consultar();
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_ref_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_001_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_002_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_003_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_004_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_005_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_006_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z3_Z4", "", cbo_ez3_ez4_007_inc);

        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_ref_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_001_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_002_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_003_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_004_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_005_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_006_inc);
        FWGNR.VerificaStatus(dsOverfeed_M900, "CODIGO", "OVERFEED_Z5_Z6", "", cbo_ez5_ez6_007_inc);
        dsOverfeed_M900.Dispose();
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
            DataSet dsTeste = Teste.ConsultarSequencia();
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
                txt_mge_004_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_004"].ToString();
                txt_mge_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_REF"].ToString();
                txt_mge_002_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_002_REF"].ToString();
                txt_mge_003_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_003_REF"].ToString();
                txt_mge_004_ref_inc.Text = dsTeste.Tables[0].Rows[0]["TST_MGE_004_REF"].ToString();
                cbo_for_001_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_FOR_004_ID"].ToString();
                //Excluído por solicitação do Wagner 11/07/2011
                //txt_vlc_inc.Text = dsTeste.Tables[0].Rows[0]["TST_VLC"].ToString();
                cbo_aps_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_APS_ID"].ToString();
                cbo_maq_tip_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_MAQ_TIP_ID"].ToString();
                object sender = null;
                EventArgs e = null;
                cbo_maq_tip_id_OnSelectedIndexChanged(sender, e);
                cbo_ert_id_inc.SelectedValue = dsTeste.Tables[0].Rows[0]["TST_ERT_ID"].ToString();
                txt_dat_ini_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_INI"].ToString()).ToString("dd/MM/yyyy");
                txt_hor_ini_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_INI"].ToString()).ToString("HH:mm");
                txt_dat_fim_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_FIM"].ToString()).ToString("dd/MM/yyyy");
                txt_hor_fim_inc.Text = Convert.ToDateTime(dsTeste.Tables[0].Rows[0]["TST_DAT_FIM"].ToString()).ToString("HH:mm");
                calculaTempoGasto(sender, e);

                //Carrega a Referência e as 7 ocorrências de teste
                for (int i = 0; i <= 7; i++)
                {
                    CarregaItem(i, "vw2", dsTeste);
                    CarregaItem(i, "egm", dsTeste);
                    CarregaItem(i, "dyy", dsTeste);
                    CarregaItem(i, "2wx", dsTeste);
                    CarregaItem(i, "3w3", dsTeste);
                    CarregaItem(i, "4w4", dsTeste);
                    CarregaItem(i, "agl", dsTeste);
                    CarregaItem(i, "tup", dsTeste);
                    CarregaItem(i, "veo", dsTeste);
                    CarregaItem(i, "t1t", dsTeste);
                    CarregaItem(i, "t1c", dsTeste);
                    CarregaItem(i, "t1l", dsTeste);
                    CarregaItem(i, "t2f", dsTeste);
                    CarregaItem(i, "sve", dsTeste);
                    CarregaItem(i, "stf", dsTeste);
                    CarregaItem(i, "stm", dsTeste);
                    CarregaItem(i, "sce", dsTeste);
                    CarregaItem(i, "sco", dsTeste);
                    CarregaItem(i, "sch", dsTeste);
                    CarregaItem(i, "scg", dsTeste);
                    CarregaItem(i, "see", dsTeste);
                    CarregaItem(i, "seo", dsTeste);
                    CarregaItem(i, "seh", dsTeste);
                    CarregaItem(i, "seg", dsTeste);
                    CarregaItem(i, "sjc", dsTeste);
                    CarregaItem(i, "sjt", dsTeste);
                    CarregaItem(i, "sjb", dsTeste);
                    CarregaItem(i, "spj", dsTeste);
                    CarregaItem(i, "sbc", dsTeste);
                    CarregaItem(i, "spo", dsTeste);
                    CarregaItem(i, "sva", dsTeste);
                    CarregaItem(i, "tip", dsTeste);
                    CarregaItem(i, "dsb", dsTeste);
                    CarregaItem(i, "tca", dsTeste);
                    CarregaItem(i, "fmc", dsTeste);
                    CarregaItem(i, "1tb", dsTeste);
                    CarregaItem(i, "1pp", dsTeste);
                    CarregaItem(i, "2tb", dsTeste);
                    CarregaItem(i, "2pp", dsTeste);
                    CarregaItem(i, "p1c", dsTeste);
                    CarregaItem(i, "cso", dsTeste);
                    CarregaItem(i, "esp", dsTeste);
                    CarregaItem(i, "tol", dsTeste);
                    CarregaItem(i, "p2d", dsTeste);
                    CarregaItem(i, "p3d", dsTeste);
                    CarregaItem(i, "p4u", dsTeste);
                    CarregaItem(i, "mol", dsTeste);
                    CarregaItem(i, "tpd", dsTeste);
                    CarregaItem(i, "tt1", dsTeste);
                    CarregaItem(i, "tt2", dsTeste);
                    CarregaItem(i, "tt3", dsTeste);
                    CarregaItem(i, "t21", dsTeste);
                    CarregaItem(i, "tun", dsTeste);
                    CarregaItem(i, "tcv", dsTeste);
                    CarregaItem(i, "tss", dsTeste);
                    CarregaItem(i, "tit", dsTeste);
                    CarregaItem(i, "tnc", dsTeste);
                    CarregaItem(i, "aon", dsTeste);
                    CarregaItem(i, "enm", dsTeste);
                    CarregaItem(i, "eee", dsTeste);
                    CarregaItem(i, "kkk", dsTeste);
                    CarregaItem(i, "bbb", dsTeste);
                    CarregaItem(i, "ole", dsTeste);
                    CarregaItem(i, "trq", dsTeste);
                    CarregaItem(i, "ert", dsTeste);
                    CarregaItem(i, "rt3", dsTeste);
                    CarregaItem(i, "rt5", dsTeste);
                    CarregaItem(i, "dnd", dsTeste);
                    CarregaItem(i, "dmo", dsTeste);
                    CarregaItem(i, "pes", dsTeste);
                    CarregaItem(i, "vrr", dsTeste);
                    CarregaItem(i, "tre", dsTeste);
                    CarregaItem(i, "lme", dsTeste, "0.0");
                    CarregaItem(i, "ume", dsTeste, "0.0");
                    CarregaItem(i, "lpe", dsTeste, "0.0");
                    CarregaItem(i, "upe", dsTeste, "0.0");
                    CarregaItem(i, "ucv", dsTeste, "0.0");
                    CarregaItem(i, "lcv", dsTeste, "0.0");
                    CarregaItem(i, "dur", dsTeste, "0.0");
                    CarregaItem(i, "dft", dsTeste, "0.0");
                    CarregaItem(i, "lmc", dsTeste, "0.0");
                    CarregaItem(i, "umc", dsTeste, "0.0");
                    CarregaItem(i, "lpc", dsTeste, "0.0");
                    CarregaItem(i, "upc", dsTeste, "0.0");
                    CarregaItem(i, "cvc", dsTeste, "0.0");
                    CarregaItem(i, "lvc", dsTeste, "0.0");
                    CarregaItem(i, "dfc", dsTeste, "0.0");
                    CarregaItem(i, "tfs", dsTeste, "0.0");
                    CarregaItem(i, "fsw", dsTeste, "0.0");
                    CarregaItem(i, "wfw", dsTeste, "0.0");
                    CarregaItem(i, "ybt", dsTeste, "0.0");
                    CarregaItem(i, "eco", dsTeste, "0.0");
                    CarregaItem(i, "mol", dsTeste);
                    CarregaItem(i, "tgr", dsTeste);
                    CarregaItem(i, "eol", dsTeste);
                    CarregaItem(i, "etu", dsTeste);
                    CarregaItem(i, "etd", dsTeste);
                    CarregaItem(i, "ecu", dsTeste);
                    CarregaItem(i, "egd", dsTeste);
                    CarregaItem(i, "eec", dsTeste);
                    CarregaItem(i, "ecd", dsTeste);
                    CarregaItem(i, "egu", dsTeste);
                    CarregaItem(i, "eso", dsTeste);
                    CarregaItem(i, "esi", dsTeste);
                    CarregaItem(i, "ecr", dsTeste);
                    CarregaItem(i, "eod", dsTeste);
                    CarregaItem(i, "eaw", dsTeste);
                    CarregaItem(i, "ed1", dsTeste);
                    CarregaItem(i, "ed2", dsTeste);
                    CarregaItemCombo(i, "idd", dsTeste);
                    CarregaItem(i, "pco", dsTeste);
                    CarregaItem(i, "pcv", dsTeste);
                    CarregaItem(i, "drt", dsTeste);
                    CarregaItem(i, "tal", dsTeste);
                    CarregaItem(i, "val", dsTeste);
                    CarregaItem(i, "sje", dsTeste);
                    CarregaItem(i, "eta", dsTeste);
                    CarregaItem(i, "eth", dsTeste);
                    CarregaItem(i, "etg", dsTeste);
                    CarregaItem(i, "edt", dsTeste);
                    CarregaItem(i, "efp", dsTeste);
                    CarregaItem(i, "eyt", dsTeste);
                    CarregaItem(i, "edl", dsTeste);
                    CarregaItem(i, "eab", dsTeste);
                    CarregaItem(i, "eca", dsTeste);
                    CarregaItem(i, "ecw", dsTeste);
                    CarregaItem(i, "etl", dsTeste);
                    CarregaItem(i, "ett", dsTeste);
                    CarregaItem(i, "ere", dsTeste);
                    CarregaItem(i, "ele", dsTeste);
                    CarregaItem(i, "ept", dsTeste);
                    CarregaItem(i, "epl", dsTeste);
                    CarregaItemCombo(i, "ctx", dsTeste);
                    CarregaItemCombo(i, "cvx", dsTeste);
                    CarregaItemCombo(i, "cvr", dsTeste);
                    // TMT
                    CarregaItem(i, "hot", dsTeste);
                    CarregaItem(i, "vrd", dsTeste);
                    CarregaItem(i, "acr", dsTeste);
                    CarregaItem(i, "pen", dsTeste);
                    CarregaItem(i, "cra", dsTeste);
                    CarregaItem(i, "cle", dsTeste);
                    CarregaItem(i, "afo", dsTeste);
                    CarregaItemCombo(i, "tcu", dsTeste);
                    CarregaItem(i, "tar", dsTeste);
                    CarregaItemCombo(i, "tam", dsTeste);
                    CarregaItem(i, "dtu", dsTeste);
                    CarregaItem(i, "dpa", dsTeste);
                    CarregaItem(i, "cin", dsTeste);
                    CarregaItemCombo(i, "tip_fr2", dsTeste);
                    CarregaItem(i, "fr2", dsTeste);
                    CarregaItemCombo(i, "tip_fr1", dsTeste);
                    CarregaItem(i, "fr1", dsTeste);
                    CarregaItemCombo(i, "tip_fr0", dsTeste);
                    CarregaItem(i, "fr0", dsTeste);
                    CarregaItem(i, "ato", dsTeste);
                    CarregaItem(i, "tp1", dsTeste);
                    CarregaItem(i, "tp2", dsTeste);
                    CarregaItem(i, "tcp", dsTeste);
                    CarregaItem(i, "jf2", dsTeste);
                    CarregaItem(i, "ps2", dsTeste);
                    CarregaItem(i, "jf0", dsTeste);
                    CarregaItem(i, "ps0", dsTeste);
                    CarregaItem(i, "bba", dsTeste);
                    CarregaItem(i, "gro", dsTeste);
                    CarregaItem(i, "tcs", dsTeste);
                    CarregaItem(i, "cvp", dsTeste);
                    CarregaItem(i, "ssv", dsTeste);
                    CarregaItem(i, "ssp", dsTeste);
                    CarregaItem(i, "tte_001", dsTeste);
                    CarregaItem(i, "tte_002", dsTeste);
                    CarregaItemCombo(i, "wpo_001", dsTeste);
                    CarregaItemCombo(i, "wpo_002", dsTeste);
                    CarregaItem(i, "dir_001", dsTeste);
                    CarregaItem(i, "dir_002", dsTeste);
                    CarregaItem(i, "cra_001", dsTeste);
                    CarregaItem(i, "cra_002", dsTeste);
                    CarregaItemCombo(i, "ced_001", dsTeste);
                    CarregaItemCombo(i, "ced_002", dsTeste);
                    CarregaItem(i, "ted_001", dsTeste);
                    CarregaItem(i, "ted_002", dsTeste);
                    CarregaItem(i, "dle_001", dsTeste);
                    CarregaItem(i, "dle_002", dsTeste);
                    CarregaItem(i, "cti_001", dsTeste);
                    CarregaItem(i, "cti_002", dsTeste);
                    CarregaItem(i, "g1o_001", dsTeste);
                    CarregaItem(i, "g1o_002", dsTeste);
                    CarregaItem(i, "g1u_001", dsTeste);
                    CarregaItem(i, "g1u_002", dsTeste);
                    CarregaItem(i, "g2o_001", dsTeste);
                    CarregaItem(i, "g2o_002", dsTeste);
                    CarregaItem(i, "g2u_001", dsTeste);
                    CarregaItem(i, "g2u_002", dsTeste);
                    CarregaItem(i, "cvp_001", dsTeste);
                    CarregaItem(i, "cvp_002", dsTeste);
                    CarregaItem(i, "ocu_001", dsTeste);
                    CarregaItem(i, "ocu_002", dsTeste);
                    CarregaItem(i, "ucu_001", dsTeste);
                    CarregaItem(i, "ucu_002", dsTeste);
                    CarregaItem(i, "c1o_001", dsTeste);
                    CarregaItem(i, "c1o_002", dsTeste);
                    CarregaItem(i, "l1o_001", dsTeste);
                    CarregaItem(i, "l1o_002", dsTeste);
                    CarregaItem(i, "c1u_001", dsTeste);
                    CarregaItem(i, "c1u_002", dsTeste);
                    CarregaItem(i, "l1u_001", dsTeste);
                    CarregaItem(i, "l1u_002", dsTeste);
                    CarregaItem(i, "c2o_001", dsTeste);
                    CarregaItem(i, "c2o_002", dsTeste);
                    CarregaItem(i, "l2o_001", dsTeste);
                    CarregaItem(i, "l2o_002", dsTeste);
                    CarregaItem(i, "c2u_001", dsTeste);
                    CarregaItem(i, "c2u_002", dsTeste);
                    CarregaItem(i, "l2u_001", dsTeste);
                    CarregaItem(i, "l2u_002", dsTeste);
                    CarregaItem(i, "tsu_001", dsTeste);
                    CarregaItem(i, "tsu_002", dsTeste);
                    CarregaItem(i, "cvc_001", dsTeste);
                    CarregaItem(i, "cvc_002", dsTeste);
                    CarregaItem(i, "cvl_001", dsTeste);
                    CarregaItem(i, "cvl_002", dsTeste);
                    CarregaItem(i, "tle_001", dsTeste);
                    CarregaItem(i, "tle_002", dsTeste);
                    CarregaItemCombo(i, "roi", dsTeste);
                    CarregaItemCombo(i, "rr0", dsTeste);
                    CarregaItemCombo(i, "r01", dsTeste);
                    CarregaItemCombo(i, "rr1", dsTeste);
                    CarregaItemCombo(i, "rr2", dsTeste);
                    CarregaItemCombo(i, "r2a", dsTeste);
                    CarregaItemCombo(i, "rr3", dsTeste);
                    CarregaItemCombo(i, "rwr", dsTeste);
                    CarregaItem(i, "std", dsTeste);
                    CarregaItem(i, "stp", dsTeste);
                    CarregaItem(i, "ttd", dsTeste);
                    CarregaItem(i, "ttp", dsTeste);
                    CarregaItem(i, "ftd", dsTeste);
                    CarregaItem(i, "ftp", dsTeste);
                    CarregaItem(i, "itd", dsTeste);
                    CarregaItem(i, "itp", dsTeste);
                    CarregaItem(i, "xtd", dsTeste);
                    CarregaItem(i, "xtp", dsTeste);
                    CarregaItem(i, "ttr", dsTeste);
                }

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
        txt_mge_004_inc.Text = "";
        txt_mge_ref_inc.Text = "";
        txt_mge_002_ref_inc.Text = "";
        txt_mge_003_ref_inc.Text = "";
        txt_mge_004_ref_inc.Text = "";
        cbo_for_001_id_inc.SelectedIndex = 0;
        cbo_for_002_id_inc.SelectedIndex = 0;
        cbo_for_003_id_inc.SelectedIndex = 0;
        cbo_for_004_id_inc.SelectedIndex = 0;
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
        txt_lcv_ref_inc.Text = "";
        txt_dur_ref_inc.Text = "";
        txt_dft_ref_inc.Text = "";
        txt_lmc_ref_inc.Text = "";
        txt_umc_ref_inc.Text = "";
        txt_lpc_ref_inc.Text = "";
        txt_upc_ref_inc.Text = "";
        txt_cvc_ref_inc.Text = "";
        txt_lvc_ref_inc.Text = "";
        txt_dfc_ref_inc.Text = "";
        txt_tfs_ref_inc.Text = "";
        txt_fsw_ref_inc.Text = "";
        txt_wfw_ref_inc.Text = "";
        txt_ybt_ref_inc.Text = "";
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
        cbo_idd_ref_inc.Text = "";

        txt_eta_ref_inc.Text = "";
        txt_eth_ref_inc.Text = "";
        txt_etg_ref_inc.Text = "";
        txt_edt_ref_inc.Text = "";
        txt_efp_ref_inc.Text = "";
        txt_eyt_ref_inc.Text = "";
        txt_edl_ref_inc.Text = "";
        txt_eab_ref_inc.Text = "";
        txt_eca_ref_inc.Text = "";
        txt_ecw_ref_inc.Text = "";
        txt_etl_ref_inc.Text = "";
        txt_ett_ref_inc.Text = "";
        txt_ere_ref_inc.Text = "";
        txt_ele_ref_inc.Text = "";
        txt_ept_ref_inc.Text = "";
        txt_epl_ref_inc.Text = "";
        cbo_ez1_ez2_ref_inc.Text = "";
        cbo_ez3_ez4_ref_inc.Text = "";
        cbo_ez5_ez6_ref_inc.Text = "";

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
        txt_lcv_001_inc.Text = "";
        txt_dur_001_inc.Text = "";
        txt_dft_001_inc.Text = "";
        txt_lmc_001_inc.Text = "";
        txt_umc_001_inc.Text = "";
        txt_lpc_001_inc.Text = "";
        txt_upc_001_inc.Text = "";
        txt_cvc_001_inc.Text = "";
        txt_lvc_001_inc.Text = "";
        txt_dfc_001_inc.Text = "";
        txt_tfs_001_inc.Text = "";
        txt_fsw_001_inc.Text = "";
        txt_wfw_001_inc.Text = "";
        txt_ybt_001_inc.Text = "";
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
        cbo_idd_001_inc.Text = "";

        txt_eta_001_inc.Text = "";
        txt_eth_001_inc.Text = "";
        txt_etg_001_inc.Text = "";
        txt_edt_001_inc.Text = "";
        txt_efp_001_inc.Text = "";
        txt_eyt_001_inc.Text = "";
        txt_edl_001_inc.Text = "";
        txt_eab_001_inc.Text = "";
        txt_eca_001_inc.Text = "";
        txt_ecw_001_inc.Text = "";
        txt_etl_001_inc.Text = "";
        txt_ett_001_inc.Text = "";
        txt_ere_001_inc.Text = "";
        txt_ele_001_inc.Text = "";
        txt_ept_001_inc.Text = "";
        txt_epl_001_inc.Text = "";
        cbo_ez1_ez2_001_inc.Text = "";
        cbo_ez3_ez4_001_inc.Text = "";
        cbo_ez5_ez6_001_inc.Text = "";

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
        txt_lcv_002_inc.Text = "";
        txt_dur_002_inc.Text = "";
        txt_dft_002_inc.Text = "";
        txt_lmc_002_inc.Text = "";
        txt_umc_002_inc.Text = "";
        txt_lpc_002_inc.Text = "";
        txt_upc_002_inc.Text = "";
        txt_cvc_002_inc.Text = "";
        txt_lvc_002_inc.Text = "";
        txt_dfc_002_inc.Text = "";
        txt_tfs_002_inc.Text = "";
        txt_fsw_002_inc.Text = "";
        txt_wfw_002_inc.Text = "";
        txt_ybt_002_inc.Text = "";
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
        cbo_idd_002_inc.Text = "";

        txt_eta_002_inc.Text = "";
        txt_eth_002_inc.Text = "";
        txt_etg_002_inc.Text = "";
        txt_edt_002_inc.Text = "";
        txt_efp_002_inc.Text = "";
        txt_eyt_002_inc.Text = "";
        txt_edl_002_inc.Text = "";
        txt_eab_002_inc.Text = "";
        txt_eca_002_inc.Text = "";
        txt_ecw_002_inc.Text = "";
        txt_etl_002_inc.Text = "";
        txt_ett_002_inc.Text = "";
        txt_ere_002_inc.Text = "";
        txt_ele_002_inc.Text = "";
        txt_ept_002_inc.Text = "";
        txt_epl_002_inc.Text = "";
        cbo_ez1_ez2_002_inc.Text = "";
        cbo_ez3_ez4_002_inc.Text = "";
        cbo_ez5_ez6_002_inc.Text = "";

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
        txt_lcv_003_inc.Text = "";
        txt_dur_003_inc.Text = "";
        txt_dft_003_inc.Text = "";
        txt_lmc_003_inc.Text = "";
        txt_umc_003_inc.Text = "";
        txt_lpc_003_inc.Text = "";
        txt_upc_003_inc.Text = "";
        txt_cvc_003_inc.Text = "";
        txt_lvc_003_inc.Text = "";
        txt_dfc_003_inc.Text = "";
        txt_tfs_003_inc.Text = "";
        txt_fsw_003_inc.Text = "";
        txt_wfw_003_inc.Text = "";
        txt_ybt_003_inc.Text = "";
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
        cbo_idd_003_inc.Text = "";

        txt_eta_003_inc.Text = "";
        txt_eth_003_inc.Text = "";
        txt_etg_003_inc.Text = "";
        txt_edt_003_inc.Text = "";
        txt_efp_003_inc.Text = "";
        txt_eyt_003_inc.Text = "";
        txt_edl_003_inc.Text = "";
        txt_eab_003_inc.Text = "";
        txt_eca_003_inc.Text = "";
        txt_ecw_003_inc.Text = "";
        txt_etl_003_inc.Text = "";
        txt_ett_003_inc.Text = "";
        txt_ere_003_inc.Text = "";
        txt_ele_003_inc.Text = "";
        txt_ept_003_inc.Text = "";
        txt_epl_003_inc.Text = "";
        cbo_ez1_ez2_003_inc.Text = "";
        cbo_ez3_ez4_003_inc.Text = "";
        cbo_ez5_ez6_003_inc.Text = "";

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
        txt_lcv_004_inc.Text = "";
        txt_dur_004_inc.Text = "";
        txt_dft_004_inc.Text = "";
        txt_lmc_004_inc.Text = "";
        txt_umc_004_inc.Text = "";
        txt_lpc_004_inc.Text = "";
        txt_upc_004_inc.Text = "";
        txt_cvc_004_inc.Text = "";
        txt_lvc_004_inc.Text = "";
        txt_dfc_004_inc.Text = "";
        txt_tfs_004_inc.Text = "";
        txt_fsw_004_inc.Text = "";
        txt_wfw_004_inc.Text = "";
        txt_ybt_004_inc.Text = "";
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
        cbo_idd_004_inc.Text = "";

        txt_eta_004_inc.Text = "";
        txt_eth_004_inc.Text = "";
        txt_etg_004_inc.Text = "";
        txt_edt_004_inc.Text = "";
        txt_efp_004_inc.Text = "";
        txt_eyt_004_inc.Text = "";
        txt_edl_004_inc.Text = "";
        txt_eab_004_inc.Text = "";
        txt_eca_004_inc.Text = "";
        txt_ecw_004_inc.Text = "";
        txt_etl_004_inc.Text = "";
        txt_ett_004_inc.Text = "";
        txt_ere_004_inc.Text = "";
        txt_ele_004_inc.Text = "";
        txt_ept_004_inc.Text = "";
        txt_epl_004_inc.Text = "";
        cbo_ez1_ez2_004_inc.Text = "";
        cbo_ez3_ez4_004_inc.Text = "";
        cbo_ez5_ez6_004_inc.Text = "";

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
        txt_lcv_005_inc.Text = "";
        txt_dur_005_inc.Text = "";
        txt_dft_005_inc.Text = "";
        txt_lmc_005_inc.Text = "";
        txt_umc_005_inc.Text = "";
        txt_lpc_005_inc.Text = "";
        txt_upc_005_inc.Text = "";
        txt_cvc_005_inc.Text = "";
        txt_lvc_005_inc.Text = "";
        txt_dfc_005_inc.Text = "";
        txt_tfs_005_inc.Text = "";
        txt_fsw_005_inc.Text = "";
        txt_wfw_005_inc.Text = "";
        txt_ybt_005_inc.Text = "";
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
        cbo_idd_005_inc.Text = "";

        txt_eta_005_inc.Text = "";
        txt_eth_005_inc.Text = "";
        txt_etg_005_inc.Text = "";
        txt_edt_005_inc.Text = "";
        txt_efp_005_inc.Text = "";
        txt_eyt_005_inc.Text = "";
        txt_edl_005_inc.Text = "";
        txt_eab_005_inc.Text = "";
        txt_eca_005_inc.Text = "";
        txt_ecw_005_inc.Text = "";
        txt_etl_005_inc.Text = "";
        txt_ett_005_inc.Text = "";
        txt_ere_005_inc.Text = "";
        txt_ele_005_inc.Text = "";
        txt_ept_005_inc.Text = "";
        txt_epl_005_inc.Text = "";
        cbo_ez1_ez2_005_inc.Text = "";
        cbo_ez3_ez4_005_inc.Text = "";
        cbo_ez5_ez6_005_inc.Text = "";

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
        txt_lcv_006_inc.Text = "";
        txt_dur_006_inc.Text = "";
        txt_dft_006_inc.Text = "";
        txt_lmc_006_inc.Text = "";
        txt_umc_006_inc.Text = "";
        txt_lpc_006_inc.Text = "";
        txt_upc_006_inc.Text = "";
        txt_cvc_006_inc.Text = "";
        txt_lvc_006_inc.Text = "";
        txt_dfc_006_inc.Text = "";
        txt_tfs_006_inc.Text = "";
        txt_fsw_006_inc.Text = "";
        txt_wfw_006_inc.Text = "";
        txt_ybt_006_inc.Text = "";
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
        cbo_idd_006_inc.Text = "";

        txt_eta_006_inc.Text = "";
        txt_eth_006_inc.Text = "";
        txt_etg_006_inc.Text = "";
        txt_edt_006_inc.Text = "";
        txt_efp_006_inc.Text = "";
        txt_eyt_006_inc.Text = "";
        txt_edl_006_inc.Text = "";
        txt_eab_006_inc.Text = "";
        txt_eca_006_inc.Text = "";
        txt_ecw_006_inc.Text = "";
        txt_etl_006_inc.Text = "";
        txt_ett_006_inc.Text = "";
        txt_ere_006_inc.Text = "";
        txt_ele_006_inc.Text = "";
        txt_ept_006_inc.Text = "";
        txt_epl_006_inc.Text = "";
        cbo_ez1_ez2_006_inc.Text = "";
        cbo_ez3_ez4_006_inc.Text = "";
        cbo_ez5_ez6_006_inc.Text = "";

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
        txt_lcv_007_inc.Text = "";
        txt_dur_007_inc.Text = "";
        txt_dft_007_inc.Text = "";
        txt_lmc_007_inc.Text = "";
        txt_umc_007_inc.Text = "";
        txt_lpc_007_inc.Text = "";
        txt_upc_007_inc.Text = "";
        txt_cvc_007_inc.Text = "";
        txt_lvc_007_inc.Text = "";
        txt_dfc_007_inc.Text = "";
        txt_tfs_007_inc.Text = "";
        txt_fsw_007_inc.Text = "";
        txt_wfw_007_inc.Text = "";
        txt_ybt_007_inc.Text = "";
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
        cbo_idd_007_inc.Text = "";

        txt_eta_007_inc.Text = "";
        txt_eth_007_inc.Text = "";
        txt_etg_007_inc.Text = "";
        txt_edt_007_inc.Text = "";
        txt_efp_007_inc.Text = "";
        txt_eyt_007_inc.Text = "";
        txt_edl_007_inc.Text = "";
        txt_eab_007_inc.Text = "";
        txt_eca_007_inc.Text = "";
        txt_ecw_007_inc.Text = "";
        txt_etl_007_inc.Text = "";
        txt_ett_007_inc.Text = "";
        txt_ere_007_inc.Text = "";
        txt_ele_007_inc.Text = "";
        txt_ept_007_inc.Text = "";
        txt_epl_007_inc.Text = "";
        cbo_ez1_ez2_007_inc.Text = "";
        cbo_ez3_ez4_007_inc.Text = "";
        cbo_ez5_ez6_007_inc.Text = "";

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
        rowId.Value = null;
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
            Teste.TST_DAT_INI_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Início= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Teste.TST_DAT_FIM_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Fim= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Teste.TST_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }

        //Trazer somente a Sequencia 0 (Referência) não é necessário trazer as demais ocorrências SEQ 1 a 7.
        Teste.TST_SEQ = 0;

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

        //Primeira REF TST_TST_ID é nullo depois será o do primeiro insert
        int? iTST_TST_ID = null;
        //Carrega a Referência e as 7 ocorrências de teste
        for (int i = 0; i <= 7; i++)
        {
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
            if (txt_mge_004_inc.Text != "")
            {
                Teste.TST_MGE_004 = txt_mge_004_inc.Text;
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
            if (txt_mge_004_ref_inc.Text != "")
            {
                Teste.TST_MGE_004_REF = txt_mge_004_ref_inc.Text;
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
            if (cbo_for_004_id_inc.Text != "")
            {
                Teste.TST_FOR_004_ID = Convert.ToInt32(cbo_for_004_id_inc.SelectedValue);
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

            //Primeira Ocorrência (Referência) o TST_TST_ID é Nulo
            Teste.TST_TST_ID = iTST_TST_ID;
            Teste.TST_SEQ = i;

            //Popula Teste com as ocorrências
            SalvaItem(i, Teste);

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
                sMsg = Teste.AlterarSequencia();

                if (sMsg != "")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                    return;
                }
                else
                {
                    //Se for a inclusão do REF Armazena ID da inclusão do TST_SEQ = 0 para vinculo nos demais
                    iTST_TST_ID = Teste.TST_ID;
                }
            }
            else
            {
                Teste.TST_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
                sMsg = Teste.Inserir();

                if (sMsg.Substring(0, 1) == "E")
                {
                    Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
                    return;
                }
                else
                {
                    //Se for a inclusão do REF Armazena ID da inclusão do TST_SEQ = 0 para vinculo nos demais
                    if (i == 0)
                    {
                        iTST_TST_ID = Convert.ToInt32(sMsg);
                    }
                }
            }
            //Response.Write(Teste.SQL);
        }



        if (!string.IsNullOrEmpty(rowId.Value))
        {
            TratamentoErro("Teste alterado com sucesso.");
        }
        else
        {
            TratamentoErro("Teste inserido com sucesso.");
            if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
                ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
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
                txt_mge_004_inc.Text = dsRTS.Tables[0].Rows[0]["RTS_MGE_004"].ToString();
                cbo_for_001_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_001_ID"].ToString();
                cbo_for_002_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_002_ID"].ToString();
                cbo_for_003_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_003_ID"].ToString();
                cbo_for_004_id_inc.SelectedValue = dsRTS.Tables[0].Rows[0]["RTS_FOR_004_ID"].ToString();
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
                txt_mge_004_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_MGE_004"].ToString();
            }
            else
            {
                txt_mge_ref_inc.Text = "";
                txt_mge_002_ref_inc.Text = "";
                txt_mge_003_ref_inc.Text = "";
                txt_mge_004_ref_inc.Text = "";
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
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()))
                {
                    txt_lcv_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LCV"].ToString()).ToString("0.0");
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
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()))
                {
                    txt_lvc_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_LVC"].ToString()).ToString("0.0");
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
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()))
                {
                    txt_ybt_ref_inc.Text = Convert.ToDouble(dsStandard.Tables[0].Rows[0]["EPF_YBT"].ToString()).ToString("0.0");
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
                cbo_idd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_IDD"].ToString();

                txt_eta_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETA"].ToString();
                txt_eth_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETH"].ToString();
                txt_etg_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETG"].ToString();
                txt_edt_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDT"].ToString();
                txt_efp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EFP"].ToString();
                txt_eyt_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EYT"].ToString();
                txt_edl_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EDL"].ToString();
                txt_eab_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EAB"].ToString();
                txt_eca_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECA"].ToString();
                txt_ecw_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ECW"].ToString();
                txt_etl_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETL"].ToString();
                txt_ett_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ETT"].ToString();
                txt_ere_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ERE"].ToString();
                txt_ele_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ELE"].ToString();
                txt_ept_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPT"].ToString();
                txt_epl_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_EPL"].ToString();

                txt_pco_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCO"].ToString();
                txt_pcv_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PCV"].ToString();
                txt_drt_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DRT"].ToString();
                txt_tal_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAL"].ToString();
                txt_val_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VAL"].ToString();
                txt_sje_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SJE"].ToString();

                //TMT
                txt_hot_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_HOT"].ToString();
                txt_vrd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_VRD"].ToString();
                txt_acr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ACR"].ToString();
                txt_pen_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PEN"].ToString();
                txt_cra_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA"].ToString();
                txt_cle_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CLE"].ToString();
                txt_afo_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_AFO"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString()))
                {
                    cbo_tcu_ref_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TCU"].ToString();
                }
                txt_tar_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TAR"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString()))
                {
                    cbo_tam_ref_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TAM"].ToString();
                }
                txt_std_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STD"].ToString();
                txt_stp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_STP"].ToString();
                txt_ttd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTD"].ToString();
                txt_ttp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTP"].ToString();
                txt_ftd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTD"].ToString();
                txt_ftp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FTP"].ToString();
                txt_itd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITD"].ToString();
                txt_itp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ITP"].ToString();
                txt_xtd_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTD"].ToString();
                txt_xtp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_XTP"].ToString();
                txt_ttr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTR"].ToString();
                txt_dtu_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DTU"].ToString();
                txt_dpa_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DPA"].ToString();
                txt_cin_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CIN"].ToString();
                cbo_tip_fr2_ref_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR2"].ToString();
                txt_fr2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR2"].ToString();
                cbo_tip_fr1_ref_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR1"].ToString();
                txt_fr1_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR1"].ToString();
                cbo_tip_fr0_ref_inc.SelectedValue = dsStandard.Tables[0].Rows[0]["EPF_TIP_FR0"].ToString();
                txt_fr0_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_FR0"].ToString();
                txt_ato_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ATO"].ToString();
                txt_tp1_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP1"].ToString();
                txt_tp2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TP2"].ToString();
                txt_tcp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCP"].ToString();
                txt_jf2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF2"].ToString();
                txt_ps2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS2"].ToString();
                txt_jf0_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_JF0"].ToString();
                txt_ps0_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_PS0"].ToString();
                txt_bba_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_BBA"].ToString();
                txt_gro_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_GRO"].ToString();
                txt_tcs_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TCS"].ToString();
                txt_cvp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP"].ToString();
                txt_ssv_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSV"].ToString();
                txt_ssp_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_SSP"].ToString();
                txt_tte_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_001"].ToString();
                txt_tte_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TTE_002"].ToString();
                cbo_wpo_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_001"].ToString();
                cbo_wpo_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_WPO_002"].ToString();
                txt_dir_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_001"].ToString();
                txt_dir_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DIR_002"].ToString();
                txt_cra_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_001"].ToString();
                txt_cra_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CRA_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString()))
                {
                    cbo_ced_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_001"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString()))
                {
                    cbo_ced_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CED_002"].ToString();
                }
                txt_ted_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_001"].ToString();
                txt_ted_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TED_002"].ToString();
                txt_dle_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_001"].ToString();
                txt_dle_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_DLE_002"].ToString();
                txt_cti_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_001"].ToString();
                txt_cti_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CTI_002"].ToString();
                txt_g1o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_001"].ToString();
                txt_g1o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1O_002"].ToString();
                txt_g1u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_001"].ToString();
                txt_g1u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G1U_002"].ToString();
                txt_g2o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_001"].ToString();
                txt_g2o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2O_002"].ToString();
                txt_g2u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_001"].ToString();
                txt_g2u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_G2U_002"].ToString();
                txt_cvp_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_001"].ToString();
                txt_cvp_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVP_002"].ToString();
                txt_ocu_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_001"].ToString();
                txt_ocu_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_OCU_002"].ToString();
                txt_ucu_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_001"].ToString();
                txt_ucu_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_UCU_002"].ToString();
                txt_c1o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_001"].ToString();
                txt_c1o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1O_002"].ToString();
                txt_l1o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_001"].ToString();
                txt_l1o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1O_002"].ToString();
                txt_c1u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_001"].ToString();
                txt_c1u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C1U_002"].ToString();
                txt_l1u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_001"].ToString();
                txt_l1u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L1U_002"].ToString();
                txt_c2o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_001"].ToString();
                txt_c2o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2O_002"].ToString();
                txt_l2o_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_001"].ToString();
                txt_l2o_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2O_002"].ToString();
                txt_c2u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_001"].ToString();
                txt_c2u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_C2U_002"].ToString();
                txt_l2u_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_001"].ToString();
                txt_l2u_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_L2U_002"].ToString();
                txt_tsu_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_001"].ToString();
                txt_tsu_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TSU_002"].ToString();
                txt_cvc_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_001"].ToString();
                txt_cvc_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVC_002"].ToString();
                txt_cvl_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_001"].ToString();
                txt_cvl_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_CVL_002"].ToString();
                txt_tle_001_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_001"].ToString();
                txt_tle_002_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_TLE_002"].ToString();
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString()))
                {
                    cbo_roi_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_ROI"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString()))
                {
                    cbo_rr0_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR0"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString()))
                {
                    cbo_r01_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R01"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString()))
                {
                    cbo_rr1_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR1"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString()))
                {
                    cbo_rr2_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR2"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString()))
                {
                    cbo_r2a_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_R2A"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString()))
                {
                    cbo_rr3_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RR3"].ToString();
                }
                if (!string.IsNullOrEmpty(dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString()))
                {
                    cbo_rwr_ref_inc.Text = dsStandard.Tables[0].Rows[0]["EPF_RWR"].ToString();
                }
                
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


            if (cbo_maq_tip_id_inc.SelectedItem.Text == "TMT")
            {
                lbl_edy.Text = "Relação VR(B/Y)";
                lbl_ewx.Text = "Overfeed do Jet(OF2A)";
                lbl_ew3.Text = "2º Overfeed(OF2)";
                lbl_ew4.Text = "3º Overfeed(OF3)";
                lbl_vw2.Text = "Velocidade YS";

                /*
                pnl_ope.Visible = false;
                pnl_epu.Visible = false;
                pnl_reg.Visible = false;
                pnl_dad.Visible = false;
                pnl_eng_pol.Visible = false;
                pnl_reg_enc.Visible = false;
                pnl_reg_bar.Visible = false;
                pnl_reg_uni.Visible = false;
                pnl_dof.Visible = false;
                */
                pnl_tup.Visible = false;
                /*
                pnl_t1e.Visible = false;
                pnl_drt.Visible = false;
                pnl_ten.Visible = false;
                */

                //pnl_tmt_poy.Visible = true;
                pnl_tmt_ope.Visible = true;
                pnl_tmt_reg.Visible = true;
                //pnl_tmt_ten.Visible = true;
                pnl_tmt_tcs.Visible = true;
                pnl_tmt_ten.Visible = true;
                pnl_tmt_rol.Visible = true;
            }
            else
            {
                lbl_edy.Text = "D/Y";
                lbl_ewx.Text = "2nd Overfeed  - WX(%)";
                lbl_ew3.Text = "3nd Overfeed  - W3(%)";
                lbl_ew4.Text = "4nd Overfeed  - W4(%)";
                lbl_vw2.Text = "Velocidade W2(m/min)";

                /*
                pnl_ope.Visible = true;
                pnl_epu.Visible = true;
                pnl_reg.Visible = true;
                pnl_dad.Visible = true;
                pnl_eng_pol.Visible = true;
                pnl_reg_enc.Visible = true;
                pnl_reg_bar.Visible = true;
                pnl_reg_uni.Visible = true;
                pnl_dof.Visible = true;
                */
                pnl_tup.Visible = true;
                /*
                pnl_t1e.Visible = true;
                pnl_drt.Visible = true;
                pnl_ten.Visible = true;
                */

                //pnl_tmt_poy.Visible = false;
                pnl_tmt_ope.Visible = false;
                pnl_tmt_reg.Visible = false;
                //pnl_tmt_ten.Visible = false;
                pnl_tmt_tcs.Visible = false;
                pnl_tmt_ten.Visible = false;
                pnl_tmt_rol.Visible = false;
            }

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
        Standard.EPF_MGE_004 = txt_mge_004_inc.Text;
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
        string sLCV = !string.IsNullOrEmpty(txt_lcv_007_inc.Text) ? txt_lcv_007_inc.Text : !string.IsNullOrEmpty(txt_lcv_006_inc.Text) ? txt_lcv_006_inc.Text : !string.IsNullOrEmpty(txt_lcv_005_inc.Text) ? txt_lcv_005_inc.Text : !string.IsNullOrEmpty(txt_lcv_004_inc.Text) ? txt_lcv_004_inc.Text : !string.IsNullOrEmpty(txt_lcv_003_inc.Text) ? txt_lcv_003_inc.Text : !string.IsNullOrEmpty(txt_lcv_002_inc.Text) ? txt_lcv_002_inc.Text : !string.IsNullOrEmpty(txt_lcv_001_inc.Text) ? txt_lcv_001_inc.Text : txt_lcv_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLCV))
        {
            Standard.EPF_LCV = Convert.ToDouble(sLCV);
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
        string sLVC = !string.IsNullOrEmpty(txt_lvc_007_inc.Text) ? txt_lvc_007_inc.Text : !string.IsNullOrEmpty(txt_lvc_006_inc.Text) ? txt_lvc_006_inc.Text : !string.IsNullOrEmpty(txt_lvc_005_inc.Text) ? txt_lvc_005_inc.Text : !string.IsNullOrEmpty(txt_lvc_004_inc.Text) ? txt_lvc_004_inc.Text : !string.IsNullOrEmpty(txt_lvc_003_inc.Text) ? txt_lvc_003_inc.Text : !string.IsNullOrEmpty(txt_lvc_002_inc.Text) ? txt_lvc_002_inc.Text : !string.IsNullOrEmpty(txt_lvc_001_inc.Text) ? txt_lvc_001_inc.Text : txt_lvc_ref_inc.Text;
        if (!string.IsNullOrEmpty(sLVC))
        {
            Standard.EPF_LVC = Convert.ToDouble(sLVC);
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
        string sYBT = !string.IsNullOrEmpty(txt_ybt_007_inc.Text) ? txt_ybt_007_inc.Text : !string.IsNullOrEmpty(txt_ybt_006_inc.Text) ? txt_ybt_006_inc.Text : !string.IsNullOrEmpty(txt_ybt_005_inc.Text) ? txt_ybt_005_inc.Text : !string.IsNullOrEmpty(txt_ybt_004_inc.Text) ? txt_ybt_004_inc.Text : !string.IsNullOrEmpty(txt_ybt_003_inc.Text) ? txt_ybt_003_inc.Text : !string.IsNullOrEmpty(txt_ybt_002_inc.Text) ? txt_ybt_002_inc.Text : !string.IsNullOrEmpty(txt_ybt_001_inc.Text) ? txt_ybt_001_inc.Text : txt_ybt_ref_inc.Text;
        if (!string.IsNullOrEmpty(sYBT))
        {
            Standard.EPF_YBT = Convert.ToDouble(sYBT);
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
        Standard.EPF_IDD = !string.IsNullOrEmpty(cbo_idd_007_inc.Text) ? cbo_idd_007_inc.Text : !string.IsNullOrEmpty(cbo_idd_006_inc.Text) ? cbo_idd_006_inc.Text : !string.IsNullOrEmpty(cbo_idd_005_inc.Text) ? cbo_idd_005_inc.Text : !string.IsNullOrEmpty(cbo_idd_004_inc.Text) ? cbo_idd_004_inc.Text : !string.IsNullOrEmpty(cbo_idd_003_inc.Text) ? cbo_idd_003_inc.Text : !string.IsNullOrEmpty(cbo_idd_002_inc.Text) ? cbo_idd_002_inc.Text : !string.IsNullOrEmpty(cbo_idd_001_inc.Text) ? cbo_idd_001_inc.Text : cbo_idd_ref_inc.Text;

        Standard.EPF_ETA = !string.IsNullOrEmpty(txt_eta_007_inc.Text) ? txt_eta_007_inc.Text : !string.IsNullOrEmpty(txt_eta_006_inc.Text) ? txt_eta_006_inc.Text : !string.IsNullOrEmpty(txt_eta_005_inc.Text) ? txt_eta_005_inc.Text : !string.IsNullOrEmpty(txt_eta_004_inc.Text) ? txt_eta_004_inc.Text : !string.IsNullOrEmpty(txt_eta_003_inc.Text) ? txt_eta_003_inc.Text : !string.IsNullOrEmpty(txt_eta_002_inc.Text) ? txt_eta_002_inc.Text : !string.IsNullOrEmpty(txt_eta_001_inc.Text) ? txt_eta_001_inc.Text : txt_eta_ref_inc.Text;
        Standard.EPF_ETH = !string.IsNullOrEmpty(txt_eth_007_inc.Text) ? txt_eth_007_inc.Text : !string.IsNullOrEmpty(txt_eth_006_inc.Text) ? txt_eth_006_inc.Text : !string.IsNullOrEmpty(txt_eth_005_inc.Text) ? txt_eth_005_inc.Text : !string.IsNullOrEmpty(txt_eth_004_inc.Text) ? txt_eth_004_inc.Text : !string.IsNullOrEmpty(txt_eth_003_inc.Text) ? txt_eth_003_inc.Text : !string.IsNullOrEmpty(txt_eth_002_inc.Text) ? txt_eth_002_inc.Text : !string.IsNullOrEmpty(txt_eth_001_inc.Text) ? txt_eth_001_inc.Text : txt_eth_ref_inc.Text;
        Standard.EPF_ETG = !string.IsNullOrEmpty(txt_etg_007_inc.Text) ? txt_etg_007_inc.Text : !string.IsNullOrEmpty(txt_etg_006_inc.Text) ? txt_etg_006_inc.Text : !string.IsNullOrEmpty(txt_etg_005_inc.Text) ? txt_etg_005_inc.Text : !string.IsNullOrEmpty(txt_etg_004_inc.Text) ? txt_etg_004_inc.Text : !string.IsNullOrEmpty(txt_etg_003_inc.Text) ? txt_etg_003_inc.Text : !string.IsNullOrEmpty(txt_etg_002_inc.Text) ? txt_etg_002_inc.Text : !string.IsNullOrEmpty(txt_etg_001_inc.Text) ? txt_etg_001_inc.Text : txt_etg_ref_inc.Text;
        Standard.EPF_EDT = !string.IsNullOrEmpty(txt_edt_007_inc.Text) ? txt_edt_007_inc.Text : !string.IsNullOrEmpty(txt_edt_006_inc.Text) ? txt_edt_006_inc.Text : !string.IsNullOrEmpty(txt_edt_005_inc.Text) ? txt_edt_005_inc.Text : !string.IsNullOrEmpty(txt_edt_004_inc.Text) ? txt_edt_004_inc.Text : !string.IsNullOrEmpty(txt_edt_003_inc.Text) ? txt_edt_003_inc.Text : !string.IsNullOrEmpty(txt_edt_002_inc.Text) ? txt_edt_002_inc.Text : !string.IsNullOrEmpty(txt_edt_001_inc.Text) ? txt_edt_001_inc.Text : txt_edt_ref_inc.Text;
        Standard.EPF_EFP = !string.IsNullOrEmpty(txt_efp_007_inc.Text) ? txt_efp_007_inc.Text : !string.IsNullOrEmpty(txt_efp_006_inc.Text) ? txt_efp_006_inc.Text : !string.IsNullOrEmpty(txt_efp_005_inc.Text) ? txt_efp_005_inc.Text : !string.IsNullOrEmpty(txt_efp_004_inc.Text) ? txt_efp_004_inc.Text : !string.IsNullOrEmpty(txt_efp_003_inc.Text) ? txt_efp_003_inc.Text : !string.IsNullOrEmpty(txt_efp_002_inc.Text) ? txt_efp_002_inc.Text : !string.IsNullOrEmpty(txt_efp_001_inc.Text) ? txt_efp_001_inc.Text : txt_efp_ref_inc.Text;
        Standard.EPF_EYT = !string.IsNullOrEmpty(txt_eyt_007_inc.Text) ? txt_eyt_007_inc.Text : !string.IsNullOrEmpty(txt_eyt_006_inc.Text) ? txt_eyt_006_inc.Text : !string.IsNullOrEmpty(txt_eyt_005_inc.Text) ? txt_eyt_005_inc.Text : !string.IsNullOrEmpty(txt_eyt_004_inc.Text) ? txt_eyt_004_inc.Text : !string.IsNullOrEmpty(txt_eyt_003_inc.Text) ? txt_eyt_003_inc.Text : !string.IsNullOrEmpty(txt_eyt_002_inc.Text) ? txt_eyt_002_inc.Text : !string.IsNullOrEmpty(txt_eyt_001_inc.Text) ? txt_eyt_001_inc.Text : txt_eyt_ref_inc.Text;
        Standard.EPF_EDL = !string.IsNullOrEmpty(txt_edl_007_inc.Text) ? txt_edl_007_inc.Text : !string.IsNullOrEmpty(txt_edl_006_inc.Text) ? txt_edl_006_inc.Text : !string.IsNullOrEmpty(txt_edl_005_inc.Text) ? txt_edl_005_inc.Text : !string.IsNullOrEmpty(txt_edl_004_inc.Text) ? txt_edl_004_inc.Text : !string.IsNullOrEmpty(txt_edl_003_inc.Text) ? txt_edl_003_inc.Text : !string.IsNullOrEmpty(txt_edl_002_inc.Text) ? txt_edl_002_inc.Text : !string.IsNullOrEmpty(txt_edl_001_inc.Text) ? txt_edl_001_inc.Text : txt_edl_ref_inc.Text;
        Standard.EPF_EAB = !string.IsNullOrEmpty(txt_eab_007_inc.Text) ? txt_eab_007_inc.Text : !string.IsNullOrEmpty(txt_eab_006_inc.Text) ? txt_eab_006_inc.Text : !string.IsNullOrEmpty(txt_eab_005_inc.Text) ? txt_eab_005_inc.Text : !string.IsNullOrEmpty(txt_eab_004_inc.Text) ? txt_eab_004_inc.Text : !string.IsNullOrEmpty(txt_eab_003_inc.Text) ? txt_eab_003_inc.Text : !string.IsNullOrEmpty(txt_eab_002_inc.Text) ? txt_eab_002_inc.Text : !string.IsNullOrEmpty(txt_eab_001_inc.Text) ? txt_eab_001_inc.Text : txt_eab_ref_inc.Text;
        Standard.EPF_ECA = !string.IsNullOrEmpty(txt_eca_007_inc.Text) ? txt_eca_007_inc.Text : !string.IsNullOrEmpty(txt_eca_006_inc.Text) ? txt_eca_006_inc.Text : !string.IsNullOrEmpty(txt_eca_005_inc.Text) ? txt_eca_005_inc.Text : !string.IsNullOrEmpty(txt_eca_004_inc.Text) ? txt_eca_004_inc.Text : !string.IsNullOrEmpty(txt_eca_003_inc.Text) ? txt_eca_003_inc.Text : !string.IsNullOrEmpty(txt_eca_002_inc.Text) ? txt_eca_002_inc.Text : !string.IsNullOrEmpty(txt_eca_001_inc.Text) ? txt_eca_001_inc.Text : txt_eca_ref_inc.Text;
        Standard.EPF_ECW = !string.IsNullOrEmpty(txt_ecw_007_inc.Text) ? txt_ecw_007_inc.Text : !string.IsNullOrEmpty(txt_ecw_006_inc.Text) ? txt_ecw_006_inc.Text : !string.IsNullOrEmpty(txt_ecw_005_inc.Text) ? txt_ecw_005_inc.Text : !string.IsNullOrEmpty(txt_ecw_004_inc.Text) ? txt_ecw_004_inc.Text : !string.IsNullOrEmpty(txt_ecw_003_inc.Text) ? txt_ecw_003_inc.Text : !string.IsNullOrEmpty(txt_ecw_002_inc.Text) ? txt_ecw_002_inc.Text : !string.IsNullOrEmpty(txt_ecw_001_inc.Text) ? txt_ecw_001_inc.Text : txt_ecw_ref_inc.Text;
        Standard.EPF_ETL = !string.IsNullOrEmpty(txt_etl_007_inc.Text) ? txt_etl_007_inc.Text : !string.IsNullOrEmpty(txt_etl_006_inc.Text) ? txt_etl_006_inc.Text : !string.IsNullOrEmpty(txt_etl_005_inc.Text) ? txt_etl_005_inc.Text : !string.IsNullOrEmpty(txt_etl_004_inc.Text) ? txt_etl_004_inc.Text : !string.IsNullOrEmpty(txt_etl_003_inc.Text) ? txt_etl_003_inc.Text : !string.IsNullOrEmpty(txt_etl_002_inc.Text) ? txt_etl_002_inc.Text : !string.IsNullOrEmpty(txt_etl_001_inc.Text) ? txt_etl_001_inc.Text : txt_etl_ref_inc.Text;
        Standard.EPF_ETT = !string.IsNullOrEmpty(txt_ett_007_inc.Text) ? txt_ett_007_inc.Text : !string.IsNullOrEmpty(txt_ett_006_inc.Text) ? txt_ett_006_inc.Text : !string.IsNullOrEmpty(txt_ett_005_inc.Text) ? txt_ett_005_inc.Text : !string.IsNullOrEmpty(txt_ett_004_inc.Text) ? txt_ett_004_inc.Text : !string.IsNullOrEmpty(txt_ett_003_inc.Text) ? txt_ett_003_inc.Text : !string.IsNullOrEmpty(txt_ett_002_inc.Text) ? txt_ett_002_inc.Text : !string.IsNullOrEmpty(txt_ett_001_inc.Text) ? txt_ett_001_inc.Text : txt_ett_ref_inc.Text;
        Standard.EPF_ERE = !string.IsNullOrEmpty(txt_ere_007_inc.Text) ? txt_ere_007_inc.Text : !string.IsNullOrEmpty(txt_ere_006_inc.Text) ? txt_ere_006_inc.Text : !string.IsNullOrEmpty(txt_ere_005_inc.Text) ? txt_ere_005_inc.Text : !string.IsNullOrEmpty(txt_ere_004_inc.Text) ? txt_ere_004_inc.Text : !string.IsNullOrEmpty(txt_ere_003_inc.Text) ? txt_ere_003_inc.Text : !string.IsNullOrEmpty(txt_ere_002_inc.Text) ? txt_ere_002_inc.Text : !string.IsNullOrEmpty(txt_ere_001_inc.Text) ? txt_ere_001_inc.Text : txt_ere_ref_inc.Text;
        Standard.EPF_ELE = !string.IsNullOrEmpty(txt_ele_007_inc.Text) ? txt_ele_007_inc.Text : !string.IsNullOrEmpty(txt_ele_006_inc.Text) ? txt_ele_006_inc.Text : !string.IsNullOrEmpty(txt_ele_005_inc.Text) ? txt_ele_005_inc.Text : !string.IsNullOrEmpty(txt_ele_004_inc.Text) ? txt_ele_004_inc.Text : !string.IsNullOrEmpty(txt_ele_003_inc.Text) ? txt_ele_003_inc.Text : !string.IsNullOrEmpty(txt_ele_002_inc.Text) ? txt_ele_002_inc.Text : !string.IsNullOrEmpty(txt_ele_001_inc.Text) ? txt_ele_001_inc.Text : txt_ele_ref_inc.Text;
        Standard.EPF_EPT = !string.IsNullOrEmpty(txt_ept_007_inc.Text) ? txt_ept_007_inc.Text : !string.IsNullOrEmpty(txt_ept_006_inc.Text) ? txt_ept_006_inc.Text : !string.IsNullOrEmpty(txt_ept_005_inc.Text) ? txt_ept_005_inc.Text : !string.IsNullOrEmpty(txt_ept_004_inc.Text) ? txt_ept_004_inc.Text : !string.IsNullOrEmpty(txt_ept_003_inc.Text) ? txt_ept_003_inc.Text : !string.IsNullOrEmpty(txt_ept_002_inc.Text) ? txt_ept_002_inc.Text : !string.IsNullOrEmpty(txt_ept_001_inc.Text) ? txt_ept_001_inc.Text : txt_ept_ref_inc.Text;
        Standard.EPF_EPL = !string.IsNullOrEmpty(txt_epl_007_inc.Text) ? txt_epl_007_inc.Text : !string.IsNullOrEmpty(txt_epl_006_inc.Text) ? txt_epl_006_inc.Text : !string.IsNullOrEmpty(txt_epl_005_inc.Text) ? txt_epl_005_inc.Text : !string.IsNullOrEmpty(txt_epl_004_inc.Text) ? txt_epl_004_inc.Text : !string.IsNullOrEmpty(txt_epl_003_inc.Text) ? txt_epl_003_inc.Text : !string.IsNullOrEmpty(txt_epl_002_inc.Text) ? txt_epl_002_inc.Text : !string.IsNullOrEmpty(txt_epl_001_inc.Text) ? txt_epl_001_inc.Text : txt_epl_ref_inc.Text;

        string sCTX = !string.IsNullOrEmpty(cbo_ez1_ez2_007_inc.Text) ? cbo_ez1_ez2_007_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_006_inc.Text) ? cbo_ez1_ez2_006_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_005_inc.Text) ? cbo_ez1_ez2_005_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_004_inc.Text) ? cbo_ez1_ez2_004_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_003_inc.Text) ? cbo_ez1_ez2_003_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_002_inc.Text) ? cbo_ez1_ez2_002_inc.Text : !string.IsNullOrEmpty(cbo_ez1_ez2_001_inc.Text) ? cbo_ez1_ez2_001_inc.Text : cbo_ez1_ez2_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCTX))
        {
            Standard.EPF_CTX = Convert.ToInt32(sCTX);
        }
        string sCVX = !string.IsNullOrEmpty(cbo_ez3_ez4_007_inc.Text) ? cbo_ez3_ez4_007_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_006_inc.Text) ? cbo_ez3_ez4_006_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_005_inc.Text) ? cbo_ez3_ez4_005_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_004_inc.Text) ? cbo_ez3_ez4_004_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_003_inc.Text) ? cbo_ez3_ez4_003_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_002_inc.Text) ? cbo_ez3_ez4_002_inc.Text : !string.IsNullOrEmpty(cbo_ez3_ez4_001_inc.Text) ? cbo_ez3_ez4_001_inc.Text : cbo_ez3_ez4_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVX))
        {
            Standard.EPF_CVX = Convert.ToInt32(sCVX);
        }
        string sCVR = !string.IsNullOrEmpty(cbo_ez5_ez6_007_inc.Text) ? cbo_ez5_ez6_007_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_006_inc.Text) ? cbo_ez5_ez6_006_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_005_inc.Text) ? cbo_ez5_ez6_005_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_004_inc.Text) ? cbo_ez5_ez6_004_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_003_inc.Text) ? cbo_ez5_ez6_003_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_002_inc.Text) ? cbo_ez5_ez6_002_inc.Text : !string.IsNullOrEmpty(cbo_ez5_ez6_001_inc.Text) ? cbo_ez5_ez6_001_inc.Text : cbo_ez5_ez6_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVR))
        {
            Standard.EPF_CVR = Convert.ToInt32(sCVR);
        }

        Standard.EPF_PCO = !string.IsNullOrEmpty(txt_pco_007_inc.Text) ? txt_pco_007_inc.Text : !string.IsNullOrEmpty(txt_pco_006_inc.Text) ? txt_pco_006_inc.Text : !string.IsNullOrEmpty(txt_pco_005_inc.Text) ? txt_pco_005_inc.Text : !string.IsNullOrEmpty(txt_pco_004_inc.Text) ? txt_pco_004_inc.Text : !string.IsNullOrEmpty(txt_pco_003_inc.Text) ? txt_pco_003_inc.Text : !string.IsNullOrEmpty(txt_pco_002_inc.Text) ? txt_pco_002_inc.Text : !string.IsNullOrEmpty(txt_pco_001_inc.Text) ? txt_pco_001_inc.Text : txt_pco_ref_inc.Text;
        Standard.EPF_PCV = !string.IsNullOrEmpty(txt_pcv_007_inc.Text) ? txt_pcv_007_inc.Text : !string.IsNullOrEmpty(txt_pcv_006_inc.Text) ? txt_pcv_006_inc.Text : !string.IsNullOrEmpty(txt_pcv_005_inc.Text) ? txt_pcv_005_inc.Text : !string.IsNullOrEmpty(txt_pcv_004_inc.Text) ? txt_pcv_004_inc.Text : !string.IsNullOrEmpty(txt_pcv_003_inc.Text) ? txt_pcv_003_inc.Text : !string.IsNullOrEmpty(txt_pcv_002_inc.Text) ? txt_pcv_002_inc.Text : !string.IsNullOrEmpty(txt_pcv_001_inc.Text) ? txt_pcv_001_inc.Text : txt_pcv_ref_inc.Text;
        Standard.EPF_DRT = !string.IsNullOrEmpty(txt_drt_007_inc.Text) ? txt_drt_007_inc.Text : !string.IsNullOrEmpty(txt_drt_006_inc.Text) ? txt_drt_006_inc.Text : !string.IsNullOrEmpty(txt_drt_005_inc.Text) ? txt_drt_005_inc.Text : !string.IsNullOrEmpty(txt_drt_004_inc.Text) ? txt_drt_004_inc.Text : !string.IsNullOrEmpty(txt_drt_003_inc.Text) ? txt_drt_003_inc.Text : !string.IsNullOrEmpty(txt_drt_002_inc.Text) ? txt_drt_002_inc.Text : !string.IsNullOrEmpty(txt_drt_001_inc.Text) ? txt_drt_001_inc.Text : txt_drt_ref_inc.Text;
        Standard.EPF_TAL = !string.IsNullOrEmpty(txt_tal_007_inc.Text) ? txt_tal_007_inc.Text : !string.IsNullOrEmpty(txt_tal_006_inc.Text) ? txt_tal_006_inc.Text : !string.IsNullOrEmpty(txt_tal_005_inc.Text) ? txt_tal_005_inc.Text : !string.IsNullOrEmpty(txt_tal_004_inc.Text) ? txt_tal_004_inc.Text : !string.IsNullOrEmpty(txt_tal_003_inc.Text) ? txt_tal_003_inc.Text : !string.IsNullOrEmpty(txt_tal_002_inc.Text) ? txt_tal_002_inc.Text : !string.IsNullOrEmpty(txt_tal_001_inc.Text) ? txt_tal_001_inc.Text : txt_tal_ref_inc.Text;
        Standard.EPF_VAL = !string.IsNullOrEmpty(txt_val_007_inc.Text) ? txt_val_007_inc.Text : !string.IsNullOrEmpty(txt_val_006_inc.Text) ? txt_val_006_inc.Text : !string.IsNullOrEmpty(txt_val_005_inc.Text) ? txt_val_005_inc.Text : !string.IsNullOrEmpty(txt_val_004_inc.Text) ? txt_val_004_inc.Text : !string.IsNullOrEmpty(txt_val_003_inc.Text) ? txt_val_003_inc.Text : !string.IsNullOrEmpty(txt_val_002_inc.Text) ? txt_val_002_inc.Text : !string.IsNullOrEmpty(txt_val_001_inc.Text) ? txt_val_001_inc.Text : txt_val_ref_inc.Text;
        Standard.EPF_SJE = !string.IsNullOrEmpty(txt_sje_007_inc.Text) ? txt_sje_007_inc.Text : !string.IsNullOrEmpty(txt_sje_006_inc.Text) ? txt_sje_006_inc.Text : !string.IsNullOrEmpty(txt_sje_005_inc.Text) ? txt_sje_005_inc.Text : !string.IsNullOrEmpty(txt_sje_004_inc.Text) ? txt_sje_004_inc.Text : !string.IsNullOrEmpty(txt_sje_003_inc.Text) ? txt_sje_003_inc.Text : !string.IsNullOrEmpty(txt_sje_002_inc.Text) ? txt_sje_002_inc.Text : !string.IsNullOrEmpty(txt_sje_001_inc.Text) ? txt_sje_001_inc.Text : txt_sje_ref_inc.Text;

        string sHOT = !string.IsNullOrEmpty(txt_hot_007_inc.Text) ? txt_hot_007_inc.Text : !string.IsNullOrEmpty(txt_hot_006_inc.Text) ? txt_hot_006_inc.Text : !string.IsNullOrEmpty(txt_hot_005_inc.Text) ? txt_hot_005_inc.Text : !string.IsNullOrEmpty(txt_hot_004_inc.Text) ? txt_hot_004_inc.Text : !string.IsNullOrEmpty(txt_hot_003_inc.Text) ? txt_hot_003_inc.Text : !string.IsNullOrEmpty(txt_hot_002_inc.Text) ? txt_hot_002_inc.Text : !string.IsNullOrEmpty(txt_hot_001_inc.Text) ? txt_hot_001_inc.Text : txt_hot_ref_inc.Text;
        if (!string.IsNullOrEmpty(sHOT))
        {
            Standard.EPF_HOT = Convert.ToInt32(sHOT);
        }
        Standard.EPF_VRD = !string.IsNullOrEmpty(txt_vrd_007_inc.Text) ? txt_vrd_007_inc.Text : !string.IsNullOrEmpty(txt_vrd_006_inc.Text) ? txt_vrd_006_inc.Text : !string.IsNullOrEmpty(txt_vrd_005_inc.Text) ? txt_vrd_005_inc.Text : !string.IsNullOrEmpty(txt_vrd_004_inc.Text) ? txt_vrd_004_inc.Text : !string.IsNullOrEmpty(txt_vrd_003_inc.Text) ? txt_vrd_003_inc.Text : !string.IsNullOrEmpty(txt_vrd_002_inc.Text) ? txt_vrd_002_inc.Text : !string.IsNullOrEmpty(txt_vrd_001_inc.Text) ? txt_vrd_001_inc.Text : txt_vrd_ref_inc.Text;
        string sACR = !string.IsNullOrEmpty(txt_acr_007_inc.Text) ? txt_acr_007_inc.Text : !string.IsNullOrEmpty(txt_acr_006_inc.Text) ? txt_acr_006_inc.Text : !string.IsNullOrEmpty(txt_acr_005_inc.Text) ? txt_acr_005_inc.Text : !string.IsNullOrEmpty(txt_acr_004_inc.Text) ? txt_acr_004_inc.Text : !string.IsNullOrEmpty(txt_acr_003_inc.Text) ? txt_acr_003_inc.Text : !string.IsNullOrEmpty(txt_acr_002_inc.Text) ? txt_acr_002_inc.Text : !string.IsNullOrEmpty(txt_acr_001_inc.Text) ? txt_acr_001_inc.Text : txt_acr_ref_inc.Text;
        if (!string.IsNullOrEmpty(sACR))
        {
            Standard.EPF_ACR = Convert.ToInt32(sACR);
        }
        string sPEN = !string.IsNullOrEmpty(txt_pen_007_inc.Text) ? txt_pen_007_inc.Text : !string.IsNullOrEmpty(txt_pen_006_inc.Text) ? txt_pen_006_inc.Text : !string.IsNullOrEmpty(txt_pen_005_inc.Text) ? txt_pen_005_inc.Text : !string.IsNullOrEmpty(txt_pen_004_inc.Text) ? txt_pen_004_inc.Text : !string.IsNullOrEmpty(txt_pen_003_inc.Text) ? txt_pen_003_inc.Text : !string.IsNullOrEmpty(txt_pen_002_inc.Text) ? txt_pen_002_inc.Text : !string.IsNullOrEmpty(txt_pen_001_inc.Text) ? txt_pen_001_inc.Text : txt_pen_ref_inc.Text;
        if (!string.IsNullOrEmpty(sPEN))
        {
            Standard.EPF_PEN = Convert.ToInt32(sPEN);
        }
        string sCRA = !string.IsNullOrEmpty(txt_cra_007_inc.Text) ? txt_cra_007_inc.Text : !string.IsNullOrEmpty(txt_cra_006_inc.Text) ? txt_cra_006_inc.Text : !string.IsNullOrEmpty(txt_cra_005_inc.Text) ? txt_cra_005_inc.Text : !string.IsNullOrEmpty(txt_cra_004_inc.Text) ? txt_cra_004_inc.Text : !string.IsNullOrEmpty(txt_cra_003_inc.Text) ? txt_cra_003_inc.Text : !string.IsNullOrEmpty(txt_cra_002_inc.Text) ? txt_cra_002_inc.Text : !string.IsNullOrEmpty(txt_cra_001_inc.Text) ? txt_cra_001_inc.Text : txt_cra_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCRA))
        {
            Standard.EPF_CRA = Convert.ToInt32(sCRA);
        }
        string sCLE = !string.IsNullOrEmpty(txt_cle_007_inc.Text) ? txt_cle_007_inc.Text : !string.IsNullOrEmpty(txt_cle_006_inc.Text) ? txt_cle_006_inc.Text : !string.IsNullOrEmpty(txt_cle_005_inc.Text) ? txt_cle_005_inc.Text : !string.IsNullOrEmpty(txt_cle_004_inc.Text) ? txt_cle_004_inc.Text : !string.IsNullOrEmpty(txt_cle_003_inc.Text) ? txt_cle_003_inc.Text : !string.IsNullOrEmpty(txt_cle_002_inc.Text) ? txt_cle_002_inc.Text : !string.IsNullOrEmpty(txt_cle_001_inc.Text) ? txt_cle_001_inc.Text : txt_cle_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCLE))
        {
            Standard.EPF_CLE = Convert.ToInt32(sCLE);
        }
        string sAFO = !string.IsNullOrEmpty(txt_afo_007_inc.Text) ? txt_afo_007_inc.Text : !string.IsNullOrEmpty(txt_afo_006_inc.Text) ? txt_afo_006_inc.Text : !string.IsNullOrEmpty(txt_afo_005_inc.Text) ? txt_afo_005_inc.Text : !string.IsNullOrEmpty(txt_afo_004_inc.Text) ? txt_afo_004_inc.Text : !string.IsNullOrEmpty(txt_afo_003_inc.Text) ? txt_afo_003_inc.Text : !string.IsNullOrEmpty(txt_afo_002_inc.Text) ? txt_afo_002_inc.Text : !string.IsNullOrEmpty(txt_afo_001_inc.Text) ? txt_afo_001_inc.Text : txt_afo_ref_inc.Text;
        if (!string.IsNullOrEmpty(sAFO))
        {
            Standard.EPF_AFO = Convert.ToInt32(sAFO);
        }
        Standard.EPF_TCU = !string.IsNullOrEmpty(cbo_tcu_007_inc.Text) ? cbo_tcu_007_inc.Text : !string.IsNullOrEmpty(cbo_tcu_006_inc.Text) ? cbo_tcu_006_inc.Text : !string.IsNullOrEmpty(cbo_tcu_005_inc.Text) ? cbo_tcu_005_inc.Text : !string.IsNullOrEmpty(cbo_tcu_004_inc.Text) ? cbo_tcu_004_inc.Text : !string.IsNullOrEmpty(cbo_tcu_003_inc.Text) ? cbo_tcu_003_inc.Text : !string.IsNullOrEmpty(cbo_tcu_002_inc.Text) ? cbo_tcu_002_inc.Text : !string.IsNullOrEmpty(cbo_tcu_001_inc.Text) ? cbo_tcu_001_inc.Text : cbo_tcu_ref_inc.Text;
        Standard.EPF_TAR = !string.IsNullOrEmpty(txt_tar_007_inc.Text) ? txt_tar_007_inc.Text : !string.IsNullOrEmpty(txt_tar_006_inc.Text) ? txt_tar_006_inc.Text : !string.IsNullOrEmpty(txt_tar_005_inc.Text) ? txt_tar_005_inc.Text : !string.IsNullOrEmpty(txt_tar_004_inc.Text) ? txt_tar_004_inc.Text : !string.IsNullOrEmpty(txt_tar_003_inc.Text) ? txt_tar_003_inc.Text : !string.IsNullOrEmpty(txt_tar_002_inc.Text) ? txt_tar_002_inc.Text : !string.IsNullOrEmpty(txt_tar_001_inc.Text) ? txt_tar_001_inc.Text : txt_tar_ref_inc.Text;
        Standard.EPF_TAM = !string.IsNullOrEmpty(cbo_tam_007_inc.Text) ? cbo_tam_007_inc.Text : !string.IsNullOrEmpty(cbo_tam_006_inc.Text) ? cbo_tam_006_inc.Text : !string.IsNullOrEmpty(cbo_tam_005_inc.Text) ? cbo_tam_005_inc.Text : !string.IsNullOrEmpty(cbo_tam_004_inc.Text) ? cbo_tam_004_inc.Text : !string.IsNullOrEmpty(cbo_tam_003_inc.Text) ? cbo_tam_003_inc.Text : !string.IsNullOrEmpty(cbo_tam_002_inc.Text) ? cbo_tam_002_inc.Text : !string.IsNullOrEmpty(cbo_tam_001_inc.Text) ? cbo_tam_001_inc.Text : cbo_tam_ref_inc.Text;
        string sDTU = !string.IsNullOrEmpty(txt_dtu_007_inc.Text) ? txt_dtu_007_inc.Text : !string.IsNullOrEmpty(txt_dtu_006_inc.Text) ? txt_dtu_006_inc.Text : !string.IsNullOrEmpty(txt_dtu_005_inc.Text) ? txt_dtu_005_inc.Text : !string.IsNullOrEmpty(txt_dtu_004_inc.Text) ? txt_dtu_004_inc.Text : !string.IsNullOrEmpty(txt_dtu_003_inc.Text) ? txt_dtu_003_inc.Text : !string.IsNullOrEmpty(txt_dtu_002_inc.Text) ? txt_dtu_002_inc.Text : !string.IsNullOrEmpty(txt_dtu_001_inc.Text) ? txt_dtu_001_inc.Text : txt_dtu_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDTU))
        {
            Standard.EPF_DTU = Convert.ToInt32(sDTU);
        }
        string sDPA = !string.IsNullOrEmpty(txt_dpa_007_inc.Text) ? txt_dpa_007_inc.Text : !string.IsNullOrEmpty(txt_dpa_006_inc.Text) ? txt_dpa_006_inc.Text : !string.IsNullOrEmpty(txt_dpa_005_inc.Text) ? txt_dpa_005_inc.Text : !string.IsNullOrEmpty(txt_dpa_004_inc.Text) ? txt_dpa_004_inc.Text : !string.IsNullOrEmpty(txt_dpa_003_inc.Text) ? txt_dpa_003_inc.Text : !string.IsNullOrEmpty(txt_dpa_002_inc.Text) ? txt_dpa_002_inc.Text : !string.IsNullOrEmpty(txt_dpa_001_inc.Text) ? txt_dpa_001_inc.Text : txt_dpa_ref_inc.Text;
        if (!string.IsNullOrEmpty(sDPA))
        {
            Standard.EPF_DPA = Convert.ToInt32(sDPA);
        }
        string sCIN = !string.IsNullOrEmpty(txt_cin_007_inc.Text) ? txt_cin_007_inc.Text : !string.IsNullOrEmpty(txt_cin_006_inc.Text) ? txt_cin_006_inc.Text : !string.IsNullOrEmpty(txt_cin_005_inc.Text) ? txt_cin_005_inc.Text : !string.IsNullOrEmpty(txt_cin_004_inc.Text) ? txt_cin_004_inc.Text : !string.IsNullOrEmpty(txt_cin_003_inc.Text) ? txt_cin_003_inc.Text : !string.IsNullOrEmpty(txt_cin_002_inc.Text) ? txt_cin_002_inc.Text : !string.IsNullOrEmpty(txt_cin_001_inc.Text) ? txt_cin_001_inc.Text : txt_cin_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCIN))
        {
            Standard.EPF_CIN = Convert.ToInt32(sCIN);
        }
        Standard.EPF_TIP_FR2 = !string.IsNullOrEmpty(cbo_tip_fr2_007_inc.Text) ? cbo_tip_fr2_007_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_006_inc.Text) ? cbo_tip_fr2_006_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_005_inc.Text) ? cbo_tip_fr2_005_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_004_inc.Text) ? cbo_tip_fr2_004_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_003_inc.Text) ? cbo_tip_fr2_003_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_002_inc.Text) ? cbo_tip_fr2_002_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr2_001_inc.Text) ? cbo_tip_fr2_001_inc.Text : cbo_tip_fr2_ref_inc.Text;
        Standard.EPF_FR2 = !string.IsNullOrEmpty(txt_fr2_007_inc.Text) ? txt_fr2_007_inc.Text : !string.IsNullOrEmpty(txt_fr2_006_inc.Text) ? txt_fr2_006_inc.Text : !string.IsNullOrEmpty(txt_fr2_005_inc.Text) ? txt_fr2_005_inc.Text : !string.IsNullOrEmpty(txt_fr2_004_inc.Text) ? txt_fr2_004_inc.Text : !string.IsNullOrEmpty(txt_fr2_003_inc.Text) ? txt_fr2_003_inc.Text : !string.IsNullOrEmpty(txt_fr2_002_inc.Text) ? txt_fr2_002_inc.Text : !string.IsNullOrEmpty(txt_fr2_001_inc.Text) ? txt_fr2_001_inc.Text : txt_fr2_ref_inc.Text;
        Standard.EPF_TIP_FR1 = !string.IsNullOrEmpty(cbo_tip_fr1_007_inc.Text) ? cbo_tip_fr1_007_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_006_inc.Text) ? cbo_tip_fr1_006_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_005_inc.Text) ? cbo_tip_fr1_005_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_004_inc.Text) ? cbo_tip_fr1_004_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_003_inc.Text) ? cbo_tip_fr1_003_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_002_inc.Text) ? cbo_tip_fr1_002_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr1_001_inc.Text) ? cbo_tip_fr1_001_inc.Text : cbo_tip_fr1_ref_inc.Text;
        Standard.EPF_FR1 = !string.IsNullOrEmpty(txt_fr1_007_inc.Text) ? txt_fr1_007_inc.Text : !string.IsNullOrEmpty(txt_fr1_006_inc.Text) ? txt_fr1_006_inc.Text : !string.IsNullOrEmpty(txt_fr1_005_inc.Text) ? txt_fr1_005_inc.Text : !string.IsNullOrEmpty(txt_fr1_004_inc.Text) ? txt_fr1_004_inc.Text : !string.IsNullOrEmpty(txt_fr1_003_inc.Text) ? txt_fr1_003_inc.Text : !string.IsNullOrEmpty(txt_fr1_002_inc.Text) ? txt_fr1_002_inc.Text : !string.IsNullOrEmpty(txt_fr1_001_inc.Text) ? txt_fr1_001_inc.Text : txt_fr1_ref_inc.Text;
        Standard.EPF_TIP_FR0 = !string.IsNullOrEmpty(cbo_tip_fr0_007_inc.Text) ? cbo_tip_fr0_007_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_006_inc.Text) ? cbo_tip_fr0_006_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_005_inc.Text) ? cbo_tip_fr0_005_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_004_inc.Text) ? cbo_tip_fr0_004_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_003_inc.Text) ? cbo_tip_fr0_003_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_002_inc.Text) ? cbo_tip_fr0_002_inc.Text : !string.IsNullOrEmpty(cbo_tip_fr0_001_inc.Text) ? cbo_tip_fr0_001_inc.Text : cbo_tip_fr0_ref_inc.Text;
        Standard.EPF_FR0 = !string.IsNullOrEmpty(txt_fr0_007_inc.Text) ? txt_fr0_007_inc.Text : !string.IsNullOrEmpty(txt_fr0_006_inc.Text) ? txt_fr0_006_inc.Text : !string.IsNullOrEmpty(txt_fr0_005_inc.Text) ? txt_fr0_005_inc.Text : !string.IsNullOrEmpty(txt_fr0_004_inc.Text) ? txt_fr0_004_inc.Text : !string.IsNullOrEmpty(txt_fr0_003_inc.Text) ? txt_fr0_003_inc.Text : !string.IsNullOrEmpty(txt_fr0_002_inc.Text) ? txt_fr0_002_inc.Text : !string.IsNullOrEmpty(txt_fr0_001_inc.Text) ? txt_fr0_001_inc.Text : txt_fr0_ref_inc.Text;
        string sATO = !string.IsNullOrEmpty(txt_ato_007_inc.Text) ? txt_ato_007_inc.Text : !string.IsNullOrEmpty(txt_ato_006_inc.Text) ? txt_ato_006_inc.Text : !string.IsNullOrEmpty(txt_ato_005_inc.Text) ? txt_ato_005_inc.Text : !string.IsNullOrEmpty(txt_ato_004_inc.Text) ? txt_ato_004_inc.Text : !string.IsNullOrEmpty(txt_ato_003_inc.Text) ? txt_ato_003_inc.Text : !string.IsNullOrEmpty(txt_ato_002_inc.Text) ? txt_ato_002_inc.Text : !string.IsNullOrEmpty(txt_ato_001_inc.Text) ? txt_ato_001_inc.Text : txt_ato_ref_inc.Text;
        if (!string.IsNullOrEmpty(sATO))
        {
            Standard.EPF_ATO = Convert.ToInt32(sATO);
        }
        string sTP1 = !string.IsNullOrEmpty(txt_tp1_007_inc.Text) ? txt_tp1_007_inc.Text : !string.IsNullOrEmpty(txt_tp1_006_inc.Text) ? txt_tp1_006_inc.Text : !string.IsNullOrEmpty(txt_tp1_005_inc.Text) ? txt_tp1_005_inc.Text : !string.IsNullOrEmpty(txt_tp1_004_inc.Text) ? txt_tp1_004_inc.Text : !string.IsNullOrEmpty(txt_tp1_003_inc.Text) ? txt_tp1_003_inc.Text : !string.IsNullOrEmpty(txt_tp1_002_inc.Text) ? txt_tp1_002_inc.Text : !string.IsNullOrEmpty(txt_tp1_001_inc.Text) ? txt_tp1_001_inc.Text : txt_tp1_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTP1))
        {
            Standard.EPF_TP1 = Convert.ToDouble(sTP1);
        }
        string sTP2 = !string.IsNullOrEmpty(txt_tp2_007_inc.Text) ? txt_tp2_007_inc.Text : !string.IsNullOrEmpty(txt_tp2_006_inc.Text) ? txt_tp2_006_inc.Text : !string.IsNullOrEmpty(txt_tp2_005_inc.Text) ? txt_tp2_005_inc.Text : !string.IsNullOrEmpty(txt_tp2_004_inc.Text) ? txt_tp2_004_inc.Text : !string.IsNullOrEmpty(txt_tp2_003_inc.Text) ? txt_tp2_003_inc.Text : !string.IsNullOrEmpty(txt_tp2_002_inc.Text) ? txt_tp2_002_inc.Text : !string.IsNullOrEmpty(txt_tp2_001_inc.Text) ? txt_tp2_001_inc.Text : txt_tp2_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTP2))
        {
            Standard.EPF_TP2 = Convert.ToDouble(sTP2);
        }
        string sTCP = !string.IsNullOrEmpty(txt_tcp_007_inc.Text) ? txt_tcp_007_inc.Text : !string.IsNullOrEmpty(txt_tcp_006_inc.Text) ? txt_tcp_006_inc.Text : !string.IsNullOrEmpty(txt_tcp_005_inc.Text) ? txt_tcp_005_inc.Text : !string.IsNullOrEmpty(txt_tcp_004_inc.Text) ? txt_tcp_004_inc.Text : !string.IsNullOrEmpty(txt_tcp_003_inc.Text) ? txt_tcp_003_inc.Text : !string.IsNullOrEmpty(txt_tcp_002_inc.Text) ? txt_tcp_002_inc.Text : !string.IsNullOrEmpty(txt_tcp_001_inc.Text) ? txt_tcp_001_inc.Text : txt_tcp_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTCP))
        {
            Standard.EPF_TCP = Convert.ToInt32(sTCP);
        }
        Standard.EPF_JF2 = !string.IsNullOrEmpty(txt_jf2_007_inc.Text) ? txt_jf2_007_inc.Text : !string.IsNullOrEmpty(txt_jf2_006_inc.Text) ? txt_jf2_006_inc.Text : !string.IsNullOrEmpty(txt_jf2_005_inc.Text) ? txt_jf2_005_inc.Text : !string.IsNullOrEmpty(txt_jf2_004_inc.Text) ? txt_jf2_004_inc.Text : !string.IsNullOrEmpty(txt_jf2_003_inc.Text) ? txt_jf2_003_inc.Text : !string.IsNullOrEmpty(txt_jf2_002_inc.Text) ? txt_jf2_002_inc.Text : !string.IsNullOrEmpty(txt_jf2_001_inc.Text) ? txt_jf2_001_inc.Text : txt_jf2_ref_inc.Text;
        string sPS2 = !string.IsNullOrEmpty(txt_ps2_007_inc.Text) ? txt_ps2_007_inc.Text : !string.IsNullOrEmpty(txt_ps2_006_inc.Text) ? txt_ps2_006_inc.Text : !string.IsNullOrEmpty(txt_ps2_005_inc.Text) ? txt_ps2_005_inc.Text : !string.IsNullOrEmpty(txt_ps2_004_inc.Text) ? txt_ps2_004_inc.Text : !string.IsNullOrEmpty(txt_ps2_003_inc.Text) ? txt_ps2_003_inc.Text : !string.IsNullOrEmpty(txt_ps2_002_inc.Text) ? txt_ps2_002_inc.Text : !string.IsNullOrEmpty(txt_ps2_001_inc.Text) ? txt_ps2_001_inc.Text : txt_ps2_ref_inc.Text;
        if (!string.IsNullOrEmpty(sPS2))
        {
            Standard.EPF_PS2 = Convert.ToInt32(sPS2);
        }
        Standard.EPF_JF0 = !string.IsNullOrEmpty(txt_jf0_007_inc.Text) ? txt_jf0_007_inc.Text : !string.IsNullOrEmpty(txt_jf0_006_inc.Text) ? txt_jf0_006_inc.Text : !string.IsNullOrEmpty(txt_jf0_005_inc.Text) ? txt_jf0_005_inc.Text : !string.IsNullOrEmpty(txt_jf0_004_inc.Text) ? txt_jf0_004_inc.Text : !string.IsNullOrEmpty(txt_jf0_003_inc.Text) ? txt_jf0_003_inc.Text : !string.IsNullOrEmpty(txt_jf0_002_inc.Text) ? txt_jf0_002_inc.Text : !string.IsNullOrEmpty(txt_jf0_001_inc.Text) ? txt_jf0_001_inc.Text : txt_jf0_ref_inc.Text;
        string sPS0 = !string.IsNullOrEmpty(txt_ps0_007_inc.Text) ? txt_ps0_007_inc.Text : !string.IsNullOrEmpty(txt_ps0_006_inc.Text) ? txt_ps0_006_inc.Text : !string.IsNullOrEmpty(txt_ps0_005_inc.Text) ? txt_ps0_005_inc.Text : !string.IsNullOrEmpty(txt_ps0_004_inc.Text) ? txt_ps0_004_inc.Text : !string.IsNullOrEmpty(txt_ps0_003_inc.Text) ? txt_ps0_003_inc.Text : !string.IsNullOrEmpty(txt_ps0_002_inc.Text) ? txt_ps0_002_inc.Text : !string.IsNullOrEmpty(txt_ps0_001_inc.Text) ? txt_ps0_001_inc.Text : txt_ps0_ref_inc.Text;
        if (!string.IsNullOrEmpty(sPS0))
        {
            Standard.EPF_PS0 = Convert.ToInt32(sPS0);
        }
        string sBBA = !string.IsNullOrEmpty(txt_bba_007_inc.Text) ? txt_bba_007_inc.Text : !string.IsNullOrEmpty(txt_bba_006_inc.Text) ? txt_bba_006_inc.Text : !string.IsNullOrEmpty(txt_bba_005_inc.Text) ? txt_bba_005_inc.Text : !string.IsNullOrEmpty(txt_bba_004_inc.Text) ? txt_bba_004_inc.Text : !string.IsNullOrEmpty(txt_bba_003_inc.Text) ? txt_bba_003_inc.Text : !string.IsNullOrEmpty(txt_bba_002_inc.Text) ? txt_bba_002_inc.Text : !string.IsNullOrEmpty(txt_bba_001_inc.Text) ? txt_bba_001_inc.Text : txt_bba_ref_inc.Text;
        if (!string.IsNullOrEmpty(sBBA))
        {
            Standard.EPF_BBA = Convert.ToDouble(sBBA);
        }
        Standard.EPF_GRO = !string.IsNullOrEmpty(txt_gro_007_inc.Text) ? txt_gro_007_inc.Text : !string.IsNullOrEmpty(txt_gro_006_inc.Text) ? txt_gro_006_inc.Text : !string.IsNullOrEmpty(txt_gro_005_inc.Text) ? txt_gro_005_inc.Text : !string.IsNullOrEmpty(txt_gro_004_inc.Text) ? txt_gro_004_inc.Text : !string.IsNullOrEmpty(txt_gro_003_inc.Text) ? txt_gro_003_inc.Text : !string.IsNullOrEmpty(txt_gro_002_inc.Text) ? txt_gro_002_inc.Text : !string.IsNullOrEmpty(txt_gro_001_inc.Text) ? txt_gro_001_inc.Text : txt_gro_ref_inc.Text;
        Standard.EPF_TCS = !string.IsNullOrEmpty(txt_tcs_007_inc.Text) ? txt_tcs_007_inc.Text : !string.IsNullOrEmpty(txt_tcs_006_inc.Text) ? txt_tcs_006_inc.Text : !string.IsNullOrEmpty(txt_tcs_005_inc.Text) ? txt_tcs_005_inc.Text : !string.IsNullOrEmpty(txt_tcs_004_inc.Text) ? txt_tcs_004_inc.Text : !string.IsNullOrEmpty(txt_tcs_003_inc.Text) ? txt_tcs_003_inc.Text : !string.IsNullOrEmpty(txt_tcs_002_inc.Text) ? txt_tcs_002_inc.Text : !string.IsNullOrEmpty(txt_tcs_001_inc.Text) ? txt_tcs_001_inc.Text : txt_tcs_ref_inc.Text;
        Standard.EPF_CVP = !string.IsNullOrEmpty(txt_cvp_007_inc.Text) ? txt_cvp_007_inc.Text : !string.IsNullOrEmpty(txt_cvp_006_inc.Text) ? txt_cvp_006_inc.Text : !string.IsNullOrEmpty(txt_cvp_005_inc.Text) ? txt_cvp_005_inc.Text : !string.IsNullOrEmpty(txt_cvp_004_inc.Text) ? txt_cvp_004_inc.Text : !string.IsNullOrEmpty(txt_cvp_003_inc.Text) ? txt_cvp_003_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_inc.Text) ? txt_cvp_002_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_inc.Text) ? txt_cvp_001_inc.Text : txt_cvp_ref_inc.Text;
        string sSSV = !string.IsNullOrEmpty(txt_ssv_007_inc.Text) ? txt_ssv_007_inc.Text : !string.IsNullOrEmpty(txt_ssv_006_inc.Text) ? txt_ssv_006_inc.Text : !string.IsNullOrEmpty(txt_ssv_005_inc.Text) ? txt_ssv_005_inc.Text : !string.IsNullOrEmpty(txt_ssv_004_inc.Text) ? txt_ssv_004_inc.Text : !string.IsNullOrEmpty(txt_ssv_003_inc.Text) ? txt_ssv_003_inc.Text : !string.IsNullOrEmpty(txt_ssv_002_inc.Text) ? txt_ssv_002_inc.Text : !string.IsNullOrEmpty(txt_ssv_001_inc.Text) ? txt_ssv_001_inc.Text : txt_ssv_ref_inc.Text;
        if (!string.IsNullOrEmpty(sSSV))
        {
            Standard.EPF_SSV = Convert.ToInt32(sSSV);
        }
        string sSSP = !string.IsNullOrEmpty(txt_ssp_007_inc.Text) ? txt_ssp_007_inc.Text : !string.IsNullOrEmpty(txt_ssp_006_inc.Text) ? txt_ssp_006_inc.Text : !string.IsNullOrEmpty(txt_ssp_005_inc.Text) ? txt_ssp_005_inc.Text : !string.IsNullOrEmpty(txt_ssp_004_inc.Text) ? txt_ssp_004_inc.Text : !string.IsNullOrEmpty(txt_ssp_003_inc.Text) ? txt_ssp_003_inc.Text : !string.IsNullOrEmpty(txt_ssp_002_inc.Text) ? txt_ssp_002_inc.Text : !string.IsNullOrEmpty(txt_ssp_001_inc.Text) ? txt_ssp_001_inc.Text : txt_ssp_ref_inc.Text;
        if (!string.IsNullOrEmpty(sSSP))
        {
            Standard.EPF_SSP = Convert.ToInt32(sSSP);
        }
        string sTTE_001 = !string.IsNullOrEmpty(txt_tte_001_007_inc.Text) ? txt_tte_001_007_inc.Text : !string.IsNullOrEmpty(txt_tte_001_006_inc.Text) ? txt_tte_001_006_inc.Text : !string.IsNullOrEmpty(txt_tte_001_005_inc.Text) ? txt_tte_001_005_inc.Text : !string.IsNullOrEmpty(txt_tte_001_004_inc.Text) ? txt_tte_001_004_inc.Text : !string.IsNullOrEmpty(txt_tte_001_003_inc.Text) ? txt_tte_001_003_inc.Text : !string.IsNullOrEmpty(txt_tte_001_002_inc.Text) ? txt_tte_001_002_inc.Text : !string.IsNullOrEmpty(txt_tte_001_001_inc.Text) ? txt_tte_001_001_inc.Text : txt_tte_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTTE_001))
        {
            Standard.EPF_TTE_001 = Convert.ToDouble(sTTE_001);
        }
        string sTTE_002 = !string.IsNullOrEmpty(txt_tte_002_007_inc.Text) ? txt_tte_002_007_inc.Text : !string.IsNullOrEmpty(txt_tte_002_006_inc.Text) ? txt_tte_002_006_inc.Text : !string.IsNullOrEmpty(txt_tte_002_005_inc.Text) ? txt_tte_002_005_inc.Text : !string.IsNullOrEmpty(txt_tte_002_004_inc.Text) ? txt_tte_002_004_inc.Text : !string.IsNullOrEmpty(txt_tte_002_003_inc.Text) ? txt_tte_002_003_inc.Text : !string.IsNullOrEmpty(txt_tte_002_002_inc.Text) ? txt_tte_002_002_inc.Text : !string.IsNullOrEmpty(txt_tte_002_001_inc.Text) ? txt_tte_002_001_inc.Text : txt_tte_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTTE_002))
        {
            Standard.EPF_TTE_002 = Convert.ToDouble(sTTE_002);
        }
        Standard.EPF_WPO_001 = !string.IsNullOrEmpty(cbo_wpo_001_007_inc.Text) ? cbo_wpo_001_007_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_006_inc.Text) ? cbo_wpo_001_006_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_005_inc.Text) ? cbo_wpo_001_005_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_004_inc.Text) ? cbo_wpo_001_004_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_003_inc.Text) ? cbo_wpo_001_003_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_002_inc.Text) ? cbo_wpo_001_002_inc.Text : !string.IsNullOrEmpty(cbo_wpo_001_001_inc.Text) ? cbo_wpo_001_001_inc.Text : cbo_wpo_001_ref_inc.Text;
        Standard.EPF_WPO_002 = !string.IsNullOrEmpty(cbo_wpo_002_007_inc.Text) ? cbo_wpo_002_007_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_006_inc.Text) ? cbo_wpo_002_006_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_005_inc.Text) ? cbo_wpo_002_005_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_004_inc.Text) ? cbo_wpo_002_004_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_003_inc.Text) ? cbo_wpo_002_003_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_002_inc.Text) ? cbo_wpo_002_002_inc.Text : !string.IsNullOrEmpty(cbo_wpo_002_001_inc.Text) ? cbo_wpo_002_001_inc.Text : cbo_wpo_002_ref_inc.Text;
        Standard.EPF_DIR_001 = !string.IsNullOrEmpty(txt_dir_001_007_inc.Text) ? txt_dir_001_007_inc.Text : !string.IsNullOrEmpty(txt_dir_001_006_inc.Text) ? txt_dir_001_006_inc.Text : !string.IsNullOrEmpty(txt_dir_001_005_inc.Text) ? txt_dir_001_005_inc.Text : !string.IsNullOrEmpty(txt_dir_001_004_inc.Text) ? txt_dir_001_004_inc.Text : !string.IsNullOrEmpty(txt_dir_001_003_inc.Text) ? txt_dir_001_003_inc.Text : !string.IsNullOrEmpty(txt_dir_001_002_inc.Text) ? txt_dir_001_002_inc.Text : !string.IsNullOrEmpty(txt_dir_001_001_inc.Text) ? txt_dir_001_001_inc.Text : txt_dir_001_ref_inc.Text;
        Standard.EPF_DIR_002 = !string.IsNullOrEmpty(txt_dir_002_007_inc.Text) ? txt_dir_002_007_inc.Text : !string.IsNullOrEmpty(txt_dir_002_006_inc.Text) ? txt_dir_002_006_inc.Text : !string.IsNullOrEmpty(txt_dir_002_005_inc.Text) ? txt_dir_002_005_inc.Text : !string.IsNullOrEmpty(txt_dir_002_004_inc.Text) ? txt_dir_002_004_inc.Text : !string.IsNullOrEmpty(txt_dir_002_003_inc.Text) ? txt_dir_002_003_inc.Text : !string.IsNullOrEmpty(txt_dir_002_002_inc.Text) ? txt_dir_002_002_inc.Text : !string.IsNullOrEmpty(txt_dir_002_001_inc.Text) ? txt_dir_002_001_inc.Text : txt_dir_002_ref_inc.Text;
        string sCRA_001 = !string.IsNullOrEmpty(txt_cra_001_007_inc.Text) ? txt_cra_001_007_inc.Text : !string.IsNullOrEmpty(txt_cra_001_006_inc.Text) ? txt_cra_001_006_inc.Text : !string.IsNullOrEmpty(txt_cra_001_005_inc.Text) ? txt_cra_001_005_inc.Text : !string.IsNullOrEmpty(txt_cra_001_004_inc.Text) ? txt_cra_001_004_inc.Text : !string.IsNullOrEmpty(txt_cra_001_003_inc.Text) ? txt_cra_001_003_inc.Text : !string.IsNullOrEmpty(txt_cra_001_002_inc.Text) ? txt_cra_001_002_inc.Text : !string.IsNullOrEmpty(txt_cra_001_001_inc.Text) ? txt_cra_001_001_inc.Text : txt_cra_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCRA_001))
        {
            Standard.EPF_CRA_001 = Convert.ToInt32(sCRA_001);
        }
        string sCRA_002 = !string.IsNullOrEmpty(txt_cra_002_007_inc.Text) ? txt_cra_002_007_inc.Text : !string.IsNullOrEmpty(txt_cra_002_006_inc.Text) ? txt_cra_002_006_inc.Text : !string.IsNullOrEmpty(txt_cra_002_005_inc.Text) ? txt_cra_002_005_inc.Text : !string.IsNullOrEmpty(txt_cra_002_004_inc.Text) ? txt_cra_002_004_inc.Text : !string.IsNullOrEmpty(txt_cra_002_003_inc.Text) ? txt_cra_002_003_inc.Text : !string.IsNullOrEmpty(txt_cra_002_002_inc.Text) ? txt_cra_002_002_inc.Text : !string.IsNullOrEmpty(txt_cra_002_001_inc.Text) ? txt_cra_002_001_inc.Text : txt_cra_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCRA_002))
        {
            Standard.EPF_CRA_002 = Convert.ToInt32(sCRA_002);
        }
        Standard.EPF_CED_001 = !string.IsNullOrEmpty(cbo_ced_001_007_inc.Text) ? cbo_ced_001_007_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_006_inc.Text) ? cbo_ced_001_006_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_005_inc.Text) ? cbo_ced_001_005_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_004_inc.Text) ? cbo_ced_001_004_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_003_inc.Text) ? cbo_ced_001_003_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_002_inc.Text) ? cbo_ced_001_002_inc.Text : !string.IsNullOrEmpty(cbo_ced_001_001_inc.Text) ? cbo_ced_001_001_inc.Text : cbo_ced_001_ref_inc.Text;
        Standard.EPF_CED_002 = !string.IsNullOrEmpty(cbo_ced_002_007_inc.Text) ? cbo_ced_002_007_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_006_inc.Text) ? cbo_ced_002_006_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_005_inc.Text) ? cbo_ced_002_005_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_004_inc.Text) ? cbo_ced_002_004_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_003_inc.Text) ? cbo_ced_002_003_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_002_inc.Text) ? cbo_ced_002_002_inc.Text : !string.IsNullOrEmpty(cbo_ced_002_001_inc.Text) ? cbo_ced_002_001_inc.Text : cbo_ced_002_ref_inc.Text;
        Standard.EPF_TED_001 = !string.IsNullOrEmpty(txt_ted_001_007_inc.Text) ? txt_ted_001_007_inc.Text : !string.IsNullOrEmpty(txt_ted_001_006_inc.Text) ? txt_ted_001_006_inc.Text : !string.IsNullOrEmpty(txt_ted_001_005_inc.Text) ? txt_ted_001_005_inc.Text : !string.IsNullOrEmpty(txt_ted_001_004_inc.Text) ? txt_ted_001_004_inc.Text : !string.IsNullOrEmpty(txt_ted_001_003_inc.Text) ? txt_ted_001_003_inc.Text : !string.IsNullOrEmpty(txt_ted_001_002_inc.Text) ? txt_ted_001_002_inc.Text : !string.IsNullOrEmpty(txt_ted_001_001_inc.Text) ? txt_ted_001_001_inc.Text : txt_ted_001_ref_inc.Text;
        Standard.EPF_TED_002 = !string.IsNullOrEmpty(txt_ted_002_007_inc.Text) ? txt_ted_002_007_inc.Text : !string.IsNullOrEmpty(txt_ted_002_006_inc.Text) ? txt_ted_002_006_inc.Text : !string.IsNullOrEmpty(txt_ted_002_005_inc.Text) ? txt_ted_002_005_inc.Text : !string.IsNullOrEmpty(txt_ted_002_004_inc.Text) ? txt_ted_002_004_inc.Text : !string.IsNullOrEmpty(txt_ted_002_003_inc.Text) ? txt_ted_002_003_inc.Text : !string.IsNullOrEmpty(txt_ted_002_002_inc.Text) ? txt_ted_002_002_inc.Text : !string.IsNullOrEmpty(txt_ted_002_001_inc.Text) ? txt_ted_002_001_inc.Text : txt_ted_002_ref_inc.Text;
        Standard.EPF_DLE_001 = !string.IsNullOrEmpty(txt_dle_001_007_inc.Text) ? txt_dle_001_007_inc.Text : !string.IsNullOrEmpty(txt_dle_001_006_inc.Text) ? txt_dle_001_006_inc.Text : !string.IsNullOrEmpty(txt_dle_001_005_inc.Text) ? txt_dle_001_005_inc.Text : !string.IsNullOrEmpty(txt_dle_001_004_inc.Text) ? txt_dle_001_004_inc.Text : !string.IsNullOrEmpty(txt_dle_001_003_inc.Text) ? txt_dle_001_003_inc.Text : !string.IsNullOrEmpty(txt_dle_001_002_inc.Text) ? txt_dle_001_002_inc.Text : !string.IsNullOrEmpty(txt_dle_001_001_inc.Text) ? txt_dle_001_001_inc.Text : txt_dle_001_ref_inc.Text;
        Standard.EPF_DLE_002 = !string.IsNullOrEmpty(txt_dle_002_007_inc.Text) ? txt_dle_002_007_inc.Text : !string.IsNullOrEmpty(txt_dle_002_006_inc.Text) ? txt_dle_002_006_inc.Text : !string.IsNullOrEmpty(txt_dle_002_005_inc.Text) ? txt_dle_002_005_inc.Text : !string.IsNullOrEmpty(txt_dle_002_004_inc.Text) ? txt_dle_002_004_inc.Text : !string.IsNullOrEmpty(txt_dle_002_003_inc.Text) ? txt_dle_002_003_inc.Text : !string.IsNullOrEmpty(txt_dle_002_002_inc.Text) ? txt_dle_002_002_inc.Text : !string.IsNullOrEmpty(txt_dle_002_001_inc.Text) ? txt_dle_002_001_inc.Text : txt_dle_002_ref_inc.Text;
        Standard.EPF_CTI_001 = !string.IsNullOrEmpty(txt_cti_001_007_inc.Text) ? txt_cti_001_007_inc.Text : !string.IsNullOrEmpty(txt_cti_001_006_inc.Text) ? txt_cti_001_006_inc.Text : !string.IsNullOrEmpty(txt_cti_001_005_inc.Text) ? txt_cti_001_005_inc.Text : !string.IsNullOrEmpty(txt_cti_001_004_inc.Text) ? txt_cti_001_004_inc.Text : !string.IsNullOrEmpty(txt_cti_001_003_inc.Text) ? txt_cti_001_003_inc.Text : !string.IsNullOrEmpty(txt_cti_001_002_inc.Text) ? txt_cti_001_002_inc.Text : !string.IsNullOrEmpty(txt_cti_001_001_inc.Text) ? txt_cti_001_001_inc.Text : txt_cti_001_ref_inc.Text;
        Standard.EPF_CTI_002 = !string.IsNullOrEmpty(txt_cti_002_007_inc.Text) ? txt_cti_002_007_inc.Text : !string.IsNullOrEmpty(txt_cti_002_006_inc.Text) ? txt_cti_002_006_inc.Text : !string.IsNullOrEmpty(txt_cti_002_005_inc.Text) ? txt_cti_002_005_inc.Text : !string.IsNullOrEmpty(txt_cti_002_004_inc.Text) ? txt_cti_002_004_inc.Text : !string.IsNullOrEmpty(txt_cti_002_003_inc.Text) ? txt_cti_002_003_inc.Text : !string.IsNullOrEmpty(txt_cti_002_002_inc.Text) ? txt_cti_002_002_inc.Text : !string.IsNullOrEmpty(txt_cti_002_001_inc.Text) ? txt_cti_002_001_inc.Text : txt_cti_002_ref_inc.Text;
        string sG1O_001 = !string.IsNullOrEmpty(txt_g1o_001_007_inc.Text) ? txt_g1o_001_007_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_006_inc.Text) ? txt_g1o_001_006_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_005_inc.Text) ? txt_g1o_001_005_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_004_inc.Text) ? txt_g1o_001_004_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_003_inc.Text) ? txt_g1o_001_003_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_002_inc.Text) ? txt_g1o_001_002_inc.Text : !string.IsNullOrEmpty(txt_g1o_001_001_inc.Text) ? txt_g1o_001_001_inc.Text : txt_g1o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG1O_001))
        {
            Standard.EPF_G1O_001 = Convert.ToInt32(sG1O_001);
        }
        string sG1O_002 = !string.IsNullOrEmpty(txt_g1o_002_007_inc.Text) ? txt_g1o_002_007_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_006_inc.Text) ? txt_g1o_002_006_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_005_inc.Text) ? txt_g1o_002_005_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_004_inc.Text) ? txt_g1o_002_004_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_003_inc.Text) ? txt_g1o_002_003_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_002_inc.Text) ? txt_g1o_002_002_inc.Text : !string.IsNullOrEmpty(txt_g1o_002_001_inc.Text) ? txt_g1o_002_001_inc.Text : txt_g1o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG1O_002))
        {
            Standard.EPF_G1O_002 = Convert.ToInt32(sG1O_002);
        }
        string sG1U_001 = !string.IsNullOrEmpty(txt_g1u_001_007_inc.Text) ? txt_g1u_001_007_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_006_inc.Text) ? txt_g1u_001_006_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_005_inc.Text) ? txt_g1u_001_005_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_004_inc.Text) ? txt_g1u_001_004_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_003_inc.Text) ? txt_g1u_001_003_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_002_inc.Text) ? txt_g1u_001_002_inc.Text : !string.IsNullOrEmpty(txt_g1u_001_001_inc.Text) ? txt_g1u_001_001_inc.Text : txt_g1u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG1U_001))
        {
            Standard.EPF_G1U_001 = Convert.ToInt32(sG1U_001);
        }
        string sG1U_002 = !string.IsNullOrEmpty(txt_g1u_002_007_inc.Text) ? txt_g1u_002_007_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_006_inc.Text) ? txt_g1u_002_006_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_005_inc.Text) ? txt_g1u_002_005_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_004_inc.Text) ? txt_g1u_002_004_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_003_inc.Text) ? txt_g1u_002_003_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_002_inc.Text) ? txt_g1u_002_002_inc.Text : !string.IsNullOrEmpty(txt_g1u_002_001_inc.Text) ? txt_g1u_002_001_inc.Text : txt_g1u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG1U_002))
        {
            Standard.EPF_G1U_002 = Convert.ToInt32(sG1U_002);
        }
        string sG2O_001 = !string.IsNullOrEmpty(txt_g2o_001_007_inc.Text) ? txt_g2o_001_007_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_006_inc.Text) ? txt_g2o_001_006_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_005_inc.Text) ? txt_g2o_001_005_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_004_inc.Text) ? txt_g2o_001_004_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_003_inc.Text) ? txt_g2o_001_003_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_002_inc.Text) ? txt_g2o_001_002_inc.Text : !string.IsNullOrEmpty(txt_g2o_001_001_inc.Text) ? txt_g2o_001_001_inc.Text : txt_g2o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG2O_001))
        {
            Standard.EPF_G2O_001 = Convert.ToInt32(sG2O_001);
        }
        string sG2O_002 = !string.IsNullOrEmpty(txt_g2o_002_007_inc.Text) ? txt_g2o_002_007_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_006_inc.Text) ? txt_g2o_002_006_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_005_inc.Text) ? txt_g2o_002_005_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_004_inc.Text) ? txt_g2o_002_004_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_003_inc.Text) ? txt_g2o_002_003_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_002_inc.Text) ? txt_g2o_002_002_inc.Text : !string.IsNullOrEmpty(txt_g2o_002_001_inc.Text) ? txt_g2o_002_001_inc.Text : txt_g2o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG2O_002))
        {
            Standard.EPF_G2O_002 = Convert.ToInt32(sG2O_002);
        }
        string sG2U_001 = !string.IsNullOrEmpty(txt_g2u_001_007_inc.Text) ? txt_g2u_001_007_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_006_inc.Text) ? txt_g2u_001_006_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_005_inc.Text) ? txt_g2u_001_005_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_004_inc.Text) ? txt_g2u_001_004_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_003_inc.Text) ? txt_g2u_001_003_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_002_inc.Text) ? txt_g2u_001_002_inc.Text : !string.IsNullOrEmpty(txt_g2u_001_001_inc.Text) ? txt_g2u_001_001_inc.Text : txt_g2u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG2U_001))
        {
            Standard.EPF_G2U_001 = Convert.ToInt32(sG2U_001);
        }
        string sG2U_002 = !string.IsNullOrEmpty(txt_g2u_002_007_inc.Text) ? txt_g2u_002_007_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_006_inc.Text) ? txt_g2u_002_006_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_005_inc.Text) ? txt_g2u_002_005_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_004_inc.Text) ? txt_g2u_002_004_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_003_inc.Text) ? txt_g2u_002_003_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_002_inc.Text) ? txt_g2u_002_002_inc.Text : !string.IsNullOrEmpty(txt_g2u_002_001_inc.Text) ? txt_g2u_002_001_inc.Text : txt_g2u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sG2U_002))
        {
            Standard.EPF_G2U_002 = Convert.ToInt32(sG2U_002);
        }
        string sCVP_001 = !string.IsNullOrEmpty(txt_cvp_001_007_inc.Text) ? txt_cvp_001_007_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_006_inc.Text) ? txt_cvp_001_006_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_005_inc.Text) ? txt_cvp_001_005_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_004_inc.Text) ? txt_cvp_001_004_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_003_inc.Text) ? txt_cvp_001_003_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_002_inc.Text) ? txt_cvp_001_002_inc.Text : !string.IsNullOrEmpty(txt_cvp_001_001_inc.Text) ? txt_cvp_001_001_inc.Text : txt_cvp_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVP_001))
        {
            Standard.EPF_CVP_001 = Convert.ToInt32(sCVP_001);
        }
        string sCVP_002 = !string.IsNullOrEmpty(txt_cvp_002_007_inc.Text) ? txt_cvp_002_007_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_006_inc.Text) ? txt_cvp_002_006_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_005_inc.Text) ? txt_cvp_002_005_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_004_inc.Text) ? txt_cvp_002_004_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_003_inc.Text) ? txt_cvp_002_003_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_002_inc.Text) ? txt_cvp_002_002_inc.Text : !string.IsNullOrEmpty(txt_cvp_002_001_inc.Text) ? txt_cvp_002_001_inc.Text : txt_cvp_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVP_002))
        {
            Standard.EPF_CVP_002 = Convert.ToInt32(sCVP_002);
        }
        string sOCU_001 = !string.IsNullOrEmpty(txt_ocu_001_007_inc.Text) ? txt_ocu_001_007_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_006_inc.Text) ? txt_ocu_001_006_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_005_inc.Text) ? txt_ocu_001_005_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_004_inc.Text) ? txt_ocu_001_004_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_003_inc.Text) ? txt_ocu_001_003_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_002_inc.Text) ? txt_ocu_001_002_inc.Text : !string.IsNullOrEmpty(txt_ocu_001_001_inc.Text) ? txt_ocu_001_001_inc.Text : txt_ocu_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sOCU_001))
        {
            Standard.EPF_OCU_001 = Convert.ToInt32(sOCU_001);
        }
        string sOCU_002 = !string.IsNullOrEmpty(txt_ocu_002_007_inc.Text) ? txt_ocu_002_007_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_006_inc.Text) ? txt_ocu_002_006_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_005_inc.Text) ? txt_ocu_002_005_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_004_inc.Text) ? txt_ocu_002_004_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_003_inc.Text) ? txt_ocu_002_003_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_002_inc.Text) ? txt_ocu_002_002_inc.Text : !string.IsNullOrEmpty(txt_ocu_002_001_inc.Text) ? txt_ocu_002_001_inc.Text : txt_ocu_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sOCU_002))
        {
            Standard.EPF_OCU_002 = Convert.ToInt32(sOCU_002);
        }
        string sUCU_001 = !string.IsNullOrEmpty(txt_ucu_001_007_inc.Text) ? txt_ucu_001_007_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_006_inc.Text) ? txt_ucu_001_006_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_005_inc.Text) ? txt_ucu_001_005_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_004_inc.Text) ? txt_ucu_001_004_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_003_inc.Text) ? txt_ucu_001_003_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_002_inc.Text) ? txt_ucu_001_002_inc.Text : !string.IsNullOrEmpty(txt_ucu_001_001_inc.Text) ? txt_ucu_001_001_inc.Text : txt_ucu_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUCU_001))
        {
            Standard.EPF_UCU_001 = Convert.ToInt32(sUCU_001);
        }
        string sUCU_002 = !string.IsNullOrEmpty(txt_ucu_002_007_inc.Text) ? txt_ucu_002_007_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_006_inc.Text) ? txt_ucu_002_006_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_005_inc.Text) ? txt_ucu_002_005_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_004_inc.Text) ? txt_ucu_002_004_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_003_inc.Text) ? txt_ucu_002_003_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_002_inc.Text) ? txt_ucu_002_002_inc.Text : !string.IsNullOrEmpty(txt_ucu_002_001_inc.Text) ? txt_ucu_002_001_inc.Text : txt_ucu_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sUCU_002))
        {
            Standard.EPF_UCU_002 = Convert.ToInt32(sUCU_002);
        }
        string sC1O_001 = !string.IsNullOrEmpty(txt_c1o_001_007_inc.Text) ? txt_c1o_001_007_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_006_inc.Text) ? txt_c1o_001_006_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_005_inc.Text) ? txt_c1o_001_005_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_004_inc.Text) ? txt_c1o_001_004_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_003_inc.Text) ? txt_c1o_001_003_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_002_inc.Text) ? txt_c1o_001_002_inc.Text : !string.IsNullOrEmpty(txt_c1o_001_001_inc.Text) ? txt_c1o_001_001_inc.Text : txt_c1o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC1O_001))
        {
            Standard.EPF_C1O_001 = Convert.ToInt32(sC1O_001);
        }
        string sC1O_002 = !string.IsNullOrEmpty(txt_c1o_002_007_inc.Text) ? txt_c1o_002_007_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_006_inc.Text) ? txt_c1o_002_006_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_005_inc.Text) ? txt_c1o_002_005_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_004_inc.Text) ? txt_c1o_002_004_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_003_inc.Text) ? txt_c1o_002_003_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_002_inc.Text) ? txt_c1o_002_002_inc.Text : !string.IsNullOrEmpty(txt_c1o_002_001_inc.Text) ? txt_c1o_002_001_inc.Text : txt_c1o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC1O_002))
        {
            Standard.EPF_C1O_002 = Convert.ToInt32(sC1O_002);
        }
        string sL1O_001 = !string.IsNullOrEmpty(txt_l1o_001_007_inc.Text) ? txt_l1o_001_007_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_006_inc.Text) ? txt_l1o_001_006_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_005_inc.Text) ? txt_l1o_001_005_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_004_inc.Text) ? txt_l1o_001_004_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_003_inc.Text) ? txt_l1o_001_003_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_002_inc.Text) ? txt_l1o_001_002_inc.Text : !string.IsNullOrEmpty(txt_l1o_001_001_inc.Text) ? txt_l1o_001_001_inc.Text : txt_l1o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL1O_001))
        {
            Standard.EPF_L1O_001 = Convert.ToInt32(sL1O_001);
        }
        string sL1O_002 = !string.IsNullOrEmpty(txt_l1o_002_007_inc.Text) ? txt_l1o_002_007_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_006_inc.Text) ? txt_l1o_002_006_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_005_inc.Text) ? txt_l1o_002_005_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_004_inc.Text) ? txt_l1o_002_004_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_003_inc.Text) ? txt_l1o_002_003_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_002_inc.Text) ? txt_l1o_002_002_inc.Text : !string.IsNullOrEmpty(txt_l1o_002_001_inc.Text) ? txt_l1o_002_001_inc.Text : txt_l1o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL1O_002))
        {
            Standard.EPF_L1O_002 = Convert.ToInt32(sL1O_002);
        }
        string sC1U_001 = !string.IsNullOrEmpty(txt_c1u_001_007_inc.Text) ? txt_c1u_001_007_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_006_inc.Text) ? txt_c1u_001_006_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_005_inc.Text) ? txt_c1u_001_005_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_004_inc.Text) ? txt_c1u_001_004_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_003_inc.Text) ? txt_c1u_001_003_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_002_inc.Text) ? txt_c1u_001_002_inc.Text : !string.IsNullOrEmpty(txt_c1u_001_001_inc.Text) ? txt_c1u_001_001_inc.Text : txt_c1u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC1U_001))
        {
            Standard.EPF_C1U_001 = Convert.ToInt32(sC1U_001);
        }
        string sC1U_002 = !string.IsNullOrEmpty(txt_c1u_002_007_inc.Text) ? txt_c1u_002_007_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_006_inc.Text) ? txt_c1u_002_006_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_005_inc.Text) ? txt_c1u_002_005_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_004_inc.Text) ? txt_c1u_002_004_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_003_inc.Text) ? txt_c1u_002_003_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_002_inc.Text) ? txt_c1u_002_002_inc.Text : !string.IsNullOrEmpty(txt_c1u_002_001_inc.Text) ? txt_c1u_002_001_inc.Text : txt_c1u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC1U_002))
        {
            Standard.EPF_C1U_002 = Convert.ToInt32(sC1U_002);
        }
        string sL1U_001 = !string.IsNullOrEmpty(txt_l1u_001_007_inc.Text) ? txt_l1u_001_007_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_006_inc.Text) ? txt_l1u_001_006_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_005_inc.Text) ? txt_l1u_001_005_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_004_inc.Text) ? txt_l1u_001_004_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_003_inc.Text) ? txt_l1u_001_003_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_002_inc.Text) ? txt_l1u_001_002_inc.Text : !string.IsNullOrEmpty(txt_l1u_001_001_inc.Text) ? txt_l1u_001_001_inc.Text : txt_l1u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL1U_001))
        {
            Standard.EPF_L1U_001 = Convert.ToInt32(sL1U_001);
        }
        string sL1U_002 = !string.IsNullOrEmpty(txt_l1u_002_007_inc.Text) ? txt_l1u_002_007_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_006_inc.Text) ? txt_l1u_002_006_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_005_inc.Text) ? txt_l1u_002_005_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_004_inc.Text) ? txt_l1u_002_004_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_003_inc.Text) ? txt_l1u_002_003_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_002_inc.Text) ? txt_l1u_002_002_inc.Text : !string.IsNullOrEmpty(txt_l1u_002_001_inc.Text) ? txt_l1u_002_001_inc.Text : txt_l1u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL1U_002))
        {
            Standard.EPF_L1U_002 = Convert.ToInt32(sL1U_002);
        }
        string sC2O_001 = !string.IsNullOrEmpty(txt_c2o_001_007_inc.Text) ? txt_c2o_001_007_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_006_inc.Text) ? txt_c2o_001_006_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_005_inc.Text) ? txt_c2o_001_005_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_004_inc.Text) ? txt_c2o_001_004_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_003_inc.Text) ? txt_c2o_001_003_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_002_inc.Text) ? txt_c2o_001_002_inc.Text : !string.IsNullOrEmpty(txt_c2o_001_001_inc.Text) ? txt_c2o_001_001_inc.Text : txt_c2o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC2O_001))
        {
            Standard.EPF_C2O_001 = Convert.ToInt32(sC2O_001);
        }
        string sC2O_002 = !string.IsNullOrEmpty(txt_c2o_002_007_inc.Text) ? txt_c2o_002_007_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_006_inc.Text) ? txt_c2o_002_006_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_005_inc.Text) ? txt_c2o_002_005_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_004_inc.Text) ? txt_c2o_002_004_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_003_inc.Text) ? txt_c2o_002_003_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_002_inc.Text) ? txt_c2o_002_002_inc.Text : !string.IsNullOrEmpty(txt_c2o_002_001_inc.Text) ? txt_c2o_002_001_inc.Text : txt_c2o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC2O_002))
        {
            Standard.EPF_C2O_002 = Convert.ToInt32(sC2O_002);
        }
        string sL2O_001 = !string.IsNullOrEmpty(txt_l2o_001_007_inc.Text) ? txt_l2o_001_007_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_006_inc.Text) ? txt_l2o_001_006_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_005_inc.Text) ? txt_l2o_001_005_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_004_inc.Text) ? txt_l2o_001_004_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_003_inc.Text) ? txt_l2o_001_003_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_002_inc.Text) ? txt_l2o_001_002_inc.Text : !string.IsNullOrEmpty(txt_l2o_001_001_inc.Text) ? txt_l2o_001_001_inc.Text : txt_l2o_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL2O_001))
        {
            Standard.EPF_L2O_001 = Convert.ToInt32(sL2O_001);
        }
        string sL2O_002 = !string.IsNullOrEmpty(txt_l2o_002_007_inc.Text) ? txt_l2o_002_007_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_006_inc.Text) ? txt_l2o_002_006_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_005_inc.Text) ? txt_l2o_002_005_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_004_inc.Text) ? txt_l2o_002_004_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_003_inc.Text) ? txt_l2o_002_003_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_002_inc.Text) ? txt_l2o_002_002_inc.Text : !string.IsNullOrEmpty(txt_l2o_002_001_inc.Text) ? txt_l2o_002_001_inc.Text : txt_l2o_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL2O_002))
        {
            Standard.EPF_L2O_002 = Convert.ToInt32(sL2O_002);
        }
        string sC2U_001 = !string.IsNullOrEmpty(txt_c2u_001_007_inc.Text) ? txt_c2u_001_007_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_006_inc.Text) ? txt_c2u_001_006_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_005_inc.Text) ? txt_c2u_001_005_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_004_inc.Text) ? txt_c2u_001_004_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_003_inc.Text) ? txt_c2u_001_003_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_002_inc.Text) ? txt_c2u_001_002_inc.Text : !string.IsNullOrEmpty(txt_c2u_001_001_inc.Text) ? txt_c2u_001_001_inc.Text : txt_c2u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC2U_001))
        {
            Standard.EPF_C2U_001 = Convert.ToInt32(sC2U_001);
        }
        string sC2U_002 = !string.IsNullOrEmpty(txt_c2u_002_007_inc.Text) ? txt_c2u_002_007_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_006_inc.Text) ? txt_c2u_002_006_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_005_inc.Text) ? txt_c2u_002_005_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_004_inc.Text) ? txt_c2u_002_004_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_003_inc.Text) ? txt_c2u_002_003_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_002_inc.Text) ? txt_c2u_002_002_inc.Text : !string.IsNullOrEmpty(txt_c2u_002_001_inc.Text) ? txt_c2u_002_001_inc.Text : txt_c2u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sC2U_002))
        {
            Standard.EPF_C2U_002 = Convert.ToInt32(sC2U_002);
        }
        string sL2U_001 = !string.IsNullOrEmpty(txt_l2u_001_007_inc.Text) ? txt_l2u_001_007_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_006_inc.Text) ? txt_l2u_001_006_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_005_inc.Text) ? txt_l2u_001_005_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_004_inc.Text) ? txt_l2u_001_004_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_003_inc.Text) ? txt_l2u_001_003_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_002_inc.Text) ? txt_l2u_001_002_inc.Text : !string.IsNullOrEmpty(txt_l2u_001_001_inc.Text) ? txt_l2u_001_001_inc.Text : txt_l2u_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL2U_001))
        {
            Standard.EPF_L2U_001 = Convert.ToInt32(sL2U_001);
        }
        string sL2U_002 = !string.IsNullOrEmpty(txt_l2u_002_007_inc.Text) ? txt_l2u_002_007_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_006_inc.Text) ? txt_l2u_002_006_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_005_inc.Text) ? txt_l2u_002_005_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_004_inc.Text) ? txt_l2u_002_004_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_003_inc.Text) ? txt_l2u_002_003_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_002_inc.Text) ? txt_l2u_002_002_inc.Text : !string.IsNullOrEmpty(txt_l2u_002_001_inc.Text) ? txt_l2u_002_001_inc.Text : txt_l2u_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sL2U_002))
        {
            Standard.EPF_L2U_002 = Convert.ToInt32(sL2U_002);
        }
        string sTSU_001 = !string.IsNullOrEmpty(txt_tsu_001_007_inc.Text) ? txt_tsu_001_007_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_006_inc.Text) ? txt_tsu_001_006_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_005_inc.Text) ? txt_tsu_001_005_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_004_inc.Text) ? txt_tsu_001_004_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_003_inc.Text) ? txt_tsu_001_003_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_002_inc.Text) ? txt_tsu_001_002_inc.Text : !string.IsNullOrEmpty(txt_tsu_001_001_inc.Text) ? txt_tsu_001_001_inc.Text : txt_tsu_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTSU_001))
        {
            Standard.EPF_TSU_001 = Convert.ToInt32(sTSU_001);
        }
        string sTSU_002 = !string.IsNullOrEmpty(txt_tsu_002_007_inc.Text) ? txt_tsu_002_007_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_006_inc.Text) ? txt_tsu_002_006_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_005_inc.Text) ? txt_tsu_002_005_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_004_inc.Text) ? txt_tsu_002_004_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_003_inc.Text) ? txt_tsu_002_003_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_002_inc.Text) ? txt_tsu_002_002_inc.Text : !string.IsNullOrEmpty(txt_tsu_002_001_inc.Text) ? txt_tsu_002_001_inc.Text : txt_tsu_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTSU_002))
        {
            Standard.EPF_TSU_002 = Convert.ToInt32(sTSU_002);
        }
        string sCVC_001 = !string.IsNullOrEmpty(txt_cvc_001_007_inc.Text) ? txt_cvc_001_007_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_006_inc.Text) ? txt_cvc_001_006_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_005_inc.Text) ? txt_cvc_001_005_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_004_inc.Text) ? txt_cvc_001_004_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_003_inc.Text) ? txt_cvc_001_003_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_002_inc.Text) ? txt_cvc_001_002_inc.Text : !string.IsNullOrEmpty(txt_cvc_001_001_inc.Text) ? txt_cvc_001_001_inc.Text : txt_cvc_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVC_001))
        {
            Standard.EPF_CVC_001 = Convert.ToInt32(sCVC_001);
        }
        string sCVC_002 = !string.IsNullOrEmpty(txt_cvc_002_007_inc.Text) ? txt_cvc_002_007_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_006_inc.Text) ? txt_cvc_002_006_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_005_inc.Text) ? txt_cvc_002_005_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_004_inc.Text) ? txt_cvc_002_004_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_003_inc.Text) ? txt_cvc_002_003_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_002_inc.Text) ? txt_cvc_002_002_inc.Text : !string.IsNullOrEmpty(txt_cvc_002_001_inc.Text) ? txt_cvc_002_001_inc.Text : txt_cvc_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVC_002))
        {
            Standard.EPF_CVC_002 = Convert.ToInt32(sCVC_002);
        }
        string sCVL_001 = !string.IsNullOrEmpty(txt_cvl_001_007_inc.Text) ? txt_cvl_001_007_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_006_inc.Text) ? txt_cvl_001_006_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_005_inc.Text) ? txt_cvl_001_005_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_004_inc.Text) ? txt_cvl_001_004_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_003_inc.Text) ? txt_cvl_001_003_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_002_inc.Text) ? txt_cvl_001_002_inc.Text : !string.IsNullOrEmpty(txt_cvl_001_001_inc.Text) ? txt_cvl_001_001_inc.Text : txt_cvl_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVL_001))
        {
            Standard.EPF_CVL_001 = Convert.ToInt32(sCVL_001);
        }
        string sCVL_002 = !string.IsNullOrEmpty(txt_cvl_002_007_inc.Text) ? txt_cvl_002_007_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_006_inc.Text) ? txt_cvl_002_006_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_005_inc.Text) ? txt_cvl_002_005_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_004_inc.Text) ? txt_cvl_002_004_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_003_inc.Text) ? txt_cvl_002_003_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_002_inc.Text) ? txt_cvl_002_002_inc.Text : !string.IsNullOrEmpty(txt_cvl_002_001_inc.Text) ? txt_cvl_002_001_inc.Text : txt_cvl_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sCVL_002))
        {
            Standard.EPF_CVL_002 = Convert.ToInt32(sCVL_002);
        }
        string sTLE_001 = !string.IsNullOrEmpty(txt_tle_001_007_inc.Text) ? txt_tle_001_007_inc.Text : !string.IsNullOrEmpty(txt_tle_001_006_inc.Text) ? txt_tle_001_006_inc.Text : !string.IsNullOrEmpty(txt_tle_001_005_inc.Text) ? txt_tle_001_005_inc.Text : !string.IsNullOrEmpty(txt_tle_001_004_inc.Text) ? txt_tle_001_004_inc.Text : !string.IsNullOrEmpty(txt_tle_001_003_inc.Text) ? txt_tle_001_003_inc.Text : !string.IsNullOrEmpty(txt_tle_001_002_inc.Text) ? txt_tle_001_002_inc.Text : !string.IsNullOrEmpty(txt_tle_001_001_inc.Text) ? txt_tle_001_001_inc.Text : txt_tle_001_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTLE_001))
        {
            Standard.EPF_TLE_001 = Convert.ToInt32(sTLE_001);
        }
        string sTLE_002 = !string.IsNullOrEmpty(txt_tle_002_007_inc.Text) ? txt_tle_002_007_inc.Text : !string.IsNullOrEmpty(txt_tle_002_006_inc.Text) ? txt_tle_002_006_inc.Text : !string.IsNullOrEmpty(txt_tle_002_005_inc.Text) ? txt_tle_002_005_inc.Text : !string.IsNullOrEmpty(txt_tle_002_004_inc.Text) ? txt_tle_002_004_inc.Text : !string.IsNullOrEmpty(txt_tle_002_003_inc.Text) ? txt_tle_002_003_inc.Text : !string.IsNullOrEmpty(txt_tle_002_002_inc.Text) ? txt_tle_002_002_inc.Text : !string.IsNullOrEmpty(txt_tle_002_001_inc.Text) ? txt_tle_002_001_inc.Text : txt_tle_002_ref_inc.Text;
        if (!string.IsNullOrEmpty(sTLE_002))
        {
            Standard.EPF_TLE_002 = Convert.ToInt32(sTLE_002);
        }
        Standard.EPF_ROI = !string.IsNullOrEmpty(cbo_roi_007_inc.Text) ? cbo_roi_007_inc.Text : !string.IsNullOrEmpty(cbo_roi_006_inc.Text) ? cbo_roi_006_inc.Text : !string.IsNullOrEmpty(cbo_roi_005_inc.Text) ? cbo_roi_005_inc.Text : !string.IsNullOrEmpty(cbo_roi_004_inc.Text) ? cbo_roi_004_inc.Text : !string.IsNullOrEmpty(cbo_roi_003_inc.Text) ? cbo_roi_003_inc.Text : !string.IsNullOrEmpty(cbo_roi_002_inc.Text) ? cbo_roi_002_inc.Text : !string.IsNullOrEmpty(cbo_roi_001_inc.Text) ? cbo_roi_001_inc.Text : cbo_roi_ref_inc.Text;
        Standard.EPF_RR0 = !string.IsNullOrEmpty(cbo_rr0_007_inc.Text) ? cbo_rr0_007_inc.Text : !string.IsNullOrEmpty(cbo_rr0_006_inc.Text) ? cbo_rr0_006_inc.Text : !string.IsNullOrEmpty(cbo_rr0_005_inc.Text) ? cbo_rr0_005_inc.Text : !string.IsNullOrEmpty(cbo_rr0_004_inc.Text) ? cbo_rr0_004_inc.Text : !string.IsNullOrEmpty(cbo_rr0_003_inc.Text) ? cbo_rr0_003_inc.Text : !string.IsNullOrEmpty(cbo_rr0_002_inc.Text) ? cbo_rr0_002_inc.Text : !string.IsNullOrEmpty(cbo_rr0_001_inc.Text) ? cbo_rr0_001_inc.Text : cbo_rr0_ref_inc.Text;
        Standard.EPF_R01 = !string.IsNullOrEmpty(cbo_r01_007_inc.Text) ? cbo_r01_007_inc.Text : !string.IsNullOrEmpty(cbo_r01_006_inc.Text) ? cbo_r01_006_inc.Text : !string.IsNullOrEmpty(cbo_r01_005_inc.Text) ? cbo_r01_005_inc.Text : !string.IsNullOrEmpty(cbo_r01_004_inc.Text) ? cbo_r01_004_inc.Text : !string.IsNullOrEmpty(cbo_r01_003_inc.Text) ? cbo_r01_003_inc.Text : !string.IsNullOrEmpty(cbo_r01_002_inc.Text) ? cbo_r01_002_inc.Text : !string.IsNullOrEmpty(cbo_r01_001_inc.Text) ? cbo_r01_001_inc.Text : cbo_r01_ref_inc.Text;
        Standard.EPF_RR1 = !string.IsNullOrEmpty(cbo_rr1_007_inc.Text) ? cbo_rr1_007_inc.Text : !string.IsNullOrEmpty(cbo_rr1_006_inc.Text) ? cbo_rr1_006_inc.Text : !string.IsNullOrEmpty(cbo_rr1_005_inc.Text) ? cbo_rr1_005_inc.Text : !string.IsNullOrEmpty(cbo_rr1_004_inc.Text) ? cbo_rr1_004_inc.Text : !string.IsNullOrEmpty(cbo_rr1_003_inc.Text) ? cbo_rr1_003_inc.Text : !string.IsNullOrEmpty(cbo_rr1_002_inc.Text) ? cbo_rr1_002_inc.Text : !string.IsNullOrEmpty(cbo_rr1_001_inc.Text) ? cbo_rr1_001_inc.Text : cbo_rr1_ref_inc.Text;
        Standard.EPF_RR2 = !string.IsNullOrEmpty(cbo_rr2_007_inc.Text) ? cbo_rr2_007_inc.Text : !string.IsNullOrEmpty(cbo_rr2_006_inc.Text) ? cbo_rr2_006_inc.Text : !string.IsNullOrEmpty(cbo_rr2_005_inc.Text) ? cbo_rr2_005_inc.Text : !string.IsNullOrEmpty(cbo_rr2_004_inc.Text) ? cbo_rr2_004_inc.Text : !string.IsNullOrEmpty(cbo_rr2_003_inc.Text) ? cbo_rr2_003_inc.Text : !string.IsNullOrEmpty(cbo_rr2_002_inc.Text) ? cbo_rr2_002_inc.Text : !string.IsNullOrEmpty(cbo_rr2_001_inc.Text) ? cbo_rr2_001_inc.Text : cbo_rr2_ref_inc.Text;
        Standard.EPF_R2A = !string.IsNullOrEmpty(cbo_r2a_007_inc.Text) ? cbo_r2a_007_inc.Text : !string.IsNullOrEmpty(cbo_r2a_006_inc.Text) ? cbo_r2a_006_inc.Text : !string.IsNullOrEmpty(cbo_r2a_005_inc.Text) ? cbo_r2a_005_inc.Text : !string.IsNullOrEmpty(cbo_r2a_004_inc.Text) ? cbo_r2a_004_inc.Text : !string.IsNullOrEmpty(cbo_r2a_003_inc.Text) ? cbo_r2a_003_inc.Text : !string.IsNullOrEmpty(cbo_r2a_002_inc.Text) ? cbo_r2a_002_inc.Text : !string.IsNullOrEmpty(cbo_r2a_001_inc.Text) ? cbo_r2a_001_inc.Text : cbo_r2a_ref_inc.Text;
        Standard.EPF_RR3 = !string.IsNullOrEmpty(cbo_rr3_007_inc.Text) ? cbo_rr3_007_inc.Text : !string.IsNullOrEmpty(cbo_rr3_006_inc.Text) ? cbo_rr3_006_inc.Text : !string.IsNullOrEmpty(cbo_rr3_005_inc.Text) ? cbo_rr3_005_inc.Text : !string.IsNullOrEmpty(cbo_rr3_004_inc.Text) ? cbo_rr3_004_inc.Text : !string.IsNullOrEmpty(cbo_rr3_003_inc.Text) ? cbo_rr3_003_inc.Text : !string.IsNullOrEmpty(cbo_rr3_002_inc.Text) ? cbo_rr3_002_inc.Text : !string.IsNullOrEmpty(cbo_rr3_001_inc.Text) ? cbo_rr3_001_inc.Text : cbo_rr3_ref_inc.Text;
        Standard.EPF_RWR = !string.IsNullOrEmpty(cbo_rwr_007_inc.Text) ? cbo_rwr_007_inc.Text : !string.IsNullOrEmpty(cbo_rwr_006_inc.Text) ? cbo_rwr_006_inc.Text : !string.IsNullOrEmpty(cbo_rwr_005_inc.Text) ? cbo_rwr_005_inc.Text : !string.IsNullOrEmpty(cbo_rwr_004_inc.Text) ? cbo_rwr_004_inc.Text : !string.IsNullOrEmpty(cbo_rwr_003_inc.Text) ? cbo_rwr_003_inc.Text : !string.IsNullOrEmpty(cbo_rwr_002_inc.Text) ? cbo_rwr_002_inc.Text : !string.IsNullOrEmpty(cbo_rwr_001_inc.Text) ? cbo_rwr_001_inc.Text : cbo_rwr_ref_inc.Text;
        Standard.EPF_STD = !string.IsNullOrEmpty(txt_std_007_inc.Text) ? txt_std_007_inc.Text : !string.IsNullOrEmpty(txt_std_006_inc.Text) ? txt_std_006_inc.Text : !string.IsNullOrEmpty(txt_std_005_inc.Text) ? txt_std_005_inc.Text : !string.IsNullOrEmpty(txt_std_004_inc.Text) ? txt_std_004_inc.Text : !string.IsNullOrEmpty(txt_std_003_inc.Text) ? txt_std_003_inc.Text : !string.IsNullOrEmpty(txt_std_002_inc.Text) ? txt_std_002_inc.Text : !string.IsNullOrEmpty(txt_std_001_inc.Text) ? txt_std_001_inc.Text : txt_std_ref_inc.Text;
        Standard.EPF_STP = !string.IsNullOrEmpty(txt_stp_007_inc.Text) ? txt_stp_007_inc.Text : !string.IsNullOrEmpty(txt_stp_006_inc.Text) ? txt_stp_006_inc.Text : !string.IsNullOrEmpty(txt_stp_005_inc.Text) ? txt_stp_005_inc.Text : !string.IsNullOrEmpty(txt_stp_004_inc.Text) ? txt_stp_004_inc.Text : !string.IsNullOrEmpty(txt_stp_003_inc.Text) ? txt_stp_003_inc.Text : !string.IsNullOrEmpty(txt_stp_002_inc.Text) ? txt_stp_002_inc.Text : !string.IsNullOrEmpty(txt_stp_001_inc.Text) ? txt_stp_001_inc.Text : txt_stp_ref_inc.Text;
        Standard.EPF_TTD = !string.IsNullOrEmpty(txt_ttd_007_inc.Text) ? txt_ttd_007_inc.Text : !string.IsNullOrEmpty(txt_ttd_006_inc.Text) ? txt_ttd_006_inc.Text : !string.IsNullOrEmpty(txt_ttd_005_inc.Text) ? txt_ttd_005_inc.Text : !string.IsNullOrEmpty(txt_ttd_004_inc.Text) ? txt_ttd_004_inc.Text : !string.IsNullOrEmpty(txt_ttd_003_inc.Text) ? txt_ttd_003_inc.Text : !string.IsNullOrEmpty(txt_ttd_002_inc.Text) ? txt_ttd_002_inc.Text : !string.IsNullOrEmpty(txt_ttd_001_inc.Text) ? txt_ttd_001_inc.Text : txt_ttd_ref_inc.Text;
        Standard.EPF_TTP = !string.IsNullOrEmpty(txt_ttp_007_inc.Text) ? txt_ttp_007_inc.Text : !string.IsNullOrEmpty(txt_ttp_006_inc.Text) ? txt_ttp_006_inc.Text : !string.IsNullOrEmpty(txt_ttp_005_inc.Text) ? txt_ttp_005_inc.Text : !string.IsNullOrEmpty(txt_ttp_004_inc.Text) ? txt_ttp_004_inc.Text : !string.IsNullOrEmpty(txt_ttp_003_inc.Text) ? txt_ttp_003_inc.Text : !string.IsNullOrEmpty(txt_ttp_002_inc.Text) ? txt_ttp_002_inc.Text : !string.IsNullOrEmpty(txt_ttp_001_inc.Text) ? txt_ttp_001_inc.Text : txt_ttp_ref_inc.Text;
        Standard.EPF_FTD = !string.IsNullOrEmpty(txt_ftd_007_inc.Text) ? txt_ftd_007_inc.Text : !string.IsNullOrEmpty(txt_ftd_006_inc.Text) ? txt_ftd_006_inc.Text : !string.IsNullOrEmpty(txt_ftd_005_inc.Text) ? txt_ftd_005_inc.Text : !string.IsNullOrEmpty(txt_ftd_004_inc.Text) ? txt_ftd_004_inc.Text : !string.IsNullOrEmpty(txt_ftd_003_inc.Text) ? txt_ftd_003_inc.Text : !string.IsNullOrEmpty(txt_ftd_002_inc.Text) ? txt_ftd_002_inc.Text : !string.IsNullOrEmpty(txt_ftd_001_inc.Text) ? txt_ftd_001_inc.Text : txt_ftd_ref_inc.Text;
        Standard.EPF_FTP = !string.IsNullOrEmpty(txt_ftp_007_inc.Text) ? txt_ftp_007_inc.Text : !string.IsNullOrEmpty(txt_ftp_006_inc.Text) ? txt_ftp_006_inc.Text : !string.IsNullOrEmpty(txt_ftp_005_inc.Text) ? txt_ftp_005_inc.Text : !string.IsNullOrEmpty(txt_ftp_004_inc.Text) ? txt_ftp_004_inc.Text : !string.IsNullOrEmpty(txt_ftp_003_inc.Text) ? txt_ftp_003_inc.Text : !string.IsNullOrEmpty(txt_ftp_002_inc.Text) ? txt_ftp_002_inc.Text : !string.IsNullOrEmpty(txt_ftp_001_inc.Text) ? txt_ftp_001_inc.Text : txt_ftp_ref_inc.Text;
        Standard.EPF_ITD = !string.IsNullOrEmpty(txt_itd_007_inc.Text) ? txt_itd_007_inc.Text : !string.IsNullOrEmpty(txt_itd_006_inc.Text) ? txt_itd_006_inc.Text : !string.IsNullOrEmpty(txt_itd_005_inc.Text) ? txt_itd_005_inc.Text : !string.IsNullOrEmpty(txt_itd_004_inc.Text) ? txt_itd_004_inc.Text : !string.IsNullOrEmpty(txt_itd_003_inc.Text) ? txt_itd_003_inc.Text : !string.IsNullOrEmpty(txt_itd_002_inc.Text) ? txt_itd_002_inc.Text : !string.IsNullOrEmpty(txt_itd_001_inc.Text) ? txt_itd_001_inc.Text : txt_itd_ref_inc.Text;
        Standard.EPF_ITP = !string.IsNullOrEmpty(txt_itp_007_inc.Text) ? txt_itp_007_inc.Text : !string.IsNullOrEmpty(txt_itp_006_inc.Text) ? txt_itp_006_inc.Text : !string.IsNullOrEmpty(txt_itp_005_inc.Text) ? txt_itp_005_inc.Text : !string.IsNullOrEmpty(txt_itp_004_inc.Text) ? txt_itp_004_inc.Text : !string.IsNullOrEmpty(txt_itp_003_inc.Text) ? txt_itp_003_inc.Text : !string.IsNullOrEmpty(txt_itp_002_inc.Text) ? txt_itp_002_inc.Text : !string.IsNullOrEmpty(txt_itp_001_inc.Text) ? txt_itp_001_inc.Text : txt_itp_ref_inc.Text;
        Standard.EPF_XTD = !string.IsNullOrEmpty(txt_xtd_007_inc.Text) ? txt_xtd_007_inc.Text : !string.IsNullOrEmpty(txt_xtd_006_inc.Text) ? txt_xtd_006_inc.Text : !string.IsNullOrEmpty(txt_xtd_005_inc.Text) ? txt_xtd_005_inc.Text : !string.IsNullOrEmpty(txt_xtd_004_inc.Text) ? txt_xtd_004_inc.Text : !string.IsNullOrEmpty(txt_xtd_003_inc.Text) ? txt_xtd_003_inc.Text : !string.IsNullOrEmpty(txt_xtd_002_inc.Text) ? txt_xtd_002_inc.Text : !string.IsNullOrEmpty(txt_xtd_001_inc.Text) ? txt_xtd_001_inc.Text : txt_xtd_ref_inc.Text;
        Standard.EPF_XTP = !string.IsNullOrEmpty(txt_xtp_007_inc.Text) ? txt_xtp_007_inc.Text : !string.IsNullOrEmpty(txt_xtp_006_inc.Text) ? txt_xtp_006_inc.Text : !string.IsNullOrEmpty(txt_xtp_005_inc.Text) ? txt_xtp_005_inc.Text : !string.IsNullOrEmpty(txt_xtp_004_inc.Text) ? txt_xtp_004_inc.Text : !string.IsNullOrEmpty(txt_xtp_003_inc.Text) ? txt_xtp_003_inc.Text : !string.IsNullOrEmpty(txt_xtp_002_inc.Text) ? txt_xtp_002_inc.Text : !string.IsNullOrEmpty(txt_xtp_001_inc.Text) ? txt_xtp_001_inc.Text : txt_xtp_ref_inc.Text;
        Standard.EPF_TTR = !string.IsNullOrEmpty(txt_ttr_007_inc.Text) ? txt_ttr_007_inc.Text : !string.IsNullOrEmpty(txt_ttr_006_inc.Text) ? txt_ttr_006_inc.Text : !string.IsNullOrEmpty(txt_ttr_005_inc.Text) ? txt_ttr_005_inc.Text : !string.IsNullOrEmpty(txt_ttr_004_inc.Text) ? txt_ttr_004_inc.Text : !string.IsNullOrEmpty(txt_ttr_003_inc.Text) ? txt_ttr_003_inc.Text : !string.IsNullOrEmpty(txt_ttr_002_inc.Text) ? txt_ttr_002_inc.Text : !string.IsNullOrEmpty(txt_ttr_001_inc.Text) ? txt_ttr_001_inc.Text : txt_ttr_ref_inc.Text;        
        Standard.EPF_DET = txt_det_inc.Text;

        Standard.EPF_STS = 1; //Ativo

        // Nunca Atualiza, Inativa os Anteriores e Inclui um novo
        string sMsg = "";
        /*
        sMsg = Standard.Inserir();

        if (sMsg.Substring(0, 1) == "E")
        {
            Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
        }
        else
        {
            TratamentoErro("Standard Atualizado com sucesso.");
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
            //Salva o novo Standard com uma versão a mais.
            Standard oEPF = new Standard();
            oEPF.EPF_LOT = txt_lot_inc.Text;
            DataSet dsEPF = oEPF.ConsultarUltimaVersao();
            if (dsEPF.Tables[0].Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dsEPF.Tables[0].Rows[0]["EPF_VRS"].ToString()))
                {
                    Standard.EPF_VRS = Convert.ToInt32(dsEPF.Tables[0].Rows[0]["EPF_VRS"].ToString()) + 1;
                }
                else
                {
                    Standard.EPF_VRS = 1;
                }
            }
            else
            {
                Standard.EPF_VRS = 1;
            }
            Standard.EPF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = Standard.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));
            }
            else
            {
                TratamentoErro("Standard atualizado com sucesso.");
            }
        }
    }

    private void CarregaItem(int i, string sItem, DataSet dsTeste, string sFormato = "")
    {
        string sPos = "";
        if (i == 0)
        {
            sPos = "_REF";
        }
        else
        {
            sPos = "_00" + i;
        }

        if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[i]["TST_" + sItem.ToUpper()].ToString()))
        {
            TextBox lb_item = (TextBox)dvResultado.FindControl("txt_" + sItem + sPos + "_inc");
            if (string.IsNullOrEmpty(sFormato))
            {
                try
                {
                    lb_item.Text = dsTeste.Tables[0].Rows[i]["TST_" + sItem.ToUpper()].ToString();
                }
                catch
                {
                    Response.Write("txt_" + sItem + sPos);
                    Response.End();
                }
            }
            else
            {
                lb_item.Text = Convert.ToDouble(dsTeste.Tables[0].Rows[i]["TST_" + sItem.ToUpper()].ToString()).ToString(sFormato);
            }
        }
    }

    private void CarregaItemCombo(int i, string sItem, DataSet dsTeste)
    {
        string sPos = "";
        if (i == 0)
        {
            sPos = "_REF";
        }
        else
        {
            sPos = "_00" + i;
        }

        string sCombo = sItem;
        switch (sItem)
        {
            case "ctx":
                sCombo = "ez1_ez2";
                break;
            case "cvx":
                sCombo = "ez3_ez4";
                break;
            case "cvr":
                sCombo = "ez5_ez6";
                break;
        }

        if (!string.IsNullOrEmpty(dsTeste.Tables[0].Rows[i]["TST_" + sItem.ToUpper()].ToString()))
        {
            DropDownList cbo_item = (DropDownList)dvResultado.FindControl("cbo_" + sCombo + sPos + "_inc");
            try
            {
                cbo_item.SelectedValue = dsTeste.Tables[0].Rows[i]["TST_" + sItem.ToUpper()].ToString();
            }
            catch
            {
                Response.Write("cbo_" + sCombo + sPos);
                Response.End();
            }
        }
    }

    private void SalvaItem(int i, Teste Teste)
    {
        string sPos = "";
        if (i == 0)
        {
            sPos = "_ref";
        }
        else
        {
            sPos = "_00" + i;
        }

        TextBox txt_itm = (TextBox)dvResultado.FindControl("txt_vw2" + sPos + "_inc");
        Teste.TST_VW2 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_egm" + sPos + "_inc");
        Teste.TST_EGM = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dyy" + sPos + "_inc");
        Teste.TST_DYY = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_2wx" + sPos + "_inc");
        Teste.TST_2WX = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_3w3" + sPos + "_inc");
        Teste.TST_3W3 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_4w4" + sPos + "_inc");
        Teste.TST_4W4 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_agl" + sPos + "_inc");
        Teste.TST_AGL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tup" + sPos + "_inc");
        Teste.TST_TUP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_veo" + sPos + "_inc");
        Teste.TST_VEO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_t1t" + sPos + "_inc");
        Teste.TST_T1T = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_t1c" + sPos + "_inc");
        Teste.TST_T1C = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_t1l" + sPos + "_inc");
        Teste.TST_T1L = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_t2f" + sPos + "_inc");
        Teste.TST_T2F = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sve" + sPos + "_inc");
        Teste.TST_SVE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_stf" + sPos + "_inc");
        Teste.TST_STF = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_stm" + sPos + "_inc");
        Teste.TST_STM = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sce" + sPos + "_inc");
        Teste.TST_SCE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sco" + sPos + "_inc");
        Teste.TST_SCO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sch" + sPos + "_inc");
        Teste.TST_SCH = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_scg" + sPos + "_inc");
        Teste.TST_SCG = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_see" + sPos + "_inc");
        Teste.TST_SEE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_seo" + sPos + "_inc");
        Teste.TST_SEO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_seh" + sPos + "_inc");
        Teste.TST_SEH = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_seg" + sPos + "_inc");
        Teste.TST_SEG = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sjc" + sPos + "_inc");
        Teste.TST_SJC = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sjt" + sPos + "_inc");
        Teste.TST_SJT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sjb" + sPos + "_inc");
        Teste.TST_SJB = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_spj" + sPos + "_inc");
        Teste.TST_SPJ = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sbc" + sPos + "_inc");
        Teste.TST_SBC = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_spo" + sPos + "_inc");
        Teste.TST_SPO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sva" + sPos + "_inc");
        Teste.TST_SVA = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tgr" + sPos + "_inc");
        Teste.TST_TGR = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tip" + sPos + "_inc");
        Teste.TST_TIP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dsb" + sPos + "_inc");
        Teste.TST_DSB = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tca" + sPos + "_inc");
        Teste.TST_TCA = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_fmc" + sPos + "_inc");
        Teste.TST_FMC = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_1tb" + sPos + "_inc");
        Teste.TST_1TB = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_1pp" + sPos + "_inc");
        Teste.TST_1PP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_2tb" + sPos + "_inc");
        Teste.TST_2TB = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_2pp" + sPos + "_inc");
        Teste.TST_2PP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_cso" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CSO = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_esp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ESP = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tol" + sPos + "_inc");
        Teste.TST_TOL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_p1c" + sPos + "_inc");
        Teste.TST_P1C = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_p2d" + sPos + "_inc");
        Teste.TST_P2D = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_p3d" + sPos + "_inc");
        Teste.TST_P3D = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_p4u" + sPos + "_inc");
        Teste.TST_P4U = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_mol" + sPos + "_inc");
        Teste.TST_MOL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tpd" + sPos + "_inc");
        Teste.TST_TPD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tt1" + sPos + "_inc");
        Teste.TST_TT1 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tt2" + sPos + "_inc");
        Teste.TST_TT2 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tt3" + sPos + "_inc");
        Teste.TST_TT3 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_t21" + sPos + "_inc");
        Teste.TST_T21 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tun" + sPos + "_inc");
        Teste.TST_TUN = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tcv" + sPos + "_inc");
        Teste.TST_TCV = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tss" + sPos + "_inc");
        Teste.TST_TSS = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tit" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TIT = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tnc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TNC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_aon" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_AON = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_enm" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ENM = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_eee" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_EEE = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_kkk" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_KKK = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_bbb" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_BBB = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ole" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_OLE = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_trq" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TRQ = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ert" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ERT = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_rt3" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_RT3 = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_rt5" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_RT5 = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dnd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DND = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dmo" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DMO = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_pes" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_PES = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_vrr" + sPos + "_inc");
        Teste.TST_VRR = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tre" + sPos + "_inc");
        Teste.TST_TRE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_lme" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LME = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ume" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UME = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_lpe" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LPE = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_upe" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UPE = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ucv" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UCV = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_lcv" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LCV = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dur" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DUR = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dft" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DFT = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_lmc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LMC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_umc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UMC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_lpc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LPC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_upc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UPC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_lvc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_LVC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dfc" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DFC = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tfs" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TFS = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_fsw" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_FSW = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_wfw" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_WFW = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ybt" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_YBT = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_eco" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ECO = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_eol" + sPos + "_inc");
        Teste.TST_EOL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_etu" + sPos + "_inc");
        Teste.TST_ETU = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_etd" + sPos + "_inc");
        Teste.TST_ETD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ecu" + sPos + "_inc");
        Teste.TST_ECU = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_egd" + sPos + "_inc");
        Teste.TST_EGD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eec" + sPos + "_inc");
        Teste.TST_EEC = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ecd" + sPos + "_inc");
        Teste.TST_ECD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_egu" + sPos + "_inc");
        Teste.TST_EGU = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eso" + sPos + "_inc");
        Teste.TST_ESO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_esi" + sPos + "_inc");
        Teste.TST_ESI = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ecr" + sPos + "_inc");
        Teste.TST_ECR = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eod" + sPos + "_inc");
        Teste.TST_EOD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eaw" + sPos + "_inc");
        Teste.TST_EAW = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ed1" + sPos + "_inc");
        Teste.TST_ED1 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ed2" + sPos + "_inc");
        Teste.TST_ED2 = txt_itm.Text;
        DropDownList cbo_itm = (DropDownList)dvResultado.FindControl("cbo_idd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_IDD = cbo_itm.SelectedItem.Value;
        }

        txt_itm = (TextBox)dvResultado.FindControl("txt_eta" + sPos + "_inc");
        Teste.TST_ETA = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eth" + sPos + "_inc");
        Teste.TST_ETH = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_etg" + sPos + "_inc");
        Teste.TST_ETG = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_edt" + sPos + "_inc");
        Teste.TST_EDT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_efp" + sPos + "_inc");
        Teste.TST_EFP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eyt" + sPos + "_inc");
        Teste.TST_EYT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_edl" + sPos + "_inc");
        Teste.TST_EDL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eab" + sPos + "_inc");
        Teste.TST_EAB = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_eca" + sPos + "_inc");
        Teste.TST_ECA = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ecw" + sPos + "_inc");
        Teste.TST_ECW = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_etl" + sPos + "_inc");
        Teste.TST_ETL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ett" + sPos + "_inc");
        Teste.TST_ETT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ere" + sPos + "_inc");
        Teste.TST_ERE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ele" + sPos + "_inc");
        Teste.TST_ELE = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ept" + sPos + "_inc");
        Teste.TST_EPT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_epl" + sPos + "_inc");
        Teste.TST_EPL = txt_itm.Text;

        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_ez1_ez2" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_CTX = Convert.ToInt32(cbo_itm.SelectedItem.Value);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_ez3_ez4" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
        Teste.TST_CVX = Convert.ToInt32(cbo_itm.SelectedItem.Value);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_ez5_ez6" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_CVR = Convert.ToInt32(cbo_itm.SelectedItem.Value);
        }

        txt_itm = (TextBox)dvResultado.FindControl("txt_pco" + sPos + "_inc");
        Teste.TST_PCO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_pcv" + sPos + "_inc");
        Teste.TST_PCV = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_drt" + sPos + "_inc");
        Teste.TST_DRT = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tal" + sPos + "_inc");
        Teste.TST_TAL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_val" + sPos + "_inc");
        Teste.TST_VAL = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_sje" + sPos + "_inc");
        Teste.TST_SJE = txt_itm.Text;
        //TMT
        txt_itm = (TextBox)dvResultado.FindControl("txt_hot" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_HOT = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_vrd" + sPos + "_inc");
        Teste.TST_VRD = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_acr" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ACR = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_pen" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_PEN = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cra" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CRA = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cle" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CLE = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_afo" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_AFO = Convert.ToInt32(txt_itm.Text);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_tcu" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_TCU = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tar" + sPos + "_inc");
        Teste.TST_TAR = txt_itm.Text;
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_tam" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_TAM = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dtu" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DTU = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_dpa" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_DPA = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cin" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CIN = Convert.ToInt32(txt_itm.Text);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_tip_fr2" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_TIP_FR2 = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_fr2" + sPos + "_inc");
        Teste.TST_FR2 = txt_itm.Text;
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_tip_fr1" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_TIP_FR1 = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_fr1" + sPos + "_inc");
        Teste.TST_FR1 = txt_itm.Text;
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_tip_fr0" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_TIP_FR0 = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_fr0" + sPos + "_inc");
        Teste.TST_FR0 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ato" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ATO = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tp1" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TP1 = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tp2" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TP2 = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tcp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TCP = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_jf2" + sPos + "_inc");
        Teste.TST_JF2 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ps2" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_PS2 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_jf0" + sPos + "_inc");
        Teste.TST_JF0 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ps0" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_PS0 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_bba" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_BBA = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_gro" + sPos + "_inc");
        Teste.TST_GRO = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_tcs" + sPos + "_inc");
        Teste.TST_TCS = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvp" + sPos + "_inc");
        Teste.TST_CVP = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ssv" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_SSV = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ssp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_SSP = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tte_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TTE_001 = Convert.ToDouble(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tte_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TTE_002 = Convert.ToDouble(txt_itm.Text);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_wpo_001" + sPos + "_inc");
        Teste.TST_WPO_001 = cbo_itm.SelectedValue;
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_wpo_002" + sPos + "_inc");
        Teste.TST_WPO_002 = cbo_itm.SelectedValue;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dir_001" + sPos + "_inc");
        Teste.TST_DIR_001 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dir_002" + sPos + "_inc");
        Teste.TST_DIR_002 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_cra_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CRA_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cra_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CRA_002 = Convert.ToInt32(txt_itm.Text);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_ced_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_CED_001 = cbo_itm.SelectedItem.Value;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_ced_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.SelectedItem.Value))
        {
            Teste.TST_CED_002 = cbo_itm.SelectedItem.Value;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ted_001" + sPos + "_inc");
        Teste.TST_TED_001 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_ted_002" + sPos + "_inc");
        Teste.TST_TED_002 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dle_001" + sPos + "_inc");
        Teste.TST_DLE_001 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_dle_002" + sPos + "_inc");
        Teste.TST_DLE_002 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_cti_001" + sPos + "_inc");
        Teste.TST_CTI_001 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_cti_002" + sPos + "_inc");
        Teste.TST_CTI_002 = txt_itm.Text;
        txt_itm = (TextBox)dvResultado.FindControl("txt_g1o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G1O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g1o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G1O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g1u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G1U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g1u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G1U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g2o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G2O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g2o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G2O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g2u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G2U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_g2u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_G2U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvp_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVP_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvp_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVP_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ocu_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_OCU_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ocu_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_OCU_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ucu_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UCU_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ucu_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_UCU_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c1o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C1O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c1o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C1O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l1o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L1O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l1o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L1O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c1u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C1U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c1u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C1U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l1u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L1U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l1u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L1U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c2o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C2O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c2o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C2O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l2o_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L2O_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l2o_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L2O_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c2u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C2U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_c2u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_C2U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l2u_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L2U_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_l2u_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_L2U_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tsu_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TSU_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tsu_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TSU_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvc_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVC_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvc_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVC_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvl_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVL_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_cvl_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_CVL_002 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tle_001" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TLE_001 = Convert.ToInt32(txt_itm.Text);
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_tle_002" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TLE_002 = Convert.ToInt32(txt_itm.Text);
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_roi" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_ROI = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_rr0" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_RR0 = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_r01" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_R01 = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_rr1" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_RR1 = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_rr2" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_RR2 = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_r2a" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_R2A = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_rr3" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_RR3 = cbo_itm.Text;
        }
        cbo_itm = (DropDownList)dvResultado.FindControl("cbo_rwr" + sPos + "_inc");
        if (!string.IsNullOrEmpty(cbo_itm.Text))
        {
            Teste.TST_RWR = cbo_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_std" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_STD = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_stp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_STP = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ttd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TTD = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ttp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TTP = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ftd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_FTD = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ftp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_FTP = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_itd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ITD = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_itp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_ITP = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_xtd" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_XTD = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_xtp" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_XTP = txt_itm.Text;
        }
        txt_itm = (TextBox)dvResultado.FindControl("txt_ttr" + sPos + "_inc");
        if (!string.IsNullOrEmpty(txt_itm.Text))
        {
            Teste.TST_TTR = txt_itm.Text;
        }
    }

    protected void cbo_tam_ref_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_ref_inc.SelectedValue == "1")
        {
            txt_std_ref_inc.ReadOnly = false;
            txt_stp_ref_inc.ReadOnly = false;
            txt_ttd_ref_inc.ReadOnly = false;
            txt_ttp_ref_inc.ReadOnly = false;
            txt_ftd_ref_inc.ReadOnly = false;
            txt_ftp_ref_inc.ReadOnly = false;
            txt_itd_ref_inc.ReadOnly = false;
            txt_itp_ref_inc.ReadOnly = false;
            txt_xtd_ref_inc.ReadOnly = false;
            txt_xtp_ref_inc.ReadOnly = false;
        }
        else
        {
            txt_std_ref_inc.Text = "";
            txt_stp_ref_inc.Text = "";
            txt_ttd_ref_inc.Text = "";
            txt_ttp_ref_inc.Text = "";
            txt_ftd_ref_inc.Text = "";
            txt_ftp_ref_inc.Text = "";
            txt_itd_ref_inc.Text = "";
            txt_itp_ref_inc.Text = "";
            txt_xtd_ref_inc.Text = "";
            txt_xtp_ref_inc.Text = "";

            txt_std_ref_inc.ReadOnly = true;
            txt_stp_ref_inc.ReadOnly = true;
            txt_ttd_ref_inc.ReadOnly = true;
            txt_ttp_ref_inc.ReadOnly = true;
            txt_ftd_ref_inc.ReadOnly = true;
            txt_ftp_ref_inc.ReadOnly = true;
            txt_itd_ref_inc.ReadOnly = true;
            txt_itp_ref_inc.ReadOnly = true;
            txt_xtd_ref_inc.ReadOnly = true;
            txt_xtp_ref_inc.ReadOnly = true;
        }

        cbo_tam_ref_inc.Focus();

    }

    protected void cbo_tam_001_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_001_inc.SelectedValue == "1")
        {
            txt_std_001_inc.ReadOnly = false;
            txt_stp_001_inc.ReadOnly = false;
            txt_ttd_001_inc.ReadOnly = false;
            txt_ttp_001_inc.ReadOnly = false;
            txt_ftd_001_inc.ReadOnly = false;
            txt_ftp_001_inc.ReadOnly = false;
            txt_itd_001_inc.ReadOnly = false;
            txt_itp_001_inc.ReadOnly = false;
            txt_xtd_001_inc.ReadOnly = false;
            txt_xtp_001_inc.ReadOnly = false;
        }
        else
        {
            txt_std_001_inc.Text = "";
            txt_stp_001_inc.Text = "";
            txt_ttd_001_inc.Text = "";
            txt_ttp_001_inc.Text = "";
            txt_ftd_001_inc.Text = "";
            txt_ftp_001_inc.Text = "";
            txt_itd_001_inc.Text = "";
            txt_itp_001_inc.Text = "";
            txt_xtd_001_inc.Text = "";
            txt_xtp_001_inc.Text = "";

            txt_std_001_inc.ReadOnly = true;
            txt_stp_001_inc.ReadOnly = true;
            txt_ttd_001_inc.ReadOnly = true;
            txt_ttp_001_inc.ReadOnly = true;
            txt_ftd_001_inc.ReadOnly = true;
            txt_ftp_001_inc.ReadOnly = true;
            txt_itd_001_inc.ReadOnly = true;
            txt_itp_001_inc.ReadOnly = true;
            txt_xtd_001_inc.ReadOnly = true;
            txt_xtp_001_inc.ReadOnly = true;
        }

        cbo_tam_001_inc.Focus();

    }

    protected void cbo_tam_002_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_002_inc.SelectedValue == "1")
        {
            txt_std_002_inc.ReadOnly = false;
            txt_stp_002_inc.ReadOnly = false;
            txt_ttd_002_inc.ReadOnly = false;
            txt_ttp_002_inc.ReadOnly = false;
            txt_ftd_002_inc.ReadOnly = false;
            txt_ftp_002_inc.ReadOnly = false;
            txt_itd_002_inc.ReadOnly = false;
            txt_itp_002_inc.ReadOnly = false;
            txt_xtd_002_inc.ReadOnly = false;
            txt_xtp_002_inc.ReadOnly = false;
        }
        else
        {
            txt_std_002_inc.Text = "";
            txt_stp_002_inc.Text = "";
            txt_ttd_002_inc.Text = "";
            txt_ttp_002_inc.Text = "";
            txt_ftd_002_inc.Text = "";
            txt_ftp_002_inc.Text = "";
            txt_itd_002_inc.Text = "";
            txt_itp_002_inc.Text = "";
            txt_xtd_002_inc.Text = "";
            txt_xtp_002_inc.Text = "";

            txt_std_002_inc.ReadOnly = true;
            txt_stp_002_inc.ReadOnly = true;
            txt_ttd_002_inc.ReadOnly = true;
            txt_ttp_002_inc.ReadOnly = true;
            txt_ftd_002_inc.ReadOnly = true;
            txt_ftp_002_inc.ReadOnly = true;
            txt_itd_002_inc.ReadOnly = true;
            txt_itp_002_inc.ReadOnly = true;
            txt_xtd_002_inc.ReadOnly = true;
            txt_xtp_002_inc.ReadOnly = true;
        }

        cbo_tam_002_inc.Focus();

    }

    protected void cbo_tam_003_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_003_inc.SelectedValue == "1")
        {
            txt_std_003_inc.ReadOnly = false;
            txt_stp_003_inc.ReadOnly = false;
            txt_ttd_003_inc.ReadOnly = false;
            txt_ttp_003_inc.ReadOnly = false;
            txt_ftd_003_inc.ReadOnly = false;
            txt_ftp_003_inc.ReadOnly = false;
            txt_itd_003_inc.ReadOnly = false;
            txt_itp_003_inc.ReadOnly = false;
            txt_xtd_003_inc.ReadOnly = false;
            txt_xtp_003_inc.ReadOnly = false;
        }
        else
        {
            txt_std_003_inc.Text = "";
            txt_stp_003_inc.Text = "";
            txt_ttd_003_inc.Text = "";
            txt_ttp_003_inc.Text = "";
            txt_ftd_003_inc.Text = "";
            txt_ftp_003_inc.Text = "";
            txt_itd_003_inc.Text = "";
            txt_itp_003_inc.Text = "";
            txt_xtd_003_inc.Text = "";
            txt_xtp_003_inc.Text = "";

            txt_std_003_inc.ReadOnly = true;
            txt_stp_003_inc.ReadOnly = true;
            txt_ttd_003_inc.ReadOnly = true;
            txt_ttp_003_inc.ReadOnly = true;
            txt_ftd_003_inc.ReadOnly = true;
            txt_ftp_003_inc.ReadOnly = true;
            txt_itd_003_inc.ReadOnly = true;
            txt_itp_003_inc.ReadOnly = true;
            txt_xtd_003_inc.ReadOnly = true;
            txt_xtp_003_inc.ReadOnly = true;
        }

        cbo_tam_003_inc.Focus();

    }

    protected void cbo_tam_004_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_004_inc.SelectedValue == "1")
        {
            txt_std_004_inc.ReadOnly = false;
            txt_stp_004_inc.ReadOnly = false;
            txt_ttd_004_inc.ReadOnly = false;
            txt_ttp_004_inc.ReadOnly = false;
            txt_ftd_004_inc.ReadOnly = false;
            txt_ftp_004_inc.ReadOnly = false;
            txt_itd_004_inc.ReadOnly = false;
            txt_itp_004_inc.ReadOnly = false;
            txt_xtd_004_inc.ReadOnly = false;
            txt_xtp_004_inc.ReadOnly = false;
        }
        else
        {
            txt_std_004_inc.Text = "";
            txt_stp_004_inc.Text = "";
            txt_ttd_004_inc.Text = "";
            txt_ttp_004_inc.Text = "";
            txt_ftd_004_inc.Text = "";
            txt_ftp_004_inc.Text = "";
            txt_itd_004_inc.Text = "";
            txt_itp_004_inc.Text = "";
            txt_xtd_004_inc.Text = "";
            txt_xtp_004_inc.Text = "";

            txt_std_004_inc.ReadOnly = true;
            txt_stp_004_inc.ReadOnly = true;
            txt_ttd_004_inc.ReadOnly = true;
            txt_ttp_004_inc.ReadOnly = true;
            txt_ftd_004_inc.ReadOnly = true;
            txt_ftp_004_inc.ReadOnly = true;
            txt_itd_004_inc.ReadOnly = true;
            txt_itp_004_inc.ReadOnly = true;
            txt_xtd_004_inc.ReadOnly = true;
            txt_xtp_004_inc.ReadOnly = true;
        }

        cbo_tam_004_inc.Focus();

    }

    protected void cbo_tam_005_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_005_inc.SelectedValue == "1")
        {
            txt_std_005_inc.ReadOnly = false;
            txt_stp_005_inc.ReadOnly = false;
            txt_ttd_005_inc.ReadOnly = false;
            txt_ttp_005_inc.ReadOnly = false;
            txt_ftd_005_inc.ReadOnly = false;
            txt_ftp_005_inc.ReadOnly = false;
            txt_itd_005_inc.ReadOnly = false;
            txt_itp_005_inc.ReadOnly = false;
            txt_xtd_005_inc.ReadOnly = false;
            txt_xtp_005_inc.ReadOnly = false;
        }
        else
        {
            txt_std_005_inc.Text = "";
            txt_stp_005_inc.Text = "";
            txt_ttd_005_inc.Text = "";
            txt_ttp_005_inc.Text = "";
            txt_ftd_005_inc.Text = "";
            txt_ftp_005_inc.Text = "";
            txt_itd_005_inc.Text = "";
            txt_itp_005_inc.Text = "";
            txt_xtd_005_inc.Text = "";
            txt_xtp_005_inc.Text = "";

            txt_std_005_inc.ReadOnly = true;
            txt_stp_005_inc.ReadOnly = true;
            txt_ttd_005_inc.ReadOnly = true;
            txt_ttp_005_inc.ReadOnly = true;
            txt_ftd_005_inc.ReadOnly = true;
            txt_ftp_005_inc.ReadOnly = true;
            txt_itd_005_inc.ReadOnly = true;
            txt_itp_005_inc.ReadOnly = true;
            txt_xtd_005_inc.ReadOnly = true;
            txt_xtp_005_inc.ReadOnly = true;
        }

        cbo_tam_005_inc.Focus();

    }

    protected void cbo_tam_006_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_006_inc.SelectedValue == "1")
        {
            txt_std_006_inc.ReadOnly = false;
            txt_stp_006_inc.ReadOnly = false;
            txt_ttd_006_inc.ReadOnly = false;
            txt_ttp_006_inc.ReadOnly = false;
            txt_ftd_006_inc.ReadOnly = false;
            txt_ftp_006_inc.ReadOnly = false;
            txt_itd_006_inc.ReadOnly = false;
            txt_itp_006_inc.ReadOnly = false;
            txt_xtd_006_inc.ReadOnly = false;
            txt_xtp_006_inc.ReadOnly = false;
        }
        else
        {
            txt_std_006_inc.Text = "";
            txt_stp_006_inc.Text = "";
            txt_ttd_006_inc.Text = "";
            txt_ttp_006_inc.Text = "";
            txt_ftd_006_inc.Text = "";
            txt_ftp_006_inc.Text = "";
            txt_itd_006_inc.Text = "";
            txt_itp_006_inc.Text = "";
            txt_xtd_006_inc.Text = "";
            txt_xtp_006_inc.Text = "";

            txt_std_006_inc.ReadOnly = true;
            txt_stp_006_inc.ReadOnly = true;
            txt_ttd_006_inc.ReadOnly = true;
            txt_ttp_006_inc.ReadOnly = true;
            txt_ftd_006_inc.ReadOnly = true;
            txt_ftp_006_inc.ReadOnly = true;
            txt_itd_006_inc.ReadOnly = true;
            txt_itp_006_inc.ReadOnly = true;
            txt_xtd_006_inc.ReadOnly = true;
            txt_xtp_006_inc.ReadOnly = true;
        }

        cbo_tam_006_inc.Focus();

    }

    protected void cbo_tam_007_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbo_tam_007_inc.SelectedValue == "1")
        {
            txt_std_007_inc.ReadOnly = false;
            txt_stp_007_inc.ReadOnly = false;
            txt_ttd_007_inc.ReadOnly = false;
            txt_ttp_007_inc.ReadOnly = false;
            txt_ftd_007_inc.ReadOnly = false;
            txt_ftp_007_inc.ReadOnly = false;
            txt_itd_007_inc.ReadOnly = false;
            txt_itp_007_inc.ReadOnly = false;
            txt_xtd_007_inc.ReadOnly = false;
            txt_xtp_007_inc.ReadOnly = false;
        }
        else
        {
            txt_std_007_inc.Text = "";
            txt_stp_007_inc.Text = "";
            txt_ttd_007_inc.Text = "";
            txt_ttp_007_inc.Text = "";
            txt_ftd_007_inc.Text = "";
            txt_ftp_007_inc.Text = "";
            txt_itd_007_inc.Text = "";
            txt_itp_007_inc.Text = "";
            txt_xtd_007_inc.Text = "";
            txt_xtp_007_inc.Text = "";

            txt_std_007_inc.ReadOnly = true;
            txt_stp_007_inc.ReadOnly = true;
            txt_ttd_007_inc.ReadOnly = true;
            txt_ttp_007_inc.ReadOnly = true;
            txt_ftd_007_inc.ReadOnly = true;
            txt_ftp_007_inc.ReadOnly = true;
            txt_itd_007_inc.ReadOnly = true;
            txt_itp_007_inc.ReadOnly = true;
            txt_xtd_007_inc.ReadOnly = true;
            txt_xtp_007_inc.ReadOnly = true;
        }

        cbo_tam_007_inc.Focus();

    }

}