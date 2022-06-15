<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioAfinidadeAnalitico.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioAfinidadeAnalitico.aspx 
Criado em         : 04/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Afinidade Analítico
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
			Pesquisar Relatório de Afinidade Analítico
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
		<td colspan="2" class="font_body">Semana</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_sem" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
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
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" maxlength="10" style="width:100px" OnTextChanged="txt_lot_TextChanged" AutoPostBack="true"></asp:TextBox>
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
		<td class="font_body">Merge 1</td>
		<td class="font_body">Fornecedor 1</td>
	</tr>
	<tr>
		<td>
			<asp:TextBox id="txt_mge_001" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>
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
			<asp:TextBox id="txt_mge_002" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>
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
			<asp:TextBox id="txt_mge_003" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>
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
			<asp:TextBox id="txt_mge_004" runat="server" CssClass="text_box" maxlength="18" style="width:180px"></asp:TextBox>
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
		<td colspan="2" class="font_body">Tipo Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_tip_id" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_maq_tip_id_OnSelectedIndexChanged" AutoPostBack="true">
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
	<tr>
		<td colspan="2" class="font_body">Bobina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_bbn" runat="server" CssClass="text_box" maxlength="4" style="width:40px"></asp:TextBox>
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
		<td colspan="5" class="font_titulo_grd">
			Relatório de Afinidade Analítico
		</td>
	</tr>
	<tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
		<table>		

        <tr>
		    <td class="font_body">Data Inicial</td>
		    <td class="font_body">Data Final</td>
		    <td class="font_body">Semana</td>
		    <td class="font_body">Tipo</td>
	    </tr>
	    <tr>
		    <td>
			    <asp:TextBox id="txt_dat_ini_rel" runat="server" CssClass="text_box" maxlength="8" style="width:80px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_dat_fim_rel" runat="server" CssClass="text_box" maxlength="8" style="width:80px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_sem_rel" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_tip_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
				    <asp:ListItem value="1" Text="AFINIDADE"></asp:ListItem>
				    <asp:ListItem value="2" Text="LUZ NEGRA"></asp:ListItem>
			    </asp:DropDownList>
		    </td>
	    </tr>
	    <tr>
		    <td class="font_body">Título</td>
		    <td class="font_body">Lote</td>
	    </tr>
	    <tr>
		    <td>
			    <asp:DropDownList ID="cbo_tit_poy_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:TextBox id="txt_lot_rel" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Enabled="false"></asp:TextBox>
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
			    <asp:TextBox id="txt_mge_001_rel" runat="server" CssClass="text_box" maxlength="18" style="width:180px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_mge_002_rel" runat="server" CssClass="text_box" maxlength="18" style="width:180px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_mge_003_rel" runat="server" CssClass="text_box" maxlength="18" style="width:180px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_mge_004_rel" runat="server" CssClass="text_box" maxlength="18" style="width:180px" Enabled="false"></asp:TextBox>
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
			    <asp:DropDownList ID="cbo_for_001_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_for_002_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_for_003_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_for_004_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
	    </tr>
	    <tr>
		    <td class="font_body">Tipo Máquina</td>
		    <td class="font_body">Máquina</td>
		    <td class="font_body">Entrelaçamento</td>
		    <td class="font_body">Apresentação</td>
		    <td class="font_body">Velocidade</td>
		    <td class="font_body">Virada</td>
		    <td class="font_body">Bobina</td>
	    </tr>
	    <tr>
		    <td>
			    <asp:DropDownList ID="cbo_maq_tip_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_maq_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_ert_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_aps_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:TextBox id="txt_vlc_rel" runat="server" CssClass="text_box" maxlength="4" style="width:40px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_vrd_rel" runat="server" CssClass="text_box" maxlength="4" style="width:40px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:TextBox id="txt_bbn_rel" runat="server" CssClass="text_box" maxlength="4" style="width:40px" Enabled="false"></asp:TextBox>
		    </td>
	    </tr>

        </table>
        </td>
    </tr>    
	<tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td class="font_body" colspan="5">Quantidade de Afinidades: <asp:Label ID="lbl_num" runat="server"></asp:Label></td>
	</tr>
	<tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
		<table>		
	    <tr>
		    <td class="font_body">&nbsp;</td>
		    <td class="font_body" id="td_clo" runat="server">Claro</td>
		    <td class="font_body" id="td_esu" runat="server">Escuro</td>
		    <td class="font_body" id="td_tmt" runat="server">% TMT</td>
		    <td class="font_body" id="td_pmt" runat="server">% MT</td>
		    <td class="font_body" id="td_ppf" runat="server">% PF</td>
		    <td class="font_body" id="td_bbb" runat="server">% B</td>
		    <td class="font_body" id="td_pfe" runat="server">% FE</td>
		    <td class="font_body" id="td_pse" runat="server">% SE</td>
		    <td class="font_body" id="td_lne" runat="server">% LNE</td>
		    <td class="font_body" id="td_lnc" runat="server">% LNC</td>
		    <td class="font_body" id="td_esl" runat="server">% Escolha</td>
		    <td class="font_body">Total</td>
	    </tr>
	    <tr>
		    <td class="font_body">Média</td>
		    <td id="td_clo_med" runat="server">
			    <asp:TextBox id="txt_clo_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esu_med" runat="server">
			    <asp:TextBox id="txt_esu_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_tmt_med" runat="server">
			    <asp:TextBox id="txt_tmt_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pmt_med" runat="server">
			    <asp:TextBox id="txt_pmt_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_ppf_med" runat="server">
			    <asp:TextBox id="txt_ppf_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_bbb_med" runat="server">
			    <asp:TextBox id="txt_bbb_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pfe_med" runat="server">
			    <asp:TextBox id="txt_pfe_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pse_med" runat="server">
			    <asp:TextBox id="txt_pse_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lne_med" runat="server">
			    <asp:TextBox id="txt_lne_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lnc_med" runat="server">
			    <asp:TextBox id="txt_lnc_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esl_med" runat="server">
			    <asp:TextBox id="txt_esl_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td>
			    <asp:TextBox id="txt_tot_med" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
	    </tr>
