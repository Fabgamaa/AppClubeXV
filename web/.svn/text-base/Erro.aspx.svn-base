<%@ Page Language="C#"  Inherits="Erro" CodeFile="Erro.aspx.cs" %>
<!-- :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::Empresa           : Fourway InformáticaSistema           : FWUNFArquivo           : Erro.aspx Criado em         : 01/01/2010Última Alteração  : Versão            : 1.00Descrição         : Módulo para Apresentação de Erro:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::--><!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"><html xmlns="http://www.w3.org/1999/xhtml"><head id="Head" runat="server"><link rel="stylesheet" type="text/css" href="css/FW.css"/>	<title><% Response.Write(ConfigurationManager.AppSettings["Título"]); %></title></head><body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px"><form id="frmErro" runat="server" action="RTS.aspx"><asp:HiddenField ID="Origem" runat="server" /><asp:HiddenField ID="rowId" runat="server" /><script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script><script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script><table border="0" cellpadding="0" cellspacing="0" style="width: 700px;">
    <tr>
        <td valign="middle" style="padding-left: 40px;" class="font_body">
            <br />
            <br />
            <br />
            <br />
            <br />
            Ocorreu um erro na página <b><span id="pagina" runat="server">&nbsp;</span></b>!<br />
            Por favor, contacte o Administrador do sistema.<br />
            <br />
            <br />
            <div>
                Clique <a class="ancora" href="BemVindo.aspx"> <b>aqui</b></a> para retornar à página principal.
            </div>
            <br />
            <br />
            ERRO:
            <br />
            <div id="detalhes" visible="false" runat="server">
                <div id="innerException" runat="server" style="overflow: auto; background: #f0f0f0; width: 700px;">
                    <asp:Label id="lblErro" runat="Server"></asp:Label>&nbsp;
                </div>
            </div>
        </td>
    </tr>
</table>
</form></body><script type="text/javascript">
<!--
    $show = function (elemID, nodisplay) {
        var targetElement;
        if (typeof elemID == "string")
            targetElement = $find(elemID);
        else
            targetElement = elemID;
        if (targetElement) {
            targetElement.style.visibility = 'visible';
            if (nodisplay != null && nodisplay == false)
                targetElement.style.display = 'block';
        }
    };
    $hide = function (elemID, nodisplay) {
        var targetElement;
        if (typeof elemID == "string")
            targetElement = $find(elemID);
        else
            targetElement = elemID;
        if (targetElement) {
            targetElement.style.visibility = "hidden";
            if (nodisplay != null && nodisplay == false)
                targetElement.style.display = "none";
        }
    };
    $find = function (elemID) {
        return document.getElementById(elemID);
    };
//-->
</script>
</html>