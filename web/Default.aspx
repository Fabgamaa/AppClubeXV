 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_Default" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Gama
Sistema			: XV 
Arquivo			: Default.aspx
Criado em		: 20/05/2022
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Default (Login)
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<head>
    <title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
    <link rel="stylesheet" type="text/css" href="css/FW.css"/>
</head>
<body>
    <form runat="server" action="" id="frm_login" defaultfocus="txt_nom_usr">
        <table border="0" style="width:400" align="center">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center"><img alt="" src="img/logoxv1.png" style="height: 193px; width: 393px"/></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="fundo_claro" style="width:400" align="center">
            <tr>
                <td colspan="3" class="cabecalho_tabela" style="text-decoration: none" align="center">Login</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width:145px" class="font_body" align="right">Login:</td>
                <td style="width:15px">&nbsp;</td>
                <td><asp:TextBox runat="server" id="txt_nom_usr" width="200px" CssClass="text_box" Text="" />
                <asp:Label runat="server" ForeColor="red" ID="ObLogin"></asp:Label></td>
            </tr>
            <tr>
                <td class="font_body" align="right">Senha:</td>
                <td style="width:15px">&nbsp;</td>
                <td><asp:TextBox Textmode="Password" runat="server" id="txt_snh" width="200px" CssClass="text_box" Text="" />
                <asp:Label runat="server" ForeColor="red" ID="ObSenha"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style=" text-align:center"><asp:Label runat="server" ForeColor="red" ID="Msg"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Button runat="server" ID="bt_log" Text="Login" CssClass="botao" OnClick="bt_log_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>



