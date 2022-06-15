using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Cor
    {

        #region Propriedades

        private int? _COR_ID;
        private string _COR_DES;
        private int? _COR_STS;
        private int? _COR_USR_INC_ID;
        private int? _COR_USR_ALT_ID;
        private DateTime? _COR_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? COR_ID
        {
            get { return _COR_ID; }
            set { _COR_ID = value; }
        }
        public string COR_DES
        {
            get { return _COR_DES; }
            set { _COR_DES = value.ToUpper(); }
        }
        public int? COR_STS
        {
            get { return _COR_STS; }
            set { _COR_STS = value; }
        }
        public int? COR_USR_INC_ID
        {
            get { return _COR_USR_INC_ID; }
            set { _COR_USR_INC_ID = value; }
        }
        public int? COR_USR_ALT_ID
        {
            get { return _COR_USR_ALT_ID; }
            set { _COR_USR_ALT_ID = value; }
        }
        public DateTime? COR_TMS_ATL
        {
            get { return _COR_TMS_ATL; }
            set { _COR_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO COR (";
            sSQL = sSQL + "COR_DES, ";
            sSQL = sSQL + "COR_STS, ";
            sSQL = sSQL + "COR_USR_INC_ID, ";
            sSQL = sSQL + "COR_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(COR_DES))
            {
                sSQL = sSQL + "'" + COR_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(COR_STS.ToString()))
            {
                sSQL = sSQL + COR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(COR_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + COR_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE COR ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(COR_DES))
            {
                sSQL = sSQL + "COR_DES = '" + COR_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "COR_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(COR_STS.ToString()))
            {
                sSQL = sSQL + "COR_STS = " + COR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "COR_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(COR_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "COR_USR_ALT_ID = " + COR_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "COR_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "COR_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE COR_ID = " + COR_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM COR";
            sSQL = sSQL + " WHERE COR_ID = " + COR_ID;

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
            sSQL = sSQL + " FROM COR";
            if (!String.IsNullOrEmpty(Convert.ToString(COR_ID)))
            {
                sCond = sCond + " COR_ID = " + COR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(COR_STS)))
            {
                sCond = sCond + " COR_STS = " + COR_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY COR_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}