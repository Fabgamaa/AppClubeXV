<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastroPermissoes.aspx.cs" Inherits="_Default" %>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra" %>
<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: CadastroPermissoes.aspx
Criado em		: 23/12/2008
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Cadastro de Permissões do Perfil
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >

<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
    <form id="frmCadastroPermissoes" runat="server" defaultfocus="ck_cst">
	<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
	<asp:HiddenField runat="server" ID="MNU_ID" />
	<asp:HiddenField runat="server" ID="PFL_ID" />
    <div style="left:5px">
    	    <table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0" class="font_body">
	        <tr>
		        <td colspan="4" class="font_titulo_grd" style="width:780px">
		            <asp:Label runat="server" ID="lbAcao" CssClass="font_titulo_grd"></asp:Label>
		            Permissões do Perfil
    		        <asp:HyperLink ID="Msg" runat="server" ForeColor="Red"></asp:HyperLink>
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td style="width:190px" class="font_body">Perfil Selecionado </td>
	        </tr>
	        <tr>
		        <td>
		            <asp:TextBox ID="txt_pfl" runat="server" Text="Estagiário" CssClass="text_box" Width="400px" ReadOnly="true"></asp:TextBox>
		        </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td style="width:190px" class="destaque">Permissões </td>
	        </tr>
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td colspan="4">		        
                <asp:Label ID="lblSortLogin" runat="server" Visible="False" Text="ASC"></asp:Label>
                <asp:GridView Width="760px" CausesValidation="False"  ID="gvPerfilMenu" DataKeyNames="PFL_MNU_ID" 
                        runat="server" AutoGenerateColumns="false" AllowSorting="true" 
                        OnRowDataBound="gvPerfilMenu_RowDataBound"  OnSorting="gvPerfilMenu_Sorting"
                        OnRowCreated="gvPerfilMenu_RowCreated"
                        EmptyDataText="Não foram encontrados registros de acordo com o filtro.">
                    <Columns>
                        <asp:TemplateField HeaderText=" Menu " SortExpression="MNU_TIT" ControlStyle-Width="150px" >
                            <ItemTemplate>
                                <asp:Label ID="lbMNU_TIT" runat="server" Text='<%# new System.Text.StringBuilder().Insert(0,"&nbsp;",Convert.ToInt16(Eval("MNU_NVL").ToString()) * 2).ToString() + Eval("MNU_TIT").ToString() %>' />
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Consultar " SortExpression="PFL_MNU_CSU" ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckPFL_MNU_CSU" runat="server" Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("PFL_MNU_CSU").ToString())) %>'  Visible='<%# !String.IsNullOrEmpty(Eval("MNU_URL").ToString()) %>'/>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Alterar " SortExpression="PFL_MNU_ALT" ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckPFL_MNU_ALT" runat="server" Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("PFL_MNU_ALT").ToString())) %>' Visible='<%# !String.IsNullOrEmpty(Eval("MNU_URL").ToString()) %>'/>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Novo " SortExpression="PFL_MNU_NOO" ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckPFL_MNU_NOO" runat="server" Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("PFL_MNU_NOO").ToString())) %>' Visible='<%# !String.IsNullOrEmpty(Eval("MNU_URL").ToString()) %>'/>
                            </ItemTemplate>
                            <HeaderStyle ForeColor="White" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText=" Excluir " SortExpression="PFL_MNU_EXL" ControlStyle-Width="20px" ItemStyle-HorizontalAlign="Center">
                            <ItemTemplate>
                                <asp:CheckBox ID="ckPFL_MNU_EXL" runat="server" Checked='<%# Convert.ToBoolean(Convert.ToInt32(Eval("PFL_MNU_EXL").ToString())) %>' Visible='<%# !String.IsNullOrEmpty(Eval("MNU_URL").ToString()) %>'/>
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
<!--
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
	        <tr>
		        <td style="width:190px" class="destaque">Funções </td>
	        </tr>
	        <tr>
		        <td>
                    <table style="width:780" align="center" border="0" cellspacing="2" cellpadding="0">
                        <tr>
                            <td colspan="3">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="cabecalho_tabela" align="center" style="height:20px; width:500px">Descrição </td>
                            <td class="cabecalho_tabela" align="center" style="height:20px">Observações </td>
                            <td class="cabecalho_tabela" align="center" style="height:20px">Permitir </td>
                        </tr>
                        <tr class="linha_impar" id="linha1f">    
                            <td onmouseover="JavaScript:MudaCor('linha1f')" onmouseout="JavaScript:VoltaCor('linha1f', 'linha_impar')" valign="top">Visualizar Status no Relatório de Intimação / Publicação</td>    
                            <td onmouseover="JavaScript:MudaCor('linha1f')" onmouseout="JavaScript:VoltaCor('linha1f', 'linha_impar')" style="width:50%">Função que permite a visualização de status Distribuido no Relatório de Intimação / Publicação</td>
                            <td onmouseover="JavaScript:MudaCor('linha1f')" onmouseout="JavaScript:VoltaCor('linha1f', 'linha_impar')"><asp:CheckBox runat="server" ID="ck_func1" /></td>
                        </tr>
                    </table>
		        </td>
	        </tr>
-->
	        <tr>
		        <td colspan="4">&nbsp;</td>
	        </tr>
            <tr>
	            <td colspan="4">
    		        <asp:Button ID="btSalvar" runat="server" Text="Salvar" CssClass="botao" OnClick="btSalvar_Click"/> &nbsp;&nbsp;
    		        <asp:Button ID="btVoltar" runat="server" Text="Filtro" CssClass="botao" PostBackUrl="SegurancaPermissoes.aspx"/> &nbsp;&nbsp;
	            </td>
            </tr>

        </table>
        </div>
    </form>
</body>
</html>
