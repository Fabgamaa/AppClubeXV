using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class CEP
    {
        #region Propriedades

        private string _CEP_COD;
        private string _CEP_TIP_LGO;
        private string _CEP_NOM_LGO;
        private string _CEP_BRR;
        private string _CEP_PAS;
        private string _CEP_STA;
        private string _CEP_CID;

        public string CEP_COD
        {
            get { return _CEP_COD; }
            set { _CEP_COD = value; }
        }
        public string CEP_TIP_LGO
        {
            get { return _CEP_TIP_LGO; }
            set { _CEP_TIP_LGO = value; }
        }
        public string CEP_NOM_LGO
        {
            get { return _CEP_NOM_LGO; }
            set { _CEP_NOM_LGO = value; }
        }
        public string CEP_BRR
        {
            get { return _CEP_BRR; }
            set { _CEP_BRR = value; }
        }
        public string CEP_PAS
        {
            get { return _CEP_PAS; }
            set { _CEP_PAS = value; }
        }
        public string CEP_STA
        {
            get { return _CEP_STA; }
            set { _CEP_STA = value; }
        }
        public string CEP_CID
        {
            get { return _CEP_CID; }
            set { _CEP_CID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO CEP ";
            sSQL = sSQL + " (CEP_COD, CEP_TIP_LGO, CEP_NOM_LGO, CEP_BRR, CEP_PAS, CEP_STA, CEP_CID)";
            sSQL = sSQL + " VALUES ('" + CEP_COD.Replace("'", "''") + "', '" + CEP_TIP_LGO.Replace("'", "''") + "',";
            sSQL = sSQL + " '" + CEP_NOM_LGO.Replace("'", "''") + "', '" + CEP_BRR.Replace("'", "''") + "',";
            sSQL = sSQL + " '" + CEP_PAS.Replace("'", "''") + "', '" + CEP_STA.Replace("'", "''") + "',";
            sSQL = sSQL + " '" + CEP_CID.Replace("'", "''") + "')";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE CEP ";
            sSQL = sSQL + " SET CEP_COD = '" + CEP_COD.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_TIP_LGO = '" + CEP_TIP_LGO.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_NOM_LGO = '" + CEP_NOM_LGO.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_BRR = '" + CEP_BRR.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_PAS = '" + CEP_PAS.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_STA = '" + CEP_STA.Replace("'", "''") + "' ";
            sSQL = sSQL + ", CEP_CID = '" + CEP_CID.Replace("'", "''") + "' ";
            sSQL = sSQL + " WHERE CEP_COD = '" + CEP_COD.Replace("'", "''") + "' ";

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM CEP ";
            sSQL = sSQL + " WHERE CEP_COD = '" + CEP_COD.Replace("'", "''") + "' ";

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT CEP_COD, CEP_TIP_LGO, CEP_NOM_LGO, CEP_BRR, CEP_PAS, CEP_STA, CEP_CID ";

            sSQL = sSQL + " FROM CEP ";
            if (!String.IsNullOrEmpty(CEP_COD))
            {
                sCond = sCond + " CEP_COD = '" + CEP_COD.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(CEP_NOM_LGO))
            {
                sCond = sCond + " CEP_NOM_LGO like '%" + CEP_NOM_LGO.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(CEP_PAS))
            {
                sCond = sCond + " CEP_PAS = '" + CEP_PAS.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(CEP_STA))
            {
                sCond = sCond + " CEP_STA = '" + CEP_STA.Replace("'", "''") + "' AND ";
            }
            if (!String.IsNullOrEmpty(CEP_CID))
            {
                sCond = sCond + " CEP_CID = '" + CEP_CID.Replace("'", "''") + "' AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CEP_COD ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
