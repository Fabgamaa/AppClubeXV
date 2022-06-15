using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Dynafil
    {

        #region Propriedades

        private int? _DNF_ID;
        private string _DNF_MGE;
        private int? _DNF_FOR_ID;
        private int? _DNF_TIT_POY_ID;
        private DateTime? _DNF_DAT_TIT_POY;
        private string _DNF_VLC;
        private DateTime? _DNF_DAT;
        private DateTime? _DNF_DAT_FIA;
        private double? _DNF_TIT_001;
        private double? _DNF_TNC_001;
        private double? _DNF_AON_001;
        private double? _DNF_EVE_001;
        private double? _DNF_QBR_001;
        private double? _DNF_FOA_001;
        private double? _DNF_CVF_001;
        private double? _DNF_TIT_002;
        private double? _DNF_TNC_002;
        private double? _DNF_AON_002;
        private double? _DNF_EVE_002;
        private double? _DNF_QBR_002;
        private double? _DNF_FOA_002;
        private double? _DNF_CVF_002;
        private double? _DNF_TIT_003;
        private double? _DNF_TNC_003;
        private double? _DNF_AON_003;
        private double? _DNF_EVE_003;
        private double? _DNF_QBR_003;
        private double? _DNF_FOA_003;
        private double? _DNF_CVF_003;
        private double? _DNF_TIT_004;
        private double? _DNF_TNC_004;
        private double? _DNF_AON_004;
        private double? _DNF_EVE_004;
        private double? _DNF_QBR_004;
        private double? _DNF_FOA_004;
        private double? _DNF_CVF_004;
        private double? _DNF_TIT_005;
        private double? _DNF_TNC_005;
        private double? _DNF_AON_005;
        private double? _DNF_EVE_005;
        private double? _DNF_QBR_005;
        private double? _DNF_FOA_005;
        private double? _DNF_CVF_005;
        private double? _DNF_TIT_006;
        private double? _DNF_TNC_006;
        private double? _DNF_AON_006;
        private double? _DNF_EVE_006;
        private double? _DNF_QBR_006;
        private double? _DNF_FOA_006;
        private double? _DNF_CVF_006;
        private double? _DNF_TIT_007;
        private double? _DNF_TNC_007;
        private double? _DNF_AON_007;
        private double? _DNF_EVE_007;
        private double? _DNF_QBR_007;
        private double? _DNF_FOA_007;
        private double? _DNF_CVF_007;
        private double? _DNF_TIT_008;
        private double? _DNF_TNC_008;
        private double? _DNF_AON_008;
        private double? _DNF_EVE_008;
        private double? _DNF_QBR_008;
        private double? _DNF_FOA_008;
        private double? _DNF_CVF_008;
        private double? _DNF_TIT_009;
        private double? _DNF_TNC_009;
        private double? _DNF_AON_009;
        private double? _DNF_EVE_009;
        private double? _DNF_QBR_009;
        private double? _DNF_FOA_009;
        private double? _DNF_CVF_009;
        private double? _DNF_TIT_010;
        private double? _DNF_TNC_010;
        private double? _DNF_AON_010;
        private double? _DNF_EVE_010;
        private double? _DNF_QBR_010;
        private double? _DNF_FOA_010;
        private double? _DNF_CVF_010;
        private int? _DNF_STS;
        private int? _DNF_USR_INC_ID;
        private int? _DNF_USR_ALT_ID;
        private DateTime? _DNF_TMS_ATL;
        private string _DNF_OBS;
        private DateTime? _DNF_DAT_INI;
        private DateTime? _DNF_DAT_FIM;
        private string _LST_DNF_MGE;
        private string _TOP;
        private string _SQL;

        public int? DNF_ID
        {
            get { return _DNF_ID; }
            set { _DNF_ID = value; }
        }
        public string DNF_MGE
        {
            get { return _DNF_MGE; }
            set { _DNF_MGE = value.ToUpper(); }
        }
        public int? DNF_FOR_ID
        {
            get { return _DNF_FOR_ID; }
            set { _DNF_FOR_ID = value; }
        }
        public int? DNF_TIT_POY_ID
        {
            get { return _DNF_TIT_POY_ID; }
            set { _DNF_TIT_POY_ID = value; }
        }
        public DateTime? DNF_DAT_TIT_POY
        {
            get { return _DNF_DAT_TIT_POY; }
            set { _DNF_DAT_TIT_POY = value; }
        }
        public string DNF_VLC
        {
            get { return _DNF_VLC; }
            set { _DNF_VLC = value.ToUpper(); }
        }
        public DateTime? DNF_DAT
        {
            get { return _DNF_DAT; }
            set { _DNF_DAT = value; }
        }
        public DateTime? DNF_DAT_FIA
        {
            get { return _DNF_DAT_FIA; }
            set { _DNF_DAT_FIA = value; }
        }
        public double? DNF_TIT_001
        {
            get { return _DNF_TIT_001; }
            set { _DNF_TIT_001 = value; }
        }
        public double? DNF_TNC_001
        {
            get { return _DNF_TNC_001; }
            set { _DNF_TNC_001 = value; }
        }
        public double? DNF_AON_001
        {
            get { return _DNF_AON_001; }
            set { _DNF_AON_001 = value; }
        }
        public double? DNF_EVE_001
        {
            get { return _DNF_EVE_001; }
            set { _DNF_EVE_001 = value; }
        }
        public double? DNF_QBR_001
        {
            get { return _DNF_QBR_001; }
            set { _DNF_QBR_001 = value; }
        }
        public double? DNF_FOA_001
        {
            get { return _DNF_FOA_001; }
            set { _DNF_FOA_001 = value; }
        }
        public double? DNF_CVF_001
        {
            get { return _DNF_CVF_001; }
            set { _DNF_CVF_001 = value; }
        }
        public double? DNF_TIT_002
        {
            get { return _DNF_TIT_002; }
            set { _DNF_TIT_002 = value; }
        }
        public double? DNF_TNC_002
        {
            get { return _DNF_TNC_002; }
            set { _DNF_TNC_002 = value; }
        }
        public double? DNF_AON_002
        {
            get { return _DNF_AON_002; }
            set { _DNF_AON_002 = value; }
        }
        public double? DNF_EVE_002
        {
            get { return _DNF_EVE_002; }
            set { _DNF_EVE_002 = value; }
        }
        public double? DNF_QBR_002
        {
            get { return _DNF_QBR_002; }
            set { _DNF_QBR_002 = value; }
        }
        public double? DNF_FOA_002
        {
            get { return _DNF_FOA_002; }
            set { _DNF_FOA_002 = value; }
        }
        public double? DNF_CVF_002
        {
            get { return _DNF_CVF_002; }
            set { _DNF_CVF_002 = value; }
        }
        public double? DNF_TIT_003
        {
            get { return _DNF_TIT_003; }
            set { _DNF_TIT_003 = value; }
        }
        public double? DNF_TNC_003
        {
            get { return _DNF_TNC_003; }
            set { _DNF_TNC_003 = value; }
        }
        public double? DNF_AON_003
        {
            get { return _DNF_AON_003; }
            set { _DNF_AON_003 = value; }
        }
        public double? DNF_EVE_003
        {
            get { return _DNF_EVE_003; }
            set { _DNF_EVE_003 = value; }
        }
        public double? DNF_QBR_003
        {
            get { return _DNF_QBR_003; }
            set { _DNF_QBR_003 = value; }
        }
        public double? DNF_FOA_003
        {
            get { return _DNF_FOA_003; }
            set { _DNF_FOA_003 = value; }
        }
        public double? DNF_CVF_003
        {
            get { return _DNF_CVF_003; }
            set { _DNF_CVF_003 = value; }
        }
        public double? DNF_TIT_004
        {
            get { return _DNF_TIT_004; }
            set { _DNF_TIT_004 = value; }
        }
        public double? DNF_TNC_004
        {
            get { return _DNF_TNC_004; }
            set { _DNF_TNC_004 = value; }
        }
        public double? DNF_AON_004
        {
            get { return _DNF_AON_004; }
            set { _DNF_AON_004 = value; }
        }
        public double? DNF_EVE_004
        {
            get { return _DNF_EVE_004; }
            set { _DNF_EVE_004 = value; }
        }
        public double? DNF_QBR_004
        {
            get { return _DNF_QBR_004; }
            set { _DNF_QBR_004 = value; }
        }
        public double? DNF_FOA_004
        {
            get { return _DNF_FOA_004; }
            set { _DNF_FOA_004 = value; }
        }
        public double? DNF_CVF_004
        {
            get { return _DNF_CVF_004; }
            set { _DNF_CVF_004 = value; }
        }
        public double? DNF_TIT_005
        {
            get { return _DNF_TIT_005; }
            set { _DNF_TIT_005 = value; }
        }
        public double? DNF_TNC_005
        {
            get { return _DNF_TNC_005; }
            set { _DNF_TNC_005 = value; }
        }
        public double? DNF_AON_005
        {
            get { return _DNF_AON_005; }
            set { _DNF_AON_005 = value; }
        }
        public double? DNF_EVE_005
        {
            get { return _DNF_EVE_005; }
            set { _DNF_EVE_005 = value; }
        }
        public double? DNF_QBR_005
        {
            get { return _DNF_QBR_005; }
            set { _DNF_QBR_005 = value; }
        }
        public double? DNF_FOA_005
        {
            get { return _DNF_FOA_005; }
            set { _DNF_FOA_005 = value; }
        }
        public double? DNF_CVF_005
        {
            get { return _DNF_CVF_005; }
            set { _DNF_CVF_005 = value; }
        }
        public double? DNF_TIT_006
        {
            get { return _DNF_TIT_006; }
            set { _DNF_TIT_006 = value; }
        }
        public double? DNF_TNC_006
        {
            get { return _DNF_TNC_006; }
            set { _DNF_TNC_006 = value; }
        }
        public double? DNF_AON_006
        {
            get { return _DNF_AON_006; }
            set { _DNF_AON_006 = value; }
        }
        public double? DNF_EVE_006
        {
            get { return _DNF_EVE_006; }
            set { _DNF_EVE_006 = value; }
        }
        public double? DNF_QBR_006
        {
            get { return _DNF_QBR_006; }
            set { _DNF_QBR_006 = value; }
        }
        public double? DNF_FOA_006
        {
            get { return _DNF_FOA_006; }
            set { _DNF_FOA_006 = value; }
        }
        public double? DNF_CVF_006
        {
            get { return _DNF_CVF_006; }
            set { _DNF_CVF_006 = value; }
        }
        public double? DNF_TIT_007
        {
            get { return _DNF_TIT_007; }
            set { _DNF_TIT_007 = value; }
        }
        public double? DNF_TNC_007
        {
            get { return _DNF_TNC_007; }
            set { _DNF_TNC_007 = value; }
        }
        public double? DNF_AON_007
        {
            get { return _DNF_AON_007; }
            set { _DNF_AON_007 = value; }
        }
        public double? DNF_EVE_007
        {
            get { return _DNF_EVE_007; }
            set { _DNF_EVE_007 = value; }
        }
        public double? DNF_QBR_007
        {
            get { return _DNF_QBR_007; }
            set { _DNF_QBR_007 = value; }
        }
        public double? DNF_FOA_007
        {
            get { return _DNF_FOA_007; }
            set { _DNF_FOA_007 = value; }
        }
        public double? DNF_CVF_007
        {
            get { return _DNF_CVF_007; }
            set { _DNF_CVF_007 = value; }
        }
        public double? DNF_TIT_008
        {
            get { return _DNF_TIT_008; }
            set { _DNF_TIT_008 = value; }
        }
        public double? DNF_TNC_008
        {
            get { return _DNF_TNC_008; }
            set { _DNF_TNC_008 = value; }
        }
        public double? DNF_AON_008
        {
            get { return _DNF_AON_008; }
            set { _DNF_AON_008 = value; }
        }
        public double? DNF_EVE_008
        {
            get { return _DNF_EVE_008; }
            set { _DNF_EVE_008 = value; }
        }
        public double? DNF_QBR_008
        {
            get { return _DNF_QBR_008; }
            set { _DNF_QBR_008 = value; }
        }
        public double? DNF_FOA_008
        {
            get { return _DNF_FOA_008; }
            set { _DNF_FOA_008 = value; }
        }
        public double? DNF_CVF_008
        {
            get { return _DNF_CVF_008; }
            set { _DNF_CVF_008 = value; }
        }
        public double? DNF_TIT_009
        {
            get { return _DNF_TIT_009; }
            set { _DNF_TIT_009 = value; }
        }
        public double? DNF_TNC_009
        {
            get { return _DNF_TNC_009; }
            set { _DNF_TNC_009 = value; }
        }
        public double? DNF_AON_009
        {
            get { return _DNF_AON_009; }
            set { _DNF_AON_009 = value; }
        }
        public double? DNF_EVE_009
        {
            get { return _DNF_EVE_009; }
            set { _DNF_EVE_009 = value; }
        }
        public double? DNF_QBR_009
        {
            get { return _DNF_QBR_009; }
            set { _DNF_QBR_009 = value; }
        }
        public double? DNF_FOA_009
        {
            get { return _DNF_FOA_009; }
            set { _DNF_FOA_009 = value; }
        }
        public double? DNF_CVF_009
        {
            get { return _DNF_CVF_009; }
            set { _DNF_CVF_009 = value; }
        }
        public double? DNF_TIT_010
        {
            get { return _DNF_TIT_010; }
            set { _DNF_TIT_010 = value; }
        }
        public double? DNF_TNC_010
        {
            get { return _DNF_TNC_010; }
            set { _DNF_TNC_010 = value; }
        }
        public double? DNF_AON_010
        {
            get { return _DNF_AON_010; }
            set { _DNF_AON_010 = value; }
        }
        public double? DNF_EVE_010
        {
            get { return _DNF_EVE_010; }
            set { _DNF_EVE_010 = value; }
        }
        public double? DNF_QBR_010
        {
            get { return _DNF_QBR_010; }
            set { _DNF_QBR_010 = value; }
        }
        public double? DNF_FOA_010
        {
            get { return _DNF_FOA_010; }
            set { _DNF_FOA_010 = value; }
        }
        public double? DNF_CVF_010
        {
            get { return _DNF_CVF_010; }
            set { _DNF_CVF_010 = value; }
        }
        public int? DNF_STS
        {
            get { return _DNF_STS; }
            set { _DNF_STS = value; }
        }
        public int? DNF_USR_INC_ID
        {
            get { return _DNF_USR_INC_ID; }
            set { _DNF_USR_INC_ID = value; }
        }
        public int? DNF_USR_ALT_ID
        {
            get { return _DNF_USR_ALT_ID; }
            set { _DNF_USR_ALT_ID = value; }
        }
        public DateTime? DNF_TMS_ATL
        {
            get { return _DNF_TMS_ATL; }
            set { _DNF_TMS_ATL = value; }
        }

        public DateTime? DNF_DAT_INI
        {
            get { return _DNF_DAT_INI; }
            set { _DNF_DAT_INI = value; }
        }

        public DateTime? DNF_DAT_FIM
        {
            get { return _DNF_DAT_FIM; }
            set { _DNF_DAT_FIM = value; }
        }
        public string LST_DNF_MGE
        {
            get { return _LST_DNF_MGE; }
            set { _LST_DNF_MGE = value.ToUpper(); }
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

        public string DNF_OBS
        {
            get { return _DNF_OBS; }
            set { _DNF_OBS = value.ToUpper(); }
        }


        #endregion

        #region Métodos

        clsBanco dbConn = new clsBanco();

        public string Inserir()
        {
            string sSQL = "INSERT INTO DNF (";
            sSQL = sSQL + "DNF_MGE, ";
            sSQL = sSQL + "DNF_FOR_ID, ";
            sSQL = sSQL + "DNF_TIT_POY_ID, ";
            sSQL = sSQL + "DNF_VLC, ";
            sSQL = sSQL + "DNF_DAT, ";
            sSQL = sSQL + "DNF_TIT_001, ";
            sSQL = sSQL + "DNF_TNC_001, ";
            sSQL = sSQL + "DNF_AON_001, ";
            sSQL = sSQL + "DNF_EVE_001, ";
            sSQL = sSQL + "DNF_QBR_001, ";
            sSQL = sSQL + "DNF_FOA_001, ";
            sSQL = sSQL + "DNF_CVF_001, ";
            sSQL = sSQL + "DNF_TIT_002, ";
            sSQL = sSQL + "DNF_TNC_002, ";
            sSQL = sSQL + "DNF_AON_002, ";
            sSQL = sSQL + "DNF_EVE_002, ";
            sSQL = sSQL + "DNF_QBR_002, ";
            sSQL = sSQL + "DNF_FOA_002, ";
            sSQL = sSQL + "DNF_CVF_002, ";
            sSQL = sSQL + "DNF_TIT_003, ";
            sSQL = sSQL + "DNF_TNC_003, ";
            sSQL = sSQL + "DNF_AON_003, ";
            sSQL = sSQL + "DNF_EVE_003, ";
            sSQL = sSQL + "DNF_QBR_003, ";
            sSQL = sSQL + "DNF_FOA_003, ";
            sSQL = sSQL + "DNF_CVF_003, ";
            sSQL = sSQL + "DNF_TIT_004, ";
            sSQL = sSQL + "DNF_TNC_004, ";
            sSQL = sSQL + "DNF_AON_004, ";
            sSQL = sSQL + "DNF_EVE_004, ";
            sSQL = sSQL + "DNF_QBR_004, ";
            sSQL = sSQL + "DNF_FOA_004, ";
            sSQL = sSQL + "DNF_CVF_004, ";
            sSQL = sSQL + "DNF_TIT_005, ";
            sSQL = sSQL + "DNF_TNC_005, ";
            sSQL = sSQL + "DNF_AON_005, ";
            sSQL = sSQL + "DNF_EVE_005, ";
            sSQL = sSQL + "DNF_QBR_005, ";
            sSQL = sSQL + "DNF_FOA_005, ";
            sSQL = sSQL + "DNF_CVF_005, ";
            sSQL = sSQL + "DNF_TIT_006, ";
            sSQL = sSQL + "DNF_TNC_006, ";
            sSQL = sSQL + "DNF_AON_006, ";
            sSQL = sSQL + "DNF_EVE_006, ";
            sSQL = sSQL + "DNF_QBR_006, ";
            sSQL = sSQL + "DNF_FOA_006, ";
            sSQL = sSQL + "DNF_CVF_006, ";
            sSQL = sSQL + "DNF_TIT_007, ";
            sSQL = sSQL + "DNF_TNC_007, ";
            sSQL = sSQL + "DNF_AON_007, ";
            sSQL = sSQL + "DNF_EVE_007, ";
            sSQL = sSQL + "DNF_QBR_007, ";
            sSQL = sSQL + "DNF_FOA_007, ";
            sSQL = sSQL + "DNF_CVF_007, ";
            sSQL = sSQL + "DNF_TIT_008, ";
            sSQL = sSQL + "DNF_TNC_008, ";
            sSQL = sSQL + "DNF_AON_008, ";
            sSQL = sSQL + "DNF_EVE_008, ";
            sSQL = sSQL + "DNF_QBR_008, ";
            sSQL = sSQL + "DNF_FOA_008, ";
            sSQL = sSQL + "DNF_CVF_008, ";
            sSQL = sSQL + "DNF_TIT_009, ";
            sSQL = sSQL + "DNF_TNC_009, ";
            sSQL = sSQL + "DNF_AON_009, ";
            sSQL = sSQL + "DNF_EVE_009, ";
            sSQL = sSQL + "DNF_QBR_009, ";
            sSQL = sSQL + "DNF_FOA_009, ";
            sSQL = sSQL + "DNF_CVF_009, ";
            sSQL = sSQL + "DNF_TIT_010, ";
            sSQL = sSQL + "DNF_TNC_010, ";
            sSQL = sSQL + "DNF_AON_010, ";
            sSQL = sSQL + "DNF_EVE_010, ";
            sSQL = sSQL + "DNF_QBR_010, ";
            sSQL = sSQL + "DNF_FOA_010, ";
            sSQL = sSQL + "DNF_CVF_010, ";
            sSQL = sSQL + "DNF_STS, ";
            sSQL = sSQL + "DNF_OBS, ";
            sSQL = sSQL + "DNF_DAT_FIA, ";
            sSQL = sSQL + "DNF_USR_INC_ID, ";
            sSQL = sSQL + "DNF_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sSQL = sSQL + "'" + DNF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOR_ID.ToString()))
            {
                sSQL = sSQL + DNF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + DNF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sSQL = sSQL + "'" + DNF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + DNF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_001.ToString()))
            {
                sSQL = sSQL + DNF_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_001.ToString()))
            {
                sSQL = sSQL + DNF_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_001.ToString()))
            {
                sSQL = sSQL + DNF_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_001.ToString()))
            {
                sSQL = sSQL + DNF_EVE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_001.ToString()))
            {
                sSQL = sSQL + DNF_QBR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_001.ToString()))
            {
                sSQL = sSQL + DNF_FOA_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_001.ToString()))
            {
                sSQL = sSQL + DNF_CVF_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_002.ToString()))
            {
                sSQL = sSQL + DNF_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_002.ToString()))
            {
                sSQL = sSQL + DNF_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_002.ToString()))
            {
                sSQL = sSQL + DNF_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_002.ToString()))
            {
                sSQL = sSQL + DNF_EVE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_002.ToString()))
            {
                sSQL = sSQL + DNF_QBR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_002.ToString()))
            {
                sSQL = sSQL + DNF_FOA_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_002.ToString()))
            {
                sSQL = sSQL + DNF_CVF_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_003.ToString()))
            {
                sSQL = sSQL + DNF_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_003.ToString()))
            {
                sSQL = sSQL + DNF_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_003.ToString()))
            {
                sSQL = sSQL + DNF_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_003.ToString()))
            {
                sSQL = sSQL + DNF_EVE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_003.ToString()))
            {
                sSQL = sSQL + DNF_QBR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_003.ToString()))
            {
                sSQL = sSQL + DNF_FOA_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_003.ToString()))
            {
                sSQL = sSQL + DNF_CVF_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_004.ToString()))
            {
                sSQL = sSQL + DNF_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_004.ToString()))
            {
                sSQL = sSQL + DNF_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_004.ToString()))
            {
                sSQL = sSQL + DNF_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_004.ToString()))
            {
                sSQL = sSQL + DNF_EVE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_004.ToString()))
            {
                sSQL = sSQL + DNF_QBR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_004.ToString()))
            {
                sSQL = sSQL + DNF_FOA_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_004.ToString()))
            {
                sSQL = sSQL + DNF_CVF_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_005.ToString()))
            {
                sSQL = sSQL + DNF_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_005.ToString()))
            {
                sSQL = sSQL + DNF_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_005.ToString()))
            {
                sSQL = sSQL + DNF_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_005.ToString()))
            {
                sSQL = sSQL + DNF_EVE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_005.ToString()))
            {
                sSQL = sSQL + DNF_QBR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_005.ToString()))
            {
                sSQL = sSQL + DNF_FOA_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_005.ToString()))
            {
                sSQL = sSQL + DNF_CVF_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_006.ToString()))
            {
                sSQL = sSQL + DNF_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_006.ToString()))
            {
                sSQL = sSQL + DNF_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_006.ToString()))
            {
                sSQL = sSQL + DNF_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_006.ToString()))
            {
                sSQL = sSQL + DNF_EVE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_006.ToString()))
            {
                sSQL = sSQL + DNF_QBR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_006.ToString()))
            {
                sSQL = sSQL + DNF_FOA_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_006.ToString()))
            {
                sSQL = sSQL + DNF_CVF_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_007.ToString()))
            {
                sSQL = sSQL + DNF_TIT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_007.ToString()))
            {
                sSQL = sSQL + DNF_TNC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_007.ToString()))
            {
                sSQL = sSQL + DNF_AON_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_007.ToString()))
            {
                sSQL = sSQL + DNF_EVE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_007.ToString()))
            {
                sSQL = sSQL + DNF_QBR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_007.ToString()))
            {
                sSQL = sSQL + DNF_FOA_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_007.ToString()))
            {
                sSQL = sSQL + DNF_CVF_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_008.ToString()))
            {
                sSQL = sSQL + DNF_TIT_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_008.ToString()))
            {
                sSQL = sSQL + DNF_TNC_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_008.ToString()))
            {
                sSQL = sSQL + DNF_AON_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_008.ToString()))
            {
                sSQL = sSQL + DNF_EVE_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_008.ToString()))
            {
                sSQL = sSQL + DNF_QBR_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_008.ToString()))
            {
                sSQL = sSQL + DNF_FOA_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_008.ToString()))
            {
                sSQL = sSQL + DNF_CVF_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_009.ToString()))
            {
                sSQL = sSQL + DNF_TIT_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_009.ToString()))
            {
                sSQL = sSQL + DNF_TNC_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_009.ToString()))
            {
                sSQL = sSQL + DNF_AON_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_009.ToString()))
            {
                sSQL = sSQL + DNF_EVE_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_009.ToString()))
            {
                sSQL = sSQL + DNF_QBR_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_009.ToString()))
            {
                sSQL = sSQL + DNF_FOA_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_009.ToString()))
            {
                sSQL = sSQL + DNF_CVF_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_010.ToString()))
            {
                sSQL = sSQL + DNF_TIT_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_010.ToString()))
            {
                sSQL = sSQL + DNF_TNC_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_010.ToString()))
            {
                sSQL = sSQL + DNF_AON_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_010.ToString()))
            {
                sSQL = sSQL + DNF_EVE_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_010.ToString()))
            {
                sSQL = sSQL + DNF_QBR_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_010.ToString()))
            {
                sSQL = sSQL + DNF_FOA_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_010.ToString()))
            {
                sSQL = sSQL + DNF_CVF_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_STS.ToString()))
            {
                sSQL = sSQL + DNF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_OBS))
            {
                sSQL = sSQL + "'" + DNF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_DAT_FIA.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + DNF_DAT_FIA + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + DNF_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE DNF ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sSQL = sSQL + "DNF_MGE = '" + DNF_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DNF_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOR_ID.ToString()))
            {
                sSQL = sSQL + "DNF_FOR_ID = " + DNF_FOR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_POY_ID = " + DNF_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sSQL = sSQL + "DNF_VLC = '" + DNF_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DNF_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_DAT.ToString()))
            {
                sSQL = sSQL + "DNF_DAT = Convert(datetime, '" + DNF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "DNF_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_DAT_FIA.ToString()))
            {
                sSQL = sSQL + "DNF_DAT_FIA = Convert(datetime, '" + DNF_DAT_FIA + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "DNF_DAT_FIA = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_001.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_001 = " + DNF_TIT_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_001.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_001 = " + DNF_TNC_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_001.ToString()))
            {
                sSQL = sSQL + "DNF_AON_001 = " + DNF_AON_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_001.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_001 = " + DNF_EVE_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_001.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_001 = " + DNF_QBR_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_001.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_001 = " + DNF_FOA_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_001.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_001 = " + DNF_CVF_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_002.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_002 = " + DNF_TIT_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_002.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_002 = " + DNF_TNC_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_002.ToString()))
            {
                sSQL = sSQL + "DNF_AON_002 = " + DNF_AON_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_002.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_002 = " + DNF_EVE_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_002.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_002 = " + DNF_QBR_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_002.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_002 = " + DNF_FOA_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_002.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_002 = " + DNF_CVF_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_003.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_003 = " + DNF_TIT_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_003.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_003 = " + DNF_TNC_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_003.ToString()))
            {
                sSQL = sSQL + "DNF_AON_003 = " + DNF_AON_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_003.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_003 = " + DNF_EVE_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_003.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_003 = " + DNF_QBR_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_003.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_003 = " + DNF_FOA_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_003.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_003 = " + DNF_CVF_003.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_004.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_004 = " + DNF_TIT_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_004.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_004 = " + DNF_TNC_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_004.ToString()))
            {
                sSQL = sSQL + "DNF_AON_004 = " + DNF_AON_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_004.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_004 = " + DNF_EVE_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_004.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_004 = " + DNF_QBR_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_004.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_004 = " + DNF_FOA_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_004.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_004 = " + DNF_CVF_004.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_005.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_005 = " + DNF_TIT_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_005.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_005 = " + DNF_TNC_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_005.ToString()))
            {
                sSQL = sSQL + "DNF_AON_005 = " + DNF_AON_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_005.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_005 = " + DNF_EVE_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_005.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_005 = " + DNF_QBR_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_005.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_005 = " + DNF_FOA_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_005.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_005 = " + DNF_CVF_005.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_005 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_006.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_006 = " + DNF_TIT_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_006.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_006 = " + DNF_TNC_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_006.ToString()))
            {
                sSQL = sSQL + "DNF_AON_006 = " + DNF_AON_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_006.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_006 = " + DNF_EVE_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_006.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_006 = " + DNF_QBR_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_006.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_006 = " + DNF_FOA_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_006.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_006 = " + DNF_CVF_006.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_006 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_007.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_007 = " + DNF_TIT_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_007.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_007 = " + DNF_TNC_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_007.ToString()))
            {
                sSQL = sSQL + "DNF_AON_007 = " + DNF_AON_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_007.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_007 = " + DNF_EVE_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_007.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_007 = " + DNF_QBR_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_007.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_007 = " + DNF_FOA_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_007.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_007 = " + DNF_CVF_007.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_007 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_008.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_008 = " + DNF_TIT_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_008.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_008 = " + DNF_TNC_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_008.ToString()))
            {
                sSQL = sSQL + "DNF_AON_008 = " + DNF_AON_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_008.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_008 = " + DNF_EVE_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_008.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_008 = " + DNF_QBR_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_008.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_008 = " + DNF_FOA_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_008.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_008 = " + DNF_CVF_008.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_008 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_009.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_009 = " + DNF_TIT_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_009.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_009 = " + DNF_TNC_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_009.ToString()))
            {
                sSQL = sSQL + "DNF_AON_009 = " + DNF_AON_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_009.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_009 = " + DNF_EVE_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_009.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_009 = " + DNF_QBR_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_009.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_009 = " + DNF_FOA_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_009.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_009 = " + DNF_CVF_009.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_009 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TIT_010.ToString()))
            {
                sSQL = sSQL + "DNF_TIT_010 = " + DNF_TIT_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TIT_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_TNC_010.ToString()))
            {
                sSQL = sSQL + "DNF_TNC_010 = " + DNF_TNC_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_TNC_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_AON_010.ToString()))
            {
                sSQL = sSQL + "DNF_AON_010 = " + DNF_AON_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_AON_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_EVE_010.ToString()))
            {
                sSQL = sSQL + "DNF_EVE_010 = " + DNF_EVE_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_EVE_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_QBR_010.ToString()))
            {
                sSQL = sSQL + "DNF_QBR_010 = " + DNF_QBR_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_QBR_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_FOA_010.ToString()))
            {
                sSQL = sSQL + "DNF_FOA_010 = " + DNF_FOA_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_FOA_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_CVF_010.ToString()))
            {
                sSQL = sSQL + "DNF_CVF_010 = " + DNF_CVF_010.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_CVF_010 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_STS.ToString()))
            {
                sSQL = sSQL + "DNF_STS = " + DNF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(DNF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "DNF_USR_ALT_ID = " + DNF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DNF_USR_ALT_ID = NULL, ";
            }

            if (!String.IsNullOrEmpty(DNF_OBS))
            {
                sSQL = sSQL + "DNF_OBS = '" +  DNF_OBS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DNF_OBS = NULL, ";
            }


            sSQL = sSQL + "DNF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE DNF_ID = " + DNF_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM DNF";
            sSQL = sSQL + " WHERE DNF_ID = " + DNF_ID;

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
            sSQL = sSQL + " FROM DNF";
            sSQL = sSQL + " LEFT JOIN [FOR] ON FOR_ID = DNF_FOR_ID";
            sSQL = sSQL + " LEFT JOIN [TIT_POY] ON TIT_POY_ID = DNF_TIT_POY_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_ID)))
            {
                sCond = sCond + " DNF_ID = " + DNF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sCond = sCond + " DNF_MGE = '" + DNF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_FOR_ID)))
            {
                sCond = sCond + " DNF_FOR_ID = " + DNF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_TIT_POY_ID)))
            {
                sCond = sCond + " DNF_TIT_POY_ID = " + DNF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sCond = sCond + " DNF_VLC = '" + DNF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT)))
            {
                sCond = sCond + " DNF_DAT BETWEEN Convert(datetime, '" + DNF_DAT + "',103) AND Convert(datetime, '" + DNF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_INI)))
            {
                sCond = sCond + " DNF_DAT >= Convert(datetime, '" + DNF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIM)))
            {
                sCond = sCond + " DNF_DAT <= Convert(datetime, '" + DNF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_STS)))
            {
                sCond = sCond + " DNF_STS = " + DNF_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIA)))
            {
                sCond = sCond + " DNF_DAT_FIA = Convert(datetime, '" + DNF_DAT_FIA + "',103) AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DNF_DAT DESC";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarMediaMergeTotal()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT DNF_MGE, COUNT(*) QTD_ANS,";
            sSQL = sSQL + " SUM(dbo.CONTA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) QTD_BOB,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MAX";
            sSQL = sSQL + " FROM DNF";
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_ID)))
            {
                sCond = sCond + " DNF_ID = " + DNF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sCond = sCond + " DNF_MGE = '" + DNF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(LST_DNF_MGE))
            {
                sCond = sCond + " DNF_MGE IN (" + LST_DNF_MGE + ") AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_FOR_ID)))
            {
                sCond = sCond + " DNF_FOR_ID = " + DNF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_TIT_POY_ID)))
            {
                sCond = sCond + " DNF_TIT_POY_ID = " + DNF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sCond = sCond + " DNF_VLC = '" + DNF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT)))
            {
                sCond = sCond + " DNF_DAT BETWEEN Convert(datetime, '" + DNF_DAT + "',103) AND Convert(datetime, '" + DNF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_INI)))
            {
                sCond = sCond + " DNF_DAT >= Convert(datetime, '" + DNF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIM)))
            {
                sCond = sCond + " DNF_DAT <= Convert(datetime, '" + DNF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_STS)))
            {
                sCond = sCond + " DNF_STS = " + DNF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + " GROUP BY DNF_MGE";
            sSQL = sSQL + " ORDER BY DNF_MGE";
            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarMediaTotal()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT COUNT(*) QTD_ANS,";
            sSQL = sSQL + " SUM(dbo.CONTA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) QTD_BOB,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010)) TIT_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010)) TNC_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010)) AON_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010)) EVE_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010)) QBR_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010)) FOA_MAX,";
            sSQL = sSQL + " MIN(dbo.MINIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MIN,";
            sSQL = sSQL + " AVG(dbo.MEDIA (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MED,";
            sSQL = sSQL + " STDEV(dbo.DESVIO (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_DSV,";
            sSQL = sSQL + " MAX(dbo.MAXIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010)) CVF_MAX";
            sSQL = sSQL + " FROM DNF";
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_ID)))
            {
                sCond = sCond + " DNF_ID = " + DNF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sCond = sCond + " DNF_MGE = '" + DNF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(LST_DNF_MGE))
            {
                sCond = sCond + " DNF_MGE IN ('" + LST_DNF_MGE + "') AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_FOR_ID)))
            {
                sCond = sCond + " DNF_FOR_ID = " + DNF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_TIT_POY_ID)))
            {
                sCond = sCond + " DNF_TIT_POY_ID = " + DNF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sCond = sCond + " DNF_VLC = '" + DNF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT)))
            {
                sCond = sCond + " DNF_DAT BETWEEN Convert(datetime, '" + DNF_DAT + "',103) AND Convert(datetime, '" + DNF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIA)))
            {
                sCond = sCond + " DNF_DAT_FIA >= Convert(datetime, '" + DNF_DAT_FIA + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_INI)))
            {
                sCond = sCond + " DNF_DAT >= Convert(datetime, '" + DNF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIM)))
            {
                sCond = sCond + " DNF_DAT <= Convert(datetime, '" + DNF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_STS)))
            {
                sCond = sCond + " DNF_STS = " + DNF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarMedia()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT DNF_ID, DNF_DAT, DNF_MGE, DNF_VLC, FOR_NOM, TIT_POY_DES, DNF_OBS, DNF_DAT_FIA, ";
            sSQL = sSQL + " dbo.CONTA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010) QTD_BOB,";
            sSQL = sSQL + " dbo.MINIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010) TIT_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010) TIT_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010) TIT_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_TIT_001, DNF_TIT_002, DNF_TIT_003, DNF_TIT_004, DNF_TIT_005, DNF_TIT_006, DNF_TIT_007, DNF_TIT_008, DNF_TIT_009, DNF_TIT_010) TIT_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010) TNC_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010) TNC_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010) TNC_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_TNC_001, DNF_TNC_002, DNF_TNC_003, DNF_TNC_004, DNF_TNC_005, DNF_TNC_006, DNF_TNC_007, DNF_TNC_008, DNF_TNC_009, DNF_TNC_010) TNC_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010) AON_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010) AON_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010) AON_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_AON_001, DNF_AON_002, DNF_AON_003, DNF_AON_004, DNF_AON_005, DNF_AON_006, DNF_AON_007, DNF_AON_008, DNF_AON_009, DNF_AON_010) AON_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010) EVE_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010) EVE_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010) EVE_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_EVE_001, DNF_EVE_002, DNF_EVE_003, DNF_EVE_004, DNF_EVE_005, DNF_EVE_006, DNF_EVE_007, DNF_EVE_008, DNF_EVE_009, DNF_EVE_010) EVE_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010) QBR_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010) QBR_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010) QBR_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_QBR_001, DNF_QBR_002, DNF_QBR_003, DNF_QBR_004, DNF_QBR_005, DNF_QBR_006, DNF_QBR_007, DNF_QBR_008, DNF_QBR_009, DNF_QBR_010) QBR_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010) FOA_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010) FOA_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010) FOA_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_FOA_001, DNF_FOA_002, DNF_FOA_003, DNF_FOA_004, DNF_FOA_005, DNF_FOA_006, DNF_FOA_007, DNF_FOA_008, DNF_FOA_009, DNF_FOA_010) FOA_MAX,";
            sSQL = sSQL + " dbo.MINIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010) CVF_MIN,";
            sSQL = sSQL + " dbo.MEDIA (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010) CVF_MED,";
            sSQL = sSQL + " dbo.DESVIO (DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010) CVF_DSV,";
            sSQL = sSQL + " dbo.MAXIMO(DNF_CVF_001, DNF_CVF_002, DNF_CVF_003, DNF_CVF_004, DNF_CVF_005, DNF_CVF_006, DNF_CVF_007, DNF_CVF_008, DNF_CVF_009, DNF_CVF_010) CVF_MAX";
            sSQL = sSQL + " FROM DNF";
            sSQL = sSQL + " LEFT JOIN [FOR] ON FOR_ID = DNF_FOR_ID";
            sSQL = sSQL + " LEFT JOIN [TIT_POY] ON TIT_POY_ID = DNF_TIT_POY_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_ID)))
            {
                sCond = sCond + " DNF_ID = " + DNF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_MGE))
            {
                sCond = sCond + " DNF_MGE = '" + DNF_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_FOR_ID)))
            {
                sCond = sCond + " DNF_FOR_ID = " + DNF_FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_TIT_POY_ID)))
            {
                sCond = sCond + " DNF_TIT_POY_ID = " + DNF_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(DNF_VLC))
            {
                sCond = sCond + " DNF_VLC = '" + DNF_VLC + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT)))
            {
                sCond = sCond + " DNF_DAT BETWEEN Convert(datetime, '" + DNF_DAT + "',103) AND Convert(datetime, '" + DNF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_INI)))
            {
                sCond = sCond + " DNF_DAT >= Convert(datetime, '" + DNF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_DAT_FIM)))
            {
                sCond = sCond + " DNF_DAT <= Convert(datetime, '" + DNF_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DNF_STS)))
            {
                sCond = sCond + " DNF_STS = " + DNF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DNF_DAT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }
        #endregion

    }
}