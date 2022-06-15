﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioEtiquetaVirada.aspx.cs" Inherits="_Default"%>
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
	<tr>
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
			</ItemTemplate>
            <HeaderTemplate>
                <asp:CheckBox ID="chk_sel_tdo" runat="server" AutoPostBack="true" oncheckedchanged="chk_sel_tdo_CheckedChanged" />
            </HeaderTemplate>
			<ItemTemplate>
                <asp:CheckBox ID="chk_sel" runat="server" />
			</ItemTemplate>
			<HeaderStyle ForeColor="White" />
			</asp:TemplateField>
			</Columns>