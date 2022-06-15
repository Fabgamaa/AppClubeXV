using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class DOFF
    {

        #region Propriedades

        private int? _DOF_ID;
        private int? _DOF_EPF_ID;
        private DateTime? _DOF_DAT;
        private string _DOF_MAQ;
        private int? _DOF_REJ;
        private int? _DOF_LIM;
        private int? _DOF_TOT;
        private string _DOF_LOT;
        private string _DOF_MGE_001;
        private string _DOF_MGE_002;
        private string _DOF_MGE_003;
        private string _DOF_MGE_004;
        private int? _DOF_STS;
        private int? _DOF_USR_INC_ID;
        private int? _DOF_USR_ALT_ID;
        private DateTime? _DOF_TMS_ATL;
        private DateTime? _DOF_DAT_INI;
        private DateTime? _DOF_DAT_FIM;
        private string _TOP;
        private string _SQL;

        public int? DOF_ID
        {
            get { return _DOF_ID; }
            set { _DOF_ID = value; }
        }
        public int? DOF_EPF_ID
        {
            get { return _DOF_EPF_ID; }
            set { _DOF_EPF_ID = value; }
        }
        public DateTime? DOF_DAT
        {
            get { return _DOF_DAT; }
            set { _DOF_DAT = value; }
        }
        public string DOF_MAQ
        {
            get { return _DOF_MAQ; }
            set { _DOF_MAQ = value.ToUpper(); }
        }
        public int? DOF_REJ
        {
            get { return _DOF_REJ; }
            set { _DOF_REJ = value; }
        }
        public int? DOF_LIM
        {
            get { return _DOF_LIM; }
            set { _DOF_LIM = value; }
        }
        public int? DOF_TOT
        {
            get { return _DOF_TOT; }
            set { _DOF_TOT = value; }
        }
        public string DOF_LOT
        {
            get { return _DOF_LOT; }
            set { _DOF_LOT = value.ToUpper(); }
        }
        public string DOF_MGE_001
        {
            get { return _DOF_MGE_001; }
            set { _DOF_MGE_001 = value.ToUpper(); }
        }
        public string DOF_MGE_002
        {
            get { return _DOF_MGE_002; }
            set { _DOF_MGE_002 = value.ToUpper(); }
        }
        public string DOF_MGE_003
        {
            get { return _DOF_MGE_003; }
            set { _DOF_MGE_003 = value.ToUpper(); }
        }
        public string DOF_MGE_004
        {
            get { return _DOF_MGE_004; }
            set { _DOF_MGE_004 = value.ToUpper(); }
        }
        public int? DOF_STS
        {
            get { return _DOF_STS; }
            set { _DOF_STS = value; }
        }
        public int? DOF_USR_INC_ID
        {
            get { return _DOF_USR_INC_ID; }
            set { _DOF_USR_INC_ID = value; }
        }
        public int? DOF_USR_ALT_ID
        {
            get { return _DOF_USR_ALT_ID; }
            set { _DOF_USR_ALT_ID = value; }
        }
        public DateTime? DOF_TMS_ATL
        {
            get { return _DOF_TMS_ATL; }
            set { _DOF_TMS_ATL = value; }
        }

        public DateTime? DOF_DAT_INI
        {
            get { return _DOF_DAT_INI; }
            set { _DOF_DAT_INI = value; }
        }

        public DateTime? DOF_DAT_FIM
        {
            get { return _DOF_DAT_FIM; }
            set { _DOF_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO DOF (";
            sSQL = sSQL + "DOF_EPF_ID, ";
            sSQL = sSQL + "DOF_DAT, ";
            sSQL = sSQL + "DOF_MAQ, ";
            sSQL = sSQL + "DOF_REJ, ";
            sSQL = sSQL + "DOF_LIM, ";
            sSQL = sSQL + "DOF_TOT, ";
            sSQL = sSQL + "DOF_LOT, ";
            sSQL = sSQL + "DOF_MGE_001, ";
            sSQL = sSQL + "DOF_MGE_002, ";
            sSQL = sSQL + "DOF_MGE_003, ";
            sSQL = sSQL + "DOF_MGE_004, ";
            sSQL = sSQL + "DOF_STS, ";
            sSQL = sSQL + "DOF_USR_INC_ID, ";
            sSQL = sSQL + "DOF_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(DOF_EPF_ID.ToString()))
            {
                sSQL = sSQL + DOF_EPF_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + DOF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MAQ))
            {
                sSQL = sSQL + "'" + DOF_MAQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_REJ.ToString()))
            {
                sSQL = sSQL + DOF_REJ + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_LIM.ToString()))
            {
                sSQL = sSQL + DOF_LIM + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_TOT.ToString()))
            {
                sSQL = sSQL + DOF_TOT + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_LOT))
            {
                sSQL = sSQL + "'" + DOF_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_001))
            {
                sSQL = sSQL + "'" + DOF_MGE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_002))
            {
                sSQL = sSQL + "'" + DOF_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_003))
            {
                sSQL = sSQL + "'" + DOF_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_004))
            {
                sSQL = sSQL + "'" + DOF_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_STS.ToString()))
            {
                sSQL = sSQL + DOF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + DOF_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE DOF ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(DOF_EPF_ID.ToString()))
            {
                sSQL = sSQL + "DOF_EPF_ID = " + DOF_EPF_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_EPF_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_DAT.ToString()))
            {
                sSQL = sSQL + "DOF_DAT = Convert(datetime, '" + DOF_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "DOF_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MAQ))
            {
                sSQL = sSQL + "DOF_MAQ = '" + DOF_MAQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_MAQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_REJ.ToString()))
            {
                sSQL = sSQL + "DOF_REJ = " + DOF_REJ + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_REJ = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_LIM.ToString()))
            {
                sSQL = sSQL + "DOF_LIM = " + DOF_LIM + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_LIM = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_TOT.ToString()))
            {
                sSQL = sSQL + "DOF_TOT = " + DOF_TOT + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_TOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_LOT))
            {
                sSQL = sSQL + "DOF_LOT = '" + DOF_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_001))
            {
                sSQL = sSQL + "DOF_MGE_001 = '" + DOF_MGE_001.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_MGE_001 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_002))
            {
                sSQL = sSQL + "DOF_MGE_002 = '" + DOF_MGE_002.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_MGE_002 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_003))
            {
                sSQL = sSQL + "DOF_MGE_003 = '" + DOF_MGE_003.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_MGE_003 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_004))
            {
                sSQL = sSQL + "DOF_MGE_004 = '" + DOF_MGE_004.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "DOF_MGE_004 = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_STS.ToString()))
            {
                sSQL = sSQL + "DOF_STS = " + DOF_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(DOF_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "DOF_USR_ALT_ID = " + DOF_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DOF_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "DOF_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE DOF_ID = " + DOF_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM DOF";
            sSQL = sSQL + " WHERE DOF_ID = " + DOF_ID;

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
            sSQL = sSQL + " FROM DOF";
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_ID)))
            {
                sCond = sCond + " DOF_ID = " + DOF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_EPF_ID)))
            {
                sCond = sCond + " DOF_EPF_ID = " + DOF_EPF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT)))
            {
                sCond = sCond + " DOF_DAT BETWEEN Convert(datetime, '" + DOF_DAT + "',103) AND Convert(datetime, '" + DOF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_INI)))
            {
                sCond = sCond + " DOF_DAT >= Convert(datetime, '" + DOF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_FIM)))
            {
                sCond = sCond + " DOF_DAT <= Convert(datetime, '" + DOF_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(DOF_LOT))
            {
                sCond = sCond + " DOF_LOT = '" + DOF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(DOF_MAQ))
            {
                sCond = sCond + " DOF_MAQ = '" + DOF_MAQ + "' AND ";
            }
            if (!String.IsNullOrEmpty(DOF_MGE_001))
            {
                sCond = sCond + " DOF_MGE_001 = '" + DOF_MGE_001 + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_STS)))
            {
                sCond = sCond + " DOF_STS = " + DOF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DOF_DAT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }


        public DataSet ConsultarMaquina()
        {
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT DISTINCT DOF_MAQ ";
            }
            sSQL = sSQL + " ORDER BY ASC";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }






        //Falhas OLT (Summary of olt fallout by lot)
        public DataSet RelatorioFalhaOLT()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " ";
            }
            sSQL = sSQL + " DOF_LOT, DOF_MAQ, DOF_MGE_001, MAX(DOF_REJ) DOF_REJ, MAX(DOF_LIM) DOF_LIM, SUM(DOF_TOT) DOF_TOT, EPF_DES, EPF_VLC ";
            //Será calculado no RowDataBound
            //COUNT(*) QTD, CAST(((CAST(COUNT(*)AS DECIMAL (10,2))  / CASE DOF_TOT WHEN 0 THEN 1 ELSE DOF_TOT END) * 100) AS DECIMAL (5, 2)) PSL, 
            sSQL = sSQL + " FROM DOF ";
            sSQL = sSQL + " INNER JOIN EPF ON EPF_ID = DOF_EPF_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT)))
            {
                sCond = sCond + " DOF_DAT BETWEEN Convert(datetime, '" + DOF_DAT + "',103) AND Convert(datetime, '" + DOF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_INI)))
            {
                sCond = sCond + " DOF_DAT >= Convert(datetime, '" + DOF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_FIM)))
            {
                sCond = sCond + " DOF_DAT <= Convert(datetime, '" + DOF_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_LOT)))
            {
                sCond = sCond + " DOF_LOT = '" + DOF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_MAQ)))
            {
                sCond = sCond + " DOF_MAQ = '" + DOF_MAQ + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_MGE_001)))
            {
                sCond = sCond + " DOF_MGE_001 = '" + DOF_MGE_001 + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_STS)))
            {
                sCond = sCond + " DOF_STS = " + DOF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " GROUP BY DOF_LOT, DOF_MAQ, DOF_MGE_001, EPF_DES, EPF_VLC";
            sSQL = sSQL + " ORDER BY DOF_LOT, DOF_MAQ";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        //Fim De Evento (On line tensor reject report by merge)
        public DataSet RelatorioFimDeEvento()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " ";
            }
            //Será calculado no RowDataBound
            //COUNT(*) QTD, CAST(((CAST(COUNT(*)AS DECIMAL (10,2))  / CASE DOF_TOT WHEN 0 THEN 1 ELSE DOF_TOT END) * 100) AS DECIMAL (5, 2)) PSL, 
            sSQL = sSQL + " DOF_MGE_001, DOF_MAQ, DOF_LOT, MAX(DOF_REJ) DOF_REJ, MAX(DOF_LIM) DOF_LIM, SUM(DOF_TOT) DOF_TOT, EPF_DES, EPF_VLC ";
            sSQL = sSQL + " FROM DOF ";
            sSQL = sSQL + " INNER JOIN EPF ON EPF_ID = DOF_EPF_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT)))
            {
                sCond = sCond + " DOF_DAT BETWEEN Convert(datetime, '" + DOF_DAT + "',103) AND Convert(datetime, '" + DOF_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_INI)))
            {
                sCond = sCond + " DOF_DAT >= Convert(datetime, '" + DOF_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_DAT_FIM)))
            {
                sCond = sCond + " DOF_DAT <= Convert(datetime, '" + DOF_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_LOT)))
            {
                sCond = sCond + " DOF_LOT = '" + DOF_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_MAQ)))
            {
                sCond = sCond + " DOF_MAQ = '" + DOF_MAQ + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_MGE_001)))
            {
                sCond = sCond + " DOF_MGE_001 = '" + DOF_MGE_001 + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DOF_STS)))
            {
                sCond = sCond + " DOF_STS = " + DOF_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " GROUP BY DOF_MGE_001, DOF_MAQ, DOF_LOT, EPF_DES, EPF_VLC ";
            sSQL = sSQL + " ORDER BY DOF_MGE_001, DOF_LOT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}