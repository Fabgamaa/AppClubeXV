using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Estado
    {
        #region Propriedades

        private int? _STA_ID;
        private int? _STA_PAS_ID;
        private string _STA_SGL;
        private string _STA_NOM;

        private string _PAS_NOM;

        public int? STA_ID
        {
            get { return _STA_ID; }
            set { _STA_ID = value; }
        }
        public int? STA_PAS_ID
        {
            get { return _STA_PAS_ID; }
            set { _STA_PAS_ID = value; }
        }
        public string STA_SGL
        {
            get { return _STA_SGL; }
            set { _STA_SGL = value; }
        }
        public string STA_NOM
        {
            get { return _STA_NOM; }
            set { _STA_NOM = value; }
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
            string sSQL = "INSERT INTO STA ";
            sSQL = sSQL + " (STA_PAS_ID, STA_SGL, STA_NOM)";
            sSQL = sSQL + " VALUES (" + STA_PAS_ID + ",'" + STA_SGL.Replace("'", "''") + "','" + STA_NOM.Replace("'", "''") + "')";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE STA ";
            sSQL = sSQL + " SET STA_NOM = '" + STA_NOM.Replace("'", "''") + "' ";
            sSQL = sSQL + ", STA_SGL = '" + STA_SGL.Replace("'", "''") + "' ";
            sSQL = sSQL + ", STA_PAS_ID = " + STA_PAS_ID;
            sSQL = sSQL + " WHERE STA_ID = " + STA_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM STA ";
            sSQL = sSQL + " WHERE STA_ID = " + STA_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT STA_ID, STA_PAS_ID, STA_SGL, STA_NOM ";

            sSQL = sSQL + " FROM STA ";
            sSQL = sSQL + " INNER JOIN PAS ON STA_PAS_ID = PAS_ID ";
            if (!String.IsNullOrEmpty(STA_NOM))
            {
                sCond = sCond + " STA_NOM like '%" + STA_NOM.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(STA_ID)))
            {
                sCond = sCond + " STA_ID = " + STA_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(STA_PAS_ID)))
            {
                sCond = sCond + " STA_PAS_ID = " + STA_PAS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(STA_SGL))
            {
                sCond = sCond + " STA_SGL = '" + STA_SGL.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(STA_NOM))
            {
                sCond = sCond + " PAS_NOM like '" + STA_NOM.Replace("'", "''") + "' AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY STA_NOM ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
