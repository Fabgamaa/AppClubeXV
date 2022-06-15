<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroUsuario.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra" %>
<%@ Register Src="Endereco.ascx" TagName="Endereco" TagPrefix="ucEndereco" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: CadastroUsuario.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Cadastro de Usuários
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
    <form id="formCadastroUsuario" runat="server" defaultfocus="txt_cod">
	<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
	<asp:HiddenField ID="MNU_ID" runat="server" />
	<asp:HiddenField ID="USR_ID" runat="server" />
	<asp:HiddenField ID="SNH_ANE" runat="server" />
	<asp:HiddenField ID="USR_NUM_TTT" runat="server" />
	<asp:HiddenField ID="USR_SNH_ANE" runat="server" />
    <div style="left:5px">
	    <table style="width:780" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	        <tr>
		        <td colspan="4" class="font_titulo_grd" style="width:780px">
		            <asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
		            Usuário
    		        <asp:HyperLink ID="Msg" runat="server" ForeColor="Red"></asp:HyperLink>
		            <asp:Label ID="UsuBloqueado" runat="server" Visible="false" CssClass="font_body_red">
		            <br /><br />Usuário Bloqueado
		            <br />* Utilize o botão desbloquear para permitir o acesso ao usuário.</asp:Label>
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td class="font_body">Login </td>
		        <td class="font_body">Senha </td>
		        <td class="font_body">Data de Expiração da Senha </td>
		        <td></td>
	        </tr>
	        <tr>
		        <td>
		            <asp:TextBox runat="server" ID="txt_cod" CssClass="text_box" style="width:153px" maxlength="20"/> *
		        </td>
		        <td>
			        <asp:TextBox runat="server" ID="txt_snh" cssClass="text_box" style="width:153px" maxlength="20"/> *
		        </td>
	            <td>
		            <asp:TextBox runat="server" ID="txt_dat_exi" CssClass="text_box" style="width:100px" maxlength="10"/> 
		        </td>
		        <td></td>
	        </tr>
	        <tr>
		        <td colspan="2" class="font_body">Perfil </td>
		        <td colspan="2" class="font_body">Status </td>
	        </tr>
	        <tr>
		        <td colspan="2">
		           <asp:DropDownList ID="cbo_pfl" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_pfl_SelectedIndexChanged" AutoPostBack="true">
		            </asp:DropDownList> *
		        </td>
		        <td colspan="2">
		            <asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">
                        <asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				        <asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
		            </asp:DropDownList> 
		        </td>
	        </tr>
	        <tr>
	            <td class="font_body" colspan="4">Página Inicial </td>
	        </tr>	        
	        <tr>
	            <td colspan="4">
		            <asp:DropDownList runat="server" ID="cbo_pgn_ini" CssClass="combo_box">
		            </asp:DropDownList>
		        </td>
	        </tr>	        
	        <tr>
		        <td class="font_body" colspan="4">Nome </td>
	        </tr>
	        <tr>
		        <td colspan="4">
		            <asp:TextBox runat="server" ID="txt_nom" cssClass="text_box" style="width:433px" maxlength="50"/> *
		        </td>
	        </tr>
	        <tr>
		        <td class="font_body" colspan="4">Email</td>
	        </tr>
	        <tr>		
		        <td colspan="4">
			        <asp:TextBox runat="server" ID="txt_eml" cssclass="text_box" style="width:433px" maxlength="50"/>
		        </td>
	        </tr>

        	<tr>
	            <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
	            <td colspan="4">
    		        <asp:Button ID="btSalvar"      runat="server" Text="Salvar"      CssClass="botao" OnClick="btSalvar_Click"/> &nbsp;&nbsp;
    		        <asp:Button ID="btVoltar"      runat="server" Text="Filtro"      CssClass="botao" PostBackUrl="SegurancaUsuario.aspx"/> &nbsp;&nbsp;
    		        <asp:Button ID="btNovo"        runat="server" Text="Novo"        CssClass="botao" OnClick="btNovo_Click" /> &nbsp;&nbsp;
    		        <asp:Button ID="btDesbloquear" runat="server" Text="Desbloquear" CssClass="botao" OnClick="btDesbloquear_Click" Visible="false"/>
	            </td>
            </tr>

        </table>
        </div>
    </form>
</body>
</html>
