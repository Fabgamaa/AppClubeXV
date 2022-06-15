using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Performance
    {

        #region Propriedades

        private int? _PFM_ID;
        private DateTime? _PFM_DAT;
        private string _PFM_LOT;
        private string _PFM_MGE;
        private int? _PFM_VLC;
        private string _PFM_TIT;
        private double? _PFM_QLD_001;
        private double? _PFM_OUT;
        private double? _PFM_QLD_002;
        private double? _PFM_QBR;
        private double? _PFM_AFN;
        private double? _PFM_UNT;
        private double? _PFM_PRC;
        private int? _PFM_STS;
        private int? _PFM_USR_INC_ID;
        private int? _PFM_USR_ALT_ID;
        private DateTime? _PFM_TMS_ATL;

        private DateTime? _PFM_DAT_INI;
        private DateTime? _PFM_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? PFM_ID
        {
            get { return _PFM_ID; }
            set { _PFM_ID = value; }
        }
        public DateTime? PFM_DAT
        {
            get { return _PFM_DAT; }
            set { _PFM_DAT = value; }
        }
        public string PFM_LOT
        {
            get { return _PFM_LOT; }
            set { _PFM_LOT = value.ToUpper(); }
        }
        public string PFM_MGE
        {
            get { return _PFM_MGE; }
            set { _PFM_MGE = value.ToUpper(); }
        }
        public int? PFM_VLC
        {
            get { return _PFM_VLC; }
            set { _PFM_VLC = value; }
        }
        public string PFM_TIT
        {
            get { return _PFM_TIT; }
            set { _PFM_TIT = value.ToUpper(); }
        }
        public double? PFM_QLD_001
        {
            get { return _PFM_QLD_001; }
            set { _PFM_QLD_001 = value; }
        }
        public double? PFM_OUT
        {
            get { return _PFM_OUT; }
            set { _PFM_OUT = value; }
        }
        public double? PFM_QLD_002
        {
            get { return _PFM_QLD_002; }
            set { _PFM_QLD_002 = value; }
        }
        public double? PFM_QBR
        {
            get { return _PFM_QBR; }
            set { _PFM_QBR = value; }
        }
        public double? PFM_AFN
        {
            get { return _PFM_AFN; }
            set { _PFM_AFN = value; }
        }
        public double? PFM_UNT
        {
            get { return _PFM_UNT; }
            set { _PFM_UNT = value; }
        }
        public double? PFM_PRC
        {
            get { return _PFM_PRC; }
            set { _PFM_PRC = value; }
        }
        public int? PFM_STS
        {
            get { return _PFM_STS; }
            set { _PFM_STS = value; }
        }
        public int? PFM_USR_INC_ID
        {
            get { return _PFM_USR_INC_ID; }
            set { _PFM_USR_INC_ID = value; }
        }
        public int? PFM_USR_ALT_ID
        {
            get { return _PFM_USR_ALT_ID; }
            set { _PFM_USR_ALT_ID = value; }
        }
        public DateTime? PFM_TMS_ATL
        {
            get { return _PFM_TMS_ATL; }
            set { _PFM_TMS_ATL = value; }
        }

        public DateTime? PFM_DAT_INI
        {
            get { return _PFM_DAT_INI; }
            set { _PFM_DAT_INI = value; }
        }

        public DateTime? PFM_DAT_FIM
        {
            get { return _PFM_DAT_FIM; }
            set { _PFM_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO PFM (";
            sSQL = sSQL + "PFM_DAT, ";
            sSQL = sSQL + "PFM_LOT, ";
            sSQL = sSQL + "PFM_MGE, ";
            sSQL = sSQL + "PFM_VLC, ";
            sSQL = sSQL + "PFM_TIT, ";
            sSQL = sSQL + "PFM_QLD_001, ";
            sSQL = sSQL + "PFM_OUT, ";
            sSQL = sSQL + "PFM_QLD_002, ";
            sSQL = sSQL + "PFM_QBR, ";
            sSQL = sSQL + "PFM_AFN, ";
            sSQL = sSQL + "PFM_UNT, ";
            sSQL = sSQL + "PFM_PRC, ";
            sSQL = sSQL + "PFM_STS, ";
            sSQL = sSQL + "PFM_USR_INC_ID, ";
            sSQL = sSQL + "PFM_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(PFM_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + PFM_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_LOT))
            {
                sSQL = sSQL + "'" + PFM_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_MGE))
            {
                sSQL = sSQL + "'" + PFM_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_VLC.ToString()))
            {
                sSQL = sSQL + PFM_VLC + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_TIT))
            {
                sSQL = sSQL + "'" + PFM_TIT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QLD_001.ToString()))
            {
                sSQL = sSQL + PFM_QLD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_OUT.ToString()))
            {
                sSQL = sSQL + PFM_OUT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QLD_002.ToString()))
            {
                sSQL = sSQL + PFM_QLD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QBR.ToString()))
            {
                sSQL = sSQL + PFM_QBR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_AFN.ToString()))
            {
                sSQL = sSQL + PFM_AFN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_UNT.ToString()))
            {
                sSQL = sSQL + PFM_UNT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_PRC.ToString()))
            {
                sSQL = sSQL + PFM_PRC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_STS.ToString()))
            {
                sSQL = sSQL + PFM_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + PFM_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE PFM ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(PFM_DAT.ToString()))
            {
                sSQL = sSQL + "PFM_DAT = Convert(datetime, '" + PFM_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "PFM_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_LOT))
            {
                sSQL = sSQL + "PFM_LOT = '" + PFM_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PFM_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_MGE))
            {
                sSQL = sSQL + "PFM_MGE = '" + PFM_MGE.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PFM_MGE = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_VLC.ToString()))
            {
                sSQL = sSQL + "PFM_VLC = " + PFM_VLC + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_VLC = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_TIT))
            {
                sSQL = sSQL + "PFM_TIT = '" + PFM_TIT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PFM_TIT = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QLD_001.ToString()))
            {
                sSQL = sSQL + "PFM_QLD_001 = " + PFM_QLD_001.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_QLD_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_OUT.ToString()))
            {
                sSQL = sSQL + "PFM_OUT = " + PFM_OUT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_OUT = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QLD_002.ToString()))
            {
                sSQL = sSQL + "PFM_QLD_002 = " + PFM_QLD_002.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_QLD_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_QBR.ToString()))
            {
                sSQL = sSQL + "PFM_QBR = " + PFM_QBR.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_QBR = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_AFN.ToString()))
            {
                sSQL = sSQL + "PFM_AFN = " + PFM_AFN.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_AFN = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_UNT.ToString()))
            {
                sSQL = sSQL + "PFM_UNT = " + PFM_UNT.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_UNT = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_PRC.ToString()))
            {
                sSQL = sSQL + "PFM_PRC = " + PFM_PRC.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_PRC = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_STS.ToString()))
            {
                sSQL = sSQL + "PFM_STS = " + PFM_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(PFM_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "PFM_USR_ALT_ID = " + PFM_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "PFM_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "PFM_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2); 
            sSQL = sSQL + " WHERE PFM_ID = " + PFM_ID;

            SQL = sSQL; 

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PFM";
            sSQL = sSQL + " WHERE PFM_ID = " + PFM_ID;

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
            sSQL = sSQL + " FROM PFM";
            if (!String.IsNullOrEmpty(Convert.ToString(PFM_ID)))
            {
                sCond = sCond + " PFM_ID = " + PFM_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PFM_LOT))
            {
                sCond = sCond + " PFM_LOT = '" + PFM_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(PFM_MGE))
            {
                sCond = sCond + " PFM_MGE = '" + PFM_MGE + "' AND ";
            }
            if (!String.IsNullOrEmpty(PFM_TIT))
            {
                sCond = sCond + " PFM_TIT = '" + PFM_TIT + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFM_DAT)))
            {
                sCond = sCond + " PFM_DAT BETWEEN Convert(datetime, '" + PFM_DAT + "',103) AND Convert(datetime, '" + PFM_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFM_DAT_INI)))
            {
                sCond = sCond + " PFM_DAT_INI >= Convert(datetime, '" + PFM_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFM_DAT_FIM)))
            {
                sCond = sCond + " PFM_DAT_FIM <= Convert(datetime, '" + PFM_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFM_STS)))
            {
                sCond = sCond + " PFM_STS = " + PFM_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PFM_ID";

            SQL = sSQL; 

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}