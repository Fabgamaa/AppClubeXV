using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Escolha
    {

        #region Propriedades

        private int? _ESL_ID;
        private string _ESL_DES;
        private int? _ESL_STS;
        private int? _ESL_USR_INC_ID;
        private int? _ESL_USR_ALT_ID;
        private DateTime? _ESL_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? ESL_ID
        {
            get { return _ESL_ID; }
            set { _ESL_ID = value; }
        }
        public string ESL_DES
        {
            get { return _ESL_DES; }
            set { _ESL_DES = value.ToUpper(); }
        }
        public int? ESL_STS
        {
            get { return _ESL_STS; }
            set { _ESL_STS = value; }
        }
        public int? ESL_USR_INC_ID
        {
            get { return _ESL_USR_INC_ID; }
            set { _ESL_USR_INC_ID = value; }
        }
        public int? ESL_USR_ALT_ID
        {
            get { return _ESL_USR_ALT_ID; }
            set { _ESL_USR_ALT_ID = value; }
        }
        public DateTime? ESL_TMS_ATL
        {
            get { return _ESL_TMS_ATL; }
            set { _ESL_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO ESL (";
            sSQL = sSQL + "ESL_DES, ";
            sSQL = sSQL + "ESL_STS, ";
            sSQL = sSQL + "ESL_USR_INC_ID, ";
            sSQL = sSQL + "ESL_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ESL_DES))
            {
                sSQL = sSQL + "'" + ESL_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ESL_STS.ToString()))
            {
                sSQL = sSQL + ESL_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ESL_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ESL_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ESL ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ESL_DES))
            {
                sSQL = sSQL + "ESL_DES = '" + ESL_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ESL_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(ESL_STS.ToString()))
            {
                sSQL = sSQL + "ESL_STS = " + ESL_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ESL_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ESL_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ESL_USR_ALT_ID = " + ESL_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ESL_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ESL_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE ESL_ID = " + ESL_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ESL";
            sSQL = sSQL + " WHERE ESL_ID = " + ESL_ID;

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
            sSQL = sSQL + " FROM ESL";
            if (!String.IsNullOrEmpty(Convert.ToString(ESL_ID)))
            {
                sCond = sCond + " ESL_ID = " + ESL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ESL_STS)))
            {
                sCond = sCond + " ESL_STS = " + ESL_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ESL_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}