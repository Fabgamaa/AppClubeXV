using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Caixa
    {

        #region Propriedades

        private int? _CXA_ID;
        private string _CXA_DES;
        private int? _CXA_STS;
        private int? _CXA_USR_INC_ID;
        private int? _CXA_USR_ALT_ID;
        private DateTime? _CXA_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? CXA_ID
        {
            get { return _CXA_ID; }
            set { _CXA_ID = value; }
        }
        public string CXA_DES
        {
            get { return _CXA_DES; }
            set { _CXA_DES = value.ToUpper(); }
        }
        public int? CXA_STS
        {
            get { return _CXA_STS; }
            set { _CXA_STS = value; }
        }
        public int? CXA_USR_INC_ID
        {
            get { return _CXA_USR_INC_ID; }
            set { _CXA_USR_INC_ID = value; }
        }
        public int? CXA_USR_ALT_ID
        {
            get { return _CXA_USR_ALT_ID; }
            set { _CXA_USR_ALT_ID = value; }
        }
        public DateTime? CXA_TMS_ATL
        {
            get { return _CXA_TMS_ATL; }
            set { _CXA_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO CXA (";
            sSQL = sSQL + "CXA_DES, ";
            sSQL = sSQL + "CXA_STS, ";
            sSQL = sSQL + "CXA_USR_INC_ID, ";
            sSQL = sSQL + "CXA_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(CXA_DES))
            {
                sSQL = sSQL + "'" + CXA_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CXA_STS.ToString()))
            {
                sSQL = sSQL + CXA_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(CXA_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + CXA_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE CXA ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(CXA_DES))
            {
                sSQL = sSQL + "CXA_DES = '" + CXA_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "CXA_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(CXA_STS.ToString()))
            {
                sSQL = sSQL + "CXA_STS = " + CXA_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "CXA_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(CXA_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "CXA_USR_ALT_ID = " + CXA_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "CXA_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "CXA_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE CXA_ID = " + CXA_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM CXA";
            sSQL = sSQL + " WHERE CXA_ID = " + CXA_ID;

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
            sSQL = sSQL + " FROM CXA";
            if (!String.IsNullOrEmpty(Convert.ToString(CXA_ID)))
            {
                sCond = sCond + " CXA_ID = " + CXA_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(CXA_STS)))
            {
                sCond = sCond + " CXA_STS = " + CXA_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CXA_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}