<%@ Page Language="C#"  Inherits="Erro" CodeFile="Erro.aspx.cs" %>
<!-- 
    <tr>
        <td valign="middle" style="padding-left: 40px;" class="font_body">
            <br />
            <br />
            <br />
            <br />
            <br />
            Ocorreu um erro na p�gina <b><span id="pagina" runat="server">&nbsp;</span></b>!<br />
            Por favor, contacte o Administrador do sistema.<br />
            <br />
            <br />
            <div>
                Clique <a class="ancora" href="BemVindo.aspx"> <b>aqui</b></a> para retornar � p�gina principal.
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
</form>
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