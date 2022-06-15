using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Overfeed_Stahle
    {

        #region Propriedades

        private int? _Cod;
        private double? _Overfeed;
        private int? _Z1;
        private int? _Z5;
        private int? _Z6;
        private int? _Z7;
        private int? _Z8;
        private int? _Z13;
        private int? _Z14;


        private string _TOP;
        private string _SQL;

        public int? Cod
        {
            get { return _Cod; }
            set { _Cod = value; }
        }
        public double? Overfeed
        {
            get { return _Overfeed; }
            set { _Overfeed = value; }
        }
        public int? Z1
        {
            get { return _Z1; }
            set { _Z1 = value; }
        }
        public int? Z5
        {
            get { return _Z5; }
            set { _Z5 = value; }
        }
        public int? Z6
        {
            get { return _Z6; }
            set { _Z6 = value; }
        }
        public int? Z7
        {
            get { return _Z7; }
            set { _Z7 = value; }
        }
        public int? Z8
        {
            get { return _Z8; }
            set { _Z8 = value; }
        }
        public int? Z13
        {
            get { return _Z13; }
            set { _Z13 = value; }
        }
        public int? Z14
        {
            get { return _Z14; }
            set { _Z14 = value; }
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
            string sSQL = "INSERT INTO OVERFEED_STAHLE (";
            sSQL = sSQL + "Cod, ";
            sSQL = sSQL + "Overfeed, ";
            sSQL = sSQL + "Z1, ";
            sSQL = sSQL + "Z5, ";
            sSQL = sSQL + "Z6, ";
            sSQL = sSQL + "Z7, ";
            sSQL = sSQL + "Z8, ";
            sSQL = sSQL + "Z13, ";
            sSQL = sSQL + "Z14) ";
            sSQL = sSQL + "VALUES (";
            if (!String.IsNullOrEmpty(Cod.ToString()))
            {
                sSQL = sSQL + Cod + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Overfeed.ToString()))
            {
                sSQL = sSQL + Overfeed.ToString().Replace(",", ".") + ", ";
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
            if (!String.IsNullOrEmpty(Z5.ToString()))
            {
                sSQL = sSQL + Z5 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z6.ToString()))
            {
                sSQL = sSQL + Z6 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z7.ToString()))
            {
                sSQL = sSQL + Z7 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z8.ToString()))
            {
                sSQL = sSQL + Z8 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z13.ToString()))
            {
                sSQL = sSQL + Z13 + ", ";
            }
            else
            {
                sSQL = sSQL + "NULL, ";
            }
            if (!String.IsNullOrEmpty(Z14.ToString()))
            {
                sSQL = sSQL + Z14 + ", ";
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
            string sSQL = "UPDATE OVERFEED_STAHLE ";
            sSQL = sSQL + "SET ";
            if (!String.IsNullOrEmpty(Overfeed.ToString()))
            {
                sSQL = sSQL + "Overfeed = " + Overfeed.ToString().Replace(",", ".") + ", ";
            }
            else
            {
                sSQL = sSQL + "Overfeed = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z1.ToString()))
            {
                sSQL = sSQL + "Z1 = " + Z1 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z1 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z5.ToString()))
            {
                sSQL = sSQL + "Z5 = " + Z5 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z5 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z6.ToString()))
            {
                sSQL = sSQL + "Z6 = " + Z6 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z6 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z7.ToString()))
            {
                sSQL = sSQL + "Z7 = " + Z7 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z7 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z8.ToString()))
            {
                sSQL = sSQL + "Z8 = " + Z8 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z8 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z13.ToString()))
            {
                sSQL = sSQL + "Z13 = " + Z13 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z13 = NULL, ";
            }
            if (!String.IsNullOrEmpty(Z14.ToString()))
            {
                sSQL = sSQL + "Z14 = " + Z14 + ", ";
            }
            else
            {
                sSQL = sSQL + "Z14 = NULL, ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - 2);
            sSQL = sSQL + " WHERE OVERFEED_STAHLE_ID = " + Cod;

            SQL = sSQL;

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM OVERFEED_STAHLE";
            sSQL = sSQL + " WHERE OVERFEED_STAHLE_ID = " + Cod;

            SQL = sSQL;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "";
            //Z02 e Z04 são fixas 40
            if (String.IsNullOrEmpty(Convert.ToString(TOP)))
            {
                sSQL = sSQL + " SELECT *, REPLACE(CONVERT(VARCHAR, OVERFEED), '.', ',') + ' / ' + CONVERT(VARCHAR, Z5) + ' / ' + CONVERT(VARCHAR, Z8)  + ' / ' + CONVERT(VARCHAR, Z13) OVERFEED_Z05_Z08_Z13, REPLACE(CONVERT(VARCHAR, OVERFEED), '.', ',') + ' / ' + CONVERT(VARCHAR, Z1) + ' / ' + CONVERT(VARCHAR, '40')  + ' / ' + CONVERT(VARCHAR, '40')  + ' / ' + CONVERT(VARCHAR, Z6)  + ' / ' + CONVERT(VARCHAR, Z14) OVERFEED_Z01_Z02_Z04_Z06_Z14 ";
            }
            else
            {
                sSQL = sSQL + " SELECT TOP " + TOP.ToString() + " *, REPLACE(CONVERT(VARCHAR, OVERFEED), '.', ',') + ' / ' + CONVERT(VARCHAR, Z5) + ' / ' + CONVERT(VARCHAR, Z8)  + ' / ' + CONVERT(VARCHAR, Z13) OVERFEED_Z05_Z08_Z13, REPLACE(CONVERT(VARCHAR, OVERFEED), '.', ',') + ' / ' + CONVERT(VARCHAR, Z1) + ' / ' + CONVERT(VARCHAR, '40')  + ' / ' + CONVERT(VARCHAR, '40')  + ' / ' + CONVERT(VARCHAR, Z6)  + ' / ' + CONVERT(VARCHAR, Z14) OVERFEED_Z01_Z02_Z04_Z06_Z14 ";
            }
            sSQL = sSQL + " FROM OVERFEED_STAHLE";

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