using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class EspecificacaoLimite
    {

        #region Propriedades

        private int? _ANE_LMT_ID;
        private double? _ANE_LMT_TIT_MIN;
        private double? _ANE_LMT_TNC_MIN;
        private double? _ANE_LMT_AON_MIN;
        private double? _ANE_LMT_ENM_MIN;
        private double? _ANE_LMT_EEE_MIN;
        private double? _ANE_LMT_KKK_MIN;
        private double? _ANE_LMT_BBB_MIN;
        private double? _ANE_LMT_PUE_MIN;
        private double? _ANE_LMT_OLE_MIN;
        private double? _ANE_LMT_TRQ_MIN;
        private double? _ANE_LMT_ERT_MIN;
        private double? _ANE_LMT_RT3_MIN;
        private double? _ANE_LMT_RT5_MIN;
        private double? _ANE_LMT_PES_MIN;
        private double? _ANE_LMT_DMO_MIN;
        private double? _ANE_LMT_DND_MIN;
        private double? _ANE_LMT_TIT_MAX;
        private double? _ANE_LMT_TNC_MAX;
        private double? _ANE_LMT_AON_MAX;
        private double? _ANE_LMT_ENM_MAX;
        private double? _ANE_LMT_EEE_MAX;
        private double? _ANE_LMT_KKK_MAX;
        private double? _ANE_LMT_BBB_MAX;
        private double? _ANE_LMT_PUE_MAX;
        private double? _ANE_LMT_OLE_MAX;
        private double? _ANE_LMT_TRQ_MAX;
        private double? _ANE_LMT_ERT_MAX;
        private double? _ANE_LMT_RT3_MAX;
        private double? _ANE_LMT_RT5_MAX;
        private double? _ANE_LMT_PES_MAX;
        private double? _ANE_LMT_DMO_MAX;
        private double? _ANE_LMT_DND_MAX;
        private int? _ANE_LMT_STS;
        private int? _ANE_LMT_USR_INC_ID;
        private int? _ANE_LMT_USR_ALT_ID;
        private DateTime? _ANE_LMT_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? ANE_LMT_ID
        {
            get { return _ANE_LMT_ID; }
            set { _ANE_LMT_ID = value; }
        }
        public double? ANE_LMT_TIT_MIN
        {
            get { return _ANE_LMT_TIT_MIN; }
            set { _ANE_LMT_TIT_MIN = value; }
        }
        public double? ANE_LMT_TNC_MIN
        {
            get { return _ANE_LMT_TNC_MIN; }
            set { _ANE_LMT_TNC_MIN = value; }
        }
        public double? ANE_LMT_AON_MIN
        {
            get { return _ANE_LMT_AON_MIN; }
            set { _ANE_LMT_AON_MIN = value; }
        }
        public double? ANE_LMT_ENM_MIN
        {
            get { return _ANE_LMT_ENM_MIN; }
            set { _ANE_LMT_ENM_MIN = value; }
        }
        public double? ANE_LMT_EEE_MIN
        {
            get { return _ANE_LMT_EEE_MIN; }
            set { _ANE_LMT_EEE_MIN = value; }
        }
        public double? ANE_LMT_KKK_MIN
        {
            get { return _ANE_LMT_KKK_MIN; }
            set { _ANE_LMT_KKK_MIN = value; }
        }
        public double? ANE_LMT_BBB_MIN
        {
            get { return _ANE_LMT_BBB_MIN; }
            set { _ANE_LMT_BBB_MIN = value; }
        }
        public double? ANE_LMT_PUE_MIN
        {
            get { return _ANE_LMT_PUE_MIN; }
            set { _ANE_LMT_PUE_MIN = value; }
        }
        public double? ANE_LMT_OLE_MIN
        {
            get { return _ANE_LMT_OLE_MIN; }
            set { _ANE_LMT_OLE_MIN = value; }
        }
        public double? ANE_LMT_TRQ_MIN
        {
            get { return _ANE_LMT_TRQ_MIN; }
            set { _ANE_LMT_TRQ_MIN = value; }
        }
        public double? ANE_LMT_ERT_MIN
        {
            get { return _ANE_LMT_ERT_MIN; }
            set { _ANE_LMT_ERT_MIN = value; }
        }
        public double? ANE_LMT_RT3_MIN
        {
            get { return _ANE_LMT_RT3_MIN; }
            set { _ANE_LMT_RT3_MIN = value; }
        }
        public double? ANE_LMT_RT5_MIN
        {
            get { return _ANE_LMT_RT5_MIN; }
            set { _ANE_LMT_RT5_MIN = value; }
        }
        public double? ANE_LMT_PES_MIN
        {
            get { return _ANE_LMT_PES_MIN; }
            set { _ANE_LMT_PES_MIN = value; }
        }
        public double? ANE_LMT_DMO_MIN
        {
            get { return _ANE_LMT_DMO_MIN; }
            set { _ANE_LMT_DMO_MIN = value; }
        }
        public double? ANE_LMT_DND_MIN
        {
            get { return _ANE_LMT_DND_MIN; }
            set { _ANE_LMT_DND_MIN = value; }
        }
        public double? ANE_LMT_TIT_MAX
        {
            get { return _ANE_LMT_TIT_MAX; }
            set { _ANE_LMT_TIT_MAX = value; }
        }
        public double? ANE_LMT_TNC_MAX
        {
            get { return _ANE_LMT_TNC_MAX; }
            set { _ANE_LMT_TNC_MAX = value; }
        }
        public double? ANE_LMT_AON_MAX
        {
            get { return _ANE_LMT_AON_MAX; }
            set { _ANE_LMT_AON_MAX = value; }
        }
        public double? ANE_LMT_ENM_MAX
        {
            get { return _ANE_LMT_ENM_MAX; }
            set { _ANE_LMT_ENM_MAX = value; }
        }
        public double? ANE_LMT_EEE_MAX
        {
            get { return _ANE_LMT_EEE_MAX; }
            set { _ANE_LMT_EEE_MAX = value; }
        }
        public double? ANE_LMT_KKK_MAX
        {
            get { return _ANE_LMT_KKK_MAX; }
            set { _ANE_LMT_KKK_MAX = value; }
        }
        public double? ANE_LMT_BBB_MAX
        {
            get { return _ANE_LMT_BBB_MAX; }
            set { _ANE_LMT_BBB_MAX = value; }
        }
        public double? ANE_LMT_PUE_MAX
        {
            get { return _ANE_LMT_PUE_MAX; }
            set { _ANE_LMT_PUE_MAX = value; }
        }
        public double? ANE_LMT_OLE_MAX
        {
            get { return _ANE_LMT_OLE_MAX; }
            set { _ANE_LMT_OLE_MAX = value; }
        }
        public double? ANE_LMT_TRQ_MAX
        {
            get { return _ANE_LMT_TRQ_MAX; }
            set { _ANE_LMT_TRQ_MAX = value; }
        }
        public double? ANE_LMT_ERT_MAX
        {
            get { return _ANE_LMT_ERT_MAX; }
            set { _ANE_LMT_ERT_MAX = value; }
        }
        public double? ANE_LMT_RT3_MAX
        {
            get { return _ANE_LMT_RT3_MAX; }
            set { _ANE_LMT_RT3_MAX = value; }
        }
        public double? ANE_LMT_RT5_MAX
        {
            get { return _ANE_LMT_RT5_MAX; }
            set { _ANE_LMT_RT5_MAX = value; }
        }
        public double? ANE_LMT_PES_MAX
        {
            get { return _ANE_LMT_PES_MAX; }
            set { _ANE_LMT_PES_MAX = value; }
        }
        public double? ANE_LMT_DMO_MAX
        {
            get { return _ANE_LMT_DMO_MAX; }
            set { _ANE_LMT_DMO_MAX = value; }
        }
        public double? ANE_LMT_DND_MAX
        {
            get { return _ANE_LMT_DND_MAX; }
            set { _ANE_LMT_DND_MAX = value; }
        }
        public int? ANE_LMT_STS
        {
            get { return _ANE_LMT_STS; }
            set { _ANE_LMT_STS = value; }
        }
        public int? ANE_LMT_USR_INC_ID
        {
            get { return _ANE_LMT_USR_INC_ID; }
            set { _ANE_LMT_USR_INC_ID = value; }
        }
        public int? ANE_LMT_USR_ALT_ID
        {
            get { return _ANE_LMT_USR_ALT_ID; }
            set { _ANE_LMT_USR_ALT_ID = value; }
        }
        public DateTime? ANE_LMT_TMS_ATL
        {
            get { return _ANE_LMT_TMS_ATL; }
            set { _ANE_LMT_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO ANE_LMT (";
            sSQL = sSQL + "ANE_LMT_TIT_MIN, ";
            sSQL = sSQL + "ANE_LMT_TNC_MIN, ";
            sSQL = sSQL + "ANE_LMT_AON_MIN, ";
            sSQL = sSQL + "ANE_LMT_ENM_MIN, ";
            sSQL = sSQL + "ANE_LMT_EEE_MIN, ";
            sSQL = sSQL + "ANE_LMT_KKK_MIN, ";
            sSQL = sSQL + "ANE_LMT_BBB_MIN, ";
            sSQL = sSQL + "ANE_LMT_PUE_MIN, ";
            sSQL = sSQL + "ANE_LMT_OLE_MIN, ";
            sSQL = sSQL + "ANE_LMT_TRQ_MIN, ";
            sSQL = sSQL + "ANE_LMT_ERT_MIN, ";
            sSQL = sSQL + "ANE_LMT_RT3_MIN, ";
            sSQL = sSQL + "ANE_LMT_RT5_MIN, ";
            sSQL = sSQL + "ANE_LMT_PES_MIN, ";
            sSQL = sSQL + "ANE_LMT_DMO_MIN, ";
            sSQL = sSQL + "ANE_LMT_DND_MIN, ";
            sSQL = sSQL + "ANE_LMT_TIT_MAX, ";
            sSQL = sSQL + "ANE_LMT_TNC_MAX, ";
            sSQL = sSQL + "ANE_LMT_AON_MAX, ";
            sSQL = sSQL + "ANE_LMT_ENM_MAX, ";
            sSQL = sSQL + "ANE_LMT_EEE_MAX, ";
            sSQL = sSQL + "ANE_LMT_KKK_MAX, ";
            sSQL = sSQL + "ANE_LMT_BBB_MAX, ";
            sSQL = sSQL + "ANE_LMT_PUE_MAX, ";
            sSQL = sSQL + "ANE_LMT_OLE_MAX, ";
            sSQL = sSQL + "ANE_LMT_TRQ_MAX, ";
            sSQL = sSQL + "ANE_LMT_ERT_MAX, ";
            sSQL = sSQL + "ANE_LMT_RT3_MAX, ";
            sSQL = sSQL + "ANE_LMT_RT5_MAX, ";
            sSQL = sSQL + "ANE_LMT_PES_MAX, ";
            sSQL = sSQL + "ANE_LMT_DMO_MAX, ";
            sSQL = sSQL + "ANE_LMT_DND_MAX, ";
            sSQL = sSQL + "ANE_LMT_STS, ";
            sSQL = sSQL + "ANE_LMT_USR_INC_ID, ";
            sSQL = sSQL + "ANE_LMT_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ANE_LMT_TIT_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TNC_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_AON_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ENM_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_ENM_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_EEE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_EEE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_KKK_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_KKK_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_BBB_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_BBB_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PUE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_PUE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_OLE_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_OLE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TRQ_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TRQ_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ERT_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_ERT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT3_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_RT3_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT5_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_RT5_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PES_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_PES_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DMO_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_DMO_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DND_MIN.ToString()))
            {
                sSQL = sSQL + ANE_LMT_DND_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TIT_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TNC_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_AON_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ENM_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_ENM_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_EEE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_EEE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_KKK_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_KKK_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_BBB_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_BBB_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PUE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_PUE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_OLE_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_OLE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TRQ_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_TRQ_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ERT_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_ERT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT3_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_RT3_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT5_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_RT5_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PES_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_PES_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DMO_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_DMO_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DND_MAX.ToString()))
            {
                sSQL = sSQL + ANE_LMT_DND_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_STS.ToString()))
            {
                sSQL = sSQL + ANE_LMT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ANE_LMT_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ANE_LMT ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ANE_LMT_TIT_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TIT_MIN = " + ANE_LMT_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TIT_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TNC_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TNC_MIN = " + ANE_LMT_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TNC_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_AON_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_AON_MIN = " + ANE_LMT_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_AON_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ENM_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_ENM_MIN = " + ANE_LMT_ENM_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_ENM_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_EEE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_EEE_MIN = " + ANE_LMT_EEE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_EEE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_KKK_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_KKK_MIN = " + ANE_LMT_KKK_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_KKK_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_BBB_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_BBB_MIN = " + ANE_LMT_BBB_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_BBB_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PUE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_PUE_MIN = " + ANE_LMT_PUE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_PUE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_OLE_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_OLE_MIN = " + ANE_LMT_OLE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_OLE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TRQ_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TRQ_MIN = " + ANE_LMT_TRQ_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TRQ_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ERT_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_ERT_MIN = " + ANE_LMT_ERT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_ERT_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT3_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_RT3_MIN = " + ANE_LMT_RT3_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_RT3_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT5_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_RT5_MIN = " + ANE_LMT_RT5_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_RT5_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PES_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_PES_MIN = " + ANE_LMT_PES_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_PES_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DMO_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_DMO_MIN = " + ANE_LMT_DMO_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_DMO_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DND_MIN.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_DND_MIN = " + ANE_LMT_DND_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_DND_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TIT_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TIT_MAX = " + ANE_LMT_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TIT_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TNC_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TNC_MAX = " + ANE_LMT_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TNC_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_AON_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_AON_MAX = " + ANE_LMT_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_AON_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ENM_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_ENM_MAX = " + ANE_LMT_ENM_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_ENM_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_EEE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_EEE_MAX = " + ANE_LMT_EEE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_EEE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_KKK_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_KKK_MAX = " + ANE_LMT_KKK_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_KKK_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_BBB_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_BBB_MAX = " + ANE_LMT_BBB_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_BBB_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PUE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_PUE_MAX = " + ANE_LMT_PUE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_PUE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_OLE_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_OLE_MAX = " + ANE_LMT_OLE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_OLE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_TRQ_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_TRQ_MAX = " + ANE_LMT_TRQ_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_TRQ_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_ERT_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_ERT_MAX = " + ANE_LMT_ERT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_ERT_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT3_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_RT3_MAX = " + ANE_LMT_RT3_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_RT3_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_RT5_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_RT5_MAX = " + ANE_LMT_RT5_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_RT5_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_PES_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_PES_MAX = " + ANE_LMT_PES_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_PES_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DMO_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_DMO_MAX = " + ANE_LMT_DMO_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_DMO_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_DND_MAX.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_DND_MAX = " + ANE_LMT_DND_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_DND_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_STS.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_STS = " + ANE_LMT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANE_LMT_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ANE_LMT_USR_ALT_ID = " + ANE_LMT_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANE_LMT_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ANE_LMT_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE ANE_LMT_ID = " + ANE_LMT_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ANE_LMT";
            sSQL = sSQL + " WHERE ANE_LMT_ID = " + ANE_LMT_ID;

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
            sSQL = sSQL + " FROM ANE_LMT";
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_LMT_ID)))
            {
                sCond = sCond + " ANE_LMT_ID = " + ANE_LMT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANE_LMT_STS)))
            {
                sCond = sCond + " ANE_LMT_STS = " + ANE_LMT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ANE_LMT_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}