<%--            começou aqui--%>
	    <tr>
		    <td class="font_body">Desvio</td>
		    <td id="td_clo_dsv" runat="server">
			    <asp:TextBox id="txt_clo_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esu_dsv" runat="server">
			    <asp:TextBox id="txt_esu_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_tmt_dsv" runat="server">
			    <asp:TextBox id="txt_tmt_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pmt_dsv" runat="server">
			    <asp:TextBox id="txt_pmt_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_ppf_dsv" runat="server">
			    <asp:TextBox id="txt_ppf_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_bbb_dsv" runat="server">
			    <asp:TextBox id="txt_bbb_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pfe_dsv" runat="server">
			    <asp:TextBox id="txt_pfe_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pse_dsv" runat="server">
			    <asp:TextBox id="txt_pse_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lne_dsv" runat="server">
			    <asp:TextBox id="txt_lne_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lnc_dsv" runat="server">
			    <asp:TextBox id="txt_lnc_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esl_dsv" runat="server">
			    <asp:TextBox id="txt_esl_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td>
			    <asp:TextBox id="txt_tot_dsv" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
	    </tr>
 	    <tr>
		    <td class="font_body">Mínimo</td>
		    <td id="td_clo_min" runat="server">
			    <asp:TextBox id="txt_clo_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esu_min" runat="server">
			    <asp:TextBox id="txt_esu_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_tmt_min" runat="server">
			    <asp:TextBox id="txt_tmt_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pmt_min" runat="server">
			    <asp:TextBox id="txt_pmt_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_ppf_min" runat="server">
			    <asp:TextBox id="txt_ppf_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_bbb_min" runat="server">
			    <asp:TextBox id="txt_bbb_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pfe_min" runat="server">
			    <asp:TextBox id="txt_pfe_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pse_min" runat="server">
			    <asp:TextBox id="txt_pse_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lne_min" runat="server">
			    <asp:TextBox id="txt_lne_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lnc_min" runat="server">
			    <asp:TextBox id="txt_lnc_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esl_min" runat="server">
			    <asp:TextBox id="txt_esl_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td>
			    <asp:TextBox id="txt_tot_min" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
	    </tr>
 	    <tr>
		    <td class="font_body">Máximo</td>
		    <td id="td_clo_max" runat="server">
			    <asp:TextBox id="txt_clo_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esu_max" runat="server">
			    <asp:TextBox id="txt_esu_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_tmt_max" runat="server">
			    <asp:TextBox id="txt_tmt_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pmt_max" runat="server">
			    <asp:TextBox id="txt_pmt_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_ppf_max" runat="server">
			    <asp:TextBox id="txt_ppf_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_bbb_max" runat="server">
			    <asp:TextBox id="txt_bbb_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pfe_max" runat="server">
			    <asp:TextBox id="txt_pfe_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_pse_max" runat="server">
			    <asp:TextBox id="txt_pse_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lne_max" runat="server">
			    <asp:TextBox id="txt_lne_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_lnc_max" runat="server">
			    <asp:TextBox id="txt_lnc_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td id="td_esl_max" runat="server">
			    <asp:TextBox id="txt_esl_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
		    <td>
			    <asp:TextBox id="txt_tot_max" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" ReadOnly="true"></asp:TextBox> 
		    </td>
	    </tr>
