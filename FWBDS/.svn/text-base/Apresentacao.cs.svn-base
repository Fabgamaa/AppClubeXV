using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Apresentacao
    {

        #region Propriedades

        private int? _APS_ID;
        private string _APS_DES;
        private double? _APS_PES;
        private double? _APS_DMO;
        private int? _APS_STS;
        private int? _APS_USR_INC_ID;
        private int? _APS_USR_ALT_ID;
        private DateTime? _APS_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? APS_ID
        {
            get { return _APS_ID; }
            set { _APS_ID = value; }
        }
        public string APS_DES
        {
            get { return _APS_DES; }
            set { _APS_DES = value.ToUpper(); }
        }
        public double? APS_PES
        {
            get { return _APS_PES; }
            set { _APS_PES = value; }
        }
        public double? APS_DMO
        {
            get { return _APS_DMO; }
            set { _APS_DMO = value; }
        }
        public int? APS_STS
        {
            get { return _APS_STS; }
            set { _APS_STS = value; }
        }
        public int? APS_USR_INC_ID
        {
            get { return _APS_USR_INC_ID; }
            set { _APS_USR_INC_ID = value; }
        }
        public int? APS_USR_ALT_ID
        {
            get { return _APS_USR_ALT_ID; }
            set { _APS_USR_ALT_ID = value; }
        }
        public DateTime? APS_TMS_ATL
        {
            get { return _APS_TMS_ATL; }
            set { _APS_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO APS (";
            sSQL = sSQL + "APS_DES, ";
            sSQL = sSQL + "APS_PES, ";
            sSQL = sSQL + "APS_DMO, ";
            sSQL = sSQL + "APS_STS, ";
            sSQL = sSQL + "APS_USR_INC_ID, ";
            sSQL = sSQL + "APS_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(APS_DES))
            {
                sSQL = sSQL + "'" + APS_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_PES.ToString()))
            {
                sSQL = sSQL + APS_PES + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_DMO.ToString()))
            {
                sSQL = sSQL + APS_DMO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_STS.ToString()))
            {
                sSQL = sSQL + APS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + APS_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE APS ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(APS_DES))
            {
                sSQL = sSQL + "APS_DES = '" + APS_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "APS_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_PES.ToString()))
            {
                sSQL = sSQL + "APS_PES = " + APS_PES + ", ";
            }
            else
            {
                sSQL = sSQL + "APS_PES = NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_DMO.ToString()))
            {
                sSQL = sSQL + "APS_DMO = " + APS_DMO + ", ";
            }
            else
            {
                sSQL = sSQL + "APS_DMO = NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_STS.ToString()))
            {
                sSQL = sSQL + "APS_STS = " + APS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "APS_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(APS_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "APS_USR_ALT_ID = " + APS_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "APS_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "APS_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE APS_ID = " + APS_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM APS";
            sSQL = sSQL + " WHERE APS_ID = " + APS_ID;

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
            sSQL = sSQL + " FROM APS";
            if (!String.IsNullOrEmpty(Convert.ToString(APS_ID)))
            {
                sCond = sCond + " APS_ID = " + APS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(APS_STS)))
            {
                sCond = sCond + " APS_STS = " + APS_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY APS_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}