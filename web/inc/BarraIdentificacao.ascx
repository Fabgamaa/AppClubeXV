<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BarraIdentificacao.ascx.cs" Inherits="BarraIdentificacao" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Frameset//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd">

<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: BarraIdentificacao.ascx
Criado em		: 23/12/2008
Última Alteração: 23/12/2008
Versão			: 1.00
Descrição		: Módulo para Barra de Identificacao
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<table align="center" style="width:800px;height:30px" border="0">
    <tr>
        <td class="font_body">&nbsp;&nbsp;<b>Usuário: </b><a href="Default.aspx" target=_top><%=Session["USR"]%></a></td>
        <td class="font_body" align="right"><b>Perfil: </b><%=Session["PFL"]%></td>
    </tr>
</table>


