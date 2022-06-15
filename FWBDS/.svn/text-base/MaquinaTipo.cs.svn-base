using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class MaquinaTipo
    {

        #region Propriedades

        private int? _MAQ_TIP_ID;
        private string _MAQ_TIP_DES;
        private string _MAQ_TIP_SAP;
        private int? _MAQ_TIP_STS;
        private int? _MAQ_TIP_USR_INC_ID;
        private int? _MAQ_TIP_USR_ALT_ID;
        private DateTime? _MAQ_TIP_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MAQ_TIP_ID
        {
            get { return _MAQ_TIP_ID; }
            set { _MAQ_TIP_ID = value; }
        }
        public string MAQ_TIP_DES
        {
            get { return _MAQ_TIP_DES; }
            set { _MAQ_TIP_DES = value.ToUpper(); }
        }
        public string MAQ_TIP_SAP
        {
            get { return _MAQ_TIP_SAP; }
            set { _MAQ_TIP_SAP = value.ToUpper(); }
        }
        public int? MAQ_TIP_STS
        {
            get { return _MAQ_TIP_STS; }
            set { _MAQ_TIP_STS = value; }
        }
        public int? MAQ_TIP_USR_INC_ID
        {
            get { return _MAQ_TIP_USR_INC_ID; }
            set { _MAQ_TIP_USR_INC_ID = value; }
        }
        public int? MAQ_TIP_USR_ALT_ID
        {
            get { return _MAQ_TIP_USR_ALT_ID; }
            set { _MAQ_TIP_USR_ALT_ID = value; }
        }
        public DateTime? MAQ_TIP_TMS_ATL
        {
            get { return _MAQ_TIP_TMS_ATL; }
            set { _MAQ_TIP_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MAQ_TIP (";
            sSQL = sSQL + "MAQ_TIP_DES, ";
            sSQL = sSQL + "MAQ_TIP_SAP, ";
            sSQL = sSQL + "MAQ_TIP_STS, ";
            sSQL = sSQL + "MAQ_TIP_USR_INC_ID, ";
            sSQL = sSQL + "MAQ_TIP_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MAQ_TIP_DES))
            {
                sSQL = sSQL + "'" + MAQ_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_SAP))
            {
                sSQL = sSQL + "'" + MAQ_TIP_SAP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_STS.ToString()))
            {
                sSQL = sSQL + MAQ_TIP_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MAQ_TIP_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MAQ_TIP ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MAQ_TIP_DES))
            {
                sSQL = sSQL + "MAQ_TIP_DES = '" + MAQ_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MAQ_TIP_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_SAP))
            {
                sSQL = sSQL + "MAQ_TIP_SAP = '" + MAQ_TIP_SAP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MAQ_TIP_SAP = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_STS.ToString()))
            {
                sSQL = sSQL + "MAQ_TIP_STS = " + MAQ_TIP_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MAQ_TIP_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_TIP_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MAQ_TIP_USR_ALT_ID = " + MAQ_TIP_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MAQ_TIP_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MAQ_TIP_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MAQ_TIP_ID = " + MAQ_TIP_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MAQ_TIP";
            sSQL = sSQL + " WHERE MAQ_TIP_ID = " + MAQ_TIP_ID;

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
            sSQL = sSQL + " FROM MAQ_TIP";
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_TIP_ID)))
            {
                sCond = sCond + " MAQ_TIP_ID = " + MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_TIP_STS)))
            {
                sCond = sCond + " MAQ_TIP_STS = " + MAQ_TIP_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_TIP_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}