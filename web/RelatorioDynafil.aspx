<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioDynafil.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioDynafil.aspx 
Criado em         : 04/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Dynafil
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 TrDNFitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-trDNFitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<style type="text/css">
    .td_borda
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 1px solid;
        BORDER-LEFT: #003876 1px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS SDNF Serif';
	    text-decoration: none;
    }
</style>
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
			Pesquisar Relatório de Dynafil
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>		<td colspan="2" class="font_body">Merge</td>	</tr>	<tr>		<td colspan="2">			<asp:TextBox id="txt_mge" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Fornecedor</td>	</tr>	<tr>		<td colspan="2">			<asp:DropDownList ID="cbo_for_id" runat="server" CssClass="combo_box">				<asp:ListItem value="" Text=""></asp:ListItem>			</asp:DropDownList>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Título</td>	</tr>	<tr>		<td colspan="2">			<asp:DropDownList ID="cbo_tit_poy_id" runat="server" CssClass="combo_box">				<asp:ListItem value="" Text=""></asp:ListItem>			</asp:DropDownList>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Velocidade</td>	</tr>	<tr>		<td colspan="2">			<asp:TextBox id="txt_vlc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Data Inicial</td>	</tr>	<tr>		<td colspan="2">			<asp:TextBox id="txt_dat_ini" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Data Final</td>	</tr>	<tr>		<td colspan="2">			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>		</td>	</tr>	<tr>		<td colspan="2" class="font_body">Status</td>	</tr>	<tr>		<td colspan="2">			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">				<asp:ListItem value="" Text=""></asp:ListItem>				<asp:ListItem value="1" Text="ATIVO" Selected="True"></asp:ListItem>				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>			</asp:DropDownList>		</td>	</tr>	<tr>
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
		<td class="font_titulo_grd">
			Relatório de Dynafil
		</td>
	</tr>
	<tr>
		<td class="font_body" style="width:780px" align="right">
			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;
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
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvDynafil_RowDataBound"  OnSorting="gvDynafil_Sorting"
				OnRowCreated="gvDynafil_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Merge " SortExpression="DNF_MGE" ControlStyle-Width="180px" >			<ItemTemplate>				<asp:Label ID="lbDNF_MGE" runat="server" Text='<%# Eval("DNF_MGE") %>' />			</ItemTemplate>            <ControlStyle Width="60px"></ControlStyle>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Fornecedor " SortExpression="FOR_NOM" ControlStyle-Width="60px" >			<ItemTemplate>				<asp:Label ID="lbFOR_NOM" runat="server" Text='<%# Eval("FOR_NOM") %>' />			</ItemTemplate>            <ControlStyle Width="60px"></ControlStyle>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="60px" >			<ItemTemplate>				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />			</ItemTemplate>            <ControlStyle Width="60px"></ControlStyle>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Velocidade " SortExpression="DNF_VLC" ControlStyle-Width="60px" >			<ItemTemplate>				<asp:Label ID="lbDNF_VLC" runat="server" Text='<%# Eval("DNF_VLC") %>' />			</ItemTemplate>            <ControlStyle Width="60px"></ControlStyle>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Data " SortExpression="DNF_DAT" ControlStyle-Width="60px" >			<ItemTemplate>					<asp:Label ID="lbDNF_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("DNF_DAT").ToString())?"":Convert.ToDateTime(Eval("DNF_DAT").ToString()).ToString("dd/MM/yyyy") %>' />			</ItemTemplate>            <ControlStyle Width="60px"></ControlStyle>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			</Columns>
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
<div runat="server" id="dvRelatorio" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="5" class="font_titulo_grd">
			Relatório de Dynafil
		</td>
	</tr>
	<tr>
		<td colspan="5" class="font_body" align="right"><%= DateTime.Now.ToString() %></td>
	</tr>
	<tr>
		<td colspan="5" class="font_body"><asp:Label runat="server" ID="lb_filtro"></asp:Label></td>
	</tr>
	<div runat="server" id="dv_rel" visible="false">
	<tr>
		<td colspan="5">
		<table cellspacing="1px">        <tr>		    <td class="td_borda">Data</td>
		    <td class="td_borda">Merge</td>
		    <td class="td_borda">Fornecedor</td>
		    <td class="td_borda">Título</td>
		    <td class="td_borda">Velocidade</td>
	    </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_dat_rel" runat="server">&nbsp;</asp:Label>
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_mge_rel" runat="server">&nbsp;</asp:Label>
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_poy_id_rel" runat="server">&nbsp;</asp:Label>		    
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_for_id_rel" runat="server">&nbsp;</asp:Label>		    
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_vlc_rel" runat="server">&nbsp;</asp:Label>		    
		    </td>
		</tr>
		</table>
		</td>
	</tr>
	<tr>
		<td colspan="5" class="font_body">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
		<table cellspacing="1px">
		    <tr>
	        <td class="td_borda" style="width:120px">Posição</td>
		    <td class="td_borda">1</td>
		    <td class="td_borda">2</td>
		    <td class="td_borda">3</td>
		    <td class="td_borda">4</td>
		    <td class="td_borda">5</td>
		    <td class="td_borda">6</td>
            <!--
		    <td class="td_borda">7</td>
		    <td class="td_borda">8</td>
		    <td class="td_borda">9</td>
		    <td class="td_borda">10</td>
            -->
		    <td class="td_borda">
    		    &nbsp;
		    </td>
		    <td class="td_borda">Média</td>
		    <td class="td_borda">Desvio</td>
		    <td class="td_borda">Espec.</td>
		    <td class="td_borda">Mínimo</td>
		    <td class="td_borda">Máximo</td>
        </tr>
	    <tr>
		    <td class="td_borda" rowspan="2">Titulo (Dtex)</td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tit_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tit_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tit_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tit_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tit_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">Tenacidade </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_tnc_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tnc_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tnc_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_tnc_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_tnc_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">Alongamento </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_aon_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_aon_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_aon_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_aon_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_aon_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">CV - Eveness </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_eve_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_eve_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_eve_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_eve_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_eve_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">Fil. Quebrados </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_qbr_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_qbr_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_qbr_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_qbr_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_qbr_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">Força </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_foa_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_foa_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_foa_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_foa_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_foa_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    <tr>
		    <td class="td_borda" rowspan="2">CV - Força </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_001" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_002" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_003" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_004" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_005" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_006" runat="server">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_007" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_008" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_009" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_010" runat="server">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_med" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" style="width:50px">
    		    <asp:Label id="lb_cvf_dsv" runat="server">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_cvf_med_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_cvf_min_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda" rowspan="2" style="width:50px">
    		    <asp:Label id="lb_cvf_max_esp" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
        </tr>
	    <tr>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_001" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_002" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_003" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_004" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_005" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_006" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            <!--
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_007" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_008" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_009" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_010" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
            -->
		    <td class="td_borda" style="width:10px">
    		    &nbsp;
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_med" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
		    <td class="td_borda">
    		    <asp:Label id="lb_cvf_sts_dsv" runat="server" ForeColor="Green">&nbsp;</asp:Label> 
		    </td>
	    </tr>

	    </table>
	    </td>
	</tr>
    <tr>
		<td>&nbsp;</td>
    </tr>
    <tr>
		<td class="font_body">
            Observação: <asp:Label id="lb_obs_rel" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
		<td>&nbsp;</td>
    </tr>
    </div>
</table>
</div>
</div>
</form>
</body>
</html>