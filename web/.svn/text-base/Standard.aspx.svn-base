<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Standard.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : Standard.aspx 
Criado em         : 08/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Standard 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmStandard" runat="server" action="Standard.aspx">
<asp:HiddenField ID="Origem" runat="server" /><asp:HiddenField ID="rowId" runat="server" /><script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Standard
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Versão</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vrs" runat="server" CssClass="text_box" style="width:80px"></asp:TextBox>
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
			<asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovoFiltro" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovoFiltro_Click" />
		</td>
	</tr>
</table>
</div>
<div runat="server" id="dvResultado" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td class="font_titulo_grd" style="width:780px">
			Pesquisar Standard
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
			<asp:Button ID="btNovoFiltroGrid" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovoFiltro_Click" />
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvStandard" DataKeyNames="EPF_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvStandard_RowDataBound"  OnSorting="gvStandard_Sorting"
				OnRowCreated="gvStandard_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Lote " SortExpression="EPF_LOT" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_LOT" runat="server" Text='<%# Eval("EPF_LOT") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote Referência " SortExpression="EPF_LOT_REF" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_LOT_REF" runat="server" Text='<%# Eval("EPF_LOT_REF") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Merge " SortExpression="EPF_MGE" ControlStyle-Width="180px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_MGE" runat="server" Text='<%# Eval("EPF_MGE") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Fornecedor " SortExpression="FOR_NOM" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbFOR_NOM" runat="server" Text='<%# Eval("FOR_NOM") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Versão " SortExpression="EPF_VRS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_VRS" runat="server" Text='<%# Eval("EPF_VRS") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data " SortExpression="EPF_DAT" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("EPF_DAT").ToString())?"":Convert.ToDateTime(Eval("EPF_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="EPF_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbEPF_STS" runat="server" Text='<%#(Eval("EPF_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
			Standard
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td class="font_body">Data</td>
		<td colspan="3" class="font_body">Versão</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
		<td colspan="3">
			<asp:TextBox id="txt_vrs_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" ReadOnly="true"></asp:TextBox>
		</td>
	</tr>
	<tr>		<td colspan="4" class="font_body">Responsável</td>	</tr>	<tr>		<td colspan="4">			<asp:DropDownList ID="cbo_rsp_inc" runat="server" CssClass="combo_box">				<asp:ListItem value="" Text=""></asp:ListItem>			</asp:DropDownList> *		</td>	</tr>	<tr>
		<td colspan="4" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_lot_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Lote Referência</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_lot_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_lot_ref_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td class="font_body">Título</td>
		<td colspan="3" class="font_body">Descrição</td>
	</tr>
	<tr>
		<td>
    		<asp:DropDownList ID="cbo_tit_poy_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList> *
		</td>
		<td colspan="3">
			<asp:TextBox id="txt_des_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:400px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 1</td>
		<td class="font_body">Merge 2</td>
		<td class="font_body">Merge 3</td>
		<td class="font_body">Merge 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox> *
		</td>
		<td>
			<asp:TextBox id="txt_mge_002_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_003_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_004_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td class="font_body">Descrição 1</td>
		<td class="font_body">Descrição 2</td>
		<td class="font_body">Descrição 3</td>
		<td class="font_body">Descrição 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_des_001_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mge_des_002_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mge_des_003_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mge_des_004_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td class="font_body">Fornecedor 1</td>
		<td class="font_body">Fornecedor 2</td>
		<td class="font_body">Fornecedor 3</td>
		<td class="font_body">Fornecedor 4</td>
	</tr>
	<tr>
		<td nowrap="nowrap">
    		<asp:DropDownList ID="cbo_for_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList> *
		</td>
		<td>
    		<asp:DropDownList ID="cbo_for_002_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
		<td>
    		<asp:DropDownList ID="cbo_for_003_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
		<td>
    		<asp:DropDownList ID="cbo_for_004_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
	</tr>
    <!-- Inicio TMT-->
    <asp:Panel ID="pnl_tmt_poy" runat="server" Visible="false">
	<tr>
		<td class="font_body">Matiz 1</td>
		<td class="font_body">Matiz 2</td>
		<td class="font_body">Matiz 3</td>
		<td class="font_body">Matiz 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mat_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mat_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mat_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_mat_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td class="font_body">Local da Cantre 1</td>
		<td class="font_body">Local da Cantre 2</td>
		<td class="font_body">Local da Cantre 3</td>
		<td class="font_body">Local da Cantre 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_can_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_can_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_can_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_can_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td class="font_body">Épura 1</td>
		<td class="font_body">Épura 2</td>
		<td class="font_body">Épura 3</td>
		<td class="font_body">Épura 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_epu_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_epu_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_epu_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_epu_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td class="font_body">% Merge 1</td>
		<td class="font_body">% Merge 2</td>
		<td class="font_body">% Merge 3</td>
		<td class="font_body">% Merge 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_per_mge_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_per_mge_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_per_mge_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_per_mge_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
	</tr>
    </asp:Panel>
    <!-- Fim TMT-->
        
    <asp:Panel ID="pnl_sta_poy" runat="server">
    <tr>
		<td class="font_body">Merge E1</td>
		<td class="font_body">Merge E2</td>
		<td class="font_body">Merge E3</td>
		<td class="font_body">Merge E4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_ege_001_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_ege_002_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_ege_003_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_ege_004_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td class="font_body">Descrição E1</td>
		<td class="font_body">Descrição E2</td>
		<td class="font_body">Descrição E3</td>
		<td class="font_body">Descrição E4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_ege_des_001_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_ege_des_002_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_ege_des_003_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
		<td>
			<asp:TextBox id="txt_ege_des_004_inc" runat="server" CssClass="text_box"  maxlength="40" style="width:180px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td class="font_body">Fornecedor E1</td>
		<td class="font_body">Fornecedor E2</td>
		<td class="font_body">Fornecedor E3</td>
		<td class="font_body">Fornecedor E4</td>
	</tr>
	<tr>
		<td nowrap="nowrap">
    		<asp:DropDownList ID="cbo_eor_001_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList> 
		</td>
		<td>
    		<asp:DropDownList ID="cbo_eor_002_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
		<td>
    		<asp:DropDownList ID="cbo_eor_003_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
		<td>
    		<asp:DropDownList ID="cbo_eor_004_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList>
		</td>
	</tr>
    </asp:Panel>
	<tr>
		<td colspan="4" class="font_body">Apresentação</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:DropDownList ID="cbo_aps_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Tipo de Máquina</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:DropDownList ID="cbo_maq_tip_id_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_maq_tip_id_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
		    </asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Entrelaçamento</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:DropDownList ID="cbo_ert_id_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
    		</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp</td>
	</tr>

	<tr>
	<td colspan="4">
    <table>
    <tr style="vertical-align:top">
    <td>
    <table>       
    	<tr>
		<td colspan="2" class="destaque">Condições de Operação</td>
	    </tr>
        <asp:Panel ID="pnl_afk" runat="server" Visible="true">
		<tr class="linha_par">
        <td class="font_body" style="width:150px"><asp:label id="lbl_vw2" runat="server" Text="Velocidade W2(m/min)"></asp:label></td>
		<td><asp:TextBox id="txt_vw2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Taxa de estiragem</td>
		<td><asp:TextBox id="txt_egm_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body"><asp:label id="lbl_edy" runat="server" Text="D/Y"></asp:label></td>
		<td><asp:TextBox id="txt_dyy_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"><asp:label id="lbl_ewx" runat="server" Text="2nd Overfeed  - WX(%)"></asp:label></td>
		<td><asp:TextBox id="txt_2wx_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body"><asp:label id="lbl_ew3" runat="server" Text="3rd  Overfeed  - W3(%)"></asp:label></td>
		<td><asp:TextBox id="txt_3w3_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"><asp:label id="lbl_ew4" runat="server" Text="4rd  Overfeed  - W4(%)"></asp:label></td>
		<td><asp:TextBox id="txt_4w4_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- Criado novo painel para não visualizar Ângulo cruzamento e Take Up Program das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_tup" runat="server" Visible="true">
		<tr class="linha_par">
        <td class="font_body">Ângulo cruzamento(°)</td>
		<td><asp:TextBox id="txt_agl_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Take Up Program</td>
		<td><asp:TextBox id="txt_tup_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
		<tr class="linha_par">
        <td class="font_body">Vel. Eixo óleo(rpm)</td>
		<td><asp:TextBox id="txt_veo_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T1 - Texturização(ºC)</td>
		<td><asp:TextBox id="txt_t1t_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- Criado novo painel para não visualizar Take Up Program das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_t1e" runat="server" Visible="true">
		<tr class="linha_par">
        <td class="font_body">T1 - Estufa curta(ºC)</td>
		<td><asp:TextBox id="txt_t1c_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T1 - Estufa Longa(ºC)</td>
		<td><asp:TextBox id="txt_t1l_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
		<tr class="linha_par">
        <td class="font_body">T2 - Fixação(ºC)</td>
		<td><asp:TextBox id="txt_t2f_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_ope" runat="server" Visible="false">
	    <tr>
		    <td class="font_body">T0(Hot-pin)</td>
		    <td><asp:TextBox id="txt_hot_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Torção(VR Direction)</td>
		    <td><asp:TextBox id="txt_vrd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Ângulo de Cruzamento</td>
		    <td><asp:TextBox id="txt_acr_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Padrão de Enrolamento</td>
		    <td><asp:TextBox id="txt_pen_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Creeping Ratio</td>
		    <td><asp:TextBox id="txt_cra_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Creeping Length/o</td>
		    <td><asp:TextBox id="txt_cle_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Ângulo de Formação</td>
		    <td><asp:TextBox id="txt_afo_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Taper Curve</td>
            <td>
			<asp:DropDownList ID="ddl_tcu_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">Taper Adjustment Ratio</td>
		    <td><asp:TextBox id="txt_tar_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Taper Angle Multistage</td>
            <td>
			<asp:DropDownList ID="ddl_tam_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="ddl_tam_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr>
		    <td class="font_body">Second Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_std_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Second Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_stp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Third Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_ttd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Third Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_ttp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Fourth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_ftd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Fourth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_ftp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Fifth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_itd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Fifth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_itp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Sixth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_xtd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Sixth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_xtp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>

		<tr class="linha_par">
		    <td class="font_body">Diâmetro do Tubo</td>
		    <td><asp:TextBox id="txt_dtu_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
        <tr>
		    <td class="font_body">Diâmetro do Pacote</td>
		    <td><asp:TextBox id="txt_dpa_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Curso Inicial</td>
		    <td><asp:TextBox id="txt_cin_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
        <asp:Panel ID="pnl_frs" runat="server" Visible="true">
        <tr>
            <td>
			<asp:DropDownList ID="ddl_fr2_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="ddl_tam_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value=""  Text=""></asp:ListItem>
				<asp:ListItem value="FR0/FR1"  Text="FR0/FR1"></asp:ListItem>
				<asp:ListItem value="FR0/FR01" Text="FR0/FR01"></asp:ListItem>
				<asp:ListItem value="FR0/FR2"  Text="FR0/FR2"></asp:ListItem>
				<asp:ListItem value="FR01/FR0" Text="FR01/FR0"></asp:ListItem>
				<asp:ListItem value="FR01/FR1" Text="FR01/FR1"></asp:ListItem>
				<asp:ListItem value="FR01/FR2" Text="FR01/FR2"></asp:ListItem>
				<asp:ListItem value="FR1/FR0"  Text="FR1/FR0"></asp:ListItem>
				<asp:ListItem value="FR1/FR01" Text="FR1/FR01"></asp:ListItem>
				<asp:ListItem value="FR2/FR0"  Text="FR2/FR0"></asp:ListItem>
				<asp:ListItem value="FR2/FR01" Text="FR2/FR01"></asp:ListItem>
			</asp:DropDownList>
            </td>
		    <td><asp:TextBox id="txt_fr2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
            <td>
			<asp:DropDownList ID="ddl_fr1_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="ddl_tam_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value=""  Text=""></asp:ListItem>
				<asp:ListItem value="FR0/FR1"  Text="FR0/FR1"></asp:ListItem>
				<asp:ListItem value="FR0/FR01" Text="FR0/FR01"></asp:ListItem>
				<asp:ListItem value="FR0/FR2"  Text="FR0/FR2"></asp:ListItem>
				<asp:ListItem value="FR01/FR0" Text="FR01/FR0"></asp:ListItem>
				<asp:ListItem value="FR01/FR1" Text="FR01/FR1"></asp:ListItem>
				<asp:ListItem value="FR01/FR2" Text="FR01/FR2"></asp:ListItem>
				<asp:ListItem value="FR1/FR0"  Text="FR1/FR0"></asp:ListItem>
				<asp:ListItem value="FR1/FR01" Text="FR1/FR01"></asp:ListItem>
				<asp:ListItem value="FR2/FR0"  Text="FR2/FR0"></asp:ListItem>
				<asp:ListItem value="FR2/FR01" Text="FR2/FR01"></asp:ListItem>
			</asp:DropDownList>
            </td>
		    <td><asp:TextBox id="txt_fr1_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr>
            <td>
			<asp:DropDownList ID="ddl_fr0_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="ddl_tam_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value=""  Text=""></asp:ListItem>
				<asp:ListItem value="FR0/FR1"  Text="FR0/FR1"></asp:ListItem>
				<asp:ListItem value="FR0/FR01" Text="FR0/FR01"></asp:ListItem>
				<asp:ListItem value="FR0/FR2"  Text="FR0/FR2"></asp:ListItem>
				<asp:ListItem value="FR01/FR0" Text="FR01/FR0"></asp:ListItem>
				<asp:ListItem value="FR01/FR1" Text="FR01/FR1"></asp:ListItem>
				<asp:ListItem value="FR01/FR2" Text="FR01/FR2"></asp:ListItem>
				<asp:ListItem value="FR1/FR0"  Text="FR1/FR0"></asp:ListItem>
				<asp:ListItem value="FR1/FR01" Text="FR1/FR01"></asp:ListItem>
				<asp:ListItem value="FR2/FR0"  Text="FR2/FR0"></asp:ListItem>
				<asp:ListItem value="FR2/FR01" Text="FR2/FR01"></asp:ListItem>
			</asp:DropDownList>
            </td>
		    <td><asp:TextBox id="txt_fr0_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
        </asp:Panel>
        <!-- Fim TMT-->

        <!-- panel estava abaixo do tr-->
        <asp:Panel ID="pnl_sta" runat="server" Visible="false">
		<tr>
        <td class="linha_par" class="font_body">Velocidade(m/min)</td>
		<td><asp:TextBox id="txt_sve_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Taxa de fixação</td>
		<td><asp:TextBox id="txt_stf_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="SelecionaEngrenagem" AutoPostBack="true"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Temperatura Fixação(°C)</td>
		<td><asp:TextBox id="txt_stm_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">C-Taxa de Estiragem</td>
		<td><asp:TextBox id="txt_sce_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="SelecionaEngrenagem" AutoPostBack="true"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C-Overfeed(%)</td>
		<td><asp:TextBox id="txt_sco_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="SelecionaEngrenagem" AutoPostBack="true"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">C-Temp. Hot Pin(°C)</td>
		<td><asp:TextBox id="txt_sch_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C-Temp. Godet(°C)</td>
		<td><asp:TextBox id="txt_scg_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E-Taxa de Estiragem</td>
		<td><asp:TextBox id="txt_see_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="SelecionaEngrenagem" AutoPostBack="true"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">E-Overfeed(%)</td>
		<td><asp:TextBox id="txt_seo_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="SelecionaEngrenagem" AutoPostBack="true"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E-Temp. Hot Pin(°C)</td>
		<td><asp:TextBox id="txt_seh_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">E-Temp. Godet(°C)</td>
		<td><asp:TextBox id="txt_seg_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Jet Core</td>
		<td><asp:TextBox id="txt_sjc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Jet Type</td>
		<td><asp:TextBox id="txt_sjt_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Jet Body</td>
		<td><asp:TextBox id="txt_sjb_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão Jet(bar)</td>
		<td><asp:TextBox id="txt_spj_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Dist. Bola/Carcaça(mm)</td>
		<td><asp:TextBox id="txt_sbc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Programa</td>
		<td><asp:TextBox id="txt_spo_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Variação</td>
		<td><asp:TextBox id="txt_sva_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>

        <!-- Criado novo painel para não visualizar Epura das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_ope" runat="server" Visible="true">
		<tr>
        <td class="font_body">Tipo de Óleo</td>
		<td><asp:TextBox id="txt_cot_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Óleo 3</td>
		<td><asp:TextBox id="txt_co2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Curso</td>
		<td><asp:TextBox id="txt_coc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Valor Tensão</td>
		<td><asp:TextBox id="txt_cov_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Tensão Alim(g)</td>
		<td><asp:TextBox id="txt_tal_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Voltas Alim</td>
		<td><asp:TextBox id="txt_val_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Sentido Jet</td>
		<td><asp:TextBox id="txt_sje_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
    </table>       

    <!-- Criado novo painel para não visualizar Epura das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_epu" runat="server" Visible="true">
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Epura</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body" style="width:150px">Guia do Fio Tinto</td>
		<td>
            <asp:DropDownList ID="cbo_gft_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="SIM"></asp:ListItem>
				<asp:ListItem value="0" Text="NÃO"></asp:ListItem>
			</asp:DropDownList>
        </td>
		</tr>
        <tr>
        <td class="font_body">Hemawet</td>
		<td>
            <asp:DropDownList ID="cbo_hem_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="SIM"></asp:ListItem>
				<asp:ListItem value="0" Text="NÃO"></asp:ListItem>
			</asp:DropDownList>
        </td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Vazão</td>
		<td><asp:TextBox id="txt_vaz_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>
    </asp:Panel>

    <!-- Criado novo painel para não visualizar Dados Informativos das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_dad" runat="server" Visible="true">
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Dados Informativos</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body" style="width:150px">Metragem Total</td>
		<td><asp:TextBox id="txt_dim_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>
    </asp:Panel>

	<table>       
	    <tr>
		    <td colspan="2" class="destaque">Serimetria</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body" style="width:150px">SURGE SPEED</td>
		<td><asp:TextBox id="txt_tss_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Título(dtex)</td>
		<td><asp:TextBox id="txt_tit_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tenacidade(cN/dtex)</td>
		<td><asp:TextBox id="txt_tnc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Alongamento(%)</td>
		<td><asp:TextBox id="txt_aon_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Encolhimento(%)</td>
		<td><asp:TextBox id="txt_enm_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E%</td>
		<td><asp:TextBox id="txt_eee_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">K%</td>
		<td><asp:TextBox id="txt_kkk_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">B%</td>
		<td><asp:TextBox id="txt_bbb_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Óleo(%)</td>
		<td><asp:TextBox id="txt_ole_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Torque(T/m/s)</td>
		<td><asp:TextBox id="txt_trq_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Entrelaçamento</td>
		<td><asp:TextBox id="txt_ert_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Retenção(3%)</td>
		<td><asp:TextBox id="txt_rt3_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Retenção(5%)</td>
		<td><asp:TextBox id="txt_rt5_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Densidade(g/cm3)</td>
		<td><asp:TextBox id="txt_dnd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diâmetro(cm)</td>
		<td><asp:TextBox id="txt_dmo_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Peso(g)</td>
		<td><asp:TextBox id="txt_pes_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tempo de Virada(min)</td>
		<td><asp:TextBox id="txt_vrr_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- Criado novo painel para não visualizar Draft das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_drt" runat="server" Visible="true">
		<tr>
        <td class="font_body">% de Core</td>
		<td><asp:TextBox id="txt_pco_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">% de Cover</td>
		<td><asp:TextBox id="txt_pcv_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Draft</td>
		<td><asp:TextBox id="txt_drt_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
    </table>       
	</td>

	<td>
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Regulagens Manuais</td>
	    </tr>
        <!-- Criado novo painel para não visualizar Regulagens Manuais das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_reg" runat="server" Visible="true">
		<tr class="linha_par">
        <td class="font_body" style="width:150px">Tipo Agregado</td>
		<td><asp:TextBox id="txt_tgr_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body" style="width:150px">Tipo Disco</td>
		<td><asp:TextBox id="txt_tip_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diposição dos discos</td>
		<td><asp:TextBox id="txt_dsb_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body">Torção</td>
		<td><asp:TextBox id="txt_tca_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Ângulo de formação</td>
		<td><asp:TextBox id="txt_fmc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body"># 1 Tipo de Buso</td>
		<td><asp:TextBox id="txt_1tb_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão(psi)</td>
		<td><asp:TextBox id="txt_1pp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body"># 2 Tipo de Buso</td>
		<td><asp:TextBox id="txt_2tb_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão(psi)</td>
		<td><asp:TextBox id="txt_2pp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body">Curso</td>
		<td><asp:TextBox id="txt_cso_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Espaçamento</td>
		<td><asp:TextBox id="txt_esp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
	    <tr>
        <td class="font_body">Tipo Óleo</td>
		<td><asp:TextBox id="txt_tol_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>    
        </asp:Panel>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_reg" runat="server" Visible="false">
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">Ângulo de Torção</td>
		    <td><asp:TextBox id="txt_ato_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body" style="width:150px">P1</td>
		    <td><asp:TextBox id="txt_tp1_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">P2</td>
		    <td><asp:TextBox id="txt_tp2_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CP</td>
		    <td><asp:TextBox id="txt_tcp_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">JET FR2A</td>
		    <td><asp:TextBox id="txt_jf2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Pressão(Bar)</td>
		    <td><asp:TextBox id="txt_ps2_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">JET FR0</td>
		    <td><asp:TextBox id="txt_jf0_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Pressão(Bar)</td>
		    <td><asp:TextBox id="txt_ps0_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Baffle Bar</td>
		    <td><asp:TextBox id="txt_bba_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Guias Rotativos</td>
		    <td><asp:TextBox id="txt_gro_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
        <!-- Fim TMT-->
    </table>       

    <!-- Início TMT-->
    <asp:Panel ID="pnl_tmt_tcs" runat="server" Visible="false">
    <table>
	    <tr>
		    <td colspan="3" class="destaque">Regulagens TCS</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body">Título Real(dtex)</td>
		<td colspan="2"><asp:TextBox id="txt_ttr_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; text-align:"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
		    <td class="font_body">Ply Layout</td>
            <td colspan="2">
			<asp:DropDownList ID="cbo_pll_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_pll_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ALL" Text="ALL"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        <tr>
        <td colspan="2">
        <table>
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">Ply Layout</td>
		    <td class="font_body">Ply 1</td>
	    </tr>
	    <tr>
		    <td class="font_body" style="width:150px">Target Tension</td>
		    <td><asp:TextBox id="txt_tte_001_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Number of Ply</td>
            <td>
			<asp:DropDownList ID="cbo_ply_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_ply_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="1"></asp:ListItem>
				<asp:ListItem value="2" Text="2"></asp:ListItem>
				<asp:ListItem value="3" Text="3"></asp:ListItem>
				<asp:ListItem value="4" Text="4"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        <asp:Panel ID="pnl_wpo_001" runat="server" Visible="true">
		<tr class="linha_par">
		    <td class="font_body">Winding Position</td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        </asp:Panel>
	    <tr>
		    <td class="font_body">Direction</td>
		    <td><asp:TextBox id="txt_dir_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Control Range</td>
		    <td><asp:TextBox id="txt_cra_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Control Error D.</td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Ply Cut Function</td>
            <td>
			<asp:DropDownList ID="cbo_plf_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_plf_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ATIVO" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="INATIVO" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        <asp:Panel ID="pnl_plf_001" runat="server" Visible="true">
		<tr class="linha_par">
		    <td class="font_body">Tension Dev.</td>
		    <td><asp:TextBox id="txt_ted_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Detect Lenght</td>
		    <td><asp:TextBox id="txt_dle_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Count Times</td>
		    <td><asp:TextBox id="txt_cti_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
	    <tr>
		    <td class="font_body">GL1O</td>
		    <td><asp:TextBox id="txt_g1o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1U</td>
		    <td><asp:TextBox id="txt_g1u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2O</td>
		    <td><asp:TextBox id="txt_g2o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2U</td>
		    <td><asp:TextBox id="txt_g2u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CV(%)</td>
		    <td><asp:TextBox id="txt_cvp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Over Cut(%)</td>
		    <td><asp:TextBox id="txt_ocu_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Under Cut(%)</td>
		    <td><asp:TextBox id="txt_ucu_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1O Count</td>
		    <td><asp:TextBox id="txt_c1o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL1O Length</td>
		    <td><asp:TextBox id="txt_l1o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1U Count</td>
		    <td><asp:TextBox id="txt_c1u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL1U Length</td>
		    <td><asp:TextBox id="txt_l1u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2O Count</td>
		    <td><asp:TextBox id="txt_c2o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2O Length</td>
		    <td><asp:TextBox id="txt_l2o_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2U Count</td>
		    <td><asp:TextBox id="txt_c2u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2U Length</td>
		    <td><asp:TextBox id="txt_l2u_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Total Sum</td>
		    <td><asp:TextBox id="txt_tsu_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CV Count</td>
		    <td><asp:TextBox id="txt_cvc_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">CV Lenght</td>
		    <td><asp:TextBox id="txt_cvl_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Total Length</td>
		    <td><asp:TextBox id="txt_tle_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
        </table>
        </td>
        <td>
        <asp:Panel ID="pnl_ply_002" runat="server" Visible="true">
        <table>
		<tr class="linha_par">
		    <td class="font_body">Ply 2</td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_tte_002_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
            <td>
            </td>
	    </tr>
        <asp:Panel ID="pnl_wpo_002" runat="server" Visible="true">
		<tr class="linha_par">
            <td>
			<asp:DropDownList ID="cbo_wpo_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        </asp:Panel>
	    <tr>
		    <td><asp:TextBox id="txt_dir_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_cra_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td>
			<asp:DropDownList ID="cbo_ced_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
            <td>
            </td>
	    </tr>
        <asp:Panel ID="pnl_plf_002" runat="server" Visible="true">
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_ted_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_dle_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_cti_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
	    <tr>
		    <td><asp:TextBox id="txt_g1o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_g1u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_g2o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_g2u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_cvp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_ocu_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_ucu_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_c1o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_l1o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_c1u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_l1u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_c2o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_l2o_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_c2u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_l2u_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_tsu_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_cvc_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td><asp:TextBox id="txt_cvl_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td><asp:TextBox id="txt_tle_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:60px"></asp:TextBox></td>
	    </tr>
        </table>
        </asp:Panel>
        </td>
        </tr>
    </table>       
    </asp:Panel>

    <!-- Criado novo painel para não visualizar Engrenagens e Polias das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_eng_pol" runat="server" Visible="true">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Engrenagens</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body" style="width:150px">Overfeed Core</td>
		<td><asp:TextBox id="txt_eoc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Overfeed Efeito</td>
		<td><asp:TextBox id="txt_eoe_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Taxa Core</td>
		<td><asp:TextBox id="txt_etc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Taxa Efeito</td>
		<td><asp:TextBox id="txt_ete_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>       
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Polias</td>
	    </tr>
		<tr class="linha_par">
            <td class="font_body" style="width:150px">Tensão</td>
		    <td><asp:TextBox id="txt_ptn_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>       
    </asp:Panel>

    <asp:Panel ID="pnl_M900_V900" runat="server">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Engrenagens</td>
	    </tr>
	    <tr class="linha_par">
            <td class="font_body" style="width:150px">Z1 / Z2</td>
		    <td class="font_body" align="right">
			    <asp:DropDownList ID="cbo_ez1_ez2_inc" runat="server" CssClass="combo_box" style="width:100px">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr>
            <td class="font_body">Z3 / Z4</td>
		    <td class="font_body" align="right">
			    <asp:DropDownList ID="cbo_ez3_ez4_inc" runat="server" CssClass="combo_box" style="width:100px">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr class="linha_par">
            <td class="font_body">Z5 / Z6</td>
		    <td class="font_body" align="right">
			    <asp:DropDownList ID="cbo_ez5_ez6_inc" runat="server" CssClass="combo_box" style="width:100px">
			    </asp:DropDownList>
            </td>
	    </tr>
    </table>
    </asp:Panel>
    <asp:Panel ID="pnl_Stahle" runat="server">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Engrenagens</td>
	    </tr>
	    <tr class="linha_par">
            <td colspan="2" class="font_body" style="width:250px">Z5 / Z8 / Z13</td>
	    </tr>
	    <tr class="linha_par">
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_sta_z05_z08_z13_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td colspan="2"></td>
	    </tr>
	    <tr>
            <td colspan="2" class="font_body">Z1 / Z2 / Z4 / Z6 / Z14</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_sta_z01_z02_z04_z06_z14_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td colspan="2"></td>
	    </tr>
	    <tr class="linha_par">
            <td colspan="2" class="font_body">Z9 / Z10</td>
	    </tr>
	    <tr class="linha_par">
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_sta_z09_z10_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td colspan="2"></td>
	    </tr>
	    <tr>
            <td colspan="2" class="font_body">Z11 / Z12</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_sta_z11_z12_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td colspan="2"></td>
	    </tr>
	    <tr class="linha_par">
            <td colspan="2" class="font_body">Z3</td>
	    </tr>
	    <tr class="linha_par">
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_sta_z03_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
    </table>
    </asp:Panel>
    <asp:Panel ID="pnl_sta_ctn" runat="server">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Polias</td>
	    </tr>
	    <tr class="linha_par">
            <td colspan="2" class="font_body" style="width:250px">P1 / P2</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">
			    <asp:DropDownList ID="cbo_ctn_inc" runat="server" CssClass="combo_box">
			    </asp:DropDownList>
            </td>
	    </tr>
    </table>
    </asp:Panel>

    <!-- Criado novo painel para não visualizar Regulagem Unitens das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_reg_uni" runat="server" Visible="true">
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Regulagem Unitens</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body">Título Real(dtex)</td>
		<td><asp:TextBox id="txt_tre_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Inicio -->
        <tr>
        <td class="font_body">Fault Duration(s)</td>
		<td><asp:TextBox id="txt_dur_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Upper Mean(cN)</td>
		<td><asp:TextBox id="txt_ume_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body" style="width:150px">Lower Mean(cN)</td>
		<td><asp:TextBox id="txt_lme_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Upper Peak(cN)</td>
		<td><asp:TextBox id="txt_upe_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">Lower Peak(cN)</td>
		<td><asp:TextBox id="txt_lpe_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Upper CV(%)</td>
		<td><asp:TextBox id="txt_ucv_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">Lower CV(%)</td>
		<td><asp:TextBox id="txt_lcv_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Fim -->
        <tr class="linha_par">
        <td class="font_body">Mean Drift(cN)</td>
		<td><asp:TextBox id="txt_dft_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Inicio -->
        <tr>
        <td class="font_body">Upper peak C(nº)</td>
		<td><asp:TextBox id="txt_upc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Lower peak C(nº)</td>
		<td><asp:TextBox id="txt_lpc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">Upper mean C(nº)</td>
		<td><asp:TextBox id="txt_umc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Lower mean C(nº)</td>
		<td><asp:TextBox id="txt_lmc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">Upper CV C(nº)</td>
		<td><asp:TextBox id="txt_cvc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Lower CV C(nº)</td>
		<td><asp:TextBox id="txt_lvc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Fim -->
        <tr>
        <td class="font_body">Mean Drift C(nº)</td>
		<td><asp:TextBox id="txt_dfc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Total Fault Sum(nº)</td>
		<td><asp:TextBox id="txt_tfs_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">F Sum Window(nº)</td>
		<td><asp:TextBox id="txt_fsw_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">Width F Wind(min)</td>
		<td><asp:TextBox id="txt_wfw_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Inicio -->
        <tr>
        <td class="font_body">Yarn Break Threshold(cN)</td>
		<td><asp:TextBox id="txt_ybt_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Fim -->
    </table>       
    </asp:Panel>
	</td>

	<td>
    <!-- Criado novo painel para não visualizar Régua e Encosto das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_reg_enc" runat="server" Visible="true">
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Régua e Encosto</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body" style="width:150px">P1-Constant Main(bar)</td>
		<td><asp:TextBox id="txt_p1c_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">P2-Down Thr. Arm(bar)</td>
		<td><asp:TextBox id="txt_p2d_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">P3-Down Cradle(bar)</td>
        <td><asp:TextBox id="txt_p3d_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">P4-Up Cradle(bar)</td>
		<td><asp:TextBox id="txt_p4u_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Regulagem Mola</td>
		<td><asp:TextBox id="txt_mol_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>       	
    </asp:Panel>
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Tensões</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body" style="width:150px">Pre-Draw</td>
		<td><asp:TextBox id="txt_tpd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T-1</td>
		<td><asp:TextBox id="txt_tt1_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T-2</td>
		<td><asp:TextBox id="txt_tt2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T-3</td>
		<td><asp:TextBox id="txt_tt3_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T2/T1</td>
		<td><asp:TextBox id="txt_t21_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- Criado novo painel para não visualizar Tensões das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_ten" runat="server" Visible="true">
		<tr>
        <td class="font_body">UNITENS</td>
		<td><asp:TextBox id="txt_tun_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C.V. UNITENS</td>
		<td><asp:TextBox id="txt_tcv_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        </asp:Panel>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_ten" runat="server" Visible="false">
        <tr>
		    <td class="font_body">Tensão do TCS(cN)</td>
		    <td><asp:TextBox id="txt_tcs_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CV%</td>
		    <td><asp:TextBox id="txt_cvp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Surge Speed(m/min)</td>
		    <td><asp:TextBox id="txt_ssv_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Surge Speed(%)</td>
		    <td><asp:TextBox id="txt_ssp_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:100px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
        <!-- Fim TMT-->
    </table>       

    <!-- Início TMT-->
    <asp:Panel ID="pnl_tmt_rol" runat="server" Visible="false">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Roller Switch</td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">Oil</td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR0</td>
            <td>
			<asp:DropDownList ID="cbo_rr0_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_rr0_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR01</td>
            <td>
			<asp:DropDownList ID="cbo_r01_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_r01_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR1</td>
            <td>
			<asp:DropDownList ID="cbo_rr1_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR2</td>
            <td>
			<asp:DropDownList ID="cbo_rr2_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR2A</td>
            <td>
			<asp:DropDownList ID="cbo_r2a_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR3</td>
            <td>
			<asp:DropDownList ID="cbo_rr3_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">WR</td>
            <td>
			<asp:DropDownList ID="cbo_rwr_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
    </table>       
    </asp:Panel>
    <!-- Fim TMT-->

    <!-- Criado novo painel para não visualizar Regulagens Barco das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_reg_bar" runat="server" Visible="true">
    <table>
	    <tr>
		    <td colspan="2" class="destaque">Regulagens Barco</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body" style="width:150px">Short Quality</td>
		<td><asp:TextBox id="txt_rsq_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Long Quality</td>
		<td><asp:TextBox id="txt_rlq_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Ref Mean Dev</td>
		<td><asp:TextBox id="txt_rrm_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Max CV</td>
		<td><asp:TextBox id="txt_rmx_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Min CV</td>
		<td><asp:TextBox id="txt_rmn_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Max Hariness</td>
		<td><asp:TextBox id="txt_rmh_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Quality Stop Limits</td>
		<td><asp:TextBox id="txt_rqs_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Thick Yarn Stop</td>
		<td><asp:TextBox id="txt_rty_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Thin Yarn Stop</td>
		<td><asp:TextBox id="txt_rhy_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>       
    </asp:Panel>

    <!-- Criado novo painel para não visualizar Doff Sequence Times das outras máquinas(TMT)-->
    <asp:Panel ID="pnl_dof" runat="server" Visible="true">
    <table>       
	    <tr>
		    <td colspan="2" class="destaque">Doff Sequence Times</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body" style="width:150px">Off-oil lifter UP</td>
		<td><asp:TextBox id="txt_eol_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Off traversing lifter UP</td>
		<td><asp:TextBox id="txt_etu_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Off traversing lifter DOWN</td>
		<td><asp:TextBox id="txt_etd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle UP</td>
		<td><asp:TextBox id="txt_ecu_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <tr class="linha_par">
        <td class="font_body">End Caps Open</td>
		<td><asp:TextBox id="txt_eco_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Tube Gripper DOWN</td>
		<td><asp:TextBox id="txt_egd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">EndCaps CLOSE</td>
		<td><asp:TextBox id="txt_eec_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle DOWN</td>
		<td><asp:TextBox id="txt_ecd_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tube Gripper UP</td>
		<td><asp:TextBox id="txt_egu_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">String-up device OUT</td>
		<td><asp:TextBox id="txt_eso_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">String-up device IN</td>
		<td><asp:TextBox id="txt_esi_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle RESET</td>
		<td><asp:TextBox id="txt_ecr_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Off-oil lifter DOWN</td>
		<td><asp:TextBox id="txt_eod_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Aux.step. WAITING</td>
		<td><asp:TextBox id="txt_eaw_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Duration after Start Point 1</td>
		<td><asp:TextBox id="txt_ed1_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Duration after Start Point 2</td>
		<td><asp:TextBox id="txt_ed2_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        <!-- 26/09/2014 Inicio -->
		<tr class="linha_par">
        <td class="font_body">Injectors durring doff</td>
        <td>
			<asp:DropDownList ID="cbo_idd_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
			</asp:DropDownList>
        </td>
		</tr>
        <!-- 26/09/2014 Fim -->
        <!--
        <tr>
        <td class="font_body">Tensão Spx</td>
		<td><asp:TextBox id="txt_spx_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
        -->
    </table>
    </asp:Panel>
	</td>
    </tr>

    <asp:Panel ID="pnl_afk3" runat="server" Visible="true">
	<tr style="vertical-align:top">
	<td>
    <table width="260px">       
	    <tr>
		    <td colspan="2" class="destaque">Enrolamento AFK 3</td>
	    </tr>
        <tr class="linha_par">
        <td class="font_body" style="width:150px">Taper Angle(º)</td>
		<td><asp:TextBox id="txt_eta_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Starting Taper Height(mm)</td>
		<td><asp:TextBox id="txt_eth_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Starting Taper Gradient(%)</td>
		<td><asp:TextBox id="txt_etg_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Diameter Tube(mm)</td>
		<td><asp:TextBox id="txt_edt_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diameter Full Package(mm)</td>
		<td><asp:TextBox id="txt_efp_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Decrease of Yarn tension(%)</td>
		<td><asp:TextBox id="txt_eyt_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Overfeed W5 Dye Layer(%)</td>
		<td><asp:TextBox id="txt_edl_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Anti-Bulging(mm)</td>
		<td><asp:TextBox id="txt_eab_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Crossing Angle(º)</td>
		<td><asp:TextBox id="txt_eca_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Additional Length Center Wrap(Rev.)</td>
		<td><asp:TextBox id="txt_ecw_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Length Transfer-Tail Dye Layer(Rev.)</td>
		<td><asp:TextBox id="txt_etl_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Length Transfer-Tail(Rev.)</td>
		<td><asp:TextBox id="txt_ett_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Right Edge of Package(mm)</td>
		<td><asp:TextBox id="txt_ere_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Left Edge of Package(mm)</td>
		<td><asp:TextBox id="txt_ele_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Position Transfer Tail(mm)</td>
		<td><asp:TextBox id="txt_ept_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Position Transfer Tail Dye Layer(mm)</td>
		<td><asp:TextBox id="txt_epl_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		</tr>
    </table>       
	</td>
	<td>
	</td>
	<td>
	</td>
    </tr>
    </asp:Panel>

    </table>       
	</td>
    </tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Detalhes</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:TextBox id="txt_det_inc" runat="server" CssClass="text_box"  maxlength="1600"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 		</td>
	</tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Observação</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:TextBox id="txt_obs_inc" runat="server" CssClass="text_box"  maxlength="1600"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 
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
		<td colspan="4" class="font_body">Atualizado em: <asp:Label ID="lb_tms_atl" runat="server"/>, criado por: <asp:Label ID="lb_usr_atl" runat="server"/></td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" onclick="btSalvar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" onclick="btVoltar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" Onclick="btNovoFiltro_Click" />
		</td>
	</tr>
</table>
</div>
</div>
</form>
</body>
</html>