using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class DistribuicaoVirada
    {

        #region Propriedades

        private int? _DST_VRD_ID;
        private int? _DST_VRD_OPD_ID;
        private int? _DST_VRD_LNC_MAQ_ID;
        private DateTime? _DST_VRD_DAT;
        private string _DST_VRD_TUR;
        private int? _DST_VRD_STS;
        private int? _DST_VRD_USR_INC_ID;
        private int? _DST_VRD_USR_ALT_ID;
        private DateTime? _DST_VRD_TMS_ATL;

        private DateTime? _DST_VRD_DAT_INI;
        private DateTime? _DST_VRD_DAT_FIM;

        private int? _LNC_MAQ_MAQ_ID;
        private int? _LNC_MAQ_STS;
        private int? _MAQ_STS;

        private string _OPD_TUR;

        private string _TOP;
        private string _SQL;

        public int? DST_VRD_ID
        {
            get { return _DST_VRD_ID; }
            set { _DST_VRD_ID = value; }
        }
        public int? DST_VRD_OPD_ID
        {
            get { return _DST_VRD_OPD_ID; }
            set { _DST_VRD_OPD_ID = value; }
        }
        public int? DST_VRD_LNC_MAQ_ID
        {
            get { return _DST_VRD_LNC_MAQ_ID; }
            set { _DST_VRD_LNC_MAQ_ID = value; }
        }
        public DateTime? DST_VRD_DAT
        {
            get { return _DST_VRD_DAT; }
            set { _DST_VRD_DAT = value; }
        }
        public string DST_VRD_TUR
        {
            get { return _DST_VRD_TUR; }
            set { _DST_VRD_TUR = value.ToUpper(); }
        }
        public int? DST_VRD_STS
        {
            get { return _DST_VRD_STS; }
            set { _DST_VRD_STS = value; }
        }
        public int? DST_VRD_USR_INC_ID
        {
            get { return _DST_VRD_USR_INC_ID; }
            set { _DST_VRD_USR_INC_ID = value; }
        }
        public int? DST_VRD_USR_ALT_ID
        {
            get { return _DST_VRD_USR_ALT_ID; }
            set { _DST_VRD_USR_ALT_ID = value; }
        }
        public DateTime? DST_VRD_TMS_ATL
        {
            get { return _DST_VRD_TMS_ATL; }
            set { _DST_VRD_TMS_ATL = value; }
        }

        public DateTime? DST_VRD_DAT_INI
        {
            get { return _DST_VRD_DAT_INI; }
            set { _DST_VRD_DAT_INI = value; }
        }
        public DateTime? DST_VRD_DAT_FIM
        {
            get { return _DST_VRD_DAT_FIM; }
            set { _DST_VRD_DAT_FIM = value; }
        }

        public string OPD_TUR
        {
            get { return _OPD_TUR; }
            set { _OPD_TUR = value.ToUpper(); }
        }

        public int? LNC_MAQ_MAQ_ID
        {
            get { return _LNC_MAQ_MAQ_ID; }
            set { _LNC_MAQ_MAQ_ID = value; }
        }
        public int? LNC_MAQ_STS
        {
            get { return _LNC_MAQ_STS; }
            set { _LNC_MAQ_STS = value; }
        }

        public int? MAQ_STS
        {
            get { return _MAQ_STS; }
            set { _MAQ_STS = value; }
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
            string sSQL = "INSERT INTO DST_VRD (";
            sSQL = sSQL + "DST_VRD_OPD_ID, ";
            sSQL = sSQL + "DST_VRD_LNC_MAQ_ID, ";
            sSQL = sSQL + "DST_VRD_DAT, ";
            sSQL = sSQL + "DST_VRD_TUR, ";
            sSQL = sSQL + "DST_VRD_STS, ";
            sSQL = sSQL + "DST_VRD_USR_INC_ID, ";
            sSQL = sSQL + "DST_VRD_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(DST_VRD_OPD_ID.ToString()))
            {
                sSQL = sSQL + DST_VRD_OPD_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_LNC_MAQ_ID.ToString()))
            {
                sSQL = sSQL + DST_VRD_LNC_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + DST_VRD_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_TUR))
            {
                sSQL = sSQL + "'" + DST_VRD_TUR + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_STS.ToString()))
            {
                sSQL = sSQL + DST_VRD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + DST_VRD_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE DST_VRD ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(DST_VRD_OPD_ID.ToString()))
            {
                sSQL = sSQL + "DST_VRD_OPD_ID = " + DST_VRD_OPD_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_OPD_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_LNC_MAQ_ID.ToString()))
            {
                sSQL = sSQL + "DST_VRD_LNC_MAQ_ID = " + DST_VRD_LNC_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_LNC_MAQ_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_DAT.ToString()))
            {
                sSQL = sSQL + "DST_VRD_DAT = Convert(datetime, '" + DST_VRD_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_TUR))
            {
                sSQL = sSQL + "DST_VRD_TUR = '" + DST_VRD_TUR + "', ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_TUR = NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_STS.ToString()))
            {
                sSQL = sSQL + "DST_VRD_STS = " + DST_VRD_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "DST_VRD_USR_ALT_ID = " + DST_VRD_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "DST_VRD_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "DST_VRD_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE DST_VRD_ID = " + DST_VRD_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sCond = "";
            string sSQL = "DELETE FROM DST_VRD ";

            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_ID)))
            {
                sCond = sCond + " DST_VRD_ID = " + DST_VRD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT)))
            {
                sCond = sCond + " DST_VRD_DAT BETWEEN Convert(datetime, '" + DST_VRD_DAT + "',103) AND Convert(datetime, '" + DST_VRD_DAT + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_INI)))
            {
                sCond = sCond + " DST_VRD_DAT >= Convert(datetime, '" + DST_VRD_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_FIM)))
            {
                sCond = sCond + " DST_VRD_DAT <= Convert(datetime, '" + DST_VRD_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(DST_VRD_TUR))
            {
                sCond = sCond + " DST_VRD_TUR = '" + DST_VRD_TUR + "' AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
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
            sSQL = sSQL + " FROM DST_VRD";
            sSQL = sSQL + " INNER JOIN OPD ON OPD_ID = DST_VRD_OPD_ID";
            sSQL = sSQL + " INNER JOIN LNC_MAQ ON LNC_MAQ_ID = DST_VRD_LNC_MAQ_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_ID)))
            {
                sCond = sCond + " DST_VRD_ID = " + DST_VRD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_OPD_ID)))
            {
                sCond = sCond + " DST_VRD_OPD_ID = " + DST_VRD_OPD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_LNC_MAQ_ID)))
            {
                sCond = sCond + " DST_VRD_LNC_MAQ_ID = " + DST_VRD_LNC_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_STS)))
            {
                sCond = sCond + " DST_VRD_STS = " + DST_VRD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DST_VRD_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet RelatorioViradaTempo()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT MAQ_DES, DST_VRD_DAT, LNC_MAQ_COR ";
            sSQL = sSQL + " FROM DST_VRD";
            sSQL = sSQL + " INNER JOIN LNC_MAQ ON LNC_MAQ_ID = DST_VRD_LNC_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT)))
            {
                sCond = sCond + " DST_VRD_DAT BETWEEN Convert(datetime, '" + DST_VRD_DAT + "',103) AND Convert(datetime, '" + DST_VRD_DAT + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_INI)))
            {
                sCond = sCond + " DST_VRD_DAT >= Convert(datetime, '" + DST_VRD_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_FIM)))
            {
                sCond = sCond + " DST_VRD_DAT <= Convert(datetime, '" + DST_VRD_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_STS)))
            {
                sCond = sCond + " DST_VRD_STS = " + DST_VRD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY DST_VRD_DAT, MAQ_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet RelatorioViradaMaquina()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT MAQ_TIP_DES, MAQ_DES, DST_VRD_DAT, LNC_MAQ_VRD, LNC_MAQ_DAT, LNC_MAQ_LOT, LNC_MAQ_PRD, LNC_MAQ_TUB ";
            sSQL = sSQL + " FROM DST_VRD";
            sSQL = sSQL + " INNER JOIN OPD ON OPD_ID = DST_VRD_OPD_ID";
            sSQL = sSQL + " INNER JOIN LNC_MAQ ON LNC_MAQ_ID = DST_VRD_LNC_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = MAQ_MAQ_TIP_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_ID)))
            {
                sCond = sCond + " DST_VRD_ID = " + DST_VRD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_OPD_ID)))
            {
                sCond = sCond + " DST_VRD_OPD_ID = " + DST_VRD_OPD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_LNC_MAQ_ID)))
            {
                sCond = sCond + " DST_VRD_LNC_MAQ_ID = " + DST_VRD_LNC_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT)))
            {
                sCond = sCond + " DST_VRD_DAT BETWEEN Convert(datetime, '" + DST_VRD_DAT + "',103) AND Convert(datetime, '" + DST_VRD_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_INI)))
            {
                sCond = sCond + " DST_VRD_DAT >= Convert(datetime, '" + DST_VRD_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_FIM)))
            {
                sCond = sCond + " DST_VRD_DAT <= Convert(datetime, '" + DST_VRD_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_STS)))
            {
                sCond = sCond + " DST_VRD_STS = " + DST_VRD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_TIP_DES, MAQ_DES, LNC_MAQ_VRD";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet DistribuicaoMaquina()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT DISTINCT MAQ_ID, MAQ_DES, MAQ_STS ";
            sSQL = sSQL + " FROM DST_VRD";
            sSQL = sSQL + " INNER JOIN LNC_MAQ ON LNC_MAQ_ID = DST_VRD_LNC_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_ID)))
            {
                sCond = sCond + " DST_VRD_ID = " + DST_VRD_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT)))
            {
                sCond = sCond + " DST_VRD_DAT BETWEEN Convert(datetime, '" + DST_VRD_DAT + "',103) AND Convert(datetime, '" + DST_VRD_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_INI)))
            {
                sCond = sCond + " DST_VRD_DAT >= Convert(datetime, '" + DST_VRD_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_FIM)))
            {
                sCond = sCond + " DST_VRD_DAT <= Convert(datetime, '" + DST_VRD_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_STS)))
            {
                sCond = sCond + " DST_VRD_STS = " + DST_VRD_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet RelatorioDistribuicaoVirada()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT OPD_NOM, OPD_TUM, OPD_PUO, MAQ_DES, DST_VRD_DAT, LNC_MAQ_COR ";
            sSQL = sSQL + " FROM DST_VRD";
            sSQL = sSQL + " INNER JOIN OPD ON OPD_ID = DST_VRD_OPD_ID";
            sSQL = sSQL + " INNER JOIN LNC_MAQ ON LNC_MAQ_ID = DST_VRD_LNC_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT)))
            {
                sCond = sCond + " DST_VRD_DAT BETWEEN Convert(datetime, '" + DST_VRD_DAT + "',103) AND Convert(datetime, '" + DST_VRD_DAT + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_INI)))
            {
                sCond = sCond + " DST_VRD_DAT >= Convert(datetime, '" + DST_VRD_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_DAT_FIM)))
            {
                sCond = sCond + " DST_VRD_DAT <= Convert(datetime, '" + DST_VRD_DAT_FIM + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_STS)))
            {
                sCond = sCond + " DST_VRD_STS = " + DST_VRD_STS + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(DST_VRD_TUR)))
            {
                sCond = sCond + " DST_VRD_TUR = '" + DST_VRD_TUR.Replace("'", "''") + "' AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY OPD_NOM, DST_VRD_DAT, MAQ_DES";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}
