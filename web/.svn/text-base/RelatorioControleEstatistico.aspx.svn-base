<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="RelatorioControleEstatistico.aspx.cs" Inherits="_Default"%>
<%@ Register Src="inc/BarraIdentificacao.ascx" TagName="Barra" TagPrefix="ucBarra"%>

<!--#include file="inc/FWMNUSUB.aspx"-->
<!-- 
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
Empresa           : Fourway Informtica
Sistema           : FWUNF
Arquivo           : RelatorioControleEstatistico.aspx 
Criado em         : 04/11/2010
Última Alter~ção  : 
Versão            : 1.00
Descrição         : Módulo para Relatório de Controle Estatístico
:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
-->

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head" runat="server">
<link rel="stylesheet" type="text/css" href="css/FW.css"/>
	<title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
<body class="bg" style="margin-left:0;margin-right:0;margin-top:0;margin-bottom:0;width:780px">
<form id="frmControleEstatistico" runat="server">
<script type="text/javascript" language="javascript" src="scr/FWGNR.js"></script>
<script type="text/javascript" language="javascript" src="scr/FWMNU.js"></script>
<ucBarra:Barra ID="ucBarra" runat="server"></ucBarra:Barra>
<div style="left:5px">
<div runat="server" id="dvFiltro" visible="true">
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="2" class="font_titulo_grd" style="width:780px">
			Pesquisar Relatório de Controle Estatístico
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Lote</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:TextBox id="txt_lot" runat="server" CssClass="text_box" maxlength="10" style="width:100px"></asp:TextBox>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Título</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_tit_poy_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Apresentação</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_aps_id" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Máquina</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_maq_id" runat="server" CssClass="combo_box">
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Entrelaçamento</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_ert_id" runat="server" CssClass="combo_box">
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2" class="font_body">Status</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:DropDownList ID="cbo_sts" runat="server" CssClass="combo_box">
				<asp:ListItem value="" Text=""></asp:ListItem>
				<asp:ListItem value="1" Text="ATIVO"></asp:ListItem>
				<asp:ListItem value="0" Text="INATIVO"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="2">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="2">
			<asp:Button ID="btProcurar"   runat="server" CssClass="botao" Text="Listar" OnClick="btProcurar_Click" />
		</td>
	</tr>
