using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace FWBDS
{
    public class Usuario
    {
        #region Propriedades

        private int? _USR_ID;
        private int? _USR_PFL_ID;
        private int? _USR_MNU_ID;
        private int? _USR_PAS_ID;
        private int? _USR_STA_ID;
        private int? _USR_CID_ID;
        private string _USR_COD;
        private string _USR_SNH;
        private string _USR_NOM;
        private int? _USR_STS;
        private string _USR_RAZ_SOC;
        private DateTime? _USR_DAT_NAS;
        private string _USR_NOM_BNF;
        private string _USR_TEL_BNF;
        private string _USR_SEX;
        private string _USR_NAC;
        private string _USR_STC;
        private string _USR_TIP_PSA;
        private string _USR_NUM_CPF_CGC;
        private string _USR_NUM_RG;
        private string _USR_CEP;
        private string _USR_EDR;
        private string _USR_NUM_EDR;
        private string _USR_EDR_CMP;
        private string _USR_BRR;
        private string _USR_EML;
        private string _USR_MSG;
        private string _USR_SIT;
        private string _USR_BCO;
        private string _USR_AGE;
        private string _USR_CCO;
        private string _USR_OBS;
        private int? _USR_NUM_TTT;
        private DateTime? _USR_DAT_EXI;
        private DateTime? _USR_DAT_ATL_SNH;
        private string _USR_SNH_ANE;
        private int? _USR_STM;
        private int? _USR_USR_INC_ID;
        private int? _USR_USR_ALT_ID;
        private bool _AtualizaTentativas;
        private bool _AtualizaSenha;
        private string _Pagina;

        private string _IN_USR_PFL_ID;

        public int? USR_ID
        {
            get { return _USR_ID; }
            set { _USR_ID = value; }
        }
        public int? USR_PFL_ID
        {
            get { return _USR_PFL_ID; }
            set { _USR_PFL_ID = value; }
        }
        public int? USR_MNU_ID
        {
            get { return _USR_MNU_ID; }
            set { _USR_MNU_ID = value; }
        }
        public int? USR_PAS_ID
        {
            get { return _USR_PAS_ID; }
            set { _USR_PAS_ID = value; }
        }
        public int? USR_STA_ID
        {
            get { return _USR_STA_ID; }
            set { _USR_STA_ID = value; }
        }
        public int? USR_CID_ID
        {
            get { return _USR_CID_ID; }
            set { _USR_CID_ID = value; }
        }
        public string USR_COD
        {
            get { return _USR_COD; }
            set { _USR_COD = value.ToUpper(); }
        }
        public string USR_SNH
        {
            get { return _USR_SNH; }
            set { _USR_SNH = value.ToUpper(); }
        }
        public string USR_NOM
        {
            get { return _USR_NOM; }
            set { _USR_NOM = value.ToUpper(); }
        }
        public int? USR_STS
        {
            get { return _USR_STS; }
            set { _USR_STS = value; }
        }
        public string USR_RAZ_SOC
        {
            get { return _USR_RAZ_SOC; }
            set { _USR_RAZ_SOC = value.ToUpper(); }
        }
        public DateTime? USR_DAT_NAS
        {
            get { return _USR_DAT_NAS; }
            set { _USR_DAT_NAS = value; }
        }
        public string USR_NOM_BNF
        {
            get { return _USR_NOM_BNF; }
            set { _USR_NOM_BNF = value.ToUpper(); }
        }
        public string USR_TEL_BNF
        {
            get { return _USR_TEL_BNF; }
            set { _USR_TEL_BNF = value.ToUpper(); }
        }
        public string USR_SEX
        {
            get { return _USR_SEX; }
            set { _USR_SEX = value.ToUpper(); }
        }
        public string USR_NAC
        {
            get { return _USR_NAC; }
            set { _USR_NAC = value.ToUpper(); }
        }
        public string USR_STC
        {
            get { return _USR_STC; }
            set { _USR_STC = value.ToUpper(); }
        }
        public string USR_TIP_PSA
        {
            get { return _USR_TIP_PSA; }
            set { _USR_TIP_PSA = value.ToUpper(); }
        }
        public string USR_NUM_CPF_CGC
        {
            get { return _USR_NUM_CPF_CGC; }
            set { _USR_NUM_CPF_CGC = value.ToUpper(); }
        }
        public string USR_NUM_RG
        {
            get { return _USR_NUM_RG; }
            set { _USR_NUM_RG = value.ToUpper(); }
        }
        public string USR_CEP
        {
            get { return _USR_CEP; }
            set { _USR_CEP = value.ToUpper(); }
        }
        public string USR_EDR
        {
            get { return _USR_EDR; }
            set { _USR_EDR = value.ToUpper(); }
        }
        public string USR_NUM_EDR
        {
            get { return _USR_NUM_EDR; }
            set { _USR_NUM_EDR = value.ToUpper(); }
        }
        public string USR_EDR_CMP
        {
            get { return _USR_EDR_CMP; }
            set { _USR_EDR_CMP = value.ToUpper(); }
        }
        public string USR_BRR
        {
            get { return _USR_BRR; }
            set { _USR_BRR = value.ToUpper(); }
        }
        public string USR_EML
        {
            get { return _USR_EML; }
            set { _USR_EML = value.ToUpper(); }
        }
        public string USR_MSG
        {
            get { return _USR_MSG; }
            set { _USR_MSG = value.ToUpper(); }
        }
        public string USR_SIT
        {
            get { return _USR_SIT; }
            set { _USR_SIT = value.ToUpper(); }
        }
        public string USR_BCO
        {
            get { return _USR_BCO; }
            set { _USR_BCO = value.ToUpper(); }
        }
        public string USR_AGE
        {
            get { return _USR_AGE; }
            set { _USR_AGE = value.ToUpper(); }
        }
        public string USR_CCO
        {
            get { return _USR_CCO; }
            set { _USR_CCO = value.ToUpper(); }
        }
        public string USR_OBS
        {
            get { return _USR_OBS; }
            set { _USR_OBS = value.ToUpper(); }
        }
        public int? USR_NUM_TTT
        {
            get { return _USR_NUM_TTT; }
            set { _USR_NUM_TTT = value; }
        }
        public DateTime? USR_DAT_EXI
        {
            get { return _USR_DAT_EXI; }
            set { _USR_DAT_EXI = value; }
        }
        public DateTime? USR_DAT_ATL_SNH
        {
            get { return _USR_DAT_ATL_SNH; }
            set { _USR_DAT_ATL_SNH = value; }
        }
        public int? USR_STM
        {
            get { return _USR_STM; }
            set { _USR_STM = value; }
        }
        public int? USR_USR_INC_ID
        {
            get { return _USR_USR_INC_ID; }
            set { _USR_USR_INC_ID = value; }
        }
        public int? USR_USR_ALT_ID
        {
            get { return _USR_USR_ALT_ID; }
            set { _USR_USR_ALT_ID = value; }
        }
        public string USR_SNH_ANE
        {
            get { return _USR_SNH_ANE; }
            set { _USR_SNH_ANE = value.ToUpper(); }
        }
        public bool AtualizaTentativas
        {
            get { return _AtualizaTentativas; }
            set { _AtualizaTentativas = value; }
        }
        public bool AtualizaSenha
        {
            get { return _AtualizaSenha; }
            set { _AtualizaSenha = value; }
        }
        public string Pagina
        {
            get { return _Pagina; }
            set { _Pagina = value.ToUpper(); }
        }

        public string IN_USR_PFL_ID
        {
            get { return _IN_USR_PFL_ID; }
            set { _IN_USR_PFL_ID = value.ToUpper(); }
        }
        #endregion

        clsBanco dbConn = new clsBanco();

        #region Métodos
        public string Inserir()
        {
            string sSQL = "INSERT INTO USR ";
            sSQL = sSQL + " (USR_PFL_ID, USR_MNU_ID, USR_PAS_ID, USR_STA_ID, USR_CID_ID, USR_COD, USR_SNH, USR_NOM, ";
            sSQL = sSQL + " USR_STS, USR_SEX, USR_NAC, USR_TIP_PSA, USR_NUM_CPF_CGC, USR_NUM_RG, USR_CEP, USR_EDR, ";
            sSQL = sSQL + " USR_NUM_EDR, USR_EDR_CMP, USR_BRR, USR_EML, USR_MSG, USR_SIT, USR_BCO, USR_AGE, USR_CCO,  ";
            sSQL = sSQL + " USR_OBS, USR_NUM_TTT, USR_DAT_EXI, USR_DAT_ATL_SNH, USR_SNH_ANE, USR_STM, USR_USR_INC_ID, USR_TMS_ATL)";
            sSQL = sSQL + " VALUES (" + USR_PFL_ID;
            if (!String.IsNullOrEmpty(USR_MNU_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_MNU_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_PAS_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_PAS_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_STA_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_STA_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL";
            }
            if (!String.IsNullOrEmpty(USR_CID_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_CID_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_COD))
            {
                sSQL = sSQL + ",'" + USR_COD.Replace("'","''") + "' ";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_SNH))
            {
                sSQL = sSQL + ",'" + USR_SNH.Replace("'", "''") + "' ";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NOM.ToString()))
            {
                sSQL = sSQL + ",'" + USR_NOM.Replace("'", "''") + "' ";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_STS.ToString()))
            {
                sSQL = sSQL + "," + USR_STS;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_SEX))
            {
                sSQL = sSQL + ",'" + USR_SEX.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NAC))
            {
                sSQL = sSQL + ",'" + USR_NAC.Replace("'","''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_TIP_PSA))
            {
                sSQL = sSQL + ",'" + USR_TIP_PSA + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NUM_CPF_CGC))
            {
                sSQL = sSQL + ",'" + USR_NUM_CPF_CGC.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NUM_RG))
            {
                sSQL = sSQL + ",'" + USR_NUM_RG.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_CEP))
            {
                sSQL = sSQL + ",'" + USR_CEP.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_EDR))
            {
                sSQL = sSQL + ",'" + USR_EDR.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NUM_EDR))
            {
                sSQL = sSQL + ",'" + USR_NUM_EDR.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_EDR_CMP))
            {
                sSQL = sSQL + ",'" + USR_EDR_CMP.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_BRR))
            {
                sSQL = sSQL + ",'" + USR_BRR.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_EML))
            {
                sSQL = sSQL + ",'" + USR_EML.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_MSG))
            {
                sSQL = sSQL + ",'" + USR_MSG.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_SIT))
            {
                sSQL = sSQL + ",'" + USR_SIT.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_BCO))
            {
                sSQL = sSQL + ",'" + USR_BCO.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_AGE))
            {
                sSQL = sSQL + ",'" + USR_AGE.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_CCO))
            {
                sSQL = sSQL + ",'" + USR_CCO.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_OBS))
            {
                sSQL = sSQL + ",'" + USR_OBS.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_NUM_TTT.ToString()))
            {
                sSQL = sSQL + "," + USR_NUM_TTT.ToString();
            }
            else
            {
                sSQL = sSQL + ",0 ";
            }
            if (!String.IsNullOrEmpty(USR_DAT_EXI.ToString()))
            {
                sSQL = sSQL + ",Convert(datetime, '" + USR_DAT_EXI + "', 103)";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_DAT_ATL_SNH.ToString()))
            {
                sSQL = sSQL + ",Convert(datetime, '" + USR_DAT_ATL_SNH + "', 103)";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_SNH_ANE))
            {
                sSQL = sSQL + ",'" + USR_SNH_ANE.Replace("'", "''") + "'";
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_STM.ToString()))
            {
                sSQL = sSQL + "," + USR_STM;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            if (!String.IsNullOrEmpty(USR_USR_INC_ID.ToString()))
            {
                sSQL = sSQL + "," + USR_USR_INC_ID;
            }
            else
            {
                sSQL = sSQL + ",NULL ";
            }
            sSQL = sSQL + ",GetDate())";

            return dbConn.ExecutarInserir(sSQL);

        }

        public string Alterar()
        {
            string sSQL = "UPDATE USR ";
            sSQL = sSQL + " SET USR_TMS_ATL = GetDate() ";
            if (AtualizaTentativas != true && AtualizaSenha != true)
            {
                if (!String.IsNullOrEmpty(USR_PFL_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_PFL_ID = " + USR_PFL_ID;
                }
                else
                {
                    sSQL = sSQL + ", USR_PFL_ID = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_MNU_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_MNU_ID = " + USR_MNU_ID;
                }
                else
                {
                    sSQL = sSQL + ", USR_MNU_ID = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_PAS_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_PAS_ID = " + USR_PAS_ID;
                }
                else
                {
                    sSQL = sSQL + ", USR_PAS_ID = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_STA_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_STA_ID = " + USR_STA_ID;
                }
                else
                {
                    sSQL = sSQL + ", USR_STA_ID = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_CID_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_CID_ID = " + USR_CID_ID;
                }
                else
                {
                    sSQL = sSQL + ", USR_CID_ID = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_COD))
                {
                    sSQL = sSQL + ", USR_COD = '" + USR_COD.Replace("'", "''") + "' ";
                }
                if (!String.IsNullOrEmpty(USR_NOM))
                {
                    sSQL = sSQL + ", USR_NOM = '" + USR_NOM.Replace("'", "''") + "' ";
                }
                if (!String.IsNullOrEmpty(USR_STS.ToString()))
                {
                    sSQL = sSQL + ", USR_STS = " + USR_STS;
                }
                if (!String.IsNullOrEmpty(USR_SEX))
                {
                    sSQL = sSQL + ", USR_SEX = '" + USR_SEX.Replace("'", "''") + "'";
                }
                if (!String.IsNullOrEmpty(USR_NAC))
                {
                    sSQL = sSQL + ", USR_NAC = '" + USR_NAC.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_NAC = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_TIP_PSA))
                {
                    sSQL = sSQL + ", USR_TIP_PSA = '" + USR_TIP_PSA + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_TIP_PSA = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_NUM_CPF_CGC))
                {
                    sSQL = sSQL + ", USR_NUM_CPF_CGC = '" + USR_NUM_CPF_CGC.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_NUM_CPF_CGC = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_NUM_RG))
                {
                    sSQL = sSQL + ", USR_NUM_RG = '" + USR_NUM_RG.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_NUM_RG = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_CEP))
                {
                    sSQL = sSQL + ", USR_CEP = '" + USR_CEP.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_CEP = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_EDR))
                {
                    sSQL = sSQL + ", USR_EDR = '" + USR_EDR.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_EDR = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_NUM_EDR))
                {
                    sSQL = sSQL + ", USR_NUM_EDR = '" + USR_NUM_EDR.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_NUM_EDR = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_EDR_CMP))
                {
                    sSQL = sSQL + ", USR_EDR_CMP = '" + USR_EDR_CMP.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_EDR_CMP = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_BRR))
                {
                    sSQL = sSQL + ", USR_BRR = '" + USR_BRR.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_BRR = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_EML))
                {
                    sSQL = sSQL + ", USR_EML = '" + USR_EML.Replace("'", "''") + "'";
                }
                else
                {
                    sSQL = sSQL + ", USR_EML = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_DAT_EXI.ToString()))
                {
                    sSQL = sSQL + ", USR_DAT_EXI = Convert(datetime, '" + USR_DAT_EXI.ToString() + "',103)";
                }
                else
                {
                    sSQL = sSQL + ", USR_DAT_EXI = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_USR_ALT_ID.ToString()))
                {
                    sSQL = sSQL + ", USR_USR_ALT_ID = " + USR_USR_ALT_ID;
                }
            }
            if (AtualizaTentativas != true)
            {
                if (!String.IsNullOrEmpty(USR_SNH))
                {
                    sSQL = sSQL + ", USR_SNH = '" + USR_SNH.Replace("'", "''") + "' ";
                }
                if (!String.IsNullOrEmpty(USR_SNH_ANE))
                {
                    sSQL = sSQL + ", USR_SNH_ANE = '" + USR_SNH_ANE.Replace("'", "''") + "' ";
                }
                else
                {
                    sSQL = sSQL + ", USR_SNH_ANE = NULL ";
                }
                if (!String.IsNullOrEmpty(USR_DAT_ATL_SNH.ToString()))
                {
                    sSQL = sSQL + ", USR_DAT_ATL_SNH = Convert(datetime, '" + USR_DAT_ATL_SNH.ToString() + "',103)";
                }
                else
                {
                    sSQL = sSQL + ", USR_DAT_ATL_SNH = NULL ";
                }
            }
            if (AtualizaSenha != true)
            {
                if (!String.IsNullOrEmpty(USR_NUM_TTT.ToString()))
                {
                    sSQL = sSQL + ", USR_NUM_TTT = " + USR_NUM_TTT.ToString();
                }
                else
                {
                    sSQL = sSQL + ", USR_NUM_TTT = 0 ";
                }
            }

            sSQL = sSQL + " WHERE USR_ID = " + USR_ID;

            return dbConn.Executar(sSQL);

        }

        public string Excluir()
        {
            string sSQL = "DELETE FROM USR ";
            sSQL = sSQL + " WHERE USR_ID = " + USR_ID;

            return dbConn.Executar(sSQL);

        }

        public DataSet Consultar()
        {
            string sCond = "";
            string sSQL = "SELECT USR.*, PFL_DES, PAS_NOM, PAS_SGL, STA_NOM, STA_SGL, CID_NOM ";

            sSQL = sSQL + " FROM USR ";
            sSQL = sSQL + " INNER JOIN PFL ON PFL_ID = USR_PFL_ID ";
            sSQL = sSQL + " LEFT OUTER JOIN PAS ON USR_PAS_ID = PAS_ID ";
            sSQL = sSQL + " LEFT OUTER JOIN STA ON USR_STA_ID = STA_ID ";
            sSQL = sSQL + " LEFT OUTER JOIN CID ON USR_CID_ID = CID_ID ";
            if (!String.IsNullOrEmpty(Convert.ToString(USR_ID)))
            {
                sCond = sCond + " USR_ID = " + USR_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(USR_COD))
            {
                sCond = sCond + " USR_COD LIKE '%" + USR_COD + "%' AND ";
            }
            if (!String.IsNullOrEmpty(USR_SNH))
            {
                sCond = sCond + " USR_SNH = '" + USR_SNH + "' AND ";
            }
            if (!String.IsNullOrEmpty(USR_NOM))
            {
                sCond = sCond + " USR_NOM LIKE '%" + USR_NOM + "%' AND ";
            }
            if (!String.IsNullOrEmpty(USR_PFL_ID.ToString()))
            {
                sCond = sCond + " USR_PFL_ID = " + USR_PFL_ID + " AND ";
            }
            if (!String.IsNullOrEmpty(USR_STS.ToString()))
            {
                sCond = sCond + " USR_STS = " + USR_STS + " AND ";
            }

            if (!String.IsNullOrEmpty(IN_USR_PFL_ID))
            {
                sCond = sCond + " USR_PFL_ID IN (" + IN_USR_PFL_ID + ") AND ";
            }
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY USR_COD ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public DataSet ConsultarLogin()
        {
            string sCond = "";
            string sSQL = "SELECT USR_ID, USR_COD, USR_PFL_ID, PFL_DES, PFL_URL_INI, ISNULL(USR_NUM_TTT, 0) USR_NUM_TTT, USR_DAT_EXI, ";
            sSQL = sSQL + " USR_DAT_ATL_SNH, USR_SNH_ANE, USR_USR_INC_ID, USR_USR_ALT_ID, USR_TMS_ATL, PFL_DES ";

            sSQL = sSQL + " FROM USR ";
            sSQL = sSQL + " INNER JOIN PFL ON USR_PFL_ID = PFL_ID";
            if (!String.IsNullOrEmpty(USR_COD))
            {
                sCond = sCond + " USR_COD = '" + USR_COD + "' AND ";
            }
            if (!String.IsNullOrEmpty(USR_ID.ToString()))
            {
                sCond = sCond + " USR_ID = " + USR_ID;
            }
            if (!String.IsNullOrEmpty(USR_SNH))
            {
                sCond = sCond + " USR_SNH = '" + USR_SNH + "' AND ";
            }
            sCond = sCond + " USR_STS = 1 AND ";
            if (sCond != "")
            {
                sCond = sCond.Substring(1, sCond.Length - 5);
                sSQL = sSQL + " WHERE " + sCond;
            }
            sSQL = sSQL + " ORDER BY USR_COD ";
            return dbConn.ExecutarRetorno(sSQL);

        }

        public DataSet ConsultarPermissao()
        {
            string sSQL = "SELECT MNU_FHO_MNU_ID, MNU_FHO_URL, PFL_MNU_CSU, PFL_MNU_ALT, PFL_MNU_NOO, PFL_MNU_EXL ";
            sSQL = sSQL + " FROM MNU_FHO ";
	        sSQL = sSQL + "     INNER JOIN MNU ON MNU_ID = MNU_FHO_MNU_ID ";
	        sSQL = sSQL + "     INNER JOIN PFL_MNU ON PFL_MNU_MNU_ID = MNU_ID ";
	        sSQL = sSQL + "     INNER JOIN USR ON USR_PFL_ID = PFL_MNU_PFL_ID ";
            sSQL = sSQL + " WHERE PFL_MNU_CSU = 1"; // Somente Menus com permissão de Consulta
            sSQL = sSQL + "   AND MNU_FHO_URL = '" + Pagina + "'";
			sSQL = sSQL + " AND USR_ID = " + USR_ID.ToString();
            sSQL = sSQL + " UNION ";
            // Considerar páginas soltas com todas as permissões
            sSQL = sSQL + " SELECT MNU_FHO_MNU_ID, MNU_FHO_URL, CONVERT(bit, 1) PFL_MNU_CSU, CONVERT(bit, 1) PFL_MNU_ALT, CONVERT(bit, 1) PFL_MNU_NOO, CONVERT(bit, 1) PFL_MNU_EXL  ";
            sSQL = sSQL + " FROM MNU_FHO ";
            sSQL = sSQL + " WHERE MNU_FHO_MNU_ID IS NULL ";
	        sSQL = sSQL + "   AND MNU_FHO_URL = '" + Pagina + "'";
            return dbConn.ExecutarRetorno(sSQL);
        }



        #endregion

    }

}
