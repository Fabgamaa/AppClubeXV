using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Cliente
    {

        #region Propriedades

        private int? _CLI_ID;
        private string _CLI_NOM;
        private int? _CLI_STS;
        private int? _CLI_USR_INC_ID;
        private int? _CLI_USR_ALT_ID;
        private DateTime? _CLI_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? CLI_ID
        {
            get { return _CLI_ID; }
            set { _CLI_ID = value; }
        }
        public string CLI_NOM
        {
            get { return _CLI_NOM; }
            set { _CLI_NOM = value.ToUpper(); }
        }
        public int? CLI_STS
        {
            get { return _CLI_STS; }
            set { _CLI_STS = value; }
        }
        public int? CLI_USR_INC_ID
        {
            get { return _CLI_USR_INC_ID; }
            set { _CLI_USR_INC_ID = value; }
        }
        public int? CLI_USR_ALT_ID
        {
            get { return _CLI_USR_ALT_ID; }
            set { _CLI_USR_ALT_ID = value; }
        }
        public DateTime? CLI_TMS_ATL
        {
            get { return _CLI_TMS_ATL; }
            set { _CLI_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO [CLI](";
            sSQL = sSQL + "CLI_NOM, ";
            sSQL = sSQL + "CLI_STS, ";
            sSQL = sSQL + "CLI_USR_INC_ID, ";
            sSQL = sSQL + "CLI_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(CLI_NOM))
            {
                sSQL = sSQL + "'" + CLI_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CLI_STS.ToString()))
            {
                sSQL = sSQL + CLI_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CLI_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + CLI_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE [CLI]";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(CLI_NOM))
            {
                sSQL = sSQL + "CLI_NOM = '" + CLI_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "CLI_NOM = NULL, ";
            }
            if (!String.IsNullOrEmpty(CLI_STS.ToString()))
            {
                sSQL = sSQL + "CLI_STS = " + CLI_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "CLI_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(CLI_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "CLI_USR_ALT_ID = " + CLI_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "CLI_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "CLI_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE CLI_ID = " + CLI_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM [CLI]";
            sSQL = sSQL + " WHERE CLI_ID = " + CLI_ID;

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
            sSQL = sSQL + " FROM [CLI]";
            if (!String.IsNullOrEmpty(Convert.ToString(CLI_ID)))
            {
                sCond = sCond + " CLI_ID = " + CLI_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(CLI_STS)))
            {
                sCond = sCond + " CLI_STS = " + CLI_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CLI_NOM";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}