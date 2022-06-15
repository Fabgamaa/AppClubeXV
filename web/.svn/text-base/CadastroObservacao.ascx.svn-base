<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CadastroObservacao.ascx.cs" Inherits="CadastroObservacao"%>
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - Fourway Framework
Arquivo			: CadastroObservacao.ascx
Criado em		: 15/02/2008
Última Alteração: 15/02/2008
Versão			: 1.00
Descrição		: Módulo para Cadastro de Observacao
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<table border="0" width="780px">
    <tr>
	    <td class="destaque" colspan="4" height="25">Observações</td>
    </tr>
    <tr>
	    <td class="font_body" colspan="4"><u>O</u>bservação</td>
    </tr>
    <tr>
	    <td class="font_body" colspan="3">
            <asp:TextBox ID="txt_des" runat="server" CssClass="text_box" style="width:650px;" maxlength="1000" Text="" TextMode="MultiLine" Rows="5" /> *
	    </td>
	    <td align="right">
		    <asp:Button ID="btIncluir" runat="server" CssClass="botao" Text="Incluir" OnClick="btIncluir_Click" AutoPostBack="true"/>
	    </td>
    </tr>
    <tr>
	    <td colspan="4">&nbsp;</td>
    </tr>
    <tr>
	    <td colspan="4">
            <asp:Label ID="lblSortLogin" runat="server" Visible="False" Text="ASC"></asp:Label>
            <asp:GridView Width="760px" ID="gvObservacao" DataKeyNames="OBS_ID" 
                    runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                    OnRowDataBound="gvObservacao_RowDataBound"  OnSorting="gvObservacao_Sorting"
                    OnRowCreated="gvObservacao_RowCreated"
                    EmptyDataText="Não foram encontradas Observações.">
                <Columns>
                    <asp:TemplateField HeaderText=" Observação " SortExpression="OBS_DES" ControlStyle-Width="510px" >
                        <ItemTemplate>
                            <asp:Label ID="lbOBS_DES" runat="server" Text='<%# Eval("OBS_DES") %>' />
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Inclusão " SortExpression="OBS_TMS_ATL" ControlStyle-Width="80px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label ID="lbOBS_TMS_ATL" runat="server" Text='<%# ((bool)!String.IsNullOrEmpty(Eval("OBS_TMS_ATL").ToString()) == true)?Convert.ToDateTime(Eval("OBS_TMS_ATL")).ToString("dd/MM/yyyy"):""%>'/>
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Usuário " SortExpression="USR_NOM" ControlStyle-Width="150px">
                        <ItemTemplate>
                            <asp:Label ID="lbUSR_NOM" runat="server" Text='<%# Eval("USR_NOM") %>'/>
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Inativar " SortExpression="USR_NOM" ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgInativar" runat="server"  AlternateText="Inativar" ImageUrl="img/exclui.jpg" Width="20px" CommandName="Inativar" OnClientClick='if(!confirm("Confirma Inativar esse Registro?")){return false;}' CommandArgument='<%# Eval("OBS_ID").ToString()%>' OnClick="imgInativar_Click" />
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
