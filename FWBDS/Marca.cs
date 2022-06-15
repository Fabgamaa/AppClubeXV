using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Marca
    {

        #region Propriedades

        private int? _MRC_ID;
        private string _MRC_DES;
        private int? _MRC_STS;
        private int? _MRC_USR_INC_ID;
        private int? _MRC_USR_ALT_ID;
        private DateTime? _MRC_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? MRC_ID
        {
            get { return _MRC_ID; }
            set { _MRC_ID = value; }
        }
        public string MRC_DES
        {
            get { return _MRC_DES; }
            set { _MRC_DES = value.ToUpper(); }
        }
        public int? MRC_STS
        {
            get { return _MRC_STS; }
            set { _MRC_STS = value; }
        }
        public int? MRC_USR_INC_ID
        {
            get { return _MRC_USR_INC_ID; }
            set { _MRC_USR_INC_ID = value; }
        }
        public int? MRC_USR_ALT_ID
        {
            get { return _MRC_USR_ALT_ID; }
            set { _MRC_USR_ALT_ID = value; }
        }
        public DateTime? MRC_TMS_ATL
        {
            get { return _MRC_TMS_ATL; }
            set { _MRC_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO MRC (";
            sSQL = sSQL + "MRC_DES, ";
            sSQL = sSQL + "MRC_STS, ";
            sSQL = sSQL + "MRC_USR_INC_ID, ";
            sSQL = sSQL + "MRC_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(MRC_DES))
            {
                sSQL = sSQL + "'" + MRC_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MRC_STS.ToString()))
            {
                sSQL = sSQL + MRC_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(MRC_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + MRC_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE MRC ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(MRC_DES))
            {
                sSQL = sSQL + "MRC_DES = '" + MRC_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "MRC_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(MRC_STS.ToString()))
            {
                sSQL = sSQL + "MRC_STS = " + MRC_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "MRC_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(MRC_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "MRC_USR_ALT_ID = " + MRC_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "MRC_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "MRC_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE MRC_ID = " + MRC_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MRC";
            sSQL = sSQL + " WHERE MRC_ID = " + MRC_ID;

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
            sSQL = sSQL + " FROM MRC";
            if (!String.IsNullOrEmpty(Convert.ToString(MRC_ID)))
            {
                sCond = sCond + " MRC_ID = " + MRC_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MRC_STS)))
            {
                sCond = sCond + " MRC_STS = " + MRC_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MRC_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}