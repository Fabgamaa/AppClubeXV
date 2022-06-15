<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="LancamentoMaquina.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : LancamentoMaquina.aspx 
Criado em         : 30/05/2016
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Lancamento de Maquina 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationSettings.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmLancamentoMaquina" runat="server" action="LancamentoMaquina.aspx">
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
			Pesquisar Lançamento de Máquina
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
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
		<td colspan="2" class="font_body">Lado</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_lad" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="A" Text="A"></asp:ListItem>
				<asp:ListItem value="B" Text="B"></asp:ListItem>
				<asp:ListItem value="C" Text="C"></asp:ListItem>
				<asp:ListItem value="D" Text="D"></asp:ListItem>
				<asp:ListItem value="E" Text="E"></asp:ListItem>
				<asp:ListItem value="F" Text="F"></asp:ListItem>
				<asp:ListItem value="G" Text="G"></asp:ListItem>
				<asp:ListItem value="H" Text="H"></asp:ListItem>
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
		<td colspan="2" class="font_body">Cor</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_cor" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="AZUL" Text="AZUL"></asp:ListItem>
				<asp:ListItem value="PRETO" Text="PRETO"></asp:ListItem>
				<asp:ListItem value="VERDE" Text="VERDE"></asp:ListItem>
				<asp:ListItem value="VERMELHO" Text="VERMELHO"></asp:ListItem>
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
			Pesquisar Lançamento de Máquina
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvLancamentoMaquina" DataKeyNames="LNC_MAQ_ID, LNC_MAQ_STS" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvLancamentoMaquina_RowDataBound"  OnSorting="gvLancamentoMaquina_Sorting"
				OnRowCreated="gvLancamentoMaquina_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Máquina " SortExpression="MAQ_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbMAQ_DES" runat="server" Text='<%# Eval("MAQ_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lado " SortExpression="LNC_MAQ_LAD" ControlStyle-Width="10px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_LAD" runat="server" Text='<%# Eval("LNC_MAQ_LAD") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="LNC_MAQ_LOT" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_LOT" runat="server" Text='<%# Eval("LNC_MAQ_LOT") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tubo " SortExpression="LNC_MAQ_TUB" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_TUB" runat="server" Text='<%# Eval("LNC_MAQ_TUB") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Produto " SortExpression="LNC_MAQ_PRD" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_PRD" runat="server" Text='<%# Eval("LNC_MAQ_PRD") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Virada " SortExpression="LNC_MAQ_VRD" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_VRD" runat="server" Text='<%# String.IsNullOrEmpty(Eval("LNC_MAQ_VRD").ToString())?"":Convert.ToDateTime(Eval("LNC_MAQ_VRD").ToString()).ToString("HH:mm") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Descrição " SortExpression="LNC_MAQ_DES" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_DES" runat="server" Text='<%# Eval("LNC_MAQ_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Cor " SortExpression="LNC_MAQ_COR" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_COR" runat="server" Text='<%# Eval("LNC_MAQ_COR") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data " SortExpression="LNC_MAQ_DAT" ControlStyle-Width="120px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("LNC_MAQ_DAT").ToString())?"":Convert.ToDateTime(Eval("LNC_MAQ_DAT").ToString()).ToString("dd/MM/yyyy HH:mm") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Usuário " SortExpression="USR_NOM" ControlStyle-Width="120px" >
			<ItemTemplate>
				<asp:Label ID="lbUSR_NOM" runat="server" Text='<%# Eval("USR_NOM").ToString() %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="LNC_MAQ_STS" ControlStyle-Width="50px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MAQ_STS" runat="server" Text='<%# (Eval("LNC_MAQ_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
			Lançamento de Máquina
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_maq_id_inc" runat="server" CssClass="combo_box">
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Lado</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_lad_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="A" Text="A"></asp:ListItem>
				<asp:ListItem value="B" Text="B"></asp:ListItem>
				<asp:ListItem value="C" Text="C"></asp:ListItem>
				<asp:ListItem value="D" Text="D"></asp:ListItem>
				<asp:ListItem value="E" Text="E"></asp:ListItem>
				<asp:ListItem value="F" Text="F"></asp:ListItem>
				<asp:ListItem value="G" Text="G"></asp:ListItem>
				<asp:ListItem value="H" Text="H"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_lot_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px" OnTextChanged="txt_lot_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
			<asp:DropDownList ID="cbo_lot_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_lot_inc_OnSelectedIndexChanged" AutoPostBack="true" Visible="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Tubo</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_tub_inc" runat="server" CssClass="text_box"  maxlength="50" style="width:500px" enabled="false"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Produto</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_prd_inc" runat="server" CssClass="text_box"  maxlength="50" style="width:500px" enabled="false"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Descrição</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_des_inc" runat="server" CssClass="text_box"  maxlength="50" style="width:500px; text-transform: none;"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Cor</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_cor_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="AZUL" Text="AZUL"></asp:ListItem>
				<asp:ListItem value="PRETO" Text="PRETO"></asp:ListItem>
				<asp:ListItem value="VERDE" Text="VERDE"></asp:ListItem>
				<asp:ListItem value="VERMELHO" Text="VERMELHO"></asp:ListItem>
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Tempo de Virada</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_vrd_inc" runat="server" CssClass="text_box"  maxlength="5" style="width:50px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box"  maxlength="16" style="width:140px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Posição</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_pos_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="Máquina Inteira - 1 a 216" Text="Máquina Inteira - 1 a 216"></asp:ListItem>
				<asp:ListItem value="Lado A - 1 a 110" Text="Lado A - 1 a 110"></asp:ListItem>
				<asp:ListItem value="Lado B - 109 a 216" Text="Lado B - 109 a 216"></asp:ListItem>
				<asp:ListItem value="Máquina Inteira 2 Cabos - 1 a 110" Text="Máquina Inteira 2 Cabos - 1 a 110"></asp:ListItem>
				<asp:ListItem value="Máquina Inteira 3 Cabos - 1 a 80" Text="Máquina Inteira 3 Cabos - 1 a 80"></asp:ListItem>
				<asp:ListItem value="Máquina Inteira 4 Cabos - 1 a 60" Text="Máquina Inteira 4 Cabos - 1 a 60"></asp:ListItem>
				<asp:ListItem value="Lado A 2 Cabos - 1 a 60" Text="Lado A 2 Cabos - 1 a 60"></asp:ListItem>
				<asp:ListItem value="Lado B 2 Cabos - 55 a 109" Text="Lado B 2 Cabos - 55 a 60"></asp:ListItem>
				<asp:ListItem value="Lado A 3 Cabos - 1 a 40" Text="Lado A 3 Cabos - 1 a 40"></asp:ListItem>
				<asp:ListItem value="Lado B 3 Cabos - 37 a 72" Text="Lado B 3 Cabos - 37 a 72"></asp:ListItem>
				<asp:ListItem value="Lado A 4 Cabos - 1 a 30" Text="Lado A 4 Cabos - 1 a 30"></asp:ListItem>
				<asp:ListItem value="Lado B 4 Cabos - 28 a 54" Text="Lado B 4 Cabos - 28 a 54"></asp:ListItem>
				<asp:ListItem value="Etiqueta de Quebra - 1 a 60" Text="Etiqueta de Quebra - 1 a 60"></asp:ListItem>
				<asp:ListItem value="Murata - 121 a 240" Text="Murata - 121 a 240"></asp:ListItem>
				<asp:ListItem value="Murata - 1 a 120" Text="Murata - 1 a 120"></asp:ListItem>
			</asp:DropDownList> 
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
