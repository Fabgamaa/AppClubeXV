<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa			: Fourway Informática
Sistema			: FWFWK - FrameWork Fourway
Arquivo			: FWMNUSUB.aspx
Criado em		: 16/01/2009
Última Alteração: 
Versão			: 1.00
Descrição		: Módulo para SUB Menu
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<script type="text/javascript" language="JavaScript" src="scr/FWMNUDEF.js"></script>
<script type="text/javascript" language="javascript">

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
suboffset_left=10;			// Sub menu offset Left position
Frames_Top_Offset=0 		// Frames Page Adjustment for Top Offset
Frames_Left_Offset=0		// Frames Page Adjustment for Left Offset

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
"",							// Top Bar image (Leave this blank to disable)
]

<%
Response.Write(FWMNUSUB.CarregaSubMenu(Session["USR_ID"].ToString()));
%>

dumpmenus()
</script>
