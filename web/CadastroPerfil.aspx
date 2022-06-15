<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroPerfil.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - Fourway Framework
Arquivo			: CadastroPerfil.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Cadastro de Perfil
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
    <form id="frmCadastroPerfil" runat="server" defaultfocus="txt_des">
	<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
	<asp:HiddenField runat="server" ID="MNU_ID" />
	<asp:HiddenField runat="server" ID="PFL_ID" />
    <div style="left:5px">
    	    <table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	        <tr>
		        <td colspan="4" class="font_titulo_grd" style="width:780px">
		            <asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
		            Perfil
    		        <asp:HyperLink ID="Msg" runat="server" ForeColor="Red"></asp:HyperLink>
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td colspan="4" class="font_body" style="width:190px">Descrição </td>
	        </tr>
	        <tr>
		        <td colspan="4">
		            <asp:TextBox runat="server" ID="txt_des" CssClass="text_box" style="width:500px" maxlength="50"/> *
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4" class="font_body" style="width:190px" >Perfil Responsável </td>
	        </tr>
	        <tr>
		        <td colspan="4">
		            <asp:DropDownList ID="cbo_pfl_rsp" runat="server" CssClass="combo_box">
		            </asp:DropDownList>
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4" class="font_body" style="width:190px" >Status </td>
	        </tr>
	        <tr>
		        <td colspan="4">
		            <asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box" style="width:100px;">
                        <asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				        <asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
		            </asp:DropDownList> *
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
            <tr>
	            <td colspan="4">
    		        <asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" OnClick="btSalvar_Click"/> &nbsp;&nbsp;
    		        <asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" PostBackUrl="SegurancaPerfil.aspx"/> &nbsp;&nbsp;
    		        <asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" OnClick="btNovo_Click" />
	            </td>
            </tr>

        </table>
        </div>
    </form>
</body>
</html>
