<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SemPermissao.aspx.cs" Inherits="SemPermissao" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: SemPermissao.aspx
Criado em		: 30/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Alteração de Senha
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<head id="Head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
    <form id="frmSemPermissao" runat="server">
	<asp:HiddenField runat="server" ID="MNU_ID" />
    <uc2:Barra ID="ucBarra" runat="server"></uc2:Barra>
    <table width="100%">
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="destaque_red" align="center">Permissão Negada!</td>
        </tr>
    </table>
    
    </form>
</body>
</html>