<%--            acabou aqui--%>
        </table>
        </td>
    </tr>    
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
    <tr>
	    <td colspan="5" class="destaque">Relação</td>
    </tr>
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvAfinidade" DataKeyNames="AFN_ID" 
				runat="server" AutoGenerateColumns="False" AllowSorting="True" 
				OnRowDataBound="gvAfinidade_RowDataBound"  OnSorting="gvAfinidade_Sorting"
				OnRowCreated="gvAfinidade_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Data " SortExpression="AFN_DAT" ControlStyle-Width="120px" >
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
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="AFN_LOT" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_LOT" runat="server" Text='<%# Eval("AFN_LOT") %>' />
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

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
			<%--<asp:TemplateField HeaderText=" Defeito " SortExpression="AFN_CLO" ControlStyle-Width="60px" Visible="False" >
            <ItemTemplate>
			<asp:Label ID="lbAFN_CLO" runat="server" Text='<%# Eval("DEF_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>--%>

			<%--<asp:TemplateField HeaderText=" Escuro " SortExpression="AFN_ESU" ControlStyle-Width="60px" Visible="False" >
			<ItemTemplate>
			<asp:Label ID="lbAFN_ESU" runat="server" Text='<%# Eval("DEF_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>--%>
			<asp:TemplateField HeaderText=" % TMT " SortExpression="AFN_TMT" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_TMT" runat="server" Text='<%# Eval("AFN_TMT") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % MT " SortExpression="AFN_PMT" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_PMT" runat="server" Text='<%# Eval("AFN_PMT") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % PF " SortExpression="AFN_PPF" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_PPF" runat="server" Text='<%# Eval("AFN_PPF") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % B " SortExpression="AFN_BBB" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_BBB" runat="server" Text='<%# Eval("AFN_BBB") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % FE " SortExpression="AFN_PFE" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_PFE" runat="server" Text='<%# Eval("AFN_PFE") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % SE " SortExpression="AFN_PSE" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_PSE" runat="server" Text='<%# Eval("AFN_PSE") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % LNE " SortExpression="AFN_LNE" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_LNE" runat="server" Text='<%# Eval("AFN_LNE") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % LNC " SortExpression="AFN_LNC" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_LNC" runat="server" Text='<%# Eval("AFN_LNC") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % Escolha " SortExpression="AFN_ESL" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_ESL" runat="server" Text='<%# Eval("AFN_ESL") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Total " SortExpression="AFN_TOT" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_TOT" runat="server" Text='<%# Eval("AFN_TOT") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
                <%--termina aqui--%>
			<asp:TemplateField HeaderText=" Status " SortExpression="AFN_STS" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_STS" runat="server" Text='<%# (Eval("AFN_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
			</ItemTemplate>

<ControlStyle Width="40px"></ControlStyle>

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
		<td colspan="5">&nbsp;</td>
	</tr>
</table>
</div>
</div>
</form>
</body>
</html>