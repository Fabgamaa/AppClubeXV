﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RTS.aspx.cs" Inherits="_Default"%>
		<td colspan="4">&nbsp;</td>
	</tr>

	<tr>
		<td colspan="4" class="destaque">Logística</td>
	</tr>
		<td colspan="4">&nbsp;</td>
	</tr>

	<tr>
		<td colspan="4" class="destaque">P&D</td>
	</tr>
			<asp:DropDownList ID="cbo_jet_001_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="CalculaConsumoAr" AutoPostBack="true">
                <asp:ListItem value="(0.621  * (PAO_001 + 1))" Text="A317"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_001 + 1))" Text="A327"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_001 + 1))" Text="A347"></asp:ListItem>
                <asp:ListItem value="(0.991  * PAO_001 + 0.861)" Text="Barmag"></asp:ListItem>
                <asp:ListItem value="(1.19   * PAO_001 + 1.19)" Text="C16S"></asp:ListItem>
                <asp:ListItem value="(1.186  * PAO_001 + 1.172)" Text="C24"></asp:ListItem>
                <asp:ListItem value="(2.328  * PAO_001 + 1.132)" Text="CBS"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_001 + 1)) " Text="D11"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_001 + 1))  " Text="D12"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_001 + 1))  " Text="D21"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_001 + 1)) " Text="D42"></asp:ListItem>
                <asp:ListItem value="(0.723  * PAO_001 + 0.714)" Text="DJ1"></asp:ListItem>
                <asp:ListItem value="(0.381  * PAO_001 + 0.991)" Text="DJ21"></asp:ListItem>
                <asp:ListItem value="(0.723  * PAO_001 + 0.714) " Text="DJ31"></asp:ListItem>
                <asp:ListItem value="(1.19   * PAO_001 + 1.19) " Text="E16V"></asp:ListItem>
                <asp:ListItem value="(1.002  * PAO_001 + 1.017)" Text="FG255"></asp:ListItem>
                <asp:ListItem value="(0.438  * PAO_001 + 1.137)" Text="P102"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_001 + 0.939)" Text="P203"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961)" Text="P212"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961) " Text="P212B"></asp:ListItem>
                <asp:ListItem value="(1.372  * PAO_001 + 0.953)" Text="P213"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_001 + 0.939) " Text="P221"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961)  " Text="P223"></asp:ListItem>
                <asp:ListItem value="(0.911  * PAO_001 + 0.911)" Text="P243"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_001 + 0.939)  " Text="P261"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_001 + 0.939)   " Text="P261-AFKeMV900"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_001 + 0.939)    " Text="P261M"></asp:ListItem>
                <asp:ListItem value="(1.859  * PAO_001 + 1.859)" Text="P312"></asp:ListItem>
                <asp:ListItem value="(2.91   * PAO_001 + 2.91)" Text="P412"></asp:ListItem>
                <asp:ListItem value="(1.367  * PAO_001 + 1.012)" Text="PS23"></asp:ListItem>
                <asp:ListItem value="(1.720  * PAO_001 + 0.962)" Text="PS48"></asp:ListItem>
                <asp:ListItem value="(0.591  * PAO_001 + 0.913)" Text="PS91"></asp:ListItem>
                <asp:ListItem value="(1.720  * PAO_001 + 0.962) " Text="SF774"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961)   " Text="SN050"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961)    " Text="SN150"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_001 + 0.961)     " Text="SN250"></asp:ListItem>
                <asp:ListItem value="(0.7015 * (PAO_001 + 1))" Text="T100"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_001 + 1))   " Text="T311"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_001 + 1)) " Text="T321"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_001 + 1))  " Text="T341"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_001 + 1))   " Text="T341-Nova"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_001 + 1))    " Text="T341-Velha"></asp:ListItem>
                <asp:ListItem value="(2.357  * (PAO_001 + 1))" Text="T351"></asp:ListItem>
			</asp:DropDownList> *
			<asp:DropDownList ID="cbo_jet_002_inc" runat="server" CssClass="combo_box" OnSelectedIndexChanged="CalculaConsumoAr" AutoPostBack="true">
                <asp:ListItem value="(0.621  * (PAO_002 + 1))" Text="A317"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_002 + 1))" Text="A327"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_002 + 1))" Text="A347"></asp:ListItem>
                <asp:ListItem value="(0.991  * PAO_002 + 0.861)" Text="Barmag"></asp:ListItem>
                <asp:ListItem value="(1.19   * PAO_002 + 1.19)" Text="C16S"></asp:ListItem>
                <asp:ListItem value="(1.186  * PAO_002 + 1.172)" Text="C24"></asp:ListItem>
                <asp:ListItem value="(2.328  * PAO_002 + 1.132)" Text="CBS"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_002 + 1)) " Text="D11"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_002 + 1))  " Text="D12"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_002 + 1))  " Text="D21"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_002 + 1)) " Text="D42"></asp:ListItem>
                <asp:ListItem value="(0.723  * PAO_002 + 0.714)" Text="DJ1"></asp:ListItem>
                <asp:ListItem value="(0.381  * PAO_002 + 0.991)" Text="DJ21"></asp:ListItem>
                <asp:ListItem value="(0.723  * PAO_002 + 0.714) " Text="DJ31"></asp:ListItem>
                <asp:ListItem value="(1.19   * PAO_002 + 1.19) " Text="E16V"></asp:ListItem>
                <asp:ListItem value="(1.002  * PAO_002 + 1.017)" Text="FG255"></asp:ListItem>
                <asp:ListItem value="(0.438  * PAO_002 + 1.137)" Text="P102"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_002 + 0.939)" Text="P203"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961)" Text="P212"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961) " Text="P212B"></asp:ListItem>
                <asp:ListItem value="(1.372  * PAO_002 + 0.953)" Text="P213"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_002 + 0.939) " Text="P221"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961)  " Text="P223"></asp:ListItem>
                <asp:ListItem value="(0.911  * PAO_002 + 0.911)" Text="P243"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_002 + 0.939)  " Text="P261"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_002 + 0.939)   " Text="P261-AFKeMV900"></asp:ListItem>
                <asp:ListItem value="(0.912  * PAO_002 + 0.939)    " Text="P261M"></asp:ListItem>
                <asp:ListItem value="(1.859  * PAO_002 + 1.859)" Text="P312"></asp:ListItem>
                <asp:ListItem value="(2.91   * PAO_002 + 2.91)" Text="P412"></asp:ListItem>
                <asp:ListItem value="(1.367  * PAO_002 + 1.012)" Text="PS23"></asp:ListItem>
                <asp:ListItem value="(1.720  * PAO_002 + 0.962)" Text="PS48"></asp:ListItem>
                <asp:ListItem value="(0.591  * PAO_002 + 0.913)" Text="PS91"></asp:ListItem>
                <asp:ListItem value="(1.720  * PAO_002 + 0.962) " Text="SF774"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961)   " Text="SN050"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961)    " Text="SN150"></asp:ListItem>
                <asp:ListItem value="(0.972  * PAO_002 + 0.961)     " Text="SN250"></asp:ListItem>
                <asp:ListItem value="(0.7015 * (PAO_002 + 1))" Text="T100"></asp:ListItem>
                <asp:ListItem value="(0.621  * (PAO_002 + 1))   " Text="T311"></asp:ListItem>
                <asp:ListItem value="(0.931  * (PAO_002 + 1)) " Text="T321"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_002 + 1))  " Text="T341"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_002 + 1))   " Text="T341-Nova"></asp:ListItem>
                <asp:ListItem value="(1.679  * (PAO_002 + 1))    " Text="T341-Velha"></asp:ListItem>
                <asp:ListItem value="(2.357  * (PAO_002 + 1))" Text="T351"></asp:ListItem>
			</asp:DropDownList> 
		<td colspan="4">&nbsp;</td>
	</tr>

	<tr>
		<td colspan="4" class="destaque">PCP</td>
	</tr>
		<td colspan="4">&nbsp;</td>
	</tr>
	<tr>