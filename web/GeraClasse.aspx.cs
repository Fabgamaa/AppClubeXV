using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class GeraClasse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txt_tab.Text = txt_tab.Text.ToUpper();
    }

    protected void btGerar_Click(object sender, EventArgs e)
    {
        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        pre_cls.InnerText = "";

        String sSelectCommand = "sp_help '" + txt_tab.Text + "'";
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);
    
        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);
    
        GeraCabecalho();
        GeraPropriedades(dsPro);
        GeraMetodos(dsPro);
        GeraRodape();

        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();

    }

    protected void GeraCabecalho()
    {
        pre_cls.InnerText += "using System;\n";
        pre_cls.InnerText += "using System.Collections.Generic;\n";
        pre_cls.InnerText += "using System.Linq;\n";
        pre_cls.InnerText += "using System.Text;\n";
        pre_cls.InnerText += "using System.Data;\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "namespace FWBDS\n";
        pre_cls.InnerText += "{\n";
        pre_cls.InnerText += "    public class " + txt_nom_cls.Text + "\n";
        pre_cls.InnerText += "    {\n";
        pre_cls.InnerText += "\n";

    }

    protected void GeraPropriedades(DataSet dsPro)
    {
        pre_cls.InnerText += "        #region Propriedades\n";
        pre_cls.InnerText += "\n";

        // Declaração
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            pre_cls.InnerText += "        private " + sDataType(drPro["type"].ToString()) + " _" + drPro["Column_name"].ToString() + ";\n";
        }

        pre_cls.InnerText += "\n";

        // Colunas DAT
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if (drPro["Column_name"].ToString().Contains("_DAT"))
            {
                pre_cls.InnerText += "        private " + sDataType(drPro["type"].ToString()) + " _" + drPro["Column_name"].ToString() + "_INI;\n";
                pre_cls.InnerText += "        private " + sDataType(drPro["type"].ToString()) + " _" + drPro["Column_name"].ToString() + "_FIM;\n";
            }
        }

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        private string _TOP;\n";
        pre_cls.InnerText += "        private string _SQL;\n";

        pre_cls.InnerText += "\n";

        //Get e Set
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            pre_cls.InnerText += "        public " + sDataType(drPro["type"].ToString()) + " " + drPro["Column_name"].ToString() + "\n";
            pre_cls.InnerText += "        {\n";
            pre_cls.InnerText += "            get { return _" + drPro["Column_name"].ToString() + "; }\n";
            if (sDataType(drPro["type"].ToString()) == "string")
            {
                pre_cls.InnerText += "            set { _" + drPro["Column_name"].ToString() + " = value.ToUpper(); }\n";
            }
            else
            {
                pre_cls.InnerText += "            set { _" + drPro["Column_name"].ToString() + " = value; }\n";
            }
            pre_cls.InnerText += "        }\n";
        }

        pre_cls.InnerText += "\n";
        // Colunas DAT
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if (drPro["Column_name"].ToString().Contains("_DAT"))
            {
                pre_cls.InnerText += "        public " + sDataType(drPro["type"].ToString()) + " " + drPro["Column_name"].ToString() + "_INI\n";
                pre_cls.InnerText += "        {\n";
                pre_cls.InnerText += "            get { return _" + drPro["Column_name"].ToString() + "_INI; }\n";
                {
                    pre_cls.InnerText += "            set { _" + drPro["Column_name"].ToString() + "_INI = value; }\n";
                }
                pre_cls.InnerText += "        }\n";
                pre_cls.InnerText += "        \n";
                pre_cls.InnerText += "        public " + sDataType(drPro["type"].ToString()) + " " + drPro["Column_name"].ToString() + "_FIM\n";
                pre_cls.InnerText += "        {\n";
                pre_cls.InnerText += "            get { return _" + drPro["Column_name"].ToString() + "_FIM; }\n";
                {
                    pre_cls.InnerText += "            set { _" + drPro["Column_name"].ToString() + "_FIM = value; }\n";
                }
                pre_cls.InnerText += "        }\n";
            }
        }

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        public string TOP\n";
        pre_cls.InnerText += "        {\n";
        pre_cls.InnerText += "            get { return _TOP; }\n";
        pre_cls.InnerText += "            set { _TOP = value; }\n";
        pre_cls.InnerText += "        }\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        public string SQL\n";
        pre_cls.InnerText += "        {\n";
        pre_cls.InnerText += "            get { return _SQL; }\n";
        pre_cls.InnerText += "            set { _SQL = value; }\n";
        pre_cls.InnerText += "        }\n";

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        #endregion\n";
        pre_cls.InnerText += "\n";

    }

    protected void GeraMetodos(DataSet dsPro)
    {

        pre_cls.InnerText += "        #region Métodos\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        clsBanco dbConn = new clsBanco();\n";
        pre_cls.InnerText += "\n";

        //Método Inserir
        pre_cls.InnerText += "        public string Inserir()\n";
        pre_cls.InnerText += "        {\n";

        pre_cls.InnerText += "            string sSQL = \"INSERT INTO " + txt_tab.Text + " (\";\n";
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            //Não criar insert para ID e Usuário de Atualização
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") && (drPro["Column_name"].ToString() != txt_tab.Text + "_USR_ALT_ID"))
            {
                pre_cls.InnerText += "            sSQL = sSQL + \"" + drPro["Column_name"].ToString() + ", \";\n";
            }
        }
        //Retirar última , e quebra de linha
        pre_cls.InnerText = pre_cls.InnerText.Substring(0, pre_cls.InnerText.Length - 5);
        pre_cls.InnerText += ") \";\n";

        pre_cls.InnerText += "            sSQL = sSQL + \"VALUES (\";\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            //Não criar insert para ID e Usuário de Atualização
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") && (drPro["Column_name"].ToString() != txt_tab.Text + "_USR_ALT_ID"))
            {
                pre_cls.InnerText += sDataTypeInsert(drPro["Column_name"].ToString(), drPro["type"].ToString());
            }
        }
        //Retirar última , e quebra de linha
        pre_cls.InnerText += "            sSQL = sSQL.Substring(0, sSQL.Length - 2); \n";
        pre_cls.InnerText += "            sSQL = sSQL + \") \";\n";

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            SQL = sSQL; \n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            return dbConn.ExecutarInserir(sSQL);";
        pre_cls.InnerText += "\n";
        
        pre_cls.InnerText += "        }\n";
        pre_cls.InnerText += "\n";

        //Método Alterar
        pre_cls.InnerText += "        public string Alterar()\n";
        pre_cls.InnerText += "        {\n";

        pre_cls.InnerText += "            string sSQL = \"UPDATE " + txt_tab.Text + " \";\n";
        pre_cls.InnerText += "            sSQL = sSQL + \"SET \";\n";
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            //Não criar insert para ID e Usuário de Atualização
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") && (drPro["Column_name"].ToString() != txt_tab.Text + "_USR_INC_ID"))
            {
                pre_cls.InnerText += sDataTypeUpdate(drPro["Column_name"].ToString(), drPro["type"].ToString());
            }
        }
        //Retirar última , e quebra de linha
        pre_cls.InnerText += "            sSQL = sSQL.Substring(0, sSQL.Length - 2); \n";
        pre_cls.InnerText += "            sSQL = sSQL + \" WHERE " + txt_tab.Text + "_ID = \" + " + txt_tab.Text + "_ID;\n";

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            SQL = sSQL; \n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            return dbConn.ExecutarInserir(sSQL);\n";
        pre_cls.InnerText += "\n";

        pre_cls.InnerText += "        }\n";
        pre_cls.InnerText += "\n";


        //Método Excluir
        pre_cls.InnerText += "        public string Excluir()\n";
        pre_cls.InnerText += "        {\n";
        pre_cls.InnerText += "            string sSQL = \"DELETE FROM " + txt_tab.Text + "\";\n";
        pre_cls.InnerText += "            sSQL = sSQL + \" WHERE " + txt_tab.Text + "_ID = \" + " + txt_tab.Text + "_ID;\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            SQL = sSQL; \n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            return dbConn.Executar(sSQL);\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        }\n";
        pre_cls.InnerText += "\n";

        //Método Consultar
        pre_cls.InnerText += "        public DataSet Consultar()\n";
        pre_cls.InnerText += "        {\n";

        pre_cls.InnerText += "            string sCond = \"\";\n";
        pre_cls.InnerText += "            string sSQL = \"\";\n";
        pre_cls.InnerText += "            if (String.IsNullOrEmpty(Convert.ToString(TOP)))\n";
        pre_cls.InnerText += "            {\n";
        pre_cls.InnerText += "                sSQL = sSQL + \" SELECT * \";\n";
        pre_cls.InnerText += "            }\n";
        pre_cls.InnerText += "            else\n";
        pre_cls.InnerText += "            {\n";
        pre_cls.InnerText += "                sSQL = sSQL + \" SELECT TOP \" + TOP.ToString() + \" * \";\n";
        pre_cls.InnerText += "            }\n";
        pre_cls.InnerText += "            sSQL = sSQL + \" FROM " + txt_tab.Text + "\";\n";
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            //Filtro para colunas _ID e STS
            if (drPro["Column_name"].ToString().EndsWith("_ID") || drPro["Column_name"].ToString().EndsWith("_STS"))
            {
                //Não criar consulta por Usuário de Inclusão e Atualização
                if ((drPro["Column_name"].ToString() != txt_tab.Text + "_USR_INC_ID") && (drPro["Column_name"].ToString() != txt_tab.Text + "_USR_ALT_ID"))
                {
                    pre_cls.InnerText += "            if (!String.IsNullOrEmpty(Convert.ToString(" + drPro["Column_name"].ToString() + ")))\n";
                    pre_cls.InnerText += "            {\n";
                    pre_cls.InnerText += "                sCond = sCond + \" " + drPro["Column_name"].ToString() + " = \" + " + drPro["Column_name"].ToString() + " + \" AND \";\n";
                    pre_cls.InnerText += "            }\n";
                }
            }

            //Filtro para colunas _DAT
            if (drPro["Column_name"].ToString().Contains("_DAT"))
            {
                pre_cls.InnerText += "            if (!String.IsNullOrEmpty(Convert.ToString(" + drPro["Column_name"].ToString() + ")))\n";
                pre_cls.InnerText += "            {\n";
                pre_cls.InnerText += "                sCond = sCond + \" " + drPro["Column_name"].ToString() + " BETWEEN Convert(datetime, '\" + " + drPro["Column_name"].ToString() + " + \"',103) AND Convert(datetime, '\" + " + drPro["Column_name"].ToString() + " + \"',103) + 0.99999 AND \";\n";
                pre_cls.InnerText += "            }\n";
                pre_cls.InnerText += "            if (!String.IsNullOrEmpty(Convert.ToString(" + drPro["Column_name"].ToString() + "_INI)))\n";
                pre_cls.InnerText += "            {\n";
                pre_cls.InnerText += "                sCond = sCond + \" " + drPro["Column_name"].ToString() + " >= Convert(datetime, '\" + " + drPro["Column_name"].ToString() + "_INI + \"',103) AND \";\n";
                pre_cls.InnerText += "            }\n";
                pre_cls.InnerText += "            if (!String.IsNullOrEmpty(Convert.ToString(" + drPro["Column_name"].ToString() + "_FIM)))\n";
                pre_cls.InnerText += "            {\n";
                pre_cls.InnerText += "                sCond = sCond + \" " + drPro["Column_name"].ToString() + " <= Convert(datetime, '\" + " + drPro["Column_name"].ToString() + "_FIM + \"',103) AND \";\n";
                pre_cls.InnerText += "            }\n";
            }
        }
        //Retirar última , e quebra de linha
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            if (sCond != \"\")\n";
        pre_cls.InnerText += "            {\n";
        pre_cls.InnerText += "                sCond = sCond.Substring(1, sCond.Length - 5);\n";
        pre_cls.InnerText += "                sSQL = sSQL + \" WHERE \" + sCond;\n";
        pre_cls.InnerText += "            }\n";
        pre_cls.InnerText += "            sSQL = sSQL + \" ORDER BY " + txt_tab.Text + "_ID\";\n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            SQL = sSQL; \n";
        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "            return dbConn.ExecutarRetorno(sSQL);\n";
        pre_cls.InnerText += "        }\n";

        pre_cls.InnerText += "\n";
        pre_cls.InnerText += "        #endregion\n";
        pre_cls.InnerText += "\n";

    }

    protected void GeraRodape()
    {
        pre_cls.InnerText += "    }\n";
        pre_cls.InnerText += "}\n";

    }

    protected string sDataType(string sType)
    {
        switch (sType)
        {
            case "smalldatetime": return "DateTime?";
            case "datetime": return "DateTime?";

            case "float": return "double?";
            case "smallmoney": return "double?";
            case "money": return "double?";
            case "numeric": return "double?";
            case "real": return "double?";

            case "int": return "int?";
            case "bit": return "int?";
            case "tinyint": return "int?";
            case "smallint": return "int?";
            case "bigint": return "int?";

            case "char": return "string";
            case "nchar": return "string";
            case "varchar": return "string";
            case "nvarchar": return "string";
            case "ntext": return "string";
            case "text": return "string";

            default: return "string";

        }

    }

    protected string sDataTypeInsert(string sColumn, string sType)
    {
        string sInsert = "";
        switch (sDataType(sType))
        {
            case "DateTime?":
                if (sColumn.Contains("_TMS_ATL") == true)
                {
                    sInsert = "            sSQL = sSQL + \"GETDATE(), \";\n";
                }
                else
                {
                    sInsert = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                    sInsert += "            {\n";
                    sInsert += "                sSQL = sSQL + \"Convert(datetime, '\" + " + sColumn + " + \"', 103), \";\n";
                    sInsert += "            }\n";
                    sInsert += "            else\n";
                    sInsert += "            {\n";
                    sInsert += "                sSQL = sSQL + \"NULL, \";\n";
                    sInsert += "            }\n";
                }
                break;

            case "double?":
                sInsert = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + " + sColumn + ".ToString().Replace(\",\", \".\") + \", \";\n";
                sInsert += "            }\n";
                sInsert += "            else\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + \"NULL, \";\n";
                sInsert += "            }\n";
                break;

            case "int?":
                sInsert = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + " + sColumn + " + \", \";\n";
                sInsert += "            }\n";
                sInsert += "            else\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + \"NULL, \";\n";
                sInsert += "            }\n";
                break;

            case "string":
                sInsert = "            if (!String.IsNullOrEmpty(" + sColumn + "))\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + \"'\" + " + sColumn + ".Replace(\"'\", \"''\") + \"', \";\n";
                sInsert += "            }\n";
                sInsert += "            else\n";
                sInsert += "            {\n";
                sInsert += "                sSQL = sSQL + \"NULL, \";\n";
                sInsert += "            }\n";
                break;

        }
        return sInsert;

    }

    protected string sDataTypeUpdate(string sColumn, string sType)
    {
        string sUpdate = "";
        switch (sDataType(sType))
        {
            case "DateTime?":
                if (sColumn.Contains("_TMS_ATL") == true)
                {
                    sUpdate = "            sSQL = sSQL + \"" + sColumn + " =  GETDATE(), \";\n";
                }
                else
                {
                    sUpdate = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                    sUpdate += "            {\n";
                    sUpdate += "                sSQL = sSQL + \"" + sColumn + " = Convert(datetime, '\" + " + sColumn + " + \"', 103), \";\n";
                    sUpdate += "            }\n";
                    sUpdate += "            else\n";
                    sUpdate += "            {\n";
                    sUpdate += "                sSQL = sSQL + \"" + sColumn + " = NULL, \";\n";
                    sUpdate += "            }\n";
                }
                break;

            case "double?":
                sUpdate = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = \" + " + sColumn + ".ToString().Replace(\",\", \".\") + \", \";\n";
                sUpdate += "            }\n";
                sUpdate += "            else\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = NULL, \";\n";
                sUpdate += "            }\n";
                break;

            case "int?":
                sUpdate = "            if (!String.IsNullOrEmpty(" + sColumn + ".ToString()))\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = \" + " + sColumn + " + \", \";\n";
                sUpdate += "            }\n";
                sUpdate += "            else\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = NULL, \";\n";
                sUpdate += "            }\n";
                break;

            case "string":
                sUpdate = "            if (!String.IsNullOrEmpty(" + sColumn + "))\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = '\" + " + sColumn + ".Replace(\"'\", \"''\") + \"', \";\n";
                sUpdate += "            }\n";
                sUpdate += "            else\n";
                sUpdate += "            {\n";
                sUpdate += "                sSQL = sSQL + \"" + sColumn + " = NULL, \";\n";
                sUpdate += "            }\n";
                break;

        }
        return sUpdate;

    }

}

