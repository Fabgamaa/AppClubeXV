using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Perfil
    {
        #region Propriedades

        private int? _PFL_ID;
        private int? _PFL_PFL_RSP_ID;
        private string _PFL_DES;
        private int? _PFL_STS;
        private int? _PFL_STM;
        private int? _PFL_USR_INC_ID;
        private int? _PFL_USR_ALT_ID;

        public int? PFL_ID
        {
            get { return _PFL_ID; }
            set { _PFL_ID = value; }
        }
        public int? PFL_PFL_RSP_ID
        {
            get { return _PFL_PFL_RSP_ID; }
            set { _PFL_PFL_RSP_ID = value; }
        }
        public string PFL_DES
        {
            get { return _PFL_DES; }
            set { _PFL_DES = value.ToUpper(); }
        }
        public int? PFL_STS
        {
            get { return _PFL_STS; }
            set { _PFL_STS = value; }
        }
        public int? PFL_STM
        {
            get { return _PFL_STM; }
            set { _PFL_STM = value; }
        }
        public int? PFL_USR_INC_ID
        {
            get { return _PFL_USR_INC_ID; }
            set { _PFL_USR_INC_ID = value; }
        }
        public int? PFL_USR_ALT_ID
        {
            get { return _PFL_USR_ALT_ID; }
            set { _PFL_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO PFL ";
            sSQL = sSQL + " (PFL_DES, PFL_PFL_RSP_ID, PFL_STS, PFL_STM, PFL_USR_INC_ID, PFL_TMS_ATL)";
            sSQL = sSQL + " VALUES ('" + PFL_DES.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(PFL_PFL_RSP_ID.ToString()))
            {
                sSQL = sSQL + "," + PFL_PFL_RSP_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + "," + PFL_STS;
            sSQL = sSQL + "," + PFL_STM;
            if (!String.IsNullOrEmpty(PFL_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + PFL_USR_INC_ID;
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
            string sSQL = "UPDATE PFL ";
            sSQL = sSQL + " SET PFL_DES = '" + PFL_DES.Replace("'", "''") + "' ";
            if (!String.IsNullOrEmpty(PFL_PFL_RSP_ID.ToString()))
            {
                sSQL = sSQL + ", PFL_PFL_RSP_ID = " + PFL_PFL_RSP_ID;
            }
            else
            {
                sSQL = sSQL + ", PFL_PFL_RSP_ID = NULL";
            }
            sSQL = sSQL + ", PFL_STS = " + PFL_STS;
            if (!String.IsNullOrEmpty(PFL_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", PFL_USR_ALT_ID = " + PFL_USR_ALT_ID;
            }
            sSQL = sSQL + ", PFL_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE PFL_ID = " + PFL_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PFL ";
            sSQL = sSQL + " WHERE PFL_ID = " + PFL_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT A.*, B.PFL_DES PFL_PFL_RSP_DES ";

            sSQL = sSQL + " FROM PFL A LEFT OUTER JOIN PFL B ";

            sSQL = sSQL + " ON A.PFL_PFL_RSP_ID = B.PFL_ID ";
            if (!String.IsNullOrEmpty(PFL_DES))
            {
                sCond = sCond + " A.PFL_DES like '%" + PFL_DES.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_PFL_RSP_ID)))
            {
                sCond = sCond + " A.PFL_PFL_RSP_ID = " + PFL_PFL_RSP_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_STS)))
            {
                sCond = sCond + " A.PFL_STS = " + PFL_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_ID)))
            {
                sCond = sCond + " A.PFL_ID = " + PFL_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PFL_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
