using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Pais
    {
        #region Propriedades

        private int? _PAS_ID;
        private string _PAS_SGL;
        private string _PAS_NOM;

        public int? PAS_ID
        {
            get { return _PAS_ID; }
            set { _PAS_ID = value; }
        }
        public string PAS_SGL
        {
            get { return _PAS_SGL; }
            set { _PAS_SGL = value; }
        }
        public string PAS_NOM
        {
            get { return _PAS_NOM; }
            set { _PAS_NOM = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO PAS ";
            sSQL = sSQL + " (PAS_SGL, PAS_NOM)";
            sSQL = sSQL + " VALUES ('" + PAS_SGL.Replace("'","''") + "','" + PAS_NOM.Replace("'", "''") + "')";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE PAS ";
            sSQL = sSQL + " SET PAS_NOM = '" + PAS_NOM.Replace("'", "''") + "' ";
            sSQL = sSQL + ", PAS_SGL = '" + PAS_SGL.Replace("'", "''") + "' ";
            sSQL = sSQL + " WHERE PAS_ID = " + PAS_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PAS ";
            sSQL = sSQL + " WHERE PAS_ID = " + PAS_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT PAS_ID, PAS_SGL, PAS_NOM ";

            sSQL = sSQL + " FROM PAS ";
            if (!String.IsNullOrEmpty(PAS_NOM))
            {
                sCond = sCond + " PAS_NOM like '%" + PAS_NOM.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PAS_ID)))
            {
                sCond = sCond + " PAS_ID = " + PAS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PAS_SGL))
            {
                sCond = sCond + " PAS_SGL = '" + PAS_SGL.Replace("'", "''") + "' AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PAS_NOM ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
