﻿<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="Performance.aspx.cs" Inherits="_Default"%>
            <asp:TableRow CssClass="cabecalho_tabela">
                <asp:TableCell CssClass="cabecalho_tabela" ColumnSpan="2" HorizontalAlign="Center">Resumo</asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_par">
                <asp:TableCell>Primeira Qualidade</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_QLD_001"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_impar">
                <asp:TableCell>Out Sort</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_OUT"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_par">
                <asp:TableCell>Segunda Qualidade</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_QLD_002"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_impar">
                <asp:TableCell>Quebra</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_QBR"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_par">
                <asp:TableCell>Afinidade</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_AFN"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_impar">
                <asp:TableCell>Unitens</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_UNT"></asp:Label></asp:TableCell>
	        </asp:TableRow>
            <asp:TableRow CssClass="linha_par">
                <asp:TableCell>Produção</asp:TableCell>
                <asp:TableCell HorizontalAlign="Right"><asp:Label runat="server" ID="lbPFM_PRC"></asp:Label></asp:TableCell>
	        </asp:TableRow>
	        </asp:Table>
		</td>