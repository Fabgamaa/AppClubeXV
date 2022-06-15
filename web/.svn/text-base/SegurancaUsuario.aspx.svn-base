<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SegurancaUsuario.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="uc2" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWADV (Innocenti)
Arquivo			: SegurancaUsuario.aspx
Criado em		: 07/08/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Lista de Usuários
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title> 
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
    <form id="frmUsuario" runat="server" defaultfocus="txt_cod" defaultbutton="btProcurar">
	<uc2:Barra ID="ucBarra" runat="server"></uc2:Barra>
	<input type="hidden" name="MNU_ID" value="<%=Request.QueryString["MNU_ID"]%>" />
    <div runat="server" id="dvFiltro" visible="true">
	<table style="width:780" align="center" border="0" cellspacing="4" cellpadding="0">
		<tr>
			<td style="width:5" rowspan="15"></td>
		</tr>
		<tr>
			<td colspan="2" class="font_titulo_grd" style="width:800">Pesquisar Usuários</td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Login </td>
		</tr>
		<tr>
			<td colspan="2">
			    <asp:TextBox ID="txt_cod" runat="server" CssClass="text_box" MaxLength="20" Width="146px"></asp:TextBox>
            </td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Nome </td>			
		</tr>
		<tr>
			<td colspan="2">
			    <asp:TextBox ID="txt_nom" runat="server" CssClass="text_box" MaxLength="50" Width="376px"></asp:TextBox>
            </td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Perfil </td>			
		</tr>
		<tr>
		    <td colspan="2">
		        <asp:DropDownList ID="cbo_pfl" runat="server" CssClass="combo_box">
		        </asp:DropDownList>
		    </td>
		</tr>
		<tr>
			<td colspan="2"><br/>	    
			    <asp:Button ID="btProcurar" runat="server" CssClass="botao" Text="Listar" onclick="btProcurar_Click" />
                &nbsp;<asp:Button ID="btLimpar" runat="server" CssClass="botao" Text="Limpar" onclick="btLimpar_Click" />
                &nbsp;<asp:Button ID="btNovo" runat="server" CssClass="botao" Text="Novo" PostBackUrl="CadastroUsuario.aspx" />	            
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
		    <td colspan="2" class="font_titulo_grd" style="width:800">Pesquisar Usuários</td>
	    </tr>
	    <tr>
		    <td colspan="6">&nbsp;</td>
	    </tr>
	    <tr>
		    <td colspan="6" align="right" class="font_body" style="width:800">
    	        <asp:Label runat="server" ID="lb_fil" />&nbsp;
		    </td>
	    </tr>
	    <tr>
		    <td colspan="2">&nbsp;</td>
	    </tr>
	    <tr>
		    <td>
	            <asp:Button ID="btNovo2" runat="server" CssClass="botao" PostBackUrl="CadastroUsuario.aspx" Text="Novo" />&nbsp;
                <asp:Button ID="btFiltro" runat="server" CssClass="botao" Text="Filtro" onclick="btFiltro_Click" />
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
                <asp:GridView Width="760px" CausesValidation="False"  ID="gvUsuario" DataKeyNames="USR_ID" 
                        runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                        OnRowDataBound="gvUsuario_RowDataBound"  OnSorting="gvUsuario_Sorting"
                        OnRowCreated="gvUsuario_RowCreated"
                        EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
                    <Columns>
                        <asp:TemplateField HeaderText=" Login " SortExpression="USR_COD" ControlStyle-Width="100px" >
                            <ItemTemplate>
                                <asp:Label ID="lbUSR_COD" runat="server" Text='<%# Eval("USR_COD") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Nome " SortExpression="USR_NOM" ControlStyle-Width="380px" >
                            <ItemTemplate>
                                <asp:Label ID="lbUSR_NOM" runat="server" Text='<%# Eval("USR_NOM") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Perfil " SortExpression="PFL_DES" ControlStyle-Width="200px" >
                            <ItemTemplate>
                                <asp:Label ID="lbPFL_DES" runat="server" Text='<%# Eval("PFL_DES") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
			            <asp:TemplateField HeaderText=" Status " SortExpression="USR_STS" ControlStyle-Width="40px" >
			            <ItemTemplate>
				            <asp:Label ID="lbUSR_STS" runat="server" Text='<%# (Eval("USR_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
    </form>
</body>
</html>
