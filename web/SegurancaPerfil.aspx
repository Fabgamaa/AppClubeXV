<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SegurancaPerfil.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - Fourway Framework
Arquivo			: SegurancaPerfil.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Lista de Perfil
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
    <form id="frmPerfil" runat="server" defaultfocus="txt_des" defaultbutton="btProcurar">
	<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
	<input type="hidden" name="MNU_ID" value="<%=Request.QueryString["MNU_ID"]%>" />
    <div style="left:5px">
    <div runat="server" id="dvFiltro" visible="true">
	<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
		<tr>
			<td colspan="2" class="font_titulo_grd" style="width:780px">
    			Pesquisar Perfil
		        <asp:HyperLink ID="Msg" runat="server" ForeColor="Red"></asp:HyperLink>
			</td>
		</tr>
		<tr>
			<td colspan="2">&nbsp;</td>
		</tr>
		<tr>
			<td colspan="2" class="font_body">Descrição </td>
		</tr>
		<tr>
			<td colspan="2"><asp:TextBox id="txt_des" runat="server" CssClass="text_box"  maxlength="50" style="width:500px"></asp:TextBox></td>
		</tr>
        <tr>
	        <td colspan="2" class="font_body" style="width:190px">Perfil Responsável </td>
        </tr>
        <tr>
	        <td colspan="2">
	            <asp:DropDownList ID="cbo_pfl_rsp" runat="server" CssClass="combo_box">
                    <asp:ListItem value="" Text=""></asp:ListItem>
	            </asp:DropDownList>        
	        </td>
        </tr>
        <tr>
	        <td colspan="2" class="font_body" style="width:190px">Status </td>
        </tr>
        <tr>
	        <td colspan="2">
	            <asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box" style="width:100px;">
                    <asp:ListItem value="" Text=""></asp:ListItem>
                    <asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
			        <asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
	            </asp:DropDownList>        
	        </td>
        </tr>
		<tr>
			<td colspan="2"><br/>
	            <asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;
	            <asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" /> &nbsp;&nbsp;
	            <asp:Button ID="btNovoFiltro" runat="server" CssClass="botao" Text="Novo"  PostBackUrl="CadastroPerfil.aspx" />
			</td>
		</tr>
	</table>
    </div>
    <div runat="server" id="dvResultado" visible="false">
	    <table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	    <tr>
		    <td colspan="2" class="font_titulo_grd" style="width:780px">Pesquisar Perfil</td>
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
		    <td colspan="2">
	            <asp:Button ID="btNovoLista"   runat="server" CssClass="botao" Text="Novo"   PostBackUrl="CadastroPerfil.aspx"/> &nbsp;&nbsp;
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
                <asp:GridView Width="760px" CausesValidation="False"  ID="gvPerfil" DataKeyNames="PFL_ID" 
                        runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                        OnRowDataBound="gvPerfil_RowDataBound"  OnSorting="gvPerfil_Sorting"
                        OnRowCreated="gvPerfil_RowCreated"
                        EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
                    <Columns>
                        <asp:TemplateField HeaderText=" Descrição " SortExpression="PFL_DES" ControlStyle-Width="330px" >
                            <ItemTemplate>
                                <asp:Label ID="lbPFL_DES" runat="server" Text='<%# Eval("PFL_DES") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Perfil Responsável " SortExpression="PFL_PFL_RSP_DES" ControlStyle-Width="330px" >
                            <ItemTemplate>
                                <asp:Label ID="lbPFL_PFL_RSP_DES" runat="server" Text='<%# Eval("PFL_PFL_RSP_DES") %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Status " SortExpression="PFL_STS" ControlStyle-Width="100px" >
                            <ItemTemplate>
                                <asp:Label ID="lbPFL_STS" runat="server" Text='<%# ((int)Eval("PFL_STS") == 1)?"ATIVO":"INATIVO" %>'/>
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
