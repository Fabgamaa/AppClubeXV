using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Defeito
    {
        #region Propriendades
        
        private int? _DEF_ID;
        private int? _DEF_POS;
        private string _DEF_DES;
        private int? _DEF_AFN_ID;
        private int? _DEF_TIP;
        private int? _DEF_STS;
        private string _SQL;

        private string _TOP;

        public int? DEF_ID
        {
            get { return _DEF_ID; }
            set { _DEF_ID = value; }
        }
        public int? DEF_POS
        {
            get { return _DEF_POS; }
            set { _DEF_POS = value; }
        }
        public string DEF_DES
        {
            get { return _DEF_DES; }
            set { _DEF_DES = value; }
        }
        public int? DEF_AFN_ID
        {
            get { return _DEF_AFN_ID; }
            set { _DEF_AFN_ID = value; }
        }

        public string TOP
        {
            get { return _TOP; }
            set { _TOP = value; }
        }
        public int? DEF_TIP
        {
            get { return _DEF_TIP; }
            set { _DEF_TIP = value; }
        }
        public int? DEF_STS
        {
            get { return _DEF_STS; }
            set { _DEF_STS = value; }
        }
        public string SQL
        {
            get { return _SQL; }
            set { _SQL = value; }
        }

        #endregion


        #region Métodos

        clsBanco dbConn = new clsBanco();


        public string Inserir()
        {
            string sSQL = "INSERT INTO Def ";
            sSQL = sSQL + " (DEF_POS,DEF_DES,DEF_AFN_ID,DEF_TIP,DEF_STS)";
            sSQL = sSQL + " VALUES (";

            if (!String.IsNullOrEmpty(DEF_POS.ToString()))
            {
                sSQL = sSQL + _DEF_POS;
            }
            else
            {
                sSQL = sSQL + ", NULL ";
            }

            if (!String.IsNullOrEmpty(DEF_DES.ToString()))
            {
                sSQL = sSQL + ",'" + DEF_DES + "', ";
            }
            else
            {
                sSQL = sSQL + ", NULL ";
            }
            if (!String.IsNullOrEmpty(DEF_AFN_ID.ToString()))
            {
                sSQL = sSQL + DEF_AFN_ID;
            }
            else
            {
                sSQL = sSQL + ", NULL ";
            }
            if (!String.IsNullOrEmpty(DEF_TIP.ToString()))
            {
                sSQL = sSQL + "," + DEF_TIP;
            }
            else
            {
                sSQL = sSQL + ", NULL ";
            }
            sSQL = sSQL + ", 1 ";
            sSQL = sSQL + ")";
            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM DEF";
            sSQL = sSQL + " WHERE DEF_AFN_ID = " + DEF_AFN_ID;

            SQL = sSQL;
            return dbConn.Executar(sSQL);

        }
 


        public string Alterar()
        {
            string sCond = "";
            string sSQL = "UPDATE DEF ";
            sSQL = sSQL + " SET ";
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_ID)))
            {
                sCond = sCond + " DEF_ID = " + DEF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_POS)))
            {
                sCond = sCond + "DEF_POS = " + DEF_POS + " AND ";
            }

            //if (!String.IsNullOrEmpty(DEF_DES.ToString()))
            //{
            //    sSQL = sSQL + ",'" + DEF_DES + "', ";
            //}
            //else
            //{
            //    sSQL = sSQL + ", NULL ";
            //}

            //if (!String.IsNullOrEmpty(DEF_DES)) ;
            //{
            //    sCond = sCond + " DEF_DES like '%" + DEF_DES.Replace("'", "''") + "%', AND ";
            //}
            //if (!String.IsNullOrEmpty(Convert.ToString(DEF_AFN_ID)))
            //{
            //    sCond = sCond + " DEF_AFN_ID = " + DEF_AFN_ID + ", AND " ;
            //}
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_TIP)))
            {
                sCond = sCond + " DEF_TIP = " + DEF_TIP;
                if (DEF_TIP==1)
                {
                    DEF_STS = 0;
                }

            }

            //sSQL = sSQL + " DEF_ID = " + DEF_ID;
            sSQL = sSQL + " DEF_POS = " + DEF_POS;
            sSQL = sSQL + ", DEF_DES = '" + DEF_DES;
            sSQL = sSQL + "', DEF_TIP = " + DEF_TIP;
            sSQL = sSQL + ", DEF_STS = " + DEF_STS;
            sSQL = sSQL + " WHERE DEF_ID = " + DEF_ID;

            return dbConn.ExecutarInserir(sSQL);

        }

        //public string Excluir()
        //{
        //    string sSQL = "DELETE FROM ANX ";
        //    sSQL = sSQL + " WHERE ANX_ID = " + ANX_ID;

        //    return dbConn.Executar(sSQL);

        //}

        public DataSet Consultar()
        {
            string sCond = "";
            //string sSQL = "SELECT DEF_ID, DEF_POS, DEF_DES, DEF_AFN_ID FROM DEF";
            string sSQL = "SELECT * FROM DEF";
            sSQL = sSQL + " INNER JOIN AFN ON DEF_AFN_ID = AFN_ID";

            //if (!String.IsNullOrEmpty(DEF_DES)) ;
            //{
            //    sCond = sCond + " DEF_DES like '%" + DEF_DES.Replace("'", "''") + "%' AND ";
            //}
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_ID)))
            {
                sCond = sCond + "DEF_ID = " + DEF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_POS)))
            {
                sCond = sCond + "DEF_POS = " + DEF_POS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_AFN_ID)))
            {
                sCond = sCond + "DEF_AFN_ID = " + DEF_AFN_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DEF_TIP)))
            {
                sCond = sCond + "DEF_TIP = " + DEF_TIP + " AND ";
            }
            sCond = sCond + "DEF_STS = 1";

            if (sCond != "")
            {
                //sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DEF_DES ";

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarD()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT Distinct DEF_DES ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " * ";
            }
            sSQL = sSQL + " FROM DEF";
            //if (!String.IsNullOrEmpty(Convert.ToString(DEF_ID)))
            //{
            //    sCond = sCond + " DEF_ID = " + DEF_ID + " AND ";
            //}
            //if (!String.IsNullOrEmpty(Convert.ToString(DEF_POS)))
            //{
            //    sCond = sCond + "DEF_POS = " + DEF_POS + " AND ";
            //}
            //if (!String.IsNullOrEmpty(Convert.ToString(DEF_AFN_ID)))
            //{
            //    sCond = sCond + " DEF_AFN_ID = " + DEF_AFN_ID + " AND ";
            //}
            if (sCond != "" )
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            return dbConn.ExecutarRetorno(sSQL);
        }


        //public DataSet Consultar()
        //{
        //    string sCond = "";
        //    string sSQL = "SELECT ANX_ID, ANX_TAB_PAI, ANX_PAI_ID, ANX_TIP_ANX_ID, ANX_DES, ANX_CAM,";
        //    sSQL = sSQL + " ANX_USR_INC_ID, ANX_USR_ALT_ID, ANX_TMS_ATL, TIP_ANX_DES ";

        //    sSQL = sSQL + " FROM ANX ";
        //    sSQL = sSQL + " INNER JOIN TIP_ANX ON ANX_TIP_ANX_ID = TIP_ANX_ID";

        //    if (!String.IsNullOrEmpty(Convert.ToString(ANX_TAB_PAI)))
        //    {
        //        sCond = sCond + " ANX_TAB_PAI = '" + ANX_TAB_PAI + "' AND ";
        //    }
        //    if (!String.IsNullOrEmpty(Convert.ToString(ANX_PAI_ID)))
        //    {
        //        sCond = sCond + " ANX_PAI_ID = " + ANX_PAI_ID + " AND ";
        //    }
        //    if (!String.IsNullOrEmpty(Convert.ToString(ANX_ID)))
        //    {
        //        sCond = sCond + " ANX_ID = " + ANX_ID + " AND ";
        //    }
        //    if (!String.IsNullOrEmpty(ANX_DES))
        //    {
        //        sCond = sCond + " ANX_DES like '%" + ANX_DES.Replace("'", "''") + "%' AND ";
        //    }
        //    if (!String.IsNullOrEmpty(Convert.ToString(ANX_TIP_ANX_ID)))
        //    {
        //        sCond = sCond + " ANX_TIP_ANX_ID = " + ANX_TIP_ANX_ID + " AND ";
        //    }
        //    if (sCond != "")
        //    {
        //        sCond = sCond.Substring(1, sCond.Length - 5);
        //        sSQL = sSQL + " WHERE " + sCond;
        //    }
        //    sSQL = sSQL + " ORDER BY ANX_DES ";
        //    return dbConn.ExecutarRetorno(sSQL);

    }
        #endregion



 }

