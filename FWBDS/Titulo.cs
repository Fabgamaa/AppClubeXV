using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Titulo
    {

        #region Propriedades

        private int? _TIT_POY_ID;
        private string _TIT_POY_DES;
        private string _TIT_POY_TIP;
        private int? _TIT_POY_TIT;
        private int? _TIT_POY_FLA;
        private int? _TIT_POY_CBO;
        private int? _TIT_POY_STS;
        private int? _TIT_POY_USR_INC_ID;
        private int? _TIT_POY_USR_ALT_ID;
        private DateTime? _TIT_POY_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? TIT_POY_ID
        {
            get { return _TIT_POY_ID; }
            set { _TIT_POY_ID = value; }
        }
        public string TIT_POY_DES
        {
            get { return _TIT_POY_DES; }
            set { _TIT_POY_DES = value.ToUpper(); }
        }
        public string TIT_POY_TIP
        {
            get { return _TIT_POY_TIP; }
            set { _TIT_POY_TIP = value.ToUpper(); }
        }
        public int? TIT_POY_TIT
        {
            get { return _TIT_POY_TIT; }
            set { _TIT_POY_TIT = value; }
        }
        public int? TIT_POY_FLA
        {
            get { return _TIT_POY_FLA; }
            set { _TIT_POY_FLA = value; }
        }
        public int? TIT_POY_CBO
        {
            get { return _TIT_POY_CBO; }
            set { _TIT_POY_CBO = value; }
        }
        public int? TIT_POY_STS
        {
            get { return _TIT_POY_STS; }
            set { _TIT_POY_STS = value; }
        }
        public int? TIT_POY_USR_INC_ID
        {
            get { return _TIT_POY_USR_INC_ID; }
            set { _TIT_POY_USR_INC_ID = value; }
        }
        public int? TIT_POY_USR_ALT_ID
        {
            get { return _TIT_POY_USR_ALT_ID; }
            set { _TIT_POY_USR_ALT_ID = value; }
        }
        public DateTime? TIT_POY_TMS_ATL
        {
            get { return _TIT_POY_TMS_ATL; }
            set { _TIT_POY_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO TIT_POY (";
            sSQL = sSQL + "TIT_POY_DES, ";
            sSQL = sSQL + "TIT_POY_TIP, ";
            sSQL = sSQL + "TIT_POY_TIT, ";
            sSQL = sSQL + "TIT_POY_FLA, ";
            sSQL = sSQL + "TIT_POY_CBO, ";
            sSQL = sSQL + "TIT_POY_STS, ";
            sSQL = sSQL + "TIT_POY_USR_INC_ID, ";
            sSQL = sSQL + "TIT_POY_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(TIT_POY_DES))
            {
                sSQL = sSQL + "'" + TIT_POY_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_TIP))
            {
                sSQL = sSQL + "'" + TIT_POY_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_TIT.ToString()))
            {
                sSQL = sSQL + TIT_POY_TIT + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_FLA.ToString()))
            {
                sSQL = sSQL + TIT_POY_FLA + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_CBO.ToString()))
            {
                sSQL = sSQL + TIT_POY_CBO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_STS.ToString()))
            {
                sSQL = sSQL + TIT_POY_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + TIT_POY_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE TIT_POY ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(TIT_POY_DES))
            {
                sSQL = sSQL + "TIT_POY_DES = '" + TIT_POY_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_TIP))
            {
                sSQL = sSQL + "TIT_POY_TIP = '" + TIT_POY_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_TIP = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_TIT.ToString()))
            {
                sSQL = sSQL + "TIT_POY_TIT = " + TIT_POY_TIT + ", ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_TIT = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_FLA.ToString()))
            {
                sSQL = sSQL + "TIT_POY_FLA = " + TIT_POY_FLA + ", ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_FLA = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_CBO.ToString()))
            {
                sSQL = sSQL + "TIT_POY_CBO = " + TIT_POY_CBO + ", ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_CBO = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_STS.ToString()))
            {
                sSQL = sSQL + "TIT_POY_STS = " + TIT_POY_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "TIT_POY_USR_ALT_ID = " + TIT_POY_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "TIT_POY_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "TIT_POY_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE TIT_POY_ID = " + TIT_POY_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM TIT_POY";
            sSQL = sSQL + " WHERE TIT_POY_ID = " + TIT_POY_ID;

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
            sSQL = sSQL + " FROM TIT_POY";
            if (!String.IsNullOrEmpty(Convert.ToString(TIT_POY_ID)))
            {
                sCond = sCond + " TIT_POY_ID = " + TIT_POY_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_DES))
            {
                sCond = sCond + " TIT_POY_DES = '" + TIT_POY_DES + "' AND ";
            }
            if (!String.IsNullOrEmpty(TIT_POY_TIP))
            {
                sCond = sCond + " TIT_POY_TIP = '" + TIT_POY_TIP + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TIT_POY_TIT)))
            {
                sCond = sCond + " TIT_POY_TIT = " + TIT_POY_TIT + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TIT_POY_FLA)))
            {
                sCond = sCond + " TIT_POY_FLA = " + TIT_POY_FLA + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TIT_POY_CBO)))
            {
                sCond = sCond + " TIT_POY_CBO = " + TIT_POY_CBO + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TIT_POY_STS)))
            {
                sCond = sCond + " TIT_POY_STS = " + TIT_POY_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY TIT_POY_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}