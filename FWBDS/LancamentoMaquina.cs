using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class LancamentoMaquina
    {

        #region Propriedades

        private int? _LNC_MAQ_ID;
        private int? _LNC_MAQ_MAQ_ID;
        private string _LNC_MAQ_LAD;
        private string _LNC_MAQ_LOT;
        private DateTime? _LNC_MAQ_VRD;
        private string _LNC_MAQ_TUB;
        private string _LNC_MAQ_PRD;
        private string _LNC_MAQ_COR;
        private string _LNC_MAQ_DES;
        private DateTime? _LNC_MAQ_DAT;
        private string _LNC_MAQ_POS;
        private int? _LNC_MAQ_STS;
        private int? _LNC_MAQ_USR_INC_ID;
        private int? _LNC_MAQ_USR_ALT_ID;
        private DateTime? _LNC_MAQ_TMS_ATL;

        private DateTime? _LNC_MAQ_DAT_INI;
        private DateTime? _LNC_MAQ_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? LNC_MAQ_ID
        {
            get { return _LNC_MAQ_ID; }
            set { _LNC_MAQ_ID = value; }
        }
        public int? LNC_MAQ_MAQ_ID
        {
            get { return _LNC_MAQ_MAQ_ID; }
            set { _LNC_MAQ_MAQ_ID = value; }
        }
        public string LNC_MAQ_LAD
        {
            get { return _LNC_MAQ_LAD; }
            set { _LNC_MAQ_LAD = value.ToUpper(); }
        }
        public string LNC_MAQ_LOT
        {
            get { return _LNC_MAQ_LOT; }
            set { _LNC_MAQ_LOT = value.ToUpper(); }
        }
        public DateTime? LNC_MAQ_VRD
        {
            get { return _LNC_MAQ_VRD; }
            set { _LNC_MAQ_VRD = value; }
        }
        public string LNC_MAQ_TUB
        {
            get { return _LNC_MAQ_TUB; }
            set { _LNC_MAQ_TUB = value.ToUpper(); }
        }
        public string LNC_MAQ_PRD
        {
            get { return _LNC_MAQ_PRD; }
            set { _LNC_MAQ_PRD = value.ToUpper(); }
        }
        public string LNC_MAQ_COR
        {
            get { return _LNC_MAQ_COR; }
            set { _LNC_MAQ_COR = value.ToUpper(); }
        }
        public string LNC_MAQ_DES
        {
            get { return _LNC_MAQ_DES; }
            set { _LNC_MAQ_DES = value; }
        }
        public DateTime? LNC_MAQ_DAT
        {
            get { return _LNC_MAQ_DAT; }
            set { _LNC_MAQ_DAT = value; }
        }
        public string LNC_MAQ_POS
        {
            get { return _LNC_MAQ_POS; }
            set { _LNC_MAQ_POS = value; }
        }
        public int? LNC_MAQ_STS
        {
            get { return _LNC_MAQ_STS; }
            set { _LNC_MAQ_STS = value; }
        }
        public int? LNC_MAQ_USR_INC_ID
        {
            get { return _LNC_MAQ_USR_INC_ID; }
            set { _LNC_MAQ_USR_INC_ID = value; }
        }
        public int? LNC_MAQ_USR_ALT_ID
        {
            get { return _LNC_MAQ_USR_ALT_ID; }
            set { _LNC_MAQ_USR_ALT_ID = value; }
        }
        public DateTime? LNC_MAQ_TMS_ATL
        {
            get { return _LNC_MAQ_TMS_ATL; }
            set { _LNC_MAQ_TMS_ATL = value; }
        }

        public DateTime? LNC_MAQ_DAT_INI
        {
            get { return _LNC_MAQ_DAT_INI; }
            set { _LNC_MAQ_DAT_INI = value; }
        }

        public DateTime? LNC_MAQ_DAT_FIM
        {
            get { return _LNC_MAQ_DAT_FIM; }
            set { _LNC_MAQ_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO LNC_MAQ (";
            sSQL = sSQL + "LNC_MAQ_MAQ_ID, ";
            sSQL = sSQL + "LNC_MAQ_LAD, ";
            sSQL = sSQL + "LNC_MAQ_LOT, ";
            sSQL = sSQL + "LNC_MAQ_VRD, ";
            sSQL = sSQL + "LNC_MAQ_TUB, ";
            sSQL = sSQL + "LNC_MAQ_PRD, ";
            sSQL = sSQL + "LNC_MAQ_COR, ";
            sSQL = sSQL + "LNC_MAQ_DES, ";
            sSQL = sSQL + "LNC_MAQ_DAT, ";
            sSQL = sSQL + "LNC_MAQ_POS, ";
            sSQL = sSQL + "LNC_MAQ_STS, ";
            sSQL = sSQL + "LNC_MAQ_USR_INC_ID, ";
            sSQL = sSQL + "LNC_MAQ_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(LNC_MAQ_MAQ_ID.ToString()))
            {
                sSQL = sSQL + LNC_MAQ_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LAD))
            {
                sSQL = sSQL + "'" + LNC_MAQ_LAD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LOT))
            {
                sSQL = sSQL + "'" + LNC_MAQ_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_VRD.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + LNC_MAQ_VRD + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_TUB))
            {
                sSQL = sSQL + "'" + LNC_MAQ_TUB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_PRD))
            {
                sSQL = sSQL + "'" + LNC_MAQ_PRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_COR))
            {
                sSQL = sSQL + "'" + LNC_MAQ_COR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_DES))
            {
                sSQL = sSQL + "'" + LNC_MAQ_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + LNC_MAQ_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_POS))
            {
                sSQL = sSQL + "'" + LNC_MAQ_POS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_STS.ToString()))
            {
                sSQL = sSQL + LNC_MAQ_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + LNC_MAQ_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE LNC_MAQ ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(LNC_MAQ_MAQ_ID.ToString()))
            {
                sSQL = sSQL + "LNC_MAQ_MAQ_ID = " + LNC_MAQ_MAQ_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_MAQ_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LAD))
            {
                sSQL = sSQL + "LNC_MAQ_LAD = '" + LNC_MAQ_LAD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_LAD = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LOT))
            {
                sSQL = sSQL + "LNC_MAQ_LOT = '" + LNC_MAQ_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_VRD.ToString()))
            {
                sSQL = sSQL + "LNC_MAQ_VRD = Convert(datetime, '" + LNC_MAQ_VRD + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_VRD = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_TUB))
            {
                sSQL = sSQL + "LNC_MAQ_TUB = '" + LNC_MAQ_TUB.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_TUB = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_PRD))
            {
                sSQL = sSQL + "LNC_MAQ_PRD = '" + LNC_MAQ_PRD.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_PRD = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_COR))
            {
                sSQL = sSQL + "LNC_MAQ_COR = '" + LNC_MAQ_COR.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_COR = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_DES))
            {
                sSQL = sSQL + "LNC_MAQ_DES = '" + LNC_MAQ_DES.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_DES = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_DAT.ToString()))
            {
                sSQL = sSQL + "LNC_MAQ_DAT = Convert(datetime, '" + LNC_MAQ_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_POS))
            {
                sSQL = sSQL + "LNC_MAQ_POS = '" + LNC_MAQ_POS.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_POS = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_STS.ToString()))
            {
                sSQL = sSQL + "LNC_MAQ_STS = " + LNC_MAQ_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "LNC_MAQ_USR_ALT_ID = " + LNC_MAQ_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "LNC_MAQ_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "LNC_MAQ_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE LNC_MAQ_ID = " + LNC_MAQ_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM LNC_MAQ";
            sSQL = sSQL + " WHERE LNC_MAQ_ID = " + LNC_MAQ_ID;

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
            sSQL = sSQL + " FROM LNC_MAQ";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            sSQL = sSQL + " INNER JOIN USR ON USR_ID = ISNULL(LNC_MAQ_USR_ALT_ID, LNC_MAQ_USR_INC_ID)";
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_ID)))
            {
                sCond = sCond + " LNC_MAQ_ID = " + LNC_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_MAQ_ID)))
            {
                sCond = sCond + " LNC_MAQ_MAQ_ID = " + LNC_MAQ_MAQ_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LAD))
            {
                sCond = sCond + " LNC_MAQ_LAD = '" + LNC_MAQ_LAD + "' AND ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_LOT))
            {
                sCond = sCond + " LNC_MAQ_LOT = '" + LNC_MAQ_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(LNC_MAQ_COR))
            {
                sCond = sCond + " LNC_MAQ_COR = '" + LNC_MAQ_COR + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_DAT)))
            {
                sCond = sCond + " LNC_MAQ_DAT BETWEEN Convert(datetime, '" + LNC_MAQ_DAT + "',103) AND Convert(datetime, '" + LNC_MAQ_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_DAT_INI)))
            {
                sCond = sCond + " LNC_MAQ_DAT >= Convert(datetime, '" + LNC_MAQ_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_DAT_FIM)))
            {
                sCond = sCond + " LNC_MAQ_DAT <= Convert(datetime, '" + LNC_MAQ_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_STS)))
            {
                sCond = sCond + " LNC_MAQ_STS = " + LNC_MAQ_STS + " AND ";
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


        public DataSet RelatorioEtiqueta()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = " SELECT DISTINCT MAQ_DES, LNC_MAQ_LOT, LNC_MAQ_PRD, LNC_MAQ_DES, LNC_MAQ_POS";
            sSQL = sSQL + " FROM LNC_MAQ";
            sSQL = sSQL + " INNER JOIN MAQ ON MAQ_ID = LNC_MAQ_MAQ_ID";
            sSQL = sSQL + " INNER JOIN MAQ_TIP ON MAQ_TIP_ID = MAQ_MAQ_TIP_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_MAQ_ID)))
            {
                sCond = sCond + " LNC_MAQ_MAQ_ID = " + LNC_MAQ_MAQ_ID + " AND ";
            }

            if (!String.IsNullOrEmpty(Convert.ToString(LNC_MAQ_STS)))
            {
                sCond = sCond + " LNC_MAQ_STS = " + LNC_MAQ_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MAQ_DES, LNC_MAQ_LOT ";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}
