﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioFalhasOLT.aspx.cs" Inherits="_Default"%><%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%><!--#include file="inc/FWMNUSUB.aspx"--><!-- :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Empresa           : Fourway InformáticaSistema           : FWUNFArquivo           : RelatorioFalhasOLT.aspx Criado em         : 09/05/2012Última Alteração  : Versão            : 1.00Descrição         : Módulo para Relatório Falhas OLT:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml"><head id="Head" runat="server"><link rel="stylesheet" type="text/css" href="css/FW.css"/>	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>    </head><body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px"><form id="frmDOFF" runat="server"><asp:HiddenField ID="Origem" runat="server" /><asp:HiddenField ID="rowId" runat="server" /><asp:HiddenField ID="hid_epf_id" runat="server" /><script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script><script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script><ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra><div style="left:5px"><div runat="server" id="dvFiltro" visible="true"></div><div runat="server" id="dvResultado" visible="false">    <tr><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">	<tr>		<td class="font_titulo_grd" style="width:780px">Relatório Falhas UNITENS</td>    </tr>    	<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">			<td class="font_titulo_grd" style="width:780px">			Pesquisar Falhas UNITENS		</td>	</tr>	<tr>		<td>&nbsp;</td>	</tr>	<tr>		<td class="font_body">Data Inicial</td>	</tr>	<tr>    <td>			<asp:TextBox id="txt_dat_ini" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>		</td>	</tr>	<tr>		<td class="font_body">Data Final</td>	</tr>    <tr>		<td>			<asp:TextBox id="txt_dat_fim" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>		</td>	</tr>    <tr>		<td class="font_body">Lote</td>	</tr>    <tr>	<td>			<asp:TextBox ID="txt_lot" runat="server" CssClass="text_box" MaxLength="10" style="width:100px"></asp:TextBox>		</td>	</tr>	<tr>	<td class="font_body">Maquina</td>    	<td>			&nbsp;</td>	</tr>	<tr>		<td class="font_body">            <asp:DropDownList ID="cbo_maq" runat="server" CssClass="combo_box">                <asp:ListItem></asp:ListItem>            </asp:DropDownList>        </td>	</tr>	<tr>	<td class="font_body">Merge</td>	</tr>	</tr>	<tr>		<td>            <asp:TextBox ID="txt_mge" runat="server" CssClass="text_box" style="width:180px"></asp:TextBox>            <br />        </td>	</tr>	<tr>		<td>			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;		</td>	</tr></table>	<tr>		<td class="font_body" style="width:780px" align="right">			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;		</td>	</tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td align="right">			<asp:LinkButton ID="lkb_pdf" runat="server" OnClick="lkb_pdf_Click" Text="pdf" ToolTip="Exporta para PDF"></asp:LinkButton>			&nbsp;			<asp:LinkButton ID="lkb_xls" runat="server" OnClick="lkb_xls_Click" Text="xls" ToolTip="Exporta para XLS"></asp:LinkButton>		</td>	</tr>	<tr>		<td>			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>			<asp:GridView Width="760px" CausesValidation="false"   ID="gvDOFF" DataKeyNames="DOF_LOT, DOF_MAQ" 				runat="server" AutoGenerateColumns="false" AllowSorting="true" 				OnRowDataBound="gvDOFF_RowDataBound"  OnSorting="gvDOFF_Sorting"				OnRowCreated="gvDOFF_RowCreated"				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">			<Columns>			<asp:TemplateField HeaderText=" Lote " SortExpression="DOF_LOT" ControlStyle-Width="100px" >			<ItemTemplate>				<asp:Label ID="lbDOF_LOT" runat="server" Text='<%# Eval("DOF_LOT") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Descrição " SortExpression="EPF_DES" ControlStyle-Width="100px" >			<ItemTemplate>				<asp:Label ID="lbEPF_DES" runat="server" Text='<%# Eval("EPF_DES") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Velocidade " SortExpression="EPF_VLC" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbEPF_VLC" runat="server" Text='<%# Eval("EPF_VLC") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Máquina " SortExpression="DOF_MAQ" ControlStyle-Width="100px" >			<ItemTemplate>				<asp:Label ID="lbDOF_MAQ" runat="server" Text='<%# Eval("DOF_MAQ") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Merge " SortExpression="DOF_MGE_001" ControlStyle-Width="180px" >			<ItemTemplate>				<asp:Label ID="lbDOF_MGE_001" runat="server" Text='<%# Eval("DOF_MGE_001") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Fim de Evento " SortExpression="DOF_REJ" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbDOF_REJ" runat="server" Text='<%# Eval("DOF_REJ") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Limite " SortExpression="DOF_LIM" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbDOF_LIM" runat="server" Text='<%# Eval("DOF_LIM") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			<asp:TemplateField HeaderText=" Total " SortExpression="DOF_TOT" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbDOF_TOT" runat="server" Text='<%# Eval("DOF_TOT") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>            <asp:TemplateField HeaderText=" %SL " SortExpression="PSL" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbPSL" runat="server" Text='' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>            <asp:TemplateField HeaderText=" S/L " SortExpression="QTD" ControlStyle-Width="40px" >			<ItemTemplate>				<asp:Label ID="lbQTD" runat="server" Text='' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />			</asp:TemplateField>			</Columns>			<AlternatingRowStyle CssClass="linha_impar" />			<RowStyle CssClass="linha_par" />			<SelectedRowStyle CssClass="selecionado" />			<HeaderStyle CssClass="cabecalho_tabela" />			<EmptyDataRowStyle CssClass="font_body" />			</asp:GridView>		</td>	</tr></table></div></div></form></body></html>