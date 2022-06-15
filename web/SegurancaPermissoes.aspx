<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SegurancaPermissoes.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: SegurancaPermissoes.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Lista de Perfil x Menu
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
    <form id="frmMenu" runat="server" defaultfocus="cbo_pfl" defaultbutton="btProcurar">
	<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
	<input type="hidden" name="MNU_ID" value="<%=Request.QueryString["MNU_ID"]%>" />
    <div style="left:5px">
    <div runat="server" id="dvFiltro" visible="true">
	<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
		<tr>
			<td colspan="2" class="font_titulo_grd" style="width:780px">Pesquisar Permissões do Perfil</td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Perfil </td>
		</tr>
		<tr>
			<td colspan="2">
			    <asp:DropDownList ID="cbo_pfl" runat="server" CssClass="combo_box" style="width:180px;">
                    <asp:ListItem value="" Text=""></asp:ListItem>
	            </asp:DropDownList> 
	        </td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Menu </td>			
		</tr>
		<tr>
			<td colspan="2">
			    <asp:DropDownList ID="cbo_mnu" runat="server" cssClass="combo_box">
                    <asp:ListItem value="" Text=""></asp:ListItem>
                </asp:DropDownList>
			</td>
		</tr>
		<tr>
			<td colspan="2"><br/>
	            <asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;
	            <asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" /> &nbsp;&nbsp;
			</td>
		</tr>
	</table>
    </div>
    <div runat="server" id="dvResultado" visible="false">
	    <table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	    <tr>
		    <td colspan="2" class="font_titulo_grd" style="width:800">Pesquisar Permissões do Perfil</td>
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body" style="width:780px" align="right">
    	        <asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;
		    </td>
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
	    <tr>
		    <td>
	            <asp:Button ID="btFiltro"      runat="server" CssClass="botao" Text="Filtro" OnClick="btFiltro_Click"/>
		    </td> 
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
        <tr>
            <td colspan="2" style="height:30"></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblSortLogin" runat="server" Visible="False" Text="ASC"></asp:Label>
                <asp:GridView Width="760px" CausesValidation="False"  ID="gvPerfilMenu" DataKeyNames="PFL_MNU_PFL_ID" 
                        runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                        OnRowDataBound="gvPerfilMenu_RowDataBound"  OnSorting="gvPerfilMenu_Sorting"
                        OnRowCreated="gvPerfilMenu_RowCreated"
                        EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
                    <Columns>
                        <asp:TemplateField HeaderText=" Perfil " SortExpression="PFL_DES" ControlStyle-Width="150px" >
                            <ItemTemplate>
                                <asp:Label ID="lbPFL_DES" runat="server" Text='<%# Eval("PFL_DES") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Menu " SortExpression="MNU_TIT" ControlStyle-Width="200px" >
                            <ItemTemplate>
                                <asp:Label ID="lbMNU_TIT" runat="server" Text=' ' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                    </Columns>
            
                    <AlternatingRowStyle CssClass="linha_impar" />
                    <RowStyle CssClass="linha_par" />
                    <SelectedRowStyle CssClass="selecionado" />
                    <HeaderStyle CssClass="cabecalho_tabela" />
                    <EmptyDataRowStyle CssClass="font_body" />
                </asp:GridView>
	        </td>
	    </tr>
	    </table>
    
    </div>    
    </div>    
    </form>
</body>
</html>
