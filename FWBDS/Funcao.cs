using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Funcao
    {
        #region Propriedades

        private int? _FAO_ID;
        private string _FAO_DES;
        private string _FAO_OBS;
        private bool? _FAO_STS;
        private int? _FAO_USR_INC_ID;
        private int? _FAO_USR_ALT_ID;

        public int? FAO_ID
        {
            get { return _FAO_ID; }
            set { _FAO_ID = value; }
        }
        public string FAO_DES
        {
            get { return _FAO_DES; }
            set { _FAO_DES = value; }
        }
        public string FAO_OBS
        {
            get { return _FAO_OBS; }
            set { _FAO_OBS = value; }
        }
        public bool? FAO_STS
        {
            get { return _FAO_STS; }
            set { _FAO_STS = value; }
        }
        public int? FAO_USR_INC_ID
        {
            get { return _FAO_USR_INC_ID; }
            set { _FAO_USR_INC_ID = value; }
        }
        public int? FAO_USR_ALT_ID
        {
            get { return _FAO_USR_ALT_ID; }
            set { _FAO_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO FAO ";
            sSQL = sSQL + " (FAO_DES, FAO_OBS, FAO_STS, FAO_USR_INC_ID, FAO_TMS_ATL)";
            sSQL = sSQL + " VALUES ('" + FAO_DES.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(FAO_OBS))
            {
                sSQL = sSQL + ",'" + FAO_OBS.Replace("'","''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + "," + FAO_STS;
            if (!String.IsNullOrEmpty(FAO_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + FAO_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE FAO ";
            sSQL = sSQL + " SET FAO_DES = '" + FAO_DES.Replace("'", "''") + "' ";
            if (!String.IsNullOrEmpty(FAO_OBS))
            {
                sSQL = sSQL + ", FAO_OBS = '" + FAO_OBS.Replace("'", "''") + "'";
            }
            if (!String.IsNullOrEmpty(FAO_STS.ToString()))
            {
                sSQL = sSQL + ", FAO_STS = " + FAO_STS;
            }
            if (!String.IsNullOrEmpty(FAO_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", FAO_USR_ALT_ID = " + FAO_USR_ALT_ID;
            }
            sSQL = sSQL + ", FAO_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE FAO_ID = " + FAO_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM FAO ";
            sSQL = sSQL + " WHERE FAO_ID = " + FAO_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT FAO_ID, FAO_DES, FAO_OBS, FAO_STS ";

            sSQL = sSQL + " FROM FAO ";
            if (!String.IsNullOrEmpty(FAO_DES))
            {
                sCond = sCond + " FAO_DES like '%" + FAO_DES.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(FAO_ID)))
            {
                sCond = sCond + " FAO_ID = " + FAO_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(FAO_STS)))
            {
                sCond = sCond + " FAO_STS = " + FAO_STS + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY FAO_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
