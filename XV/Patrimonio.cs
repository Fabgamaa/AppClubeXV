using System;
using System.Data;

namespace XV


{
    public class Patrimonio
    {

        #region Propriedades

        private int? _PTR_ID;
        private int? _PTR_USR_ID;
        private string _PTR_UND;
        private string _PTR_LOC;
        private string _PTR_BEM;
        private string _PTR_ETQ;
        private int? _PTR_STS;
        private DateTime? _PTR_TMS_ALT;


        private string _TOP;
        private string _SQL;

        public int? PTR_ID
        {
            get { return _PTR_ID; }
            set { _PTR_ID = value; }
        }
        public int? PTR_USR_ID
        {
            get { return _PTR_USR_ID; }
            set { _PTR_USR_ID = value; }
        }
        public string PTR_UND
        {
            get { return _PTR_UND; }
            set { _PTR_UND = value.ToUpper(); }
        }
        public string PTR_LOC
        {
            get { return _PTR_LOC; }
            set { _PTR_LOC = value.ToUpper(); }
        }
        public string PTR_BEM
        {
            get { return _PTR_BEM; }
            set { _PTR_BEM = value.ToUpper(); }
        }
        public string PTR_ETQ
        {
            get { return _PTR_ETQ; }
            set { _PTR_ETQ = value.ToUpper(); }
        }
        public int? PTR_STS
        {
            get { return _PTR_STS; }
            set { _PTR_STS = value; }
        }
        public DateTime? PTR_TMS_ALT
        {
            get { return _PTR_TMS_ALT; }
            set { _PTR_TMS_ALT = value; }
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

        public Patrimonio()
        {
        }

        public string Inserir()
        {
            string sSQL = "INSERT INTO PTR (";
            sSQL = sSQL + "PTR_USR_ID, ";
            sSQL = sSQL + "PTR_UND, ";
            sSQL = sSQL + "PTR_LOC, ";
            sSQL = sSQL + "PTR_BEM, ";
            sSQL = sSQL + "PTR_ETQ, ";
            sSQL = sSQL + "PTR_STS, ";
            sSQL = sSQL + "PTR_TMS_ALT) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(PTR_USR_ID.ToString()))
            {
                sSQL = sSQL + PTR_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_UND))
            {
                sSQL = sSQL + "'" + PTR_UND.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_LOC))
            {
                sSQL = sSQL + "'" + PTR_LOC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_BEM))
            {
                sSQL = sSQL + "'" + PTR_BEM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_ETQ))
            {
                sSQL = sSQL + "'" + PTR_ETQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_STS.ToString()))
            {
                sSQL = sSQL + PTR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_TMS_ALT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + PTR_TMS_ALT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + ") ";

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Alterar()
        {
            string sSQL = "UPDATE PTR ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(PTR_USR_ID.ToString()))
            {
                sSQL = sSQL + "PTR_USR_ID = " + PTR_USR_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "PTR_USR_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_UND))
            {
                sSQL = sSQL + "PTR_UND = '" + PTR_UND.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PTR_UND = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_LOC))
            {
                sSQL = sSQL + "PTR_LOC = '" + PTR_LOC.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PTR_LOC = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_BEM))
            {
                sSQL = sSQL + "PTR_BEM = '" + PTR_BEM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PTR_BEM = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_ETQ))
            {
                sSQL = sSQL + "PTR_ETQ = '" + PTR_ETQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "PTR_ETQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_STS.ToString()))
            {
                sSQL = sSQL + "PTR_STS = " + PTR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "PTR_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(PTR_TMS_ALT.ToString()))
            {
                sSQL = sSQL + "PTR_TMS_ALT = Convert(datetime, '" + PTR_TMS_ALT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "PTR_TMS_ALT = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE PTR_ID = " + PTR_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PTR";
            sSQL = sSQL + " WHERE PTR_ID = " + PTR_ID;

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
            sSQL = sSQL + " FROM PTR";
            if (!String.IsNullOrEmpty(Convert.ToString(PTR_ID)))
            {
                sCond = sCond + " PTR_ID = " + PTR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PTR_USR_ID)))
            {
                sCond = sCond + " PTR_USR_ID = " + PTR_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PTR_STS)))
            {
                sCond = sCond + " PTR_STS = " + PTR_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PTR_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}