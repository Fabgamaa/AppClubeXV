using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Anexo
    {
        #region Propriedades

        private int? _ANX_ID;
        private string _ANX_TAB_PAI;
        private int? _ANX_PAI_ID;
        private int? _ANX_TIP_ANX_ID;
        private string _ANX_DES;
        private string _ANX_CAM;
        private int? _ANX_USR_INC_ID;
        private int? _ANX_USR_ALT_ID;

        public int? ANX_ID
        {
            get { return _ANX_ID; }
            set { _ANX_ID = value; }
        }
        public string ANX_TAB_PAI
        {
            get { return _ANX_TAB_PAI; }
            set { _ANX_TAB_PAI = value.ToUpper(); }
        }
        public int? ANX_PAI_ID
        {
            get { return _ANX_PAI_ID; }
            set { _ANX_PAI_ID = value; }
        }
        public int? ANX_TIP_ANX_ID
        {
            get { return _ANX_TIP_ANX_ID; }
            set { _ANX_TIP_ANX_ID = value; }
        }
        public string ANX_DES
        {
            get { return _ANX_DES; }
            set { _ANX_DES = value.ToUpper(); }
        }
        public string ANX_CAM
        {
            get { return _ANX_CAM; }
            set { _ANX_CAM = value.ToUpper(); }
        }
        public int? ANX_USR_INC_ID
        {
            get { return _ANX_USR_INC_ID; }
            set { _ANX_USR_INC_ID = value; }
        }
        public int? ANX_USR_ALT_ID
        {
            get { return _ANX_USR_ALT_ID; }
            set { _ANX_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO ANX ";
            sSQL = sSQL + " (ANX_TAB_PAI, ANX_PAI_ID, ANX_TIP_ANX_ID, ANX_DES, ANX_CAM, ANX_USR_INC_ID, ANX_TMS_ATL)";
            sSQL = sSQL + " VALUES (";
            sSQL = sSQL + "'" + ANX_TAB_PAI.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(ANX_PAI_ID.ToString()))
            {
                sSQL = sSQL + ", " + ANX_PAI_ID;

            }
            else
            {
                sSQL = sSQL + ", NULL ";
            }
            sSQL = sSQL + ", " + ANX_TIP_ANX_ID;
            sSQL = sSQL + ", '" + ANX_DES.Replace("'", "''") + "'";
            sSQL = sSQL + ", '" + ANX_CAM + "'";
            if (!String.IsNullOrEmpty(ANX_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + ", " + ANX_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ", NULL";
            }
            sSQL = sSQL + ", GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE ANX ";
            sSQL = sSQL + " SET ANX_TMS_ATL = GetDate() ";
            if (!String.IsNullOrEmpty(ANX_TAB_PAI.ToString()))
            {
                sSQL = sSQL + ", ANX_TAB_PAI = '" + ANX_TAB_PAI.Replace("'", "''") + "' ";
            }
            else
            {
                sSQL = sSQL + ", ANX_TAB_PAI = NULL";
            }
            if (!String.IsNullOrEmpty(ANX_PAI_ID.ToString()))
            {
                sSQL = sSQL + ", ANX_PAI_ID = " + ANX_PAI_ID;
            }
            else
            {
                sSQL = sSQL + ", ANX_PAI_ID = NULL";
            }
            sSQL = sSQL + ", ANX_TIP_ANX_ID = " + ANX_TIP_ANX_ID;
            sSQL = sSQL + ", ANX_DES = '" + ANX_DES.Replace("'", "''") + "'";
            sSQL = sSQL + ", ANX_CAM = '" + ANX_CAM.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(ANX_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", ANX_USR_ALT_ID = " + ANX_USR_ALT_ID;
            }
            sSQL = sSQL + " WHERE ANX_ID = " + ANX_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ANX ";
            sSQL = sSQL + " WHERE ANX_ID = " + ANX_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT ANX_ID, ANX_TAB_PAI, ANX_PAI_ID, ANX_TIP_ANX_ID, ANX_DES, ANX_CAM,";
            sSQL = sSQL + " ANX_USR_INC_ID, ANX_USR_ALT_ID, ANX_TMS_ATL, TIP_ANX_DES ";

            sSQL = sSQL + " FROM ANX ";
            sSQL = sSQL + " INNER JOIN TIP_ANX ON ANX_TIP_ANX_ID = TIP_ANX_ID";

            if (!String.IsNullOrEmpty(Convert.ToString(ANX_TAB_PAI)))
            {
                sCond = sCond + " ANX_TAB_PAI = '" + ANX_TAB_PAI + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANX_PAI_ID)))
            {
                sCond = sCond + " ANX_PAI_ID = " + ANX_PAI_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANX_ID)))
            {
                sCond = sCond + " ANX_ID = " + ANX_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(ANX_DES))
            {
                sCond = sCond + " ANX_DES like '%" + ANX_DES.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(ANX_TIP_ANX_ID)))
            {
                sCond = sCond + " ANX_TIP_ANX_ID = " + ANX_TIP_ANX_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY ANX_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
