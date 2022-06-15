using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class PerfilMenu
    {
        #region Propriedades

        private int? _PFL_MNU_ID;
        private int? _PFL_MNU_PFL_ID;
        private int? _PFL_MNU_MNU_ID;
        private bool? _PFL_MNU_CSU;
        private bool? _PFL_MNU_ALT;
        private bool? _PFL_MNU_NOO;
        private bool? _PFL_MNU_EXL;
        private int? _PFL_USR_INC_ID;
        private int? _PFL_USR_ALT_ID;

        public int? PFL_MNU_ID
        {
            get { return _PFL_MNU_ID; }
            set { _PFL_MNU_ID = value; }
        }
        public int? PFL_MNU_PFL_ID
        {
            get { return _PFL_MNU_PFL_ID; }
            set { _PFL_MNU_PFL_ID = value; }
        }
        public int? PFL_MNU_MNU_ID
        {
            get { return _PFL_MNU_MNU_ID; }
            set { _PFL_MNU_MNU_ID = value; }
        }
        public bool? PFL_MNU_CSU
        {
            get { return _PFL_MNU_CSU; }
            set { _PFL_MNU_CSU = value; }
        }
        public bool? PFL_MNU_ALT
        {
            get { return _PFL_MNU_ALT; }
            set { _PFL_MNU_ALT = value; }
        }
        public bool? PFL_MNU_NOO
        {
            get { return _PFL_MNU_NOO; }
            set { _PFL_MNU_NOO = value; }
        }
        public bool? PFL_MNU_EXL
        {
            get { return _PFL_MNU_EXL; }
            set { _PFL_MNU_EXL = value; }
        }
        public int? PFL_USR_INC_ID
        {
            get { return _PFL_USR_INC_ID; }
            set { _PFL_USR_INC_ID = value; }
        }
        public int? PFL_USR_ALT_ID
        {
            get { return _PFL_USR_ALT_ID; }
            set { _PFL_USR_ALT_ID = value; }
        }

        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO PFL_MNU ";
            sSQL = sSQL + " (PFL_MNU_MNU_ID, PFL_MNU_PFL_ID, PFL_MNU_CSU, PFL_MNU_ALT, PFL_MNU_NOO, PFL_MNU_EXL, ";
            sSQL = sSQL + " PFL_MNU_USR_INC_ID, PFL_MNU_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + PFL_MNU_MNU_ID + "," + PFL_MNU_PFL_ID;
            sSQL = sSQL + "," + PFL_MNU_CSU;
            sSQL = sSQL + "," + PFL_MNU_ALT;
            sSQL = sSQL + "," + PFL_MNU_NOO;
            sSQL = sSQL + "," + PFL_MNU_EXL;
            if (!String.IsNullOrEmpty(PFL_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + PFL_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE PFL_MNU ";
            sSQL = sSQL + " SET PFL_MNU_PFL_ID = " + PFL_MNU_PFL_ID;
            if (!String.IsNullOrEmpty(PFL_MNU_MNU_ID.ToString()))
            {
                sSQL = sSQL + ", PFL_MNU_MNU_ID = " + PFL_MNU_MNU_ID;
            }
            sSQL = sSQL + ", PFL_MNU_CSU = " + Convert.ToInt16(PFL_MNU_CSU);
            sSQL = sSQL + ", PFL_MNU_ALT = " + Convert.ToInt16(PFL_MNU_ALT);
            sSQL = sSQL + ", PFL_MNU_NOO = " + Convert.ToInt16(PFL_MNU_NOO);
            sSQL = sSQL + ", PFL_MNU_EXL = " + Convert.ToInt16(PFL_MNU_EXL);
            if (!String.IsNullOrEmpty(PFL_USR_ALT_ID.ToString()))
            {
                sSQL = sSQL + ", PFL_MNU_USR_ALT_ID = " + PFL_USR_ALT_ID;
            }
            sSQL = sSQL + ", PFL_MNU_TMS_ATL = GetDate() ";
            sSQL = sSQL + " WHERE PFL_MNU_ID = " + PFL_MNU_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM PFL ";
            sSQL = sSQL + " WHERE PFL_MNU_ID = " + PFL_MNU_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT PFL_MNU_ID, PFL_MNU_PFL_ID, PFL_MNU_MNU_ID, PFL_MNU_CSU, ";
            sSQL = sSQL + " PFL_MNU_ALT, PFL_MNU_NOO, PFL_MNU_EXL, PFL_DES, MNU_TIT, MNU_NVL, MNU_URL ";

            sSQL = sSQL + " FROM PFL_MNU ";
            sSQL = sSQL + " INNER JOIN PFL ON PFL_MNU_PFL_ID = PFL_ID ";
            sSQL = sSQL + " INNER JOIN MNU ON PFL_MNU_MNU_ID = MNU_ID ";

            if (!String.IsNullOrEmpty(PFL_MNU_MNU_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_MNU_ID = " + PFL_MNU_MNU_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PFL_MNU_PFL_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_PFL_ID = " + PFL_MNU_PFL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_MNU_ID)))
            {
                sCond = sCond + " PFL_MNU_ID = " + PFL_MNU_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY MNU_ORD ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public string InserirPermissaoNovoPerfil(int PFL_ID)
        {
            string sSQL = "INSERT INTO PFL_MNU ";
            sSQL = sSQL + " (PFL_MNU_PFL_ID, PFL_MNU_MNU_ID, PFL_MNU_CSU, PFL_MNU_ALT, PFL_MNU_NOO, PFL_MNU_EXL, PFL_MNU_USR_INC_ID, PFL_MNU_TMS_ATL)";
            sSQL = sSQL + " SELECT ";
            sSQL = sSQL + PFL_ID;
            sSQL = sSQL + ",MNU_ID";
            sSQL = sSQL + ",1"; // Permite Consulta
            sSQL = sSQL + ",1"; // Permite Alteração
            sSQL = sSQL + ",1"; // Permite Novo
            sSQL = sSQL + ",1"; // Permite Exclusão
            if (!String.IsNullOrEmpty(PFL_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + PFL_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            sSQL = sSQL + ",GetDate()";
            sSQL = sSQL + " FROM MNU";

            return dbConn.Executar(sSQL);

        }

        public DataSet ConsultarPerfil()
        {
            string sCond = "";
            string sSQL = "SELECT PFL_MNU_PFL_ID, PFL_DES ";

            sSQL = sSQL + " FROM PFL_MNU ";
            sSQL = sSQL + " INNER JOIN PFL ON PFL_MNU_PFL_ID = PFL_ID ";

            if (!String.IsNullOrEmpty(PFL_MNU_MNU_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_MNU_ID = " + PFL_MNU_MNU_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PFL_MNU_PFL_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_PFL_ID = " + PFL_MNU_PFL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_MNU_ID)))
            {
                sCond = sCond + " PFL_MNU_ID = " + PFL_MNU_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " GROUP BY PFL_MNU_PFL_ID, PFL_DES ";
            sSQL = sSQL + " ORDER BY PFL_DES ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public DataSet ConsultarMenusHabilitados()
        {
            string sCond = "";
            string sSQL = "SELECT DISTINCT MNU_A.MNU_ID, MNU_A.MNU_ORD, MNU_A.MNU_TIT, MNU_A.MNU_URL, MNU_A.MNU_IMG, MNU_A.MNU_ALU, MNU_A.MNU_LAR, MNU_A.MNU_NVL, MNU_A.MNU_REG_ID";
            sSQL = sSQL + " FROM USR USR_A";
            sSQL = sSQL + " INNER JOIN PFL_MNU PFL_MNU_A ON PFL_MNU_A.PFL_MNU_PFL_ID = USR_A.USR_PFL_ID ";
            sSQL = sSQL + " INNER JOIN MNU MNU_A ON MNU_A.MNU_ID = PFL_MNU_A.PFL_MNU_MNU_ID";

            sCond = sCond + " PFL_MNU_A.PFL_MNU_CSU = 1 AND "; // Somente Menus com permissão de Consulta
            // Somente Menus que não sejam Menus de SubMenus (MNU_URL IS NOT NULL)
            // porem se forem, que tenham filhos que não sejam SubMenus com permissão de consulta (EXISTS).
            // Estamos verificando somente até o segundo nível de Menu Regedor (Tabelas "C")
            // Caso haja necessidade de verificar níveis mais baixos, o melhor será criar uma função que
            // recursivamente faça o teste se temos filhos que não sejam SubMenus e que tenham permissão de consulta.
            sCond = sCond + " (MNU_A.MNU_URL IS NOT NULL OR ";
            sCond = sCond + "  EXISTS (SELECT MNU_B.MNU_ID ";
            sCond = sCond + "          FROM MNU MNU_B  ";
            sCond = sCond + "          INNER JOIN PFL_MNU PFL_MNU_B ON PFL_MNU_B.PFL_MNU_PFL_ID = PFL_MNU_A.PFL_MNU_PFL_ID AND PFL_MNU_B.PFL_MNU_MNU_ID = MNU_B.MNU_ID ";
            sCond = sCond + "          WHERE MNU_B.MNU_REG_ID = MNU_A.MNU_ID AND  ";
            sCond = sCond + "          (MNU_B.MNU_URL IS NOT NULL OR ";
            sCond = sCond + "           EXISTS (SELECT MNU_C.MNU_ID ";
            sCond = sCond + "                   FROM MNU MNU_C ";
            sCond = sCond + "                   INNER JOIN PFL_MNU PFL_MNU_C ON PFL_MNU_C.PFL_MNU_PFL_ID = PFL_MNU_B.PFL_MNU_PFL_ID AND PFL_MNU_C.PFL_MNU_MNU_ID = MNU_C.MNU_ID ";
            sCond = sCond + "                   WHERE MNU_C.MNU_REG_ID = MNU_B.MNU_ID AND MNU_C.MNU_URL IS NOT NULL AND PFL_MNU_C.PFL_MNU_CSU = 1)) AND ";
            sCond = sCond + "          PFL_MNU_B.PFL_MNU_CSU = 1)) AND ";
            if (!String.IsNullOrEmpty(PFL_MNU_MNU_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_MNU_ID = " + PFL_MNU_MNU_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(PFL_MNU_PFL_ID.ToString()))
            {
                sCond = sCond + " PFL_MNU_PFL_ID = " + PFL_MNU_PFL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(Convert.ToString(PFL_MNU_ID)))
            {
                sCond = sCond + " PFL_MNU_ID = " + PFL_MNU_ID + " AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }

            sSQL = sSQL + " ORDER BY MNU_A.MNU_ORD ";

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet CarregaMenuTopo(string USR_ID)
        {
            string sSQL = "SELECT USR_A.USR_ID, MNU_A.MNU_ID, MNU_A.MNU_ORD, MNU_A.MNU_TIT, MNU_A.MNU_URL, MNU_A.MNU_IMG, MNU_A.MNU_ALU, MNU_A.MNU_LAR, MNU_A.MNU_NVL, MNU_A.MNU_REG_ID";
            sSQL = sSQL + " FROM USR USR_A";
            sSQL = sSQL + " INNER JOIN PFL_MNU PFL_MNU_A ON PFL_MNU_A.PFL_MNU_PFL_ID = USR_A.USR_PFL_ID ";
            sSQL = sSQL + " INNER JOIN MNU MNU_A ON MNU_A.MNU_ID = PFL_MNU_A.PFL_MNU_MNU_ID";
            sSQL = sSQL + " WHERE USR_A.USR_ID = " + USR_ID + " AND ";
            sSQL = sSQL + " PFL_MNU_A.PFL_MNU_CSU = 1 AND "; // Somente Menus com permissão de Consulta
            sSQL = sSQL + " MNU_A.MNU_NVL = 0 AND ";
            ////// Somente Menus que não sejam Menus de SubMenus (MNU_URL IS NOT NULL)
            ////// porem se forem, que tenham filhos  que não sejam SubMenus com permissão de consulta (EXISTS).
            ////// Estamos verificando somente até o segundo nível de Menu Regedor (Tabelas "C")
            ////// Caso haja necessidade de verificar níveis mais baixos, o melhor será criar uma função que
            ////// recursivamente faça o teste se temos filhos que não sejam SubMenus e que tenham permissão de consulta.
            sSQL = sSQL + " (MNU_A.MNU_URL IS NOT NULL OR ";
            sSQL = sSQL + "  EXISTS (SELECT MNU_B.MNU_ID ";
            sSQL = sSQL + "          FROM MNU MNU_B  ";
            sSQL = sSQL + "          INNER JOIN PFL_MNU PFL_MNU_B ON PFL_MNU_B.PFL_MNU_PFL_ID = PFL_MNU_A.PFL_MNU_PFL_ID AND PFL_MNU_B.PFL_MNU_MNU_ID = MNU_B.MNU_ID ";
            sSQL = sSQL + "          WHERE MNU_B.MNU_REG_ID = MNU_A.MNU_ID AND  ";
            sSQL = sSQL + "          (MNU_B.MNU_URL IS NOT NULL OR ";
            sSQL = sSQL + "           EXISTS (SELECT MNU_C.MNU_ID ";
            sSQL = sSQL + "                   FROM MNU MNU_C ";
            sSQL = sSQL + "                   INNER JOIN PFL_MNU PFL_MNU_C ON PFL_MNU_C.PFL_MNU_PFL_ID = PFL_MNU_B.PFL_MNU_PFL_ID AND PFL_MNU_C.PFL_MNU_MNU_ID = MNU_C.MNU_ID ";
            sSQL = sSQL + "                   WHERE MNU_C.MNU_REG_ID = MNU_B.MNU_ID AND MNU_C.MNU_URL IS NOT NULL AND PFL_MNU_C.PFL_MNU_CSU = 1)) AND ";
            sSQL = sSQL + "          PFL_MNU_B.PFL_MNU_CSU = 1)) ";
            sSQL = sSQL + " ORDER BY MNU_A.MNU_ORD ";

            return dbConn.ExecutarRetorno(sSQL);
        }

        public DataSet CarregaSubMenu(string USR_ID)
        {
            string sSQL = "SELECT USR_A.USR_ID, MNU_A.MNU_ID, MNU_A.MNU_ORD, MNU_A.MNU_TIT, MNU_A.MNU_URL, MNU_A.MNU_IMG, MNU_A.MNU_ALU, MNU_A.MNU_LAR, MNU_A.MNU_NVL, MNU_A.MNU_REG_ID";
            sSQL = sSQL + " FROM USR USR_A";
            sSQL = sSQL + " INNER JOIN PFL_MNU PFL_MNU_A ON PFL_MNU_A.PFL_MNU_PFL_ID = USR_A.USR_PFL_ID ";
            sSQL = sSQL + " INNER JOIN MNU MNU_A ON MNU_A.MNU_ID = PFL_MNU_A.PFL_MNU_MNU_ID";
            sSQL = sSQL + " WHERE USR_A.USR_ID = " + USR_ID + " AND ";
            sSQL = sSQL + " PFL_MNU_A.PFL_MNU_CSU = 1 AND "; // Somente Menus com permissão de Consulta
            sSQL = sSQL + " MNU_A.MNU_NVL > 0  AND ";
            // Somente Menus que não sejam Menus de SubMenus (MNU_URL IS NOT NULL)
            // porem se forem, que tenham filhos que não sejam SubMenus com permissão de consulta (EXISTS).
            // Estamos verificando somente até o segundo nível de Menu Regedor (Tabelas "C")
            // Caso haja necessidade de verificar níveis mais baixos, o melhor será criar uma função que
            // recursivamente faça o teste se temos filhos que não sejam SubMenus e que tenham permissão de consulta.
            sSQL = sSQL + " (MNU_A.MNU_URL IS NOT NULL OR ";
            sSQL = sSQL + "  EXISTS (SELECT MNU_B.MNU_ID ";
            sSQL = sSQL + "          FROM MNU MNU_B  ";
            sSQL = sSQL + "          INNER JOIN PFL_MNU PFL_MNU_B ON PFL_MNU_B.PFL_MNU_PFL_ID = PFL_MNU_A.PFL_MNU_PFL_ID AND PFL_MNU_B.PFL_MNU_MNU_ID = MNU_B.MNU_ID ";
            sSQL = sSQL + "          WHERE MNU_B.MNU_REG_ID = MNU_A.MNU_ID AND  ";
            sSQL = sSQL + "          (MNU_B.MNU_URL IS NOT NULL OR ";
            sSQL = sSQL + "           EXISTS (SELECT MNU_C.MNU_ID ";
            sSQL = sSQL + "                   FROM MNU MNU_C ";
            sSQL = sSQL + "                   INNER JOIN PFL_MNU PFL_MNU_C ON PFL_MNU_C.PFL_MNU_PFL_ID = PFL_MNU_B.PFL_MNU_PFL_ID AND PFL_MNU_C.PFL_MNU_MNU_ID = MNU_C.MNU_ID ";
            sSQL = sSQL + "                   WHERE MNU_C.MNU_REG_ID = MNU_B.MNU_ID AND MNU_C.MNU_URL IS NOT NULL AND PFL_MNU_C.PFL_MNU_CSU = 1)) AND ";
            sSQL = sSQL + "          PFL_MNU_B.PFL_MNU_CSU = 1)) ";
            sSQL = sSQL + " ORDER BY MNU_A.MNU_REG_ID, MNU_A.MNU_ORD ";

            return dbConn.ExecutarRetorno(sSQL);
        }
        #endregion

    }
}
