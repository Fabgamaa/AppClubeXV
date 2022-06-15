using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Filamento
    {

        #region Propriedades

        private int? _FLA_ID;
        private string _FLA_DES;
        private int? _FLA_STS;
        private int? _FLA_USR_INC_ID;
        private int? _FLA_USR_ALT_ID;
        private DateTime? _FLA_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? FLA_ID
        {
            get { return _FLA_ID; }
            set { _FLA_ID = value; }
        }
        public string FLA_DES
        {
            get { return _FLA_DES; }
            set { _FLA_DES = value.ToUpper(); }
        }
        public int? FLA_STS
        {
            get { return _FLA_STS; }
            set { _FLA_STS = value; }
        }
        public int? FLA_USR_INC_ID
        {
            get { return _FLA_USR_INC_ID; }
            set { _FLA_USR_INC_ID = value; }
        }
        public int? FLA_USR_ALT_ID
        {
            get { return _FLA_USR_ALT_ID; }
            set { _FLA_USR_ALT_ID = value; }
        }
        public DateTime? FLA_TMS_ATL
        {
            get { return _FLA_TMS_ATL; }
            set { _FLA_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO FLA (";
            sSQL = sSQL + "FLA_DES, ";
            sSQL = sSQL + "FLA_STS, ";
            sSQL = sSQL + "FLA_USR_INC_ID, ";
            sSQL = sSQL + "FLA_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(FLA_DES))
            {
                sSQL = sSQL + "'" + FLA_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FLA_STS.ToString()))
            {
                sSQL = sSQL + FLA_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FLA_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + FLA_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE FLA ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(FLA_DES))
            {
                sSQL = sSQL + "FLA_DES = '" + FLA_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "FLA_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(FLA_STS.ToString()))
            {
                sSQL = sSQL + "FLA_STS = " + FLA_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "FLA_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(FLA_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "FLA_USR_ALT_ID = " + FLA_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "FLA_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "FLA_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE FLA_ID = " + FLA_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM FLA";
            sSQL = sSQL + " WHERE FLA_ID = " + FLA_ID;

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
            sSQL = sSQL + " FROM FLA";
            if (!String.IsNullOrEmpty(Convert.ToString(FLA_ID)))
            {
                sCond = sCond + " FLA_ID = " + FLA_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(FLA_STS)))
            {
                sCond = sCond + " FLA_STS = " + FLA_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY FLA_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}