<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioEtiquetaVirada.aspx.cs" Inherits="_Default"%><%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%><!--#include file="inc/FWMNUSUB.aspx"--><!-- :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Empresa           : Fourway InformáticaSistema           : FWUNFArquivo           : RelatorioViradaTempo.aspx Criado em         : 09/05/2012Última Alteração  : Versão            : 1.00Descrição         : Módulo para Relatório Distribuição de Virada:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml"><head id="Head" runat="server"><link rel="stylesheet" type="text/css" href="css/FW.css"/>	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title></head><body id="bdyDST_VRD" runat="server" class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px"><form id="frmDST_VRD" runat="server"><asp:HiddenField ID="Origem" runat="server" /><asp:HiddenField ID="rowId" runat="server" /><asp:HiddenField ID="hid_epf_id" runat="server" /><script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script><script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script><ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra><div style="left:5px"><div runat="server" id="dvFiltro" visible="true"><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">	<tr>		<td colspan="2" class="font_titulo_grd" style="width:1024px">			Pesquisar Etiqueta de Virada		</td>	</tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>
		<td colspan="4" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_maq_id" runat="server" CssClass="combo_box">
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="4" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td colspan="2">			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;		</td>	</tr></table></div><div runat="server" id="dvResultado" visible="false"><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">	<tr>		<td class="font_titulo_grd" style="width:780px">			Relatório Etiqueta de Virada 		</td>	</tr>	<tr>		<td class="font_body" style="width:780px" align="right">			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;		</td>	</tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td>			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>			<asp:GridView Width="760px" CausesValidation="false"   ID="gvLancamentoMaquina" DataKeyNames="MAQ_DES, LNC_MAQ_LOT, LNC_MAQ_PRD, LNC_MAQ_DES, LNC_MAQ_POS" 				runat="server" AutoGenerateColumns="false" AllowSorting="false" 				OnRowDataBound="gvLancamentoMaquina_RowDataBound" 				OnRowCreated="gvLancamentoMaquina_RowCreated" 				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">			<Columns>			<asp:TemplateField HeaderText=" Máquina " SortExpression="MAQ_DES" ControlStyle-Width="100px" >			<ItemTemplate>				<asp:Label ID="lbMAQ_DES" runat="server" Text='<%# Eval("MAQ_DES") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Lote " SortExpression="LNC_MAQ_LOT" ControlStyle-Width="60px" >			<ItemTemplate>				<asp:Label ID="lbLNC_MAQ_LOT" runat="server" Text='<%# Eval("LNC_MAQ_LOT") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Produto " SortExpression="LNC_MAQ_PRD" ControlStyle-Width="260px" >			<ItemTemplate>				<asp:Label ID="lbLNC_MAQ_PRD" runat="server" Text='<%# Eval("LNC_MAQ_PRD") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Descrição " SortExpression="LNC_MAQ_DES" ControlStyle-Width="260px" >			<ItemTemplate>				<asp:Label ID="lbLNC_MAQ_DES" runat="server" Text='<%# Eval("LNC_MAQ_DES") %>' />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Virada Inicial " ControlStyle-Width="80px" >			<ItemTemplate>				<asp:TextBox id="txt_vrd_ini" runat="server" CssClass="text_box" maxlength="4" style="width:40px" />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Virada Final " ControlStyle-Width="80px" >			<ItemTemplate>				<asp:TextBox id="txt_vrd_fim" runat="server" CssClass="text_box" maxlength="4" style="width:40px" />			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" Posições " ControlStyle-Width="300px" >			<ItemTemplate>			    <asp:DropDownList ID="ddl_pos" runat="server" CssClass="combo_box">
				    <asp:ListItem value="" Text=""></asp:ListItem>
				    <asp:ListItem value="Máquina Inteira - 1 a 216" Text="Máquina Inteira - 1 a 216"></asp:ListItem>
				    <asp:ListItem value="Lado A - 1 a 110" Text="Lado A - 1 a 110"></asp:ListItem>
				    <asp:ListItem value="Lado B - 109 a 216" Text="Lado B - 109 a 216"></asp:ListItem>
				    <asp:ListItem value="Máquina Inteira 2 Cabos - 1 a 110" Text="Máquina Inteira 2 Cabos - 1 a 110"></asp:ListItem>
				    <asp:ListItem value="Máquina Inteira 3 Cabos - 1 a 80" Text="Máquina Inteira 3 Cabos - 1 a 80"></asp:ListItem>
				    <asp:ListItem value="Máquina Inteira 4 Cabos - 1 a 60" Text="Máquina Inteira 4 Cabos - 1 a 60"></asp:ListItem>
				    <asp:ListItem value="Lado A 2 Cabos - 1 a 60" Text="Lado A 2 Cabos - 1 a 60"></asp:ListItem>
				    <asp:ListItem value="Lado B 2 Cabos - 55 a 109" Text="Lado B 2 Cabos - 55 a 60"></asp:ListItem>
				    <asp:ListItem value="Lado A 3 Cabos - 1 a 40" Text="Lado A 3 Cabos - 1 a 40"></asp:ListItem>
				    <asp:ListItem value="Lado B 3 Cabos - 37 a 72" Text="Lado B 3 Cabos - 37 a 72"></asp:ListItem>
				    <asp:ListItem value="Lado A 4 Cabos - 1 a 30" Text="Lado A 4 Cabos - 1 a 30"></asp:ListItem>
				    <asp:ListItem value="Lado B 4 Cabos - 28 a 54" Text="Lado B 4 Cabos - 28 a 54"></asp:ListItem>
				    <asp:ListItem value="Etiqueta de Quebra - 1 a 60" Text="Etiqueta de Quebra - 1 a 60"></asp:ListItem>
				    <asp:ListItem value="Murata - 121 a 240" Text="Murata - 121 a 240"></asp:ListItem>
				    <asp:ListItem value="Murata - 1 a 120" Text="Murata - 1 a 120"></asp:ListItem>
			    </asp:DropDownList> 
			</ItemTemplate>			<HeaderStyle ForeColor="White" />            </asp:TemplateField>			<asp:TemplateField HeaderText=" " ControlStyle-Width="20px">
            <HeaderTemplate>
                <asp:CheckBox ID="chk_sel_tdo" runat="server" AutoPostBack="true" oncheckedchanged="chk_sel_tdo_CheckedChanged" />
            </HeaderTemplate>
			<ItemTemplate>
                <asp:CheckBox ID="chk_sel" runat="server" />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			</Columns>			<AlternatingRowStyle CssClass="linha_impar" />			<RowStyle CssClass="linha_par" />			<SelectedRowStyle CssClass="selecionado" />			<HeaderStyle CssClass="cabecalho_tabela" />			<EmptyDataRowStyle CssClass="font_body" />			</asp:GridView>        </td>    </tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td colspan="2">			<asp:Button ID="btImprimir"   runat="server" CssClass="botao" Text="Imprimir" OnClick="btImprimir_Click" /> &nbsp;&nbsp;		</td>	</tr></table></div><div runat="server" id="dvEtiqueta" style="width:780px;" visible="false"><style>    .td_etiqueta { font-family:Arial; text-align:center; width:45mm; height:17mm; padding-left:1mm; padding-right:1mm;}    table tr.page-break{page-break-after:always}</style><table id="tEtiqueta" runat="server" cellspacing="0" cellpadding="0"></table></div></div></form></body></html>