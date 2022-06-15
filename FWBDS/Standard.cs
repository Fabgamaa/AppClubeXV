using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Standard
    {

        #region Propriedades

        private int? _EPF_ID;
        private DateTime? _EPF_DAT;
        private int? _EPF_VRS;
        private string _EPF_LOT;
        private string _EPF_LOT_REF;
        private int? _EPF_TIT_POY_ID;
        private string _EPF_DES;
        private string _EPF_MGE;
        private string _EPF_MGE_DES_001;
        private int? _EPF_FOR_ID;
        private string _EPF_MGE_002;
        private string _EPF_MGE_DES_002;
        private int? _EPF_FOR_002_ID;
        private string _EPF_MGE_003;
        private string _EPF_MGE_DES_003;
        private int? _EPF_FOR_003_ID;
        private string _EPF_MGE_004;
        private string _EPF_MGE_DES_004;
        private int? _EPF_FOR_004_ID;
        private string _EPF_VLC;
        private int? _EPF_APS_ID;
        private int? _EPF_MAQ_TIP_ID;
        private int? _EPF_ERT_ID;
        private string _EPF_VW2;
        private string _EPF_EGM;
        private string _EPF_DYY;
        private string _EPF_2WX;
        private string _EPF_3W3;
        private string _EPF_4W4;
        private string _EPF_AGL;
        private string _EPF_TUP;
        private string _EPF_VEO;
        private string _EPF_T1T;
        private string _EPF_T1C;
        private string _EPF_T1L;
        private string _EPF_T2F;
        private string _EPF_SVE;
        private string _EPF_STF;
        private string _EPF_STM;
        private string _EPF_SCE;
        private string _EPF_SCO;
        private string _EPF_SCH;
        private string _EPF_SCG;
        private string _EPF_SEE;
        private string _EPF_SEO;
        private string _EPF_SEH;
        private string _EPF_SEG;
        private string _EPF_SJC;
        private string _EPF_SJT;
        private string _EPF_SJB;
        private string _EPF_SPJ;
        private string _EPF_SBC;
        private string _EPF_SPO;
        private string _EPF_SVA;
        private string _EPF_TGR;
        private string _EPF_TIP;
        private string _EPF_DSB;
        private string _EPF_TCA;
        private string _EPF_FMC;
        private string _EPF_1TB;
        private string _EPF_1PP;
        private string _EPF_2TB;
        private string _EPF_2PP;
        private string _EPF_P1C;
        private string _EPF_P2D;
        private string _EPF_P3D;
        private string _EPF_P4U;
        private string _EPF_MOL;
        private string _EPF_TPD;
        private string _EPF_TT1;
        private string _EPF_TT2;
        private string _EPF_TT3;
        private string _EPF_T21;
        private string _EPF_TUN;
        private string _EPF_TCV;
        private string _EPF_TSS;
        private double? _EPF_TIT;
        private double? _EPF_TNC;
        private double? _EPF_AON;
        private double? _EPF_ENM;
        private double? _EPF_EEE;
        private double? _EPF_KKK;
        private double? _EPF_BBB;
        private double? _EPF_OLE;
        private double? _EPF_TRQ;
        private double? _EPF_ERT;
        private double? _EPF_RT3;
        private double? _EPF_RT5;
        private double? _EPF_DND;
        private double? _EPF_DMO;
        private double? _EPF_PES;
        private string _EPF_VRR;
        private string _EPF_TRE;
        private double? _EPF_LME;
        private double? _EPF_UME;
        private double? _EPF_LPE;
        private double? _EPF_UPE;
        private double? _EPF_UCV;
        private double? _EPF_LCV;
        private double? _EPF_CSO;
        private double? _EPF_ESP;
        private string _EPF_TOL;
        private double? _EPF_DUR;
        private double? _EPF_DFT;
        private double? _EPF_LMC;
        private double? _EPF_UMC;
        private double? _EPF_LPC;
        private double? _EPF_UPC;
        private double? _EPF_CVC;
        private double? _EPF_LVC;
        private double? _EPF_DFC;
        private double? _EPF_TFS;
        private double? _EPF_FSW;
        private double? _EPF_WFW;
        private double? _EPF_YBT;
        private int? _EPF_RSP;
        private double? _EPF_ECO;
        private double? _EPF_SPX;
        private string _EPF_GFT;
        private string _EPF_HEM;
        private double? _EPF_VAZ;
        private string _EPF_COT;
        private double? _EPF_CO2;
        private double? _EPF_COC;
        private double? _EPF_COV;
        private double? _EPF_DIM;
        private string _EPF_RSQ;
        private string _EPF_RLQ;
        private int? _EPF_RRM;
        private string _EPF_RMX;
        private string _EPF_RMN;
        private string _EPF_RMH;
        private string _EPF_RQS;
        private int? _EPF_RTY;
        private int? _EPF_RHY;
        private int? _EPF_EOC;
        private int? _EPF_EOE;
        private int? _EPF_ETC;
        private int? _EPF_ETE;
        private int? _EPF_PTN;
        private string _EPF_EOL;
        private string _EPF_ETU;
        private string _EPF_ETD;
        private string _EPF_ECU;
        private string _EPF_EGD;
        private string _EPF_EEC;
        private string _EPF_ECD;
        private string _EPF_EGU;
        private string _EPF_ESO;
        private string _EPF_ESI;
        private string _EPF_ECR;
        private string _EPF_EOD;
        private string _EPF_EAW;
        private string _EPF_ED1;
        private string _EPF_ED2;
        private string _EPF_IDD;
        private string _EPF_PCO;
        private string _EPF_PCV;
        private string _EPF_DRT;
        private string _EPF_TAL;
        private string _EPF_VAL;
        private string _EPF_SJE;
        private string _EPF_ETA;
        private string _EPF_ETH;
        private string _EPF_ETG;
        private string _EPF_EDT;
        private string _EPF_EFP;
        private string _EPF_EYT;
        private string _EPF_EDL;
        private string _EPF_EAB;
        private string _EPF_ECA;
        private string _EPF_ECW;
        private string _EPF_ETL;
        private string _EPF_ETT;
        private string _EPF_ERE;
        private string _EPF_ELE;
        private string _EPF_EPT;
        private string _EPF_EPL;
        private int? _EPF_CTX;
        private int? _EPF_CVX;
        private int? _EPF_CVR;
        private int? _EPF_CRC;
        private int? _EPF_CRE;
        private int? _EPF_CTC;
        private int? _EPF_CTE;
        private int? _EPF_CTS;
        private string _EPF_EGE_001;
        private string _EPF_EGE_DES_001;
        private int? _EPF_EOR_001_ID;
        private string _EPF_EGE_002;
        private string _EPF_EGE_DES_002;
        private int? _EPF_EOR_002_ID;
        private string _EPF_EGE_003;
        private string _EPF_EGE_DES_003;
        private int? _EPF_EOR_003_ID;
        private string _EPF_EGE_004;
        private string _EPF_EGE_DES_004;
        private int? _EPF_EOR_004_ID;
        private int? _EPF_CTN;
        //TMT
        private string _EPF_MAT;
        private string _EPF_CAN;
        private string _EPF_EPU;
        private double? _EPF_PER_MGE;
        private string _EPF_MAT_002;
        private string _EPF_CAN_002;
        private string _EPF_EPU_002;
        private double? _EPF_PER_MGE_002;
        private string _EPF_MAT_003;
        private string _EPF_CAN_003;
        private string _EPF_EPU_003;
        private double? _EPF_PER_MGE_003;
        private string _EPF_MAT_004;
        private string _EPF_CAN_004;
        private string _EPF_EPU_004;
        private double? _EPF_PER_MGE_004;
        private int? _EPF_HOT;
        private string _EPF_VRD;
        private int? _EPF_ACR;
        private int? _EPF_PEN;
        private int? _EPF_CRA;
        private int? _EPF_CLE;
        private int? _EPF_AFO;
        private string _EPF_TCU;
        private string _EPF_TAR;
        private string _EPF_TAM;
        private int? _EPF_DTU;
        private int? _EPF_DPA;
        private int? _EPF_CIN;
        private string _EPF_TIP_FR2;
        private string _EPF_FR2;
        private string _EPF_TIP_FR1;
        private string _EPF_FR1;
        private string _EPF_TIP_FR0;
        private string _EPF_FR0;
        private int? _EPF_ATO;
        private double? _EPF_TP1;
        private double? _EPF_TP2;
        private int? _EPF_TCP;
        private string _EPF_JF2;
        private int? _EPF_PS2;
        private string _EPF_JF0;
        private int? _EPF_PS0;
        private double? _EPF_BBA;
        private string _EPF_GRO;
        private string _EPF_TCS;
        private string _EPF_CVP;
        private int? _EPF_SSV;
        private int? _EPF_SSP;
        private double? _EPF_TTE_001;
        private double? _EPF_TTE_002;
        private string _EPF_WPO_001;
        private string _EPF_WPO_002;
        private string _EPF_DIR_001;
        private string _EPF_DIR_002;
        private int? _EPF_CRA_001;
        private int? _EPF_CRA_002;
        private string _EPF_CED_001;
        private string _EPF_CED_002;
        private string _EPF_TED_001;
        private string _EPF_TED_002;
        private string _EPF_DLE_001;
        private string _EPF_DLE_002;
        private string _EPF_CTI_001;
        private string _EPF_CTI_002;
        private int? _EPF_G1O_001;
        private int? _EPF_G1O_002;
        private int? _EPF_G1U_001;
        private int? _EPF_G1U_002;
        private int? _EPF_G2O_001;
        private int? _EPF_G2O_002;
        private int? _EPF_G2U_001;
        private int? _EPF_G2U_002;
        private int? _EPF_CVP_001;
        private int? _EPF_CVP_002;
        private int? _EPF_OCU_001;
        private int? _EPF_OCU_002;
        private int? _EPF_UCU_001;
        private int? _EPF_UCU_002;
        private int? _EPF_C1O_001;
        private int? _EPF_C1O_002;
        private int? _EPF_L1O_001;
        private int? _EPF_L1O_002;
        private int? _EPF_C1U_001;
        private int? _EPF_C1U_002;
        private int? _EPF_L1U_001;
        private int? _EPF_L1U_002;
        private int? _EPF_C2O_001;
        private int? _EPF_C2O_002;
        private int? _EPF_L2O_001;
        private int? _EPF_L2O_002;
        private int? _EPF_C2U_001;
        private int? _EPF_C2U_002;
        private int? _EPF_L2U_001;
        private int? _EPF_L2U_002;
        private int? _EPF_TSU_001;
        private int? _EPF_TSU_002;
        private int? _EPF_CVC_001;
        private int? _EPF_CVC_002;
        private int? _EPF_CVL_001;
        private int? _EPF_CVL_002;
        private int? _EPF_TLE_001;
        private int? _EPF_TLE_002;
        private string _EPF_ROI;
        private string _EPF_RR0;
        private string _EPF_R01;
        private string _EPF_RR1;
        private string _EPF_RR2;
        private string _EPF_R2A;
        private string _EPF_RR3;
        private string _EPF_RWR;
        private string _EPF_STD;
        private string _EPF_STP;
        private string _EPF_TTD;
        private string _EPF_TTP;
        private string _EPF_FTD;
        private string _EPF_FTP;
        private string _EPF_ITD;
        private string _EPF_ITP;
        private string _EPF_XTD;
        private string _EPF_XTP;
        private string _EPF_TTR;
        private int _EPF_PLY;
        private string _EPF_PLF;
        private string _EPF_PLL;
        private string _EPF_DET;
        private string _EPF_OBS;
        private int? _EPF_RSP_USR_ID;
        private int? _EPF_STS;
        private int? _EPF_USR_INC_ID;
        private int? _EPF_USR_ALT_ID;
        private DateTime? _EPF_TMS_ATL;

        private DateTime? _EPF_DAT_INI;
        private DateTime? _EPF_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? EPF_ID
        {
            get { return _EPF_ID; }
            set { _EPF_ID = value; }
        }
        public DateTime? EPF_DAT
        {
            get { return _EPF_DAT; }
            set { _EPF_DAT = value; }
        }
        public int? EPF_VRS
        {
            get { return _EPF_VRS; }
            set { _EPF_VRS = value; }
        }
        public string EPF_LOT
        {
            get { return _EPF_LOT; }
            set { _EPF_LOT = value.ToUpper(); }
        }
        public string EPF_LOT_REF
        {
            get { return _EPF_LOT_REF; }
            set { _EPF_LOT_REF = value.ToUpper(); }
        }
        public int? EPF_TIT_POY_ID
        {
            get { return _EPF_TIT_POY_ID; }
            set { _EPF_TIT_POY_ID = value; }
        }
        public string EPF_DES
        {
            get { return _EPF_DES; }
            set { _EPF_DES = value.ToUpper(); }
        }
        public string EPF_MGE
        {
            get { return _EPF_MGE; }
            set { _EPF_MGE = value.ToUpper(); }
        }
        public string EPF_MGE_DES_001
        {
            get { return _EPF_MGE_DES_001; }
            set { _EPF_MGE_DES_001 = value.ToUpper(); }
        }
        public int? EPF_FOR_ID
        {
            get { return _EPF_FOR_ID; }
            set { _EPF_FOR_ID = value; }
        }
        public string EPF_MGE_002
        {
            get { return _EPF_MGE_002; }
            set { _EPF_MGE_002 = value.ToUpper(); }
        }
        public string EPF_MGE_DES_002
        {
            get { return _EPF_MGE_DES_002; }
            set { _EPF_MGE_DES_002 = value.ToUpper(); }
        }
        public int? EPF_FOR_002_ID
        {
            get { return _EPF_FOR_002_ID; }
            set { _EPF_FOR_002_ID = value; }
        }
        public string EPF_MGE_003
        {
            get { return _EPF_MGE_003; }
            set { _EPF_MGE_003 = value.ToUpper(); }
        }
        public string EPF_MGE_DES_003
        {
            get { return _EPF_MGE_DES_003; }
            set { _EPF_MGE_DES_003 = value.ToUpper(); }
        }
        public int? EPF_FOR_003_ID
        {
            get { return _EPF_FOR_003_ID; }
            set { _EPF_FOR_003_ID = value; }
        }
        public string EPF_MGE_004
        {
            get { return _EPF_MGE_004; }
            set { _EPF_MGE_004 = value.ToUpper(); }
        }
        public string EPF_MGE_DES_004
        {
            get { return _EPF_MGE_DES_004; }
            set { _EPF_MGE_DES_004 = value.ToUpper(); }
        }
        public int? EPF_FOR_004_ID
        {
            get { return _EPF_FOR_004_ID; }
            set { _EPF_FOR_004_ID = value; }
        }
        public string EPF_VLC
        {
            get { return _EPF_VLC; }
            set { _EPF_VLC = value.ToUpper(); }
        }
        public int? EPF_APS_ID
        {
            get { return _EPF_APS_ID; }
            set { _EPF_APS_ID = value; }
        }
        public int? EPF_MAQ_TIP_ID
        {
            get { return _EPF_MAQ_TIP_ID; }
            set { _EPF_MAQ_TIP_ID = value; }
        }
        public int? EPF_ERT_ID
        {
            get { return _EPF_ERT_ID; }
            set { _EPF_ERT_ID = value; }
        }
        public string EPF_VW2
        {
            get { return _EPF_VW2; }
            set { _EPF_VW2 = value.ToUpper(); }
        }
        public string EPF_EGM
        {
            get { return _EPF_EGM; }
            set { _EPF_EGM = value.ToUpper(); }
        }
        public string EPF_DYY
        {
            get { return _EPF_DYY; }
            set { _EPF_DYY = value.ToUpper(); }
        }
        public string EPF_2WX
        {
            get { return _EPF_2WX; }
            set { _EPF_2WX = value.ToUpper(); }
        }
        public string EPF_3W3
        {
            get { return _EPF_3W3; }
            set { _EPF_3W3 = value.ToUpper(); }
        }
        public string EPF_4W4
        {
            get { return _EPF_4W4; }
            set { _EPF_4W4 = value.ToUpper(); }
        }
        public string EPF_AGL
        {
            get { return _EPF_AGL; }
            set { _EPF_AGL = value.ToUpper(); }
        }
        public string EPF_TUP
        {
            get { return _EPF_TUP; }
            set { _EPF_TUP = value.ToUpper(); }
        }
        public string EPF_VEO
        {
            get { return _EPF_VEO; }
            set { _EPF_VEO = value.ToUpper(); }
        }
        public string EPF_T1T
        {
            get { return _EPF_T1T; }
            set { _EPF_T1T = value.ToUpper(); }
        }
        public string EPF_T1C
        {
            get { return _EPF_T1C; }
            set { _EPF_T1C = value.ToUpper(); }
        }
        public string EPF_T1L
        {
            get { return _EPF_T1L; }
            set { _EPF_T1L = value.ToUpper(); }
        }
        public string EPF_T2F
        {
            get { return _EPF_T2F; }
            set { _EPF_T2F = value.ToUpper(); }
        }
        public string EPF_SVE
        {
            get { return _EPF_SVE; }
            set { _EPF_SVE = value.ToUpper(); }
        }
        public string EPF_STF
        {
            get { return _EPF_STF; }
            set { _EPF_STF = value.ToUpper(); }
        }
        public string EPF_STM
        {
            get { return _EPF_STM; }
            set { _EPF_STM = value.ToUpper(); }
        }
        public string EPF_SCE
        {
            get { return _EPF_SCE; }
            set { _EPF_SCE = value.ToUpper(); }
        }
        public string EPF_SCO
        {
            get { return _EPF_SCO; }
            set { _EPF_SCO = value.ToUpper(); }
        }
        public string EPF_SCH
        {
            get { return _EPF_SCH; }
            set { _EPF_SCH = value.ToUpper(); }
        }
        public string EPF_SCG
        {
            get { return _EPF_SCG; }
            set { _EPF_SCG = value.ToUpper(); }
        }
        public string EPF_SEE
        {
            get { return _EPF_SEE; }
            set { _EPF_SEE = value.ToUpper(); }
        }
        public string EPF_SEO
        {
            get { return _EPF_SEO; }
            set { _EPF_SEO = value.ToUpper(); }
        }
        public string EPF_SEH
        {
            get { return _EPF_SEH; }
            set { _EPF_SEH = value.ToUpper(); }
        }
        public string EPF_SEG
        {
            get { return _EPF_SEG; }
            set { _EPF_SEG = value.ToUpper(); }
        }
        public string EPF_SJC
        {
            get { return _EPF_SJC; }
            set { _EPF_SJC = value.ToUpper(); }
        }
        public string EPF_SJT
        {
            get { return _EPF_SJT; }
            set { _EPF_SJT = value.ToUpper(); }
        }
        public string EPF_SJB
        {
            get { return _EPF_SJB; }
            set { _EPF_SJB = value.ToUpper(); }
        }
        public string EPF_SPJ
        {
            get { return _EPF_SPJ; }
            set { _EPF_SPJ = value.ToUpper(); }
        }
        public string EPF_SBC
        {
            get { return _EPF_SBC; }
            set { _EPF_SBC = value.ToUpper(); }
        }
        public string EPF_SPO
        {
            get { return _EPF_SPO; }
            set { _EPF_SPO = value.ToUpper(); }
        }
        public string EPF_SVA
        {
            get { return _EPF_SVA; }
            set { _EPF_SVA = value.ToUpper(); }
        }
        public string EPF_TGR
        {
            get { return _EPF_TGR; }
            set { _EPF_TGR = value.ToUpper(); }
        }
        public string EPF_TIP
        {
            get { return _EPF_TIP; }
            set { _EPF_TIP = value.ToUpper(); }
        }
        public string EPF_DSB
        {
            get { return _EPF_DSB; }
            set { _EPF_DSB = value.ToUpper(); }
        }
        public string EPF_TCA
        {
            get { return _EPF_TCA; }
            set { _EPF_TCA = value.ToUpper(); }
        }
        public string EPF_FMC
        {
            get { return _EPF_FMC; }
            set { _EPF_FMC = value.ToUpper(); }
        }
        public string EPF_1TB
        {
            get { return _EPF_1TB; }
            set { _EPF_1TB = value.ToUpper(); }
        }
        public string EPF_1PP
        {
            get { return _EPF_1PP; }
            set { _EPF_1PP = value.ToUpper(); }
        }
        public string EPF_2TB
        {
            get { return _EPF_2TB; }
            set { _EPF_2TB = value.ToUpper(); }
        }
        public string EPF_2PP
        {
            get { return _EPF_2PP; }
            set { _EPF_2PP = value.ToUpper(); }
        }
        public string EPF_P1C
        {
            get { return _EPF_P1C; }
            set { _EPF_P1C = value.ToUpper(); }
        }
        public string EPF_P2D
        {
            get { return _EPF_P2D; }
            set { _EPF_P2D = value.ToUpper(); }
        }
        public string EPF_P3D
        {
            get { return _EPF_P3D; }
            set { _EPF_P3D = value.ToUpper(); }
        }
        public string EPF_P4U
        {
            get { return _EPF_P4U; }
            set { _EPF_P4U = value.ToUpper(); }
        }
        public string EPF_MOL
        {
            get { return _EPF_MOL; }
            set { _EPF_MOL = value.ToUpper(); }
        }
        public string EPF_TPD
        {
            get { return _EPF_TPD; }
            set { _EPF_TPD = value.ToUpper(); }
        }
        public string EPF_TT1
        {
            get { return _EPF_TT1; }
            set { _EPF_TT1 = value.ToUpper(); }
        }
        public string EPF_TT2
        {
            get { return _EPF_TT2; }
            set { _EPF_TT2 = value.ToUpper(); }
        }
        public string EPF_TT3
        {
            get { return _EPF_TT3; }
            set { _EPF_TT3 = value.ToUpper(); }
        }
        public string EPF_T21
        {
            get { return _EPF_T21; }
            set { _EPF_T21 = value.ToUpper(); }
        }
        public string EPF_TUN
        {
            get { return _EPF_TUN; }
            set { _EPF_TUN = value.ToUpper(); }
        }
        public string EPF_TCV
        {
            get { return _EPF_TCV; }
            set { _EPF_TCV = value.ToUpper(); }
        }
        public string EPF_TSS
        {
            get { return _EPF_TSS; }
            set { _EPF_TSS = value.ToUpper(); }
        }
        public double? EPF_TIT
        {
            get { return _EPF_TIT; }
            set { _EPF_TIT = value; }
        }
        public double? EPF_TNC
        {
            get { return _EPF_TNC; }
            set { _EPF_TNC = value; }
        }
        public double? EPF_AON
        {
            get { return _EPF_AON; }
            set { _EPF_AON = value; }
        }
        public double? EPF_ENM
        {
            get { return _EPF_ENM; }
            set { _EPF_ENM = value; }
        }
        public double? EPF_EEE
        {
            get { return _EPF_EEE; }
            set { _EPF_EEE = value; }
        }
        public double? EPF_KKK
        {
            get { return _EPF_KKK; }
            set { _EPF_KKK = value; }
        }
        public double? EPF_BBB
        {
            get { return _EPF_BBB; }
            set { _EPF_BBB = value; }
        }
        public double? EPF_OLE
        {
            get { return _EPF_OLE; }
            set { _EPF_OLE = value; }
        }
        public double? EPF_TRQ
        {
            get { return _EPF_TRQ; }
            set { _EPF_TRQ = value; }
        }
        public double? EPF_ERT
        {
            get { return _EPF_ERT; }
            set { _EPF_ERT = value; }
        }
        public double? EPF_RT3
        {
            get { return _EPF_RT3; }
            set { _EPF_RT3 = value; }
        }
        public double? EPF_RT5
        {
            get { return _EPF_RT5; }
            set { _EPF_RT5 = value; }
        }
        public double? EPF_DND
        {
            get { return _EPF_DND; }
            set { _EPF_DND = value; }
        }
        public double? EPF_DMO
        {
            get { return _EPF_DMO; }
            set { _EPF_DMO = value; }
        }
        public double? EPF_PES
        {
            get { return _EPF_PES; }
            set { _EPF_PES = value; }
        }
        public string EPF_VRR
        {
            get { return _EPF_VRR; }
            set { _EPF_VRR = value.ToUpper(); }
        }
        public string EPF_TRE
        {
            get { return _EPF_TRE; }
            set { _EPF_TRE = value.ToUpper(); }
        }
        public double? EPF_LME
        {
            get { return _EPF_LME; }
            set { _EPF_LME = value; }
        }
        public double? EPF_UME
        {
            get { return _EPF_UME; }
            set { _EPF_UME = value; }
        }
        public double? EPF_LPE
        {
            get { return _EPF_LPE; }
            set { _EPF_LPE = value; }
        }
        public double? EPF_UPE
        {
            get { return _EPF_UPE; }
            set { _EPF_UPE = value; }
        }
        public double? EPF_UCV
        {
            get { return _EPF_UCV; }
            set { _EPF_UCV = value; }
        }
        public double? EPF_LCV
        {
            get { return _EPF_LCV; }
            set { _EPF_LCV = value; }
        }
        public double? EPF_CSO
        {
            get { return _EPF_CSO; }
            set { _EPF_CSO = value; }
        }
        public double? EPF_ESP
        {
            get { return _EPF_ESP; }
            set { _EPF_ESP = value; }
        }
        public string EPF_TOL
        {
            get { return _EPF_TOL; }
            set { _EPF_TOL = value.ToUpper(); }
        }
        public double? EPF_DUR
        {
            get { return _EPF_DUR; }
            set { _EPF_DUR = value; }
        }
        public double? EPF_DFT
        {
            get { return _EPF_DFT; }
            set { _EPF_DFT = value; }
        }
        public double? EPF_LMC
        {
            get { return _EPF_LMC; }
            set { _EPF_LMC = value; }
        }
        public double? EPF_UMC
        {
            get { return _EPF_UMC; }
            set { _EPF_UMC = value; }
        }
        public double? EPF_LPC
        {
            get { return _EPF_LPC; }
            set { _EPF_LPC = value; }
        }
        public double? EPF_UPC
        {
            get { return _EPF_UPC; }
            set { _EPF_UPC = value; }
        }
        public double? EPF_CVC
        {
            get { return _EPF_CVC; }
            set { _EPF_CVC = value; }
        }
        public double? EPF_LVC
        {
            get { return _EPF_LVC; }
            set { _EPF_LVC = value; }
        }
        public double? EPF_DFC
        {
            get { return _EPF_DFC; }
            set { _EPF_DFC = value; }
        }
        public double? EPF_TFS
        {
            get { return _EPF_TFS; }
            set { _EPF_TFS = value; }
        }
        public double? EPF_FSW
        {
            get { return _EPF_FSW; }
            set { _EPF_FSW = value; }
        }
        public double? EPF_WFW
        {
            get { return _EPF_WFW; }
            set { _EPF_WFW = value; }
        }
        public double? EPF_YBT
        {
            get { return _EPF_YBT; }
            set { _EPF_YBT = value; }
        }
        public int? EPF_RSP
        {
            get { return _EPF_RSP; }
            set { _EPF_RSP = value; }
        }
        public double? EPF_ECO
        {
            get { return _EPF_ECO; }
            set { _EPF_ECO = value; }
        }
        public double? EPF_SPX
        {
            get { return _EPF_SPX; }
            set { _EPF_SPX = value; }
        }
        public string EPF_GFT
        {
            get { return _EPF_GFT; }
            set { _EPF_GFT = value.ToUpper(); }
        }
        public string EPF_HEM
        {
            get { return _EPF_HEM; }
            set { _EPF_HEM = value.ToUpper(); }
        }
        public double? EPF_VAZ
        {
            get { return _EPF_VAZ; }
            set { _EPF_VAZ = value; }
        }
        public string EPF_COT
        {
            get { return _EPF_COT; }
            set { _EPF_COT = value.ToUpper(); }
        }
        public double? EPF_CO2
        {
            get { return _EPF_CO2; }
            set { _EPF_CO2 = value; }
        }
        public double? EPF_COC
        {
            get { return _EPF_COC; }
            set { _EPF_COC = value; }
        }
        public double? EPF_COV
        {
            get { return _EPF_COV; }
            set { _EPF_COV = value; }
        }
        public double? EPF_DIM
        {
            get { return _EPF_DIM; }
            set { _EPF_DIM = value; }
        }
        public string EPF_RSQ
        {
            get { return _EPF_RSQ; }
            set { _EPF_RSQ = value.ToUpper(); }
        }
        public string EPF_RLQ
        {
            get { return _EPF_RLQ; }
            set { _EPF_RLQ = value.ToUpper(); }
        }
        public int? EPF_RRM
        {
            get { return _EPF_RRM; }
            set { _EPF_RRM = value; }
        }
        public string EPF_RMX
        {
            get { return _EPF_RMX; }
            set { _EPF_RMX = value.ToUpper(); }
        }
        public string EPF_RMN
        {
            get { return _EPF_RMN; }
            set { _EPF_RMN = value.ToUpper(); }
        }
        public string EPF_RMH
        {
            get { return _EPF_RMH; }
            set { _EPF_RMH = value.ToUpper(); }
        }
        public string EPF_RQS
        {
            get { return _EPF_RQS; }
            set { _EPF_RQS = value.ToUpper(); }
        }
        public int? EPF_RTY
        {
            get { return _EPF_RTY; }
            set { _EPF_RTY = value; }
        }
        public int? EPF_RHY
        {
            get { return _EPF_RHY; }
            set { _EPF_RHY = value; }
        }
        public int? EPF_EOC
        {
            get { return _EPF_EOC; }
            set { _EPF_EOC = value; }
        }
        public int? EPF_EOE
        {
            get { return _EPF_EOE; }
            set { _EPF_EOE = value; }
        }
        public int? EPF_ETC
        {
            get { return _EPF_ETC; }
            set { _EPF_ETC = value; }
        }
        public int? EPF_ETE
        {
            get { return _EPF_ETE; }
            set { _EPF_ETE = value; }
        }
        public int? EPF_PTN
        {
            get { return _EPF_PTN; }
            set { _EPF_PTN = value; }
        }
        public string EPF_EOL
        {
            get { return _EPF_EOL; }
            set { _EPF_EOL = value; }
        }
        public string EPF_ETU
        {
            get { return _EPF_ETU; }
            set { _EPF_ETU = value; }
        }
        public string EPF_ETD
        {
            get { return _EPF_ETD; }
            set { _EPF_ETD = value; }
        }
        public string EPF_ECU
        {
            get { return _EPF_ECU; }
            set { _EPF_ECU = value; }
        }
        public string EPF_EGD
        {
            get { return _EPF_EGD; }
            set { _EPF_EGD = value; }
        }
        public string EPF_EEC
        {
            get { return _EPF_EEC; }
            set { _EPF_EEC = value; }
        }
        public string EPF_ECD
        {
            get { return _EPF_ECD; }
            set { _EPF_ECD = value; }
        }
        public string EPF_EGU
        {
            get { return _EPF_EGU; }
            set { _EPF_EGU = value; }
        }
        public string EPF_ESO
        {
            get { return _EPF_ESO; }
            set { _EPF_ESO = value; }
        }
        public string EPF_ESI
        {
            get { return _EPF_ESI; }
            set { _EPF_ESI = value; }
        }
        public string EPF_ECR
        {
            get { return _EPF_ECR; }
            set { _EPF_ECR = value; }
        }
        public string EPF_EOD
        {
            get { return _EPF_EOD; }
            set { _EPF_EOD = value; }
        }
        public string EPF_EAW
        {
            get { return _EPF_EAW; }
            set { _EPF_EAW = value; }
        }
        public string EPF_ED1
        {
            get { return _EPF_ED1; }
            set { _EPF_ED1 = value; }
        }
        public string EPF_ED2
        {
            get { return _EPF_ED2; }
            set { _EPF_ED2 = value; }
        }
        public string EPF_IDD
        {
            get { return _EPF_IDD; }
            set { _EPF_IDD = value; }
        }
        public string EPF_PCO
        {
            get { return _EPF_PCO; }
            set { _EPF_PCO = value; }
        }
        public string EPF_PCV
        {
            get { return _EPF_PCV; }
            set { _EPF_PCV = value; }
        }
        public string EPF_DRT
        {
            get { return _EPF_DRT; }
            set { _EPF_DRT = value; }
        }
        public string EPF_TAL
        {
            get { return _EPF_TAL; }
            set { _EPF_TAL = value; }
        }
        public string EPF_VAL
        {
            get { return _EPF_VAL; }
            set { _EPF_VAL = value; }
        }
        public string EPF_SJE
        {
            get { return _EPF_SJE; }
            set { _EPF_SJE = value; }
        }
        public string EPF_ETA
        {
            get { return _EPF_ETA; }
            set { _EPF_ETA = value.ToUpper(); }
        }
        public string EPF_ETH
        {
            get { return _EPF_ETH; }
            set { _EPF_ETH = value.ToUpper(); }
        }
        public string EPF_ETG
        {
            get { return _EPF_ETG; }
            set { _EPF_ETG = value.ToUpper(); }
        }
        public string EPF_EDT
        {
            get { return _EPF_EDT; }
            set { _EPF_EDT = value.ToUpper(); }
        }
        public string EPF_EFP
        {
            get { return _EPF_EFP; }
            set { _EPF_EFP = value.ToUpper(); }
        }
        public string EPF_EYT
        {
            get { return _EPF_EYT; }
            set { _EPF_EYT = value.ToUpper(); }
        }
        public string EPF_EDL
        {
            get { return _EPF_EDL; }
            set { _EPF_EDL = value.ToUpper(); }
        }
        public string EPF_EAB
        {
            get { return _EPF_EAB; }
            set { _EPF_EAB = value.ToUpper(); }
        }
        public string EPF_ECA
        {
            get { return _EPF_ECA; }
            set { _EPF_ECA = value.ToUpper(); }
        }
        public string EPF_ECW
        {
            get { return _EPF_ECW; }
            set { _EPF_ECW = value.ToUpper(); }
        }
        public string EPF_ETL
        {
            get { return _EPF_ETL; }
            set { _EPF_ETL = value.ToUpper(); }
        }
        public string EPF_ETT
        {
            get { return _EPF_ETT; }
            set { _EPF_ETT = value.ToUpper(); }
        }
        public string EPF_ERE
        {
            get { return _EPF_ERE; }
            set { _EPF_ERE = value.ToUpper(); }
        }
        public string EPF_ELE
        {
            get { return _EPF_ELE; }
            set { _EPF_ELE = value.ToUpper(); }
        }
        public string EPF_EPT
        {
            get { return _EPF_EPT; }
            set { _EPF_EPT = value.ToUpper(); }
        }
        public string EPF_EPL
        {
            get { return _EPF_EPL; }
            set { _EPF_EPL = value.ToUpper(); }
        }
        public int? EPF_CTX
        {
            get { return _EPF_CTX; }
            set { _EPF_CTX = value; }
        }
        public int? EPF_CVX
        {
            get { return _EPF_CVX; }
            set { _EPF_CVX = value; }
        }
        public int? EPF_CVR
        {
            get { return _EPF_CVR; }
            set { _EPF_CVR = value; }
        }
        public int? EPF_CRC
        {
            get { return _EPF_CRC; }
            set { _EPF_CRC = value; }
        }
        public int? EPF_CRE
        {
            get { return _EPF_CRE; }
            set { _EPF_CRE = value; }
        }
        public int? EPF_CTC
        {
            get { return _EPF_CTC; }
            set { _EPF_CTC = value; }
        }
        public int? EPF_CTE
        {
            get { return _EPF_CTE; }
            set { _EPF_CTE = value; }
        }
        public int? EPF_CTS
        {
            get { return _EPF_CTS; }
            set { _EPF_CTS = value; }
        }
        public string EPF_EGE_001
        {
            get { return _EPF_EGE_001; }
            set { _EPF_EGE_001 = value.ToUpper(); }
        }
        public string EPF_EGE_DES_001
        {
            get { return _EPF_EGE_DES_001; }
            set { _EPF_EGE_DES_001 = value.ToUpper(); }
        }
        public int? EPF_EOR_001_ID
        {
            get { return _EPF_EOR_001_ID; }
            set { _EPF_EOR_001_ID = value; }
        }
        public string EPF_EGE_002
        {
            get { return _EPF_EGE_002; }
            set { _EPF_EGE_002 = value.ToUpper(); }
        }
        public string EPF_EGE_DES_002
        {
            get { return _EPF_EGE_DES_002; }
            set { _EPF_EGE_DES_002 = value.ToUpper(); }
        }
        public int? EPF_EOR_002_ID
        {
            get { return _EPF_EOR_002_ID; }
            set { _EPF_EOR_002_ID = value; }
        }
        public string EPF_EGE_003
        {
            get { return _EPF_EGE_003; }
            set { _EPF_EGE_003 = value.ToUpper(); }
        }
        public string EPF_EGE_DES_003
        {
            get { return _EPF_EGE_DES_003; }
            set { _EPF_EGE_DES_003 = value.ToUpper(); }
        }
        public int? EPF_EOR_003_ID
        {
            get { return _EPF_EOR_003_ID; }
            set { _EPF_EOR_003_ID = value; }
        }
        public string EPF_EGE_004
        {
            get { return _EPF_EGE_004; }
            set { _EPF_EGE_004 = value.ToUpper(); }
        }
        public string EPF_EGE_DES_004
        {
            get { return _EPF_EGE_DES_004; }
            set { _EPF_EGE_DES_004 = value.ToUpper(); }
        }
        public int? EPF_EOR_004_ID
        {
            get { return _EPF_EOR_004_ID; }
            set { _EPF_EOR_004_ID = value; }
        }
        public int? EPF_CTN
        {
            get { return _EPF_CTN; }
            set { _EPF_CTN = value; }
        }
        //TMT
        public string EPF_MAT
        {
            get { return _EPF_MAT; }
            set { _EPF_MAT = value.ToUpper(); }
        }
        public string EPF_CAN
        {
            get { return _EPF_CAN; }
            set { _EPF_CAN = value.ToUpper(); }
        }
        public string EPF_EPU
        {
            get { return _EPF_EPU; }
            set { _EPF_EPU = value.ToUpper(); }
        }
        public double? EPF_PER_MGE
        {
            get { return _EPF_PER_MGE; }
            set { _EPF_PER_MGE = value; }
        }
        public string EPF_MAT_002
        {
            get { return _EPF_MAT_002; }
            set { _EPF_MAT_002 = value.ToUpper(); }
        }
        public string EPF_CAN_002
        {
            get { return _EPF_CAN_002; }
            set { _EPF_CAN_002 = value.ToUpper(); }
        }
        public string EPF_EPU_002
        {
            get { return _EPF_EPU_002; }
            set { _EPF_EPU_002 = value.ToUpper(); }
        }
        public double? EPF_PER_MGE_002
        {
            get { return _EPF_PER_MGE_002; }
            set { _EPF_PER_MGE_002 = value; }
        }
        public string EPF_MAT_003
        {
            get { return _EPF_MAT_003; }
            set { _EPF_MAT_003 = value.ToUpper(); }
        }
        public string EPF_CAN_003
        {
            get { return _EPF_CAN_003; }
            set { _EPF_CAN_003 = value.ToUpper(); }
        }
        public string EPF_EPU_003
        {
            get { return _EPF_EPU_003; }
            set { _EPF_EPU_003 = value.ToUpper(); }
        }
        public double? EPF_PER_MGE_003
        {
            get { return _EPF_PER_MGE_003; }
            set { _EPF_PER_MGE_003 = value; }
        }
        public string EPF_MAT_004
        {
            get { return _EPF_MAT_004; }
            set { _EPF_MAT_004 = value.ToUpper(); }
        }
        public string EPF_CAN_004
        {
            get { return _EPF_CAN_004; }
            set { _EPF_CAN_004 = value.ToUpper(); }
        }
        public string EPF_EPU_004
        {
            get { return _EPF_EPU_004; }
            set { _EPF_EPU_004 = value.ToUpper(); }
        }
        public double? EPF_PER_MGE_004
        {
            get { return _EPF_PER_MGE_004; }
            set { _EPF_PER_MGE_004 = value; }
        }
        public int? EPF_HOT
        {
            get { return _EPF_HOT; }
            set { _EPF_HOT = value; }
        }
        public string EPF_VRD
        {
            get { return _EPF_VRD; }
            set { _EPF_VRD = value.ToUpper(); }
        }
        public int? EPF_ACR
        {
            get { return _EPF_ACR; }
            set { _EPF_ACR = value; }
        }
        public int? EPF_PEN
        {
            get { return _EPF_PEN; }
            set { _EPF_PEN = value; }
        }
        public int? EPF_CRA
        {
            get { return _EPF_CRA; }
            set { _EPF_CRA = value; }
        }
        public int? EPF_CLE
        {
            get { return _EPF_CLE; }
            set { _EPF_CLE = value; }
        }
        public int? EPF_AFO
        {
            get { return _EPF_AFO; }
            set { _EPF_AFO = value; }
        }
        public string EPF_TCU
        {
            get { return _EPF_TCU; }
            set { _EPF_TCU = value.ToUpper(); }
        }
        public string EPF_TAR
        {
            get { return _EPF_TAR; }
            set { _EPF_TAR = value; }
        }
        public string EPF_TAM
        {
            get { return _EPF_TAM; }
            set { _EPF_TAM = value.ToUpper(); }
        }
        public int? EPF_DTU
        {
            get { return _EPF_DTU; }
            set { _EPF_DTU = value; }
        }
        public int? EPF_DPA
        {
            get { return _EPF_DPA; }
            set { _EPF_DPA = value; }
        }
        public int? EPF_CIN
        {
            get { return _EPF_CIN; }
            set { _EPF_CIN = value; }
        }
        public string EPF_TIP_FR2
        {
            get { return _EPF_TIP_FR2; }
            set { _EPF_TIP_FR2 = value.ToUpper(); }
        }
        public string EPF_FR2
        {
            get { return _EPF_FR2; }
            set { _EPF_FR2 = value.ToUpper(); }
        }
        public string EPF_TIP_FR1
        {
            get { return _EPF_TIP_FR1; }
            set { _EPF_TIP_FR1 = value.ToUpper(); }
        }
        public string EPF_FR1
        {
            get { return _EPF_FR1; }
            set { _EPF_FR1 = value.ToUpper(); }
        }
        public string EPF_TIP_FR0
        {
            get { return _EPF_TIP_FR0; }
            set { _EPF_TIP_FR0 = value.ToUpper(); }
        }
        public string EPF_FR0
        {
            get { return _EPF_FR0; }
            set { _EPF_FR0 = value.ToUpper(); }
        }
        public int? EPF_ATO
        {
            get { return _EPF_ATO; }
            set { _EPF_ATO = value; }
        }
        public double? EPF_TP1
        {
            get { return _EPF_TP1; }
            set { _EPF_TP1 = value; }
        }
        public double? EPF_TP2
        {
            get { return _EPF_TP2; }
            set { _EPF_TP2 = value; }
        }
        public int? EPF_TCP
        {
            get { return _EPF_TCP; }
            set { _EPF_TCP = value; }
        }
        public string EPF_JF2
        {
            get { return _EPF_JF2; }
            set { _EPF_JF2 = value.ToUpper(); }
        }
        public int? EPF_PS2
        {
            get { return _EPF_PS2; }
            set { _EPF_PS2 = value; }
        }
        public string EPF_JF0
        {
            get { return _EPF_JF0; }
            set { _EPF_JF0 = value.ToUpper(); }
        }
        public int? EPF_PS0
        {
            get { return _EPF_PS0; }
            set { _EPF_PS0 = value; }
        }
        public double? EPF_BBA
        {
            get { return _EPF_BBA; }
            set { _EPF_BBA = value; }
        }
        public string EPF_GRO
        {
            get { return _EPF_GRO; }
            set { _EPF_GRO = value.ToUpper(); }
        }
        public string EPF_TCS
        {
            get { return _EPF_TCS; }
            set { _EPF_TCS = value.ToUpper(); }
        }
        public string EPF_CVP
        {
            get { return _EPF_CVP; }
            set { _EPF_CVP = value.ToUpper(); }
        }
        public int? EPF_SSV
        {
            get { return _EPF_SSV; }
            set { _EPF_SSV = value; }
        }
        public int? EPF_SSP
        {
            get { return _EPF_SSP; }
            set { _EPF_SSP = value; }
        }
        public double? EPF_TTE_001
        {
            get { return _EPF_TTE_001; }
            set { _EPF_TTE_001 = value; }
        }
        public double? EPF_TTE_002
        {
            get { return _EPF_TTE_002; }
            set { _EPF_TTE_002 = value; }
        }
        public string EPF_WPO_001
        {
            get { return _EPF_WPO_001; }
            set { _EPF_WPO_001 = value.ToUpper(); }
        }
        public string EPF_WPO_002
        {
            get { return _EPF_WPO_002; }
            set { _EPF_WPO_002 = value.ToUpper(); }
        }
        public string EPF_DIR_001
        {
            get { return _EPF_DIR_001; }
            set { _EPF_DIR_001 = value.ToUpper(); }
        }
        public string EPF_DIR_002
        {
            get { return _EPF_DIR_002; }
            set { _EPF_DIR_002 = value.ToUpper(); }
        }
        public int? EPF_CRA_001
        {
            get { return _EPF_CRA_001; }
            set { _EPF_CRA_001 = value; }
        }
        public int? EPF_CRA_002
        {
            get { return _EPF_CRA_002; }
            set { _EPF_CRA_002 = value; }
        }
        public string EPF_CED_001
        {
            get { return _EPF_CED_001; }
            set { _EPF_CED_001 = value.ToUpper(); }
        }
        public string EPF_CED_002
        {
            get { return _EPF_CED_002; }
            set { _EPF_CED_002 = value.ToUpper(); }
        }
        public string EPF_TED_001
        {
            get { return _EPF_TED_001; }
            set { _EPF_TED_001 = value.ToUpper(); }
        }
        public string EPF_TED_002
        {
            get { return _EPF_TED_002; }
            set { _EPF_TED_002 = value.ToUpper(); }
        }
        public string EPF_DLE_001
        {
            get { return _EPF_DLE_001; }
            set { _EPF_DLE_001 = value.ToUpper(); }
        }
        public string EPF_DLE_002
        {
            get { return _EPF_DLE_002; }
            set { _EPF_DLE_002 = value.ToUpper(); }
        }
        public string EPF_CTI_001
        {
            get { return _EPF_CTI_001; }
            set { _EPF_CTI_001 = value.ToUpper(); }
        }
        public string EPF_CTI_002
        {
            get { return _EPF_CTI_002; }
            set { _EPF_CTI_002 = value.ToUpper(); }
        }
        public int? EPF_G1O_001
        {
            get { return _EPF_G1O_001; }
            set { _EPF_G1O_001 = value; }
        }
        public int? EPF_G1O_002
        {
            get { return _EPF_G1O_002; }
            set { _EPF_G1O_002 = value; }
        }
        public int? EPF_G1U_001
        {
            get { return _EPF_G1U_001; }
            set { _EPF_G1U_001 = value; }
        }
        public int? EPF_G1U_002
        {
            get { return _EPF_G1U_002; }
            set { _EPF_G1U_002 = value; }
        }
        public int? EPF_G2O_001
        {
            get { return _EPF_G2O_001; }
            set { _EPF_G2O_001 = value; }
        }
        public int? EPF_G2O_002
        {
            get { return _EPF_G2O_002; }
            set { _EPF_G2O_002 = value; }
        }
        public int? EPF_G2U_001
        {
            get { return _EPF_G2U_001; }
            set { _EPF_G2U_001 = value; }
        }
        public int? EPF_G2U_002
        {
            get { return _EPF_G2U_002; }
            set { _EPF_G2U_002 = value; }
        }
        public int? EPF_CVP_001
        {
            get { return _EPF_CVP_001; }
            set { _EPF_CVP_001 = value; }
        }
        public int? EPF_CVP_002
        {
            get { return _EPF_CVP_002; }
            set { _EPF_CVP_002 = value; }
        }
        public int? EPF_OCU_001
        {
            get { return _EPF_OCU_001; }
            set { _EPF_OCU_001 = value; }
        }
        public int? EPF_OCU_002
        {
            get { return _EPF_OCU_002; }
            set { _EPF_OCU_002 = value; }
        }
        public int? EPF_UCU_001
        {
            get { return _EPF_UCU_001; }
            set { _EPF_UCU_001 = value; }
        }
        public int? EPF_UCU_002
        {
            get { return _EPF_UCU_002; }
            set { _EPF_UCU_002 = value; }
        }
        public int? EPF_C1O_001
        {
            get { return _EPF_C1O_001; }
            set { _EPF_C1O_001 = value; }
        }
        public int? EPF_C1O_002
        {
            get { return _EPF_C1O_002; }
            set { _EPF_C1O_002 = value; }
        }
        public int? EPF_L1O_001
        {
            get { return _EPF_L1O_001; }
            set { _EPF_L1O_001 = value; }
        }
        public int? EPF_L1O_002
        {
            get { return _EPF_L1O_002; }
            set { _EPF_L1O_002 = value; }
        }
        public int? EPF_C1U_001
        {
            get { return _EPF_C1U_001; }
            set { _EPF_C1U_001 = value; }
        }
        public int? EPF_C1U_002
        {
            get { return _EPF_C1U_002; }
            set { _EPF_C1U_002 = value; }
        }
        public int? EPF_L1U_001
        {
            get { return _EPF_L1U_001; }
            set { _EPF_L1U_001 = value; }
        }
        public int? EPF_L1U_002
        {
            get { return _EPF_L1U_002; }
            set { _EPF_L1U_002 = value; }
        }
        public int? EPF_C2O_001
        {
            get { return _EPF_C2O_001; }
            set { _EPF_C2O_001 = value; }
        }
        public int? EPF_C2O_002
        {
            get { return _EPF_C2O_002; }
            set { _EPF_C2O_002 = value; }
        }
        public int? EPF_L2O_001
        {
            get { return _EPF_L2O_001; }
            set { _EPF_L2O_001 = value; }
        }
        public int? EPF_L2O_002
        {
            get { return _EPF_L2O_002; }
            set { _EPF_L2O_002 = value; }
        }
        public int? EPF_C2U_001
        {
            get { return _EPF_C2U_001; }
            set { _EPF_C2U_001 = value; }
        }
        public int? EPF_C2U_002
        {
            get { return _EPF_C2U_002; }
            set { _EPF_C2U_002 = value; }
        }
        public int? EPF_L2U_001
        {
            get { return _EPF_L2U_001; }
            set { _EPF_L2U_001 = value; }
        }
        public int? EPF_L2U_002
        {
            get { return _EPF_L2U_002; }
            set { _EPF_L2U_002 = value; }
        }
        public int? EPF_TSU_001
        {
            get { return _EPF_TSU_001; }
            set { _EPF_TSU_001 = value; }
        }
        public int? EPF_TSU_002
        {
            get { return _EPF_TSU_002; }
            set { _EPF_TSU_002 = value; }
        }
        public int? EPF_CVC_001
        {
            get { return _EPF_CVC_001; }
            set { _EPF_CVC_001 = value; }
        }
        public int? EPF_CVC_002
        {
            get { return _EPF_CVC_002; }
            set { _EPF_CVC_002 = value; }
        }
        public int? EPF_CVL_001
        {
            get { return _EPF_CVL_001; }
            set { _EPF_CVL_001 = value; }
        }
        public int? EPF_CVL_002
        {
            get { return _EPF_CVL_002; }
            set { _EPF_CVL_002 = value; }
        }
        public int? EPF_TLE_001
        {
            get { return _EPF_TLE_001; }
            set { _EPF_TLE_001 = value; }
        }
        public int? EPF_TLE_002
        {
            get { return _EPF_TLE_002; }
            set { _EPF_TLE_002 = value; }
        }
        public string EPF_ROI
        {
            get { return _EPF_ROI; }
            set { _EPF_ROI = value.ToUpper(); }
        }
        public string EPF_RR0
        {
            get { return _EPF_RR0; }
            set { _EPF_RR0 = value.ToUpper(); }
        }
        public string EPF_R01
        {
            get { return _EPF_R01; }
            set { _EPF_R01 = value.ToUpper(); }
        }
        public string EPF_RR1
        {
            get { return _EPF_RR1; }
            set { _EPF_RR1 = value.ToUpper(); }
        }
        public string EPF_RR2
        {
            get { return _EPF_RR2; }
            set { _EPF_RR2 = value.ToUpper(); }
        }
        public string EPF_R2A
        {
            get { return _EPF_R2A; }
            set { _EPF_R2A = value.ToUpper(); }
        }
        public string EPF_RR3
        {
            get { return _EPF_RR3; }
            set { _EPF_RR3 = value.ToUpper(); }
        }
        public string EPF_RWR
        {
            get { return _EPF_RWR; }
            set { _EPF_RWR = value.ToUpper(); }
        }
        public string EPF_STD
        {
            get { return _EPF_STD; }
            set { _EPF_STD = value.ToUpper(); }
        }
        public string EPF_STP
        {
            get { return _EPF_STP; }
            set { _EPF_STP = value.ToUpper(); }
        }
        public string EPF_TTD
        {
            get { return _EPF_TTD; }
            set { _EPF_TTD = value.ToUpper(); }
        }
        public string EPF_TTP
        {
            get { return _EPF_TTP; }
            set { _EPF_TTP = value.ToUpper(); }
        }
        public string EPF_FTD
        {
            get { return _EPF_FTD; }
            set { _EPF_FTD = value.ToUpper(); }
        }
        public string EPF_FTP
        {
            get { return _EPF_FTP; }
            set { _EPF_FTP = value.ToUpper(); }
        }
        public string EPF_ITD
        {
            get { return _EPF_ITD; }
            set { _EPF_ITD = value.ToUpper(); }
        }
        public string EPF_ITP
        {
            get { return _EPF_ITP; }
            set { _EPF_ITP = value.ToUpper(); }
        }
        public string EPF_XTD
        {
            get { return _EPF_XTD; }
            set { _EPF_XTD = value.ToUpper(); }
        }
        public string EPF_XTP
        {
            get { return _EPF_XTP; }
            set { _EPF_XTP = value.ToUpper(); }
        }
        public string EPF_TTR
        {
            get { return _EPF_TTR; }
            set { _EPF_TTR = value.ToUpper(); }
        }
        public int EPF_PLY
        {
            get { return _EPF_PLY; }
            set { _EPF_PLY = value; }
        }
        public string EPF_PLF
        {
            get { return _EPF_PLF; }
            set { _EPF_PLF = value.ToUpper(); }
        }
        public string EPF_PLL
        {
            get { return _EPF_PLL; }
            set { _EPF_PLL = value.ToUpper(); }
        }

        public string EPF_DET
        {
            get { return _EPF_DET; }
            set { _EPF_DET = value.ToUpper(); }
        }
        public string EPF_OBS
        {
            get { return _EPF_OBS; }
            set { _EPF_OBS = value.ToUpper(); }
        }
        public int? EPF_RSP_USR_ID
        {
            get { return _EPF_RSP_USR_ID; }
            set { _EPF_RSP_USR_ID = value; }
        }
        public int? EPF_STS
        {
            get { return _EPF_STS; }
            set { _EPF_STS = value; }
        }
        public int? EPF_USR_INC_ID
        {
            get { return _EPF_USR_INC_ID; }
            set { _EPF_USR_INC_ID = value; }
        }
        public int? EPF_USR_ALT_ID
        {
            get { return _EPF_USR_ALT_ID; }
            set { _EPF_USR_ALT_ID = value; }
        }
        public DateTime? EPF_TMS_ATL
        {
            get { return _EPF_TMS_ATL; }
            set { _EPF_TMS_ATL = value; }
        }

        public DateTime? EPF_DAT_INI
        {
            get { return _EPF_DAT_INI; }
            set { _EPF_DAT_INI = value; }
        }

        public DateTime? EPF_DAT_FIM
        {
            get { return _EPF_DAT_FIM; }
            set { _EPF_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO EPF (";
            sSQL = sSQL + "EPF_DAT, ";
            sSQL = sSQL + "EPF_VRS, ";
            sSQL = sSQL + "EPF_LOT, ";
            sSQL = sSQL + "EPF_LOT_REF, ";
            sSQL = sSQL + "EPF_TIT_POY_ID, ";
            sSQL = sSQL + "EPF_DES, ";
            sSQL = sSQL + "EPF_MGE, ";
            sSQL = sSQL + "EPF_MGE_DES_001, ";
            sSQL = sSQL + "EPF_FOR_ID, ";
            sSQL = sSQL + "EPF_MGE_002, ";
            sSQL = sSQL + "EPF_MGE_DES_002, ";
            sSQL = sSQL + "EPF_FOR_002_ID, ";
            sSQL = sSQL + "EPF_MGE_003, ";
            sSQL = sSQL + "EPF_MGE_DES_003, ";
            sSQL = sSQL + "EPF_FOR_003_ID, ";
            sSQL = sSQL + "EPF_MGE_004, ";
            sSQL = sSQL + "EPF_MGE_DES_004, ";
            sSQL = sSQL + "EPF_FOR_004_ID, ";
            sSQL = sSQL + "EPF_VLC, ";
            sSQL = sSQL + "EPF_APS_ID, ";
            sSQL = sSQL + "EPF_MAQ_TIP_ID, ";
            sSQL = sSQL + "EPF_ERT_ID, ";
            sSQL = sSQL + "EPF_VW2, ";
            sSQL = sSQL + "EPF_EGM, ";
            sSQL = sSQL + "EPF_DYY, ";
            sSQL = sSQL + "EPF_2WX, ";
            sSQL = sSQL + "EPF_3W3, ";
            sSQL = sSQL + "EPF_4W4, ";
            sSQL = sSQL + "EPF_AGL, ";
            sSQL = sSQL + "EPF_TUP, ";
            sSQL = sSQL + "EPF_VEO, ";
            sSQL = sSQL + "EPF_T1T, ";
            sSQL = sSQL + "EPF_T1C, ";
            sSQL = sSQL + "EPF_T1L, ";
            sSQL = sSQL + "EPF_T2F, ";
            sSQL = sSQL + "EPF_SVE, ";
            sSQL = sSQL + "EPF_STF, ";
            sSQL = sSQL + "EPF_STM, ";
            sSQL = sSQL + "EPF_SCE, ";
            sSQL = sSQL + "EPF_SCO, ";
            sSQL = sSQL + "EPF_SCH, ";
            sSQL = sSQL + "EPF_SCG, ";
            sSQL = sSQL + "EPF_SEE, ";
            sSQL = sSQL + "EPF_SEO, ";
            sSQL = sSQL + "EPF_SEH, ";
            sSQL = sSQL + "EPF_SEG, ";
            sSQL = sSQL + "EPF_SJC, ";
            sSQL = sSQL + "EPF_SJT, ";
            sSQL = sSQL + "EPF_SJB, ";
            sSQL = sSQL + "EPF_SPJ, ";
            sSQL = sSQL + "EPF_SBC, ";
            sSQL = sSQL + "EPF_SPO, ";
            sSQL = sSQL + "EPF_SVA, ";
            sSQL = sSQL + "EPF_TGR, ";
            sSQL = sSQL + "EPF_TIP, ";
            sSQL = sSQL + "EPF_DSB, ";
            sSQL = sSQL + "EPF_TCA, ";
            sSQL = sSQL + "EPF_FMC, ";
            sSQL = sSQL + "EPF_1TB, ";
            sSQL = sSQL + "EPF_1PP, ";
            sSQL = sSQL + "EPF_2TB, ";
            sSQL = sSQL + "EPF_2PP, ";
            sSQL = sSQL + "EPF_P1C, ";
            sSQL = sSQL + "EPF_P2D, ";
            sSQL = sSQL + "EPF_P3D, ";
            sSQL = sSQL + "EPF_P4U, ";
            sSQL = sSQL + "EPF_MOL, ";
            sSQL = sSQL + "EPF_TPD, ";
            sSQL = sSQL + "EPF_TT1, ";
            sSQL = sSQL + "EPF_TT2, ";
            sSQL = sSQL + "EPF_TT3, ";
            sSQL = sSQL + "EPF_T21, ";
            sSQL = sSQL + "EPF_TUN, ";
            sSQL = sSQL + "EPF_TCV, ";
            sSQL = sSQL + "EPF_TSS, ";
            sSQL = sSQL + "EPF_TIT, ";
            sSQL = sSQL + "EPF_TNC, ";
            sSQL = sSQL + "EPF_AON, ";
            sSQL = sSQL + "EPF_ENM, ";
            sSQL = sSQL + "EPF_EEE, ";
            sSQL = sSQL + "EPF_KKK, ";
            sSQL = sSQL + "EPF_BBB, ";
            sSQL = sSQL + "EPF_OLE, ";
            sSQL = sSQL + "EPF_TRQ, ";
            sSQL = sSQL + "EPF_ERT, ";
            sSQL = sSQL + "EPF_RT3, ";
            sSQL = sSQL + "EPF_RT5, ";
            sSQL = sSQL + "EPF_DND, ";
            sSQL = sSQL + "EPF_DMO, ";
            sSQL = sSQL + "EPF_PES, ";
            sSQL = sSQL + "EPF_VRR, ";
            sSQL = sSQL + "EPF_TRE, ";
            sSQL = sSQL + "EPF_LME, ";
            sSQL = sSQL + "EPF_UME, ";
            sSQL = sSQL + "EPF_LPE, ";
            sSQL = sSQL + "EPF_UPE, ";
            sSQL = sSQL + "EPF_UCV, ";
            sSQL = sSQL + "EPF_LCV, ";
            sSQL = sSQL + "EPF_CSO, ";
            sSQL = sSQL + "EPF_ESP, ";
            sSQL = sSQL + "EPF_TOL, ";
            sSQL = sSQL + "EPF_DUR, ";
            sSQL = sSQL + "EPF_DFT, ";
            sSQL = sSQL + "EPF_LMC, ";
            sSQL = sSQL + "EPF_UMC, ";
            sSQL = sSQL + "EPF_LPC, ";
            sSQL = sSQL + "EPF_UPC, ";
            sSQL = sSQL + "EPF_CVC, ";
            sSQL = sSQL + "EPF_LVC, ";
            sSQL = sSQL + "EPF_DFC, ";
            sSQL = sSQL + "EPF_TFS, ";
            sSQL = sSQL + "EPF_FSW, ";
            sSQL = sSQL + "EPF_WFW, ";
            sSQL = sSQL + "EPF_YBT, ";
            sSQL = sSQL + "EPF_RSP, ";
            sSQL = sSQL + "EPF_ECO, ";
            sSQL = sSQL + "EPF_SPX, ";
            sSQL = sSQL + "EPF_GFT, ";
            sSQL = sSQL + "EPF_HEM, ";
            sSQL = sSQL + "EPF_VAZ, ";
            sSQL = sSQL + "EPF_COT, ";
            sSQL = sSQL + "EPF_CO2, ";
            sSQL = sSQL + "EPF_COC, ";
            sSQL = sSQL + "EPF_COV, ";
            sSQL = sSQL + "EPF_DIM, ";
            sSQL = sSQL + "EPF_RSQ, ";
            sSQL = sSQL + "EPF_RLQ, ";
            sSQL = sSQL + "EPF_RRM, ";
            sSQL = sSQL + "EPF_RMX, ";
            sSQL = sSQL + "EPF_RMN, ";
            sSQL = sSQL + "EPF_RMH, ";
            sSQL = sSQL + "EPF_RQS, ";
            sSQL = sSQL + "EPF_RTY, ";
            sSQL = sSQL + "EPF_RHY, ";
            sSQL = sSQL + "EPF_EOC, ";
            sSQL = sSQL + "EPF_EOE, ";
            sSQL = sSQL + "EPF_ETC, ";
            sSQL = sSQL + "EPF_ETE, ";
            sSQL = sSQL + "EPF_PTN, ";
            sSQL = sSQL + "EPF_EOL, ";
            sSQL = sSQL + "EPF_ETU, ";
            sSQL = sSQL + "EPF_ETD, ";
            sSQL = sSQL + "EPF_ECU, ";
            sSQL = sSQL + "EPF_EGD, ";
            sSQL = sSQL + "EPF_EEC, ";
            sSQL = sSQL + "EPF_ECD, ";
            sSQL = sSQL + "EPF_EGU, ";
            sSQL = sSQL + "EPF_ESO, ";
            sSQL = sSQL + "EPF_ESI, ";
            sSQL = sSQL + "EPF_ECR, ";
            sSQL = sSQL + "EPF_EOD, ";
            sSQL = sSQL + "EPF_EAW, ";
            sSQL = sSQL + "EPF_ED1, ";
            sSQL = sSQL + "EPF_ED2, ";
            sSQL = sSQL + "EPF_IDD, ";
            sSQL = sSQL + "EPF_PCO, ";
            sSQL = sSQL + "EPF_PCV, ";
            sSQL = sSQL + "EPF_DRT, ";
            sSQL = sSQL + "EPF_TAL, ";
            sSQL = sSQL + "EPF_VAL, ";
            sSQL = sSQL + "EPF_SJE, ";
            sSQL = sSQL + "EPF_ETA, ";
            sSQL = sSQL + "EPF_ETH, ";
            sSQL = sSQL + "EPF_ETG, ";
            sSQL = sSQL + "EPF_EDT, ";
            sSQL = sSQL + "EPF_EFP, ";
            sSQL = sSQL + "EPF_EYT, ";
            sSQL = sSQL + "EPF_EDL, ";
            sSQL = sSQL + "EPF_EAB, ";
            sSQL = sSQL + "EPF_ECA, ";
            sSQL = sSQL + "EPF_ECW, ";
            sSQL = sSQL + "EPF_ETL, ";
            sSQL = sSQL + "EPF_ETT, ";
            sSQL = sSQL + "EPF_ERE, ";
            sSQL = sSQL + "EPF_ELE, ";
            sSQL = sSQL + "EPF_EPT, ";
            sSQL = sSQL + "EPF_EPL, ";
            sSQL = sSQL + "EPF_CTX, ";
            sSQL = sSQL + "EPF_CVX, ";
            sSQL = sSQL + "EPF_CVR, ";
            sSQL = sSQL + "EPF_CRC, ";
            sSQL = sSQL + "EPF_CRE, ";
            sSQL = sSQL + "EPF_CTC, ";
            sSQL = sSQL + "EPF_CTE, ";
            sSQL = sSQL + "EPF_CTS, ";
            sSQL = sSQL + "EPF_EGE_001, ";
            sSQL = sSQL + "EPF_EGE_DES_001, ";
            sSQL = sSQL + "EPF_EOR_001_ID, ";
            sSQL = sSQL + "EPF_EGE_002, ";
            sSQL = sSQL + "EPF_EGE_DES_002, ";
            sSQL = sSQL + "EPF_EOR_002_ID, ";
            sSQL = sSQL + "EPF_EGE_003, ";
            sSQL = sSQL + "EPF_EGE_DES_003, ";
            sSQL = sSQL + "EPF_EOR_003_ID, ";
            sSQL = sSQL + "EPF_EGE_004, ";
            sSQL = sSQL + "EPF_EGE_DES_004, ";
            sSQL = sSQL + "EPF_EOR_004_ID, ";
            sSQL = sSQL + "EPF_CTN, ";
            //TMT
            sSQL = sSQL + "EPF_MAT, ";
            sSQL = sSQL + "EPF_CAN, ";
            sSQL = sSQL + "EPF_EPU, ";
            sSQL = sSQL + "EPF_PER_MGE, ";
            sSQL = sSQL + "EPF_MAT_002, ";
            sSQL = sSQL + "EPF_CAN_002, ";
            sSQL = sSQL + "EPF_EPU_002, ";
            sSQL = sSQL + "EPF_PER_MGE_002, ";
            sSQL = sSQL + "EPF_MAT_003, ";
            sSQL = sSQL + "EPF_CAN_003, ";
            sSQL = sSQL + "EPF_EPU_003, ";
            sSQL = sSQL + "EPF_PER_MGE_003, ";
            sSQL = sSQL + "EPF_MAT_004, ";
            sSQL = sSQL + "EPF_CAN_004, ";
            sSQL = sSQL + "EPF_EPU_004, ";
            sSQL = sSQL + "EPF_PER_MGE_004, ";
            sSQL = sSQL + "EPF_HOT, ";
            sSQL = sSQL + "EPF_VRD, ";
            sSQL = sSQL + "EPF_ACR, ";
            sSQL = sSQL + "EPF_PEN, ";
            sSQL = sSQL + "EPF_CRA, ";
            sSQL = sSQL + "EPF_CLE, ";
            sSQL = sSQL + "EPF_AFO, ";
            sSQL = sSQL + "EPF_TCU, ";
            sSQL = sSQL + "EPF_TAR, ";
            sSQL = sSQL + "EPF_TAM, ";
            sSQL = sSQL + "EPF_DTU, ";
            sSQL = sSQL + "EPF_DPA, ";
            sSQL = sSQL + "EPF_CIN, ";
            sSQL = sSQL + "EPF_TIP_FR2, ";
            sSQL = sSQL + "EPF_FR2, ";
            sSQL = sSQL + "EPF_TIP_FR1, ";
            sSQL = sSQL + "EPF_FR1, ";
            sSQL = sSQL + "EPF_TIP_FR0, ";
            sSQL = sSQL + "EPF_FR0, ";
            sSQL = sSQL + "EPF_ATO, ";
            sSQL = sSQL + "EPF_TP1, ";
            sSQL = sSQL + "EPF_TP2, ";
            sSQL = sSQL + "EPF_TCP, ";
            sSQL = sSQL + "EPF_JF2, ";
            sSQL = sSQL + "EPF_PS2, ";
            sSQL = sSQL + "EPF_JF0, ";
            sSQL = sSQL + "EPF_PS0, ";
            sSQL = sSQL + "EPF_BBA, ";
            sSQL = sSQL + "EPF_GRO, ";
            sSQL = sSQL + "EPF_TCS, ";
            sSQL = sSQL + "EPF_CVP, ";
            sSQL = sSQL + "EPF_SSV, ";
            sSQL = sSQL + "EPF_SSP, ";
            sSQL = sSQL + "EPF_TTE_001, ";
            sSQL = sSQL + "EPF_TTE_002, ";
            sSQL = sSQL + "EPF_WPO_001, ";
            sSQL = sSQL + "EPF_WPO_002, ";
            sSQL = sSQL + "EPF_DIR_001, ";
            sSQL = sSQL + "EPF_DIR_002, ";
            sSQL = sSQL + "EPF_CRA_001, ";
            sSQL = sSQL + "EPF_CRA_002, ";
            sSQL = sSQL + "EPF_CED_001, ";
            sSQL = sSQL + "EPF_CED_002, ";
            sSQL = sSQL + "EPF_TED_001, ";
            sSQL = sSQL + "EPF_TED_002, ";
            sSQL = sSQL + "EPF_DLE_001, ";
            sSQL = sSQL + "EPF_DLE_002, ";
            sSQL = sSQL + "EPF_CTI_001, ";
            sSQL = sSQL + "EPF_CTI_002, ";
            sSQL = sSQL + "EPF_G1O_001, ";
            sSQL = sSQL + "EPF_G1O_002, ";
            sSQL = sSQL + "EPF_G1U_001, ";
            sSQL = sSQL + "EPF_G1U_002, ";
            sSQL = sSQL + "EPF_G2O_001, ";
            sSQL = sSQL + "EPF_G2O_002, ";
            sSQL = sSQL + "EPF_G2U_001, ";
            sSQL = sSQL + "EPF_G2U_002, ";
            sSQL = sSQL + "EPF_CVP_001, ";
            sSQL = sSQL + "EPF_CVP_002, ";
            sSQL = sSQL + "EPF_OCU_001, ";
            sSQL = sSQL + "EPF_OCU_002, ";
            sSQL = sSQL + "EPF_UCU_001, ";
            sSQL = sSQL + "EPF_UCU_002, ";
            sSQL = sSQL + "EPF_C1O_001, ";
            sSQL = sSQL + "EPF_C1O_002, ";
            sSQL = sSQL + "EPF_L1O_001, ";
            sSQL = sSQL + "EPF_L1O_002, ";
            sSQL = sSQL + "EPF_C1U_001, ";
            sSQL = sSQL + "EPF_C1U_002, ";
            sSQL = sSQL + "EPF_L1U_001, ";
            sSQL = sSQL + "EPF_L1U_002, ";
            sSQL = sSQL + "EPF_C2O_001, ";
            sSQL = sSQL + "EPF_C2O_002, ";
            sSQL = sSQL + "EPF_L2O_001, ";
            sSQL = sSQL + "EPF_L2O_002, ";
            sSQL = sSQL + "EPF_C2U_001, ";
            sSQL = sSQL + "EPF_C2U_002, ";
            sSQL = sSQL + "EPF_L2U_001, ";
            sSQL = sSQL + "EPF_L2U_002, ";
            sSQL = sSQL + "EPF_TSU_001, ";
            sSQL = sSQL + "EPF_TSU_002, ";
            sSQL = sSQL + "EPF_CVC_001, ";
            sSQL = sSQL + "EPF_CVC_002, ";
            sSQL = sSQL + "EPF_CVL_001, ";
            sSQL = sSQL + "EPF_CVL_002, ";
            sSQL = sSQL + "EPF_TLE_001, ";
            sSQL = sSQL + "EPF_TLE_002, ";
            sSQL = sSQL + "EPF_ROI, ";
            sSQL = sSQL + "EPF_RR0, ";
            sSQL = sSQL + "EPF_R01, ";
            sSQL = sSQL + "EPF_RR1, ";
            sSQL = sSQL + "EPF_RR2, ";
            sSQL = sSQL + "EPF_R2A, ";
            sSQL = sSQL + "EPF_RR3, ";
            sSQL = sSQL + "EPF_RWR, ";
            sSQL = sSQL + "EPF_STD, ";
            sSQL = sSQL + "EPF_STP, ";
            sSQL = sSQL + "EPF_TTD, ";
            sSQL = sSQL + "EPF_TTP, ";
            sSQL = sSQL + "EPF_FTD, ";
            sSQL = sSQL + "EPF_FTP, ";
            sSQL = sSQL + "EPF_ITD, ";
            sSQL = sSQL + "EPF_ITP, ";
            sSQL = sSQL + "EPF_XTD, ";
            sSQL = sSQL + "EPF_XTP, ";
            sSQL = sSQL + "EPF_TTR, ";
            sSQL = sSQL + "EPF_PLY, ";
            sSQL = sSQL + "EPF_PLF, ";
            sSQL = sSQL + "EPF_PLL, ";

            sSQL = sSQL + "EPF_DET, ";
            sSQL = sSQL + "EPF_OBS, ";
            sSQL = sSQL + "EPF_RSP_USR_ID, ";
            sSQL = sSQL + "EPF_STS, ";
            sSQL = sSQL + "EPF_USR_INC_ID, ";
            sSQL = sSQL + "EPF_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(EPF_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + EPF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRS.ToString()))
            {
                sSQL = sSQL + EPF_VRS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT))
            {
                sSQL = sSQL + "'" + EPF_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT_REF))
            {
                sSQL = sSQL + "'" + EPF_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + EPF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DES))
            {
                sSQL = sSQL + "'" + EPF_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE))
            {
                sSQL = sSQL + "'" + EPF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_001))
            {
                sSQL = sSQL + "'" + EPF_MGE_DES_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_ID.ToString()))
            {
                sSQL = sSQL + EPF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_002))
            {
                sSQL = sSQL + "'" + EPF_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_002))
            {
                sSQL = sSQL + "'" + EPF_MGE_DES_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + EPF_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_003))
            {
                sSQL = sSQL + "'" + EPF_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_003))
            {
                sSQL = sSQL + "'" + EPF_MGE_DES_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + EPF_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_004))
            {
                sSQL = sSQL + "'" + EPF_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_004))
            {
                sSQL = sSQL + "'" + EPF_MGE_DES_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_004_ID.ToString()))
            {
                sSQL = sSQL + EPF_FOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VLC))
            {
                sSQL = sSQL + "'" + EPF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_APS_ID.ToString()))
            {
                sSQL = sSQL + EPF_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + EPF_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERT_ID.ToString()))
            {
                sSQL = sSQL + EPF_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VW2))
            {
                sSQL = sSQL + "'" + EPF_VW2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGM))
            {
                sSQL = sSQL + "'" + EPF_EGM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DYY))
            {
                sSQL = sSQL + "'" + EPF_DYY.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2WX))
            {
                sSQL = sSQL + "'" + EPF_2WX.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_3W3))
            {
                sSQL = sSQL + "'" + EPF_3W3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_4W4))
            {
                sSQL = sSQL + "'" + EPF_4W4.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AGL))
            {
                sSQL = sSQL + "'" + EPF_AGL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUP))
            {
                sSQL = sSQL + "'" + EPF_TUP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VEO))
            {
                sSQL = sSQL + "'" + EPF_VEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1T))
            {
                sSQL = sSQL + "'" + EPF_T1T.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1C))
            {
                sSQL = sSQL + "'" + EPF_T1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1L))
            {
                sSQL = sSQL + "'" + EPF_T1L.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T2F))
            {
                sSQL = sSQL + "'" + EPF_T2F.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVE))
            {
                sSQL = sSQL + "'" + EPF_SVE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STF))
            {
                sSQL = sSQL + "'" + EPF_STF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STM))
            {
                sSQL = sSQL + "'" + EPF_STM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCE))
            {
                sSQL = sSQL + "'" + EPF_SCE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCO))
            {
                sSQL = sSQL + "'" + EPF_SCO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCH))
            {
                sSQL = sSQL + "'" + EPF_SCH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCG))
            {
                sSQL = sSQL + "'" + EPF_SCG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEE))
            {
                sSQL = sSQL + "'" + EPF_SEE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEO))
            {
                sSQL = sSQL + "'" + EPF_SEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEH))
            {
                sSQL = sSQL + "'" + EPF_SEH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEG))
            {
                sSQL = sSQL + "'" + EPF_SEG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJC))
            {
                sSQL = sSQL + "'" + EPF_SJC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJT))
            {
                sSQL = sSQL + "'" + EPF_SJT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJB))
            {
                sSQL = sSQL + "'" + EPF_SJB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPJ))
            {
                sSQL = sSQL + "'" + EPF_SPJ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SBC))
            {
                sSQL = sSQL + "'" + EPF_SBC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPO))
            {
                sSQL = sSQL + "'" + EPF_SPO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVA))
            {
                sSQL = sSQL + "'" + EPF_SVA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TGR))
            {
                sSQL = sSQL + "'" + EPF_TGR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP))
            {
                sSQL = sSQL + "'" + EPF_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DSB))
            {
                sSQL = sSQL + "'" + EPF_DSB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCA))
            {
                sSQL = sSQL + "'" + EPF_TCA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FMC))
            {
                sSQL = sSQL + "'" + EPF_FMC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1TB))
            {
                sSQL = sSQL + "'" + EPF_1TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1PP))
            {
                sSQL = sSQL + "'" + EPF_1PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2TB))
            {
                sSQL = sSQL + "'" + EPF_2TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2PP))
            {
                sSQL = sSQL + "'" + EPF_2PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P1C))
            {
                sSQL = sSQL + "'" + EPF_P1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P2D))
            {
                sSQL = sSQL + "'" + EPF_P2D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P3D))
            {
                sSQL = sSQL + "'" + EPF_P3D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P4U))
            {
                sSQL = sSQL + "'" + EPF_P4U.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MOL))
            {
                sSQL = sSQL + "'" + EPF_MOL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TPD))
            {
                sSQL = sSQL + "'" + EPF_TPD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT1))
            {
                sSQL = sSQL + "'" + EPF_TT1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT2))
            {
                sSQL = sSQL + "'" + EPF_TT2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT3))
            {
                sSQL = sSQL + "'" + EPF_TT3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T21))
            {
                sSQL = sSQL + "'" + EPF_T21.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUN))
            {
                sSQL = sSQL + "'" + EPF_TUN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCV))
            {
                sSQL = sSQL + "'" + EPF_TCV.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSS))
            {
                sSQL = sSQL + "'" + EPF_TSS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIT.ToString()))
            {
                sSQL = sSQL + EPF_TIT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TNC.ToString()))
            {
                sSQL = sSQL + EPF_TNC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AON.ToString()))
            {
                sSQL = sSQL + EPF_AON.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ENM.ToString()))
            {
                sSQL = sSQL + EPF_ENM.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EEE.ToString()))
            {
                sSQL = sSQL + EPF_EEE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_KKK.ToString()))
            {
                sSQL = sSQL + EPF_KKK.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_BBB.ToString()))
            {
                sSQL = sSQL + EPF_BBB.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OLE.ToString()))
            {
                sSQL = sSQL + EPF_OLE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRQ.ToString()))
            {
                sSQL = sSQL + EPF_TRQ.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERT.ToString()))
            {
                sSQL = sSQL + EPF_ERT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT3.ToString()))
            {
                sSQL = sSQL + EPF_RT3.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT5.ToString()))
            {
                sSQL = sSQL + EPF_RT5.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DND.ToString()))
            {
                sSQL = sSQL + EPF_DND.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DMO.ToString()))
            {
                sSQL = sSQL + EPF_DMO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PES.ToString()))
            {
                sSQL = sSQL + EPF_PES.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRR))
            {
                sSQL = sSQL + "'" + EPF_VRR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRE))
            {
                sSQL = sSQL + "'" + EPF_TRE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LME.ToString()))
            {
                sSQL = sSQL + EPF_LME.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UME.ToString()))
            {
                sSQL = sSQL + EPF_UME.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LPE.ToString()))
            {
                sSQL = sSQL + EPF_LPE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UPE.ToString()))
            {
                sSQL = sSQL + EPF_UPE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCV.ToString()))
            {
                sSQL = sSQL + EPF_UCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LCV.ToString()))
            {
                sSQL = sSQL + EPF_LCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CSO.ToString()))
            {
                sSQL = sSQL + EPF_CSO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESP.ToString()))
            {
                sSQL = sSQL + EPF_ESP.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TOL))
            {
                sSQL = sSQL + "'" + EPF_TOL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DUR.ToString()))
            {
                sSQL = sSQL + EPF_DUR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DFT.ToString()))
            {
                sSQL = sSQL + EPF_DFT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LMC.ToString()))
            {
                sSQL = sSQL + EPF_LMC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UMC.ToString()))
            {
                sSQL = sSQL + EPF_UMC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LPC.ToString()))
            {
                sSQL = sSQL + EPF_LPC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UPC.ToString()))
            {
                sSQL = sSQL + EPF_UPC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC.ToString()))
            {
                sSQL = sSQL + EPF_CVC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LVC.ToString()))
            {
                sSQL = sSQL + EPF_LVC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DFC.ToString()))
            {
                sSQL = sSQL + EPF_DFC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TFS.ToString()))
            {
                sSQL = sSQL + EPF_TFS.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FSW.ToString()))
            {
                sSQL = sSQL + EPF_FSW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WFW.ToString()))
            {
                sSQL = sSQL + EPF_WFW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_YBT.ToString()))
            {
                sSQL = sSQL + EPF_YBT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSP.ToString()))
            {
                sSQL = sSQL + EPF_RSP + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECO.ToString()))
            {
                sSQL = sSQL + EPF_ECO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPX.ToString()))
            {
                sSQL = sSQL + EPF_SPX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_GFT))
            {
                sSQL = sSQL + "'" + EPF_GFT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_HEM))
            {
                sSQL = sSQL + "'" + EPF_HEM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VAZ.ToString()))
            {
                sSQL = sSQL + EPF_VAZ.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COT))
            {
                sSQL = sSQL + "'" + EPF_COT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CO2.ToString()))
            {
                sSQL = sSQL + EPF_CO2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COC.ToString()))
            {
                sSQL = sSQL + EPF_COC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COV.ToString()))
            {
                sSQL = sSQL + EPF_COV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIM.ToString()))
            {
                sSQL = sSQL + EPF_DIM.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSQ))
            {
                sSQL = sSQL + "'" + EPF_RSQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RLQ))
            {
                sSQL = sSQL + "'" + EPF_RLQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RRM.ToString()))
            {
                sSQL = sSQL + EPF_RRM + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMX))
            {
                sSQL = sSQL + "'" + EPF_RMX.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMN))
            {
                sSQL = sSQL + "'" + EPF_RMN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMH))
            {
                sSQL = sSQL + "'" + EPF_RMH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RQS))
            {
                sSQL = sSQL + "'" + EPF_RQS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RTY.ToString()))
            {
                sSQL = sSQL + EPF_RTY + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RHY.ToString()))
            {
                sSQL = sSQL + EPF_RHY + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOC.ToString()))
            {
                sSQL = sSQL + EPF_EOC + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOE.ToString()))
            {
                sSQL = sSQL + EPF_EOE + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETC.ToString()))
            {
                sSQL = sSQL + EPF_ETC + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETE.ToString()))
            {
                sSQL = sSQL + EPF_ETE + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PTN.ToString()))
            {
                sSQL = sSQL + EPF_PTN + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOL.ToString()))
            {
                sSQL = sSQL + EPF_EOL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETU.ToString()))
            {
                sSQL = sSQL + EPF_ETU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETD.ToString()))
            {
                sSQL = sSQL + EPF_ETD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECU.ToString()))
            {
                sSQL = sSQL + EPF_ECU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGD.ToString()))
            {
                sSQL = sSQL + EPF_EGD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EEC.ToString()))
            {
                sSQL = sSQL + EPF_EEC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECD.ToString()))
            {
                sSQL = sSQL + EPF_ECD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGU.ToString()))
            {
                sSQL = sSQL + EPF_EGU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESO.ToString()))
            {
                sSQL = sSQL + EPF_ESO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESI.ToString()))
            {
                sSQL = sSQL + EPF_ESI.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECR.ToString()))
            {
                sSQL = sSQL + EPF_ECR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOD.ToString()))
            {
                sSQL = sSQL + EPF_EOD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EAW.ToString()))
            {
                sSQL = sSQL + EPF_EAW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ED1.ToString()))
            {
                sSQL = sSQL + EPF_ED1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ED2.ToString()))
            {
                sSQL = sSQL + EPF_ED2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_IDD.ToString()))
            {
                sSQL = sSQL + "'" + EPF_IDD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PCO.ToString()))
            {
                sSQL = sSQL + EPF_PCO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PCV.ToString()))
            {
                sSQL = sSQL + EPF_PCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DRT.ToString()))
            {
                sSQL = sSQL + EPF_DRT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAL.ToString()))
            {
                sSQL = sSQL + EPF_TAL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VAL.ToString()))
            {
                sSQL = sSQL + EPF_VAL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJE.ToString()))
            {
                sSQL = sSQL + EPF_SJE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETA))
            {
                sSQL = sSQL + "'" + EPF_ETA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETH))
            {
                sSQL = sSQL + "'" + EPF_ETH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETG))
            {
                sSQL = sSQL + "'" + EPF_ETG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EDT))
            {
                sSQL = sSQL + "'" + EPF_EDT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EFP))
            {
                sSQL = sSQL + "'" + EPF_EFP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EYT))
            {
                sSQL = sSQL + "'" + EPF_EYT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EDL))
            {
                sSQL = sSQL + "'" + EPF_EDL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EAB))
            {
                sSQL = sSQL + "'" + EPF_EAB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECA))
            {
                sSQL = sSQL + "'" + EPF_ECA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECW))
            {
                sSQL = sSQL + "'" + EPF_ECW.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETL))
            {
                sSQL = sSQL + "'" + EPF_ETL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETT))
            {
                sSQL = sSQL + "'" + EPF_ETT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERE))
            {
                sSQL = sSQL + "'" + EPF_ERE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ELE))
            {
                sSQL = sSQL + "'" + EPF_ELE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPT))
            {
                sSQL = sSQL + "'" + EPF_EPT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPL))
            {
                sSQL = sSQL + "'" + EPF_EPL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTX.ToString()))
            {
                sSQL = sSQL + EPF_CTX + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVX.ToString()))
            {
                sSQL = sSQL + EPF_CVX + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVR.ToString()))
            {
                sSQL = sSQL + EPF_CVR + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRC.ToString()))
            {
                sSQL = sSQL + EPF_CRC + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRE.ToString()))
            {
                sSQL = sSQL + EPF_CRE + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTC.ToString()))
            {
                sSQL = sSQL + EPF_CTC + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTE.ToString()))
            {
                sSQL = sSQL + EPF_CTE + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTS.ToString()))
            {
                sSQL = sSQL + EPF_CTS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_001))
            {
                sSQL = sSQL + "'" + EPF_EGE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_001))
            {
                sSQL = sSQL + "'" + EPF_EGE_DES_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_001_ID.ToString()))
            {
                sSQL = sSQL + EPF_EOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_002))
            {
                sSQL = sSQL + "'" + EPF_EGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_002))
            {
                sSQL = sSQL + "'" + EPF_EGE_DES_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_002_ID.ToString()))
            {
                sSQL = sSQL + EPF_EOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_003))
            {
                sSQL = sSQL + "'" + EPF_EGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_003))
            {
                sSQL = sSQL + "'" + EPF_EGE_DES_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_003_ID.ToString()))
            {
                sSQL = sSQL + EPF_EOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_004))
            {
                sSQL = sSQL + "'" + EPF_EGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_004))
            {
                sSQL = sSQL + "'" + EPF_EGE_DES_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_004_ID.ToString()))
            {
                sSQL = sSQL + EPF_EOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTN.ToString()))
            {
                sSQL = sSQL + EPF_CTN + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            //TMT
            if (!String.IsNullOrEmpty(EPF_MAT))
            {
                sSQL = sSQL + "'" + EPF_MAT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN))
            {
                sSQL = sSQL + "'" + EPF_CAN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU))
            {
                sSQL = sSQL + "'" + EPF_EPU.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE.ToString()))
            {
                sSQL = sSQL + EPF_PER_MGE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_002))
            {
                sSQL = sSQL + "'" + EPF_MAT_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_002))
            {
                sSQL = sSQL + "'" + EPF_CAN_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_002))
            {
                sSQL = sSQL + "'" + EPF_EPU_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_002.ToString()))
            {
                sSQL = sSQL + EPF_PER_MGE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_003))
            {
                sSQL = sSQL + "'" + EPF_MAT_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_003))
            {
                sSQL = sSQL + "'" + EPF_CAN_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_003))
            {
                sSQL = sSQL + "'" + EPF_EPU_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_003.ToString()))
            {
                sSQL = sSQL + EPF_PER_MGE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_004))
            {
                sSQL = sSQL + "'" + EPF_MAT_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_004))
            {
                sSQL = sSQL + "'" + EPF_CAN_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_004))
            {
                sSQL = sSQL + "'" + EPF_EPU_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_004.ToString()))
            {
                sSQL = sSQL + EPF_PER_MGE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_HOT.ToString()))
            {
                sSQL = sSQL + EPF_HOT + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRD))
            {
                sSQL = sSQL + "'" + EPF_VRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ACR.ToString()))
            {
                sSQL = sSQL + EPF_ACR + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PEN.ToString()))
            {
                sSQL = sSQL + EPF_PEN + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA.ToString()))
            {
                sSQL = sSQL + EPF_CRA + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CLE.ToString()))
            {
                sSQL = sSQL + EPF_CLE + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AFO.ToString()))
            {
                sSQL = sSQL + EPF_AFO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCU))
            {
                sSQL = sSQL + "'" + EPF_TCU.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAR))
            {
                sSQL = sSQL + "'" + EPF_TAR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAM))
            {
                sSQL = sSQL + "'" + EPF_TAM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DTU.ToString()))
            {
                sSQL = sSQL + EPF_DTU + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DPA.ToString()))
            {
                sSQL = sSQL + EPF_DPA + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CIN.ToString()))
            {
                sSQL = sSQL + EPF_CIN + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR2))
            {
                sSQL = sSQL + "'" + EPF_TIP_FR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR2))
            {
                sSQL = sSQL + "'" + EPF_FR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR1))
            {
                sSQL = sSQL + "'" + EPF_TIP_FR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR1))
            {
                sSQL = sSQL + "'" + EPF_FR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR0))
            {
                sSQL = sSQL + "'" + EPF_TIP_FR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR0))
            {
                sSQL = sSQL + "'" + EPF_FR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ATO.ToString()))
            {
                sSQL = sSQL + EPF_ATO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TP1.ToString()))
            {
                sSQL = sSQL + EPF_TP1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TP2.ToString()))
            {
                sSQL = sSQL + EPF_TP2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCP.ToString()))
            {
                sSQL = sSQL + EPF_TCP + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_JF2))
            {
                sSQL = sSQL + "'" + EPF_JF2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PS2.ToString()))
            {
                sSQL = sSQL + EPF_PS2 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_JF0))
            {
                sSQL = sSQL + "'" + EPF_JF0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PS0.ToString()))
            {
                sSQL = sSQL + EPF_PS0 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_BBA.ToString()))
            {
                sSQL = sSQL + EPF_BBA.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_GRO))
            {
                sSQL = sSQL + "'" + EPF_GRO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCS))
            {
                sSQL = sSQL + "'" + EPF_TCS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP))
            {
                sSQL = sSQL + "'" + EPF_CVP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SSV.ToString()))
            {
                sSQL = sSQL + EPF_SSV + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SSP.ToString()))
            {
                sSQL = sSQL + EPF_SSP + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTE_001.ToString()))
            {
                sSQL = sSQL + EPF_TTE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTE_002.ToString()))
            {
                sSQL = sSQL + EPF_TTE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WPO_001))
            {
                sSQL = sSQL + "'" + EPF_WPO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WPO_002))
            {
                sSQL = sSQL + "'" + EPF_WPO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIR_001))
            {
                sSQL = sSQL + "'" + EPF_DIR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIR_002))
            {
                sSQL = sSQL + "'" + EPF_DIR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA_001.ToString()))
            {
                sSQL = sSQL + EPF_CRA_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA_002.ToString()))
            {
                sSQL = sSQL + EPF_CRA_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CED_001))
            {
                sSQL = sSQL + "'" + EPF_CED_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CED_002))
            {
                sSQL = sSQL + "'" + EPF_CED_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TED_001))
            {
                sSQL = sSQL + "'" + EPF_TED_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TED_002))
            {
                sSQL = sSQL + "'" + EPF_TED_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DLE_001))
            {
                sSQL = sSQL + "'" + EPF_DLE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DLE_002))
            {
                sSQL = sSQL + "'" + EPF_DLE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTI_001))
            {
                sSQL = sSQL + "'" + EPF_CTI_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTI_002))
            {
                sSQL = sSQL + "'" + EPF_CTI_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1O_001.ToString()))
            {
                sSQL = sSQL + EPF_G1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1O_002.ToString()))
            {
                sSQL = sSQL + EPF_G1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1U_001.ToString()))
            {
                sSQL = sSQL + EPF_G1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1U_002.ToString()))
            {
                sSQL = sSQL + EPF_G1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2O_001.ToString()))
            {
                sSQL = sSQL + EPF_G2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2O_002.ToString()))
            {
                sSQL = sSQL + EPF_G2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2U_001.ToString()))
            {
                sSQL = sSQL + EPF_G2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2U_002.ToString()))
            {
                sSQL = sSQL + EPF_G2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP_001.ToString()))
            {
                sSQL = sSQL + EPF_CVP_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP_002.ToString()))
            {
                sSQL = sSQL + EPF_CVP_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OCU_001.ToString()))
            {
                sSQL = sSQL + EPF_OCU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OCU_002.ToString()))
            {
                sSQL = sSQL + EPF_OCU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCU_001.ToString()))
            {
                sSQL = sSQL + EPF_UCU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCU_002.ToString()))
            {
                sSQL = sSQL + EPF_UCU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1O_001.ToString()))
            {
                sSQL = sSQL + EPF_C1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1O_002.ToString()))
            {
                sSQL = sSQL + EPF_C1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1O_001.ToString()))
            {
                sSQL = sSQL + EPF_L1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1O_002.ToString()))
            {
                sSQL = sSQL + EPF_L1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1U_001.ToString()))
            {
                sSQL = sSQL + EPF_C1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1U_002.ToString()))
            {
                sSQL = sSQL + EPF_C1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1U_001.ToString()))
            {
                sSQL = sSQL + EPF_L1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1U_002.ToString()))
            {
                sSQL = sSQL + EPF_L1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2O_001.ToString()))
            {
                sSQL = sSQL + EPF_C2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2O_002.ToString()))
            {
                sSQL = sSQL + EPF_C2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2O_001.ToString()))
            {
                sSQL = sSQL + EPF_L2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2O_002.ToString()))
            {
                sSQL = sSQL + EPF_L2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2U_001.ToString()))
            {
                sSQL = sSQL + EPF_C2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2U_002.ToString()))
            {
                sSQL = sSQL + EPF_C2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2U_001.ToString()))
            {
                sSQL = sSQL + EPF_L2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2U_002.ToString()))
            {
                sSQL = sSQL + EPF_L2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSU_001.ToString()))
            {
                sSQL = sSQL + EPF_TSU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSU_002.ToString()))
            {
                sSQL = sSQL + EPF_TSU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC_001.ToString()))
            {
                sSQL = sSQL + EPF_CVC_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC_002.ToString()))
            {
                sSQL = sSQL + EPF_CVC_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVL_001.ToString()))
            {
                sSQL = sSQL + EPF_CVL_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVL_002.ToString()))
            {
                sSQL = sSQL + EPF_CVL_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TLE_001.ToString()))
            {
                sSQL = sSQL + EPF_TLE_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TLE_002.ToString()))
            {
                sSQL = sSQL + EPF_TLE_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ROI))
            {
                sSQL = sSQL + "'" + EPF_ROI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR0))
            {
                sSQL = sSQL + "'" + EPF_RR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_R01))
            {
                sSQL = sSQL + "'" + EPF_R01.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR1))
            {
                sSQL = sSQL + "'" + EPF_RR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR2))
            {
                sSQL = sSQL + "'" + EPF_RR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_R2A))
            {
                sSQL = sSQL + "'" + EPF_R2A.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR3))
            {
                sSQL = sSQL + "'" + EPF_RR3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RWR))
            {
                sSQL = sSQL + "'" + EPF_RWR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STD))
            {
                sSQL = sSQL + "'" + EPF_STD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STP))
            {
                sSQL = sSQL + "'" + EPF_STP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTD))
            {
                sSQL = sSQL + "'" + EPF_TTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTP))
            {
                sSQL = sSQL + "'" + EPF_TTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FTD))
            {
                sSQL = sSQL + "'" + EPF_FTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FTP))
            {
                sSQL = sSQL + "'" + EPF_FTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ITD))
            {
                sSQL = sSQL + "'" + EPF_ITD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ITP))
            {
                sSQL = sSQL + "'" + EPF_ITP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_XTD))
            {
                sSQL = sSQL + "'" + EPF_XTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_XTP))
            {
                sSQL = sSQL + "'" + EPF_XTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTR))
            {
                sSQL = sSQL + "'" + EPF_TTR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLY.ToString()))
            {
                sSQL = sSQL + EPF_PLY + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLF))
            {
                sSQL = sSQL + "'" + EPF_PLF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLL))
            {
                sSQL = sSQL + "'" + EPF_PLL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }

            if (!String.IsNullOrEmpty(EPF_DET))
            {
                sSQL = sSQL + "'" + EPF_DET.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OBS))
            {
                sSQL = sSQL + "'" + EPF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSP_USR_ID.ToString()))
            {
                sSQL = sSQL + EPF_RSP_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STS.ToString()))
            {
                sSQL = sSQL + EPF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + EPF_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE EPF ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(EPF_DAT.ToString()))
            {
                sSQL = sSQL + "EPF_DAT = Convert(datetime, '" + EPF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "EPF_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRS.ToString()))
            {
                sSQL = sSQL + "EPF_VRS = " + EPF_VRS + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_VRS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT))
            {
                sSQL = sSQL + "EPF_LOT = '" + EPF_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT_REF))
            {
                sSQL = sSQL + "EPF_LOT_REF = '" + EPF_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_LOT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "EPF_TIT_POY_ID = " + EPF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DES))
            {
                sSQL = sSQL + "EPF_DES = '" + EPF_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE))
            {
                sSQL = sSQL + "EPF_MGE = '" + EPF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_001))
            {
                sSQL = sSQL + "EPF_MGE_DES_001 = '" + EPF_MGE_DES_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_DES_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_ID.ToString()))
            {
                sSQL = sSQL + "EPF_FOR_ID = " + EPF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_FOR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_002))
            {
                sSQL = sSQL + "EPF_MGE_002 = '" + EPF_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_002))
            {
                sSQL = sSQL + "EPF_MGE_DES_002 = '" + EPF_MGE_DES_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_DES_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + "EPF_FOR_002_ID = " + EPF_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_FOR_002_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_003))
            {
                sSQL = sSQL + "EPF_MGE_003 = '" + EPF_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_003))
            {
                sSQL = sSQL + "EPF_MGE_DES_003 = '" + EPF_MGE_DES_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_DES_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + "EPF_FOR_003_ID = " + EPF_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_FOR_003_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_004))
            {
                sSQL = sSQL + "EPF_MGE_004 = '" + EPF_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE_DES_004))
            {
                sSQL = sSQL + "EPF_MGE_DES_004 = '" + EPF_MGE_DES_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MGE_DES_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FOR_004_ID.ToString()))
            {
                sSQL = sSQL + "EPF_FOR_004_ID = " + EPF_FOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_FOR_004_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VLC))
            {
                sSQL = sSQL + "EPF_VLC = '" + EPF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_APS_ID.ToString()))
            {
                sSQL = sSQL + "EPF_APS_ID = " + EPF_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_APS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "EPF_MAQ_TIP_ID = " + EPF_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERT_ID.ToString()))
            {
                sSQL = sSQL + "EPF_ERT_ID = " + EPF_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ERT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VW2))
            {
                sSQL = sSQL + "EPF_VW2 = '" + EPF_VW2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VW2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGM))
            {
                sSQL = sSQL + "EPF_EGM = '" + EPF_EGM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DYY))
            {
                sSQL = sSQL + "EPF_DYY = '" + EPF_DYY.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2WX))
            {
                sSQL = sSQL + "EPF_2WX = '" + EPF_2WX.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2WX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_3W3))
            {
                sSQL = sSQL + "EPF_3W3 = '" + EPF_3W3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_3W3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_4W4))
            {
                sSQL = sSQL + "EPF_4W4 = '" + EPF_4W4.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_4W4 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AGL))
            {
                sSQL = sSQL + "EPF_AGL = '" + EPF_AGL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_AGL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUP))
            {
                sSQL = sSQL + "EPF_TUP = '" + EPF_TUP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TUP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VEO))
            {
                sSQL = sSQL + "EPF_VEO = '" + EPF_VEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VEO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1T))
            {
                sSQL = sSQL + "EPF_T1T = '" + EPF_T1T.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1T = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1C))
            {
                sSQL = sSQL + "EPF_T1C = '" + EPF_T1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1C = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1L))
            {
                sSQL = sSQL + "EPF_T1L = '" + EPF_T1L.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1L = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T2F))
            {
                sSQL = sSQL + "EPF_T2F = '" + EPF_T2F.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T2F = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVE))
            {
                sSQL = sSQL + "EPF_SVE = '" + EPF_SVE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SVE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STF))
            {
                sSQL = sSQL + "EPF_STF = '" + EPF_STF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_STF = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STM))
            {
                sSQL = sSQL + "EPF_STM = '" + EPF_STM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_STM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCE))
            {
                sSQL = sSQL + "EPF_SCE = '" + EPF_SCE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCO))
            {
                sSQL = sSQL + "EPF_SCO = '" + EPF_SCO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCH))
            {
                sSQL = sSQL + "EPF_SCH = '" + EPF_SCH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCG))
            {
                sSQL = sSQL + "EPF_SCG = '" + EPF_SCG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCG = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEE))
            {
                sSQL = sSQL + "EPF_SEE = '" + EPF_SEE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEO))
            {
                sSQL = sSQL + "EPF_SEO = '" + EPF_SEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEH))
            {
                sSQL = sSQL + "EPF_SEH = '" + EPF_SEH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEG))
            {
                sSQL = sSQL + "EPF_SEG = '" + EPF_SEG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEG = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJC))
            {
                sSQL = sSQL + "EPF_SJC = '" + EPF_SJC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJT))
            {
                sSQL = sSQL + "EPF_SJT = '" + EPF_SJT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJB))
            {
                sSQL = sSQL + "EPF_SJB = '" + EPF_SJB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPJ))
            {
                sSQL = sSQL + "EPF_SPJ = '" + EPF_SPJ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SPJ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SBC))
            {
                sSQL = sSQL + "EPF_SBC = '" + EPF_SBC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SBC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPO))
            {
                sSQL = sSQL + "EPF_SPO = '" + EPF_SPO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SPO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVA))
            {
                sSQL = sSQL + "EPF_SVA = '" + EPF_SVA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SVA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TGR))
            {
                sSQL = sSQL + "EPF_TGR = '" + EPF_TGR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TGR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP))
            {
                sSQL = sSQL + "EPF_TIP = '" + EPF_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DSB))
            {
                sSQL = sSQL + "EPF_DSB = '" + EPF_DSB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DSB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCA))
            {
                sSQL = sSQL + "EPF_TCA = '" + EPF_TCA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FMC))
            {
                sSQL = sSQL + "EPF_FMC = '" + EPF_FMC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_FMC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1TB))
            {
                sSQL = sSQL + "EPF_1TB = '" + EPF_1TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_1TB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1PP))
            {
                sSQL = sSQL + "EPF_1PP = '" + EPF_1PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_1PP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2TB))
            {
                sSQL = sSQL + "EPF_2TB = '" + EPF_2TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2TB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2PP))
            {
                sSQL = sSQL + "EPF_2PP = '" + EPF_2PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2PP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P1C))
            {
                sSQL = sSQL + "EPF_P1C = '" + EPF_P1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P1C = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P2D))
            {
                sSQL = sSQL + "EPF_P2D = '" + EPF_P2D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P2D = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P3D))
            {
                sSQL = sSQL + "EPF_P3D = '" + EPF_P3D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P3D = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P4U))
            {
                sSQL = sSQL + "EPF_P4U = '" + EPF_P4U.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P4U = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MOL))
            {
                sSQL = sSQL + "EPF_MOL = '" + EPF_MOL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MOL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TPD))
            {
                sSQL = sSQL + "EPF_TPD = '" + EPF_TPD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TPD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT1))
            {
                sSQL = sSQL + "EPF_TT1 = '" + EPF_TT1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT2))
            {
                sSQL = sSQL + "EPF_TT2 = '" + EPF_TT2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT3))
            {
                sSQL = sSQL + "EPF_TT3 = '" + EPF_TT3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T21))
            {
                sSQL = sSQL + "EPF_T21 = '" + EPF_T21.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T21 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUN))
            {
                sSQL = sSQL + "EPF_TUN = '" + EPF_TUN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TUN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCV))
            {
                sSQL = sSQL + "EPF_TCV = '" + EPF_TCV.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSS))
            {
                sSQL = sSQL + "EPF_TSS = '" + EPF_TSS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TSS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIT.ToString()))
            {
                sSQL = sSQL + "EPF_TIT = " + EPF_TIT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TNC.ToString()))
            {
                sSQL = sSQL + "EPF_TNC = " + EPF_TNC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TNC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AON.ToString()))
            {
                sSQL = sSQL + "EPF_AON = " + EPF_AON.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_AON = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ENM.ToString()))
            {
                sSQL = sSQL + "EPF_ENM = " + EPF_ENM.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ENM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EEE.ToString()))
            {
                sSQL = sSQL + "EPF_EEE = " + EPF_EEE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EEE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_KKK.ToString()))
            {
                sSQL = sSQL + "EPF_KKK = " + EPF_KKK.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_KKK = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_BBB.ToString()))
            {
                sSQL = sSQL + "EPF_BBB = " + EPF_BBB.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_BBB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OLE.ToString()))
            {
                sSQL = sSQL + "EPF_OLE = " + EPF_OLE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_OLE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRQ.ToString()))
            {
                sSQL = sSQL + "EPF_TRQ = " + EPF_TRQ.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TRQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERT.ToString()))
            {
                sSQL = sSQL + "EPF_ERT = " + EPF_ERT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ERT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT3.ToString()))
            {
                sSQL = sSQL + "EPF_RT3 = " + EPF_RT3.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RT3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT5.ToString()))
            {
                sSQL = sSQL + "EPF_RT5 = " + EPF_RT5.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RT5 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DND.ToString()))
            {
                sSQL = sSQL + "EPF_DND = " + EPF_DND.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DND = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DMO.ToString()))
            {
                sSQL = sSQL + "EPF_DMO = " + EPF_DMO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DMO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PES.ToString()))
            {
                sSQL = sSQL + "EPF_PES = " + EPF_PES.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PES = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRR))
            {
                sSQL = sSQL + "EPF_VRR = '" + EPF_VRR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VRR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRE))
            {
                sSQL = sSQL + "EPF_TRE = '" + EPF_TRE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TRE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LME.ToString()))
            {
                sSQL = sSQL + "EPF_LME = " + EPF_LME.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LME = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UME.ToString()))
            {
                sSQL = sSQL + "EPF_UME = " + EPF_UME.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UME = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LPE.ToString()))
            {
                sSQL = sSQL + "EPF_LPE = " + EPF_LPE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LPE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UPE.ToString()))
            {
                sSQL = sSQL + "EPF_UPE = " + EPF_UPE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UPE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCV.ToString()))
            {
                sSQL = sSQL + "EPF_UCV = " + EPF_UCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UCV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LCV.ToString()))
            {
                sSQL = sSQL + "EPF_LCV = " + EPF_LCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LCV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CSO.ToString()))
            {
                sSQL = sSQL + "EPF_CSO = " + EPF_CSO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CSO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESP.ToString()))
            {
                sSQL = sSQL + "EPF_ESP = " + EPF_ESP.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ESP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TOL))
            {
                sSQL = sSQL + "EPF_TOL = '" + EPF_TOL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TOL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DUR.ToString()))
            {
                sSQL = sSQL + "EPF_DUR = " + EPF_DUR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DUR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DFT.ToString()))
            {
                sSQL = sSQL + "EPF_DFT = " + EPF_DFT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DFT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LMC.ToString()))
            {
                sSQL = sSQL + "EPF_LMC = " + EPF_LMC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LMC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UMC.ToString()))
            {
                sSQL = sSQL + "EPF_UMC = " + EPF_UMC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UMC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LPC.ToString()))
            {
                sSQL = sSQL + "EPF_LPC = " + EPF_LPC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LPC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UPC.ToString()))
            {
                sSQL = sSQL + "EPF_UPC = " + EPF_UPC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UPC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC.ToString()))
            {
                sSQL = sSQL + "EPF_CVC = " + EPF_CVC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_LVC.ToString()))
            {
                sSQL = sSQL + "EPF_LVC = " + EPF_LVC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_LVC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DFC.ToString()))
            {
                sSQL = sSQL + "EPF_DFC = " + EPF_DFC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DFC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TFS.ToString()))
            {
                sSQL = sSQL + "EPF_TFS = " + EPF_TFS.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TFS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FSW.ToString()))
            {
                sSQL = sSQL + "EPF_FSW = " + EPF_FSW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_FSW = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WFW.ToString()))
            {
                sSQL = sSQL + "EPF_WFW = " + EPF_WFW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_WFW = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_YBT.ToString()))
            {
                sSQL = sSQL + "EPF_YBT = " + EPF_YBT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_YBT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSP.ToString()))
            {
                sSQL = sSQL + "EPF_RSP = " + EPF_RSP + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RSP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECO.ToString()))
            {
                sSQL = sSQL + "EPF_ECO = " + EPF_ECO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPX.ToString()))
            {
                sSQL = sSQL + "EPF_SPX = " + EPF_SPX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_SPX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_GFT))
            {
                sSQL = sSQL + "EPF_GFT = '" + EPF_GFT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_GFT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_HEM))
            {
                sSQL = sSQL + "EPF_HEM = '" + EPF_HEM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_HEM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VAZ.ToString()))
            {
                sSQL = sSQL + "EPF_VAZ = " + EPF_VAZ.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_VAZ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COT))
            {
                sSQL = sSQL + "EPF_COT = '" + EPF_COT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_COT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CO2.ToString()))
            {
                sSQL = sSQL + "EPF_CO2 = " + EPF_CO2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CO2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COC.ToString()))
            {
                sSQL = sSQL + "EPF_COC = " + EPF_COC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_COC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_COV.ToString()))
            {
                sSQL = sSQL + "EPF_COV = " + EPF_COV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_COV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIM.ToString()))
            {
                sSQL = sSQL + "EPF_DIM = " + EPF_DIM.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DIM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSQ))
            {
                sSQL = sSQL + "EPF_RSQ = '" + EPF_RSQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RSQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RLQ))
            {
                sSQL = sSQL + "EPF_RLQ = '" + EPF_RLQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RLQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RRM.ToString()))
            {
                sSQL = sSQL + "EPF_RRM = " + EPF_RRM + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RRM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMX))
            {
                sSQL = sSQL + "EPF_RMX = '" + EPF_RMX.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RMX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMN))
            {
                sSQL = sSQL + "EPF_RMN = '" + EPF_RMN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RMN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RMH))
            {
                sSQL = sSQL + "EPF_RMH = '" + EPF_RMH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RMH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RQS))
            {
                sSQL = sSQL + "EPF_RQS = '" + EPF_RQS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RQS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RTY.ToString()))
            {
                sSQL = sSQL + "EPF_RTY = " + EPF_RTY + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RTY = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RHY.ToString()))
            {
                sSQL = sSQL + "EPF_RHY = " + EPF_RHY + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RHY = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOC.ToString()))
            {
                sSQL = sSQL + "EPF_EOC = " + EPF_EOC + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOE.ToString()))
            {
                sSQL = sSQL + "EPF_EOE = " + EPF_EOE + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETC.ToString()))
            {
                sSQL = sSQL + "EPF_ETC = " + EPF_ETC + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETE.ToString()))
            {
                sSQL = sSQL + "EPF_ETE = " + EPF_ETE + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PTN.ToString()))
            {
                sSQL = sSQL + "EPF_PTN = " + EPF_PTN + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PTN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOL.ToString()))
            {
                sSQL = sSQL + "EPF_EOL = " + EPF_EOL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETU.ToString()))
            {
                sSQL = sSQL + "EPF_ETU = " + EPF_ETU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETD.ToString()))
            {
                sSQL = sSQL + "EPF_ETD = " + EPF_ETD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECU.ToString()))
            {
                sSQL = sSQL + "EPF_ECU = " + EPF_ECU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGD.ToString()))
            {
                sSQL = sSQL + "EPF_EGD = " + EPF_EGD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EEC.ToString()))
            {
                sSQL = sSQL + "EPF_EEC = " + EPF_EEC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EEC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECD.ToString()))
            {
                sSQL = sSQL + "EPF_ECD = " + EPF_ECD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGU.ToString()))
            {
                sSQL = sSQL + "EPF_EGU = " + EPF_EGU.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESO.ToString()))
            {
                sSQL = sSQL + "EPF_ESO = " + EPF_ESO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ESO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ESI.ToString()))
            {
                sSQL = sSQL + "EPF_ESI = " + EPF_ESI.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ESI = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECR.ToString()))
            {
                sSQL = sSQL + "EPF_ECR = " + EPF_ECR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOD.ToString()))
            {
                sSQL = sSQL + "EPF_EOD = " + EPF_EOD.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EAW.ToString()))
            {
                sSQL = sSQL + "EPF_EAW = " + EPF_EAW.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EAW = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ED1.ToString()))
            {
                sSQL = sSQL + "EPF_ED1 = " + EPF_ED1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ED1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ED2.ToString()))
            {
                sSQL = sSQL + "EPF_ED2 = " + EPF_ED2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ED2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_IDD.ToString()))
            {
                sSQL = sSQL + "EPF_IDD = '" + EPF_IDD.ToString().Replace(",", ".") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_IDD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PCO.ToString()))
            {
                sSQL = sSQL + "EPF_PCO = " + EPF_PCO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PCO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PCV.ToString()))
            {
                sSQL = sSQL + "EPF_PCV = " + EPF_PCV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PCV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DRT.ToString()))
            {
                sSQL = sSQL + "EPF_DRT = " + EPF_DRT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DRT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAL.ToString()))
            {
                sSQL = sSQL + "EPF_TAL = " + EPF_TAL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TAL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VAL.ToString()))
            {
                sSQL = sSQL + "EPF_VAL = " + EPF_VAL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_VAL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJE.ToString()))
            {
                sSQL = sSQL + "EPF_SJE = " + EPF_SJE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETA))
            {
                sSQL = sSQL + "EPF_ETA = '" + EPF_ETA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETH))
            {
                sSQL = sSQL + "EPF_ETH = '" + EPF_ETH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETG))
            {
                sSQL = sSQL + "EPF_ETG = '" + EPF_ETG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETG = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EDT))
            {
                sSQL = sSQL + "EPF_EDT = '" + EPF_EDT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EDT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EFP))
            {
                sSQL = sSQL + "EPF_EFP = '" + EPF_EFP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EFP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EYT))
            {
                sSQL = sSQL + "EPF_EYT = '" + EPF_EYT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EYT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EDL))
            {
                sSQL = sSQL + "EPF_EDL = '" + EPF_EDL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EDL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EAB))
            {
                sSQL = sSQL + "EPF_EAB = '" + EPF_EAB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EAB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECA))
            {
                sSQL = sSQL + "EPF_ECA = '" + EPF_ECA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ECW))
            {
                sSQL = sSQL + "EPF_ECW = '" + EPF_ECW.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ECW = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETL))
            {
                sSQL = sSQL + "EPF_ETL = '" + EPF_ETL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ETT))
            {
                sSQL = sSQL + "EPF_ETT = '" + EPF_ETT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ETT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERE))
            {
                sSQL = sSQL + "EPF_ERE = '" + EPF_ERE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ERE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ELE))
            {
                sSQL = sSQL + "EPF_ELE = '" + EPF_ELE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ELE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPT))
            {
                sSQL = sSQL + "EPF_EPT = '" + EPF_EPT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPL))
            {
                sSQL = sSQL + "EPF_EPL = '" + EPF_EPL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTX.ToString()))
            {
                sSQL = sSQL + "EPF_CTX = " + EPF_CTX + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVX.ToString()))
            {
                sSQL = sSQL + "EPF_CVX = " + EPF_CVX + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVR.ToString()))
            {
                sSQL = sSQL + "EPF_CVR = " + EPF_CVR + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRC.ToString()))
            {
                sSQL = sSQL + "EPF_CRC = " + EPF_CRC + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CRC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRE.ToString()))
            {
                sSQL = sSQL + "EPF_CRE = " + EPF_CRE + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CRE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTC.ToString()))
            {
                sSQL = sSQL + "EPF_CTC = " + EPF_CTC + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTE.ToString()))
            {
                sSQL = sSQL + "EPF_CTE = " + EPF_CTE + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTS.ToString()))
            {
                sSQL = sSQL + "EPF_CTS = " + EPF_CTS + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_001))
            {
                sSQL = sSQL + "EPF_EGE_001 = '" + EPF_EGE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_001))
            {
                sSQL = sSQL + "EPF_EGE_DES_001 = '" + EPF_EGE_DES_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_DES_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_001_ID.ToString()))
            {
                sSQL = sSQL + "EPF_EOR_001_ID = " + EPF_EOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOR_001_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_002))
            {
                sSQL = sSQL + "EPF_EGE_002 = '" + EPF_EGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_002))
            {
                sSQL = sSQL + "EPF_EGE_DES_002 = '" + EPF_EGE_DES_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_DES_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_002_ID.ToString()))
            {
                sSQL = sSQL + "EPF_EOR_002_ID = " + EPF_EOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOR_002_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_003))
            {
                sSQL = sSQL + "EPF_EGE_003 = '" + EPF_EGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_003))
            {
                sSQL = sSQL + "EPF_EGE_DES_003 = '" + EPF_EGE_DES_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_DES_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_003_ID.ToString()))
            {
                sSQL = sSQL + "EPF_EOR_003_ID = " + EPF_EOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOR_003_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_004))
            {
                sSQL = sSQL + "EPF_EGE_004 = '" + EPF_EGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGE_DES_004))
            {
                sSQL = sSQL + "EPF_EGE_DES_004 = '" + EPF_EGE_DES_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGE_DES_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EOR_004_ID.ToString()))
            {
                sSQL = sSQL + "EPF_EOR_004_ID = " + EPF_EOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EOR_004_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTN.ToString()))
            {
                sSQL = sSQL + "EPF_CTN = " + EPF_CTN + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTN = NULL, ";
            }
            //TMT
            if (!String.IsNullOrEmpty(EPF_MAT))
            {
                sSQL = sSQL + "EPF_MAT = '" + EPF_MAT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN))
            {
                sSQL = sSQL + "EPF_CAN = '" + EPF_CAN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CAN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU))
            {
                sSQL = sSQL + "EPF_EPU = '" + EPF_EPU.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE.ToString()))
            {
                sSQL = sSQL + "EPF_PER_MGE = " + EPF_PER_MGE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PER_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_002))
            {
                sSQL = sSQL + "EPF_MAT_002 = '" + EPF_MAT_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MAT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_002))
            {
                sSQL = sSQL + "EPF_CAN_002 = '" + EPF_CAN_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CAN_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_002))
            {
                sSQL = sSQL + "EPF_EPU_002 = '" + EPF_EPU_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_002.ToString()))
            {
                sSQL = sSQL + "EPF_PER_MGE_002 = " + EPF_PER_MGE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PER_MGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_003))
            {
                sSQL = sSQL + "EPF_MAT_003 = '" + EPF_MAT_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MAT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_003))
            {
                sSQL = sSQL + "EPF_CAN_003 = '" + EPF_CAN_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CAN_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_003))
            {
                sSQL = sSQL + "EPF_EPU_003 = '" + EPF_EPU_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPU_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_003.ToString()))
            {
                sSQL = sSQL + "EPF_PER_MGE_003 = " + EPF_PER_MGE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PER_MGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MAT_004))
            {
                sSQL = sSQL + "EPF_MAT_004 = '" + EPF_MAT_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MAT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CAN_004))
            {
                sSQL = sSQL + "EPF_CAN_004 = '" + EPF_CAN_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CAN_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EPU_004))
            {
                sSQL = sSQL + "EPF_EPU_004 = '" + EPF_EPU_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EPU_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PER_MGE_004.ToString()))
            {
                sSQL = sSQL + "EPF_PER_MGE_004 = " + EPF_PER_MGE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PER_MGE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_HOT.ToString()))
            {
                sSQL = sSQL + "EPF_HOT = " + EPF_HOT + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_HOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRD))
            {
                sSQL = sSQL + "EPF_VRD = '" + EPF_VRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VRD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ACR.ToString()))
            {
                sSQL = sSQL + "EPF_ACR = " + EPF_ACR + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ACR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PEN.ToString()))
            {
                sSQL = sSQL + "EPF_PEN = " + EPF_PEN + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PEN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA.ToString()))
            {
                sSQL = sSQL + "EPF_CRA = " + EPF_CRA + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CRA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CLE.ToString()))
            {
                sSQL = sSQL + "EPF_CLE = " + EPF_CLE + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CLE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AFO.ToString()))
            {
                sSQL = sSQL + "EPF_AFO = " + EPF_AFO + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_AFO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCU))
            {
                sSQL = sSQL + "EPF_TCU = '" + EPF_TCU.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAR.ToString()))
            {
                sSQL = sSQL + "EPF_TAR = '" + EPF_TAR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TAR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TAM))
            {
                sSQL = sSQL + "EPF_TAM = '" + EPF_TAM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TAM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DTU.ToString()))
            {
                sSQL = sSQL + "EPF_DTU = " + EPF_DTU + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DTU = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DPA.ToString()))
            {
                sSQL = sSQL + "EPF_DPA = " + EPF_DPA + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DPA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CIN.ToString()))
            {
                sSQL = sSQL + "EPF_CIN = " + EPF_CIN + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR2))
            {
                sSQL = sSQL + "EPF_TIP_FR2 = '" + EPF_TIP_FR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIP_FR2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR2))
            {
                sSQL = sSQL + "EPF_FR2 = '" + EPF_FR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_FR2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR1))
            {
                sSQL = sSQL + "EPF_TIP_FR1 = '" + EPF_TIP_FR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIP_FR1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR1))
            {
                sSQL = sSQL + "EPF_FR1 = '" + EPF_FR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_FR1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP_FR0))
            {
                sSQL = sSQL + "EPF_TIP_FR0 = '" + EPF_TIP_FR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIP_FR0 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FR0))
            {
                sSQL = sSQL + "EPF_FR0 = '" + EPF_FR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_FR0 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ATO.ToString()))
            {
                sSQL = sSQL + "EPF_ATO = " + EPF_ATO + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ATO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TP1.ToString()))
            {
                sSQL = sSQL + "EPF_TP1 = " + EPF_TP1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TP1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TP2.ToString()))
            {
                sSQL = sSQL + "EPF_TP2 = " + EPF_TP2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TP2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCP.ToString()))
            {
                sSQL = sSQL + "EPF_TCP = " + EPF_TCP + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_JF2))
            {
                sSQL = sSQL + "EPF_JF2 = '" + EPF_JF2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_JF2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PS2.ToString()))
            {
                sSQL = sSQL + "EPF_PS2 = " + EPF_PS2 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PS2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_JF0))
            {
                sSQL = sSQL + "EPF_JF0 = '" + EPF_JF0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_JF0 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PS0.ToString()))
            {
                sSQL = sSQL + "EPF_PS0 = " + EPF_PS0 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PS0 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_BBA.ToString()))
            {
                sSQL = sSQL + "EPF_BBA = " + EPF_BBA.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_BBA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_GRO))
            {
                sSQL = sSQL + "EPF_GRO = '" + EPF_GRO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_GRO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCS))
            {
                sSQL = sSQL + "EPF_TCS = '" + EPF_TCS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP))
            {
                sSQL = sSQL + "EPF_CVP = '" + EPF_CVP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SSV.ToString()))
            {
                sSQL = sSQL + "EPF_SSV = " + EPF_SSV + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_SSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SSP.ToString()))
            {
                sSQL = sSQL + "EPF_SSP = " + EPF_SSP + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_SSP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTE_001.ToString()))
            {
                sSQL = sSQL + "EPF_TTE_001 = " + EPF_TTE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TTE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTE_002.ToString()))
            {
                sSQL = sSQL + "EPF_TTE_002 = " + EPF_TTE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TTE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WPO_001))
            {
                sSQL = sSQL + "EPF_WPO_001 = '" + EPF_WPO_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_WPO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_WPO_002))
            {
                sSQL = sSQL + "EPF_WPO_002 = '" + EPF_WPO_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_WPO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIR_001))
            {
                sSQL = sSQL + "EPF_DIR_001 = '" + EPF_DIR_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DIR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DIR_002))
            {
                sSQL = sSQL + "EPF_DIR_002 = '" + EPF_DIR_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DIR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA_001.ToString()))
            {
                sSQL = sSQL + "EPF_CRA_001 = " + EPF_CRA_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CRA_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CRA_002.ToString()))
            {
                sSQL = sSQL + "EPF_CRA_002 = " + EPF_CRA_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CRA_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CED_001))
            {
                sSQL = sSQL + "EPF_CED_001 = '" + EPF_CED_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CED_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CED_002))
            {
                sSQL = sSQL + "EPF_CED_002 = '" + EPF_CED_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CED_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TED_001))
            {
                sSQL = sSQL + "EPF_TED_001 = '" + EPF_TED_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TED_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TED_002))
            {
                sSQL = sSQL + "EPF_TED_002 = '" + EPF_TED_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TED_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DLE_001))
            {
                sSQL = sSQL + "EPF_DLE_001 = '" + EPF_DLE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DLE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DLE_002))
            {
                sSQL = sSQL + "EPF_DLE_002 = '" + EPF_DLE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DLE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTI_001))
            {
                sSQL = sSQL + "EPF_CTI_001 = '" + EPF_CTI_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTI_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CTI_002))
            {
                sSQL = sSQL + "EPF_CTI_002 = '" + EPF_CTI_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_CTI_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1O_001.ToString()))
            {
                sSQL = sSQL + "EPF_G1O_001 = " + EPF_G1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G1O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1O_002.ToString()))
            {
                sSQL = sSQL + "EPF_G1O_002 = " + EPF_G1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G1O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1U_001.ToString()))
            {
                sSQL = sSQL + "EPF_G1U_001 = " + EPF_G1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G1U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G1U_002.ToString()))
            {
                sSQL = sSQL + "EPF_G1U_002 = " + EPF_G1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G1U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2O_001.ToString()))
            {
                sSQL = sSQL + "EPF_G2O_001 = " + EPF_G2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G2O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2O_002.ToString()))
            {
                sSQL = sSQL + "EPF_G2O_002 = " + EPF_G2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G2O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2U_001.ToString()))
            {
                sSQL = sSQL + "EPF_G2U_001 = " + EPF_G2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G2U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_G2U_002.ToString()))
            {
                sSQL = sSQL + "EPF_G2U_002 = " + EPF_G2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_G2U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP_001.ToString()))
            {
                sSQL = sSQL + "EPF_CVP_001 = " + EPF_CVP_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVP_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVP_002.ToString()))
            {
                sSQL = sSQL + "EPF_CVP_002 = " + EPF_CVP_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVP_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OCU_001.ToString()))
            {
                sSQL = sSQL + "EPF_OCU_001 = " + EPF_OCU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_OCU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OCU_002.ToString()))
            {
                sSQL = sSQL + "EPF_OCU_002 = " + EPF_OCU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_OCU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCU_001.ToString()))
            {
                sSQL = sSQL + "EPF_UCU_001 = " + EPF_UCU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UCU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_UCU_002.ToString()))
            {
                sSQL = sSQL + "EPF_UCU_002 = " + EPF_UCU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_UCU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1O_001.ToString()))
            {
                sSQL = sSQL + "EPF_C1O_001 = " + EPF_C1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C1O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1O_002.ToString()))
            {
                sSQL = sSQL + "EPF_C1O_002 = " + EPF_C1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C1O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1O_001.ToString()))
            {
                sSQL = sSQL + "EPF_L1O_001 = " + EPF_L1O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L1O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1O_002.ToString()))
            {
                sSQL = sSQL + "EPF_L1O_002 = " + EPF_L1O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L1O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1U_001.ToString()))
            {
                sSQL = sSQL + "EPF_C1U_001 = " + EPF_C1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C1U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C1U_002.ToString()))
            {
                sSQL = sSQL + "EPF_C1U_002 = " + EPF_C1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C1U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1U_001.ToString()))
            {
                sSQL = sSQL + "EPF_L1U_001 = " + EPF_L1U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L1U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L1U_002.ToString()))
            {
                sSQL = sSQL + "EPF_L1U_002 = " + EPF_L1U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L1U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2O_001.ToString()))
            {
                sSQL = sSQL + "EPF_C2O_001 = " + EPF_C2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C2O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2O_002.ToString()))
            {
                sSQL = sSQL + "EPF_C2O_002 = " + EPF_C2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C2O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2O_001.ToString()))
            {
                sSQL = sSQL + "EPF_L2O_001 = " + EPF_L2O_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L2O_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2O_002.ToString()))
            {
                sSQL = sSQL + "EPF_L2O_002 = " + EPF_L2O_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L2O_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2U_001.ToString()))
            {
                sSQL = sSQL + "EPF_C2U_001 = " + EPF_C2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C2U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_C2U_002.ToString()))
            {
                sSQL = sSQL + "EPF_C2U_002 = " + EPF_C2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_C2U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2U_001.ToString()))
            {
                sSQL = sSQL + "EPF_L2U_001 = " + EPF_L2U_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L2U_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_L2U_002.ToString()))
            {
                sSQL = sSQL + "EPF_L2U_002 = " + EPF_L2U_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_L2U_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSU_001.ToString()))
            {
                sSQL = sSQL + "EPF_TSU_001 = " + EPF_TSU_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TSU_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSU_002.ToString()))
            {
                sSQL = sSQL + "EPF_TSU_002 = " + EPF_TSU_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TSU_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC_001.ToString()))
            {
                sSQL = sSQL + "EPF_CVC_001 = " + EPF_CVC_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVC_002.ToString()))
            {
                sSQL = sSQL + "EPF_CVC_002 = " + EPF_CVC_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVL_001.ToString()))
            {
                sSQL = sSQL + "EPF_CVL_001 = " + EPF_CVL_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVL_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_CVL_002.ToString()))
            {
                sSQL = sSQL + "EPF_CVL_002 = " + EPF_CVL_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_CVL_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TLE_001.ToString()))
            {
                sSQL = sSQL + "EPF_TLE_001 = " + EPF_TLE_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TLE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TLE_002.ToString()))
            {
                sSQL = sSQL + "EPF_TLE_002 = " + EPF_TLE_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TLE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ROI))
            {
                sSQL = sSQL + "EPF_ROI = '" + EPF_ROI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_ROI = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR0))
            {
                sSQL = sSQL + "EPF_RR0 = '" + EPF_RR0.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RR0 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_R01))
            {
                sSQL = sSQL + "EPF_R01 = '" + EPF_R01.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_R01 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR1))
            {
                sSQL = sSQL + "EPF_RR1 = '" + EPF_RR1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RR1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR2))
            {
                sSQL = sSQL + "EPF_RR2 = '" + EPF_RR2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RR2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_R2A))
            {
                sSQL = sSQL + "EPF_R2A = '" + EPF_R2A.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_R2A = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RR3))
            {
                sSQL = sSQL + "EPF_RR3 = '" + EPF_RR3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RR3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RWR))
            {
                sSQL = sSQL + "EPF_RWR = '" + EPF_RWR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_RWR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STD))
            {
                sSQL = sSQL + "'" + EPF_STD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STP))
            {
                sSQL = sSQL + "'" + EPF_STP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTD))
            {
                sSQL = sSQL + "'" + EPF_TTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTP))
            {
                sSQL = sSQL + "'" + EPF_TTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FTD))
            {
                sSQL = sSQL + "'" + EPF_FTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FTP))
            {
                sSQL = sSQL + "'" + EPF_FTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ITD))
            {
                sSQL = sSQL + "'" + EPF_ITD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ITP))
            {
                sSQL = sSQL + "'" + EPF_ITP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_XTD))
            {
                sSQL = sSQL + "'" + EPF_XTD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_XTP))
            {
                sSQL = sSQL + "'" + EPF_XTP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TTR))
            {
                sSQL = sSQL + "'" + EPF_TTR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLY.ToString()))
            {
                sSQL = sSQL + EPF_PLY + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLF))
            {
                sSQL = sSQL + "'" + EPF_PLF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PLL))
            {
                sSQL = sSQL + "'" + EPF_PLL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }


            if (!String.IsNullOrEmpty(EPF_DET))
            {
                sSQL = sSQL + "EPF_DET = '" + EPF_DET.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DET = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OBS))
            {
                sSQL = sSQL + "EPF_OBS = '" + EPF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_OBS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSP_USR_ID.ToString()))
            {
                sSQL = sSQL + "EPF_RSP_USR_ID = " + EPF_RSP_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RSP_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STS.ToString()))
            {
                sSQL = sSQL + "EPF_STS = " + EPF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = " + EPF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "EPF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE EPF_ID = " + EPF_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM EPF";
            sSQL = sSQL + " WHERE EPF_ID = " + EPF_ID;

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
            sSQL = sSQL + " FROM EPF";
            sSQL = sSQL + " INNER JOIN TIT_POY ON TIT_POY_ID = EPF_TIT_POY_ID";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = EPF_MAQ_TIP_ID";
            sSQL = sSQL + " INNER JOIN [FOR] ON FOR_ID = EPF_FOR_ID";
            sSQL = sSQL + " LEFT JOIN USR ON USR_ID = EPF_RSP_USR_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(EPF_ID)))
            {
                sCond = sCond + " EPF_ID = " + EPF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT)))
            {
                sCond = sCond + " EPF_DAT BETWEEN Convert(datetime, '" + EPF_DAT + "',103) AND Convert(datetime, '" + EPF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_INI)))
            {
                sCond = sCond + " EPF_DAT >= Convert(datetime, '" + EPF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_FIM)))
            {
                sCond = sCond + " EPF_DAT <= Convert(datetime, '" + EPF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_VRS)))
            {
                sCond = sCond + " EPF_VRS = " + EPF_VRS + " AND ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT))
            {
                sCond = sCond + " EPF_LOT = '" + EPF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT_REF))
            {
                sCond = sCond + " EPF_LOT_REF = '" + EPF_LOT_REF + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_TIT_POY_ID)))
            {
                sCond = sCond + " EPF_TIT_POY_ID = " + EPF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE))
            {
                sCond = sCond + " EPF_MGE = '" + EPF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_FOR_ID)))
            {
                sCond = sCond + " EPF_FOR_ID = " + EPF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EPF_VLC))
            {
                sCond = sCond + " EPF_VLC = '" + EPF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_APS_ID)))
            {
                sCond = sCond + " EPF_APS_ID = " + EPF_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_MAQ_TIP_ID)))
            {
                sCond = sCond + " EPF_MAQ_TIP_ID = " + EPF_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_ERT_ID)))
            {
                sCond = sCond + " EPF_ERT_ID = " + EPF_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_STS)))
            {
                sCond = sCond + " EPF_STS = " + EPF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY EPF_LOT, EPF_VRS DESC, EPF_LOT_REF, EPF_TIT_POY_ID, EPF_MGE, EPF_FOR_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarLote()
        {
            string sSQL = "";
            sSQL = sSQL + " SELECT DISTINCT EPF_LOT ";
            sSQL = sSQL + " FROM EPF";
            sSQL = sSQL + " ORDER BY EPF_LOT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarUltimaVersao()
        {
            string sSQL = "";
            sSQL = sSQL + " SELECT MAX(EPF_VRS) EPF_VRS ";
            sSQL = sSQL + " FROM EPF";
            sSQL = sSQL + " WHERE EPF_LOT = '" + EPF_LOT + "'";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet MediaStandard()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = sSQL + " SELECT COUNT(*) NUM,";
            sSQL = sSQL + " AVG(EPF_TIT) AVG_TIT, AVG(EPF_TNC) AVG_TNC, AVG(EPF_AON) AVG_AON, AVG(EPF_ENM) AVG_ENM, AVG(EPF_TRQ) AVG_TRQ, AVG(EPF_ERT) AVG_ERT, AVG(EPF_RT3) AVG_RT3, AVG(EPF_RT5) AVG_RT5, AVG(EPF_DND) AVG_DND,";
            sSQL = sSQL + " MIN(EPF_TIT) MIN_TIT, MIN(EPF_TNC) MIN_TNC, MIN(EPF_AON) MIN_AON, MIN(EPF_ENM) MIN_ENM, MIN(EPF_TRQ) MIN_TRQ, MIN(EPF_ERT) MIN_ERT, MIN(EPF_RT3) MIN_RT3, MIN(EPF_RT5) MIN_RT5, MIN(EPF_DND) MIN_DND,";
            sSQL = sSQL + " MAX(EPF_TIT) MAX_TIT, MAX(EPF_TNC) MAX_TNC, MAX(EPF_AON) MAX_AON, MAX(EPF_ENM) MAX_ENM, MAX(EPF_TRQ) MAX_TRQ, MAX(EPF_ERT) MAX_ERT, MAX(EPF_RT3) MAX_RT3, MAX(EPF_RT5) MAX_RT5, MAX(EPF_DND) MAX_DND,";
            sSQL = sSQL + " ISNULL(STDEV(EPF_TIT),0) DSV_TIT, ISNULL(STDEV(EPF_TNC),0) DSV_TNC, ISNULL(STDEV(EPF_AON),0) DSV_AON, ISNULL(STDEV(EPF_ENM),0) DSV_ENM, ISNULL(STDEV(EPF_TRQ),0) DSV_TRQ, ISNULL(STDEV(EPF_ERT),0) DSV_ERT, ISNULL(STDEV(EPF_RT3),0) DSV_RT3, ISNULL(STDEV(EPF_RT5),0) DSV_RT5, ISNULL(STDEV(EPF_DND),0) DSV_DND";
            sSQL = sSQL + " FROM EPF";

            if (!String.IsNullOrEmpty(Convert.ToString(EPF_ID)))
            {
                sCond = sCond + " EPF_ID = " + EPF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT)))
            {
                sCond = sCond + " EPF_DAT BETWEEN Convert(datetime, '" + EPF_DAT + "',103) AND Convert(datetime, '" + EPF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_INI)))
            {
                sCond = sCond + " EPF_DAT >= Convert(datetime, '" + EPF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_FIM)))
            {
                sCond = sCond + " EPF_DAT <= Convert(datetime, '" + EPF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT))
            {
                sCond = sCond + " EPF_LOT = '" + EPF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(EPF_LOT_REF))
            {
                sCond = sCond + " EPF_LOT_REF = '" + EPF_LOT_REF + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_TIT_POY_ID)))
            {
                sCond = sCond + " EPF_TIT_POY_ID = " + EPF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EPF_MGE))
            {
                sCond = sCond + " EPF_MGE = '" + EPF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_FOR_ID)))
            {
                sCond = sCond + " EPF_FOR_ID = " + EPF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EPF_VLC))
            {
                sCond = sCond + " EPF_VLC = '" + EPF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_APS_ID)))
            {
                sCond = sCond + " EPF_APS_ID = " + EPF_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_MAQ_TIP_ID)))
            {
                sCond = sCond + " EPF_MAQ_TIP_ID = " + EPF_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_ERT_ID)))
            {
                sCond = sCond + " EPF_ERT_ID = " + EPF_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_STS)))
            {
                sCond = sCond + " EPF_STS = " + EPF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            SQL = sSQL;
            return dbConn.ExecutarRetorno(sSQL);
        }

        public string Atualizar()
        {
            string sSQL = "UPDATE EPF ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(EPF_VW2))
            {
                sSQL = sSQL + "EPF_VW2 = '" + EPF_VW2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VW2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EGM))
            {
                sSQL = sSQL + "EPF_EGM = '" + EPF_EGM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_EGM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DYY))
            {
                sSQL = sSQL + "EPF_DYY = '" + EPF_DYY.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2WX))
            {
                sSQL = sSQL + "EPF_2WX = '" + EPF_2WX.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2WX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_3W3))
            {
                sSQL = sSQL + "EPF_3W3 = '" + EPF_3W3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_3W3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_4W4))
            {
                sSQL = sSQL + "EPF_4W4 = '" + EPF_4W4.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_4W4 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AGL))
            {
                sSQL = sSQL + "EPF_AGL = '" + EPF_AGL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_AGL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUP))
            {
                sSQL = sSQL + "EPF_TUP = '" + EPF_TUP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TUP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VEO))
            {
                sSQL = sSQL + "EPF_VEO = '" + EPF_VEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VEO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1T))
            {
                sSQL = sSQL + "EPF_T1T = '" + EPF_T1T.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1T = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1C))
            {
                sSQL = sSQL + "EPF_T1C = '" + EPF_T1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1C = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T1L))
            {
                sSQL = sSQL + "EPF_T1L = '" + EPF_T1L.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T1L = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T2F))
            {
                sSQL = sSQL + "EPF_T2F = '" + EPF_T2F.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T2F = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVE))
            {
                sSQL = sSQL + "EPF_SVE = '" + EPF_SVE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SVE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STF))
            {
                sSQL = sSQL + "EPF_STF = '" + EPF_STF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_STF = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_STM))
            {
                sSQL = sSQL + "EPF_STM = '" + EPF_STM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_STM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCE))
            {
                sSQL = sSQL + "EPF_SCE = '" + EPF_SCE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCO))
            {
                sSQL = sSQL + "EPF_SCO = '" + EPF_SCO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCH))
            {
                sSQL = sSQL + "EPF_SCH = '" + EPF_SCH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SCG))
            {
                sSQL = sSQL + "EPF_SCG = '" + EPF_SCG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SCG = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEE))
            {
                sSQL = sSQL + "EPF_SEE = '" + EPF_SEE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEO))
            {
                sSQL = sSQL + "EPF_SEO = '" + EPF_SEO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEH))
            {
                sSQL = sSQL + "EPF_SEH = '" + EPF_SEH.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEH = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SEG))
            {
                sSQL = sSQL + "EPF_SEG = '" + EPF_SEG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SEG = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJC))
            {
                sSQL = sSQL + "EPF_SJC = '" + EPF_SJC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJT))
            {
                sSQL = sSQL + "EPF_SJT = '" + EPF_SJT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SJB))
            {
                sSQL = sSQL + "EPF_SJB = '" + EPF_SJB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SJB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPJ))
            {
                sSQL = sSQL + "EPF_SPJ = '" + EPF_SPJ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SPJ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SBC))
            {
                sSQL = sSQL + "EPF_SBC = '" + EPF_SBC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SBC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SPO))
            {
                sSQL = sSQL + "EPF_SPO = '" + EPF_SPO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SPO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_SVA))
            {
                sSQL = sSQL + "EPF_SVA = '" + EPF_SVA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_SVA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TGR))
            {
                sSQL = sSQL + "EPF_TGR = '" + EPF_TGR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TGR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIP))
            {
                sSQL = sSQL + "EPF_TIP = '" + EPF_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DSB))
            {
                sSQL = sSQL + "EPF_DSB = '" + EPF_DSB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_DSB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCA))
            {
                sSQL = sSQL + "EPF_TCA = '" + EPF_TCA.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCA = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_FMC))
            {
                sSQL = sSQL + "EPF_FMC = '" + EPF_FMC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_FMC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1TB))
            {
                sSQL = sSQL + "EPF_1TB = '" + EPF_1TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_1TB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_1PP))
            {
                sSQL = sSQL + "EPF_1PP = '" + EPF_1PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_1PP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2TB))
            {
                sSQL = sSQL + "EPF_2TB = '" + EPF_2TB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2TB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_2PP))
            {
                sSQL = sSQL + "EPF_2PP = '" + EPF_2PP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_2PP = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P1C))
            {
                sSQL = sSQL + "EPF_P1C = '" + EPF_P1C.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P1C = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P2D))
            {
                sSQL = sSQL + "EPF_P2D = '" + EPF_P2D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P2D = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P3D))
            {
                sSQL = sSQL + "EPF_P3D = '" + EPF_P3D.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P3D = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_P4U))
            {
                sSQL = sSQL + "EPF_P4U = '" + EPF_P4U.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_P4U = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_MOL))
            {
                sSQL = sSQL + "EPF_MOL = '" + EPF_MOL.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_MOL = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TPD))
            {
                sSQL = sSQL + "EPF_TPD = '" + EPF_TPD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TPD = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT1))
            {
                sSQL = sSQL + "EPF_TT1 = '" + EPF_TT1.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT2))
            {
                sSQL = sSQL + "EPF_TT2 = '" + EPF_TT2.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TT3))
            {
                sSQL = sSQL + "EPF_TT3 = '" + EPF_TT3.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TT3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_T21))
            {
                sSQL = sSQL + "EPF_T21 = '" + EPF_T21.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_T21 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TUN))
            {
                sSQL = sSQL + "EPF_TUN = '" + EPF_TUN.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TUN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TCV))
            {
                sSQL = sSQL + "EPF_TCV = '" + EPF_TCV.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TCV = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TSS))
            {
                sSQL = sSQL + "EPF_TSS = '" + EPF_TSS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TSS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TIT.ToString()))
            {
                sSQL = sSQL + "EPF_TIT = " + EPF_TIT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TIT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TNC.ToString()))
            {
                sSQL = sSQL + "EPF_TNC = " + EPF_TNC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TNC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_AON.ToString()))
            {
                sSQL = sSQL + "EPF_AON = " + EPF_AON.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_AON = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ENM.ToString()))
            {
                sSQL = sSQL + "EPF_ENM = " + EPF_ENM.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ENM = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_EEE.ToString()))
            {
                sSQL = sSQL + "EPF_EEE = " + EPF_EEE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_EEE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_KKK.ToString()))
            {
                sSQL = sSQL + "EPF_KKK = " + EPF_KKK.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_KKK = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_BBB.ToString()))
            {
                sSQL = sSQL + "EPF_BBB = " + EPF_BBB.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_BBB = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_OLE.ToString()))
            {
                sSQL = sSQL + "EPF_OLE = " + EPF_OLE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_OLE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRQ.ToString()))
            {
                sSQL = sSQL + "EPF_TRQ = " + EPF_TRQ.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_TRQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_ERT.ToString()))
            {
                sSQL = sSQL + "EPF_ERT = " + EPF_ERT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_ERT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT3.ToString()))
            {
                sSQL = sSQL + "EPF_RT3 = " + EPF_RT3.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RT3 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RT5.ToString()))
            {
                sSQL = sSQL + "EPF_RT5 = " + EPF_RT5.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RT5 = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DND.ToString()))
            {
                sSQL = sSQL + "EPF_DND = " + EPF_DND.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DND = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_DMO.ToString()))
            {
                sSQL = sSQL + "EPF_DMO = " + EPF_DMO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_DMO = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_PES.ToString()))
            {
                sSQL = sSQL + "EPF_PES = " + EPF_PES.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_PES = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_VRR))
            {
                sSQL = sSQL + "EPF_VRR = '" + EPF_VRR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_VRR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_TRE))
            {
                sSQL = sSQL + "EPF_TRE = '" + EPF_TRE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EPF_TRE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_RSP_USR_ID.ToString()))
            {
                sSQL = sSQL + "EPF_RSP_USR_ID = " + EPF_RSP_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_RSP_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EPF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = " + EPF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "EPF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE EPF_LOT = '" + EPF_LOT + "'";

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Inativar()
        {
            string sSQL = "UPDATE EPF ";
            sSQL = sSQL + "SET EPF_STS = 0, ";
            if (!String.IsNullOrEmpty(EPF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = " + EPF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EPF_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "EPF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);

            sSQL = sSQL + " WHERE EPF_LOT = '" + EPF_LOT + "'";
            //MAP01022013
            //Inativar todos os Standards do Lote independentemente das demais informações
            /*
            sSQL = sSQL + " EPF_LOT_REF = '" + EPF_LOT_REF + "' AND ";
            sSQL = sSQL + " EPF_TIT_POY_ID = " + EPF_TIT_POY_ID + " AND ";
            sSQL = sSQL + " EPF_MGE = '" + EPF_MGE + "' AND ";
            sSQL = sSQL + " EPF_FOR_ID = " + EPF_FOR_ID;
            */

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public DataSet RelatorioStandardLote()
        {
            string sSQL = "";
            string sCond = "";
            sSQL = sSQL + " SELECT * ";
            sSQL = sSQL + " FROM EPF ";
            sSQL = sSQL + " INNER JOIN ERT ON ERT_ID = EPF_ERT_ID ";
            sSQL = sSQL + " INNER JOIN TIT_POY ON TIT_POY_ID = EPF_TIT_POY_ID ";
            sSQL = sSQL + " LEFT JOIN USR ON USR_ID = EPF_RSP_USR_ID ";

            if (!String.IsNullOrEmpty(EPF_LOT))
            {
                sCond = sCond + " EPF_LOT = '" + EPF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT)))
            {
                sCond = sCond + " EPF_DAT BETWEEN Convert(datetime, '" + EPF_DAT + "',103) AND Convert(datetime, '" + EPF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_INI)))
            {
                sCond = sCond + " EPF_DAT >= Convert(datetime, '" + EPF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DAT_FIM)))
            {
                sCond = sCond + " EPF_DAT <= Convert(datetime, '" + EPF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_MAQ_TIP_ID)))
            {
                sCond = sCond + " EPF_MAQ_TIP_ID = " + EPF_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_TIT_POY_ID)))
            {
                sCond = sCond + " EPF_TIT_POY_ID = " + EPF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_PCV)))
            {
                sCond = sCond + " EPF_PCV = " + EPF_PCV + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_TAL)))
            {
                sCond = sCond + " EPF_TAL = " + EPF_TAL + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_DND)))
            {
                sCond = sCond + " EPF_DND = " + EPF_DND + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EPF_STS)))
            {
                sCond = sCond + " EPF_STS = " + EPF_STS + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY EPF_LOT ";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}