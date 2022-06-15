using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class AnaliseTipo
    {

        #region Propriedades

        private int? _ANS_TIP_ID;
        private string _ANS_TIP_DES;
        private int? _ANS_TIP_STS;
        private int? _ANS_TIP_USR_INC_ID;
        private int? _ANS_TIP_USR_ALT_ID;
        private DateTime? _ANS_TIP_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? ANS_TIP_ID
        {
            get { return _ANS_TIP_ID; }
            set { _ANS_TIP_ID = value; }
        }
        public string ANS_TIP_DES
        {
            get { return _ANS_TIP_DES; }
            set { _ANS_TIP_DES = value.ToUpper(); }
        }
        public int? ANS_TIP_STS
        {
            get { return _ANS_TIP_STS; }
            set { _ANS_TIP_STS = value; }
        }
        public int? ANS_TIP_USR_INC_ID
        {
            get { return _ANS_TIP_USR_INC_ID; }
            set { _ANS_TIP_USR_INC_ID = value; }
        }
        public int? ANS_TIP_USR_ALT_ID
        {
            get { return _ANS_TIP_USR_ALT_ID; }
            set { _ANS_TIP_USR_ALT_ID = value; }
        }
        public DateTime? ANS_TIP_TMS_ATL
        {
            get { return _ANS_TIP_TMS_ATL; }
            set { _ANS_TIP_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO ANS_TIP (";
            sSQL = sSQL + "ANS_TIP_DES, ";
            sSQL = sSQL + "ANS_TIP_STS, ";
            sSQL = sSQL + "ANS_TIP_USR_INC_ID, ";
            sSQL = sSQL + "ANS_TIP_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sSQL = sSQL + "'" + ANS_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_STS.ToString()))
            {
                sSQL = sSQL + ANS_TIP_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ANS_TIP_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE ANS_TIP ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(ANS_TIP_DES))
            {
                sSQL = sSQL + "ANS_TIP_DES = '" + ANS_TIP_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIP_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_STS.ToString()))
            {
                sSQL = sSQL + "ANS_TIP_STS = " + ANS_TIP_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIP_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(ANS_TIP_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "ANS_TIP_USR_ALT_ID = " + ANS_TIP_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "ANS_TIP_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "ANS_TIP_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE ANS_TIP_ID = " + ANS_TIP_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ANS_TIP";
            sSQL = sSQL + " WHERE ANS_TIP_ID = " + ANS_TIP_ID;

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
            sSQL = sSQL + " FROM ANS_TIP";
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIP_ID)))
            {
                sCond = sCond + " ANS_TIP_ID = " + ANS_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANS_TIP_STS)))
            {
                sCond = sCond + " ANS_TIP_STS = " + ANS_TIP_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ANS_TIP_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}