</table>
</div>
<div runat="server" id="dvResultado" visible="false" >
<table style="width:780px" align="center" border="0" cellspacing="4" cellpadding="0">
	<tr>
		<td colspan="3" class="font_titulo_grd">
			Relatório de Controle Estatístico
		</td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="3" class="font_body">Tipo</td>
	</tr>
	<tr>
		<td colspan="3">
			<asp:DropDownList ID="cbo_tip" runat="server" CssClass="combo_box" OnSelectedIndexChanged="cbo_tip_OnSelectedIndexChanged" AutoPostBack="true">
				<asp:ListItem value="TIT" Text="TÍTULO"></asp:ListItem>
				<asp:ListItem value="TNC" Text="TENACIDADE"></asp:ListItem>
				<asp:ListItem value="AON" Text="ALONGAMENTO"></asp:ListItem>
				<asp:ListItem value="ENM" Text="ENCOLHIMENTO"></asp:ListItem>
				<asp:ListItem value="EEE" Text="E%"></asp:ListItem>
				<asp:ListItem value="KKK" Text="K%"></asp:ListItem>
				<asp:ListItem value="BBB" Text="B%"></asp:ListItem>
				<asp:ListItem value="PUE" Text="PUE%"></asp:ListItem>
				<asp:ListItem value="OLE" Text="ÓLEO%"></asp:ListItem>
				<asp:ListItem value="TRQ" Text="TORQUE"></asp:ListItem>
				<asp:ListItem value="ERT" Text="ENTRALAÇAMENTO"></asp:ListItem>
				<asp:ListItem value="RT3" Text="RETENÇÃO 3%"></asp:ListItem>
				<asp:ListItem value="RT5" Text="RETENÇÂO 5%"></asp:ListItem>
				<asp:ListItem value="PES" Text="PESO"></asp:ListItem>
				<asp:ListItem value="DMO" Text="DIÂMETRO"></asp:ListItem>
				<asp:ListItem value="DND" Text="DENSIDADE"></asp:ListItem>
			</asp:DropDownList>
		</td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
	<tr>
		<td colspan="3">
		<table border="0">
	    <tr>
		    <td class="font_body">Lote</td>
		    <td class="font_body">Título</td>
		    <td class="font_body">Apresentação</td>
		    <td class="font_body">Máquina</td>
		    <td class="font_body">Entrelaçamento</td>
	    </tr>
	    <tr>
		    <td>
			    <asp:TextBox id="txt_lot_rel" runat="server" CssClass="text_box"  maxlength="10" style="width:100px" Enabled="false"></asp:TextBox> 
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_tit_poy_id_rel" runat="server" CssClass="combo_box" Enabled="false">
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_aps_id_rel" runat="server" CssClass="combo_box" Enabled="false">
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_maq_id_rel" runat="server" CssClass="combo_box" Enabled="false">
			    </asp:DropDownList>
		    </td>
		    <td>
			    <asp:DropDownList ID="cbo_ert_id_rel" runat="server" CssClass="combo_box" Enabled="false">
			    </asp:DropDownList>
		    </td>
	    </tr>
	    </table>
	    </td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
    <tr>
	    <td colspan="3" class="destaque">Médias</td>
    </tr>
	<tr>
		<td>
		<asp:chart id="cht_med_lnh" runat="server" Height="250px" Width="430px" ImageStorageMode="UseImageLocation" ImageLocation="~/tmp/ChartPic_#SEQ(300,3)" Palette="BrightPastel" imagetype="Png" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2" backcolor="#D3DFF0" BorderColor="26, 59, 105">
            <legends>
                <asp:Legend IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
            </legends>
            <borderskin skinstyle="Emboss"></borderskin>
            <series>
                <asp:Series Name="LSE"    ChartType="Line" Color="Blue"  BorderWidth="2"></asp:Series>
                <asp:Series Name="LSC"    ChartType="Line" Color="Green" BorderWidth="2"></asp:Series>
                <asp:Series Name="Medida" ChartType="Line" Color="Green" BorderWidth="2" MarkerSize="6" MarkerStyle="Circle" IsXValueIndexed="false"></asp:Series>
                <asp:Series Name="Media"  ChartType="Line" Color="Red"   BorderWidth="2" LegendText="Média"></asp:Series>
                <asp:Series Name="LIC"    ChartType="Line" Color="Green" BorderWidth="2"></asp:Series>
                <asp:Series Name="LIE"    ChartType="Line" Color="Blue"  BorderWidth="2"></asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="cht_med_lnh_are" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64, 165, 191, 228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                    <AxisX IsLabelAutoFit="false" >
                        <MajorGrid Enabled="false" />
                        <LabelStyle Angle="-45" />
                    </AxisX>
                    <AxisY IsStartedFromZero="false">
                        <MajorGrid Enabled="false" />
                    </AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:chart>
		</td>
		<td>&nbsp;</td>
		<td>
		<asp:chart id="cht_med_bar" runat="server" Height="250px" Width="250px" ImageStorageMode="UseImageLocation" ImageLocation="~/tmp/ChartPic_#SEQ(300,3)" Palette="BrightPastel" imagetype="Png" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2" backcolor="#D3DFF0" BorderColor="26, 59, 105">
            <legends>
                <asp:Legend Docking="Bottom" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
            </legends>
            <borderskin skinstyle="Emboss"></borderskin>
            <series>
                <asp:Series Name="LIE"          ChartType="Column" Color="Blue"  BorderWidth="2" LegendText="LE"></asp:Series>
                <asp:Series Name="Histograma"   ChartType="Column" Color="Green" BorderWidth="2" LegendText="Histog." YAxisType="Secondary"></asp:Series>
                <asp:Series Name="Distribuicao" ChartType="Spline" Color="Red"   BorderWidth="2" LegendText="Dist. N."></asp:Series>
                <asp:Series Name="LSE"          ChartType="Column" Color="Blue"  BorderWidth="2" IsVisibleInLegend="false"></asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="cht_med_bar_are" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64, 165, 191, 228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                    <AxisX IsLabelAutoFit="false">
                        <MajorGrid Enabled="false" />
                        <LabelStyle Angle="-45" />
                    </AxisX>
                    <AxisY>
                        <MajorGrid Enabled="false" />
                    </AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:chart>
		</td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
	<tr>
	    <td colspan="3">
	    <table border="0">
	    <tr>
		    <td colspan="2" class="font_body">Número de Pontos: </td>
		    <td align="right" class="font_body"><asp:Label ID="lbl_med_num" runat="server"></asp:Label></td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">(Média, desvio) do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_pcs_med" runat="server"></asp:Label>;<asp:Label ID="lbl_med_pcs_dsv" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">Limites de controle do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_pcs_ini" runat="server"></asp:Label>;<asp:Label ID="lbl_med_pcs_fim" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% de elementos (&lt;LIC; &gt;LSC): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_pcs_lic" runat="server"></asp:Label>;<asp:Label ID="lbl_med_pcs_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% teórica de elementos (&lt;LIC; &gt;LSC): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_pcs_teo_lic" runat="server"></asp:Label>;<asp:Label ID="lbl_med_pcs_teo_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="3">&nbsp;</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">(Média, desvio) de especificação: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_epf_med" runat="server"></asp:Label>;<asp:Label ID="lbl_med_epf_dsv" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">Limites de especificação do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_epf_ini" runat="server"></asp:Label>;<asp:Label ID="lbl_med_epf_fim" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% de elementos (&lt;LIE; &gt;LSE): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_epf_lic" runat="server"></asp:Label>;<asp:Label ID="lbl_med_epf_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% teórica de elementos (&lt;LIE; &gt;LSE): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_med_epf_teo_lic" runat="server"></asp:Label>;<asp:Label ID="lbl_med_epf_teo_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    </table>
	    </td>
    </tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
    <tr>
	    <td colspan="3" class="destaque">Desvios</td>
    </tr>
	<tr>
		<td>
		<asp:chart id="cht_dsv_lnh" runat="server" Height="250px" Width="430px" ImageStorageMode="UseImageLocation" ImageLocation="~/tmp/ChartPic_#SEQ(300,3)" Palette="BrightPastel" imagetype="Png" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2" backcolor="#D3DFF0" BorderColor="26, 59, 105">
            <legends>
                <asp:Legend IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
            </legends>
            <borderskin skinstyle="Emboss"></borderskin>
            <series>
                <asp:Series Name="LSE"    ChartType="Line" Color="Blue"  BorderWidth="2"></asp:Series>
                <asp:Series Name="LSC"    ChartType="Line" Color="Green" BorderWidth="2"></asp:Series>
                <asp:Series Name="Desvio" ChartType="Line" Color="Green" BorderWidth="2" MarkerSize="6" MarkerStyle="Circle" IsXValueIndexed="false"></asp:Series>
                <asp:Series Name="Media"  ChartType="Line" Color="Red"   BorderWidth="2" LegendText="Média"></asp:Series>
                <asp:Series Name="LIC"    ChartType="Line" Color="Green" BorderWidth="2"></asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="cht_dsv_lnh_are" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64, 165, 191, 228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                    <AxisX IsLabelAutoFit="false" >
                        <MajorGrid Enabled="false" />
                        <LabelStyle Angle="-45" />
                    </AxisX>
                    <AxisY IsStartedFromZero="true">
                        <MajorGrid Enabled="false" />
                    </AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:chart>
		</td>
		<td>&nbsp;</td>
		<td>
		<asp:chart id="cht_dsv_bar" runat="server" Height="250px" Width="250px" ImageStorageMode="UseImageLocation" ImageLocation="~/tmp/ChartPic_#SEQ(300,3)" Palette="BrightPastel" imagetype="Png" BorderDashStyle="Solid" BackSecondaryColor="White" BackGradientStyle="TopBottom" BorderWidth="2" backcolor="#D3DFF0" BorderColor="26, 59, 105">
            <legends>
                <asp:Legend Docking="Bottom" IsTextAutoFit="False" Name="Default" BackColor="Transparent" Font="Trebuchet MS, 8.25pt, style=Bold"></asp:Legend>
            </legends>
            <borderskin skinstyle="Emboss"></borderskin>
            <series>
                <asp:Series Name="LSE"          ChartType="Column" Color="Blue"  BorderWidth="2" LegendText="LE"></asp:Series>
                <asp:Series Name="Histograma"   ChartType="Column" Color="Green" BorderWidth="2" LegendText="Histog." YAxisType="Secondary"></asp:Series>
                <asp:Series Name="Distribuicao" ChartType="Spline" Color="Red"   BorderWidth="2" LegendText="Dist. N."></asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="cht_dsv_bar_are" BorderColor="64, 64, 64, 64" BorderDashStyle="Solid" BackSecondaryColor="White" BackColor="64, 165, 191, 228" ShadowColor="Transparent" BackGradientStyle="TopBottom">
                    <AxisX IsLabelAutoFit="false">
                        <MajorGrid Enabled="false" />
                        <LabelStyle Angle="-45" />
                    </AxisX>
                    <AxisY>
                        <MajorGrid Enabled="false" />
                    </AxisY>
                </asp:ChartArea>
            </chartareas>
        </asp:chart>
		</td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
	<tr>
	    <td colspan="3">
	    <table border="0">
	    <tr>
		    <td colspan="2" class="font_body">(Média, desvio) do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_pcs_med" runat="server"></asp:Label>;<asp:Label ID="lbl_dsv_pcs_dsv" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">Limites de controle do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_pcs_ini" runat="server"></asp:Label>;<asp:Label ID="lbl_dsv_pcs_fim" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% de elementos (&gt;LSC): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_pcs_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% teórica de elementos (&lt;LIC; &gt;LSC): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_pcs_teo_lic" runat="server"></asp:Label>;<asp:Label ID="lbl_dsv_pcs_teo_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="3">&nbsp;</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">Limites de especificação do processo: </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_epf_ini" runat="server"></asp:Label>) Dtex</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% de elementos (&gt;LSE): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_epf_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    <tr>
		    <td colspan="2" class="font_body">% teórica de elementos (&gt;LSE): </td>
		    <td align="right" class="font_body">(<asp:Label ID="lbl_dsv_epf_teo_lsc" runat="server"></asp:Label>) %</td>
	    </tr>
	    </table>
	    </td>
	</tr>
	<tr>
		<td colspan="3">&nbsp;</td>
	</tr>
</table>
</div>
</div>
</form>
</body>
</html>