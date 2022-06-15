using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class MotivoTeste
    {

        #region Propriedades

        private int? _MTV_TST_ID;
        private string _MTV_TST_DES;
        private int? _MTV_TST_STS;
        private int? _MTV_TST_USR_INC_ID;
        private int? _MTV_TST_USR_ALT_ID;
        private DateTime? _MTV_TST_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MTV_TST_ID
        {
            get { return _MTV_TST_ID; }
            set { _MTV_TST_ID = value; }
        }
        public string MTV_TST_DES
        {
            get { return _MTV_TST_DES; }
            set { _MTV_TST_DES = value.ToUpper(); }
        }
        public int? MTV_TST_STS
        {
            get { return _MTV_TST_STS; }
            set { _MTV_TST_STS = value; }
        }
        public int? MTV_TST_USR_INC_ID
        {
            get { return _MTV_TST_USR_INC_ID; }
            set { _MTV_TST_USR_INC_ID = value; }
        }
        public int? MTV_TST_USR_ALT_ID
        {
            get { return _MTV_TST_USR_ALT_ID; }
            set { _MTV_TST_USR_ALT_ID = value; }
        }
        public DateTime? MTV_TST_TMS_ATL
        {
            get { return _MTV_TST_TMS_ATL; }
            set { _MTV_TST_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MTV_TST (";
            sSQL = sSQL + "MTV_TST_DES, ";
            sSQL = sSQL + "MTV_TST_STS, ";
            sSQL = sSQL + "MTV_TST_USR_INC_ID, ";
            sSQL = sSQL + "MTV_TST_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MTV_TST_DES))
            {
                sSQL = sSQL + "'" + MTV_TST_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_TST_STS.ToString()))
            {
                sSQL = sSQL + MTV_TST_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_TST_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MTV_TST_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MTV_TST ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MTV_TST_DES))
            {
                sSQL = sSQL + "MTV_TST_DES = '" + MTV_TST_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MTV_TST_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_TST_STS.ToString()))
            {
                sSQL = sSQL + "MTV_TST_STS = " + MTV_TST_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MTV_TST_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MTV_TST_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MTV_TST_USR_ALT_ID = " + MTV_TST_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MTV_TST_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MTV_TST_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MTV_TST_ID = " + MTV_TST_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MTV_TST";
            sSQL = sSQL + " WHERE MTV_TST_ID = " + MTV_TST_ID;

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
            sSQL = sSQL + " FROM MTV_TST";
            if (!String.IsNullOrEmpty(Convert.ToString(MTV_TST_ID)))
            {
                sCond = sCond + " MTV_TST_ID = " + MTV_TST_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MTV_TST_STS)))
            {
                sCond = sCond + " MTV_TST_STS = " + MTV_TST_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MTV_TST_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}