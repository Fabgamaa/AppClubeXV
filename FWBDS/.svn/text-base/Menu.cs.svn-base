using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Menu
    {
        #region Propriedades

        private int? _MNU_ID;
        private string _MNU_COD_APL;
        private string _MNU_TIT;
        private string _MNU_ORD;
        private string _MNU_URL;
        private string _MNU_IMG;
        private string _MNU_ALU;
        private string _MNU_LAR;
        private string _MNU_NVL;
        private int? _MNU_REG_ID;
        private int? _MNU_USR_INC_ID;
        private int? _MNU_USR_ALT_ID;
        private int? _PFL_ID;

        public int? MNU_ID
        {
            get { return _MNU_ID; }
            set { _MNU_ID = value; }
        }
        public string MNU_COD_APL
        {
            get { return _MNU_COD_APL; }
            set { _MNU_COD_APL = value; }
        }
        public string MNU_TIT
        {
            get { return _MNU_TIT; }
            set { _MNU_TIT = value; }
        }
        public string MNU_ORD
        {
            get { return _MNU_ORD; }
            set { _MNU_ORD = value; }
        }
        public string MNU_URL
        {
            get { return _MNU_URL; }
            set { _MNU_URL = value; }
        }
        public string MNU_IMG
        {
            get { return _MNU_IMG; }
            set { _MNU_IMG = value; }
        }
        public string MNU_ALU
        {
            get { return _MNU_ALU; }
            set { _MNU_ALU = value; }
        }
        public string MNU_LAR
        {
            get { return _MNU_LAR; }
            set { _MNU_LAR = value; }
        }
        public string MNU_NVL
        {
            get { return _MNU_NVL; }
            set { _MNU_NVL = value; }
        }
        public int? MNU_REG_ID
        {
            get { return _MNU_REG_ID; }
            set { _MNU_REG_ID = value; }
        }
        public int? MNU_USR_INC_ID
        {
            get { return _MNU_USR_INC_ID; }
            set { _MNU_USR_INC_ID = value; }
        }
        public int? MNU_USR_ALT_ID
        {
            get { return _MNU_USR_ALT_ID; }
            set { _MNU_USR_ALT_ID = value; }
        }
        public int? PFL_ID
        {
            get { return _PFL_ID; }
            set { _PFL_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO MNU ";
            sSQL = sSQL + " (MNU_COD_APL, MNU_TIT, MNU_ORD, MNU_URL, MNU_IMG, MNU_ALU, MNU_LAR, MNU_NVL, ";
            sSQL = sSQL + " MNU_REG_ID, MNU_USR_INC_ID, MNU_TMS_ATL)";
            sSQL = sSQL + " VALUES ('" + MNU_COD_APL.Replace("'","''") + "','" + MNU_TIT.Replace("'", "''") + "'";
            sSQL = sSQL + ",'" + MNU_ORD.Replace("'", "''");
            if (!String.IsNullOrEmpty(MNU_URL))
            {
                sSQL = sSQL + ",'" + MNU_URL.Replace("'","''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            if (!String.IsNullOrEmpty(MNU_IMG))
            {
                sSQL = sSQL + ",'" + MNU_IMG.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",'" + MNU_ALU.Replace("'", "''") + "'";
            sSQL = sSQL + ",'" + MNU_LAR.Replace("'", "''") + "'";
            sSQL = sSQL + ",'" + MNU_NVL.Replace("'", "''") + "'";
            if (!String.IsNullOrEmpty(MNU_REG_ID.ToString()))
            {
                sSQL = sSQL + ",'" + MNU_REG_ID + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            if (!String.IsNullOrEmpty(MNU_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + MNU_USR_INC_ID;
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
            string sSQL = "UPDATE MNU ";
            sSQL = sSQL + " SET MNU_COD_APL = '" + MNU_COD_APL.Replace("'","''") + "'";
            if (!String.IsNullOrEmpty(MNU_TIT))
            {
                sSQL = sSQL + ", MNU_TIT = '" + MNU_TIT.Replace("'", "''") + "' ";
            }
            if (!String.IsNullOrEmpty(MNU_ORD))
            {
                sSQL = sSQL + ", MNU_ORD = '" + MNU_ORD.Replace("'", "''") + "' ";
            }
            if (!String.IsNullOrEmpty(MNU_URL))
            {
                sSQL = sSQL + ", MNU_URL = '" + MNU_URL.Replace("'", "''") + "' ";
            }
            else
            {
                sSQL = sSQL + ", MNU_URL = NULL ";
            }
            if (!String.IsNullOrEmpty(MNU_IMG))
            {
                sSQL = sSQL + ", MNU_IMG = '" + MNU_IMG.Replace("'", "''") + "' ";
            }
            else
            {
                sSQL = sSQL + ", MNU_IMG = NULL ";
            }
            if (!String.IsNullOrEmpty(MNU_ALU))
            {
                sSQL = sSQL + ", MNU_ALU = '" + MNU_ALU.Replace("'", "''") + "' ";
            }
            if (!String.IsNullOrEmpty(MNU_LAR))
            {
                sSQL = sSQL + ", MNU_LAR = '" + MNU_LAR.Replace("'", "''") + "' ";
            }
            if (!String.IsNullOrEmpty(MNU_NVL))
            {
                sSQL = sSQL + ", MNU_NVL = '" + MNU_NVL.Replace("'", "''") + "' ";
            }
            if (!String.IsNullOrEmpty(MNU_REG_ID.ToString()))
            {
                sSQL = sSQL + ", MNU_REG_ID = " + MNU_REG_ID;
            }
            else
            {
                sSQL = sSQL + ", MNU_REG_ID = NULL ";
            }
            if (!String.IsNullOrEmpty(MNU_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", MNU_USR_ALT_ID = " + MNU_USR_ALT_ID;
            }
            sSQL = sSQL + ", MNU_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE MNU_ID = " + MNU_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM MNU ";
            sSQL = sSQL + " WHERE MNU_ID = " + MNU_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT MNU_ID, MNU_COD_APL, MNU_TIT, MNU_ORD, MNU_URL, MNU_IMG, MNU_ALU, MNU_LAR, ";
            sSQL = sSQL + " MNU_NVL, MNU_REG_ID ";

            sSQL = sSQL + " FROM MNU ";
            if (!String.IsNullOrEmpty(MNU_TIT))
            {
                sCond = sCond + " MNU_TIT like '%" + MNU_TIT.Replace("'", "''") + "%' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MNU_ID)))
            {
                sCond = sCond + " MNU_ID = " + MNU_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(MNU_REG_ID)))
            {
                sCond = sCond + " MNU_REG_ID = " + MNU_REG_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MNU_TIT ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public DataSet CarregarMenus()
        {
            string sCond = "";
            string sSQL = "SELECT MNU_ID, MNU_TIT, MNU_URL, MNU_NVL, MNU_REG_ID, MNU_ORD ";

            sSQL = sSQL + " FROM MNU, PFL_MNU ";
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_ID)))
            {
                sCond = sCond + " PFL_MNU_PFL_ID = " + PFL_ID + " AND ";
            }
            sCond = sCond + " PFL_MNU_MNU_ID = MNU_ID AND ";
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MNU_ORD ";
            return dbConn.ExecutarRetorno(sSQL);

        }
        #endregion

    }
}
