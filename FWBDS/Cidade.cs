using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Cidade
    {
        #region Propriedades

        private int? _CID_ID;
        private int? _CID_STA_ID;
        private string _CID_NOM;

        private string _STA_NOM;

        public int? CID_ID
        {
            get { return _CID_ID; }
            set { _CID_ID = value; }
        }
        public int? CID_STA_ID
        {
            get { return _CID_STA_ID; }
            set { _CID_STA_ID = value; }
        }
        public string CID_NOM
        {
            get { return _CID_NOM; }
            set { _CID_NOM = value; }
        }

        public string STA_NOM
        {
            get { return _STA_NOM; }
            set { _STA_NOM = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO CID ";
            sSQL = sSQL + " (CID_STA_ID, CID_NOM)";
            sSQL = sSQL + " VALUES (" + CID_STA_ID + ",'" + CID_NOM.Replace("'", "''") + "')";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE CID ";
            sSQL = sSQL + " SET CID_NOM = '" + CID_NOM.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CID_STA_ID = " + CID_STA_ID;
            sSQL = sSQL + " WHERE CID_ID = " + CID_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM CID ";
            sSQL = sSQL + " WHERE CID_ID = " + CID_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT CID_ID, CID_STA_ID, CID_NOM ";

            sSQL = sSQL + " FROM CID ";

            sSQL = sSQL + " INNER JOIN STA ON CID_STA_ID = STA_ID ";

            if (!String.IsNullOrEmpty(CID_NOM))
            {
                sCond = sCond + " CID_NOM like '%" + CID_NOM.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(CID_ID)))
            {
                sCond = sCond + " CID_ID = " + CID_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(CID_STA_ID)))
            {
                sCond = sCond + " CID_STA_ID = " + CID_STA_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(STA_NOM))
            {
                sCond = sCond + " STA_NOM = '" + STA_NOM.Replace("'", "''") + "' AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CID_NOM ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
