using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Linq;
using System.Collections.Generic;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    class ItemLancamento
    {
        public string MAQ_DES { get; set; }
        public DateTime DST_VRD_DAT { get; set; }
        public DateTime LNC_MAQ_VRD { get; set; }
        public DateTime LNC_MAQ_DAT { get; set; }
        public string LNC_MAQ_LOT { get; set; }
        public string LNC_MAQ_PRD { get; set; }
        public string LNC_MAQ_TUB { get; set; }
        public string LNC_MAQ_COR { get; set; }
    }
    List<ItemLancamento> lLancamento = new List<ItemLancamento>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["rowId"] != null)
            rowId.Value = Request["rowId"].ToString();

        if (Request["Origem"] != null)
            Origem.Value = Request["Origem"].ToString();

        if (!IsPostBack)
        {
            if (!String.IsNullOrEmpty(Origem.Value))
            {
                ucBarra.Visible = false;
                Form.Style.Add("width", "550");
                Form.Style.Add("height", "200");
            }

            FormataControles();
            CarregaControles();
        }
    }

    protected void FormataControles()
    {
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data_hora();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_formata_data_hora(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data_hora();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_formata_data_hora(this);");

        txt_dat_ini.Text = DateTime.Now.ToString("dd/MM/yyyy") + " 00:00";
        txt_dat_fim.Text = DateTime.Now.ToString("dd/MM/yyyy") + " 23:59";

        txt_dat_ini.Focus();
    }

    protected void CarregaControles()	{
	}

    protected string CriaFiltro(DistribuicaoVirada DistribuicaoVirada)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_dat_ini.Text))		{			DistribuicaoVirada.DST_VRD_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);			filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";		}
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            DistribuicaoVirada.DST_VRD_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        DistribuicaoVirada.DST_VRD_STS = 1; //Somente Ativos

        return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        int i = 0;
        int j = 0;
        int p = 0;

        HtmlTableRow tr = new HtmlTableRow();
        HtmlTableCell tc = new HtmlTableCell();

        DistribuicaoVirada DistribuicaoVirada = new DistribuicaoVirada();
        filtro = CriaFiltro(DistribuicaoVirada);

        /*
        DataSet dsDistribuicaoVirada = DistribuicaoVirada.RelatorioViradaTempo();
        */

        CarregaLancamentoMaquina();

        if (lLancamento.Count == 0)
        {
            Response.Write("Não há dados para esse Período");
        }

        foreach (ItemLancamento il in lLancamento)
        {
            i++;

            tc = new HtmlTableCell();
            tc.Attributes.Add("class", "td_virada");

            string sCor = "Black";
            switch (il.LNC_MAQ_COR)
            {
                case "AZUL":
                    sCor = "Blue";
                    break;

                case "PRETO":
                    sCor = "Black";
                    break;

                case "VERDE":
                    sCor = "rgb(0, 176, 80)";
                    break;

                case "VERMELHO":
                    sCor = "Red";
                    break;
            }

            tc.Attributes.Add("style", "color:" + sCor);
            if (il.MAQ_DES.StartsWith("A11"))
            {
                tc.Attributes.Add("style", "font-weight: bold");
            }
            tc.InnerHtml = il.MAQ_DES + " - " + Convert.ToDateTime(il.DST_VRD_DAT.ToString()).ToString("dd/MM/yy HH:mm") + "&nbsp;&nbsp;";

            if (j == 0)
            {
                tr = new HtmlTableRow();
                tr.Cells.Add(tc);
                tVirada.Rows.Add(tr);
            }
            else
            {
                HtmlTableCell tcb = new HtmlTableCell();
                tVirada.Rows[i - 1].Cells.Add(tcb);

                tVirada.Rows[i - 1].Cells.Add(tc);
            }

            if (i >= (40 * (p + 1)))
            {
                if (j == 3)
                {
                    tr.Attributes.Add("class", "page-break");
                    j = 0;
                    p++;
                }
                else
                {
                    i = (40 * p);
                    j++;
                }
            }
        }

        dvFiltro.Visible = false;
        bdyVRD.Attributes.Add("class", "");
        ucBarra.Visible = false;
        dvVirada.Visible = true;
    }

    protected void CarregaLancamentoMaquina()
    {
        LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
        LancamentoMaquina.LNC_MAQ_STS = 1;
        DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();

        DateTime dtInicial = Convert.ToDateTime(txt_dat_ini.Text);
        DateTime dtFinal = Convert.ToDateTime(txt_dat_fim.Text);

        int iVirada = 0;
        bool bDistribuiu = true;

        while (bDistribuiu)
        {
            bDistribuiu = false;
            for (int i = 0; i < dsLancamentoMaquina.Tables[0].Rows.Count; i++)
            {
                double dViradaHora = Convert.ToDouble(Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString()).ToString("HH"));
                double dViradaMinuto = Convert.ToDouble(Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString()).ToString("mm"));

                DateTime dtData = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_DAT"].ToString());
                if (dtData < dtInicial)
                {
                    //dtData = dtInicial;
                    do
                    {
                        dtData = dtData.AddHours(dViradaHora).AddMinutes(dViradaMinuto);
                    }
                    while (dtData < dtInicial);
                }

                for (int j = 1; j <= iVirada; j++)
                {
                    dtData = dtData.AddHours(dViradaHora).AddMinutes(dViradaMinuto);
                }

                if (dtData <= dtFinal)
                {
                    ItemLancamento il = new ItemLancamento();
                    il.MAQ_DES = dsLancamentoMaquina.Tables[0].Rows[i]["MAQ_DES"].ToString();
                    il.DST_VRD_DAT = dtData;
                    il.LNC_MAQ_VRD = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString());
                    il.LNC_MAQ_DAT = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_DAT"].ToString());
                    il.LNC_MAQ_LOT = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_LOT"].ToString();
                    il.LNC_MAQ_PRD = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_PRD"].ToString();
                    il.LNC_MAQ_TUB = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_TUB"].ToString();
                    il.LNC_MAQ_COR = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_COR"].ToString();
                    lLancamento.Add(il);

                    bDistribuiu = true;
                }
            }

            iVirada++;
        }
        dsLancamentoMaquina.Dispose();

        lLancamento = lLancamento.OrderBy(x => x.DST_VRD_DAT).ThenBy(x => x.MAQ_DES).ToList();
    }

}