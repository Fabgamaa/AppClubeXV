using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Operador
    {

        #region Propriedades

        private int? _OPD_ID;
        private int? _OPD_MAQ_TIP_ID;
        private string _OPD_NOM;
        private string _OPD_PUO;
        private string _OPD_TUM;
        private int? _OPD_STS;
        private string _OPD_TUR;
        private int? _OPD_USR_INC_ID;
        private int? _OPD_USR_ALT_ID;
        private DateTime? _OPD_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? OPD_ID
        {
            get { return _OPD_ID; }
            set { _OPD_ID = value; }
        }
        public int? OPD_MAQ_TIP_ID
        {
            get { return _OPD_MAQ_TIP_ID; }
            set { _OPD_MAQ_TIP_ID = value; }
        }
        public string OPD_NOM
        {
            get { return _OPD_NOM; }
            set { _OPD_NOM = value.ToUpper(); }
        }
        public string OPD_PUO
        {
            get { return _OPD_PUO; }
            set { _OPD_PUO = value.ToUpper(); }
        }
        public string OPD_TUM
        {
            get { return _OPD_TUM; }
            set { _OPD_TUM = value.ToUpper(); }
        }
        public int? OPD_STS
        {
            get { return _OPD_STS; }
            set { _OPD_STS = value; }
        }
        public string OPD_TUR
        {
            get { return _OPD_TUR; }
            set { _OPD_TUR = value.ToUpper(); }
        }
        public int? OPD_USR_INC_ID
        {
            get { return _OPD_USR_INC_ID; }
            set { _OPD_USR_INC_ID = value; }
        }
        public int? OPD_USR_ALT_ID
        {
            get { return _OPD_USR_ALT_ID; }
            set { _OPD_USR_ALT_ID = value; }
        }
        public DateTime? OPD_TMS_ATL
        {
            get { return _OPD_TMS_ATL; }
            set { _OPD_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO OPD (";
            sSQL = sSQL + "OPD_MAQ_TIP_ID, ";
            sSQL = sSQL + "OPD_NOM, ";
            sSQL = sSQL + "OPD_PUO, ";
            sSQL = sSQL + "OPD_TUM, ";
            sSQL = sSQL + "OPD_STS, ";
            sSQL = sSQL + "OPD_TUR, ";
            sSQL = sSQL + "OPD_USR_INC_ID, ";
            sSQL = sSQL + "OPD_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(OPD_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + OPD_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_NOM))
            {
                sSQL = sSQL + "'" + OPD_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_PUO))
            {
                sSQL = sSQL + "'" + OPD_PUO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_TUM))
            {
                sSQL = sSQL + "'" + OPD_TUM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_STS.ToString()))
            {
                sSQL = sSQL + OPD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_TUR))
            {
                sSQL = sSQL + "'" + OPD_TUR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + OPD_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE OPD ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(OPD_MAQ_TIP_ID.ToString()))
            {
                sSQL = sSQL + "OPD_MAQ_TIP_ID = " + OPD_MAQ_TIP_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OPD_MAQ_TIP_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_NOM))
            {
                sSQL = sSQL + "OPD_NOM = '" + OPD_NOM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OPD_NOM = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_PUO))
            {
                sSQL = sSQL + "OPD_PUO = '" + OPD_PUO.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OPD_PUO = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_TUM))
            {
                sSQL = sSQL + "OPD_TUM = '" + OPD_TUM.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OPD_TUM = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_STS.ToString()))
            {
                sSQL = sSQL + "OPD_STS = " + OPD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "OPD_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_TUR))
            {
                sSQL = sSQL + "OPD_TUR = '" + OPD_TUR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OPD_TUR = NULL, ";
            }
            if (!String.IsNullOrEmpty(OPD_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "OPD_USR_ALT_ID = " + OPD_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OPD_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "OPD_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE OPD_ID = " + OPD_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OPD";
            sSQL = sSQL + " WHERE OPD_ID = " + OPD_ID;

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
            sSQL = sSQL + " FROM OPD";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = OPD_MAQ_TIP_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(OPD_ID)))
            {
                sCond = sCond + " OPD_ID = " + OPD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OPD_MAQ_TIP_ID)))
            {
                sCond = sCond + " OPD_MAQ_TIP_ID = " + OPD_MAQ_TIP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(OPD_NOM))
            {
                sCond = sCond + " OPD_NOM = '" + OPD_NOM.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(OPD_TUR))
            {
                sCond = sCond + " OPD_TUR = '" + OPD_TUR.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OPD_STS)))
            {
                sCond = sCond + " OPD_STS = " + OPD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY OPD_NOM";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}
