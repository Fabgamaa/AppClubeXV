using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class RTS
    {

        #region Propriedades

        private int? _RTS_ID;
        private int? _RTS_MTV_TST_ID;
        private int? _RTS_TIT_POY_ID;
        private int? _RTS_ERT_ID;
        private int? _RTS_APS_ID;
        private int? _RTS_SCC_TRV_ID;
        private int? _RTS_MTD_ID;
        private int? _RTS_COR_ID;
        private int? _RTS_CLI_ID;
        private int? _RTS_FIO_ID;
        private int? _RTS_GRP_MRL_ID;
        private string _RTS_LOT_REF;
        private string _RTS_VLC;
        private int? _RTS_MRC_ID;
        private int? _RTS_ESL_ID;
        private int? _RTS_CXA_ID;
        private int? _RTS_SLT_USR_ID;
        private string _RTS_CST;
        private DateTime? _RTS_DAT;
        private string _RTS_OBS_SLT;
        private int? _RTS_FOR_001_ID;
        private int? _RTS_FOR_002_ID;
        private int? _RTS_FOR_003_ID;
        private int? _RTS_FOR_004_ID;
        private int? _RTS_SPA;
        private int? _RTS_MAQ_TIP_ID;
        private int? _RTS_MAQ_ID;
        private string _RTS_MGE;
        private string _RTS_MGE_002;
        private string _RTS_MGE_003;
        private string _RTS_MGE_004;
        private DateTime? _RTS_LOG_DAT;
        private int? _RTS_LOG_USR_ID;
        private string _RTS_OBS_LOG;
        private string _RTS_VLI;
        private string _RTS_JTF;
        private string _RTS_LOT;
        private double? _RTS_TIT;
        private int? _RTS_VEL;
        private int? _RTS_CBO;
        private double? _RTS_PAO_001;
        private double? _RTS_PAO_002;
        private string _RTS_JET_001;
        private string _RTS_JET_002;
        private double? _RTS_OLE;
        private double? _RTS_PES_SUP;
        private double? _RTS_EFC;
        private double? _RTS_PRC;
        private double? _RTS_QBR_TUR;
        private double? _RTS_QBR_KIO;
        private double? _RTS_QBR_PNV;
        private double? _RTS_QBR_DNV;
        private double? _RTS_QBR_CAR;
        private DateTime? _RTS_PED_DAT;
        private int? _RTS_PED_USR_ID;
        private string _RTS_DMO;
        private string _RTS_PES;
        private string _RTS_SPE;
        private string _RTS_OBS_PED;
        private DateTime? _RTS_DAT_DSV;
        private DateTime? _RTS_PJT_DAT;
        private int? _RTS_PJT_USR_ID;
        private string _RTS_OBS_PCP;
        private int? _RTS_STS;
        private int? _RTS_USR_INC_ID;
        private int? _RTS_USR_ALT_ID;
        private DateTime? _RTS_TMS_ATL;

        private DateTime? _RTS_DAT_INI;
        private DateTime? _RTS_DAT_FIM;
        private DateTime? _RTS_LOG_DAT_INI;
        private DateTime? _RTS_LOG_DAT_FIM;
        private DateTime? _RTS_PED_DAT_INI;
        private DateTime? _RTS_PED_DAT_FIM;
        private DateTime? _RTS_DAT_DSV_INI;
        private DateTime? _RTS_DAT_DSV_FIM;
        private DateTime? _RTS_PJT_DAT_INI;
        private DateTime? _RTS_PJT_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? RTS_ID
        {
            get { return _RTS_ID; }
            set { _RTS_ID = value; }
        }
        public int? RTS_MTV_TST_ID
        {
            get { return _RTS_MTV_TST_ID; }
            set { _RTS_MTV_TST_ID = value; }
        }
        public int? RTS_TIT_POY_ID
        {
            get { return _RTS_TIT_POY_ID; }
            set { _RTS_TIT_POY_ID = value; }
        }
        public int? RTS_ERT_ID
        {
            get { return _RTS_ERT_ID; }
            set { _RTS_ERT_ID = value; }
        }
        public int? RTS_APS_ID
        {
            get { return _RTS_APS_ID; }
            set { _RTS_APS_ID = value; }
        }
        public int? RTS_SCC_TRV_ID
        {
            get { return _RTS_SCC_TRV_ID; }
            set { _RTS_SCC_TRV_ID = value; }
        }
        public int? RTS_MTD_ID
        {
            get { return _RTS_MTD_ID; }
            set { _RTS_MTD_ID = value; }
        }
        public int? RTS_COR_ID
        {
            get { return _RTS_COR_ID; }
            set { _RTS_COR_ID = value; }
        }
        public int? RTS_CLI_ID
        {
            get { return _RTS_CLI_ID; }
            set { _RTS_CLI_ID = value; }
        }
        public int? RTS_FIO_ID
        {
            get { return _RTS_FIO_ID; }
            set { _RTS_FIO_ID = value; }
        }
        public int? RTS_GRP_MRL_ID
        {
            get { return _RTS_GRP_MRL_ID; }
            set { _RTS_GRP_MRL_ID = value; }
        }
        public string RTS_LOT_REF
        {
            get { return _RTS_LOT_REF; }
            set { _RTS_LOT_REF = value.ToUpper(); }
        }
        public string RTS_VLC
        {
            get { return _RTS_VLC; }
            set { _RTS_VLC = value.ToUpper(); }
        }
        public int? RTS_MRC_ID
        {
            get { return _RTS_MRC_ID; }
            set { _RTS_MRC_ID = value; }
        }
        public int? RTS_ESL_ID
        {
            get { return _RTS_ESL_ID; }
            set { _RTS_ESL_ID = value; }
        }
        public int? RTS_CXA_ID
        {
            get { return _RTS_CXA_ID; }
            set { _RTS_CXA_ID = value; }
        }
        public int? RTS_SLT_USR_ID
        {
            get { return _RTS_SLT_USR_ID; }
            set { _RTS_SLT_USR_ID = value; }
        }
        public string RTS_CST
        {
            get { return _RTS_CST; }
            set { _RTS_CST = value.ToUpper(); }
        }
        public DateTime? RTS_DAT
        {
            get { return _RTS_DAT; }
            set { _RTS_DAT = value; }
        }
        public string RTS_OBS_SLT
        {
            get { return _RTS_OBS_SLT; }
            set { _RTS_OBS_SLT = value.ToUpper(); }
        }
        public int? RTS_FOR_001_ID
        {
            get { return _RTS_FOR_001_ID; }
            set { _RTS_FOR_001_ID = value; }
        }
        public int? RTS_FOR_002_ID
        {
            get { return _RTS_FOR_002_ID; }
            set { _RTS_FOR_002_ID = value; }
        }
        public int? RTS_FOR_003_ID
        {
            get { return _RTS_FOR_003_ID; }
            set { _RTS_FOR_003_ID = value; }
        }
        public int? RTS_FOR_004_ID
        {
            get { return _RTS_FOR_004_ID; }
            set { _RTS_FOR_004_ID = value; }
        }
        public int? RTS_SPA
        {
            get { return _RTS_SPA; }
            set { _RTS_SPA = value; }
        }
        public int? RTS_MAQ_TIP_ID
        {
            get { return _RTS_MAQ_TIP_ID; }
            set { _RTS_MAQ_TIP_ID = value; }
        }
        public int? RTS_MAQ_ID
        {
            get { return _RTS_MAQ_ID; }
            set { _RTS_MAQ_ID = value; }
        }
        public string RTS_MGE
        {
            get { return _RTS_MGE; }
            set { _RTS_MGE = value.ToUpper(); }
        }
        public string RTS_MGE_002
        {
            get { return _RTS_MGE_002; }
            set { _RTS_MGE_002 = value.ToUpper(); }
        }
        public string RTS_MGE_003
        {
            get { return _RTS_MGE_003; }
            set { _RTS_MGE_003 = value.ToUpper(); }
        }
        public string RTS_MGE_004
        {
            get { return _RTS_MGE_004; }
            set { _RTS_MGE_004 = value.ToUpper(); }
        }
        public DateTime? RTS_LOG_DAT
        {
            get { return _RTS_LOG_DAT; }
            set { _RTS_LOG_DAT = value; }
        }
        public int? RTS_LOG_USR_ID
        {
            get { return _RTS_LOG_USR_ID; }
            set { _RTS_LOG_USR_ID = value; }
        }
        public string RTS_OBS_LOG
        {
            get { return _RTS_OBS_LOG; }
            set { _RTS_OBS_LOG = value.ToUpper(); }
        }
        public string RTS_VLI
        {
            get { return _RTS_VLI; }
            set { _RTS_VLI = value.ToUpper(); }
        }
        public string RTS_JTF
        {
            get { return _RTS_JTF; }
            set { _RTS_JTF = value.ToUpper(); }
        }
        public string RTS_LOT
        {
            get { return _RTS_LOT; }
            set { _RTS_LOT = value.ToUpper(); }
        }
        public double? RTS_TIT
        {
            get { return _RTS_TIT; }
            set { _RTS_TIT = value; }
        }
        public int? RTS_VEL
        {
            get { return _RTS_VEL; }
            set { _RTS_VEL = value; }
        }
        public int? RTS_CBO
        {
            get { return _RTS_CBO; }
            set { _RTS_CBO = value; }
        }
        public double? RTS_PAO_001
        {
            get { return _RTS_PAO_001; }
            set { _RTS_PAO_001 = value; }
        }
        public double? RTS_PAO_002
        {
            get { return _RTS_PAO_002; }
            set { _RTS_PAO_002 = value; }
        }
        public string RTS_JET_001
        {
            get { return _RTS_JET_001; }
            set { _RTS_JET_001 = value; }
        }
        public string RTS_JET_002
        {
            get { return _RTS_JET_002; }
            set { _RTS_JET_002 = value; }
        }
        public double? RTS_OLE
        {
            get { return _RTS_OLE; }
            set { _RTS_OLE = value; }
        }
        public double? RTS_PES_SUP
        {
            get { return _RTS_PES_SUP; }
            set { _RTS_PES_SUP = value; }
        }
        public double? RTS_EFC
        {
            get { return _RTS_EFC; }
            set { _RTS_EFC = value; }
        }
        public double? RTS_PRC
        {
            get { return _RTS_PRC; }
            set { _RTS_PRC = value; }
        }
        public double? RTS_QBR_TUR
        {
            get { return _RTS_QBR_TUR; }
            set { _RTS_QBR_TUR = value; }
        }
        public double? RTS_QBR_KIO
        {
            get { return _RTS_QBR_KIO; }
            set { _RTS_QBR_KIO = value; }
        }
        public double? RTS_QBR_PNV
        {
            get { return _RTS_QBR_PNV; }
            set { _RTS_QBR_PNV = value; }
        }
        public double? RTS_QBR_DNV
        {
            get { return _RTS_QBR_DNV; }
            set { _RTS_QBR_DNV = value; }
        }
        public double? RTS_QBR_CAR
        {
            get { return _RTS_QBR_CAR; }
            set { _RTS_QBR_CAR = value; }
        }
        public DateTime? RTS_PED_DAT
        {
            get { return _RTS_PED_DAT; }
            set { _RTS_PED_DAT = value; }
        }
        public int? RTS_PED_USR_ID
        {
            get { return _RTS_PED_USR_ID; }
            set { _RTS_PED_USR_ID = value; }
        }
        public string RTS_DMO
        {
            get { return _RTS_DMO; }
            set { _RTS_DMO = value.ToUpper(); }
        }
        public string RTS_PES
        {
            get { return _RTS_PES; }
            set { _RTS_PES = value.ToUpper(); }
        }
        public string RTS_SPE
        {
            get { return _RTS_SPE; }
            set { _RTS_SPE = value.ToUpper(); }
        }
        public string RTS_OBS_PED
        {
            get { return _RTS_OBS_PED; }
            set { _RTS_OBS_PED = value.ToUpper(); }
        }
        public DateTime? RTS_DAT_DSV
        {
            get { return _RTS_DAT_DSV; }
            set { _RTS_DAT_DSV = value; }
        }
        public DateTime? RTS_PJT_DAT
        {
            get { return _RTS_PJT_DAT; }
            set { _RTS_PJT_DAT = value; }
        }
        public int? RTS_PJT_USR_ID
        {
            get { return _RTS_PJT_USR_ID; }
            set { _RTS_PJT_USR_ID = value; }
        }
        public string RTS_OBS_PCP
        {
            get { return _RTS_OBS_PCP; }
            set { _RTS_OBS_PCP = value.ToUpper(); }
        }
        public int? RTS_STS
        {
            get { return _RTS_STS; }
            set { _RTS_STS = value; }
        }
        public int? RTS_USR_INC_ID
        {
            get { return _RTS_USR_INC_ID; }
            set { _RTS_USR_INC_ID = value; }
        }
        public int? RTS_USR_ALT_ID
        {
            get { return _RTS_USR_ALT_ID; }
            set { _RTS_USR_ALT_ID = value; }
        }
        public DateTime? RTS_TMS_ATL
        {
            get { return _RTS_TMS_ATL; }
            set { _RTS_TMS_ATL = value; }
        }

        public DateTime? RTS_DAT_INI
        {
            get { return _RTS_DAT_INI; }
            set { _RTS_DAT_INI = value; }
        }

        public DateTime? RTS_DAT_FIM
        {
            get { return _RTS_DAT_FIM; }
            set { _RTS_DAT_FIM = value; }
        }
        public DateTime? RTS_LOG_DAT_INI
        {
            get { return _RTS_LOG_DAT_INI; }
            set { _RTS_LOG_DAT_INI = value; }
        }

        public DateTime? RTS_LOG_DAT_FIM
        {
            get { return _RTS_LOG_DAT_FIM; }
            set { _RTS_LOG_DAT_FIM = value; }
        }
        public DateTime? RTS_PED_DAT_INI
        {
            get { return _RTS_PED_DAT_INI; }
            set { _RTS_PED_DAT_INI = value; }
        }

        public DateTime? RTS_PED_DAT_FIM
        {
            get { return _RTS_PED_DAT_FIM; }
            set { _RTS_PED_DAT_FIM = value; }
        }
        public DateTime? RTS_DAT_DSV_INI
        {
            get { return _RTS_DAT_DSV_INI; }
            set { _RTS_DAT_DSV_INI = value; }
        }

        public DateTime? RTS_DAT_DSV_FIM
        {
            get { return _RTS_DAT_DSV_FIM; }
            set { _RTS_DAT_DSV_FIM = value; }
        }
        public DateTime? RTS_PJT_DAT_INI
        {
            get { return _RTS_PJT_DAT_INI; }
            set { _RTS_PJT_DAT_INI = value; }
        }

        public DateTime? RTS_PJT_DAT_FIM
        {
            get { return _RTS_PJT_DAT_FIM; }
            set { _RTS_PJT_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO RTS (";
            sSQL = sSQL + "RTS_MTV_TST_ID, ";
            sSQL = sSQL + "RTS_TIT_POY_ID, ";
            sSQL = sSQL + "RTS_ERT_ID, ";
            sSQL = sSQL + "RTS_APS_ID, ";
            sSQL = sSQL + "RTS_SCC_TRV_ID, ";
            sSQL = sSQL + "RTS_MTD_ID, ";
            sSQL = sSQL + "RTS_COR_ID, ";
            sSQL = sSQL + "RTS_CLI_ID, ";
            sSQL = sSQL + "RTS_FIO_ID, ";
            sSQL = sSQL + "RTS_GRP_MRL_ID, ";
            sSQL = sSQL + "RTS_LOT_REF, ";
            sSQL = sSQL + "RTS_VLC, ";
            sSQL = sSQL + "RTS_MRC_ID, ";
            sSQL = sSQL + "RTS_ESL_ID, ";
            sSQL = sSQL + "RTS_CXA_ID, ";
            sSQL = sSQL + "RTS_SLT_USR_ID, ";
            sSQL = sSQL + "RTS_CST, ";
            sSQL = sSQL + "RTS_DAT, ";
            sSQL = sSQL + "RTS_OBS_SLT, ";
            sSQL = sSQL + "RTS_FOR_001_ID, ";
            sSQL = sSQL + "RTS_FOR_002_ID, ";
            sSQL = sSQL + "RTS_FOR_003_ID, ";
            sSQL = sSQL + "RTS_FOR_004_ID, ";
            sSQL = sSQL + "RTS_SPA, ";
            sSQL = sSQL + "RTS_MAQ_TIP_ID, ";
            sSQL = sSQL + "RTS_MAQ_ID, ";
            sSQL = sSQL + "RTS_MGE, ";
            sSQL = sSQL + "RTS_MGE_002, ";
            sSQL = sSQL + "RTS_MGE_003, ";
            sSQL = sSQL + "RTS_MGE_004, ";
            sSQL = sSQL + "RTS_LOG_DAT, ";
            sSQL = sSQL + "RTS_LOG_USR_ID, ";
            sSQL = sSQL + "RTS_OBS_LOG, ";
            sSQL = sSQL + "RTS_VLI, ";
            sSQL = sSQL + "RTS_JTF, ";
            sSQL = sSQL + "RTS_LOT, ";
            sSQL = sSQL + "RTS_TIT, ";
            sSQL = sSQL + "RTS_VEL, ";
            sSQL = sSQL + "RTS_CBO, ";
            sSQL = sSQL + "RTS_PAO_001, ";
            sSQL = sSQL + "RTS_PAO_002, ";
            sSQL = sSQL + "RTS_JET_001, ";
            sSQL = sSQL + "RTS_JET_002, ";
            sSQL = sSQL + "RTS_OLE, ";
            sSQL = sSQL + "RTS_PES_SUP, ";
            sSQL = sSQL + "RTS_EFC, ";
            sSQL = sSQL + "RTS_PRC, ";
            sSQL = sSQL + "RTS_QBR_TUR, ";
            sSQL = sSQL + "RTS_QBR_KIO, ";
            sSQL = sSQL + "RTS_QBR_PNV, ";
            sSQL = sSQL + "RTS_QBR_DNV, ";
            sSQL = sSQL + "RTS_QBR_CAR, ";
            sSQL = sSQL + "RTS_PED_DAT, ";
            sSQL = sSQL + "RTS_PED_USR_ID, ";
            sSQL = sSQL + "RTS_DMO, ";
            sSQL = sSQL + "RTS_PES, ";
            sSQL = sSQL + "RTS_SPE, ";
            sSQL = sSQL + "RTS_OBS_PED, ";
            sSQL = sSQL + "RTS_DAT_DSV, ";
            sSQL = sSQL + "RTS_PJT_DAT, ";
            sSQL = sSQL + "RTS_PJT_USR_ID, ";
            sSQL = sSQL + "RTS_OBS_PCP, ";
            sSQL = sSQL + "RTS_STS, ";
            sSQL = sSQL + "RTS_USR_INC_ID, ";
            sSQL = sSQL + "RTS_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(RTS_MTV_TST_ID.ToString()))
            {
                sSQL = sSQL + RTS_MTV_TST_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + RTS_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_ERT_ID.ToString()))
            {
                sSQL = sSQL + RTS_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_APS_ID.ToString()))
            {
                sSQL = sSQL + RTS_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SCC_TRV_ID.ToString()))
            {
                sSQL = sSQL + RTS_SCC_TRV_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MTD_ID.ToString()))
            {
                sSQL = sSQL + RTS_MTD_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_COR_ID.ToString()))
            {
                sSQL = sSQL + RTS_COR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CLI_ID.ToString()))
            {
                sSQL = sSQL + RTS_CLI_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FIO_ID.ToString()))
            {
                sSQL = sSQL + RTS_FIO_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_GRP_MRL_ID.ToString()))
            {
                sSQL = sSQL + RTS_GRP_MRL_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOT_REF))
            {
                sSQL = sSQL + "'" + RTS_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VLC))
            {
                sSQL = sSQL + "'" + RTS_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MRC_ID.ToString()))
            {
                sSQL = sSQL + RTS_MRC_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_ESL_ID.ToString()))
            {
                sSQL = sSQL + RTS_ESL_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CXA_ID.ToString()))
            {
                sSQL = sSQL + RTS_CXA_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SLT_USR_ID.ToString()))
            {
                sSQL = sSQL + RTS_SLT_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CST))
            {
                sSQL = sSQL + "'" + RTS_CST.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + RTS_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_SLT))
            {
                sSQL = sSQL + "'" + RTS_OBS_SLT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_001_ID.ToString()))
            {
                sSQL = sSQL + RTS_FOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + RTS_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + RTS_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_004_ID.ToString()))
            {
                sSQL = sSQL + RTS_FOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SPA.ToString()))
            {
                sSQL = sSQL + RTS_SPA + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + RTS_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MAQ_ID.ToString()))
            {
                sSQL = sSQL + RTS_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE))
            {
                sSQL = sSQL + "'" + RTS_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_002))
            {
                sSQL = sSQL + "'" + RTS_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_003))
            {
                sSQL = sSQL + "'" + RTS_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_004))
            {
                sSQL = sSQL + "'" + RTS_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOG_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + RTS_LOG_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOG_USR_ID.ToString()))
            {
                sSQL = sSQL + RTS_LOG_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_LOG))
            {
                sSQL = sSQL + "'" + RTS_OBS_LOG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VLI))
            {
                sSQL = sSQL + "'" + RTS_VLI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JTF))
            {
                sSQL = sSQL + "'" + RTS_JTF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOT))
            {
                sSQL = sSQL + "'" + RTS_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_TIT.ToString()))
            {
                sSQL = sSQL + RTS_TIT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VEL.ToString()))
            {
                sSQL = sSQL + RTS_VEL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CBO.ToString()))
            {
                sSQL = sSQL + RTS_CBO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PAO_001.ToString()))
            {
                sSQL = sSQL + RTS_PAO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PAO_002.ToString()))
            {
                sSQL = sSQL + RTS_PAO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JET_001))
            {
                sSQL = sSQL + "'" + RTS_JET_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JET_002))
            {
                sSQL = sSQL + "'" + RTS_JET_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OLE.ToString()))
            {
                sSQL = sSQL + RTS_OLE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PES_SUP.ToString()))
            {
                sSQL = sSQL + RTS_PES_SUP.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_EFC.ToString()))
            {
                sSQL = sSQL + RTS_EFC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PRC.ToString()))
            {
                sSQL = sSQL + RTS_PRC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_TUR.ToString()))
            {
                sSQL = sSQL + RTS_QBR_TUR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_KIO.ToString()))
            {
                sSQL = sSQL + RTS_QBR_KIO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_PNV.ToString()))
            {
                sSQL = sSQL + RTS_QBR_PNV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_DNV.ToString()))
            {
                sSQL = sSQL + RTS_QBR_DNV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_CAR.ToString()))
            {
                sSQL = sSQL + RTS_QBR_CAR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PED_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + RTS_PED_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PED_USR_ID.ToString()))
            {
                sSQL = sSQL + RTS_PED_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DMO))
            {
                sSQL = sSQL + "'" + RTS_DMO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PES))
            {
                sSQL = sSQL + "'" + RTS_PES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SPE))
            {
                sSQL = sSQL + "'" + RTS_SPE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_PED))
            {
                sSQL = sSQL + "'" + RTS_OBS_PED.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DAT_DSV.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + RTS_DAT_DSV + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PJT_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + RTS_PJT_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PJT_USR_ID.ToString()))
            {
                sSQL = sSQL + RTS_PJT_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_PCP))
            {
                sSQL = sSQL + "'" + RTS_OBS_PCP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_STS.ToString()))
            {
                sSQL = sSQL + RTS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + RTS_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE RTS ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(RTS_MTV_TST_ID.ToString()))
            {
                sSQL = sSQL + "RTS_MTV_TST_ID = " + RTS_MTV_TST_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_MTV_TST_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_TIT_POY_ID.ToString()))
            {
                sSQL = sSQL + "RTS_TIT_POY_ID = " + RTS_TIT_POY_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_TIT_POY_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_ERT_ID.ToString()))
            {
                sSQL = sSQL + "RTS_ERT_ID = " + RTS_ERT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_ERT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_APS_ID.ToString()))
            {
                sSQL = sSQL + "RTS_APS_ID = " + RTS_APS_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_APS_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SCC_TRV_ID.ToString()))
            {
                sSQL = sSQL + "RTS_SCC_TRV_ID = " + RTS_SCC_TRV_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_SCC_TRV_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MTD_ID.ToString()))
            {
                sSQL = sSQL + "RTS_MTD_ID = " + RTS_MTD_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_MTD_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_COR_ID.ToString()))
            {
                sSQL = sSQL + "RTS_COR_ID = " + RTS_COR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_COR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CLI_ID.ToString()))
            {
                sSQL = sSQL + "RTS_CLI_ID = " + RTS_CLI_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_CLI_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FIO_ID.ToString()))
            {
                sSQL = sSQL + "RTS_FIO_ID = " + RTS_FIO_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_FIO_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_GRP_MRL_ID.ToString()))
            {
                sSQL = sSQL + "RTS_GRP_MRL_ID = " + RTS_GRP_MRL_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_GRP_MRL_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOT_REF))
            {
                sSQL = sSQL + "RTS_LOT_REF = '" + RTS_LOT_REF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_LOT_REF = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VLC))
            {
                sSQL = sSQL + "RTS_VLC = '" + RTS_VLC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MRC_ID.ToString()))
            {
                sSQL = sSQL + "RTS_MRC_ID = " + RTS_MRC_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_MRC_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_ESL_ID.ToString()))
            {
                sSQL = sSQL + "RTS_ESL_ID = " + RTS_ESL_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_ESL_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CXA_ID.ToString()))
            {
                sSQL = sSQL + "RTS_CXA_ID = " + RTS_CXA_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_CXA_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SLT_USR_ID.ToString()))
            {
                sSQL = sSQL + "RTS_SLT_USR_ID = " + RTS_SLT_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_SLT_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CST))
            {
                sSQL = sSQL + "RTS_CST = '" + RTS_CST.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_CST = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DAT.ToString()))
            {
                sSQL = sSQL + "RTS_DAT = Convert(datetime, '" + RTS_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "RTS_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_SLT))
            {
                sSQL = sSQL + "RTS_OBS_SLT = '" + RTS_OBS_SLT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_OBS_SLT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_001_ID.ToString()))
            {
                sSQL = sSQL + "RTS_FOR_001_ID = " + RTS_FOR_001_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_FOR_001_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_002_ID.ToString()))
            {
                sSQL = sSQL + "RTS_FOR_002_ID = " + RTS_FOR_002_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_FOR_002_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_003_ID.ToString()))
            {
                sSQL = sSQL + "RTS_FOR_003_ID = " + RTS_FOR_003_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_FOR_003_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_FOR_004_ID.ToString()))
            {
                sSQL = sSQL + "RTS_FOR_004_ID = " + RTS_FOR_004_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_FOR_004_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SPA.ToString()))
            {
                sSQL = sSQL + "RTS_SPA = " + RTS_SPA + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_SPA = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "RTS_MAQ_TIP_ID = " + RTS_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MAQ_ID.ToString()))
            {
                sSQL = sSQL + "RTS_MAQ_ID = " + RTS_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_MAQ_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE))
            {
                sSQL = sSQL + "RTS_MGE = '" + RTS_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_002))
            {
                sSQL = sSQL + "RTS_MGE_002 = '" + RTS_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_MGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_003))
            {
                sSQL = sSQL + "RTS_MGE_003 = '" + RTS_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_MGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_MGE_004))
            {
                sSQL = sSQL + "RTS_MGE_004 = '" + RTS_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_MGE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOG_DAT.ToString()))
            {
                sSQL = sSQL + "RTS_LOG_DAT = Convert(datetime, '" + RTS_LOG_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "RTS_LOG_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOG_USR_ID.ToString()))
            {
                sSQL = sSQL + "RTS_LOG_USR_ID = " + RTS_LOG_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_LOG_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_LOG))
            {
                sSQL = sSQL + "RTS_OBS_LOG = '" + RTS_OBS_LOG.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_OBS_LOG = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VLI))
            {
                sSQL = sSQL + "RTS_VLI = '" + RTS_VLI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_VLI = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JTF))
            {
                sSQL = sSQL + "RTS_JTF = '" + RTS_JTF.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_JTF = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_LOT))
            {
                sSQL = sSQL + "RTS_LOT = '" + RTS_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_TIT.ToString()))
            {
                sSQL = sSQL + "RTS_TIT = " + RTS_TIT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_TIT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_VEL.ToString()))
            {
                sSQL = sSQL + "RTS_VEL = " + RTS_VEL.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_VEL = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_CBO.ToString()))
            {
                sSQL = sSQL + "RTS_CBO = " + RTS_CBO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_CBO = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PAO_001.ToString()))
            {
                sSQL = sSQL + "RTS_PAO_001 = " + RTS_PAO_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PAO_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PAO_002.ToString()))
            {
                sSQL = sSQL + "RTS_PAO_002 = " + RTS_PAO_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PAO_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JET_001))
            {
                sSQL = sSQL + "RTS_JET_001 = '" + RTS_JET_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_JET_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_JET_002))
            {
                sSQL = sSQL + "RTS_JET_002 = '" + RTS_JET_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_JET_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OLE.ToString()))
            {
                sSQL = sSQL + "RTS_OLE = " + RTS_OLE.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_OLE = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PES_SUP.ToString()))
            {
                sSQL = sSQL + "RTS_PES_SUP = " + RTS_PES_SUP.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PES_SUP = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_EFC.ToString()))
            {
                sSQL = sSQL + "RTS_EFC = " + RTS_EFC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_EFC = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PRC.ToString()))
            {
                sSQL = sSQL + "RTS_PRC = " + RTS_PRC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PRC = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_TUR.ToString()))
            {
                sSQL = sSQL + "RTS_QBR_TUR = " + RTS_QBR_TUR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_QBR_TUR = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_KIO.ToString()))
            {
                sSQL = sSQL + "RTS_QBR_KIO = " + RTS_QBR_KIO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_QBR_KIO = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_PNV.ToString()))
            {
                sSQL = sSQL + "RTS_QBR_PNV = " + RTS_QBR_PNV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_QBR_PNV = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_DNV.ToString()))
            {
                sSQL = sSQL + "RTS_QBR_DNV = " + RTS_QBR_DNV.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_QBR_DNV = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_QBR_CAR.ToString()))
            {
                sSQL = sSQL + "RTS_QBR_CAR = " + RTS_QBR_CAR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_QBR_CAR = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PED_DAT.ToString()))
            {
                sSQL = sSQL + "RTS_PED_DAT = Convert(datetime, '" + RTS_PED_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "RTS_PED_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PED_USR_ID.ToString()))
            {
                sSQL = sSQL + "RTS_PED_USR_ID = " + RTS_PED_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PED_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DMO))
            {
                sSQL = sSQL + "RTS_DMO = '" + RTS_DMO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_DMO = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PES))
            {
                sSQL = sSQL + "RTS_PES = '" + RTS_PES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_PES = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_SPE))
            {
                sSQL = sSQL + "RTS_SPE = '" + RTS_SPE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_SPE = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_PED))
            {
                sSQL = sSQL + "RTS_OBS_PED = '" + RTS_OBS_PED.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_OBS_PED = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_DAT_DSV.ToString()))
            {
                sSQL = sSQL + "RTS_DAT_DSV = Convert(datetime, '" + RTS_DAT_DSV + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "RTS_DAT_DSV = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PJT_DAT.ToString()))
            {
                sSQL = sSQL + "RTS_PJT_DAT = Convert(datetime, '" + RTS_PJT_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "RTS_PJT_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_PJT_USR_ID.ToString()))
            {
                sSQL = sSQL + "RTS_PJT_USR_ID = " + RTS_PJT_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_PJT_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_OBS_PCP))
            {
                sSQL = sSQL + "RTS_OBS_PCP = '" + RTS_OBS_PCP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "RTS_OBS_PCP = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_STS.ToString()))
            {
                sSQL = sSQL + "RTS_STS = " + RTS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(RTS_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "RTS_USR_ALT_ID = " + RTS_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "RTS_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "RTS_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE RTS_ID = " + RTS_ID;

            SQL = sSQL;

            return dbConn.Executar(sSQL);
            
        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM RTS";
            sSQL = sSQL + " WHERE RTS_ID = " + RTS_ID;

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
            sSQL = sSQL + " ,CASE RTS_STS ";
            sSQL = sSQL + "    WHEN 1 THEN 'SOLICITADO' ";
            sSQL = sSQL + "    WHEN 2 THEN 'LOGISTICA' ";
            sSQL = sSQL + "    WHEN 3 THEN 'P&D' ";
            sSQL = sSQL + "    WHEN 4 THEN 'PCP' ";
            sSQL = sSQL + "    WHEN 5 THEN 'PRODUÇÃO' ";
            sSQL = sSQL + "    WHEN 0 THEN 'CANCELADO' ";
            sSQL = sSQL + "    ELSE CONVERT(VARCHAR(02), RTS_STS) + ' - OUTRO' ";
            sSQL = sSQL + "  END STS_DES ";
            sSQL = sSQL + " FROM RTS";
            sSQL = sSQL + " INNER JOIN ERT ON ERT_ID = RTS_ERT_ID";
            sSQL = sSQL + " INNER JOIN APS ON APS_ID = RTS_APS_ID";
            sSQL = sSQL + " INNER JOIN MTV_TST ON MTV_TST_ID = RTS_MTV_TST_ID";
            sSQL = sSQL + " INNER JOIN USR ON USR_ID = RTS_SLT_USR_ID";
            sSQL = sSQL + " LEFT JOIN [FOR] FOR_001 ON FOR_001.FOR_ID = RTS_FOR_001_ID";
            sSQL = sSQL + " LEFT JOIN [FOR] FOR_002 ON FOR_002.FOR_ID = RTS_FOR_002_ID";
            sSQL = sSQL + " LEFT JOIN [FOR] FOR_003 ON FOR_003.FOR_ID = RTS_FOR_003_ID";
            sSQL = sSQL + " LEFT JOIN [FOR] FOR_004 ON FOR_004.FOR_ID = RTS_FOR_004_ID";
            sSQL = sSQL + " LEFT JOIN MAQ_TIP ON MAQ_TIP_ID = RTS_MAQ_TIP_ID";
            sSQL = sSQL + " LEFT JOIN MAQ ON MAQ_ID = RTS_MAQ_ID";
            sSQL = sSQL + " LEFT JOIN FIO ON FIO_ID = RTS_FIO_ID";
            sSQL = sSQL + " LEFT JOIN GRP_MRL ON GRP_MRL_ID = RTS_GRP_MRL_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_ID)))
            {
                sCond = sCond + " RTS_ID = " + RTS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_MTV_TST_ID)))
            {
                sCond = sCond + " RTS_MTV_TST_ID = " + RTS_MTV_TST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_TIT_POY_ID)))
            {
                sCond = sCond + " RTS_TIT_POY_ID = " + RTS_TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_ERT_ID)))
            {
                sCond = sCond + " RTS_ERT_ID = " + RTS_ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_APS_ID)))
            {
                sCond = sCond + " RTS_APS_ID = " + RTS_APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_SCC_TRV_ID)))
            {
                sCond = sCond + " RTS_SCC_TRV_ID = " + RTS_SCC_TRV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_MTD_ID)))
            {
                sCond = sCond + " RTS_MTD_ID = " + RTS_MTD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_COR_ID)))
            {
                sCond = sCond + " RTS_COR_ID = " + RTS_COR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_CLI_ID)))
            {
                sCond = sCond + " RTS_CLI_ID = " + RTS_CLI_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_FIO_ID)))
            {
                sCond = sCond + " RTS_FIO_ID = " + RTS_FIO_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_GRP_MRL_ID)))
            {
                sCond = sCond + " RTS_GRP_MRL_ID = " + RTS_GRP_MRL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_MRC_ID)))
            {
                sCond = sCond + " RTS_MRC_ID = " + RTS_MRC_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_ESL_ID)))
            {
                sCond = sCond + " RTS_ESL_ID = " + RTS_ESL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_CXA_ID)))
            {
                sCond = sCond + " RTS_CXA_ID = " + RTS_CXA_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_SLT_USR_ID)))
            {
                sCond = sCond + " RTS_SLT_USR_ID = " + RTS_SLT_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT)))
            {
                sCond = sCond + " RTS_DAT BETWEEN Convert(datetime, '" + RTS_DAT + "',103) AND Convert(datetime, '" + RTS_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT_INI)))
            {
                sCond = sCond + " RTS_DAT >= Convert(datetime, '" + RTS_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT_FIM)))
            {
                sCond = sCond + " RTS_DAT <= Convert(datetime, '" + RTS_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_FOR_001_ID)))
            {
                sCond = sCond + " RTS_FOR_001_ID = " + RTS_FOR_001_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_MAQ_TIP_ID)))
            {
                sCond = sCond + " RTS_MAQ_TIP_ID = " + RTS_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_MAQ_ID)))
            {
                sCond = sCond + " RTS_MAQ_ID = " + RTS_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_LOG_DAT)))
            {
                sCond = sCond + " RTS_LOG_DAT BETWEEN Convert(datetime, '" + RTS_LOG_DAT + "',103) AND Convert(datetime, '" + RTS_LOG_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_LOG_DAT_INI)))
            {
                sCond = sCond + " RTS_LOG_DAT >= Convert(datetime, '" + RTS_LOG_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_LOG_DAT_FIM)))
            {
                sCond = sCond + " RTS_LOG_DAT <= Convert(datetime, '" + RTS_LOG_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_LOG_USR_ID)))
            {
                sCond = sCond + " RTS_LOG_USR_ID = " + RTS_LOG_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PED_DAT)))
            {
                sCond = sCond + " RTS_PED_DAT BETWEEN Convert(datetime, '" + RTS_PED_DAT + "',103) AND Convert(datetime, '" + RTS_PED_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PED_DAT_INI)))
            {
                sCond = sCond + " RTS_PED_DAT >= Convert(datetime, '" + RTS_PED_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PED_DAT_FIM)))
            {
                sCond = sCond + " RTS_PED_DAT <= Convert(datetime, '" + RTS_PED_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PED_USR_ID)))
            {
                sCond = sCond + " RTS_PED_USR_ID = " + RTS_PED_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT_DSV)))
            {
                sCond = sCond + " RTS_DAT_DSV BETWEEN Convert(datetime, '" + RTS_DAT_DSV + "',103) AND Convert(datetime, '" + RTS_DAT_DSV + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT_DSV_INI)))
            {
                sCond = sCond + " RTS_DAT_DSV >= Convert(datetime, '" + RTS_DAT_DSV_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_DAT_DSV_FIM)))
            {
                sCond = sCond + " RTS_DAT_DSV <= Convert(datetime, '" + RTS_DAT_DSV_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PJT_DAT)))
            {
                sCond = sCond + " RTS_PJT_DAT BETWEEN Convert(datetime, '" + RTS_PJT_DAT + "',103) AND Convert(datetime, '" + RTS_PJT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PJT_DAT_INI)))
            {
                sCond = sCond + " RTS_PJT_DAT >= Convert(datetime, '" + RTS_PJT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PJT_DAT_FIM)))
            {
                sCond = sCond + " RTS_PJT_DAT <= Convert(datetime, '" + RTS_PJT_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_PJT_USR_ID)))
            {
                sCond = sCond + " RTS_PJT_USR_ID = " + RTS_PJT_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_LOT)))
            {
                sCond = sCond + " RTS_LOT = '" + RTS_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(RTS_STS)))
            {
                sCond = sCond + " RTS_STS = " + RTS_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY RTS_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}