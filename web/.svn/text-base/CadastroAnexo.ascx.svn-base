<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CadastroAnexo.ascx.cs" Inherits="CadastroAnexo"%>
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - Fourway Framework
Arquivo			: CadastroAnexo.ascx
Criado em		: 15/02/2008
Última Alteração: 15/02/2008
Versão			: 1.00
Descrição		: Módulo para Cadastro de Anexo
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<table border="0" width="780px">
    <tr>
	    <td class="destaque" colspan="4" height="25">Anexo</td>
    </tr>
    <tr>
	    <td class="font_body"><u>D</u>escrição</td>
	    <td class="font_body"><u>C</u>aminho</td>
	    <td class="font_body">&nbsp;</td>
    </tr>
    <tr>
	    <td>
		    <asp:TextBox ID="txt_des" runat="server" CssClass="text_box" maxlength="80" style="width:400px" accesskey="D"/>
	    </td>
	    <td>
            <asp:FileUpload ID="fu_url" runat="server" CssClass="text_box" style="width:200px;" accesskey="C"/>
	    </td>
	    <td>
		    <asp:Button ID="btIncluir" runat="server" CssClass="botao" Text="Incluir" OnClick="btIncluir_Click" AutoPostBack="true"/>
	    </td>
    </tr>
    <tr>
	    <td colspan="4">&nbsp;</td>
    </tr>
    <tr>
	    <td colspan="4">
            <asp:Label ID="lblSortLogin" runat="server" Visible="False" Text="ASC"></asp:Label>
            <asp:GridView Width="760px" ID="gvAnexo" DataKeyNames="ANX_ID,ANX_CAM,ANX_DES" 
                    runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                    OnRowDataBound="gvAnexo_RowDataBound"  OnSorting="gvAnexo_Sorting"
                    OnRowCreated="gvAnexo_RowCreated"
                    EmptyDataText="Não foram encontrados anexos.">
                <Columns>
                    <asp:TemplateField HeaderText=" Descrição " SortExpression="ANX_DES" ControlStyle-Width="400px" >
                        <ItemTemplate>
                            <asp:Label ID="lbANX_DES" runat="server" Text='<%# Eval("ANX_DES") %>'/>
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Inclusão " SortExpression="ANX_TMS_ATL" ControlStyle-Width="80px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:Label ID="lbANX_DAT_INC" runat="server" Text='<%# ((bool)!String.IsNullOrEmpty(Eval("ANX_TMS_ATL").ToString()) == true)?Convert.ToDateTime(Eval("ANX_TMS_ATL")).ToString("dd/MM/yyyy"):""%>'/>
                        </ItemTemplate>
                        <HeaderStyle ForeColor="White" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText=" Excluir " ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                        <ItemTemplate>
                            <asp:ImageButton ID="imgExcluir" runat="server"  AlternateText="Excluir" ImageUrl="img/exclui.jpg" Width="20px" CommandName="Excluir" OnClientClick='if(!confirm("Confirma a exclusão desse Anexo?")){return false;}' CommandArgument='<%# Eval("ANX_ID").ToString() + "," + Eval("ANX_CAM").ToString()%>' OnClick="imgExcluir_Click" />
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
