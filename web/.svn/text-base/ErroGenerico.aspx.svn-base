<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErroGenerico.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="uc1" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: ErroGenerico.aspx
Criado em		: 21/01/2009
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Mostrar Erros do Sistema
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<head>
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<title></title>
</head>

<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<form runat="server" ID="frmErro" method="post" action="ErroGenerico.aspx">
    <uc1:Barra ID="Barra1" runat="server"></uc1:Barra>
	<input type="hidden" name="MNU_ID" value="<%=Request.QueryString["MNU_ID"]%>"/>
    <table style="width:780" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
        <tr>
	        <td style="width:5" rowspan="30"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="destaque_red" colspan="2">
                Houve um erro no Sistema, copie as informações abaixo e encaminhe para o responsável pelo suporte.
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="font_body_destaque">Mensagem:</td>
            <td class="font_body" ><asp:Label runat="server" ID="lbMsgErro"></asp:Label></td>
        </tr>
        <tr>
            <td class="font_body_destaque">URL:</td>
            <td class="font_body" ><asp:Label runat="server" ID="lbURL"></asp:Label></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="font_body_destaque"><asp:Label runat="server" ID="lbtitLog"></asp:Label></td>
            <td class="font_body" ><asp:Label runat="server" ID="lbLog"></asp:Label></td>
        </tr>
    </table>
</form>	
</body>	

</html>
