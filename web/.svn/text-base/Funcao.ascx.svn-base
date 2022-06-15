<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Funcao.ascx.cs" Inherits="uc_Funcao" %>
<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>

<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: Funcao.ascx
Criado em		: 04/05/2009
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Associação de Funções
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<table width="100%">
    <tr>
        <td style="width:190px" class="destaque" colspan="4">Funções </td>
    </tr>
    <tr>
        <td colspan="4">
            <asp:HyperLink runat="server" ForeColor="Red" ID="Msg"></asp:HyperLink>
            <asp:Label ID="lblSortLogin" runat="server" Visible="False" Text="ASC"></asp:Label>
            <asp:GridView Width="780px" CausesValidation="False"  ID="gvFuncoes" DataKeyNames="FAO_ID" 
                    runat="server" AutoGenerateColumns="false"
                    OnRowDataBound="gvFuncoes_RowDataBound"
                     EmptyDataText="Não há funções cadastradas.">
                <Columns>
                    <asp:TemplateField HeaderText=" Descrição " SortExpression="FAO_DES">
                        <ItemTemplate>
                            <asp:Label ID="lbFAO_DES" runat="server" Text='<%# Eval("FAO_DES").ToString() %>' />
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField ControlStyle-Width="300px" HeaderText=" Observações "  SortExpression="FAO_OBS">
                        <ItemTemplate>
                            <asp:Label ID="lbFAO_OBS" runat="server" Text='<%# Eval("FAO_OBS") %>'/>
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField ItemStyle-HorizontalAlign="Center" HeaderText=" Permitir ">
                        <ItemTemplate>
                            <asp:CheckBox runat="server" ID="ckPermitir"/>
                        </ItemTemplate>
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

</table>