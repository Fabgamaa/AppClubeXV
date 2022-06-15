using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Teste
    {

        #region Propriedades

        private int? _TST_ID;
        private int? _TST_RTS_ID;
        private int? _TST_RTS_MTV_TST_ID;
        private string _TST_LOT;
        private string _TST_LOT_REF;
        private string _TST_LOT_EPF;
        private string _TST_LOT_ANS;
        private int? _TST_TIT_POY_ID;
        private string _TST_DES;
        private string _TST_MGE;
        private string _TST_MGE_002;
        private string _TST_MGE_003;
        private string _TST_MGE_REF;
        private string _TST_MGE_002_REF;
        private string _TST_MGE_003_REF;
        private int? _TST_FOR_001_ID;
        private int? _TST_FOR_002_ID;
        private int? _TST_FOR_003_ID;
        private string _TST_VLC;
        private int? _TST_APS_ID;
        private int? _TST_MAQ_TIP_ID;
        private int? _TST_ERT_ID;
        private DateTime? _TST_DAT_INI;
        private DateTime? _TST_DAT_FIM;
        private string _TST_VW2_REF;
        private string _TST_EGM_REF;
        private string _TST_DYY_REF;
        private string _TST_2WX_REF;
        private string _TST_3W3_REF;
        private string _TST_4W4_REF;
        private string _TST_AGL_REF;
        private string _TST_TUP_REF;
        private string _TST_VEO_REF;
        private string _TST_T1T_REF;
        private string _TST_T1C_REF;
        private string _TST_T1L_REF;
        private string _TST_T2F_REF;
        private string _TST_SVE_REF;
        private string _TST_STF_REF;
        private string _TST_STM_REF;
        private string _TST_SCE_REF;
        private string _TST_SCO_REF;
        private string _TST_SCH_REF;
        private string _TST_SCG_REF;
        private string _TST_SEE_REF;
        private string _TST_SEO_REF;
        private string _TST_SEH_REF;
        private string _TST_SEG_REF;
        private string _TST_SJC_REF;
        private string _TST_SJT_REF;
        private string _TST_SJB_REF;
        private string _TST_SPJ_REF;
        private string _TST_SBC_REF;
        private string _TST_SPO_REF;
        private string _TST_SVA_REF;
        private string _TST_TGR_REF;
        private string _TST_TIP_REF;
        private string _TST_DSB_REF;
        private string _TST_TCA_REF;
        private string _TST_FMC_REF;
        private string _TST_1TB_REF;
        private string _TST_1PP_REF;
        private string _TST_2TB_REF;
        private string _TST_2PP_REF;
        private string _TST_P1C_REF;
        private string _TST_P2D_REF;
        private string _TST_P3D_REF;
        private string _TST_P4U_REF;
        private string _TST_MOL_REF;
        private string _TST_TPD_REF;
        private string _TST_TT1_REF;
        private string _TST_TT2_REF;
        private string _TST_TT3_REF;
        private string _TST_T21_REF;
        private string _TST_TUN_REF;
        private string _TST_TCV_REF;
        private string _TST_TSS_REF;
        private double? _TST_TIT_REF;
        private double? _TST_TNC_REF;
        private double? _TST_AON_REF;
        private double? _TST_ENM_REF;
        private double? _TST_EEE_REF;
        private double? _TST_KKK_REF;
        private double? _TST_BBB_REF;
        private double? _TST_OLE_REF;
        private double? _TST_TRQ_REF;
        private double? _TST_ERT_REF;
        private double? _TST_RT3_REF;
        private double? _TST_RT5_REF;
        private double? _TST_DND_REF;
        private double? _TST_DMO_REF;
        private double? _TST_PES_REF;
        private string _TST_VRR_REF;
        private string _TST_TRE_REF;
        private double? _TST_LME_REF;
        private double? _TST_UME_REF;
        private double? _TST_LPE_REF;
        private double? _TST_UPE_REF;
        private double? _TST_UCV_REF;
        private double? _TST_CSO_REF;
        private double? _TST_ESP_REF;
        private string _TST_TOL_REF;
        private double? _TST_DUR_REF;
        private double? _TST_DFT_REF;
        private double? _TST_LMC_REF;
        private double? _TST_UMC_REF;
        private double? _TST_LPC_REF;
        private double? _TST_UPC_REF;
        private double? _TST_CVC_REF;
        private double? _TST_DFC_REF;
        private double? _TST_TFS_REF;
        private double? _TST_FSW_REF;
        private double? _TST_WFW_REF;
        private double? _TST_ECO_REF;
        private string _TST_EOL_REF;
        private string _TST_ETU_REF;
        private string _TST_ETD_REF;
        private string _TST_ECU_REF;
        private string _TST_EGD_REF;
        private string _TST_EEC_REF;
        private string _TST_ECD_REF;
        private string _TST_EGU_REF;
        private string _TST_ESO_REF;
        private string _TST_ESI_REF;
        private string _TST_ECR_REF;
        private string _TST_EOD_REF;
        private string _TST_EAW_REF;
        private string _TST_ED1_REF;
        private string _TST_ED2_REF;
        private string _TST_VW2_001;
        private string _TST_EGM_001;
        private string _TST_DYY_001;
        private string _TST_2WX_001;
        private string _TST_3W3_001;
        private string _TST_4W4_001;
        private string _TST_AGL_001;
        private string _TST_TUP_001;
        private string _TST_VEO_001;
        private string _TST_T1T_001;
        private string _TST_T1C_001;
        private string _TST_T1L_001;
        private string _TST_T2F_001;
        private string _TST_SVE_001;
        private string _TST_STF_001;
        private string _TST_STM_001;
        private string _TST_SCE_001;
        private string _TST_SCO_001;
        private string _TST_SCH_001;
        private string _TST_SCG_001;
        private string _TST_SEE_001;
        private string _TST_SEO_001;
        private string _TST_SEH_001;
        private string _TST_SEG_001;
        private string _TST_SJC_001;
        private string _TST_SJT_001;
        private string _TST_SJB_001;
        private string _TST_SPJ_001;
        private string _TST_SBC_001;
        private string _TST_SPO_001;
        private string _TST_SVA_001;
        private string _TST_TGR_001;
        private string _TST_TIP_001;
        private string _TST_DSB_001;
        private string _TST_TCA_001;
        private string _TST_FMC_001;
        private string _TST_1TB_001;
        private string _TST_1PP_001;
        private string _TST_2TB_001;
        private string _TST_2PP_001;
        private string _TST_P1C_001;
        private string _TST_P2D_001;
        private string _TST_P3D_001;
        private string _TST_P4U_001;
        private string _TST_MOL_001;
        private string _TST_TPD_001;
        private string _TST_TT1_001;
        private string _TST_TT2_001;
        private string _TST_TT3_001;
        private string _TST_T21_001;
        private string _TST_TUN_001;
        private string _TST_TCV_001;
        private string _TST_TSS_001;
        private double? _TST_TIT_001;
        private double? _TST_TNC_001;
        private double? _TST_AON_001;
        private double? _TST_ENM_001;
        private double? _TST_EEE_001;
        private double? _TST_KKK_001;
        private double? _TST_BBB_001;
        private double? _TST_OLE_001;
        private double? _TST_TRQ_001;
        private double? _TST_ERT_001;
        private double? _TST_RT3_001;
        private double? _TST_RT5_001;
        private double? _TST_DND_001;
        private double? _TST_DMO_001;
        private double? _TST_PES_001;
        private string _TST_VRR_001;
        private string _TST_TRE_001;
        private double? _TST_LME_001;
        private double? _TST_UME_001;
        private double? _TST_LPE_001;
        private double? _TST_UPE_001;
        private double? _TST_UCV_001;
        private double? _TST_CSO_001;
        private double? _TST_ESP_001;
        private string _TST_TOL_001;
        private double? _TST_DUR_001;
        private double? _TST_DFT_001;
        private double? _TST_LMC_001;
        private double? _TST_UMC_001;
        private double? _TST_LPC_001;
        private double? _TST_UPC_001;
        private double? _TST_CVC_001;
        private double? _TST_DFC_001;
        private double? _TST_TFS_001;
        private double? _TST_FSW_001;
        private double? _TST_WFW_001;
        private double? _TST_ECO_001;
        private string _TST_EOL_001;
        private string _TST_ETU_001;
        private string _TST_ETD_001;
        private string _TST_ECU_001;
        private string _TST_EGD_001;
        private string _TST_EEC_001;
        private string _TST_ECD_001;
        private string _TST_EGU_001;
        private string _TST_ESO_001;
        private string _TST_ESI_001;
        private string _TST_ECR_001;
        private string _TST_EOD_001;
        private string _TST_EAW_001;
        private string _TST_ED1_001;
        private string _TST_ED2_001;
        private string _TST_VW2_002;
        private string _TST_EGM_002;
        private string _TST_DYY_002;
        private string _TST_2WX_002;
        private string _TST_3W3_002;
        private string _TST_4W4_002;
        private string _TST_AGL_002;
        private string _TST_TUP_002;
        private string _TST_VEO_002;
        private string _TST_T1T_002;
        private string _TST_T1C_002;
        private string _TST_T1L_002;
        private string _TST_T2F_002;
        private string _TST_SVE_002;
        private string _TST_STF_002;
        private string _TST_STM_002;
        private string _TST_SCE_002;
        private string _TST_SCO_002;
        private string _TST_SCH_002;
        private string _TST_SCG_002;
        private string _TST_SEE_002;
        private string _TST_SEO_002;
        private string _TST_SEH_002;
        private string _TST_SEG_002;
        private string _TST_SJC_002;
        private string _TST_SJT_002;
        private string _TST_SJB_002;
        private string _TST_SPJ_002;
        private string _TST_SBC_002;
        private string _TST_SPO_002;
        private string _TST_SVA_002;
        private string _TST_TGR_002;
        private string _TST_TIP_002;
        private string _TST_DSB_002;
        private string _TST_TCA_002;
        private string _TST_FMC_002;
        private string _TST_1TB_002;
        private string _TST_1PP_002;
        private string _TST_2TB_002;
        private string _TST_2PP_002;
        private string _TST_P1C_002;
        private string _TST_P2D_002;
        private string _TST_P3D_002;
        private string _TST_P4U_002;
        private string _TST_MOL_002;
        private string _TST_TPD_002;
        private string _TST_TT1_002;
        private string _TST_TT2_002;
        private string _TST_TT3_002;
        private string _TST_T21_002;
        private string _TST_TUN_002;
        private string _TST_TCV_002;
        private string _TST_TSS_002;
        private double? _TST_TIT_002;
        private double? _TST_TNC_002;
        private double? _TST_AON_002;
        private double? _TST_ENM_002;
        private double? _TST_EEE_002;
        private double? _TST_KKK_002;
        private double? _TST_BBB_002;
        private double? _TST_OLE_002;
        private double? _TST_TRQ_002;
        private double? _TST_ERT_002;
        private double? _TST_RT3_002;
        private double? _TST_RT5_002;
        private double? _TST_DND_002;
        private double? _TST_DMO_002;
        private double? _TST_PES_002;
        private string _TST_VRR_002;
        private string _TST_TRE_002;
        private double? _TST_LME_002;
        private double? _TST_UME_002;
        private double? _TST_LPE_002;
        private double? _TST_UPE_002;
        private double? _TST_UCV_002;
        private double? _TST_CSO_002;
        private double? _TST_ESP_002;
        private string _TST_TOL_002;
        private double? _TST_DUR_002;
        private double? _TST_DFT_002;
        private double? _TST_LMC_002;
        private double? _TST_UMC_002;
        private double? _TST_LPC_002;
        private double? _TST_UPC_002;
        private double? _TST_CVC_002;
        private double? _TST_DFC_002;
        private double? _TST_TFS_002;
        private double? _TST_FSW_002;
        private double? _TST_WFW_002;
        private double? _TST_ECO_002;
        private string _TST_EOL_002;
        private string _TST_ETU_002;
        private string _TST_ETD_002;
        private string _TST_ECU_002;
        private string _TST_EGD_002;
        private string _TST_EEC_002;
        private string _TST_ECD_002;
        private string _TST_EGU_002;
        private string _TST_ESO_002;
        private string _TST_ESI_002;
        private string _TST_ECR_002;
        private string _TST_EOD_002;
        private string _TST_EAW_002;
        private string _TST_ED1_002;
        private string _TST_ED2_002;
        private string _TST_VW2_003;
        private string _TST_EGM_003;
        private string _TST_DYY_003;
        private string _TST_2WX_003;
        private string _TST_3W3_003;
        private string _TST_4W4_003;
        private string _TST_AGL_003;
        private string _TST_TUP_003;
        private string _TST_VEO_003;
        private string _TST_T1T_003;
        private string _TST_T1C_003;
        private string _TST_T1L_003;
        private string _TST_T2F_003;
        private string _TST_SVE_003;
        private string _TST_STF_003;
        private string _TST_STM_003;
        private string _TST_SCE_003;
        private string _TST_SCO_003;
        private string _TST_SCH_003;
        private string _TST_SCG_003;
        private string _TST_SEE_003;
        private string _TST_SEO_003;
        private string _TST_SEH_003;
        private string _TST_SEG_003;
        private string _TST_SJC_003;
        private string _TST_SJT_003;
        private string _TST_SJB_003;
        private string _TST_SPJ_003;
        private string _TST_SBC_003;
        private string _TST_SPO_003;
        private string _TST_SVA_003;
        private string _TST_TGR_003;
        private string _TST_TIP_003;
        private string _TST_DSB_003;
        private string _TST_TCA_003;
        private string _TST_FMC_003;
        private string _TST_1TB_003;
        private string _TST_1PP_003;
        private string _TST_2TB_003;
        private string _TST_2PP_003;
        private string _TST_P1C_003;
        private string _TST_P2D_003;
        private string _TST_P3D_003;
        private string _TST_P4U_003;
        private string _TST_MOL_003;
        private string _TST_TPD_003;
        private string _TST_TT1_003;
        private string _TST_TT2_003;
        private string _TST_TT3_003;
        private string _TST_T21_003;
        private string _TST_TUN_003;
        private string _TST_TCV_003;
        private string _TST_TSS_003;
        private double? _TST_TIT_003;
        private double? _TST_TNC_003;
        private double? _TST_AON_003;
        private double? _TST_ENM_003;
        private double? _TST_EEE_003;
        private double? _TST_KKK_003;
        private double? _TST_BBB_003;
        private double? _TST_OLE_003;
        private double? _TST_TRQ_003;
        private double? _TST_ERT_003;
        private double? _TST_RT3_003;
        private double? _TST_RT5_003;
        private double? _TST_DND_003;
        private double? _TST_DMO_003;
        private double? _TST_PES_003;
        private string _TST_VRR_003;
        private string _TST_TRE_003;
        private double? _TST_LME_003;
        private double? _TST_UME_003;
        private double? _TST_LPE_003;
        private double? _TST_UPE_003;
        private double? _TST_UCV_003;
        private double? _TST_CSO_003;
        private double? _TST_ESP_003;
        private string _TST_TOL_003;
        private double? _TST_DUR_003;
        private double? _TST_DFT_003;
        private double? _TST_LMC_003;
        private double? _TST_UMC_003;
        private double? _TST_LPC_003;
        private double? _TST_UPC_003;
        private double? _TST_CVC_003;
        private double? _TST_DFC_003;
        private double? _TST_TFS_003;
        private double? _TST_FSW_003;
        private double? _TST_WFW_003;
        private double? _TST_ECO_003;
        private string _TST_EOL_003;
        private string _TST_ETU_003;
        private string _TST_ETD_003;
        private string _TST_ECU_003;
        private string _TST_EGD_003;
        private string _TST_EEC_003;
        private string _TST_ECD_003;
        private string _TST_EGU_003;
        private string _TST_ESO_003;
        private string _TST_ESI_003;
        private string _TST_ECR_003;
        private string _TST_EOD_003;
        private string _TST_EAW_003;
        private string _TST_ED1_003;
        private string _TST_ED2_003;
        private string _TST_VW2_004;
        private string _TST_EGM_004;
        private string _TST_DYY_004;
        private string _TST_2WX_004;
        private string _TST_3W3_004;
        private string _TST_4W4_004;
        private string _TST_AGL_004;
        private string _TST_TUP_004;
        private string _TST_VEO_004;
        private string _TST_T1T_004;
        private string _TST_T1C_004;
        private string _TST_T1L_004;
        private string _TST_T2F_004;
        private string _TST_SVE_004;
        private string _TST_STF_004;
        private string _TST_STM_004;
        private string _TST_SCE_004;
        private string _TST_SCO_004;
        private string _TST_SCH_004;
        private string _TST_SCG_004;
        private string _TST_SEE_004;
        private string _TST_SEO_004;
        private string _TST_SEH_004;
        private string _TST_SEG_004;
        private string _TST_SJC_004;
        private string _TST_SJT_004;
        private string _TST_SJB_004;
        private string _TST_SPJ_004;
        private string _TST_SBC_004;
        private string _TST_SPO_004;
        private string _TST_SVA_004;
        private string _TST_TGR_004;
        private string _TST_TIP_004;
        private string _TST_DSB_004;
        private string _TST_TCA_004;
        private string _TST_FMC_004;
        private string _TST_1TB_004;
        private string _TST_1PP_004;
        private string _TST_2TB_004;
        private string _TST_2PP_004;
        private string _TST_P1C_004;
        private string _TST_P2D_004;
        private string _TST_P3D_004;
        private string _TST_P4U_004;
        private string _TST_MOL_004;
        private string _TST_TPD_004;
        private string _TST_TT1_004;
        private string _TST_TT2_004;
        private string _TST_TT3_004;
        private string _TST_T21_004;
        private string _TST_TUN_004;
        private string _TST_TCV_004;
        private string _TST_TSS_004;
        private double? _TST_TIT_004;
        private double? _TST_TNC_004;
        private double? _TST_AON_004;
        private double? _TST_ENM_004;
        private double? _TST_EEE_004;
        private double? _TST_KKK_004;
        private double? _TST_BBB_004;
        private double? _TST_OLE_004;
        private double? _TST_TRQ_004;
        private double? _TST_ERT_004;
        private double? _TST_RT3_004;
        private double? _TST_RT5_004;
        private double? _TST_DND_004;
        private double? _TST_DMO_004;
        private double? _TST_PES_004;
        private string _TST_VRR_004;
        private string _TST_TRE_004;
        private double? _TST_LME_004;
        private double? _TST_UME_004;
        private double? _TST_LPE_004;
        private double? _TST_UPE_004;
        private double? _TST_UCV_004;
        private double? _TST_CSO_004;
        private double? _TST_ESP_004;
        private string _TST_TOL_004;
        private double? _TST_DUR_004;
        private double? _TST_DFT_004;
        private double? _TST_LMC_004;
        private double? _TST_UMC_004;
        private double? _TST_LPC_004;
        private double? _TST_UPC_004;
        private double? _TST_CVC_004;
        private double? _TST_DFC_004;
        private double? _TST_TFS_004;
        private double? _TST_FSW_004;
        private double? _TST_WFW_004;
        private double? _TST_ECO_004;
        private string _TST_EOL_004;
        private string _TST_ETU_004;
        private string _TST_ETD_004;
        private string _TST_ECU_004;
        private string _TST_EGD_004;
        private string _TST_EEC_004;
        private string _TST_ECD_004;
        private string _TST_EGU_004;
        private string _TST_ESO_004;
        private string _TST_ESI_004;
        private string _TST_ECR_004;
        private string _TST_EOD_004;
        private string _TST_EAW_004;
        private string _TST_ED1_004;
        private string _TST_ED2_004;
        private string _TST_VW2_005;
        private string _TST_EGM_005;
        private string _TST_DYY_005;
        private string _TST_2WX_005;
        private string _TST_3W3_005;
        private string _TST_4W4_005;
        private string _TST_AGL_005;
        private string _TST_TUP_005;
        private string _TST_VEO_005;
        private string _TST_T1T_005;
        private string _TST_T1C_005;
        private string _TST_T1L_005;
        private string _TST_T2F_005;
        private string _TST_SVE_005;
        private string _TST_STF_005;
        private string _TST_STM_005;
        private string _TST_SCE_005;
        private string _TST_SCO_005;
        private string _TST_SCH_005;
        private string _TST_SCG_005;
        private string _TST_SEE_005;
        private string _TST_SEO_005;
        private string _TST_SEH_005;
        private string _TST_SEG_005;
        private string _TST_SJC_005;
        private string _TST_SJT_005;
        private string _TST_SJB_005;
        private string _TST_SPJ_005;
        private string _TST_SBC_005;
        private string _TST_SPO_005;
        private string _TST_SVA_005;
        private string _TST_TGR_005;
        private string _TST_TIP_005;
        private string _TST_DSB_005;
        private string _TST_TCA_005;
        private string _TST_FMC_005;
        private string _TST_1TB_005;
        private string _TST_1PP_005;
        private string _TST_2TB_005;
        private string _TST_2PP_005;
        private string _TST_P1C_005;
        private string _TST_P2D_005;
        private string _TST_P3D_005;
        private string _TST_P4U_005;
        private string _TST_MOL_005;
        private string _TST_TPD_005;
        private string _TST_TT1_005;
        private string _TST_TT2_005;
        private string _TST_TT3_005;
        private string _TST_T21_005;
        private string _TST_TUN_005;
        private string _TST_TCV_005;
        private string _TST_TSS_005;
        private double? _TST_TIT_005;
        private double? _TST_TNC_005;
        private double? _TST_AON_005;
        private double? _TST_ENM_005;
        private double? _TST_EEE_005;
        private double? _TST_KKK_005;
        private double? _TST_BBB_005;
        private double? _TST_OLE_005;
        private double? _TST_TRQ_005;
        private double? _TST_ERT_005;
        private double? _TST_RT3_005;
        private double? _TST_RT5_005;
        private double? _TST_DND_005;
        private double? _TST_DMO_005;
        private double? _TST_PES_005;
        private string _TST_VRR_005;
        private string _TST_TRE_005;
        private double? _TST_LME_005;
        private double? _TST_UME_005;
        private double? _TST_LPE_005;
        private double? _TST_UPE_005;
        private double? _TST_UCV_005;
        private double? _TST_CSO_005;
        private double? _TST_ESP_005;
        private string _TST_TOL_005;
        private double? _TST_DUR_005;
        private double? _TST_DFT_005;
        private double? _TST_LMC_005;
        private double? _TST_UMC_005;
        private double? _TST_LPC_005;
        private double? _TST_UPC_005;
        private double? _TST_CVC_005;
        private double? _TST_DFC_005;
        private double? _TST_TFS_005;
        private double? _TST_FSW_005;
        private double? _TST_WFW_005;
        private double? _TST_ECO_005;
        private string _TST_EOL_005;
        private string _TST_ETU_005;
        private string _TST_ETD_005;
        private string _TST_ECU_005;
        private string _TST_EGD_005;
        private string _TST_EEC_005;
        private string _TST_ECD_005;
        private string _TST_EGU_005;
        private string _TST_ESO_005;
        private string _TST_ESI_005;
        private string _TST_ECR_005;
        private string _TST_EOD_005;
        private string _TST_EAW_005;
        private string _TST_ED1_005;
        private string _TST_ED2_005;
        private string _TST_VW2_006;
        private string _TST_EGM_006;
        private string _TST_DYY_006;
        private string _TST_2WX_006;
        private string _TST_3W3_006;
        private string _TST_4W4_006;
        private string _TST_AGL_006;
        private string _TST_TUP_006;
        private string _TST_VEO_006;
        private string _TST_T1T_006;
        private string _TST_T1C_006;
        private string _TST_T1L_006;
        private string _TST_T2F_006;
        private string _TST_SVE_006;
        private string _TST_STF_006;
        private string _TST_STM_006;
        private string _TST_SCE_006;
        private string _TST_SCO_006;
        private string _TST_SCH_006;
        private string _TST_SCG_006;
        private string _TST_SEE_006;
        private string _TST_SEO_006;
        private string _TST_SEH_006;
        private string _TST_SEG_006;
        private string _TST_SJC_006;
        private string _TST_SJT_006;
        private string _TST_SJB_006;
        private string _TST_SPJ_006;
        private string _TST_SBC_006;
        private string _TST_SPO_006;
        private string _TST_SVA_006;
        private string _TST_TGR_006;
        private string _TST_TIP_006;
        private string _TST_DSB_006;
        private string _TST_TCA_006;
        private string _TST_FMC_006;
        private string _TST_1TB_006;
        private string _TST_1PP_006;
        private string _TST_2TB_006;
        private string _TST_2PP_006;
        private string _TST_P1C_006;
        private string _TST_P2D_006;
        private string _TST_P3D_006;
        private string _TST_P4U_006;
        private string _TST_MOL_006;
        private string _TST_TPD_006;
        private string _TST_TT1_006;
        private string _TST_TT2_006;
        private string _TST_TT3_006;
        private string _TST_T21_006;
        private string _TST_TUN_006;
        private string _TST_TCV_006;
        private string _TST_TSS_006;
        private double? _TST_TIT_006;
        private double? _TST_TNC_006;
        private double? _TST_AON_006;
        private double? _TST_ENM_006;
        private double? _TST_EEE_006;
        private double? _TST_KKK_006;
        private double? _TST_BBB_006;
        private double? _TST_OLE_006;
        private double? _TST_TRQ_006;
        private double? _TST_ERT_006;
        private double? _TST_RT3_006;
        private double? _TST_RT5_006;
        private double? _TST_DND_006;
        private double? _TST_DMO_006;
        private double? _TST_PES_006;
        private string _TST_VRR_006;
        private string _TST_TRE_006;
        private double? _TST_LME_006;
        private double? _TST_UME_006;
        private double? _TST_LPE_006;
        private double? _TST_UPE_006;
        private double? _TST_UCV_006;
        private double? _TST_CSO_006;
        private double? _TST_ESP_006;
        private string _TST_TOL_006;
        private double? _TST_DUR_006;
        private double? _TST_DFT_006;
        private double? _TST_LMC_006;
        private double? _TST_UMC_006;
        private double? _TST_LPC_006;
        private double? _TST_UPC_006;
        private double? _TST_CVC_006;
        private double? _TST_DFC_006;
        private double? _TST_TFS_006;
        private double? _TST_FSW_006;
        private double? _TST_WFW_006;
        private double? _TST_ECO_006;
        private string _TST_EOL_006;
        private string _TST_ETU_006;
        private string _TST_ETD_006;
        private string _TST_ECU_006;
        private string _TST_EGD_006;
        private string _TST_EEC_006;
        private string _TST_ECD_006;
        private string _TST_EGU_006;
        private string _TST_ESO_006;
        private string _TST_ESI_006;
        private string _TST_ECR_006;
        private string _TST_EOD_006;
        private string _TST_EAW_006;
        private string _TST_ED1_006;
        private string _TST_ED2_006;
        private string _TST_VW2_007;
        private string _TST_EGM_007;
        private string _TST_DYY_007;
        private string _TST_2WX_007;
        private string _TST_3W3_007;
        private string _TST_4W4_007;
        private string _TST_AGL_007;
        private string _TST_TUP_007;
        private string _TST_VEO_007;
        private string _TST_T1T_007;
        private string _TST_T1C_007;
        private string _TST_T1L_007;
        private string _TST_T2F_007;
        private string _TST_SVE_007;
        private string _TST_STF_007;
        private string _TST_STM_007;
        private string _TST_SCE_007;
        private string _TST_SCO_007;
        private string _TST_SCH_007;
        private string _TST_SCG_007;
        private string _TST_SEE_007;
        private string _TST_SEO_007;
        private string _TST_SEH_007;
        private string _TST_SEG_007;
        private string _TST_SJC_007;
        private string _TST_SJT_007;
        private string _TST_SJB_007;
        private string _TST_SPJ_007;
        private string _TST_SBC_007;
        private string _TST_SPO_007;
        private string _TST_SVA_007;
        private string _TST_TGR_007;
        private string _TST_TIP_007;
        private string _TST_DSB_007;
        private string _TST_TCA_007;
        private string _TST_FMC_007;
        private string _TST_1TB_007;
        private string _TST_1PP_007;
        private string _TST_2TB_007;
        private string _TST_2PP_007;
        private string _TST_P1C_007;
        private string _TST_P2D_007;
        private string _TST_P3D_007;
        private string _TST_P4U_007;
        private string _TST_MOL_007;
        private string _TST_TPD_007;
        private string _TST_TT1_007;
        private string _TST_TT2_007;
        private string _TST_TT3_007;
        private string _TST_T21_007;
        private string _TST_TUN_007;
        private string _TST_TCV_007;
        private string _TST_TSS_007;
        private double? _TST_TIT_007;
        private double? _TST_TNC_007;
        private double? _TST_AON_007;
        private double? _TST_ENM_007;
        private double? _TST_EEE_007;
        private double? _TST_KKK_007;
        private double? _TST_BBB_007;
        private double? _TST_OLE_007;
        private double? _TST_TRQ_007;
        private double? _TST_ERT_007;
        private double? _TST_RT3_007;
        private double? _TST_RT5_007;
        private double? _TST_DND_007;
        private double? _TST_DMO_007;
        private double? _TST_PES_007;
        private string _TST_VRR_007;
        private string _TST_TRE_007;
        private double? _TST_LME_007;
        private double? _TST_UME_007;
        private double? _TST_LPE_007;
        private double? _TST_UPE_007;
        private double? _TST_UCV_007;
        private double? _TST_CSO_007;
        private double? _TST_ESP_007;
        private string _TST_TOL_007;
        private double? _TST_DUR_007;
        private double? _TST_DFT_007;
        private double? _TST_LMC_007;
        private double? _TST_UMC_007;
        private double? _TST_LPC_007;
        private double? _TST_UPC_007;
        private double? _TST_CVC_007;
        private double? _TST_DFC_007;
        private double? _TST_TFS_007;
        private double? _TST_FSW_007;
        private double? _TST_WFW_007;
        private double? _TST_ECO_007;
        private string _TST_EOL_007;
        private string _TST_ETU_007;
        private string _TST_ETD_007;
        private string _TST_ECU_007;
        private string _TST_EGD_007;
        private string _TST_EEC_007;
        private string _TST_ECD_007;
        private string _TST_EGU_007;
        private string _TST_ESO_007;
        private string _TST_ESI_007;
        private string _TST_ECR_007;
        private string _TST_EOD_007;
        private string _TST_EAW_007;
        private string _TST_ED1_007;
        private string _TST_ED2_007;
        private string _TST_PCO_REF; 
        private string _TST_PCO_001; 
        private string _TST_PCO_002; 
        private string _TST_PCO_003; 
        private string _TST_PCO_004; 
        private string _TST_PCO_005; 
        private string _TST_PCO_006; 
        private string _TST_PCO_007;
        private string _TST_PCV_REF; 
        private string _TST_PCV_001; 
        private string _TST_PCV_002; 
        private string _TST_PCV_003; 
        private string _TST_PCV_004; 
        private string _TST_PCV_005; 
        private string _TST_PCV_006; 
        private string _TST_PCV_007;
        private string _TST_DRT_REF; 
        private string _TST_DRT_001; 
        private string _TST_DRT_002; 
        private string _TST_DRT_003; 
        private string _TST_DRT_004; 
        private string _TST_DRT_005; 
        private string _TST_DRT_006; 
        private string _TST_DRT_007;
        private string _TST_TAL_REF;
        private string _TST_TAL_001; 
        private string _TST_TAL_002; 
        private string _TST_TAL_003; 
        private string _TST_TAL_004; 
        private string _TST_TAL_005; 
        private string _TST_TAL_006; 
        private string _TST_TAL_007;
        private string _TST_VAL_REF; 
        private string _TST_VAL_001; 
        private string _TST_VAL_002; 
        private string _TST_VAL_003; 
        private string _TST_VAL_004; 
        private string _TST_VAL_005; 
        private string _TST_VAL_006; 
        private string _TST_VAL_007;
        private string _TST_SJE_REF; 
        private string _TST_SJE_001; 
        private string _TST_SJE_002; 
        private string _TST_SJE_003; 
        private string _TST_SJE_004; 
        private string _TST_SJE_005; 
        private string _TST_SJE_006; 
        private string _TST_SJE_007;
        private string _TST_DET;
        private string _TST_OBS;
        private int? _TST_STS;
        private int? _TST_USR_INC_ID;
        private int? _TST_USR_ALT_ID;
        private DateTime? _TST_TMS_ATL;

        private DateTime? _TST_DAT_INI_INI;
        private DateTime? _TST_DAT_INI_FIM;
        private DateTime? _TST_DAT_FIM_INI;
        private DateTime? _TST_DAT_FIM_FIM;

        private string _TOP;
        private string _SQL;

        public int? TST_ID
        {
            get { return _TST_ID; }
            set { _TST_ID = value; }
        }
        public int? TST_RTS_ID
        {
            get { return _TST_RTS_ID; }
            set { _TST_RTS_ID = value; }
        }
        public int? TST_RTS_MTV_TST_ID
        {
            get { return _TST_RTS_MTV_TST_ID; }
            set { _TST_RTS_MTV_TST_ID = value; }
        }
        public string TST_LOT
        {
            get { return _TST_LOT; }
            set { _TST_LOT = value.ToUpper(); }
        }
        public string TST_LOT_REF
        {
            get { return _TST_LOT_REF; }
            set { _TST_LOT_REF = value.ToUpper(); }
        }
        public string TST_LOT_EPF
        {
            get { return _TST_LOT_EPF; }
            set { _TST_LOT_EPF = value.ToUpper(); }
        }
        public string TST_LOT_ANS
        {
            get { return _TST_LOT_ANS; }
            set { _TST_LOT_ANS = value.ToUpper(); }
        }
        public int? TST_TIT_POY_ID
        {
            get { return _TST_TIT_POY_ID; }
            set { _TST_TIT_POY_ID = value; }
        }
        public string TST_DES
        {
            get { return _TST_DES; }
            set { _TST_DES = value.ToUpper(); }
        }
        public string TST_MGE
        {
            get { return _TST_MGE; }
            set { _TST_MGE = value.ToUpper(); }
        }
        public string TST_MGE_002
        {
            get { return _TST_MGE_002; }
            set { _TST_MGE_002 = value.ToUpper(); }
        }
        public string TST_MGE_003
        {
            get { return _TST_MGE_003; }
            set { _TST_MGE_003 = value.ToUpper(); }
        }
        public string TST_MGE_REF
        {
            get { return _TST_MGE_REF; }
            set { _TST_MGE_REF = value.ToUpper(); }
        }
        public string TST_MGE_002_REF
        {
            get { return _TST_MGE_002_REF; }
            set { _TST_MGE_002_REF = value.ToUpper(); }
        }
        public string TST_MGE_003_REF
        {
            get { return _TST_MGE_003_REF; }
            set { _TST_MGE_003_REF = value.ToUpper(); }
        }
        public int? TST_FOR_001_ID
        {
            get { return _TST_FOR_001_ID; }
            set { _TST_FOR_001_ID = value; }
        }
        public int? TST_FOR_002_ID
        {
            get { return _TST_FOR_002_ID; }
            set { _TST_FOR_002_ID = value; }
        }
        public int? TST_FOR_003_ID
        {
            get { return _TST_FOR_003_ID; }
            set { _TST_FOR_003_ID = value; }
        }
        public string TST_VLC
        {
            get { return _TST_VLC; }
            set { _TST_VLC = value.ToUpper(); }
        }
        public int? TST_APS_ID
        {
            get { return _TST_APS_ID; }
            set { _TST_APS_ID = value; }
        }
        public int? TST_MAQ_TIP_ID
        {
            get { return _TST_MAQ_TIP_ID; }
            set { _TST_MAQ_TIP_ID = value; }
        }
        public int? TST_ERT_ID
        {
            get { return _TST_ERT_ID; }
            set { _TST_ERT_ID = value; }
        }
        public DateTime? TST_DAT_INI
        {
            get { return _TST_DAT_INI; }
            set { _TST_DAT_INI = value; }
        }
        public DateTime? TST_DAT_FIM
        {
            get { return _TST_DAT_FIM; }
            set { _TST_DAT_FIM = value; }
        }
        public string TST_VW2_REF
        {
            get { return _TST_VW2_REF; }
            set { _TST_VW2_REF = value.ToUpper(); }
        }
        public string TST_EGM_REF
        {
            get { return _TST_EGM_REF; }
            set { _TST_EGM_REF = value.ToUpper(); }
        }
        public string TST_DYY_REF
        {
            get { return _TST_DYY_REF; }
            set { _TST_DYY_REF = value.ToUpper(); }
        }
        public string TST_2WX_REF
        {
            get { return _TST_2WX_REF; }
            set { _TST_2WX_REF = value.ToUpper(); }
        }
        public string TST_3W3_REF
        {
            get { return _TST_3W3_REF; }
            set { _TST_3W3_REF = value.ToUpper(); }
        }
        public string TST_4W4_REF
        {
            get { return _TST_4W4_REF; }
            set { _TST_4W4_REF = value.ToUpper(); }
        }
        public string TST_AGL_REF
        {
            get { return _TST_AGL_REF; }
            set { _TST_AGL_REF = value.ToUpper(); }
        }
        public string TST_TUP_REF
        {
            get { return _TST_TUP_REF; }
            set { _TST_TUP_REF = value.ToUpper(); }
        }
        public string TST_VEO_REF
        {
            get { return _TST_VEO_REF; }
            set { _TST_VEO_REF = value.ToUpper(); }
        }
        public string TST_T1T_REF
        {
            get { return _TST_T1T_REF; }
            set { _TST_T1T_REF = value.ToUpper(); }
        }
        public string TST_T1C_REF
        {
            get { return _TST_T1C_REF; }
            set { _TST_T1C_REF = value.ToUpper(); }
        }
        public string TST_T1L_REF
        {
            get { return _TST_T1L_REF; }
            set { _TST_T1L_REF = value.ToUpper(); }
        }
        public string TST_T2F_REF
        {
            get { return _TST_T2F_REF; }
            set { _TST_T2F_REF = value.ToUpper(); }
        }
        public string TST_SVE_REF
        {
            get { return _TST_SVE_REF; }
            set { _TST_SVE_REF = value.ToUpper(); }
        }
        public string TST_STF_REF
        {
            get { return _TST_STF_REF; }
            set { _TST_STF_REF = value.ToUpper(); }
        }
        public string TST_STM_REF
        {
            get { return _TST_STM_REF; }
            set { _TST_STM_REF = value.ToUpper(); }
        }
        public string TST_SCE_REF
        {
            get { return _TST_SCE_REF; }
            set { _TST_SCE_REF = value.ToUpper(); }
        }
        public string TST_SCO_REF
        {
            get { return _TST_SCO_REF; }
            set { _TST_SCO_REF = value.ToUpper(); }
        }
        public string TST_SCH_REF
        {
            get { return _TST_SCH_REF; }
            set { _TST_SCH_REF = value.ToUpper(); }
        }
        public string TST_SCG_REF
        {
            get { return _TST_SCG_REF; }
            set { _TST_SCG_REF = value.ToUpper(); }
        }
        public string TST_SEE_REF
        {
            get { return _TST_SEE_REF; }
            set { _TST_SEE_REF = value.ToUpper(); }
        }
        public string TST_SEO_REF
        {
            get { return _TST_SEO_REF; }
            set { _TST_SEO_REF = value.ToUpper(); }
        }
        public string TST_SEH_REF
        {
            get { return _TST_SEH_REF; }
            set { _TST_SEH_REF = value.ToUpper(); }
        }
        public string TST_SEG_REF
        {
            get { return _TST_SEG_REF; }
            set { _TST_SEG_REF = value.ToUpper(); }
        }
        public string TST_SJC_REF
        {
            get { return _TST_SJC_REF; }
            set { _TST_SJC_REF = value.ToUpper(); }
        }
        public string TST_SJT_REF
        {
            get { return _TST_SJT_REF; }
            set { _TST_SJT_REF = value.ToUpper(); }
        }
        public string TST_SJB_REF
        {
            get { return _TST_SJB_REF; }
            set { _TST_SJB_REF = value.ToUpper(); }
        }
        public string TST_SPJ_REF
        {
            get { return _TST_SPJ_REF; }
            set { _TST_SPJ_REF = value.ToUpper(); }
        }
        public string TST_SBC_REF
        {
            get { return _TST_SBC_REF; }
            set { _TST_SBC_REF = value.ToUpper(); }
        }
        public string TST_SPO_REF
        {
            get { return _TST_SPO_REF; }
            set { _TST_SPO_REF = value.ToUpper(); }
        }
        public string TST_SVA_REF
        {
            get { return _TST_SVA_REF; }
            set { _TST_SVA_REF = value.ToUpper(); }
        }
        public string TST_TGR_REF
        {
            get { return _TST_TGR_REF; }
            set { _TST_TGR_REF = value.ToUpper(); }
        }
        public string TST_TIP_REF
        {
            get { return _TST_TIP_REF; }
            set { _TST_TIP_REF = value.ToUpper(); }
        }
        public string TST_DSB_REF
        {
            get { return _TST_DSB_REF; }
            set { _TST_DSB_REF = value.ToUpper(); }
        }
        public string TST_TCA_REF
        {
            get { return _TST_TCA_REF; }
            set { _TST_TCA_REF = value.ToUpper(); }
        }
        public string TST_FMC_REF
        {
            get { return _TST_FMC_REF; }
            set { _TST_FMC_REF = value.ToUpper(); }
        }
        public string TST_1TB_REF
        {
            get { return _TST_1TB_REF; }
            set { _TST_1TB_REF = value.ToUpper(); }
        }
        public string TST_1PP_REF
        {
            get { return _TST_1PP_REF; }
            set { _TST_1PP_REF = value.ToUpper(); }
        }
        public string TST_2TB_REF
        {
            get { return _TST_2TB_REF; }
            set { _TST_2TB_REF = value.ToUpper(); }
        }
        public string TST_2PP_REF
        {
            get { return _TST_2PP_REF; }
            set { _TST_2PP_REF = value.ToUpper(); }
        }
        public string TST_P1C_REF
        {
            get { return _TST_P1C_REF; }
            set { _TST_P1C_REF = value.ToUpper(); }
        }
        public string TST_P2D_REF
        {
            get { return _TST_P2D_REF; }
            set { _TST_P2D_REF = value.ToUpper(); }
        }
        public string TST_P3D_REF
        {
            get { return _TST_P3D_REF; }
            set { _TST_P3D_REF = value.ToUpper(); }
        }
        public string TST_P4U_REF
        {
            get { return _TST_P4U_REF; }
            set { _TST_P4U_REF = value.ToUpper(); }
        }
        public string TST_MOL_REF
        {
            get { return _TST_MOL_REF; }
            set { _TST_MOL_REF = value.ToUpper(); }
        }
        public string TST_TPD_REF
        {
            get { return _TST_TPD_REF; }
            set { _TST_TPD_REF = value.ToUpper(); }
        }
        public string TST_TT1_REF
        {
            get { return _TST_TT1_REF; }
            set { _TST_TT1_REF = value.ToUpper(); }
        }
        public string TST_TT2_REF
        {
            get { return _TST_TT2_REF; }
            set { _TST_TT2_REF = value.ToUpper(); }
        }
        public string TST_TT3_REF
        {
            get { return _TST_TT3_REF; }
            set { _TST_TT3_REF = value.ToUpper(); }
        }
        public string TST_T21_REF
        {
            get { return _TST_T21_REF; }
            set { _TST_T21_REF = value.ToUpper(); }
        }
        public string TST_TUN_REF
        {
            get { return _TST_TUN_REF; }
            set { _TST_TUN_REF = value.ToUpper(); }
        }
        public string TST_TCV_REF
        {
            get { return _TST_TCV_REF; }
            set { _TST_TCV_REF = value.ToUpper(); }
        }
        public string TST_TSS_REF
        {
            get { return _TST_TSS_REF; }
            set { _TST_TSS_REF = value.ToUpper(); }
        }
        public double? TST_TIT_REF
        {
            get { return _TST_TIT_REF; }
            set { _TST_TIT_REF = value; }
        }
        public double? TST_TNC_REF
        {
            get { return _TST_TNC_REF; }
            set { _TST_TNC_REF = value; }
        }
        public double? TST_AON_REF
        {
            get { return _TST_AON_REF; }
            set { _TST_AON_REF = value; }
        }
        public double? TST_ENM_REF
        {
            get { return _TST_ENM_REF; }
            set { _TST_ENM_REF = value; }
        }
        public double? TST_EEE_REF
        {
            get { return _TST_EEE_REF; }
            set { _TST_EEE_REF = value; }
        }
        public double? TST_KKK_REF
        {
            get { return _TST_KKK_REF; }
            set { _TST_KKK_REF = value; }
        }
        public double? TST_BBB_REF
        {
            get { return _TST_BBB_REF; }
            set { _TST_BBB_REF = value; }
        }
        public double? TST_OLE_REF
        {
            get { return _TST_OLE_REF; }
            set { _TST_OLE_REF = value; }
        }
        public double? TST_TRQ_REF
        {
            get { return _TST_TRQ_REF; }
            set { _TST_TRQ_REF = value; }
        }
        public double? TST_ERT_REF
        {
            get { return _TST_ERT_REF; }
            set { _TST_ERT_REF = value; }
        }
        public double? TST_RT3_REF
        {
            get { return _TST_RT3_REF; }
            set { _TST_RT3_REF = value; }
        }
        public double? TST_RT5_REF
        {
            get { return _TST_RT5_REF; }
            set { _TST_RT5_REF = value; }
        }
        public double? TST_DND_REF
        {
            get { return _TST_DND_REF; }
            set { _TST_DND_REF = value; }
        }
        public double? TST_DMO_REF
        {
            get { return _TST_DMO_REF; }
            set { _TST_DMO_REF = value; }
        }
        public double? TST_PES_REF
        {
            get { return _TST_PES_REF; }
            set { _TST_PES_REF = value; }
        }
        public string TST_VRR_REF
        {
            get { return _TST_VRR_REF; }
            set { _TST_VRR_REF = value.ToUpper(); }
        }
        public string TST_TRE_REF
        {
            get { return _TST_TRE_REF; }
            set { _TST_TRE_REF = value.ToUpper(); }
        }
        public double? TST_LME_REF
        {
            get { return _TST_LME_REF; }
            set { _TST_LME_REF = value; }
        }
        public double? TST_UME_REF
        {
            get { return _TST_UME_REF; }
            set { _TST_UME_REF = value; }
        }
        public double? TST_LPE_REF
        {
            get { return _TST_LPE_REF; }
            set { _TST_LPE_REF = value; }
        }
        public double? TST_UPE_REF
        {
            get { return _TST_UPE_REF; }
            set { _TST_UPE_REF = value; }
        }
        public double? TST_UCV_REF
        {
            get { return _TST_UCV_REF; }
            set { _TST_UCV_REF = value; }
        }
        public double? TST_CSO_REF
        {
            get { return _TST_CSO_REF; }
            set { _TST_CSO_REF = value; }
        }
        public double? TST_ESP_REF
        {
            get { return _TST_ESP_REF; }
            set { _TST_ESP_REF = value; }
        }
        public string TST_TOL_REF
        {
            get { return _TST_TOL_REF; }
            set { _TST_TOL_REF = value.ToUpper(); }
        }
        public double? TST_DUR_REF
        {
            get { return _TST_DUR_REF; }
            set { _TST_DUR_REF = value; }
        }
        public double? TST_DFT_REF
        {
            get { return _TST_DFT_REF; }
            set { _TST_DFT_REF = value; }
        }
        public double? TST_LMC_REF
        {
            get { return _TST_LMC_REF; }
            set { _TST_LMC_REF = value; }
        }
        public double? TST_UMC_REF
        {
            get { return _TST_UMC_REF; }
            set { _TST_UMC_REF = value; }
        }
        public double? TST_LPC_REF
        {
            get { return _TST_LPC_REF; }
            set { _TST_LPC_REF = value; }
        }
        public double? TST_UPC_REF
        {
            get { return _TST_UPC_REF; }
            set { _TST_UPC_REF = value; }
        }
        public double? TST_CVC_REF
        {
            get { return _TST_CVC_REF; }
            set { _TST_CVC_REF = value; }
        }
        public double? TST_DFC_REF
        {
            get { return _TST_DFC_REF; }
            set { _TST_DFC_REF = value; }
        }
        public double? TST_TFS_REF
        {
            get { return _TST_TFS_REF; }
            set { _TST_TFS_REF = value; }
        }
        public double? TST_FSW_REF
        {
            get { return _TST_FSW_REF; }
            set { _TST_FSW_REF = value; }
        }
        public double? TST_WFW_REF
        {
            get { return _TST_WFW_REF; }
            set { _TST_WFW_REF = value; }
        }
        public double? TST_ECO_REF
        {
            get { return _TST_ECO_REF; }
            set { _TST_ECO_REF = value; }
        }
        public string TST_EOL_REF
        {
            get { return _TST_EOL_REF; }
            set { _TST_EOL_REF = value; }
        }
        public string TST_ETU_REF
        {
            get { return _TST_ETU_REF; }
            set { _TST_ETU_REF = value; }
        }
        public string TST_ETD_REF
        {
            get { return _TST_ETD_REF; }
            set { _TST_ETD_REF = value; }
        }
        public string TST_ECU_REF
        {
            get { return _TST_ECU_REF; }
            set { _TST_ECU_REF = value; }
        }
        public string TST_EGD_REF
        {
            get { return _TST_EGD_REF; }
            set { _TST_EGD_REF = value; }
        }
        public string TST_EEC_REF
        {
            get { return _TST_EEC_REF; }
            set { _TST_EEC_REF = value; }
        }
        public string TST_ECD_REF
        {
            get { return _TST_ECD_REF; }
            set { _TST_ECD_REF = value; }
        }
        public string TST_EGU_REF
        {
            get { return _TST_EGU_REF; }
            set { _TST_EGU_REF = value; }
        }
        public string TST_ESO_REF
        {
            get { return _TST_ESO_REF; }
            set { _TST_ESO_REF = value; }
        }
        public string TST_ESI_REF
        {
            get { return _TST_ESI_REF; }
            set { _TST_ESI_REF = value; }
        }
        public string TST_ECR_REF
        {
            get { return _TST_ECR_REF; }
            set { _TST_ECR_REF = value; }
        }
        public string TST_EOD_REF
        {
            get { return _TST_EOD_REF; }
            set { _TST_EOD_REF = value; }
        }
        public string TST_EAW_REF
        {
            get { return _TST_EAW_REF; }
            set { _TST_EAW_REF = value; }
        }
        public string TST_ED1_REF
        {
            get { return _TST_ED1_REF; }
            set { _TST_ED1_REF = value; }
        }
        public string TST_ED2_REF
        {
            get { return _TST_ED2_REF; }
            set { _TST_ED2_REF = value; }
        }
        public string TST_VW2_001
        {
            get { return _TST_VW2_001; }
            set { _TST_VW2_001 = value.ToUpper(); }
        }
        public string TST_EGM_001
        {
            get { return _TST_EGM_001; }
            set { _TST_EGM_001 = value.ToUpper(); }
        }
        public string TST_DYY_001
        {
            get { return _TST_DYY_001; }
            set { _TST_DYY_001 = value.ToUpper(); }
        }
        public string TST_2WX_001
        {
            get { return _TST_2WX_001; }
            set { _TST_2WX_001 = value.ToUpper(); }
        }
        public string TST_3W3_001
        {
            get { return _TST_3W3_001; }
            set { _TST_3W3_001 = value.ToUpper(); }
        }
        public string TST_4W4_001
        {
            get { return _TST_4W4_001; }
            set { _TST_4W4_001 = value.ToUpper(); }
        }
        public string TST_AGL_001
        {
            get { return _TST_AGL_001; }
            set { _TST_AGL_001 = value.ToUpper(); }
        }
        public string TST_TUP_001
        {
            get { return _TST_TUP_001; }
            set { _TST_TUP_001 = value.ToUpper(); }
        }
        public string TST_VEO_001
        {
            get { return _TST_VEO_001; }
            set { _TST_VEO_001 = value.ToUpper(); }
        }
        public string TST_T1T_001
        {
            get { return _TST_T1T_001; }
            set { _TST_T1T_001 = value.ToUpper(); }
        }
        public string TST_T1C_001
        {
            get { return _TST_T1C_001; }
            set { _TST_T1C_001 = value.ToUpper(); }
        }
        public string TST_T1L_001
        {
            get { return _TST_T1L_001; }
            set { _TST_T1L_001 = value.ToUpper(); }
        }
        public string TST_T2F_001
        {
            get { return _TST_T2F_001; }
            set { _TST_T2F_001 = value.ToUpper(); }
        }
        public string TST_SVE_001
        {
            get { return _TST_SVE_001; }
            set { _TST_SVE_001 = value.ToUpper(); }
        }
        public string TST_STF_001
        {
            get { return _TST_STF_001; }
            set { _TST_STF_001 = value.ToUpper(); }
        }
        public string TST_STM_001
        {
            get { return _TST_STM_001; }
            set { _TST_STM_001 = value.ToUpper(); }
        }
        public string TST_SCE_001
        {
            get { return _TST_SCE_001; }
            set { _TST_SCE_001 = value.ToUpper(); }
        }
        public string TST_SCO_001
        {
            get { return _TST_SCO_001; }
            set { _TST_SCO_001 = value.ToUpper(); }
        }
        public string TST_SCH_001
        {
            get { return _TST_SCH_001; }
            set { _TST_SCH_001 = value.ToUpper(); }
        }
        public string TST_SCG_001
        {
            get { return _TST_SCG_001; }
            set { _TST_SCG_001 = value.ToUpper(); }
        }
        public string TST_SEE_001
        {
            get { return _TST_SEE_001; }
            set { _TST_SEE_001 = value.ToUpper(); }
        }
        public string TST_SEO_001
        {
            get { return _TST_SEO_001; }
            set { _TST_SEO_001 = value.ToUpper(); }
        }
        public string TST_SEH_001
        {
            get { return _TST_SEH_001; }
            set { _TST_SEH_001 = value.ToUpper(); }
        }
        public string TST_SEG_001
        {
            get { return _TST_SEG_001; }
            set { _TST_SEG_001 = value.ToUpper(); }
        }
        public string TST_SJC_001
        {
            get { return _TST_SJC_001; }
            set { _TST_SJC_001 = value.ToUpper(); }
        }
        public string TST_SJT_001
        {
            get { return _TST_SJT_001; }
            set { _TST_SJT_001 = value.ToUpper(); }
        }
        public string TST_SJB_001
        {
            get { return _TST_SJB_001; }
            set { _TST_SJB_001 = value.ToUpper(); }
        }
        public string TST_SPJ_001
        {
            get { return _TST_SPJ_001; }
            set { _TST_SPJ_001 = value.ToUpper(); }
        }
        public string TST_SBC_001
        {
            get { return _TST_SBC_001; }
            set { _TST_SBC_001 = value.ToUpper(); }
        }
        public string TST_SPO_001
        {
            get { return _TST_SPO_001; }
            set { _TST_SPO_001 = value.ToUpper(); }
        }
        public string TST_SVA_001
        {
            get { return _TST_SVA_001; }
            set { _TST_SVA_001 = value.ToUpper(); }
        }
        public string TST_TGR_001
        {
            get { return _TST_TGR_001; }
            set { _TST_TGR_001 = value.ToUpper(); }
        }
        public string TST_TIP_001
        {
            get { return _TST_TIP_001; }
            set { _TST_TIP_001 = value.ToUpper(); }
        }
        public string TST_DSB_001
        {
            get { return _TST_DSB_001; }
            set { _TST_DSB_001 = value.ToUpper(); }
        }
        public string TST_TCA_001
        {
            get { return _TST_TCA_001; }
            set { _TST_TCA_001 = value.ToUpper(); }
        }
        public string TST_FMC_001
        {
            get { return _TST_FMC_001; }
            set { _TST_FMC_001 = value.ToUpper(); }
        }
        public string TST_1TB_001
        {
            get { return _TST_1TB_001; }
            set { _TST_1TB_001 = value.ToUpper(); }
        }
        public string TST_1PP_001
        {
            get { return _TST_1PP_001; }
            set { _TST_1PP_001 = value.ToUpper(); }
        }
        public string TST_2TB_001
        {
            get { return _TST_2TB_001; }
            set { _TST_2TB_001 = value.ToUpper(); }
        }
        public string TST_2PP_001
        {
            get { return _TST_2PP_001; }
            set { _TST_2PP_001 = value.ToUpper(); }
        }
        public string TST_P1C_001
        {
            get { return _TST_P1C_001; }
            set { _TST_P1C_001 = value.ToUpper(); }
        }
        public string TST_P2D_001
        {
            get { return _TST_P2D_001; }
            set { _TST_P2D_001 = value.ToUpper(); }
        }
        public string TST_P3D_001
        {
            get { return _TST_P3D_001; }
            set { _TST_P3D_001 = value.ToUpper(); }
        }
        public string TST_P4U_001
        {
            get { return _TST_P4U_001; }
            set { _TST_P4U_001 = value.ToUpper(); }
        }
        public string TST_MOL_001
        {
            get { return _TST_MOL_001; }
            set { _TST_MOL_001 = value.ToUpper(); }
        }
        public string TST_TPD_001
        {
            get { return _TST_TPD_001; }
            set { _TST_TPD_001 = value.ToUpper(); }
        }
        public string TST_TT1_001
        {
            get { return _TST_TT1_001; }
            set { _TST_TT1_001 = value.ToUpper(); }
        }
        public string TST_TT2_001
        {
            get { return _TST_TT2_001; }
            set { _TST_TT2_001 = value.ToUpper(); }
        }
        public string TST_TT3_001
        {
            get { return _TST_TT3_001; }
            set { _TST_TT3_001 = value.ToUpper(); }
        }
        public string TST_T21_001
        {
            get { return _TST_T21_001; }
            set { _TST_T21_001 = value.ToUpper(); }
        }
        public string TST_TUN_001
        {
            get { return _TST_TUN_001; }
            set { _TST_TUN_001 = value.ToUpper(); }
        }
        public string TST_TCV_001
        {
            get { return _TST_TCV_001; }
            set { _TST_TCV_001 = value.ToUpper(); }
        }
        public string TST_TSS_001
        {
            get { return _TST_TSS_001; }
            set { _TST_TSS_001 = value.ToUpper(); }
        }
        public double? TST_TIT_001
        {
            get { return _TST_TIT_001; }
            set { _TST_TIT_001 = value; }
        }
        public double? TST_TNC_001
        {
            get { return _TST_TNC_001; }
            set { _TST_TNC_001 = value; }
        }
        public double? TST_AON_001
        {
            get { return _TST_AON_001; }
            set { _TST_AON_001 = value; }
        }
        public double? TST_ENM_001
        {
            get { return _TST_ENM_001; }
            set { _TST_ENM_001 = value; }
        }
        public double? TST_EEE_001
        {
            get { return _TST_EEE_001; }
            set { _TST_EEE_001 = value; }
        }
        public double? TST_KKK_001
        {
            get { return _TST_KKK_001; }
            set { _TST_KKK_001 = value; }
        }
        public double? TST_BBB_001
        {
            get { return _TST_BBB_001; }
            set { _TST_BBB_001 = value; }
        }
        public double? TST_OLE_001
        {
            get { return _TST_OLE_001; }
            set { _TST_OLE_001 = value; }
        }
        public double? TST_TRQ_001
        {
            get { return _TST_TRQ_001; }
            set { _TST_TRQ_001 = value; }
        }
        public double? TST_ERT_001
        {
            get { return _TST_ERT_001; }
            set { _TST_ERT_001 = value; }
        }
        public double? TST_RT3_001
        {
            get { return _TST_RT3_001; }
            set { _TST_RT3_001 = value; }
        }
        public double? TST_RT5_001
        {
            get { return _TST_RT5_001; }
            set { _TST_RT5_001 = value; }
        }
        public double? TST_DND_001
        {
            get { return _TST_DND_001; }
            set { _TST_DND_001 = value; }
        }
        public double? TST_DMO_001
        {
            get { return _TST_DMO_001; }
            set { _TST_DMO_001 = value; }
        }
        public double? TST_PES_001
        {
            get { return _TST_PES_001; }
            set { _TST_PES_001 = value; }
        }
        public string TST_VRR_001
        {
            get { return _TST_VRR_001; }
            set { _TST_VRR_001 = value.ToUpper(); }
        }
        public string TST_TRE_001
        {
            get { return _TST_TRE_001; }
            set { _TST_TRE_001 = value.ToUpper(); }
        }
        public double? TST_LME_001
        {
            get { return _TST_LME_001; }
            set { _TST_LME_001 = value; }
        }
        public double? TST_UME_001
        {
            get { return _TST_UME_001; }
            set { _TST_UME_001 = value; }
        }
        public double? TST_LPE_001
        {
            get { return _TST_LPE_001; }
            set { _TST_LPE_001 = value; }
        }
        public double? TST_UPE_001
        {
            get { return _TST_UPE_001; }
            set { _TST_UPE_001 = value; }
        }
        public double? TST_UCV_001
        {
            get { return _TST_UCV_001; }
            set { _TST_UCV_001 = value; }
        }
        public double? TST_CSO_001
        {
            get { return _TST_CSO_001; }
            set { _TST_CSO_001 = value; }
        }
        public double? TST_ESP_001
        {
            get { return _TST_ESP_001; }
            set { _TST_ESP_001 = value; }
        }
        public string TST_TOL_001
        {
            get { return _TST_TOL_001; }
            set { _TST_TOL_001 = value.ToUpper(); }
        }
        public double? TST_DUR_001
        {
            get { return _TST_DUR_001; }
            set { _TST_DUR_001 = value; }
        }
        public double? TST_DFT_001
        {
            get { return _TST_DFT_001; }
            set { _TST_DFT_001 = value; }
        }
        public double? TST_LMC_001
        {
            get { return _TST_LMC_001; }
            set { _TST_LMC_001 = value; }
        }
        public double? TST_UMC_001
        {
            get { return _TST_UMC_001; }
            set { _TST_UMC_001 = value; }
        }
        public double? TST_LPC_001
        {
            get { return _TST_LPC_001; }
            set { _TST_LPC_001 = value; }
        }
        public double? TST_UPC_001
        {
            get { return _TST_UPC_001; }
            set { _TST_UPC_001 = value; }
        }
        public double? TST_CVC_001
        {
            get { return _TST_CVC_001; }
            set { _TST_CVC_001 = value; }
        }
        public double? TST_DFC_001
        {
            get { return _TST_DFC_001; }
            set { _TST_DFC_001 = value; }
        }
        public double? TST_TFS_001
        {
            get { return _TST_TFS_001; }
            set { _TST_TFS_001 = value; }
        }
        public double? TST_FSW_001
        {
            get { return _TST_FSW_001; }
            set { _TST_FSW_001 = value; }
        }
        public double? TST_WFW_001
        {
            get { return _TST_WFW_001; }
            set { _TST_WFW_001 = value; }
        }
        public double? TST_ECO_001
        {
            get { return _TST_ECO_001; }
            set { _TST_ECO_001 = value; }
        }
        public string TST_EOL_001
        {
            get { return _TST_EOL_001; }
            set { _TST_EOL_001 = value; }
        }
        public string TST_ETU_001
        {
            get { return _TST_ETU_001; }
            set { _TST_ETU_001 = value; }
        }
        public string TST_ETD_001
        {
            get { return _TST_ETD_001; }
            set { _TST_ETD_001 = value; }
        }
        public string TST_ECU_001
        {
            get { return _TST_ECU_001; }
            set { _TST_ECU_001 = value; }
        }
        public string TST_EGD_001
        {
            get { return _TST_EGD_001; }
            set { _TST_EGD_001 = value; }
        }
        public string TST_EEC_001
        {
            get { return _TST_EEC_001; }
            set { _TST_EEC_001 = value; }
        }
        public string TST_ECD_001
        {
            get { return _TST_ECD_001; }
            set { _TST_ECD_001 = value; }
        }
        public string TST_EGU_001
        {
            get { return _TST_EGU_001; }
            set { _TST_EGU_001 = value; }
        }
        public string TST_ESO_001
        {
            get { return _TST_ESO_001; }
            set { _TST_ESO_001 = value; }
        }
        public string TST_ESI_001
        {
            get { return _TST_ESI_001; }
            set { _TST_ESI_001 = value; }
        }
        public string TST_ECR_001
        {
            get { return _TST_ECR_001; }
            set { _TST_ECR_001 = value; }
        }
        public string TST_EOD_001
        {
            get { return _TST_EOD_001; }
            set { _TST_EOD_001 = value; }
        }
        public string TST_EAW_001
        {
            get { return _TST_EAW_001; }
            set { _TST_EAW_001 = value; }
        }
        public string TST_ED1_001
        {
            get { return _TST_ED1_001; }
            set { _TST_ED1_001 = value; }
        }
        public string TST_ED2_001
        {
            get { return _TST_ED2_001; }
            set { _TST_ED2_001 = value; }
        }
        public string TST_VW2_002
        {
            get { return _TST_VW2_002; }
            set { _TST_VW2_002 = value.ToUpper(); }
        }
        public string TST_EGM_002
        {
            get { return _TST_EGM_002; }
            set { _TST_EGM_002 = value.ToUpper(); }
        }
        public string TST_DYY_002
        {
            get { return _TST_DYY_002; }
            set { _TST_DYY_002 = value.ToUpper(); }
        }
        public string TST_2WX_002
        {
            get { return _TST_2WX_002; }
            set { _TST_2WX_002 = value.ToUpper(); }
        }
        public string TST_3W3_002
        {
            get { return _TST_3W3_002; }
            set { _TST_3W3_002 = value.ToUpper(); }
        }
        public string TST_4W4_002
        {
            get { return _TST_4W4_002; }
            set { _TST_4W4_002 = value.ToUpper(); }
        }
        public string TST_AGL_002
        {
            get { return _TST_AGL_002; }
            set { _TST_AGL_002 = value.ToUpper(); }
        }
        public string TST_TUP_002
        {
            get { return _TST_TUP_002; }
            set { _TST_TUP_002 = value.ToUpper(); }
        }
        public string TST_VEO_002
        {
            get { return _TST_VEO_002; }
            set { _TST_VEO_002 = value.ToUpper(); }
        }
        public string TST_T1T_002
        {
            get { return _TST_T1T_002; }
            set { _TST_T1T_002 = value.ToUpper(); }
        }
        public string TST_T1C_002
        {
            get { return _TST_T1C_002; }
            set { _TST_T1C_002 = value.ToUpper(); }
        }
        public string TST_T1L_002
        {
            get { return _TST_T1L_002; }
            set { _TST_T1L_002 = value.ToUpper(); }
        }
        public string TST_T2F_002
        {
            get { return _TST_T2F_002; }
            set { _TST_T2F_002 = value.ToUpper(); }
        }
        public string TST_SVE_002
        {
            get { return _TST_SVE_002; }
            set { _TST_SVE_002 = value.ToUpper(); }
        }
        public string TST_STF_002
        {
            get { return _TST_STF_002; }
            set { _TST_STF_002 = value.ToUpper(); }
        }
        public string TST_STM_002
        {
            get { return _TST_STM_002; }
            set { _TST_STM_002 = value.ToUpper(); }
        }
        public string TST_SCE_002
        {
            get { return _TST_SCE_002; }
            set { _TST_SCE_002 = value.ToUpper(); }
        }
        public string TST_SCO_002
        {
            get { return _TST_SCO_002; }
            set { _TST_SCO_002 = value.ToUpper(); }
        }
        public string TST_SCH_002
        {
            get { return _TST_SCH_002; }
            set { _TST_SCH_002 = value.ToUpper(); }
        }
        public string TST_SCG_002
        {
            get { return _TST_SCG_002; }
            set { _TST_SCG_002 = value.ToUpper(); }
        }
        public string TST_SEE_002
        {
            get { return _TST_SEE_002; }
            set { _TST_SEE_002 = value.ToUpper(); }
        }
        public string TST_SEO_002
        {
            get { return _TST_SEO_002; }
            set { _TST_SEO_002 = value.ToUpper(); }
        }
        public string TST_SEH_002
        {
            get { return _TST_SEH_002; }
            set { _TST_SEH_002 = value.ToUpper(); }
        }
        public string TST_SEG_002
        {
            get { return _TST_SEG_002; }
            set { _TST_SEG_002 = value.ToUpper(); }
        }
        public string TST_SJC_002
        {
            get { return _TST_SJC_002; }
            set { _TST_SJC_002 = value.ToUpper(); }
        }
        public string TST_SJT_002
        {
            get { return _TST_SJT_002; }
            set { _TST_SJT_002 = value.ToUpper(); }
        }
        public string TST_SJB_002
        {
            get { return _TST_SJB_002; }
            set { _TST_SJB_002 = value.ToUpper(); }
        }
        public string TST_SPJ_002
        {
            get { return _TST_SPJ_002; }
            set { _TST_SPJ_002 = value.ToUpper(); }
        }
        public string TST_SBC_002
        {
            get { return _TST_SBC_002; }
            set { _TST_SBC_002 = value.ToUpper(); }
        }
        public string TST_SPO_002
        {
            get { return _TST_SPO_002; }
            set { _TST_SPO_002 = value.ToUpper(); }
        }
        public string TST_SVA_002
        {
            get { return _TST_SVA_002; }
            set { _TST_SVA_002 = value.ToUpper(); }
        }
        public string TST_TGR_002
        {
            get { return _TST_TGR_002; }
            set { _TST_TGR_002 = value.ToUpper(); }
        }
        public string TST_TIP_002
        {
            get { return _TST_TIP_002; }
            set { _TST_TIP_002 = value.ToUpper(); }
        }
        public string TST_DSB_002
        {
            get { return _TST_DSB_002; }
            set { _TST_DSB_002 = value.ToUpper(); }
        }
        public string TST_TCA_002
        {
            get { return _TST_TCA_002; }
            set { _TST_TCA_002 = value.ToUpper(); }
        }
        public string TST_FMC_002
        {
            get { return _TST_FMC_002; }
            set { _TST_FMC_002 = value.ToUpper(); }
        }
        public string TST_1TB_002
        {
            get { return _TST_1TB_002; }
            set { _TST_1TB_002 = value.ToUpper(); }
        }
        public string TST_1PP_002
        {
            get { return _TST_1PP_002; }
            set { _TST_1PP_002 = value.ToUpper(); }
        }
        public string TST_2TB_002
        {
            get { return _TST_2TB_002; }
            set { _TST_2TB_002 = value.ToUpper(); }
        }
        public string TST_2PP_002
        {
            get { return _TST_2PP_002; }
            set { _TST_2PP_002 = value.ToUpper(); }
        }
        public string TST_P1C_002
        {
            get { return _TST_P1C_002; }
            set { _TST_P1C_002 = value.ToUpper(); }
        }
        public string TST_P2D_002
        {
            get { return _TST_P2D_002; }
            set { _TST_P2D_002 = value.ToUpper(); }
        }
        public string TST_P3D_002
        {
            get { return _TST_P3D_002; }
            set { _TST_P3D_002 = value.ToUpper(); }
        }
        public string TST_P4U_002
        {
            get { return _TST_P4U_002; }
            set { _TST_P4U_002 = value.ToUpper(); }
        }
        public string TST_MOL_002
        {
            get { return _TST_MOL_002; }
            set { _TST_MOL_002 = value.ToUpper(); }
        }
        public string TST_TPD_002
        {
            get { return _TST_TPD_002; }
            set { _TST_TPD_002 = value.ToUpper(); }
        }
        public string TST_TT1_002
        {
            get { return _TST_TT1_002; }
            set { _TST_TT1_002 = value.ToUpper(); }
        }
        public string TST_TT2_002
        {
            get { return _TST_TT2_002; }
            set { _TST_TT2_002 = value.ToUpper(); }
        }
        public string TST_TT3_002
        {
            get { return _TST_TT3_002; }
            set { _TST_TT3_002 = value.ToUpper(); }
        }
        public string TST_T21_002
        {
            get { return _TST_T21_002; }
            set { _TST_T21_002 = value.ToUpper(); }
        }
        public string TST_TUN_002
        {
            get { return _TST_TUN_002; }
            set { _TST_TUN_002 = value.ToUpper(); }
        }
        public string TST_TCV_002
        {
            get { return _TST_TCV_002; }
            set { _TST_TCV_002 = value.ToUpper(); }
        }
        public string TST_TSS_002
        {
            get { return _TST_TSS_002; }
            set { _TST_TSS_002 = value.ToUpper(); }
        }
        public double? TST_TIT_002
        {
            get { return _TST_TIT_002; }
            set { _TST_TIT_002 = value; }
        }
        public double? TST_TNC_002
        {
            get { return _TST_TNC_002; }
            set { _TST_TNC_002 = value; }
        }
        public double? TST_AON_002
        {
            get { return _TST_AON_002; }
            set { _TST_AON_002 = value; }
        }
        public double? TST_ENM_002
        {
            get { return _TST_ENM_002; }
            set { _TST_ENM_002 = value; }
        }
        public double? TST_EEE_002
        {
            get { return _TST_EEE_002; }
            set { _TST_EEE_002 = value; }
        }
        public double? TST_KKK_002
        {
            get { return _TST_KKK_002; }
            set { _TST_KKK_002 = value; }
        }
        public double? TST_BBB_002
        {
            get { return _TST_BBB_002; }
            set { _TST_BBB_002 = value; }
        }
        public double? TST_OLE_002
        {
            get { return _TST_OLE_002; }
            set { _TST_OLE_002 = value; }
        }
        public double? TST_TRQ_002
        {
            get { return _TST_TRQ_002; }
            set { _TST_TRQ_002 = value; }
        }
        public double? TST_ERT_002
        {
            get { return _TST_ERT_002; }
            set { _TST_ERT_002 = value; }
        }
        public double? TST_RT3_002
        {
            get { return _TST_RT3_002; }
            set { _TST_RT3_002 = value; }
        }
        public double? TST_RT5_002
        {
            get { return _TST_RT5_002; }
            set { _TST_RT5_002 = value; }
        }
        public double? TST_DND_002
        {
            get { return _TST_DND_002; }
            set { _TST_DND_002 = value; }
        }
        public double? TST_DMO_002
        {
            get { return _TST_DMO_002; }
            set { _TST_DMO_002 = value; }
        }
        public double? TST_PES_002
        {
            get { return _TST_PES_002; }
            set { _TST_PES_002 = value; }
        }
        public string TST_VRR_002
        {
            get { return _TST_VRR_002; }
            set { _TST_VRR_002 = value.ToUpper(); }
        }
        public string TST_TRE_002
        {
            get { return _TST_TRE_002; }
            set { _TST_TRE_002 = value.ToUpper(); }
        }
        public double? TST_LME_002
        {
            get { return _TST_LME_002; }
            set { _TST_LME_002 = value; }
        }
        public double? TST_UME_002
        {
            get { return _TST_UME_002; }
            set { _TST_UME_002 = value; }
        }
        public double? TST_LPE_002
        {
            get { return _TST_LPE_002; }
            set { _TST_LPE_002 = value; }
        }
        public double? TST_UPE_002
        {
            get { return _TST_UPE_002; }
            set { _TST_UPE_002 = value; }
        }
        public double? TST_UCV_002
        {
            get { return _TST_UCV_002; }
            set { _TST_UCV_002 = value; }
        }
        public double? TST_CSO_002
        {
            get { return _TST_CSO_002; }
            set { _TST_CSO_002 = value; }
        }
        public double? TST_ESP_002
        {
            get { return _TST_ESP_002; }
            set { _TST_ESP_002 = value; }
        }
        public string TST_TOL_002
        {
            get { return _TST_TOL_002; }
            set { _TST_TOL_002 = value.ToUpper(); }
        }
        public double? TST_DUR_002
        {
            get { return _TST_DUR_002; }
            set { _TST_DUR_002 = value; }
        }
        public double? TST_DFT_002
        {
            get { return _TST_DFT_002; }
            set { _TST_DFT_002 = value; }
        }
        public double? TST_LMC_002
        {
            get { return _TST_LMC_002; }
            set { _TST_LMC_002 = value; }
        }
        public double? TST_UMC_002
        {
            get { return _TST_UMC_002; }
            set { _TST_UMC_002 = value; }
        }
        public double? TST_LPC_002
        {
            get { return _TST_LPC_002; }
            set { _TST_LPC_002 = value; }
        }
        public double? TST_UPC_002
        {
            get { return _TST_UPC_002; }
            set { _TST_UPC_002 = value; }
        }
        public double? TST_CVC_002
        {
            get { return _TST_CVC_002; }
            set { _TST_CVC_002 = value; }
        }
        public double? TST_DFC_002
        {
            get { return _TST_DFC_002; }
            set { _TST_DFC_002 = value; }
        }
        public double? TST_TFS_002
        {
            get { return _TST_TFS_002; }
            set { _TST_TFS_002 = value; }
        }
        public double? TST_FSW_002
        {
            get { return _TST_FSW_002; }
            set { _TST_FSW_002 = value; }
        }
        public double? TST_WFW_002
        {
            get { return _TST_WFW_002; }
            set { _TST_WFW_002 = value; }
        }
        public double? TST_ECO_002
        {
            get { return _TST_ECO_002; }
            set { _TST_ECO_002 = value; }
        }
        public string TST_EOL_002
        {
            get { return _TST_EOL_002; }
            set { _TST_EOL_002 = value; }
        }
        public string TST_ETU_002
        {
            get { return _TST_ETU_002; }
            set { _TST_ETU_002 = value; }
        }
        public string TST_ETD_002
        {
            get { return _TST_ETD_002; }
            set { _TST_ETD_002 = value; }
        }
        public string TST_ECU_002
        {
            get { return _TST_ECU_002; }
            set { _TST_ECU_002 = value; }
        }
        public string TST_EGD_002
        {
            get { return _TST_EGD_002; }
            set { _TST_EGD_002 = value; }
        }
        public string TST_EEC_002
        {
            get { return _TST_EEC_002; }
            set { _TST_EEC_002 = value; }
        }
        public string TST_ECD_002
        {
            get { return _TST_ECD_002; }
            set { _TST_ECD_002 = value; }
        }
        public string TST_EGU_002
        {
            get { return _TST_EGU_002; }
            set { _TST_EGU_002 = value; }
        }
        public string TST_ESO_002
        {
            get { return _TST_ESO_002; }
            set { _TST_ESO_002 = value; }
        }
        public string TST_ESI_002
        {
            get { return _TST_ESI_002; }
            set { _TST_ESI_002 = value; }
        }
        public string TST_ECR_002
        {
            get { return _TST_ECR_002; }
            set { _TST_ECR_002 = value; }
        }
        public string TST_EOD_002
        {
            get { return _TST_EOD_002; }
            set { _TST_EOD_002 = value; }
        }
        public string TST_EAW_002
        {
            get { return _TST_EAW_002; }
            set { _TST_EAW_002 = value; }
        }
        public string TST_ED1_002
        {
            get { return _TST_ED1_002; }
            set { _TST_ED1_002 = value; }
        }
        public string TST_ED2_002
        {
            get { return _TST_ED2_002; }
            set { _TST_ED2_002 = value; }
        }
        public string TST_VW2_003
        {
            get { return _TST_VW2_003; }
            set { _TST_VW2_003 = value.ToUpper(); }
        }
        public string TST_EGM_003
        {
            get { return _TST_EGM_003; }
            set { _TST_EGM_003 = value.ToUpper(); }
        }
        public string TST_DYY_003
        {
            get { return _TST_DYY_003; }
            set { _TST_DYY_003 = value.ToUpper(); }
        }
        public string TST_2WX_003
        {
            get { return _TST_2WX_003; }
            set { _TST_2WX_003 = value.ToUpper(); }
        }
        public string TST_3W3_003
        {
            get { return _TST_3W3_003; }
            set { _TST_3W3_003 = value.ToUpper(); }
        }
        public string TST_4W4_003
        {
            get { return _TST_4W4_003; }
            set { _TST_4W4_003 = value.ToUpper(); }
        }
        public string TST_AGL_003
        {
            get { return _TST_AGL_003; }
            set { _TST_AGL_003 = value.ToUpper(); }
        }
        public string TST_TUP_003
        {
            get { return _TST_TUP_003; }
            set { _TST_TUP_003 = value.ToUpper(); }
        }
        public string TST_VEO_003
        {
            get { return _TST_VEO_003; }
            set { _TST_VEO_003 = value.ToUpper(); }
        }
        public string TST_T1T_003
        {
            get { return _TST_T1T_003; }
            set { _TST_T1T_003 = value.ToUpper(); }
        }
        public string TST_T1C_003
        {
            get { return _TST_T1C_003; }
            set { _TST_T1C_003 = value.ToUpper(); }
        }
        public string TST_T1L_003
        {
            get { return _TST_T1L_003; }
            set { _TST_T1L_003 = value.ToUpper(); }
        }
        public string TST_T2F_003
        {
            get { return _TST_T2F_003; }
            set { _TST_T2F_003 = value.ToUpper(); }
        }
        public string TST_SVE_003
        {
            get { return _TST_SVE_003; }
            set { _TST_SVE_003 = value.ToUpper(); }
        }
        public string TST_STF_003
        {
            get { return _TST_STF_003; }
            set { _TST_STF_003 = value.ToUpper(); }
        }
        public string TST_STM_003
        {
            get { return _TST_STM_003; }
            set { _TST_STM_003 = value.ToUpper(); }
        }
        public string TST_SCE_003
        {
            get { return _TST_SCE_003; }
            set { _TST_SCE_003 = value.ToUpper(); }
        }
        public string TST_SCO_003
        {
            get { return _TST_SCO_003; }
            set { _TST_SCO_003 = value.ToUpper(); }
        }
        public string TST_SCH_003
        {
            get { return _TST_SCH_003; }
            set { _TST_SCH_003 = value.ToUpper(); }
        }
        public string TST_SCG_003
        {
            get { return _TST_SCG_003; }
            set { _TST_SCG_003 = value.ToUpper(); }
        }
        public string TST_SEE_003
        {
            get { return _TST_SEE_003; }
            set { _TST_SEE_003 = value.ToUpper(); }
        }
        public string TST_SEO_003
        {
            get { return _TST_SEO_003; }
            set { _TST_SEO_003 = value.ToUpper(); }
        }
        public string TST_SEH_003
        {
            get { return _TST_SEH_003; }
            set { _TST_SEH_003 = value.ToUpper(); }
        }
        public string TST_SEG_003
        {
            get { return _TST_SEG_003; }
            set { _TST_SEG_003 = value.ToUpper(); }
        }
        public string TST_SJC_003
        {
            get { return _TST_SJC_003; }
            set { _TST_SJC_003 = value.ToUpper(); }
        }
        public string TST_SJT_003
        {
            get { return _TST_SJT_003; }
            set { _TST_SJT_003 = value.ToUpper(); }
        }
        public string TST_SJB_003
        {
            get { return _TST_SJB_003; }
            set { _TST_SJB_003 = value.ToUpper(); }
        }
        public string TST_SPJ_003
        {
            get { return _TST_SPJ_003; }
            set { _TST_SPJ_003 = value.ToUpper(); }
        }
        public string TST_SBC_003
        {
            get { return _TST_SBC_003; }
            set { _TST_SBC_003 = value.ToUpper(); }
        }
        public string TST_SPO_003
        {
            get { return _TST_SPO_003; }
            set { _TST_SPO_003 = value.ToUpper(); }
        }
        public string TST_SVA_003
        {
            get { return _TST_SVA_003; }
            set { _TST_SVA_003 = value.ToUpper(); }
        }
        public string TST_TGR_003
        {
            get { return _TST_TGR_003; }
            set { _TST_TGR_003 = value.ToUpper(); }
        }
        public string TST_TIP_003
        {
            get { return _TST_TIP_003; }
            set { _TST_TIP_003 = value.ToUpper(); }
        }
        public string TST_DSB_003
        {
            get { return _TST_DSB_003; }
            set { _TST_DSB_003 = value.ToUpper(); }
        }
        public string TST_TCA_003
        {
            get { return _TST_TCA_003; }
            set { _TST_TCA_003 = value.ToUpper(); }
        }
        public string TST_FMC_003
        {
            get { return _TST_FMC_003; }
            set { _TST_FMC_003 = value.ToUpper(); }
        }
        public string TST_1TB_003
        {
            get { return _TST_1TB_003; }
            set { _TST_1TB_003 = value.ToUpper(); }
        }
        public string TST_1PP_003
        {
            get { return _TST_1PP_003; }
            set { _TST_1PP_003 = value.ToUpper(); }
        }
        public string TST_2TB_003
        {
            get { return _TST_2TB_003; }
            set { _TST_2TB_003 = value.ToUpper(); }
        }
        public string TST_2PP_003
        {
            get { return _TST_2PP_003; }
            set { _TST_2PP_003 = value.ToUpper(); }
        }
        public string TST_P1C_003
        {
            get { return _TST_P1C_003; }
            set { _TST_P1C_003 = value.ToUpper(); }
        }
        public string TST_P2D_003
        {
            get { return _TST_P2D_003; }
            set { _TST_P2D_003 = value.ToUpper(); }
        }
        public string TST_P3D_003
        {
            get { return _TST_P3D_003; }
            set { _TST_P3D_003 = value.ToUpper(); }
        }
        public string TST_P4U_003
        {
            get { return _TST_P4U_003; }
            set { _TST_P4U_003 = value.ToUpper(); }
        }
        public string TST_MOL_003
        {
            get { return _TST_MOL_003; }
            set { _TST_MOL_003 = value.ToUpper(); }
        }
        public string TST_TPD_003
        {
            get { return _TST_TPD_003; }
            set { _TST_TPD_003 = value.ToUpper(); }
        }
        public string TST_TT1_003
        {
            get { return _TST_TT1_003; }
            set { _TST_TT1_003 = value.ToUpper(); }
        }
        public string TST_TT2_003
        {
            get { return _TST_TT2_003; }
            set { _TST_TT2_003 = value.ToUpper(); }
        }
        public string TST_TT3_003
        {
            get { return _TST_TT3_003; }
            set { _TST_TT3_003 = value.ToUpper(); }
        }
        public string TST_T21_003
        {
            get { return _TST_T21_003; }
            set { _TST_T21_003 = value.ToUpper(); }
        }
        public string TST_TUN_003
        {
            get { return _TST_TUN_003; }
            set { _TST_TUN_003 = value.ToUpper(); }
        }
        public string TST_TCV_003
        {
            get { return _TST_TCV_003; }
            set { _TST_TCV_003 = value.ToUpper(); }
        }
        public string TST_TSS_003
        {
            get { return _TST_TSS_003; }
            set { _TST_TSS_003 = value.ToUpper(); }
        }
        public double? TST_TIT_003
        {
            get { return _TST_TIT_003; }
            set { _TST_TIT_003 = value; }
        }
        public double? TST_TNC_003
        {
            get { return _TST_TNC_003; }
            set { _TST_TNC_003 = value; }
        }
        public double? TST_AON_003
        {
            get { return _TST_AON_003; }
            set { _TST_AON_003 = value; }
        }
        public double? TST_ENM_003
        {
            get { return _TST_ENM_003; }
            set { _TST_ENM_003 = value; }
        }
        public double? TST_EEE_003
        {
            get { return _TST_EEE_003; }
            set { _TST_EEE_003 = value; }
        }
        public double? TST_KKK_003
        {
            get { return _TST_KKK_003; }
            set { _TST_KKK_003 = value; }
        }
        public double? TST_BBB_003
        {
            get { return _TST_BBB_003; }
            set { _TST_BBB_003 = value; }
        }
        public double? TST_OLE_003
        {
            get { return _TST_OLE_003; }
            set { _TST_OLE_003 = value; }
        }
        public double? TST_TRQ_003
        {
            get { return _TST_TRQ_003; }
            set { _TST_TRQ_003 = value; }
        }
        public double? TST_ERT_003
        {
            get { return _TST_ERT_003; }
            set { _TST_ERT_003 = value; }
        }
        public double? TST_RT3_003
        {
            get { return _TST_RT3_003; }
            set { _TST_RT3_003 = value; }
        }
        public double? TST_RT5_003
        {
            get { return _TST_RT5_003; }
            set { _TST_RT5_003 = value; }
        }
        public double? TST_DND_003
        {
            get { return _TST_DND_003; }
            set { _TST_DND_003 = value; }
        }
        public double? TST_DMO_003
        {
            get { return _TST_DMO_003; }
            set { _TST_DMO_003 = value; }
        }
        public double? TST_PES_003
        {
            get { return _TST_PES_003; }
            set { _TST_PES_003 = value; }
        }
        public string TST_VRR_003
        {
            get { return _TST_VRR_003; }
            set { _TST_VRR_003 = value.ToUpper(); }
        }
        public string TST_TRE_003
        {
            get { return _TST_TRE_003; }
            set { _TST_TRE_003 = value.ToUpper(); }
        }
        public double? TST_LME_003
        {
            get { return _TST_LME_003; }
            set { _TST_LME_003 = value; }
        }
        public double? TST_UME_003
        {
            get { return _TST_UME_003; }
            set { _TST_UME_003 = value; }
        }
        public double? TST_LPE_003
        {
            get { return _TST_LPE_003; }
            set { _TST_LPE_003 = value; }
        }
        public double? TST_UPE_003
        {
            get { return _TST_UPE_003; }
            set { _TST_UPE_003 = value; }
        }
        public double? TST_UCV_003
        {
            get { return _TST_UCV_003; }
            set { _TST_UCV_003 = value; }
        }
        public double? TST_CSO_003
        {
            get { return _TST_CSO_003; }
            set { _TST_CSO_003 = value; }
        }
        public double? TST_ESP_003
        {
            get { return _TST_ESP_003; }
            set { _TST_ESP_003 = value; }
        }
        public string TST_TOL_003
        {
            get { return _TST_TOL_003; }
            set { _TST_TOL_003 = value.ToUpper(); }
        }
        public double? TST_DUR_003
        {
            get { return _TST_DUR_003; }
            set { _TST_DUR_003 = value; }
        }
        public double? TST_DFT_003
        {
            get { return _TST_DFT_003; }
            set { _TST_DFT_003 = value; }
        }
        public double? TST_LMC_003
        {
            get { return _TST_LMC_003; }
            set { _TST_LMC_003 = value; }
        }
        public double? TST_UMC_003
        {
            get { return _TST_UMC_003; }
            set { _TST_UMC_003 = value; }
        }
        public double? TST_LPC_003
        {
            get { return _TST_LPC_003; }
            set { _TST_LPC_003 = value; }
        }
        public double? TST_UPC_003
        {
            get { return _TST_UPC_003; }
            set { _TST_UPC_003 = value; }
        }
        public double? TST_CVC_003
        {
            get { return _TST_CVC_003; }
            set { _TST_CVC_003 = value; }
        }
        public double? TST_DFC_003
        {
            get { return _TST_DFC_003; }
            set { _TST_DFC_003 = value; }
        }
        public double? TST_TFS_003
        {
            get { return _TST_TFS_003; }
            set { _TST_TFS_003 = value; }
        }
        public double? TST_FSW_003
        {
            get { return _TST_FSW_003; }
            set { _TST_FSW_003 = value; }
        }
        public double? TST_WFW_003
        {
            get { return _TST_WFW_003; }
            set { _TST_WFW_003 = value; }
        }
        public double? TST_ECO_003
        {
            get { return _TST_ECO_003; }
            set { _TST_ECO_003 = value; }
        }
        public string TST_EOL_003
        {
            get { return _TST_EOL_003; }
            set { _TST_EOL_003 = value; }
        }
        public string TST_ETU_003
        {
            get { return _TST_ETU_003; }
            set { _TST_ETU_003 = value; }
        }
        public string TST_ETD_003
        {
            get { return _TST_ETD_003; }
            set { _TST_ETD_003 = value; }
        }
        public string TST_ECU_003
        {
            get { return _TST_ECU_003; }
            set { _TST_ECU_003 = value; }
        }
        public string TST_EGD_003
        {
            get { return _TST_EGD_003; }
            set { _TST_EGD_003 = value; }
        }
        public string TST_EEC_003
        {
            get { return _TST_EEC_003; }
            set { _TST_EEC_003 = value; }
        }
        public string TST_ECD_003
        {
            get { return _TST_ECD_003; }
            set { _TST_ECD_003 = value; }
        }
        public string TST_EGU_003
        {
            get { return _TST_EGU_003; }
            set { _TST_EGU_003 = value; }
        }
        public string TST_ESO_003
        {
            get { return _TST_ESO_003; }
            set { _TST_ESO_003 = value; }
        }
        public string TST_ESI_003
        {
            get { return _TST_ESI_003; }
            set { _TST_ESI_003 = value; }
        }
        public string TST_ECR_003
        {
            get { return _TST_ECR_003; }
            set { _TST_ECR_003 = value; }
        }
        public string TST_EOD_003
        {
            get { return _TST_EOD_003; }
            set { _TST_EOD_003 = value; }
        }
        public string TST_EAW_003
        {
            get { return _TST_EAW_003; }
            set { _TST_EAW_003 = value; }
        }
        public string TST_ED1_003
        {
            get { return _TST_ED1_003; }
            set { _TST_ED1_003 = value; }
        }
        public string TST_ED2_003
        {
            get { return _TST_ED2_003; }
            set { _TST_ED2_003 = value; }
        }
        public string TST_VW2_004
        {
            get { return _TST_VW2_004; }
            set { _TST_VW2_004 = value.ToUpper(); }
        }
        public string TST_EGM_004
        {
            get { return _TST_EGM_004; }
            set { _TST_EGM_004 = value.ToUpper(); }
        }
        public string TST_DYY_004
        {
            get { return _TST_DYY_004; }
            set { _TST_DYY_004 = value.ToUpper(); }
        }
        public string TST_2WX_004
        {
            get { return _TST_2WX_004; }
            set { _TST_2WX_004 = value.ToUpper(); }
        }
        public string TST_3W3_004
        {
            get { return _TST_3W3_004; }
            set { _TST_3W3_004 = value.ToUpper(); }
        }
        public string TST_4W4_004
        {
            get { return _TST_4W4_004; }
            set { _TST_4W4_004 = value.ToUpper(); }
        }
        public string TST_AGL_004
        {
            get { return _TST_AGL_004; }
            set { _TST_AGL_004 = value.ToUpper(); }
        }
        public string TST_TUP_004
        {
            get { return _TST_TUP_004; }
            set { _TST_TUP_004 = value.ToUpper(); }
        }
        public string TST_VEO_004
        {
            get { return _TST_VEO_004; }
            set { _TST_VEO_004 = value.ToUpper(); }
        }
        public string TST_T1T_004
        {
            get { return _TST_T1T_004; }
            set { _TST_T1T_004 = value.ToUpper(); }
        }
        public string TST_T1C_004
        {
            get { return _TST_T1C_004; }
            set { _TST_T1C_004 = value.ToUpper(); }
        }
        public string TST_T1L_004
        {
            get { return _TST_T1L_004; }
            set { _TST_T1L_004 = value.ToUpper(); }
        }
        public string TST_T2F_004
        {
            get { return _TST_T2F_004; }
            set { _TST_T2F_004 = value.ToUpper(); }
        }
        public string TST_SVE_004
        {
            get { return _TST_SVE_004; }
            set { _TST_SVE_004 = value.ToUpper(); }
        }
        public string TST_STF_004
        {
            get { return _TST_STF_004; }
            set { _TST_STF_004 = value.ToUpper(); }
        }
        public string TST_STM_004
        {
            get { return _TST_STM_004; }
            set { _TST_STM_004 = value.ToUpper(); }
        }
        public string TST_SCE_004
        {
            get { return _TST_SCE_004; }
            set { _TST_SCE_004 = value.ToUpper(); }
        }
        public string TST_SCO_004
        {
            get { return _TST_SCO_004; }
            set { _TST_SCO_004 = value.ToUpper(); }
        }
        public string TST_SCH_004
        {
            get { return _TST_SCH_004; }
            set { _TST_SCH_004 = value.ToUpper(); }
        }
        public string TST_SCG_004
        {
            get { return _TST_SCG_004; }
            set { _TST_SCG_004 = value.ToUpper(); }
        }
        public string TST_SEE_004
        {
            get { return _TST_SEE_004; }
            set { _TST_SEE_004 = value.ToUpper(); }
        }
        public string TST_SEO_004
        {
            get { return _TST_SEO_004; }
            set { _TST_SEO_004 = value.ToUpper(); }
        }
        public string TST_SEH_004
        {
            get { return _TST_SEH_004; }
            set { _TST_SEH_004 = value.ToUpper(); }
        }
        public string TST_SEG_004
        {
            get { return _TST_SEG_004; }
            set { _TST_SEG_004 = value.ToUpper(); }
        }
        public string TST_SJC_004
        {
            get { return _TST_SJC_004; }
            set { _TST_SJC_004 = value.ToUpper(); }
        }
        public string TST_SJT_004
        {
            get { return _TST_SJT_004; }
            set { _TST_SJT_004 = value.ToUpper(); }
        }
        public string TST_SJB_004
        {
            get { return _TST_SJB_004; }
            set { _TST_SJB_004 = value.ToUpper(); }
        }
        public string TST_SPJ_004
        {
            get { return _TST_SPJ_004; }
            set { _TST_SPJ_004 = value.ToUpper(); }
        }
        public string TST_SBC_004
        {
            get { return _TST_SBC_004; }
            set { _TST_SBC_004 = value.ToUpper(); }
        }
        public string TST_SPO_004
        {
            get { return _TST_SPO_004; }
            set { _TST_SPO_004 = value.ToUpper(); }
        }
        public string TST_SVA_004
        {
            get { return _TST_SVA_004; }
            set { _TST_SVA_004 = value.ToUpper(); }
        }
        public string TST_TGR_004
        {
            get { return _TST_TGR_004; }
            set { _TST_TGR_004 = value.ToUpper(); }
        }
        public string TST_TIP_004
        {
            get { return _TST_TIP_004; }
            set { _TST_TIP_004 = value.ToUpper(); }
        }
        public string TST_DSB_004
        {
            get { return _TST_DSB_004; }
            set { _TST_DSB_004 = value.ToUpper(); }
        }
        public string TST_TCA_004
        {
            get { return _TST_TCA_004; }
            set { _TST_TCA_004 = value.ToUpper(); }
        }
        public string TST_FMC_004
        {
            get { return _TST_FMC_004; }
            set { _TST_FMC_004 = value.ToUpper(); }
        }
        public string TST_1TB_004
        {
            get { return _TST_1TB_004; }
            set { _TST_1TB_004 = value.ToUpper(); }
        }
        public string TST_1PP_004
        {
            get { return _TST_1PP_004; }
            set { _TST_1PP_004 = value.ToUpper(); }
        }
        public string TST_2TB_004
        {
            get { return _TST_2TB_004; }
            set { _TST_2TB_004 = value.ToUpper(); }
        }
        public string TST_2PP_004
        {
            get { return _TST_2PP_004; }
            set { _TST_2PP_004 = value.ToUpper(); }
        }
        public string TST_P1C_004
        {
            get { return _TST_P1C_004; }
            set { _TST_P1C_004 = value.ToUpper(); }
        }
        public string TST_P2D_004
        {
            get { return _TST_P2D_004; }
            set { _TST_P2D_004 = value.ToUpper(); }
        }
        public string TST_P3D_004
        {
            get { return _TST_P3D_004; }
            set { _TST_P3D_004 = value.ToUpper(); }
        }
        public string TST_P4U_004
        {
            get { return _TST_P4U_004; }
            set { _TST_P4U_004 = value.ToUpper(); }
        }
        public string TST_MOL_004
        {
            get { return _TST_MOL_004; }
            set { _TST_MOL_004 = value.ToUpper(); }
        }
        public string TST_TPD_004
        {
            get { return _TST_TPD_004; }
            set { _TST_TPD_004 = value.ToUpper(); }
        }
        public string TST_TT1_004
        {
            get { return _TST_TT1_004; }
            set { _TST_TT1_004 = value.ToUpper(); }
        }
        public string TST_TT2_004
        {
            get { return _TST_TT2_004; }
            set { _TST_TT2_004 = value.ToUpper(); }
        }
        public string TST_TT3_004
        {
            get { return _TST_TT3_004; }
            set { _TST_TT3_004 = value.ToUpper(); }
        }
        public string TST_T21_004
        {
            get { return _TST_T21_004; }
            set { _TST_T21_004 = value.ToUpper(); }
        }
        public string TST_TUN_004
        {
            get { return _TST_TUN_004; }
            set { _TST_TUN_004 = value.ToUpper(); }
        }
        public string TST_TCV_004
        {
            get { return _TST_TCV_004; }
            set { _TST_TCV_004 = value.ToUpper(); }
        }
        public string TST_TSS_004
        {
            get { return _TST_TSS_004; }
            set { _TST_TSS_004 = value.ToUpper(); }
        }
        public double? TST_TIT_004
        {
            get { return _TST_TIT_004; }
            set { _TST_TIT_004 = value; }
        }
        public double? TST_TNC_004
        {
            get { return _TST_TNC_004; }
            set { _TST_TNC_004 = value; }
        }
        public double? TST_AON_004
        {
            get { return _TST_AON_004; }
            set { _TST_AON_004 = value; }
        }
        public double? TST_ENM_004
        {
            get { return _TST_ENM_004; }
            set { _TST_ENM_004 = value; }
        }
        public double? TST_EEE_004
        {
            get { return _TST_EEE_004; }
            set { _TST_EEE_004 = value; }
        }
        public double? TST_KKK_004
        {
            get { return _TST_KKK_004; }
            set { _TST_KKK_004 = value; }
        }
        public double? TST_BBB_004
        {
            get { return _TST_BBB_004; }
            set { _TST_BBB_004 = value; }
        }
        public double? TST_OLE_004
        {
            get { return _TST_OLE_004; }
            set { _TST_OLE_004 = value; }
        }
        public double? TST_TRQ_004
        {
            get { return _TST_TRQ_004; }
            set { _TST_TRQ_004 = value; }
        }
        public double? TST_ERT_004
        {
            get { return _TST_ERT_004; }
            set { _TST_ERT_004 = value; }
        }
        public double? TST_RT3_004
        {
            get { return _TST_RT3_004; }
            set { _TST_RT3_004 = value; }
        }
        public double? TST_RT5_004
        {
            get { return _TST_RT5_004; }
            set { _TST_RT5_004 = value; }
        }
        public double? TST_DND_004
        {
            get { return _TST_DND_004; }
            set { _TST_DND_004 = value; }
        }
        public double? TST_DMO_004
        {
            get { return _TST_DMO_004; }
            set { _TST_DMO_004 = value; }
        }
        public double? TST_PES_004
        {
            get { return _TST_PES_004; }
            set { _TST_PES_004 = value; }
        }
        public string TST_VRR_004
        {
            get { return _TST_VRR_004; }
            set { _TST_VRR_004 = value.ToUpper(); }
        }
        public string TST_TRE_004
        {
            get { return _TST_TRE_004; }
            set { _TST_TRE_004 = value.ToUpper(); }
        }
        public double? TST_LME_004
        {
            get { return _TST_LME_004; }
            set { _TST_LME_004 = value; }
        }
        public double? TST_UME_004
        {
            get { return _TST_UME_004; }
            set { _TST_UME_004 = value; }
        }
        public double? TST_LPE_004
        {
            get { return _TST_LPE_004; }
            set { _TST_LPE_004 = value; }
        }
        public double? TST_UPE_004
        {
            get { return _TST_UPE_004; }
            set { _TST_UPE_004 = value; }
        }
        public double? TST_UCV_004
        {
            get { return _TST_UCV_004; }
            set { _TST_UCV_004 = value; }
        }
        public double? TST_CSO_004
        {
            get { return _TST_CSO_004; }
            set { _TST_CSO_004 = value; }
        }
        public double? TST_ESP_004
        {
            get { return _TST_ESP_004; }
            set { _TST_ESP_004 = value; }
        }
        public string TST_TOL_004
        {
            get { return _TST_TOL_004; }
            set { _TST_TOL_004 = value.ToUpper(); }
        }
        public double? TST_DUR_004
        {
            get { return _TST_DUR_004; }
            set { _TST_DUR_004 = value; }
        }
        public double? TST_DFT_004
        {
            get { return _TST_DFT_004; }
            set { _TST_DFT_004 = value; }
        }
        public double? TST_LMC_004
        {
            get { return _TST_LMC_004; }
            set { _TST_LMC_004 = value; }
        }
        public double? TST_UMC_004
        {
            get { return _TST_UMC_004; }
            set { _TST_UMC_004 = value; }
        }
        public double? TST_LPC_004
        {
            get { return _TST_LPC_004; }
            set { _TST_LPC_004 = value; }
        }
        public double? TST_UPC_004
        {
            get { return _TST_UPC_004; }
            set { _TST_UPC_004 = value; }
        }
        public double? TST_CVC_004
        {
            get { return _TST_CVC_004; }
            set { _TST_CVC_004 = value; }
        }
        public double? TST_DFC_004
        {
            get { return _TST_DFC_004; }
            set { _TST_DFC_004 = value; }
        }
        public double? TST_TFS_004
        {
            get { return _TST_TFS_004; }
            set { _TST_TFS_004 = value; }
        }
        public double? TST_FSW_004
        {
            get { return _TST_FSW_004; }
            set { _TST_FSW_004 = value; }
        }
        public double? TST_WFW_004
        {
            get { return _TST_WFW_004; }
            set { _TST_WFW_004 = value; }
        }
        public double? TST_ECO_004
        {
            get { return _TST_ECO_004; }
            set { _TST_ECO_004 = value; }
        }
        public string TST_EOL_004
        {
            get { return _TST_EOL_004; }
            set { _TST_EOL_004 = value; }
        }
        public string TST_ETU_004
        {
            get { return _TST_ETU_004; }
            set { _TST_ETU_004 = value; }
        }
        public string TST_ETD_004
        {
            get { return _TST_ETD_004; }
            set { _TST_ETD_004 = value; }
        }
        public string TST_ECU_004
        {
            get { return _TST_ECU_004; }
            set { _TST_ECU_004 = value; }
        }
        public string TST_EGD_004
        {
            get { return _TST_EGD_004; }
            set { _TST_EGD_004 = value; }
        }
        public string TST_EEC_004
        {
            get { return _TST_EEC_004; }
            set { _TST_EEC_004 = value; }
        }
        public string TST_ECD_004
        {
            get { return _TST_ECD_004; }
            set { _TST_ECD_004 = value; }
        }
        public string TST_EGU_004
        {
            get { return _TST_EGU_004; }
            set { _TST_EGU_004 = value; }
        }
        public string TST_ESO_004
        {
            get { return _TST_ESO_004; }
            set { _TST_ESO_004 = value; }
        }
        public string TST_ESI_004
        {
            get { return _TST_ESI_004; }
            set { _TST_ESI_004 = value; }
        }
        public string TST_ECR_004
        {
            get { return _TST_ECR_004; }
            set { _TST_ECR_004 = value; }
        }
        public string TST_EOD_004
        {
            get { return _TST_EOD_004; }
            set { _TST_EOD_004 = value; }
        }
        public string TST_EAW_004
        {
            get { return _TST_EAW_004; }
            set { _TST_EAW_004 = value; }
        }
        public string TST_ED1_004
        {
            get { return _TST_ED1_004; }
            set { _TST_ED1_004 = value; }
        }
        public string TST_ED2_004
        {
            get { return _TST_ED2_004; }
            set { _TST_ED2_004 = value; }
        }
        public string TST_VW2_005
        {
            get { return _TST_VW2_005; }
            set { _TST_VW2_005 = value.ToUpper(); }
        }
        public string TST_EGM_005
        {
            get { return _TST_EGM_005; }
            set { _TST_EGM_005 = value.ToUpper(); }
        }
        public string TST_DYY_005
        {
            get { return _TST_DYY_005; }
            set { _TST_DYY_005 = value.ToUpper(); }
        }
        public string TST_2WX_005
        {
            get { return _TST_2WX_005; }
            set { _TST_2WX_005 = value.ToUpper(); }
        }
        public string TST_3W3_005
        {
            get { return _TST_3W3_005; }
            set { _TST_3W3_005 = value.ToUpper(); }
        }
        public string TST_4W4_005
        {
            get { return _TST_4W4_005; }
            set { _TST_4W4_005 = value.ToUpper(); }
        }
        public string TST_AGL_005
        {
            get { return _TST_AGL_005; }
            set { _TST_AGL_005 = value.ToUpper(); }
        }
        public string TST_TUP_005
        {
            get { return _TST_TUP_005; }
            set { _TST_TUP_005 = value.ToUpper(); }
        }
        public string TST_VEO_005
        {
            get { return _TST_VEO_005; }
            set { _TST_VEO_005 = value.ToUpper(); }
        }
        public string TST_T1T_005
        {
            get { return _TST_T1T_005; }
            set { _TST_T1T_005 = value.ToUpper(); }
        }
        public string TST_T1C_005
        {
            get { return _TST_T1C_005; }
            set { _TST_T1C_005 = value.ToUpper(); }
        }
        public string TST_T1L_005
        {
            get { return _TST_T1L_005; }
            set { _TST_T1L_005 = value.ToUpper(); }
        }
        public string TST_T2F_005
        {
            get { return _TST_T2F_005; }
            set { _TST_T2F_005 = value.ToUpper(); }
        }
        public string TST_SVE_005
        {
            get { return _TST_SVE_005; }
            set { _TST_SVE_005 = value.ToUpper(); }
        }
        public string TST_STF_005
        {
            get { return _TST_STF_005; }
            set { _TST_STF_005 = value.ToUpper(); }
        }
        public string TST_STM_005
        {
            get { return _TST_STM_005; }
            set { _TST_STM_005 = value.ToUpper(); }
        }
        public string TST_SCE_005
        {
            get { return _TST_SCE_005; }
            set { _TST_SCE_005 = value.ToUpper(); }
        }
        public string TST_SCO_005
        {
            get { return _TST_SCO_005; }
            set { _TST_SCO_005 = value.ToUpper(); }
        }
        public string TST_SCH_005
        {
            get { return _TST_SCH_005; }
            set { _TST_SCH_005 = value.ToUpper(); }
        }
        public string TST_SCG_005
        {
            get { return _TST_SCG_005; }
            set { _TST_SCG_005 = value.ToUpper(); }
        }
        public string TST_SEE_005
        {
            get { return _TST_SEE_005; }
            set { _TST_SEE_005 = value.ToUpper(); }
        }
        public string TST_SEO_005
        {
            get { return _TST_SEO_005; }
            set { _TST_SEO_005 = value.ToUpper(); }
        }
        public string TST_SEH_005
        {
            get { return _TST_SEH_005; }
            set { _TST_SEH_005 = value.ToUpper(); }
        }
        public string TST_SEG_005
        {
            get { return _TST_SEG_005; }
            set { _TST_SEG_005 = value.ToUpper(); }
        }
        public string TST_SJC_005
        {
            get { return _TST_SJC_005; }
            set { _TST_SJC_005 = value.ToUpper(); }
        }
        public string TST_SJT_005
        {
            get { return _TST_SJT_005; }
            set { _TST_SJT_005 = value.ToUpper(); }
        }
        public string TST_SJB_005
        {
            get { return _TST_SJB_005; }
            set { _TST_SJB_005 = value.ToUpper(); }
        }
        public string TST_SPJ_005
        {
            get { return _TST_SPJ_005; }
            set { _TST_SPJ_005 = value.ToUpper(); }
        }
        public string TST_SBC_005
        {
            get { return _TST_SBC_005; }
            set { _TST_SBC_005 = value.ToUpper(); }
        }
        public string TST_SPO_005
        {
            get { return _TST_SPO_005; }
            set { _TST_SPO_005 = value.ToUpper(); }
        }
        public string TST_SVA_005
        {
            get { return _TST_SVA_005; }
            set { _TST_SVA_005 = value.ToUpper(); }
        }
        public string TST_TGR_005
        {
            get { return _TST_TGR_005; }
            set { _TST_TGR_005 = value.ToUpper(); }
        }
        public string TST_TIP_005
        {
            get { return _TST_TIP_005; }
            set { _TST_TIP_005 = value.ToUpper(); }
        }
        public string TST_DSB_005
        {
            get { return _TST_DSB_005; }
            set { _TST_DSB_005 = value.ToUpper(); }
        }
        public string TST_TCA_005
        {
            get { return _TST_TCA_005; }
            set { _TST_TCA_005 = value.ToUpper(); }
        }
        public string TST_FMC_005
        {
            get { return _TST_FMC_005; }
            set { _TST_FMC_005 = value.ToUpper(); }
        }
        public string TST_1TB_005
        {
            get { return _TST_1TB_005; }
            set { _TST_1TB_005 = value.ToUpper(); }
        }
        public string TST_1PP_005
        {
            get { return _TST_1PP_005; }
            set { _TST_1PP_005 = value.ToUpper(); }
        }
        public string TST_2TB_005
        {
            get { return _TST_2TB_005; }
            set { _TST_2TB_005 = value.ToUpper(); }
        }
        public string TST_2PP_005
        {
            get { return _TST_2PP_005; }
            set { _TST_2PP_005 = value.ToUpper(); }
        }
        public string TST_P1C_005
        {
            get { return _TST_P1C_005; }
            set { _TST_P1C_005 = value.ToUpper(); }
        }
        public string TST_P2D_005
        {
            get { return _TST_P2D_005; }
            set { _TST_P2D_005 = value.ToUpper(); }
        }
        public string TST_P3D_005
        {
            get { return _TST_P3D_005; }
            set { _TST_P3D_005 = value.ToUpper(); }
        }
        public string TST_P4U_005
        {
            get { return _TST_P4U_005; }
            set { _TST_P4U_005 = value.ToUpper(); }
        }
        public string TST_MOL_005
        {
            get { return _TST_MOL_005; }
            set { _TST_MOL_005 = value.ToUpper(); }
        }
        public string TST_TPD_005
        {
            get { return _TST_TPD_005; }
            set { _TST_TPD_005 = value.ToUpper(); }
        }
        public string TST_TT1_005
        {
            get { return _TST_TT1_005; }
            set { _TST_TT1_005 = value.ToUpper(); }
        }
        public string TST_TT2_005
        {
            get { return _TST_TT2_005; }
            set { _TST_TT2_005 = value.ToUpper(); }
        }
        public string TST_TT3_005
        {
            get { return _TST_TT3_005; }
            set { _TST_TT3_005 = value.ToUpper(); }
        }
        public string TST_T21_005
        {
            get { return _TST_T21_005; }
            set { _TST_T21_005 = value.ToUpper(); }
        }
        public string TST_TUN_005
        {
            get { return _TST_TUN_005; }
            set { _TST_TUN_005 = value.ToUpper(); }
        }
        public string TST_TCV_005
        {
            get { return _TST_TCV_005; }
            set { _TST_TCV_005 = value.ToUpper(); }
        }
        public string TST_TSS_005
        {
            get { return _TST_TSS_005; }
            set { _TST_TSS_005 = value.ToUpper(); }
        }
        public double? TST_TIT_005
        {
            get { return _TST_TIT_005; }
            set { _TST_TIT_005 = value; }
        }
        public double? TST_TNC_005
        {
            get { return _TST_TNC_005; }
            set { _TST_TNC_005 = value; }
        }
        public double? TST_AON_005
        {
            get { return _TST_AON_005; }
            set { _TST_AON_005 = value; }
        }
        public double? TST_ENM_005
        {
            get { return _TST_ENM_005; }
            set { _TST_ENM_005 = value; }
        }
        public double? TST_EEE_005
        {
            get { return _TST_EEE_005; }
            set { _TST_EEE_005 = value; }
        }
        public double? TST_KKK_005
        {
            get { return _TST_KKK_005; }
            set { _TST_KKK_005 = value; }
        }
        public double? TST_BBB_005
        {
            get { return _TST_BBB_005; }
            set { _TST_BBB_005 = value; }
        }
        public double? TST_OLE_005
        {
            get { return _TST_OLE_005; }
            set { _TST_OLE_005 = value; }
        }
        public double? TST_TRQ_005
        {
            get { return _TST_TRQ_005; }
            set { _TST_TRQ_005 = value; }
        }
        public double? TST_ERT_005
        {
            get { return _TST_ERT_005; }
            set { _TST_ERT_005 = value; }
        }
        public double? TST_RT3_005
        {
            get { return _TST_RT3_005; }
            set { _TST_RT3_005 = value; }
        }
        public double? TST_RT5_005
        {
            get { return _TST_RT5_005; }
            set { _TST_RT5_005 = value; }
        }
        public double? TST_DND_005
        {
            get { return _TST_DND_005; }
            set { _TST_DND_005 = value; }
        }
        public double? TST_DMO_005
        {
            get { return _TST_DMO_005; }
            set { _TST_DMO_005 = value; }
        }
        public double? TST_PES_005
        {
            get { return _TST_PES_005; }
            set { _TST_PES_005 = value; }
        }
        public string TST_VRR_005
        {
            get { return _TST_VRR_005; }
            set { _TST_VRR_005 = value.ToUpper(); }
        }
        public string TST_TRE_005
        {
            get { return _TST_TRE_005; }
            set { _TST_TRE_005 = value.ToUpper(); }
        }
        public double? TST_LME_005
        {
            get { return _TST_LME_005; }
            set { _TST_LME_005 = value; }
        }
        public double? TST_UME_005
        {
            get { return _TST_UME_005; }
            set { _TST_UME_005 = value; }
        }
        public double? TST_LPE_005
        {
            get { return _TST_LPE_005; }
            set { _TST_LPE_005 = value; }
        }
        public double? TST_UPE_005
        {
            get { return _TST_UPE_005; }
            set { _TST_UPE_005 = value; }
        }
        public double? TST_UCV_005
        {
            get { return _TST_UCV_005; }
            set { _TST_UCV_005 = value; }
        }
        public double? TST_CSO_005
        {
            get { return _TST_CSO_005; }
            set { _TST_CSO_005 = value; }
        }
        public double? TST_ESP_005
        {
            get { return _TST_ESP_005; }
            set { _TST_ESP_005 = value; }
        }
        public string TST_TOL_005
        {
            get { return _TST_TOL_005; }
            set { _TST_TOL_005 = value.ToUpper(); }
        }
        public double? TST_DUR_005
        {
            get { return _TST_DUR_005; }
            set { _TST_DUR_005 = value; }
        }
        public double? TST_DFT_005
        {
            get { return _TST_DFT_005; }
            set { _TST_DFT_005 = value; }
        }
        public double? TST_LMC_005
        {
            get { return _TST_LMC_005; }
            set { _TST_LMC_005 = value; }
        }
        public double? TST_UMC_005
        {
            get { return _TST_UMC_005; }
            set { _TST_UMC_005 = value; }
        }
        public double? TST_LPC_005
        {
            get { return _TST_LPC_005; }
            set { _TST_LPC_005 = value; }
        }
        public double? TST_UPC_005
        {
            get { return _TST_UPC_005; }
            set { _TST_UPC_005 = value; }
        }
        public double? TST_CVC_005
        {
            get { return _TST_CVC_005; }
            set { _TST_CVC_005 = value; }
        }
        public double? TST_DFC_005
        {
            get { return _TST_DFC_005; }
            set { _TST_DFC_005 = value; }
        }
        public double? TST_TFS_005
        {
            get { return _TST_TFS_005; }
            set { _TST_TFS_005 = value; }
        }
        public double? TST_FSW_005
        {
            get { return _TST_FSW_005; }
            set { _TST_FSW_005 = value; }
        }
        public double? TST_WFW_005
        {
            get { return _TST_WFW_005; }
            set { _TST_WFW_005 = value; }
        }
        public double? TST_ECO_005
        {
            get { return _TST_ECO_005; }
            set { _TST_ECO_005 = value; }
        }
        public string TST_EOL_005
        {
            get { return _TST_EOL_005; }
            set { _TST_EOL_005 = value; }
        }
        public string TST_ETU_005
        {
            get { return _TST_ETU_005; }
            set { _TST_ETU_005 = value; }
        }
        public string TST_ETD_005
        {
            get { return _TST_ETD_005; }
            set { _TST_ETD_005 = value; }
        }
        public string TST_ECU_005
        {
            get { return _TST_ECU_005; }
            set { _TST_ECU_005 = value; }
        }
        public string TST_EGD_005
        {
            get { return _TST_EGD_005; }
            set { _TST_EGD_005 = value; }
        }
        public string TST_EEC_005
        {
            get { return _TST_EEC_005; }
            set { _TST_EEC_005 = value; }
        }
        public string TST_ECD_005
        {
            get { return _TST_ECD_005; }
            set { _TST_ECD_005 = value; }
        }
        public string TST_EGU_005
        {
            get { return _TST_EGU_005; }
            set { _TST_EGU_005 = value; }
        }
        public string TST_ESO_005
        {
            get { return _TST_ESO_005; }
            set { _TST_ESO_005 = value; }
        }
        public string TST_ESI_005
        {
            get { return _TST_ESI_005; }
            set { _TST_ESI_005 = value; }
        }
        public string TST_ECR_005
        {
            get { return _TST_ECR_005; }
            set { _TST_ECR_005 = value; }
        }
        public string TST_EOD_005
        {
            get { return _TST_EOD_005; }
            set { _TST_EOD_005 = value; }
        }
        public string TST_EAW_005
        {
            get { return _TST_EAW_005; }
            set { _TST_EAW_005 = value; }
        }
        public string TST_ED1_005
        {
            get { return _TST_ED1_005; }
            set { _TST_ED1_005 = value; }
        }
        public string TST_ED2_005
        {
            get { return _TST_ED2_005; }
            set { _TST_ED2_005 = value; }
        }
        public string TST_VW2_006
        {
            get { return _TST_VW2_006; }
            set { _TST_VW2_006 = value.ToUpper(); }
        }
        public string TST_EGM_006
        {
            get { return _TST_EGM_006; }
            set { _TST_EGM_006 = value.ToUpper(); }
        }
        public string TST_DYY_006
        {
            get { return _TST_DYY_006; }
            set { _TST_DYY_006 = value.ToUpper(); }
        }
        public string TST_2WX_006
        {
            get { return _TST_2WX_006; }
            set { _TST_2WX_006 = value.ToUpper(); }
        }
        public string TST_3W3_006
        {
            get { return _TST_3W3_006; }
            set { _TST_3W3_006 = value.ToUpper(); }
        }
        public string TST_4W4_006
        {
            get { return _TST_4W4_006; }
            set { _TST_4W4_006 = value.ToUpper(); }
        }
        public string TST_AGL_006
        {
            get { return _TST_AGL_006; }
            set { _TST_AGL_006 = value.ToUpper(); }
        }
        public string TST_TUP_006
        {
            get { return _TST_TUP_006; }
            set { _TST_TUP_006 = value.ToUpper(); }
        }
        public string TST_VEO_006
        {
            get { return _TST_VEO_006; }
            set { _TST_VEO_006 = value.ToUpper(); }
        }
        public string TST_T1T_006
        {
            get { return _TST_T1T_006; }
            set { _TST_T1T_006 = value.ToUpper(); }
        }
        public string TST_T1C_006
        {
            get { return _TST_T1C_006; }
            set { _TST_T1C_006 = value.ToUpper(); }
        }
        public string TST_T1L_006
        {
            get { return _TST_T1L_006; }
            set { _TST_T1L_006 = value.ToUpper(); }
        }
        public string TST_T2F_006
        {
            get { return _TST_T2F_006; }
            set { _TST_T2F_006 = value.ToUpper(); }
        }
        public string TST_SVE_006
        {
            get { return _TST_SVE_006; }
            set { _TST_SVE_006 = value.ToUpper(); }
        }
        public string TST_STF_006
        {
            get { return _TST_STF_006; }
            set { _TST_STF_006 = value.ToUpper(); }
        }
        public string TST_STM_006
        {
            get { return _TST_STM_006; }
            set { _TST_STM_006 = value.ToUpper(); }
        }
        public string TST_SCE_006
        {
            get { return _TST_SCE_006; }
            set { _TST_SCE_006 = value.ToUpper(); }
        }
        public string TST_SCO_006
        {
            get { return _TST_SCO_006; }
            set { _TST_SCO_006 = value.ToUpper(); }
        }
        public string TST_SCH_006
        {
            get { return _TST_SCH_006; }
            set { _TST_SCH_006 = value.ToUpper(); }
        }
        public string TST_SCG_006
        {
            get { return _TST_SCG_006; }
            set { _TST_SCG_006 = value.ToUpper(); }
        }
        public string TST_SEE_006
        {
            get { return _TST_SEE_006; }
            set { _TST_SEE_006 = value.ToUpper(); }
        }
        public string TST_SEO_006
        {
            get { return _TST_SEO_006; }
            set { _TST_SEO_006 = value.ToUpper(); }
        }
        public string TST_SEH_006
        {
            get { return _TST_SEH_006; }
            set { _TST_SEH_006 = value.ToUpper(); }
        }
        public string TST_SEG_006
        {
            get { return _TST_SEG_006; }
            set { _TST_SEG_006 = value.ToUpper(); }
        }
        public string TST_SJC_006
        {
            get { return _TST_SJC_006; }
            set { _TST_SJC_006 = value.ToUpper(); }
        }
        public string TST_SJT_006
        {
            get { return _TST_SJT_006; }
            set { _TST_SJT_006 = value.ToUpper(); }
        }
        public string TST_SJB_006
        {
            get { return _TST_SJB_006; }
            set { _TST_SJB_006 = value.ToUpper(); }
        }
        public string TST_SPJ_006
        {
            get { return _TST_SPJ_006; }
            set { _TST_SPJ_006 = value.ToUpper(); }
        }
        public string TST_SBC_006
        {
            get { return _TST_SBC_006; }
            set { _TST_SBC_006 = value.ToUpper(); }
        }
        public string TST_SPO_006
        {
            get { return _TST_SPO_006; }
            set { _TST_SPO_006 = value.ToUpper(); }
        }
        public string TST_SVA_006
        {
            get { return _TST_SVA_006; }
            set { _TST_SVA_006 = value.ToUpper(); }
        }
        public string TST_TGR_006
        {
            get { return _TST_TGR_006; }
            set { _TST_TGR_006 = value.ToUpper(); }
        }
        public string TST_TIP_006
        {
            get { return _TST_TIP_006; }
            set { _TST_TIP_006 = value.ToUpper(); }
        }
        public string TST_DSB_006
        {
            get { return _TST_DSB_006; }
            set { _TST_DSB_006 = value.ToUpper(); }
        }
        public string TST_TCA_006
        {
            get { return _TST_TCA_006; }
            set { _TST_TCA_006 = value.ToUpper(); }
        }
        public string TST_FMC_006
        {
            get { return _TST_FMC_006; }
            set { _TST_FMC_006 = value.ToUpper(); }
        }
        public string TST_1TB_006
        {
            get { return _TST_1TB_006; }
            set { _TST_1TB_006 = value.ToUpper(); }
        }
        public string TST_1PP_006
        {
            get { return _TST_1PP_006; }
            set { _TST_1PP_006 = value.ToUpper(); }
        }
        public string TST_2TB_006
        {
            get { return _TST_2TB_006; }
            set { _TST_2TB_006 = value.ToUpper(); }
        }
        public string TST_2PP_006
        {
            get { return _TST_2PP_006; }
            set { _TST_2PP_006 = value.ToUpper(); }
        }
        public string TST_P1C_006
        {
            get { return _TST_P1C_006; }
            set { _TST_P1C_006 = value.ToUpper(); }
        }
        public string TST_P2D_006
        {
            get { return _TST_P2D_006; }
            set { _TST_P2D_006 = value.ToUpper(); }
        }
        public string TST_P3D_006
        {
            get { return _TST_P3D_006; }
            set { _TST_P3D_006 = value.ToUpper(); }
        }
        public string TST_P4U_006
        {
            get { return _TST_P4U_006; }
            set { _TST_P4U_006 = value.ToUpper(); }
        }
        public string TST_MOL_006
        {
            get { return _TST_MOL_006; }
            set { _TST_MOL_006 = value.ToUpper(); }
        }
        public string TST_TPD_006
        {
            get { return _TST_TPD_006; }
            set { _TST_TPD_006 = value.ToUpper(); }
        }
        public string TST_TT1_006
        {
            get { return _TST_TT1_006; }
            set { _TST_TT1_006 = value.ToUpper(); }
        }
        public string TST_TT2_006
        {
            get { return _TST_TT2_006; }
            set { _TST_TT2_006 = value.ToUpper(); }
        }
        public string TST_TT3_006
        {
            get { return _TST_TT3_006; }
            set { _TST_TT3_006 = value.ToUpper(); }
        }
        public string TST_T21_006
        {
            get { return _TST_T21_006; }
            set { _TST_T21_006 = value.ToUpper(); }
        }
        public string TST_TUN_006
        {
            get { return _TST_TUN_006; }
            set { _TST_TUN_006 = value.ToUpper(); }
        }
        public string TST_TCV_006
        {
            get { return _TST_TCV_006; }
            set { _TST_TCV_006 = value.ToUpper(); }
        }
        public string TST_TSS_006
        {
            get { return _TST_TSS_006; }
            set { _TST_TSS_006 = value.ToUpper(); }
        }
        public double? TST_TIT_006
        {
            get { return _TST_TIT_006; }
            set { _TST_TIT_006 = value; }
        }
        public double? TST_TNC_006
        {
            get { return _TST_TNC_006; }
            set { _TST_TNC_006 = value; }
        }
        public double? TST_AON_006
        {
            get { return _TST_AON_006; }
            set { _TST_AON_006 = value; }
        }
        public double? TST_ENM_006
        {
            get { return _TST_ENM_006; }
            set { _TST_ENM_006 = value; }
        }
        public double? TST_EEE_006
        {
            get { return _TST_EEE_006; }
            set { _TST_EEE_006 = value; }
        }
        public double? TST_KKK_006
        {
            get { return _TST_KKK_006; }
            set { _TST_KKK_006 = value; }
        }
        public double? TST_BBB_006
        {
            get { return _TST_BBB_006; }
            set { _TST_BBB_006 = value; }
        }
        public double? TST_OLE_006
        {
            get { return _TST_OLE_006; }
            set { _TST_OLE_006 = value; }
        }
        public double? TST_TRQ_006
        {
            get { return _TST_TRQ_006; }
            set { _TST_TRQ_006 = value; }
        }
        public double? TST_ERT_006
        {
            get { return _TST_ERT_006; }
            set { _TST_ERT_006 = value; }
        }
        public double? TST_RT3_006
        {
            get { return _TST_RT3_006; }
            set { _TST_RT3_006 = value; }
        }
        public double? TST_RT5_006
        {
            get { return _TST_RT5_006; }
            set { _TST_RT5_006 = value; }
        }
        public double? TST_DND_006
        {
            get { return _TST_DND_006; }
            set { _TST_DND_006 = value; }
        }
        public double? TST_DMO_006
        {
            get { return _TST_DMO_006; }
            set { _TST_DMO_006 = value; }
        }
        public double? TST_PES_006
        {
            get { return _TST_PES_006; }
            set { _TST_PES_006 = value; }
        }
        public string TST_VRR_006
        {
            get { return _TST_VRR_006; }
            set { _TST_VRR_006 = value.ToUpper(); }
        }
        public string TST_TRE_006
        {
            get { return _TST_TRE_006; }
            set { _TST_TRE_006 = value.ToUpper(); }
        }
        public double? TST_LME_006
        {
            get { return _TST_LME_006; }
            set { _TST_LME_006 = value; }
        }
        public double? TST_UME_006
        {
            get { return _TST_UME_006; }
            set { _TST_UME_006 = value; }
        }
        public double? TST_LPE_006
        {
            get { return _TST_LPE_006; }
            set { _TST_LPE_006 = value; }
        }
        public double? TST_UPE_006
        {
            get { return _TST_UPE_006; }
            set { _TST_UPE_006 = value; }
        }
        public double? TST_UCV_006
        {
            get { return _TST_UCV_006; }
            set { _TST_UCV_006 = value; }
        }
        public double? TST_CSO_006
        {
            get { return _TST_CSO_006; }
            set { _TST_CSO_006 = value; }
        }
        public double? TST_ESP_006
        {
            get { return _TST_ESP_006; }
            set { _TST_ESP_006 = value; }
        }
        public string TST_TOL_006
        {
            get { return _TST_TOL_006; }
            set { _TST_TOL_006 = value.ToUpper(); }
        }
        public double? TST_DUR_006
        {
            get { return _TST_DUR_006; }
            set { _TST_DUR_006 = value; }
        }
        public double? TST_DFT_006
        {
            get { return _TST_DFT_006; }
            set { _TST_DFT_006 = value; }
        }
        public double? TST_LMC_006
        {
            get { return _TST_LMC_006; }
            set { _TST_LMC_006 = value; }
        }
        public double? TST_UMC_006
        {
            get { return _TST_UMC_006; }
            set { _TST_UMC_006 = value; }
        }
        public double? TST_LPC_006
        {
            get { return _TST_LPC_006; }
            set { _TST_LPC_006 = value; }
        }
        public double? TST_UPC_006
        {
            get { return _TST_UPC_006; }
            set { _TST_UPC_006 = value; }
        }
        public double? TST_CVC_006
        {
            get { return _TST_CVC_006; }
            set { _TST_CVC_006 = value; }
        }
        public double? TST_DFC_006
        {
            get { return _TST_DFC_006; }
            set { _TST_DFC_006 = value; }
        }
        public double? TST_TFS_006
        {
            get { return _TST_TFS_006; }
            set { _TST_TFS_006 = value; }
        }
        public double? TST_FSW_006
        {
            get { return _TST_FSW_006; }
            set { _TST_FSW_006 = value; }
        }
        public double? TST_WFW_006
        {
            get { return _TST_WFW_006; }
            set { _TST_WFW_006 = value; }
        }
        public double? TST_ECO_006
        {
            get { return _TST_ECO_006; }
            set { _TST_ECO_006 = value; }
        }
        public string TST_EOL_006
        {
            get { return _TST_EOL_006; }
            set { _TST_EOL_006 = value; }
        }
        public string TST_ETU_006
        {
            get { return _TST_ETU_006; }
            set { _TST_ETU_006 = value; }
        }
        public string TST_ETD_006
        {
            get { return _TST_ETD_006; }
            set { _TST_ETD_006 = value; }
        }
        public string TST_ECU_006
        {
            get { return _TST_ECU_006; }
            set { _TST_ECU_006 = value; }
        }
        public string TST_EGD_006
        {
            get { return _TST_EGD_006; }
            set { _TST_EGD_006 = value; }
        }
        public string TST_EEC_006
        {
            get { return _TST_EEC_006; }
            set { _TST_EEC_006 = value; }
        }
        public string TST_ECD_006
        {
            get { return _TST_ECD_006; }
            set { _TST_ECD_006 = value; }
        }
        public string TST_EGU_006
        {
            get { return _TST_EGU_006; }
            set { _TST_EGU_006 = value; }
        }
        public string TST_ESO_006
        {
            get { return _TST_ESO_006; }
            set { _TST_ESO_006 = value; }
        }
        public string TST_ESI_006
        {
            get { return _TST_ESI_006; }
            set { _TST_ESI_006 = value; }
        }
        public string TST_ECR_006
        {
            get { return _TST_ECR_006; }
            set { _TST_ECR_006 = value; }
        }
        public string TST_EOD_006
        {
            get { return _TST_EOD_006; }
            set { _TST_EOD_006 = value; }
        }
        public string TST_EAW_006
        {
            get { return _TST_EAW_006; }
            set { _TST_EAW_006 = value; }
        }
        public string TST_ED1_006
        {
            get { return _TST_ED1_006; }
            set { _TST_ED1_006 = value; }
        }
        public string TST_ED2_006
        {
            get { return _TST_ED2_006; }
            set { _TST_ED2_006 = value; }
        }
        public string TST_VW2_007
        {
            get { return _TST_VW2_007; }
            set { _TST_VW2_007 = value.ToUpper(); }
        }
        public string TST_EGM_007
        {
            get { return _TST_EGM_007; }
            set { _TST_EGM_007 = value.ToUpper(); }
        }
        public string TST_DYY_007
        {
            get { return _TST_DYY_007; }
            set { _TST_DYY_007 = value.ToUpper(); }
        }
        public string TST_2WX_007
        {
            get { return _TST_2WX_007; }
            set { _TST_2WX_007 = value.ToUpper(); }
        }
        public string TST_3W3_007
        {
            get { return _TST_3W3_007; }
            set { _TST_3W3_007 = value.ToUpper(); }
        }
        public string TST_4W4_007
        {
            get { return _TST_4W4_007; }
            set { _TST_4W4_007 = value.ToUpper(); }
        }
        public string TST_AGL_007
        {
            get { return _TST_AGL_007; }
            set { _TST_AGL_007 = value.ToUpper(); }
        }
        public string TST_TUP_007
        {
            get { return _TST_TUP_007; }
            set { _TST_TUP_007 = value.ToUpper(); }
        }
        public string TST_VEO_007
        {
            get { return _TST_VEO_007; }
            set { _TST_VEO_007 = value.ToUpper(); }
        }
        public string TST_T1T_007
        {
            get { return _TST_T1T_007; }
            set { _TST_T1T_007 = value.ToUpper(); }
        }
        public string TST_T1C_007
        {
            get { return _TST_T1C_007; }
            set { _TST_T1C_007 = value.ToUpper(); }
        }
        public string TST_T1L_007
        {
            get { return _TST_T1L_007; }
            set { _TST_T1L_007 = value.ToUpper(); }
        }
        public string TST_T2F_007
        {
            get { return _TST_T2F_007; }
            set { _TST_T2F_007 = value.ToUpper(); }
        }
        public string TST_SVE_007
        {
            get { return _TST_SVE_007; }
            set { _TST_SVE_007 = value.ToUpper(); }
        }
        public string TST_STF_007
        {
            get { return _TST_STF_007; }
            set { _TST_STF_007 = value.ToUpper(); }
        }
        public string TST_STM_007
        {
            get { return _TST_STM_007; }
            set { _TST_STM_007 = value.ToUpper(); }
        }
        public string TST_SCE_007
        {
            get { return _TST_SCE_007; }
            set { _TST_SCE_007 = value.ToUpper(); }
        }
        public string TST_SCO_007
        {
            get { return _TST_SCO_007; }
            set { _TST_SCO_007 = value.ToUpper(); }
        }
        public string TST_SCH_007
        {
            get { return _TST_SCH_007; }
            set { _TST_SCH_007 = value.ToUpper(); }
        }
        public string TST_SCG_007
        {
            get { return _TST_SCG_007; }
            set { _TST_SCG_007 = value.ToUpper(); }
        }
        public string TST_SEE_007
        {
            get { return _TST_SEE_007; }
            set { _TST_SEE_007 = value.ToUpper(); }
        }
        public string TST_SEO_007
        {
            get { return _TST_SEO_007; }
            set { _TST_SEO_007 = value.ToUpper(); }
        }
        public string TST_SEH_007
        {
            get { return _TST_SEH_007; }
            set { _TST_SEH_007 = value.ToUpper(); }
        }
        public string TST_SEG_007
        {
            get { return _TST_SEG_007; }
            set { _TST_SEG_007 = value.ToUpper(); }
        }
        public string TST_SJC_007
        {
            get { return _TST_SJC_007; }
            set { _TST_SJC_007 = value.ToUpper(); }
        }
        public string TST_SJT_007
        {
            get { return _TST_SJT_007; }
            set { _TST_SJT_007 = value.ToUpper(); }
        }
        public string TST_SJB_007
        {
            get { return _TST_SJB_007; }
            set { _TST_SJB_007 = value.ToUpper(); }
        }
        public string TST_SPJ_007
        {
            get { return _TST_SPJ_007; }
            set { _TST_SPJ_007 = value.ToUpper(); }
        }
        public string TST_SBC_007
        {
            get { return _TST_SBC_007; }
            set { _TST_SBC_007 = value.ToUpper(); }
        }
        public string TST_SPO_007
        {
            get { return _TST_SPO_007; }
            set { _TST_SPO_007 = value.ToUpper(); }
        }
        public string TST_SVA_007
        {
            get { return _TST_SVA_007; }
            set { _TST_SVA_007 = value.ToUpper(); }
        }
        public string TST_TGR_007
        {
            get { return _TST_TGR_007; }
            set { _TST_TGR_007 = value.ToUpper(); }
        }
        public string TST_TIP_007
        {
            get { return _TST_TIP_007; }
            set { _TST_TIP_007 = value.ToUpper(); }
        }
        public string TST_DSB_007
        {
            get { return _TST_DSB_007; }
            set { _TST_DSB_007 = value.ToUpper(); }
        }
        public string TST_TCA_007
        {
            get { return _TST_TCA_007; }
            set { _TST_TCA_007 = value.ToUpper(); }
        }
        public string TST_FMC_007
        {
            get { return _TST_FMC_007; }
            set { _TST_FMC_007 = value.ToUpper(); }
        }
        public string TST_1TB_007
        {
            get { return _TST_1TB_007; }
            set { _TST_1TB_007 = value.ToUpper(); }
        }
        public string TST_1PP_007
        {
            get { return _TST_1PP_007; }
            set { _TST_1PP_007 = value.ToUpper(); }
        }
        public string TST_2TB_007
        {
            get { return _TST_2TB_007; }
            set { _TST_2TB_007 = value.ToUpper(); }
        }
        public string TST_2PP_007
        {
            get { return _TST_2PP_007; }
            set { _TST_2PP_007 = value.ToUpper(); }
        }
        public string TST_P1C_007
        {
            get { return _TST_P1C_007; }
            set { _TST_P1C_007 = value.ToUpper(); }
        }
        public string TST_P2D_007
        {
            get { return _TST_P2D_007; }
            set { _TST_P2D_007 = value.ToUpper(); }
        }
        public string TST_P3D_007
        {
            get { return _TST_P3D_007; }
            set { _TST_P3D_007 = value.ToUpper(); }
        }
        public string TST_P4U_007
        {
            get { return _TST_P4U_007; }
            set { _TST_P4U_007 = value.ToUpper(); }
        }
        public string TST_MOL_007
        {
            get { return _TST_MOL_007; }
            set { _TST_MOL_007 = value.ToUpper(); }
        }
        public string TST_TPD_007
        {
            get { return _TST_TPD_007; }
            set { _TST_TPD_007 = value.ToUpper(); }
        }
        public string TST_TT1_007
        {
            get { return _TST_TT1_007; }
            set { _TST_TT1_007 = value.ToUpper(); }
        }
        public string TST_TT2_007
        {
            get { return _TST_TT2_007; }
            set { _TST_TT2_007 = value.ToUpper(); }
        }
        public string TST_TT3_007
        {
            get { return _TST_TT3_007; }
            set { _TST_TT3_007 = value.ToUpper(); }
        }
        public string TST_T21_007
        {
            get { return _TST_T21_007; }
            set { _TST_T21_007 = value.ToUpper(); }
        }
        public string TST_TUN_007
        {
            get { return _TST_TUN_007; }
            set { _TST_TUN_007 = value.ToUpper(); }
        }
        public string TST_TCV_007
        {
            get { return _TST_TCV_007; }
            set { _TST_TCV_007 = value.ToUpper(); }
        }
        public string TST_TSS_007
        {
            get { return _TST_TSS_007; }
            set { _TST_TSS_007 = value.ToUpper(); }
        }
        public double? TST_TIT_007
        {
            get { return _TST_TIT_007; }
            set { _TST_TIT_007 = value; }
        }
        public double? TST_TNC_007
        {
            get { return _TST_TNC_007; }
            set { _TST_TNC_007 = value; }
        }
        public double? TST_AON_007
        {
            get { return _TST_AON_007; }
            set { _TST_AON_007 = value; }
        }
        public double? TST_ENM_007
        {
            get { return _TST_ENM_007; }
            set { _TST_ENM_007 = value; }
        }
        public double? TST_EEE_007
        {
            get { return _TST_EEE_007; }
            set { _TST_EEE_007 = value; }
        }
        public double? TST_KKK_007
        {
            get { return _TST_KKK_007; }
            set { _TST_KKK_007 = value; }
        }
        public double? TST_BBB_007
        {
            get { return _TST_BBB_007; }
            set { _TST_BBB_007 = value; }
        }
        public double? TST_OLE_007
        {
            get { return _TST_OLE_007; }
            set { _TST_OLE_007 = value; }
        }
        public double? TST_TRQ_007
        {
            get { return _TST_TRQ_007; }
            set { _TST_TRQ_007 = value; }
        }
        public double? TST_ERT_007
        {
            get { return _TST_ERT_007; }
            set { _TST_ERT_007 = value; }
        }
        public double? TST_RT3_007
        {
            get { return _TST_RT3_007; }
            set { _TST_RT3_007 = value; }
        }
        public double? TST_RT5_007
        {
            get { return _TST_RT5_007; }
            set { _TST_RT5_007 = value; }
        }
        public double? TST_DND_007
        {
            get { return _TST_DND_007; }
            set { _TST_DND_007 = value; }
        }
        public double? TST_DMO_007
        {
            get { return _TST_DMO_007; }
            set { _TST_DMO_007 = value; }
        }
        public double? TST_PES_007
        {
            get { return _TST_PES_007; }
            set { _TST_PES_007 = value; }
        }
        public string TST_VRR_007
        {
            get { return _TST_VRR_007; }
            set { _TST_VRR_007 = value.ToUpper(); }
        }
        public string TST_TRE_007
        {
            get { return _TST_TRE_007; }
            set { _TST_TRE_007 = value.ToUpper(); }
        }
        public double? TST_LME_007
        {
            get { return _TST_LME_007; }
            set { _TST_LME_007 = value; }
        }
        public double? TST_UME_007
        {
            get { return _TST_UME_007; }
            set { _TST_UME_007 = value; }
        }
        public double? TST_LPE_007
        {
            get { return _TST_LPE_007; }
            set { _TST_LPE_007 = value; }
        }
        public double? TST_UPE_007
        {
            get { return _TST_UPE_007; }
            set { _TST_UPE_007 = value; }
        }
        public double? TST_UCV_007
        {
            get { return _TST_UCV_007; }
            set { _TST_UCV_007 = value; }
        }
        public double? TST_CSO_007
        {
            get { return _TST_CSO_007; }
            set { _TST_CSO_007 = value; }
        }
        public double? TST_ESP_007
        {
            get { return _TST_ESP_007; }
            set { _TST_ESP_007 = value; }
        }
        public string TST_TOL_007
        {
            get { return _TST_TOL_007; }
            set { _TST_TOL_007 = value.ToUpper(); }
        }
        public double? TST_DUR_007
        {
            get { return _TST_DUR_007; }
            set { _TST_DUR_007 = value; }
        }
        public double? TST_DFT_007
        {
            get { return _TST_DFT_007; }
            set { _TST_DFT_007 = value; }
        }
        public double? TST_LMC_007
        {
            get { return _TST_LMC_007; }
            set { _TST_LMC_007 = value; }
        }
        public double? TST_UMC_007
        {
            get { return _TST_UMC_007; }
            set { _TST_UMC_007 = value; }
        }
        public double? TST_LPC_007
        {
            get { return _TST_LPC_007; }
            set { _TST_LPC_007 = value; }
        }
        public double? TST_UPC_007
        {
            get { return _TST_UPC_007; }
            set { _TST_UPC_007 = value; }
        }
        public double? TST_CVC_007
        {
            get { return _TST_CVC_007; }
            set { _TST_CVC_007 = value; }
        }
        public double? TST_DFC_007
        {
            get { return _TST_DFC_007; }
            set { _TST_DFC_007 = value; }
        }
        public double? TST_TFS_007
        {
            get { return _TST_TFS_007; }
            set { _TST_TFS_007 = value; }
        }
        public double? TST_FSW_007
        {
            get { return _TST_FSW_007; }
            set { _TST_FSW_007 = value; }
        }
        public double? TST_WFW_007
        {
            get { return _TST_WFW_007; }
            set { _TST_WFW_007 = value; }
        }
        public double? TST_ECO_007
        {
            get { return _TST_ECO_007; }
            set { _TST_ECO_007 = value; }
        }
        public string TST_EOL_007
        {
            get { return _TST_EOL_007; }
            set { _TST_EOL_007 = value; }
        }
        public string TST_ETU_007
        {
            get { return _TST_ETU_007; }
            set { _TST_ETU_007 = value; }
        }
        public string TST_ETD_007
        {
            get { return _TST_ETD_007; }
            set { _TST_ETD_007 = value; }
        }
        public string TST_ECU_007
        {
            get { return _TST_ECU_007; }
            set { _TST_ECU_007 = value; }
        }
        public string TST_EGD_007
        {
            get { return _TST_EGD_007; }
            set { _TST_EGD_007 = value; }
        }
        public string TST_EEC_007
        {
            get { return _TST_EEC_007; }
            set { _TST_EEC_007 = value; }
        }
        public string TST_ECD_007
        {
            get { return _TST_ECD_007; }
            set { _TST_ECD_007 = value; }
        }
        public string TST_EGU_007
        {
            get { return _TST_EGU_007; }
            set { _TST_EGU_007 = value; }
        }
        public string TST_ESO_007
        {
            get { return _TST_ESO_007; }
            set { _TST_ESO_007 = value; }
        }
        public string TST_ESI_007
        {
            get { return _TST_ESI_007; }
            set { _TST_ESI_007 = value; }
        }
        public string TST_ECR_007
        {
            get { return _TST_ECR_007; }
            set { _TST_ECR_007 = value; }
        }
        public string TST_EOD_007
        {
            get { return _TST_EOD_007; }
            set { _TST_EOD_007 = value; }
        }
        public string TST_EAW_007
        {
            get { return _TST_EAW_007; }
            set { _TST_EAW_007 = value; }
        }
        public string TST_ED1_007
        {
            get { return _TST_ED1_007; }
            set { _TST_ED1_007 = value; }
        }
        public string TST_ED2_007
        {
            get { return _TST_ED2_007; }
            set { _TST_ED2_007 = value; }
        }
        public string TST_PCO_REF
        {
            get { return _TST_PCO_REF; }
            set { _TST_PCO_REF = value; }
        }
        public string TST_PCV_REF
        {
            get { return _TST_PCV_REF; }
            set { _TST_PCV_REF = value; }
        }
        public string TST_DRT_REF
        {
            get { return _TST_DRT_REF; }
            set { _TST_DRT_REF = value; }
        }
        public string TST_TAL_REF
        {
            get { return _TST_TAL_REF; }
            set { _TST_TAL_REF = value; }
        }
        public string TST_VAL_REF
        {
            get { return _TST_VAL_REF; }
            set { _TST_VAL_REF = value; }
        }
        public string TST_SJE_REF
        {
            get { return _TST_SJE_REF; }
            set { _TST_SJE_REF = value; }
        }
        public string TST_PCO_001
        {
            get { return _TST_PCO_001; }
            set { _TST_PCO_001 = value; }
        }
        public string TST_PCV_001
        {
            get { return _TST_PCV_001; }
            set { _TST_PCV_001 = value; }
        }
        public string TST_DRT_001
        {
            get { return _TST_DRT_001; }
            set { _TST_DRT_001 = value; }
        }
        public string TST_TAL_001
        {
            get { return _TST_TAL_001; }
            set { _TST_TAL_001 = value; }
        }
        public string TST_VAL_001
        {
            get { return _TST_VAL_001; }
            set { _TST_VAL_001 = value; }
        }
        public string TST_SJE_001
        {
            get { return _TST_SJE_001; }
            set { _TST_SJE_001 = value; }
        }
        public string TST_PCO_002
        {
            get { return _TST_PCO_002; }
            set { _TST_PCO_002 = value; }
        }
        public string TST_PCV_002
        {
            get { return _TST_PCV_002; }
            set { _TST_PCV_002 = value; }
        }
        public string TST_DRT_002
        {
            get { return _TST_DRT_002; }
            set { _TST_DRT_002 = value; }
        }
        public string TST_TAL_002
        {
            get { return _TST_TAL_002; }
            set { _TST_TAL_002 = value; }
        }
        public string TST_VAL_002
        {
            get { return _TST_VAL_002; }
            set { _TST_VAL_002 = value; }
        }
        public string TST_SJE_002
        {
            get { return _TST_SJE_002; }
            set { _TST_SJE_002 = value; }
        }
        public string TST_PCO_003
        {
            get { return _TST_PCO_003; }
            set { _TST_PCO_003 = value; }
        }
        public string TST_PCV_003
        {
            get { return _TST_PCV_003; }
            set { _TST_PCV_003 = value; }
        }
        public string TST_DRT_003
        {
            get { return _TST_DRT_003; }
            set { _TST_DRT_003 = value; }
        }
        public string TST_TAL_003
        {
            get { return _TST_TAL_003; }
            set { _TST_TAL_003 = value; }
        }
        public string TST_VAL_003
        {
            get { return _TST_VAL_003; }
            set { _TST_VAL_003 = value; }
        }
        public string TST_SJE_003
        {
            get { return _TST_SJE_003; }
            set { _TST_SJE_003 = value; }
        }
        public string TST_PCO_004
        {
            get { return _TST_PCO_004; }
            set { _TST_PCO_004 = value; }
        }
        public string TST_PCV_004
        {
            get { return _TST_PCV_004; }
            set { _TST_PCV_004 = value; }
        }
        public string TST_DRT_004
        {
            get { return _TST_DRT_004; }
            set { _TST_DRT_004 = value; }
        }
        public string TST_TAL_004
        {
            get { return _TST_TAL_004; }
            set { _TST_TAL_004 = value; }
        }
        public string TST_VAL_004
        {
            get { return _TST_VAL_004; }
            set { _TST_VAL_004 = value; }
        }
        public string TST_SJE_004
        {
            get { return _TST_SJE_004; }
            set { _TST_SJE_004 = value; }
        }
        public string TST_PCO_005
        {
            get { return _TST_PCO_005; }
            set { _TST_PCO_005 = value; }
        }
        public string TST_PCV_005
        {
            get { return _TST_PCV_005; }
            set { _TST_PCV_005 = value; }
        }
        public string TST_DRT_005
        {
            get { return _TST_DRT_005; }
            set { _TST_DRT_005 = value; }
        }
        public string TST_TAL_005
        {
            get { return _TST_TAL_005; }
            set { _TST_TAL_005 = value; }
        }
        public string TST_VAL_005
        {
            get { return _TST_VAL_005; }
            set { _TST_VAL_005 = value; }
        }
        public string TST_SJE_005
        {
            get { return _TST_SJE_005; }
            set { _TST_SJE_005 = value; }
        }
        public string TST_PCO_006
        {
            get { return _TST_PCO_006; }
            set { _TST_PCO_006 = value; }
        }
        public string TST_PCV_006
        {
            get { return _TST_PCV_006; }
            set { _TST_PCV_006 = value; }
        }
        public string TST_DRT_006
        {
            get { return _TST_DRT_006; }
            set { _TST_DRT_006 = value; }
        }
        public string TST_TAL_006
        {
            get { return _TST_TAL_006; }
            set { _TST_TAL_006 = value; }
        }
        public string TST_VAL_006
        {
            get { return _TST_VAL_006; }
            set { _TST_VAL_006 = value; }
        }
        public string TST_SJE_006
        {
            get { return _TST_SJE_006; }
            set { _TST_SJE_006 = value; }
        }
        public string TST_PCO_007
        {
            get { return _TST_PCO_007; }
            set { _TST_PCO_007 = value; }
        }
        public string TST_PCV_007
        {
            get { return _TST_PCV_007; }
            set { _TST_PCV_007 = value; }
        }
        public string TST_DRT_007
        {
            get { return _TST_DRT_007; }
            set { _TST_DRT_007 = value; }
        }
        public string TST_TAL_007
        {
            get { return _TST_TAL_007; }
            set { _TST_TAL_007 = value; }
        }
        public string TST_VAL_007
        {
            get { return _TST_VAL_007; }
            set { _TST_VAL_007 = value; }
        }
        public string TST_SJE_007
        {
            get { return _TST_SJE_007; }
            set { _TST_SJE_007 = value; }
        }
        public string TST_DET
        {
            get { return _TST_DET; }
            set { _TST_DET = value.ToUpper(); }
        }
        public string TST_OBS
        {
            get { return _TST_OBS; }
            set { _TST_OBS = value.ToUpper(); }
        }
        public int? TST_STS
        {
            get { return _TST_STS; }
            set { _TST_STS = value; }
        }
        public int? TST_USR_INC_ID
        {
            get { return _TST_USR_INC_ID; }
            set { _TST_USR_INC_ID = value; }
        }
        public int? TST_USR_ALT_ID
        {
            get { return _TST_USR_ALT_ID; }
            set { _TST_USR_ALT_ID = value; }
        }
        public DateTime? TST_TMS_ATL
        {
            get { return _TST_TMS_ATL; }
            set { _TST_TMS_ATL = value; }
        }

        public DateTime? TST_DAT_INI_INI
        {
            get { return _TST_DAT_INI_INI; }
            set { _TST_DAT_INI_INI = value; }
        }

        public DateTime? TST_DAT_INI_FIM
        {
            get { return _TST_DAT_INI_FIM; }
            set { _TST_DAT_INI_FIM = value; }
        }
        public DateTime? TST_DAT_FIM_INI
        {
            get { return _TST_DAT_FIM_INI; }
            set { _TST_DAT_FIM_INI = value; }
        }

        public DateTime? TST_DAT_FIM_FIM
        {
            get { return _TST_DAT_FIM_FIM; }
            set { _TST_DAT_FIM_FIM = value; }
        }

        public string TOP
        {
            get { return _TOP; }
            set { _TOP = value; }
        }

        public string SQL
        {
            get { return _SQL; }
            set { _SQL = value; }
        }

        #endregion

        #region Métodos

        clsBanco dbConn = new clsBanco();

        public string Inserir()
        {
            string sSQL = "INSERT INTO TST (";
            sSQL = sSQL + "TST_RTS_ID, ";
            sSQL = sSQL + "TST_RTS_MTV_TST_ID, ";
            sSQL = sSQL + "TST_LOT, ";
            sSQL = sSQL + "TST_LOT_REF, ";
            sSQL = sSQL + "TST_LOT_EPF, ";
            sSQL = sSQL + "TST_LOT_ANS, ";
            sSQL = sSQL + "TST_TIT_POY_ID, ";
            sSQL = sSQL + "TST_DES, ";
            sSQL = sSQL + "TST_MGE, ";
            sSQL = sSQL + "TST_MGE_002, ";
            sSQL = sSQL + "TST_MGE_003, ";
            sSQL = sSQL + "TST_MGE_REF, ";
            sSQL = sSQL + "TST_MGE_002_REF, ";
            sSQL = sSQL + "TST_MGE_003_REF, ";
            sSQL = sSQL + "TST_FOR_001_ID, ";
            sSQL = sSQL + "TST_FOR_002_ID, ";
            sSQL = sSQL + "TST_FOR_003_ID, ";
            sSQL = sSQL + "TST_VLC, ";
            sSQL = sSQL + "TST_APS_ID, ";
            sSQL = sSQL + "TST_MAQ_TIP_ID, ";
            sSQL = sSQL + "TST_ERT_ID, ";
            sSQL = sSQL + "TST_DAT_INI, ";
            sSQL = sSQL + "TST_DAT_FIM, ";
            sSQL = sSQL + "TST_VW2_REF, ";
            sSQL = sSQL + "TST_EGM_REF, ";
            sSQL = sSQL + "TST_DYY_REF, ";
            sSQL = sSQL + "TST_2WX_REF, ";
            sSQL = sSQL + "TST_3W3_REF, ";
            sSQL = sSQL + "TST_4W4_REF, ";
            sSQL = sSQL + "TST_AGL_REF, ";
            sSQL = sSQL + "TST_TUP_REF, ";
            sSQL = sSQL + "TST_VEO_REF, ";
            sSQL = sSQL + "TST_T1T_REF, ";
            sSQL = sSQL + "TST_T1C_REF, ";
            sSQL = sSQL + "TST_T1L_REF, ";
            sSQL = sSQL + "TST_T2F_REF, ";
            sSQL = sSQL + "TST_SVE_REF, ";
            sSQL = sSQL + "TST_STF_REF, ";
            sSQL = sSQL + "TST_STM_REF, ";
            sSQL = sSQL + "TST_SCE_REF, ";
            sSQL = sSQL + "TST_SCO_REF, ";
            sSQL = sSQL + "TST_SCH_REF, ";
            sSQL = sSQL + "TST_SCG_REF, ";
            sSQL = sSQL + "TST_SEE_REF, ";
            sSQL = sSQL + "TST_SEO_REF, ";
            sSQL = sSQL + "TST_SEH_REF, ";
            sSQL = sSQL + "TST_SEG_REF, ";
            sSQL = sSQL + "TST_SJC_REF, ";
            sSQL = sSQL + "TST_SJT_REF, ";
            sSQL = sSQL + "TST_SJB_REF, ";
            sSQL = sSQL + "TST_SPJ_REF, ";
            sSQL = sSQL + "TST_SBC_REF, ";
            sSQL = sSQL + "TST_SPO_REF, ";
            sSQL = sSQL + "TST_SVA_REF, ";
            sSQL = sSQL + "TST_TGR_REF, ";
            sSQL = sSQL + "TST_TIP_REF, ";
            sSQL = sSQL + "TST_DSB_REF, ";
            sSQL = sSQL + "TST_TCA_REF, ";
            sSQL = sSQL + "TST_FMC_REF, ";
            sSQL = sSQL + "TST_1TB_REF, ";
            sSQL = sSQL + "TST_1PP_REF, ";
            sSQL = sSQL + "TST_2TB_REF, ";
            sSQL = sSQL + "TST_2PP_REF, ";
            sSQL = sSQL + "TST_P1C_REF, ";
            sSQL = sSQL + "TST_P2D_REF, ";
            sSQL = sSQL + "TST_P3D_REF, ";
            sSQL = sSQL + "TST_P4U_REF, ";
            sSQL = sSQL + "TST_MOL_REF, ";
            sSQL = sSQL + "TST_TPD_REF, ";
            sSQL = sSQL + "TST_TT1_REF, ";
            sSQL = sSQL + "TST_TT2_REF, ";
            sSQL = sSQL + "TST_TT3_REF, ";
            sSQL = sSQL + "TST_T21_REF, ";
            sSQL = sSQL + "TST_TUN_REF, ";
            sSQL = sSQL + "TST_TCV_REF, ";
            sSQL = sSQL + "TST_TSS_REF, ";
            sSQL = sSQL + "TST_TIT_REF, ";
            sSQL = sSQL + "TST_TNC_REF, ";
            sSQL = sSQL + "TST_AON_REF, ";
            sSQL = sSQL + "TST_ENM_REF, ";
            sSQL = sSQL + "TST_EEE_REF, ";
            sSQL = sSQL + "TST_KKK_REF, ";
            sSQL = sSQL + "TST_BBB_REF, ";
            sSQL = sSQL + "TST_OLE_REF, ";
            sSQL = sSQL + "TST_TRQ_REF, ";
            sSQL = sSQL + "TST_ERT_REF, ";
            sSQL = sSQL + "TST_RT3_REF, ";
            sSQL = sSQL + "TST_RT5_REF, ";
            sSQL = sSQL + "TST_DND_REF, ";
            sSQL = sSQL + "TST_DMO_REF, ";
            sSQL = sSQL + "TST_PES_REF, ";
            sSQL = sSQL + "TST_VRR_REF, ";
            sSQL = sSQL + "TST_TRE_REF, ";
            sSQL = sSQL + "TST_LME_REF, ";
            sSQL = sSQL + "TST_UME_REF, ";
            sSQL = sSQL + "TST_LPE_REF, ";
            sSQL = sSQL + "TST_UPE_REF, ";
            sSQL = sSQL + "TST_UCV_REF, ";
            sSQL = sSQL + "TST_CSO_REF, ";
            sSQL = sSQL + "TST_ESP_REF, ";
            sSQL = sSQL + "TST_TOL_REF, ";
            sSQL = sSQL + "TST_DUR_REF, ";
            sSQL = sSQL + "TST_DFT_REF, ";
            sSQL = sSQL + "TST_LMC_REF, ";
            sSQL = sSQL + "TST_UMC_REF, ";
            sSQL = sSQL + "TST_LPC_REF, ";
            sSQL = sSQL + "TST_UPC_REF, ";
            sSQL = sSQL + "TST_CVC_REF, ";
            sSQL = sSQL + "TST_DFC_REF, ";
            sSQL = sSQL + "TST_TFS_REF, ";
            sSQL = sSQL + "TST_FSW_REF, ";
            sSQL = sSQL + "TST_WFW_REF, ";
            sSQL = sSQL + "TST_ECO_REF, ";
            sSQL = sSQL + "TST_EOL_REF, ";
            sSQL = sSQL + "TST_ETU_REF, ";
            sSQL = sSQL + "TST_ETD_REF, ";
            sSQL = sSQL + "TST_ECU_REF, ";
            sSQL = sSQL + "TST_EGD_REF, ";
            sSQL = sSQL + "TST_EEC_REF, ";
            sSQL = sSQL + "TST_ECD_REF, ";
            sSQL = sSQL + "TST_EGU_REF, ";
            sSQL = sSQL + "TST_ESO_REF, ";
            sSQL = sSQL + "TST_ESI_REF, ";
            sSQL = sSQL + "TST_ECR_REF, ";
            sSQL = sSQL + "TST_EOD_REF, ";
            sSQL = sSQL + "TST_EAW_REF, ";
            sSQL = sSQL + "TST_ED1_REF, ";
            sSQL = sSQL + "TST_ED2_REF, ";
            sSQL = sSQL + "TST_VW2_001, ";
            sSQL = sSQL + "TST_EGM_001, ";
            sSQL = sSQL + "TST_DYY_001, ";
            sSQL = sSQL + "TST_2WX_001, ";
            sSQL = sSQL + "TST_3W3_001, ";
            sSQL = sSQL + "TST_4W4_001, ";
            sSQL = sSQL + "TST_AGL_001, ";
            sSQL = sSQL + "TST_TUP_001, ";
            sSQL = sSQL + "TST_VEO_001, ";
            sSQL = sSQL + "TST_T1T_001, ";
            sSQL = sSQL + "TST_T1C_001, ";
            sSQL = sSQL + "TST_T1L_001, ";
            sSQL = sSQL + "TST_T2F_001, ";
            sSQL = sSQL + "TST_SVE_001, ";
            sSQL = sSQL + "TST_STF_001, ";
            sSQL = sSQL + "TST_STM_001, ";
            sSQL = sSQL + "TST_SCE_001, ";
            sSQL = sSQL + "TST_SCO_001, ";
            sSQL = sSQL + "TST_SCH_001, ";
            sSQL = sSQL + "TST_SCG_001, ";
            sSQL = sSQL + "TST_SEE_001, ";
            sSQL = sSQL + "TST_SEO_001, ";
            sSQL = sSQL + "TST_SEH_001, ";
            sSQL = sSQL + "TST_SEG_001, ";
            sSQL = sSQL + "TST_SJC_001, ";
            sSQL = sSQL + "TST_SJT_001, ";
            sSQL = sSQL + "TST_SJB_001, ";
            sSQL = sSQL + "TST_SPJ_001, ";
            sSQL = sSQL + "TST_SBC_001, ";
            sSQL = sSQL + "TST_SPO_001, ";
            sSQL = sSQL + "TST_SVA_001, ";
            sSQL = sSQL + "TST_TGR_001, ";
            sSQL = sSQL + "TST_TIP_001, ";
            sSQL = sSQL + "TST_DSB_001, ";
            sSQL = sSQL + "TST_TCA_001, ";
            sSQL = sSQL + "TST_FMC_001, ";
            sSQL = sSQL + "TST_1TB_001, ";
            sSQL = sSQL + "TST_1PP_001, ";
            sSQL = sSQL + "TST_2TB_001, ";
            sSQL = sSQL + "TST_2PP_001, ";
            sSQL = sSQL + "TST_P1C_001, ";
            sSQL = sSQL + "TST_P2D_001, ";
            sSQL = sSQL + "TST_P3D_001, ";
            sSQL = sSQL + "TST_P4U_001, ";
            sSQL = sSQL + "TST_MOL_001, ";
            sSQL = sSQL + "TST_TPD_001, ";
            sSQL = sSQL + "TST_TT1_001, ";
            sSQL = sSQL + "TST_TT2_001, ";
            sSQL = sSQL + "TST_TT3_001, ";
            sSQL = sSQL + "TST_T21_001, ";
            sSQL = sSQL + "TST_TUN_001, ";
            sSQL = sSQL + "TST_TCV_001, ";
            sSQL = sSQL + "TST_TSS_001, ";
            sSQL = sSQL + "TST_TIT_001, ";
            sSQL = sSQL + "TST_TNC_001, ";
            sSQL = sSQL + "TST_AON_001, ";
            sSQL = sSQL + "TST_ENM_001, ";
            sSQL = sSQL + "TST_EEE_001, ";
            sSQL = sSQL + "TST_KKK_001, ";
            sSQL = sSQL + "TST_BBB_001, ";
            sSQL = sSQL + "TST_OLE_001, ";
            sSQL = sSQL + "TST_TRQ_001, ";
            sSQL = sSQL + "TST_ERT_001, ";
            sSQL = sSQL + "TST_RT3_001, ";
            sSQL = sSQL + "TST_RT5_001, ";
            sSQL = sSQL + "TST_DND_001, ";
            sSQL = sSQL + "TST_DMO_001, ";
            sSQL = sSQL + "TST_PES_001, ";
            sSQL = sSQL + "TST_VRR_001, ";
            sSQL = sSQL + "TST_TRE_001, ";
            sSQL = sSQL + "TST_LME_001, ";
            sSQL = sSQL + "TST_UME_001, ";
            sSQL = sSQL + "TST_LPE_001, ";
            sSQL = sSQL + "TST_UPE_001, ";
            sSQL = sSQL + "TST_UCV_001, ";
            sSQL = sSQL + "TST_CSO_001, ";
            sSQL = sSQL + "TST_ESP_001, ";
            sSQL = sSQL + "TST_TOL_001, ";
            sSQL = sSQL + "TST_DUR_001, ";
            sSQL = sSQL + "TST_DFT_001, ";
            sSQL = sSQL + "TST_LMC_001, ";
            sSQL = sSQL + "TST_UMC_001, ";
            sSQL = sSQL + "TST_LPC_001, ";
            sSQL = sSQL + "TST_UPC_001, ";
            sSQL = sSQL + "TST_CVC_001, ";
            sSQL = sSQL + "TST_DFC_001, ";
            sSQL = sSQL + "TST_TFS_001, ";
            sSQL = sSQL + "TST_FSW_001, ";
            sSQL = sSQL + "TST_WFW_001, ";
            sSQL = sSQL + "TST_ECO_001, ";
            sSQL = sSQL + "TST_EOL_001, ";
            sSQL = sSQL + "TST_ETU_001, ";
            sSQL = sSQL + "TST_ETD_001, ";
            sSQL = sSQL + "TST_ECU_001, ";
            sSQL = sSQL + "TST_EGD_001, ";
            sSQL = sSQL + "TST_EEC_001, ";
            sSQL = sSQL + "TST_ECD_001, ";
            sSQL = sSQL + "TST_EGU_001, ";
            sSQL = sSQL + "TST_ESO_001, ";
            sSQL = sSQL + "TST_ESI_001, ";
            sSQL = sSQL + "TST_ECR_001, ";
            sSQL = sSQL + "TST_EOD_001, ";
            sSQL = sSQL + "TST_EAW_001, ";
            sSQL = sSQL + "TST_ED1_001, ";
            sSQL = sSQL + "TST_ED2_001, ";
            sSQL = sSQL + "TST_VW2_002, ";
            sSQL = sSQL + "TST_EGM_002, ";
            sSQL = sSQL + "TST_DYY_002, ";
            sSQL = sSQL + "TST_2WX_002, ";
            sSQL = sSQL + "TST_3W3_002, ";
            sSQL = sSQL + "TST_4W4_002, ";
            sSQL = sSQL + "TST_AGL_002, ";
            sSQL = sSQL + "TST_TUP_002, ";
            sSQL = sSQL + "TST_VEO_002, ";
            sSQL = sSQL + "TST_T1T_002, ";
            sSQL = sSQL + "TST_T1C_002, ";
            sSQL = sSQL + "TST_T1L_002, ";
            sSQL = sSQL + "TST_T2F_002, ";
            sSQL = sSQL + "TST_SVE_002, ";
            sSQL = sSQL + "TST_STF_002, ";
            sSQL = sSQL + "TST_STM_002, ";
            sSQL = sSQL + "TST_SCE_002, ";
            sSQL = sSQL + "TST_SCO_002, ";
            sSQL = sSQL + "TST_SCH_002, ";
            sSQL = sSQL + "TST_SCG_002, ";
            sSQL = sSQL + "TST_SEE_002, ";
            sSQL = sSQL + "TST_SEO_002, ";
            sSQL = sSQL + "TST_SEH_002, ";
            sSQL = sSQL + "TST_SEG_002, ";
            sSQL = sSQL + "TST_SJC_002, ";
            sSQL = sSQL + "TST_SJT_002, ";
            sSQL = sSQL + "TST_SJB_002, ";
            sSQL = sSQL + "TST_SPJ_002, ";
            sSQL = sSQL + "TST_SBC_002, ";
            sSQL = sSQL + "TST_SPO_002, ";
            sSQL = sSQL + "TST_SVA_002, ";
            sSQL = sSQL + "TST_TGR_002, ";
            sSQL = sSQL + "TST_TIP_002, ";
            sSQL = sSQL + "TST_DSB_002, ";
            sSQL = sSQL + "TST_TCA_002, ";
            sSQL = sSQL + "TST_FMC_002, ";
            sSQL = sSQL + "TST_1TB_002, ";
            sSQL = sSQL + "TST_1PP_002, ";
            sSQL = sSQL + "TST_2TB_002, ";
            sSQL = sSQL + "TST_2PP_002, ";
            sSQL = sSQL + "TST_P1C_002, ";
            sSQL = sSQL + "TST_P2D_002, ";
            sSQL = sSQL + "TST_P3D_002, ";
            sSQL = sSQL + "TST_P4U_002, ";
            sSQL = sSQL + "TST_MOL_002, ";
            sSQL = sSQL + "TST_TPD_002, ";
            sSQL = sSQL + "TST_TT1_002, ";
            sSQL = sSQL + "TST_TT2_002, ";
            sSQL = sSQL + "TST_TT3_002, ";
            sSQL = sSQL + "TST_T21_002, ";
            sSQL = sSQL + "TST_TUN_002, ";
            sSQL = sSQL + "TST_TCV_002, ";
            sSQL = sSQL + "TST_TSS_002, ";
            sSQL = sSQL + "TST_TIT_002, ";
            sSQL = sSQL + "TST_TNC_002, ";
            sSQL = sSQL + "TST_AON_002, ";
            sSQL = sSQL + "TST_ENM_002, ";
            sSQL = sSQL + "TST_EEE_002, ";
            sSQL = sSQL + "TST_KKK_002, ";
            sSQL = sSQL + "TST_BBB_002, ";
            sSQL = sSQL + "TST_OLE_002, ";
            sSQL = sSQL + "TST_TRQ_002, ";
            sSQL = sSQL + "TST_ERT_002, ";
            sSQL = sSQL + "TST_RT3_002, ";
            sSQL = sSQL + "TST_RT5_002, ";
            sSQL = sSQL + "TST_DND_002, ";
            sSQL = sSQL + "TST_DMO_002, ";
            sSQL = sSQL + "TST_PES_002, ";
            sSQL = sSQL + "TST_VRR_002, ";
            sSQL = sSQL + "TST_TRE_002, ";
            sSQL = sSQL + "TST_LME_002, ";
            sSQL = sSQL + "TST_UME_002, ";
            sSQL = sSQL + "TST_LPE_002, ";
            sSQL = sSQL + "TST_UPE_002, ";
            sSQL = sSQL + "TST_UCV_002, ";
            sSQL = sSQL + "TST_CSO_002, ";
            sSQL = sSQL + "TST_ESP_002, ";
            sSQL = sSQL + "TST_TOL_002, ";
            sSQL = sSQL + "TST_DUR_002, ";
            sSQL = sSQL + "TST_DFT_002, ";
            sSQL = sSQL + "TST_LMC_002, ";
            sSQL = sSQL + "TST_UMC_002, ";
            sSQL = sSQL + "TST_LPC_002, ";
            sSQL = sSQL + "TST_UPC_002, ";
            sSQL = sSQL + "TST_CVC_002, ";
            sSQL = sSQL + "TST_DFC_002, ";
            sSQL = sSQL + "TST_TFS_002, ";
            sSQL = sSQL + "TST_FSW_002, ";
            sSQL = sSQL + "TST_WFW_002, ";
            sSQL = sSQL + "TST_ECO_002, ";
            sSQL = sSQL + "TST_EOL_002, ";
            sSQL = sSQL + "TST_ETU_002, ";
            sSQL = sSQL + "TST_ETD_002, ";
            sSQL = sSQL + "TST_ECU_002, ";
            sSQL = sSQL + "TST_EGD_002, ";
            sSQL = sSQL + "TST_EEC_002, ";
            sSQL = sSQL + "TST_ECD_002, ";
            sSQL = sSQL + "TST_EGU_002, ";
            sSQL = sSQL + "TST_ESO_002, ";
            sSQL = sSQL + "TST_ESI_002, ";
            sSQL = sSQL + "TST_ECR_002, ";
            sSQL = sSQL + "TST_EOD_002, ";
            sSQL = sSQL + "TST_EAW_002, ";
            sSQL = sSQL + "TST_ED1_002, ";
            sSQL = sSQL + "TST_ED2_002, ";
            sSQL = sSQL + "TST_VW2_003, ";
            sSQL = sSQL + "TST_EGM_003, ";
            sSQL = sSQL + "TST_DYY_003, ";
            sSQL = sSQL + "TST_2WX_003, ";
            sSQL = sSQL + "TST_3W3_003, ";
            sSQL = sSQL + "TST_4W4_003, ";
            sSQL = sSQL + "TST_AGL_003, ";
            sSQL = sSQL + "TST_TUP_003, ";
            sSQL = sSQL + "TST_VEO_003, ";
            sSQL = sSQL + "TST_T1T_003, ";
            sSQL = sSQL + "TST_T1C_003, ";
            sSQL = sSQL + "TST_T1L_003, ";
            sSQL = sSQL + "TST_T2F_003, ";
            sSQL = sSQL + "TST_SVE_003, ";
            sSQL = sSQL + "TST_STF_003, ";
            sSQL = sSQL + "TST_STM_003, ";
            sSQL = sSQL + "TST_SCE_003, ";
            sSQL = sSQL + "TST_SCO_003, ";
            sSQL = sSQL + "TST_SCH_003, ";
            sSQL = sSQL + "TST_SCG_003, ";
            sSQL = sSQL + "TST_SEE_003, ";
            sSQL = sSQL + "TST_SEO_003, ";
            sSQL = sSQL + "TST_SEH_003, ";
            sSQL = sSQL + "TST_SEG_003, ";
            sSQL = sSQL + "TST_SJC_003, ";
            sSQL = sSQL + "TST_SJT_003, ";
            sSQL = sSQL + "TST_SJB_003, ";
            sSQL = sSQL + "TST_SPJ_003, ";
            sSQL = sSQL + "TST_SBC_003, ";
            sSQL = sSQL + "TST_SPO_003, ";
            sSQL = sSQL + "TST_SVA_003, ";
            sSQL = sSQL + "TST_TGR_003, ";
            sSQL = sSQL + "TST_TIP_003, ";
            sSQL = sSQL + "TST_DSB_003, ";
            sSQL = sSQL + "TST_TCA_003, ";
            sSQL = sSQL + "TST_FMC_003, ";
            sSQL = sSQL + "TST_1TB_003, ";
            sSQL = sSQL + "TST_1PP_003, ";
            sSQL = sSQL + "TST_2TB_003, ";
            sSQL = sSQL + "TST_2PP_003, ";
            sSQL = sSQL + "TST_P1C_003, ";
            sSQL = sSQL + "TST_P2D_003, ";
            sSQL = sSQL + "TST_P3D_003, ";
            sSQL = sSQL + "TST_P4U_003, ";
            sSQL = sSQL + "TST_MOL_003, ";
            sSQL = sSQL + "TST_TPD_003, ";
            sSQL = sSQL + "TST_TT1_003, ";
            sSQL = sSQL + "TST_TT2_003, ";
            sSQL = sSQL + "TST_TT3_003, ";
            sSQL = sSQL + "TST_T21_003, ";
            sSQL = sSQL + "TST_TUN_003, ";
            sSQL = sSQL + "TST_TCV_003, ";
            sSQL = sSQL + "TST_TSS_003, ";
            sSQL = sSQL + "TST_TIT_003, ";
            sSQL = sSQL + "TST_TNC_003, ";
            sSQL = sSQL + "TST_AON_003, ";
            sSQL = sSQL + "TST_ENM_003, ";
            sSQL = sSQL + "TST_EEE_003, ";
            sSQL = sSQL + "TST_KKK_003, ";
            sSQL = sSQL + "TST_BBB_003, ";
            sSQL = sSQL + "TST_OLE_003, ";
            sSQL = sSQL + "TST_TRQ_003, ";
            sSQL = sSQL + "TST_ERT_003, ";
            sSQL = sSQL + "TST_RT3_003, ";
            sSQL = sSQL + "TST_RT5_003, ";
            sSQL = sSQL + "TST_DND_003, ";
            sSQL = sSQL + "TST_DMO_003, ";
            sSQL = sSQL + "TST_PES_003, ";
            sSQL = sSQL + "TST_VRR_003, ";
            sSQL = sSQL + "TST_TRE_003, ";
            sSQL = sSQL + "TST_LME_003, ";
            sSQL = sSQL + "TST_UME_003, ";
            sSQL = sSQL + "TST_LPE_003, ";
            sSQL = sSQL + "TST_UPE_003, ";
            sSQL = sSQL + "TST_UCV_003, ";
            sSQL = sSQL + "TST_CSO_003, ";
            sSQL = sSQL + "TST_ESP_003, ";
            sSQL = sSQL + "TST_TOL_003, ";
            sSQL = sSQL + "TST_DUR_003, ";
            sSQL = sSQL + "TST_DFT_003, ";
            sSQL = sSQL + "TST_LMC_003, ";
            sSQL = sSQL + "TST_UMC_003, ";
            sSQL = sSQL + "TST_LPC_003, ";
            sSQL = sSQL + "TST_UPC_003, ";
            sSQL = sSQL + "TST_CVC_003, ";
            sSQL = sSQL + "TST_DFC_003, ";
            sSQL = sSQL + "TST_TFS_003, ";
            sSQL = sSQL + "TST_FSW_003, ";
            sSQL = sSQL + "TST_WFW_003, ";
            sSQL = sSQL + "TST_ECO_003, ";
            sSQL = sSQL + "TST_EOL_003, ";
            sSQL = sSQL + "TST_ETU_003, ";
            sSQL = sSQL + "TST_ETD_003, ";
            sSQL = sSQL + "TST_ECU_003, ";
            sSQL = sSQL + "TST_EGD_003, ";
            sSQL = sSQL + "TST_EEC_003, ";
            sSQL = sSQL + "TST_ECD_003, ";
            sSQL = sSQL + "TST_EGU_003, ";
            sSQL = sSQL + "TST_ESO_003, ";
            sSQL = sSQL + "TST_ESI_003, ";
            sSQL = sSQL + "TST_ECR_003, ";
            sSQL = sSQL + "TST_EOD_003, ";
            sSQL = sSQL + "TST_EAW_003, ";
            sSQL = sSQL + "TST_ED1_003, ";
            sSQL = sSQL + "TST_ED2_003, ";
            sSQL = sSQL + "TST_VW2_004, ";
            sSQL = sSQL + "TST_EGM_004, ";
            sSQL = sSQL + "TST_DYY_004, ";
            sSQL = sSQL + "TST_2WX_004, ";
            sSQL = sSQL + "TST_3W3_004, ";
            sSQL = sSQL + "TST_4W4_004, ";
            sSQL = sSQL + "TST_AGL_004, ";
            sSQL = sSQL + "TST_TUP_004, ";
            sSQL = sSQL + "TST_VEO_004, ";
            sSQL = sSQL + "TST_T1T_004, ";
            sSQL = sSQL + "TST_T1C_004, ";
            sSQL = sSQL + "TST_T1L_004, ";
            sSQL = sSQL + "TST_T2F_004, ";
            sSQL = sSQL + "TST_SVE_004, ";
            sSQL = sSQL + "TST_STF_004, ";
            sSQL = sSQL + "TST_STM_004, ";
            sSQL = sSQL + "TST_SCE_004, ";
            sSQL = sSQL + "TST_SCO_004, ";
            sSQL = sSQL + "TST_SCH_004, ";
            sSQL = sSQL + "TST_SCG_004, ";
            sSQL = sSQL + "TST_SEE_004, ";
            sSQL = sSQL + "TST_SEO_004, ";
            sSQL = sSQL + "TST_SEH_004, ";
            sSQL = sSQL + "TST_SEG_004, ";
            sSQL = sSQL + "TST_SJC_004, ";
            sSQL = sSQL + "TST_SJT_004, ";
            sSQL = sSQL + "TST_SJB_004, ";
            sSQL = sSQL + "TST_SPJ_004, ";
            sSQL = sSQL + "TST_SBC_004, ";
            sSQL = sSQL + "TST_SPO_004, ";
            sSQL = sSQL + "TST_SVA_004, ";
            sSQL = sSQL + "TST_TGR_004, ";
            sSQL = sSQL + "TST_TIP_004, ";
            sSQL = sSQL + "TST_DSB_004, ";
            sSQL = sSQL + "TST_TCA_004, ";
            sSQL = sSQL + "TST_FMC_004, ";
            sSQL = sSQL + "TST_1TB_004, ";
            sSQL = sSQL + "TST_1PP_004, ";
            sSQL = sSQL + "TST_2TB_004, ";
            sSQL = sSQL + "TST_2PP_004, ";
            sSQL = sSQL + "TST_P1C_004, ";
            sSQL = sSQL + "TST_P2D_004, ";
            sSQL = sSQL + "TST_P3D_004, ";
            sSQL = sSQL + "TST_P4U_004, ";
            sSQL = sSQL + "TST_MOL_004, ";
            sSQL = sSQL + "TST_TPD_004, ";
            sSQL = sSQL + "TST_TT1_004, ";
            sSQL = sSQL + "TST_TT2_004, ";
            sSQL = sSQL + "TST_TT3_004, ";
            sSQL = sSQL + "TST_T21_004, ";
            sSQL = sSQL + "TST_TUN_004, ";
            sSQL = sSQL + "TST_TCV_004, ";
            sSQL = sSQL + "TST_TSS_004, ";
            sSQL = sSQL + "TST_TIT_004, ";
            sSQL = sSQL + "TST_TNC_004, ";
            sSQL = sSQL + "TST_AON_004, ";
            sSQL = sSQL + "TST_ENM_004, ";
            sSQL = sSQL + "TST_EEE_004, ";
            sSQL = sSQL + "TST_KKK_004, ";
            sSQL = sSQL + "TST_BBB_004, ";
            sSQL = sSQL + "TST_OLE_004, ";
            sSQL = sSQL + "TST_TRQ_004, ";
            sSQL = sSQL + "TST_ERT_004, ";
            sSQL = sSQL + "TST_RT3_004, ";
            sSQL = sSQL + "TST_RT5_004, ";
            sSQL = sSQL + "TST_DND_004, ";
            sSQL = sSQL + "TST_DMO_004, ";
            sSQL = sSQL + "TST_PES_004, ";
            sSQL = sSQL + "TST_VRR_004, ";
            sSQL = sSQL + "TST_TRE_004, ";
            sSQL = sSQL + "TST_LME_004, ";
            sSQL = sSQL + "TST_UME_004, ";
            sSQL = sSQL + "TST_LPE_004, ";
            sSQL = sSQL + "TST_UPE_004, ";
            sSQL = sSQL + "TST_UCV_004, ";
            sSQL = sSQL + "TST_CSO_004, ";
            sSQL = sSQL + "TST_ESP_004, ";
            sSQL = sSQL + "TST_TOL_004, ";
            sSQL = sSQL + "TST_DUR_004, ";
            sSQL = sSQL + "TST_DFT_004, ";
            sSQL = sSQL + "TST_LMC_004, ";
            sSQL = sSQL + "TST_UMC_004, ";
            sSQL = sSQL + "TST_LPC_004, ";
            sSQL = sSQL + "TST_UPC_004, ";
            sSQL = sSQL + "TST_CVC_004, ";
            sSQL = sSQL + "TST_DFC_004, ";
            sSQL = sSQL + "TST_TFS_004, ";
            sSQL = sSQL + "TST_FSW_004, ";
            sSQL = sSQL + "TST_WFW_004, ";
            sSQL = sSQL + "TST_ECO_004, ";
            sSQL = sSQL + "TST_EOL_004, ";
            sSQL = sSQL + "TST_ETU_004, ";
            sSQL = sSQL + "TST_ETD_004, ";
            sSQL = sSQL + "TST_ECU_004, ";
            sSQL = sSQL + "TST_EGD_004, ";
            sSQL = sSQL + "TST_EEC_004, ";
            sSQL = sSQL + "TST_ECD_004, ";
            sSQL = sSQL + "TST_EGU_004, ";
            sSQL = sSQL + "TST_ESO_004, ";
            sSQL = sSQL + "TST_ESI_004, ";
            sSQL = sSQL + "TST_ECR_004, ";
            sSQL = sSQL + "TST_EOD_004, ";
            sSQL = sSQL + "TST_EAW_004, ";
            sSQL = sSQL + "TST_ED1_004, ";
            sSQL = sSQL + "TST_ED2_004, ";
            sSQL = sSQL + "TST_VW2_005, ";
            sSQL = sSQL + "TST_EGM_005, ";
            sSQL = sSQL + "TST_DYY_005, ";
            sSQL = sSQL + "TST_2WX_005, ";
            sSQL = sSQL + "TST_3W3_005, ";
            sSQL = sSQL + "TST_4W4_005, ";
            sSQL = sSQL + "TST_AGL_005, ";
            sSQL = sSQL + "TST_TUP_005, ";
            sSQL = sSQL + "TST_VEO_005, ";
            sSQL = sSQL + "TST_T1T_005, ";
            sSQL = sSQL + "TST_T1C_005, ";
            sSQL = sSQL + "TST_T1L_005, ";
            sSQL = sSQL + "TST_T2F_005, ";
            sSQL = sSQL + "TST_SVE_005, ";
            sSQL = sSQL + "TST_STF_005, ";
            sSQL = sSQL + "TST_STM_005, ";
            sSQL = sSQL + "TST_SCE_005, ";
            sSQL = sSQL + "TST_SCO_005, ";
            sSQL = sSQL + "TST_SCH_005, ";
            sSQL = sSQL + "TST_SCG_005, ";
            sSQL = sSQL + "TST_SEE_005, ";
            sSQL = sSQL + "TST_SEO_005, ";
            sSQL = sSQL + "TST_SEH_005, ";
            sSQL = sSQL + "TST_SEG_005, ";
            sSQL = sSQL + "TST_SJC_005, ";
            sSQL = sSQL + "TST_SJT_005, ";
            sSQL = sSQL + "TST_SJB_005, ";
            sSQL = sSQL + "TST_SPJ_005, ";
            sSQL = sSQL + "TST_SBC_005, ";
            sSQL = sSQL + "TST_SPO_005, ";
            sSQL = sSQL + "TST_SVA_005, ";
            sSQL = sSQL + "TST_TGR_005, ";
            sSQL = sSQL + "TST_TIP_005, ";
            sSQL = sSQL + "TST_DSB_005, ";
            sSQL = sSQL + "TST_TCA_005, ";
            sSQL = sSQL + "TST_FMC_005, ";
            sSQL = sSQL + "TST_1TB_005, ";
            sSQL = sSQL + "TST_1PP_005, ";
            sSQL = sSQL + "TST_2TB_005, ";
            sSQL = sSQL + "TST_2PP_005, ";
            sSQL = sSQL + "TST_P1C_005, ";
            sSQL = sSQL + "TST_P2D_005, ";
            sSQL = sSQL + "TST_P3D_005, ";
            sSQL = sSQL + "TST_P4U_005, ";
            sSQL = sSQL + "TST_MOL_005, ";
            sSQL = sSQL + "TST_TPD_005, ";
            sSQL = sSQL + "TST_TT1_005, ";
            sSQL = sSQL + "TST_TT2_005, ";
            sSQL = sSQL + "TST_TT3_005, ";
            sSQL = sSQL + "TST_T21_005, ";
            sSQL = sSQL + "TST_TUN_005, ";
            sSQL = sSQL + "TST_TCV_005, ";
            sSQL = sSQL + "TST_TSS_005, ";
            sSQL = sSQL + "TST_TIT_005, ";
            sSQL = sSQL + "TST_TNC_005, ";
            sSQL = sSQL + "TST_AON_005, ";
            sSQL = sSQL + "TST_ENM_005, ";
            sSQL = sSQL + "TST_EEE_005, ";
            sSQL = sSQL + "TST_KKK_005, ";
            sSQL = sSQL + "TST_BBB_005, ";
            sSQL = sSQL + "TST_OLE_005, ";
            sSQL = sSQL + "TST_TRQ_005, ";
            sSQL = sSQL + "TST_ERT_005, ";
            sSQL = sSQL + "TST_RT3_005, ";
            sSQL = sSQL + "TST_RT5_005, ";
            sSQL = sSQL + "TST_DND_005, ";
            sSQL = sSQL + "TST_DMO_005, ";
            sSQL = sSQL + "TST_PES_005, ";
            sSQL = sSQL + "TST_VRR_005, ";
            sSQL = sSQL + "TST_TRE_005, ";
            sSQL = sSQL + "TST_LME_005, ";
            sSQL = sSQL + "TST_UME_005, ";
            sSQL = sSQL + "TST_LPE_005, ";
            sSQL = sSQL + "TST_UPE_005, ";
            sSQL = sSQL + "TST_UCV_005, ";
            sSQL = sSQL + "TST_CSO_005, ";
            sSQL = sSQL + "TST_ESP_005, ";
            sSQL = sSQL + "TST_TOL_005, ";
            sSQL = sSQL + "TST_DUR_005, ";
            sSQL = sSQL + "TST_DFT_005, ";
            sSQL = sSQL + "TST_LMC_005, ";
            sSQL = sSQL + "TST_UMC_005, ";
            sSQL = sSQL + "TST_LPC_005, ";
            sSQL = sSQL + "TST_UPC_005, ";
            sSQL = sSQL + "TST_CVC_005, ";
            sSQL = sSQL + "TST_DFC_005, ";
            sSQL = sSQL + "TST_TFS_005, ";
            sSQL = sSQL + "TST_FSW_005, ";
            sSQL = sSQL + "TST_WFW_005, ";
            sSQL = sSQL + "TST_ECO_005, ";
            sSQL = sSQL + "TST_EOL_005, ";
            sSQL = sSQL + "TST_ETU_005, ";
            sSQL = sSQL + "TST_ETD_005, ";
            sSQL = sSQL + "TST_ECU_005, ";
            sSQL = sSQL + "TST_EGD_005, ";
            sSQL = sSQL + "TST_EEC_005, ";
            sSQL = sSQL + "TST_ECD_005, ";
            sSQL = sSQL + "TST_EGU_005, ";
            sSQL = sSQL + "TST_ESO_005, ";
            sSQL = sSQL + "TST_ESI_005, ";
            sSQL = sSQL + "TST_ECR_005, ";
            sSQL = sSQL + "TST_EOD_005, ";
            sSQL = sSQL + "TST_EAW_005, ";
            sSQL = sSQL + "TST_ED1_005, ";
            sSQL = sSQL + "TST_ED2_005, ";
            sSQL = sSQL + "TST_VW2_006, ";
            sSQL = sSQL + "TST_EGM_006, ";
            sSQL = sSQL + "TST_DYY_006, ";
            sSQL = sSQL + "TST_2WX_006, ";
            sSQL = sSQL + "TST_3W3_006, ";
            sSQL = sSQL + "TST_4W4_006, ";
            sSQL = sSQL + "TST_AGL_006, ";
            sSQL = sSQL + "TST_TUP_006, ";
            sSQL = sSQL + "TST_VEO_006, ";
            sSQL = sSQL + "TST_T1T_006, ";
            sSQL = sSQL + "TST_T1C_006, ";
            sSQL = sSQL + "TST_T1L_006, ";
            sSQL = sSQL + "TST_T2F_006, ";
            sSQL = sSQL + "TST_SVE_006, ";
            sSQL = sSQL + "TST_STF_006, ";
            sSQL = sSQL + "TST_STM_006, ";
            sSQL = sSQL + "TST_SCE_006, ";
            sSQL = sSQL + "TST_SCO_006, ";
            sSQL = sSQL + "TST_SCH_006, ";
            sSQL = sSQL + "TST_SCG_006, ";
            sSQL = sSQL + "TST_SEE_006, ";
            sSQL = sSQL + "TST_SEO_006, ";
            sSQL = sSQL + "TST_SEH_006, ";
            sSQL = sSQL + "TST_SEG_006, ";
            sSQL = sSQL + "TST_SJC_006, ";
            sSQL = sSQL + "TST_SJT_006, ";
            sSQL = sSQL + "TST_SJB_006, ";
            sSQL = sSQL + "TST_SPJ_006, ";
            sSQL = sSQL + "TST_SBC_006, ";
            sSQL = sSQL + "TST_SPO_006, ";
            sSQL = sSQL + "TST_SVA_006, ";
            sSQL = sSQL + "TST_TGR_006, ";
            sSQL = sSQL + "TST_TIP_006, ";
            sSQL = sSQL + "TST_DSB_006, ";
            sSQL = sSQL + "TST_TCA_006, ";
            sSQL = sSQL + "TST_FMC_006, ";
            sSQL = sSQL + "TST_1TB_006, ";
            sSQL = sSQL + "TST_1PP_006, ";
            sSQL = sSQL + "TST_2TB_006, ";
            sSQL = sSQL + "TST_2PP_006, ";
            sSQL = sSQL + "TST_P1C_006, ";
            sSQL = sSQL + "TST_P2D_006, ";
            sSQL = sSQL + "TST_P3D_006, ";
            sSQL = sSQL + "TST_P4U_006, ";
            sSQL = sSQL + "TST_MOL_006, ";
            sSQL = sSQL + "TST_TPD_006, ";
            sSQL = sSQL + "TST_TT1_006, ";
            sSQL = sSQL + "TST_TT2_006, ";
            sSQL = sSQL + "TST_TT3_006, ";
            sSQL = sSQL + "TST_T21_006, ";
            sSQL = sSQL + "TST_TUN_006, ";
            sSQL = sSQL + "TST_TCV_006, ";
            sSQL = sSQL + "TST_TSS_006, ";
            sSQL = sSQL + "TST_TIT_006, ";
            sSQL = sSQL + "TST_TNC_006, ";
            sSQL = sSQL + "TST_AON_006, ";
            sSQL = sSQL + "TST_ENM_006, ";
            sSQL = sSQL + "TST_EEE_006, ";
            sSQL = sSQL + "TST_KKK_006, ";
            sSQL = sSQL + "TST_BBB_006, ";
            sSQL = sSQL + "TST_OLE_006, ";
            sSQL = sSQL + "TST_TRQ_006, ";
            sSQL = sSQL + "TST_ERT_006, ";
            sSQL = sSQL + "TST_RT3_006, ";
            sSQL = sSQL + "TST_RT5_006, ";
            sSQL = sSQL + "TST_DND_006, ";
            sSQL = sSQL + "TST_DMO_006, ";
            sSQL = sSQL + "TST_PES_006, ";
            sSQL = sSQL + "TST_VRR_006, ";
            sSQL = sSQL + "TST_TRE_006, ";
            sSQL = sSQL + "TST_LME_006, ";
            sSQL = sSQL + "TST_UME_006, ";
            sSQL = sSQL + "TST_LPE_006, ";
            sSQL = sSQL + "TST_UPE_006, ";
            sSQL = sSQL + "TST_UCV_006, ";
            sSQL = sSQL + "TST_CSO_006, ";
            sSQL = sSQL + "TST_ESP_006, ";
            sSQL = sSQL + "TST_TOL_006, ";
            sSQL = sSQL + "TST_DUR_006, ";
            sSQL = sSQL + "TST_DFT_006, ";
            sSQL = sSQL + "TST_LMC_006, ";
            sSQL = sSQL + "TST_UMC_006, ";
            sSQL = sSQL + "TST_LPC_006, ";
            sSQL = sSQL + "TST_UPC_006, ";
            sSQL = sSQL + "TST_CVC_006, ";
            sSQL = sSQL + "TST_DFC_006, ";
            sSQL = sSQL + "TST_TFS_006, ";
            sSQL = sSQL + "TST_FSW_006, ";
            sSQL = sSQL + "TST_WFW_006, ";
            sSQL = sSQL + "TST_ECO_006, ";
            sSQL = sSQL + "TST_EOL_006, ";
            sSQL = sSQL + "TST_ETU_006, ";
            sSQL = sSQL + "TST_ETD_006, ";
            sSQL = sSQL + "TST_ECU_006, ";
            sSQL = sSQL + "TST_EGD_006, ";
            sSQL = sSQL + "TST_EEC_006, ";
            sSQL = sSQL + "TST_ECD_006, ";
            sSQL = sSQL + "TST_EGU_006, ";
            sSQL = sSQL + "TST_ESO_006, ";
            sSQL = sSQL + "TST_ESI_006, ";
            sSQL = sSQL + "TST_ECR_006, ";
            sSQL = sSQL + "TST_EOD_006, ";
            sSQL = sSQL + "TST_EAW_006, ";
            sSQL = sSQL + "TST_ED1_006, ";
            sSQL = sSQL + "TST_ED2_006, ";
            sSQL = sSQL + "TST_VW2_007, ";
            sSQL = sSQL + "TST_EGM_007, ";
            sSQL = sSQL + "TST_DYY_007, ";
            sSQL = sSQL + "TST_2WX_007, ";
            sSQL = sSQL + "TST_3W3_007, ";
            sSQL = sSQL + "TST_4W4_007, ";
            sSQL = sSQL + "TST_AGL_007, ";
            sSQL = sSQL + "TST_TUP_007, ";
            sSQL = sSQL + "TST_VEO_007, ";
            sSQL = sSQL + "TST_T1T_007, ";
            sSQL = sSQL + "TST_T1C_007, ";
            sSQL = sSQL + "TST_T1L_007, ";
            sSQL = sSQL + "TST_T2F_007, ";
            sSQL = sSQL + "TST_SVE_007, ";
            sSQL = sSQL + "TST_STF_007, ";
            sSQL = sSQL + "TST_STM_007, ";
            sSQL = sSQL + "TST_SCE_007, ";
            sSQL = sSQL + "TST_SCO_007, ";
            sSQL = sSQL + "TST_SCH_007, ";
            sSQL = sSQL + "TST_SCG_007, ";
            sSQL = sSQL + "TST_SEE_007, ";
            sSQL = sSQL + "TST_SEO_007, ";
            sSQL = sSQL + "TST_SEH_007, ";
            sSQL = sSQL + "TST_SEG_007, ";
            sSQL = sSQL + "TST_SJC_007, ";
            sSQL = sSQL + "TST_SJT_007, ";
            sSQL = sSQL + "TST_SJB_007, ";
            sSQL = sSQL + "TST_SPJ_007, ";
            sSQL = sSQL + "TST_SBC_007, ";
            sSQL = sSQL + "TST_SPO_007, ";
            sSQL = sSQL + "TST_SVA_007, ";
            sSQL = sSQL + "TST_TGR_007, ";
            sSQL = sSQL + "TST_TIP_007, ";
            sSQL = sSQL + "TST_DSB_007, ";
            sSQL = sSQL + "TST_TCA_007, ";
            sSQL = sSQL + "TST_FMC_007, ";
            sSQL = sSQL + "TST_1TB_007, ";
            sSQL = sSQL + "TST_1PP_007, ";
            sSQL = sSQL + "TST_2TB_007, ";
            sSQL = sSQL + "TST_2PP_007, ";
            sSQL = sSQL + "TST_P1C_007, ";
            sSQL = sSQL + "TST_P2D_007, ";
            sSQL = sSQL + "TST_P3D_007, ";
            sSQL = sSQL + "TST_P4U_007, ";
            sSQL = sSQL + "TST_MOL_007, ";
            sSQL = sSQL + "TST_TPD_007, ";
            sSQL = sSQL + "TST_TT1_007, ";
            sSQL = sSQL + "TST_TT2_007, ";
            sSQL = sSQL + "TST_TT3_007, ";
            sSQL = sSQL + "TST_T21_007, ";
            sSQL = sSQL + "TST_TUN_007, ";
            sSQL = sSQL + "TST_TCV_007, ";
            sSQL = sSQL + "TST_TSS_007, ";
            sSQL = sSQL + "TST_TIT_007, ";
            sSQL = sSQL + "TST_TNC_007, ";
            sSQL = sSQL + "TST_AON_007, ";
            sSQL = sSQL + "TST_ENM_007, ";
            sSQL = sSQL + "TST_EEE_007, ";
            sSQL = sSQL + "TST_KKK_007, ";
            sSQL = sSQL + "TST_BBB_007, ";
            sSQL = sSQL + "TST_OLE_007, ";
            sSQL = sSQL + "TST_TRQ_007, ";
            sSQL = sSQL + "TST_ERT_007, ";
            sSQL = sSQL + "TST_RT3_007, ";
            sSQL = sSQL + "TST_RT5_007, ";
            sSQL = sSQL + "TST_DND_007, ";
            sSQL = sSQL + "TST_DMO_007, ";
            sSQL = sSQL + "TST_PES_007, ";
            sSQL = sSQL + "TST_VRR_007, ";
            sSQL = sSQL + "TST_TRE_007, ";
            sSQL = sSQL + "TST_LME_007, ";
            sSQL = sSQL + "TST_UME_007, ";
            sSQL = sSQL + "TST_LPE_007, ";
            sSQL = sSQL + "TST_UPE_007, ";
            sSQL = sSQL + "TST_UCV_007, ";
            sSQL = sSQL + "TST_CSO_007, ";
            sSQL = sSQL + "TST_ESP_007, ";
            sSQL = sSQL + "TST_TOL_007, ";
            sSQL = sSQL + "TST_DUR_007, ";
            sSQL = sSQL + "TST_DFT_007, ";
            sSQL = sSQL + "TST_LMC_007, ";
            sSQL = sSQL + "TST_UMC_007, ";
            sSQL = sSQL + "TST_LPC_007, ";
            sSQL = sSQL + "TST_UPC_007, ";
            sSQL = sSQL + "TST_CVC_007, ";
            sSQL = sSQL + "TST_DFC_007, ";
            sSQL = sSQL + "TST_TFS_007, ";
            sSQL = sSQL + "TST_FSW_007, ";
            sSQL = sSQL + "TST_WFW_007, ";
            sSQL = sSQL + "TST_ECO_007, ";
            sSQL = sSQL + "TST_EOL_007, ";
            sSQL = sSQL + "TST_ETU_007, ";
            sSQL = sSQL + "TST_ETD_007, ";
            sSQL = sSQL + "TST_ECU_007, ";
            sSQL = sSQL + "TST_EGD_007, ";
            sSQL = sSQL + "TST_EEC_007, ";
            sSQL = sSQL + "TST_ECD_007, ";
            sSQL = sSQL + "TST_EGU_007, ";
            sSQL = sSQL + "TST_ESO_007, ";
            sSQL = sSQL + "TST_ESI_007, ";
            sSQL = sSQL + "TST_ECR_007, ";
            sSQL = sSQL + "TST_EOD_007, ";
            sSQL = sSQL + "TST_EAW_007, ";
            sSQL = sSQL + "TST_ED1_007, ";
            sSQL = sSQL + "TST_ED2_007, ";
            sSQL = sSQL + "TST_PCO_REF, ";
            sSQL = sSQL + "TST_PCV_REF, ";
            sSQL = sSQL + "TST_DRT_REF, ";
            sSQL = sSQL + "TST_TAL_REF, ";
            sSQL = sSQL + "TST_VAL_REF, ";
            sSQL = sSQL + "TST_SJE_REF, ";
            sSQL = sSQL + "TST_PCO_001, ";
            sSQL = sSQL + "TST_PCV_001, ";
            sSQL = sSQL + "TST_DRT_001, ";
            sSQL = sSQL + "TST_TAL_001, ";
            sSQL = sSQL + "TST_VAL_001, ";
            sSQL = sSQL + "TST_SJE_001, ";
            sSQL = sSQL + "TST_PCO_002, ";
            sSQL = sSQL + "TST_PCV_002, ";
            sSQL = sSQL + "TST_DRT_002, ";
            sSQL = sSQL + "TST_TAL_002, ";
            sSQL = sSQL + "TST_VAL_002, ";
            sSQL = sSQL + "TST_SJE_002, ";
            sSQL = sSQL + "TST_PCO_003, ";
            sSQL = sSQL + "TST_PCV_003, ";
            sSQL = sSQL + "TST_DRT_003, ";
            sSQL = sSQL + "TST_TAL_003, ";
            sSQL = sSQL + "TST_VAL_003, ";
            sSQL = sSQL + "TST_SJE_003, ";
            sSQL = sSQL + "TST_PCO_004, ";
            sSQL = sSQL + "TST_PCV_004, ";
            sSQL = sSQL + "TST_DRT_004, ";
            sSQL = sSQL + "TST_TAL_004, ";
            sSQL = sSQL + "TST_VAL_004, ";
            sSQL = sSQL + "TST_SJE_004, ";
            sSQL = sSQL + "TST_PCO_005, ";
            sSQL = sSQL + "TST_PCV_005, ";
            sSQL = sSQL + "TST_DRT_005, ";
            sSQL = sSQL + "TST_TAL_005, ";
            sSQL = sSQL + "TST_VAL_005, ";
            sSQL = sSQL + "TST_SJE_005, ";
            sSQL = sSQL + "TST_PCO_006, ";
            sSQL = sSQL + "TST_PCV_006, ";
            sSQL = sSQL + "TST_DRT_006, ";
            sSQL = sSQL + "TST_TAL_006, ";
            sSQL = sSQL + "TST_VAL_006, ";
            sSQL = sSQL + "TST_SJE_006, ";
            sSQL = sSQL + "TST_PCO_007, ";
            sSQL = sSQL + "TST_PCV_007, ";
            sSQL = sSQL + "TST_DRT_007, ";
            sSQL = sSQL + "TST_TAL_007, ";
            sSQL = sSQL + "TST_VAL_007, ";
            sSQL = sSQL + "TST_SJE_007, ";
            sSQL = sSQL + "TST_DET, ";
            sSQL = sSQL + "TST_OBS, ";
            sSQL = sSQL + "TST_STS, ";
            sSQL = sSQL + "TST_USR_INC_ID, ";
            sSQL = sSQL + "TST_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(TST_RTS_ID.ToString()))
            {
                sSQL = sSQL + TST_RTS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RTS_MTV_TST_ID.ToString()))
            {
                sSQL = sSQL + TST_RTS_MTV_TST_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT))
            {
                sSQL = sSQL + "'" + TST_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_REF))
            {
                sSQL = sSQL + "'" + TST_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_EPF))
            {
                sSQL = sSQL + "'" + TST_LOT_EPF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_ANS))
            {
                sSQL = sSQL + "'" + TST_LOT_ANS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + TST_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DES))
            {
                sSQL = sSQL + "'" + TST_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE))
            {
                sSQL = sSQL + "'" + TST_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_002))
            {
                sSQL = sSQL + "'" + TST_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_003))
            {
                sSQL = sSQL + "'" + TST_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_REF))
            {
                sSQL = sSQL + "'" + TST_MGE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_002_REF))
            {
                sSQL = sSQL + "'" + TST_MGE_002_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_003_REF))
            {
                sSQL = sSQL + "'" + TST_MGE_003_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_001_ID.ToString()))
            {
                sSQL = sSQL + TST_FOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + TST_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + TST_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VLC))
            {
                sSQL = sSQL + "'" + TST_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_APS_ID.ToString()))
            {
                sSQL = sSQL + TST_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + TST_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_ID.ToString()))
            {
                sSQL = sSQL + TST_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DAT_INI.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + TST_DAT_INI + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DAT_FIM.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + TST_DAT_FIM + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_REF))
            {
                sSQL = sSQL + "'" + TST_VW2_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_REF))
            {
                sSQL = sSQL + "'" + TST_EGM_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_REF))
            {
                sSQL = sSQL + "'" + TST_DYY_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_REF))
            {
                sSQL = sSQL + "'" + TST_2WX_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_REF))
            {
                sSQL = sSQL + "'" + TST_3W3_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_REF))
            {
                sSQL = sSQL + "'" + TST_4W4_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_REF))
            {
                sSQL = sSQL + "'" + TST_AGL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_REF))
            {
                sSQL = sSQL + "'" + TST_TUP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_REF))
            {
                sSQL = sSQL + "'" + TST_VEO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_REF))
            {
                sSQL = sSQL + "'" + TST_T1T_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_REF))
            {
                sSQL = sSQL + "'" + TST_T1C_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_REF))
            {
                sSQL = sSQL + "'" + TST_T1L_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_REF))
            {
                sSQL = sSQL + "'" + TST_T2F_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_REF))
            {
                sSQL = sSQL + "'" + TST_SVE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_REF))
            {
                sSQL = sSQL + "'" + TST_STF_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_REF))
            {
                sSQL = sSQL + "'" + TST_STM_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_REF))
            {
                sSQL = sSQL + "'" + TST_SCE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_REF))
            {
                sSQL = sSQL + "'" + TST_SCO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_REF))
            {
                sSQL = sSQL + "'" + TST_SCH_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_REF))
            {
                sSQL = sSQL + "'" + TST_SCG_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_REF))
            {
                sSQL = sSQL + "'" + TST_SEE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_REF))
            {
                sSQL = sSQL + "'" + TST_SEO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_REF))
            {
                sSQL = sSQL + "'" + TST_SEH_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_REF))
            {
                sSQL = sSQL + "'" + TST_SEG_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_REF))
            {
                sSQL = sSQL + "'" + TST_SJC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_REF))
            {
                sSQL = sSQL + "'" + TST_SJT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_REF))
            {
                sSQL = sSQL + "'" + TST_SJB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_REF))
            {
                sSQL = sSQL + "'" + TST_SPJ_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_REF))
            {
                sSQL = sSQL + "'" + TST_SBC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_REF))
            {
                sSQL = sSQL + "'" + TST_SPO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_REF))
            {
                sSQL = sSQL + "'" + TST_SVA_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_REF))
            {
                sSQL = sSQL + "'" + TST_TGR_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_REF))
            {
                sSQL = sSQL + "'" + TST_TIP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_REF))
            {
                sSQL = sSQL + "'" + TST_DSB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_REF))
            {
                sSQL = sSQL + "'" + TST_TCA_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_REF))
            {
                sSQL = sSQL + "'" + TST_FMC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_REF))
            {
                sSQL = sSQL + "'" + TST_1TB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_REF))
            {
                sSQL = sSQL + "'" + TST_1PP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_REF))
            {
                sSQL = sSQL + "'" + TST_2TB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_REF))
            {
                sSQL = sSQL + "'" + TST_2PP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_REF))
            {
                sSQL = sSQL + "'" + TST_P1C_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_REF))
            {
                sSQL = sSQL + "'" + TST_P2D_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_REF))
            {
                sSQL = sSQL + "'" + TST_P3D_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_REF))
            {
                sSQL = sSQL + "'" + TST_P4U_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_REF))
            {
                sSQL = sSQL + "'" + TST_MOL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_REF))
            {
                sSQL = sSQL + "'" + TST_TPD_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_REF))
            {
                sSQL = sSQL + "'" + TST_TT1_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_REF))
            {
                sSQL = sSQL + "'" + TST_TT2_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_REF))
            {
                sSQL = sSQL + "'" + TST_TT3_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_REF))
            {
                sSQL = sSQL + "'" + TST_T21_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_REF))
            {
                sSQL = sSQL + "'" + TST_TUN_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_REF))
            {
                sSQL = sSQL + "'" + TST_TCV_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_REF))
            {
                sSQL = sSQL + "'" + TST_TSS_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_REF.ToString()))
            {
                sSQL = sSQL + TST_TIT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_REF.ToString()))
            {
                sSQL = sSQL + TST_TNC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_REF.ToString()))
            {
                sSQL = sSQL + TST_AON_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_REF.ToString()))
            {
                sSQL = sSQL + TST_ENM_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_REF.ToString()))
            {
                sSQL = sSQL + TST_EEE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_REF.ToString()))
            {
                sSQL = sSQL + TST_KKK_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_REF.ToString()))
            {
                sSQL = sSQL + TST_BBB_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_REF.ToString()))
            {
                sSQL = sSQL + TST_OLE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_REF.ToString()))
            {
                sSQL = sSQL + TST_TRQ_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_REF.ToString()))
            {
                sSQL = sSQL + TST_ERT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_REF.ToString()))
            {
                sSQL = sSQL + TST_RT3_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_REF.ToString()))
            {
                sSQL = sSQL + TST_RT5_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_REF.ToString()))
            {
                sSQL = sSQL + TST_DND_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_REF.ToString()))
            {
                sSQL = sSQL + TST_DMO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_REF.ToString()))
            {
                sSQL = sSQL + TST_PES_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_REF))
            {
                sSQL = sSQL + "'" + TST_VRR_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_REF))
            {
                sSQL = sSQL + "'" + TST_TRE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_REF.ToString()))
            {
                sSQL = sSQL + TST_LME_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_REF.ToString()))
            {
                sSQL = sSQL + TST_UME_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_REF.ToString()))
            {
                sSQL = sSQL + TST_LPE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_REF.ToString()))
            {
                sSQL = sSQL + TST_UPE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_REF.ToString()))
            {
                sSQL = sSQL + TST_UCV_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_REF.ToString()))
            {
                sSQL = sSQL + TST_CSO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_REF.ToString()))
            {
                sSQL = sSQL + TST_ESP_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_REF))
            {
                sSQL = sSQL + "'" + TST_TOL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_REF.ToString()))
            {
                sSQL = sSQL + TST_DUR_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_REF.ToString()))
            {
                sSQL = sSQL + TST_DFT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_REF.ToString()))
            {
                sSQL = sSQL + TST_LMC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_REF.ToString()))
            {
                sSQL = sSQL + TST_UMC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_REF.ToString()))
            {
                sSQL = sSQL + TST_LPC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_REF.ToString()))
            {
                sSQL = sSQL + TST_UPC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_REF.ToString()))
            {
                sSQL = sSQL + TST_CVC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_REF.ToString()))
            {
                sSQL = sSQL + TST_DFC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_REF.ToString()))
            {
                sSQL = sSQL + TST_TFS_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_REF.ToString()))
            {
                sSQL = sSQL + TST_FSW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_REF.ToString()))
            {
                sSQL = sSQL + TST_WFW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_REF.ToString()))
            {
                sSQL = sSQL + TST_ECO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_REF.ToString()))
            {
                sSQL = sSQL + TST_EOL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_REF.ToString()))
            {
                sSQL = sSQL + TST_ETU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_REF.ToString()))
            {
                sSQL = sSQL + TST_ETD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_REF.ToString()))
            {
                sSQL = sSQL + TST_ECU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_REF.ToString()))
            {
                sSQL = sSQL + TST_EGD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_REF.ToString()))
            {
                sSQL = sSQL + TST_EEC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_REF.ToString()))
            {
                sSQL = sSQL + TST_ECD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_REF.ToString()))
            {
                sSQL = sSQL + TST_EGU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_REF.ToString()))
            {
                sSQL = sSQL + TST_ESO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_REF.ToString()))
            {
                sSQL = sSQL + TST_ESI_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_REF.ToString()))
            {
                sSQL = sSQL + TST_ECR_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_REF.ToString()))
            {
                sSQL = sSQL + TST_EOD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_REF.ToString()))
            {
                sSQL = sSQL + TST_EAW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_REF.ToString()))
            {
                sSQL = sSQL + TST_ED1_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_REF.ToString()))
            {
                sSQL = sSQL + TST_ED2_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_001))
            {
                sSQL = sSQL + "'" + TST_VW2_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_001))
            {
                sSQL = sSQL + "'" + TST_EGM_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_001))
            {
                sSQL = sSQL + "'" + TST_DYY_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_001))
            {
                sSQL = sSQL + "'" + TST_2WX_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_001))
            {
                sSQL = sSQL + "'" + TST_3W3_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_001))
            {
                sSQL = sSQL + "'" + TST_4W4_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_001))
            {
                sSQL = sSQL + "'" + TST_AGL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_001))
            {
                sSQL = sSQL + "'" + TST_TUP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_001))
            {
                sSQL = sSQL + "'" + TST_VEO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_001))
            {
                sSQL = sSQL + "'" + TST_T1T_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_001))
            {
                sSQL = sSQL + "'" + TST_T1C_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_001))
            {
                sSQL = sSQL + "'" + TST_T1L_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_001))
            {
                sSQL = sSQL + "'" + TST_T2F_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_001))
            {
                sSQL = sSQL + "'" + TST_SVE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_001))
            {
                sSQL = sSQL + "'" + TST_STF_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_001))
            {
                sSQL = sSQL + "'" + TST_STM_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_001))
            {
                sSQL = sSQL + "'" + TST_SCE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_001))
            {
                sSQL = sSQL + "'" + TST_SCO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_001))
            {
                sSQL = sSQL + "'" + TST_SCH_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_001))
            {
                sSQL = sSQL + "'" + TST_SCG_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_001))
            {
                sSQL = sSQL + "'" + TST_SEE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_001))
            {
                sSQL = sSQL + "'" + TST_SEO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_001))
            {
                sSQL = sSQL + "'" + TST_SEH_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_001))
            {
                sSQL = sSQL + "'" + TST_SEG_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_001))
            {
                sSQL = sSQL + "'" + TST_SJC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_001))
            {
                sSQL = sSQL + "'" + TST_SJT_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_001))
            {
                sSQL = sSQL + "'" + TST_SJB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_001))
            {
                sSQL = sSQL + "'" + TST_SPJ_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_001))
            {
                sSQL = sSQL + "'" + TST_SBC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_001))
            {
                sSQL = sSQL + "'" + TST_SPO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_001))
            {
                sSQL = sSQL + "'" + TST_SVA_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_001))
            {
                sSQL = sSQL + "'" + TST_TGR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_001))
            {
                sSQL = sSQL + "'" + TST_TIP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_001))
            {
                sSQL = sSQL + "'" + TST_DSB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_001))
            {
                sSQL = sSQL + "'" + TST_TCA_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_001))
            {
                sSQL = sSQL + "'" + TST_FMC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_001))
            {
                sSQL = sSQL + "'" + TST_1TB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_001))
            {
                sSQL = sSQL + "'" + TST_1PP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_001))
            {
                sSQL = sSQL + "'" + TST_2TB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_001))
            {
                sSQL = sSQL + "'" + TST_2PP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_001))
            {
                sSQL = sSQL + "'" + TST_P1C_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_001))
            {
                sSQL = sSQL + "'" + TST_P2D_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_001))
            {
                sSQL = sSQL + "'" + TST_P3D_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_001))
            {
                sSQL = sSQL + "'" + TST_P4U_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_001))
            {
                sSQL = sSQL + "'" + TST_MOL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_001))
            {
                sSQL = sSQL + "'" + TST_TPD_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_001))
            {
                sSQL = sSQL + "'" + TST_TT1_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_001))
            {
                sSQL = sSQL + "'" + TST_TT2_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_001))
            {
                sSQL = sSQL + "'" + TST_TT3_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_001))
            {
                sSQL = sSQL + "'" + TST_T21_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_001))
            {
                sSQL = sSQL + "'" + TST_TUN_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_001))
            {
                sSQL = sSQL + "'" + TST_TCV_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_001))
            {
                sSQL = sSQL + "'" + TST_TSS_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_001.ToString()))
            {
                sSQL = sSQL + TST_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_001.ToString()))
            {
                sSQL = sSQL + TST_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_001.ToString()))
            {
                sSQL = sSQL + TST_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_001.ToString()))
            {
                sSQL = sSQL + TST_ENM_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_001.ToString()))
            {
                sSQL = sSQL + TST_EEE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_001.ToString()))
            {
                sSQL = sSQL + TST_KKK_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_001.ToString()))
            {
                sSQL = sSQL + TST_BBB_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_001.ToString()))
            {
                sSQL = sSQL + TST_OLE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_001.ToString()))
            {
                sSQL = sSQL + TST_TRQ_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_001.ToString()))
            {
                sSQL = sSQL + TST_ERT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_001.ToString()))
            {
                sSQL = sSQL + TST_RT3_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_001.ToString()))
            {
                sSQL = sSQL + TST_RT5_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_001.ToString()))
            {
                sSQL = sSQL + TST_DND_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_001.ToString()))
            {
                sSQL = sSQL + TST_DMO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_001.ToString()))
            {
                sSQL = sSQL + TST_PES_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_001))
            {
                sSQL = sSQL + "'" + TST_VRR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_001))
            {
                sSQL = sSQL + "'" + TST_TRE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_001.ToString()))
            {
                sSQL = sSQL + TST_LME_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_001.ToString()))
            {
                sSQL = sSQL + TST_UME_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_001.ToString()))
            {
                sSQL = sSQL + TST_LPE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_001.ToString()))
            {
                sSQL = sSQL + TST_UPE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_001.ToString()))
            {
                sSQL = sSQL + TST_UCV_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_001.ToString()))
            {
                sSQL = sSQL + TST_CSO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_001.ToString()))
            {
                sSQL = sSQL + TST_ESP_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_001))
            {
                sSQL = sSQL + "'" + TST_TOL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_001.ToString()))
            {
                sSQL = sSQL + TST_DUR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_001.ToString()))
            {
                sSQL = sSQL + TST_DFT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_001.ToString()))
            {
                sSQL = sSQL + TST_LMC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_001.ToString()))
            {
                sSQL = sSQL + TST_UMC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_001.ToString()))
            {
                sSQL = sSQL + TST_LPC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_001.ToString()))
            {
                sSQL = sSQL + TST_UPC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_001.ToString()))
            {
                sSQL = sSQL + TST_CVC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_001.ToString()))
            {
                sSQL = sSQL + TST_DFC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_001.ToString()))
            {
                sSQL = sSQL + TST_TFS_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_001.ToString()))
            {
                sSQL = sSQL + TST_FSW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_001.ToString()))
            {
                sSQL = sSQL + TST_WFW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_001.ToString()))
            {
                sSQL = sSQL + TST_ECO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_001.ToString()))
            {
                sSQL = sSQL + TST_EOL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_001.ToString()))
            {
                sSQL = sSQL + TST_ETU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_001.ToString()))
            {
                sSQL = sSQL + TST_ETD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_001.ToString()))
            {
                sSQL = sSQL + TST_ECU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_001.ToString()))
            {
                sSQL = sSQL + TST_EGD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_001.ToString()))
            {
                sSQL = sSQL + TST_EEC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_001.ToString()))
            {
                sSQL = sSQL + TST_ECD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_001.ToString()))
            {
                sSQL = sSQL + TST_EGU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_001.ToString()))
            {
                sSQL = sSQL + TST_ESO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_001.ToString()))
            {
                sSQL = sSQL + TST_ESI_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_001.ToString()))
            {
                sSQL = sSQL + TST_ECR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_001.ToString()))
            {
                sSQL = sSQL + TST_EOD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_001.ToString()))
            {
                sSQL = sSQL + TST_EAW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_001.ToString()))
            {
                sSQL = sSQL + TST_ED1_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_001.ToString()))
            {
                sSQL = sSQL + TST_ED2_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_002))
            {
                sSQL = sSQL + "'" + TST_VW2_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_002))
            {
                sSQL = sSQL + "'" + TST_EGM_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_002))
            {
                sSQL = sSQL + "'" + TST_DYY_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_002))
            {
                sSQL = sSQL + "'" + TST_2WX_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_002))
            {
                sSQL = sSQL + "'" + TST_3W3_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_002))
            {
                sSQL = sSQL + "'" + TST_4W4_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_002))
            {
                sSQL = sSQL + "'" + TST_AGL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_002))
            {
                sSQL = sSQL + "'" + TST_TUP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_002))
            {
                sSQL = sSQL + "'" + TST_VEO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_002))
            {
                sSQL = sSQL + "'" + TST_T1T_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_002))
            {
                sSQL = sSQL + "'" + TST_T1C_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_002))
            {
                sSQL = sSQL + "'" + TST_T1L_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_002))
            {
                sSQL = sSQL + "'" + TST_T2F_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_002))
            {
                sSQL = sSQL + "'" + TST_SVE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_002))
            {
                sSQL = sSQL + "'" + TST_STF_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_002))
            {
                sSQL = sSQL + "'" + TST_STM_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_002))
            {
                sSQL = sSQL + "'" + TST_SCE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_002))
            {
                sSQL = sSQL + "'" + TST_SCO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_002))
            {
                sSQL = sSQL + "'" + TST_SCH_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_002))
            {
                sSQL = sSQL + "'" + TST_SCG_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_002))
            {
                sSQL = sSQL + "'" + TST_SEE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_002))
            {
                sSQL = sSQL + "'" + TST_SEO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_002))
            {
                sSQL = sSQL + "'" + TST_SEH_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_002))
            {
                sSQL = sSQL + "'" + TST_SEG_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_002))
            {
                sSQL = sSQL + "'" + TST_SJC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_002))
            {
                sSQL = sSQL + "'" + TST_SJT_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_002))
            {
                sSQL = sSQL + "'" + TST_SJB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_002))
            {
                sSQL = sSQL + "'" + TST_SPJ_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_002))
            {
                sSQL = sSQL + "'" + TST_SBC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_002))
            {
                sSQL = sSQL + "'" + TST_SPO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_002))
            {
                sSQL = sSQL + "'" + TST_SVA_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_002))
            {
                sSQL = sSQL + "'" + TST_TGR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_002))
            {
                sSQL = sSQL + "'" + TST_TIP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_002))
            {
                sSQL = sSQL + "'" + TST_DSB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_002))
            {
                sSQL = sSQL + "'" + TST_TCA_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_002))
            {
                sSQL = sSQL + "'" + TST_FMC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_002))
            {
                sSQL = sSQL + "'" + TST_1TB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_002))
            {
                sSQL = sSQL + "'" + TST_1PP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_002))
            {
                sSQL = sSQL + "'" + TST_2TB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_002))
            {
                sSQL = sSQL + "'" + TST_2PP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_002))
            {
                sSQL = sSQL + "'" + TST_P1C_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_002))
            {
                sSQL = sSQL + "'" + TST_P2D_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_002))
            {
                sSQL = sSQL + "'" + TST_P3D_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_002))
            {
                sSQL = sSQL + "'" + TST_P4U_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_002))
            {
                sSQL = sSQL + "'" + TST_MOL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_002))
            {
                sSQL = sSQL + "'" + TST_TPD_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_002))
            {
                sSQL = sSQL + "'" + TST_TT1_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_002))
            {
                sSQL = sSQL + "'" + TST_TT2_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_002))
            {
                sSQL = sSQL + "'" + TST_TT3_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_002))
            {
                sSQL = sSQL + "'" + TST_T21_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_002))
            {
                sSQL = sSQL + "'" + TST_TUN_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_002))
            {
                sSQL = sSQL + "'" + TST_TCV_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_002))
            {
                sSQL = sSQL + "'" + TST_TSS_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_002.ToString()))
            {
                sSQL = sSQL + TST_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_002.ToString()))
            {
                sSQL = sSQL + TST_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_002.ToString()))
            {
                sSQL = sSQL + TST_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_002.ToString()))
            {
                sSQL = sSQL + TST_ENM_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_002.ToString()))
            {
                sSQL = sSQL + TST_EEE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_002.ToString()))
            {
                sSQL = sSQL + TST_KKK_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_002.ToString()))
            {
                sSQL = sSQL + TST_BBB_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_002.ToString()))
            {
                sSQL = sSQL + TST_OLE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_002.ToString()))
            {
                sSQL = sSQL + TST_TRQ_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_002.ToString()))
            {
                sSQL = sSQL + TST_ERT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_002.ToString()))
            {
                sSQL = sSQL + TST_RT3_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_002.ToString()))
            {
                sSQL = sSQL + TST_RT5_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_002.ToString()))
            {
                sSQL = sSQL + TST_DND_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_002.ToString()))
            {
                sSQL = sSQL + TST_DMO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_002.ToString()))
            {
                sSQL = sSQL + TST_PES_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_002))
            {
                sSQL = sSQL + "'" + TST_VRR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_002))
            {
                sSQL = sSQL + "'" + TST_TRE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_002.ToString()))
            {
                sSQL = sSQL + TST_LME_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_002.ToString()))
            {
                sSQL = sSQL + TST_UME_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_002.ToString()))
            {
                sSQL = sSQL + TST_LPE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_002.ToString()))
            {
                sSQL = sSQL + TST_UPE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_002.ToString()))
            {
                sSQL = sSQL + TST_UCV_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_002.ToString()))
            {
                sSQL = sSQL + TST_CSO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_002.ToString()))
            {
                sSQL = sSQL + TST_ESP_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_002))
            {
                sSQL = sSQL + "'" + TST_TOL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_002.ToString()))
            {
                sSQL = sSQL + TST_DUR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_002.ToString()))
            {
                sSQL = sSQL + TST_DFT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_002.ToString()))
            {
                sSQL = sSQL + TST_LMC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_002.ToString()))
            {
                sSQL = sSQL + TST_UMC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_002.ToString()))
            {
                sSQL = sSQL + TST_LPC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_002.ToString()))
            {
                sSQL = sSQL + TST_UPC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_002.ToString()))
            {
                sSQL = sSQL + TST_CVC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_002.ToString()))
            {
                sSQL = sSQL + TST_DFC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_002.ToString()))
            {
                sSQL = sSQL + TST_TFS_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_002.ToString()))
            {
                sSQL = sSQL + TST_FSW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_002.ToString()))
            {
                sSQL = sSQL + TST_WFW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_002.ToString()))
            {
                sSQL = sSQL + TST_ECO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_002.ToString()))
            {
                sSQL = sSQL + TST_EOL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_002.ToString()))
            {
                sSQL = sSQL + TST_ETU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_002.ToString()))
            {
                sSQL = sSQL + TST_ETD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_002.ToString()))
            {
                sSQL = sSQL + TST_ECU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_002.ToString()))
            {
                sSQL = sSQL + TST_EGD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_002.ToString()))
            {
                sSQL = sSQL + TST_EEC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_002.ToString()))
            {
                sSQL = sSQL + TST_ECD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_002.ToString()))
            {
                sSQL = sSQL + TST_EGU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_002.ToString()))
            {
                sSQL = sSQL + TST_ESO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_002.ToString()))
            {
                sSQL = sSQL + TST_ESI_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_002.ToString()))
            {
                sSQL = sSQL + TST_ECR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_002.ToString()))
            {
                sSQL = sSQL + TST_EOD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_002.ToString()))
            {
                sSQL = sSQL + TST_EAW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_002.ToString()))
            {
                sSQL = sSQL + TST_ED1_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_002.ToString()))
            {
                sSQL = sSQL + TST_ED2_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_003))
            {
                sSQL = sSQL + "'" + TST_VW2_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_003))
            {
                sSQL = sSQL + "'" + TST_EGM_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_003))
            {
                sSQL = sSQL + "'" + TST_DYY_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_003))
            {
                sSQL = sSQL + "'" + TST_2WX_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_003))
            {
                sSQL = sSQL + "'" + TST_3W3_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_003))
            {
                sSQL = sSQL + "'" + TST_4W4_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_003))
            {
                sSQL = sSQL + "'" + TST_AGL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_003))
            {
                sSQL = sSQL + "'" + TST_TUP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_003))
            {
                sSQL = sSQL + "'" + TST_VEO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_003))
            {
                sSQL = sSQL + "'" + TST_T1T_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_003))
            {
                sSQL = sSQL + "'" + TST_T1C_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_003))
            {
                sSQL = sSQL + "'" + TST_T1L_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_003))
            {
                sSQL = sSQL + "'" + TST_T2F_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_003))
            {
                sSQL = sSQL + "'" + TST_SVE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_003))
            {
                sSQL = sSQL + "'" + TST_STF_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_003))
            {
                sSQL = sSQL + "'" + TST_STM_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_003))
            {
                sSQL = sSQL + "'" + TST_SCE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_003))
            {
                sSQL = sSQL + "'" + TST_SCO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_003))
            {
                sSQL = sSQL + "'" + TST_SCH_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_003))
            {
                sSQL = sSQL + "'" + TST_SCG_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_003))
            {
                sSQL = sSQL + "'" + TST_SEE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_003))
            {
                sSQL = sSQL + "'" + TST_SEO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_003))
            {
                sSQL = sSQL + "'" + TST_SEH_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_003))
            {
                sSQL = sSQL + "'" + TST_SEG_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_003))
            {
                sSQL = sSQL + "'" + TST_SJC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_003))
            {
                sSQL = sSQL + "'" + TST_SJT_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_003))
            {
                sSQL = sSQL + "'" + TST_SJB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_003))
            {
                sSQL = sSQL + "'" + TST_SPJ_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_003))
            {
                sSQL = sSQL + "'" + TST_SBC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_003))
            {
                sSQL = sSQL + "'" + TST_SPO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_003))
            {
                sSQL = sSQL + "'" + TST_SVA_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_003))
            {
                sSQL = sSQL + "'" + TST_TGR_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_003))
            {
                sSQL = sSQL + "'" + TST_TIP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_003))
            {
                sSQL = sSQL + "'" + TST_DSB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_003))
            {
                sSQL = sSQL + "'" + TST_TCA_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_003))
            {
                sSQL = sSQL + "'" + TST_FMC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_003))
            {
                sSQL = sSQL + "'" + TST_1TB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_003))
            {
                sSQL = sSQL + "'" + TST_1PP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_003))
            {
                sSQL = sSQL + "'" + TST_2TB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_003))
            {
                sSQL = sSQL + "'" + TST_2PP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_003))
            {
                sSQL = sSQL + "'" + TST_P1C_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_003))
            {
                sSQL = sSQL + "'" + TST_P2D_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_003))
            {
                sSQL = sSQL + "'" + TST_P3D_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_003))
            {
                sSQL = sSQL + "'" + TST_P4U_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_003))
            {
                sSQL = sSQL + "'" + TST_MOL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_003))
            {
                sSQL = sSQL + "'" + TST_TPD_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_003))
            {
                sSQL = sSQL + "'" + TST_TT1_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_003))
            {
                sSQL = sSQL + "'" + TST_TT2_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_003))
            {
                sSQL = sSQL + "'" + TST_TT3_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_003))
            {
                sSQL = sSQL + "'" + TST_T21_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_003))
            {
                sSQL = sSQL + "'" + TST_TUN_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_003))
            {
                sSQL = sSQL + "'" + TST_TCV_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_003))
            {
                sSQL = sSQL + "'" + TST_TSS_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_003.ToString()))
            {
                sSQL = sSQL + TST_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_003.ToString()))
            {
                sSQL = sSQL + TST_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_003.ToString()))
            {
                sSQL = sSQL + TST_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_003.ToString()))
            {
                sSQL = sSQL + TST_ENM_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_003.ToString()))
            {
                sSQL = sSQL + TST_EEE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_003.ToString()))
            {
                sSQL = sSQL + TST_KKK_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_003.ToString()))
            {
                sSQL = sSQL + TST_BBB_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_003.ToString()))
            {
                sSQL = sSQL + TST_OLE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_003.ToString()))
            {
                sSQL = sSQL + TST_TRQ_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_003.ToString()))
            {
                sSQL = sSQL + TST_ERT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_003.ToString()))
            {
                sSQL = sSQL + TST_RT3_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_003.ToString()))
            {
                sSQL = sSQL + TST_RT5_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_003.ToString()))
            {
                sSQL = sSQL + TST_DND_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_003.ToString()))
            {
                sSQL = sSQL + TST_DMO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_003.ToString()))
            {
                sSQL = sSQL + TST_PES_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_003))
            {
                sSQL = sSQL + "'" + TST_VRR_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_003))
            {
                sSQL = sSQL + "'" + TST_TRE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_003.ToString()))
            {
                sSQL = sSQL + TST_LME_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_003.ToString()))
            {
                sSQL = sSQL + TST_UME_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_003.ToString()))
            {
                sSQL = sSQL + TST_LPE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_003.ToString()))
            {
                sSQL = sSQL + TST_UPE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_003.ToString()))
            {
                sSQL = sSQL + TST_UCV_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_003.ToString()))
            {
                sSQL = sSQL + TST_CSO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_003.ToString()))
            {
                sSQL = sSQL + TST_ESP_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_003))
            {
                sSQL = sSQL + "'" + TST_TOL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_003.ToString()))
            {
                sSQL = sSQL + TST_DUR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_003.ToString()))
            {
                sSQL = sSQL + TST_DFT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_003.ToString()))
            {
                sSQL = sSQL + TST_LMC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_003.ToString()))
            {
                sSQL = sSQL + TST_UMC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_003.ToString()))
            {
                sSQL = sSQL + TST_LPC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_003.ToString()))
            {
                sSQL = sSQL + TST_UPC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_003.ToString()))
            {
                sSQL = sSQL + TST_CVC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_003.ToString()))
            {
                sSQL = sSQL + TST_DFC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_003.ToString()))
            {
                sSQL = sSQL + TST_TFS_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_003.ToString()))
            {
                sSQL = sSQL + TST_FSW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_003.ToString()))
            {
                sSQL = sSQL + TST_WFW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_003.ToString()))
            {
                sSQL = sSQL + TST_ECO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_003.ToString()))
            {
                sSQL = sSQL + TST_EOL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_003.ToString()))
            {
                sSQL = sSQL + TST_ETU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_003.ToString()))
            {
                sSQL = sSQL + TST_ETD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_003.ToString()))
            {
                sSQL = sSQL + TST_ECU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_003.ToString()))
            {
                sSQL = sSQL + TST_EGD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_003.ToString()))
            {
                sSQL = sSQL + TST_EEC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_003.ToString()))
            {
                sSQL = sSQL + TST_ECD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_003.ToString()))
            {
                sSQL = sSQL + TST_EGU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_003.ToString()))
            {
                sSQL = sSQL + TST_ESO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_003.ToString()))
            {
                sSQL = sSQL + TST_ESI_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_003.ToString()))
            {
                sSQL = sSQL + TST_ECR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_003.ToString()))
            {
                sSQL = sSQL + TST_EOD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_003.ToString()))
            {
                sSQL = sSQL + TST_EAW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_003.ToString()))
            {
                sSQL = sSQL + TST_ED1_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_003.ToString()))
            {
                sSQL = sSQL + TST_ED2_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_004))
            {
                sSQL = sSQL + "'" + TST_VW2_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_004))
            {
                sSQL = sSQL + "'" + TST_EGM_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_004))
            {
                sSQL = sSQL + "'" + TST_DYY_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_004))
            {
                sSQL = sSQL + "'" + TST_2WX_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_004))
            {
                sSQL = sSQL + "'" + TST_3W3_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_004))
            {
                sSQL = sSQL + "'" + TST_4W4_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_004))
            {
                sSQL = sSQL + "'" + TST_AGL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_004))
            {
                sSQL = sSQL + "'" + TST_TUP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_004))
            {
                sSQL = sSQL + "'" + TST_VEO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_004))
            {
                sSQL = sSQL + "'" + TST_T1T_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_004))
            {
                sSQL = sSQL + "'" + TST_T1C_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_004))
            {
                sSQL = sSQL + "'" + TST_T1L_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_004))
            {
                sSQL = sSQL + "'" + TST_T2F_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_004))
            {
                sSQL = sSQL + "'" + TST_SVE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_004))
            {
                sSQL = sSQL + "'" + TST_STF_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_004))
            {
                sSQL = sSQL + "'" + TST_STM_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_004))
            {
                sSQL = sSQL + "'" + TST_SCE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_004))
            {
                sSQL = sSQL + "'" + TST_SCO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_004))
            {
                sSQL = sSQL + "'" + TST_SCH_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_004))
            {
                sSQL = sSQL + "'" + TST_SCG_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_004))
            {
                sSQL = sSQL + "'" + TST_SEE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_004))
            {
                sSQL = sSQL + "'" + TST_SEO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_004))
            {
                sSQL = sSQL + "'" + TST_SEH_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_004))
            {
                sSQL = sSQL + "'" + TST_SEG_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_004))
            {
                sSQL = sSQL + "'" + TST_SJC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_004))
            {
                sSQL = sSQL + "'" + TST_SJT_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_004))
            {
                sSQL = sSQL + "'" + TST_SJB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_004))
            {
                sSQL = sSQL + "'" + TST_SPJ_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_004))
            {
                sSQL = sSQL + "'" + TST_SBC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_004))
            {
                sSQL = sSQL + "'" + TST_SPO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_004))
            {
                sSQL = sSQL + "'" + TST_SVA_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_004))
            {
                sSQL = sSQL + "'" + TST_TGR_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_004))
            {
                sSQL = sSQL + "'" + TST_TIP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_004))
            {
                sSQL = sSQL + "'" + TST_DSB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_004))
            {
                sSQL = sSQL + "'" + TST_TCA_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_004))
            {
                sSQL = sSQL + "'" + TST_FMC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_004))
            {
                sSQL = sSQL + "'" + TST_1TB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_004))
            {
                sSQL = sSQL + "'" + TST_1PP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_004))
            {
                sSQL = sSQL + "'" + TST_2TB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_004))
            {
                sSQL = sSQL + "'" + TST_2PP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_004))
            {
                sSQL = sSQL + "'" + TST_P1C_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_004))
            {
                sSQL = sSQL + "'" + TST_P2D_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_004))
            {
                sSQL = sSQL + "'" + TST_P3D_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_004))
            {
                sSQL = sSQL + "'" + TST_P4U_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_004))
            {
                sSQL = sSQL + "'" + TST_MOL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_004))
            {
                sSQL = sSQL + "'" + TST_TPD_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_004))
            {
                sSQL = sSQL + "'" + TST_TT1_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_004))
            {
                sSQL = sSQL + "'" + TST_TT2_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_004))
            {
                sSQL = sSQL + "'" + TST_TT3_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_004))
            {
                sSQL = sSQL + "'" + TST_T21_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_004))
            {
                sSQL = sSQL + "'" + TST_TUN_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_004))
            {
                sSQL = sSQL + "'" + TST_TCV_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_004))
            {
                sSQL = sSQL + "'" + TST_TSS_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_004.ToString()))
            {
                sSQL = sSQL + TST_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_004.ToString()))
            {
                sSQL = sSQL + TST_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_004.ToString()))
            {
                sSQL = sSQL + TST_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_004.ToString()))
            {
                sSQL = sSQL + TST_ENM_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_004.ToString()))
            {
                sSQL = sSQL + TST_EEE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_004.ToString()))
            {
                sSQL = sSQL + TST_KKK_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_004.ToString()))
            {
                sSQL = sSQL + TST_BBB_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_004.ToString()))
            {
                sSQL = sSQL + TST_OLE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_004.ToString()))
            {
                sSQL = sSQL + TST_TRQ_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_004.ToString()))
            {
                sSQL = sSQL + TST_ERT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_004.ToString()))
            {
                sSQL = sSQL + TST_RT3_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_004.ToString()))
            {
                sSQL = sSQL + TST_RT5_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_004.ToString()))
            {
                sSQL = sSQL + TST_DND_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_004.ToString()))
            {
                sSQL = sSQL + TST_DMO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_004.ToString()))
            {
                sSQL = sSQL + TST_PES_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_004))
            {
                sSQL = sSQL + "'" + TST_VRR_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_004))
            {
                sSQL = sSQL + "'" + TST_TRE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_004.ToString()))
            {
                sSQL = sSQL + TST_LME_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_004.ToString()))
            {
                sSQL = sSQL + TST_UME_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_004.ToString()))
            {
                sSQL = sSQL + TST_LPE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_004.ToString()))
            {
                sSQL = sSQL + TST_UPE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_004.ToString()))
            {
                sSQL = sSQL + TST_UCV_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_004.ToString()))
            {
                sSQL = sSQL + TST_CSO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_004.ToString()))
            {
                sSQL = sSQL + TST_ESP_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_004))
            {
                sSQL = sSQL + "'" + TST_TOL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_004.ToString()))
            {
                sSQL = sSQL + TST_DUR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_004.ToString()))
            {
                sSQL = sSQL + TST_DFT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_004.ToString()))
            {
                sSQL = sSQL + TST_LMC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_004.ToString()))
            {
                sSQL = sSQL + TST_UMC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_004.ToString()))
            {
                sSQL = sSQL + TST_LPC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_004.ToString()))
            {
                sSQL = sSQL + TST_UPC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_004.ToString()))
            {
                sSQL = sSQL + TST_CVC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_004.ToString()))
            {
                sSQL = sSQL + TST_DFC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_004.ToString()))
            {
                sSQL = sSQL + TST_TFS_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_004.ToString()))
            {
                sSQL = sSQL + TST_FSW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_004.ToString()))
            {
                sSQL = sSQL + TST_WFW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_004.ToString()))
            {
                sSQL = sSQL + TST_ECO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_004.ToString()))
            {
                sSQL = sSQL + TST_EOL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_004.ToString()))
            {
                sSQL = sSQL + TST_ETU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_004.ToString()))
            {
                sSQL = sSQL + TST_ETD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_004.ToString()))
            {
                sSQL = sSQL + TST_ECU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_004.ToString()))
            {
                sSQL = sSQL + TST_EGD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_004.ToString()))
            {
                sSQL = sSQL + TST_EEC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_004.ToString()))
            {
                sSQL = sSQL + TST_ECD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_004.ToString()))
            {
                sSQL = sSQL + TST_EGU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_004.ToString()))
            {
                sSQL = sSQL + TST_ESO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_004.ToString()))
            {
                sSQL = sSQL + TST_ESI_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_004.ToString()))
            {
                sSQL = sSQL + TST_ECR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_004.ToString()))
            {
                sSQL = sSQL + TST_EOD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_004.ToString()))
            {
                sSQL = sSQL + TST_EAW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_004.ToString()))
            {
                sSQL = sSQL + TST_ED1_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_004.ToString()))
            {
                sSQL = sSQL + TST_ED2_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_005))
            {
                sSQL = sSQL + "'" + TST_VW2_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_005))
            {
                sSQL = sSQL + "'" + TST_EGM_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_005))
            {
                sSQL = sSQL + "'" + TST_DYY_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_005))
            {
                sSQL = sSQL + "'" + TST_2WX_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_005))
            {
                sSQL = sSQL + "'" + TST_3W3_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_005))
            {
                sSQL = sSQL + "'" + TST_4W4_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_005))
            {
                sSQL = sSQL + "'" + TST_AGL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_005))
            {
                sSQL = sSQL + "'" + TST_TUP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_005))
            {
                sSQL = sSQL + "'" + TST_VEO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_005))
            {
                sSQL = sSQL + "'" + TST_T1T_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_005))
            {
                sSQL = sSQL + "'" + TST_T1C_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_005))
            {
                sSQL = sSQL + "'" + TST_T1L_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_005))
            {
                sSQL = sSQL + "'" + TST_T2F_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_005))
            {
                sSQL = sSQL + "'" + TST_SVE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_005))
            {
                sSQL = sSQL + "'" + TST_STF_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_005))
            {
                sSQL = sSQL + "'" + TST_STM_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_005))
            {
                sSQL = sSQL + "'" + TST_SCE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_005))
            {
                sSQL = sSQL + "'" + TST_SCO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_005))
            {
                sSQL = sSQL + "'" + TST_SCH_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_005))
            {
                sSQL = sSQL + "'" + TST_SCG_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_005))
            {
                sSQL = sSQL + "'" + TST_SEE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_005))
            {
                sSQL = sSQL + "'" + TST_SEO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_005))
            {
                sSQL = sSQL + "'" + TST_SEH_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_005))
            {
                sSQL = sSQL + "'" + TST_SEG_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_005))
            {
                sSQL = sSQL + "'" + TST_SJC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_005))
            {
                sSQL = sSQL + "'" + TST_SJT_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_005))
            {
                sSQL = sSQL + "'" + TST_SJB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_005))
            {
                sSQL = sSQL + "'" + TST_SPJ_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_005))
            {
                sSQL = sSQL + "'" + TST_SBC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_005))
            {
                sSQL = sSQL + "'" + TST_SPO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_005))
            {
                sSQL = sSQL + "'" + TST_SVA_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_005))
            {
                sSQL = sSQL + "'" + TST_TGR_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_005))
            {
                sSQL = sSQL + "'" + TST_TIP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_005))
            {
                sSQL = sSQL + "'" + TST_DSB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_005))
            {
                sSQL = sSQL + "'" + TST_TCA_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_005))
            {
                sSQL = sSQL + "'" + TST_FMC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_005))
            {
                sSQL = sSQL + "'" + TST_1TB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_005))
            {
                sSQL = sSQL + "'" + TST_1PP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_005))
            {
                sSQL = sSQL + "'" + TST_2TB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_005))
            {
                sSQL = sSQL + "'" + TST_2PP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_005))
            {
                sSQL = sSQL + "'" + TST_P1C_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_005))
            {
                sSQL = sSQL + "'" + TST_P2D_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_005))
            {
                sSQL = sSQL + "'" + TST_P3D_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_005))
            {
                sSQL = sSQL + "'" + TST_P4U_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_005))
            {
                sSQL = sSQL + "'" + TST_MOL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_005))
            {
                sSQL = sSQL + "'" + TST_TPD_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_005))
            {
                sSQL = sSQL + "'" + TST_TT1_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_005))
            {
                sSQL = sSQL + "'" + TST_TT2_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_005))
            {
                sSQL = sSQL + "'" + TST_TT3_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_005))
            {
                sSQL = sSQL + "'" + TST_T21_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_005))
            {
                sSQL = sSQL + "'" + TST_TUN_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_005))
            {
                sSQL = sSQL + "'" + TST_TCV_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_005))
            {
                sSQL = sSQL + "'" + TST_TSS_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_005.ToString()))
            {
                sSQL = sSQL + TST_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_005.ToString()))
            {
                sSQL = sSQL + TST_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_005.ToString()))
            {
                sSQL = sSQL + TST_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_005.ToString()))
            {
                sSQL = sSQL + TST_ENM_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_005.ToString()))
            {
                sSQL = sSQL + TST_EEE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_005.ToString()))
            {
                sSQL = sSQL + TST_KKK_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_005.ToString()))
            {
                sSQL = sSQL + TST_BBB_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_005.ToString()))
            {
                sSQL = sSQL + TST_OLE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_005.ToString()))
            {
                sSQL = sSQL + TST_TRQ_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_005.ToString()))
            {
                sSQL = sSQL + TST_ERT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_005.ToString()))
            {
                sSQL = sSQL + TST_RT3_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_005.ToString()))
            {
                sSQL = sSQL + TST_RT5_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_005.ToString()))
            {
                sSQL = sSQL + TST_DND_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_005.ToString()))
            {
                sSQL = sSQL + TST_DMO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_005.ToString()))
            {
                sSQL = sSQL + TST_PES_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_005))
            {
                sSQL = sSQL + "'" + TST_VRR_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_005))
            {
                sSQL = sSQL + "'" + TST_TRE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_005.ToString()))
            {
                sSQL = sSQL + TST_LME_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_005.ToString()))
            {
                sSQL = sSQL + TST_UME_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_005.ToString()))
            {
                sSQL = sSQL + TST_LPE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_005.ToString()))
            {
                sSQL = sSQL + TST_UPE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_005.ToString()))
            {
                sSQL = sSQL + TST_UCV_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_005.ToString()))
            {
                sSQL = sSQL + TST_CSO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_005.ToString()))
            {
                sSQL = sSQL + TST_ESP_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_005))
            {
                sSQL = sSQL + "'" + TST_TOL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_005.ToString()))
            {
                sSQL = sSQL + TST_DUR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_005.ToString()))
            {
                sSQL = sSQL + TST_DFT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_005.ToString()))
            {
                sSQL = sSQL + TST_LMC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_005.ToString()))
            {
                sSQL = sSQL + TST_UMC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_005.ToString()))
            {
                sSQL = sSQL + TST_LPC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_005.ToString()))
            {
                sSQL = sSQL + TST_UPC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_005.ToString()))
            {
                sSQL = sSQL + TST_CVC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_005.ToString()))
            {
                sSQL = sSQL + TST_DFC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_005.ToString()))
            {
                sSQL = sSQL + TST_TFS_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_005.ToString()))
            {
                sSQL = sSQL + TST_FSW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_005.ToString()))
            {
                sSQL = sSQL + TST_WFW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_005.ToString()))
            {
                sSQL = sSQL + TST_ECO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_005.ToString()))
            {
                sSQL = sSQL + TST_EOL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_005.ToString()))
            {
                sSQL = sSQL + TST_ETU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_005.ToString()))
            {
                sSQL = sSQL + TST_ETD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_005.ToString()))
            {
                sSQL = sSQL + TST_ECU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_005.ToString()))
            {
                sSQL = sSQL + TST_EGD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_005.ToString()))
            {
                sSQL = sSQL + TST_EEC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_005.ToString()))
            {
                sSQL = sSQL + TST_ECD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_005.ToString()))
            {
                sSQL = sSQL + TST_EGU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_005.ToString()))
            {
                sSQL = sSQL + TST_ESO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_005.ToString()))
            {
                sSQL = sSQL + TST_ESI_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_005.ToString()))
            {
                sSQL = sSQL + TST_ECR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_005.ToString()))
            {
                sSQL = sSQL + TST_EOD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_005.ToString()))
            {
                sSQL = sSQL + TST_EAW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_005.ToString()))
            {
                sSQL = sSQL + TST_ED1_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_005.ToString()))
            {
                sSQL = sSQL + TST_ED2_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_006))
            {
                sSQL = sSQL + "'" + TST_VW2_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_006))
            {
                sSQL = sSQL + "'" + TST_EGM_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_006))
            {
                sSQL = sSQL + "'" + TST_DYY_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_006))
            {
                sSQL = sSQL + "'" + TST_2WX_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_006))
            {
                sSQL = sSQL + "'" + TST_3W3_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_006))
            {
                sSQL = sSQL + "'" + TST_4W4_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_006))
            {
                sSQL = sSQL + "'" + TST_AGL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_006))
            {
                sSQL = sSQL + "'" + TST_TUP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_006))
            {
                sSQL = sSQL + "'" + TST_VEO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_006))
            {
                sSQL = sSQL + "'" + TST_T1T_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_006))
            {
                sSQL = sSQL + "'" + TST_T1C_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_006))
            {
                sSQL = sSQL + "'" + TST_T1L_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_006))
            {
                sSQL = sSQL + "'" + TST_T2F_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_006))
            {
                sSQL = sSQL + "'" + TST_SVE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_006))
            {
                sSQL = sSQL + "'" + TST_STF_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_006))
            {
                sSQL = sSQL + "'" + TST_STM_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_006))
            {
                sSQL = sSQL + "'" + TST_SCE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_006))
            {
                sSQL = sSQL + "'" + TST_SCO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_006))
            {
                sSQL = sSQL + "'" + TST_SCH_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_006))
            {
                sSQL = sSQL + "'" + TST_SCG_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_006))
            {
                sSQL = sSQL + "'" + TST_SEE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_006))
            {
                sSQL = sSQL + "'" + TST_SEO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_006))
            {
                sSQL = sSQL + "'" + TST_SEH_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_006))
            {
                sSQL = sSQL + "'" + TST_SEG_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_006))
            {
                sSQL = sSQL + "'" + TST_SJC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_006))
            {
                sSQL = sSQL + "'" + TST_SJT_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_006))
            {
                sSQL = sSQL + "'" + TST_SJB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_006))
            {
                sSQL = sSQL + "'" + TST_SPJ_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_006))
            {
                sSQL = sSQL + "'" + TST_SBC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_006))
            {
                sSQL = sSQL + "'" + TST_SPO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_006))
            {
                sSQL = sSQL + "'" + TST_SVA_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_006))
            {
                sSQL = sSQL + "'" + TST_TGR_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_006))
            {
                sSQL = sSQL + "'" + TST_TIP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_006))
            {
                sSQL = sSQL + "'" + TST_DSB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_006))
            {
                sSQL = sSQL + "'" + TST_TCA_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_006))
            {
                sSQL = sSQL + "'" + TST_FMC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_006))
            {
                sSQL = sSQL + "'" + TST_1TB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_006))
            {
                sSQL = sSQL + "'" + TST_1PP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_006))
            {
                sSQL = sSQL + "'" + TST_2TB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_006))
            {
                sSQL = sSQL + "'" + TST_2PP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_006))
            {
                sSQL = sSQL + "'" + TST_P1C_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_006))
            {
                sSQL = sSQL + "'" + TST_P2D_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_006))
            {
                sSQL = sSQL + "'" + TST_P3D_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_006))
            {
                sSQL = sSQL + "'" + TST_P4U_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_006))
            {
                sSQL = sSQL + "'" + TST_MOL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_006))
            {
                sSQL = sSQL + "'" + TST_TPD_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_006))
            {
                sSQL = sSQL + "'" + TST_TT1_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_006))
            {
                sSQL = sSQL + "'" + TST_TT2_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_006))
            {
                sSQL = sSQL + "'" + TST_TT3_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_006))
            {
                sSQL = sSQL + "'" + TST_T21_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_006))
            {
                sSQL = sSQL + "'" + TST_TUN_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_006))
            {
                sSQL = sSQL + "'" + TST_TCV_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_006))
            {
                sSQL = sSQL + "'" + TST_TSS_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_006.ToString()))
            {
                sSQL = sSQL + TST_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_006.ToString()))
            {
                sSQL = sSQL + TST_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_006.ToString()))
            {
                sSQL = sSQL + TST_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_006.ToString()))
            {
                sSQL = sSQL + TST_ENM_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_006.ToString()))
            {
                sSQL = sSQL + TST_EEE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_006.ToString()))
            {
                sSQL = sSQL + TST_KKK_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_006.ToString()))
            {
                sSQL = sSQL + TST_BBB_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_006.ToString()))
            {
                sSQL = sSQL + TST_OLE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_006.ToString()))
            {
                sSQL = sSQL + TST_TRQ_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_006.ToString()))
            {
                sSQL = sSQL + TST_ERT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_006.ToString()))
            {
                sSQL = sSQL + TST_RT3_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_006.ToString()))
            {
                sSQL = sSQL + TST_RT5_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_006.ToString()))
            {
                sSQL = sSQL + TST_DND_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_006.ToString()))
            {
                sSQL = sSQL + TST_DMO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_006.ToString()))
            {
                sSQL = sSQL + TST_PES_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_006))
            {
                sSQL = sSQL + "'" + TST_VRR_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_006))
            {
                sSQL = sSQL + "'" + TST_TRE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_006.ToString()))
            {
                sSQL = sSQL + TST_LME_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_006.ToString()))
            {
                sSQL = sSQL + TST_UME_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_006.ToString()))
            {
                sSQL = sSQL + TST_LPE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_006.ToString()))
            {
                sSQL = sSQL + TST_UPE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_006.ToString()))
            {
                sSQL = sSQL + TST_UCV_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_006.ToString()))
            {
                sSQL = sSQL + TST_CSO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_006.ToString()))
            {
                sSQL = sSQL + TST_ESP_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_006))
            {
                sSQL = sSQL + "'" + TST_TOL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_006.ToString()))
            {
                sSQL = sSQL + TST_DUR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_006.ToString()))
            {
                sSQL = sSQL + TST_DFT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_006.ToString()))
            {
                sSQL = sSQL + TST_LMC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_006.ToString()))
            {
                sSQL = sSQL + TST_UMC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_006.ToString()))
            {
                sSQL = sSQL + TST_LPC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_006.ToString()))
            {
                sSQL = sSQL + TST_UPC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_006.ToString()))
            {
                sSQL = sSQL + TST_CVC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_006.ToString()))
            {
                sSQL = sSQL + TST_DFC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_006.ToString()))
            {
                sSQL = sSQL + TST_TFS_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_006.ToString()))
            {
                sSQL = sSQL + TST_FSW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_006.ToString()))
            {
                sSQL = sSQL + TST_WFW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_006.ToString()))
            {
                sSQL = sSQL + TST_ECO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_006.ToString()))
            {
                sSQL = sSQL + TST_EOL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_006.ToString()))
            {
                sSQL = sSQL + TST_ETU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_006.ToString()))
            {
                sSQL = sSQL + TST_ETD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_006.ToString()))
            {
                sSQL = sSQL + TST_ECU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_006.ToString()))
            {
                sSQL = sSQL + TST_EGD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_006.ToString()))
            {
                sSQL = sSQL + TST_EEC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_006.ToString()))
            {
                sSQL = sSQL + TST_ECD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_006.ToString()))
            {
                sSQL = sSQL + TST_EGU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_006.ToString()))
            {
                sSQL = sSQL + TST_ESO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_006.ToString()))
            {
                sSQL = sSQL + TST_ESI_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_006.ToString()))
            {
                sSQL = sSQL + TST_ECR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_006.ToString()))
            {
                sSQL = sSQL + TST_EOD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_006.ToString()))
            {
                sSQL = sSQL + TST_EAW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_006.ToString()))
            {
                sSQL = sSQL + TST_ED1_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_006.ToString()))
            {
                sSQL = sSQL + TST_ED2_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_007))
            {
                sSQL = sSQL + "'" + TST_VW2_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_007))
            {
                sSQL = sSQL + "'" + TST_EGM_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_007))
            {
                sSQL = sSQL + "'" + TST_DYY_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_007))
            {
                sSQL = sSQL + "'" + TST_2WX_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_007))
            {
                sSQL = sSQL + "'" + TST_3W3_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_007))
            {
                sSQL = sSQL + "'" + TST_4W4_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_007))
            {
                sSQL = sSQL + "'" + TST_AGL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_007))
            {
                sSQL = sSQL + "'" + TST_TUP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_007))
            {
                sSQL = sSQL + "'" + TST_VEO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_007))
            {
                sSQL = sSQL + "'" + TST_T1T_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_007))
            {
                sSQL = sSQL + "'" + TST_T1C_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_007))
            {
                sSQL = sSQL + "'" + TST_T1L_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_007))
            {
                sSQL = sSQL + "'" + TST_T2F_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_007))
            {
                sSQL = sSQL + "'" + TST_SVE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_007))
            {
                sSQL = sSQL + "'" + TST_STF_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_007))
            {
                sSQL = sSQL + "'" + TST_STM_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_007))
            {
                sSQL = sSQL + "'" + TST_SCE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_007))
            {
                sSQL = sSQL + "'" + TST_SCO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_007))
            {
                sSQL = sSQL + "'" + TST_SCH_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_007))
            {
                sSQL = sSQL + "'" + TST_SCG_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_007))
            {
                sSQL = sSQL + "'" + TST_SEE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_007))
            {
                sSQL = sSQL + "'" + TST_SEO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_007))
            {
                sSQL = sSQL + "'" + TST_SEH_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_007))
            {
                sSQL = sSQL + "'" + TST_SEG_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_007))
            {
                sSQL = sSQL + "'" + TST_SJC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_007))
            {
                sSQL = sSQL + "'" + TST_SJT_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_007))
            {
                sSQL = sSQL + "'" + TST_SJB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_007))
            {
                sSQL = sSQL + "'" + TST_SPJ_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_007))
            {
                sSQL = sSQL + "'" + TST_SBC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_007))
            {
                sSQL = sSQL + "'" + TST_SPO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_007))
            {
                sSQL = sSQL + "'" + TST_SVA_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_007))
            {
                sSQL = sSQL + "'" + TST_TGR_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_007))
            {
                sSQL = sSQL + "'" + TST_TIP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_007))
            {
                sSQL = sSQL + "'" + TST_DSB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_007))
            {
                sSQL = sSQL + "'" + TST_TCA_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_007))
            {
                sSQL = sSQL + "'" + TST_FMC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_007))
            {
                sSQL = sSQL + "'" + TST_1TB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_007))
            {
                sSQL = sSQL + "'" + TST_1PP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_007))
            {
                sSQL = sSQL + "'" + TST_2TB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_007))
            {
                sSQL = sSQL + "'" + TST_2PP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_007))
            {
                sSQL = sSQL + "'" + TST_P1C_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_007))
            {
                sSQL = sSQL + "'" + TST_P2D_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_007))
            {
                sSQL = sSQL + "'" + TST_P3D_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_007))
            {
                sSQL = sSQL + "'" + TST_P4U_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_007))
            {
                sSQL = sSQL + "'" + TST_MOL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_007))
            {
                sSQL = sSQL + "'" + TST_TPD_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_007))
            {
                sSQL = sSQL + "'" + TST_TT1_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_007))
            {
                sSQL = sSQL + "'" + TST_TT2_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_007))
            {
                sSQL = sSQL + "'" + TST_TT3_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_007))
            {
                sSQL = sSQL + "'" + TST_T21_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_007))
            {
                sSQL = sSQL + "'" + TST_TUN_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_007))
            {
                sSQL = sSQL + "'" + TST_TCV_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_007))
            {
                sSQL = sSQL + "'" + TST_TSS_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_007.ToString()))
            {
                sSQL = sSQL + TST_TIT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_007.ToString()))
            {
                sSQL = sSQL + TST_TNC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_007.ToString()))
            {
                sSQL = sSQL + TST_AON_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_007.ToString()))
            {
                sSQL = sSQL + TST_ENM_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_007.ToString()))
            {
                sSQL = sSQL + TST_EEE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_007.ToString()))
            {
                sSQL = sSQL + TST_KKK_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_007.ToString()))
            {
                sSQL = sSQL + TST_BBB_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_007.ToString()))
            {
                sSQL = sSQL + TST_OLE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_007.ToString()))
            {
                sSQL = sSQL + TST_TRQ_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_007.ToString()))
            {
                sSQL = sSQL + TST_ERT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_007.ToString()))
            {
                sSQL = sSQL + TST_RT3_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_007.ToString()))
            {
                sSQL = sSQL + TST_RT5_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_007.ToString()))
            {
                sSQL = sSQL + TST_DND_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_007.ToString()))
            {
                sSQL = sSQL + TST_DMO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_007.ToString()))
            {
                sSQL = sSQL + TST_PES_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_007))
            {
                sSQL = sSQL + "'" + TST_VRR_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_007))
            {
                sSQL = sSQL + "'" + TST_TRE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_007.ToString()))
            {
                sSQL = sSQL + TST_LME_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_007.ToString()))
            {
                sSQL = sSQL + TST_UME_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_007.ToString()))
            {
                sSQL = sSQL + TST_LPE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_007.ToString()))
            {
                sSQL = sSQL + TST_UPE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_007.ToString()))
            {
                sSQL = sSQL + TST_UCV_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_007.ToString()))
            {
                sSQL = sSQL + TST_CSO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_007.ToString()))
            {
                sSQL = sSQL + TST_ESP_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_007))
            {
                sSQL = sSQL + "'" + TST_TOL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_007.ToString()))
            {
                sSQL = sSQL + TST_DUR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_007.ToString()))
            {
                sSQL = sSQL + TST_DFT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_007.ToString()))
            {
                sSQL = sSQL + TST_LMC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_007.ToString()))
            {
                sSQL = sSQL + TST_UMC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_007.ToString()))
            {
                sSQL = sSQL + TST_LPC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_007.ToString()))
            {
                sSQL = sSQL + TST_UPC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_007.ToString()))
            {
                sSQL = sSQL + TST_CVC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_007.ToString()))
            {
                sSQL = sSQL + TST_DFC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_007.ToString()))
            {
                sSQL = sSQL + TST_TFS_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_007.ToString()))
            {
                sSQL = sSQL + TST_FSW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_007.ToString()))
            {
                sSQL = sSQL + TST_WFW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_007.ToString()))
            {
                sSQL = sSQL + TST_ECO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_007.ToString()))
            {
                sSQL = sSQL + TST_EOL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_007.ToString()))
            {
                sSQL = sSQL + TST_ETU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_007.ToString()))
            {
                sSQL = sSQL + TST_ETD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_007.ToString()))
            {
                sSQL = sSQL + TST_ECU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_007.ToString()))
            {
                sSQL = sSQL + TST_EGD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_007.ToString()))
            {
                sSQL = sSQL + TST_EEC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_007.ToString()))
            {
                sSQL = sSQL + TST_ECD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_007.ToString()))
            {
                sSQL = sSQL + TST_EGU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_007.ToString()))
            {
                sSQL = sSQL + TST_ESO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_007.ToString()))
            {
                sSQL = sSQL + TST_ESI_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_007.ToString()))
            {
                sSQL = sSQL + TST_ECR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_007.ToString()))
            {
                sSQL = sSQL + TST_EOD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_007.ToString()))
            {
                sSQL = sSQL + TST_EAW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_007.ToString()))
            {
                sSQL = sSQL + TST_ED1_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_007.ToString()))
            {
                sSQL = sSQL + TST_ED2_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_REF.ToString()))
            {
                sSQL = sSQL + TST_PCO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_REF.ToString()))
            {
                sSQL = sSQL + TST_PCV_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_REF.ToString()))
            {
                sSQL = sSQL + TST_DRT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_REF.ToString()))
            {
                sSQL = sSQL + TST_TAL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_REF.ToString()))
            {
                sSQL = sSQL + TST_VAL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_REF.ToString()))
            {
                sSQL = sSQL + TST_SJE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_001.ToString()))
            {
                sSQL = sSQL + TST_PCO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_001.ToString()))
            {
                sSQL = sSQL + TST_PCV_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_001.ToString()))
            {
                sSQL = sSQL + TST_DRT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_001.ToString()))
            {
                sSQL = sSQL + TST_TAL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_001.ToString()))
            {
                sSQL = sSQL + TST_VAL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_001.ToString()))
            {
                sSQL = sSQL + TST_SJE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_002.ToString()))
            {
                sSQL = sSQL + TST_PCO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_002.ToString()))
            {
                sSQL = sSQL + TST_PCV_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_002.ToString()))
            {
                sSQL = sSQL + TST_DRT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_002.ToString()))
            {
                sSQL = sSQL + TST_TAL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_002.ToString()))
            {
                sSQL = sSQL + TST_VAL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_002.ToString()))
            {
                sSQL = sSQL + TST_SJE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_003.ToString()))
            {
                sSQL = sSQL + TST_PCO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_003.ToString()))
            {
                sSQL = sSQL + TST_PCV_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_003.ToString()))
            {
                sSQL = sSQL + TST_DRT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_003.ToString()))
            {
                sSQL = sSQL + TST_TAL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_003.ToString()))
            {
                sSQL = sSQL + TST_VAL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_003.ToString()))
            {
                sSQL = sSQL + TST_SJE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_004.ToString()))
            {
                sSQL = sSQL + TST_PCO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_004.ToString()))
            {
                sSQL = sSQL + TST_PCV_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_004.ToString()))
            {
                sSQL = sSQL + TST_DRT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_004.ToString()))
            {
                sSQL = sSQL + TST_TAL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_004.ToString()))
            {
                sSQL = sSQL + TST_VAL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_004.ToString()))
            {
                sSQL = sSQL + TST_SJE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_005.ToString()))
            {
                sSQL = sSQL + TST_PCO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_005.ToString()))
            {
                sSQL = sSQL + TST_PCV_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_005.ToString()))
            {
                sSQL = sSQL + TST_DRT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_005.ToString()))
            {
                sSQL = sSQL + TST_TAL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_005.ToString()))
            {
                sSQL = sSQL + TST_VAL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_005.ToString()))
            {
                sSQL = sSQL + TST_SJE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_006.ToString()))
            {
                sSQL = sSQL + TST_PCO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_006.ToString()))
            {
                sSQL = sSQL + TST_PCV_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_006.ToString()))
            {
                sSQL = sSQL + TST_DRT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_006.ToString()))
            {
                sSQL = sSQL + TST_TAL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_006.ToString()))
            {
                sSQL = sSQL + TST_VAL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_006.ToString()))
            {
                sSQL = sSQL + TST_SJE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_007.ToString()))
            {
                sSQL = sSQL + TST_PCO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_007.ToString()))
            {
                sSQL = sSQL + TST_PCV_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_007.ToString()))
            {
                sSQL = sSQL + TST_DRT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_007.ToString()))
            {
                sSQL = sSQL + TST_TAL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_007.ToString()))
            {
                sSQL = sSQL + TST_VAL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_007.ToString()))
            {
                sSQL = sSQL + TST_SJE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DET))
            {
                sSQL = sSQL + "'" + TST_DET.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OBS))
            {
                sSQL = sSQL + "'" + TST_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STS.ToString()))
            {
                sSQL = sSQL + TST_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + TST_USR_INC_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            sSQL = sSQL + "GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + ") ";

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Alterar()
        {
            string sSQL = "UPDATE TST ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(TST_RTS_ID.ToString()))
            {
                sSQL = sSQL + "TST_RTS_ID = " + TST_RTS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RTS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RTS_MTV_TST_ID.ToString()))
            {
                sSQL = sSQL + "TST_RTS_MTV_TST_ID = " + TST_RTS_MTV_TST_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RTS_MTV_TST_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT))
            {
                sSQL = sSQL + "TST_LOT = '" + TST_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_REF))
            {
                sSQL = sSQL + "TST_LOT_REF = '" + TST_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_LOT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_EPF))
            {
                sSQL = sSQL + "TST_LOT_EPF = '" + TST_LOT_EPF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_LOT_EPF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LOT_ANS))
            {
                sSQL = sSQL + "TST_LOT_ANS = '" + TST_LOT_ANS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_LOT_ANS = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "TST_TIT_POY_ID = " + TST_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DES))
            {
                sSQL = sSQL + "TST_DES = '" + TST_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE))
            {
                sSQL = sSQL + "TST_MGE = '" + TST_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_002))
            {
                sSQL = sSQL + "TST_MGE_002 = '" + TST_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_003))
            {
                sSQL = sSQL + "TST_MGE_003 = '" + TST_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_REF))
            {
                sSQL = sSQL + "TST_MGE_REF = '" + TST_MGE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_002_REF))
            {
                sSQL = sSQL + "TST_MGE_002_REF = '" + TST_MGE_002_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE_002_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MGE_003_REF))
            {
                sSQL = sSQL + "TST_MGE_003_REF = '" + TST_MGE_003_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MGE_003_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_001_ID.ToString()))
            {
                sSQL = sSQL + "TST_FOR_001_ID = " + TST_FOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FOR_001_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + "TST_FOR_002_ID = " + TST_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FOR_002_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + "TST_FOR_003_ID = " + TST_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FOR_003_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VLC))
            {
                sSQL = sSQL + "TST_VLC = '" + TST_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_APS_ID.ToString()))
            {
                sSQL = sSQL + "TST_APS_ID = " + TST_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_APS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "TST_MAQ_TIP_ID = " + TST_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_ID.ToString()))
            {
                sSQL = sSQL + "TST_ERT_ID = " + TST_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DAT_INI.ToString()))
            {
                sSQL = sSQL + "TST_DAT_INI = Convert(datetime, '" + TST_DAT_INI + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "TST_DAT_INI = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DAT_FIM.ToString()))
            {
                sSQL = sSQL + "TST_DAT_FIM = Convert(datetime, '" + TST_DAT_FIM + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "TST_DAT_FIM = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_REF))
            {
                sSQL = sSQL + "TST_VW2_REF = '" + TST_VW2_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_REF))
            {
                sSQL = sSQL + "TST_EGM_REF = '" + TST_EGM_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_REF))
            {
                sSQL = sSQL + "TST_DYY_REF = '" + TST_DYY_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_REF))
            {
                sSQL = sSQL + "TST_2WX_REF = '" + TST_2WX_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_REF))
            {
                sSQL = sSQL + "TST_3W3_REF = '" + TST_3W3_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_REF))
            {
                sSQL = sSQL + "TST_4W4_REF = '" + TST_4W4_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_REF))
            {
                sSQL = sSQL + "TST_AGL_REF = '" + TST_AGL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_REF))
            {
                sSQL = sSQL + "TST_TUP_REF = '" + TST_TUP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_REF))
            {
                sSQL = sSQL + "TST_VEO_REF = '" + TST_VEO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_REF))
            {
                sSQL = sSQL + "TST_T1T_REF = '" + TST_T1T_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_REF))
            {
                sSQL = sSQL + "TST_T1C_REF = '" + TST_T1C_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_REF))
            {
                sSQL = sSQL + "TST_T1L_REF = '" + TST_T1L_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_REF))
            {
                sSQL = sSQL + "TST_T2F_REF = '" + TST_T2F_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_REF))
            {
                sSQL = sSQL + "TST_SVE_REF = '" + TST_SVE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_REF))
            {
                sSQL = sSQL + "TST_STF_REF = '" + TST_STF_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_REF))
            {
                sSQL = sSQL + "TST_STM_REF = '" + TST_STM_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_REF))
            {
                sSQL = sSQL + "TST_SCE_REF = '" + TST_SCE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_REF))
            {
                sSQL = sSQL + "TST_SCO_REF = '" + TST_SCO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_REF))
            {
                sSQL = sSQL + "TST_SCH_REF = '" + TST_SCH_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_REF))
            {
                sSQL = sSQL + "TST_SCG_REF = '" + TST_SCG_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_REF))
            {
                sSQL = sSQL + "TST_SEE_REF = '" + TST_SEE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_REF))
            {
                sSQL = sSQL + "TST_SEO_REF = '" + TST_SEO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_REF))
            {
                sSQL = sSQL + "TST_SEH_REF = '" + TST_SEH_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_REF))
            {
                sSQL = sSQL + "TST_SEG_REF = '" + TST_SEG_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_REF))
            {
                sSQL = sSQL + "TST_SJC_REF = '" + TST_SJC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_REF))
            {
                sSQL = sSQL + "TST_SJT_REF = '" + TST_SJT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_REF))
            {
                sSQL = sSQL + "TST_SJB_REF = '" + TST_SJB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_REF))
            {
                sSQL = sSQL + "TST_SPJ_REF = '" + TST_SPJ_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_REF))
            {
                sSQL = sSQL + "TST_SBC_REF = '" + TST_SBC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_REF))
            {
                sSQL = sSQL + "TST_SPO_REF = '" + TST_SPO_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_REF))
            {
                sSQL = sSQL + "TST_SVA_REF = '" + TST_SVA_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_REF))
            {
                sSQL = sSQL + "TST_TGR_REF = '" + TST_TGR_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_REF))
            {
                sSQL = sSQL + "TST_TIP_REF = '" + TST_TIP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_REF))
            {
                sSQL = sSQL + "TST_DSB_REF = '" + TST_DSB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_REF))
            {
                sSQL = sSQL + "TST_TCA_REF = '" + TST_TCA_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_REF))
            {
                sSQL = sSQL + "TST_FMC_REF = '" + TST_FMC_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_REF))
            {
                sSQL = sSQL + "TST_1TB_REF = '" + TST_1TB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_REF))
            {
                sSQL = sSQL + "TST_1PP_REF = '" + TST_1PP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_REF))
            {
                sSQL = sSQL + "TST_2TB_REF = '" + TST_2TB_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_REF))
            {
                sSQL = sSQL + "TST_2PP_REF = '" + TST_2PP_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_REF))
            {
                sSQL = sSQL + "TST_P1C_REF = '" + TST_P1C_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_REF))
            {
                sSQL = sSQL + "TST_P2D_REF = '" + TST_P2D_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_REF))
            {
                sSQL = sSQL + "TST_P3D_REF = '" + TST_P3D_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_REF))
            {
                sSQL = sSQL + "TST_P4U_REF = '" + TST_P4U_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_REF))
            {
                sSQL = sSQL + "TST_MOL_REF = '" + TST_MOL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_REF))
            {
                sSQL = sSQL + "TST_TPD_REF = '" + TST_TPD_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_REF))
            {
                sSQL = sSQL + "TST_TT1_REF = '" + TST_TT1_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_REF))
            {
                sSQL = sSQL + "TST_TT2_REF = '" + TST_TT2_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_REF))
            {
                sSQL = sSQL + "TST_TT3_REF = '" + TST_TT3_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_REF))
            {
                sSQL = sSQL + "TST_T21_REF = '" + TST_T21_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_REF))
            {
                sSQL = sSQL + "TST_TUN_REF = '" + TST_TUN_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_REF))
            {
                sSQL = sSQL + "TST_TCV_REF = '" + TST_TCV_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_REF))
            {
                sSQL = sSQL + "TST_TSS_REF = '" + TST_TSS_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_REF.ToString()))
            {
                sSQL = sSQL + "TST_TIT_REF = " + TST_TIT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_REF.ToString()))
            {
                sSQL = sSQL + "TST_TNC_REF = " + TST_TNC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_REF.ToString()))
            {
                sSQL = sSQL + "TST_AON_REF = " + TST_AON_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_REF.ToString()))
            {
                sSQL = sSQL + "TST_ENM_REF = " + TST_ENM_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_REF.ToString()))
            {
                sSQL = sSQL + "TST_EEE_REF = " + TST_EEE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_REF.ToString()))
            {
                sSQL = sSQL + "TST_KKK_REF = " + TST_KKK_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_REF.ToString()))
            {
                sSQL = sSQL + "TST_BBB_REF = " + TST_BBB_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_REF.ToString()))
            {
                sSQL = sSQL + "TST_OLE_REF = " + TST_OLE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_REF.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_REF = " + TST_TRQ_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_REF.ToString()))
            {
                sSQL = sSQL + "TST_ERT_REF = " + TST_ERT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_REF.ToString()))
            {
                sSQL = sSQL + "TST_RT3_REF = " + TST_RT3_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_REF.ToString()))
            {
                sSQL = sSQL + "TST_RT5_REF = " + TST_RT5_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_REF.ToString()))
            {
                sSQL = sSQL + "TST_DND_REF = " + TST_DND_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_REF.ToString()))
            {
                sSQL = sSQL + "TST_DMO_REF = " + TST_DMO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_REF.ToString()))
            {
                sSQL = sSQL + "TST_PES_REF = " + TST_PES_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_REF))
            {
                sSQL = sSQL + "TST_VRR_REF = '" + TST_VRR_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_REF))
            {
                sSQL = sSQL + "TST_TRE_REF = '" + TST_TRE_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_REF.ToString()))
            {
                sSQL = sSQL + "TST_LME_REF = " + TST_LME_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_REF.ToString()))
            {
                sSQL = sSQL + "TST_UME_REF = " + TST_UME_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_REF.ToString()))
            {
                sSQL = sSQL + "TST_LPE_REF = " + TST_LPE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_REF.ToString()))
            {
                sSQL = sSQL + "TST_UPE_REF = " + TST_UPE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_REF.ToString()))
            {
                sSQL = sSQL + "TST_UCV_REF = " + TST_UCV_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_REF.ToString()))
            {
                sSQL = sSQL + "TST_CSO_REF = " + TST_CSO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_REF.ToString()))
            {
                sSQL = sSQL + "TST_ESP_REF = " + TST_ESP_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_REF))
            {
                sSQL = sSQL + "TST_TOL_REF = '" + TST_TOL_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_REF.ToString()))
            {
                sSQL = sSQL + "TST_DUR_REF = " + TST_DUR_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_REF.ToString()))
            {
                sSQL = sSQL + "TST_DFT_REF = " + TST_DFT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_REF.ToString()))
            {
                sSQL = sSQL + "TST_LMC_REF = " + TST_LMC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_REF.ToString()))
            {
                sSQL = sSQL + "TST_UMC_REF = " + TST_UMC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_REF.ToString()))
            {
                sSQL = sSQL + "TST_LPC_REF = " + TST_LPC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_REF.ToString()))
            {
                sSQL = sSQL + "TST_UPC_REF = " + TST_UPC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_REF.ToString()))
            {
                sSQL = sSQL + "TST_CVC_REF = " + TST_CVC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_REF.ToString()))
            {
                sSQL = sSQL + "TST_DFC_REF = " + TST_DFC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_REF.ToString()))
            {
                sSQL = sSQL + "TST_TFS_REF = " + TST_TFS_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_REF.ToString()))
            {
                sSQL = sSQL + "TST_FSW_REF = " + TST_FSW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_REF.ToString()))
            {
                sSQL = sSQL + "TST_WFW_REF = " + TST_WFW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_REF.ToString()))
            {
                sSQL = sSQL + "TST_ECO_REF = " + TST_ECO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_REF.ToString()))
            {
                sSQL = sSQL + "TST_EOL_REF = " + TST_EOL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_REF.ToString()))
            {
                sSQL = sSQL + "TST_ETU_REF = " + TST_ETU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_REF.ToString()))
            {
                sSQL = sSQL + "TST_ETD_REF = " + TST_ETD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_REF.ToString()))
            {
                sSQL = sSQL + "TST_ECU_REF = " + TST_ECU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_REF.ToString()))
            {
                sSQL = sSQL + "TST_EGD_REF = " + TST_EGD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_REF.ToString()))
            {
                sSQL = sSQL + "TST_EEC_REF = " + TST_EEC_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_REF.ToString()))
            {
                sSQL = sSQL + "TST_ECD_REF = " + TST_ECD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_REF.ToString()))
            {
                sSQL = sSQL + "TST_EGU_REF = " + TST_EGU_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_REF.ToString()))
            {
                sSQL = sSQL + "TST_ESO_REF = " + TST_ESO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_REF.ToString()))
            {
                sSQL = sSQL + "TST_ESI_REF = " + TST_ESI_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_REF.ToString()))
            {
                sSQL = sSQL + "TST_ECR_REF = " + TST_ECR_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_REF.ToString()))
            {
                sSQL = sSQL + "TST_EOD_REF = " + TST_EOD_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_REF.ToString()))
            {
                sSQL = sSQL + "TST_EAW_REF = " + TST_EAW_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_REF.ToString()))
            {
                sSQL = sSQL + "TST_ED1_REF = " + TST_ED1_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_REF.ToString()))
            {
                sSQL = sSQL + "TST_ED2_REF = " + TST_ED2_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_001))
            {
                sSQL = sSQL + "TST_VW2_001 = '" + TST_VW2_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_001))
            {
                sSQL = sSQL + "TST_EGM_001 = '" + TST_EGM_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_001))
            {
                sSQL = sSQL + "TST_DYY_001 = '" + TST_DYY_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_001))
            {
                sSQL = sSQL + "TST_2WX_001 = '" + TST_2WX_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_001))
            {
                sSQL = sSQL + "TST_3W3_001 = '" + TST_3W3_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_001))
            {
                sSQL = sSQL + "TST_4W4_001 = '" + TST_4W4_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_001))
            {
                sSQL = sSQL + "TST_AGL_001 = '" + TST_AGL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_001))
            {
                sSQL = sSQL + "TST_TUP_001 = '" + TST_TUP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_001))
            {
                sSQL = sSQL + "TST_VEO_001 = '" + TST_VEO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_001))
            {
                sSQL = sSQL + "TST_T1T_001 = '" + TST_T1T_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_001))
            {
                sSQL = sSQL + "TST_T1C_001 = '" + TST_T1C_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_001))
            {
                sSQL = sSQL + "TST_T1L_001 = '" + TST_T1L_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_001))
            {
                sSQL = sSQL + "TST_T2F_001 = '" + TST_T2F_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_001))
            {
                sSQL = sSQL + "TST_SVE_001 = '" + TST_SVE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_001))
            {
                sSQL = sSQL + "TST_STF_001 = '" + TST_STF_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_001))
            {
                sSQL = sSQL + "TST_STM_001 = '" + TST_STM_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_001))
            {
                sSQL = sSQL + "TST_SCE_001 = '" + TST_SCE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_001))
            {
                sSQL = sSQL + "TST_SCO_001 = '" + TST_SCO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_001))
            {
                sSQL = sSQL + "TST_SCH_001 = '" + TST_SCH_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_001))
            {
                sSQL = sSQL + "TST_SCG_001 = '" + TST_SCG_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_001))
            {
                sSQL = sSQL + "TST_SEE_001 = '" + TST_SEE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_001))
            {
                sSQL = sSQL + "TST_SEO_001 = '" + TST_SEO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_001))
            {
                sSQL = sSQL + "TST_SEH_001 = '" + TST_SEH_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_001))
            {
                sSQL = sSQL + "TST_SEG_001 = '" + TST_SEG_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_001))
            {
                sSQL = sSQL + "TST_SJC_001 = '" + TST_SJC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_001))
            {
                sSQL = sSQL + "TST_SJT_001 = '" + TST_SJT_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_001))
            {
                sSQL = sSQL + "TST_SJB_001 = '" + TST_SJB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_001))
            {
                sSQL = sSQL + "TST_SPJ_001 = '" + TST_SPJ_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_001))
            {
                sSQL = sSQL + "TST_SBC_001 = '" + TST_SBC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_001))
            {
                sSQL = sSQL + "TST_SPO_001 = '" + TST_SPO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_001))
            {
                sSQL = sSQL + "TST_SVA_001 = '" + TST_SVA_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_001))
            {
                sSQL = sSQL + "TST_TGR_001 = '" + TST_TGR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_001))
            {
                sSQL = sSQL + "TST_TIP_001 = '" + TST_TIP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_001))
            {
                sSQL = sSQL + "TST_DSB_001 = '" + TST_DSB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_001))
            {
                sSQL = sSQL + "TST_TCA_001 = '" + TST_TCA_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_001))
            {
                sSQL = sSQL + "TST_FMC_001 = '" + TST_FMC_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_001))
            {
                sSQL = sSQL + "TST_1TB_001 = '" + TST_1TB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_001))
            {
                sSQL = sSQL + "TST_1PP_001 = '" + TST_1PP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_001))
            {
                sSQL = sSQL + "TST_2TB_001 = '" + TST_2TB_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_001))
            {
                sSQL = sSQL + "TST_2PP_001 = '" + TST_2PP_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_001))
            {
                sSQL = sSQL + "TST_P1C_001 = '" + TST_P1C_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_001))
            {
                sSQL = sSQL + "TST_P2D_001 = '" + TST_P2D_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_001))
            {
                sSQL = sSQL + "TST_P3D_001 = '" + TST_P3D_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_001))
            {
                sSQL = sSQL + "TST_P4U_001 = '" + TST_P4U_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_001))
            {
                sSQL = sSQL + "TST_MOL_001 = '" + TST_MOL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_001))
            {
                sSQL = sSQL + "TST_TPD_001 = '" + TST_TPD_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_001))
            {
                sSQL = sSQL + "TST_TT1_001 = '" + TST_TT1_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_001))
            {
                sSQL = sSQL + "TST_TT2_001 = '" + TST_TT2_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_001))
            {
                sSQL = sSQL + "TST_TT3_001 = '" + TST_TT3_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_001))
            {
                sSQL = sSQL + "TST_T21_001 = '" + TST_T21_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_001))
            {
                sSQL = sSQL + "TST_TUN_001 = '" + TST_TUN_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_001))
            {
                sSQL = sSQL + "TST_TCV_001 = '" + TST_TCV_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_001))
            {
                sSQL = sSQL + "TST_TSS_001 = '" + TST_TSS_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_001.ToString()))
            {
                sSQL = sSQL + "TST_TIT_001 = " + TST_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_001.ToString()))
            {
                sSQL = sSQL + "TST_TNC_001 = " + TST_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_001.ToString()))
            {
                sSQL = sSQL + "TST_AON_001 = " + TST_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_001.ToString()))
            {
                sSQL = sSQL + "TST_ENM_001 = " + TST_ENM_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_001.ToString()))
            {
                sSQL = sSQL + "TST_EEE_001 = " + TST_EEE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_001.ToString()))
            {
                sSQL = sSQL + "TST_KKK_001 = " + TST_KKK_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_001.ToString()))
            {
                sSQL = sSQL + "TST_BBB_001 = " + TST_BBB_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_001.ToString()))
            {
                sSQL = sSQL + "TST_OLE_001 = " + TST_OLE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_001.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_001 = " + TST_TRQ_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_001.ToString()))
            {
                sSQL = sSQL + "TST_ERT_001 = " + TST_ERT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_001.ToString()))
            {
                sSQL = sSQL + "TST_RT3_001 = " + TST_RT3_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_001.ToString()))
            {
                sSQL = sSQL + "TST_RT5_001 = " + TST_RT5_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_001.ToString()))
            {
                sSQL = sSQL + "TST_DND_001 = " + TST_DND_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_001.ToString()))
            {
                sSQL = sSQL + "TST_DMO_001 = " + TST_DMO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_001.ToString()))
            {
                sSQL = sSQL + "TST_PES_001 = " + TST_PES_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_001))
            {
                sSQL = sSQL + "TST_VRR_001 = '" + TST_VRR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_001))
            {
                sSQL = sSQL + "TST_TRE_001 = '" + TST_TRE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_001.ToString()))
            {
                sSQL = sSQL + "TST_LME_001 = " + TST_LME_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_001.ToString()))
            {
                sSQL = sSQL + "TST_UME_001 = " + TST_UME_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_001.ToString()))
            {
                sSQL = sSQL + "TST_LPE_001 = " + TST_LPE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_001.ToString()))
            {
                sSQL = sSQL + "TST_UPE_001 = " + TST_UPE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_001.ToString()))
            {
                sSQL = sSQL + "TST_UCV_001 = " + TST_UCV_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_001.ToString()))
            {
                sSQL = sSQL + "TST_CSO_001 = " + TST_CSO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_001.ToString()))
            {
                sSQL = sSQL + "TST_ESP_001 = " + TST_ESP_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_001))
            {
                sSQL = sSQL + "TST_TOL_001 = '" + TST_TOL_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_001.ToString()))
            {
                sSQL = sSQL + "TST_DUR_001 = " + TST_DUR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_001.ToString()))
            {
                sSQL = sSQL + "TST_DFT_001 = " + TST_DFT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_001.ToString()))
            {
                sSQL = sSQL + "TST_LMC_001 = " + TST_LMC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_001.ToString()))
            {
                sSQL = sSQL + "TST_UMC_001 = " + TST_UMC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_001.ToString()))
            {
                sSQL = sSQL + "TST_LPC_001 = " + TST_LPC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_001.ToString()))
            {
                sSQL = sSQL + "TST_UPC_001 = " + TST_UPC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_001.ToString()))
            {
                sSQL = sSQL + "TST_CVC_001 = " + TST_CVC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_001.ToString()))
            {
                sSQL = sSQL + "TST_DFC_001 = " + TST_DFC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_001.ToString()))
            {
                sSQL = sSQL + "TST_TFS_001 = " + TST_TFS_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_001.ToString()))
            {
                sSQL = sSQL + "TST_FSW_001 = " + TST_FSW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_001.ToString()))
            {
                sSQL = sSQL + "TST_WFW_001 = " + TST_WFW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_001.ToString()))
            {
                sSQL = sSQL + "TST_ECO_001 = " + TST_ECO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_001.ToString()))
            {
                sSQL = sSQL + "TST_EOL_001 = " + TST_EOL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_001.ToString()))
            {
                sSQL = sSQL + "TST_ETU_001 = " + TST_ETU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_001.ToString()))
            {
                sSQL = sSQL + "TST_ETD_001 = " + TST_ETD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_001.ToString()))
            {
                sSQL = sSQL + "TST_ECU_001 = " + TST_ECU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_001.ToString()))
            {
                sSQL = sSQL + "TST_EGD_001 = " + TST_EGD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_001.ToString()))
            {
                sSQL = sSQL + "TST_EEC_001 = " + TST_EEC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_001.ToString()))
            {
                sSQL = sSQL + "TST_ECD_001 = " + TST_ECD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_001.ToString()))
            {
                sSQL = sSQL + "TST_EGU_001 = " + TST_EGU_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_001.ToString()))
            {
                sSQL = sSQL + "TST_ESO_001 = " + TST_ESO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_001.ToString()))
            {
                sSQL = sSQL + "TST_ESI_001 = " + TST_ESI_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_001.ToString()))
            {
                sSQL = sSQL + "TST_ECR_001 = " + TST_ECR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_001.ToString()))
            {
                sSQL = sSQL + "TST_EOD_001 = " + TST_EOD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_001.ToString()))
            {
                sSQL = sSQL + "TST_EAW_001 = " + TST_EAW_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_001.ToString()))
            {
                sSQL = sSQL + "TST_ED1_001 = " + TST_ED1_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_001.ToString()))
            {
                sSQL = sSQL + "TST_ED2_001 = " + TST_ED2_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_002))
            {
                sSQL = sSQL + "TST_VW2_002 = '" + TST_VW2_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_002))
            {
                sSQL = sSQL + "TST_EGM_002 = '" + TST_EGM_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_002))
            {
                sSQL = sSQL + "TST_DYY_002 = '" + TST_DYY_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_002))
            {
                sSQL = sSQL + "TST_2WX_002 = '" + TST_2WX_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_002))
            {
                sSQL = sSQL + "TST_3W3_002 = '" + TST_3W3_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_002))
            {
                sSQL = sSQL + "TST_4W4_002 = '" + TST_4W4_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_002))
            {
                sSQL = sSQL + "TST_AGL_002 = '" + TST_AGL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_002))
            {
                sSQL = sSQL + "TST_TUP_002 = '" + TST_TUP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_002))
            {
                sSQL = sSQL + "TST_VEO_002 = '" + TST_VEO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_002))
            {
                sSQL = sSQL + "TST_T1T_002 = '" + TST_T1T_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_002))
            {
                sSQL = sSQL + "TST_T1C_002 = '" + TST_T1C_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_002))
            {
                sSQL = sSQL + "TST_T1L_002 = '" + TST_T1L_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_002))
            {
                sSQL = sSQL + "TST_T2F_002 = '" + TST_T2F_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_002))
            {
                sSQL = sSQL + "TST_SVE_002 = '" + TST_SVE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_002))
            {
                sSQL = sSQL + "TST_STF_002 = '" + TST_STF_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_002))
            {
                sSQL = sSQL + "TST_STM_002 = '" + TST_STM_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_002))
            {
                sSQL = sSQL + "TST_SCE_002 = '" + TST_SCE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_002))
            {
                sSQL = sSQL + "TST_SCO_002 = '" + TST_SCO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_002))
            {
                sSQL = sSQL + "TST_SCH_002 = '" + TST_SCH_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_002))
            {
                sSQL = sSQL + "TST_SCG_002 = '" + TST_SCG_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_002))
            {
                sSQL = sSQL + "TST_SEE_002 = '" + TST_SEE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_002))
            {
                sSQL = sSQL + "TST_SEO_002 = '" + TST_SEO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_002))
            {
                sSQL = sSQL + "TST_SEH_002 = '" + TST_SEH_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_002))
            {
                sSQL = sSQL + "TST_SEG_002 = '" + TST_SEG_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_002))
            {
                sSQL = sSQL + "TST_SJC_002 = '" + TST_SJC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_002))
            {
                sSQL = sSQL + "TST_SJT_002 = '" + TST_SJT_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_002))
            {
                sSQL = sSQL + "TST_SJB_002 = '" + TST_SJB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_002))
            {
                sSQL = sSQL + "TST_SPJ_002 = '" + TST_SPJ_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_002))
            {
                sSQL = sSQL + "TST_SBC_002 = '" + TST_SBC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_002))
            {
                sSQL = sSQL + "TST_SPO_002 = '" + TST_SPO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_002))
            {
                sSQL = sSQL + "TST_SVA_002 = '" + TST_SVA_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_002))
            {
                sSQL = sSQL + "TST_TGR_002 = '" + TST_TGR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_002))
            {
                sSQL = sSQL + "TST_TIP_002 = '" + TST_TIP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_002))
            {
                sSQL = sSQL + "TST_DSB_002 = '" + TST_DSB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_002))
            {
                sSQL = sSQL + "TST_TCA_002 = '" + TST_TCA_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_002))
            {
                sSQL = sSQL + "TST_FMC_002 = '" + TST_FMC_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_002))
            {
                sSQL = sSQL + "TST_1TB_002 = '" + TST_1TB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_002))
            {
                sSQL = sSQL + "TST_1PP_002 = '" + TST_1PP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_002))
            {
                sSQL = sSQL + "TST_2TB_002 = '" + TST_2TB_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_002))
            {
                sSQL = sSQL + "TST_2PP_002 = '" + TST_2PP_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_002))
            {
                sSQL = sSQL + "TST_P1C_002 = '" + TST_P1C_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_002))
            {
                sSQL = sSQL + "TST_P2D_002 = '" + TST_P2D_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_002))
            {
                sSQL = sSQL + "TST_P3D_002 = '" + TST_P3D_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_002))
            {
                sSQL = sSQL + "TST_P4U_002 = '" + TST_P4U_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_002))
            {
                sSQL = sSQL + "TST_MOL_002 = '" + TST_MOL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_002))
            {
                sSQL = sSQL + "TST_TPD_002 = '" + TST_TPD_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_002))
            {
                sSQL = sSQL + "TST_TT1_002 = '" + TST_TT1_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_002))
            {
                sSQL = sSQL + "TST_TT2_002 = '" + TST_TT2_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_002))
            {
                sSQL = sSQL + "TST_TT3_002 = '" + TST_TT3_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_002))
            {
                sSQL = sSQL + "TST_T21_002 = '" + TST_T21_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_002))
            {
                sSQL = sSQL + "TST_TUN_002 = '" + TST_TUN_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_002))
            {
                sSQL = sSQL + "TST_TCV_002 = '" + TST_TCV_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_002))
            {
                sSQL = sSQL + "TST_TSS_002 = '" + TST_TSS_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_002.ToString()))
            {
                sSQL = sSQL + "TST_TIT_002 = " + TST_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_002.ToString()))
            {
                sSQL = sSQL + "TST_TNC_002 = " + TST_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_002.ToString()))
            {
                sSQL = sSQL + "TST_AON_002 = " + TST_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_002.ToString()))
            {
                sSQL = sSQL + "TST_ENM_002 = " + TST_ENM_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_002.ToString()))
            {
                sSQL = sSQL + "TST_EEE_002 = " + TST_EEE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_002.ToString()))
            {
                sSQL = sSQL + "TST_KKK_002 = " + TST_KKK_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_002.ToString()))
            {
                sSQL = sSQL + "TST_BBB_002 = " + TST_BBB_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_002.ToString()))
            {
                sSQL = sSQL + "TST_OLE_002 = " + TST_OLE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_002.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_002 = " + TST_TRQ_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_002.ToString()))
            {
                sSQL = sSQL + "TST_ERT_002 = " + TST_ERT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_002.ToString()))
            {
                sSQL = sSQL + "TST_RT3_002 = " + TST_RT3_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_002.ToString()))
            {
                sSQL = sSQL + "TST_RT5_002 = " + TST_RT5_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_002.ToString()))
            {
                sSQL = sSQL + "TST_DND_002 = " + TST_DND_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_002.ToString()))
            {
                sSQL = sSQL + "TST_DMO_002 = " + TST_DMO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_002.ToString()))
            {
                sSQL = sSQL + "TST_PES_002 = " + TST_PES_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_002))
            {
                sSQL = sSQL + "TST_VRR_002 = '" + TST_VRR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_002))
            {
                sSQL = sSQL + "TST_TRE_002 = '" + TST_TRE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_002.ToString()))
            {
                sSQL = sSQL + "TST_LME_002 = " + TST_LME_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_002.ToString()))
            {
                sSQL = sSQL + "TST_UME_002 = " + TST_UME_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_002.ToString()))
            {
                sSQL = sSQL + "TST_LPE_002 = " + TST_LPE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_002.ToString()))
            {
                sSQL = sSQL + "TST_UPE_002 = " + TST_UPE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_002.ToString()))
            {
                sSQL = sSQL + "TST_UCV_002 = " + TST_UCV_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_002.ToString()))
            {
                sSQL = sSQL + "TST_CSO_002 = " + TST_CSO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_002.ToString()))
            {
                sSQL = sSQL + "TST_ESP_002 = " + TST_ESP_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_002))
            {
                sSQL = sSQL + "TST_TOL_002 = '" + TST_TOL_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_002.ToString()))
            {
                sSQL = sSQL + "TST_DUR_002 = " + TST_DUR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_002.ToString()))
            {
                sSQL = sSQL + "TST_DFT_002 = " + TST_DFT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_002.ToString()))
            {
                sSQL = sSQL + "TST_LMC_002 = " + TST_LMC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_002.ToString()))
            {
                sSQL = sSQL + "TST_UMC_002 = " + TST_UMC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_002.ToString()))
            {
                sSQL = sSQL + "TST_LPC_002 = " + TST_LPC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_002.ToString()))
            {
                sSQL = sSQL + "TST_UPC_002 = " + TST_UPC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_002.ToString()))
            {
                sSQL = sSQL + "TST_CVC_002 = " + TST_CVC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_002.ToString()))
            {
                sSQL = sSQL + "TST_DFC_002 = " + TST_DFC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_002.ToString()))
            {
                sSQL = sSQL + "TST_TFS_002 = " + TST_TFS_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_002.ToString()))
            {
                sSQL = sSQL + "TST_FSW_002 = " + TST_FSW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_002.ToString()))
            {
                sSQL = sSQL + "TST_WFW_002 = " + TST_WFW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_002.ToString()))
            {
                sSQL = sSQL + "TST_ECO_002 = " + TST_ECO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_002.ToString()))
            {
                sSQL = sSQL + "TST_EOL_002 = " + TST_EOL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_002.ToString()))
            {
                sSQL = sSQL + "TST_ETU_002 = " + TST_ETU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_002.ToString()))
            {
                sSQL = sSQL + "TST_ETD_002 = " + TST_ETD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_002.ToString()))
            {
                sSQL = sSQL + "TST_ECU_002 = " + TST_ECU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_002.ToString()))
            {
                sSQL = sSQL + "TST_EGD_002 = " + TST_EGD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_002.ToString()))
            {
                sSQL = sSQL + "TST_EEC_002 = " + TST_EEC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_002.ToString()))
            {
                sSQL = sSQL + "TST_ECD_002 = " + TST_ECD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_002.ToString()))
            {
                sSQL = sSQL + "TST_EGU_002 = " + TST_EGU_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_002.ToString()))
            {
                sSQL = sSQL + "TST_ESO_002 = " + TST_ESO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_002.ToString()))
            {
                sSQL = sSQL + "TST_ESI_002 = " + TST_ESI_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_002.ToString()))
            {
                sSQL = sSQL + "TST_ECR_002 = " + TST_ECR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_002.ToString()))
            {
                sSQL = sSQL + "TST_EOD_002 = " + TST_EOD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_002.ToString()))
            {
                sSQL = sSQL + "TST_EAW_002 = " + TST_EAW_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_002.ToString()))
            {
                sSQL = sSQL + "TST_ED1_002 = " + TST_ED1_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_002.ToString()))
            {
                sSQL = sSQL + "TST_ED2_002 = " + TST_ED2_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_003))
            {
                sSQL = sSQL + "TST_VW2_003 = '" + TST_VW2_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_003))
            {
                sSQL = sSQL + "TST_EGM_003 = '" + TST_EGM_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_003))
            {
                sSQL = sSQL + "TST_DYY_003 = '" + TST_DYY_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_003))
            {
                sSQL = sSQL + "TST_2WX_003 = '" + TST_2WX_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_003))
            {
                sSQL = sSQL + "TST_3W3_003 = '" + TST_3W3_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_003))
            {
                sSQL = sSQL + "TST_4W4_003 = '" + TST_4W4_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_003))
            {
                sSQL = sSQL + "TST_AGL_003 = '" + TST_AGL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_003))
            {
                sSQL = sSQL + "TST_TUP_003 = '" + TST_TUP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_003))
            {
                sSQL = sSQL + "TST_VEO_003 = '" + TST_VEO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_003))
            {
                sSQL = sSQL + "TST_T1T_003 = '" + TST_T1T_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_003))
            {
                sSQL = sSQL + "TST_T1C_003 = '" + TST_T1C_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_003))
            {
                sSQL = sSQL + "TST_T1L_003 = '" + TST_T1L_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_003))
            {
                sSQL = sSQL + "TST_T2F_003 = '" + TST_T2F_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_003))
            {
                sSQL = sSQL + "TST_SVE_003 = '" + TST_SVE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_003))
            {
                sSQL = sSQL + "TST_STF_003 = '" + TST_STF_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_003))
            {
                sSQL = sSQL + "TST_STM_003 = '" + TST_STM_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_003))
            {
                sSQL = sSQL + "TST_SCE_003 = '" + TST_SCE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_003))
            {
                sSQL = sSQL + "TST_SCO_003 = '" + TST_SCO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_003))
            {
                sSQL = sSQL + "TST_SCH_003 = '" + TST_SCH_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_003))
            {
                sSQL = sSQL + "TST_SCG_003 = '" + TST_SCG_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_003))
            {
                sSQL = sSQL + "TST_SEE_003 = '" + TST_SEE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_003))
            {
                sSQL = sSQL + "TST_SEO_003 = '" + TST_SEO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_003))
            {
                sSQL = sSQL + "TST_SEH_003 = '" + TST_SEH_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_003))
            {
                sSQL = sSQL + "TST_SEG_003 = '" + TST_SEG_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_003))
            {
                sSQL = sSQL + "TST_SJC_003 = '" + TST_SJC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_003))
            {
                sSQL = sSQL + "TST_SJT_003 = '" + TST_SJT_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_003))
            {
                sSQL = sSQL + "TST_SJB_003 = '" + TST_SJB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_003))
            {
                sSQL = sSQL + "TST_SPJ_003 = '" + TST_SPJ_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_003))
            {
                sSQL = sSQL + "TST_SBC_003 = '" + TST_SBC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_003))
            {
                sSQL = sSQL + "TST_SPO_003 = '" + TST_SPO_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_003))
            {
                sSQL = sSQL + "TST_SVA_003 = '" + TST_SVA_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_003))
            {
                sSQL = sSQL + "TST_TGR_003 = '" + TST_TGR_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_003))
            {
                sSQL = sSQL + "TST_TIP_003 = '" + TST_TIP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_003))
            {
                sSQL = sSQL + "TST_DSB_003 = '" + TST_DSB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_003))
            {
                sSQL = sSQL + "TST_TCA_003 = '" + TST_TCA_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_003))
            {
                sSQL = sSQL + "TST_FMC_003 = '" + TST_FMC_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_003))
            {
                sSQL = sSQL + "TST_1TB_003 = '" + TST_1TB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_003))
            {
                sSQL = sSQL + "TST_1PP_003 = '" + TST_1PP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_003))
            {
                sSQL = sSQL + "TST_2TB_003 = '" + TST_2TB_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_003))
            {
                sSQL = sSQL + "TST_2PP_003 = '" + TST_2PP_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_003))
            {
                sSQL = sSQL + "TST_P1C_003 = '" + TST_P1C_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_003))
            {
                sSQL = sSQL + "TST_P2D_003 = '" + TST_P2D_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_003))
            {
                sSQL = sSQL + "TST_P3D_003 = '" + TST_P3D_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_003))
            {
                sSQL = sSQL + "TST_P4U_003 = '" + TST_P4U_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_003))
            {
                sSQL = sSQL + "TST_MOL_003 = '" + TST_MOL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_003))
            {
                sSQL = sSQL + "TST_TPD_003 = '" + TST_TPD_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_003))
            {
                sSQL = sSQL + "TST_TT1_003 = '" + TST_TT1_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_003))
            {
                sSQL = sSQL + "TST_TT2_003 = '" + TST_TT2_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_003))
            {
                sSQL = sSQL + "TST_TT3_003 = '" + TST_TT3_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_003))
            {
                sSQL = sSQL + "TST_T21_003 = '" + TST_T21_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_003))
            {
                sSQL = sSQL + "TST_TUN_003 = '" + TST_TUN_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_003))
            {
                sSQL = sSQL + "TST_TCV_003 = '" + TST_TCV_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_003))
            {
                sSQL = sSQL + "TST_TSS_003 = '" + TST_TSS_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_003.ToString()))
            {
                sSQL = sSQL + "TST_TIT_003 = " + TST_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_003.ToString()))
            {
                sSQL = sSQL + "TST_TNC_003 = " + TST_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_003.ToString()))
            {
                sSQL = sSQL + "TST_AON_003 = " + TST_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_003.ToString()))
            {
                sSQL = sSQL + "TST_ENM_003 = " + TST_ENM_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_003.ToString()))
            {
                sSQL = sSQL + "TST_EEE_003 = " + TST_EEE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_003.ToString()))
            {
                sSQL = sSQL + "TST_KKK_003 = " + TST_KKK_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_003.ToString()))
            {
                sSQL = sSQL + "TST_BBB_003 = " + TST_BBB_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_003.ToString()))
            {
                sSQL = sSQL + "TST_OLE_003 = " + TST_OLE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_003.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_003 = " + TST_TRQ_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_003.ToString()))
            {
                sSQL = sSQL + "TST_ERT_003 = " + TST_ERT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_003.ToString()))
            {
                sSQL = sSQL + "TST_RT3_003 = " + TST_RT3_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_003.ToString()))
            {
                sSQL = sSQL + "TST_RT5_003 = " + TST_RT5_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_003.ToString()))
            {
                sSQL = sSQL + "TST_DND_003 = " + TST_DND_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_003.ToString()))
            {
                sSQL = sSQL + "TST_DMO_003 = " + TST_DMO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_003.ToString()))
            {
                sSQL = sSQL + "TST_PES_003 = " + TST_PES_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_003))
            {
                sSQL = sSQL + "TST_VRR_003 = '" + TST_VRR_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_003))
            {
                sSQL = sSQL + "TST_TRE_003 = '" + TST_TRE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_003.ToString()))
            {
                sSQL = sSQL + "TST_LME_003 = " + TST_LME_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_003.ToString()))
            {
                sSQL = sSQL + "TST_UME_003 = " + TST_UME_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_003.ToString()))
            {
                sSQL = sSQL + "TST_LPE_003 = " + TST_LPE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_003.ToString()))
            {
                sSQL = sSQL + "TST_UPE_003 = " + TST_UPE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_003.ToString()))
            {
                sSQL = sSQL + "TST_UCV_003 = " + TST_UCV_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_003.ToString()))
            {
                sSQL = sSQL + "TST_CSO_003 = " + TST_CSO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_003.ToString()))
            {
                sSQL = sSQL + "TST_ESP_003 = " + TST_ESP_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_003))
            {
                sSQL = sSQL + "TST_TOL_003 = '" + TST_TOL_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_003.ToString()))
            {
                sSQL = sSQL + "TST_DUR_003 = " + TST_DUR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_003.ToString()))
            {
                sSQL = sSQL + "TST_DFT_003 = " + TST_DFT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_003.ToString()))
            {
                sSQL = sSQL + "TST_LMC_003 = " + TST_LMC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_003.ToString()))
            {
                sSQL = sSQL + "TST_UMC_003 = " + TST_UMC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_003.ToString()))
            {
                sSQL = sSQL + "TST_LPC_003 = " + TST_LPC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_003.ToString()))
            {
                sSQL = sSQL + "TST_UPC_003 = " + TST_UPC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_003.ToString()))
            {
                sSQL = sSQL + "TST_CVC_003 = " + TST_CVC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_003.ToString()))
            {
                sSQL = sSQL + "TST_DFC_003 = " + TST_DFC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_003.ToString()))
            {
                sSQL = sSQL + "TST_TFS_003 = " + TST_TFS_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_003.ToString()))
            {
                sSQL = sSQL + "TST_FSW_003 = " + TST_FSW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_003.ToString()))
            {
                sSQL = sSQL + "TST_WFW_003 = " + TST_WFW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_003.ToString()))
            {
                sSQL = sSQL + "TST_ECO_003 = " + TST_ECO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_003.ToString()))
            {
                sSQL = sSQL + "TST_EOL_003 = " + TST_EOL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_003.ToString()))
            {
                sSQL = sSQL + "TST_ETU_003 = " + TST_ETU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_003.ToString()))
            {
                sSQL = sSQL + "TST_ETD_003 = " + TST_ETD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_003.ToString()))
            {
                sSQL = sSQL + "TST_ECU_003 = " + TST_ECU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_003.ToString()))
            {
                sSQL = sSQL + "TST_EGD_003 = " + TST_EGD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_003.ToString()))
            {
                sSQL = sSQL + "TST_EEC_003 = " + TST_EEC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_003.ToString()))
            {
                sSQL = sSQL + "TST_ECD_003 = " + TST_ECD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_003.ToString()))
            {
                sSQL = sSQL + "TST_EGU_003 = " + TST_EGU_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_003.ToString()))
            {
                sSQL = sSQL + "TST_ESO_003 = " + TST_ESO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_003.ToString()))
            {
                sSQL = sSQL + "TST_ESI_003 = " + TST_ESI_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_003.ToString()))
            {
                sSQL = sSQL + "TST_ECR_003 = " + TST_ECR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_003.ToString()))
            {
                sSQL = sSQL + "TST_EOD_003 = " + TST_EOD_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_003.ToString()))
            {
                sSQL = sSQL + "TST_EAW_003 = " + TST_EAW_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_003.ToString()))
            {
                sSQL = sSQL + "TST_ED1_003 = " + TST_ED1_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_003.ToString()))
            {
                sSQL = sSQL + "TST_ED2_003 = " + TST_ED2_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_004))
            {
                sSQL = sSQL + "TST_VW2_004 = '" + TST_VW2_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_004))
            {
                sSQL = sSQL + "TST_EGM_004 = '" + TST_EGM_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_004))
            {
                sSQL = sSQL + "TST_DYY_004 = '" + TST_DYY_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_004))
            {
                sSQL = sSQL + "TST_2WX_004 = '" + TST_2WX_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_004))
            {
                sSQL = sSQL + "TST_3W3_004 = '" + TST_3W3_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_004))
            {
                sSQL = sSQL + "TST_4W4_004 = '" + TST_4W4_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_004))
            {
                sSQL = sSQL + "TST_AGL_004 = '" + TST_AGL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_004))
            {
                sSQL = sSQL + "TST_TUP_004 = '" + TST_TUP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_004))
            {
                sSQL = sSQL + "TST_VEO_004 = '" + TST_VEO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_004))
            {
                sSQL = sSQL + "TST_T1T_004 = '" + TST_T1T_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_004))
            {
                sSQL = sSQL + "TST_T1C_004 = '" + TST_T1C_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_004))
            {
                sSQL = sSQL + "TST_T1L_004 = '" + TST_T1L_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_004))
            {
                sSQL = sSQL + "TST_T2F_004 = '" + TST_T2F_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_004))
            {
                sSQL = sSQL + "TST_SVE_004 = '" + TST_SVE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_004))
            {
                sSQL = sSQL + "TST_STF_004 = '" + TST_STF_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_004))
            {
                sSQL = sSQL + "TST_STM_004 = '" + TST_STM_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_004))
            {
                sSQL = sSQL + "TST_SCE_004 = '" + TST_SCE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_004))
            {
                sSQL = sSQL + "TST_SCO_004 = '" + TST_SCO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_004))
            {
                sSQL = sSQL + "TST_SCH_004 = '" + TST_SCH_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_004))
            {
                sSQL = sSQL + "TST_SCG_004 = '" + TST_SCG_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_004))
            {
                sSQL = sSQL + "TST_SEE_004 = '" + TST_SEE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_004))
            {
                sSQL = sSQL + "TST_SEO_004 = '" + TST_SEO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_004))
            {
                sSQL = sSQL + "TST_SEH_004 = '" + TST_SEH_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_004))
            {
                sSQL = sSQL + "TST_SEG_004 = '" + TST_SEG_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_004))
            {
                sSQL = sSQL + "TST_SJC_004 = '" + TST_SJC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_004))
            {
                sSQL = sSQL + "TST_SJT_004 = '" + TST_SJT_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_004))
            {
                sSQL = sSQL + "TST_SJB_004 = '" + TST_SJB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_004))
            {
                sSQL = sSQL + "TST_SPJ_004 = '" + TST_SPJ_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_004))
            {
                sSQL = sSQL + "TST_SBC_004 = '" + TST_SBC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_004))
            {
                sSQL = sSQL + "TST_SPO_004 = '" + TST_SPO_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_004))
            {
                sSQL = sSQL + "TST_SVA_004 = '" + TST_SVA_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_004))
            {
                sSQL = sSQL + "TST_TGR_004 = '" + TST_TGR_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_004))
            {
                sSQL = sSQL + "TST_TIP_004 = '" + TST_TIP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_004))
            {
                sSQL = sSQL + "TST_DSB_004 = '" + TST_DSB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_004))
            {
                sSQL = sSQL + "TST_TCA_004 = '" + TST_TCA_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_004))
            {
                sSQL = sSQL + "TST_FMC_004 = '" + TST_FMC_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_004))
            {
                sSQL = sSQL + "TST_1TB_004 = '" + TST_1TB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_004))
            {
                sSQL = sSQL + "TST_1PP_004 = '" + TST_1PP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_004))
            {
                sSQL = sSQL + "TST_2TB_004 = '" + TST_2TB_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_004))
            {
                sSQL = sSQL + "TST_2PP_004 = '" + TST_2PP_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_004))
            {
                sSQL = sSQL + "TST_P1C_004 = '" + TST_P1C_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_004))
            {
                sSQL = sSQL + "TST_P2D_004 = '" + TST_P2D_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_004))
            {
                sSQL = sSQL + "TST_P3D_004 = '" + TST_P3D_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_004))
            {
                sSQL = sSQL + "TST_P4U_004 = '" + TST_P4U_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_004))
            {
                sSQL = sSQL + "TST_MOL_004 = '" + TST_MOL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_004))
            {
                sSQL = sSQL + "TST_TPD_004 = '" + TST_TPD_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_004))
            {
                sSQL = sSQL + "TST_TT1_004 = '" + TST_TT1_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_004))
            {
                sSQL = sSQL + "TST_TT2_004 = '" + TST_TT2_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_004))
            {
                sSQL = sSQL + "TST_TT3_004 = '" + TST_TT3_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_004))
            {
                sSQL = sSQL + "TST_T21_004 = '" + TST_T21_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_004))
            {
                sSQL = sSQL + "TST_TUN_004 = '" + TST_TUN_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_004))
            {
                sSQL = sSQL + "TST_TCV_004 = '" + TST_TCV_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_004))
            {
                sSQL = sSQL + "TST_TSS_004 = '" + TST_TSS_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_004.ToString()))
            {
                sSQL = sSQL + "TST_TIT_004 = " + TST_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_004.ToString()))
            {
                sSQL = sSQL + "TST_TNC_004 = " + TST_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_004.ToString()))
            {
                sSQL = sSQL + "TST_AON_004 = " + TST_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_004.ToString()))
            {
                sSQL = sSQL + "TST_ENM_004 = " + TST_ENM_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_004.ToString()))
            {
                sSQL = sSQL + "TST_EEE_004 = " + TST_EEE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_004.ToString()))
            {
                sSQL = sSQL + "TST_KKK_004 = " + TST_KKK_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_004.ToString()))
            {
                sSQL = sSQL + "TST_BBB_004 = " + TST_BBB_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_004.ToString()))
            {
                sSQL = sSQL + "TST_OLE_004 = " + TST_OLE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_004.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_004 = " + TST_TRQ_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_004.ToString()))
            {
                sSQL = sSQL + "TST_ERT_004 = " + TST_ERT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_004.ToString()))
            {
                sSQL = sSQL + "TST_RT3_004 = " + TST_RT3_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_004.ToString()))
            {
                sSQL = sSQL + "TST_RT5_004 = " + TST_RT5_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_004.ToString()))
            {
                sSQL = sSQL + "TST_DND_004 = " + TST_DND_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_004.ToString()))
            {
                sSQL = sSQL + "TST_DMO_004 = " + TST_DMO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_004.ToString()))
            {
                sSQL = sSQL + "TST_PES_004 = " + TST_PES_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_004))
            {
                sSQL = sSQL + "TST_VRR_004 = '" + TST_VRR_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_004))
            {
                sSQL = sSQL + "TST_TRE_004 = '" + TST_TRE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_004.ToString()))
            {
                sSQL = sSQL + "TST_LME_004 = " + TST_LME_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_004.ToString()))
            {
                sSQL = sSQL + "TST_UME_004 = " + TST_UME_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_004.ToString()))
            {
                sSQL = sSQL + "TST_LPE_004 = " + TST_LPE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_004.ToString()))
            {
                sSQL = sSQL + "TST_UPE_004 = " + TST_UPE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_004.ToString()))
            {
                sSQL = sSQL + "TST_UCV_004 = " + TST_UCV_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_004.ToString()))
            {
                sSQL = sSQL + "TST_CSO_004 = " + TST_CSO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_004.ToString()))
            {
                sSQL = sSQL + "TST_ESP_004 = " + TST_ESP_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_004))
            {
                sSQL = sSQL + "TST_TOL_004 = '" + TST_TOL_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_004.ToString()))
            {
                sSQL = sSQL + "TST_DUR_004 = " + TST_DUR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_004.ToString()))
            {
                sSQL = sSQL + "TST_DFT_004 = " + TST_DFT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_004.ToString()))
            {
                sSQL = sSQL + "TST_LMC_004 = " + TST_LMC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_004.ToString()))
            {
                sSQL = sSQL + "TST_UMC_004 = " + TST_UMC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_004.ToString()))
            {
                sSQL = sSQL + "TST_LPC_004 = " + TST_LPC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_004.ToString()))
            {
                sSQL = sSQL + "TST_UPC_004 = " + TST_UPC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_004.ToString()))
            {
                sSQL = sSQL + "TST_CVC_004 = " + TST_CVC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_004.ToString()))
            {
                sSQL = sSQL + "TST_DFC_004 = " + TST_DFC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_004.ToString()))
            {
                sSQL = sSQL + "TST_TFS_004 = " + TST_TFS_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_004.ToString()))
            {
                sSQL = sSQL + "TST_FSW_004 = " + TST_FSW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_004.ToString()))
            {
                sSQL = sSQL + "TST_WFW_004 = " + TST_WFW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_004.ToString()))
            {
                sSQL = sSQL + "TST_ECO_004 = " + TST_ECO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_004.ToString()))
            {
                sSQL = sSQL + "TST_EOL_004 = " + TST_EOL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_004.ToString()))
            {
                sSQL = sSQL + "TST_ETU_004 = " + TST_ETU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_004.ToString()))
            {
                sSQL = sSQL + "TST_ETD_004 = " + TST_ETD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_004.ToString()))
            {
                sSQL = sSQL + "TST_ECU_004 = " + TST_ECU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_004.ToString()))
            {
                sSQL = sSQL + "TST_EGD_004 = " + TST_EGD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_004.ToString()))
            {
                sSQL = sSQL + "TST_EEC_004 = " + TST_EEC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_004.ToString()))
            {
                sSQL = sSQL + "TST_ECD_004 = " + TST_ECD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_004.ToString()))
            {
                sSQL = sSQL + "TST_EGU_004 = " + TST_EGU_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_004.ToString()))
            {
                sSQL = sSQL + "TST_ESO_004 = " + TST_ESO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_004.ToString()))
            {
                sSQL = sSQL + "TST_ESI_004 = " + TST_ESI_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_004.ToString()))
            {
                sSQL = sSQL + "TST_ECR_004 = " + TST_ECR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_004.ToString()))
            {
                sSQL = sSQL + "TST_EOD_004 = " + TST_EOD_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_004.ToString()))
            {
                sSQL = sSQL + "TST_EAW_004 = " + TST_EAW_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_004.ToString()))
            {
                sSQL = sSQL + "TST_ED1_004 = " + TST_ED1_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_004.ToString()))
            {
                sSQL = sSQL + "TST_ED2_004 = " + TST_ED2_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_005))
            {
                sSQL = sSQL + "TST_VW2_005 = '" + TST_VW2_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_005))
            {
                sSQL = sSQL + "TST_EGM_005 = '" + TST_EGM_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_005))
            {
                sSQL = sSQL + "TST_DYY_005 = '" + TST_DYY_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_005))
            {
                sSQL = sSQL + "TST_2WX_005 = '" + TST_2WX_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_005))
            {
                sSQL = sSQL + "TST_3W3_005 = '" + TST_3W3_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_005))
            {
                sSQL = sSQL + "TST_4W4_005 = '" + TST_4W4_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_005))
            {
                sSQL = sSQL + "TST_AGL_005 = '" + TST_AGL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_005))
            {
                sSQL = sSQL + "TST_TUP_005 = '" + TST_TUP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_005))
            {
                sSQL = sSQL + "TST_VEO_005 = '" + TST_VEO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_005))
            {
                sSQL = sSQL + "TST_T1T_005 = '" + TST_T1T_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_005))
            {
                sSQL = sSQL + "TST_T1C_005 = '" + TST_T1C_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_005))
            {
                sSQL = sSQL + "TST_T1L_005 = '" + TST_T1L_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_005))
            {
                sSQL = sSQL + "TST_T2F_005 = '" + TST_T2F_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_005))
            {
                sSQL = sSQL + "TST_SVE_005 = '" + TST_SVE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_005))
            {
                sSQL = sSQL + "TST_STF_005 = '" + TST_STF_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_005))
            {
                sSQL = sSQL + "TST_STM_005 = '" + TST_STM_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_005))
            {
                sSQL = sSQL + "TST_SCE_005 = '" + TST_SCE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_005))
            {
                sSQL = sSQL + "TST_SCO_005 = '" + TST_SCO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_005))
            {
                sSQL = sSQL + "TST_SCH_005 = '" + TST_SCH_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_005))
            {
                sSQL = sSQL + "TST_SCG_005 = '" + TST_SCG_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_005))
            {
                sSQL = sSQL + "TST_SEE_005 = '" + TST_SEE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_005))
            {
                sSQL = sSQL + "TST_SEO_005 = '" + TST_SEO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_005))
            {
                sSQL = sSQL + "TST_SEH_005 = '" + TST_SEH_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_005))
            {
                sSQL = sSQL + "TST_SEG_005 = '" + TST_SEG_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_005))
            {
                sSQL = sSQL + "TST_SJC_005 = '" + TST_SJC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_005))
            {
                sSQL = sSQL + "TST_SJT_005 = '" + TST_SJT_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_005))
            {
                sSQL = sSQL + "TST_SJB_005 = '" + TST_SJB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_005))
            {
                sSQL = sSQL + "TST_SPJ_005 = '" + TST_SPJ_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_005))
            {
                sSQL = sSQL + "TST_SBC_005 = '" + TST_SBC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_005))
            {
                sSQL = sSQL + "TST_SPO_005 = '" + TST_SPO_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_005))
            {
                sSQL = sSQL + "TST_SVA_005 = '" + TST_SVA_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_005))
            {
                sSQL = sSQL + "TST_TGR_005 = '" + TST_TGR_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_005))
            {
                sSQL = sSQL + "TST_TIP_005 = '" + TST_TIP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_005))
            {
                sSQL = sSQL + "TST_DSB_005 = '" + TST_DSB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_005))
            {
                sSQL = sSQL + "TST_TCA_005 = '" + TST_TCA_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_005))
            {
                sSQL = sSQL + "TST_FMC_005 = '" + TST_FMC_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_005))
            {
                sSQL = sSQL + "TST_1TB_005 = '" + TST_1TB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_005))
            {
                sSQL = sSQL + "TST_1PP_005 = '" + TST_1PP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_005))
            {
                sSQL = sSQL + "TST_2TB_005 = '" + TST_2TB_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_005))
            {
                sSQL = sSQL + "TST_2PP_005 = '" + TST_2PP_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_005))
            {
                sSQL = sSQL + "TST_P1C_005 = '" + TST_P1C_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_005))
            {
                sSQL = sSQL + "TST_P2D_005 = '" + TST_P2D_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_005))
            {
                sSQL = sSQL + "TST_P3D_005 = '" + TST_P3D_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_005))
            {
                sSQL = sSQL + "TST_P4U_005 = '" + TST_P4U_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_005))
            {
                sSQL = sSQL + "TST_MOL_005 = '" + TST_MOL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_005))
            {
                sSQL = sSQL + "TST_TPD_005 = '" + TST_TPD_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_005))
            {
                sSQL = sSQL + "TST_TT1_005 = '" + TST_TT1_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_005))
            {
                sSQL = sSQL + "TST_TT2_005 = '" + TST_TT2_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_005))
            {
                sSQL = sSQL + "TST_TT3_005 = '" + TST_TT3_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_005))
            {
                sSQL = sSQL + "TST_T21_005 = '" + TST_T21_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_005))
            {
                sSQL = sSQL + "TST_TUN_005 = '" + TST_TUN_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_005))
            {
                sSQL = sSQL + "TST_TCV_005 = '" + TST_TCV_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_005))
            {
                sSQL = sSQL + "TST_TSS_005 = '" + TST_TSS_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_005.ToString()))
            {
                sSQL = sSQL + "TST_TIT_005 = " + TST_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_005.ToString()))
            {
                sSQL = sSQL + "TST_TNC_005 = " + TST_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_005.ToString()))
            {
                sSQL = sSQL + "TST_AON_005 = " + TST_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_005.ToString()))
            {
                sSQL = sSQL + "TST_ENM_005 = " + TST_ENM_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_005.ToString()))
            {
                sSQL = sSQL + "TST_EEE_005 = " + TST_EEE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_005.ToString()))
            {
                sSQL = sSQL + "TST_KKK_005 = " + TST_KKK_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_005.ToString()))
            {
                sSQL = sSQL + "TST_BBB_005 = " + TST_BBB_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_005.ToString()))
            {
                sSQL = sSQL + "TST_OLE_005 = " + TST_OLE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_005.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_005 = " + TST_TRQ_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_005.ToString()))
            {
                sSQL = sSQL + "TST_ERT_005 = " + TST_ERT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_005.ToString()))
            {
                sSQL = sSQL + "TST_RT3_005 = " + TST_RT3_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_005.ToString()))
            {
                sSQL = sSQL + "TST_RT5_005 = " + TST_RT5_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_005.ToString()))
            {
                sSQL = sSQL + "TST_DND_005 = " + TST_DND_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_005.ToString()))
            {
                sSQL = sSQL + "TST_DMO_005 = " + TST_DMO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_005.ToString()))
            {
                sSQL = sSQL + "TST_PES_005 = " + TST_PES_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_005))
            {
                sSQL = sSQL + "TST_VRR_005 = '" + TST_VRR_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_005))
            {
                sSQL = sSQL + "TST_TRE_005 = '" + TST_TRE_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_005.ToString()))
            {
                sSQL = sSQL + "TST_LME_005 = " + TST_LME_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_005.ToString()))
            {
                sSQL = sSQL + "TST_UME_005 = " + TST_UME_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_005.ToString()))
            {
                sSQL = sSQL + "TST_LPE_005 = " + TST_LPE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_005.ToString()))
            {
                sSQL = sSQL + "TST_UPE_005 = " + TST_UPE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_005.ToString()))
            {
                sSQL = sSQL + "TST_UCV_005 = " + TST_UCV_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_005.ToString()))
            {
                sSQL = sSQL + "TST_CSO_005 = " + TST_CSO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_005.ToString()))
            {
                sSQL = sSQL + "TST_ESP_005 = " + TST_ESP_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_005))
            {
                sSQL = sSQL + "TST_TOL_005 = '" + TST_TOL_005.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_005.ToString()))
            {
                sSQL = sSQL + "TST_DUR_005 = " + TST_DUR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_005.ToString()))
            {
                sSQL = sSQL + "TST_DFT_005 = " + TST_DFT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_005.ToString()))
            {
                sSQL = sSQL + "TST_LMC_005 = " + TST_LMC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_005.ToString()))
            {
                sSQL = sSQL + "TST_UMC_005 = " + TST_UMC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_005.ToString()))
            {
                sSQL = sSQL + "TST_LPC_005 = " + TST_LPC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_005.ToString()))
            {
                sSQL = sSQL + "TST_UPC_005 = " + TST_UPC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_005.ToString()))
            {
                sSQL = sSQL + "TST_CVC_005 = " + TST_CVC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_005.ToString()))
            {
                sSQL = sSQL + "TST_DFC_005 = " + TST_DFC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_005.ToString()))
            {
                sSQL = sSQL + "TST_TFS_005 = " + TST_TFS_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_005.ToString()))
            {
                sSQL = sSQL + "TST_FSW_005 = " + TST_FSW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_005.ToString()))
            {
                sSQL = sSQL + "TST_WFW_005 = " + TST_WFW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_005.ToString()))
            {
                sSQL = sSQL + "TST_ECO_005 = " + TST_ECO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_005.ToString()))
            {
                sSQL = sSQL + "TST_EOL_005 = " + TST_EOL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_005.ToString()))
            {
                sSQL = sSQL + "TST_ETU_005 = " + TST_ETU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_005.ToString()))
            {
                sSQL = sSQL + "TST_ETD_005 = " + TST_ETD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_005.ToString()))
            {
                sSQL = sSQL + "TST_ECU_005 = " + TST_ECU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_005.ToString()))
            {
                sSQL = sSQL + "TST_EGD_005 = " + TST_EGD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_005.ToString()))
            {
                sSQL = sSQL + "TST_EEC_005 = " + TST_EEC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_005.ToString()))
            {
                sSQL = sSQL + "TST_ECD_005 = " + TST_ECD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_005.ToString()))
            {
                sSQL = sSQL + "TST_EGU_005 = " + TST_EGU_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_005.ToString()))
            {
                sSQL = sSQL + "TST_ESO_005 = " + TST_ESO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_005.ToString()))
            {
                sSQL = sSQL + "TST_ESI_005 = " + TST_ESI_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_005.ToString()))
            {
                sSQL = sSQL + "TST_ECR_005 = " + TST_ECR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_005.ToString()))
            {
                sSQL = sSQL + "TST_EOD_005 = " + TST_EOD_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_005.ToString()))
            {
                sSQL = sSQL + "TST_EAW_005 = " + TST_EAW_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_005.ToString()))
            {
                sSQL = sSQL + "TST_ED1_005 = " + TST_ED1_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_005.ToString()))
            {
                sSQL = sSQL + "TST_ED2_005 = " + TST_ED2_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_006))
            {
                sSQL = sSQL + "TST_VW2_006 = '" + TST_VW2_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_006))
            {
                sSQL = sSQL + "TST_EGM_006 = '" + TST_EGM_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_006))
            {
                sSQL = sSQL + "TST_DYY_006 = '" + TST_DYY_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_006))
            {
                sSQL = sSQL + "TST_2WX_006 = '" + TST_2WX_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_006))
            {
                sSQL = sSQL + "TST_3W3_006 = '" + TST_3W3_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_006))
            {
                sSQL = sSQL + "TST_4W4_006 = '" + TST_4W4_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_006))
            {
                sSQL = sSQL + "TST_AGL_006 = '" + TST_AGL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_006))
            {
                sSQL = sSQL + "TST_TUP_006 = '" + TST_TUP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_006))
            {
                sSQL = sSQL + "TST_VEO_006 = '" + TST_VEO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_006))
            {
                sSQL = sSQL + "TST_T1T_006 = '" + TST_T1T_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_006))
            {
                sSQL = sSQL + "TST_T1C_006 = '" + TST_T1C_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_006))
            {
                sSQL = sSQL + "TST_T1L_006 = '" + TST_T1L_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_006))
            {
                sSQL = sSQL + "TST_T2F_006 = '" + TST_T2F_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_006))
            {
                sSQL = sSQL + "TST_SVE_006 = '" + TST_SVE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_006))
            {
                sSQL = sSQL + "TST_STF_006 = '" + TST_STF_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_006))
            {
                sSQL = sSQL + "TST_STM_006 = '" + TST_STM_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_006))
            {
                sSQL = sSQL + "TST_SCE_006 = '" + TST_SCE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_006))
            {
                sSQL = sSQL + "TST_SCO_006 = '" + TST_SCO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_006))
            {
                sSQL = sSQL + "TST_SCH_006 = '" + TST_SCH_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_006))
            {
                sSQL = sSQL + "TST_SCG_006 = '" + TST_SCG_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_006))
            {
                sSQL = sSQL + "TST_SEE_006 = '" + TST_SEE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_006))
            {
                sSQL = sSQL + "TST_SEO_006 = '" + TST_SEO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_006))
            {
                sSQL = sSQL + "TST_SEH_006 = '" + TST_SEH_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_006))
            {
                sSQL = sSQL + "TST_SEG_006 = '" + TST_SEG_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_006))
            {
                sSQL = sSQL + "TST_SJC_006 = '" + TST_SJC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_006))
            {
                sSQL = sSQL + "TST_SJT_006 = '" + TST_SJT_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_006))
            {
                sSQL = sSQL + "TST_SJB_006 = '" + TST_SJB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_006))
            {
                sSQL = sSQL + "TST_SPJ_006 = '" + TST_SPJ_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_006))
            {
                sSQL = sSQL + "TST_SBC_006 = '" + TST_SBC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_006))
            {
                sSQL = sSQL + "TST_SPO_006 = '" + TST_SPO_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_006))
            {
                sSQL = sSQL + "TST_SVA_006 = '" + TST_SVA_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_006))
            {
                sSQL = sSQL + "TST_TGR_006 = '" + TST_TGR_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_006))
            {
                sSQL = sSQL + "TST_TIP_006 = '" + TST_TIP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_006))
            {
                sSQL = sSQL + "TST_DSB_006 = '" + TST_DSB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_006))
            {
                sSQL = sSQL + "TST_TCA_006 = '" + TST_TCA_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_006))
            {
                sSQL = sSQL + "TST_FMC_006 = '" + TST_FMC_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_006))
            {
                sSQL = sSQL + "TST_1TB_006 = '" + TST_1TB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_006))
            {
                sSQL = sSQL + "TST_1PP_006 = '" + TST_1PP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_006))
            {
                sSQL = sSQL + "TST_2TB_006 = '" + TST_2TB_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_006))
            {
                sSQL = sSQL + "TST_2PP_006 = '" + TST_2PP_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_006))
            {
                sSQL = sSQL + "TST_P1C_006 = '" + TST_P1C_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_006))
            {
                sSQL = sSQL + "TST_P2D_006 = '" + TST_P2D_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_006))
            {
                sSQL = sSQL + "TST_P3D_006 = '" + TST_P3D_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_006))
            {
                sSQL = sSQL + "TST_P4U_006 = '" + TST_P4U_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_006))
            {
                sSQL = sSQL + "TST_MOL_006 = '" + TST_MOL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_006))
            {
                sSQL = sSQL + "TST_TPD_006 = '" + TST_TPD_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_006))
            {
                sSQL = sSQL + "TST_TT1_006 = '" + TST_TT1_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_006))
            {
                sSQL = sSQL + "TST_TT2_006 = '" + TST_TT2_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_006))
            {
                sSQL = sSQL + "TST_TT3_006 = '" + TST_TT3_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_006))
            {
                sSQL = sSQL + "TST_T21_006 = '" + TST_T21_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_006))
            {
                sSQL = sSQL + "TST_TUN_006 = '" + TST_TUN_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_006))
            {
                sSQL = sSQL + "TST_TCV_006 = '" + TST_TCV_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_006))
            {
                sSQL = sSQL + "TST_TSS_006 = '" + TST_TSS_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_006.ToString()))
            {
                sSQL = sSQL + "TST_TIT_006 = " + TST_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_006.ToString()))
            {
                sSQL = sSQL + "TST_TNC_006 = " + TST_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_006.ToString()))
            {
                sSQL = sSQL + "TST_AON_006 = " + TST_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_006.ToString()))
            {
                sSQL = sSQL + "TST_ENM_006 = " + TST_ENM_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_006.ToString()))
            {
                sSQL = sSQL + "TST_EEE_006 = " + TST_EEE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_006.ToString()))
            {
                sSQL = sSQL + "TST_KKK_006 = " + TST_KKK_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_006.ToString()))
            {
                sSQL = sSQL + "TST_BBB_006 = " + TST_BBB_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_006.ToString()))
            {
                sSQL = sSQL + "TST_OLE_006 = " + TST_OLE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_006.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_006 = " + TST_TRQ_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_006.ToString()))
            {
                sSQL = sSQL + "TST_ERT_006 = " + TST_ERT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_006.ToString()))
            {
                sSQL = sSQL + "TST_RT3_006 = " + TST_RT3_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_006.ToString()))
            {
                sSQL = sSQL + "TST_RT5_006 = " + TST_RT5_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_006.ToString()))
            {
                sSQL = sSQL + "TST_DND_006 = " + TST_DND_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_006.ToString()))
            {
                sSQL = sSQL + "TST_DMO_006 = " + TST_DMO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_006.ToString()))
            {
                sSQL = sSQL + "TST_PES_006 = " + TST_PES_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_006))
            {
                sSQL = sSQL + "TST_VRR_006 = '" + TST_VRR_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_006))
            {
                sSQL = sSQL + "TST_TRE_006 = '" + TST_TRE_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_006.ToString()))
            {
                sSQL = sSQL + "TST_LME_006 = " + TST_LME_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_006.ToString()))
            {
                sSQL = sSQL + "TST_UME_006 = " + TST_UME_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_006.ToString()))
            {
                sSQL = sSQL + "TST_LPE_006 = " + TST_LPE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_006.ToString()))
            {
                sSQL = sSQL + "TST_UPE_006 = " + TST_UPE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_006.ToString()))
            {
                sSQL = sSQL + "TST_UCV_006 = " + TST_UCV_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_006.ToString()))
            {
                sSQL = sSQL + "TST_CSO_006 = " + TST_CSO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_006.ToString()))
            {
                sSQL = sSQL + "TST_ESP_006 = " + TST_ESP_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_006))
            {
                sSQL = sSQL + "TST_TOL_006 = '" + TST_TOL_006.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_006.ToString()))
            {
                sSQL = sSQL + "TST_DUR_006 = " + TST_DUR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_006.ToString()))
            {
                sSQL = sSQL + "TST_DFT_006 = " + TST_DFT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_006.ToString()))
            {
                sSQL = sSQL + "TST_LMC_006 = " + TST_LMC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_006.ToString()))
            {
                sSQL = sSQL + "TST_UMC_006 = " + TST_UMC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_006.ToString()))
            {
                sSQL = sSQL + "TST_LPC_006 = " + TST_LPC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_006.ToString()))
            {
                sSQL = sSQL + "TST_UPC_006 = " + TST_UPC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_006.ToString()))
            {
                sSQL = sSQL + "TST_CVC_006 = " + TST_CVC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_006.ToString()))
            {
                sSQL = sSQL + "TST_DFC_006 = " + TST_DFC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_006.ToString()))
            {
                sSQL = sSQL + "TST_TFS_006 = " + TST_TFS_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_006.ToString()))
            {
                sSQL = sSQL + "TST_FSW_006 = " + TST_FSW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_006.ToString()))
            {
                sSQL = sSQL + "TST_WFW_006 = " + TST_WFW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_006.ToString()))
            {
                sSQL = sSQL + "TST_ECO_006 = " + TST_ECO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_006.ToString()))
            {
                sSQL = sSQL + "TST_EOL_006 = " + TST_EOL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_006.ToString()))
            {
                sSQL = sSQL + "TST_ETU_006 = " + TST_ETU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_006.ToString()))
            {
                sSQL = sSQL + "TST_ETD_006 = " + TST_ETD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_006.ToString()))
            {
                sSQL = sSQL + "TST_ECU_006 = " + TST_ECU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_006.ToString()))
            {
                sSQL = sSQL + "TST_EGD_006 = " + TST_EGD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_006.ToString()))
            {
                sSQL = sSQL + "TST_EEC_006 = " + TST_EEC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_006.ToString()))
            {
                sSQL = sSQL + "TST_ECD_006 = " + TST_ECD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_006.ToString()))
            {
                sSQL = sSQL + "TST_EGU_006 = " + TST_EGU_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_006.ToString()))
            {
                sSQL = sSQL + "TST_ESO_006 = " + TST_ESO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_006.ToString()))
            {
                sSQL = sSQL + "TST_ESI_006 = " + TST_ESI_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_006.ToString()))
            {
                sSQL = sSQL + "TST_ECR_006 = " + TST_ECR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_006.ToString()))
            {
                sSQL = sSQL + "TST_EOD_006 = " + TST_EOD_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_006.ToString()))
            {
                sSQL = sSQL + "TST_EAW_006 = " + TST_EAW_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_006.ToString()))
            {
                sSQL = sSQL + "TST_ED1_006 = " + TST_ED1_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_006.ToString()))
            {
                sSQL = sSQL + "TST_ED2_006 = " + TST_ED2_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VW2_007))
            {
                sSQL = sSQL + "TST_VW2_007 = '" + TST_VW2_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VW2_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGM_007))
            {
                sSQL = sSQL + "TST_EGM_007 = '" + TST_EGM_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_EGM_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DYY_007))
            {
                sSQL = sSQL + "TST_DYY_007 = '" + TST_DYY_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DYY_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2WX_007))
            {
                sSQL = sSQL + "TST_2WX_007 = '" + TST_2WX_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2WX_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_3W3_007))
            {
                sSQL = sSQL + "TST_3W3_007 = '" + TST_3W3_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_3W3_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_4W4_007))
            {
                sSQL = sSQL + "TST_4W4_007 = '" + TST_4W4_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_4W4_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AGL_007))
            {
                sSQL = sSQL + "TST_AGL_007 = '" + TST_AGL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_AGL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUP_007))
            {
                sSQL = sSQL + "TST_TUP_007 = '" + TST_TUP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUP_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VEO_007))
            {
                sSQL = sSQL + "TST_VEO_007 = '" + TST_VEO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VEO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1T_007))
            {
                sSQL = sSQL + "TST_T1T_007 = '" + TST_T1T_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1T_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1C_007))
            {
                sSQL = sSQL + "TST_T1C_007 = '" + TST_T1C_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1C_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T1L_007))
            {
                sSQL = sSQL + "TST_T1L_007 = '" + TST_T1L_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T1L_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T2F_007))
            {
                sSQL = sSQL + "TST_T2F_007 = '" + TST_T2F_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T2F_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVE_007))
            {
                sSQL = sSQL + "TST_SVE_007 = '" + TST_SVE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STF_007))
            {
                sSQL = sSQL + "TST_STF_007 = '" + TST_STF_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STF_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STM_007))
            {
                sSQL = sSQL + "TST_STM_007 = '" + TST_STM_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_STM_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCE_007))
            {
                sSQL = sSQL + "TST_SCE_007 = '" + TST_SCE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCO_007))
            {
                sSQL = sSQL + "TST_SCO_007 = '" + TST_SCO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCH_007))
            {
                sSQL = sSQL + "TST_SCH_007 = '" + TST_SCH_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCH_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SCG_007))
            {
                sSQL = sSQL + "TST_SCG_007 = '" + TST_SCG_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SCG_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEE_007))
            {
                sSQL = sSQL + "TST_SEE_007 = '" + TST_SEE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEO_007))
            {
                sSQL = sSQL + "TST_SEO_007 = '" + TST_SEO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEH_007))
            {
                sSQL = sSQL + "TST_SEH_007 = '" + TST_SEH_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEH_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SEG_007))
            {
                sSQL = sSQL + "TST_SEG_007 = '" + TST_SEG_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SEG_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJC_007))
            {
                sSQL = sSQL + "TST_SJC_007 = '" + TST_SJC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJT_007))
            {
                sSQL = sSQL + "TST_SJT_007 = '" + TST_SJT_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJB_007))
            {
                sSQL = sSQL + "TST_SJB_007 = '" + TST_SJB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SJB_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPJ_007))
            {
                sSQL = sSQL + "TST_SPJ_007 = '" + TST_SPJ_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPJ_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SBC_007))
            {
                sSQL = sSQL + "TST_SBC_007 = '" + TST_SBC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SBC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SPO_007))
            {
                sSQL = sSQL + "TST_SPO_007 = '" + TST_SPO_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SPO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SVA_007))
            {
                sSQL = sSQL + "TST_SVA_007 = '" + TST_SVA_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_SVA_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TGR_007))
            {
                sSQL = sSQL + "TST_TGR_007 = '" + TST_TGR_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TGR_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIP_007))
            {
                sSQL = sSQL + "TST_TIP_007 = '" + TST_TIP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TIP_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DSB_007))
            {
                sSQL = sSQL + "TST_DSB_007 = '" + TST_DSB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DSB_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCA_007))
            {
                sSQL = sSQL + "TST_TCA_007 = '" + TST_TCA_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCA_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FMC_007))
            {
                sSQL = sSQL + "TST_FMC_007 = '" + TST_FMC_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_FMC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1TB_007))
            {
                sSQL = sSQL + "TST_1TB_007 = '" + TST_1TB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1TB_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_1PP_007))
            {
                sSQL = sSQL + "TST_1PP_007 = '" + TST_1PP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_1PP_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2TB_007))
            {
                sSQL = sSQL + "TST_2TB_007 = '" + TST_2TB_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2TB_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_2PP_007))
            {
                sSQL = sSQL + "TST_2PP_007 = '" + TST_2PP_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_2PP_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P1C_007))
            {
                sSQL = sSQL + "TST_P1C_007 = '" + TST_P1C_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P1C_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P2D_007))
            {
                sSQL = sSQL + "TST_P2D_007 = '" + TST_P2D_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P2D_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P3D_007))
            {
                sSQL = sSQL + "TST_P3D_007 = '" + TST_P3D_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P3D_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_P4U_007))
            {
                sSQL = sSQL + "TST_P4U_007 = '" + TST_P4U_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_P4U_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_MOL_007))
            {
                sSQL = sSQL + "TST_MOL_007 = '" + TST_MOL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_MOL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TPD_007))
            {
                sSQL = sSQL + "TST_TPD_007 = '" + TST_TPD_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TPD_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT1_007))
            {
                sSQL = sSQL + "TST_TT1_007 = '" + TST_TT1_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT1_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT2_007))
            {
                sSQL = sSQL + "TST_TT2_007 = '" + TST_TT2_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT2_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TT3_007))
            {
                sSQL = sSQL + "TST_TT3_007 = '" + TST_TT3_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TT3_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_T21_007))
            {
                sSQL = sSQL + "TST_T21_007 = '" + TST_T21_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_T21_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TUN_007))
            {
                sSQL = sSQL + "TST_TUN_007 = '" + TST_TUN_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TUN_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TCV_007))
            {
                sSQL = sSQL + "TST_TCV_007 = '" + TST_TCV_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TCV_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TSS_007))
            {
                sSQL = sSQL + "TST_TSS_007 = '" + TST_TSS_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TSS_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TIT_007.ToString()))
            {
                sSQL = sSQL + "TST_TIT_007 = " + TST_TIT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TIT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TNC_007.ToString()))
            {
                sSQL = sSQL + "TST_TNC_007 = " + TST_TNC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TNC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_AON_007.ToString()))
            {
                sSQL = sSQL + "TST_AON_007 = " + TST_AON_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_AON_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ENM_007.ToString()))
            {
                sSQL = sSQL + "TST_ENM_007 = " + TST_ENM_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ENM_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEE_007.ToString()))
            {
                sSQL = sSQL + "TST_EEE_007 = " + TST_EEE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_KKK_007.ToString()))
            {
                sSQL = sSQL + "TST_KKK_007 = " + TST_KKK_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_KKK_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_BBB_007.ToString()))
            {
                sSQL = sSQL + "TST_BBB_007 = " + TST_BBB_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_BBB_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OLE_007.ToString()))
            {
                sSQL = sSQL + "TST_OLE_007 = " + TST_OLE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_OLE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRQ_007.ToString()))
            {
                sSQL = sSQL + "TST_TRQ_007 = " + TST_TRQ_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TRQ_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ERT_007.ToString()))
            {
                sSQL = sSQL + "TST_ERT_007 = " + TST_ERT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ERT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT3_007.ToString()))
            {
                sSQL = sSQL + "TST_RT3_007 = " + TST_RT3_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT3_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_RT5_007.ToString()))
            {
                sSQL = sSQL + "TST_RT5_007 = " + TST_RT5_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_RT5_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DND_007.ToString()))
            {
                sSQL = sSQL + "TST_DND_007 = " + TST_DND_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DND_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DMO_007.ToString()))
            {
                sSQL = sSQL + "TST_DMO_007 = " + TST_DMO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DMO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PES_007.ToString()))
            {
                sSQL = sSQL + "TST_PES_007 = " + TST_PES_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PES_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VRR_007))
            {
                sSQL = sSQL + "TST_VRR_007 = '" + TST_VRR_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_VRR_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TRE_007))
            {
                sSQL = sSQL + "TST_TRE_007 = '" + TST_TRE_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TRE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LME_007.ToString()))
            {
                sSQL = sSQL + "TST_LME_007 = " + TST_LME_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LME_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UME_007.ToString()))
            {
                sSQL = sSQL + "TST_UME_007 = " + TST_UME_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UME_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPE_007.ToString()))
            {
                sSQL = sSQL + "TST_LPE_007 = " + TST_LPE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPE_007.ToString()))
            {
                sSQL = sSQL + "TST_UPE_007 = " + TST_UPE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UCV_007.ToString()))
            {
                sSQL = sSQL + "TST_UCV_007 = " + TST_UCV_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UCV_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CSO_007.ToString()))
            {
                sSQL = sSQL + "TST_CSO_007 = " + TST_CSO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CSO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESP_007.ToString()))
            {
                sSQL = sSQL + "TST_ESP_007 = " + TST_ESP_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESP_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TOL_007))
            {
                sSQL = sSQL + "TST_TOL_007 = '" + TST_TOL_007.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_TOL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DUR_007.ToString()))
            {
                sSQL = sSQL + "TST_DUR_007 = " + TST_DUR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DUR_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFT_007.ToString()))
            {
                sSQL = sSQL + "TST_DFT_007 = " + TST_DFT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LMC_007.ToString()))
            {
                sSQL = sSQL + "TST_LMC_007 = " + TST_LMC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LMC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UMC_007.ToString()))
            {
                sSQL = sSQL + "TST_UMC_007 = " + TST_UMC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UMC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_LPC_007.ToString()))
            {
                sSQL = sSQL + "TST_LPC_007 = " + TST_LPC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_LPC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_UPC_007.ToString()))
            {
                sSQL = sSQL + "TST_UPC_007 = " + TST_UPC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_UPC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_CVC_007.ToString()))
            {
                sSQL = sSQL + "TST_CVC_007 = " + TST_CVC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_CVC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DFC_007.ToString()))
            {
                sSQL = sSQL + "TST_DFC_007 = " + TST_DFC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DFC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TFS_007.ToString()))
            {
                sSQL = sSQL + "TST_TFS_007 = " + TST_TFS_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TFS_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_FSW_007.ToString()))
            {
                sSQL = sSQL + "TST_FSW_007 = " + TST_FSW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_FSW_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_WFW_007.ToString()))
            {
                sSQL = sSQL + "TST_WFW_007 = " + TST_WFW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_WFW_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECO_007.ToString()))
            {
                sSQL = sSQL + "TST_ECO_007 = " + TST_ECO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOL_007.ToString()))
            {
                sSQL = sSQL + "TST_EOL_007 = " + TST_EOL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETU_007.ToString()))
            {
                sSQL = sSQL + "TST_ETU_007 = " + TST_ETU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETU_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ETD_007.ToString()))
            {
                sSQL = sSQL + "TST_ETD_007 = " + TST_ETD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ETD_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECU_007.ToString()))
            {
                sSQL = sSQL + "TST_ECU_007 = " + TST_ECU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECU_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGD_007.ToString()))
            {
                sSQL = sSQL + "TST_EGD_007 = " + TST_EGD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGD_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EEC_007.ToString()))
            {
                sSQL = sSQL + "TST_EEC_007 = " + TST_EEC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EEC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECD_007.ToString()))
            {
                sSQL = sSQL + "TST_ECD_007 = " + TST_ECD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECD_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EGU_007.ToString()))
            {
                sSQL = sSQL + "TST_EGU_007 = " + TST_EGU_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EGU_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESO_007.ToString()))
            {
                sSQL = sSQL + "TST_ESO_007 = " + TST_ESO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ESI_007.ToString()))
            {
                sSQL = sSQL + "TST_ESI_007 = " + TST_ESI_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ESI_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ECR_007.ToString()))
            {
                sSQL = sSQL + "TST_ECR_007 = " + TST_ECR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ECR_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EOD_007.ToString()))
            {
                sSQL = sSQL + "TST_EOD_007 = " + TST_EOD_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EOD_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_EAW_007.ToString()))
            {
                sSQL = sSQL + "TST_EAW_007 = " + TST_EAW_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_EAW_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED1_007.ToString()))
            {
                sSQL = sSQL + "TST_ED1_007 = " + TST_ED1_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED1_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_ED2_007.ToString()))
            {
                sSQL = sSQL + "TST_ED2_007 = " + TST_ED2_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_ED2_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_REF.ToString()))
            {
                sSQL = sSQL + "TST_PCO_REF = " + TST_PCO_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_REF.ToString()))
            {
                sSQL = sSQL + "TST_PCV_REF = " + TST_PCV_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_REF.ToString()))
            {
                sSQL = sSQL + "TST_DRT_REF = " + TST_DRT_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_REF.ToString()))
            {
                sSQL = sSQL + "TST_TAL_REF = " + TST_TAL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_REF.ToString()))
            {
                sSQL = sSQL + "TST_VAL_REF = " + TST_VAL_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_REF.ToString()))
            {
                sSQL = sSQL + "TST_SJE_REF = " + TST_SJE_REF.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_001.ToString()))
            {
                sSQL = sSQL + "TST_PCO_001 = " + TST_PCO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_001.ToString()))
            {
                sSQL = sSQL + "TST_PCV_001 = " + TST_PCV_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_001.ToString()))
            {
                sSQL = sSQL + "TST_DRT_001 = " + TST_DRT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_001.ToString()))
            {
                sSQL = sSQL + "TST_TAL_001 = " + TST_TAL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_001.ToString()))
            {
                sSQL = sSQL + "TST_VAL_001 = " + TST_VAL_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_001.ToString()))
            {
                sSQL = sSQL + "TST_SJE_001 = " + TST_SJE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_002.ToString()))
            {
                sSQL = sSQL + "TST_PCO_002 = " + TST_PCO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_002.ToString()))
            {
                sSQL = sSQL + "TST_PCV_002 = " + TST_PCV_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_002.ToString()))
            {
                sSQL = sSQL + "TST_DRT_002 = " + TST_DRT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_002.ToString()))
            {
                sSQL = sSQL + "TST_TAL_002 = " + TST_TAL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_002.ToString()))
            {
                sSQL = sSQL + "TST_VAL_002 = " + TST_VAL_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_002.ToString()))
            {
                sSQL = sSQL + "TST_SJE_002 = " + TST_SJE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_003.ToString()))
            {
                sSQL = sSQL + "TST_PCO_003 = " + TST_PCO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_003.ToString()))
            {
                sSQL = sSQL + "TST_PCV_003 = " + TST_PCV_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_003.ToString()))
            {
                sSQL = sSQL + "TST_DRT_003 = " + TST_DRT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_003.ToString()))
            {
                sSQL = sSQL + "TST_TAL_003 = " + TST_TAL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_003.ToString()))
            {
                sSQL = sSQL + "TST_VAL_003 = " + TST_VAL_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_003.ToString()))
            {
                sSQL = sSQL + "TST_SJE_003 = " + TST_SJE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_004.ToString()))
            {
                sSQL = sSQL + "TST_PCO_004 = " + TST_PCO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_004.ToString()))
            {
                sSQL = sSQL + "TST_PCV_004 = " + TST_PCV_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_004.ToString()))
            {
                sSQL = sSQL + "TST_DRT_004 = " + TST_DRT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_004.ToString()))
            {
                sSQL = sSQL + "TST_TAL_004 = " + TST_TAL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_004.ToString()))
            {
                sSQL = sSQL + "TST_VAL_004 = " + TST_VAL_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_004.ToString()))
            {
                sSQL = sSQL + "TST_SJE_004 = " + TST_SJE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_005.ToString()))
            {
                sSQL = sSQL + "TST_PCO_005 = " + TST_PCO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_005.ToString()))
            {
                sSQL = sSQL + "TST_PCV_005 = " + TST_PCV_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_005.ToString()))
            {
                sSQL = sSQL + "TST_DRT_005 = " + TST_DRT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_005.ToString()))
            {
                sSQL = sSQL + "TST_TAL_005 = " + TST_TAL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_005.ToString()))
            {
                sSQL = sSQL + "TST_VAL_005 = " + TST_VAL_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_005.ToString()))
            {
                sSQL = sSQL + "TST_SJE_005 = " + TST_SJE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_006.ToString()))
            {
                sSQL = sSQL + "TST_PCO_006 = " + TST_PCO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_006.ToString()))
            {
                sSQL = sSQL + "TST_PCV_006 = " + TST_PCV_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_006.ToString()))
            {
                sSQL = sSQL + "TST_DRT_006 = " + TST_DRT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_006.ToString()))
            {
                sSQL = sSQL + "TST_TAL_006 = " + TST_TAL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_006.ToString()))
            {
                sSQL = sSQL + "TST_VAL_006 = " + TST_VAL_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_006.ToString()))
            {
                sSQL = sSQL + "TST_SJE_006 = " + TST_SJE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCO_007.ToString()))
            {
                sSQL = sSQL + "TST_PCO_007 = " + TST_PCO_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCO_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_PCV_007.ToString()))
            {
                sSQL = sSQL + "TST_PCV_007 = " + TST_PCV_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_PCV_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DRT_007.ToString()))
            {
                sSQL = sSQL + "TST_DRT_007 = " + TST_DRT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_DRT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_TAL_007.ToString()))
            {
                sSQL = sSQL + "TST_TAL_007 = " + TST_TAL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_TAL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_VAL_007.ToString()))
            {
                sSQL = sSQL + "TST_VAL_007 = " + TST_VAL_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_VAL_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_SJE_007.ToString()))
            {
                sSQL = sSQL + "TST_SJE_007 = " + TST_SJE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_SJE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_DET))
            {
                sSQL = sSQL + "TST_DET = '" + TST_DET.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_DET = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_OBS))
            {
                sSQL = sSQL + "TST_OBS = '" + TST_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TST_OBS = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_STS.ToString()))
            {
                sSQL = sSQL + "TST_STS = " + TST_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(TST_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "TST_USR_ALT_ID = " + TST_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TST_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "TST_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE TST_ID = " + TST_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM TST";
            sSQL = sSQL + " WHERE TST_ID = " + TST_ID;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT * ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " * ";
            }
            sSQL = sSQL + " FROM TST";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = TST_MAQ_TIP_ID";

            if (!String.IsNullOrEmpty(Convert.ToString(TST_ID)))
            {
                sCond = sCond + " TST_ID = " + TST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_RTS_ID)))
            {
                sCond = sCond + " TST_RTS_ID = " + TST_RTS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_RTS_MTV_TST_ID)))
            {
                sCond = sCond + " TST_RTS_MTV_TST_ID = " + TST_RTS_MTV_TST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_TIT_POY_ID)))
            {
                sCond = sCond + " TST_TIT_POY_ID = " + TST_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_FOR_001_ID)))
            {
                sCond = sCond + " TST_FOR_001_ID = " + TST_FOR_001_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_FOR_002_ID)))
            {
                sCond = sCond + " TST_FOR_002_ID = " + TST_FOR_002_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_FOR_003_ID)))
            {
                sCond = sCond + " TST_FOR_003_ID = " + TST_FOR_003_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_APS_ID)))
            {
                sCond = sCond + " TST_APS_ID = " + TST_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_MAQ_TIP_ID)))
            {
                sCond = sCond + " TST_MAQ_TIP_ID = " + TST_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_ERT_ID)))
            {
                sCond = sCond + " TST_ERT_ID = " + TST_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_INI)))
            {
                sCond = sCond + " TST_DAT_INI BETWEEN Convert(datetime, '" + TST_DAT_INI + "',103) AND Convert(datetime, '" + TST_DAT_INI + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_INI_INI)))
            {
                sCond = sCond + " TST_DAT_INI >= Convert(datetime, '" + TST_DAT_INI_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_INI_FIM)))
            {
                sCond = sCond + " TST_DAT_INI <= Convert(datetime, '" + TST_DAT_INI_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_FIM)))
            {
                sCond = sCond + " TST_DAT_FIM BETWEEN Convert(datetime, '" + TST_DAT_FIM + "',103) AND Convert(datetime, '" + TST_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_FIM_INI)))
            {
                sCond = sCond + " TST_DAT_FIM >= Convert(datetime, '" + TST_DAT_FIM_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_DAT_FIM_FIM)))
            {
                sCond = sCond + " TST_DAT_FIM <= Convert(datetime, '" + TST_DAT_FIM_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TST_STS)))
            {
                sCond = sCond + " TST_STS = " + TST_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY TST_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}