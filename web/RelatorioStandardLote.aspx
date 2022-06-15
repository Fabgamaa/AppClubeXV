<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioStandardLote.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioStandardLote.aspx 
Criado em         : 11/04/2012
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Standard Lote
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmStandard" runat="server" action="RelatorioStandardLote.aspx">
<asp:HiddenField ID="Origem" runat="server" />
<asp:HiddenField ID="rowId" runat="server" />
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Relatório de Standard Lote
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data Inicial</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat_ini" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data Final</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Tipo de Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_maq_tip_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" />
		</td>
	</tr>
</table>
</div>
<div runat="server" id="dvResultado" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td class="font_titulo_grd" style="width:780px">
			Relatório de Standard Lote
		</td>
	</tr>
	<tr>
		<td class="font_body" style="width:780px" align="right">
			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td align="right">
			<asp:LinkButton ID="lkb_pdf" runat="server" OnClick="lkb_pdf_Click" Text="pdf" ToolTip="Exporta para PDF"></asp:LinkButton>
			&nbsp;
			<asp:LinkButton ID="lkb_xls" runat="server" OnClick="lkb_xls_Click" Text="xls" ToolTip="Exporta para XLS"></asp:LinkButton>
		</td>
	</tr>
	<tr>
		<td>
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvStandard" DataKeyNames="EPF_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvStandard_RowDataBound"  OnSorting="gvStandard_Sorting"
				OnRowCreated="gvStandard_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Lote " SortExpression="EPF_LOT" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_LOT" runat="server" Text='<%# Eval("EPF_LOT") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Disposição " SortExpression="EPF_DSB" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_DSB" runat="server" Text='<%# Eval("EPF_DSB") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Disco " SortExpression="EPF_TIP" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_TIP" runat="server" Text='<%# Eval("EPF_TIP") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Buse 1 " SortExpression="EPF_1TB" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_1TB" runat="server" Text='<%# Eval("EPF_1TB") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Buse 2 " SortExpression="EPF_2TB" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_2TB" runat="server" Text='<%# Eval("EPF_2TB") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Taxa " SortExpression="EPF_EGM" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_EGM" runat="server" Text='<%# Eval("EPF_EGM") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Velocidade " SortExpression="EPF_VW2" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_VW2" runat="server" Text='<%# Eval("EPF_VW2") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Pressão 1 " SortExpression="EPF_1PP" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_1PP" runat="server" Text='<%# Eval("EPF_1PP") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Pressão 2 " SortExpression="EPF_2PP" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_2PP" runat="server" Text='<%# Eval("EPF_2PP") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Entrelaçamento " SortExpression="ERT_DES" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right" >
			<ItemTemplate>
				<asp:Label ID="lbERT_DES" runat="server" Text='<%# Eval("ERT_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="EPF_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_STS" runat="server" Text='<%# (Eval("EPF_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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