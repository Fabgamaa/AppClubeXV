using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Observacao
    {

        #region Propriedades

        private int? _OBS_ID;
        private string _OBS_TAB_PAI;
        private int? _OBS_PAI_ID;
        private string _OBS_DES;
        private int? _OBS_STS;
        private int? _OBS_USR_INC_ID;
        private int? _OBS_USR_ALT_ID;
        private DateTime? _OBS_TMS_ATL;

        public int? OBS_ID
        {
            get { return _OBS_ID; }
            set { _OBS_ID = value; }
        }
        public string OBS_TAB_PAI
        {
            get { return _OBS_TAB_PAI; }
            set { _OBS_TAB_PAI = value.ToUpper(); }
        }
        public int? OBS_PAI_ID
        {
            get { return _OBS_PAI_ID; }
            set { _OBS_PAI_ID = value; }
        }
        public string OBS_DES
        {
            get { return _OBS_DES; }
            set { _OBS_DES = value.ToUpper(); }
        }
        public int? OBS_STS
        {
            get { return _OBS_STS; }
            set { _OBS_STS = value; }
        }
        public int? OBS_USR_INC_ID
        {
            get { return _OBS_USR_INC_ID; }
            set { _OBS_USR_INC_ID = value; }
        }
        public int? OBS_USR_ALT_ID
        {
            get { return _OBS_USR_ALT_ID; }
            set { _OBS_USR_ALT_ID = value; }
        }
        public DateTime? OBS_TMS_ATL
        {
            get { return _OBS_TMS_ATL; }
            set { _OBS_TMS_ATL = value; }
        }

        #endregion

        #region Métodos

        clsBanco dbConn = new clsBanco();

        public string Inserir()
        {
            string sSQL = "INSERT INTO OBS (";
            sSQL = sSQL + "OBS_TAB_PAI, ";
            sSQL = sSQL + "OBS_PAI_ID, ";
            sSQL = sSQL + "OBS_DES, ";
            sSQL = sSQL + "OBS_STS, ";
            sSQL = sSQL + "OBS_USR_INC_ID, ";
            sSQL = sSQL + "OBS_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(OBS_TAB_PAI))
            {
                sSQL = sSQL + "'" + OBS_TAB_PAI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_PAI_ID.ToString()))
            {
                sSQL = sSQL + OBS_PAI_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_DES))
            {
                sSQL = sSQL + "'" + OBS_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_STS.ToString()))
            {
                sSQL = sSQL + OBS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + OBS_USR_INC_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            sSQL = sSQL + "GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + ") ";

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Alterar()
        {
            string sSQL = "UPDATE OBS ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(OBS_TAB_PAI))
            {
                sSQL = sSQL + "OBS_TAB_PAI = '" + OBS_TAB_PAI.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OBS_TAB_PAI = NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_PAI_ID.ToString()))
            {
                sSQL = sSQL + "OBS_PAI_ID = " + OBS_PAI_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OBS_PAI_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(OBS_DES))
            {
                sSQL = sSQL + "OBS_DES = '" + OBS_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OBS_DES = NULL, ";
            }
            sSQL = sSQL + "OBS_STS = " + OBS_STS.ToString() + ", ";
            if (!String.IsNullOrEmpty(OBS_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "OBS_USR_ALT_ID = " + OBS_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OBS_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "OBS_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE OBS_ID = " + OBS_ID;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OBS";
            sSQL = sSQL + " WHERE OBS_ID = " + OBS_ID;
            return dbConn.Executar(sSQL);

        }

        public string Inativar()
        {
            string sSQL = "UPDATE OBS";
            sSQL = sSQL + " SET OBS_STS = 0";
            sSQL = sSQL + " WHERE OBS_ID = " + OBS_ID;
            return dbConn.Executar(sSQL);
        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT OBS.*, USR_NOM ";
            sSQL = sSQL + " FROM OBS ";
            sSQL = sSQL + " INNER JOIN USR ON OBS_USR_INC_ID = USR_ID ";
            if (!String.IsNullOrEmpty(Convert.ToString(OBS_TAB_PAI)))
            {
                sCond = sCond + " OBS_TAB_PAI = '" + OBS_TAB_PAI + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OBS_PAI_ID)))
            {
                sCond = sCond + " OBS_PAI_ID = " + OBS_PAI_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OBS_ID)))
            {
                sCond = sCond + " OBS_ID = " + OBS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OBS_STS)))
            {
                sCond = sCond + " OBS_STS = " + OBS_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY OBS_TMS_ATL DESC";
            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}