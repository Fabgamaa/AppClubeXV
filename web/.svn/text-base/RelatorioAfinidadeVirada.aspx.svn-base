<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioAfinidadeVirada.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioAfinidadeVirada.aspx 
Criado em         : 02/09/2015
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Afinidade Virada
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 TrAFNitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-trAFNitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmAfinidade" runat="server">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Relatório de Afinidade Virada
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
			<asp:TextBox id="txt_dat_ini" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data Final</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Tipo</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_tip" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="AFINIDADE"></asp:ListItem>
				<asp:ListItem value="2" Text="LUZ NEGRA"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Virada</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vrd" runat="server" CssClass="text_box" maxlength="4" style="width:40px"></asp:TextBox>
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
<div runat="server" id="dvAfinidade" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td class="font_titulo_grd">
			Relatório de Afinidade Virada
		</td>
	</tr>
	<tr>		<td class="font_body" style="width:780px" align="right">			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;		</td>	</tr>	<tr>		<td align="right">			<asp:LinkButton ID="lkb_pdf" runat="server" OnClick="lkb_pdf_Click" Text="pdf" ToolTip="Exporta para PDF"></asp:LinkButton>			&nbsp;			<asp:LinkButton ID="lkb_xls" runat="server" OnClick="lkb_xls_Click" Text="xls" ToolTip="Exporta para XLS"></asp:LinkButton>		</td>	</tr>	<tr>
		<td>
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			    <asp:GridView Width="760px" CausesValidation="false"   ID="gvAfinidade" DataKeyNames="AFN_DAT, AFN_LOT, MAQ_DES" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvAfinidade_RowDataBound"  OnSorting="gvAfinidade_Sorting"
				OnRowCreated="gvAfinidade_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
                <asp:TemplateField HeaderText=" Data " SortExpression="AFN_DAT" ControlStyle-Width="60px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("AFN_DAT").ToString())?"":Convert.ToDateTime(Eval("AFN_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" Lote " SortExpression="AFN_LOT" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_LOT" runat="server" Text='<%# Eval("AFN_LOT") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" Máquina " SortExpression="MAQ_DES" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbMAQ_DES" runat="server" Text='<%# Eval("MAQ_DES") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" Virada " SortExpression="AFN_VRD" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_VRD" runat="server" Text='<%# Eval("AFN_VRD") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" Analisadas " SortExpression="AFN_BBN" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_BBN" runat="server" Text='<%# Eval("AFN_BBN") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" Desclassificadas " SortExpression="AFN_DCL" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_DCL" runat="server" Text='<%# Eval("AFN_DCL") %>' />
			    </ItemTemplate>
			    <HeaderStyle ForeColor="White" />
			    </asp:TemplateField>
			    <asp:TemplateField HeaderText=" % Desclassificação " SortExpression="AFN_DCL" ControlStyle-Width="40px" >
			    <ItemTemplate>
				    <asp:Label ID="lbAFN_PER_DCL" runat="server" Text='<%# (Eval("AFN_DCL").ToString()=="0")?"0,00":(Convert.ToDouble(Eval("AFN_DCL")) / Convert.ToDouble(Eval("AFN_BBN")) * 100).ToString("N2") %>' />
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
	<tr>
		<td>&nbsp;</td>
	</tr>
</table>
</div>
</div>
</form>
</body>
</html>