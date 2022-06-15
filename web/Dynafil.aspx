<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Dynafil.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : Dynafil.aspx 
Criado em         : 18/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Dynafil 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
    <form id="frmDynafil" runat="server">
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
			Pesquisar Dynafil
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
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
		<td colspan="2" class="font_body">Velocidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vlc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
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
			Pesquisar Dynafil
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
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvDynafil" DataKeyNames="DNF_ID" 
				runat="server" AutoGenerateColumns="False" AllowSorting="True" 
				OnRowDataBound="gvDynafil_RowDataBound"  OnSorting="gvDynafil_Sorting"
				OnRowCreated="gvDynafil_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Merge " SortExpression="DNF_MGE" ControlStyle-Width="180px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_MGE" runat="server" Text='<%# Eval("DNF_MGE") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Fornecedor " SortExpression="FOR_NOM" ControlStyle-Width="120px" >
			<ItemTemplate>
				<asp:Label ID="lbFOR_NOM" runat="server" Text='<%# Eval("FOR_NOM") %>' />
			</ItemTemplate>

<ControlStyle Width="120px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="140px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="140px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Velocidade " SortExpression="DNF_VLC" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_VLC" runat="server" Text='<%# Eval("DNF_VLC") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data " SortExpression="DNF_DAT" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("DNF_DAT").ToString())?"":Convert.ToDateTime(Eval("DNF_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Status " SortExpression="DNF_STS" ControlStyle-Width="80px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_STS" runat="server" Text='<%# (Eval("DNF_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			    <asp:BoundField DataField="DNF_DAT_FIA" DataFormatString="{0:d}" HeaderText="Data Fiação" SortExpression="DNF_DAT_FIA">
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
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="4" class="font_titulo_grd" style="width:780px">
			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label> Dynafil			
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Merge</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_mge_inc" runat="server" CssClass="text_box"  maxlength="18" style="width:180px"></asp:TextBox> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Fornecedor</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_for_id_inc" runat="server" CssClass="combo_box">
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Titulo</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_tit_poy_id_inc" runat="server" CssClass="combo_box">
			</asp:DropDownList> *
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Velocidade</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_vlc_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
	</tr>
    	<tr>
		<td colspan="4" class="font_body">Data Fiação</td>
	</tr>

	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_dat_fia_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> </td>
	</tr>
	<tr>
		<td colspan="4" class="destaque">Dados</td>
	</tr>

	<tr>
	<td colspan="4">
    <table width="1000px">        
		<tr>
            <td class="font_body_destaque">Posição</td>
            <td class="font_body_destaque">Título</td>
            <td class="font_body_destaque">Tenacidade</td>
            <td class="font_body_destaque">Alongamento</td>
            <td class="font_body_destaque">CV - Eveness</td>
            <td class="font_body_destaque">Fil. Quebrados</td>
            <td class="font_body_destaque">Força</td>
            <td class="font_body_destaque">CV - Força</td>
        </tr>
        <tr>
            <td class="font_body_destaque">1</td>
		    <td><asp:TextBox id="txt_tit_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_001_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td class="font_body_destaque">2</td>
		    <td><asp:TextBox id="txt_tit_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_002_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td class="font_body_destaque">3</td>
		    <td><asp:TextBox id="txt_tit_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_003_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td class="font_body_destaque">4</td>
		    <td><asp:TextBox id="txt_tit_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_004_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td class="font_body_destaque">5</td>
		    <td><asp:TextBox id="txt_tit_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_005_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
	    <tr>
            <td class="font_body_destaque">6</td>
		    <td><asp:TextBox id="txt_tit_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_006_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        <!--
        <tr>
            <td class="font_body_destaque">7</td>
		    <td><asp:TextBox id="txt_tit_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_007_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        <tr>
            <td class="font_body_destaque">8</td>
		    <td><asp:TextBox id="txt_tit_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_008_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
         <tr>
            <td class="font_body_destaque">9</td>
		    <td><asp:TextBox id="txt_tit_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_009_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        <tr>
            <td class="font_body_destaque">10</td>
		    <td><asp:TextBox id="txt_tit_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_010_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox></td>
	    </tr>
        -->
   </table>
    </td>
	</tr>

	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
    <tr>		<td colspan="4" class="font_body">Observação</td>	</tr>	<tr>		<td colspan="4">    		<asp:TextBox id="txt_obs_dnf" runat="server" CssClass="text_box"  maxlength="1600"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 		</td>	</tr>
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