﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioDistribuicaoVirada.aspx.cs" Inherits="_Default"%>
			<asp:DropDownList ID="cbo_tur" runat="server" CssClass="combo_box">
				<asp:ListItem value=""></asp:ListItem>
				<asp:ListItem value="TURNO 1" Text="TURNO 1 - 05:01 a 14:59"></asp:ListItem>
				<asp:ListItem value="TURNO 2" Text="TURNO 2 - 13:01 a 22:59"></asp:ListItem>
				<asp:ListItem value="TURNO 3" Text="TURNO 3 - 21:01 a 06:59"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
			<asp:DropDownList ID="cbo_agu" runat="server" CssClass="combo_box">
				<asp:ListItem value="SIM" Text="SIM"></asp:ListItem>
				<asp:ListItem value="NÃO" Text="NÃO"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>