using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Fornecedor
    {

        #region Propriedades

        private int? _FOR_ID;
        private string _FOR_NOM;
        private string _FOR_SAP;
        private string _FOR_TIP;
        private int? _FOR_STS;
        private int? _FOR_USR_INC_ID;
        private int? _FOR_USR_ALT_ID;
        private DateTime? _FOR_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? FOR_ID
        {
            get { return _FOR_ID; }
            set { _FOR_ID = value; }
        }
        public string FOR_NOM
        {
            get { return _FOR_NOM; }
            set { _FOR_NOM = value.ToUpper(); }
        }
        public string FOR_SAP
        {
            get { return _FOR_SAP; }
            set { _FOR_SAP = value.ToUpper(); }
        }
        public string FOR_TIP
        {
            get { return _FOR_TIP; }
            set { _FOR_TIP = value.ToUpper(); }
        }
        public int? FOR_STS
        {
            get { return _FOR_STS; }
            set { _FOR_STS = value; }
        }
        public int? FOR_USR_INC_ID
        {
            get { return _FOR_USR_INC_ID; }
            set { _FOR_USR_INC_ID = value; }
        }
        public int? FOR_USR_ALT_ID
        {
            get { return _FOR_USR_ALT_ID; }
            set { _FOR_USR_ALT_ID = value; }
        }
        public DateTime? FOR_TMS_ATL
        {
            get { return _FOR_TMS_ATL; }
            set { _FOR_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO [FOR](";
            sSQL = sSQL + "FOR_NOM, ";
            sSQL = sSQL + "FOR_SAP, ";
            sSQL = sSQL + "FOR_TIP, ";
            sSQL = sSQL + "FOR_STS, ";
            sSQL = sSQL + "FOR_USR_INC_ID, ";
            sSQL = sSQL + "FOR_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(FOR_NOM))
            {
                sSQL = sSQL + "'" + FOR_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_SAP))
            {
                sSQL = sSQL + "'" + FOR_SAP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_TIP))
            {
                sSQL = sSQL + "'" + FOR_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_STS.ToString()))
            {
                sSQL = sSQL + FOR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + FOR_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE [FOR]";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(FOR_NOM))
            {
                sSQL = sSQL + "FOR_NOM = '" + FOR_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "FOR_NOM = NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_SAP))
            {
                sSQL = sSQL + "FOR_SAP = '" + FOR_SAP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "FOR_SAP = NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_TIP))
            {
                sSQL = sSQL + "FOR_TIP = '" + FOR_TIP.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "FOR_TIP = NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_STS.ToString()))
            {
                sSQL = sSQL + "FOR_STS = " + FOR_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "FOR_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(FOR_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "FOR_USR_ALT_ID = " + FOR_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "FOR_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "FOR_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE FOR_ID = " + FOR_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM [FOR]";
            sSQL = sSQL + " WHERE FOR_ID = " + FOR_ID;

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
            sSQL = sSQL + " FROM [FOR]";
            if (!String.IsNullOrEmpty(Convert.ToString(FOR_ID)))
            {
                sCond = sCond + " FOR_ID = " + FOR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(FOR_TIP))
            {
                sCond = sCond + " FOR_TIP = '" + FOR_TIP + "' AND ";
            }

            if (!String.IsNullOrEmpty(Convert.ToString(FOR_STS)))
            {
                sCond = sCond + " FOR_STS = " + FOR_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY FOR_NOM";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}