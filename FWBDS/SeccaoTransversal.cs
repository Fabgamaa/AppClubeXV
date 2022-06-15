using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class SeccaoTransversal
    {

        #region Propriedades

        private int? _SCC_TRV_ID;
        private string _SCC_TRV_DES;
        private int? _SCC_TRV_STS;
        private int? _SCC_TRV_USR_INC_ID;
        private int? _SCC_TRV_USR_ALT_ID;
        private DateTime? _SCC_TRV_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? SCC_TRV_ID
        {
            get { return _SCC_TRV_ID; }
            set { _SCC_TRV_ID = value; }
        }
        public string SCC_TRV_DES
        {
            get { return _SCC_TRV_DES; }
            set { _SCC_TRV_DES = value.ToUpper(); }
        }
        public int? SCC_TRV_STS
        {
            get { return _SCC_TRV_STS; }
            set { _SCC_TRV_STS = value; }
        }
        public int? SCC_TRV_USR_INC_ID
        {
            get { return _SCC_TRV_USR_INC_ID; }
            set { _SCC_TRV_USR_INC_ID = value; }
        }
        public int? SCC_TRV_USR_ALT_ID
        {
            get { return _SCC_TRV_USR_ALT_ID; }
            set { _SCC_TRV_USR_ALT_ID = value; }
        }
        public DateTime? SCC_TRV_TMS_ATL
        {
            get { return _SCC_TRV_TMS_ATL; }
            set { _SCC_TRV_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO SCC_TRV (";
            sSQL = sSQL + "SCC_TRV_DES, ";
            sSQL = sSQL + "SCC_TRV_STS, ";
            sSQL = sSQL + "SCC_TRV_USR_INC_ID, ";
            sSQL = sSQL + "SCC_TRV_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(SCC_TRV_DES))
            {
                sSQL = sSQL + "'" + SCC_TRV_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(SCC_TRV_STS.ToString()))
            {
                sSQL = sSQL + SCC_TRV_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(SCC_TRV_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + SCC_TRV_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE SCC_TRV ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(SCC_TRV_DES))
            {
                sSQL = sSQL + "SCC_TRV_DES = '" + SCC_TRV_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "SCC_TRV_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(SCC_TRV_STS.ToString()))
            {
                sSQL = sSQL + "SCC_TRV_STS = " + SCC_TRV_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "SCC_TRV_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(SCC_TRV_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "SCC_TRV_USR_ALT_ID = " + SCC_TRV_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "SCC_TRV_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "SCC_TRV_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE SCC_TRV_ID = " + SCC_TRV_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM SCC_TRV";
            sSQL = sSQL + " WHERE SCC_TRV_ID = " + SCC_TRV_ID;

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
            sSQL = sSQL + " FROM SCC_TRV";
            if (!String.IsNullOrEmpty(Convert.ToString(SCC_TRV_ID)))
            {
                sCond = sCond + " SCC_TRV_ID = " + SCC_TRV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(SCC_TRV_STS)))
            {
                sCond = sCond + " SCC_TRV_STS = " + SCC_TRV_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY SCC_TRV_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}