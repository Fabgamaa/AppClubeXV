<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Banner.aspx.cs" Inherits="_Default" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: Banner.aspx
Criado em		: 16/01/2009
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para Banner do Sistema
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->
<head>
    <title></title>
    <link rel="stylesheet" type="text/css" href="css/FW.css"/>
</head>
<body style="margin-left:inherit;margin-right:0;margin-top:0;margin-bottom:0;" class="bg_banner" onunload="JavaScript:window.location.href='Finaliza.aspx'">
<script type="text/javascript" language="JavaScript" src="scr/FWMNUDEF.js" ></script>
<script type="text/javascript" language="javascript">


// Special effect string for IE5.5 or above please visit http://www.milonic.com/filters_sample.php for more filters
if(navigator.appVersion.indexOf("MSIE 6.0")>0){
	effect = "Fade(duration=0.2);Alpha(style=0,opacity=88);Shadow(color='#777777', Direction=135, Strength=5)"
}
else{
	effect = "Shadow(color='#777777', Direction=135, Strength=5)"
}


timegap=1000				// The time delay for menus to remain visible
followspeed=5				// Follow Scrolling speed
followrate=40				// Follow Scrolling Rate
suboffset_top=1;			// Sub menu offset Top position 
suboffset_left=1;			// Sub menu offset Left position
Frames_Top_Offset=0 		// Frames Page Adjustment for Top Offset
Frames_Left_Offset=100		// Frames Page Adjustment for Left Offset



plain_style=[				// Menu Properties Array
"#C3DCFF",					// Off Font Color
"#1D417F",					// Off Back Color
"#DCC990",					// On Font Color
"#1D417F",					// On Back Color
"black",					// Border Color
10,							// Font Size
"normal",					// Font Style
"bold",						// Font Weight
"verdana,arial,technical",	// Font
3,							// Padding
"",			  				// Sub Menu Image (Leave this blank if not needed)
,							// 3D Border & Separator bar
"66ffff",					// 3D High Color
"000099",					// 3D Low Color
,							// Current Page Item Font Color (leave this blank to disable)
,							// Current Page Item Background Color (leave this blank to disable)
,							// Top Bar image (Leave this blank to disable)
] 

<%

Response.Write(CarregaMenu());

%>
dumpmenus()
</script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<form id="frmBanner" runat="server">
<asp:HiddenField runat="server" ID="hpage" />
    <table align="center" style="width:800px" border="0" cellspacing="2" cellpadding="0" class="fundo_banner_curto">
	    <tr>
		    <td rowspan="2" style="height:60px;">
		        <img src="img/logoxv2.png" alt="" border="0" style="height: 50px; width: 126px"/>
		    </td>
		    <td valign="top" colspan="2">
			    <table align="right" cellspacing="0" cellpadding="0" border="0">
			        <tr>
	                    <td style="width:50px">&nbsp;</td>
					    <td style="width:40px" align="center"><img alt="Home" onmouseover="JavaScript:Home('in');" onmouseout="JavaScript:Home('out');" id="BT_Home" onclick="JavaScript:EnviarHome();" src="img/bt_home.gif" style="CURSOR:hand" /></td>
					    <td style="width:40px" align="center"><img alt="Trocar Senha" onmouseover="JavaScript:TrocarSenha('in')" onmouseout="JavaScript:TrocarSenha('out')" id="BT_Senha" onclick="JavaScript:EnviarSenha();" src="img/bt_trocar_senha.gif" style="CURSOR:hand" /></td>
					    <td style="width:40px" align="center"><img alt="Imprimir" onmouseover="JavaScript:Imprimir('in');" onmouseout="JavaScript:Imprimir('out');" id="BT_Imprimir" src="img/bt_imprimir.gif" onclick="JavaScript:EnviarImprimir();" style="CURSOR:hand" /></td>
					    <td style="width:40px" align="center"><img alt="Sair" onmouseover="JavaScript:Sair('in');" onmouseout="JavaScript:Sair('out');" id="BT_Sair" src="img/bt_sair.gif" onclick="JavaScript:EnviarSair();" style="CURSOR:hand" /></td>
				    </tr>
				</table>
		    </td>
	    </tr>
	</table>
</form>	    
    

    
<script type="text/javascript" language="JavaScript">

function Home(vTipo)
{
	if(vTipo == "in")
	{
		document.all("BT_Home").src = "img/bt_home_on.gif"
	}
	else
	{
		document.all("BT_Home").src = "img/bt_home.gif"
	}
}

function Sair(vTipo)
{
	if(vTipo == "in")
	{
		document.all("BT_Sair").src = "img/bt_sair_on.gif"
	}
	else
	{
		document.all("BT_Sair").src = "img/bt_sair.gif"
	}
}

function TrocarSenha(vTipo)
{
	if(vTipo == "in")
	{
		document.all("BT_Senha").src = "img/bt_trocar_senha_on.gif"
	}
	else
	{
		document.all("BT_Senha").src = "img/bt_trocar_senha.gif"
	}
}

function Imprimir(vTipo)
{
	if(vTipo == "in")
	{
		document.all("BT_Imprimir").src = "img/bt_imprimir_on.gif"
	}
	else
	{
		document.all("BT_Imprimir").src = "img/bt_imprimir.gif"
	}
}

function Buscar(vTipo)
{
	if(vTipo == "in")
	{
		document.all("BT_Buscar").src = "img/bt_lupa_on.gif"
	}
	else
	{
		document.all("BT_Buscar").src = "img/bt_lupa.gif"
	}
}

function EnviarImprimir()
{
	window.top.frameprincipal.focus();
	window.top.frameprincipal.print();
}

function EnviarSair()
{
	top.window.close();
	top.window.close();
}


function EnviarHome()
{
    window.top.frameprincipal.location = document.all("hpage").value; 
}

function EnviarSenha()
{
    window.top.frameprincipal.location = 'AlterarSenha.aspx'
}

function EnviarBuscar()
{
    //Codigo que irá realizar a busca
}

</script>
	
<script type="text/javascript" language="javascript">
	if(ns4)_d.captureEvents(Event.MOUSEMOVE)
	_d.onmouseup=closeallmenus
function TABLE1_onclick() {

}

</script>

</body>
</html>
