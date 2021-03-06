using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Categoria
    {

        #region Propriedades

        private int? _CAT_ID;
        private string _CAT_DES;
        private int? _CAT_STS;
        private int? _CAT_USR_INC_ID;
        private int? _CAT_USR_ALT_ID;
        private DateTime? _CAT_TMS_ATL;
        private string _TOP;
        private string _SQL;

        public int? CAT_ID
        {
            get { return _CAT_ID; }
            set { _CAT_ID = value; }
        }
        public string CAT_DES
        {
            get { return _CAT_DES; }
            set { _CAT_DES = value.ToUpper(); }
        }
        public int? CAT_STS
        {
            get { return _CAT_STS; }
            set { _CAT_STS = value; }
        }
        public int? CAT_USR_INC_ID
        {
            get { return _CAT_USR_INC_ID; }
            set { _CAT_USR_INC_ID = value; }
        }
        public int? CAT_USR_ALT_ID
        {
            get { return _CAT_USR_ALT_ID; }
            set { _CAT_USR_ALT_ID = value; }
        }
        public DateTime? CAT_TMS_ATL
        {
            get { return _CAT_TMS_ATL; }
            set { _CAT_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO CAT (";
            sSQL = sSQL + "CAT_DES, ";
            sSQL = sSQL + "CAT_STS, ";
            sSQL = sSQL + "CAT_USR_INC_ID, ";
            sSQL = sSQL + "CAT_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(CAT_DES))
            {
                sSQL = sSQL + "'" + CAT_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CAT_STS.ToString()))
            {
                sSQL = sSQL + CAT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CAT_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + CAT_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE CAT ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(CAT_DES))
            {
                sSQL = sSQL + "CAT_DES = '" + CAT_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "CAT_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(CAT_STS.ToString()))
            {
                sSQL = sSQL + "CAT_STS = " + CAT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "CAT_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(CAT_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "CAT_USR_ALT_ID = " + CAT_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "CAT_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "CAT_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE CAT_ID = " + CAT_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM CAT";
            sSQL = sSQL + " WHERE CAT_ID = " + CAT_ID;

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
            sSQL = sSQL + " FROM CAT";
            if (!String.IsNullOrEmpty(Convert.ToString(CAT_ID)))
            {
                sCond = sCond + " CAT_ID = " + CAT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(CAT_STS)))
            {
                sCond = sCond + " CAT_STS = " + CAT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CAT_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}