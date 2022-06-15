<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioAfinidadeMensal.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioAfinidadeMensal.aspx 
Criado em         : 04/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Afinidade Mensal
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
			Pesquisar Relatório de Afinidade Mensal
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
			Relatório de Afinidade Mensal
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
		    <td class="font_body">Merge</td>
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
		<td class="font_body" colspan="5">
		    Quantidade de Afinidades: <asp:Label ID="lbl_num" runat="server"></asp:Label> &nbsp; 
		    Data Mínima: <asp:Label ID="lbl_dat_min" runat="server"></asp:Label> &nbsp; 
		    Data Máxima: <asp:Label ID="lbl_dat_max" runat="server"></asp:Label>
		</td>
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
        </table>
        </td>
    </tr>    
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
    <tr>
	    <td colspan="5" class="destaque">Relação de Lote</td>
    </tr>
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvAfinidade" DataKeyNames="AFN_LOT" 
				runat="server" AutoGenerateColumns="false" AllowSorting="true" 
				OnRowDataBound="gvAfinidade_RowDataBound"  OnSorting="gvAfinidade_Sorting"
				OnRowCreated="gvAfinidade_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
            <asp:TemplateField HeaderText=" Data " SortExpression="AFN_DAT" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("AFN_DAT").ToString())?"":Convert.ToDateTime(Eval("AFN_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Lote " SortExpression="AFN_LOT" ControlStyle-Width="40px" >
			<ItemTemplate>
				<asp:Label ID="lbAFN_LOT" runat="server" Text='<%# Eval("AFN_LOT") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Defeito " SortExpression="CLO_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
			    <asp:Label ID="lbCLO_MED" runat="server" Text='<%# Eval("DEF_DES") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
<%--                <asp:TemplateField HeaderText=" Total " SortExpression="TOT_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTOT_MED" runat="server" Text='<%# Eval("TOT_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>--%>

<%--			<asp:TemplateField HeaderText=" Escuro " SortExpression="ESU_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbESU_MED" runat="server" Text='<%# Eval("ESU_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % TMT " SortExpression="TMT_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTMT_MED" runat="server" Text='<%# Eval("TMT_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % MT " SortExpression="PMT_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbPMT_MED" runat="server" Text='<%# Eval("PMT_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % PF " SortExpression="PPF_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbPPF_MED" runat="server" Text='<%# Eval("PPF_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % B " SortExpression="BBB_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbBBB_MED" runat="server" Text='<%# Eval("BBB_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % FE " SortExpression="PFE_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbPFE_MED" runat="server" Text='<%# Eval("PFE_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % SE " SortExpression="PSE_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbPSE_MED" runat="server" Text='<%# Eval("PSE_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % LNE " SortExpression="LNE_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbLNE_MED" runat="server" Text='<%# Eval("LNE_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % LNC " SortExpression="LNC_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbLNC_MED" runat="server" Text='<%# Eval("LNC_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" % Escolha " SortExpression="ESL_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbESL_MED" runat="server" Text='<%# Eval("ESL_MED") %>' />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>--%>
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