using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class EspecificacaoDynafil
    {

        #region Propriedades

        private int? _EDF_ID;
        private string _EDF_MGE;
        private int? _EDF_FOR_ID;
        private int? _EDF_TIT_POY_ID;
        private string _EDF_VLC;
        private DateTime? _EDF_DAT;
        private double? _EDF_TIT_MED;
        private double? _EDF_TNC_MED;
        private double? _EDF_AON_MED;
        private double? _EDF_EVE_MED;
        private double? _EDF_QBR_MED;
        private double? _EDF_FOA_MED;
        private double? _EDF_CVF_MED;
        private double? _EDF_TIT_TLR;
        private double? _EDF_TNC_TLR;
        private double? _EDF_AON_TLR;
        private double? _EDF_EVE_TLR;
        private double? _EDF_QBR_TLR;
        private double? _EDF_FOA_TLR;
        private double? _EDF_CVF_TLR;
        private double? _EDF_TIT_MIN;
        private double? _EDF_TNC_MIN;
        private double? _EDF_AON_MIN;
        private double? _EDF_EVE_MIN;
        private double? _EDF_QBR_MIN;
        private double? _EDF_FOA_MIN;
        private double? _EDF_CVF_MIN;
        private double? _EDF_TIT_MAX;
        private double? _EDF_TNC_MAX;
        private double? _EDF_AON_MAX;
        private double? _EDF_EVE_MAX;
        private double? _EDF_QBR_MAX;
        private double? _EDF_FOA_MAX;
        private double? _EDF_CVF_MAX;
        private string _EDF_OBS;
        private int? _EDF_STS;
        private int? _EDF_USR_INC_ID;
        private int? _EDF_USR_ALT_ID;
        private DateTime? _EDF_TMS_ATL;

        private DateTime? _EDF_DAT_TIT_POY_INI;
        private DateTime? _EDF_DAT_TIT_POY_FIM;
        private DateTime? _EDF_DAT_INI;
        private DateTime? _EDF_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? EDF_ID
        {
            get { return _EDF_ID; }
            set { _EDF_ID = value; }
        }
        public string EDF_MGE
        {
            get { return _EDF_MGE; }
            set { _EDF_MGE = value.ToUpper(); }
        }
        public int? EDF_FOR_ID
        {
            get { return _EDF_FOR_ID; }
            set { _EDF_FOR_ID = value; }
        }
        public int? EDF_TIT_POY_ID
        {
            get { return _EDF_TIT_POY_ID; }
            set { _EDF_TIT_POY_ID = value; }
        }
        public string EDF_VLC
        {
            get { return _EDF_VLC; }
            set { _EDF_VLC = value.ToUpper(); }
        }
        public DateTime? EDF_DAT
        {
            get { return _EDF_DAT; }
            set { _EDF_DAT = value; }
        }
        public double? EDF_TIT_MED
        {
            get { return _EDF_TIT_MED; }
            set { _EDF_TIT_MED = value; }
        }
        public double? EDF_TNC_MED
        {
            get { return _EDF_TNC_MED; }
            set { _EDF_TNC_MED = value; }
        }
        public double? EDF_AON_MED
        {
            get { return _EDF_AON_MED; }
            set { _EDF_AON_MED = value; }
        }
        public double? EDF_EVE_MED
        {
            get { return _EDF_EVE_MED; }
            set { _EDF_EVE_MED = value; }
        }
        public double? EDF_QBR_MED
        {
            get { return _EDF_QBR_MED; }
            set { _EDF_QBR_MED = value; }
        }
        public double? EDF_FOA_MED
        {
            get { return _EDF_FOA_MED; }
            set { _EDF_FOA_MED = value; }
        }
        public double? EDF_CVF_MED
        {
            get { return _EDF_CVF_MED; }
            set { _EDF_CVF_MED = value; }
        }
        public double? EDF_TIT_TLR
        {
            get { return _EDF_TIT_TLR; }
            set { _EDF_TIT_TLR = value; }
        }
        public double? EDF_TNC_TLR
        {
            get { return _EDF_TNC_TLR; }
            set { _EDF_TNC_TLR = value; }
        }
        public double? EDF_AON_TLR
        {
            get { return _EDF_AON_TLR; }
            set { _EDF_AON_TLR = value; }
        }
        public double? EDF_EVE_TLR
        {
            get { return _EDF_EVE_TLR; }
            set { _EDF_EVE_TLR = value; }
        }
        public double? EDF_QBR_TLR
        {
            get { return _EDF_QBR_TLR; }
            set { _EDF_QBR_TLR = value; }
        }
        public double? EDF_FOA_TLR
        {
            get { return _EDF_FOA_TLR; }
            set { _EDF_FOA_TLR = value; }
        }
        public double? EDF_CVF_TLR
        {
            get { return _EDF_CVF_TLR; }
            set { _EDF_CVF_TLR = value; }
        }
        public double? EDF_TIT_MIN
        {
            get { return _EDF_TIT_MIN; }
            set { _EDF_TIT_MIN = value; }
        }
        public double? EDF_TNC_MIN
        {
            get { return _EDF_TNC_MIN; }
            set { _EDF_TNC_MIN = value; }
        }
        public double? EDF_AON_MIN
        {
            get { return _EDF_AON_MIN; }
            set { _EDF_AON_MIN = value; }
        }
        public double? EDF_EVE_MIN
        {
            get { return _EDF_EVE_MIN; }
            set { _EDF_EVE_MIN = value; }
        }
        public double? EDF_QBR_MIN
        {
            get { return _EDF_QBR_MIN; }
            set { _EDF_QBR_MIN = value; }
        }
        public double? EDF_FOA_MIN
        {
            get { return _EDF_FOA_MIN; }
            set { _EDF_FOA_MIN = value; }
        }
        public double? EDF_CVF_MIN
        {
            get { return _EDF_CVF_MIN; }
            set { _EDF_CVF_MIN = value; }
        }
        public double? EDF_TIT_MAX
        {
            get { return _EDF_TIT_MAX; }
            set { _EDF_TIT_MAX = value; }
        }
        public double? EDF_TNC_MAX
        {
            get { return _EDF_TNC_MAX; }
            set { _EDF_TNC_MAX = value; }
        }
        public double? EDF_AON_MAX
        {
            get { return _EDF_AON_MAX; }
            set { _EDF_AON_MAX = value; }
        }
        public double? EDF_EVE_MAX
        {
            get { return _EDF_EVE_MAX; }
            set { _EDF_EVE_MAX = value; }
        }
        public double? EDF_QBR_MAX
        {
            get { return _EDF_QBR_MAX; }
            set { _EDF_QBR_MAX = value; }
        }
        public double? EDF_FOA_MAX
        {
            get { return _EDF_FOA_MAX; }
            set { _EDF_FOA_MAX = value; }
        }
        public double? EDF_CVF_MAX
        {
            get { return _EDF_CVF_MAX; }
            set { _EDF_CVF_MAX = value; }
        }
        public string EDF_OBS
        {
            get { return _EDF_OBS; }
            set { _EDF_OBS = value.ToUpper(); }
        }
        public int? EDF_STS
        {
            get { return _EDF_STS; }
            set { _EDF_STS = value; }
        }
        public int? EDF_USR_INC_ID
        {
            get { return _EDF_USR_INC_ID; }
            set { _EDF_USR_INC_ID = value; }
        }
        public int? EDF_USR_ALT_ID
        {
            get { return _EDF_USR_ALT_ID; }
            set { _EDF_USR_ALT_ID = value; }
        }
        public DateTime? EDF_TMS_ATL
        {
            get { return _EDF_TMS_ATL; }
            set { _EDF_TMS_ATL = value; }
        }

        public DateTime? EDF_DAT_TIT_POY_INI
        {
            get { return _EDF_DAT_TIT_POY_INI; }
            set { _EDF_DAT_TIT_POY_INI = value; }
        }

        public DateTime? EDF_DAT_TIT_POY_FIM
        {
            get { return _EDF_DAT_TIT_POY_FIM; }
            set { _EDF_DAT_TIT_POY_FIM = value; }
        }
        public DateTime? EDF_DAT_INI
        {
            get { return _EDF_DAT_INI; }
            set { _EDF_DAT_INI = value; }
        }

        public DateTime? EDF_DAT_FIM
        {
            get { return _EDF_DAT_FIM; }
            set { _EDF_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO EDF (";
            sSQL = sSQL + "EDF_MGE, ";
            sSQL = sSQL + "EDF_FOR_ID, ";
            sSQL = sSQL + "EDF_TIT_POY_ID, ";
            sSQL = sSQL + "EDF_VLC, ";
            sSQL = sSQL + "EDF_DAT, ";
            sSQL = sSQL + "EDF_TIT_MED, ";
            sSQL = sSQL + "EDF_TNC_MED, ";
            sSQL = sSQL + "EDF_AON_MED, ";
            sSQL = sSQL + "EDF_EVE_MED, ";
            sSQL = sSQL + "EDF_QBR_MED, ";
            sSQL = sSQL + "EDF_FOA_MED, ";
            sSQL = sSQL + "EDF_CVF_MED, ";
            sSQL = sSQL + "EDF_TIT_TLR, ";
            sSQL = sSQL + "EDF_TNC_TLR, ";
            sSQL = sSQL + "EDF_AON_TLR, ";
            sSQL = sSQL + "EDF_EVE_TLR, ";
            sSQL = sSQL + "EDF_QBR_TLR, ";
            sSQL = sSQL + "EDF_FOA_TLR, ";
            sSQL = sSQL + "EDF_CVF_TLR, ";
            sSQL = sSQL + "EDF_TIT_MIN, ";
            sSQL = sSQL + "EDF_TNC_MIN, ";
            sSQL = sSQL + "EDF_AON_MIN, ";
            sSQL = sSQL + "EDF_EVE_MIN, ";
            sSQL = sSQL + "EDF_QBR_MIN, ";
            sSQL = sSQL + "EDF_FOA_MIN, ";
            sSQL = sSQL + "EDF_CVF_MIN, ";
            sSQL = sSQL + "EDF_TIT_MAX, ";
            sSQL = sSQL + "EDF_TNC_MAX, ";
            sSQL = sSQL + "EDF_AON_MAX, ";
            sSQL = sSQL + "EDF_EVE_MAX, ";
            sSQL = sSQL + "EDF_QBR_MAX, ";
            sSQL = sSQL + "EDF_FOA_MAX, ";
            sSQL = sSQL + "EDF_CVF_MAX, ";
            sSQL = sSQL + "EDF_OBS, ";
            sSQL = sSQL + "EDF_STS, ";
            sSQL = sSQL + "EDF_USR_INC_ID, ";
            sSQL = sSQL + "EDF_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(EDF_MGE))
            {
                sSQL = sSQL + "'" + EDF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOR_ID.ToString()))
            {
                sSQL = sSQL + EDF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + EDF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_VLC))
            {
                sSQL = sSQL + "'" + EDF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + EDF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MED.ToString()))
            {
                sSQL = sSQL + EDF_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MED.ToString()))
            {
                sSQL = sSQL + EDF_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MED.ToString()))
            {
                sSQL = sSQL + EDF_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MED.ToString()))
            {
                sSQL = sSQL + EDF_EVE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MED.ToString()))
            {
                sSQL = sSQL + EDF_QBR_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MED.ToString()))
            {
                sSQL = sSQL + EDF_FOA_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MED.ToString()))
            {
                sSQL = sSQL + EDF_CVF_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_TLR.ToString()))
            {
                sSQL = sSQL + EDF_TIT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_TLR.ToString()))
            {
                sSQL = sSQL + EDF_TNC_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_TLR.ToString()))
            {
                sSQL = sSQL + EDF_AON_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_TLR.ToString()))
            {
                sSQL = sSQL + EDF_EVE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_TLR.ToString()))
            {
                sSQL = sSQL + EDF_QBR_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_TLR.ToString()))
            {
                sSQL = sSQL + EDF_FOA_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_TLR.ToString()))
            {
                sSQL = sSQL + EDF_CVF_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MIN.ToString()))
            {
                sSQL = sSQL + EDF_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MIN.ToString()))
            {
                sSQL = sSQL + EDF_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MIN.ToString()))
            {
                sSQL = sSQL + EDF_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MIN.ToString()))
            {
                sSQL = sSQL + EDF_EVE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MIN.ToString()))
            {
                sSQL = sSQL + EDF_QBR_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MIN.ToString()))
            {
                sSQL = sSQL + EDF_FOA_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MIN.ToString()))
            {
                sSQL = sSQL + EDF_CVF_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MAX.ToString()))
            {
                sSQL = sSQL + EDF_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MAX.ToString()))
            {
                sSQL = sSQL + EDF_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MAX.ToString()))
            {
                sSQL = sSQL + EDF_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MAX.ToString()))
            {
                sSQL = sSQL + EDF_EVE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MAX.ToString()))
            {
                sSQL = sSQL + EDF_QBR_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MAX.ToString()))
            {
                sSQL = sSQL + EDF_FOA_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MAX.ToString()))
            {
                sSQL = sSQL + EDF_CVF_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_OBS))
            {
                sSQL = sSQL + "'" + EDF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_STS.ToString()))
            {
                sSQL = sSQL + EDF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + EDF_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE EDF ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(EDF_MGE))
            {
                sSQL = sSQL + "EDF_MGE = '" + EDF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EDF_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOR_ID.ToString()))
            {
                sSQL = sSQL + "EDF_FOR_ID = " + EDF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_FOR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "EDF_TIT_POY_ID = " + EDF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_VLC))
            {
                sSQL = sSQL + "EDF_VLC = '" + EDF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EDF_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_DAT.ToString()))
            {
                sSQL = sSQL + "EDF_DAT = Convert(datetime, '" + EDF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "EDF_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MED.ToString()))
            {
                sSQL = sSQL + "EDF_TIT_MED = " + EDF_TIT_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TIT_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MED.ToString()))
            {
                sSQL = sSQL + "EDF_TNC_MED = " + EDF_TNC_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TNC_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MED.ToString()))
            {
                sSQL = sSQL + "EDF_AON_MED = " + EDF_AON_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_AON_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MED.ToString()))
            {
                sSQL = sSQL + "EDF_EVE_MED = " + EDF_EVE_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_EVE_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MED.ToString()))
            {
                sSQL = sSQL + "EDF_QBR_MED = " + EDF_QBR_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_QBR_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MED.ToString()))
            {
                sSQL = sSQL + "EDF_FOA_MED = " + EDF_FOA_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_FOA_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MED.ToString()))
            {
                sSQL = sSQL + "EDF_CVF_MED = " + EDF_CVF_MED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_CVF_MED = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_TIT_TLR = " + EDF_TIT_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TIT_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_TNC_TLR = " + EDF_TNC_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TNC_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_AON_TLR = " + EDF_AON_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_AON_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_EVE_TLR = " + EDF_EVE_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_EVE_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_QBR_TLR = " + EDF_QBR_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_QBR_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_FOA_TLR = " + EDF_FOA_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_FOA_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_TLR.ToString()))
            {
                sSQL = sSQL + "EDF_CVF_TLR = " + EDF_CVF_TLR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_CVF_TLR = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_TIT_MIN = " + EDF_TIT_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TIT_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_TNC_MIN = " + EDF_TNC_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TNC_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_AON_MIN = " + EDF_AON_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_AON_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_EVE_MIN = " + EDF_EVE_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_EVE_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_QBR_MIN = " + EDF_QBR_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_QBR_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_FOA_MIN = " + EDF_FOA_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_FOA_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MIN.ToString()))
            {
                sSQL = sSQL + "EDF_CVF_MIN = " + EDF_CVF_MIN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_CVF_MIN = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TIT_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_TIT_MAX = " + EDF_TIT_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TIT_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_TNC_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_TNC_MAX = " + EDF_TNC_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_TNC_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_AON_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_AON_MAX = " + EDF_AON_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_AON_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_EVE_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_EVE_MAX = " + EDF_EVE_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_EVE_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_QBR_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_QBR_MAX = " + EDF_QBR_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_QBR_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_FOA_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_FOA_MAX = " + EDF_FOA_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_FOA_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_CVF_MAX.ToString()))
            {
                sSQL = sSQL + "EDF_CVF_MAX = " + EDF_CVF_MAX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_CVF_MAX = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_OBS))
            {
                sSQL = sSQL + "EDF_OBS = '" + EDF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "EDF_OBS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_STS.ToString()))
            {
                sSQL = sSQL + "EDF_STS = " + EDF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(EDF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "EDF_USR_ALT_ID = " + EDF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "EDF_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "EDF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE EDF_ID = " + EDF_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM EDF";
            sSQL = sSQL + " WHERE EDF_ID = " + EDF_ID;

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
            sSQL = sSQL + " FROM EDF";
            sSQL = sSQL + " LEFT JOIN [FOR] ON FOR_ID = EDF_FOR_ID";
            sSQL = sSQL + " LEFT JOIN [TIT_POY] ON TIT_POY_ID = EDF_TIT_POY_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_ID)))
            {
                sCond = sCond + " EDF_ID = " + EDF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EDF_MGE))
            {
                sCond = sCond + " EDF_MGE = '" + EDF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_FOR_ID)))
            {
                sCond = sCond + " EDF_FOR_ID = " + EDF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_TIT_POY_ID)))
            {
                sCond = sCond + " EDF_TIT_POY_ID = " + EDF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(EDF_VLC))
            {
                sCond = sCond + " EDF_VLC = '" + EDF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_DAT)))
            {
                sCond = sCond + " EDF_DAT BETWEEN Convert(datetime, '" + EDF_DAT + "',103) AND Convert(datetime, '" + EDF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_DAT_INI)))
            {
                sCond = sCond + " EDF_DAT >= Convert(datetime, '" + EDF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_DAT_FIM)))
            {
                sCond = sCond + " EDF_DAT <= Convert(datetime, '" + EDF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(EDF_STS)))
            {
                sCond = sCond + " EDF_STS = " + EDF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY EDF_DAT DESC";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}