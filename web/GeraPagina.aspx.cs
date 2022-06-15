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

        String sSelectCommand = "sp_help '" + txt_tab.Text + "'";
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);
    
        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);
    
        GeraCabecalhoAspx();
        GeraFiltroAspx(dsPro);
        GeraResultadoAspx(dsPro);
        GeraCadastroAspx(dsPro);
        GeraRodapeAspx();

        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();
    }

    protected void GeraCabecalhoAspx()
    {
        pre_pag.InnerText += "<%@ Page Language=\"C#\" EnableEventValidation=\"false\" AutoEventWireup=\"true\" CodeFile=\"" + txt_nom_pag.Text + ".aspx.cs\" Inherits=\"_Default\"%>\n";
        pre_pag.InnerText += "<%@ Register Src=\"inc/BarraIdentificacao.ascx\" TagName=\"Barra\" TagPrefix=\"ucBarra\"%>\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "<!--#include file=\"inc/FWMNUSUB.aspx\"-->\n";
        pre_pag.InnerText += "<!-- \n";
        pre_pag.InnerText += ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n";
        pre_pag.InnerText += "Empresa           : Fourway Informática\n";
        pre_pag.InnerText += "Sistema           : " + txt_bco.Text.Replace("_DSV","") + "\n";
        pre_pag.InnerText += "Arquivo           : " + txt_nom_pag.Text + ".aspx \n";
        pre_pag.InnerText += "Criado em         : " + DateTime.Now.ToString("dd/MM/yyyy") + "\n";
        pre_pag.InnerText += "Última Alteração  : \n";
        pre_pag.InnerText += "Versão            : 1.00\n";
        pre_pag.InnerText += "Descrição         : Módulo para Cadastro de " + txt_nom_pag.Text + " \n";
        pre_pag.InnerText += ":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n";
        pre_pag.InnerText += "-->\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\n";
        pre_pag.InnerText += "<html xmlns=\"http://www.w3.org/1999/xhtml\">\n";
        pre_pag.InnerText += "<head id=\"Head\" runat=\"server\">\n";
        pre_pag.InnerText += "<link rel=\"stylesheet\" type=\"text/css\" href=\"css/FW.css\"/>\n";
        pre_pag.InnerText += "\t<title><% Response.Write(ConfigurationSettings.AppSettings[\"Titulo\"]); %></title>\n";
        pre_pag.InnerText += "</head>\n";
        pre_pag.InnerText += "<body class=\"bg\" style=\"margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px\">\n";
        pre_pag.InnerText += "<form id=\"frm" + txt_nom_pag.Text + "\" runat=\"server\" action=\"" + txt_nom_pag.Text + ".aspx\">\n";
        pre_pag.InnerText += "<asp:HiddenField ID=\"Origem\" runat=\"server\" />\n";
        pre_pag.InnerText += "<asp:HiddenField ID=\"rowId\" runat=\"server\" />\n";        pre_pag.InnerText += "<script type=\"text/javascript\" language=\"javascript\" src=\"scr/FWGNR.js\"></script>\n";
        pre_pag.InnerText += "<script type=\"text/javascript\" language=\"javascript\" src=\"scr/FWMNU.js\"></script>\n";
        pre_pag.InnerText += "<ucBarra:Barra ID=\"ucBarra\" runat=\"server\"></ucBarra:Barra>\n";
        pre_pag.InnerText += "<div style=\"left:5px\">\n";
    }

    protected void GeraFiltroAspx(DataSet dsPro)
    {
        pre_pag.InnerText += "<div runat=\"server\" id=\"dvFiltro\" visible=\"true\">\n";
        pre_pag.InnerText += "<table style=\"width:780px\" align=\"center\" border=\"0\" cellspacing=\"4\" cellpadding=\"0\">\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"2\" class=\"font_titulo_grd\" style=\"width:780px\">\n";
        pre_pag.InnerText += "\t\t\tPesquisar " + txt_nom_pag.Text + "\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"2\">&nbsp;</td>\n";
        pre_pag.InnerText += "\t</tr>\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_STS")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                pre_pag.InnerText += "\t<tr>\n";
                pre_pag.InnerText += "\t\t<td colspan=\"2\" class=\"font_body\">" + sDataName(drPro["Column_name"].ToString()) + "</td>\n";
                pre_pag.InnerText += "\t</tr>\n";

                pre_pag.InnerText += "\t<tr>\n";
                pre_pag.InnerText += "\t\t<td colspan=\"2\">\n";
                if (!drPro["Column_name"].ToString().Contains("_ID"))
                {
                    //Campos sem ID
                    pre_pag.InnerText += "\t\t\t<asp:TextBox id=\"txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "\" runat=\"server\" CssClass=\"text_box\" maxlength=\"" + drPro["Length"].ToString() + "\" style=\"width:" + Convert.ToInt32(drPro["Length"].ToString()) * 10 + "px\"></asp:TextBox>\n";
                }
                else
                {
                    //DropDown de ID
                    pre_pag.InnerText += "\t\t\t<asp:DropDownList ID=\"cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "\" runat=\"server\" CssClass=\"combo_box\">\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"\" Text=\"\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t</asp:DropDownList>\n";
                }
                pre_pag.InnerText += "\t\t</td>\n";
                pre_pag.InnerText += "\t</tr>\n";
            }
            else
            {
                //Dropo Down STS deixa fixo as opções
                if (drPro["Column_name"].ToString() == txt_tab.Text + "_STS")
                {
                    pre_pag.InnerText += "\t<tr>\n";
                    pre_pag.InnerText += "\t\t<td colspan=\"2\" class=\"font_body\">" + sDataName(drPro["Column_name"].ToString()) + "</td>\n";
                    pre_pag.InnerText += "\t</tr>\n";
                    pre_pag.InnerText += "\t<tr>\n";
                    pre_pag.InnerText += "\t\t<td colspan=\"2\">\n";
                    pre_pag.InnerText += "\t\t\t<asp:DropDownList ID=\"cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "\" runat=\"server\" CssClass=\"combo_box\">\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"\" Text=\"\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"1\" Text=\"ATIVO\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"0\" Text=\"INATIVO\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t</asp:DropDownList>\n";
                    pre_pag.InnerText += "\t\t</td>\n";
                    pre_pag.InnerText += "\t</tr>\n";
                }
            }
        }
        
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"2\">&nbsp;</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"2\">\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btProcurar\"   runat=\"server\" CssClass=\"botao\" Text=\"Listar\" OnClick=\"btProcurar_Click\" /> &nbsp;&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btLimpar\"     runat=\"server\" CssClass=\"botao\" Text=\"Limpar\" OnClick=\"btLimpar_Click\" /> &nbsp;&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btNovoFiltro\" runat=\"server\" CssClass=\"botao\" Text=\"Novo\"   Onclick=\"btNovo_Click\" />\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "</table>\n";
        pre_pag.InnerText += "</div>\n";
    }

    protected void GeraResultadoAspx(DataSet dsPro)
    {
        pre_pag.InnerText += "<div runat=\"server\" id=\"dvResultado\" visible=\"false\">\n";
        pre_pag.InnerText += "<table style=\"width:780px\" align=\"center\" border=\"0\" cellspacing=\"4\" cellpadding=\"0\">\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td class=\"font_titulo_grd\" style=\"width:780px\">\n";
        pre_pag.InnerText += "\t\t\tPesquisar " + txt_nom_pag.Text + "\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td class=\"font_body\" style=\"width:780px\" align=\"right\">\n";
        pre_pag.InnerText += "\t\t\t<asp:Label ID=\"lb_fil\" runat=\"server\" CssClass=\"font_body_maiusculo\" />&nbsp;\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"2\">&nbsp;</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td align=\"right\">\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btVoltarGrid\"     runat=\"server\" CssClass=\"botao\" Text=\"Filtro\" Onclick=\"btVoltar_Click\" /> &nbsp;&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btNovoFiltroGrid\" runat=\"server\" CssClass=\"botao\" Text=\"Novo\"   Onclick=\"btNovo_Click\" />\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td align=\"right\">\n";
        pre_pag.InnerText += "\t\t\t<asp:LinkButton ID=\"lkb_pdf\" runat=\"server\" OnClick=\"lkb_pdf_Click\" Text=\"pdf\" ToolTip=\"Exporta para PDF\"></asp:LinkButton>\n";
        pre_pag.InnerText += "\t\t\t&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:LinkButton ID=\"lkb_xls\" runat=\"server\" OnClick=\"lkb_xls_Click\" Text=\"xls\" ToolTip=\"Exporta para XLS\"></asp:LinkButton>\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td>\n";
        pre_pag.InnerText += "\t\t\t<asp:Label ID=\"lblSortLogin\" runat=\"server\" Visible=\"false\" Text=\"ASC\"></asp:Label>\n";
        pre_pag.InnerText += "\t\t\t<asp:GridView Width=\"760px\" CausesValidation=\"false\"   ID=\"gv" + txt_nom_pag.Text + "\" DataKeyNames=\"" + txt_tab.Text + "_ID\" \n";
        pre_pag.InnerText += "\t\t\t\trunat=\"server\" AutoGenerateColumns=\"false\" AllowSorting=\"true\" \n";
        pre_pag.InnerText += "\t\t\t\tOnRowDataBound=\"gv" + txt_nom_pag.Text + "_RowDataBound\"  OnSorting=\"gv" + txt_nom_pag.Text + "_Sorting\"\n";
        pre_pag.InnerText += "\t\t\t\tOnRowCreated=\"gv" + txt_nom_pag.Text + "_RowCreated\"\n";
        pre_pag.InnerText += "\t\t\t\tEmptyDataText=\"Não foram encontrados registros de acordo com o filtro.\">\n";
        pre_pag.InnerText += "\t\t\t<Columns>\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_STS")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                pre_pag.InnerText += "\t\t\t<asp:TemplateField HeaderText=\" " + sDataName(drPro["Column_name"].ToString()) + " \" SortExpression=\"" + drPro["Column_name"].ToString() + "\" ControlStyle-Width=\"" + Convert.ToInt32(drPro["Length"].ToString()) * 10 + "px\" >\n";
                pre_pag.InnerText += "\t\t\t<ItemTemplate>\n";

                switch (sDataType(drPro["Type"].ToString()))
                {
                    case "DateTime":
                        pre_pag.InnerText += "\t\t\t\t<asp:Label ID=\"lb" + drPro["Column_name"].ToString() + "\" runat=\"server\" Text='<%# String.IsNullOrEmpty(Eval(\"" + drPro["Column_name"].ToString() + "\").ToString())?\"\":Convert.ToDateTime(Eval(\"" + drPro["Column_name"].ToString() + "\").ToString()).ToString(\"dd/MM/yyyy\") %>' />\n";
                        break;

                    case "double":
                        pre_pag.InnerText += "\t\t\t\t<asp:Label ID=\"lb" + drPro["Column_name"].ToString() + "\" runat=\"server\" Text='<%# String.IsNullOrEmpty(Eval(\"" + drPro["Column_name"].ToString() + "\").ToString())?\"\":Convert.ToDouble(Eval(\"" + drPro["Column_name"].ToString() + "\").ToString()).ToString(\"N2\") %>'/>\n";
                        break;

                    default:
                        pre_pag.InnerText += "\t\t\t\t<asp:Label ID=\"lb" + drPro["Column_name"].ToString() + "\" runat=\"server\" Text='<%# Eval(\"" + drPro["Column_name"].ToString() + "\") %>' />\n";
                        break;

                }

                pre_pag.InnerText += "\t\t\t</ItemTemplate>\n";
                pre_pag.InnerText += "\t\t\t<HeaderStyle ForeColor=\"White\" />\n";
                pre_pag.InnerText += "\t\t\t</asp:TemplateField>\n";
            }
            else
            {
                //Dropo Down STS deixa fixo as opções
                if (drPro["Column_name"].ToString() == txt_tab.Text + "_STS")
                {
                    pre_pag.InnerText += "\t\t\t<asp:TemplateField HeaderText=\" " + sDataName(drPro["Column_name"].ToString()) + " \" SortExpression=\"" + drPro["Column_name"].ToString() + "\" ControlStyle-Width=\"" + Convert.ToInt32(drPro["Length"].ToString()) * 10 + "px\" >\n";
                    pre_pag.InnerText += "\t\t\t<ItemTemplate>\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:Label ID=\"lb" + drPro["Column_name"].ToString() + "\" runat=\"server\" Text='<%# (Eval(\"" + drPro["Column_name"].ToString() + "\").ToString() == \"1\")?\"ATIVO\":\"INATIVO\" %>'/>\n";
                    pre_pag.InnerText += "\t\t\t</ItemTemplate>\n";
                    pre_pag.InnerText += "\t\t\t<HeaderStyle ForeColor=\"White\" />\n";
                    pre_pag.InnerText += "\t\t\t</asp:TemplateField>\n";
                }
            }
        }

        pre_pag.InnerText += "\t\t\t</Columns>\n";
        pre_pag.InnerText += "\t\t\t<AlternatingRowStyle CssClass=\"linha_impar\" />\n";
        pre_pag.InnerText += "\t\t\t<RowStyle CssClass=\"linha_par\" />\n";
        pre_pag.InnerText += "\t\t\t<SelectedRowStyle CssClass=\"selecionado\" />\n";
        pre_pag.InnerText += "\t\t\t<HeaderStyle CssClass=\"cabecalho_tabela\" />\n";
        pre_pag.InnerText += "\t\t\t<EmptyDataRowStyle CssClass=\"font_body\" />\n";
        pre_pag.InnerText += "\t\t\t</asp:GridView>\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "</table>\n";   
        pre_pag.InnerText += "</div>\n";
    }

    protected void GeraCadastroAspx(DataSet dsPro)
    {
        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "<div ID=\"divCadastro\" runat=\"server\">\n";
        pre_pag.InnerText += "<table style=\"width:780px\" align=\"center\" border=\"0\" cellspacing=\"4\" cellpadding=\"0\" class=\"font_body\">\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"4\" class=\"font_titulo_grd\" style=\"width:780px\">\n";
        pre_pag.InnerText += "\t\t\t<asp:Label runat=\"server\" ID=\"lbAcao\" CssClass=\"font_titulo_grd\"></asp:Label>\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + "\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"4\">&nbsp;</td>\n";
        pre_pag.InnerText += "\t</tr>\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            string sObrigatorio = "";
            if (drPro["Nullable"].ToString() == "no")
            {
                sObrigatorio = "*";
            }

            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_STS")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                pre_pag.InnerText += "\t<tr>\n";
                pre_pag.InnerText += "\t\t<td colspan=\"4\" class=\"font_body\">" + sDataName(drPro["Column_name"].ToString()) + "</td>\n";
                pre_pag.InnerText += "\t</tr>\n";

                pre_pag.InnerText += "\t<tr>\n";
                pre_pag.InnerText += "\t\t<td colspan=\"4\">\n";

                if (!drPro["Column_name"].ToString().Contains("_ID"))
                {
                    //Campos sem ID
                    if (drPro["Column_name"].ToString().Contains("DAT"))
                    {
                        //Campos Data com tamanho fixo
                        pre_pag.InnerText += "\t\t\t<asp:TextBox id=\"txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"10\" style=\"width:100px\"></asp:TextBox> " + sObrigatorio + "\n"; 
                    }
                    else
                    {
                        pre_pag.InnerText += "\t\t\t<asp:TextBox id=\"txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc\" runat=\"server\" CssClass=\"text_box\"  maxlength=\"" + drPro["Length"].ToString() + "\" style=\"width:" + Convert.ToInt32(drPro["Length"].ToString()) * 10 + "px\"></asp:TextBox> " + sObrigatorio + "\n";
                    }
                }
                else
                {
                    //DropDown de ID
                    pre_pag.InnerText += "\t\t\t<asp:DropDownList ID=\"cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc\" runat=\"server\" CssClass=\"combo_box\">\n";
                    pre_pag.InnerText += "\t\t\t</asp:DropDownList> " + sObrigatorio + "\n";
                }
                pre_pag.InnerText += "\t\t</td>\n";
                pre_pag.InnerText += "\t</tr>\n";
            }
            else
            {
                //Dropo Down STS deixa fixo as opções
                if (drPro["Column_name"].ToString() == txt_tab.Text + "_STS")
                {
                    pre_pag.InnerText += "\t<tr>\n";
                    pre_pag.InnerText += "\t\t<td colspan=\"4\" class=\"font_body\">" + sDataName(drPro["Column_name"].ToString()) + "</td>\n";
                    pre_pag.InnerText += "\t</tr>\n";
                    pre_pag.InnerText += "\t<tr>\n";
                    pre_pag.InnerText += "\t\t<td colspan=\"4\">\n";
                    pre_pag.InnerText += "\t\t\t<asp:DropDownList ID=\"cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc\" runat=\"server\" CssClass=\"combo_box\">\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"1\" Text=\"ATIVO\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t\t<asp:ListItem value=\"0\" Text=\"INATIVO\"></asp:ListItem>\n";
                    pre_pag.InnerText += "\t\t\t</asp:DropDownList> " + sObrigatorio + "\n";
                    pre_pag.InnerText += "\t\t</td>\n";
                    pre_pag.InnerText += "\t</tr>\n";
                }
            }
        }

        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"4\">&nbsp;</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "\t<tr>\n";
        pre_pag.InnerText += "\t\t<td colspan=\"4\">\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btSalvar\" runat=\"server\" Text=\"Salvar\" CssClass=\"botao\" Onclick=\"btSalvar_Click\" /> &nbsp;&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btVoltar\" runat=\"server\" Text=\"Filtro\" CssClass=\"botao\" Onclick=\"btVoltar_Click\" /> &nbsp;&nbsp;\n";
        pre_pag.InnerText += "\t\t\t<asp:Button ID=\"btNovo\"   runat=\"server\" Text=\"Novo\"   CssClass=\"botao\" Onclick=\"btNovo_Click\" />\n";
        pre_pag.InnerText += "\t\t</td>\n";
        pre_pag.InnerText += "\t</tr>\n";
        pre_pag.InnerText += "</table>\n";
        pre_pag.InnerText += "</div>\n";
    }

    protected void GeraRodapeAspx()
    {
        pre_pag.InnerText += "</div>\n";
        pre_pag.InnerText += "</form>\n";
        pre_pag.InnerText += "</body>\n";
        pre_pag.InnerText += "</html>\n";
    }


    protected void btGerarAspxCs_Click(object sender, EventArgs e)
    {
        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        sConnectionString += "Password=" + txt_snh.Text + ";";

        pre_pag.InnerText = "";

        String sSelectCommand = "sp_help '" + txt_tab.Text + "'";
        SqlDataAdapter sdaPro = new SqlDataAdapter(sSelectCommand, sConnectionString);

        DataSet dsPro = new DataSet();
        sdaPro.Fill(dsPro);

        GeraCabecalhoAspxCs();
        GeraFormataControlesAspxCs(dsPro);
        GeraCarregaControlesAspxCs(dsPro);
        GeraCarregaDadosAspxCs(dsPro);

        GeraFiltroProcurarAspxCs(dsPro);
        GeraGridViewAspxCs(dsPro);
        GeraSalvarAspxCs(dsPro);
        GeraRodapeAspxCs();

        dsPro.Dispose();
        sdaPro.Dispose();
        Dispose();

    }

    protected void GeraCabecalhoAspxCs()
    {
        pre_pag.InnerText += "using System;\n";
        pre_pag.InnerText += "using System.Data;\n";
        pre_pag.InnerText += "using System.Configuration;\n";
        pre_pag.InnerText += "using System.Collections;\n";
        pre_pag.InnerText += "using System.Web;\n";
        pre_pag.InnerText += "using System.Web.Security;\n";
        pre_pag.InnerText += "using System.Web.UI;\n";
        pre_pag.InnerText += "using System.IO;\n";
        pre_pag.InnerText += "using System.Web.UI.WebControls;\n";
        pre_pag.InnerText += "using System.Web.UI.WebControls.WebParts;\n";
        pre_pag.InnerText += "using System.Web.UI.HtmlControls;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "using iTextSharp.text;\n";
        pre_pag.InnerText += "using iTextSharp.text.pdf;\n";
        pre_pag.InnerText += "using iTextSharp.text.html;\n";
        pre_pag.InnerText += "using iTextSharp.text.html.simpleparser;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "using FWBDS;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "public partial class _Default : System.Web.UI.Page\n";
        pre_pag.InnerText += "{\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\tprotected void Page_Load(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (Request[\"rowId\"] != null)";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\trowId.Value = Request[\"rowId\"].ToString();";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\tif (Request[\"Origem\"] != null)";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tOrigem.Value = Request[\"Origem\"].ToString();";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\tif (!IsPostBack)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tif (!String.IsNullOrEmpty(Origem.Value))\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tucBarra.Visible = false;\n";
        pre_pag.InnerText += "\t\t\t\tbtNovoFiltro.Visible = false;\n";
        pre_pag.InnerText += "\t\t\t\tbtNovoFiltroGrid.Visible = false;\n";
        pre_pag.InnerText += "\t\t\t\tForm.Style.Add(\"width\", \"550\");\n";
        pre_pag.InnerText += "\t\t\t\tForm.Style.Add(\"height\", \"200\");\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tFormataControles();\n";
        pre_pag.InnerText += "\t\t\tCarregaControles();\n";
        pre_pag.InnerText += "\t\t\tCarregaDados();\n";  
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraFormataControlesAspxCs(DataSet dsPro)
    {
        pre_pag.InnerText += "\tprotected void FormataControles()\n";
        pre_pag.InnerText += "\t{\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((!drPro["Column_name"].ToString().Contains("_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_STS")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                switch (sDataType(drPro["Type"].ToString()))
                {
                    case "DateTime":
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_data();\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onBlur\", \"javascript:f_valida_data(this);\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_data();\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onBlur\", \"javascript:f_valida_data(this);\");\n";
                        break;

                    case "int":
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_numero();\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_numero();\");\n";
                        break;

                    case "double":
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_moeda();\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onBlur\", \"javascript:f_formata_valor(this);\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_moeda();\");\n";
                        pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onBlur\", \"javascript:f_formata_valor(this);\");\n";
                        break;

                    default:
                        if ((drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower().Contains("CPF")) || (drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower().Contains("cgc")))
                        {
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_numero();\");\n";
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onBlur\", \"javascript:f_consiste_cpf_cnpj(this);\");\n";
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_numero();\");\n";
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Attributes.Add(\"onBlur\", \"javascript:f_consiste_cpf_cnpj(this);\");\n";
                        }
                        if (drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower().Contains("RG"))
                        {
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onKeyPress\", \"javascript:f_filtra_teclas_numero();\");\n";
                            pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Attributes.Add(\"onBlur\", \"javascript:f_consiste_rg(this);\");\n";
                        }
                        break;
                }
            }
        }
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraCarregaControlesAspxCs(DataSet dsPro)
    {
        pre_pag.InnerText += "\tprotected void CarregaControles()\n";
        pre_pag.InnerText += "\t{\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (drPro["Column_name"].ToString().Contains("_ID")))
                {
                    string sColuna = drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").Replace("_ID","");
                    string sClasse = sDataName(sColuna).Replace(" ", "");
                    pre_pag.InnerText += "\t\t" + sClasse + " " + sClasse + " = new " + sClasse + "();\n";
                    pre_pag.InnerText += "\t\tDataSet ds" + sClasse + " = " + sClasse + ".Consultar();\n";
                    pre_pag.InnerText += "\t\tFWGNR.VerificaStatus(ds" + sClasse + ", \"" + sColuna + "_ID\", \"" + sColuna + "_DES\", \"" + sColuna + "_STS\", cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ");\n";
                    pre_pag.InnerText += "\t\tFWGNR.VerificaStatus(ds" + sClasse + ", \"" + sColuna + "_ID\", \"" + sColuna + "_DES\", \"" + sColuna + "_STS\", cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc);\n";
                    pre_pag.InnerText += "\t\tds" + sClasse + ".Dispose();\n";
                    pre_pag.InnerText += "\n";
                }
        }
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraCarregaDadosAspxCs(DataSet dsPro)
    {
        pre_pag.InnerText += "\tprotected void CarregaDados()\n";
        pre_pag.InnerText += "\t{\n";

        pre_pag.InnerText += "\t\tif (!string.IsNullOrEmpty(rowId.Value))\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tlbAcao.Text = \"Alterar\";\n";
        pre_pag.InnerText += "\t\t\tdivCadastro.Visible = true;\n";
        pre_pag.InnerText += "\t\t\tdvFiltro.Visible = false;\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\t\t\t" + sPrimeiroCampo(dsPro) + "_inc.Focus();\n";
        pre_pag.InnerText += "\n";

        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "\t\t\t" + sClasse + " " + sClasse + " = new " + sClasse + "();\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + "." + txt_tab.Text + "_ID = Convert.ToInt32(rowId.Value);\n";
        pre_pag.InnerText += "\t\t\tDataSet ds" + sClasse + " = " + sClasse + ".Consultar();\n";
        pre_pag.InnerText += "\t\t\tif (ds" + sClasse + ".Tables[0].Rows.Count > 0)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if ((drPro["Column_name"].ToString().Contains("_ID")) || (drPro["Column_name"].ToString() == txt_tab.Text + "_STS"))
                {
                    pre_pag.InnerText += "\t\t\t\tcbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.SelectedValue = ds" + sClasse + ".Tables[0].Rows[0][\"" + drPro["Column_name"].ToString() + "\"].ToString();\n";
                }
                else if (drPro["Column_name"].ToString().Contains("_STM"))
                {
                    pre_pag.InnerText += "\t\t\t\tif (ds" + sClasse + ".Tables[0].Rows[0][\"" + drPro["Column_name"].ToString() + "\"].ToString() == \"0\")\n";
                    pre_pag.InnerText += "\t\t\t\t{\n";
                    pre_pag.InnerText += "\t\t\t\t\tbtSalvar.Enabled = false;\n";
                    pre_pag.InnerText += "\t\t\t\t}\n";
                }
                else if (drPro["Column_name"].ToString().Contains("_DAT"))
                {
                    pre_pag.InnerText += "\t\t\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text = Convert.ToDateTime(ds" + sClasse + ".Tables[0].Rows[0][\"" + drPro["Column_name"].ToString() + "\"].ToString()).ToString(\"dd/MM/yyyy\");\n";
                }
                else
                {
                    pre_pag.InnerText += "\t\t\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text = ds" + sClasse + ".Tables[0].Rows[0][\"" + drPro["Column_name"].ToString() + "\"].ToString();\n";
                }
            }
        }
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\tds" + sClasse + ".Dispose();\n";
        pre_pag.InnerText += "\t\t\tDispose();\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == \"Novo\")\n";
        pre_pag.InnerText += "\t\t    {\n";
        pre_pag.InnerText += "\t\t        divCadastro.Visible = true;\n";
        pre_pag.InnerText += "\t\t        dvFiltro.Visible = false;\n";
        pre_pag.InnerText += "\t\t        dvResultado.Visible = false;\n";
        pre_pag.InnerText += "\t\t        btVoltar.Enabled = false;\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\t\t\t\t" + sPrimeiroCampo(dsPro) + "_inc.Focus();\n";

        pre_pag.InnerText += "\t\t    }\n";
        pre_pag.InnerText += "\t\t    else\n";
        pre_pag.InnerText += "\t\t    {\n";
        pre_pag.InnerText += "\t\t        divCadastro.Visible = false;\n";
        pre_pag.InnerText += "\t\t        dvFiltro.Visible = true;\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\t\t\t\t" + sPrimeiroCampo(dsPro) + ".Focus();\n";

        pre_pag.InnerText += "\t\t    }\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraFiltroProcurarAspxCs(DataSet dsPro)
    {

        pre_pag.InnerText += "\tprivate void LimpaTela()\n";
        pre_pag.InnerText += "\t{\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                {
                    pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text = \"\";\n";
                }
                else
                {
                    pre_pag.InnerText += "\t\tcbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text = \"\";\n";
                }
            }
        }

        pre_pag.InnerText += "\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                {
                    pre_pag.InnerText += "\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text = \"\";\n";
                }
                else
                {
                    pre_pag.InnerText += "\t\tcbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.SelectedIndex = 0;\n";
                }
            }
        }

        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void btNovo_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tdvResultado.Visible = false;\n";
        pre_pag.InnerText += "\t\tlbAcao.Text = \"Novo\";\n";
        pre_pag.InnerText += "\t\trowId.Value = null;\n";
        pre_pag.InnerText += "\t\tLimpaTela();\n";
        pre_pag.InnerText += "\t\tdivCadastro.Visible = true;\n";
        pre_pag.InnerText += "\t\tdvFiltro.Visible = false;\n";
        pre_pag.InnerText += "\t\t" + sPrimeiroCampo(dsPro) + "_inc.Focus();\n";

        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void btVoltar_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tdivCadastro.Visible = false;\n";
        pre_pag.InnerText += "\t\tdvResultado.Visible = false;\n";
        pre_pag.InnerText += "\t\tdvFiltro.Visible = true;\n";
        pre_pag.InnerText += "\t\t" + sPrimeiroCampo(dsPro) + ".Focus();\n";

        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void btLimpar_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tLimpaTela();\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void btFiltro_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tdvFiltro.Visible = true;\n";
        pre_pag.InnerText += "\t\tdvResultado.Visible = false;\n";
        pre_pag.InnerText += "\t\t" + sPrimeiroCampo(dsPro) + ".Focus();\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "\tprotected string CriaFiltro(" + sClasse + " " + sClasse + ")\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tstring filtro = \"\";\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                {
                    pre_pag.InnerText += "\t\tif (!String.IsNullOrEmpty(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text))\n";
                    pre_pag.InnerText += "\t\t{\n";
                    switch (sDataType(drPro["Type"].ToString()))
                    {
                        case "DateTime":
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDateTime(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text);\n";
                            break;

                        case "int":
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text);\n";
                            break;

                        case "double":
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDouble(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text);\n";
                            break;

                        default:
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text;\n";
                            break;
                    }
                    pre_pag.InnerText += "\t\t\tfiltro = filtro + \"" + sDataName(drPro["Column_name"].ToString()) + "= \" + txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text + \"; \";\n";
                    pre_pag.InnerText += "\t\t}\n";
                }
                else
                {
                    pre_pag.InnerText += "\t\tif (!String.IsNullOrEmpty(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".Text))\n";
                    pre_pag.InnerText += "\t\t{\n";
                    switch (sDataType(drPro["Type"].ToString()))
                    {
                        case "int":
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".SelectedValue);\n";
                            break;

                        default:
                            pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".SelectedValue;\n";
                            break;
                    }
                    pre_pag.InnerText += "\t\t\tfiltro = filtro + \"" + sDataName(drPro["Column_name"].ToString()) + "= \" + cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + ".SelectedItem.Text + \"; \";\n";
                    pre_pag.InnerText += "\t\t}\n";
                }
            }
        }
        pre_pag.InnerText += "\t\treturn filtro;\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    
        pre_pag.InnerText += "\tprotected void btProcurar_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tstring filtro = \"\";\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t" + sClasse + " " + sClasse + " = new " + sClasse + "();\n";
        pre_pag.InnerText += "\t\tfiltro = CriaFiltro(" + sClasse + ");\n";
        pre_pag.InnerText += "\t\tDataSet ds" + sClasse + " = " + sClasse + ".Consultar();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tgv" + sClasse + ".DataSource = ds" + sClasse + ";\n";
        pre_pag.InnerText += "\t\tgv" + sClasse + ".DataBind();\n";
        pre_pag.InnerText += "\t\tds" + sClasse + ".Dispose();\n";
        pre_pag.InnerText += "\t\tDispose();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tif (!String.IsNullOrEmpty(filtro))\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tlb_fil.Text = filtro;\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tlb_fil.Text = \"Não há filtros.\";\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tdvFiltro.Visible = false;\n";
        pre_pag.InnerText += "\t\tdvResultado.Visible = true;\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraGridViewAspxCs(DataSet dsPro)
    {
        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "\tprotected void gv" + sClasse + "_RowDataBound(object sender, GridViewRowEventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (e.Row.RowType == DataControlRowType.DataRow)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\te.Row.Attributes.Add(\"onMouseOver\", \"this.className='selecionado';\");\n";
        pre_pag.InnerText += "\t\t\tif ((e.Row.RowIndex % 2) == 0)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\te.Row.Attributes.Add(\"onMouseOut\", \"this.className='linha_par';\");\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\telse\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\te.Row.Attributes.Add(\"onMouseOut\", \"this.className='linha_impar';\");\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\tif (!string.IsNullOrEmpty(Origem.Value))\n";
        pre_pag.InnerText += "\t\t\t\te.Row.Attributes.Add(\"onClick\", \"JavaScript:retornaSelecao('\" + gv" + sClasse + ".DataKeys[e.Row.RowIndex][0].ToString() + \"', '\" + gv" + sClasse + ".DataKeys[e.Row.RowIndex][0].ToString() + \"');\");\n";
        pre_pag.InnerText += "\t\t\telse\n";
        pre_pag.InnerText += "\t\t\t\te.Row.Attributes.Add(\"onClick\", \"JavaScript:window.top.frameprincipal.location = '" + sClasse + ".aspx?rowId=\" + gv" + sClasse + ".DataKeys[e.Row.RowIndex][0].ToString() + \"'\");\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprivate SortDirection GridViewSortDirection\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tget\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tif (ViewState[\"sortDirection\"] == null)\n";
        pre_pag.InnerText += "\t\t\t\tViewState[\"sortDirection\"] = SortDirection.Ascending;\n";
        pre_pag.InnerText += "\t\t\treturn (SortDirection)ViewState[\"sortDirection\"];\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\tset { ViewState[\"sortDirection\"] = value; }\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprivate int GetSortColumnIndex()\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tforeach (DataControlField field in gv" + sClasse + ".Columns)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tif (field.SortExpression == (string)ViewState[\"SortExpression\"])\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\treturn gv" + sClasse + ".Columns.IndexOf(field);\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\treturn -1;\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprivate void AddSortImage(int columnIndex, GridViewRow headerRow)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tSystem.Web.UI.WebControls.Image sortImage = new System.Web.UI.WebControls.Image();\n";
        pre_pag.InnerText += "\t\tif (GridViewSortDirection == SortDirection.Ascending)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tsortImage.ImageUrl = \"img/arrow_down.gif\";\n";
        pre_pag.InnerText += "\t\t\tsortImage.AlternateText = \"Ordem Ascendente\";\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tsortImage.ImageUrl = \"img/arrow_up.gif\";\n";
        pre_pag.InnerText += "\t\t\tsortImage.AlternateText = \"Ordem Descendente\";\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\theaderRow.Cells[columnIndex].Controls.Add(sortImage);\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void gv" + sClasse + "_RowCreated(object sender, GridViewRowEventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (e.Row.RowType == DataControlRowType.Header)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tint sortColumnIndex = GetSortColumnIndex();\n";
        pre_pag.InnerText += "\t\t\tif (sortColumnIndex != -1)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tAddSortImage(sortColumnIndex, e.Row);\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void gv" + sClasse + "_Sorting(Object sender, GridViewSortEventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tstring Ordem = \" ASC \";\n";
        pre_pag.InnerText += "\t\tstring sortExpression = e.SortExpression;\n";
        pre_pag.InnerText += "\t\tViewState[\"SortExpression\"] = sortExpression;\n";
        pre_pag.InnerText += "\t\tif (GridViewSortDirection == SortDirection.Ascending)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tGridViewSortDirection = SortDirection.Descending;\n";
        pre_pag.InnerText += "\t\t\tOrdem = \" DESC \";\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tGridViewSortDirection = SortDirection.Ascending;\n";
        pre_pag.InnerText += "\t\t\tOrdem = \" ASC \";\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tstring filtro = \"\";\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t" + sClasse + " " + sClasse + " = new " + sClasse + "();\n";
        pre_pag.InnerText += "\t\tfiltro = CriaFiltro(" + sClasse + ");\n";
        pre_pag.InnerText += "\t\tDataSet ds" + sClasse + " = " + sClasse + ".Consultar();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tDataTable dt" + sClasse + " = ds" + sClasse + ".Tables[0];\n";
        pre_pag.InnerText += "\t\tDataView dv" + sClasse + " = new DataView(dt" + sClasse + ");\n";
        pre_pag.InnerText += "\t\tdv" + sClasse + ".Sort = e.SortExpression + Ordem;\n";
        pre_pag.InnerText += "\t\tgv" + sClasse + ".DataSource = dv" + sClasse + ";\n";
        pre_pag.InnerText += "\t\tgv" + sClasse + ".DataBind();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tdv" + sClasse + ".Dispose();\n";
        pre_pag.InnerText += "\t\tdt" + sClasse + ".Dispose();\n";
        pre_pag.InnerText += "\t\tds" + sClasse + ".Dispose();\n";
        pre_pag.InnerText += "\t\tDispose();\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraSalvarAspxCs(DataSet dsPro)
    {
        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "\tprotected void btSalvar_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tstring sMsg;\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if (drPro["Nullable"].ToString() == "no")
                {
                    if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                    {
                        pre_pag.InnerText += "\t\tif (txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text == \"\")\n";
                        pre_pag.InnerText += "\t\t{\n";
                        pre_pag.InnerText += "\t\t\tTratamentoErro(\"O campo " + sDataName(drPro["Column_name"].ToString()) + " é obrigatório.\");\n";
                        pre_pag.InnerText += "\t\t\ttxt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Focus();\n";
                        pre_pag.InnerText += "\t\t\treturn;\n";
                        pre_pag.InnerText += "\t\t}\n";
                        pre_pag.InnerText += "\n";
                    }
                    else
                    {
                        pre_pag.InnerText += "\t\tif (cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text == \"\")\n";
                        pre_pag.InnerText += "\t\t{\n";
                        pre_pag.InnerText += "\t\t\tTratamentoErro(\"O campo " + sDataName(drPro["Column_name"].ToString()) + " é obrigatório.\");\n";
                        pre_pag.InnerText += "\t\t\tcbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Focus();\n";
                        pre_pag.InnerText += "\t\t\treturn;\n";
                        pre_pag.InnerText += "\t\t}\n";
                        pre_pag.InnerText += "\n";
                    }
                }
            }
        }

        pre_pag.InnerText += "\t\t" + sClasse + " " + sClasse + " = new " + sClasse + "();\n";

        foreach (DataRow drPro in dsPro.Tables[1].Rows)
        {
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_STM")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")))
            {
                if (drPro["Nullable"].ToString() == "no")
                {
                    if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                    {
                        pre_pag.InnerText += "\t\tif (txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text != \"\")\n";
                        pre_pag.InnerText += "\t\t{\n";
                        switch (sDataType(drPro["Type"].ToString()))
                        {
                            case "DateTime":
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDateTime(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            case "int":
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            case "double":
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDouble(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            default:
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text;\n";
                                break;
                        }
                        pre_pag.InnerText += "\t\t}\n";
                    }
                    else
                    {
                        pre_pag.InnerText += "\t\tif (cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text != \"\")\n";
                        pre_pag.InnerText += "\t\t{\n";
                        switch (sDataType(drPro["Type"].ToString()))
                        {
                            case "DateTime":
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDateTime(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            case "int":
                            case "double":
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.SelectedValue);\n";
                                break;

                            default:
                                pre_pag.InnerText += "\t\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text;\n";
                                break;
                        }
                        pre_pag.InnerText += "\t\t}\n";
                    }
                }
                else
                {
                    if ((!drPro["Column_name"].ToString().Contains("_ID")) && (drPro["Column_name"].ToString() != txt_tab.Text + "_STS"))
                    {
                        switch (sDataType(drPro["Type"].ToString()))
                        {
                            case "DateTime":
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDateTime(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            case "int":
                            case "double":
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            default:
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text;\n";
                                break;
                        }
                    }
                    else
                    {
                        switch (sDataType(drPro["Type"].ToString()))
                        {
                            case "DateTime":
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToDateTime(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text);\n";
                                break;

                            case "int":
                            case "double":
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = Convert.ToInt32(cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.SelectedValue);\n";
                                break;

                            default:
                                pre_pag.InnerText += "\t\t" + sClasse + "." + drPro["Column_name"].ToString() + " = cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower() + "_inc.Text;\n";
                                break;
                        }
                    }
                }
            }
        }

        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\tif (!string.IsNullOrEmpty(rowId.Value))\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + "." + txt_tab.Text + "_ID = Convert.ToInt32(rowId.Value);\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + "." + txt_tab.Text + "_USR_ALT_ID = Convert.ToInt32(Session[\"USR_ID\"].ToString());\n";
        pre_pag.InnerText += "\t\t\tsMsg = " + sClasse + ".Alterar();\n";
        pre_pag.InnerText += "\t\t\tif (sMsg != \"\")\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tResponse.Redirect(\"Erro.aspx?Erro=\"+sMsg);\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\telse\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tTratamentoErro(\"" + sClasse + " alterado com sucesso.\");\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + " " + txt_tab.Text + " = new " + sClasse + "();\n";
        pre_pag.InnerText += "\t\t\t//Verificar se já não existe um cadastro consultando o: " + txt_tab.Text + "_DES \n";
        pre_pag.InnerText += "\t\t\t" + txt_tab.Text + "." + txt_tab.Text + "_DES = txt_des_inc.Text;\n";
        pre_pag.InnerText += "\t\t\tDataSet ds" + txt_tab.Text + " = " + txt_tab.Text + ".Consultar();\n";
        pre_pag.InnerText += "\t\t\tif (ds" + txt_tab.Text + ".Tables[0].Rows.Count > 0)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tTratamentoErro(\"Esse " + sClasse + " já está cadastrado.\");\n";
        pre_pag.InnerText += "\t\t\t\t" + sPrimeiroCampo(dsPro) + "_inc.Focus();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\t\treturn;\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\t" + sClasse + "." + txt_tab.Text + "_USR_INC_ID = Convert.ToInt32(Session[\"USR_ID\"].ToString());\n";
        pre_pag.InnerText += "\t\t\tsMsg = " + sClasse + ".Inserir();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tif (sMsg.Substring(0, 1) == \"E\")\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tResponse.Redirect(\"Erro.aspx?Erro=\" + sMsg);\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\telse\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\trowId.Value = sMsg;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\t\tTratamentoErro(\"" + sClasse + " inserido com sucesso.\");\n";
        pre_pag.InnerText += "\t\t\t\tif (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == \"Novo\")\n";
        pre_pag.InnerText += "\t\t\t\t\tScriptManager.RegisterClientScriptBlock(this, GetType(), \"alertaOrigem\", \"window.close();\", true);\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\t\t\tds" + txt_tab.Text + ".Dispose();\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\tDispose();\n";
        pre_pag.InnerText += "\t\tdivCadastro.Visible = false;\n";
        pre_pag.InnerText += "\t\tdvFiltro.Visible = true;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\trowId.Value = null;\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
    }

    protected void GeraRodapeAspxCs()
    {
        string sClasse = sDataName(txt_tab.Text);

        pre_pag.InnerText += "\tprivate void TratamentoErro(string erro)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (!string.IsNullOrEmpty(erro))\n";
        pre_pag.InnerText += "\t\t\tScriptManager.RegisterClientScriptBlock(this, GetType(), \"AlertErro\", \"alert('\" + erro + \"');\", true);\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";

        pre_pag.InnerText += "\tprotected void lkb_pdf_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (gv" + sClasse + ".Rows.Count > 0)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tResponse.Clear();\n";
        pre_pag.InnerText += "\t\t\tResponse.ContentEncoding = System.Text.Encoding.GetEncoding(\"ISO-8859-1\");\n";
        pre_pag.InnerText += "\t\t\tResponse.ContentType = \"application/pdf\";\n";
        pre_pag.InnerText += "\t\t\tResponse.AddHeader(\"content-disposition\", \"attachment;filename=Historico.pdf\");\n";
        pre_pag.InnerText += "\t\t\t// Sem a opção de Salvar\n";
        pre_pag.InnerText += "\t\t\t// Response.Cache.SetCacheability(HttpCacheability.NoCache);\n";
        pre_pag.InnerText += "\t\t\tStringWriter stringWrite = new StringWriter();\n";
        pre_pag.InnerText += "\t\t\tHtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".AllowSorting = false;\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".AllowPaging = false;\n";
        pre_pag.InnerText += "\t\t\t//gv" + sClasse + ".DataBind();\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\t// Deixar cabeçalho em branco/preto, sem links e imagens\n";
        pre_pag.InnerText += "\t\t\tfor (int i = 0; i < gv" + sClasse + ".HeaderRow.Cells.Count; i++)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tLinkButton lnk = (LinkButton)gv" + sClasse + ".HeaderRow.Cells[i].Controls[0];\n";
        pre_pag.InnerText += "\t\t\t\tlnk.Enabled = false;\n";
        pre_pag.InnerText += "\t\t\t\tlnk.BackColor = System.Drawing.Color.White;\n";
        pre_pag.InnerText += "\t\t\t\tlnk.ForeColor = System.Drawing.Color.Black;\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".RenderControl(htmlWrite);\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tStringReader stringReader = new StringReader(stringWrite.ToString());\n";
        pre_pag.InnerText += "\t\t\tDocument pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);\n";
        pre_pag.InnerText += "\t\t\tHTMLWorker htmlParser = new HTMLWorker(pdfDocument);\n";
        pre_pag.InnerText += "\t\t\tPdfWriter.GetInstance(pdfDocument, Response.OutputStream);\n";
        pre_pag.InnerText += "\t\t\tpdfDocument.Open();\n";
        pre_pag.InnerText += "\t\t\thtmlParser.Parse(stringReader);\n";
        pre_pag.InnerText += "\t\t\tpdfDocument.Close();\n";
        pre_pag.InnerText += "\t\t\tResponse.Write(pdfDocument);\n";
        pre_pag.InnerText += "\t\t\tResponse.End();\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tScriptManager.RegisterClientScriptBlock(this, GetType(), \"alerta\", \"alert('Não há registros para exportação !');\", true);\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\tprotected void lkb_xls_Click(object sender, EventArgs e)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\t\tif (gv" + sClasse + ".Rows.Count > 0)\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tResponse.Clear();\n";
        pre_pag.InnerText += "\t\t\tResponse.ContentEncoding = System.Text.Encoding.GetEncoding(\"ISO-8859-1\");\n";
        pre_pag.InnerText += "\t\t\tResponse.ContentType = \"application/vnd.ms-excel\";\n";
        pre_pag.InnerText += "\t\t\tResponse.AddHeader(\"content-disposition\", \"attachment;filename=Historico.xls\");\n";
        pre_pag.InnerText += "\t\t\t//Sem a opção de Salvar\n";
        pre_pag.InnerText += "\t\t\t//Response.Cache.SetCacheability(HttpCacheability.NoCache);\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tStringWriter stringWrite = new StringWriter();\n";
        pre_pag.InnerText += "\t\t\tHtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".AllowSorting = false;\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".AllowPaging = false;\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\t// Deixar cabeçalho em branco/preto, sem links e imagens\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tfor (int i = 0; i < gv" + sClasse + ".HeaderRow.Cells.Count; i++)\n";
        pre_pag.InnerText += "\t\t\t{\n";
        pre_pag.InnerText += "\t\t\t\tLinkButton lnk = (LinkButton)gv" + sClasse + ".HeaderRow.Cells[i].Controls[0];\n";
        pre_pag.InnerText += "\t\t\t\tlnk.Enabled = false;\n";
        pre_pag.InnerText += "\t\t\t\tlnk.BackColor = System.Drawing.Color.White;\n";
        pre_pag.InnerText += "\t\t\t\tlnk.ForeColor = System.Drawing.Color.Black;\n";
        pre_pag.InnerText += "\t\t\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tgv" + sClasse + ".RenderControl(htmlWrite);\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t\t\tResponse.Write(stringWrite.ToString());\n";
        pre_pag.InnerText += "\t\t\tResponse.End();\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t\telse\n";
        pre_pag.InnerText += "\t\t{\n";
        pre_pag.InnerText += "\t\t\tScriptManager.RegisterClientScriptBlock(this, GetType(), \"alerta\", \"alert('Não há registros para exportação !');\", true);\n";
        pre_pag.InnerText += "\t\t}\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\tpublic override void VerifyRenderingInServerForm(Control control)\n";
        pre_pag.InnerText += "\t{\n";
        pre_pag.InnerText += "\n";
        pre_pag.InnerText += "\t}\n";
        pre_pag.InnerText += "}\n";
        pre_pag.InnerText += "\n";
    }

    protected string sDataName(string sName)
    {
        string sReturn = "";
        string sConnectionString = "";
        sConnectionString = "Data Source=" + txt_srv.Text + ";";
        sConnectionString += "Initial Catalog=" + txt_bco.Text + ";";
        //sConnectionString += "Initial Catalog=FWGLO_PRC;";
        sConnectionString += "User ID=" + txt_usr.Text + ";";
        //sConnectionString += "User ID=FWGLO_PRC;";
        sConnectionString += "Password=" + txt_snh.Text + ";";
        //sConnectionString += "Password=FWGLO_PRC;";

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
            if ((drPro["Column_name"].ToString() != txt_tab.Text + "_ID") &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_INC_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_USR_ALT_ID")) &&
                (!drPro["Column_name"].ToString().EndsWith("_TMS_ATL")) &&
                (!drPro["Column_name"].ToString().Contains("_STM")))
            {
                if ((drPro["Column_name"].ToString().Contains("_ID")) || (drPro["Column_name"].ToString() == txt_tab.Text + "_STS"))
                {
                    return "cbo_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower();
                }
                else
                {
                    return "txt_" + drPro["Column_name"].ToString().Replace(txt_tab.Text + "_", "").ToLower();
                }
            }
        }
        return "";
}
}

