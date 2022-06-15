<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SegurancaFuncao.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="uc2" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: SegurancaFuncao.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Lista de Funções
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
    <form id="frmPerfil" runat="server" defaultfocus="txt_des" defaultbutton="btProcurar">
	<uc2:Barra ID="ucBarra" runat="server"></uc2:Barra>
	<input type="hidden" name="MNU_ID" value="<%=Request.QueryString["MNU_ID"]%>" />
    <div runat="server" id="dvFiltro" visible="true">
	<table style="width:780" align="center" border="0" cellspacing="4" cellpadding="0">
		<tr>
			<td style="width:5" rowspan="15"></td>
		</tr>
		<tr>
			<td colspan="2" class="font_titulo_grd">Pesquisar Função</td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Descrição </td>
		</tr>
		<tr>
			<td colspan="2"><asp:TextBox runat="server" id="txt_des" cssclass="text_box"  maxlength="50" style="width:300px"></asp:TextBox></td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Status </td>
		</tr>
		<tr>
			<td colspan="2">
			    <asp:DropDownList runat="server" ID="cb_sts" CssClass="combo_box">
			        <asp:ListItem>ATIVO</asp:ListItem>
			        <asp:ListItem>INATIVO</asp:ListItem>
			    </asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td colspan="2"><br/>
			    
	            <asp:Button runat="server" ID="btProcurar" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" />
	            <input type="reset" id="btLimpar" class="botao" value="Limpar" />
	            <asp:Button runat="server" ID="btNovo" CssClass="botao" Text="Novo" PostBackUrl="CadastroFuncao.aspx" />
	            
			</td>
		</tr>
	</table>
    </div>
    <div runat="server" id="dvResultado" visible="false">
	    <table style="width:780" align="center" border="0" cellspacing="4" cellpadding="0">
		<tr>
			<td style="width:5" rowspan="15"></td>
		</tr>
	    <tr>
		    <td colspan="2" class="font_titulo_grd" style="width:800">Lista de Função</td>
	    </tr>
	    <tr>
		    <td colspan="6">&nbsp;</td>
	    </tr>
	    <tr>
		    <td colspan="6" align="right" class="font_body" style="width:800">Não há filtros&nbsp;
    	        <asp:Label runat="server" ID="lb_fil" />&nbsp;
		    </td>
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
	    <tr>
		    <td>
	            <asp:Button runat="server" ID="btNovo2" CssClass="botao" Text="Novo"  PostBackUrl="CadastroFuncao.aspx"  />
	            <asp:Button runat="server" ID="btFiltro" CssClass="botao" Text="Filtro" OnClick="btFiltro_Click" />
		    </td> 
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
        <tr>
            <td colspan="2" style="height:30"></td>
        </tr>
        <tr>
            <td>
            <table width="100%">
            <tr>
                <td class="cabecalho_tabela" align="center" style="height:20px">Descrição </td>
                <td class="cabecalho_tabela" align="center" style="height:20px">Observações</td>
            </tr>
            <tr class="linha_impar" id="linha1" style="cursor:hand" onclick="JavaScript:window.top.frameprincipal.location = 'CadastroFuncao.aspx?USR_ID=1';">    
                <td onmouseover="JavaScript:MudaCor('linha1')" onmouseout="JavaScript:VoltaCor('linha1', 'linha_impar')">Visualizar Status no Relatório de Intimação / Publicação</td>    
                <td onmouseover="JavaScript:MudaCor('linha1')" onmouseout="JavaScript:VoltaCor('linha1', 'linha_impar')">Função que permite a visualização de status Distribuido no Relatório de Intimação / Publicação</td>
            </tr>
	        </table>
	        </td>
	    </tr>
	    </table>
    
    </div>    
    </form>
</body>
</html>
