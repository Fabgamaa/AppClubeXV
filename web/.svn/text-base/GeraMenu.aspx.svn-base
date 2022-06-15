<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GeraMenu.aspx.cs" Inherits="GeraMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<link rel="stylesheet" type="text/css" href="css/FWFWK.css"/>
<head id="Head" runat="server">
    <title></title>
</head>

<script type="text/javascript">
    function CopyToClipboard() 
    {
        document.frmGeraMenu.hdn_ClipBoard.value = pre_sql.innerText;
        var crCLS = document.frmGeraMenu.hdn_ClipBoard.createTextRange();
        crCLS.select();
        crCLS.execCommand("Copy");
    }
</script> 

<body>
    <form id="frmGeraMenu" runat="server">
    <input id="hdn_ClipBoard" type="hidden" />
    <table>
        <tr>
            <td class="font_body">
                Servidor
            </td>
            <td class="font_body">
                Banco
            </td>
            <td class="font_body">
                Usuário
            </td>
            <td class="font_body">
                Senha
            </td>
            <td class="font_body">
                Aplicação
            </td>
            <td></td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_srv" runat="server" Text="FWAPP" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_bco" runat="server" Text="FWADV_DSV" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_usr" runat="server" Text="FWADV_DSV" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_snh" runat="server" Text="FWADV_DSV" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_app" runat="server" Text="FWADV" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:Button ID="btCarregar" runat="server" CssClass="botao" Text="Carregar" OnClick="btCarregar_Click"/>
            </td>
            <td>
                <asp:Button ID="btGerar" runat="server" CssClass="botao" Text="Gerar" OnClick="btGerar_Click"/>
            </td>
        </tr>
    </table>
    <br />
    <font class="font_body">Menu</font>
    <div id="div_mnu" runat="server" style="width:800px;background-color:Silver">
        <asp:Menu ID="mnu" runat="server" BackColor="#E3EAEB" DynamicHorizontalOffset="2" Font-Names="Verdana" ForeColor="#666666" Orientation="Horizontal" OnMenuItemClick="mnu_Click">
            <DynamicHoverStyle BackColor="#666666" ForeColor="White" />
            <DynamicMenuStyle BackColor="#E3EAEB" HorizontalPadding="5px" />
            <DynamicSelectedStyle BackColor="gold" />
            <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <Items></Items>
        </asp:Menu>
        <br/>
        <table>
        <tr>
            <td class="font_body">
                Título
            </td>
            <td class="font_body">
                Página
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_tit" runat="server" Text="" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_pag" runat="server" Text="" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:Button ID="btSalvar" runat="server" CssClass="botao" Text="Salvar" OnClick="btSalvar_Click"/>
            </td>
            <td>
                <asp:Button ID="btExcluir" runat="server" CssClass="botao" Text="Excluir" OnClick="btExcluir_Click"/>
            </td>
            <td>
                <asp:Button ID="btNovoSubMenu" runat="server" CssClass="botao" Text="Novo Sub Menu" OnClick="btNovoSubMenu_Click"/>
            </td>
            <td>
                <asp:Button ID="btNovoMenu" runat="server" CssClass="botao" Text="Novo Menu" OnClick="btNovoMenu_Click"/>
            </td>
        </tr>
    </table>        
    </div>
    <br />
    <br />
    <font class="font_body">SQL </font><a href="javascript:CopyToClipboard();">(Copiar)</a>
    <div id="div_sql" runat="server" style="width:800px;background-color:Silver">
        <pre id="pre_sql" runat="server" lang="aspnet" ></pre>
    </div>
    </form>
</body>
</html>

