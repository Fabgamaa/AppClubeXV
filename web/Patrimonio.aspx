<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Patrimonio.aspx.cs" Inherits="Default2" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationSettings.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmPatrimonio" runat="server" action="Patrimonio.aspx">
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
			Pesquisar Patrimonio
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
<%--	<tr>
		<td colspan="2" class="font_body">Usuário</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_usr_id" runat="server" CssClass="combo_box" maxlength="100" style="width:200px">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>--%>
	<tr>
		<td colspan="2" class="font_body">Unidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="txt_und" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="Clube XV de Novembro" Text="Clube XV de Novembro"></asp:ListItem>
				<asp:ListItem value="Yate Clube de Alfenas" Text="Yate Clube de Alfenas"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
<%--	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_und" runat="server" CssClass="text_box" maxlength="100" style="width:500px"></asp:TextBox>
		</td>
	</tr>--%>
	<tr>
		<td colspan="2" class="font_body">Local</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_loc" runat="server" CssClass="text_box" maxlength="100" style="width:500px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Nome do bem</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_bem" runat="server" CssClass="text_box" maxlength="100" style="width:500px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Etiqueta</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_etq" runat="server" CssClass="text_box" maxlength="20" style="width:200px"></asp:TextBox>
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
<%--	<tr>
		<td colspan="2" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_tms_alt" runat="server" CssClass="text_box" maxlength="8" style="width:80px"></asp:TextBox>
		</td>
	</tr>--%>
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
			Pesquisar Patrimonio
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvPatrimonio" DataKeyNames="PTR_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvPatrimonio_RowDataBound"  OnSorting="gvPatrimonio_Sorting"
				OnRowCreated="gvPatrimonio_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_USR_ID" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_USR_ID" runat="server" Text='<%# Eval("PTR_USR_ID") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_UND" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_UND" runat="server" Text='<%# Eval("PTR_UND") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_LOC" ControlStyle-Width="300px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_LOC" runat="server" Text='<%# Eval("PTR_LOC") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_BEM" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_BEM" runat="server" Text='<%# Eval("PTR_BEM") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_ETQ" ControlStyle-Width="50px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_ETQ" runat="server" Text='<%# Eval("PTR_ETQ") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_STS" runat="server" Text='<%# (Eval("PTR_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText="  " SortExpression="PTR_TMS_ALT" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbPTR_TMS_ALT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PTR_TMS_ALT").ToString())?"":Convert.ToDateTime(Eval("PTR_TMS_ALT").ToString()).ToString("dd/MM/yyyy") %>' />
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
			
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
<%--		<tr>
		<td colspan="2" class="font_body">Usuário</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_usr_id_inc" runat="server" CssClass="combo_box" maxlength="100" style="width:200px">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>--%>


	<tr>
		<td colspan="2" class="font_body">Unidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="txt_und_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="Clube XV de Novembro" Text="Clube XV de Novembro"></asp:ListItem>
				<asp:ListItem value="Yate Clube de Alfenas" Text="Yate Clube de Alfenas"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
<%--	<tr>
		<td colspan="4" class="font_body">Usuário</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="cbo_usr_inc_id" runat="server" CssClass="text_box"  maxlength="100" style="width:1000px"></asp:TextBox> 
		</td>
	</tr>--%>
	<tr>
		<td colspan="4" class="font_body">Local</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_loc_inc" runat="server" CssClass="text_box"  maxlength="100" style="width:500px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Nome do bem</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_bem_inc" runat="server" CssClass="text_box"  maxlength="100" style="width:500px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Etiqueta</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_etq_inc" runat="server" CssClass="text_box"  maxlength="20" style="width:200px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body"></td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_sts_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList> 
		</td>
	</tr>
<%--	<tr>
		<td colspan="4" class="font_body"></td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_tms_alt_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox> 
		</td>
	</tr>--%>
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
