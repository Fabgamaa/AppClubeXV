using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Engrenagem_M900
    {

        #region Propriedades

        private int? _CODIGO;
        private double? _TAXA;
        private int? _Z2;
        private int? _Z1;


        private string _TOP;
        private string _SQL;

        public int? CODIGO
        {
            get { return _CODIGO; }
            set { _CODIGO = value; }
        }
        public double? TAXA
        {
            get { return _TAXA; }
            set { _TAXA = value; }
        }
        public int? Z2
        {
            get { return _Z2; }
            set { _Z2 = value; }
        }
        public int? Z1
        {
            get { return _Z1; }
            set { _Z1 = value; }
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
            string sSQL = "INSERT INTO ENGRENAGEM_M900 (";
            sSQL = sSQL + "CODIGO, ";
            sSQL = sSQL + "TAXA, ";
            sSQL = sSQL + "Z2, ";
            sSQL = sSQL + "Z1) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(CODIGO.ToString()))
            {
                sSQL = sSQL + CODIGO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(TAXA.ToString()))
            {
                sSQL = sSQL + TAXA.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z2.ToString()))
            {
                sSQL = sSQL + Z2 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z1.ToString()))
            {
                sSQL = sSQL + Z1 + ", ";
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
            string sSQL = "UPDATE ENGRENAGEM_M900 ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(CODIGO.ToString()))
            {
                sSQL = sSQL + "CODIGO = " + CODIGO + ", ";
            }
            else
            {
                sSQL = sSQL + "CODIGO = NULL, ";
            }
            if (!String.IsNullOrEmpty(TAXA.ToString()))
            {
                sSQL = sSQL + "TAXA = " + TAXA.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "TAXA = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z2.ToString()))
            {
                sSQL = sSQL + "Z2 = " + Z2 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z2 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z1.ToString()))
            {
                sSQL = sSQL + "Z1 = " + Z1 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z1 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE CODIGO = " + CODIGO;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM ENGRENAGEM_M900";
            sSQL = sSQL + " WHERE CODIGO = " + CODIGO;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT *, CONVERT(VARCHAR, TAXA) + ' / ' + CONVERT(VARCHAR, Z1) + ' / ' + CONVERT(VARCHAR, Z2) TAXA_Z1_Z2 ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, CONVERT(VARCHAR, TAXA) + ' / ' + CONVERT(VARCHAR, Z1) + ' / ' + CONVERT(VARCHAR, Z2) TAXA_Z1_Z2 ";
            }
            sSQL = sSQL + " FROM ENGRENAGEM_M900";

            if (!String.IsNullOrEmpty(Convert.ToString(CODIGO)))
            {
                sCond = sCond + " CODIGO = " + CODIGO + " AND ";
            }
            
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY CODIGO";

            SQL = sSQL;

            return dbConn.ExecutarRetorno(sSQL);
        }

        #endregion

    }
}