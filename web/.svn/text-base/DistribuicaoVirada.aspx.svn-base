<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="DistribuicaoVirada.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informática
Sistema           : FWUNF
Arquivo           : DistribuicaoVirada.aspx 
Criado em         : 31/05/2016
Última Alteração  : 
Versão            : 1.00
Descrição         : Módulo para Cadastro de Distribuição de Virada 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationSettings.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:1280px">
<form id="frmDistribuicaoVirada" runat="server" action="DistribuicaoVirada.aspx">
<asp:HiddenField ID="Origem" runat="server" />
<asp:HiddenField ID="rowId" runat="server" />
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<table style="width:1024px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	<tr>
		<td colspan="4" class="font_titulo_grd">
			<asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
			Distribuição de Virada
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td class="font_body">Operador (<label runat="server" id="lbl_qtd_opd">0</label>)</td>
		<td class="font_body">Virada (<label runat="server" id="lbl_qtd_vrd">0</label>)</td>
		<td class="font_body">Distribuição (<label runat="server" id="lbl_qtd_dst">0</label>)</td>
		<td colspan="2" class="font_body">Resumo (<label runat="server" id="lbl_qtd_rem">0</label>)</td>
	</tr>
	<tr>
		<td>
			<asp:ListBox ID="cbo_opd_id_inc" runat="server" CssClass="combo_box" Rows="30" SelectionMode="Multiple" Width="200px">
			</asp:ListBox>
			<asp:Button ID="btApaOpd" runat="server" Text="Apagar Operador" CssClass="botao" Onclick="btApaOpd_Click" Width="120px" />
		</td>
		<td>
			<asp:ListBox ID="cbo_lnc_maq_id_inc" runat="server" CssClass="combo_box" Rows="30" SelectionMode="Multiple" Width="250px">
			</asp:ListBox >
			<asp:Button ID="btApaLncMaq" runat="server" Text="Apagar Virada" CssClass="botao" Onclick="btApaLncMaq_Click" Width="120px" />
			<asp:Button ID="btBlack" runat="server" Text="P" Onclick="btBlack_Click" CssClass="botao" style="color: Black" Width="20px" />
			<asp:Button ID="btBlue" runat="server" Text="A" Onclick="btBlue_Click" CssClass="botao" style="color: Blue" Width="20px" />
			<asp:Button ID="btRed" runat="server" Text="V" Onclick="btRed_Click" CssClass="botao" style="color: Red" Width="20px" />
			<asp:Button ID="btGreen" runat="server" Text="V" Onclick="btGreen_Click" CssClass="botao" style="color: rgb(0, 176, 80)" Width="20px" />
			<asp:Button ID="btBold" runat="server" Text="N" Onclick="btBold_Click" CssClass="botao" style="color: Blue; font-weight: bold;" Width="20px" />
		</td>
		<td valign="top">
			<asp:ListBox ID="cbo_dst_inc" runat="server" CssClass="combo_box" Rows="30" SelectionMode="Multiple" Width="300px">
			</asp:ListBox>
			<asp:Button ID="btApaDst" runat="server" Text="Apagar Distribuição" CssClass="botao" Onclick="btApaDst_Click" Width="120px" />
		</td>
		<td valign="top">
			<asp:ListBox ID="cbo_rem" runat="server" CssClass="combo_box" Rows="30" SelectionMode="Multiple" Width="200px">
			</asp:ListBox>
		</td>
	</tr>
	<tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>
		<td class="font_body">Data</td>
		<td class="font_body">Turno</td>
		<td class="font_body">Quantidade</td>
		<td class="font_body">Status</td>
	</tr>
	<tr>
		<td >
			<asp:TextBox id="txt_dat_inc" runat="server" CssClass="text_box" maxlength="10" style="width:80px" OnTextChanged="txt_dat_inc_OnTextChanged" AutoPostBack="true"></asp:TextBox> *
		</td>
		<td>
			<asp:DropDownList ID="cbo_tur_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tur_inc_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="TURNO 1" Text="TURNO 1 - 05:01 a 14:59"></asp:ListItem>
				<asp:ListItem value="TURNO 2" Text="TURNO 2 - 13:01 a 22:59"></asp:ListItem>
				<asp:ListItem value="TURNO 3" Text="TURNO 3 - 21:01 a 06:59"></asp:ListItem>
			</asp:DropDownList> *
		</td>
		<td>
			<asp:TextBox id="txt_qtd_inc" runat="server" CssClass="text_box" maxlength="2" style="width:20px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			<asp:Button ID="btDistribuir" runat="server" Text="Distribuir" CssClass="botao" Onclick="btDistribuir_Click" />
		</td>
		<td nowrap>
			<asp:DropDownList ID="cbo_sts_inc" runat="server" CssClass="combo_box">
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList> * &nbsp; 
			<asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" Onclick="btSalvar_Click" /> &nbsp;&nbsp;
			<asp:Button ID="btNovo"   runat="server" Text="Novo"   CssClass="botao" Onclick="btNovo_Click" />
		</td>
	</tr>
</table>
</div>
</form>
</body>
</html>
