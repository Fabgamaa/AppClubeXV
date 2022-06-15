using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Motivo
    {

        #region Propriedades

        private int? _MTV_ID;
        private int? _MTV_CAT_ID;
        private string _MTV_DES;
        private string _MTV_ORI;
        private int? _MTV_STS;
        private int? _MTV_USR_INC_ID;
        private int? _MTV_USR_ALT_ID;
        private DateTime? _MTV_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MTV_ID
        {
            get { return _MTV_ID; }
            set { _MTV_ID = value; }
        }
        public int? MTV_CAT_ID
        {
            get { return _MTV_CAT_ID; }
            set { _MTV_CAT_ID = value; }
        }
        public string MTV_DES
        {
            get { return _MTV_DES; }
            set { _MTV_DES = value.ToUpper(); }
        }
        public string MTV_ORI
        {
            get { return _MTV_ORI; }
            set { _MTV_ORI = value.ToUpper(); }
        }
        public int? MTV_STS
        {
            get { return _MTV_STS; }
            set { _MTV_STS = value; }
        }
        public int? MTV_USR_INC_ID
        {
            get { return _MTV_USR_INC_ID; }
            set { _MTV_USR_INC_ID = value; }
        }
        public int? MTV_USR_ALT_ID
        {
            get { return _MTV_USR_ALT_ID; }
            set { _MTV_USR_ALT_ID = value; }
        }
        public DateTime? MTV_TMS_ATL
        {
            get { return _MTV_TMS_ATL; }
            set { _MTV_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MTV (";
            sSQL = sSQL + "MTV_CAT_ID, ";
            sSQL = sSQL + "MTV_DES, ";
            sSQL = sSQL + "MTV_ORI, ";
            sSQL = sSQL + "MTV_STS, ";
            sSQL = sSQL + "MTV_USR_INC_ID, ";
            sSQL = sSQL + "MTV_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MTV_CAT_ID.ToString()))
            {
                sSQL = sSQL + MTV_CAT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_DES))
            {
                sSQL = sSQL + "'" + MTV_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_ORI))
            {
                sSQL = sSQL + "'" + MTV_ORI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_STS.ToString()))
            {
                sSQL = sSQL + MTV_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MTV_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MTV ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MTV_CAT_ID.ToString()))
            {
                sSQL = sSQL + "MTV_CAT_ID = " + MTV_CAT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MTV_CAT_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_DES))
            {
                sSQL = sSQL + "MTV_DES = '" + MTV_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MTV_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_ORI))
            {
                sSQL = sSQL + "MTV_ORI = '" + MTV_ORI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MTV_ORI = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_STS.ToString()))
            {
                sSQL = sSQL + "MTV_STS = " + MTV_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MTV_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MTV_USR_ALT_ID = " + MTV_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MTV_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MTV_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MTV_ID = " + MTV_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MTV";
            sSQL = sSQL + " WHERE MTV_ID = " + MTV_ID;

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
            sSQL = sSQL + " FROM MTV";
            if (!String.IsNullOrEmpty(Convert.ToString(MTV_ID)))
            {
                sCond = sCond + " MTV_ID = " + MTV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MTV_CAT_ID)))
            {
                sCond = sCond + " MTV_CAT_ID = " + MTV_CAT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MTV_STS)))
            {
                sCond = sCond + " MTV_STS = " + MTV_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MTV_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}