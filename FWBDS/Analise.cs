using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Analise
    {

        #region Propriedades

        private int? _ANS_ID;
        private DateTime? _ANS_DAT;
        private string _ANS_LOT;
        private string _ANS_TIP_DES;
        private int? _ANS_LOT_TST;
        private int? _ANS_TIT_POY_ID;
        private int? _ANS_APS_ID;
        private int? _ANS_MAQ_ID;
        private int? _ANS_ERT_ID;
        private string _ANS_VRD;
        private int? _ANS_POS_001;
        private double? _ANS_TIT_001;
        private double? _ANS_TNC_001;
        private double? _ANS_AON_001;
        private double? _ANS_ENM_001;
        private double? _ANS_EEE_001;
        private double? _ANS_KKK_001;
        private double? _ANS_BBB_001;
        private double? _ANS_PUE_001;
        private double? _ANS_OLE_001;
        private double? _ANS_TRQ_001;
        private double? _ANS_ERT_001;
        private double? _ANS_RT3_001;
        private double? _ANS_RT5_001;
        private double? _ANS_PES_001;
        private double? _ANS_DMO_001;
        private double? _ANS_DND_001;
        private int? _ANS_POS_002;
        private double? _ANS_TIT_002;
        private double? _ANS_TNC_002;
        private double? _ANS_AON_002;
        private double? _ANS_ENM_002;
        private double? _ANS_EEE_002;
        private double? _ANS_KKK_002;
        private double? _ANS_BBB_002;
        private double? _ANS_PUE_002;
        private double? _ANS_OLE_002;
        private double? _ANS_TRQ_002;
        private double? _ANS_ERT_002;
        private double? _ANS_RT3_002;
        private double? _ANS_RT5_002;
        private double? _ANS_PES_002;
        private double? _ANS_DMO_002;
        private double? _ANS_DND_002;
        private int? _ANS_POS_003;
        private double? _ANS_TIT_003;
        private double? _ANS_TNC_003;
        private double? _ANS_AON_003;
        private double? _ANS_ENM_003;
        private double? _ANS_EEE_003;
        private double? _ANS_KKK_003;
        private double? _ANS_BBB_003;
        private double? _ANS_PUE_003;
        private double? _ANS_OLE_003;
        private double? _ANS_TRQ_003;
        private double? _ANS_ERT_003;
        private double? _ANS_RT3_003;
        private double? _ANS_RT5_003;
        private double? _ANS_PES_003;
        private double? _ANS_DMO_003;
        private double? _ANS_DND_003;
        private int? _ANS_POS_004;
        private double? _ANS_TIT_004;
        private double? _ANS_TNC_004;
        private double? _ANS_AON_004;
        private double? _ANS_ENM_004;
        private double? _ANS_EEE_004;
        private double? _ANS_KKK_004;
        private double? _ANS_BBB_004;
        private double? _ANS_PUE_004;
        private double? _ANS_OLE_004;
        private double? _ANS_TRQ_004;
        private double? _ANS_ERT_004;
        private double? _ANS_RT3_004;
        private double? _ANS_RT5_004;
        private double? _ANS_PES_004;
        private double? _ANS_DMO_004;
        private double? _ANS_DND_004;
        private int? _ANS_POS_005;
        private double? _ANS_TIT_005;
        private double? _ANS_TNC_005;
        private double? _ANS_AON_005;
        private double? _ANS_ENM_005;
        private double? _ANS_EEE_005;
        private double? _ANS_KKK_005;
        private double? _ANS_BBB_005;
        private double? _ANS_PUE_005;
        private double? _ANS_OLE_005;
        private double? _ANS_TRQ_005;
        private double? _ANS_ERT_005;
        private double? _ANS_RT3_005;
        private double? _ANS_RT5_005;
        private double? _ANS_PES_005;
        private double? _ANS_DMO_005;
        private double? _ANS_DND_005;
        private int? _ANS_POS_006;
        private double? _ANS_TIT_006;
        private double? _ANS_TNC_006;
        private double? _ANS_AON_006;
        private double? _ANS_ENM_006;
        private double? _ANS_EEE_006;
        private double? _ANS_KKK_006;
        private double? _ANS_BBB_006;
        private double? _ANS_PUE_006;
        private double? _ANS_OLE_006;
        private double? _ANS_TRQ_006;
        private double? _ANS_ERT_006;
        private double? _ANS_RT3_006;
        private double? _ANS_RT5_006;
        private double? _ANS_PES_006;
        private double? _ANS_DMO_006;
        private double? _ANS_DND_006;
        private double? _ANS_TIT_MED;
        private double? _ANS_TNC_MED;
        private double? _ANS_AON_MED;
        private double? _ANS_ENM_MED;
        private double? _ANS_EEE_MED;
        private double? _ANS_KKK_MED;
        private double? _ANS_BBB_MED;
        private double? _ANS_PUE_MED;
        private double? _ANS_OLE_MED;
        private double? _ANS_TRQ_MED;
        private double? _ANS_ERT_MED;
        private double? _ANS_RT3_MED;
        private double? _ANS_RT5_MED;
        private double? _ANS_PES_MED;
        private double? _ANS_DMO_MED;
        private double? _ANS_DND_MED;
        private double? _ANS_TIT_DSV;
        private double? _ANS_TNC_DSV;
        private double? _ANS_AON_DSV;
        private double? _ANS_ENM_DSV;
        private double? _ANS_EEE_DSV;
        private double? _ANS_KKK_DSV;
        private double? _ANS_BBB_DSV;
        private double? _ANS_PUE_DSV;
        private double? _ANS_OLE_DSV;
        private double? _ANS_TRQ_DSV;
        private double? _ANS_ERT_DSV;
        private double? _ANS_RT3_DSV;
        private double? _ANS_RT5_DSV;
        private double? _ANS_PES_DSV;
        private double? _ANS_DMO_DSV;
        private double? _ANS_DND_DSV;
        private string _ANS_OBS;
        private int? _ANS_STS;
        private int? _ANS_USR_INC_ID;
        private int? _ANS_USR_ALT_ID;
        private DateTime? _ANS_TMS_ATL;

        private DateTime? _ANS_DAT_INI;
        private DateTime? _ANS_DAT_FIM;

        private double? _ANS_TIT_INF;
        private double? _ANS_TNC_INF;
        private double? _ANS_AON_INF;
        private double? _ANS_ENM_INF;
        private double? _ANS_EEE_INF;
        private double? _ANS_KKK_INF;
        private double? _ANS_BBB_INF;
        private double? _ANS_PUE_INF;
        private double? _ANS_OLE_INF;
        private double? _ANS_TRQ_INF;
        private double? _ANS_ERT_INF;
        private double? _ANS_RT3_INF;
        private double? _ANS_RT5_INF;
        private double? _ANS_PES_INF;
        private double? _ANS_DMO_INF;
        private double? _ANS_DND_INF;

        private double? _ANS_TIT_SUP;
        private double? _ANS_TNC_SUP;
        private double? _ANS_AON_SUP;
        private double? _ANS_ENM_SUP;
        private double? _ANS_EEE_SUP;
        private double? _ANS_KKK_SUP;
        private double? _ANS_BBB_SUP;
        private double? _ANS_PUE_SUP;
        private double? _ANS_OLE_SUP;
        private double? _ANS_TRQ_SUP;
        private double? _ANS_ERT_SUP;
        private double? _ANS_RT3_SUP;
        private double? _ANS_RT5_SUP;
        private double? _ANS_PES_SUP;
        private double? _ANS_DMO_SUP;
        private double? _ANS_DND_SUP;

        private string _ANS_MED;

        private string _LST_ANS_TIP;

        private int? _MAQ_TIP_ID;

        private string _TOP;
        private string _SQL;

        public int? ANS_ID
        {
            get { return _ANS_ID; }
            set { _ANS_ID = value; }
        }
        public DateTime? ANS_DAT
        {
            get { return _ANS_DAT; }
            set { _ANS_DAT = value; }
        }
        public string ANS_LOT
        {
            get { return _ANS_LOT; }
            set { _ANS_LOT = value.ToUpper(); }
        }
        public string ANS_TIP_DES
        {
            get { return _ANS_TIP_DES; }
            set { _ANS_TIP_DES = value.ToUpper(); }
        }
        public int? ANS_LOT_TST
        {
            get { return _ANS_LOT_TST; }
            set { _ANS_LOT_TST = value; }
        }
        public int? ANS_TIT_POY_ID
        {
            get { return _ANS_TIT_POY_ID; }
            set { _ANS_TIT_POY_ID = value; }
        }
        public int? ANS_APS_ID
        {
            get { return _ANS_APS_ID; }
            set { _ANS_APS_ID = value; }
        }
        public int? ANS_MAQ_ID
        {
            get { return _ANS_MAQ_ID; }
            set { _ANS_MAQ_ID = value; }
        }
        public int? ANS_ERT_ID
        {
            get { return _ANS_ERT_ID; }
            set { _ANS_ERT_ID = value; }
        }
        public string ANS_VRD
        {
            get { return _ANS_VRD; }
            set { _ANS_VRD = value.ToUpper(); }
        }
        public int? ANS_POS_001
        {
            get { return _ANS_POS_001; }
            set { _ANS_POS_001 = value; }
        }
        public double? ANS_TIT_001
        {
            get { return _ANS_TIT_001; }
            set { _ANS_TIT_001 = value; }
        }
        public double? ANS_TNC_001
        {
            get { return _ANS_TNC_001; }
            set { _ANS_TNC_001 = value; }
        }
        public double? ANS_AON_001
        {
            get { return _ANS_AON_001; }
            set { _ANS_AON_001 = value; }
        }
        public double? ANS_ENM_001
        {
            get { return _ANS_ENM_001; }
            set { _ANS_ENM_001 = value; }
        }
        public double? ANS_EEE_001
        {
            get { return _ANS_EEE_001; }
            set { _ANS_EEE_001 = value; }
        }
        public double? ANS_KKK_001
        {
            get { return _ANS_KKK_001; }
            set { _ANS_KKK_001 = value; }
        }
        public double? ANS_BBB_001
        {
            get { return _ANS_BBB_001; }
            set { _ANS_BBB_001 = value; }
        }
        public double? ANS_PUE_001
        {
            get { return _ANS_PUE_001; }
            set { _ANS_PUE_001 = value; }
        }
        public double? ANS_OLE_001
        {
            get { return _ANS_OLE_001; }
            set { _ANS_OLE_001 = value; }
        }
        public double? ANS_TRQ_001
        {
            get { return _ANS_TRQ_001; }
            set { _ANS_TRQ_001 = value; }
        }
        public double? ANS_ERT_001
        {
            get { return _ANS_ERT_001; }
            set { _ANS_ERT_001 = value; }
        }
        public double? ANS_RT3_001
        {
            get { return _ANS_RT3_001; }
            set { _ANS_RT3_001 = value; }
        }
        public double? ANS_RT5_001
        {
            get { return _ANS_RT5_001; }
            set { _ANS_RT5_001 = value; }
        }
        public double? ANS_PES_001
        {
            get { return _ANS_PES_001; }
            set { _ANS_PES_001 = value; }
        }
        public double? ANS_DMO_001
        {
            get { return _ANS_DMO_001; }
            set { _ANS_DMO_001 = value; }
        }
        public double? ANS_DND_001
        {
            get { return _ANS_DND_001; }
            set { _ANS_DND_001 = value; }
        }
        public int? ANS_POS_002
        {
            get { return _ANS_POS_002; }
            set { _ANS_POS_002 = value; }
        }
        public double? ANS_TIT_002
        {
            get { return _ANS_TIT_002; }
            set { _ANS_TIT_002 = value; }
        }
        public double? ANS_TNC_002
        {
            get { return _ANS_TNC_002; }
            set { _ANS_TNC_002 = value; }
        }
        public double? ANS_AON_002
        {
            get { return _ANS_AON_002; }
            set { _ANS_AON_002 = value; }
        }
        public double? ANS_ENM_002
        {
            get { return _ANS_ENM_002; }
            set { _ANS_ENM_002 = value; }
        }
        public double? ANS_EEE_002
        {
            get { return _ANS_EEE_002; }
            set { _ANS_EEE_002 = value; }
        }
        public double? ANS_KKK_002
        {
            get { return _ANS_KKK_002; }
            set { _ANS_KKK_002 = value; }
        }
        public double? ANS_BBB_002
        {
            get { return _ANS_BBB_002; }
            set { _ANS_BBB_002 = value; }
        }
        public double? ANS_PUE_002
        {
            get { return _ANS_PUE_002; }
            set { _ANS_PUE_002 = value; }
        }
        public double? ANS_OLE_002
        {
            get { return _ANS_OLE_002; }
            set { _ANS_OLE_002 = value; }
        }
        public double? ANS_TRQ_002
        {
            get { return _ANS_TRQ_002; }
            set { _ANS_TRQ_002 = value; }
        }
        public double? ANS_ERT_002
        {
            get { return _ANS_ERT_002; }
            set { _ANS_ERT_002 = value; }
        }
        public double? ANS_RT3_002
        {
            get { return _ANS_RT3_002; }
            set { _ANS_RT3_002 = value; }
        }
        public double? ANS_RT5_002
        {
            get { return _ANS_RT5_002; }
            set { _ANS_RT5_002 = value; }
        }
        public double? ANS_PES_002
        {
            get { return _ANS_PES_002; }
            set { _ANS_PES_002 = value; }
        }
        public double? ANS_DMO_002
        {
            get { return _ANS_DMO_002; }
            set { _ANS_DMO_002 = value; }
        }
        public double? ANS_DND_002
        {
            get { return _ANS_DND_002; }
            set { _ANS_DND_002 = value; }
        }
        public int? ANS_POS_003
        {
            get { return _ANS_POS_003; }
            set { _ANS_POS_003 = value; }
        }
        public double? ANS_TIT_003
        {
            get { return _ANS_TIT_003; }
            set { _ANS_TIT_003 = value; }
        }
        public double? ANS_TNC_003
        {
            get { return _ANS_TNC_003; }
            set { _ANS_TNC_003 = value; }
        }
        public double? ANS_AON_003
        {
            get { return _ANS_AON_003; }
            set { _ANS_AON_003 = value; }
        }
        public double? ANS_ENM_003
        {
            get { return _ANS_ENM_003; }
            set { _ANS_ENM_003 = value; }
        }
        public double? ANS_EEE_003
        {
            get { return _ANS_EEE_003; }
            set { _ANS_EEE_003 = value; }
        }
        public double? ANS_KKK_003
        {
            get { return _ANS_KKK_003; }
            set { _ANS_KKK_003 = value; }
        }
        public double? ANS_BBB_003
        {
            get { return _ANS_BBB_003; }
            set { _ANS_BBB_003 = value; }
        }
        public double? ANS_PUE_003
        {
            get { return _ANS_PUE_003; }
            set { _ANS_PUE_003 = value; }
        }
        public double? ANS_OLE_003
        {
            get { return _ANS_OLE_003; }
            set { _ANS_OLE_003 = value; }
        }
        public double? ANS_TRQ_003
        {
            get { return _ANS_TRQ_003; }
            set { _ANS_TRQ_003 = value; }
        }
        public double? ANS_ERT_003
        {
            get { return _ANS_ERT_003; }
            set { _ANS_ERT_003 = value; }
        }
        public double? ANS_RT3_003
        {
            get { return _ANS_RT3_003; }
            set { _ANS_RT3_003 = value; }
        }
        public double? ANS_RT5_003
        {
            get { return _ANS_RT5_003; }
            set { _ANS_RT5_003 = value; }
        }
        public double? ANS_PES_003
        {
            get { return _ANS_PES_003; }
            set { _ANS_PES_003 = value; }
        }
        public double? ANS_DMO_003
        {
            get { return _ANS_DMO_003; }
            set { _ANS_DMO_003 = value; }
        }
        public double? ANS_DND_003
        {
            get { return _ANS_DND_003; }
            set { _ANS_DND_003 = value; }
        }
        public int? ANS_POS_004
        {
            get { return _ANS_POS_004; }
            set { _ANS_POS_004 = value; }
        }
        public double? ANS_TIT_004
        {
            get { return _ANS_TIT_004; }
            set { _ANS_TIT_004 = value; }
        }
        public double? ANS_TNC_004
        {
            get { return _ANS_TNC_004; }
            set { _ANS_TNC_004 = value; }
        }
        public double? ANS_AON_004
        {
            get { return _ANS_AON_004; }
            set { _ANS_AON_004 = value; }
        }
        public double? ANS_ENM_004
        {
            get { return _ANS_ENM_004; }
            set { _ANS_ENM_004 = value; }
        }
        public double? ANS_EEE_004
        {
            get { return _ANS_EEE_004; }
            set { _ANS_EEE_004 = value; }
        }
        public double? ANS_KKK_004
        {
            get { return _ANS_KKK_004; }
            set { _ANS_KKK_004 = value; }
        }
        public double? ANS_BBB_004
        {
            get { return _ANS_BBB_004; }
            set { _ANS_BBB_004 = value; }
        }
        public double? ANS_PUE_004
        {
            get { return _ANS_PUE_004; }
            set { _ANS_PUE_004 = value; }
        }
        public double? ANS_OLE_004
        {
            get { return _ANS_OLE_004; }
            set { _ANS_OLE_004 = value; }
        }
        public double? ANS_TRQ_004
        {
            get { return _ANS_TRQ_004; }
            set { _ANS_TRQ_004 = value; }
        }
        public double? ANS_ERT_004
        {
            get { return _ANS_ERT_004; }
            set { _ANS_ERT_004 = value; }
        }
        public double? ANS_RT3_004
        {
            get { return _ANS_RT3_004; }
            set { _ANS_RT3_004 = value; }
        }
        public double? ANS_RT5_004
        {
            get { return _ANS_RT5_004; }
            set { _ANS_RT5_004 = value; }
        }
        public double? ANS_PES_004
        {
            get { return _ANS_PES_004; }
            set { _ANS_PES_004 = value; }
        }
        public double? ANS_DMO_004
        {
            get { return _ANS_DMO_004; }
            set { _ANS_DMO_004 = value; }
        }
        public double? ANS_DND_004
        {
            get { return _ANS_DND_004; }
            set { _ANS_DND_004 = value; }
        }
        public int? ANS_POS_005
        {
            get { return _ANS_POS_005; }
            set { _ANS_POS_005 = value; }
        }
        public double? ANS_TIT_005
        {
            get { return _ANS_TIT_005; }
            set { _ANS_TIT_005 = value; }
        }
        public double? ANS_TNC_005
        {
            get { return _ANS_TNC_005; }
            set { _ANS_TNC_005 = value; }
        }
        public double? ANS_AON_005
        {
            get { return _ANS_AON_005; }
            set { _ANS_AON_005 = value; }
        }
        public double? ANS_ENM_005
        {
            get { return _ANS_ENM_005; }
            set { _ANS_ENM_005 = value; }
        }
        public double? ANS_EEE_005
        {
            get { return _ANS_EEE_005; }
            set { _ANS_EEE_005 = value; }
        }
        public double? ANS_KKK_005
        {
            get { return _ANS_KKK_005; }
            set { _ANS_KKK_005 = value; }
        }
        public double? ANS_BBB_005
        {
            get { return _ANS_BBB_005; }
            set { _ANS_BBB_005 = value; }
        }
        public double? ANS_PUE_005
        {
            get { return _ANS_PUE_005; }
            set { _ANS_PUE_005 = value; }
        }
        public double? ANS_OLE_005
        {
            get { return _ANS_OLE_005; }
            set { _ANS_OLE_005 = value; }
        }
        public double? ANS_TRQ_005
        {
            get { return _ANS_TRQ_005; }
            set { _ANS_TRQ_005 = value; }
        }
        public double? ANS_ERT_005
        {
            get { return _ANS_ERT_005; }
            set { _ANS_ERT_005 = value; }
        }
        public double? ANS_RT3_005
        {
            get { return _ANS_RT3_005; }
            set { _ANS_RT3_005 = value; }
        }
        public double? ANS_RT5_005
        {
            get { return _ANS_RT5_005; }
            set { _ANS_RT5_005 = value; }
        }
        public double? ANS_PES_005
        {
            get { return _ANS_PES_005; }
            set { _ANS_PES_005 = value; }
        }
        public double? ANS_DMO_005
        {
            get { return _ANS_DMO_005; }
            set { _ANS_DMO_005 = value; }
        }
        public double? ANS_DND_005
        {
            get { return _ANS_DND_005; }
            set { _ANS_DND_005 = value; }
        }
        public int? ANS_POS_006
        {
            get { return _ANS_POS_006; }
            set { _ANS_POS_006 = value; }
        }
        public double? ANS_TIT_006
        {
            get { return _ANS_TIT_006; }
            set { _ANS_TIT_006 = value; }
        }
        public double? ANS_TNC_006
        {
            get { return _ANS_TNC_006; }
            set { _ANS_TNC_006 = value; }
        }
        public double? ANS_AON_006
        {
            get { return _ANS_AON_006; }
            set { _ANS_AON_006 = value; }
        }
        public double? ANS_ENM_006
        {
            get { return _ANS_ENM_006; }
            set { _ANS_ENM_006 = value; }
        }
        public double? ANS_EEE_006
        {
            get { return _ANS_EEE_006; }
            set { _ANS_EEE_006 = value; }
        }
        public double? ANS_KKK_006
        {
            get { return _ANS_KKK_006; }
            set { _ANS_KKK_006 = value; }
        }
        public double? ANS_BBB_006
        {
            get { return _ANS_BBB_006; }
            set { _ANS_BBB_006 = value; }
        }
        public double? ANS_PUE_006
        {
            get { return _ANS_PUE_006; }
            set { _ANS_PUE_006 = value; }
        }
        public double? ANS_OLE_006
        {
            get { return _ANS_OLE_006; }
            set { _ANS_OLE_006 = value; }
        }
        public double? ANS_TRQ_006
        {
            get { return _ANS_TRQ_006; }
            set { _ANS_TRQ_006 = value; }
        }
        public double? ANS_ERT_006
        {
            get { return _ANS_ERT_006; }
            set { _ANS_ERT_006 = value; }
        }
        public double? ANS_RT3_006
        {
            get { return _ANS_RT3_006; }
            set { _ANS_RT3_006 = value; }
        }
        public double? ANS_RT5_006
        {
            get { return _ANS_RT5_006; }
            set { _ANS_RT5_006 = value; }
        }
        public double? ANS_PES_006
        {
            get { return _ANS_PES_006; }
            set { _ANS_PES_006 = value; }
        }
        public double? ANS_DMO_006
        {
            get { return _ANS_DMO_006; }
            set { _ANS_DMO_006 = value; }
        }
        public double? ANS_DND_006
        {
            get { return _ANS_DND_006; }
            set { _ANS_DND_006 = value; }
        }
        public double? ANS_TIT_MED
        {
            get { return _ANS_TIT_MED; }
            set { _ANS_TIT_MED = value; }
        }
        public double? ANS_TNC_MED
        {
            get { return _ANS_TNC_MED; }
            set { _ANS_TNC_MED = value; }
        }
        public double? ANS_AON_MED
        {
            get { return _ANS_AON_MED; }
            set { _ANS_AON_MED = value; }
        }
        public double? ANS_ENM_MED
        {
            get { return _ANS_ENM_MED; }
            set { _ANS_ENM_MED = value; }
        }
        public double? ANS_EEE_MED
        {
            get { return _ANS_EEE_MED; }
            set { _ANS_EEE_MED = value; }
        }
        public double? ANS_KKK_MED
        {
            get { return _ANS_KKK_MED; }
            set { _ANS_KKK_MED = value; }
        }
        public double? ANS_BBB_MED
        {
            get { return _ANS_BBB_MED; }
            set { _ANS_BBB_MED = value; }
        }
        public double? ANS_PUE_MED
        {
            get { return _ANS_PUE_MED; }
            set { _ANS_PUE_MED = value; }
        }
        public double? ANS_OLE_MED
        {
            get { return _ANS_OLE_MED; }
            set { _ANS_OLE_MED = value; }
        }
        public double? ANS_TRQ_MED
        {
            get { return _ANS_TRQ_MED; }
            set { _ANS_TRQ_MED = value; }
        }
        public double? ANS_ERT_MED
        {
            get { return _ANS_ERT_MED; }
            set { _ANS_ERT_MED = value; }
        }
        public double? ANS_RT3_MED
        {
            get { return _ANS_RT3_MED; }
            set { _ANS_RT3_MED = value; }
        }
        public double? ANS_RT5_MED
        {
            get { return _ANS_RT5_MED; }
            set { _ANS_RT5_MED = value; }
        }
        public double? ANS_PES_MED
        {
            get { return _ANS_PES_MED; }
            set { _ANS_PES_MED = value; }
        }
        public double? ANS_DMO_MED
        {
            get { return _ANS_DMO_MED; }
            set { _ANS_DMO_MED = value; }
        }
        public double? ANS_DND_MED
        {
            get { return _ANS_DND_MED; }
            set { _ANS_DND_MED = value; }
        }
        public double? ANS_TIT_DSV
        {
            get { return _ANS_TIT_DSV; }
            set { _ANS_TIT_DSV = value; }
        }
        public double? ANS_TNC_DSV
        {
            get { return _ANS_TNC_DSV; }
            set { _ANS_TNC_DSV = value; }
        }
        public double? ANS_AON_DSV
        {
            get { return _ANS_AON_DSV; }
            set { _ANS_AON_DSV = value; }
        }
        public double? ANS_ENM_DSV
        {
            get { return _ANS_ENM_DSV; }
            set { _ANS_ENM_DSV = value; }
        }
        public double? ANS_EEE_DSV
        {
            get { return _ANS_EEE_DSV; }
            set { _ANS_EEE_DSV = value; }
        }
        public double? ANS_KKK_DSV
        {
            get { return _ANS_KKK_DSV; }
            set { _ANS_KKK_DSV = value; }
        }
        public double? ANS_BBB_DSV
        {
            get { return _ANS_BBB_DSV; }
            set { _ANS_BBB_DSV = value; }
        }
        public double? ANS_PUE_DSV
        {
            get { return _ANS_PUE_DSV; }
            set { _ANS_PUE_DSV = value; }
        }
        public double? ANS_OLE_DSV
        {
            get { return _ANS_OLE_DSV; }
            set { _ANS_OLE_DSV = value; }
        }
        public double? ANS_TRQ_DSV
        {
            get { return _ANS_TRQ_DSV; }
            set { _ANS_TRQ_DSV = value; }
        }
        public double? ANS_ERT_DSV
        {
            get { return _ANS_ERT_DSV; }
            set { _ANS_ERT_DSV = value; }
        }
        public double? ANS_RT3_DSV
        {
            get { return _ANS_RT3_DSV; }
            set { _ANS_RT3_DSV = value; }
        }
        public double? ANS_RT5_DSV
        {
            get { return _ANS_RT5_DSV; }
            set { _ANS_RT5_DSV = value; }
        }
        public double? ANS_PES_DSV
        {
            get { return _ANS_PES_DSV; }
            set { _ANS_PES_DSV = value; }
        }
        public double? ANS_DMO_DSV
        {
            get { return _ANS_DMO_DSV; }
            set { _ANS_DMO_DSV = value; }
        }
        public double? ANS_DND_DSV
        {
            get { return _ANS_DND_DSV; }
            set { _ANS_DND_DSV = value; }
        }
        public string ANS_OBS
        {
            get { return _ANS_OBS; }
            set { _ANS_OBS = value.ToUpper(); }
        }
        public int? ANS_STS
        {
            get { return _ANS_STS; }
            set { _ANS_STS = value; }
        }
        public int? ANS_USR_INC_ID
        {
            get { return _ANS_USR_INC_ID; }
            set { _ANS_USR_INC_ID = value; }
        }
        public int? ANS_USR_ALT_ID
        {
            get { return _ANS_USR_ALT_ID; }
            set { _ANS_USR_ALT_ID = value; }
        }
        public DateTime? ANS_TMS_ATL
        {
            get { return _ANS_TMS_ATL; }
            set { _ANS_TMS_ATL = value; }
        }

        public DateTime? ANS_DAT_INI
        {
            get { return _ANS_DAT_INI; }
            set { _ANS_DAT_INI = value; }
        }
        
        public DateTime? ANS_DAT_FIM
        {
            get { return _ANS_DAT_FIM; }
            set { _ANS_DAT_FIM = value; }
        }

        public double? ANS_TIT_INF
        {
            get { return _ANS_TIT_INF; }
            set { _ANS_TIT_INF = value; }
        }
        public double? ANS_TNC_INF
        {
            get { return _ANS_TNC_INF; }
            set { _ANS_TNC_INF = value; }
        }
        public double? ANS_AON_INF
        {
            get { return _ANS_AON_INF; }
            set { _ANS_AON_INF = value; }
        }
        public double? ANS_ENM_INF
        {
            get { return _ANS_ENM_INF; }
            set { _ANS_ENM_INF = value; }
        }
        public double? ANS_EEE_INF
        {
            get { return _ANS_EEE_INF; }
            set { _ANS_EEE_INF = value; }
        }
        public double? ANS_KKK_INF
        {
            get { return _ANS_KKK_INF; }
            set { _ANS_KKK_INF = value; }
        }
        public double? ANS_BBB_INF
        {
            get { return _ANS_BBB_INF; }
            set { _ANS_BBB_INF = value; }
        }
        public double? ANS_PUE_INF
        {
            get { return _ANS_PUE_INF; }
            set { _ANS_PUE_INF = value; }
        }
        public double? ANS_OLE_INF
        {
            get { return _ANS_OLE_INF; }
            set { _ANS_OLE_INF = value; }
        }
        public double? ANS_TRQ_INF
        {
            get { return _ANS_TRQ_INF; }
            set { _ANS_TRQ_INF = value; }
        }
        public double? ANS_ERT_INF
        {
            get { return _ANS_ERT_INF; }
            set { _ANS_ERT_INF = value; }
        }
        public double? ANS_RT3_INF
        {
            get { return _ANS_RT3_INF; }
            set { _ANS_RT3_INF = value; }
        }
        public double? ANS_RT5_INF
        {
            get { return _ANS_RT5_INF; }
            set { _ANS_RT5_INF = value; }
        }
        public double? ANS_PES_INF
        {
            get { return _ANS_PES_INF; }
            set { _ANS_PES_INF = value; }
        }
        public double? ANS_DMO_INF
        {
            get { return _ANS_DMO_INF; }
            set { _ANS_DMO_INF = value; }
        }
        public double? ANS_DND_INF
        {
            get { return _ANS_DND_INF; }
            set { _ANS_DND_INF = value; }
        }
        public double? ANS_TIT_SUP
        {
            get { return _ANS_TIT_SUP; }
            set { _ANS_TIT_SUP = value; }
        }
        public double? ANS_TNC_SUP
        {
            get { return _ANS_TNC_SUP; }
            set { _ANS_TNC_SUP = value; }
        }
        public double? ANS_AON_SUP
        {
            get { return _ANS_AON_SUP; }
            set { _ANS_AON_SUP = value; }
        }
        public double? ANS_ENM_SUP
        {
            get { return _ANS_ENM_SUP; }
            set { _ANS_ENM_SUP = value; }
        }
        public double? ANS_EEE_SUP
        {
            get { return _ANS_EEE_SUP; }
            set { _ANS_EEE_SUP = value; }
        }
        public double? ANS_KKK_SUP
        {
            get { return _ANS_KKK_SUP; }
            set { _ANS_KKK_SUP = value; }
        }
        public double? ANS_BBB_SUP
        {
            get { return _ANS_BBB_SUP; }
            set { _ANS_BBB_SUP = value; }
        }
        public double? ANS_PUE_SUP
        {
            get { return _ANS_PUE_SUP; }
            set { _ANS_PUE_SUP = value; }
        }
        public double? ANS_OLE_SUP
        {
            get { return _ANS_OLE_SUP; }
            set { _ANS_OLE_SUP = value; }
        }
        public double? ANS_TRQ_SUP
        {
            get { return _ANS_TRQ_SUP; }
            set { _ANS_TRQ_SUP = value; }
        }
        public double? ANS_ERT_SUP
        {
            get { return _ANS_ERT_SUP; }
            set { _ANS_ERT_SUP = value; }
        }
        public double? ANS_RT3_SUP
        {
            get { return _ANS_RT3_SUP; }
            set { _ANS_RT3_SUP = value; }
        }
        public double? ANS_RT5_SUP
        {
            get { return _ANS_RT5_SUP; }
            set { _ANS_RT5_SUP = value; }
        }
        public double? ANS_PES_SUP
        {
            get { return _ANS_PES_SUP; }
            set { _ANS_PES_SUP = value; }
        }
        public double? ANS_DMO_SUP
        {
            get { return _ANS_DMO_SUP; }
            set { _ANS_DMO_SUP = value; }
        }
        public double? ANS_DND_SUP
        {
            get { return _ANS_DND_SUP; }
            set { _ANS_DND_SUP = value; }
        }

        public string ANS_MED
        {
            get { return _ANS_MED; }
            set { _ANS_MED = value.ToUpper(); }
        }

        public string LST_ANS_TIP
        {
            get { return _LST_ANS_TIP; }
            set { _LST_ANS_TIP = value.ToUpper(); }
        }

        public int? MAQ_TIP_ID
        {
            get { return _MAQ_TIP_ID; }
            set { _MAQ_TIP_ID = value; }
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
            string sSQL = "INSERT INTO ANS (";
            sSQL = sSQL + "ANS_DAT, ";
            sSQL = sSQL + "ANS_LOT, ";
            sSQL = sSQL + "ANS_TIP_DES, ";
            sSQL = sSQL + "ANS_LOT_TST, ";
            sSQL = sSQL + "ANS_TIT_POY_ID, ";
            sSQL = sSQL + "ANS_APS_ID, ";
            sSQL = sSQL + "ANS_MAQ_ID, ";
            sSQL = sSQL + "ANS_ERT_ID, ";
            sSQL = sSQL + "ANS_VRD, ";
            sSQL = sSQL + "ANS_POS_001, ";
            sSQL = sSQL + "ANS_TIT_001, ";
            sSQL = sSQL + "ANS_TNC_001, ";
            sSQL = sSQL + "ANS_AON_001, ";
            sSQL = sSQL + "ANS_ENM_001, ";
            sSQL = sSQL + "ANS_EEE_001, ";
            sSQL = sSQL + "ANS_KKK_001, ";
            sSQL = sSQL + "ANS_BBB_001, ";
            sSQL = sSQL + "ANS_PUE_001, ";
            sSQL = sSQL + "ANS_OLE_001, ";
            sSQL = sSQL + "ANS_TRQ_001, ";
            sSQL = sSQL + "ANS_ERT_001, ";
            sSQL = sSQL + "ANS_RT3_001, ";
            sSQL = sSQL + "ANS_RT5_001, ";
            sSQL = sSQL + "ANS_PES_001, ";
            sSQL = sSQL + "ANS_DMO_001, ";
            sSQL = sSQL + "ANS_DND_001, ";
            sSQL = sSQL + "ANS_POS_002, ";
            sSQL = sSQL + "ANS_TIT_002, ";
            sSQL = sSQL + "ANS_TNC_002, ";
            sSQL = sSQL + "ANS_AON_002, ";
            sSQL = sSQL + "ANS_ENM_002, ";
            sSQL = sSQL + "ANS_EEE_002, ";
            sSQL = sSQL + "ANS_KKK_002, ";
            sSQL = sSQL + "ANS_BBB_002, ";
            sSQL = sSQL + "ANS_PUE_002, ";
            sSQL = sSQL + "ANS_OLE_002, ";
            sSQL = sSQL + "ANS_TRQ_002, ";
            sSQL = sSQL + "ANS_ERT_002, ";
            sSQL = sSQL + "ANS_RT3_002, ";
            sSQL = sSQL + "ANS_RT5_002, ";
            sSQL = sSQL + "ANS_PES_002, ";
            sSQL = sSQL + "ANS_DMO_002, ";
            sSQL = sSQL + "ANS_DND_002, ";
            sSQL = sSQL + "ANS_POS_003, ";
            sSQL = sSQL + "ANS_TIT_003, ";
            sSQL = sSQL + "ANS_TNC_003, ";
            sSQL = sSQL + "ANS_AON_003, ";
            sSQL = sSQL + "ANS_ENM_003, ";
            sSQL = sSQL + "ANS_EEE_003, ";
            sSQL = sSQL + "ANS_KKK_003, ";
            sSQL = sSQL + "ANS_BBB_003, ";
            sSQL = sSQL + "ANS_PUE_003, ";
            sSQL = sSQL + "ANS_OLE_003, ";
            sSQL = sSQL + "ANS_TRQ_003, ";
            sSQL = sSQL + "ANS_ERT_003, ";
            sSQL = sSQL + "ANS_RT3_003, ";
            sSQL = sSQL + "ANS_RT5_003, ";
            sSQL = sSQL + "ANS_PES_003, ";
            sSQL = sSQL + "ANS_DMO_003, ";
            sSQL = sSQL + "ANS_DND_003, ";
            sSQL = sSQL + "ANS_POS_004, ";
            sSQL = sSQL + "ANS_TIT_004, ";
            sSQL = sSQL + "ANS_TNC_004, ";
            sSQL = sSQL + "ANS_AON_004, ";
            sSQL = sSQL + "ANS_ENM_004, ";
            sSQL = sSQL + "ANS_EEE_004, ";
            sSQL = sSQL + "ANS_KKK_004, ";
            sSQL = sSQL + "ANS_BBB_004, ";
            sSQL = sSQL + "ANS_PUE_004, ";
            sSQL = sSQL + "ANS_OLE_004, ";
            sSQL = sSQL + "ANS_TRQ_004, ";
            sSQL = sSQL + "ANS_ERT_004, ";
            sSQL = sSQL + "ANS_RT3_004, ";
            sSQL = sSQL + "ANS_RT5_004, ";
            sSQL = sSQL + "ANS_PES_004, ";
            sSQL = sSQL + "ANS_DMO_004, ";
            sSQL = sSQL + "ANS_DND_004, ";
            sSQL = sSQL + "ANS_POS_005, ";
            sSQL = sSQL + "ANS_TIT_005, ";
            sSQL = sSQL + "ANS_TNC_005, ";
            sSQL = sSQL + "ANS_AON_005, ";
            sSQL = sSQL + "ANS_ENM_005, ";
            sSQL = sSQL + "ANS_EEE_005, ";
            sSQL = sSQL + "ANS_KKK_005, ";
            sSQL = sSQL + "ANS_BBB_005, ";
            sSQL = sSQL + "ANS_PUE_005, ";
            sSQL = sSQL + "ANS_OLE_005, ";
            sSQL = sSQL + "ANS_TRQ_005, ";
            sSQL = sSQL + "ANS_ERT_005, ";
            sSQL = sSQL + "ANS_RT3_005, ";
            sSQL = sSQL + "ANS_RT5_005, ";
            sSQL = sSQL + "ANS_PES_005, ";
            sSQL = sSQL + "ANS_DMO_005, ";
            sSQL = sSQL + "ANS_DND_005, ";
            sSQL = sSQL + "ANS_POS_006, ";
            sSQL = sSQL + "ANS_TIT_006, ";
            sSQL = sSQL + "ANS_TNC_006, ";
            sSQL = sSQL + "ANS_AON_006, ";
            sSQL = sSQL + "ANS_ENM_006, ";
            sSQL = sSQL + "ANS_EEE_006, ";
            sSQL = sSQL + "ANS_KKK_006, ";
            sSQL = sSQL + "ANS_BBB_006, ";
            sSQL = sSQL + "ANS_PUE_006, ";
            sSQL = sSQL + "ANS_OLE_006, ";
            sSQL = sSQL + "ANS_TRQ_006, ";
            sSQL = sSQL + "ANS_ERT_006, ";
            sSQL = sSQL + "ANS_RT3_006, ";
            sSQL = sSQL + "ANS_RT5_006, ";
            sSQL = sSQL + "ANS_PES_006, ";
            sSQL = sSQL + "ANS_DMO_006, ";
            sSQL = sSQL + "ANS_DND_006, ";
            sSQL = sSQL + "ANS_TIT_MED, ";
            sSQL = sSQL + "ANS_TNC_MED, ";
            sSQL = sSQL + "ANS_AON_MED, ";
            sSQL = sSQL + "ANS_ENM_MED, ";
            sSQL = sSQL + "ANS_EEE_MED, ";
            sSQL = sSQL + "ANS_KKK_MED, ";
            sSQL = sSQL + "ANS_BBB_MED, ";
            sSQL = sSQL + "ANS_PUE_MED, ";
            sSQL = sSQL + "ANS_OLE_MED, ";
            sSQL = sSQL + "ANS_TRQ_MED, ";
            sSQL = sSQL + "ANS_ERT_MED, ";
            sSQL = sSQL + "ANS_RT3_MED, ";
            sSQL = sSQL + "ANS_RT5_MED, ";
            sSQL = sSQL + "ANS_PES_MED, ";
            sSQL = sSQL + "ANS_DMO_MED, ";
            sSQL = sSQL + "ANS_DND_MED, ";
            sSQL = sSQL + "ANS_TIT_DSV, ";
            sSQL = sSQL + "ANS_TNC_DSV, ";
            sSQL = sSQL + "ANS_AON_DSV, ";
            sSQL = sSQL + "ANS_ENM_DSV, ";
            sSQL = sSQL + "ANS_EEE_DSV, ";
            sSQL = sSQL + "ANS_KKK_DSV, ";
            sSQL = sSQL + "ANS_BBB_DSV, ";
            sSQL = sSQL + "ANS_PUE_DSV, ";
            sSQL = sSQL + "ANS_OLE_DSV, ";
            sSQL = sSQL + "ANS_TRQ_DSV, ";
            sSQL = sSQL + "ANS_ERT_DSV, ";
            sSQL = sSQL + "ANS_RT3_DSV, ";
            sSQL = sSQL + "ANS_RT5_DSV, ";
            sSQL = sSQL + "ANS_PES_DSV, ";
            sSQL = sSQL + "ANS_DMO_DSV, ";
            sSQL = sSQL + "ANS_DND_DSV, ";
            sSQL = sSQL + "ANS_OBS, ";
            sSQL = sSQL + "ANS_STS, ";
            sSQL = sSQL + "ANS_USR_INC_ID, ";
            sSQL = sSQL + "ANS_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ANS_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + ANS_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sSQL = sSQL + "'" + ANS_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sSQL = sSQL + "'" + ANS_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT_TST.ToString()))
            {
                sSQL = sSQL + ANS_LOT_TST + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + ANS_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_APS_ID.ToString()))
            {
                sSQL = sSQL + ANS_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_MAQ_ID.ToString()))
            {
                sSQL = sSQL + ANS_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_ID.ToString()))
            {
                sSQL = sSQL + ANS_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_VRD))
            {
                sSQL = sSQL + "'" + ANS_VRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_001.ToString()))
            {
                sSQL = sSQL + ANS_POS_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_001.ToString()))
            {
                sSQL = sSQL + ANS_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_001.ToString()))
            {
                sSQL = sSQL + ANS_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_001.ToString()))
            {
                sSQL = sSQL + ANS_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_001.ToString()))
            {
                sSQL = sSQL + ANS_ENM_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_001.ToString()))
            {
                sSQL = sSQL + ANS_EEE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_001.ToString()))
            {
                sSQL = sSQL + ANS_KKK_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_001.ToString()))
            {
                sSQL = sSQL + ANS_BBB_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_001.ToString()))
            {
                sSQL = sSQL + ANS_PUE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_001.ToString()))
            {
                sSQL = sSQL + ANS_OLE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_001.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_001.ToString()))
            {
                sSQL = sSQL + ANS_ERT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_001.ToString()))
            {
                sSQL = sSQL + ANS_RT3_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_001.ToString()))
            {
                sSQL = sSQL + ANS_RT5_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_001.ToString()))
            {
                sSQL = sSQL + ANS_PES_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_001.ToString()))
            {
                sSQL = sSQL + ANS_DMO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_001.ToString()))
            {
                sSQL = sSQL + ANS_DND_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_002.ToString()))
            {
                sSQL = sSQL + ANS_POS_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_002.ToString()))
            {
                sSQL = sSQL + ANS_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_002.ToString()))
            {
                sSQL = sSQL + ANS_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_002.ToString()))
            {
                sSQL = sSQL + ANS_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_002.ToString()))
            {
                sSQL = sSQL + ANS_ENM_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_002.ToString()))
            {
                sSQL = sSQL + ANS_EEE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_002.ToString()))
            {
                sSQL = sSQL + ANS_KKK_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_002.ToString()))
            {
                sSQL = sSQL + ANS_BBB_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_002.ToString()))
            {
                sSQL = sSQL + ANS_PUE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_002.ToString()))
            {
                sSQL = sSQL + ANS_OLE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_002.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_002.ToString()))
            {
                sSQL = sSQL + ANS_ERT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_002.ToString()))
            {
                sSQL = sSQL + ANS_RT3_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_002.ToString()))
            {
                sSQL = sSQL + ANS_RT5_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_002.ToString()))
            {
                sSQL = sSQL + ANS_PES_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_002.ToString()))
            {
                sSQL = sSQL + ANS_DMO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_002.ToString()))
            {
                sSQL = sSQL + ANS_DND_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_003.ToString()))
            {
                sSQL = sSQL + ANS_POS_003 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_003.ToString()))
            {
                sSQL = sSQL + ANS_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_003.ToString()))
            {
                sSQL = sSQL + ANS_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_003.ToString()))
            {
                sSQL = sSQL + ANS_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_003.ToString()))
            {
                sSQL = sSQL + ANS_ENM_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_003.ToString()))
            {
                sSQL = sSQL + ANS_EEE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_003.ToString()))
            {
                sSQL = sSQL + ANS_KKK_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_003.ToString()))
            {
                sSQL = sSQL + ANS_BBB_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_003.ToString()))
            {
                sSQL = sSQL + ANS_PUE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_003.ToString()))
            {
                sSQL = sSQL + ANS_OLE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_003.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_003.ToString()))
            {
                sSQL = sSQL + ANS_ERT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_003.ToString()))
            {
                sSQL = sSQL + ANS_RT3_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_003.ToString()))
            {
                sSQL = sSQL + ANS_RT5_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_003.ToString()))
            {
                sSQL = sSQL + ANS_PES_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_003.ToString()))
            {
                sSQL = sSQL + ANS_DMO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_003.ToString()))
            {
                sSQL = sSQL + ANS_DND_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_004.ToString()))
            {
                sSQL = sSQL + ANS_POS_004 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_004.ToString()))
            {
                sSQL = sSQL + ANS_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_004.ToString()))
            {
                sSQL = sSQL + ANS_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_004.ToString()))
            {
                sSQL = sSQL + ANS_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_004.ToString()))
            {
                sSQL = sSQL + ANS_ENM_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_004.ToString()))
            {
                sSQL = sSQL + ANS_EEE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_004.ToString()))
            {
                sSQL = sSQL + ANS_KKK_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_004.ToString()))
            {
                sSQL = sSQL + ANS_BBB_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_004.ToString()))
            {
                sSQL = sSQL + ANS_PUE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_004.ToString()))
            {
                sSQL = sSQL + ANS_OLE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_004.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_004.ToString()))
            {
                sSQL = sSQL + ANS_ERT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_004.ToString()))
            {
                sSQL = sSQL + ANS_RT3_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_004.ToString()))
            {
                sSQL = sSQL + ANS_RT5_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_004.ToString()))
            {
                sSQL = sSQL + ANS_PES_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_004.ToString()))
            {
                sSQL = sSQL + ANS_DMO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_004.ToString()))
            {
                sSQL = sSQL + ANS_DND_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_005.ToString()))
            {
                sSQL = sSQL + ANS_POS_005 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_005.ToString()))
            {
                sSQL = sSQL + ANS_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_005.ToString()))
            {
                sSQL = sSQL + ANS_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_005.ToString()))
            {
                sSQL = sSQL + ANS_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_005.ToString()))
            {
                sSQL = sSQL + ANS_ENM_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_005.ToString()))
            {
                sSQL = sSQL + ANS_EEE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_005.ToString()))
            {
                sSQL = sSQL + ANS_KKK_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_005.ToString()))
            {
                sSQL = sSQL + ANS_BBB_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_005.ToString()))
            {
                sSQL = sSQL + ANS_PUE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_005.ToString()))
            {
                sSQL = sSQL + ANS_OLE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_005.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_005.ToString()))
            {
                sSQL = sSQL + ANS_ERT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_005.ToString()))
            {
                sSQL = sSQL + ANS_RT3_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_005.ToString()))
            {
                sSQL = sSQL + ANS_RT5_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_005.ToString()))
            {
                sSQL = sSQL + ANS_PES_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_005.ToString()))
            {
                sSQL = sSQL + ANS_DMO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_005.ToString()))
            {
                sSQL = sSQL + ANS_DND_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_006.ToString()))
            {
                sSQL = sSQL + ANS_POS_006 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_006.ToString()))
            {
                sSQL = sSQL + ANS_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_006.ToString()))
            {
                sSQL = sSQL + ANS_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_006.ToString()))
            {
                sSQL = sSQL + ANS_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_006.ToString()))
            {
                sSQL = sSQL + ANS_ENM_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_006.ToString()))
            {
                sSQL = sSQL + ANS_EEE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_006.ToString()))
            {
                sSQL = sSQL + ANS_KKK_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_006.ToString()))
            {
                sSQL = sSQL + ANS_BBB_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_006.ToString()))
            {
                sSQL = sSQL + ANS_PUE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_006.ToString()))
            {
                sSQL = sSQL + ANS_OLE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_006.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_006.ToString()))
            {
                sSQL = sSQL + ANS_ERT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_006.ToString()))
            {
                sSQL = sSQL + ANS_RT3_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_006.ToString()))
            {
                sSQL = sSQL + ANS_RT5_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_006.ToString()))
            {
                sSQL = sSQL + ANS_PES_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_006.ToString()))
            {
                sSQL = sSQL + ANS_DMO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_006.ToString()))
            {
                sSQL = sSQL + ANS_DND_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_MED.ToString()))
            {
                sSQL = sSQL + ANS_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_MED.ToString()))
            {
                sSQL = sSQL + ANS_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_MED.ToString()))
            {
                sSQL = sSQL + ANS_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_MED.ToString()))
            {
                sSQL = sSQL + ANS_ENM_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_MED.ToString()))
            {
                sSQL = sSQL + ANS_EEE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_MED.ToString()))
            {
                sSQL = sSQL + ANS_KKK_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_MED.ToString()))
            {
                sSQL = sSQL + ANS_BBB_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_MED.ToString()))
            {
                sSQL = sSQL + ANS_PUE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_MED.ToString()))
            {
                sSQL = sSQL + ANS_OLE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_MED.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_MED.ToString()))
            {
                sSQL = sSQL + ANS_ERT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_MED.ToString()))
            {
                sSQL = sSQL + ANS_RT3_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_MED.ToString()))
            {
                sSQL = sSQL + ANS_RT5_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_MED.ToString()))
            {
                sSQL = sSQL + ANS_PES_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_MED.ToString()))
            {
                sSQL = sSQL + ANS_DMO_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_MED.ToString()))
            {
                sSQL = sSQL + ANS_DND_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_DSV.ToString()))
            {
                sSQL = sSQL + ANS_TIT_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_DSV.ToString()))
            {
                sSQL = sSQL + ANS_TNC_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_DSV.ToString()))
            {
                sSQL = sSQL + ANS_AON_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_DSV.ToString()))
            {
                sSQL = sSQL + ANS_ENM_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_DSV.ToString()))
            {
                sSQL = sSQL + ANS_EEE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_DSV.ToString()))
            {
                sSQL = sSQL + ANS_KKK_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_DSV.ToString()))
            {
                sSQL = sSQL + ANS_BBB_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_DSV.ToString()))
            {
                sSQL = sSQL + ANS_PUE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_DSV.ToString()))
            {
                sSQL = sSQL + ANS_OLE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_DSV.ToString()))
            {
                sSQL = sSQL + ANS_TRQ_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_DSV.ToString()))
            {
                sSQL = sSQL + ANS_ERT_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_DSV.ToString()))
            {
                sSQL = sSQL + ANS_RT3_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_DSV.ToString()))
            {
                sSQL = sSQL + ANS_RT5_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_DSV.ToString()))
            {
                sSQL = sSQL + ANS_PES_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_DSV.ToString()))
            {
                sSQL = sSQL + ANS_DMO_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_DSV.ToString()))
            {
                sSQL = sSQL + ANS_DND_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OBS))
            {
                sSQL = sSQL + "'" + ANS_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_STS.ToString()))
            {
                sSQL = sSQL + ANS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ANS_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ANS ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ANS_DAT.ToString()))
            {
                sSQL = sSQL + "ANS_DAT = Convert(datetime, '" + ANS_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "ANS_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sSQL = sSQL + "ANS_LOT = '" + ANS_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANS_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sSQL = sSQL + "ANS_TIP_DES = '" + ANS_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIP_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT_TST.ToString()))
            {
                sSQL = sSQL + "ANS_LOT_TST = " + ANS_LOT_TST + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_LOT_TST = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_POY_ID = " + ANS_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_APS_ID.ToString()))
            {
                sSQL = sSQL + "ANS_APS_ID = " + ANS_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_APS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_MAQ_ID.ToString()))
            {
                sSQL = sSQL + "ANS_MAQ_ID = " + ANS_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_MAQ_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_ID.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_ID = " + ANS_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_VRD))
            {
                sSQL = sSQL + "ANS_VRD = '" + ANS_VRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANS_VRD = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_001.ToString()))
            {
                sSQL = sSQL + "ANS_POS_001 = " + ANS_POS_001 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_001.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_001 = " + ANS_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_001.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_001 = " + ANS_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_001.ToString()))
            {
                sSQL = sSQL + "ANS_AON_001 = " + ANS_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_001.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_001 = " + ANS_ENM_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_001.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_001 = " + ANS_EEE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_001.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_001 = " + ANS_KKK_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_001.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_001 = " + ANS_BBB_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_001.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_001 = " + ANS_PUE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_001.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_001 = " + ANS_OLE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_001.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_001 = " + ANS_TRQ_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_001.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_001 = " + ANS_ERT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_001.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_001 = " + ANS_RT3_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_001.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_001 = " + ANS_RT5_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_001.ToString()))
            {
                sSQL = sSQL + "ANS_PES_001 = " + ANS_PES_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_001.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_001 = " + ANS_DMO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_001.ToString()))
            {
                sSQL = sSQL + "ANS_DND_001 = " + ANS_DND_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_002.ToString()))
            {
                sSQL = sSQL + "ANS_POS_002 = " + ANS_POS_002 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_002.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_002 = " + ANS_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_002.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_002 = " + ANS_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_002.ToString()))
            {
                sSQL = sSQL + "ANS_AON_002 = " + ANS_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_002.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_002 = " + ANS_ENM_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_002.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_002 = " + ANS_EEE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_002.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_002 = " + ANS_KKK_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_002.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_002 = " + ANS_BBB_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_002.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_002 = " + ANS_PUE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_002.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_002 = " + ANS_OLE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_002.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_002 = " + ANS_TRQ_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_002.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_002 = " + ANS_ERT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_002.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_002 = " + ANS_RT3_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_002.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_002 = " + ANS_RT5_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_002.ToString()))
            {
                sSQL = sSQL + "ANS_PES_002 = " + ANS_PES_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_002.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_002 = " + ANS_DMO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_002.ToString()))
            {
                sSQL = sSQL + "ANS_DND_002 = " + ANS_DND_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_003.ToString()))
            {
                sSQL = sSQL + "ANS_POS_003 = " + ANS_POS_003 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_003.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_003 = " + ANS_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_003.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_003 = " + ANS_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_003.ToString()))
            {
                sSQL = sSQL + "ANS_AON_003 = " + ANS_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_003.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_003 = " + ANS_ENM_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_003.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_003 = " + ANS_EEE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_003.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_003 = " + ANS_KKK_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_003.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_003 = " + ANS_BBB_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_003.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_003 = " + ANS_PUE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_003.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_003 = " + ANS_OLE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_003.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_003 = " + ANS_TRQ_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_003.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_003 = " + ANS_ERT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_003.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_003 = " + ANS_RT3_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_003.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_003 = " + ANS_RT5_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_003.ToString()))
            {
                sSQL = sSQL + "ANS_PES_003 = " + ANS_PES_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_003.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_003 = " + ANS_DMO_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_003.ToString()))
            {
                sSQL = sSQL + "ANS_DND_003 = " + ANS_DND_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_004.ToString()))
            {
                sSQL = sSQL + "ANS_POS_004 = " + ANS_POS_004 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_004.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_004 = " + ANS_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_004.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_004 = " + ANS_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_004.ToString()))
            {
                sSQL = sSQL + "ANS_AON_004 = " + ANS_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_004.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_004 = " + ANS_ENM_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_004.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_004 = " + ANS_EEE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_004.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_004 = " + ANS_KKK_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_004.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_004 = " + ANS_BBB_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_004.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_004 = " + ANS_PUE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_004.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_004 = " + ANS_OLE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_004.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_004 = " + ANS_TRQ_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_004.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_004 = " + ANS_ERT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_004.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_004 = " + ANS_RT3_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_004.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_004 = " + ANS_RT5_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_004.ToString()))
            {
                sSQL = sSQL + "ANS_PES_004 = " + ANS_PES_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_004.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_004 = " + ANS_DMO_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_004.ToString()))
            {
                sSQL = sSQL + "ANS_DND_004 = " + ANS_DND_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_005.ToString()))
            {
                sSQL = sSQL + "ANS_POS_005 = " + ANS_POS_005 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_005.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_005 = " + ANS_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_005.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_005 = " + ANS_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_005.ToString()))
            {
                sSQL = sSQL + "ANS_AON_005 = " + ANS_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_005.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_005 = " + ANS_ENM_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_005.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_005 = " + ANS_EEE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_005.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_005 = " + ANS_KKK_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_005.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_005 = " + ANS_BBB_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_005.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_005 = " + ANS_PUE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_005.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_005 = " + ANS_OLE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_005.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_005 = " + ANS_TRQ_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_005.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_005 = " + ANS_ERT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_005.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_005 = " + ANS_RT3_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_005.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_005 = " + ANS_RT5_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_005.ToString()))
            {
                sSQL = sSQL + "ANS_PES_005 = " + ANS_PES_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_005.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_005 = " + ANS_DMO_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_005.ToString()))
            {
                sSQL = sSQL + "ANS_DND_005 = " + ANS_DND_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_POS_006.ToString()))
            {
                sSQL = sSQL + "ANS_POS_006 = " + ANS_POS_006 + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_POS_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_006.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_006 = " + ANS_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_006.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_006 = " + ANS_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_006.ToString()))
            {
                sSQL = sSQL + "ANS_AON_006 = " + ANS_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_006.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_006 = " + ANS_ENM_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_006.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_006 = " + ANS_EEE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_006.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_006 = " + ANS_KKK_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_006.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_006 = " + ANS_BBB_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_006.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_006 = " + ANS_PUE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_006.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_006 = " + ANS_OLE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_006.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_006 = " + ANS_TRQ_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_006.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_006 = " + ANS_ERT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_006.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_006 = " + ANS_RT3_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_006.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_006 = " + ANS_RT5_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_006.ToString()))
            {
                sSQL = sSQL + "ANS_PES_006 = " + ANS_PES_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_006.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_006 = " + ANS_DMO_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_006.ToString()))
            {
                sSQL = sSQL + "ANS_DND_006 = " + ANS_DND_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_MED.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_MED = " + ANS_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_MED.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_MED = " + ANS_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_MED.ToString()))
            {
                sSQL = sSQL + "ANS_AON_MED = " + ANS_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_MED.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_MED = " + ANS_ENM_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_MED.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_MED = " + ANS_EEE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_MED.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_MED = " + ANS_KKK_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_MED.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_MED = " + ANS_BBB_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_MED.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_MED = " + ANS_PUE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_MED.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_MED = " + ANS_OLE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_MED.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_MED = " + ANS_TRQ_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_MED.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_MED = " + ANS_ERT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_MED.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_MED = " + ANS_RT3_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_MED.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_MED = " + ANS_RT5_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_MED.ToString()))
            {
                sSQL = sSQL + "ANS_PES_MED = " + ANS_PES_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_MED.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_MED = " + ANS_DMO_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_MED.ToString()))
            {
                sSQL = sSQL + "ANS_DND_MED = " + ANS_DND_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIT_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_TIT_DSV = " + ANS_TIT_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIT_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TNC_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_TNC_DSV = " + ANS_TNC_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TNC_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_AON_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_AON_DSV = " + ANS_AON_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_AON_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ENM_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_ENM_DSV = " + ANS_ENM_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ENM_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_EEE_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_EEE_DSV = " + ANS_EEE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_EEE_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_KKK_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_KKK_DSV = " + ANS_KKK_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_KKK_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_BBB_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_BBB_DSV = " + ANS_BBB_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_BBB_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PUE_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_PUE_DSV = " + ANS_PUE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PUE_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OLE_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_OLE_DSV = " + ANS_OLE_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_OLE_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TRQ_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_TRQ_DSV = " + ANS_TRQ_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TRQ_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_ERT_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_ERT_DSV = " + ANS_ERT_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_ERT_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT3_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_RT3_DSV = " + ANS_RT3_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT3_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_RT5_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_RT5_DSV = " + ANS_RT5_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_RT5_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_PES_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_PES_DSV = " + ANS_PES_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_PES_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DMO_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_DMO_DSV = " + ANS_DMO_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DMO_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_DND_DSV.ToString()))
            {
                sSQL = sSQL + "ANS_DND_DSV = " + ANS_DND_DSV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_DND_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_OBS))
            {
                sSQL = sSQL + "ANS_OBS = '" + ANS_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANS_OBS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_STS.ToString()))
            {
                sSQL = sSQL + "ANS_STS = " + ANS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ANS_USR_ALT_ID = " + ANS_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ANS_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2); 
            sSQL = sSQL + " WHERE ANS_ID = " + ANS_ID;

            SQL = sSQL; 

            return dbConn.ExecutarInserir(sSQL);

        }

        public string AtualizaMediaDesvio()
        {
            string sSQL = "UPDATE ANS";
            sSQL = sSQL + " SET ";
            sSQL = sSQL + " ANS_TIT_MED =  dbo.MEDIA  (ANS_TIT_001, ANS_TIT_002, ANS_TIT_003, ANS_TIT_004, ANS_TIT_005, ANS_TIT_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_TIT_DSV =  dbo.DESVIO (ANS_TIT_001, ANS_TIT_002, ANS_TIT_003, ANS_TIT_004, ANS_TIT_005, ANS_TIT_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_TNC_MED =  dbo.MEDIA  (ANS_TNC_001, ANS_TNC_002, ANS_TNC_003, ANS_TNC_004, ANS_TNC_005, ANS_TNC_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_TNC_DSV =  dbo.DESVIO (ANS_TNC_001, ANS_TNC_002, ANS_TNC_003, ANS_TNC_004, ANS_TNC_005, ANS_TNC_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_AON_MED =  dbo.MEDIA  (ANS_AON_001, ANS_AON_002, ANS_AON_003, ANS_AON_004, ANS_AON_005, ANS_AON_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_AON_DSV =  dbo.DESVIO (ANS_AON_001, ANS_AON_002, ANS_AON_003, ANS_AON_004, ANS_AON_005, ANS_AON_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_ENM_MED =  dbo.MEDIA  (ANS_ENM_001, ANS_ENM_002, ANS_ENM_003, ANS_ENM_004, ANS_ENM_005, ANS_ENM_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_ENM_DSV =  dbo.DESVIO (ANS_ENM_001, ANS_ENM_002, ANS_ENM_003, ANS_ENM_004, ANS_ENM_005, ANS_ENM_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_EEE_MED =  dbo.MEDIA  (ANS_EEE_001, ANS_EEE_002, ANS_EEE_003, ANS_EEE_004, ANS_EEE_005, ANS_EEE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_EEE_DSV =  dbo.DESVIO (ANS_EEE_001, ANS_EEE_002, ANS_EEE_003, ANS_EEE_004, ANS_EEE_005, ANS_EEE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_KKK_MED =  dbo.MEDIA  (ANS_KKK_001, ANS_KKK_002, ANS_KKK_003, ANS_KKK_004, ANS_KKK_005, ANS_KKK_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_KKK_DSV =  dbo.DESVIO (ANS_KKK_001, ANS_KKK_002, ANS_KKK_003, ANS_KKK_004, ANS_KKK_005, ANS_KKK_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_BBB_MED =  dbo.MEDIA  (ANS_BBB_001, ANS_BBB_002, ANS_BBB_003, ANS_BBB_004, ANS_BBB_005, ANS_BBB_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_BBB_DSV =  dbo.DESVIO (ANS_BBB_001, ANS_BBB_002, ANS_BBB_003, ANS_BBB_004, ANS_BBB_005, ANS_BBB_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_PUE_MED =  dbo.MEDIA  (ANS_PUE_001, ANS_PUE_002, ANS_PUE_003, ANS_PUE_004, ANS_PUE_005, ANS_PUE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_PUE_DSV =  dbo.DESVIO (ANS_PUE_001, ANS_PUE_002, ANS_PUE_003, ANS_PUE_004, ANS_PUE_005, ANS_PUE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_OLE_MED =  dbo.MEDIA  (ANS_OLE_001, ANS_OLE_002, ANS_OLE_003, ANS_OLE_004, ANS_OLE_005, ANS_OLE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_OLE_DSV =  dbo.DESVIO (ANS_OLE_001, ANS_OLE_002, ANS_OLE_003, ANS_OLE_004, ANS_OLE_005, ANS_OLE_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_TRQ_MED =  dbo.MEDIA  (ANS_TRQ_001, ANS_TRQ_002, ANS_TRQ_003, ANS_TRQ_004, ANS_TRQ_005, ANS_TRQ_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_TRQ_DSV =  dbo.DESVIO (ANS_TRQ_001, ANS_TRQ_002, ANS_TRQ_003, ANS_TRQ_004, ANS_TRQ_005, ANS_TRQ_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_ERT_MED =  dbo.MEDIA  (ANS_ERT_001, ANS_ERT_002, ANS_ERT_003, ANS_ERT_004, ANS_ERT_005, ANS_ERT_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_ERT_DSV =  dbo.DESVIO (ANS_ERT_001, ANS_ERT_002, ANS_ERT_003, ANS_ERT_004, ANS_ERT_005, ANS_ERT_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_RT3_MED =  dbo.MEDIA  (ANS_RT3_001, ANS_RT3_002, ANS_RT3_003, ANS_RT3_004, ANS_RT3_005, ANS_RT3_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_RT3_DSV =  dbo.DESVIO (ANS_RT3_001, ANS_RT3_002, ANS_RT3_003, ANS_RT3_004, ANS_RT3_005, ANS_RT3_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_RT5_MED =  dbo.MEDIA  (ANS_RT5_001, ANS_RT5_002, ANS_RT5_003, ANS_RT5_004, ANS_RT5_005, ANS_RT5_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_RT5_DSV =  dbo.DESVIO (ANS_RT5_001, ANS_RT5_002, ANS_RT5_003, ANS_RT5_004, ANS_RT5_005, ANS_RT5_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_PES_MED =  dbo.MEDIA  (ANS_PES_001, ANS_PES_002, ANS_PES_003, ANS_PES_004, ANS_PES_005, ANS_PES_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_PES_DSV =  dbo.DESVIO (ANS_PES_001, ANS_PES_002, ANS_PES_003, ANS_PES_004, ANS_PES_005, ANS_PES_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_DMO_MED =  dbo.MEDIA  (ANS_DMO_001, ANS_DMO_002, ANS_DMO_003, ANS_DMO_004, ANS_DMO_005, ANS_DMO_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_DMO_DSV =  dbo.DESVIO (ANS_DMO_001, ANS_DMO_002, ANS_DMO_003, ANS_DMO_004, ANS_DMO_005, ANS_DMO_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_DND_MED =  dbo.MEDIA  (ANS_DND_001, ANS_DND_002, ANS_DND_003, ANS_DND_004, ANS_DND_005, ANS_DND_006, NULL, NULL, NULL, NULL), ";
            sSQL = sSQL + " ANS_DND_DSV =  dbo.DESVIO (ANS_DND_001, ANS_DND_002, ANS_DND_003, ANS_DND_004, ANS_DND_005, ANS_DND_006, NULL, NULL, NULL, NULL) ";
            sSQL = sSQL + " WHERE ANS_ID = " + ANS_ID;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ANS";
            sSQL = sSQL + " WHERE ANS_ID = " + ANS_ID;

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
            sSQL = sSQL + " FROM ANS";
            sSQL = sSQL + " INNER JOIN TIT_POY ON TIT_POY_ID = ANS_TIT_POY_ID";
            sSQL = sSQL + " INNER JOIN APS ON APS_ID = ANS_APS_ID";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = ANS_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = MAQ_MAQ_TIP_ID";
            sSQL = sSQL + " INNER JOIN ERT ON ERT_ID = ANS_ERT_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ID)))
            {
                sCond = sCond + " ANS_ID = " + ANS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT)))
            {
                sCond = sCond + " ANS_DAT BETWEEN Convert(datetime, '" + ANS_DAT + "',103) AND Convert(datetime, '" + ANS_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_INI)))
            {
                sCond = sCond + " ANS_DAT >= Convert(datetime, '" + ANS_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_FIM)))
            {
                sCond = sCond + " ANS_DAT <= Convert(datetime, '" + ANS_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sCond = sCond + " ANS_LOT = '" + ANS_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sCond = sCond + " ANS_TIP_DES = '" + ANS_TIP_DES + "' AND ";
            }
            if (!String.IsNullOrEmpty(LST_ANS_TIP))
            {
                sCond = sCond + " ANS_TIP_DES IN (" + LST_ANS_TIP + ") AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_POY_ID)))
            {
                sCond = sCond + " ANS_TIT_POY_ID = " + ANS_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_APS_ID)))
            {
                sCond = sCond + " ANS_APS_ID = " + ANS_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_MAQ_ID)))
            {
                sCond = sCond + " ANS_MAQ_ID = " + ANS_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_TIP_ID)))
            {
                sCond = sCond + " ANS_MAQ_ID IN (SELECT MAQ_ID FROM MAQ WHERE MAQ_STS = 1 AND MAQ_MAQ_TIP_ID = " + MAQ_TIP_ID + ") AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_ID)))
            {
                sCond = sCond + " ANS_ERT_ID = " + ANS_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_STS)))
            {
                sCond = sCond + " ANS_STS = " + ANS_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_LOT_TST)))
            {
                sCond = sCond + " ANS_LOT_TST = " + ANS_LOT_TST + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ANS_DAT, ANS_LOT, ANS_TIT_POY_ID, ANS_APS_ID, ANS_MAQ_ID, ANS_ERT_ID, ANS_VRD";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarMedia()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = sSQL + " SELECT COUNT(*) NUM,";
            sSQL = sSQL + " AVG(ANS_TIT_MED) TIT_MED,";
            sSQL = sSQL + " AVG(ANS_TNC_MED) TNC_MED,";
            sSQL = sSQL + " AVG(ANS_AON_MED) AON_MED,";
            sSQL = sSQL + " AVG(ANS_ENM_MED) ENM_MED,";
            sSQL = sSQL + " AVG(ANS_EEE_MED) EEE_MED,";
            sSQL = sSQL + " AVG(ANS_KKK_MED) KKK_MED,";
            sSQL = sSQL + " AVG(ANS_BBB_MED) BBB_MED,";
            sSQL = sSQL + " AVG(ANS_PUE_MED) PUE_MED,";
            sSQL = sSQL + " AVG(ANS_OLE_MED) OLE_MED,";
            sSQL = sSQL + " AVG(ANS_TRQ_MED) TRQ_MED,";
            sSQL = sSQL + " AVG(ANS_ERT_MED) ERT_MED,";
            sSQL = sSQL + " AVG(ANS_RT3_MED) RT3_MED,";
            sSQL = sSQL + " AVG(ANS_RT5_MED) RT5_MED,";
            sSQL = sSQL + " AVG(ANS_PES_MED) PES_MED,";
            sSQL = sSQL + " AVG(ANS_DMO_MED) DMO_MED,";
            sSQL = sSQL + " AVG(ANS_DND_MED) DND_MED,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TIT_MED),0) TIT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TNC_MED),0) TNC_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_AON_MED),0) AON_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ENM_MED),0) ENM_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_EEE_MED),0) EEE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_KKK_MED),0) KKK_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_BBB_MED),0) BBB_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PUE_MED),0) PUE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_OLE_MED),0) OLE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TRQ_MED),0) TRQ_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ERT_MED),0) ERT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT3_MED),0) RT3_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT5_MED),0) RT5_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PES_MED),0) PES_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DMO_MED),0) DMO_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DND_MED),0) DND_MED_DSV,";
            sSQL = sSQL + " AVG(ANS_TIT_DSV) TIT_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_TNC_DSV) TNC_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_AON_DSV) AON_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_ENM_DSV) ENM_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_EEE_DSV) EEE_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_KKK_DSV) KKK_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_BBB_DSV) BBB_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_PUE_DSV) PUE_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_OLE_DSV) OLE_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_TRQ_DSV) TRQ_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_ERT_DSV) ERT_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_RT3_DSV) RT3_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_RT5_DSV) RT5_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_PES_DSV) PES_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_DMO_DSV) DMO_DSV_AVG,";
            sSQL = sSQL + " AVG(ANS_DND_DSV) DND_DSV_AVG,";
            sSQL = sSQL + " MIN(ANS_TIT_MED) TIT_MIN,";
            sSQL = sSQL + " MIN(ANS_TNC_MED) TNC_MIN,";
            sSQL = sSQL + " MIN(ANS_AON_MED) AON_MIN,";
            sSQL = sSQL + " MIN(ANS_ENM_MED) ENM_MIN,";
            sSQL = sSQL + " MIN(ANS_EEE_MED) EEE_MIN,";
            sSQL = sSQL + " MIN(ANS_KKK_MED) KKK_MIN,";
            sSQL = sSQL + " MIN(ANS_BBB_MED) BBB_MIN,";
            sSQL = sSQL + " MIN(ANS_PUE_MED) PUE_MIN,";
            sSQL = sSQL + " MIN(ANS_OLE_MED) OLE_MIN,";
            sSQL = sSQL + " MIN(ANS_TRQ_MED) TRQ_MIN,";
            sSQL = sSQL + " MIN(ANS_ERT_MED) ERT_MIN,";
            sSQL = sSQL + " MIN(ANS_RT3_MED) RT3_MIN,";
            sSQL = sSQL + " MIN(ANS_RT5_MED) RT5_MIN,";
            sSQL = sSQL + " MIN(ANS_PES_MED) PES_MIN,";
            sSQL = sSQL + " MIN(ANS_DMO_MED) DMO_MIN,";
            sSQL = sSQL + " MIN(ANS_DND_MED) DND_MIN,";
            sSQL = sSQL + " MAX(ANS_TIT_MED) TIT_MAX,";
            sSQL = sSQL + " MAX(ANS_TNC_MED) TNC_MAX,";
            sSQL = sSQL + " MAX(ANS_AON_MED) AON_MAX,";
            sSQL = sSQL + " MAX(ANS_ENM_MED) ENM_MAX,";
            sSQL = sSQL + " MAX(ANS_EEE_MED) EEE_MAX,";
            sSQL = sSQL + " MAX(ANS_KKK_MED) KKK_MAX,";
            sSQL = sSQL + " MAX(ANS_BBB_MED) BBB_MAX,";
            sSQL = sSQL + " MAX(ANS_PUE_MED) PUE_MAX,";
            sSQL = sSQL + " MAX(ANS_OLE_MED) OLE_MAX,";
            sSQL = sSQL + " MAX(ANS_TRQ_MED) TRQ_MAX,";
            sSQL = sSQL + " MAX(ANS_ERT_MED) ERT_MAX,";
            sSQL = sSQL + " MAX(ANS_RT3_MED) RT3_MAX,";
            sSQL = sSQL + " MAX(ANS_RT5_MED) RT5_MAX,";
            sSQL = sSQL + " MAX(ANS_PES_MED) PES_MAX,";
            sSQL = sSQL + " MAX(ANS_DMO_MED) DMO_MAX,";
            sSQL = sSQL + " MAX(ANS_DND_MED) DND_MAX,";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TIT_001, ANS_TIT_002, ANS_TIT_003, ANS_TIT_004, ANS_TIT_005, ANS_TIT_006, NULL, NULL, NULL, NULL)),0) TIT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TNC_001, ANS_TNC_002, ANS_TNC_003, ANS_TNC_004, ANS_TNC_005, ANS_TNC_006, NULL, NULL, NULL, NULL)),0) TNC_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_AON_001, ANS_AON_002, ANS_AON_003, ANS_AON_004, ANS_AON_005, ANS_AON_006, NULL, NULL, NULL, NULL)),0) AON_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ENM_001, ANS_ENM_002, ANS_ENM_003, ANS_ENM_004, ANS_ENM_005, ANS_ENM_006, NULL, NULL, NULL, NULL)),0) ENM_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_EEE_001, ANS_EEE_002, ANS_EEE_003, ANS_EEE_004, ANS_EEE_005, ANS_EEE_006, NULL, NULL, NULL, NULL)),0) EEE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_KKK_001, ANS_KKK_002, ANS_KKK_003, ANS_KKK_004, ANS_KKK_005, ANS_KKK_006, NULL, NULL, NULL, NULL)),0) KKK_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_BBB_001, ANS_BBB_002, ANS_BBB_003, ANS_BBB_004, ANS_BBB_005, ANS_BBB_006, NULL, NULL, NULL, NULL)),0) BBB_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PUE_001, ANS_PUE_002, ANS_PUE_003, ANS_PUE_004, ANS_PUE_005, ANS_PUE_006, NULL, NULL, NULL, NULL)),0) PUE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_OLE_001, ANS_OLE_002, ANS_OLE_003, ANS_OLE_004, ANS_OLE_005, ANS_OLE_006, NULL, NULL, NULL, NULL)),0) OLE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TRQ_001, ANS_TRQ_002, ANS_TRQ_003, ANS_TRQ_004, ANS_TRQ_005, ANS_TRQ_006, NULL, NULL, NULL, NULL)),0) TRQ_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ERT_001, ANS_ERT_002, ANS_ERT_003, ANS_ERT_004, ANS_ERT_005, ANS_ERT_006, NULL, NULL, NULL, NULL)),0) ERT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT3_001, ANS_RT3_002, ANS_RT3_003, ANS_RT3_004, ANS_RT3_005, ANS_RT3_006, NULL, NULL, NULL, NULL)),0) RT3_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT5_001, ANS_RT5_002, ANS_RT5_003, ANS_RT5_004, ANS_RT5_005, ANS_RT5_006, NULL, NULL, NULL, NULL)),0) RT5_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PES_001, ANS_PES_002, ANS_PES_003, ANS_PES_004, ANS_PES_005, ANS_PES_006, NULL, NULL, NULL, NULL)),0) PES_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DMO_001, ANS_DMO_002, ANS_DMO_003, ANS_DMO_004, ANS_DMO_005, ANS_DMO_006, NULL, NULL, NULL, NULL)),0) DMO_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DND_001, ANS_DND_002, ANS_DND_003, ANS_DND_004, ANS_DND_005, ANS_DND_006, NULL, NULL, NULL, NULL)),0) DND_DSV ";
            sSQL = sSQL + " FROM ANS";

            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ID)))
            {
                sCond = sCond + " ANS_ID = " + ANS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT)))
            {
                sCond = sCond + " ANS_DAT BETWEEN Convert(datetime, '" + ANS_DAT + "',103) AND Convert(datetime, '" + ANS_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_INI)))
            {
                sCond = sCond + " ANS_DAT >= Convert(datetime, '" + ANS_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_FIM)))
            {
                sCond = sCond + " ANS_DAT <= Convert(datetime, '" + ANS_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_POY_ID)))
            {
                sCond = sCond + " ANS_TIT_POY_ID = " + ANS_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sCond = sCond + " ANS_LOT = '" + ANS_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sCond = sCond + " ANS_TIP_DES = '" + ANS_TIP_DES + "' AND ";
            }
            if (!String.IsNullOrEmpty(LST_ANS_TIP))
            {
                sCond = sCond + " ANS_TIP_DES IN (" + LST_ANS_TIP + ") AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_APS_ID)))
            {
                sCond = sCond + " ANS_APS_ID = " + ANS_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_MAQ_ID)))
            {
                sCond = sCond + " ANS_MAQ_ID = " + ANS_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_ID)))
            {
                sCond = sCond + " ANS_ERT_ID = " + ANS_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_STS)))
            {
                sCond = sCond + " ANS_STS = " + ANS_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_LOT_TST)))
            {
                sCond = sCond + " ANS_LOT_TST = " + ANS_LOT_TST + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarMediaDetalhe()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = sSQL + " SELECT ANS_DAT, ANS_LOT, ANS_TIT_POY_ID, ANS_APS_ID, ANS_MAQ_ID, ANS_ERT_ID, ANS_VRD, ";
            sSQL = sSQL + " COUNT(*) NUM,";
            sSQL = sSQL + " AVG(ANS_TIT_MED) TIT_MED,";
            sSQL = sSQL + " AVG(ANS_TNC_MED) TNC_MED,";
            sSQL = sSQL + " AVG(ANS_AON_MED) AON_MED,";
            sSQL = sSQL + " AVG(ANS_ENM_MED) ENM_MED,";
            sSQL = sSQL + " AVG(ANS_EEE_MED) EEE_MED,";
            sSQL = sSQL + " AVG(ANS_KKK_MED) KKK_MED,";
            sSQL = sSQL + " AVG(ANS_BBB_MED) BBB_MED,";
            sSQL = sSQL + " AVG(ANS_PUE_MED) PUE_MED,";
            sSQL = sSQL + " AVG(ANS_OLE_MED) OLE_MED,";
            sSQL = sSQL + " AVG(ANS_TRQ_MED) TRQ_MED,";
            sSQL = sSQL + " AVG(ANS_ERT_MED) ERT_MED,";
            sSQL = sSQL + " AVG(ANS_RT3_MED) RT3_MED,";
            sSQL = sSQL + " AVG(ANS_RT5_MED) RT5_MED,";
            sSQL = sSQL + " AVG(ANS_PES_MED) PES_MED,";
            sSQL = sSQL + " AVG(ANS_DMO_MED) DMO_MED,";
            sSQL = sSQL + " AVG(ANS_DND_MED) DND_MED,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TIT_MED),0) TIT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TNC_MED),0) TNC_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_AON_MED),0) AON_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ENM_MED),0) ENM_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_EEE_MED),0) EEE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_KKK_MED),0) KKK_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_BBB_MED),0) BBB_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PUE_MED),0) PUE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_OLE_MED),0) OLE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TRQ_MED),0) TRQ_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ERT_MED),0) ERT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT3_MED),0) RT3_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT5_MED),0) RT5_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PES_MED),0) PES_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DMO_MED),0) DMO_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DND_MED),0) DND_MED_DSV,";
            sSQL = sSQL + " MIN(ANS_TIT_MED) TIT_MIN,";
            sSQL = sSQL + " MIN(ANS_TNC_MED) TNC_MIN,";
            sSQL = sSQL + " MIN(ANS_AON_MED) AON_MIN,";
            sSQL = sSQL + " MIN(ANS_ENM_MED) ENM_MIN,";
            sSQL = sSQL + " MIN(ANS_EEE_MED) EEE_MIN,";
            sSQL = sSQL + " MIN(ANS_KKK_MED) KKK_MIN,";
            sSQL = sSQL + " MIN(ANS_BBB_MED) BBB_MIN,";
            sSQL = sSQL + " MIN(ANS_PUE_MED) PUE_MIN,";
            sSQL = sSQL + " MIN(ANS_OLE_MED) OLE_MIN,";
            sSQL = sSQL + " MIN(ANS_TRQ_MED) TRQ_MIN,";
            sSQL = sSQL + " MIN(ANS_ERT_MED) ERT_MIN,";
            sSQL = sSQL + " MIN(ANS_RT3_MED) RT3_MIN,";
            sSQL = sSQL + " MIN(ANS_RT5_MED) RT5_MIN,";
            sSQL = sSQL + " MIN(ANS_PES_MED) PES_MIN,";
            sSQL = sSQL + " MIN(ANS_DMO_MED) DMO_MIN,";
            sSQL = sSQL + " MIN(ANS_DND_MED) DND_MIN,";
            sSQL = sSQL + " MAX(ANS_TIT_MED) TIT_MAX,";
            sSQL = sSQL + " MAX(ANS_TNC_MED) TNC_MAX,";
            sSQL = sSQL + " MAX(ANS_AON_MED) AON_MAX,";
            sSQL = sSQL + " MAX(ANS_ENM_MED) ENM_MAX,";
            sSQL = sSQL + " MAX(ANS_EEE_MED) EEE_MAX,";
            sSQL = sSQL + " MAX(ANS_KKK_MED) KKK_MAX,";
            sSQL = sSQL + " MAX(ANS_BBB_MED) BBB_MAX,";
            sSQL = sSQL + " MAX(ANS_PUE_MED) PUE_MAX,";
            sSQL = sSQL + " MAX(ANS_OLE_MED) OLE_MAX,";
            sSQL = sSQL + " MAX(ANS_TRQ_MED) TRQ_MAX,";
            sSQL = sSQL + " MAX(ANS_ERT_MED) ERT_MAX,";
            sSQL = sSQL + " MAX(ANS_RT3_MED) RT3_MAX,";
            sSQL = sSQL + " MAX(ANS_RT5_MED) RT5_MAX,";
            sSQL = sSQL + " MAX(ANS_PES_MED) PES_MAX,";
            sSQL = sSQL + " MAX(ANS_DMO_MED) DMO_MAX,";
            sSQL = sSQL + " MAX(ANS_DND_MED) DND_MAX,";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TIT_001, ANS_TIT_002, ANS_TIT_003, ANS_TIT_004, ANS_TIT_005, ANS_TIT_006, NULL, NULL, NULL, NULL)),0) TIT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TNC_001, ANS_TNC_002, ANS_TNC_003, ANS_TNC_004, ANS_TNC_005, ANS_TNC_006, NULL, NULL, NULL, NULL)),0) TNC_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_AON_001, ANS_AON_002, ANS_AON_003, ANS_AON_004, ANS_AON_005, ANS_AON_006, NULL, NULL, NULL, NULL)),0) AON_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ENM_001, ANS_ENM_002, ANS_ENM_003, ANS_ENM_004, ANS_ENM_005, ANS_ENM_006, NULL, NULL, NULL, NULL)),0) ENM_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_EEE_001, ANS_EEE_002, ANS_EEE_003, ANS_EEE_004, ANS_EEE_005, ANS_EEE_006, NULL, NULL, NULL, NULL)),0) EEE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_KKK_001, ANS_KKK_002, ANS_KKK_003, ANS_KKK_004, ANS_KKK_005, ANS_KKK_006, NULL, NULL, NULL, NULL)),0) KKK_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_BBB_001, ANS_BBB_002, ANS_BBB_003, ANS_BBB_004, ANS_BBB_005, ANS_BBB_006, NULL, NULL, NULL, NULL)),0) BBB_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PUE_001, ANS_PUE_002, ANS_PUE_003, ANS_PUE_004, ANS_PUE_005, ANS_PUE_006, NULL, NULL, NULL, NULL)),0) PUE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_OLE_001, ANS_OLE_002, ANS_OLE_003, ANS_OLE_004, ANS_OLE_005, ANS_OLE_006, NULL, NULL, NULL, NULL)),0) OLE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TRQ_001, ANS_TRQ_002, ANS_TRQ_003, ANS_TRQ_004, ANS_TRQ_005, ANS_TRQ_006, NULL, NULL, NULL, NULL)),0) TRQ_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ERT_001, ANS_ERT_002, ANS_ERT_003, ANS_ERT_004, ANS_ERT_005, ANS_ERT_006, NULL, NULL, NULL, NULL)),0) ERT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT3_001, ANS_RT3_002, ANS_RT3_003, ANS_RT3_004, ANS_RT3_005, ANS_RT3_006, NULL, NULL, NULL, NULL)),0) RT3_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT5_001, ANS_RT5_002, ANS_RT5_003, ANS_RT5_004, ANS_RT5_005, ANS_RT5_006, NULL, NULL, NULL, NULL)),0) RT5_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PES_001, ANS_PES_002, ANS_PES_003, ANS_PES_004, ANS_PES_005, ANS_PES_006, NULL, NULL, NULL, NULL)),0) PES_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DMO_001, ANS_DMO_002, ANS_DMO_003, ANS_DMO_004, ANS_DMO_005, ANS_DMO_006, NULL, NULL, NULL, NULL)),0) DMO_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DND_001, ANS_DND_002, ANS_DND_003, ANS_DND_004, ANS_DND_005, ANS_DND_006, NULL, NULL, NULL, NULL)),0) DND_DSV ";
            sSQL = sSQL + " FROM ANS";

            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ID)))
            {
                sCond = sCond + " ANS_ID = " + ANS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT)))
            {
                sCond = sCond + " ANS_DAT BETWEEN Convert(datetime, '" + ANS_DAT + "',103) AND Convert(datetime, '" + ANS_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_INI)))
            {
                sCond = sCond + " ANS_DAT >= Convert(datetime, '" + ANS_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_FIM)))
            {
                sCond = sCond + " ANS_DAT <= Convert(datetime, '" + ANS_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_POY_ID)))
            {
                sCond = sCond + " ANS_TIT_POY_ID = " + ANS_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sCond = sCond + " ANS_LOT = '" + ANS_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sCond = sCond + " ANS_TIP_DES = '" + ANS_TIP_DES + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_APS_ID)))
            {
                sCond = sCond + " ANS_APS_ID = " + ANS_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_MAQ_ID)))
            {
                sCond = sCond + " ANS_MAQ_ID = " + ANS_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_ID)))
            {
                sCond = sCond + " ANS_ERT_ID = " + ANS_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_STS)))
            {
                sCond = sCond + " ANS_STS = " + ANS_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_LOT_TST)))
            {
                sCond = sCond + " ANS_LOT_TST = " + ANS_LOT_TST + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + "  GROUP BY ANS_DAT, ANS_LOT, ANS_TIT_POY_ID, ANS_APS_ID, ANS_MAQ_ID, ANS_ERT_ID, ANS_VRD ";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarForaLimites()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = sSQL + " SELECT COUNT(*) NUM";
            sSQL = sSQL + " FROM ";

            sSQL = sSQL + " (SELECT ANS_DAT, ANS_LOT, ANS_TIT_POY_ID, ANS_APS_ID, ANS_MAQ_ID, ANS_ERT_ID, ANS_VRD,";
            sSQL = sSQL + "  COUNT(*) NUM,";
            sSQL = sSQL + " AVG(ANS_TIT_MED) TIT_MED,";
            sSQL = sSQL + " AVG(ANS_TNC_MED) TNC_MED,";
            sSQL = sSQL + " AVG(ANS_AON_MED) AON_MED,";
            sSQL = sSQL + " AVG(ANS_ENM_MED) ENM_MED,";
            sSQL = sSQL + " AVG(ANS_EEE_MED) EEE_MED,";
            sSQL = sSQL + " AVG(ANS_KKK_MED) KKK_MED,";
            sSQL = sSQL + " AVG(ANS_BBB_MED) BBB_MED,";
            sSQL = sSQL + " AVG(ANS_PUE_MED) PUE_MED,";
            sSQL = sSQL + " AVG(ANS_OLE_MED) OLE_MED,";
            sSQL = sSQL + " AVG(ANS_TRQ_MED) TRQ_MED,";
            sSQL = sSQL + " AVG(ANS_ERT_MED) ERT_MED,";
            sSQL = sSQL + " AVG(ANS_RT3_MED) RT3_MED,";
            sSQL = sSQL + " AVG(ANS_RT5_MED) RT5_MED,";
            sSQL = sSQL + " AVG(ANS_PES_MED) PES_MED,";
            sSQL = sSQL + " AVG(ANS_DMO_MED) DMO_MED,";
            sSQL = sSQL + " AVG(ANS_DND_MED) DND_MED,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TIT_MED),0) TIT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TNC_MED),0) TNC_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_AON_MED),0) AON_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ENM_MED),0) ENM_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_EEE_MED),0) EEE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_KKK_MED),0) KKK_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_BBB_MED),0) BBB_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PUE_MED),0) PUE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_OLE_MED),0) OLE_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_TRQ_MED),0) TRQ_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_ERT_MED),0) ERT_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT3_MED),0) RT3_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_RT5_MED),0) RT5_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_PES_MED),0) PES_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DMO_MED),0) DMO_MED_DSV,";
            sSQL = sSQL + " ISNULL(STDEV(ANS_DND_MED),0) DND_MED_DSV,";
            sSQL = sSQL + " MIN(ANS_TIT_MED) TIT_MIN,";
            sSQL = sSQL + " MIN(ANS_TNC_MED) TNC_MIN,";
            sSQL = sSQL + " MIN(ANS_AON_MED) AON_MIN,";
            sSQL = sSQL + " MIN(ANS_ENM_MED) ENM_MIN,";
            sSQL = sSQL + " MIN(ANS_EEE_MED) EEE_MIN,";
            sSQL = sSQL + " MIN(ANS_KKK_MED) KKK_MIN,";
            sSQL = sSQL + " MIN(ANS_BBB_MED) BBB_MIN,";
            sSQL = sSQL + " MIN(ANS_PUE_MED) PUE_MIN,";
            sSQL = sSQL + " MIN(ANS_OLE_MED) OLE_MIN,";
            sSQL = sSQL + " MIN(ANS_TRQ_MED) TRQ_MIN,";
            sSQL = sSQL + " MIN(ANS_ERT_MED) ERT_MIN,";
            sSQL = sSQL + " MIN(ANS_RT3_MED) RT3_MIN,";
            sSQL = sSQL + " MIN(ANS_RT5_MED) RT5_MIN,";
            sSQL = sSQL + " MIN(ANS_PES_MED) PES_MIN,";
            sSQL = sSQL + " MIN(ANS_DMO_MED) DMO_MIN,";
            sSQL = sSQL + " MIN(ANS_DND_MED) DND_MIN,";
            sSQL = sSQL + " MAX(ANS_TIT_MED) TIT_MAX,";
            sSQL = sSQL + " MAX(ANS_TNC_MED) TNC_MAX,";
            sSQL = sSQL + " MAX(ANS_AON_MED) AON_MAX,";
            sSQL = sSQL + " MAX(ANS_ENM_MED) ENM_MAX,";
            sSQL = sSQL + " MAX(ANS_EEE_MED) EEE_MAX,";
            sSQL = sSQL + " MAX(ANS_KKK_MED) KKK_MAX,";
            sSQL = sSQL + " MAX(ANS_BBB_MED) BBB_MAX,";
            sSQL = sSQL + " MAX(ANS_PUE_MED) PUE_MAX,";
            sSQL = sSQL + " MAX(ANS_OLE_MED) OLE_MAX,";
            sSQL = sSQL + " MAX(ANS_TRQ_MED) TRQ_MAX,";
            sSQL = sSQL + " MAX(ANS_ERT_MED) ERT_MAX,";
            sSQL = sSQL + " MAX(ANS_RT3_MED) RT3_MAX,";
            sSQL = sSQL + " MAX(ANS_RT5_MED) RT5_MAX,";
            sSQL = sSQL + " MAX(ANS_PES_MED) PES_MAX,";
            sSQL = sSQL + " MAX(ANS_DMO_MED) DMO_MAX,";
            sSQL = sSQL + " MAX(ANS_DND_MED) DND_MAX,";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TIT_001, ANS_TIT_002, ANS_TIT_003, ANS_TIT_004, ANS_TIT_005, ANS_TIT_006, NULL, NULL, NULL, NULL)),0) TIT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TNC_001, ANS_TNC_002, ANS_TNC_003, ANS_TNC_004, ANS_TNC_005, ANS_TNC_006, NULL, NULL, NULL, NULL)),0) TNC_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_AON_001, ANS_AON_002, ANS_AON_003, ANS_AON_004, ANS_AON_005, ANS_AON_006, NULL, NULL, NULL, NULL)),0) AON_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ENM_001, ANS_ENM_002, ANS_ENM_003, ANS_ENM_004, ANS_ENM_005, ANS_ENM_006, NULL, NULL, NULL, NULL)),0) ENM_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_EEE_001, ANS_EEE_002, ANS_EEE_003, ANS_EEE_004, ANS_EEE_005, ANS_EEE_006, NULL, NULL, NULL, NULL)),0) EEE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_KKK_001, ANS_KKK_002, ANS_KKK_003, ANS_KKK_004, ANS_KKK_005, ANS_KKK_006, NULL, NULL, NULL, NULL)),0) KKK_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_BBB_001, ANS_BBB_002, ANS_BBB_003, ANS_BBB_004, ANS_BBB_005, ANS_BBB_006, NULL, NULL, NULL, NULL)),0) BBB_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PUE_001, ANS_PUE_002, ANS_PUE_003, ANS_PUE_004, ANS_PUE_005, ANS_PUE_006, NULL, NULL, NULL, NULL)),0) PUE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_OLE_001, ANS_OLE_002, ANS_OLE_003, ANS_OLE_004, ANS_OLE_005, ANS_OLE_006, NULL, NULL, NULL, NULL)),0) OLE_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_TRQ_001, ANS_TRQ_002, ANS_TRQ_003, ANS_TRQ_004, ANS_TRQ_005, ANS_TRQ_006, NULL, NULL, NULL, NULL)),0) TRQ_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_ERT_001, ANS_ERT_002, ANS_ERT_003, ANS_ERT_004, ANS_ERT_005, ANS_ERT_006, NULL, NULL, NULL, NULL)),0) ERT_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT3_001, ANS_RT3_002, ANS_RT3_003, ANS_RT3_004, ANS_RT3_005, ANS_RT3_006, NULL, NULL, NULL, NULL)),0) RT3_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_RT5_001, ANS_RT5_002, ANS_RT5_003, ANS_RT5_004, ANS_RT5_005, ANS_RT5_006, NULL, NULL, NULL, NULL)),0) RT5_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_PES_001, ANS_PES_002, ANS_PES_003, ANS_PES_004, ANS_PES_005, ANS_PES_006, NULL, NULL, NULL, NULL)),0) PES_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DMO_001, ANS_DMO_002, ANS_DMO_003, ANS_DMO_004, ANS_DMO_005, ANS_DMO_006, NULL, NULL, NULL, NULL)),0) DMO_DSV, ";
            sSQL = sSQL + " ISNULL(STDEV(dbo.DESVIO  (ANS_DND_001, ANS_DND_002, ANS_DND_003, ANS_DND_004, ANS_DND_005, ANS_DND_006, NULL, NULL, NULL, NULL)),0) DND_DSV ";
            sSQL = sSQL + " FROM ANS";

            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ID)))
            {
                sCond = sCond + " ANS_ID = " + ANS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT)))
            {
                sCond = sCond + " ANS_DAT BETWEEN Convert(datetime, '" + ANS_DAT + "',103) AND Convert(datetime, '" + ANS_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_INI)))
            {
                sCond = sCond + " ANS_DAT >= Convert(datetime, '" + ANS_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_DAT_FIM)))
            {
                sCond = sCond + " ANS_DAT <= Convert(datetime, '" + ANS_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_POY_ID)))
            {
                sCond = sCond + " ANS_TIT_POY_ID = " + ANS_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(ANS_LOT))
            {
                sCond = sCond + " ANS_LOT = '" + ANS_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sCond = sCond + " ANS_TIP_DES = '" + ANS_TIP_DES + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_APS_ID)))
            {
                sCond = sCond + " ANS_APS_ID = " + ANS_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_MAQ_ID)))
            {
                sCond = sCond + " ANS_MAQ_ID = " + ANS_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_ID)))
            {
                sCond = sCond + " ANS_ERT_ID = " + ANS_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_STS)))
            {
                sCond = sCond + " ANS_STS = " + ANS_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + "  GROUP BY ANS_DAT, ANS_LOT, ANS_TIT_POY_ID, ANS_APS_ID, ANS_MAQ_ID, ANS_ERT_ID, ANS_VRD) ANS";

            sCond = "";

            if (ANS_MED == "S")
            {
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_INF)))
                {
                    sCond = sCond + " TIT_MED < " + ANS_TIT_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_SUP)))
                {
                    sCond = sCond + " TIT_MED > " + ANS_TIT_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TNC_INF)))
                {
                    sCond = sCond + " TNC_MED < " + ANS_TNC_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TNC_SUP)))
                {
                    sCond = sCond + " TNC_MED > " + ANS_TNC_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_AON_INF)))
                {
                    sCond = sCond + " AON_MED < " + ANS_AON_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_AON_SUP)))
                {
                    sCond = sCond + " AON_MED > " + ANS_AON_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ENM_INF)))
                {
                    sCond = sCond + " ENM_MED < " + ANS_ENM_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ENM_SUP)))
                {
                    sCond = sCond + " ENM_MED > " + ANS_ENM_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_EEE_INF)))
                {
                    sCond = sCond + " EEE_MED < " + ANS_EEE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_EEE_SUP)))
                {
                    sCond = sCond + " EEE_MED > " + ANS_EEE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_KKK_INF)))
                {
                    sCond = sCond + " KKK_MED < " + ANS_KKK_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_KKK_SUP)))
                {
                    sCond = sCond + " KKK_MED > " + ANS_KKK_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_BBB_INF)))
                {
                    sCond = sCond + " BBB_MED < " + ANS_BBB_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_BBB_SUP)))
                {
                    sCond = sCond + " BBB_MED > " + ANS_BBB_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PUE_INF)))
                {
                    sCond = sCond + " PUE_MED < " + ANS_PUE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PUE_SUP)))
                {
                    sCond = sCond + " PUE_MED > " + ANS_PUE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_OLE_INF)))
                {
                    sCond = sCond + " OLE_MED < " + ANS_OLE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_OLE_SUP)))
                {
                    sCond = sCond + " OLE_MED > " + ANS_OLE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TRQ_INF)))
                {
                    sCond = sCond + " TRQ_MED < " + ANS_TRQ_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TRQ_SUP)))
                {
                    sCond = sCond + " TRQ_MED > " + ANS_TRQ_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_INF)))
                {
                    sCond = sCond + " ERT_MED < " + ANS_ERT_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_SUP)))
                {
                    sCond = sCond + " ERT_MED > " + ANS_ERT_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT3_INF)))
                {
                    sCond = sCond + " RT3_MED < " + ANS_RT3_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT3_SUP)))
                {
                    sCond = sCond + " RT3_MED > " + ANS_RT3_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT5_INF)))
                {
                    sCond = sCond + " RT5_MED < " + ANS_RT5_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT5_SUP)))
                {
                    sCond = sCond + " RT5_MED > " + ANS_RT5_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PES_INF)))
                {
                    sCond = sCond + " PES_MED < " + ANS_PES_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PES_SUP)))
                {
                    sCond = sCond + " PES_MED > " + ANS_PES_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DMO_INF)))
                {
                    sCond = sCond + " DMO_MED < " + ANS_DMO_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DMO_SUP)))
                {
                    sCond = sCond + " DMO_MED > " + ANS_DMO_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DND_INF)))
                {
                    sCond = sCond + " DND_MED < " + ANS_DND_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DND_SUP)))
                {
                    sCond = sCond + " DND_MED > " + ANS_DND_SUP.ToString().Replace(",", ".") + " AND ";
                }
            }
            else
            {
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_INF)))
                {
                    sCond = sCond + " TIT_DSV < " + ANS_TIT_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIT_SUP)))
                {
                    sCond = sCond + " TIT_DSV > " + ANS_TIT_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TNC_INF)))
                {
                    sCond = sCond + " TNC_DSV < " + ANS_TNC_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TNC_SUP)))
                {
                    sCond = sCond + " TNC_DSV > " + ANS_TNC_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_AON_INF)))
                {
                    sCond = sCond + " AON_DSV < " + ANS_AON_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_AON_SUP)))
                {
                    sCond = sCond + " AON_DSV > " + ANS_AON_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ENM_INF)))
                {
                    sCond = sCond + " ENM_DSV < " + ANS_ENM_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ENM_SUP)))
                {
                    sCond = sCond + " ENM_DSV > " + ANS_ENM_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_EEE_INF)))
                {
                    sCond = sCond + " EEE_DSV < " + ANS_EEE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_EEE_SUP)))
                {
                    sCond = sCond + " EEE_DSV > " + ANS_EEE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_KKK_INF)))
                {
                    sCond = sCond + " KKK_DSV < " + ANS_KKK_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_KKK_SUP)))
                {
                    sCond = sCond + " KKK_DSV > " + ANS_KKK_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_BBB_INF)))
                {
                    sCond = sCond + " BBB_DSV < " + ANS_BBB_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_BBB_SUP)))
                {
                    sCond = sCond + " BBB_DSV > " + ANS_BBB_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PUE_INF)))
                {
                    sCond = sCond + " PUE_DSV < " + ANS_PUE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PUE_SUP)))
                {
                    sCond = sCond + " PUE_DSV > " + ANS_PUE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_OLE_INF)))
                {
                    sCond = sCond + " OLE_DSV < " + ANS_OLE_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_OLE_SUP)))
                {
                    sCond = sCond + " OLE_DSV > " + ANS_OLE_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TRQ_INF)))
                {
                    sCond = sCond + " TRQ_DSV < " + ANS_TRQ_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_TRQ_SUP)))
                {
                    sCond = sCond + " TRQ_DSV > " + ANS_TRQ_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_INF)))
                {
                    sCond = sCond + " ERT_DSV < " + ANS_ERT_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_ERT_SUP)))
                {
                    sCond = sCond + " ERT_DSV > " + ANS_ERT_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT3_INF)))
                {
                    sCond = sCond + " RT3_DSV < " + ANS_RT3_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT3_SUP)))
                {
                    sCond = sCond + " RT3_DSV > " + ANS_RT3_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT5_INF)))
                {
                    sCond = sCond + " RT5_DSV < " + ANS_RT5_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_RT5_SUP)))
                {
                    sCond = sCond + " RT5_DSV > " + ANS_RT5_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PES_INF)))
                {
                    sCond = sCond + " PES_DSV < " + ANS_PES_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_PES_SUP)))
                {
                    sCond = sCond + " PES_DSV > " + ANS_PES_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DMO_INF)))
                {
                    sCond = sCond + " DMO_DSV < " + ANS_DMO_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DMO_SUP)))
                {
                    sCond = sCond + " DMO_DSV > " + ANS_DMO_SUP.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DND_INF)))
                {
                    sCond = sCond + " DND_DSV < " + ANS_DND_INF.ToString().Replace(",", ".") + " AND ";
                }
                if (!String.IsNullOrEmpty(Convert.ToString(ANS_DND_SUP)))
                {
                    sCond = sCond + " DND_DSV > " + ANS_DND_SUP.ToString().Replace(",", ".") + " AND ";
                }
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }
        #endregion

    }
}