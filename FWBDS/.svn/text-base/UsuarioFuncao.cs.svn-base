using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class UsuarioFuncao
    {
        #region Propriedades

        private int? _USR_FAO_ID;
        private int? _USR_FAO_USR_ID;
        private int? _USR_FAO_FAO_ID;
        private int? _USR_FAO_USR_INC_ID;
        private int? _USR_FAO_USR_ALT_ID;

        public int? USR_FAO_ID
        {
            get { return _USR_FAO_ID; }
            set { _USR_FAO_ID = value; }
        }
        public int? USR_FAO_USR_ID
        {
            get { return _USR_FAO_USR_ID; }
            set { _USR_FAO_USR_ID = value; }
        }
        public int? USR_FAO_FAO_ID
        {
            get { return _USR_FAO_FAO_ID; }
            set { _USR_FAO_FAO_ID = value; }
        }
        public int? USR_FAO_USR_INC_ID
        {
            get { return _USR_FAO_USR_INC_ID; }
            set { _USR_FAO_USR_INC_ID = value; }
        }
        public int? USR_FAO_USR_ALT_ID
        {
            get { return _USR_FAO_USR_ALT_ID; }
            set { _USR_FAO_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO USR_FAO ";
            sSQL = sSQL + " (USR_FAO_FAO_ID, USR_FAO_USR_ID, USR_FAO_USR_INC_ID, USR_FAO_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + USR_FAO_FAO_ID + "," + USR_FAO_USR_ID;
            if (!String.IsNullOrEmpty(USR_FAO_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_FAO_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM USR_FAO ";
            sSQL = sSQL + " WHERE USR_FAO_USR_ID = " + USR_FAO_USR_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT USR_FAO_ID, USR_FAO_USR_ID, USR_FAO_FAO_ID ";

            sSQL = sSQL + " FROM USR_FAO ";
            if (!String.IsNullOrEmpty(USR_FAO_USR_ID.ToString()))
            {
                sCond = sCond + " USR_FAO_USR_ID = " + USR_FAO_USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(USR_FAO_FAO_ID.ToString()))
            {
                sCond = sCond + " USR_FAO_FAO_ID = " + USR_FAO_FAO_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(USR_FAO_ID)))
            {
                sCond = sCond + " USR_FAO_ID = " + USR_FAO_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY USR_FAO_USR_ID ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
