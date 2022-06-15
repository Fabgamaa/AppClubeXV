using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Maticidade
    {

        #region Propriedades

        private int? _MTD_ID;
        private string _MTD_DES;
        private int? _MTD_STS;
        private int? _MTD_USR_INC_ID;
        private int? _MTD_USR_ALT_ID;
        private DateTime? _MTD_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MTD_ID
        {
            get { return _MTD_ID; }
            set { _MTD_ID = value; }
        }
        public string MTD_DES
        {
            get { return _MTD_DES; }
            set { _MTD_DES = value.ToUpper(); }
        }
        public int? MTD_STS
        {
            get { return _MTD_STS; }
            set { _MTD_STS = value; }
        }
        public int? MTD_USR_INC_ID
        {
            get { return _MTD_USR_INC_ID; }
            set { _MTD_USR_INC_ID = value; }
        }
        public int? MTD_USR_ALT_ID
        {
            get { return _MTD_USR_ALT_ID; }
            set { _MTD_USR_ALT_ID = value; }
        }
        public DateTime? MTD_TMS_ATL
        {
            get { return _MTD_TMS_ATL; }
            set { _MTD_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MTD (";
            sSQL = sSQL + "MTD_DES, ";
            sSQL = sSQL + "MTD_STS, ";
            sSQL = sSQL + "MTD_USR_INC_ID, ";
            sSQL = sSQL + "MTD_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MTD_DES))
            {
                sSQL = sSQL + "'" + MTD_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTD_STS.ToString()))
            {
                sSQL = sSQL + MTD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTD_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MTD_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MTD ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MTD_DES))
            {
                sSQL = sSQL + "MTD_DES = '" + MTD_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MTD_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTD_STS.ToString()))
            {
                sSQL = sSQL + "MTD_STS = " + MTD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MTD_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTD_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MTD_USR_ALT_ID = " + MTD_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MTD_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MTD_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MTD_ID = " + MTD_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MTD";
            sSQL = sSQL + " WHERE MTD_ID = " + MTD_ID;

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
            sSQL = sSQL + " FROM MTD";
            if (!String.IsNullOrEmpty(Convert.ToString(MTD_ID)))
            {
                sCond = sCond + " MTD_ID = " + MTD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MTD_STS)))
            {
                sCond = sCond + " MTD_STS = " + MTD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MTD_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}