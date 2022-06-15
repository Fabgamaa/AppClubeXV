<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Afinidade.aspx.cs" Inherits="_Default" MaintainScrollPositionOnPostback="false"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : Afinidade.aspx 
Criado em         : 29/12/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Afinidade 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
    <style type="text/css">
        .auto-style2 {
            font-size: 8pt;
            color: #191970;
            font-family: Verdana, Arial, 'MS Sans Serif';
            text-decoration: none;
            height: 17px;
            }
        .combo_box {}
        .auto-style3 {
            font-size: 8pt;
            color: #191970;
            font-family: Verdana, Arial, 'MS Sans Serif';
            text-decoration: none;
            height: 26px;
            }
        
        .auto-style4 {
            font-size: 8pt;
            color: #191970;
            font-family: Verdana, Arial, 'MS Sans Serif';
            text-decoration: none;
            text-align: left;
            height: 20px;
        }
        
        .auto-style5 {
            height: 32px;
        }
        
        .auto-style7 {
            height: 20px;
        }
        
    </style>
</head>
<body class="bg" style="margin: 0; width:1231px; height: 1868px;">
    <form id="frmAfinidade" runat="server">
<asp:HiddenField ID="Origem" runat="server" />
<asp:HiddenField ID="rowId" runat="server" />
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Afinidade
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
			<asp:TextBox id="txt_dat" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		</td>
	</tr>
    <tr>
		<td colspan="2" class="font_body">Data Final</td>
	</tr>
    <tr>
		<td colspan="6">
			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		</td>
	</tr>

	<tr>
		<td colspan="2" class="font_body">Tipo</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_tip" runat="server" CssClass="combo_box">
				<asp:ListItem value="1" Text="AFINIDADE"></asp:ListItem>
				<asp:ListItem value="2" Text="LUZ NEGRA"></asp:ListItem>
			    <asp:ListItem Selected="True" Value="0">TODOS</asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" maxlength="10" 
                style="width:100px" ontextchanged="txt_lot_TextChanged" AutoPostBack="true"></asp:TextBox>
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
    <%--	<tr>
		<td class="font_body">Merge 1</td>
		<td class="font_body">Fornecedor 1</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_001" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_001_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 2</td>
		<td class="font_body">Fornecedor 2</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_002" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_002_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 3</td>
		<td class="font_body">Fornecedor 3</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_003" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_003_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
 	<tr>
		<td class="font_body">Merge 4</td>
		<td class="font_body">Fornecedor 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_004" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_004_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
   <tr>
		<td colspan="2" class="font_body">Velocidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vlc" runat="server" CssClass="text_box" maxlength="4" style="width:40px"></asp:TextBox>
		</td>
	</tr>--%>
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
		<td colspan="2" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
    <%--	<tr>
		<td colspan="2" class="font_body">Tipo Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_tip_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>--%>
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
		<td colspan="2" class="font_body">Virada</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vrd" runat="server" CssClass="text_box" maxlength="4" style="width:40px"></asp:TextBox>
		</td>
	</tr>
    <%--	<tr>
		<td colspan="2" class="font_body">Bobina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_bbn" runat="server" CssClass="text_box" maxlength="4" style="width:40px"></asp:TextBox>
		</td>
	</tr>--%><%--<tr>
		<td colspan="2" class="font_body">Analista</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_ana_usr_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>--%>
    <tr>
        <td colspan="2" class="font_body">Defeito</td>  
    </tr>
    <tr>
         <td colspan="2" class="font_body">   
            <asp:DropDownList ID="cbo_def_id" runat="server" CssClass="combo_box" Height="19px" Width="207px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT ">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Resp. Leitura</td>
     </tr>
    <tr>
        <td colspan="2">
            <asp:DropDownList ID="cbo_ana_lei_id" runat="server" CssClass="combo_box" Height="22px" Width="205px"></asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Resp. Liberação</td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:DropDownList ID="cbo_ana_lib_id" runat="server" CssClass="combo_box" Height="22px" Width="205px"></asp:DropDownList>
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
<table style="width:780px"  border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Afinidade
		</td>
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
		<td colspan="2" align="right">
			<asp:Button ID="btVoltarGrid"     runat="server" CssClass="botao" Text="Filtro" Onclick="btVoltar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovoFiltroGrid" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovo_Click" />
		</td>
	</tr>
	<tr>
		<td colspan="2" align="right">
			<asp:LinkButton ID="lkb_pdf" runat="server" OnClick="lkb_pdf_Click" Text="pdf" ToolTip="Exporta para PDF"></asp:LinkButton>
			&nbsp;
			<asp:LinkButton ID="lkb_xls" runat="server" OnClick="lkb_xls_Click" Text="xls" ToolTip="Exporta para XLS"></asp:LinkButton>
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false" ID="gvAfinidade" DataKeyNames="DEF_ID" 
				runat="server" AutoGenerateColumns="False" AllowSorting="True" 
				OnRowDataBound="gvAfinidade_RowDataBound"  OnSorting="gvAfinidade_Sorting"
				OnRowCreated="gvAfinidade_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Data " SortExpression="AFN_DAT" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("AFN_DAT").ToString())?"":Convert.ToDateTime(Eval("AFN_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Semana " SortExpression="AFN_SEM" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_SEM" runat="server" Text='<%# Eval("AFN_SEM") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="AFN_LOT" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_LOT" runat="server" Text='<%# Eval("AFN_LOT") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Apresentação " SortExpression="APS_DES" ControlStyle-Width="200px" >
			<ItemTemplate>
				<asp:Label ID="lbAPS_DES" runat="server" Text='<%# Eval("APS_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Maquina " SortExpression="MAQ_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbMAQ_DES" runat="server" Text='<%# Eval("MAQ_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Ent. " SortExpression="AFN_ERT_ID" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_ERT_ID" runat="server" Text='<%# Eval("AFN_ERT_ID") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Virada " SortExpression="AFN_VRD" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_VRD" runat="server" Text='<%# Eval("AFN_VRD") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Bobina " SortExpression="AFN_BBN" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_BBN" runat="server" Text='<%# Eval("AFN_BBN") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
            <asp:TemplateField HeaderText=" Posição " SortExpression="DEF_POS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbDEF_POS" runat="server" Text='<%# Eval("DEF_POS") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
            <asp:TemplateField HeaderText=" Defeito " SortExpression="DEF_DES" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbDEF_DES" runat="server" Text='<%# Eval("DEF_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>

			<asp:TemplateField HeaderText=" Status " SortExpression="AFN_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_STS" runat="server" Text='<%# (Eval("AFN_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>

			    <%--<asp:BoundField DataField="DEF_ID" HeaderText="DEF_ID" SortExpression="DEF_ID" Visible="False" />--%>

			    <asp:BoundField DataField="USR_LEI" HeaderText="Resp. Leitura" SortExpression="USR_LEI">
                <ControlStyle Width="80px" />
                <HeaderStyle ForeColor="White" />
                </asp:BoundField>
                <asp:BoundField DataField="USR_LIB" HeaderText="Resp. Liberação" SortExpression="USR_LIB">
                <ControlStyle Width="80px" />
                <HeaderStyle ForeColor="White" />
                </asp:BoundField>

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
<table style="width:1234px"  border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="2" class="font_titulo_grd">
			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
			Afinidade
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
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" AutoPostBack="true" OnTextChanged="txt_dat_inc_TextChanged"></asp:TextBox> *
            <asp:TextBox id="txt_sem_inc" runat="server" CssClass="text_box"  maxlength="5" style="width:50px" ReadOnly="true"></asp:TextBox> &nbsp;<asp:DropDownList ID="cbo_tit_poy_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <asp:TextBox id="txt_mge_001_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Visible="False"></asp:TextBox>
            <asp:TextBox id="txt_mge_002_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Visible="False"></asp:TextBox>
            <asp:TextBox id="txt_mge_003_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Visible="False"></asp:TextBox>
            <asp:TextBox id="txt_mge_004_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Visible="False"></asp:TextBox>
            <asp:DropDownList ID="cbo_for_001_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <asp:DropDownList ID="cbo_for_002_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <asp:DropDownList ID="cbo_for_003_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <asp:DropDownList ID="cbo_for_004_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <asp:DropDownList ID="cbo_aps_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
            <%--<asp:BoundField DataField="DEF_ID" HeaderText="DEF_ID" SortExpression="DEF_ID" Visible="False" />--%>
        </td>
	</tr>
    <%--<asp:BoundField DataField="DEF_ID" HeaderText="DEF_ID" SortExpression="DEF_ID" Visible="False" />--%>
	<tr>
		<td colspan="2" class="font_body">Tipo<asp:TextBox ID="txt_afn_id" runat="server" Visible="False" style="margin-left: 70px" Width="108px"></asp:TextBox>
        </td>
	</tr>
    <tr>
		<td colspan="1">
		    <asp:CheckBox ID="Chk_Luz_Negra" runat="server" Text="Luz Negra" Enabled="False" />
        &nbsp;&nbsp; Porcentagem Luz Negra:
            <asp:TextBox ID="txt_lne_inc" runat="server" Width="53px" Enabled="False"></asp:TextBox>
        </td>
    </tr>


	<%--<asp:TextBox id="TextBox1" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="CalculaSemana" AutoPostBack="true"></asp:TextBox> *--%>

	<tr>
		<td colspan="2" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" OnTextChanged="CarregaLote" AutoPostBack="true" TabIndex="1"></asp:TextBox> *
		    <asp:DropDownList ID="cbo_maq_tip_id_inc" runat="server" CssClass="combo_box" AutoPostBack="true" Visible="False"></asp:DropDownList>
            <asp:DropDownList ID="cbo_ert_id_inc" runat="server" CssClass="combo_box" Visible="False"></asp:DropDownList>
        </td>
	</tr>
    <%--	<tr>
		<td colspan="2" class="font_body">Semana</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_sem_inc" runat="server" CssClass="text_box"  maxlength="5" style="width:50px" ReadOnly="true"></asp:TextBox> *
		</td>
	</tr>--%>
	<tr>
		<td colspan="2" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_id_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="CarregaMaquinaTipo" AutoPostBack="true" TabIndex="2"></asp:DropDownList>*</td>
	</tr>
    <%--                 <asp:ListItem>Sem Defeito</asp:ListItem>
                 <asp:ListItem Value="Claro">C</asp:ListItem>
                 <asp:ListItem Value="Escuro">E</asp:ListItem>
                 <asp:ListItem Value="Trecho mal texturado">TMT</asp:ListItem>
                 <asp:ListItem Value="Mal texturado">MT</asp:ListItem>
                 <asp:ListItem Value="Ponto Fechado">PF</asp:ListItem>
                 <asp:ListItem Value="Barramento">B</asp:ListItem>
                 <asp:ListItem Value="Falha de entrelaçamento">FE</asp:ListItem>
                 <asp:ListItem Value="Sem entrelaçamento"> SE</asp:ListItem>
                 <asp:ListItem Value="Escuro na luz negra">LNE</asp:ListItem>
                 <asp:ListItem Value="Claro na luz negra">LNC</asp:ListItem>
                 <asp:ListItem Value="Luz negra da escolha">LNEsc</asp:ListItem>--%>
	<tr>
		<td colspan="2" class="font_body">Virada</td>
	</tr>
	<tr>
		<td colspan="2" class="auto-style5">
			<asp:TextBox id="txt_vrd_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:40px" TabIndex="3"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Qtd.Bobina</td>
	</tr>
	<tr>
		<td colspan="2" class="auto-style5">
			<asp:TextBox id="txt_bbn_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:40px" TabIndex="4"></asp:TextBox> *
		</td>
	</tr>

    <tr>
		<td colspan="2" class="auto-style7">Resp. Leitura<br /></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:DropDownList ID="cbo_ana_lei_id_inc" runat="server" CssClass="combo_box" Height="22px" Width="205px" TabIndex="5"></asp:DropDownList>
        </td>
        </tr>
    <tr>
            <td colspan="2">Resp. Liberação</td>
                </tr>
    <tr>
        <td colspan="2">
            <asp:DropDownList ID="cbo_ana_lib_id_inc" runat="server" CssClass="combo_box" Height="22px" Width="205px" TabIndex="6"></asp:DropDownList>
        </td>
        </tr>
    <tr>
            <td colspan="2">Gaiola</td>
        </tr>
    <tr>
    <td>
		    <asp:CheckBox ID="Chk_54" runat="server" Text="54" Enabled="True" />
            <asp:CheckBox ID="Chk_72" runat="server" Text="72" Enabled="True" />
            <asp:CheckBox ID="Chk_108" runat="server" Text="108" Enabled="True" />
        </td>
    </tr>










    <tr>
        <td colspan="2" class="font_body">Observações</td>
    </tr>
	<tr>
		<td colspan="4">
    		<asp:TextBox id="txt_obs_inc" runat="server" CssClass="text_box"  maxlength="800"  style="width:600px;" TextMode="MultiLine" Rows="5" TabIndex="7" ></asp:TextBox> 
		</td>
	</tr>
    <%--	<tr>
		<td colspan="2" class="font_body">Título</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_tit_poy_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 1</td>
		<td class="font_body">Fornecedor 1</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_001_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_001_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 2</td>
		<td class="font_body">Fornecedor 2</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_002_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_002_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 3</td>
		<td class="font_body">Fornecedor 3</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_003_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_003_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td class="font_body">Merge 4</td>
		<td class="font_body">Fornecedor 4</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_004_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
		<td>
			<asp:DropDownList ID="cbo_for_004_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Velocidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vlc_inc" runat="server" CssClass="text_box"  maxlength="4" style="width:40px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Apresentação</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_aps_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList> *
		</td>
	</tr>--%><%--	<tr>
		<td colspan="2" class="font_body">Tipo Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_tip_id_inc" runat="server" CssClass="combo_box" Enabled="false">
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Entrelaçamento</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_ert_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList> 
		</td>
	</tr>--%><%--                 <asp:ListItem>Sem Defeito</asp:ListItem>
                 <asp:ListItem Value="Claro">C</asp:ListItem>
                 <asp:ListItem Value="Escuro">E</asp:ListItem>
                 <asp:ListItem Value="Trecho mal texturado">TMT</asp:ListItem>
                 <asp:ListItem Value="Mal texturado">MT</asp:ListItem>
                 <asp:ListItem Value="Ponto Fechado">PF</asp:ListItem>
                 <asp:ListItem Value="Barramento">B</asp:ListItem>
                 <asp:ListItem Value="Falha de entrelaçamento">FE</asp:ListItem>
                 <asp:ListItem Value="Sem entrelaçamento"> SE</asp:ListItem>
                 <asp:ListItem Value="Escuro na luz negra">LNE</asp:ListItem>
                 <asp:ListItem Value="Claro na luz negra">LNC</asp:ListItem>
                 <asp:ListItem Value="Luz negra da escolha">LNEsc</asp:ListItem>--%><%--<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_tip_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="ApresentaTipo" AutoPostBack="true">
				<asp:ListItem value="1" Text="AFINIDADE"></asp:ListItem>
				<asp:ListItem value="2" Text="LUZ NEGRA"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>--%><%--	<tr>
		<td colspan="2" class="font_body">Analista</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_ana_usr_id_inc" runat="server" CssClass="combo_box"></asp:DropDownList> *
		</td>
	</tr>
--%><%--<asp:Panel ID="pnl_afn" runat="server" Visible="true">
	<tr>
		<td colspan="4" class="font_body">Claro</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_clo_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Escuro</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_esu_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% TMT</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_tmt_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% MT</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_pmt_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% PF</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_ppf_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% B</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_bbb_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% FE</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_pfe_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% SE</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_pse_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
    </asp:Panel>--%>
    <tr>
        <td colspan="2" class="auto-style4">Posição&nbsp;&nbsp;&nbsp;&nbsp;Defeito&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Posição&nbsp;&nbsp;&nbsp;&nbsp;Defeito&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Posição&nbsp;&nbsp;&nbsp;&nbsp;Defeito&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Posição&nbsp;&nbsp;&nbsp;&nbsp;Defeito&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
    </tr>
    <tr>
         <td colspan="2">   
            <asp:TextBox ID="txt_pos" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="8"></asp:TextBox> 
             &nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="9">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;&nbsp;   
            <asp:TextBox ID="txt_pos0" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="10"></asp:TextBox> 
             &nbsp;&nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc0" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="11">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;&nbsp;   
            <asp:TextBox ID="txt_pos1" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="12"></asp:TextBox> 
             &nbsp;&nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc1" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="13">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;   
            <asp:TextBox ID="txt_pos2" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="14"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc2" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="15">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        </td>
    </tr>
    <tr>
         <td colspan="2" class="auto-style3">   
            <asp:TextBox ID="txt_pos3" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="16"></asp:TextBox> 
             &nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc3" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="17">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;&nbsp;   
            <asp:TextBox ID="txt_pos4" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="18"></asp:TextBox> 
             &nbsp;&nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc4" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="19">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;&nbsp;   
            <asp:TextBox ID="txt_pos5" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="20"></asp:TextBox> 
             &nbsp;&nbsp; 
            <asp:DropDownList ID="cbo_def_id_inc5" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="21">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos6" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="22"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc6" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="23">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos7" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="24"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc7" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="25">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos8" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="26"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc8" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="27">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos9" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="28"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc9" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="29">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos10" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="30"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc10" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="31">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos11" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="32"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc11" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="33">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos12" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="34"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc12" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="35">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos13" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="36"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc13" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="37">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos14" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="38"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc14" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="39">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos15" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="40"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc15" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="41">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos16" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="42"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc16" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="43">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos17" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="44"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc17" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="45">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos18" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="46"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc18" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="47">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos19" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="48"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc19" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="49">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos20" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="50"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc20" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="51">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos21" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="52"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc21" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="53">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos22" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="54"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc22" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="55">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos23" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="56"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc23" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="57">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos24" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="58"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc24" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="59">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos25" runat="server" CssClass="text_box" maxlength="9" style="width:45px" TabIndex="60"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc25" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="61">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos26" CssClass="text_box" maxlength="9" style="width:45px" runat="server" TabIndex="62"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc26" runat="server" CssClass="combo_box" Height="16px" Width="180px" TabIndex="63">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos27" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc27" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos28" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc28" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos29" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc29" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos30" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc30" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos31" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc31" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos32" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc32" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos33" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc33" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos34" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc34" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos35" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc35" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos36" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc36" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos37" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc37" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos38" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc38" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos39" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc39" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos40" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc40" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos41" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc41" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos42" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc42" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos43" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc43" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos44" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc44" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos45" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc45" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos46" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc46" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos47" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc47" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos48" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc48" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos49" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc49" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;   
            <asp:TextBox ID="txt_pos50" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc50" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             <br />
             <asp:TextBox ID="txt_pos51" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;
             <asp:DropDownList ID="cbo_def_id_inc51" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos52" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc52" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
             &nbsp;&nbsp;
             <asp:TextBox ID="txt_pos53" runat="server" CssClass="text_box" maxlength="9" style="width:45px"></asp:TextBox>
             &nbsp;&nbsp;
             <asp:DropDownList ID="cbo_def_id_inc53" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                 <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                 <asp:ListItem Value="C">Claro</asp:ListItem>
                 <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                 <asp:ListItem Value="E">Escuro</asp:ListItem>
                 <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                 <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                 <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                 <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                 <asp:ListItem Value="B">Barramento</asp:ListItem>
                 <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                 <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                 <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                 <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                 <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        &nbsp;   
            <asp:TextBox ID="txt_pos54" CssClass="text_box" maxlength="9" style="width:45px" runat="server"></asp:TextBox> 
            <asp:DropDownList ID="cbo_def_id_inc54" runat="server" CssClass="combo_box" Height="16px" Width="180px">
                <asp:ListItem Value="Sem def">Sem defeito</asp:ListItem>
                <asp:ListItem Value="C">Claro</asp:ListItem>
                <asp:ListItem Value="CE">Claro Excessivo</asp:ListItem>
                <asp:ListItem Value="E">Escuro</asp:ListItem>
                <asp:ListItem Value="EE">Escuro Excessivo</asp:ListItem>
                <asp:ListItem Value="TMT">Trecho Mal Texturizado </asp:ListItem>
                <asp:ListItem Value="MT">Mal Texturizado</asp:ListItem>
                <asp:ListItem Value="PF">Ponto Fechado</asp:ListItem>
                <asp:ListItem Value="B">Barramento</asp:ListItem>
                <asp:ListItem Value="FE">Falha no Entrelaçamento</asp:ListItem>
                <asp:ListItem Value="SE">Sem Entrelaçamento </asp:ListItem>
                <asp:ListItem Value="LNE">Luz Negra Escuro</asp:ListItem>
                <asp:ListItem Value="LNC">Luz Negra Claro</asp:ListItem>
                <asp:ListItem Value="LNEsc">Luz Negra Escolha</asp:ListItem>
             </asp:DropDownList>
        </td>
    </tr>

    <tr>
		<td colspan="2" class="auto-style2">Status</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_sts_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2">
            <%--<asp:Panel ID="pnl_luz_neg" runat="server" Visible="false">
	<tr>
		<td colspan="4" class="font_body">% LNE</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_lne_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% LNC</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_lnc_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">% ESCOLHA</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">
			<asp:TextBox id="txt_esl_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> *
		</td>
	</tr>
    </asp:Panel>--%>
			<asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" Onclick="btVoltar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" Onclick="btNovo_Click" />
			&nbsp;&nbsp;
			<%--    <tr>
        <td colspan="2" class="font_body">Meia</td>
    </tr>
    <tr>
         <td colspan="2" class="auto-style1">   
            <asp:TextBox ID="txt_dat_meia" CssClass="text_box" runat="server" style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;   
            <asp:TextBox ID="txt_hr_meia" CssClass="text_box" runat="server" style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Analista"></asp:Label> <asp:TextBox ID="txt_res_meia" CssClass="text_box" runat="server" style="width:150px" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Tingimento</td>
    </tr>
    <tr>
         <td colspan="2" class="font_body">   
            <asp:TextBox ID="txt_dat_tin" CssClass="text_box" runat="server" 
                 style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;   
            <asp:TextBox ID="txt_hr_tin" CssClass="text_box" runat="server" style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text="Analista"></asp:Label> 
        &nbsp;<asp:DropDownList ID="cbo_ana_usr_id_tin" runat="server" CssClass="combo_box" Height="16px" Width="183px">
			</asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Leitura</td>
    </tr>
    <tr>
         <td colspan="2" class="font_body">   
            <asp:TextBox ID="txt_dat_lei" CssClass="text_box" runat="server" 
                 style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;   
            <asp:TextBox ID="txt_hr_lei" CssClass="text_box" runat="server" style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Analista"></asp:Label> &nbsp;<asp:DropDownList ID="cbo_ana_usr_id_lei" runat="server" CssClass="combo_box" Height="16px" Width="183px">
			</asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Liberação</td>
    </tr>
    <tr>
         <td colspan="2" class="font_body">   
            <asp:TextBox ID="txt_dat_lib" CssClass="text_box" runat="server" 
                 style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;   
            <asp:TextBox ID="txt_hr_lib" CssClass="text_box" runat="server" style="width:110px" ></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="Analista"></asp:Label> &nbsp;<asp:DropDownList ID="cbo_ana_usr_id_lib" runat="server" CssClass="combo_box" Height="16px" Width="183px">
			</asp:DropDownList>
        </td>
    </tr>--%><%--<asp:Button ID="btNovoDef" runat="server" Text="Novo Defeito" CssClass="botao" Onclick="btNovoDef_Click" Enabled="False" /> &nbsp;&nbsp;--%> 
		     <asp:Button ID="btAlterar" runat="server" CssClass="botao" OnClick="btAlterar_Click" Text="Alterar" Width="89px" Enabled="False" />
		    &nbsp;&nbsp;
             <asp:Button ID="btSalvar" runat="server" CssClass="botao" OnClick="btSalvar_Click" Text="Salvar" Width="89px" />
		</td>
	</tr>
</table>
</div>
</div>
    </form>
</body>
</html>