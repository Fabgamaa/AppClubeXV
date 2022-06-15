using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class TipoAnexo
    {
        #region Propriedades

        private int? _TIP_ANX_ID;
        private string _TIP_ANX_DES;
        private int? _TIP_ANX_STS;
        private int? _TIP_ANX_USR_INC_ID;
        private int? _TIP_ANX_USR_ALT_ID;

        public int? TIP_ANX_ID
        {
            get { return _TIP_ANX_ID; }
            set { _TIP_ANX_ID = value; }
        }
        public string TIP_ANX_DES
        {
            get { return _TIP_ANX_DES; }
            set { _TIP_ANX_DES = value.ToUpper(); }
        }
        public int? TIP_ANX_STS
        {
            get { return _TIP_ANX_STS; }
            set { _TIP_ANX_STS = value; }
        }
        public int? TIP_ANX_USR_INC_ID
        {
            get { return _TIP_ANX_USR_INC_ID; }
            set { _TIP_ANX_USR_INC_ID = value; }
        }
        public int? TIP_ANX_USR_ALT_ID
        {
            get { return _TIP_ANX_USR_ALT_ID; }
            set { _TIP_ANX_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO TIP_ANX ";
            sSQL = sSQL + " (TIP_ANX_DES, TIP_ANX_STS, TIP_ANX_USR_INC_ID, TIP_ANX_TMS_ATL)";
            sSQL = sSQL + " VALUES ('" + TIP_ANX_DES.Replace("'", "''") + "'";
            sSQL = sSQL + " ," + TIP_ANX_STS;
            if (!String.IsNullOrEmpty(TIP_ANX_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + TIP_ANX_USR_INC_ID;
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
            string sSQL = "UPDATE TIP_ANX ";
            sSQL = sSQL + " SET TIP_ANX_DES = '" + TIP_ANX_DES.Replace("'", "''") + "' ";
            sSQL = sSQL + ", TIP_ANX_STS = " + TIP_ANX_STS;
            if (!String.IsNullOrEmpty(TIP_ANX_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", TIP_ANX_USR_ALT_ID = " + TIP_ANX_USR_ALT_ID;
            }
            sSQL = sSQL + ", TIP_ANX_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE TIP_ANX_ID = " + TIP_ANX_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM TIP_ANX ";
            sSQL = sSQL + " WHERE TIP_ANX_ID = " + TIP_ANX_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT TIP_ANX_ID, TIP_ANX_DES, TIP_ANX_STS ";

            sSQL = sSQL + " FROM TIP_ANX ";
            if (!String.IsNullOrEmpty(Convert.ToString(TIP_ANX_ID)))
            {
                sCond = sCond + " TIP_ANX_ID = " + TIP_ANX_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(TIP_ANX_DES))
            {
                sCond = sCond + " TIP_ANX_DES like '%" + TIP_ANX_DES.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(TIP_ANX_STS)))
            {
                sCond = sCond + " TIP_ANX_STS = " + TIP_ANX_STS + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY TIP_ANX_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
