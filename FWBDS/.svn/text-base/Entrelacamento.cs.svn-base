using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Entrelacamento
    {

        #region Propriedades

        private int? _ERT_ID;
        private string _ERT_DES;
        private int? _ERT_STS;
        private int? _ERT_USR_INC_ID;
        private int? _ERT_USR_ALT_ID;
        private DateTime? _ERT_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? ERT_ID
        {
            get { return _ERT_ID; }
            set { _ERT_ID = value; }
        }
        public string ERT_DES
        {
            get { return _ERT_DES; }
            set { _ERT_DES = value.ToUpper(); }
        }
        public int? ERT_STS
        {
            get { return _ERT_STS; }
            set { _ERT_STS = value; }
        }
        public int? ERT_USR_INC_ID
        {
            get { return _ERT_USR_INC_ID; }
            set { _ERT_USR_INC_ID = value; }
        }
        public int? ERT_USR_ALT_ID
        {
            get { return _ERT_USR_ALT_ID; }
            set { _ERT_USR_ALT_ID = value; }
        }
        public DateTime? ERT_TMS_ATL
        {
            get { return _ERT_TMS_ATL; }
            set { _ERT_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO ERT (";
            sSQL = sSQL + "ERT_DES, ";
            sSQL = sSQL + "ERT_STS, ";
            sSQL = sSQL + "ERT_USR_INC_ID, ";
            sSQL = sSQL + "ERT_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ERT_DES))
            {
                sSQL = sSQL + "'" + ERT_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ERT_STS.ToString()))
            {
                sSQL = sSQL + ERT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ERT_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ERT_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ERT ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ERT_DES))
            {
                sSQL = sSQL + "ERT_DES = '" + ERT_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ERT_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(ERT_STS.ToString()))
            {
                sSQL = sSQL + "ERT_STS = " + ERT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ERT_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ERT_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ERT_USR_ALT_ID = " + ERT_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ERT_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ERT_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE ERT_ID = " + ERT_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ERT";
            sSQL = sSQL + " WHERE ERT_ID = " + ERT_ID;

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
            sSQL = sSQL + " FROM ERT";
            if (!String.IsNullOrEmpty(Convert.ToString(ERT_ID)))
            {
                sCond = sCond + " ERT_ID = " + ERT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ERT_STS)))
            {
                sCond = sCond + " ERT_STS = " + ERT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ERT_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}