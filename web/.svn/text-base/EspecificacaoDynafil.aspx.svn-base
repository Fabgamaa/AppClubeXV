<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="EspecificacaoDynafil.aspx.cs" Inherits="_Default"%><%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%><!--#include file="inc/FWMNUSUB.aspx"--><!-- :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Empresa           : Fourway InformáticaSistema           : FWUNFArquivo           : EspecificacaoDynafil.aspx Criado em         : 11/03/2011Última Alteração  : Versão            : 1.00Descrição         : Módulo para Cadastro de Especificação de Dynafil:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml"><head id="Head" runat="server"><link rel="stylesheet" type="text/css" href="css/FW.css"/>	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title></head><body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px"><form id="frmEspecificacao" runat="server" action="EspecificacaoDynafil.aspx"><asp:HiddenField ID="Origem" runat="server" /><asp:HiddenField ID="rowId" runat="server" /><script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script><script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script><ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra><div style="left:5px"><div runat="server" id="dvFiltro" visible="true"><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">	<tr>		<td colspan="2" class="font_titulo_grd" style="width:780px">			Pesquisar Especificação Dynafil		</td>	</tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>
		<td colspan="2" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_dat" runat="server" CssClass="text_box" maxlength="10" style="width:80px"></asp:TextBox>
		</td>
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
	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td colspan="2">			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" /> &nbsp;&nbsp;			<asp:Button ID="btLimpar"     runat="server" CssClass="botao" Text="Limpar" OnClick="btLimpar_Click" /> &nbsp;&nbsp;			<asp:Button ID="btNovoFiltro" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovo_Click" />		</td>	</tr></table></div><div runat="server" id="dvResultado" visible="false"><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">	<tr>		<td class="font_titulo_grd" style="width:780px">			Pesquisar Especificação Dynafil		</td>	</tr>	<tr>		<td class="font_body" style="width:780px" align="right">			<asp:Label ID="lb_fil" runat="server" CssClass="font_body_maiusculo" />&nbsp;		</td>	</tr>	<tr>		<td colspan="2">&nbsp;</td>	</tr>	<tr>		<td align="right">			<asp:Button ID="btVoltarGrid"     runat="server" CssClass="botao" Text="Filtro" Onclick="btVoltar_Click" /> &nbsp;&nbsp;			<asp:Button ID="btNovoFiltroGrid" runat="server" CssClass="botao" Text="Novo"   Onclick="btNovo_Click" />		</td>	</tr>	<tr>		<td align="right">			<asp:LinkButton ID="lkb_pdf" runat="server" OnClick="lkb_pdf_Click" Text="pdf" ToolTip="Exporta para PDF"></asp:LinkButton>			&nbsp;			<asp:LinkButton ID="lkb_xls" runat="server" OnClick="lkb_xls_Click" Text="xls" ToolTip="Exporta para XLS"></asp:LinkButton>		</td>	</tr>	<tr>		<td>			<asp:Label ID="lblSortLogin" runat="server" Visible="false" Text="ASC"></asp:Label>			<asp:GridView Width="760px" CausesValidation="false"   ID="gvEspecificacaoDynafil" DataKeyNames="EDF_ID" 				runat="server" AutoGenerateColumns="false" AllowSorting="true" 				OnRowDataBound="gvEspecificacaoDynafil_RowDataBound"  OnSorting="gvEspecificacaoDynafil_Sorting"				OnRowCreated="gvEspecificacaoDynafil_RowCreated"				EmptyDataText="Não foram encontrados registros de acordo com o filtro.">			<Columns>
                <asp:TemplateField HeaderText=" Data " SortExpression="EDF_DAT" ControlStyle-Width="80px" >
                <ItemTemplate>
	                <asp:Label ID="lbEDF_DAT" runat="server" Text='<%# String.IsNullOrEmpty(Eval("EDF_DAT").ToString())?"":Convert.ToDateTime(Eval("EDF_DAT").ToString()).ToString("dd/MM/yyyy") %>' />
                </ItemTemplate>
                <ControlStyle Width="80px"></ControlStyle>
                <HeaderStyle ForeColor="White" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText=" Merge " SortExpression="EDF_MGE" ControlStyle-Width="180px" >
                <ItemTemplate>
	                <asp:Label ID="lbEDF_MGE" runat="server" Text='<%# Eval("EDF_MGE") %>' />
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
                <asp:TemplateField HeaderText=" Velocidade " SortExpression="EDF_VLC" ControlStyle-Width="60px" >
                <ItemTemplate>
	                <asp:Label ID="lbEDF_VLC" runat="server" Text='<%# Eval("EDF_VLC") %>' />
                </ItemTemplate>
                <ControlStyle Width="60px"></ControlStyle>
                <HeaderStyle ForeColor="White" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText=" Status " SortExpression="EDF_STS" ControlStyle-Width="80px" >
                <ItemTemplate>
	                <asp:Label ID="lbEDF_STS" runat="server" Text='<%# (Eval("EDF_STS").ToString() == "1")?"ATIVO":"INATIVO" %>'/>
                </ItemTemplate>
                <ControlStyle Width="80px"></ControlStyle>
                <HeaderStyle ForeColor="White" />
                </asp:TemplateField>
            </Columns>
			<AlternatingRowStyle CssClass="linha_impar" />			<RowStyle CssClass="linha_par" />			<SelectedRowStyle CssClass="selecionado" />			<HeaderStyle CssClass="cabecalho_tabela" />			<EmptyDataRowStyle CssClass="font_body" />			</asp:GridView>		</td>	</tr></table></div><div ID="divCadastro" runat="server"><table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">	<tr>		<td colspan="4" class="font_titulo_grd" style="width:780px">			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>			Especificação Dynafil		</td>	</tr>	<tr>		<td colspan="4">&nbsp;</td>	</tr>	<tr>
		<td colspan="4" class="font_body">Data</td>
	</tr>
	<tr>
		<td colspan="4">
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box"  maxlength="10" style="width:100px"></asp:TextBox> *
		</td>
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
		<td colspan="2" class="font_body">Velocidade</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_vlc_inc" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>		<td colspan="4">&nbsp;</td>	</tr>	<tr>        <td class="font_body">&nbsp;</td>        <td class="font_body">Média</td>        <td class="font_body">Tolerância</td>		<td class="font_body">Mínimo</td>		<td class="font_body">Máximo</td>    </tr>	<tr>		<td class="font_body">Título (Dtex)</td>		<td>			<asp:TextBox id="txt_tit_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tit_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tit_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tit_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">Tenacidade (cN/tex)</td>		<td>			<asp:TextBox id="txt_tnc_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tnc_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tnc_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_tnc_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">Alongamento (%)</td>		<td>			<asp:TextBox id="txt_aon_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_aon_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_aon_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_aon_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">CV - Eveness</td>		<td>			<asp:TextBox id="txt_eve_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_eve_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_eve_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_eve_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">Fil. Quebrados</td>		<td>			<asp:TextBox id="txt_qbr_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_qbr_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_qbr_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_qbr_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">Força</td>		<td>			<asp:TextBox id="txt_foa_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_foa_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_foa_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_foa_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td class="font_body">CV - Força</td>		<td>			<asp:TextBox id="txt_cvf_med_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_cvf_tlr_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px" OnTextChanged="CalculaMinimoMaximo" AutoPostBack="true"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_cvf_min_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>		<td>			<asp:TextBox id="txt_cvf_max_inc" runat="server" CssClass="text_box"  maxlength="9" style="width:90px"></asp:TextBox> 		</td>	</tr>	<tr>		<td colspan="4">&nbsp;</td>	</tr>	<tr>		<td colspan="4" class="font_body">Observação</td>	</tr>	<tr>		<td colspan="4">    		<asp:TextBox id="txt_obs_inc" runat="server" CssClass="text_box"  maxlength="1600"  style="width:600px;" TextMode="MultiLine" Rows="5" ></asp:TextBox> 		</td>	</tr>	<tr>		<td colspan="4" class="font_body">Status</td>	</tr>	<tr>		<td colspan="4">			<asp:DropDownList ID="cbo_sts_inc" runat="server" CssClass="combo_box">				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>			</asp:DropDownList> *		</td>	</tr>	<tr>		<td colspan="4">&nbsp;</td>	</tr>	<tr>		<td colspan="4">			<asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" Onclick="btSalvar_Click" /> &nbsp;&nbsp;			<asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" Onclick="btVoltar_Click" /> &nbsp;&nbsp;			<asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" Onclick="btNovo_Click" />		</td>	</tr></table></div></div></form></body></html>