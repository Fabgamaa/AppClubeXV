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
        Drop.Items.Add("Águas de Lindóia");
        Drop.Items[1].Value = "Águas de Lindóia";
        Drop.Items.Add("Barueri");
        Drop.Items[2].Value = "Barueri";
        Drop.Items.Add("Caieiras");
        Drop.Items[3].Value = "Caieiras";
        Drop.Items.Add("Diadema");
        Drop.Items[4].Value = "Diadema";
        Drop.Items.Add("Rio de Janeiro");
        Drop.Items[5].Value = "Rio de Janeiro";
        Drop.Items.Add("São Paulo");
        Drop.Items[6].Value = "São Paulo";
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
        Drop.Items.Add("ABECÁSIA");
        Drop.Items[0].Value = "ABECÁSIA";
        Drop.Items.Add("AFEGANISTÃO");
        Drop.Items[1].Value = "AFEGANISTÃO";
        Drop.Items.Add("ÁFRICA DO SUL");
        Drop.Items[2].Value = "ÁFRICA DO SUL";
        Drop.Items.Add("ALBÂNIA");
        Drop.Items[3].Value = "ALBÂNIA";
        Drop.Items.Add("ALEMANHA");
        Drop.Items[4].Value = "ALEMANHA";
        Drop.Items.Add("ANDORRA");
        Drop.Items[5].Value = "ANDORRA";
        Drop.Items.Add("ANGOLA");
        Drop.Items[6].Value = "ANGOLA";
        Drop.Items.Add("ANTÍGUA E BARBUDA");
        Drop.Items[7].Value = "ANTÍGUA E BARBUDA";
        Drop.Items.Add("ARÁBIA SAUDITA");
        Drop.Items[8].Value = "ARÁBIA SAUDITA";
        Drop.Items.Add("ARGÉLIA");
        Drop.Items[9].Value = "ARGÉLIA";
        Drop.Items.Add("ARGENTINA");
        Drop.Items[10].Value = "ARGENTINA";
        Drop.Items.Add("ARMÊNIA");
        Drop.Items[11].Value = "ARMÊNIA";
        Drop.Items.Add("AUSTRÁLIA");
        Drop.Items[12].Value = "AUSTRÁLIA";
        Drop.Items.Add("ÁUSTRIA");
        Drop.Items[13].Value = "ÁUSTRIA";
        Drop.Items.Add("AZERBAIJÃO");
        Drop.Items[14].Value = "AZERBAIJÃO";
        Drop.Items.Add("BAHAMAS");
        Drop.Items[15].Value = "BAHAMAS";
        Drop.Items.Add("BAHREIN");
        Drop.Items[16].Value = "BAHREIN";
        Drop.Items.Add("BANGLADECHE");
        Drop.Items[17].Value = "BANGLADECHE";
        Drop.Items.Add("BARBADOS");
        Drop.Items[18].Value = "BARBADOS";
        Drop.Items.Add("BÉLGICA");
        Drop.Items[19].Value = "BÉLGICA";
        Drop.Items.Add("BELIZE");
        Drop.Items[20].Value = "BELIZE";
        Drop.Items.Add("BENIN");
        Drop.Items[21].Value = "BENIN";
        Drop.Items.Add("BIELORRÚSSIA");
        Drop.Items[22].Value = "BIELORRÚSSIA";
        Drop.Items.Add("BIRMÂNIA");
        Drop.Items[23].Value = "BIRMÂNIA";
        Drop.Items.Add("BOLÍVIA");
        Drop.Items[24].Value = "BOLÍVIA";
        Drop.Items.Add("BÓSNIA E HERZEGOVINA");
        Drop.Items[25].Value = "BÓSNIA E HERZEGOVINA";
        Drop.Items.Add("BOTSWANA");
        Drop.Items[26].Value = "BOTSWANA";
        Drop.Items.Add("BRASIL");
        Drop.Items[27].Value = "BRASIL";
        Drop.Items.Add("BRUNEI");
        Drop.Items[28].Value = "BRUNEI";
        Drop.Items.Add("BULGÁRIA");
        Drop.Items[29].Value = "BULGÁRIA";
        Drop.Items.Add("BURKINA FASO");
        Drop.Items[30].Value = "BURKINA FASO";
        Drop.Items.Add("BURUNDI");
        Drop.Items[31].Value = "BURUNDI";
        Drop.Items.Add("BUTÃO");
        Drop.Items[32].Value = "BUTÃO";
        Drop.Items.Add("CABO VERDE");
        Drop.Items[33].Value = "CABO VERDE";
        Drop.Items.Add("CAMARÕES");
        Drop.Items[34].Value = "CAMARÕES";
        Drop.Items.Add("CAMBOJA");
        Drop.Items[35].Value = "CAMBOJA";
        Drop.Items.Add("CANADÁ");
        Drop.Items[36].Value = "CANADÁ";
        Drop.Items.Add("CATAR");
        Drop.Items[37].Value = "CATAR";
        Drop.Items.Add("CAZAQUISTÃO");
        Drop.Items[38].Value = "CAZAQUISTÃO";
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
        Drop.Items.Add("COLÔMBIA");
        Drop.Items[45].Value = "COLÔMBIA";
        Drop.Items.Add("COMORES");
        Drop.Items[46].Value = "COMORES";
        Drop.Items.Add("CONGO-BRAZAVILE");
        Drop.Items[47].Value = "CONGO-BRAZAVILE";
        Drop.Items.Add("CONGO-QUINCHASA");
        Drop.Items[48].Value = "CONGO-QUINCHASA";
        Drop.Items.Add("CORÉIA DO NORTE");
        Drop.Items[49].Value = "CORÉIA DO NORTE";
        Drop.Items.Add("CORÉIA DO SUL");
        Drop.Items[50].Value = "CORÉIA DO SUL";
        Drop.Items.Add("COSTA DO MARFIM");
        Drop.Items[51].Value = "COSTA DO MARFIM";
        Drop.Items.Add("COSTA RICA");
        Drop.Items[52].Value = "COSTA RICA";
        Drop.Items.Add("CROÁCIA");
        Drop.Items[53].Value = "CROÁCIA";
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
        Drop.Items.Add("EMIRADOS ÁRABES UNIDOS");
        Drop.Items[59].Value = "EMIRADOS ÁRABES UNIDOS";
        Drop.Items.Add("EQUADOR");
        Drop.Items[60].Value = "EQUADOR";
        Drop.Items.Add("ERITRÉIA");
        Drop.Items[61].Value = "ERITRÉIA";
        Drop.Items.Add("ESCÓCIA");
        Drop.Items[62].Value = "ESCÓCIA";
        Drop.Items.Add("ESLOVÁQUIA");
        Drop.Items[63].Value = "ESLOVÁQUIA";
        Drop.Items.Add("ESLOVÊNIA");
        Drop.Items[64].Value = "ESLOVÊNIA";
        Drop.Items.Add("ESPANHA");
        Drop.Items[65].Value = "ESPANHA";
        Drop.Items.Add("ESTADOS UNIDOS");
        Drop.Items[66].Value = "ESTADOS UNIDOS";
        Drop.Items.Add("ESTÔNIA");
        Drop.Items[67].Value = "ESTÔNIA";
        Drop.Items.Add("ETIÓPIA");
        Drop.Items[68].Value = "ETIÓPIA";
        Drop.Items.Add("FIJI");
        Drop.Items[69].Value = "FIJI";
        Drop.Items.Add("FILIPINAS");
        Drop.Items[70].Value = "FILIPINAS";
        Drop.Items.Add("FINLÂNDIA");
        Drop.Items[71].Value = "FINLÂNDIA";
        Drop.Items.Add("FORMOSA");
        Drop.Items[72].Value = "FORMOSA";
        Drop.Items.Add("FRANÇA");
        Drop.Items[73].Value = "FRANÇA";
        Drop.Items.Add("GABÃO");
        Drop.Items[74].Value = "GABÃO";
        Drop.Items.Add("GÂMBIA");
        Drop.Items[75].Value = "GÂMBIA";
        Drop.Items.Add("GANA");
        Drop.Items[76].Value = "GANA";
        Drop.Items.Add("GEÓRGIA");
        Drop.Items[77].Value = "GEÓRGIA";
        Drop.Items.Add("GRANADA");
        Drop.Items[78].Value = "GRANADA";
        Drop.Items.Add("GRÉCIA");
        Drop.Items[79].Value = "GRÉCIA";
        Drop.Items.Add("GUATEMALA");
        Drop.Items[80].Value = "GUATEMALA";
        Drop.Items.Add("GUIANA");
        Drop.Items[81].Value = "GUIANA";
        Drop.Items.Add("GUINÉ");
        Drop.Items[82].Value = "GUINÉ";
        Drop.Items.Add("GUINÉ EQUATORIAL");
        Drop.Items[83].Value = "GUINÉ EQUATORIAL";
        Drop.Items.Add("GUINÉ-BISSAU");
        Drop.Items[84].Value = "GUINÉ-BISSAU";
        Drop.Items.Add("HAITI");
        Drop.Items[85].Value = "HAITI";
        Drop.Items.Add("HOLANDA");
        Drop.Items[86].Value = "HOLANDA";
        Drop.Items.Add("HONDURAS");
        Drop.Items[87].Value = "HONDURAS";
        Drop.Items.Add("HUNGRIA");
        Drop.Items[88].Value = "HUNGRIA";
        Drop.Items.Add("IÊMEN");
        Drop.Items[89].Value = "IÊMEN";
        Drop.Items.Add("IÉMEN");
        Drop.Items[90].Value = "IÉMEN";
        Drop.Items.Add("ILHAS MARSHALL");
        Drop.Items[91].Value = "ILHAS MARSHALL";
        Drop.Items.Add("ILHAS SALOMÃO");
        Drop.Items[92].Value = "ILHAS SALOMÃO";
        Drop.Items.Add("ÍNDIA");
        Drop.Items[93].Value = "ÍNDIA";
        Drop.Items.Add("INDONÉSIA");
        Drop.Items[94].Value = "INDONÉSIA";
        Drop.Items.Add("INGLATERRA");
        Drop.Items[95].Value = "INGLATERRA";
        Drop.Items.Add("IRÃ");
        Drop.Items[96].Value = "IRÃ";
        Drop.Items.Add("IRAQUE");
        Drop.Items[97].Value = "IRAQUE";
        Drop.Items.Add("IRLANDA");
        Drop.Items[98].Value = "IRLANDA";
        Drop.Items.Add("ISLÂNDIA");
        Drop.Items[99].Value = "ISLÂNDIA";
        Drop.Items.Add("ISRAEL");
        Drop.Items[100].Value = "ISRAEL";
        Drop.Items.Add("ITÁLIA");
        Drop.Items[101].Value = "ITÁLIA";
        Drop.Items.Add("JAMAICA");
        Drop.Items[102].Value = "JAMAICA";
        Drop.Items.Add("JAPÃO");
        Drop.Items[103].Value = "JAPÃO";
        Drop.Items.Add("JIBUTI");
        Drop.Items[104].Value = "JIBUTI";
        Drop.Items.Add("JORDÂNIA");
        Drop.Items[105].Value = "JORDÂNIA";
        Drop.Items.Add("KIRIBATI");
        Drop.Items[106].Value = "KIRIBATI";
        Drop.Items.Add("KUWAIT");
        Drop.Items[107].Value = "KUWAIT";
        Drop.Items.Add("LAUS");
        Drop.Items[108].Value = "LAUS";
        Drop.Items.Add("LESOTO");
        Drop.Items[109].Value = "LESOTO";
        Drop.Items.Add("LETÔNIA");
        Drop.Items[110].Value = "LETÔNIA";
        Drop.Items.Add("LÍBANO");
        Drop.Items[111].Value = "LÍBANO";
        Drop.Items.Add("LIBÉRIA");
        Drop.Items[112].Value = "LIBÉRIA";
        Drop.Items.Add("LÍBIA");
        Drop.Items[113].Value = "LÍBIA";
        Drop.Items.Add("LIECHTENSTEIN");
        Drop.Items[114].Value = "LIECHTENSTEIN";
        Drop.Items.Add("LITUÂNIA");
        Drop.Items[115].Value = "LITUÂNIA";
        Drop.Items.Add("LUXEMBURGO");
        Drop.Items[116].Value = "LUXEMBURGO";
        Drop.Items.Add("MACEDÔNIA");
        Drop.Items[117].Value = "MACEDÔNIA";
        Drop.Items.Add("MADAGÁSCAR");
        Drop.Items[118].Value = "MADAGÁSCAR";
        Drop.Items.Add("MALAÍSIA");
        Drop.Items[119].Value = "MALAÍSIA";
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
        Drop.Items.Add("MAURÍCIA");
        Drop.Items[125].Value = "MAURÍCIA";
        Drop.Items.Add("MAURITÂNIA");
        Drop.Items[126].Value = "MAURITÂNIA";
        Drop.Items.Add("MÉXICO");
        Drop.Items[127].Value = "MÉXICO";
        Drop.Items.Add("MICRONÉSIA");
        Drop.Items[128].Value = "MICRONÉSIA";
        Drop.Items.Add("MOÇAMBIQUE");
        Drop.Items[129].Value = "MOÇAMBIQUE";
        Drop.Items.Add("MOLDÁVIA");
        Drop.Items[130].Value = "MOLDÁVIA";
        Drop.Items.Add("MÔNACO");
        Drop.Items[131].Value = "MÔNACO";
        Drop.Items.Add("MONGÓLIA");
        Drop.Items[132].Value = "MONGÓLIA";
        Drop.Items.Add("MONTENEGRO");
        Drop.Items[133].Value = "MONTENEGRO";
        Drop.Items.Add("NAGORNO-CARABAQUE");
        Drop.Items[134].Value = "NAGORNO-CARABAQUE";
        Drop.Items.Add("NAMÍBIA");
        Drop.Items[135].Value = "NAMÍBIA";
        Drop.Items.Add("NAURU");
        Drop.Items[136].Value = "NAURU";
        Drop.Items.Add("NEPAL");
        Drop.Items[137].Value = "NEPAL";
        Drop.Items.Add("NICARÁGUA");
        Drop.Items[138].Value = "NICARÁGUA";
        Drop.Items.Add("NÍGER");
        Drop.Items[139].Value = "NÍGER";
        Drop.Items.Add("NIGÉRIA");
        Drop.Items[140].Value = "NIGÉRIA";
        Drop.Items.Add("NORUEGA");
        Drop.Items[141].Value = "NORUEGA";
        Drop.Items.Add("NOVA ZELÂNDIA");
        Drop.Items[142].Value = "NOVA ZELÂNDIA";
        Drop.Items.Add("OMÃ");
        Drop.Items[143].Value = "OMÃ";
        Drop.Items.Add("OSSÉTIA DO SUL");
        Drop.Items[144].Value = "OSSÉTIA DO SUL";
        Drop.Items.Add("PALAU");
        Drop.Items[145].Value = "PALAU";
        Drop.Items.Add("PALESTINA");
        Drop.Items[146].Value = "PALESTINA";
        Drop.Items.Add("PANAMÁ");
        Drop.Items[147].Value = "PANAMÁ";
        Drop.Items.Add("PAPUA-NOVA GUINÉ");
        Drop.Items[148].Value = "PAPUA-NOVA GUINÉ";
        Drop.Items.Add("PAQUISTÃO");
        Drop.Items[149].Value = "PAQUISTÃO";
        Drop.Items.Add("PARAGUAI");
        Drop.Items[150].Value = "PARAGUAI";
        Drop.Items.Add("PERU");
        Drop.Items[151].Value = "PERU";
        Drop.Items.Add("POLÔNIA");
        Drop.Items[152].Value = "POLÔNIA";
        Drop.Items.Add("PORTUGAL");
        Drop.Items[153].Value = "PORTUGAL";
        Drop.Items.Add("QUÊNIA");
        Drop.Items[154].Value = "QUÊNIA";
        Drop.Items.Add("QUIRGUISTÃO");
        Drop.Items[155].Value = "QUIRGUISTÃO";
        Drop.Items.Add("QUIRIBATI");
        Drop.Items[156].Value = "QUIRIBATI";
        Drop.Items.Add("REINO UNIDO");
        Drop.Items[157].Value = "REINO UNIDO";
        Drop.Items.Add("REPÚBLICA CENTRO-AFRICANA");
        Drop.Items[158].Value = "REPÚBLICA CENTRO-AFRICANA";
        Drop.Items.Add("REPÚBLICA DOMINICANA");
        Drop.Items[159].Value = "REPÚBLICA DOMINICANA";
        Drop.Items.Add("REPÚBLICA POPULAR DA CHINA");
        Drop.Items[160].Value = "REPÚBLICA POPULAR DA CHINA";
        Drop.Items.Add("REPÚBLICA TCHECA");
        Drop.Items[161].Value = "REPÚBLICA TCHECA";
        Drop.Items.Add("ROMÊNIA");
        Drop.Items[162].Value = "ROMÊNIA";
        Drop.Items.Add("RUANDA");
        Drop.Items[163].Value = "RUANDA";
        Drop.Items.Add("RÚSSIA");
        Drop.Items[164].Value = "RÚSSIA";
        Drop.Items.Add("SAARA OCIDENTAL");
        Drop.Items[165].Value = "SAARA OCIDENTAL";
        Drop.Items.Add("SAMOA");
        Drop.Items[166].Value = "SAMOA";
        Drop.Items.Add("SANTA LÚCIA");
        Drop.Items[167].Value = "SANTA LÚCIA";
        Drop.Items.Add("SÃO CRISTÓVÃO E NEVES");
        Drop.Items[168].Value = "SÃO CRISTÓVÃO E NEVES";
        Drop.Items.Add("SÃO MARINHO");
        Drop.Items[169].Value = "SÃO MARINHO";
        Drop.Items.Add("SÃO TOMÉ E PRÍNCIPE");
        Drop.Items[170].Value = "SÃO TOMÉ E PRÍNCIPE";
        Drop.Items.Add("SÃO VICENTE E GRANADINAS");
        Drop.Items[171].Value = "SÃO VICENTE E GRANADINAS";
        Drop.Items.Add("SENEGAL");
        Drop.Items[172].Value = "SENEGAL";
        Drop.Items.Add("SERRA LEOA");
        Drop.Items[173].Value = "SERRA LEOA";
        Drop.Items.Add("SÉRVIA");
        Drop.Items[174].Value = "SÉRVIA";
        Drop.Items.Add("SEYCHELLES");
        Drop.Items[175].Value = "SEYCHELLES";
        Drop.Items.Add("SINGAPURA");
        Drop.Items[176].Value = "SINGAPURA";
        Drop.Items.Add("SÍRIA");
        Drop.Items[177].Value = "SÍRIA";
        Drop.Items.Add("SOMÁLIA");
        Drop.Items[178].Value = "SOMÁLIA";
        Drop.Items.Add("SOMALILÂNDIA");
        Drop.Items[179].Value = "SOMALILÂNDIA";
        Drop.Items.Add("SRI LANKA");
        Drop.Items[180].Value = "SRI LANKA";
        Drop.Items.Add("SUAZILÂNDIA");
        Drop.Items[181].Value = "SUAZILÂNDIA";
        Drop.Items.Add("SUDÃO");
        Drop.Items[182].Value = "SUDÃO";
        Drop.Items.Add("SUÉCIA");
        Drop.Items[183].Value = "SUÉCIA";
        Drop.Items.Add("SUÍÇA");
        Drop.Items[184].Value = "SUÍÇA";
        Drop.Items.Add("SURINAME");
        Drop.Items[185].Value = "SURINAME";
        Drop.Items.Add("TAILÂNDIA");
        Drop.Items[186].Value = "TAILÂNDIA";
        Drop.Items.Add("TAIWAN");
        Drop.Items[187].Value = "TAIWAN";
        Drop.Items.Add("TAJIQUISTÃO");
        Drop.Items[188].Value = "TAJIQUISTÃO";
        Drop.Items.Add("TANZÂNIA");
        Drop.Items[189].Value = "TANZÂNIA";
        Drop.Items.Add("TIMOR-LESTE");
        Drop.Items[190].Value = "TIMOR-LESTE";
        Drop.Items.Add("TOGO");
        Drop.Items[191].Value = "TOGO";
        Drop.Items.Add("TONGA");
        Drop.Items[192].Value = "TONGA";
        Drop.Items.Add("TRANSNÍSTRIA");
        Drop.Items[193].Value = "TRANSNÍSTRIA";
        Drop.Items.Add("TRINDADE E TOBAGO");
        Drop.Items[194].Value = "TRINDADE E TOBAGO";
        Drop.Items.Add("TUNÍSIA");
        Drop.Items[195].Value = "TUNÍSIA";
        Drop.Items.Add("TURCOMANISTÃO");
        Drop.Items[196].Value = "TURCOMANISTÃO";
        Drop.Items.Add("TURQUIA");
        Drop.Items[197].Value = "TURQUIA";
        Drop.Items.Add("TUVALU");
        Drop.Items[198].Value = "TUVALU";
        Drop.Items.Add("UCRÂNIA");
        Drop.Items[199].Value = "UCRÂNIA";
        Drop.Items.Add("UGANDA");
        Drop.Items[200].Value = "UGANDA";
        Drop.Items.Add("URUGUAI");
        Drop.Items[201].Value = "URUGUAI";
        Drop.Items.Add("USBEQUISTÃO");
        Drop.Items[202].Value = "USBEQUISTÃO";
        Drop.Items.Add("VANUATU");
        Drop.Items[203].Value = "VANUATU";
        Drop.Items.Add("VENEZUELA");
        Drop.Items[204].Value = "VENEZUELA";
        Drop.Items.Add("VIETNÃ");
        Drop.Items[205].Value = "VIETNÃ";
        Drop.Items.Add("ZÂMBIA");
        Drop.Items[201].Value = "ZÂMBIA";
        Drop.Items.Add("ZIMBABUÉ");
        Drop.Items[202].Value = "ZIMBABUÉ";
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
