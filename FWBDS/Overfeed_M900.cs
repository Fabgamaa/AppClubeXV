using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Overfeed_M900
    {

        #region Propriedades

        private int? _CODIGO;
        private double? _OVERFEED;
        private double? _Z3Z5;
        private double? _Z4Z6;


        private string _TOP;
        private string _SQL;

        public int? CODIGO
        {
            get { return _CODIGO; }
            set { _CODIGO = value; }
        }
        public double? OVERFEED
        {
            get { return _OVERFEED; }
            set { _OVERFEED = value; }
        }
        public double? Z3Z5
        {
            get { return _Z3Z5; }
            set { _Z3Z5 = value; }
        }
        public double? Z4Z6
        {
            get { return _Z4Z6; }
            set { _Z4Z6 = value; }
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
            string sSQL = "INSERT INTO OVERFEED_M900 (";
            sSQL = sSQL + "CODIGO, ";
            sSQL = sSQL + "OVERFEED, ";
            sSQL = sSQL + "Z3Z5, ";
            sSQL = sSQL + "Z4Z6) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(CODIGO.ToString()))
            {
                sSQL = sSQL + CODIGO + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(OVERFEED.ToString()))
            {
                sSQL = sSQL + OVERFEED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z3Z5.ToString()))
            {
                sSQL = sSQL + Z3Z5.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z4Z6.ToString()))
            {
                sSQL = sSQL + Z4Z6.ToString().Replace(",", ".") + ", ";
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
            string sSQL = "UPDATE OVERFEED_M900 ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(CODIGO.ToString()))
            {
                sSQL = sSQL + "CODIGO = " + CODIGO + ", ";
            }
            else
            {
                sSQL = sSQL + "CODIGO = NULL, ";
            }
            if (!String.IsNullOrEmpty(OVERFEED.ToString()))
            {
                sSQL = sSQL + "OVERFEED = " + OVERFEED.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "OVERFEED = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z3Z5.ToString()))
            {
                sSQL = sSQL + "Z3Z5 = " + Z3Z5.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "Z3Z5 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z4Z6.ToString()))
            {
                sSQL = sSQL + "Z4Z6 = " + Z4Z6.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "Z4Z6 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE CODIGO = " + CODIGO;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OVERFEED_M900";
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
                sSQL = sSQL + " SELECT *, CONVERT(VARCHAR, OVERFEED) + ' / ' + CONVERT(VARCHAR, Z3Z5) + ' / ' + CONVERT(VARCHAR, Z4Z6) OVERFEED_Z3_Z4, CONVERT(VARCHAR, OVERFEED) + ' / ' + CONVERT(VARCHAR, Z3Z5) + ' / ' + CONVERT(VARCHAR, Z4Z6) OVERFEED_Z5_Z6 ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, CONVERT(VARCHAR, OVERFEED) + ' / ' + CONVERT(VARCHAR, Z3Z5) + ' / ' + CONVERT(VARCHAR, Z4Z6) OVERFEED_Z3_Z4, CONVERT(VARCHAR, OVERFEED) + ' / ' + CONVERT(VARCHAR, Z3Z5) + ' / ' + CONVERT(VARCHAR, Z4Z6) OVERFEED_Z5_Z6 ";
            }
            sSQL = sSQL + " FROM OVERFEED_M900";

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