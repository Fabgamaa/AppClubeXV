<%@ Control Language="C#" AutoEventWireup="true"  CodeFile="Endereco.ascx.cs" Inherits="Endereco"%>
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - Fourway Framework
Arquivo			: Endereco.ascx
Criado em		: 15/02/2008
Última Alteração: 15/02/2008
Versão			: 1.00
Descrição		: Módulo para Consulta de Endereço
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<table border="0" width="780px">
    <tr>
        <td colspan="3" class="font_body">CEP </td>
    </tr>
    <tr>
        <td colspan="3" class="font_body">
            <asp:TextBox runat="server" ID="txt_cep" CssClass="text_box" style="width:100px" maxlength="8" OnTextChanged="txt_cep_OnTextChanged" AutoPostBack="true"/> *
        </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">Endereço </td>
        <td class="font_body">Nº </td>
    </tr>
    <tr>
        <td colspan="2" class="font_body">
            <asp:TextBox runat="server" ID="txt_edr" CssClass="text_box" style="width:400px" maxlength="50"/> *
        </td>
        <td class="font_body">
            <asp:TextBox runat="server" ID="txt_num_edr" CssClass="text_box" style="width:50px" maxlength="5"/> *
        </td>
    </tr> 
    <tr>
        <td class="font_body">Complemento </td>
        <td class="font_body">Bairro </td>
        <td class="font_body">&nbsp; </td>
    </tr>
    <tr>
        <td class="font_body">
            <asp:TextBox runat="server" ID="txt_edr_cmp" CssClass="text_box" style="width:200px" maxlength="40"/>
        </td>
        <td class="font_body">
            <asp:TextBox runat="server" ID="txt_brr" CssClass="text_box" style="width:200px" maxlength="20"/>
        </td>
        <td>&nbsp; </td>
    </tr>
    <tr>
        <td class="font_body">País </td>
        <td class="font_body">Estado </td>
        <td class="font_body">Cidade </td>
    </tr>
    <tr>
        <td class="font_body">
            <asp:DropDownList runat="server" ID="cbo_pas" CssClass="combo_box" OnSelectedIndexChanged="cbo_pas_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList> *
        </td>
        <td class="font_body">
            <asp:DropDownList runat="server" ID="cbo_sta" CssClass="combo_box" OnSelectedIndexChanged="cbo_sta_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList> *
        </td>
        <td class="font_body">
            <asp:DropDownList runat="server" ID="cbo_cid" CssClass="combo_box">
            </asp:DropDownList> *
        </td>
    </tr>
</table>
