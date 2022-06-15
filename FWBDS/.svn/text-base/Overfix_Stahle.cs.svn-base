using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Overfix_Stahle
    {

        #region Propriedades

        private int? _Cod;
        private double? _Overfix;
        private int? _Z3;


        private string _TOP;
        private string _SQL;

        public int? Cod
        {
            get { return _Cod; }
            set { _Cod = value; }
        }
        public double? Overfix
        {
            get { return _Overfix; }
            set { _Overfix = value; }
        }
        public int? Z3
        {
            get { return _Z3; }
            set { _Z3 = value; }
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
            string sSQL = "INSERT INTO OVERFIX_STAHLE (";
            sSQL = sSQL + "Cod, ";
            sSQL = sSQL + "Overfix, ";
            sSQL = sSQL + "Z3) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(Cod.ToString()))
            {
                sSQL = sSQL + Cod + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Overfix.ToString()))
            {
                sSQL = sSQL + Overfix.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z3.ToString()))
            {
                sSQL = sSQL + Z3 + ", ";
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
            string sSQL = "UPDATE OVERFIX_STAHLE ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(Overfix.ToString()))
            {
                sSQL = sSQL + "Overfix = " + Overfix.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "Overfix = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z3.ToString()))
            {
                sSQL = sSQL + "Z3 = " + Z3 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z3 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE Cod = " + Cod;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OVERFIX_STAHLE";
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
                sSQL = sSQL + " SELECT *, REPLACE(CONVERT(VARCHAR, OVERFIX), '.', ',') + ' / ' + CONVERT(VARCHAR, Z3) OVERFIX_Z03 ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, REPLACE(CONVERT(VARCHAR, OVERFIX), '.', ',') + ' / ' + CONVERT(VARCHAR, Z3) OVERFIX_Z03 ";
            }
            sSQL = sSQL + " FROM OVERFIX_STAHLE";

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