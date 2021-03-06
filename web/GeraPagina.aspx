<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GeraPagina.aspx.cs" Inherits="GeraPagina" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
    <link rel="stylesheet" type="text/css" href="css/FW.css"/>
    <title></title>
</head>

<script type="text/javascript">
    function CopyToClipboard() 
    {
        document.frmGeraPagina.hdn_ClipBoard.value = pre_pag.innerText;
        var crPAG = document.frmGeraPagina.hdn_ClipBoard.createTextRange();
        crPAG.select();
        crPAG.execCommand("Copy");
    }
</script> 

<body>
    <form id="frmGeraPagina" runat="server">
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
                Tabela
            </td>
            <td class="font_body">
                Nome da Página
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txt_srv" runat="server" Text="DESKTOP-JIMGRD9" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_bco" runat="server" Text="XV" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_usr" runat="server" Text="sa" BorderStyle="Solid" BorderColor="#8BA6C4" BorderWidth="1" ForeColor="MidnightBlue" Font-Names="Verdana,Arial" Font-Size="8pt" CssClass=" text-transform: uppercase"> </asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_snh" runat="server" Text="Adm" BorderStyle="Solid" BorderColor="#8BA6C4" BorderWidth="1" ForeColor="MidnightBlue" Font-Names="Verdana,Arial" Font-Size="8pt" CssClass=" text-transform: uppercase"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_tab" runat="server" Text="PTR" CssClass="text_box"></asp:TextBox>        
            </td>
            <td>
                <asp:TextBox ID="txt_nom_pag" runat="server" Text="Perfil" BorderStyle="Solid" BorderColor="#8BA6C4" BorderWidth="1" ForeColor="MidnightBlue" Font-Names="Verdana,Arial" Font-Size="8pt" CssClass=" text-transform: uppercase"></asp:TextBox>        
            </td>
            <td>
                <asp:Button ID="btGerarAspx"   runat="server" CssClass="botao" Text="Gerar Aspx" OnClick="btGerarAspx_Click"/>&nbsp;
                <asp:Button ID="btGerarAspxCs" runat="server" CssClass="botao" Text="Gerar Aspx.cs" OnClick="btGerarAspxCs_Click"/>
            </td>
        </tr>
    </table>
    <br />
    <a href="javascript:CopyToClipboard();">Copiar</a>
    <div id="div_pag" runat="server" style="width:800px;background-color:Silver">
        <pre id="pre_pag" runat="server" lang="aspnet" ></pre>
    </div>
    </form>
</body>
</html>

