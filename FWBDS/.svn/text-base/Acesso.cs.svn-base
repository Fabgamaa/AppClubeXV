using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Acesso
    {
        #region Propriedades

        private int? _ACS_ID;
        private int? _ACS_USR_ID;
        private string _ACS_IP;
        private string _ACS_USR_COD;
        private string _ACS_USR_SNH;
        private DateTime? _ACS_DAT_INI;
        private DateTime? _ACS_DAT_FNL;
        private int? _ACS_SCS;
        

        public int? ACS_ID
        {
            get { return _ACS_ID; }
            set { _ACS_ID = value; }
        }
        public int? ACS_USR_ID
        {
            get { return _ACS_USR_ID; }
            set { _ACS_USR_ID = value; }
        }
        public string ACS_IP
        {
            get { return _ACS_IP; }
            set { _ACS_IP = value; }
        }
        public string ACS_USR_COD
        {
            get { return _ACS_USR_COD; }
            set { _ACS_USR_COD = value; }
        }
        public string ACS_USR_SNH
        {
            get { return _ACS_USR_SNH; }
            set { _ACS_USR_SNH = value; }
        }
        public DateTime? ACS_DAT_INI
        {
            get { return _ACS_DAT_INI; }
            set { _ACS_DAT_INI = value; }
        }
        public DateTime? ACS_DAT_FNL
        {
            get { return _ACS_DAT_FNL; }
            set { _ACS_DAT_FNL = value; }
        }
        public int? ACS_SCS
        {
            get { return _ACS_SCS; }
            set { _ACS_SCS = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO ACS ";
            sSQL = sSQL + " (ACS_USR_COD, ACS_USR_ID, ACS_IP, ACS_USR_SNH, ACS_DAT_INI, ACS_DAT_FNL,";
            sSQL = sSQL + "ACS_SCS, ACS_TMS_ATL)";
            sSQL = sSQL + " VALUES ('" + ACS_USR_COD.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(ACS_USR_ID.ToString()))
            {
                sSQL = sSQL + "," + ACS_USR_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            if (!String.IsNullOrEmpty(ACS_IP))
            {
                sSQL = sSQL + ",'" + ACS_IP.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            if (!String.IsNullOrEmpty(ACS_USR_SNH))
            {
                sSQL = sSQL + ",'" + ACS_USR_SNH.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",Convert(datetime, '" + ACS_DAT_INI.ToString() + "', 103)";
            if (!String.IsNullOrEmpty(ACS_DAT_FNL.ToString()))
            {
                sSQL = sSQL + ",Convert(datetime, '" + ACS_DAT_FNL.ToString() + "', 103)";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + "," + ACS_SCS.ToString();
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE ACS ";
            sSQL = sSQL + " SET ACS_DAT_FNL = convert(datetime, '" + ACS_DAT_FNL.ToString() + "', 103) ";
            sSQL = sSQL + ", ACS_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE ACS_ID = " + ACS_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ACS ";
            sSQL = sSQL + " WHERE ACS_ID = " + ACS_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT * ";

            sSQL = sSQL + " FROM ACS ";
            if (!String.IsNullOrEmpty(ACS_USR_COD))
            {
                sCond = sCond + " ACS_COD like '%" + ACS_USR_COD.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ACS_ID)))
            {
                sCond = sCond + " ACS_ID = " + ACS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ACS_USR_ID)))
            {
                sCond = sCond + " ACS_USR_ID = " + ACS_USR_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ACS_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
