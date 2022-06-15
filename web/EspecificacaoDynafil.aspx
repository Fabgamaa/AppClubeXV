﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="EspecificacaoDynafil.aspx.cs" Inherits="_Default"%>
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
	<tr>
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
			<AlternatingRowStyle CssClass="linha_impar" />
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
	<tr>