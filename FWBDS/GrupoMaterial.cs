using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class GrupoMaterial
    {

        #region Propriedades

        private int? _GRP_MRL_ID;
        private string _GRP_MRL_DES;
        private int? _GRP_MRL_STS;
        private int? _GRP_MRL_USR_INC_ID;
        private int? _GRP_MRL_USR_ALT_ID;
        private DateTime? _GRP_MRL_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? GRP_MRL_ID
        {
            get { return _GRP_MRL_ID; }
            set { _GRP_MRL_ID = value; }
        }
        public string GRP_MRL_DES
        {
            get { return _GRP_MRL_DES; }
            set { _GRP_MRL_DES = value.ToUpper(); }
        }
        public int? GRP_MRL_STS
        {
            get { return _GRP_MRL_STS; }
            set { _GRP_MRL_STS = value; }
        }
        public int? GRP_MRL_USR_INC_ID
        {
            get { return _GRP_MRL_USR_INC_ID; }
            set { _GRP_MRL_USR_INC_ID = value; }
        }
        public int? GRP_MRL_USR_ALT_ID
        {
            get { return _GRP_MRL_USR_ALT_ID; }
            set { _GRP_MRL_USR_ALT_ID = value; }
        }
        public DateTime? GRP_MRL_TMS_ATL
        {
            get { return _GRP_MRL_TMS_ATL; }
            set { _GRP_MRL_TMS_ATL = value; }
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
            string sSQL = "INSERT INTO GRP_MRL (";
            sSQL = sSQL + "GRP_MRL_DES, ";
            sSQL = sSQL + "GRP_MRL_STS, ";
            sSQL = sSQL + "GRP_MRL_USR_INC_ID, ";
            sSQL = sSQL + "GRP_MRL_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(GRP_MRL_DES))
            {
                sSQL = sSQL + "'" + GRP_MRL_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(GRP_MRL_STS.ToString()))
            {
                sSQL = sSQL + GRP_MRL_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(GRP_MRL_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + GRP_MRL_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE GRP_MRL ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(GRP_MRL_DES))
            {
                sSQL = sSQL + "GRP_MRL_DES = '" + GRP_MRL_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "GRP_MRL_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(GRP_MRL_STS.ToString()))
            {
                sSQL = sSQL + "GRP_MRL_STS = " + GRP_MRL_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "GRP_MRL_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(GRP_MRL_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "GRP_MRL_USR_ALT_ID = " + GRP_MRL_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "GRP_MRL_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "GRP_MRL_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE GRP_MRL_ID = " + GRP_MRL_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM GRP_MRL";
            sSQL = sSQL + " WHERE GRP_MRL_ID = " + GRP_MRL_ID;

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
            sSQL = sSQL + " FROM GRP_MRL";
            if (!String.IsNullOrEmpty(Convert.ToString(GRP_MRL_ID)))
            {
                sCond = sCond + " GRP_MRL_ID = " + GRP_MRL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(GRP_MRL_STS)))
            {
                sCond = sCond + " GRP_MRL_STS = " + GRP_MRL_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY GRP_MRL_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}