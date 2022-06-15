<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Operador.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : Operador.aspx 
Criado em         : 30/05/2016
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Operador 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationSettings.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmOperador" runat="server" action="Operador.aspx">
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
			Pesquisar Operador
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Nome</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_nom" runat="server" CssClass="text_box" maxlength="50" style="width:500px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Prontuário</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_puo" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Tipo Máquina </td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_tip_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Turma</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="ddl_tum" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ADM" Text="ADM"></asp:ListItem>
				<asp:ListItem value="A" Text="A"></asp:ListItem>
				<asp:ListItem value="B" Text="B"></asp:ListItem>
				<asp:ListItem value="C" Text="C"></asp:ListItem>
				<asp:ListItem value="D" Text="D"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Turno</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="ddl_tur" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ADM" Text="ADM"></asp:ListItem>
				<asp:ListItem value="TURNO 1" Text="TURNO 1"></asp:ListItem>
				<asp:ListItem value="TURNO 2" Text="TURNO 2"></asp:ListItem>
				<asp:ListItem value="TURNO 3" Text="TURNO 3"></asp:ListItem>
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
			<asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovoFiltro" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovo_Click" />
		</td>
	</tr>
</table>
</div>
<div runat="server" id="dvResultado" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td class="font_titulo_grd" style="width:780px">
			Pesquisar Operador
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
			<asp:Button ID="btVoltarGrid"     runat="server" CssClass="botao" Text="Filtro" Onclick="btVoltar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovoFiltroGrid" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovo_Click" />
		</td>
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvOperador" DataKeyNames="OPD_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvOperador_RowDataBound"  OnSorting="gvOperador_Sorting"
				OnRowCreated="gvOperador_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Nome " SortExpression="OPD_NOM" ControlStyle-Width="500px" >
			<ItemTemplate>
				<asp:Label ID="lbOPD_NOM" runat="server" Text='<%# Eval("OPD_NOM") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Prontuario " SortExpression="OPD_PUO" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbOPD_PUO" runat="server" Text='<%# Eval("OPD_PUO") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tipo " SortExpression="MAQ_TIP_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbMAQ_TIP_DES" runat="server" Text='<%# Eval("MAQ_TIP_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Turma " SortExpression="OPD_TUM" ControlStyle-Width="10px" >
			<ItemTemplate>
				<asp:Label ID="lbOPD_TUM" runat="server" Text='<%# Eval("OPD_TUM") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Turno " SortExpression="OPD_TUR" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbOPD_TUR" runat="server" Text='<%# Eval("OPD_TUR") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="OPD_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbOPD_STS" runat="server" Text='<%# (Eval("OPD_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
<div ID="divCadastro" runat="server">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="4" class="font_titulo_grd" style="width:780px">
			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
			Operador
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Nome</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_nom_inc" runat="server" CssClass="text_box"  maxlength="50" style="width:500px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Prontuario</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_puo_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Maquina Tipo</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_maq_tip_id_inc" runat="server" CssClass="combo_box">
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Turma</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="ddl_tum_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ADM" Text="ADM"></asp:ListItem>
				<asp:ListItem value="A" Text="A"></asp:ListItem>
				<asp:ListItem value="B" Text="B"></asp:ListItem>
				<asp:ListItem value="C" Text="C"></asp:ListItem>
				<asp:ListItem value="D" Text="D"></asp:ListItem>
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Turno</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="ddl_tur_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ADM" Text="ADM"></asp:ListItem>
				<asp:ListItem value="TURNO 1" Text="TURNO 1"></asp:ListItem>
				<asp:ListItem value="TURNO 2" Text="TURNO 2"></asp:ListItem>
				<asp:ListItem value="TURNO 3" Text="TURNO 3"></asp:ListItem>
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_sts_inc" runat="server" CssClass="combo_box">
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
			<asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" Onclick="btSalvar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" Onclick="btVoltar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" Onclick="btNovo_Click" />
		</td>
	</tr>
</table>
</div>
</div>
</form>
</body>
</html>
