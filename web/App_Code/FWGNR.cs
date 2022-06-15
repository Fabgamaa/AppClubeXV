using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


/// <summary>
/// Summary description for FWGNR
/// </summary>
public class FWGNR
{


    #region Cidades
    /// <summary>
    /// Preenche um DropDownList com as Cidades Brasileiras
    /// </summary>
    /// <param name="Drop"></param>
    /// 
    public static void Cidade(DropDownList Drop)
    {
        Drop.Items.Add("Adamantina");
        Drop.Items[0].Value = "Adamantina";
        Drop.Items.Add("�guas de Lind�ia");
        Drop.Items[1].Value = "�guas de Lind�ia";
        Drop.Items.Add("Barueri");
        Drop.Items[2].Value = "Barueri";
        Drop.Items.Add("Caieiras");
        Drop.Items[3].Value = "Caieiras";
        Drop.Items.Add("Diadema");
        Drop.Items[4].Value = "Diadema";
        Drop.Items.Add("Rio de Janeiro");
        Drop.Items[5].Value = "Rio de Janeiro";
        Drop.Items.Add("S�o Paulo");
        Drop.Items[6].Value = "S�o Paulo";
    }
    #endregion


    #region Estados
    /// <summary>
    /// Preenche um DropDownList com os Estados Brasileiros
    /// </summary>
    /// <param name="Drop"></param>
    /// 
    public static void Estado(DropDownList Drop)
    {
        Drop.Items.Add("AC");
        Drop.Items[0].Value = "AC";
        Drop.Items.Add("AL");
        Drop.Items[1].Value = "AL";
        Drop.Items.Add("AP");
        Drop.Items[2].Value = "AP";
        Drop.Items.Add("AM");
        Drop.Items[3].Value = "AM";
        Drop.Items.Add("BA");
        Drop.Items[4].Value = "BA";
        Drop.Items.Add("CE");
        Drop.Items[5].Value = "CE";
        Drop.Items.Add("DF");
        Drop.Items[6].Value = "DF";
        Drop.Items.Add("ES");
        Drop.Items[7].Value = "ES";
        Drop.Items.Add("GO");
        Drop.Items[8].Value = "GO";
        Drop.Items.Add("MA");
        Drop.Items[9].Value = "MA";
        Drop.Items.Add("MT");
        Drop.Items[10].Value = "MT";
        Drop.Items.Add("MS");
        Drop.Items[11].Value = "MS";
        Drop.Items.Add("MG");
        Drop.Items[12].Value = "MG";
        Drop.Items.Add("PA");
        Drop.Items[13].Value = "PA";
        Drop.Items.Add("PB");
        Drop.Items[14].Value = "PB";
        Drop.Items.Add("PR");
        Drop.Items[15].Value = "PR";
        Drop.Items.Add("PE");
        Drop.Items[16].Value = "PE";
        Drop.Items.Add("PI");
        Drop.Items[17].Value = "PI";
        Drop.Items.Add("RJ");
        Drop.Items[18].Value = "RJ";
        Drop.Items.Add("RN");
        Drop.Items[19].Value = "RN";
        Drop.Items.Add("RS");
        Drop.Items[20].Value = "RS";
        Drop.Items.Add("RO");
        Drop.Items[21].Value = "RO";
        Drop.Items.Add("RR");
        Drop.Items[22].Value = "RR";
        Drop.Items.Add("SC");
        Drop.Items[23].Value = "SC";
        Drop.Items.Add("SP");
        Drop.Items[24].Value = "SP";
        Drop.Items.Add("SE");
        Drop.Items[25].Value = "SE";
        Drop.Items.Add("TO");
        Drop.Items[26].Value = "TO";
    }
    #endregion

