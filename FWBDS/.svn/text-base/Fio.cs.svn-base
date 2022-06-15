using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Fio
    {

        #region Propriedades

        private int? _FIO_ID;
        private string _FIO_DES;
        private int? _FIO_STS;
        private int? _FIO_USR_INC_ID;
        private int? _FIO_USR_ALT_ID;
        private DateTime? _FIO_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? FIO_ID
        {
            get { return _FIO_ID; }
            set { _FIO_ID = value; }
        }
        public string FIO_DES
        {
            get { return _FIO_DES; }
            set { _FIO_DES = value.ToUpper(); }
        }
        public int? FIO_STS
        {
            get { return _FIO_STS; }
            set { _FIO_STS = value; }
        }
        public int? FIO_USR_INC_ID
        {
            get { return _FIO_USR_INC_ID; }
            set { _FIO_USR_INC_ID = value; }
        }
        public int? FIO_USR_ALT_ID
        {
            get { return _FIO_USR_ALT_ID; }
            set { _FIO_USR_ALT_ID = value; }
        }
        public DateTime? FIO_TMS_ATL
        {
            get { return _FIO_TMS_ATL; }
            set { _FIO_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO FIO (";
            sSQL = sSQL + "FIO_DES, ";
            sSQL = sSQL + "FIO_STS, ";
            sSQL = sSQL + "FIO_USR_INC_ID, ";
            sSQL = sSQL + "FIO_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(FIO_DES))
            {
                sSQL = sSQL + "'" + FIO_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FIO_STS.ToString()))
            {
                sSQL = sSQL + FIO_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FIO_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + FIO_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE FIO ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(FIO_DES))
            {
                sSQL = sSQL + "FIO_DES = '" + FIO_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "FIO_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(FIO_STS.ToString()))
            {
                sSQL = sSQL + "FIO_STS = " + FIO_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "FIO_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(FIO_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "FIO_USR_ALT_ID = " + FIO_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "FIO_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "FIO_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE FIO_ID = " + FIO_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM FIO";
            sSQL = sSQL + " WHERE FIO_ID = " + FIO_ID;

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
            sSQL = sSQL + " FROM FIO";
            if (!String.IsNullOrEmpty(Convert.ToString(FIO_ID)))
            {
                sCond = sCond + " FIO_ID = " + FIO_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(FIO_STS)))
            {
                sCond = sCond + " FIO_STS = " + FIO_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY FIO_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}