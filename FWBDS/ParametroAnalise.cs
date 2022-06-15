using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class ParametroAnalise
    {

        #region Propriedades

        private int? _PRM_ANS_ID;
        private double? _PRM_ANS_TIT_XXX;
        private double? _PRM_ANS_TNC_XXX;
        private double? _PRM_ANS_AON_XXX;
        private double? _PRM_ANS_ENM_XXX;
        private double? _PRM_ANS_EEE_XXX;
        private double? _PRM_ANS_KKK_XXX;
        private double? _PRM_ANS_BBB_XXX;
        private double? _PRM_ANS_PUE_XXX;
        private double? _PRM_ANS_OLE_XXX;
        private double? _PRM_ANS_TRQ_XXX;
        private double? _PRM_ANS_ERT_XXX;
        private double? _PRM_ANS_RT3_XXX;
        private double? _PRM_ANS_RT5_XXX;
        private double? _PRM_ANS_PES_XXX;
        private double? _PRM_ANS_DMO_XXX;
        private double? _PRM_ANS_DND_XXX;
        private double? _PRM_ANS_TIT_YYY;
        private double? _PRM_ANS_TNC_YYY;
        private double? _PRM_ANS_AON_YYY;
        private double? _PRM_ANS_ENM_YYY;
        private double? _PRM_ANS_EEE_YYY;
        private double? _PRM_ANS_KKK_YYY;
        private double? _PRM_ANS_BBB_YYY;
        private double? _PRM_ANS_PUE_YYY;
        private double? _PRM_ANS_OLE_YYY;
        private double? _PRM_ANS_TRQ_YYY;
        private double? _PRM_ANS_ERT_YYY;
        private double? _PRM_ANS_RT3_YYY;
        private double? _PRM_ANS_RT5_YYY;
        private double? _PRM_ANS_PES_YYY;
        private double? _PRM_ANS_DMO_YYY;
        private double? _PRM_ANS_DND_YYY;
        private int? _PRM_ANS_STS;
        private int? _PRM_ANS_USR_INC_ID;
        private int? _PRM_ANS_USR_ALT_ID;
        private DateTime? _PRM_ANS_TMS_ATL;


        private string _TOP;
        private string _SQL;

        public int? PRM_ANS_ID
        {
            get { return _PRM_ANS_ID; }
            set { _PRM_ANS_ID = value; }
        }
        public double? PRM_ANS_TIT_XXX
        {
            get { return _PRM_ANS_TIT_XXX; }
            set { _PRM_ANS_TIT_XXX = value; }
        }
        public double? PRM_ANS_TNC_XXX
        {
            get { return _PRM_ANS_TNC_XXX; }
            set { _PRM_ANS_TNC_XXX = value; }
        }
        public double? PRM_ANS_AON_XXX
        {
            get { return _PRM_ANS_AON_XXX; }
            set { _PRM_ANS_AON_XXX = value; }
        }
        public double? PRM_ANS_ENM_XXX
        {
            get { return _PRM_ANS_ENM_XXX; }
            set { _PRM_ANS_ENM_XXX = value; }
        }
        public double? PRM_ANS_EEE_XXX
        {
            get { return _PRM_ANS_EEE_XXX; }
            set { _PRM_ANS_EEE_XXX = value; }
        }
        public double? PRM_ANS_KKK_XXX
        {
            get { return _PRM_ANS_KKK_XXX; }
            set { _PRM_ANS_KKK_XXX = value; }
        }
        public double? PRM_ANS_BBB_XXX
        {
            get { return _PRM_ANS_BBB_XXX; }
            set { _PRM_ANS_BBB_XXX = value; }
        }
        public double? PRM_ANS_PUE_XXX
        {
            get { return _PRM_ANS_PUE_XXX; }
            set { _PRM_ANS_PUE_XXX = value; }
        }
        public double? PRM_ANS_OLE_XXX
        {
            get { return _PRM_ANS_OLE_XXX; }
            set { _PRM_ANS_OLE_XXX = value; }
        }
        public double? PRM_ANS_TRQ_XXX
        {
            get { return _PRM_ANS_TRQ_XXX; }
            set { _PRM_ANS_TRQ_XXX = value; }
        }
        public double? PRM_ANS_ERT_XXX
        {
            get { return _PRM_ANS_ERT_XXX; }
            set { _PRM_ANS_ERT_XXX = value; }
        }
        public double? PRM_ANS_RT3_XXX
        {
            get { return _PRM_ANS_RT3_XXX; }
            set { _PRM_ANS_RT3_XXX = value; }
        }
        public double? PRM_ANS_RT5_XXX
        {
            get { return _PRM_ANS_RT5_XXX; }
            set { _PRM_ANS_RT5_XXX = value; }
        }
        public double? PRM_ANS_PES_XXX
        {
            get { return _PRM_ANS_PES_XXX; }
            set { _PRM_ANS_PES_XXX = value; }
        }
        public double? PRM_ANS_DMO_XXX
        {
            get { return _PRM_ANS_DMO_XXX; }
            set { _PRM_ANS_DMO_XXX = value; }
        }
        public double? PRM_ANS_DND_XXX
        {
            get { return _PRM_ANS_DND_XXX; }
            set { _PRM_ANS_DND_XXX = value; }
        }
        public double? PRM_ANS_TIT_YYY
        {
            get { return _PRM_ANS_TIT_YYY; }
            set { _PRM_ANS_TIT_YYY = value; }
        }
        public double? PRM_ANS_TNC_YYY
        {
            get { return _PRM_ANS_TNC_YYY; }
            set { _PRM_ANS_TNC_YYY = value; }
        }
        public double? PRM_ANS_AON_YYY
        {
            get { return _PRM_ANS_AON_YYY; }
            set { _PRM_ANS_AON_YYY = value; }
        }
        public double? PRM_ANS_ENM_YYY
        {
            get { return _PRM_ANS_ENM_YYY; }
            set { _PRM_ANS_ENM_YYY = value; }
        }
        public double? PRM_ANS_EEE_YYY
        {
            get { return _PRM_ANS_EEE_YYY; }
            set { _PRM_ANS_EEE_YYY = value; }
        }
        public double? PRM_ANS_KKK_YYY
        {
            get { return _PRM_ANS_KKK_YYY; }
            set { _PRM_ANS_KKK_YYY = value; }
        }
        public double? PRM_ANS_BBB_YYY
        {
            get { return _PRM_ANS_BBB_YYY; }
            set { _PRM_ANS_BBB_YYY = value; }
        }
        public double? PRM_ANS_PUE_YYY
        {
            get { return _PRM_ANS_PUE_YYY; }
            set { _PRM_ANS_PUE_YYY = value; }
        }
        public double? PRM_ANS_OLE_YYY
        {
            get { return _PRM_ANS_OLE_YYY; }
            set { _PRM_ANS_OLE_YYY = value; }
        }
        public double? PRM_ANS_TRQ_YYY
        {
            get { return _PRM_ANS_TRQ_YYY; }
            set { _PRM_ANS_TRQ_YYY = value; }
        }
        public double? PRM_ANS_ERT_YYY
        {
            get { return _PRM_ANS_ERT_YYY; }
            set { _PRM_ANS_ERT_YYY = value; }
        }
        public double? PRM_ANS_RT3_YYY
        {
            get { return _PRM_ANS_RT3_YYY; }
            set { _PRM_ANS_RT3_YYY = value; }
        }
        public double? PRM_ANS_RT5_YYY
        {
            get { return _PRM_ANS_RT5_YYY; }
            set { _PRM_ANS_RT5_YYY = value; }
        }
        public double? PRM_ANS_PES_YYY
        {
            get { return _PRM_ANS_PES_YYY; }
            set { _PRM_ANS_PES_YYY = value; }
        }
        public double? PRM_ANS_DMO_YYY
        {
            get { return _PRM_ANS_DMO_YYY; }
            set { _PRM_ANS_DMO_YYY = value; }
        }
        public double? PRM_ANS_DND_YYY
        {
            get { return _PRM_ANS_DND_YYY; }
            set { _PRM_ANS_DND_YYY = value; }
        }
        public int? PRM_ANS_STS
        {
            get { return _PRM_ANS_STS; }
            set { _PRM_ANS_STS = value; }
        }
        public int? PRM_ANS_USR_INC_ID
        {
            get { return _PRM_ANS_USR_INC_ID; }
            set { _PRM_ANS_USR_INC_ID = value; }
        }
        public int? PRM_ANS_USR_ALT_ID
        {
            get { return _PRM_ANS_USR_ALT_ID; }
            set { _PRM_ANS_USR_ALT_ID = value; }
        }
        public DateTime? PRM_ANS_TMS_ATL
        {
            get { return _PRM_ANS_TMS_ATL; }
            set { _PRM_ANS_TMS_ATL = value; }
        }


        public string TOP
        {
            get { return _TOP; }
            set { _TOP = value; }
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
            string sSQL = "INSERT INTO PRM_ANS (";
            sSQL = sSQL + "PRM_ANS_TIT_XXX, ";
            sSQL = sSQL + "PRM_ANS_TNC_XXX, ";
            sSQL = sSQL + "PRM_ANS_AON_XXX, ";
            sSQL = sSQL + "PRM_ANS_ENM_XXX, ";
            sSQL = sSQL + "PRM_ANS_EEE_XXX, ";
            sSQL = sSQL + "PRM_ANS_KKK_XXX, ";
            sSQL = sSQL + "PRM_ANS_BBB_XXX, ";
            sSQL = sSQL + "PRM_ANS_PUE_XXX, ";
            sSQL = sSQL + "PRM_ANS_OLE_XXX, ";
            sSQL = sSQL + "PRM_ANS_TRQ_XXX, ";
            sSQL = sSQL + "PRM_ANS_ERT_XXX, ";
            sSQL = sSQL + "PRM_ANS_RT3_XXX, ";
            sSQL = sSQL + "PRM_ANS_RT5_XXX, ";
            sSQL = sSQL + "PRM_ANS_PES_XXX, ";
            sSQL = sSQL + "PRM_ANS_DMO_XXX, ";
            sSQL = sSQL + "PRM_ANS_DND_XXX, ";
            sSQL = sSQL + "PRM_ANS_TIT_YYY, ";
            sSQL = sSQL + "PRM_ANS_TNC_YYY, ";
            sSQL = sSQL + "PRM_ANS_AON_YYY, ";
            sSQL = sSQL + "PRM_ANS_ENM_YYY, ";
            sSQL = sSQL + "PRM_ANS_EEE_YYY, ";
            sSQL = sSQL + "PRM_ANS_KKK_YYY, ";
            sSQL = sSQL + "PRM_ANS_BBB_YYY, ";
            sSQL = sSQL + "PRM_ANS_PUE_YYY, ";
            sSQL = sSQL + "PRM_ANS_OLE_YYY, ";
            sSQL = sSQL + "PRM_ANS_TRQ_YYY, ";
            sSQL = sSQL + "PRM_ANS_ERT_YYY, ";
            sSQL = sSQL + "PRM_ANS_RT3_YYY, ";
            sSQL = sSQL + "PRM_ANS_RT5_YYY, ";
            sSQL = sSQL + "PRM_ANS_PES_YYY, ";
            sSQL = sSQL + "PRM_ANS_DMO_YYY, ";
            sSQL = sSQL + "PRM_ANS_DND_YYY, ";
            sSQL = sSQL + "PRM_ANS_STS, ";
            sSQL = sSQL + "PRM_ANS_USR_INC_ID, ";
            sSQL = sSQL + "PRM_ANS_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(PRM_ANS_TIT_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TIT_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TNC_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TNC_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_AON_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_AON_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ENM_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_ENM_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_EEE_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_EEE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_KKK_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_KKK_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_BBB_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_BBB_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PUE_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_PUE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_OLE_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_OLE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TRQ_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TRQ_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ERT_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_ERT_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT3_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_RT3_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT5_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_RT5_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PES_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_PES_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DMO_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_DMO_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DND_XXX.ToString()))
            {
                sSQL = sSQL + PRM_ANS_DND_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TIT_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TIT_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TNC_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TNC_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_AON_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_AON_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ENM_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_ENM_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_EEE_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_EEE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_KKK_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_KKK_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_BBB_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_BBB_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PUE_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_PUE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_OLE_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_OLE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TRQ_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_TRQ_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ERT_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_ERT_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT3_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_RT3_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT5_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_RT5_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PES_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_PES_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DMO_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_DMO_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DND_YYY.ToString()))
            {
                sSQL = sSQL + PRM_ANS_DND_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_STS.ToString()))
            {
                sSQL = sSQL + PRM_ANS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + PRM_ANS_USR_INC_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            sSQL = sSQL + "GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + ") ";

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Alterar()
        {
            string sSQL = "UPDATE PRM_ANS ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(PRM_ANS_TIT_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TIT_XXX = " + PRM_ANS_TIT_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TIT_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TNC_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TNC_XXX = " + PRM_ANS_TNC_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TNC_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_AON_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_AON_XXX = " + PRM_ANS_AON_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_AON_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ENM_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_ENM_XXX = " + PRM_ANS_ENM_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_ENM_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_EEE_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_EEE_XXX = " + PRM_ANS_EEE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_EEE_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_KKK_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_KKK_XXX = " + PRM_ANS_KKK_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_KKK_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_BBB_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_BBB_XXX = " + PRM_ANS_BBB_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_BBB_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PUE_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_PUE_XXX = " + PRM_ANS_PUE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_PUE_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_OLE_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_OLE_XXX = " + PRM_ANS_OLE_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_OLE_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TRQ_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TRQ_XXX = " + PRM_ANS_TRQ_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TRQ_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ERT_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_ERT_XXX = " + PRM_ANS_ERT_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_ERT_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT3_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_RT3_XXX = " + PRM_ANS_RT3_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_RT3_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT5_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_RT5_XXX = " + PRM_ANS_RT5_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_RT5_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PES_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_PES_XXX = " + PRM_ANS_PES_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_PES_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DMO_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_DMO_XXX = " + PRM_ANS_DMO_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_DMO_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DND_XXX.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_DND_XXX = " + PRM_ANS_DND_XXX.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_DND_XXX = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TIT_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TIT_YYY = " + PRM_ANS_TIT_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TIT_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TNC_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TNC_YYY = " + PRM_ANS_TNC_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TNC_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_AON_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_AON_YYY = " + PRM_ANS_AON_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_AON_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ENM_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_ENM_YYY = " + PRM_ANS_ENM_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_ENM_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_EEE_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_EEE_YYY = " + PRM_ANS_EEE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_EEE_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_KKK_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_KKK_YYY = " + PRM_ANS_KKK_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_KKK_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_BBB_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_BBB_YYY = " + PRM_ANS_BBB_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_BBB_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PUE_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_PUE_YYY = " + PRM_ANS_PUE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_PUE_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_OLE_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_OLE_YYY = " + PRM_ANS_OLE_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_OLE_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_TRQ_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_TRQ_YYY = " + PRM_ANS_TRQ_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_TRQ_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_ERT_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_ERT_YYY = " + PRM_ANS_ERT_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_ERT_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT3_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_RT3_YYY = " + PRM_ANS_RT3_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_RT3_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_RT5_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_RT5_YYY = " + PRM_ANS_RT5_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_RT5_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_PES_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_PES_YYY = " + PRM_ANS_PES_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_PES_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DMO_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_DMO_YYY = " + PRM_ANS_DMO_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_DMO_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_DND_YYY.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_DND_YYY = " + PRM_ANS_DND_YYY.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_DND_YYY = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_STS.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_STS = " + PRM_ANS_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(PRM_ANS_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "PRM_ANS_USR_ALT_ID = " + PRM_ANS_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "PRM_ANS_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "PRM_ANS_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE PRM_ANS_ID = " + PRM_ANS_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PRM_ANS";
            sSQL = sSQL + " WHERE PRM_ANS_ID = " + PRM_ANS_ID;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT * ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " * ";
            }
            sSQL = sSQL + " FROM PRM_ANS";
            if (!String.IsNullOrEmpty(Convert.ToString(PRM_ANS_ID)))
            {
                sCond = sCond + " PRM_ANS_ID = " + PRM_ANS_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PRM_ANS_STS)))
            {
                sCond = sCond + " PRM_ANS_STS = " + PRM_ANS_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY PRM_ANS_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}