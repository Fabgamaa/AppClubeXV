using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Taxa_Stahle
    {

        #region Propriedades

        private int? _Cod;
        private double? _TxEst;
        private int? _Z9;
        private int? _Z10;
        private int? _Z11;
        private int? _Z12;


        private string _TOP;
        private string _SQL;

        public int? Cod
        {
            get { return _Cod; }
            set { _Cod = value; }
        }
        public double? TxEst
        {
            get { return _TxEst; }
            set { _TxEst = value; }
        }
        public int? Z9
        {
            get { return _Z9; }
            set { _Z9 = value; }
        }
        public int? Z10
        {
            get { return _Z10; }
            set { _Z10 = value; }
        }
        public int? Z11
        {
            get { return _Z11; }
            set { _Z11 = value; }
        }
        public int? Z12
        {
            get { return _Z12; }
            set { _Z12 = value; }
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
            string sSQL = "INSERT INTO TAXA_STAHLE (";
            sSQL = sSQL + "Cod, ";
            sSQL = sSQL + "TxEst, ";
            sSQL = sSQL + "Z9, ";
            sSQL = sSQL + "Z10, ";
            sSQL = sSQL + "Z11, ";
            sSQL = sSQL + "Z12) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(Cod.ToString()))
            {
                sSQL = sSQL + Cod + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TxEst.ToString()))
            {
                sSQL = sSQL + TxEst.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z9.ToString()))
            {
                sSQL = sSQL + Z9 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z10.ToString()))
            {
                sSQL = sSQL + Z10 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z11.ToString()))
            {
                sSQL = sSQL + Z11 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z12.ToString()))
            {
                sSQL = sSQL + Z12 + ", ";
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
            string sSQL = "UPDATE TAXA_STAHLE ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(TxEst.ToString()))
            {
                sSQL = sSQL + "TxEst = " + TxEst.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TxEst = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z9.ToString()))
            {
                sSQL = sSQL + "Z9 = " + Z9 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z9 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z10.ToString()))
            {
                sSQL = sSQL + "Z10 = " + Z10 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z10 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z11.ToString()))
            {
                sSQL = sSQL + "Z11 = " + Z11 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z11 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z12.ToString()))
            {
                sSQL = sSQL + "Z12 = " + Z12 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z12 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE Cod = " + Cod;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM TAXA_STAHLE";
            sSQL = sSQL + " WHERE Cod = " + Cod;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT *, REPLACE(CONVERT(VARCHAR, TXEST), '.', ',') + ' / ' + CONVERT(VARCHAR, Z9) + ' / ' + CONVERT(VARCHAR, Z10) TAXA_Z09_Z10, REPLACE(CONVERT(VARCHAR, TXEST), '.', ',') + ' / ' + CONVERT(VARCHAR, Z11) + ' / ' + CONVERT(VARCHAR, Z12) TAXA_Z11_Z12 ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, REPLACE(CONVERT(VARCHAR, TXEST), '.', ',') + ' / ' + CONVERT(VARCHAR, Z9) + ' / ' + CONVERT(VARCHAR, Z10) TAXA_Z09_Z10, REPLACE(CONVERT(VARCHAR, TXEST), '.', ',') + ' / ' + CONVERT(VARCHAR, Z11) + ' / ' + CONVERT(VARCHAR, Z12) TAXA_Z11_Z12  ";
            }
            sSQL = sSQL + " FROM TAXA_STAHLE";

            if (!String.IsNullOrEmpty(Convert.ToString(Cod)))
            {
                sCond = sCond + " Cod = " + Cod + " AND ";
            }

            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY Cod";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}