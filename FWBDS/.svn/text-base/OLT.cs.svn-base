using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class OLT
    {

        #region Propriedades

        private int? _OLT_ID;
        private int? _OLT_MTV_ID;
        private int? _OLT_EPF_ID;
        private DateTime? _OLT_DAT;
        private string _OLT_MAQ;
        private int? _OLT_POS;
        private string _OLT_LOT;
        private int? _OLT_STS;
        private int? _OLT_USR_INC_ID;
        private int? _OLT_USR_ALT_ID;
        private DateTime? _OLT_TMS_ATL;

        private DateTime? _OLT_DAT_INI;
        private DateTime? _OLT_DAT_FIM;

        private string _TOP;
        private string _SQL;

        public int? OLT_ID
        {
            get { return _OLT_ID; }
            set { _OLT_ID = value; }
        }
        public int? OLT_MTV_ID
        {
            get { return _OLT_MTV_ID; }
            set { _OLT_MTV_ID = value; }
        }
        public int? OLT_EPF_ID
        {
            get { return _OLT_EPF_ID; }
            set { _OLT_EPF_ID = value; }
        }
        public DateTime? OLT_DAT
        {
            get { return _OLT_DAT; }
            set { _OLT_DAT = value; }
        }
        public string OLT_MAQ
        {
            get { return _OLT_MAQ; }
            set { _OLT_MAQ = value.ToUpper(); }
        }
        public int? OLT_POS
        {
            get { return _OLT_POS; }
            set { _OLT_POS = value; }
        }
        public string OLT_LOT
        {
            get { return _OLT_LOT; }
            set { _OLT_LOT = value.ToUpper(); }
        }
        public int? OLT_STS
        {
            get { return _OLT_STS; }
            set { _OLT_STS = value; }
        }
        public int? OLT_USR_INC_ID
        {
            get { return _OLT_USR_INC_ID; }
            set { _OLT_USR_INC_ID = value; }
        }
        public int? OLT_USR_ALT_ID
        {
            get { return _OLT_USR_ALT_ID; }
            set { _OLT_USR_ALT_ID = value; }
        }
        public DateTime? OLT_TMS_ATL
        {
            get { return _OLT_TMS_ATL; }
            set { _OLT_TMS_ATL = value; }
        }

        public DateTime? OLT_DAT_INI
        {
            get { return _OLT_DAT_INI; }
            set { _OLT_DAT_INI = value; }
        }

        public DateTime? OLT_DAT_FIM
        {
            get { return _OLT_DAT_FIM; }
            set { _OLT_DAT_FIM = value; }
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
            string sSQL = "INSERT INTO OLT (";
            sSQL = sSQL + "OLT_MTV_ID, ";
            sSQL = sSQL + "OLT_EPF_ID, ";
            sSQL = sSQL + "OLT_DAT, ";
            sSQL = sSQL + "OLT_MAQ, ";
            sSQL = sSQL + "OLT_POS, ";
            sSQL = sSQL + "OLT_LOT, ";
            sSQL = sSQL + "OLT_STS, ";
            sSQL = sSQL + "OLT_USR_INC_ID, ";
            sSQL = sSQL + "OLT_TMS_ATL) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(OLT_MTV_ID.ToString()))
            {
                sSQL = sSQL + OLT_MTV_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_EPF_ID.ToString()))
            {
                sSQL = sSQL + OLT_EPF_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_DAT.ToString()))
            {
                sSQL = sSQL + "Convert(datetime, '" + OLT_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_MAQ))
            {
                sSQL = sSQL + "'" + OLT_MAQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_POS.ToString()))
            {
                sSQL = sSQL + OLT_POS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_LOT))
            {
                sSQL = sSQL + "'" + OLT_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_STS.ToString()))
            {
                sSQL = sSQL + OLT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + OLT_USR_INC_ID + ", ";
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
            string sSQL = "UPDATE OLT ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(OLT_MTV_ID.ToString()))
            {
                sSQL = sSQL + "OLT_MTV_ID = " + OLT_MTV_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OLT_MTV_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_EPF_ID.ToString()))
            {
                sSQL = sSQL + "OLT_EPF_ID = " + OLT_EPF_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OLT_EPF_ID = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_DAT.ToString()))
            {
                sSQL = sSQL + "OLT_DAT = Convert(datetime, '" + OLT_DAT + "', 103), ";
            }
            else
            {
                sSQL = sSQL + "OLT_DAT = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_MAQ))
            {
                sSQL = sSQL + "OLT_MAQ = '" + OLT_MAQ.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OLT_MAQ = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_POS.ToString()))
            {
                sSQL = sSQL + "OLT_POS = " + OLT_POS + ", ";
            }
            else
            {
                sSQL = sSQL + "OLT_POS = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_LOT))
            {
                sSQL = sSQL + "OLT_LOT = '" + OLT_LOT.Replace("'", "''") + "', ";
            }
            else
            {
                sSQL = sSQL + "OLT_LOT = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_STS.ToString()))
            {
                sSQL = sSQL + "OLT_STS = " + OLT_STS + ", ";
            }
            else
            {
                sSQL = sSQL + "OLT_STS = NULL, ";
            }
            if (!String.IsNullOrEmpty(OLT_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + "OLT_USR_ALT_ID = " + OLT_USR_ALT_ID + ", ";
            }
            else
            {
                sSQL = sSQL + "OLT_USR_ALT_ID = NULL, ";
            }
            sSQL = sSQL + "OLT_TMS_ATL =  GETDATE(), ";
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE OLT_ID = " + OLT_ID;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OLT";
            sSQL = sSQL + " WHERE OLT_ID = " + OLT_ID;

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
            sSQL = sSQL + " FROM OLT";
            sSQL = sSQL + " INNER JOIN MTV ON MTV_ID = OLT_MTV_ID";
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_ID)))
            {
                sCond = sCond + " OLT_ID = " + OLT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_MTV_ID)))
            {
                sCond = sCond + " OLT_MTV_ID = " + OLT_MTV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_EPF_ID)))
            {
                sCond = sCond + " OLT_EPF_ID = " + OLT_EPF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(OLT_LOT))
            {
                sCond = sCond + " OLT_LOT = '" + OLT_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(OLT_MAQ))
            {
                sCond = sCond + " OLT_MAQ = '" + OLT_MAQ + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_STS)))
            {
                sCond = sCond + " OLT_STS = " + OLT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY OLT_DAT";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet ConsultarQuantidade()
        {
            string sCond = "";
            string sSQL = "";
            sSQL = sSQL + " SELECT COUNT(*) QTD ";
            sSQL = sSQL + " FROM OLT";
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_ID)))
            {
                sCond = sCond + " OLT_ID = " + OLT_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_MTV_ID)))
            {
                sCond = sCond + " OLT_MTV_ID = " + OLT_MTV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_EPF_ID)))
            {
                sCond = sCond + " OLT_EPF_ID = " + OLT_EPF_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(OLT_LOT))
            {
                sCond = sCond + " OLT_LOT = '" + OLT_LOT + "' AND ";
            }
            if (!String.IsNullOrEmpty(OLT_MAQ))
            {
                sCond = sCond + " OLT_MAQ = '" + OLT_MAQ + "' AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_STS)))
            {
                sCond = sCond + " OLT_STS = " + OLT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }
        
        //Eventos por categoria (Event Category)
        public DataSet RelatorioEventoCategoria()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " ";
            }
            sSQL = sSQL + " CAT_ID, CAT_DES, COUNT(*) QTD ";
            sSQL = sSQL + " FROM OLT ";
            sSQL = sSQL + " INNER JOIN MTV ON MTV_ID = OLT_MTV_ID ";
            sSQL = sSQL + " INNER JOIN CAT ON CAT_ID = MTV_CAT_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_STS)))
            {
                sCond = sCond + " OLT_STS = " + OLT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + " GROUP BY CAT_ID, CAT_DES";
            sSQL = sSQL + " ORDER BY CAT_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        //Motivos da desclassificação  (Reason code percentages by lot)
        public DataSet RelatorioMotivoDesclassificacao()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " ";
            }
            sSQL = sSQL + " A.OLT_LOT, MTV_ID, MTV_DES, MTV_ORI, COUNT(*) QTD, ";
            sSQL = sSQL + " (SELECT COUNT(*) FROM OLT B ";

            sCond = sCond + " B.OLT_LOT = A.OLT_LOT AND ";
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " B.OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " B.OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " B.OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
                sCond = "";
            }

            sSQL = sSQL + "  ) TOT ";
            sSQL = sSQL + " FROM OLT A ";
            sSQL = sSQL + " INNER JOIN MTV ON MTV_ID = A.OLT_MTV_ID ";
            sSQL = sSQL + " INNER JOIN CAT ON CAT_ID = MTV_CAT_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " A.OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " A.OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " A.OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_MTV_ID)))
            {
                sCond = sCond + " MTV_ID =" + OLT_MTV_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_STS)))
            {
                sCond = sCond + " A.OLT_STS = " + OLT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + " GROUP BY A.OLT_LOT, MTV_ID, MTV_DES, MTV_ORI";
            sSQL = sSQL + " ORDER BY A.OLT_LOT, MTV_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        //Percentual de motivos (Reason code percentages)
        public DataSet RelatorioPercentualMotivo()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " ";
            }
            sSQL = sSQL + " MTV_ID, MTV_DES, MTV_ORI, COUNT(*) QTD, ";
            sSQL = sSQL + " (SELECT COUNT(*) FROM OLT B ";

            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " B.OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " B.OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " B.OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
                sCond = "";
            }

            sSQL = sSQL + "  ) TOT ";
            sSQL = sSQL + " FROM OLT A ";
            sSQL = sSQL + " INNER JOIN MTV ON MTV_ID = A.OLT_MTV_ID ";
            sSQL = sSQL + " INNER JOIN CAT ON CAT_ID = MTV_CAT_ID ";

            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT)))
            {
                sCond = sCond + " A.OLT_DAT BETWEEN Convert(datetime, '" + OLT_DAT + "',103) AND Convert(datetime, '" + OLT_DAT + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_INI)))
            {
                sCond = sCond + " A.OLT_DAT >= Convert(datetime, '" + OLT_DAT_INI + "',103) AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_DAT_FIM)))
            {
                sCond = sCond + " A.OLT_DAT <= Convert(datetime, '" + OLT_DAT_FIM + "',103) + 0.99999 AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(OLT_STS)))
            {
                sCond = sCond + " A.OLT_STS = " + OLT_STS + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + " GROUP BY MTV_ID, MTV_DES, MTV_ORI";
            sSQL = sSQL + " ORDER BY MTV_ID";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}