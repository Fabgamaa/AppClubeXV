using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;



public partial class GeraPagina : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txt_tab.Text = txt_tab.Text.ToUpper();
    }

    protected void btGerarAspx_Click(object sender, EventArgs e)
    {
        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        pre_pag.InnerText = "";

        String sSelectCommand = "select lower(replace(name, '" + txt_tab.Text + "_', '')) name from syscolumns where name like '" + txt_tab.Text + "_%_001' order by colorder";
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);
    
        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);
    
        GeraCadastroTabelaAspx(dsPro);
        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();
    }

    protected void GeraCadastroTabelaAspx(DataSet dsPro)
    {
        string sClasse = sDataName(txt_tab.Text);

        foreach (DataRow drPro in dsPro.Tables[0].Rows)
        {
            pre_pag.InnerText += "\t\t<tr>\n";
            //pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString() + "_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001","") + "001_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "002_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "003_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "004_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "005_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "006_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            //pre_pag.InnerText += "\t\t<td><asp:TextBox id=\"txt_" + drPro["name"].ToString().Replace("001", "") + "007_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox></td>\n";
            pre_pag.InnerText += "\t\t</tr>\n";
        }
    }

    protected string sDataName(string sName)
    {
        string sReturn = "";
        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        sName = sName.Replace(txt_tab.Text + "_", "").Replace("_ID", "");

        string [] aName = sName.Split('_');
        foreach (string s in aName)
        {
            String sSelectCommand = "select * from glo where glo_abr_cod = '" + s + "'";
            SqlDataAdapter sdaGlo = new SqlDataAdapter(sSelectCommand, sConnectionString);
        
            DataSet dsGlo = new DataSet();
            sdaGlo.Fill(dsGlo);

            if (dsGlo.Tables[0].Rows.Count > 0)
            {
                sReturn += dsGlo.Tables[0].Rows[0]["GLO_DES"].ToString().Substring(0,1) + dsGlo.Tables[0].Rows[0]["GLO_DES"].ToString().Substring(1).ToLower() + " ";
            }
        }
        return sReturn.Trim();
    }

    protected string sDataType(string sType)
    {
        switch (sType)
        {
            case "smalldatetime": return "DateTime";
            case "datetime": return "DateTime";

            case "float": return "double";
            case "smallmoney": return "double";
            case "money": return "double";
            case "numeric": return "double";
            case "real": return "double";

            case "int": return "int";
            case "bit": return "int";
            case "tinyint": return "int";
            case "smallint": return "int";
            case "bigint": return "int";

            case "char": return "string";
            case "nchar": return "string";
            case "varchar": return "string";
            case "nvarchar": return "string";
            case "ntext": return "string";
            case "text": return "string";

            default: return "string";
        }
    }

    protected string sPrimeiroCampo(DataSet dsPro)
    {
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["name"].ToString().EndsWith("_TMS_ATL")) &&
                (!drPro["name"].ToString().Contains("_STM")))
            {
                if ((drPro["name"].ToString().Contains("_ID")) || (drPro["name"].ToString() == txt_tab.Text + "_STS"))
                {
                    return "cbo_" + drPro["name"].ToString().Replace(txt_tab.Text + "_", "").ToLower();
                }
                else
                {
                    return "txt_" + drPro["name"].ToString().Replace(txt_tab.Text + "_", "").ToLower();
                }
            }
        }
        return "";
}
}

