<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioPlanejamentoMensal.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RatorioPlanejamentoMensal.aspx 
Criado em         : 08/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Ratório de Planejamento Mensal
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmPlanejamentoMensal" runat="server">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Planejamento Mensal
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
		<td colspan="2" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Lote Referência</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot_ref" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Título</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_tit_poy_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Merge</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_mge" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Fornecedor</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_for_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Cliente</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_cli_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_maq_tip_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Apresentação</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_aps_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Entrelaçamento</td>
	</tr>
	<tr>
		<td colspan="2">
            <asp:DropDownList ID="cbo_ert_id" runat="server" CssClass="combo_box">
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
			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" />
		</td>
	</tr>
</table>
</div>
<div runat="server" id="dvResultado" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td class="font_titulo_grd" style="width:780px">
			Relatório Planejamento Mensal
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvTeste" DataKeyNames="TST_ID" 
				runat="server" AutoGenerateColumns="False" AllowSorting="True" 
				OnRowDataBound="gvTeste_RowDataBound"  OnSorting="gvTeste_Sorting"
				OnRowCreated="gvTeste_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Data " SortExpression="TST_DAT_INI" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_DAT_INI" runat="server" Text='<%# String.IsNullOrEmpty(Eval("TST_DAT_INI").ToString())?"":Convert.ToDateTime(Eval("TST_DAT_INI").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tipo Máquina " SortExpression="MAQ_TIP_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbMAQ_TIP_DES" runat="server" Text='<%# Eval("MAQ_TIP_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Entr " SortExpression="ERT_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbERT_DES" runat="server" Text='<%# Eval("ERT_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Apresentação " SortExpression="APS_DES" ControlStyle-Width="120px" >
			<ItemTemplate>
				<asp:Label ID="lbAPS_DES" runat="server" Text='<%# Eval("APS_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="120px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Fornecedor " SortExpression="FOR_NOM" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbFOR_NOM" runat="server" Text='<%# Eval("FOR_NOM") %>' />
			</ItemTemplate>

<ControlStyle Width="100px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Merge " SortExpression="TST_MGE" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_MGE" runat="server" Text='<%# Eval("TST_MGE") %>' />
			</ItemTemplate>

<ControlStyle Width="70px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="TST_LOT" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_LOT" runat="server" Text='<%# Eval("TST_LOT") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Veloc " SortExpression="RTS_VEL" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbRTS_VEL" runat="server" Text='<%# Eval("RTS_VEL") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Cliente " SortExpression="CLI_NOM" ControlStyle-Width="160px" >
			<ItemTemplate>
				<asp:Label ID="lbCLI_NOM" runat="server" Text='<%# Eval("CLI_NOM") %>' />
			</ItemTemplate>

<ControlStyle Width="160px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Motivo " SortExpression="MTV_TST_DES" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbMTV_TST_DES" runat="server" Text='<%# Eval("MTV_TST_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="100px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Solicitante " SortExpression="USR_SLT" ControlStyle-Width="140px" >
			<ItemTemplate>
				<asp:Label ID="lbUSR_SLT" runat="server" Text='<%# Eval("USR_SLT") %>' />
			</ItemTemplate>

<ControlStyle Width="140px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tempo " SortExpression="TMP_GST" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbTMP_GST" runat="server" Text='<%# Eval("TMP_GST") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

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