    #region Pais
    /// <summary>
    /// Preenche um DropDownList com os Paises
    /// </summary>
    /// <param name="Drop"></param>
    /// 
    public static void Pais(DropDownList Drop)
    {
        Drop.Items.Add("ABEC�SIA");
        Drop.Items[0].Value = "ABEC�SIA";
        Drop.Items.Add("AFEGANIST�O");
        Drop.Items[1].Value = "AFEGANIST�O";
        Drop.Items.Add("�FRICA DO SUL");
        Drop.Items[2].Value = "�FRICA DO SUL";
        Drop.Items.Add("ALB�NIA");
        Drop.Items[3].Value = "ALB�NIA";
        Drop.Items.Add("ALEMANHA");
        Drop.Items[4].Value = "ALEMANHA";
        Drop.Items.Add("ANDORRA");
        Drop.Items[5].Value = "ANDORRA";
        Drop.Items.Add("ANGOLA");
        Drop.Items[6].Value = "ANGOLA";
        Drop.Items.Add("ANT�GUA E BARBUDA");
        Drop.Items[7].Value = "ANT�GUA E BARBUDA";
        Drop.Items.Add("AR�BIA SAUDITA");
        Drop.Items[8].Value = "AR�BIA SAUDITA";
        Drop.Items.Add("ARG�LIA");
        Drop.Items[9].Value = "ARG�LIA";
        Drop.Items.Add("ARGENTINA");
        Drop.Items[10].Value = "ARGENTINA";
        Drop.Items.Add("ARM�NIA");
        Drop.Items[11].Value = "ARM�NIA";
        Drop.Items.Add("AUSTR�LIA");
        Drop.Items[12].Value = "AUSTR�LIA";
        Drop.Items.Add("�USTRIA");
        Drop.Items[13].Value = "�USTRIA";
        Drop.Items.Add("AZERBAIJ�O");
        Drop.Items[14].Value = "AZERBAIJ�O";
        Drop.Items.Add("BAHAMAS");
        Drop.Items[15].Value = "BAHAMAS";
        Drop.Items.Add("BAHREIN");
        Drop.Items[16].Value = "BAHREIN";
        Drop.Items.Add("BANGLADECHE");
        Drop.Items[17].Value = "BANGLADECHE";
        Drop.Items.Add("BARBADOS");
        Drop.Items[18].Value = "BARBADOS";
        Drop.Items.Add("B�LGICA");
        Drop.Items[19].Value = "B�LGICA";
        Drop.Items.Add("BELIZE");
        Drop.Items[20].Value = "BELIZE";
        Drop.Items.Add("BENIN");
        Drop.Items[21].Value = "BENIN";
        Drop.Items.Add("BIELORR�SSIA");
        Drop.Items[22].Value = "BIELORR�SSIA";
        Drop.Items.Add("BIRM�NIA");
        Drop.Items[23].Value = "BIRM�NIA";
        Drop.Items.Add("BOL�VIA");
        Drop.Items[24].Value = "BOL�VIA";
        Drop.Items.Add("B�SNIA E HERZEGOVINA");
        Drop.Items[25].Value = "B�SNIA E HERZEGOVINA";
        Drop.Items.Add("BOTSWANA");
        Drop.Items[26].Value = "BOTSWANA";
        Drop.Items.Add("BRASIL");
        Drop.Items[27].Value = "BRASIL";
        Drop.Items.Add("BRUNEI");
        Drop.Items[28].Value = "BRUNEI";
        Drop.Items.Add("BULG�RIA");
        Drop.Items[29].Value = "BULG�RIA";
        Drop.Items.Add("BURKINA FASO");
        Drop.Items[30].Value = "BURKINA FASO";
        Drop.Items.Add("BURUNDI");
        Drop.Items[31].Value = "BURUNDI";
        Drop.Items.Add("BUT�O");
        Drop.Items[32].Value = "BUT�O";
        Drop.Items.Add("CABO VERDE");
        Drop.Items[33].Value = "CABO VERDE";
        Drop.Items.Add("CAMAR�ES");
        Drop.Items[34].Value = "CAMAR�ES";
        Drop.Items.Add("CAMBOJA");
        Drop.Items[35].Value = "CAMBOJA";
        Drop.Items.Add("CANAD�");
        Drop.Items[36].Value = "CANAD�";
        Drop.Items.Add("CATAR");
        Drop.Items[37].Value = "CATAR";
        Drop.Items.Add("CAZAQUIST�O");
        Drop.Items[38].Value = "CAZAQUIST�O";
        Drop.Items.Add("CHADE");
        Drop.Items[39].Value = "CHADE";
        Drop.Items.Add("CHILE");
        Drop.Items[40].Value = "CHILE";
        Drop.Items.Add("CHIPRE");
        Drop.Items[41].Value = "CHIPRE";
        Drop.Items.Add("CHIPRE DO NORTE");
        Drop.Items[42].Value = "CHIPRE DO NORTE";
        Drop.Items.Add("CIDADE DO VATICANO");
        Drop.Items[43].Value = "CIDADE DO VATICANO";
        Drop.Items.Add("CINGAPURA");
        Drop.Items[44].Value = "CINGAPURA";
        Drop.Items.Add("COL�MBIA");
        Drop.Items[45].Value = "COL�MBIA";
        Drop.Items.Add("COMORES");
        Drop.Items[46].Value = "COMORES";
        Drop.Items.Add("CONGO-BRAZAVILE");
        Drop.Items[47].Value = "CONGO-BRAZAVILE";
        Drop.Items.Add("CONGO-QUINCHASA");
        Drop.Items[48].Value = "CONGO-QUINCHASA";
        Drop.Items.Add("COR�IA DO NORTE");
        Drop.Items[49].Value = "COR�IA DO NORTE";
        Drop.Items.Add("COR�IA DO SUL");
        Drop.Items[50].Value = "COR�IA DO SUL";
        Drop.Items.Add("COSTA DO MARFIM");
        Drop.Items[51].Value = "COSTA DO MARFIM";
        Drop.Items.Add("COSTA RICA");
        Drop.Items[52].Value = "COSTA RICA";
        Drop.Items.Add("CRO�CIA");
        Drop.Items[53].Value = "CRO�CIA";
        Drop.Items.Add("CUBA");
        Drop.Items[54].Value = "CUBA";
        Drop.Items.Add("DINAMARCA");
        Drop.Items[55].Value = "DINAMARCA";
        Drop.Items.Add("DOMINICA");
        Drop.Items[56].Value = "DOMINICA";
        Drop.Items.Add("EGITO");
        Drop.Items[57].Value = "EGITO";
        Drop.Items.Add("EL SALVADOR");
        Drop.Items[58].Value = "EL SALVADOR";
        Drop.Items.Add("EMIRADOS �RABES UNIDOS");
        Drop.Items[59].Value = "EMIRADOS �RABES UNIDOS";
        Drop.Items.Add("EQUADOR");
        Drop.Items[60].Value = "EQUADOR";
        Drop.Items.Add("ERITR�IA");
        Drop.Items[61].Value = "ERITR�IA";
        Drop.Items.Add("ESC�CIA");
        Drop.Items[62].Value = "ESC�CIA";
        Drop.Items.Add("ESLOV�QUIA");
        Drop.Items[63].Value = "ESLOV�QUIA";
        Drop.Items.Add("ESLOV�NIA");
        Drop.Items[64].Value = "ESLOV�NIA";
        Drop.Items.Add("ESPANHA");
        Drop.Items[65].Value = "ESPANHA";
        Drop.Items.Add("ESTADOS UNIDOS");
        Drop.Items[66].Value = "ESTADOS UNIDOS";
        Drop.Items.Add("EST�NIA");
        Drop.Items[67].Value = "EST�NIA";
        Drop.Items.Add("ETI�PIA");
        Drop.Items[68].Value = "ETI�PIA";
        Drop.Items.Add("FIJI");
        Drop.Items[69].Value = "FIJI";
        Drop.Items.Add("FILIPINAS");
        Drop.Items[70].Value = "FILIPINAS";
        Drop.Items.Add("FINL�NDIA");
        Drop.Items[71].Value = "FINL�NDIA";
        Drop.Items.Add("FORMOSA");
        Drop.Items[72].Value = "FORMOSA";
        Drop.Items.Add("FRAN�A");
        Drop.Items[73].Value = "FRAN�A";
        Drop.Items.Add("GAB�O");
        Drop.Items[74].Value = "GAB�O";
        Drop.Items.Add("G�MBIA");
        Drop.Items[75].Value = "G�MBIA";
        Drop.Items.Add("GANA");
        Drop.Items[76].Value = "GANA";
        Drop.Items.Add("GE�RGIA");
        Drop.Items[77].Value = "GE�RGIA";
        Drop.Items.Add("GRANADA");
        Drop.Items[78].Value = "GRANADA";
        Drop.Items.Add("GR�CIA");
        Drop.Items[79].Value = "GR�CIA";
        Drop.Items.Add("GUATEMALA");
        Drop.Items[80].Value = "GUATEMALA";
        Drop.Items.Add("GUIANA");
        Drop.Items[81].Value = "GUIANA";
        Drop.Items.Add("GUIN�");
        Drop.Items[82].Value = "GUIN�";
        Drop.Items.Add("GUIN� EQUATORIAL");
        Drop.Items[83].Value = "GUIN� EQUATORIAL";
        Drop.Items.Add("GUIN�-BISSAU");
        Drop.Items[84].Value = "GUIN�-BISSAU";
        Drop.Items.Add("HAITI");
        Drop.Items[85].Value = "HAITI";
        Drop.Items.Add("HOLANDA");
        Drop.Items[86].Value = "HOLANDA";
        Drop.Items.Add("HONDURAS");
        Drop.Items[87].Value = "HONDURAS";
        Drop.Items.Add("HUNGRIA");
        Drop.Items[88].Value = "HUNGRIA";
        Drop.Items.Add("I�MEN");
        Drop.Items[89].Value = "I�MEN";
        Drop.Items.Add("I�MEN");
        Drop.Items[90].Value = "I�MEN";
        Drop.Items.Add("ILHAS MARSHALL");
        Drop.Items[91].Value = "ILHAS MARSHALL";
        Drop.Items.Add("ILHAS SALOM�O");
        Drop.Items[92].Value = "ILHAS SALOM�O";
        Drop.Items.Add("�NDIA");
        Drop.Items[93].Value = "�NDIA";
        Drop.Items.Add("INDON�SIA");
        Drop.Items[94].Value = "INDON�SIA";
        Drop.Items.Add("INGLATERRA");
        Drop.Items[95].Value = "INGLATERRA";
        Drop.Items.Add("IR�");
        Drop.Items[96].Value = "IR�";
        Drop.Items.Add("IRAQUE");
        Drop.Items[97].Value = "IRAQUE";
        Drop.Items.Add("IRLANDA");
        Drop.Items[98].Value = "IRLANDA";
        Drop.Items.Add("ISL�NDIA");
        Drop.Items[99].Value = "ISL�NDIA";
        Drop.Items.Add("ISRAEL");
        Drop.Items[100].Value = "ISRAEL";
        Drop.Items.Add("IT�LIA");
        Drop.Items[101].Value = "IT�LIA";
        Drop.Items.Add("JAMAICA");
        Drop.Items[102].Value = "JAMAICA";
        Drop.Items.Add("JAP�O");
        Drop.Items[103].Value = "JAP�O";
        Drop.Items.Add("JIBUTI");
        Drop.Items[104].Value = "JIBUTI";
        Drop.Items.Add("JORD�NIA");
        Drop.Items[105].Value = "JORD�NIA";
        Drop.Items.Add("KIRIBATI");
        Drop.Items[106].Value = "KIRIBATI";
        Drop.Items.Add("KUWAIT");
        Drop.Items[107].Value = "KUWAIT";
        Drop.Items.Add("LAUS");
        Drop.Items[108].Value = "LAUS";
        Drop.Items.Add("LESOTO");
        Drop.Items[109].Value = "LESOTO";
        Drop.Items.Add("LET�NIA");
        Drop.Items[110].Value = "LET�NIA";
        Drop.Items.Add("L�BANO");
        Drop.Items[111].Value = "L�BANO";
        Drop.Items.Add("LIB�RIA");
        Drop.Items[112].Value = "LIB�RIA";
        Drop.Items.Add("L�BIA");
        Drop.Items[113].Value = "L�BIA";
        Drop.Items.Add("LIECHTENSTEIN");
        Drop.Items[114].Value = "LIECHTENSTEIN";
        Drop.Items.Add("LITU�NIA");
        Drop.Items[115].Value = "LITU�NIA";
        Drop.Items.Add("LUXEMBURGO");
        Drop.Items[116].Value = "LUXEMBURGO";
        Drop.Items.Add("MACED�NIA");
        Drop.Items[117].Value = "MACED�NIA";
        Drop.Items.Add("MADAG�SCAR");
        Drop.Items[118].Value = "MADAG�SCAR";
        Drop.Items.Add("MALA�SIA");
        Drop.Items[119].Value = "MALA�SIA";
        Drop.Items.Add("MALAWI");
        Drop.Items[120].Value = "MALAWI";
        Drop.Items.Add("MALDIVAS");
        Drop.Items[121].Value = "MALDIVAS";
        Drop.Items.Add("MALI");
        Drop.Items[122].Value = "MALI";
        Drop.Items.Add("MALTA");
        Drop.Items[123].Value = "MALTA";
        Drop.Items.Add("MARROCOS");
        Drop.Items[124].Value = "MARROCOS";
        Drop.Items.Add("MAUR�CIA");
        Drop.Items[125].Value = "MAUR�CIA";
        Drop.Items.Add("MAURIT�NIA");
        Drop.Items[126].Value = "MAURIT�NIA";
        Drop.Items.Add("M�XICO");
        Drop.Items[127].Value = "M�XICO";
        Drop.Items.Add("MICRON�SIA");
        Drop.Items[128].Value = "MICRON�SIA";
        Drop.Items.Add("MO�AMBIQUE");
        Drop.Items[129].Value = "MO�AMBIQUE";
        Drop.Items.Add("MOLD�VIA");
        Drop.Items[130].Value = "MOLD�VIA";
        Drop.Items.Add("M�NACO");
        Drop.Items[131].Value = "M�NACO";
        Drop.Items.Add("MONG�LIA");
        Drop.Items[132].Value = "MONG�LIA";
        Drop.Items.Add("MONTENEGRO");
        Drop.Items[133].Value = "MONTENEGRO";
        Drop.Items.Add("NAGORNO-CARABAQUE");
        Drop.Items[134].Value = "NAGORNO-CARABAQUE";
        Drop.Items.Add("NAM�BIA");
        Drop.Items[135].Value = "NAM�BIA";
        Drop.Items.Add("NAURU");
        Drop.Items[136].Value = "NAURU";
        Drop.Items.Add("NEPAL");
        Drop.Items[137].Value = "NEPAL";
        Drop.Items.Add("NICAR�GUA");
        Drop.Items[138].Value = "NICAR�GUA";
        Drop.Items.Add("N�GER");
        Drop.Items[139].Value = "N�GER";
        Drop.Items.Add("NIG�RIA");
        Drop.Items[140].Value = "NIG�RIA";
        Drop.Items.Add("NORUEGA");
        Drop.Items[141].Value = "NORUEGA";
        Drop.Items.Add("NOVA ZEL�NDIA");
        Drop.Items[142].Value = "NOVA ZEL�NDIA";
        Drop.Items.Add("OM�");
        Drop.Items[143].Value = "OM�";
        Drop.Items.Add("OSS�TIA DO SUL");
        Drop.Items[144].Value = "OSS�TIA DO SUL";
        Drop.Items.Add("PALAU");
        Drop.Items[145].Value = "PALAU";
        Drop.Items.Add("PALESTINA");
        Drop.Items[146].Value = "PALESTINA";
        Drop.Items.Add("PANAM�");
        Drop.Items[147].Value = "PANAM�";
        Drop.Items.Add("PAPUA-NOVA GUIN�");
        Drop.Items[148].Value = "PAPUA-NOVA GUIN�";
        Drop.Items.Add("PAQUIST�O");
        Drop.Items[149].Value = "PAQUIST�O";
        Drop.Items.Add("PARAGUAI");
        Drop.Items[150].Value = "PARAGUAI";
        Drop.Items.Add("PERU");
        Drop.Items[151].Value = "PERU";
        Drop.Items.Add("POL�NIA");
        Drop.Items[152].Value = "POL�NIA";
        Drop.Items.Add("PORTUGAL");
        Drop.Items[153].Value = "PORTUGAL";
        Drop.Items.Add("QU�NIA");
        Drop.Items[154].Value = "QU�NIA";
        Drop.Items.Add("QUIRGUIST�O");
        Drop.Items[155].Value = "QUIRGUIST�O";
        Drop.Items.Add("QUIRIBATI");
        Drop.Items[156].Value = "QUIRIBATI";
        Drop.Items.Add("REINO UNIDO");
        Drop.Items[157].Value = "REINO UNIDO";
        Drop.Items.Add("REP�BLICA CENTRO-AFRICANA");
        Drop.Items[158].Value = "REP�BLICA CENTRO-AFRICANA";
        Drop.Items.Add("REP�BLICA DOMINICANA");
        Drop.Items[159].Value = "REP�BLICA DOMINICANA";
        Drop.Items.Add("REP�BLICA POPULAR DA CHINA");
        Drop.Items[160].Value = "REP�BLICA POPULAR DA CHINA";
        Drop.Items.Add("REP�BLICA TCHECA");
        Drop.Items[161].Value = "REP�BLICA TCHECA";
        Drop.Items.Add("ROM�NIA");
        Drop.Items[162].Value = "ROM�NIA";
        Drop.Items.Add("RUANDA");
        Drop.Items[163].Value = "RUANDA";
        Drop.Items.Add("R�SSIA");
        Drop.Items[164].Value = "R�SSIA";
        Drop.Items.Add("SAARA OCIDENTAL");
        Drop.Items[165].Value = "SAARA OCIDENTAL";
        Drop.Items.Add("SAMOA");
        Drop.Items[166].Value = "SAMOA";
        Drop.Items.Add("SANTA L�CIA");
        Drop.Items[167].Value = "SANTA L�CIA";
        Drop.Items.Add("S�O CRIST�V�O E NEVES");
        Drop.Items[168].Value = "S�O CRIST�V�O E NEVES";
        Drop.Items.Add("S�O MARINHO");
        Drop.Items[169].Value = "S�O MARINHO";
        Drop.Items.Add("S�O TOM� E PR�NCIPE");
        Drop.Items[170].Value = "S�O TOM� E PR�NCIPE";
        Drop.Items.Add("S�O VICENTE E GRANADINAS");
        Drop.Items[171].Value = "S�O VICENTE E GRANADINAS";
        Drop.Items.Add("SENEGAL");
        Drop.Items[172].Value = "SENEGAL";
        Drop.Items.Add("SERRA LEOA");
        Drop.Items[173].Value = "SERRA LEOA";
        Drop.Items.Add("S�RVIA");
        Drop.Items[174].Value = "S�RVIA";
        Drop.Items.Add("SEYCHELLES");
        Drop.Items[175].Value = "SEYCHELLES";
        Drop.Items.Add("SINGAPURA");
        Drop.Items[176].Value = "SINGAPURA";
        Drop.Items.Add("S�RIA");
        Drop.Items[177].Value = "S�RIA";
        Drop.Items.Add("SOM�LIA");
        Drop.Items[178].Value = "SOM�LIA";
        Drop.Items.Add("SOMALIL�NDIA");
        Drop.Items[179].Value = "SOMALIL�NDIA";
        Drop.Items.Add("SRI LANKA");
        Drop.Items[180].Value = "SRI LANKA";
        Drop.Items.Add("SUAZIL�NDIA");
        Drop.Items[181].Value = "SUAZIL�NDIA";
        Drop.Items.Add("SUD�O");
        Drop.Items[182].Value = "SUD�O";
        Drop.Items.Add("SU�CIA");
        Drop.Items[183].Value = "SU�CIA";
        Drop.Items.Add("SU��A");
        Drop.Items[184].Value = "SU��A";
        Drop.Items.Add("SURINAME");
        Drop.Items[185].Value = "SURINAME";
        Drop.Items.Add("TAIL�NDIA");
        Drop.Items[186].Value = "TAIL�NDIA";
        Drop.Items.Add("TAIWAN");
        Drop.Items[187].Value = "TAIWAN";
        Drop.Items.Add("TAJIQUIST�O");
        Drop.Items[188].Value = "TAJIQUIST�O";
        Drop.Items.Add("TANZ�NIA");
        Drop.Items[189].Value = "TANZ�NIA";
        Drop.Items.Add("TIMOR-LESTE");
        Drop.Items[190].Value = "TIMOR-LESTE";
        Drop.Items.Add("TOGO");
        Drop.Items[191].Value = "TOGO";
        Drop.Items.Add("TONGA");
        Drop.Items[192].Value = "TONGA";
        Drop.Items.Add("TRANSN�STRIA");
        Drop.Items[193].Value = "TRANSN�STRIA";
        Drop.Items.Add("TRINDADE E TOBAGO");
        Drop.Items[194].Value = "TRINDADE E TOBAGO";
        Drop.Items.Add("TUN�SIA");
        Drop.Items[195].Value = "TUN�SIA";
        Drop.Items.Add("TURCOMANIST�O");
        Drop.Items[196].Value = "TURCOMANIST�O";
        Drop.Items.Add("TURQUIA");
        Drop.Items[197].Value = "TURQUIA";
        Drop.Items.Add("TUVALU");
        Drop.Items[198].Value = "TUVALU";
        Drop.Items.Add("UCR�NIA");
        Drop.Items[199].Value = "UCR�NIA";
        Drop.Items.Add("UGANDA");
        Drop.Items[200].Value = "UGANDA";
        Drop.Items.Add("URUGUAI");
        Drop.Items[201].Value = "URUGUAI";
        Drop.Items.Add("USBEQUIST�O");
        Drop.Items[202].Value = "USBEQUIST�O";
        Drop.Items.Add("VANUATU");
        Drop.Items[203].Value = "VANUATU";
        Drop.Items.Add("VENEZUELA");
        Drop.Items[204].Value = "VENEZUELA";
        Drop.Items.Add("VIETN�");
        Drop.Items[205].Value = "VIETN�";
        Drop.Items.Add("Z�MBIA");
        Drop.Items[201].Value = "Z�MBIA";
        Drop.Items.Add("ZIMBABU�");
        Drop.Items[202].Value = "ZIMBABU�";
    }
    #endregion

    #region combo
    public static void VerificaStatus(DataSet dsDados, string CMP_ID, string CMP_DES, string CMP_STS, DropDownList drop)
    {
        drop.Items.Clear();
        ListItem l = new ListItem();
        for (int i = 0; i < dsDados.Tables[0].Rows.Count; i++)
        {
            l = new ListItem();
            l.Text = dsDados.Tables[0].Rows[i][CMP_DES].ToString();
            l.Value = dsDados.Tables[0].Rows[i][CMP_ID].ToString();

            if (!string.IsNullOrEmpty(CMP_STS))
                if (dsDados.Tables[0].Rows[i][CMP_STS].ToString() == "0")
                    l.Attributes.Add("style", "background: #CDC5BF;");           

            drop.Items.Add(l);
        }
        drop.DataBind();
        drop.Items.Insert(0, "");
        dsDados.Dispose();
    }
    #endregion

}
