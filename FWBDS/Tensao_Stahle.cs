using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Tensao_Stahle
    {

        #region Propriedades

        private int? _COD;
        private double? _TENSAO;
        private double? _P2;
        private double? _P1;


        private string _TOP;
        private string _SQL;

        public int? COD
        {
            get { return _COD; }
            set { _COD = value; }
        }
        public double? TENSAO
        {
            get { return _TENSAO; }
            set { _TENSAO = value; }
        }
        public double? P2
        {
            get { return _P2; }
            set { _P2 = value; }
        }
        public double? P1
        {
            get { return _P1; }
            set { _P1 = value; }
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
            string sSQL = "INSERT INTO TENSAO_STAHLE (";
            sSQL = sSQL + "COD, ";
            sSQL = sSQL + "TENSAO, ";
            sSQL = sSQL + "P2, ";
            sSQL = sSQL + "P1) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(COD.ToString()))
            {
                sSQL = sSQL + COD + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TENSAO.ToString()))
            {
                sSQL = sSQL + TENSAO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(P2.ToString()))
            {
                sSQL = sSQL + P2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(P1.ToString()))
            {
                sSQL = sSQL + P1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + ") ";

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);
        }

        public string Alterar()
        {
            string sSQL = "UPDATE TENSAO_STAHLE ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(COD.ToString()))
            {
                sSQL = sSQL + "COD = " + COD + ", ";
            }
            else
            {
                sSQL = sSQL + "COD = NULL, ";
            }
            if (!String.IsNullOrEmpty(TENSAO.ToString()))
            {
                sSQL = sSQL + "TENSAO = " + TENSAO.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TENSAO = NULL, ";
            }
            if (!String.IsNullOrEmpty(P2.ToString()))
            {
                sSQL = sSQL + "P2 = " + P2.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "P2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(P1.ToString()))
            {
                sSQL = sSQL + "P1 = " + P1.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "P1 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE COD = " + COD;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM TENSAO_STAHLE";
            sSQL = sSQL + " WHERE COD = " + COD;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT *, REPLACE(CONVERT(VARCHAR, TENSAO), '.', ',') + ' / ' + CONVERT(VARCHAR, P1)  + ' / ' + CONVERT(VARCHAR, P2) TENSAO_P1_P2  ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, REPLACE(CONVERT(VARCHAR, TENSAO), '.', ',') + ' / ' + REPLACE(CONVERT(VARCHAR, P1), '.', ',')  + ' / ' + REPLACE(CONVERT(VARCHAR, P2), '.', ',') TENSAO_P1_P2  ";
            }
            sSQL = sSQL + " FROM TENSAO_STAHLE";

            if (!String.IsNullOrEmpty(Convert.ToString(COD)))
            {
                sCond = sCond + " COD = " + COD + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY COD";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}