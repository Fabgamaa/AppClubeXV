using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Maquina
    {

        #region Propriedades

        private int? _MAQ_ID;
        private string _MAQ_DES;
        private int? _MAQ_MAQ_TIP_ID;
        private int? _MAQ_STS;
        private int? _MAQ_USR_INC_ID;
        private int? _MAQ_USR_ALT_ID;
        private DateTime? _MAQ_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MAQ_ID
        {
            get { return _MAQ_ID; }
            set { _MAQ_ID = value; }
        }
        public string MAQ_DES
        {
            get { return _MAQ_DES; }
            set { _MAQ_DES = value.ToUpper(); }
        }
        public int? MAQ_MAQ_TIP_ID
        {
            get { return _MAQ_MAQ_TIP_ID; }
            set { _MAQ_MAQ_TIP_ID = value; }
        }
        public int? MAQ_STS
        {
            get { return _MAQ_STS; }
            set { _MAQ_STS = value; }
        }
        public int? MAQ_USR_INC_ID
        {
            get { return _MAQ_USR_INC_ID; }
            set { _MAQ_USR_INC_ID = value; }
        }
        public int? MAQ_USR_ALT_ID
        {
            get { return _MAQ_USR_ALT_ID; }
            set { _MAQ_USR_ALT_ID = value; }
        }
        public DateTime? MAQ_TMS_ATL
        {
            get { return _MAQ_TMS_ATL; }
            set { _MAQ_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MAQ (";
            sSQL = sSQL + "MAQ_DES, ";
            sSQL = sSQL + "MAQ_MAQ_TIP_ID, ";
            sSQL = sSQL + "MAQ_STS, ";
            sSQL = sSQL + "MAQ_USR_INC_ID, ";
            sSQL = sSQL + "MAQ_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MAQ_DES))
            {
                sSQL = sSQL + "'" + MAQ_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + MAQ_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_STS.ToString()))
            {
                sSQL = sSQL + MAQ_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MAQ_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MAQ ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MAQ_DES))
            {
                sSQL = sSQL + "MAQ_DES = '" + MAQ_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MAQ_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "MAQ_MAQ_TIP_ID = " + MAQ_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MAQ_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_STS.ToString()))
            {
                sSQL = sSQL + "MAQ_STS = " + MAQ_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MAQ_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MAQ_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MAQ_USR_ALT_ID = " + MAQ_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MAQ_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MAQ_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MAQ_ID = " + MAQ_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MAQ";
            sSQL = sSQL + " WHERE MAQ_ID = " + MAQ_ID;

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
            sSQL = sSQL + " FROM MAQ";
            sSQL = sSQL + " LEFT JOIN MAQ_TIP ON MAQ_TIP_ID = MAQ_MAQ_TIP_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_ID)))
            {
                sCond = sCond + " MAQ_ID = " + MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_MAQ_TIP_ID)))
            {
                sCond = sCond + " MAQ_MAQ_TIP_ID = " + MAQ_MAQ_TIP_ID + " AND ";
            }
            //if (!String.IsNullOrEmpty(Convert.ToString(MAQ_STS)))
            //{
            sCond = sCond + " MAQ_STS = 1 AND ";
            //}

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }
        public DataSet Consultar2()
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
            sSQL = sSQL + " FROM MAQ";
            //sSQL = sSQL + " LEFT JOIN MAQ_TIP ON MAQ_TIP_ID = MAQ_MAQ_TIP_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_ID)))
            {
                sCond = sCond + " MAQ_ID = " + MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MAQ_MAQ_TIP_ID)))
            {
                sCond = sCond + " MAQ_MAQ_TIP_ID = " + MAQ_MAQ_TIP_ID + " AND ";
            }
            //if (!String.IsNullOrEmpty(Convert.ToString(MAQ_STS)))
            //{
            sCond = sCond + " MAQ_STS = 1 AND ";
            //}

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }
        #endregion

    }
}