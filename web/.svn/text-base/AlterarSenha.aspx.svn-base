<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AlterarSenha.aspx.cs" Inherits="AlterarSenha" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="uc2" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: AlterarSenha.aspx
Criado em		: 30/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Alteração de Senha
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
    <form id="frmAlterarSenha" runat="server">
	<asp:HiddenField runat="server" ID="MNU_ID" />
    <uc2:Barra ID="ucBarra" runat="server"></uc2:Barra>
    
    <asp:Panel runat="server" ID="pnAlteraLogin">
        <table border="0" style="width:400px" align="center">
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td align="center"><img src="img/logo.jpg"/></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
        
        <table class="fundo_claro" style="width:400px" align="center">
            <tr>
                <td colspan="3" class="cabecalho_tabela" style="text-decoration: none" align="center">Alterar Senha</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr class="font_body">
                <td style="width:145px" class="font_body" align="right">Senha Atual:</td>
                <td style="width:15px">&nbsp;</td>
                <td><asp:TextBox TextMode="Password" runat="server" ID="txt_snh_atu" CssClass="text_box" MaxLength="20" style="width:153px"  /> *</td>
            </tr>
            <tr class="font_body">
                <td class="font_body" align="right">Nova Senha:</td>
                <td style="width:15px">&nbsp;</td>
                <td>
                <asp:TextBox TextMode="Password" runat="server" ID="txt_snh_nov" CssClass="text_box" MaxLength="20" style="width:153px"  /> *</td>
            </tr>
            <tr class="font_body">
                <td class="font_body" align="right">Confirmar Nova Senha:</td>
                <td style="width:15px">&nbsp;</td>
                <td><asp:TextBox TextMode="Password" runat="server" ID="txt_snh_conf" CssClass="text_box" MaxLength="20" style="width:153px"  /> *</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" style=" text-align:center">
                <asp:HyperLink runat="server" ForeColor="Red" ID="Msg"></asp:HyperLink>
                <asp:Label runat="server" ForeColor="red" ID="Msg2"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Button runat="server" ID="btSalvar" Text="Salvar" CssClass="botao" OnClick="btSalvar_Click"/>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    </form>
</body>
</html>
