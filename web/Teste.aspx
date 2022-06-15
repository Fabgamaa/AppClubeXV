<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Teste.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : Teste.aspx 
Criado em         : 08/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Teste 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmTeste" runat="server" action="Teste.aspx">
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
			Pesquisar Teste
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">RTS</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_rts" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
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
		<td colspan="2" class="font_body">Merge</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_mge" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
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
		<td colspan="2" class="font_body">Data Inicio</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat_ini" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data Fim</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
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
			Pesquisar Teste
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvTeste" DataKeyNames="TST_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvTeste_RowDataBound"  OnSorting="gvTeste_Sorting"
				OnRowCreated="gvTeste_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" RTS " SortExpression="TST_RTS_ID" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_RTS_ID" runat="server" Text='<%# Eval("TST_RTS_ID") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="TST_LOT" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_LOT" runat="server" Text='<%# Eval("TST_LOT") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Merge " SortExpression="TST_MGE" ControlStyle-Width="100px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_MGE" runat="server" Text='<%# Eval("TST_MGE") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tipo Máquina " SortExpression="MAQ_TIP_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbMAQ_TIP_DES" runat="server" Text='<%# Eval("MAQ_TIP_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data Inicio " SortExpression="TST_DAT_INI" ControlStyle-Width="160px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_DAT_INI" runat="server" Text='<%# String.IsNullOrEmpty(Eval("TST_DAT_INI").ToString())?"":Convert.ToDateTime(Eval("TST_DAT_INI").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data Fim " SortExpression="TST_DAT_FIM" ControlStyle-Width="160px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_DAT_FIM" runat="server" Text='<%# String.IsNullOrEmpty(Eval("TST_DAT_FIM").ToString())?"":Convert.ToDateTime(Eval("TST_DAT_FIM").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="TST_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbTST_STS" runat="server" Text='<%# (Eval("TST_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
			Teste
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td class="font_body">RTS</td>
		<td colspan="3" class="font_body">Motivo do Teste</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_rts_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_rts_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td colspan="3">
			<asp:DropDownList ID="cbo_mtv_tst_id_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_lot_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td class="font_body">Lote Referência</td>
		<td class="font_body">Lote Standard</td>
		<td colspan="2" class="font_body">Lote Serimetria</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_lot_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_lot_ref_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td>
			<asp:TextBox id="txt_lot_epf_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_lot_epf_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> 
		</td>
		<td colspan="2">
			<asp:TextBox id="txt_lot_ans_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_lot_ans_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> 
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
			<asp:TextBox id="txt_mge_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td>
			<asp:TextBox id="txt_mge_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 1 Referência</td>
		<td class="font_body">Merge 2 Referência</td>
		<td class="font_body">Merge 3 Referência</td>
		<td class="font_body">Merge 4 Referência</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td>
			<asp:TextBox id="txt_mge_002_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_003_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
		<td>
			<asp:TextBox id="txt_mge_004_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="txt_mge_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td class="font_body">Fornecedor 1</td>
		<td class="font_body">Fornecedor 2</td>
		<td class="font_body">Fornecedor 3</td>
		<td class="font_body">Fornecedor 4</td>
	</tr>
	<tr>
		<td>
    		<asp:DropDownList ID="cbo_for_001_id_inc" runat="server" CssClass="combo_box">
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
		<td colspan="4" class="font_body">Data Início</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_dat_ini_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="calculaTempoGasto" AutoPostBack="true"></asp:TextBox> * &nbsp; 
			<asp:TextBox id="txt_hor_ini_inc" runat="server" CssClass="text_box"  maxlength="05" style="width:050px" OnTextChanged="calculaTempoGasto" AutoPostBack="true"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td class="font_body">Data Fim</td>
		<td colspan="3" class="font_body">Tempo Gasto</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_dat_fim_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="calculaTempoGasto" AutoPostBack="true"></asp:TextBox> * &nbsp; 
			<asp:TextBox id="txt_hor_fim_inc" runat="server" CssClass="text_box"  maxlength="05" style="width:050px" OnTextChanged="calculaTempoGasto" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td colspan="3">
			<asp:TextBox id="txt_hor_gst_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" readonly="true"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="destaque">Condições de Operação</td>
	</tr>

	<tr>
	<td colspan="4">
    <table width="800px">
        
		<tr>
        <td class="font_body">&nbsp;</td>
        <td class="font_body_destaque">Referência</td>
        <td class="font_body_destaque">Teste 01</td>
        <td class="font_body_destaque">Teste 02</td>
        <td class="font_body_destaque">Teste 03</td>
        <td class="font_body_destaque">Teste 04</td>
        <td class="font_body_destaque">Teste 05</td>
        <td class="font_body_destaque">Teste 06</td>
        <td class="font_body_destaque">Teste 07</td>
        </tr>
        <asp:Panel ID="pnl_afk" runat="server" Visible="true">
		<tr>
        <td class="font_body"><asp:label id="lbl_vw2" runat="server" Text="Velocidade W2(m/min)"></asp:label></td>
		<td><asp:TextBox id="txt_vw2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vw2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Taxa de estiragem</td>
		<td><asp:TextBox id="txt_egm_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egm_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"><asp:label id="lbl_edy" runat="server" Text="D/Y"></asp:label></td>
		<td><asp:TextBox id="txt_dyy_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dyy_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body"><asp:label id="lbl_ewx" runat="server" Text="2nd Overfeed  - WX(%)"></asp:label></td>
		<td><asp:TextBox id="txt_2wx_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2wx_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"><asp:label id="lbl_ew3" runat="server" Text="3rd  Overfeed  - W3(%)"></asp:label></td>
		<td><asp:TextBox id="txt_3w3_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_3w3_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body"><asp:label id="lbl_ew4" runat="server" Text="4rd  Overfeed  - W4(%)"></asp:label></td>
		<td><asp:TextBox id="txt_4w4_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_4w4_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        <!-- Criado novo painel para não visualizar Take Up Program das outras máquinas(TMT)-->
        <asp:Panel ID="pnl_tup" runat="server" Visible="true">
		<tr>
        <td class="font_body">Ângulo de cruzamento</td>
		<td><asp:TextBox id="txt_agl_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_agl_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Take Up Program</td>
		<td><asp:TextBox id="txt_tup_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tup_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
		<tr>
        <td class="font_body">Vel. Eixo óleo (rpm)</td>
		<td><asp:TextBox id="txt_veo_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_veo_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T1 - Texturização - (ºC)</td>
		<td><asp:TextBox id="txt_t1t_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1t_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T1 - Estufa curta - (ºC)</td>
		<td><asp:TextBox id="txt_t1c_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1c_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T1 - Estufa Longa - (ºC)</td>
		<td><asp:TextBox id="txt_t1l_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t1l_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_ope" runat="server" Visible="false">
	    <tr>
		    <td class="font_body">T0(Hot-pin)</td>
		    <td><asp:TextBox id="txt_hot_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_hot_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Torção(VR Direction)</td>
		    <td><asp:TextBox id="txt_vrd_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_vrd_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Ângulo de Cruzamento</td>
		    <td><asp:TextBox id="txt_acr_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_acr_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Padrão de Enrolamento</td>
		    <td><asp:TextBox id="txt_pen_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_pen_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Creeping Ratio</td>
		    <td><asp:TextBox id="txt_cra_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Creeping Length/o</td>
		    <td><asp:TextBox id="txt_cle_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cle_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Ângulo de Formação</td>
		    <td><asp:TextBox id="txt_afo_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_afo_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Taper Curve</td>
			<td>
			<asp:DropDownList ID="cbo_tcu_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tcu_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="NONE (STRAIGHT)" Text="NONE (STRAIGHT)"></asp:ListItem>
				<asp:ListItem value="1:WOOLY" Text="1:WOOLY"></asp:ListItem>
				<asp:ListItem value="2:SET" Text="2:SET"></asp:ListItem>
				<asp:ListItem value="3:SPECIAL" Text="3:SPECIAL"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">Taper Adjustment Ratio</td>
		    <td><asp:TextBox id="txt_tar_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tar_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Taper Angle Multistage</td>
			<td>
			<asp:DropDownList ID="cbo_tam_ref_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_ref_inc_OnSelectedIndexChanged" AutoPostBack="true" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_001_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_001_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_002_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_002_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_003_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_003_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_004_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_004_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_005_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_005_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_006_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_006_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_tam_007_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tam_007_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr>
		    <td class="font_body">Second Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_std_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_std_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Second Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_stp_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_stp_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Third Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_ttd_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttd_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Third Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_ttp_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ttp_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Fourth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_ftd_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftd_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Fourth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_ftp_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ftp_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Fifth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_itd_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itd_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Fifth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_itp_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_itp_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr>
		    <td class="font_body">Sixth Taper Angle [deg]</td>
		    <td><asp:TextBox id="txt_xtd_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtd_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Sixth Taper Angle PGK diameter (mm)</td>
		    <td><asp:TextBox id="txt_xtp_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_xtp_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>

		<tr class="linha_par">
		    <td class="font_body">Diâmetro do Tubo</td>
		    <td><asp:TextBox id="txt_dtu_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dtu_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
        <tr>
		    <td class="font_body">Diâmetro do Pacote</td>
		    <td><asp:TextBox id="txt_dpa_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dpa_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Curso Inicial</td>
		    <td><asp:TextBox id="txt_cin_ref_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_001_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_002_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_003_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_004_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_005_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_006_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cin_007_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:80px"></asp:TextBox></td>
	    </tr>
        <tr>
            <td></td>
            <td style="background-color:Silver">
			<asp:DropDownList ID="cbo_tip_fr2_ref_inc" runat="server" CssClass="combo_box">
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
		    <br/>
            <asp:TextBox id="txt_fr2_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_001_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_002_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_003_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_004_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_005_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_006_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr2_007_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr2_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
            <td></td>
            <td style="background-color:Silver">
			<asp:DropDownList ID="cbo_tip_fr1_ref_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_001_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_002_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_003_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_004_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_005_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_006_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr1_007_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr1_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr>
            <td></td>
            <td style="background-color:Silver">
			<asp:DropDownList ID="cbo_tip_fr0_ref_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_ref_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_001_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_002_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_003_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_004_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_005_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_006_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
            <td>
			<asp:DropDownList ID="cbo_tip_fr0_007_inc" runat="server" CssClass="combo_box">
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
            <br/>
            <asp:TextBox id="txt_fr0_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:80px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
        <!-- Fim TMT-->

		<tr>
        <td class="font_body">T2 - Fixação - (ºC)</td>
		<td><asp:TextBox id="txt_t2f_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t2f_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tensão Alim (g)</td>
		<td><asp:TextBox id="txt_tal_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tal_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Voltas Alim</td>
		<td><asp:TextBox id="txt_val_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_val_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Sentido Jet</td>
		<td><asp:TextBox id="txt_sje_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sje_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
		<tr class="linha_par">
        <asp:Panel ID="pnl_sta" runat="server" Visible="false">
        <td class="font_body">Velocidade(m/min)</td>
		<td><asp:TextBox id="txt_sve_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sve_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Taxa de fixação</td>
		<td><asp:TextBox id="txt_stf_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stf_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Temperatura Fixação(°C)</td>
		<td><asp:TextBox id="txt_stm_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_stm_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">C-Taxa de Estiragem</td>
		<td><asp:TextBox id="txt_sce_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sce_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C-Overfeed(%)</td>
		<td><asp:TextBox id="txt_sco_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sco_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">C-Temp. Hot Pin(°C)</td>
		<td><asp:TextBox id="txt_sch_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sch_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C-Temp. Godet(°C)</td>
		<td><asp:TextBox id="txt_scg_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_scg_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E-Taxa de Estiragem</td>
		<td><asp:TextBox id="txt_see_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_see_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">E-Overfeed(%)</td>
		<td><asp:TextBox id="txt_seo_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seo_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E-Temp. Hot Pin(°C)</td>
		<td><asp:TextBox id="txt_seh_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seh_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">E-Temp. Godet(°C)</td>
		<td><asp:TextBox id="txt_seg_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_seg_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Jet Core</td>
		<td><asp:TextBox id="txt_sjc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Jet Type</td>
		<td><asp:TextBox id="txt_sjt_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjt_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Jet Body</td>
		<td><asp:TextBox id="txt_sjb_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sjb_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão Jet(bar)</td>
		<td><asp:TextBox id="txt_spj_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spj_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Dist. Bola/Carcaça(mm)</td>
		<td><asp:TextBox id="txt_sbc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sbc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Programa</td>
		<td><asp:TextBox id="txt_spo_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_spo_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Variação</td>
		<td><asp:TextBox id="txt_sva_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_sva_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
	    <tr>
		    <td colspan="9" class="destaque">Regulagens Manuais</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Tipo Agregado</td>
		<td><asp:TextBox id="txt_tgr_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tgr_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Tipo Disco</td>
		<td><asp:TextBox id="txt_tip_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tip_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diposição dos discos</td>
		<td><asp:TextBox id="txt_dsb_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dsb_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Torção</td>
		<td><asp:TextBox id="txt_tca_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tca_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Ângulo de formação</td>
		<td><asp:TextBox id="txt_fmc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fmc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"># 1 Tipo de Buso</td>
		<td><asp:TextBox id="txt_1tb_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1tb_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão (psi)</td>
		<td><asp:TextBox id="txt_1pp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_1pp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body"># 2 Tipo de Buso</td>
		<td><asp:TextBox id="txt_2tb_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2tb_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Pressão (psi)</td>
		<td><asp:TextBox id="txt_2pp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_2pp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Curso</td>
		<td><asp:TextBox id="txt_cso_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cso_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Espaçamento</td>
		<td><asp:TextBox id="txt_esp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Tipo de Óleo</td>
		<td><asp:TextBox id="txt_tol_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tol_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_reg" runat="server" Visible="false">
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">Ângulo de Torção</td>
		    <td><asp:TextBox id="txt_ato_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ato_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body" style="width:150px">P1</td>
		    <td><asp:TextBox id="txt_tp1_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp1_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">P2</td>
		    <td><asp:TextBox id="txt_tp2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tp2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CP</td>
		    <td><asp:TextBox id="txt_tcp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tcp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">JET FR2A</td>
		    <td><asp:TextBox id="txt_jf2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Pressão</td>
		    <td><asp:TextBox id="txt_ps2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">JET FR0</td>
		    <td><asp:TextBox id="txt_jf0_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_jf0_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Pressão</td>
		    <td><asp:TextBox id="txt_ps0_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ps0_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Baffle Bar</td>
		    <td><asp:TextBox id="txt_bba_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_bba_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Guias Rotativos</td>
		    <td><asp:TextBox id="txt_gro_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_gro_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
        </asp:Panel>
        <!-- Fim TMT-->

        <!-- Início TMT-->
        <asp:Panel ID="pnl_tmt_tcs" runat="server" Visible="false">
	    <tr>
		    <td colspan="9" class="destaque">Regulagens TCS</td>
	    </tr>
        <tr>
        <td colspan="9">
        <table>
        <tr class="linha_par">
        <td class="font_body">Título Real(dtex)</td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td colspan="2"><asp:TextBox id="txt_ttr_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">PLY LAYOUT</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
		    <td class="font_body">PLY 1</td>
		    <td class="font_body">PLY 2</td>
	    </tr>
	    <tr>
		    <td class="font_body" style="width:150px">Target Tension</td>
		    <td><asp:TextBox id="txt_tte_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tte_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Winding Position</td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
			<td>
			<asp:DropDownList ID="cbo_wpo_002_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_001_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_wpo_002_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1 ODD SP" Text="1 ODD SP"></asp:ListItem>
				<asp:ListItem value="2 EVEN SP" Text="2 EVEN SP"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">Direction</td>
		    <td><asp:TextBox id="txt_dir_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dir_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Control Range</td>
		    <td><asp:TextBox id="txt_cra_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cra_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Control Error Detect</td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
			<td>
			<asp:DropDownList ID="cbo_ced_002_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_001_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td>
			<asp:DropDownList ID="cbo_ced_002_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
				<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Tension Deviation</td>
		    <td><asp:TextBox id="txt_ted_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ted_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Detect Lenght</td>
		    <td><asp:TextBox id="txt_dle_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_dle_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Count Times</td>
		    <td><asp:TextBox id="txt_cti_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cti_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL1O</td>
		    <td><asp:TextBox id="txt_g1o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1U</td>
		    <td><asp:TextBox id="txt_g1u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g1u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2O</td>
		    <td><asp:TextBox id="txt_g2o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2U</td>
		    <td><asp:TextBox id="txt_g2u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_g2u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CV(%)</td>
		    <td><asp:TextBox id="txt_cvp_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvp_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Over Cut(%)</td>
		    <td><asp:TextBox id="txt_ocu_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ocu_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Under Cut(%)</td>
		    <td><asp:TextBox id="txt_ucu_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_ucu_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1O Count</td>
		    <td><asp:TextBox id="txt_c1o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL1O Length</td>
		    <td><asp:TextBox id="txt_l1o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL1U Count</td>
		    <td><asp:TextBox id="txt_c1u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c1u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL1U Length</td>
		    <td><asp:TextBox id="txt_l1u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l1u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2O Count</td>
		    <td><asp:TextBox id="txt_c2o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2O Length</td>
		    <td><asp:TextBox id="txt_l2o_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2o_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">GL2U Count</td>
		    <td><asp:TextBox id="txt_c2u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_c2u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">GL2U Length</td>
		    <td><asp:TextBox id="txt_l2u_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_l2u_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">Total Sum</td>
		    <td><asp:TextBox id="txt_tsu_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tsu_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">CV Count</td>
		    <td><asp:TextBox id="txt_cvc_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvc_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">CV Lenght</td>
		    <td><asp:TextBox id="txt_cvl_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvl_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
	    <tr>
		    <td class="font_body">Total Length</td>
		    <td><asp:TextBox id="txt_tle_001_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_001_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tle_002_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
	    </tr>
        </table>
        </td>
        </tr>        
        </asp:Panel>

	    <tr>
		    <td colspan="9" class="destaque">Régua e Encosto</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">P1-Constant Main</td>
		<td><asp:TextBox id="txt_p1c_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p1c_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">P2-Down Thr. Arm</td>
		<td><asp:TextBox id="txt_p2d_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p2d_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">P3-Down Cradle</td>
        <td><asp:TextBox id="txt_p3d_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p3d_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">P4-Up Cradle</td>
		<td><asp:TextBox id="txt_p4u_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_p4u_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Regulagem Mola</td>
		<td><asp:TextBox id="txt_mol_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_mol_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
	    <tr>
		    <td colspan="9" class="destaque">Tensões</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Pre-Draw</td>
		<td><asp:TextBox id="txt_tpd_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tpd_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T-1</td>
		<td><asp:TextBox id="txt_tt1_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt1_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T-2</td>
		<td><asp:TextBox id="txt_tt2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">T-3</td>
		<td><asp:TextBox id="txt_tt3_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tt3_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">T2/T1</td>
		<td><asp:TextBox id="txt_t21_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_t21_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">UNITENS</td>
		<td><asp:TextBox id="txt_tun_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tun_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C.V. UNITENS</td>
		<td><asp:TextBox id="txt_tcv_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcv_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">SURGE SPEED</td>
		<td><asp:TextBox id="txt_tss_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tss_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

        <!-- Inicio TMT-->
        <asp:Panel ID="pnl_tmt_ten" runat="server" Visible="false">
		<tr>
        <td class="font_body">Tensão do TCS</td>
		<td><asp:TextBox id="txt_tcs_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tcs_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">C.V. %</td>
		<td><asp:TextBox id="txt_cvp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">SURGE SPEED(m/min)</td>
		<td><asp:TextBox id="txt_ssv_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssv_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        <tr>
        <td class="font_body">SURGE SPEED(%)</td>
		<td><asp:TextBox id="txt_ssp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ssp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
        </asp:Panel>
        <!-- Fim TMT-->

        <!-- Início TMT-->
        <asp:Panel ID="pnl_tmt_rol" runat="server" Visible="false">
	    <tr>
		    <td colspan="9" class="destaque">Roller Switch</td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body" style="width:150px">Oil</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_roi_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_roi_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR0</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_rr0_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr0_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR01</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_r01_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r01_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR1</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_rr1_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr1_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR2</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_rr2_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr2_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">FR2A</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_r2a_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text=3></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_r2a_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
		<tr class="linha_par">
		    <td class="font_body">FR3</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_rr3_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rr3_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
	    <tr>
		    <td class="font_body">WR</td>
            <td style="width:100px;background-color:Silver">
			<asp:DropDownList ID="cbo_rwr_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_001_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_002_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_003_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_004_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_005_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_006_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
            <td style="width:100px">
			<asp:DropDownList ID="cbo_rwr_007_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="ON" Text="ON"></asp:ListItem>
				<asp:ListItem value="OFF" Text="OFF"></asp:ListItem>
			</asp:DropDownList>
            </td>
	    </tr>
        </asp:Panel>
        <!-- Fim TMT-->

	    <tr>
		    <td colspan="9" class="destaque">Serimetria</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Título (dtex)</td>
		<td><asp:TextBox id="txt_tit_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tit_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tenacidade (cN/dtex)</td>
		<td><asp:TextBox id="txt_tnc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tnc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Alongamento (%)</td>
		<td><asp:TextBox id="txt_aon_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_aon_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Encolhimento (%)</td>
		<td><asp:TextBox id="txt_enm_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_enm_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">E%</td>
		<td><asp:TextBox id="txt_eee_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eee_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">K%</td>
		<td><asp:TextBox id="txt_kkk_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_kkk_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">B%</td>
		<td><asp:TextBox id="txt_bbb_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_bbb_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Óleo (%)</td>
		<td><asp:TextBox id="txt_ole_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ole_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Torque  (T/m/s)</td>
		<td><asp:TextBox id="txt_trq_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_trq_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Entrelaçamento</td>
		<td><asp:TextBox id="txt_ert_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ert_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Retenção  (3%)</td>
		<td><asp:TextBox id="txt_rt3_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt3_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Retenção  (5%)</td>
		<td><asp:TextBox id="txt_rt5_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_rt5_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Densidade (g/cm3)</td>
		<td><asp:TextBox id="txt_dnd_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dnd_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diâmetro (cm)</td>
		<td><asp:TextBox id="txt_dmo_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dmo_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Peso (g)</td>
		<td><asp:TextBox id="txt_pes_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pes_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tempo de Virada</td>
		<td><asp:TextBox id="txt_vrr_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_vrr_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">% de Core</td>
		<td><asp:TextBox id="txt_pco_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pco_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">% de Cover</td>
		<td><asp:TextBox id="txt_pcv_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_pcv_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Draft</td>
		<td><asp:TextBox id="txt_drt_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_drt_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

	    <tr>
		    <td colspan="9" class="destaque">Regulagem Unitens</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Título Real (dtex)</td>
		<td><asp:TextBox id="txt_tre_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tre_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper Mean (cN)</td>
		<td><asp:TextBox id="txt_ume_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ume_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower Mean (cN)</td>
		<td><asp:TextBox id="txt_lme_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lme_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper Peak (cN)</td>
		<td><asp:TextBox id="txt_upe_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upe_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower Peak (cN)</td>
		<td><asp:TextBox id="txt_lpe_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpe_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper CV (%)</td>
		<td><asp:TextBox id="txt_ucv_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ucv_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower CV (%)</td>
		<td><asp:TextBox id="txt_lcv_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lcv_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Fault Duration (s)</td>
		<td><asp:TextBox id="txt_dur_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dur_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Mean Drift (cN)</td>
		<td><asp:TextBox id="txt_dft_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dft_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper mean C (nº)</td>
		<td><asp:TextBox id="txt_umc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_umc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower mean C (nº)</td>
		<td><asp:TextBox id="txt_lmc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lmc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper peak C (nº)</td>
		<td><asp:TextBox id="txt_upc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_upc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower peak C (nº)</td>
		<td><asp:TextBox id="txt_lpc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lpc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Upper CV C (nº)</td>
		<td><asp:TextBox id="txt_cvc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_cvc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Lower CV C (nº)</td>
		<td><asp:TextBox id="txt_lvc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_lvc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Mean Drift C (nº)</td>
		<td><asp:TextBox id="txt_dfc_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_dfc_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Total Fault Sum (nº)</td>
		<td><asp:TextBox id="txt_tfs_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_tfs_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">F Sum Window (nº)</td>
		<td><asp:TextBox id="txt_fsw_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_fsw_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Width F Wind (min)</td>
		<td><asp:TextBox id="txt_wfw_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_wfw_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Yarn Break Thresshold (cN)</td>
		<td><asp:TextBox id="txt_ybt_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ybt_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

	    <tr>
		    <td colspan="9" class="destaque">Doff Sequence Times</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Off-oil lifter UP</td>
		<td><asp:TextBox id="txt_eol_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eol_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Off traversing lifter UP</td>
		<td><asp:TextBox id="txt_etu_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etu_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Off traversing lifter DOWN</td>
		<td><asp:TextBox id="txt_etd_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etd_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle UP</td>
		<td><asp:TextBox id="txt_ecu_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecu_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">End Caps Open</td>
		<td><asp:TextBox id="txt_eco_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eco_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Tube Gripper DOWN</td>
		<td><asp:TextBox id="txt_egd_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egd_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">EndCaps CLOSE</td>
		<td><asp:TextBox id="txt_eec_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eec_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle DOWN</td>
		<td><asp:TextBox id="txt_ecd_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecd_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Tube Gripper UP</td>
		<td><asp:TextBox id="txt_egu_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_egu_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">String-up device OUT</td>
		<td><asp:TextBox id="txt_eso_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eso_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">String-up device IN</td>
		<td><asp:TextBox id="txt_esi_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_esi_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Cradle RESET</td>
		<td><asp:TextBox id="txt_ecr_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecr_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Off-oil lifter DOWN</td>
		<td><asp:TextBox id="txt_eod_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eod_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Aux.step. WAITING</td>
		<td><asp:TextBox id="txt_eaw_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eaw_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Duration after Start Point 1</td>
		<td><asp:TextBox id="txt_ed1_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed1_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Duration after Start Point 2</td>
		<td><asp:TextBox id="txt_ed2_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ed2_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Injectors during doff</td>
		<td>
		<asp:DropDownList ID="cbo_idd_ref_inc" runat="server" CssClass="combo_box" Enabled="false">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_001_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_002_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_003_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_004_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_005_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_006_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
        <td>
		<asp:DropDownList ID="cbo_idd_007_inc" runat="server" CssClass="combo_box">
			<asp:ListItem value="" Text=""></asp:ListItem>
			<asp:ListItem value="ENABLE" Text="ENABLE"></asp:ListItem>
			<asp:ListItem value="DISABLE" Text="DISABLE"></asp:ListItem>
		</asp:DropDownList>
        </td>
		</tr>
	    <tr>
		    <td colspan="9" class="destaque">Enrolamento AFK 3</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Taper Angle (º)</td>
		<td><asp:TextBox id="txt_eta_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eta_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Starting Taper Height (mm)</td>
		<td><asp:TextBox id="txt_eth_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eth_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Starting Taper Gradient (%)</td>
		<td><asp:TextBox id="txt_etg_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etg_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Diameter Tube (mm)</td>
		<td><asp:TextBox id="txt_edt_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edt_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Diameter Full Package (mm)</td>
		<td><asp:TextBox id="txt_efp_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_efp_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Decrease of Yarn tension (%)</td>
		<td><asp:TextBox id="txt_eyt_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eyt_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Overfeed W5 Dye Layer (%)</td>
		<td><asp:TextBox id="txt_edl_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_edl_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Anti-Bulging (mm)</td>
		<td><asp:TextBox id="txt_eab_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eab_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Crossing Angle (º)</td>
		<td><asp:TextBox id="txt_eca_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_eca_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Additional Length Center Wrap (Rev.)</td>
		<td><asp:TextBox id="txt_ecw_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ecw_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Length Transfer-Tail Dye Layer (Rev.)</td>
		<td><asp:TextBox id="txt_etl_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_etl_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Length Transfer-Tail (Rev.)</td>
		<td><asp:TextBox id="txt_ett_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ett_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Right Edge of Package (mm)</td>
		<td><asp:TextBox id="txt_ere_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ere_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Left Edge of Package (mm)</td>
		<td><asp:TextBox id="txt_ele_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ele_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Position Transfer Tail (mm)</td>
		<td><asp:TextBox id="txt_ept_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_ept_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>
		<tr>
        <td class="font_body">Position Transfer Tail Dye Layer (mm)</td>
		<td><asp:TextBox id="txt_epl_ref_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_001_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_002_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_003_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_004_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_005_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_006_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		<td><asp:TextBox id="txt_epl_007_inc" runat="server" CssClass="text_box"  maxlength="8" style="width:80px"></asp:TextBox></td>
		</tr>

	    <tr>
		    <td colspan="9" class="destaque">Engrenagens</td>
	    </tr>
		<tr class="linha_par">
        <td class="font_body">Z1 / Z2</td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_ref_inc" runat="server" CssClass="combo_box" style="width:80px; background-color:Silver" Enabled="false"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_001_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_002_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_003_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_004_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_005_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_006_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez1_ez2_007_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
		</tr>
		<tr>
        <td class="font_body">Z3 / Z4</td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_ref_inc" runat="server" CssClass="combo_box" style="width:80px; background-color:Silver" Enabled="false"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_001_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_002_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_003_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_004_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_005_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_006_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez3_ez4_007_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
		</tr>
		<tr class="linha_par">
        <td class="font_body">Z5 / Z6</td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_ref_inc" runat="server" CssClass="combo_box" style="width:80px; background-color:Silver" Enabled="false"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_001_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_002_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_003_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_004_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_005_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_006_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
        <td><asp:DropDownList ID="cbo_ez5_ez6_007_inc" runat="server" CssClass="combo_box" style="width:80px"></asp:DropDownList></td>
		</tr>

    </table>
    </td>
	</tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="destaque">Dynafil</td>
	</tr>
	<tr>
		<td colspan="4" >
			<asp:Label ID="Label2" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvDynafil" DataKeyNames="DNF_MGE" 
				runat="server" AutoGenerateColumns="false" AllowSorting="false" 
				OnRowDataBound="gvDynafil_RowDataBound" 
				OnRowCreated="gvDynafil_RowCreated"
				EmptyDataText="Não foram encontrados registros de Dynafil.">
			<Columns>
			<asp:TemplateField HeaderText=" Merge " SortExpression="DNF_MGE" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbDNF_MGE" runat="server" Text='<%# Eval("DNF_MGE") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Bobinas " SortExpression="QTD_BOB" ControlStyle-Width="40px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbQTD_BOB" runat="server" Text='<%# String.IsNullOrEmpty(Eval("QTD_BOB").ToString())?"":Convert.ToDouble(Eval("QTD_BOB").ToString()).ToString("0") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_MED" ControlStyle-Width="80px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbTIT_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("TIT_MED").ToString())?"":Convert.ToDouble(Eval("TIT_MED").ToString()).ToString("0.00") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tenacidade " SortExpression="TNC_MED" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbTNC_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("TNC_MED").ToString())?"":Convert.ToDouble(Eval("TNC_MED").ToString()).ToString("0.00") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Alongamento " SortExpression="AON_MED" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbAON_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("AON_MED").ToString())?"":Convert.ToDouble(Eval("AON_MED").ToString()).ToString("0.00") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" CV Even " SortExpression="EVE_MED" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbEVE_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("EVE_MED").ToString())?"":Convert.ToDouble(Eval("EVE_MED").ToString()).ToString("0.00") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Fila. Queb. " SortExpression="QBR_MED" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbQBR_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("QBR_MED").ToString())?"":Convert.ToDouble(Eval("QBR_MED").ToString()).ToString("0.00") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Força " SortExpression="FOA_MED" ControlStyle-Width="60px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbFOA_MED" runat="server" Text='<%# String.IsNullOrEmpty(Eval("FOA_MED").ToString())?"":Convert.ToDouble(Eval("FOA_MED").ToString()).ToString("0.00") %>' />
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
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="destaque">Performance</td>
	</tr>
	<tr>
		<td colspan="4" >
			<asp:Label ID="Label1" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvPerformance" DataKeyNames="PFM_ID" 
				runat="server" AutoGenerateColumns="false" AllowSorting="false" 
				OnRowDataBound="gvPerformance_RowDataBound"
				OnRowCreated="gvPerformance_RowCreated"
				EmptyDataText="Não foram encontrados registros de Performance.">
			<Columns>
			<asp:TemplateField HeaderText=" 1ª Qualidade " SortExpression="PFM_QLD_001" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_QLD_001" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_QLD_001").ToString())?"":Convert.ToDouble(Eval("PFM_QLD_001").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Out Sort " SortExpression="PFM_OUT" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_OUT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_OUT").ToString())?"":Convert.ToDouble(Eval("PFM_OUT").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" 2ª Qualidade " SortExpression="PFM_QLD_002" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_QLD_002" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_QLD_002").ToString())?"":Convert.ToDouble(Eval("PFM_QLD_002").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Quebra " SortExpression="PFM_QBR" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_QBR" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_QBR").ToString())?"":Convert.ToDouble(Eval("PFM_QBR").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Afinidade " SortExpression="PFM_AFN" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_AFN" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_AFN").ToString())?"":Convert.ToDouble(Eval("PFM_AFN").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Unitens " SortExpression="PFM_UNT" ControlStyle-Width="50px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_UNT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_UNT").ToString())?"":Convert.ToDouble(Eval("PFM_UNT").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Produção " SortExpression="PFM_PRC" ControlStyle-Width="90px" ItemStyle-HorizontalAlign="Right">
			<ItemTemplate>
				<asp:Label ID="lbPFM_PRC" runat="server" Text='<%# String.IsNullOrEmpty(Eval("PFM_PRC").ToString())?"":Convert.ToDouble(Eval("PFM_PRC").ToString()).ToString("N2") %>'/>
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="PFM_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbPFM_STS" runat="server" Text='<%# (Eval("PFM_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
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
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Detalhes</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:TextBox id="txt_det_inc" runat="server" CssClass="text_box"  maxlength="800"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 
		</td>
	</tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Análise crítica/Verificação/Validação</td>
	</tr>
	<tr>
		<td colspan="4">
    		<asp:TextBox id="txt_obs_inc" runat="server" CssClass="text_box"  maxlength="800"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 
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
			<asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" onclick="btSalvar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btAtualizarStandard" runat="server" Text="Atualizar Standard" CssClass="botao" onclick="btAtualizarStandard_Click" Width="140px"/> &nbsp;&nbsp;
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