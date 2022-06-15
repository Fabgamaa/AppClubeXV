using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Especificacao
    {

        #region Propriedades

        private int? _ANE_ID;
        private DateTime? _ANE_DAT;
        private string _ANE_LOT;
        private string _ANE_LOT_REF;
        private int? _ANE_TIT_POY_ID;
        private int? _ANE_APS_ID;
        private int? _ANE_MAQ_TIP_ID;
        private int? _ANE_ERT_ID;
        private double? _ANE_TIT_CON;
        private double? _ANE_TIT_MED;
        private double? _ANE_TNC_MED;
        private double? _ANE_AON_MED;
        private double? _ANE_ENM_MED;
        private double? _ANE_EEE_MED;
        private double? _ANE_KKK_MED;
        private double? _ANE_BBB_MED;
        private double? _ANE_PUE_MED;
        private double? _ANE_OLE_MED;
        private double? _ANE_TRQ_MED;
        private double? _ANE_ERT_MED;
        private double? _ANE_RT3_MED;
        private double? _ANE_RT5_MED;
        private double? _ANE_PES_MED;
        private double? _ANE_DMO_MED;
        private double? _ANE_DND_MED;
        private double? _ANE_TIT_TLR;
        private double? _ANE_TNC_TLR;
        private double? _ANE_AON_TLR;
        private double? _ANE_ENM_TLR;
        private double? _ANE_EEE_TLR;
        private double? _ANE_KKK_TLR;
        private double? _ANE_BBB_TLR;
        private double? _ANE_PUE_TLR;
        private double? _ANE_OLE_TLR;
        private double? _ANE_TRQ_TLR;
        private double? _ANE_ERT_TLR;
        private double? _ANE_RT3_TLR;
        private double? _ANE_RT5_TLR;
        private double? _ANE_PES_TLR;
        private double? _ANE_DMO_TLR;
        private double? _ANE_DND_TLR;
        private double? _ANE_TIT_MIN;
        private double? _ANE_TNC_MIN;
        private double? _ANE_AON_MIN;
        private double? _ANE_ENM_MIN;
        private double? _ANE_EEE_MIN;
        private double? _ANE_KKK_MIN;
        private double? _ANE_BBB_MIN;
        private double? _ANE_PUE_MIN;
        private double? _ANE_OLE_MIN;
        private double? _ANE_TRQ_MIN;
        private double? _ANE_ERT_MIN;
        private double? _ANE_RT3_MIN;
        private double? _ANE_RT5_MIN;
        private double? _ANE_PES_MIN;
        private double? _ANE_DMO_MIN;
        private double? _ANE_DND_MIN;
        private double? _ANE_TIT_MAX;
        private double? _ANE_TNC_MAX;
        private double? _ANE_AON_MAX;
        private double? _ANE_ENM_MAX;
        private double? _ANE_EEE_MAX;
        private double? _ANE_KKK_MAX;
        private double? _ANE_BBB_MAX;
        private double? _ANE_PUE_MAX;
        private double? _ANE_OLE_MAX;
        private double? _ANE_TRQ_MAX;
        private double? _ANE_ERT_MAX;
        private double? _ANE_RT3_MAX;
        private double? _ANE_RT5_MAX;
        private double? _ANE_PES_MAX;
        private double? _ANE_DMO_MAX;
        private double? _ANE_DND_MAX;
        private string _ANE_OBS;
        private int? _ANE_STS;
        private int? _ANE_USR_INC_ID;
        private int? _ANE_USR_ALT_ID;
        private DateTime? _ANE_TMS_ATL;

        private DateTime? _ANE_DAT_INI;
        private DateTime? _ANE_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? ANE_ID
        {
            get { return _ANE_ID; }
            set { _ANE_ID = value; }
        }
        public DateTime? ANE_DAT
        {
            get { return _ANE_DAT; }
            set { _ANE_DAT = value; }
        }
        public string ANE_LOT
        {
            get { return _ANE_LOT; }
            set { _ANE_LOT = value.ToUpper(); }
        }
        public string ANE_LOT_REF
        {
            get { return _ANE_LOT_REF; }
            set { _ANE_LOT_REF = value.ToUpper(); }
        }
        public int? ANE_TIT_POY_ID
        {
            get { return _ANE_TIT_POY_ID; }
            set { _ANE_TIT_POY_ID = value; }
        }
        public int? ANE_APS_ID
        {
            get { return _ANE_APS_ID; }
            set { _ANE_APS_ID = value; }
        }
        public int? ANE_MAQ_TIP_ID
        {
            get { return _ANE_MAQ_TIP_ID; }
            set { _ANE_MAQ_TIP_ID = value; }
        }
        public int? ANE_ERT_ID
        {
            get { return _ANE_ERT_ID; }
            set { _ANE_ERT_ID = value; }
        }
        public double? ANE_TIT_CON
        {
            get { return _ANE_TIT_CON; }
            set { _ANE_TIT_CON = value; }
        }
        public double? ANE_TIT_MED
        {
            get { return _ANE_TIT_MED; }
            set { _ANE_TIT_MED = value; }
        }
        public double? ANE_TNC_MED
        {
            get { return _ANE_TNC_MED; }
            set { _ANE_TNC_MED = value; }
        }
        public double? ANE_AON_MED
        {
            get { return _ANE_AON_MED; }
            set { _ANE_AON_MED = value; }
        }
        public double? ANE_ENM_MED
        {
            get { return _ANE_ENM_MED; }
            set { _ANE_ENM_MED = value; }
        }
        public double? ANE_EEE_MED
        {
            get { return _ANE_EEE_MED; }
            set { _ANE_EEE_MED = value; }
        }
        public double? ANE_KKK_MED
        {
            get { return _ANE_KKK_MED; }
            set { _ANE_KKK_MED = value; }
        }
        public double? ANE_BBB_MED
        {
            get { return _ANE_BBB_MED; }
            set { _ANE_BBB_MED = value; }
        }
        public double? ANE_PUE_MED
        {
            get { return _ANE_PUE_MED; }
            set { _ANE_PUE_MED = value; }
        }
        public double? ANE_OLE_MED
        {
            get { return _ANE_OLE_MED; }
            set { _ANE_OLE_MED = value; }
        }
        public double? ANE_TRQ_MED
        {
            get { return _ANE_TRQ_MED; }
            set { _ANE_TRQ_MED = value; }
        }
        public double? ANE_ERT_MED
        {
            get { return _ANE_ERT_MED; }
            set { _ANE_ERT_MED = value; }
        }
        public double? ANE_RT3_MED
        {
            get { return _ANE_RT3_MED; }
            set { _ANE_RT3_MED = value; }
        }
        public double? ANE_RT5_MED
        {
            get { return _ANE_RT5_MED; }
            set { _ANE_RT5_MED = value; }
        }
        public double? ANE_PES_MED
        {
            get { return _ANE_PES_MED; }
            set { _ANE_PES_MED = value; }
        }
        public double? ANE_DMO_MED
        {
            get { return _ANE_DMO_MED; }
            set { _ANE_DMO_MED = value; }
        }
        public double? ANE_DND_MED
        {
            get { return _ANE_DND_MED; }
            set { _ANE_DND_MED = value; }
        }
        public double? ANE_TIT_TLR
        {
            get { return _ANE_TIT_TLR; }
            set { _ANE_TIT_TLR = value; }
        }
        public double? ANE_TNC_TLR
        {
            get { return _ANE_TNC_TLR; }
            set { _ANE_TNC_TLR = value; }
        }
        public double? ANE_AON_TLR
        {
            get { return _ANE_AON_TLR; }
            set { _ANE_AON_TLR = value; }
        }
        public double? ANE_ENM_TLR
        {
            get { return _ANE_ENM_TLR; }
            set { _ANE_ENM_TLR = value; }
        }
        public double? ANE_EEE_TLR
        {
            get { return _ANE_EEE_TLR; }
            set { _ANE_EEE_TLR = value; }
        }
        public double? ANE_KKK_TLR
        {
            get { return _ANE_KKK_TLR; }
            set { _ANE_KKK_TLR = value; }
        }
        public double? ANE_BBB_TLR
        {
            get { return _ANE_BBB_TLR; }
            set { _ANE_BBB_TLR = value; }
        }
        public double? ANE_PUE_TLR
        {
            get { return _ANE_PUE_TLR; }
            set { _ANE_PUE_TLR = value; }
        }
        public double? ANE_OLE_TLR
        {
            get { return _ANE_OLE_TLR; }
            set { _ANE_OLE_TLR = value; }
        }
        public double? ANE_TRQ_TLR
        {
            get { return _ANE_TRQ_TLR; }
            set { _ANE_TRQ_TLR = value; }
        }
        public double? ANE_ERT_TLR
        {
            get { return _ANE_ERT_TLR; }
            set { _ANE_ERT_TLR = value; }
        }
        public double? ANE_RT3_TLR
        {
            get { return _ANE_RT3_TLR; }
            set { _ANE_RT3_TLR = value; }
        }
        public double? ANE_RT5_TLR
        {
            get { return _ANE_RT5_TLR; }
            set { _ANE_RT5_TLR = value; }
        }
        public double? ANE_PES_TLR
        {
            get { return _ANE_PES_TLR; }
            set { _ANE_PES_TLR = value; }
        }
        public double? ANE_DMO_TLR
        {
            get { return _ANE_DMO_TLR; }
            set { _ANE_DMO_TLR = value; }
        }
        public double? ANE_DND_TLR
        {
            get { return _ANE_DND_TLR; }
            set { _ANE_DND_TLR = value; }
        }
        public double? ANE_TIT_MIN
        {
            get { return _ANE_TIT_MIN; }
            set { _ANE_TIT_MIN = value; }
        }
        public double? ANE_TNC_MIN
        {
            get { return _ANE_TNC_MIN; }
            set { _ANE_TNC_MIN = value; }
        }
        public double? ANE_AON_MIN
        {
            get { return _ANE_AON_MIN; }
            set { _ANE_AON_MIN = value; }
        }
        public double? ANE_ENM_MIN
        {
            get { return _ANE_ENM_MIN; }
            set { _ANE_ENM_MIN = value; }
        }
        public double? ANE_EEE_MIN
        {
            get { return _ANE_EEE_MIN; }
            set { _ANE_EEE_MIN = value; }
        }
        public double? ANE_KKK_MIN
        {
            get { return _ANE_KKK_MIN; }
            set { _ANE_KKK_MIN = value; }
        }
        public double? ANE_BBB_MIN
        {
            get { return _ANE_BBB_MIN; }
            set { _ANE_BBB_MIN = value; }
        }
        public double? ANE_PUE_MIN
        {
            get { return _ANE_PUE_MIN; }
            set { _ANE_PUE_MIN = value; }
        }
        public double? ANE_OLE_MIN
        {
            get { return _ANE_OLE_MIN; }
            set { _ANE_OLE_MIN = value; }
        }
        public double? ANE_TRQ_MIN
        {
            get { return _ANE_TRQ_MIN; }
            set { _ANE_TRQ_MIN = value; }
        }
        public double? ANE_ERT_MIN
        {
            get { return _ANE_ERT_MIN; }
            set { _ANE_ERT_MIN = value; }
        }
        public double? ANE_RT3_MIN
        {
            get { return _ANE_RT3_MIN; }
            set { _ANE_RT3_MIN = value; }
        }
        public double? ANE_RT5_MIN
        {
            get { return _ANE_RT5_MIN; }
            set { _ANE_RT5_MIN = value; }
        }
        public double? ANE_PES_MIN
        {
            get { return _ANE_PES_MIN; }
            set { _ANE_PES_MIN = value; }
        }
        public double? ANE_DMO_MIN
        {
            get { return _ANE_DMO_MIN; }
            set { _ANE_DMO_MIN = value; }
        }
        public double? ANE_DND_MIN
        {
            get { return _ANE_DND_MIN; }
            set { _ANE_DND_MIN = value; }
        }
        public double? ANE_TIT_MAX
        {
            get { return _ANE_TIT_MAX; }
            set { _ANE_TIT_MAX = value; }
        }
        public double? ANE_TNC_MAX
        {
            get { return _ANE_TNC_MAX; }
            set { _ANE_TNC_MAX = value; }
        }
        public double? ANE_AON_MAX
        {
            get { return _ANE_AON_MAX; }
            set { _ANE_AON_MAX = value; }
        }
        public double? ANE_ENM_MAX
        {
            get { return _ANE_ENM_MAX; }
            set { _ANE_ENM_MAX = value; }
        }
        public double? ANE_EEE_MAX
        {
            get { return _ANE_EEE_MAX; }
            set { _ANE_EEE_MAX = value; }
        }
        public double? ANE_KKK_MAX
        {
            get { return _ANE_KKK_MAX; }
            set { _ANE_KKK_MAX = value; }
        }
        public double? ANE_BBB_MAX
        {
            get { return _ANE_BBB_MAX; }
            set { _ANE_BBB_MAX = value; }
        }
        public double? ANE_PUE_MAX
        {
            get { return _ANE_PUE_MAX; }
            set { _ANE_PUE_MAX = value; }
        }
        public double? ANE_OLE_MAX
        {
            get { return _ANE_OLE_MAX; }
            set { _ANE_OLE_MAX = value; }
        }
        public double? ANE_TRQ_MAX
        {
            get { return _ANE_TRQ_MAX; }
            set { _ANE_TRQ_MAX = value; }
        }
        public double? ANE_ERT_MAX
        {
            get { return _ANE_ERT_MAX; }
            set { _ANE_ERT_MAX = value; }
        }
        public double? ANE_RT3_MAX
        {
            get { return _ANE_RT3_MAX; }
            set { _ANE_RT3_MAX = value; }
        }
        public double? ANE_RT5_MAX
        {
            get { return _ANE_RT5_MAX; }
            set { _ANE_RT5_MAX = value; }
        }
        public double? ANE_PES_MAX
        {
            get { return _ANE_PES_MAX; }
            set { _ANE_PES_MAX = value; }
        }
        public double? ANE_DMO_MAX
        {
            get { return _ANE_DMO_MAX; }
            set { _ANE_DMO_MAX = value; }
        }
        public double? ANE_DND_MAX
        {
            get { return _ANE_DND_MAX; }
            set { _ANE_DND_MAX = value; }
        }
        public string ANE_OBS
        {
            get { return _ANE_OBS; }
            set { _ANE_OBS = value.ToUpper(); }
        }
        public int? ANE_STS
        {
            get { return _ANE_STS; }
            set { _ANE_STS = value; }
        }
        public int? ANE_USR_INC_ID
        {
            get { return _ANE_USR_INC_ID; }
            set { _ANE_USR_INC_ID = value; }
        }
        public int? ANE_USR_ALT_ID
        {
            get { return _ANE_USR_ALT_ID; }
            set { _ANE_USR_ALT_ID = value; }
        }
        public DateTime? ANE_TMS_ATL
        {
            get { return _ANE_TMS_ATL; }
            set { _ANE_TMS_ATL = value; }
        }

        public DateTime? ANE_DAT_INI
        {
            get { return _ANE_DAT_INI; }
            set { _ANE_DAT_INI = value; }
        }

        public DateTime? ANE_DAT_FIM
        {
            get { return _ANE_DAT_FIM; }
            set { _ANE_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO ANE (";
            sSQL = sSQL + "ANE_DAT, ";
            sSQL = sSQL + "ANE_LOT, ";
            sSQL = sSQL + "ANE_LOT_REF, ";
            sSQL = sSQL + "ANE_TIT_POY_ID, ";
            sSQL = sSQL + "ANE_APS_ID, ";
            sSQL = sSQL + "ANE_MAQ_TIP_ID, ";
            sSQL = sSQL + "ANE_ERT_ID, ";
            sSQL = sSQL + "ANE_TIT_CON, ";
            sSQL = sSQL + "ANE_TIT_MED, ";
            sSQL = sSQL + "ANE_TNC_MED, ";
            sSQL = sSQL + "ANE_AON_MED, ";
            sSQL = sSQL + "ANE_ENM_MED, ";
            sSQL = sSQL + "ANE_EEE_MED, ";
            sSQL = sSQL + "ANE_KKK_MED, ";
            sSQL = sSQL + "ANE_BBB_MED, ";
            sSQL = sSQL + "ANE_PUE_MED, ";
            sSQL = sSQL + "ANE_OLE_MED, ";
            sSQL = sSQL + "ANE_TRQ_MED, ";
            sSQL = sSQL + "ANE_ERT_MED, ";
            sSQL = sSQL + "ANE_RT3_MED, ";
            sSQL = sSQL + "ANE_RT5_MED, ";
            sSQL = sSQL + "ANE_PES_MED, ";
            sSQL = sSQL + "ANE_DMO_MED, ";
            sSQL = sSQL + "ANE_DND_MED, ";
            sSQL = sSQL + "ANE_TIT_TLR, ";
            sSQL = sSQL + "ANE_TNC_TLR, ";
            sSQL = sSQL + "ANE_AON_TLR, ";
            sSQL = sSQL + "ANE_ENM_TLR, ";
            sSQL = sSQL + "ANE_EEE_TLR, ";
            sSQL = sSQL + "ANE_KKK_TLR, ";
            sSQL = sSQL + "ANE_BBB_TLR, ";
            sSQL = sSQL + "ANE_PUE_TLR, ";
            sSQL = sSQL + "ANE_OLE_TLR, ";
            sSQL = sSQL + "ANE_TRQ_TLR, ";
            sSQL = sSQL + "ANE_ERT_TLR, ";
            sSQL = sSQL + "ANE_RT3_TLR, ";
            sSQL = sSQL + "ANE_RT5_TLR, ";
            sSQL = sSQL + "ANE_PES_TLR, ";
            sSQL = sSQL + "ANE_DMO_TLR, ";
            sSQL = sSQL + "ANE_DND_TLR, ";
            sSQL = sSQL + "ANE_TIT_MIN, ";
            sSQL = sSQL + "ANE_TNC_MIN, ";
            sSQL = sSQL + "ANE_AON_MIN, ";
            sSQL = sSQL + "ANE_ENM_MIN, ";
            sSQL = sSQL + "ANE_EEE_MIN, ";
            sSQL = sSQL + "ANE_KKK_MIN, ";
            sSQL = sSQL + "ANE_BBB_MIN, ";
            sSQL = sSQL + "ANE_PUE_MIN, ";
            sSQL = sSQL + "ANE_OLE_MIN, ";
            sSQL = sSQL + "ANE_TRQ_MIN, ";
            sSQL = sSQL + "ANE_ERT_MIN, ";
            sSQL = sSQL + "ANE_RT3_MIN, ";
            sSQL = sSQL + "ANE_RT5_MIN, ";
            sSQL = sSQL + "ANE_PES_MIN, ";
            sSQL = sSQL + "ANE_DMO_MIN, ";
            sSQL = sSQL + "ANE_DND_MIN, ";
            sSQL = sSQL + "ANE_TIT_MAX, ";
            sSQL = sSQL + "ANE_TNC_MAX, ";
            sSQL = sSQL + "ANE_AON_MAX, ";
            sSQL = sSQL + "ANE_ENM_MAX, ";
            sSQL = sSQL + "ANE_EEE_MAX, ";
            sSQL = sSQL + "ANE_KKK_MAX, ";
            sSQL = sSQL + "ANE_BBB_MAX, ";
            sSQL = sSQL + "ANE_PUE_MAX, ";
            sSQL = sSQL + "ANE_OLE_MAX, ";
            sSQL = sSQL + "ANE_TRQ_MAX, ";
            sSQL = sSQL + "ANE_ERT_MAX, ";
            sSQL = sSQL + "ANE_RT3_MAX, ";
            sSQL = sSQL + "ANE_RT5_MAX, ";
            sSQL = sSQL + "ANE_PES_MAX, ";
            sSQL = sSQL + "ANE_DMO_MAX, ";
            sSQL = sSQL + "ANE_DND_MAX, ";
            sSQL = sSQL + "ANE_OBS, ";
            sSQL = sSQL + "ANE_STS, ";
            sSQL = sSQL + "ANE_USR_INC_ID, ";
            sSQL = sSQL + "ANE_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ANE_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + ANE_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT))
            {
                sSQL = sSQL + "'" + ANE_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT_REF))
            {
                sSQL = sSQL + "'" + ANE_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + ANE_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_APS_ID.ToString()))
            {
                sSQL = sSQL + ANE_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + ANE_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_ID.ToString()))
            {
                sSQL = sSQL + ANE_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_CON.ToString()))
            {
                sSQL = sSQL + ANE_TIT_CON.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MED.ToString()))
            {
                sSQL = sSQL + ANE_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MED.ToString()))
            {
                sSQL = sSQL + ANE_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MED.ToString()))
            {
                sSQL = sSQL + ANE_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MED.ToString()))
            {
                sSQL = sSQL + ANE_ENM_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MED.ToString()))
            {
                sSQL = sSQL + ANE_EEE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MED.ToString()))
            {
                sSQL = sSQL + ANE_KKK_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MED.ToString()))
            {
                sSQL = sSQL + ANE_BBB_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MED.ToString()))
            {
                sSQL = sSQL + ANE_PUE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MED.ToString()))
            {
                sSQL = sSQL + ANE_OLE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MED.ToString()))
            {
                sSQL = sSQL + ANE_TRQ_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MED.ToString()))
            {
                sSQL = sSQL + ANE_ERT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MED.ToString()))
            {
                sSQL = sSQL + ANE_RT3_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MED.ToString()))
            {
                sSQL = sSQL + ANE_RT5_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MED.ToString()))
            {
                sSQL = sSQL + ANE_PES_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MED.ToString()))
            {
                sSQL = sSQL + ANE_DMO_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MED.ToString()))
            {
                sSQL = sSQL + ANE_DND_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_TLR.ToString()))
            {
                sSQL = sSQL + ANE_TIT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_TLR.ToString()))
            {
                sSQL = sSQL + ANE_TNC_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_TLR.ToString()))
            {
                sSQL = sSQL + ANE_AON_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_TLR.ToString()))
            {
                sSQL = sSQL + ANE_ENM_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_TLR.ToString()))
            {
                sSQL = sSQL + ANE_EEE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_TLR.ToString()))
            {
                sSQL = sSQL + ANE_KKK_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_TLR.ToString()))
            {
                sSQL = sSQL + ANE_BBB_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_TLR.ToString()))
            {
                sSQL = sSQL + ANE_PUE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_TLR.ToString()))
            {
                sSQL = sSQL + ANE_OLE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_TLR.ToString()))
            {
                sSQL = sSQL + ANE_TRQ_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_TLR.ToString()))
            {
                sSQL = sSQL + ANE_ERT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_TLR.ToString()))
            {
                sSQL = sSQL + ANE_RT3_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_TLR.ToString()))
            {
                sSQL = sSQL + ANE_RT5_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_TLR.ToString()))
            {
                sSQL = sSQL + ANE_PES_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_TLR.ToString()))
            {
                sSQL = sSQL + ANE_DMO_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_TLR.ToString()))
            {
                sSQL = sSQL + ANE_DND_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MIN.ToString()))
            {
                sSQL = sSQL + ANE_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MIN.ToString()))
            {
                sSQL = sSQL + ANE_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MIN.ToString()))
            {
                sSQL = sSQL + ANE_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MIN.ToString()))
            {
                sSQL = sSQL + ANE_ENM_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_EEE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MIN.ToString()))
            {
                sSQL = sSQL + ANE_KKK_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MIN.ToString()))
            {
                sSQL = sSQL + ANE_BBB_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_PUE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_OLE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MIN.ToString()))
            {
                sSQL = sSQL + ANE_TRQ_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MIN.ToString()))
            {
                sSQL = sSQL + ANE_ERT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MIN.ToString()))
            {
                sSQL = sSQL + ANE_RT3_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MIN.ToString()))
            {
                sSQL = sSQL + ANE_RT5_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MIN.ToString()))
            {
                sSQL = sSQL + ANE_PES_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MIN.ToString()))
            {
                sSQL = sSQL + ANE_DMO_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MIN.ToString()))
            {
                sSQL = sSQL + ANE_DND_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MAX.ToString()))
            {
                sSQL = sSQL + ANE_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MAX.ToString()))
            {
                sSQL = sSQL + ANE_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MAX.ToString()))
            {
                sSQL = sSQL + ANE_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MAX.ToString()))
            {
                sSQL = sSQL + ANE_ENM_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_EEE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MAX.ToString()))
            {
                sSQL = sSQL + ANE_KKK_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MAX.ToString()))
            {
                sSQL = sSQL + ANE_BBB_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_PUE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_OLE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MAX.ToString()))
            {
                sSQL = sSQL + ANE_TRQ_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MAX.ToString()))
            {
                sSQL = sSQL + ANE_ERT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MAX.ToString()))
            {
                sSQL = sSQL + ANE_RT3_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MAX.ToString()))
            {
                sSQL = sSQL + ANE_RT5_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MAX.ToString()))
            {
                sSQL = sSQL + ANE_PES_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MAX.ToString()))
            {
                sSQL = sSQL + ANE_DMO_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MAX.ToString()))
            {
                sSQL = sSQL + ANE_DND_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OBS))
            {
                sSQL = sSQL + "'" + ANE_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_STS.ToString()))
            {
                sSQL = sSQL + ANE_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ANE_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ANE ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ANE_DAT.ToString()))
            {
                sSQL = sSQL + "ANE_DAT = Convert(datetime, '" + ANE_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "ANE_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT))
            {
                sSQL = sSQL + "ANE_LOT = '" + ANE_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANE_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT_REF))
            {
                sSQL = sSQL + "ANE_LOT_REF = '" + ANE_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANE_LOT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_POY_ID = " + ANE_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_APS_ID.ToString()))
            {
                sSQL = sSQL + "ANE_APS_ID = " + ANE_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_APS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "ANE_MAQ_TIP_ID = " + ANE_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_ID.ToString()))
            {
                sSQL = sSQL + "ANE_ERT_ID = " + ANE_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ERT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_CON.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_CON = " + ANE_TIT_CON.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_CON = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MED.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_MED = " + ANE_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MED.ToString()))
            {
                sSQL = sSQL + "ANE_TNC_MED = " + ANE_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TNC_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MED.ToString()))
            {
                sSQL = sSQL + "ANE_AON_MED = " + ANE_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_AON_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MED.ToString()))
            {
                sSQL = sSQL + "ANE_ENM_MED = " + ANE_ENM_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ENM_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MED.ToString()))
            {
                sSQL = sSQL + "ANE_EEE_MED = " + ANE_EEE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_EEE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MED.ToString()))
            {
                sSQL = sSQL + "ANE_KKK_MED = " + ANE_KKK_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_KKK_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MED.ToString()))
            {
                sSQL = sSQL + "ANE_BBB_MED = " + ANE_BBB_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_BBB_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MED.ToString()))
            {
                sSQL = sSQL + "ANE_PUE_MED = " + ANE_PUE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PUE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MED.ToString()))
            {
                sSQL = sSQL + "ANE_OLE_MED = " + ANE_OLE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_OLE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MED.ToString()))
            {
                sSQL = sSQL + "ANE_TRQ_MED = " + ANE_TRQ_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TRQ_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MED.ToString()))
            {
                sSQL = sSQL + "ANE_ERT_MED = " + ANE_ERT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ERT_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MED.ToString()))
            {
                sSQL = sSQL + "ANE_RT3_MED = " + ANE_RT3_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT3_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MED.ToString()))
            {
                sSQL = sSQL + "ANE_RT5_MED = " + ANE_RT5_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT5_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MED.ToString()))
            {
                sSQL = sSQL + "ANE_PES_MED = " + ANE_PES_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PES_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MED.ToString()))
            {
                sSQL = sSQL + "ANE_DMO_MED = " + ANE_DMO_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DMO_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MED.ToString()))
            {
                sSQL = sSQL + "ANE_DND_MED = " + ANE_DND_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DND_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_TLR = " + ANE_TIT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_TNC_TLR = " + ANE_TNC_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TNC_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_AON_TLR = " + ANE_AON_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_AON_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_ENM_TLR = " + ANE_ENM_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ENM_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_EEE_TLR = " + ANE_EEE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_EEE_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_KKK_TLR = " + ANE_KKK_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_KKK_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_BBB_TLR = " + ANE_BBB_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_BBB_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_PUE_TLR = " + ANE_PUE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PUE_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_OLE_TLR = " + ANE_OLE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_OLE_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_TRQ_TLR = " + ANE_TRQ_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TRQ_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_ERT_TLR = " + ANE_ERT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ERT_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_RT3_TLR = " + ANE_RT3_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT3_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_RT5_TLR = " + ANE_RT5_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT5_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_PES_TLR = " + ANE_PES_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PES_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_DMO_TLR = " + ANE_DMO_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DMO_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_TLR.ToString()))
            {
                sSQL = sSQL + "ANE_DND_TLR = " + ANE_DND_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DND_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_MIN = " + ANE_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_TNC_MIN = " + ANE_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TNC_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_AON_MIN = " + ANE_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_AON_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_ENM_MIN = " + ANE_ENM_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ENM_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_EEE_MIN = " + ANE_EEE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_EEE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_KKK_MIN = " + ANE_KKK_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_KKK_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_BBB_MIN = " + ANE_BBB_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_BBB_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_PUE_MIN = " + ANE_PUE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PUE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_OLE_MIN = " + ANE_OLE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_OLE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_TRQ_MIN = " + ANE_TRQ_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TRQ_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_ERT_MIN = " + ANE_ERT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ERT_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_RT3_MIN = " + ANE_RT3_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT3_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_RT5_MIN = " + ANE_RT5_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT5_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_PES_MIN = " + ANE_PES_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PES_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_DMO_MIN = " + ANE_DMO_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DMO_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_DND_MIN = " + ANE_DND_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DND_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TIT_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_TIT_MAX = " + ANE_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TIT_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TNC_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_TNC_MAX = " + ANE_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TNC_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_AON_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_AON_MAX = " + ANE_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_AON_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ENM_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_ENM_MAX = " + ANE_ENM_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ENM_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_EEE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_EEE_MAX = " + ANE_EEE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_EEE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_KKK_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_KKK_MAX = " + ANE_KKK_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_KKK_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_BBB_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_BBB_MAX = " + ANE_BBB_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_BBB_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PUE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_PUE_MAX = " + ANE_PUE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PUE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OLE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_OLE_MAX = " + ANE_OLE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_OLE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_TRQ_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_TRQ_MAX = " + ANE_TRQ_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_TRQ_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_ERT_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_ERT_MAX = " + ANE_ERT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_ERT_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT3_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_RT3_MAX = " + ANE_RT3_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT3_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_RT5_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_RT5_MAX = " + ANE_RT5_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_RT5_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_PES_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_PES_MAX = " + ANE_PES_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_PES_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DMO_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_DMO_MAX = " + ANE_DMO_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DMO_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_DND_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_DND_MAX = " + ANE_DND_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_DND_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_OBS))
            {
                sSQL = sSQL + "ANE_OBS = '" + ANE_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANE_OBS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_STS.ToString()))
            {
                sSQL = sSQL + "ANE_STS = " + ANE_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ANE_USR_ALT_ID = " + ANE_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ANE_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE ANE_ID = " + ANE_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ANE";
            sSQL = sSQL + " WHERE ANE_ID = " + ANE_ID;

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
            sSQL = sSQL + " FROM ANE";
            sSQL = sSQL + " INNER JOIN TIT_POY ON TIT_POY_ID = ANE_TIT_POY_ID";
            sSQL = sSQL + " INNER JOIN APS ON APS_ID = ANE_APS_ID";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = ANE_MAQ_TIP_ID";
            sSQL = sSQL + " INNER JOIN ERT ON ERT_ID = ANE_ERT_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_ID)))
            {
                sCond = sCond + " ANE_ID = " + ANE_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_DAT)))
            {
                sCond = sCond + " ANE_DAT BETWEEN Convert(datetime, '" + ANE_DAT + "',103) AND Convert(datetime, '" + ANE_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_DAT_INI)))
            {
                sCond = sCond + " ANE_DAT >= Convert(datetime, '" + ANE_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_DAT_FIM)))
            {
                sCond = sCond + " ANE_DAT <= Convert(datetime, '" + ANE_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT))
            {
                sCond = sCond + " ANE_LOT = '" + ANE_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(ANE_LOT_REF))
            {
                sCond = sCond + " ANE_LOT_REF = '" + ANE_LOT_REF + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_TIT_POY_ID)))
            {
                sCond = sCond + " ANE_TIT_POY_ID = " + ANE_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_APS_ID)))
            {
                sCond = sCond + " ANE_APS_ID = " + ANE_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_MAQ_TIP_ID)))
            {
                sCond = sCond + " ANE_MAQ_TIP_ID = " + ANE_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_ERT_ID)))
            {
                sCond = sCond + " ANE_ERT_ID = " + ANE_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_STS)))
            {
                sCond = sCond + " ANE_STS = " + ANE_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ANE_DAT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}