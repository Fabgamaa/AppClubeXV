<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioResultadoDynafil.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : RelatorioResultadoDynafil.aspx 
Criado em         : 04/11/2010
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Relatório Resultado de Dynafil
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 TrDNFitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-trDNFitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmResultadoDynafil" runat="server">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Relatório Resultado de Dynafil
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
		<td colspan="2" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO" Selected="True"></asp:ListItem>
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
<div runat="server" id="dvResultadoDynafil" visible="false">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="5" class="font_titulo_grd">
			Relatório Resultado de Dynafil
		</td>
	</tr>
	<tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
		<table>		

	    <tr>
		    <td class="font_body">Merge</td>
		    <td class="font_body">Fornecedor</td>
		    <td class="font_body">Título</td>
		    <td class="font_body">Velocidade</td>
		    <td class="font_body">Data Inicial</td>
		    <td class="font_body">Data Final</td>
	    </tr>
	    <tr>
		    <td>
			    <asp:TextBox id="txt_mge_rel" runat="server" CssClass="text_box" maxlength="18" style="width:180px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_for_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_tit_poy_id_rel" runat="server" CssClass="combo_box" Enabled="false">
				    <asp:ListItem value="" Text=""></asp:ListItem>
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:TextBox id="txt_vlc_rel" runat="server" CssClass="text_box" maxlength="10" style="width:100px" Enabled="false"></asp:TextBox>
		    </td>
		    <td>
    			<asp:TextBox id="txt_dat_ini_rel" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		    </td>
		    <td>
    			<asp:TextBox id="txt_dat_fim_rel" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		    </td>
	    </tr>

        </table>
        </td>
    </tr>    
	<tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
        <table>        
		<tr>
            <td class="font_body_destaque" colspan="4">Quantidade de análises encontradas: <asp:Label ID="lbl_qtd_ans" runat="server" Text="0"></asp:Label></td>
            <td class="font_body_destaque" colspan="1">Quantidade de bobinas analisadas: <asp:Label ID="lbl_qtd_bob" runat="server" Text="0"></asp:Label></td>
        </tr>
		<tr>
            <td colspan="5">&nbsp;</td>
        </tr>
		<tr>
            <td class="font_body_destaque">&nbsp;</td>
            <td class="font_body_destaque">Média</td>
            <td class="font_body_destaque">Mínimo</td>
            <td class="font_body_destaque">Máximo</td>
            <td class="font_body_destaque">Desvio</td>
        </tr>
        <tr>
            <td class="font_body_destaque">Título</td>
		    <td><asp:TextBox id="txt_tit_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tit_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tit_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tit_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">Tenacidade</td>
		    <td><asp:TextBox id="txt_tnc_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_tnc_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">Alongamento</td>
		    <td><asp:TextBox id="txt_aon_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_aon_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">CV - Eveness</td>
		    <td><asp:TextBox id="txt_eve_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_eve_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">Fil. Quebrados</td>
		    <td><asp:TextBox id="txt_qbr_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_qbr_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">Força</td>
		    <td><asp:TextBox id="txt_foa_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_foa_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
	    </tr>
		<tr>
            <td class="font_body_destaque">CV - Força</td>
		    <td><asp:TextBox id="txt_cvf_med" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_min" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_max" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
		    <td><asp:TextBox id="txt_cvf_dsv" runat="server" CssClass="text_box"  maxlength="10" style="width:100px; background-color:Silver" ReadOnly="true"></asp:TextBox></td>
        </tr>

        </table>
        </td>
    </tr>    
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
    <tr>
	    <td colspan="5" class="destaque">Dados</td>
    </tr>
    <tr>
		<td colspan="5">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="5">
			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>
			<asp:GridView Width="760px" CausesValidation="false"   ID="gvResultadoDynafil" DataKeyNames="DNF_ID" 
				runat="server" AutoGenerateColumns="False" AllowSorting="True" 
				OnRowDataBound="gvResultadoDynafil_RowDataBound"  OnSorting="gvResultadoDynafil_Sorting"
				OnRowCreated="gvResultadoDynafil_RowCreated"
				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
			<Columns>
			<asp:TemplateField HeaderText=" Merge " SortExpression="DNF_MGE" ControlStyle-Width="180px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_MGE" runat="server" Text='<%# Eval("DNF_MGE") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Fornecedor " SortExpression="FOR_NOM" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbFOR_NOM" runat="server" Text='<%# Eval("FOR_NOM") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_POY_DES" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_POY_DES" runat="server" Text='<%# Eval("TIT_POY_DES") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Velocidade " SortExpression="DNF_VLC" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbDNF_VLC" runat="server" Text='<%# Eval("DNF_VLC") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Data " SortExpression="DNF_DAT" ControlStyle-Width="60px" >
			<ItemTemplate>
					<asp:Label ID="lbDNF_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("DNF_DAT").ToString())?"":Convert.ToDateTime(Eval("DNF_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
			</ItemTemplate>

<ControlStyle Width="80px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>

			    <asp:TemplateField HeaderText="Data Fiação" SortExpression="DNF_DAT_FIA" ControlStyle-Width="80px">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DNF_DAT_FIA") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("DNF_DAT_FIA", "{0:d}") %>'></asp:Label>
                    </ItemTemplate>
                    <HeaderStyle ForeColor="White" />
                </asp:TemplateField>

			<asp:TemplateField HeaderText=" Título " SortExpression="TIT_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTIT_MED" runat="server" Text='<%# Eval("TIT_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Tenacidade " SortExpression="TNC_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbTNC_MED" runat="server" Text='<%# Eval("TNC_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			<asp:TemplateField HeaderText=" Alongamento " SortExpression="AON_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbAON_MED" runat="server" Text='<%# Eval("AON_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
 			<asp:TemplateField HeaderText=" CV - Eveness " SortExpression="EVE_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbEVE_MED" runat="server" Text='<%# Eval("EVE_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
 			<asp:TemplateField HeaderText=" Fil. Quebrados " SortExpression="QBR_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbQBR_MED" runat="server" Text='<%# Eval("QBR_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
 			<asp:TemplateField HeaderText=" Força " SortExpression="FOA_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbFOA_MED" runat="server" Text='<%# Eval("FOA_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
 			<asp:TemplateField HeaderText=" CV - Força " SortExpression="CVF_MED" ControlStyle-Width="60px" >
			<ItemTemplate>
				<asp:Label ID="lbCVF_MED" runat="server" Text='<%# Eval("CVF_MED") %>' />
			</ItemTemplate>

<ControlStyle Width="60px"></ControlStyle>

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