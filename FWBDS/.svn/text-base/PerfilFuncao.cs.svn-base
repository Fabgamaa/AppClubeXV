using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class PerfilFuncao
    {
        #region Propriedades

        private int? _PFL_FAO_ID;
        private int? _PFL_FAO_PFL_ID;
        private int? _PFL_FAO_FAO_ID;
        private int? _PFL_FAO_USR_INC_ID;
        private int? _PFL_FAO_USR_ALT_ID;

        public int? PFL_FAO_ID
        {
            get { return _PFL_FAO_ID; }
            set { _PFL_FAO_ID = value; }
        }
        public int? PFL_FAO_PFL_ID
        {
            get { return _PFL_FAO_PFL_ID; }
            set { _PFL_FAO_PFL_ID = value; }
        }
        public int? PFL_FAO_FAO_ID
        {
            get { return _PFL_FAO_FAO_ID; }
            set { _PFL_FAO_FAO_ID = value; }
        }
        public int? PFL_FAO_USR_INC_ID
        {
            get { return _PFL_FAO_USR_INC_ID; }
            set { _PFL_FAO_USR_INC_ID = value; }
        }
        public int? PFL_FAO_USR_ALT_ID
        {
            get { return _PFL_FAO_USR_ALT_ID; }
            set { _PFL_FAO_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO PFL_FAO ";
            sSQL = sSQL + " (PFL_FAO_FAO_ID, PFL_FAO_PFL_ID, PFL_FAO_USR_INC_ID, PFL_FAO_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + PFL_FAO_FAO_ID + "," + PFL_FAO_PFL_ID;
            if (!String.IsNullOrEmpty(PFL_FAO_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + PFL_FAO_USR_INC_ID;
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
            string sSQL = "DELETE FROM PFL_FAO ";
            sSQL = sSQL + " WHERE PFL_FAO_ID = " + PFL_FAO_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT FAO_ID, FAO_DES, FAO_OBS, PFL_FAO_ID, PFL_FAO_PFL_ID, PFL_FAO_FAO_ID ";

            sSQL = sSQL + " FROM PFL_FAO, FAO ";
            sCond = sCond + " FAO_ID = PFL_FAO_FAO_ID AND ";
            sCond = sCond + " FAO_STS = 1 AND ";

            if (!String.IsNullOrEmpty(PFL_FAO_PFL_ID.ToString()))
            {
                sCond = sCond + " PFL_FAO_PFL_ID = " + PFL_FAO_PFL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PFL_FAO_FAO_ID.ToString()))
            {
                sCond = sCond + " PFL_FAO_FAO_ID = " + PFL_FAO_FAO_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_FAO_ID)))
            {
                sCond = sCond + " PFL_FAO_ID = " + PFL_FAO_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PFL_FAO_PFL_ID ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
