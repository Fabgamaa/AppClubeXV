<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioStandard.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioStandard.aspx 
Criado em         : 08/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Standard 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
	<style type="text/css">
	.bordaAzul
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 1px solid;
        BORDER-LEFT: #003876 1px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
    .bordaAzulSemRight
    {
        BORDER-RIGHT: #003876 0px solid;
        BORDER-TOP: #003876 1px solid;
        BORDER-LEFT: #003876 1px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
    .bordaAzulSemTop
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 0px solid;
        BORDER-LEFT: #003876 1px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
     .bordaAzulSemLeft
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 1px solid;
        BORDER-LEFT: #003876 0px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
    .bordaAzulLeftRight
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 0px solid;
        BORDER-LEFT: #003876 1px solid;
        BORDER-BOTTOM: #003876 0px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
    .bordaAzulRight
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 0px solid;
        BORDER-LEFT: #003876 0px solid;
        BORDER-BOTTOM: #003876 0px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
     .bordaAzulRightBottom
    {
        BORDER-RIGHT: #003876 1px solid;
        BORDER-TOP: #003876 0px solid;
        BORDER-LEFT: #003876 0px solid;
        BORDER-BOTTOM: #003876 1px solid;
        font-size: 8pt;
	    color: #191970;
	    font-family: Verdana, Arial, 'MS Sans Serif';
	    text-decoration: none;
    }
    .quebraPagina
    {
        page-break-before: always; 
    }
	</style>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmStandard" runat="server">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<div runat="server" id="dvBarra">
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
</div>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Relatório de Standard
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
			<asp:TextBox id="txt_dat" runat="server" CssClass="text_box" style="width:80px"></asp:TextBox>
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
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" Width="88px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Lote Referência</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot_ref" runat="server" CssClass="text_box" style="width:100px"></asp:TextBox>
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
		<td colspan="2" class="font_body">Merge</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_mge" runat="server" CssClass="text_box" style="width:180px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="2">
        <!-- 
        MAP20032013
        SEMPRE ATIVO
        -->
			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_sts_OnSelectedIndexChanged" AutoPostBack="true" Enabled="false">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO" Selected></asp:ListItem>
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
<div runat="server" id="dvResultado" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="4" class="font_titulo_grd" style="width:780px">
			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
			Standard
		</td>
	</tr>
	<tr>
		<td colspan="4">
            <asp:TextBox ID="TextBox1" runat="server" Width="238px" Font-Size="X-Large" Height="57px"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Width="238px" Font-Size="X-Large" Height="57px"></asp:TextBox>
        </td>
	</tr>

	<tr>
		<td colspan="4" class="bordaAzul">
        <table>
	    <tr>
		    <td class="font_body">
                Data: 
			    <asp:Label id="txt_dat_rel" runat="server"></asp:Label>
                &nbsp;
                Versão: 
			    <asp:Label id="txt_vrs_rel" runat="server"></asp:Label>
		    </td>
		    <td class="font_body">
                Lote Referência: 
			    <asp:Label id="txt_lot_ref_rel" runat="server"></asp:Label>
		    </td>
    		<td class="font_body">
                Máquina: 
			    <asp:Label id="txt_maq_tip_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_maq_tip_id_rel" runat="server" CssClass="combo_box" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
		    </td>
	    </tr>

	    <tr style="vertical-align:top">
	    <td class="bordaAzul" style="width:260px">
        <table>       
       	    <tr>
	    	    <td colspan="2" class="destaque">Informações do Produto</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body" style="width:180px">Lote</td>
	    	    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_lot_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Título</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_tit_poy_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_tit_poy_id_rel" runat="server" CssClass="combo_box" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Descrição</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_des_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Tubete</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_aps_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_aps_id_rel" runat="server" CssClass="combo_box" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
    		    </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Entrelaçamento</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ert_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_ert_id_rel" runat="server" CssClass="combo_box" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
    		    </asp:DropDownList>
                </td>
		    </tr>

       	    <tr>
	    	    <td colspan="2" class="destaque">Identificação do POY</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_for_id_rel" runat="server"/></td>
                <td align="right" class="font_body"><asp:Label id="txt_for_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_for_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr>
                <td class="font_body"><asp:Label id="lb_mge_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_mge_des_001_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_des_001_rel" runat="server"></asp:Label></td>
		    </tr>

		    <tr>
                <td class="font_body"><asp:Label id="lb_for_002_id_rel" runat="server"/></td>
                <td align="right" class="font_body"><asp:Label id="txt_for_002_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_for_002_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_mge_002_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_002_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body"><asp:Label id="lb_mge_des_002_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_des_002_rel" runat="server"></asp:Label></td>
		    </tr>

		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_for_003_id_rel" runat="server"/></td>
                <td align="right" class="font_body"><asp:Label id="txt_for_003_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_for_003_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr>
                <td class="font_body"><asp:Label id="lb_mge_003_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_003_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_mge_des_003_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_des_003_rel" runat="server"></asp:Label></td>
		    </tr>

		    <tr>
                <td class="font_body"><asp:Label id="lb_for_004_id_rel" runat="server"/></td>
                <td align="right" class="font_body"><asp:Label id="txt_for_004_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_for_004_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body"><asp:Label id="lb_mge_004_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_004_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body"><asp:Label id="lb_mge_des_004_rel" runat="server"/></td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_mge_des_004_rel" runat="server"></asp:Label></td>
		    </tr>
            <asp:Panel ID="pnl_900_lnh" runat="server">
       	    <tr>
	    	    <td colspan="2" class="destaque"></td>
	        </tr>
            </asp:Panel>

            <!-- Inicio TMT-->
            <asp:Panel ID="pnl_tmt_poy" runat="server" Visible="false">
            <!--
		    <tr class="linha_par">
		        <td class="font_body">Matiz 1</td>
		        <td align="right" class="font_body"><asp:Label id="txt_mat_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Matiz 2</td>
		        <td align="right" class="font_body"><asp:Label id="txt_mat_002_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Matiz 3</td>
		        <td align="right" class="font_body"><asp:Label id="txt_mat_003_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Matiz 4</td>
		        <td align="right" class="font_body"><asp:Label id="txt_mat_004_rel" runat="server"></asp:Label></td>
	        </tr>
            -->
		    <tr class="linha_par">
		        <td class="font_body">Local da Cantre 1</td>
		        <td align="right" class="font_body"><asp:Label id="txt_can_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Local da Cantre 2</td>
		        <td align="right" class="font_body"><asp:Label id="txt_can_002_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Local da Cantre 3</td>
		        <td align="right" class="font_body"><asp:Label id="txt_can_003_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Local da Cantre 4</td>
		        <td align="right" class="font_body"><asp:Label id="txt_can_004_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Épura 1</td>
		        <td align="right" class="font_body"><asp:Label id="txt_epu_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Épura 2</td>
		        <td align="right" class="font_body"><asp:Label id="txt_epu_002_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Épura 3</td>
		        <td align="right" class="font_body"><asp:Label id="txt_epu_003_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Épura 4</td>
		        <td align="right" class="font_body"><asp:Label id="txt_epu_004_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">% Merge 1</td>
		        <td align="right" class="font_body"><asp:Label id="txt_per_mge_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">% Merge 2</td>
		        <td align="right" class="font_body"><asp:Label id="txt_per_mge_002_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">% Merge 3</td>
		        <td align="right" class="font_body"><asp:Label id="txt_per_mge_003_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">% Merge 4</td>
		        <td align="right" class="font_body"><asp:Label id="txt_per_mge_004_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            <!-- Fim TMT-->

            <asp:Panel ID="pnl_sta_poy" runat="server">
		    <tr class="linha_par">
                <td class="font_body">E1 Fornecedor</td>
                <td align="right" class="font_body"><asp:Label id="txt_eor_001_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_eor_001_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr>
                <td class="font_body">E1-Merge</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_001_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">E1-Descrição</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_des_001_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">E2-Fornecedor</td>
                <td align="right" class="font_body"><asp:Label id="txt_eor_002_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_eor_002_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">E2-Merge</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_002_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">E2-Descrição</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_des_002_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">E3-Fornecedor</td>
                <td align="right" class="font_body"><asp:Label id="txt_eor_003_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_eor_003_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr>
                <td class="font_body">E3-Merge</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_003_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">E3-Descrição</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_des_003_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">E4-Fornecedor</td>
                <td align="right" class="font_body"><asp:Label id="txt_eor_004_id_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_eor_004_id_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
                </td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">E4-Merge</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_004_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">E4-Descrição</td>
	    	    <td class="font_body" align="right"><asp:Label id="txt_ege_des_004_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel ID="pnl_afk_003" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Doff Sequence Times</td>
	        </tr>
            <!--
            <tr>
                <td class="font_body">Tensão Spx</td>
		        <td class="font_body" align="right"><asp:Label id="txt_spx_rel" runat="server"></asp:Label></td>
		    </tr>
            -->
            <tr>
            <td class="font_body">Off-oil lifter UP</td>
		        <td class="font_body" align="right"><asp:Label id="txt_eol_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Off traversing lifter UP</td>
		    <td class="font_body" align="right"><asp:Label id="txt_etu_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Off traversing lifter DOWN</td>
		    <td class="font_body" align="right"><asp:Label id="txt_etd_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Cradle UP</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ecu_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
                <td class="font_body" style="width:180px">End Caps Open</td>
		        <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_eco_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Tube Gripper DOWN</td>
		    <td class="font_body" align="right"><asp:Label id="txt_egd_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">EndCaps CLOSE</td>
		    <td class="font_body" align="right"><asp:Label id="txt_eec_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Cradle DOWN</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ecd_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Tube Gripper UP</td>
		    <td class="font_body" align="right"><asp:Label id="txt_egu_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">String-up device OUT</td>
		    <td class="font_body" align="right"><asp:Label id="txt_eso_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">String-up device IN</td>
		    <td class="font_body" align="right"><asp:Label id="txt_esi_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Cradle RESET</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ecr_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Off-oil lifter DOWN</td>
		    <td class="font_body" align="right"><asp:Label id="txt_eod_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Aux.step. WAITING</td>
		    <td class="font_body" align="right"><asp:Label id="txt_eaw_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Duration after Start Point 1</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ed1_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Duration after Start Point 2</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ed2_rel" runat="server"></asp:Label></td>
		    </tr>
            <!-- 26/09/2014 Inicio -->
		    <tr>
            <td class="font_body">Injectors durring doff</td>
		    <td class="font_body" align="right"><asp:Label id="cbo_idd_inc" runat="server"></asp:Label></td>
		    </tr>
            <!-- 26/09/2014 Fim -->
	        <tr>
		        <td colspan="2" class="destaque">Régua e Encosto</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body">P1-Constant Main(bar)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_p1c_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">P2-Down Thr. Arm(bar)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_p2d_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">P3-Down Cradle(bar)</td>
                <td class="font_body" align="right"><asp:Label id="txt_p3d_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">P4-Up Cradle(bar)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_p4u_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Regulagem Mola</td>
                <td class="font_body" align="right"><asp:Label id="txt_mol_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel ID="pnl_epu" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Epura</td>
	        </tr>
            <tr class="linha_par">
                <td class="font_body" style="width:180px">Guia do Fio Tinto</td>
	    	    <td class="font_body" style="width:80px" align="right"><asp:Label id="txt_gft_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
                <td class="font_body">Hemawet</td>
		        <td class="font_body" align="right"><asp:Label id="txt_hem_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
                <td class="font_body">Vazão</td>
		        <td class="font_body" align="right"><asp:Label id="txt_vaz_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <!-- Inicio TMT-->
            <asp:Panel ID="pnl_tmt_reg" runat="server" Visible="false">
	        <tr>
		        <td colspan="2" class="destaque">Regulagens Manuais</td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body" style="width:150px">Ângulo de Torção (°)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ato_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body" style="width:150px">P1 (Kgf/cm2)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tp1_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">P2 (Kgf/cm2)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tp2_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">CP (g)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tcp_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">JET FR2A (WX)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_jf2_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Pressão(Bar)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ps2_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">JET FR0</td>
		        <td align="right" class="font_body"><asp:Label id="txt_jf0_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Pressão(Bar)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ps0_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Baffle Bar</td>
		        <td align="right" class="font_body"><asp:Label id="txt_bba_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Guias Rotativos</td>
		        <td align="right" class="font_body"><asp:Label id="txt_gro_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            <!-- Fim TMT-->

            </table>
	    </td>

	    <td class="bordaAzul" style="width:260px">
        <table>
    	    <tr>
		    <td colspan="2" class="destaque">Condições de Operação</td>
	        </tr>
            <asp:Panel ID="pnl_afk_001" runat="server">
		    <tr class="linha_par">
            <td class="font_body" style="width:150px"><asp:label id="lbl_vw2" runat="server" Text="Velocidade W2(m/min)"></asp:label></td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_vw2_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Taxa de estiragem</td>
		    <td class="font_body" align="right"><asp:Label id="txt_egm_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body"><asp:label id="lbl_edy" runat="server" Text="D/Y"></asp:label></td>
		    <td class="font_body" align="right"><asp:Label id="txt_dyy_rel" runat="server"></asp:Label></td>
		    </tr>
            <asp:Panel runat="server" ID="pnl_overfeed_wx_M900_V900">
		    <tr>
            <td class="font_body"><asp:label id="lbl_ewx" runat="server" Text="2nd Overfeed  - WX(%)"></asp:label></td>
    	    <td class="font_body" align="right"><asp:Label id="txt_2wx_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
		    <tr class="linha_par">
            <td class="font_body"><asp:label id="lbl_ew3" runat="server" Text="3rd  Overfeed  - W3(%)"></asp:label></td>
		    <td class="font_body" align="right"><asp:Label id="txt_3w3_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body"><asp:label id="lbl_ew4" runat="server" Text="4rd  Overfeed  - W4(%)"></asp:label></td>
		    <td class="font_body" align="right"><asp:Label id="txt_4w4_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel ID="pnl_sta" runat="server">
		    <tr class="linha_par">
            <td class="font_body" style="width:180px">Velocidade (m/min)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_sve_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Taxa de fixação</td>
		    <td class="font_body" align="right"><asp:Label id="txt_stf_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Temperatura Fixação(°C)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_stm_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">C-Taxa de Estiragem</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sce_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">C-Overfeed(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sco_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">C-Temp. Hot Pin(°C)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sch_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">C-Temp. Godet(°C)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_scg_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">E-Taxa de Estiragem</td>
		    <td class="font_body" align="right"><asp:Label id="txt_see_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">E-Overfeed(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_seo_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">E-Temp. Hot Pin(°C)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_seh_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">E-Temp. Godet(°C)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_seg_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Jet Core</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sjc_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Jet Type</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sjt_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Jet Body</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sjb_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Pressão Jet(bar)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_spj_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Dist. Bola/Carcaça(mm)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sbc_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            <asp:Panel ID="pnl_sta_002" runat="server">
            <tr class="linha_par">
            <td class="font_body">Tipo Óleo</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tol_sta_rel" runat="server"></asp:Label></td>
		    </tr>  
            <tr>
            <td class="font_body">Curso</td>
		    <td class="font_body" align="right"><asp:Label id="txt_coc_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Ângulo de formação</td>
		    <td class="font_body" align="right"><asp:Label id="txt_fmc_sta_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Programa</td>
		    <td class="font_body" align="right"><asp:Label id="txt_spo_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Variação</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sva_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Valor Tensão</td>
		    <td class="font_body" align="right"><asp:Label id="txt_cov_rel" runat="server"></asp:Label></td>
		    </tr>

            </asp:Panel>
            <asp:Panel ID="pnl_agl_tup_veo" runat="server">
            <asp:Panel ID="pnl_agl" runat="server">
		    <tr>
            <td class="font_body">Ângulo de cruzamento(°)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_agl_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
		    <tr class="linha_par">
            <td class="font_body">Take Up Program</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tup_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Vel. Eixo óleo(rpm)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_veo_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Tipo Óleo</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tol_rel" runat="server"></asp:Label></td>
		    </tr>  
            </asp:Panel>

            <!-- Inicio TMT-->
            <asp:Panel ID="pnl_tmt_ope" runat="server" Visible="false">
	        <tr>
		        <td class="font_body">T0 (Hot-pin) (ºC) (H0)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_hot_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Torção(VR Direction)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_vrd_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Ângulo de Cruzamento (º) (Widing Angle)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_acr_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Padrão de Enrolamento (Creeping Pattern)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_pen_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Creeping Ratio (%)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_cra_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Creeping Length (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_cle_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Ângulo de Formação (º)(Taper Angle)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_afo_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Taper Curve</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tcu_rel" runat="server"></asp:Label></td>
	        </tr>
	        <tr>
		        <td class="font_body">Taper Adjustment Ratio</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tar_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Taper Angle Multistage</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tam_rel" runat="server"></asp:Label>
			    <asp:DropDownList ID="ddl_tam_rel" runat="server" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
				    <asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				    <asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			    </asp:DropDownList>
                </td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Diâmetro do Tubo (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_dtu_rel" runat="server"></asp:Label></td>
	        </tr>
            <tr>
		        <td class="font_body">Diâmetro do Pacote (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_dpa_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Curso Inicial (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_cin_rel" runat="server"></asp:Label></td>
	        </tr>
            <asp:Panel ID="pnl_frs" runat="server" Visible="true">
            <tr>
		        <td class="font_body"><asp:Label id="lbl_fr2_rel" runat="server"></asp:Label></td>
		        <td align="right" class="font_body"><asp:Label id="txt_fr2_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body"><asp:Label id="lbl_fr1_rel" runat="server"></asp:Label></td>
		        <td align="right" class="font_body"><asp:Label id="txt_fr1_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body"><asp:Label id="lbl_fr0_rel" runat="server"></asp:Label></td>
		        <td align="right" class="font_body"><asp:Label id="txt_fr0_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            </asp:Panel>
            <!-- Fim TMT-->

            <asp:Panel runat="server" ID="pnl_afk_002">
		    <tr>
            <td class="font_body" style="width:180px">T1 - Estufa curta(ºC)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_t1c_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">T1 - Estufa Longa(ºC)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_t1l_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            <asp:Panel runat="server" ID="pnl_afk_d_t4_M900_V900">
		    <tr>
            <td class="font_body" style="width:180px">T1 - Texturização(ºC)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_t1t_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            <asp:Panel runat="server" ID="pnl_t2f">
		    <tr class="linha_par">
            <td class="font_body">T2 - Fixação(ºC)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_t2f_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel runat="server" ID="pnl_rgm">
	        <tr>
		        <td colspan="2" class="destaque">Regulagens Manuais</td>
	        </tr>
		    <tr class="linha_par">
            <td class="font_body" style="width:180px">Tipo Agregado</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_tgr_rel" runat="server"></asp:Label></td>
		    </tr>
	        <tr>
            <td class="font_body">Tipo Disco</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tip_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Diposição dos discos</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dsb_rel" runat="server"></asp:Label></td>
		    </tr>
	        <tr>
            <td class="font_body">Torção</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tca_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Espaçamento(mm)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_esp_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Ângulo de formação</td>
		    <td class="font_body" align="right"><asp:Label id="txt_fmc_rel" runat="server"></asp:Label></td>
		    </tr>
	        <tr class="linha_par">
            <td class="font_body">Curso</td>
		    <td class="font_body" align="right"><asp:Label id="txt_cso_rel" runat="server"></asp:Label></td>
		    </tr>
	        <tr>
            <td class="font_body"># 1 Tipo de Buso</td>
		    <td class="font_body" align="right"><asp:Label id="txt_1tb_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Pressão(psi)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_1pp_rel" runat="server"></asp:Label></td>
		    </tr>
	        <tr>
            <td class="font_body"># 2 Tipo de Buso</td>
		    <td class="font_body" align="right"><asp:Label id="txt_2tb_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Pressão(psi)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_2pp_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel runat="server" ID="pnl_tns">
	        <tr>
		        <td colspan="2" class="destaque">Tensões (cN)</td>
	        </tr>
		    <tr class="linha_par">
            <td class="font_body" style="width:180px">Pre-Draw (cN)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_tpd_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">T-1 (cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tt1_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">T-2 (cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tt2_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">T-3 (cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tt3_rel" runat="server"></asp:Label></td>
		    </tr>
            <!-- Criado novo painel para não visualizar Tensões das outras máquinas(TMT)-->
            <asp:Panel ID="pnl_ten" runat="server" Visible="true">
		    <tr class="linha_par">
            <td class="font_body">UNITENS</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tun_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">C.V. UNITENS</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tcv_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            </asp:Panel>

            <!-- Inicio TMT-->
            <asp:Panel ID="pnl_tmt_ten" runat="server" Visible="false">
            <tr>
		        <td class="font_body">Tensão do TCS(cN)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_tcs_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">CV%</td>
		        <td align="right" class="font_body"><asp:Label id="txt_cvp_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            <!-- Fim TMT-->

	        <asp:Panel runat="server" ID="pnl_ddi">
	        <tr>
		        <td colspan="2" class="destaque">Dados Informativos</td>
	        </tr>
	        <asp:Panel runat="server" ID="pnl_ddi_pdr">
           	<tr class="linha_par">
            <td class="font_body" style="width:180px">Tempo de Virada(min)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_vrr_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">T2/T1</td>
		    <td class="font_body" align="right"><asp:Label id="txt_t21_rel" runat="server"></asp:Label></td>
		    </tr>
	        <asp:Panel runat="server" ID="pnl_tmt_tss">
            <tr class="linha_par">
            <td class="font_body">SURGE SPEED(m/min)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tss_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
	        <asp:Panel runat="server" ID="pnl_tmt_ssv">
           	<tr class="linha_par">
		        <td class="font_body">Surge Speed (m/min)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ssv_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body">Surge Speed (%)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ssp_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            </asp:Panel>
	        <asp:Panel runat="server" ID="pnl_ddi_sta">
            <tr class="linha_par">
            <td class="font_body">Metragem Total</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dim_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            </asp:Panel>

            <!-- Início TMT-->
            <asp:Panel ID="pnl_tmt_rol" runat="server" Visible="false">
	            <tr>
		            <td colspan="2" class="destaque">Roller Switch</td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" style="width:150px">Oil</td>
    		        <td class="font_body" align="right" style="width:80px"><asp:Label id="cbo_roi_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">FR0</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_rr0_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">FR01</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_r01_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">FR1</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_rr1_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">FR2</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_rr2_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">FR2A</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_r2a_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">FR3</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_rr3_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">WR</td>
    		        <td align="right" class="font_body"><asp:Label id="cbo_rwr_rel" runat="server"></asp:Label></td>
	            </tr>
            </asp:Panel>
            <!-- Fim TMT-->

        </table>       
	    </td>

	    <td class="bordaAzul" style="width:260px">
        <table>       
            <asp:Panel runat="server" ID="pnl_reg">
	            <tr>
		            <td colspan="2" class="destaque">Regulagens Barco</td>
	            </tr>
           	    <tr class="linha_par">
                <td class="font_body" style="width:180px">Short Quality</td>
		        <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_rsq_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr>
                    <td class="font_body">Long Quality</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rlq_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr class="linha_par">
                    <td class="font_body">Ref Mean Dev</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rrm_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr>
                    <td class="font_body">Max CV</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rmx_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr class="linha_par">
                    <td class="font_body">Min CV</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rmn_rel" runat="server"></asp:Label></td>
		        </tr>
                <asp:Panel ID="pnl_rmh_rel" runat="server">
		        <tr>
                    <td class="font_body">Max Hariness</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rmh_rel" runat="server"></asp:Label></td>
		        </tr>
                </asp:Panel>
		        <tr class="linha_par">
                    <td class="font_body">Quality Stop Limits</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rqs_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr>
                    <td class="font_body">Thick Yarn Stop</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rty_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr class="linha_par">
                    <td class="font_body">Thin Yarn Stop</td>
		            <td class="font_body" align="right"><asp:Label id="txt_rhy_rel" runat="server"></asp:Label></td>
		        </tr>
            </asp:Panel>

            <asp:Panel runat="server" ID="pnl_uni">
	        <tr>
		        <td colspan="2" class="destaque">Regulagem Unitens</td>
	        </tr>
            <tr class="linha_par">
            <td class="font_body" style="width:180px">Título Real(dtex)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_tre_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Fault Duration(s)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dur_rel" runat="server"></asp:Label></td>
		    </tr>
            <!-- 26/09/2014 Inicio -->
            <tr class="linha_par">
            <td class="font_body">Upper Mean(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ume_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Lower Mean(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lme_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Upper Peak(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_upe_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Lower Peak(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lpe_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Upper CV(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ucv_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Lower CV(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lcv_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Mean Drift(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dft_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Upper meanC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_umc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Lower meanC</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lmc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Upper peakC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_upc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Lower peakC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lpc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Upper CVC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_cvc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Lower CVC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_lvc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Mean DriftC(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dfc_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Total Fault Sum(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tfs_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">F Sum Window(nº)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_fsw_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr class="linha_par">
            <td class="font_body">Width F Wind(min)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_wfw_rel" runat="server"></asp:Label></td>
		    </tr>
            <tr>
            <td class="font_body">Yarn Break Threshold(cN)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ybt_rel" runat="server"></asp:Label></td>
		    </tr>
            <!-- 26/09/2014 Fim -->
            </asp:Panel>

            <asp:Panel ID="pnl_ddt" runat="server">
            <tr>
		        <td colspan="2" class="destaque">Dados Téxteis</td>
	        </tr>
		    <tr class="linha_par">
            <td class="font_body" style="width:180px">Título(dtex)</td>
		    <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_tit_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Tenacidade(cN/dtex)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_tnc_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Alongamento(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_aon_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Encolhimento(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_enm_rel" runat="server"></asp:Label></td>
		    </tr>
            <asp:Panel ID="pnl_ekb" runat="server">
		    <tr class="linha_par">
            <td class="font_body">E%</td>
		    <td class="font_body" align="right"><asp:Label id="txt_eee_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">K%</td>
		    <td class="font_body" align="right"><asp:Label id="txt_kkk_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">B%</td>
		    <td class="font_body" align="right"><asp:Label id="txt_bbb_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
		    <tr>
            <td class="font_body">Óleo(%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ole_rel" runat="server"></asp:Label></td>
		    </tr>
            <asp:Panel ID="pnl_trq_ert_rt3_rt5" runat="server">
		    <tr class="linha_par">
            <td class="font_body">Torque(T/m/s)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_trq_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Entrelaçamento</td>
		    <td class="font_body" align="right"><asp:Label id="txt_ert_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Retenção(3%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_rt3_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Retenção(5%)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_rt5_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
		    <tr class="linha_par">
            <td class="font_body">Peso(g)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_pes_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Diâmetro(cm)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dmo_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Densidade(g/cm3)</td>
		    <td class="font_body" align="right"><asp:Label id="txt_dnd_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel ID="pnl_M900_V900" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Engrenagens</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body" style="width:180px">Z1</td>
		        <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_ez1_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z2</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ez2_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z3</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ez3_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z4</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ez4_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z5</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ez5_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z6</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ez6_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <asp:Panel ID="pnl_Stahle" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Engrenagens</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body" style="width:180px">Z1</td>
		        <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_sta_z01_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z2</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z02_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z3</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z03_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z4</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z04_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z5</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z05_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z6</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z06_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z7</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z07_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z8</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z08_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z9</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z09_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z10</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z10_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z11</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z11_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z12</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z12_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Z13</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z13_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Z14</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_z14_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            <asp:Panel ID="pnl_sta_ctn" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Polias</td>
	        </tr>
		    <tr class="linha_par">
                <td class="font_body" style="width:180px">P1</td>
		        <td class="font_body" align="right" style="width:80px"><asp:Label id="txt_sta_sp1_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">P2</td>
		        <td class="font_body" align="right"><asp:Label id="txt_sta_sp2_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>

            <!-- Início TMT-->
            <asp:Panel ID="pnl_tmt_tcs" runat="server" Visible="false">
	        <tr>
		        <td colspan="2">
            <table>
	            <tr>
		            <td colspan="3" class="destaque">Regulagens TCS</td>
	            </tr>
                <tr class="linha_par">
                <td class="font_body">Título Real(dtex)</td>
		        <td colspan="2" align="center" class="font_body"><asp:Label id="txt_ttr_rel" runat="server"></asp:Label></td>
		        </tr>
		        <tr class="linha_par">
		            <td class="font_body">Ply Layout</td>
                    <td colspan="2"><asp:Label id="cbo_pll_rel" runat="server"></asp:Label></td>
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
		            <td class="font_body" align="right"><asp:Label id="txt_tte_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Number of Ply</td>
                    <td class="font_body" align="right"><asp:Label id="cbo_ply_rel" runat="server"></asp:Label></td>
	            </tr>
                <asp:Panel ID="pnl_wpo_001" runat="server" Visible="true">
		        <tr class="linha_par">
		            <td class="font_body">Winding Position</td>
                    <td class="font_body" align="right"><asp:Label id="cbo_wpo_001_rel" runat="server"></asp:Label></td>
	            </tr>
                </asp:Panel>
	            <tr>
		            <td class="font_body">Direction</td>
		            <td class="font_body" align="right"><asp:Label id="txt_dir_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Control Range</td>
		            <td class="font_body" align="right"><asp:Label id="txt_cra_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">Control Error D.</td>
                    <td class="font_body" align="right"><asp:Label id="cbo_ced_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Ply Cut Function</td>
                    <td class="font_body" align="right"><asp:Label id="cbo_plf_rel" runat="server"></asp:Label></td>
	            </tr>
                <asp:Panel ID="pnl_plf_001" runat="server" Visible="true">
		        <tr class="linha_par">
		            <td class="font_body">Tension Dev.</td>
		            <td class="font_body" align="right"><asp:Label id="txt_ted_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">Detect Lenght</td>
		            <td class="font_body" align="right"><asp:Label id="txt_dle_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Count Times</td>
		            <td class="font_body" align="right"><asp:Label id="txt_cti_001_rel" runat="server"></asp:Label></td>
	            </tr>
                </asp:Panel>
	            <tr>
		            <td class="font_body">GL1O</td>
		            <td class="font_body" align="right"><asp:Label id="txt_g1o_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL1U</td>
		            <td class="font_body" align="right"><asp:Label id="txt_g1u_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">GL2O</td>
		            <td class="font_body" align="right"><asp:Label id="txt_g2o_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL2U</td>
		            <td class="font_body" align="right"><asp:Label id="txt_g2u_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">CV(%)</td>
		            <td class="font_body" align="right"><asp:Label id="txt_cvp_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Over Cut(%)</td>
		            <td class="font_body" align="right"><asp:Label id="txt_ocu_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">Under Cut(%)</td>
		            <td class="font_body" align="right"><asp:Label id="txt_ucu_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL1O Count</td>
		            <td class="font_body" align="right"><asp:Label id="txt_c1o_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">GL1O Length</td>
		            <td class="font_body" align="right"><asp:Label id="txt_l1o_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL1U Count</td>
		            <td class="font_body" align="right"><asp:Label id="txt_c1u_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">GL1U Length</td>
		            <td class="font_body" align="right"><asp:Label id="txt_l1u_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL2O Count</td>
		            <td class="font_body" align="right"><asp:Label id="txt_c2o_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">GL2O Length</td>
		            <td class="font_body" align="right"><asp:Label id="txt_l2o_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">GL2U Count</td>
		            <td class="font_body" align="right"><asp:Label id="txt_c2u_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">GL2U Length</td>
		            <td class="font_body" align="right"><asp:Label id="txt_l2u_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">Total Sum</td>
		            <td class="font_body" align="right"><asp:Label id="txt_tsu_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">CV Count</td>
		            <td class="font_body" align="right"><asp:Label id="txt_cvc_001_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body">CV Lenght</td>
		            <td class="font_body" align="right"><asp:Label id="txt_cvl_001_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body">Total Length</td>
		            <td class="font_body" align="right"><asp:Label id="txt_tle_001_rel" runat="server"></asp:Label></td>
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
		            <td class="font_body" align="right"><asp:Label id="txt_tte_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
                    <td>
                    </td>
	            </tr>
                <asp:Panel ID="pnl_wpo_002" runat="server" Visible="true">
		        <tr class="linha_par">
                    <td class="font_body" align="right"><asp:Label id="cbo_wpo_002_rel" runat="server"></asp:Label></td>
	            </tr>
                </asp:Panel>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_dir_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_cra_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
                    <td class="font_body" align="right"><asp:Label id="cbo_ced_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
                    <td>
                    </td>
	            </tr>
                <asp:Panel ID="pnl_plf_002" runat="server" Visible="true">
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_ted_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_dle_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_cti_002_rel" runat="server"></asp:Label></td>
	            </tr>
                </asp:Panel>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_g1o_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_g1u_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_g2o_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_g2u_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_cvp_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_ocu_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_ucu_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_c1o_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_l1o_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_c1u_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_l1u_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_c2o_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_l2o_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_c2u_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_l2u_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_tsu_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_cvc_002_rel" runat="server"></asp:Label></td>
	            </tr>
		        <tr class="linha_par">
		            <td class="font_body" align="right"><asp:Label id="txt_cvl_002_rel" runat="server"></asp:Label></td>
	            </tr>
	            <tr>
		            <td class="font_body" align="right"><asp:Label id="txt_tle_002_rel" runat="server"></asp:Label></td>
	            </tr>
                </table>
                </asp:Panel>
                </td>
                </tr>
            </table>       
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
		<td colspan="4" class="bordaAzul">
            Detalhes: 
    		<asp:Label id="txt_det_rel" runat="server"></asp:Label> 
		</td>
	</tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="bordaAzul">
            Observação: 
    		<asp:Label id="txt_obs_rel" runat="server"></asp:Label> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Responsável: <asp:Label ID="lb_rsp_rel" runat="server"/>, atualizado em: <asp:Label ID="lb_tms_rel" runat="server"/>, por: <asp:Label ID="lb_usr_rel" runat="server"/></td>
	</tr>
</table>
<br />

<!-- Quebra de Página-->
<asp:Panel ID="pnl_pag" runat="server" class="quebraPagina">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="4" class="font_titulo_grd" style="width:780px">
			<asp:Label runat="server" ID="lbAcao_002" CssClass="font_titulo_grd"></asp:Label>
			Standard
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>

	<tr>
		<td colspan="4">
        <table class="bordaAzul">
	    <tr>
		    <td class="font_body">
                Data: 
			    <asp:Label id="txt_dat_002_rel" runat="server"></asp:Label>
                &nbsp;
                Versão: 
			    <asp:Label id="txt_vrs_002_rel" runat="server"></asp:Label>
		    </td>
		    <td class="font_body">
                Lote Referência: 
			    <asp:Label id="txt_lot_ref_002_rel" runat="server"></asp:Label>
		    </td>
    	    <td class="font_body">
                Máquina: 
			    <asp:Label id="txt_maq_tip_id_002_rel" runat="server"></asp:Label>
    		    <asp:DropDownList ID="cbo_maq_tip_id_002_rel" runat="server" CssClass="combo_box" Visible="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
		        </asp:DropDownList>
		    </td>
	    </tr>
	    <tr style="vertical-align:top">
	        <td class="bordaAzul" style="width:260px">
            <table>       
            <asp:Panel ID="pnl_afk_3" runat="server">
	        <tr>
		        <td colspan="2" class="destaque">Enrolamento AFK 3</td>
	        </tr>
            <tr class="linha_par">
                <td class="font_body" width="180px">Taper Angle (º)</td>
		        <td class="font_body" align="right" width="80px"><asp:Label id="txt_eta_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Starting Taper Height (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_eth_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Starting Taper Gradient (%)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_etg_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Diameter Tube (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_edt_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Diameter Full Package (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_efp_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Decrease of Yarn tension (%)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_eyt_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Overfeed W5 Dye Layer (%)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_edl_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Anti-Bulging (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_eab_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Crossing Angle (º)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_eca_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Additional Length Center Wrap (Rev.)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ecw_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Length Transfer-Tail Dye Layer (Rev.)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_etl_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Length Transfer-Tail (Rev.)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ett_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Right Edge of Package (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ere_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Left Edge of Package (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ele_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
                <td class="font_body">Position Transfer Tail (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_ept_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
                <td class="font_body">Position Transfer Tail Dye Layer (mm)</td>
		        <td class="font_body" align="right"><asp:Label id="txt_epl_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            <!-- Início TMT-->
            <asp:Panel ID="pnl_tam" runat="server" Visible="false">
			<tr>
		        <td colspan="2" class="destaque">Taper Angle Multistage</td>
	        </tr>
		    <tr>
		        <td class="font_body" width="180px">Second Taper Angle [deg]</td>
		        <td align="right" class="font_body" width="80px"><asp:Label id="txt_std_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Second Taper Angle PGK diameter (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_stp_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body">Third Taper Angle [deg]</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ttd_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Third Taper Angle PGK diameter (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ttp_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body">Fourth Taper Angle [deg]</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ftd_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Fourth Taper Angle PGK diameter (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_ftp_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body">Fifth Taper Angle [deg]</td>
		        <td align="right" class="font_body"><asp:Label id="txt_itd_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Fifth Taper Angle PGK diameter (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_itp_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr>
		        <td class="font_body">Sixth Taper Angle [deg]</td>
		        <td align="right" class="font_body"><asp:Label id="txt_xtd_rel" runat="server"></asp:Label></td>
	        </tr>
		    <tr class="linha_par">
		        <td class="font_body">Sixth Taper Angle PGK diameter (mm)</td>
		        <td align="right" class="font_body"><asp:Label id="txt_xtp_rel" runat="server"></asp:Label></td>
	        </tr>
            </asp:Panel>
            <!-- Fim TMT-->
            </table>       
	        </td>
	        <td class="bordaAzul" style="width:260px">
            <table>       
            <asp:Panel ID="pnl_afk_dtx_2s_t2s_ds" runat="server">
			<tr>
		        <td colspan="2" class="destaque">Dados Téxteis</td>
	        </tr>
            <tr>
            <td class="font_body" width="180px">% de Core</td>
		    <td class="font_body" align="right" width="80px"><asp:Label id="txt_pco_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">% de Cover</td>
		    <td class="font_body" align="right"><asp:Label id="txt_pcv_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Draft</td>
		    <td class="font_body" align="right"><asp:Label id="txt_drt_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            </table>
            </td>
	        <td class="bordaAzul" style="width:260px">
            <table>       
            <asp:Panel ID="pnl_afk_cop_2s_t2s_ds" runat="server">
			<tr>
		        <td colspan="2" class="destaque">Condições de Operação</td>
	        </tr>
		    <tr class="linha_par">
            <td class="font_body" width="180px">Tensão Alim (g)</td>
		    <td class="font_body" align="right" width="80px"><asp:Label id="txt_tal_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr>
            <td class="font_body">Voltas Alim</td>
		    <td class="font_body" align="right"><asp:Label id="txt_val_rel" runat="server"></asp:Label></td>
		    </tr>
		    <tr class="linha_par">
            <td class="font_body">Sentido Jet</td>
		    <td class="font_body" align="right"><asp:Label id="txt_sje_rel" runat="server"></asp:Label></td>
		    </tr>
            </asp:Panel>
            </table>
            </td>
	    </tr>
        </table>
        </td>
    </tr>
	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="bordaAzul">
            Detalhes: 
    		<asp:Label id="txt_det_002_rel" runat="server"></asp:Label> 
		</td>
	</tr>

	<tr>
		<td colspan="4">&nbsp</td>
	</tr>
	<tr>
		<td colspan="4" class="bordaAzul">
            Observação: 
    		<asp:Label id="txt_obs_002_rel" runat="server"></asp:Label> 
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Responsável: <asp:Label ID="lb_rsp_002_rel" runat="server"/>, atualizado em: <asp:Label ID="lb_tms_002_rel" runat="server"/>, criado por: <asp:Label ID="lb_usr_002_rel" runat="server"/></td>
	</tr>
</table>
</asp:Panel>

</div>
</div>
</form>
</body>
</html>