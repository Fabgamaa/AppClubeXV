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
        public int Id { get; set; }
        public string Maquina { get; set; }
        public DateTime Data { get; set; }
        public string Cor { get; set; }
    }
    List<ItemLancamento> lLancamento = new List<ItemLancamento>();

    class ItemDistribuicao
    {
        public int Id { get; set; }
        public int IdOperador { get; set; }
        public string Operador { get; set; }
        public string Maquina { get; set; }
        public DateTime Data { get; set; }
        public string Cor { get; set; }
    }
    List<ItemDistribuicao> lDistribuicao = new List<ItemDistribuicao>();

    protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			FormataControles();
			CarregaControles();
		}
        else
        {
            CarregaAtributos();
        }
	}

	protected void FormataControles()
	{
        txt_dat_inc.Text = DateTime.Now.ToString("dd/MM/yyyy");
	}

	protected void CarregaControles()
	{
        CarregaOperador();
        CarregaLancamentoMaquina();
    }


    protected void CarregaAtributos()
    {
        foreach (System.Web.UI.WebControls.ListItem li in cbo_lnc_maq_id_inc.Items)
        {
            string[] aStyle = li.Value.Split(';');
            li.Attributes.Add("style", "color: " + aStyle[3].ToString());
            if (aStyle[1].StartsWith("A11"))
            {
                li.Attributes.Add("style", "font-weight: bold");
            }
        }

        foreach (System.Web.UI.WebControls.ListItem li in cbo_dst_inc.Items)
        {
            string[] aStyle = li.Value.Split(';');
            li.Attributes.Add("style", "color: " + aStyle[5].ToString());
            if (aStyle[3].StartsWith("A11"))
            {
                li.Attributes.Add("style", "font-weight: bold");
            }
        }
    }

    protected void CarregaOperador()
    {
        Operador Operador = new Operador();
        Operador.OPD_TUR = cbo_tur_inc.SelectedValue;
        Operador.OPD_STS = 1;
        DataSet dsOperador = Operador.Consultar();

        cbo_opd_id_inc.Items.Clear();
        System.Web.UI.WebControls.ListItem l = new System.Web.UI.WebControls.ListItem();
        for (int i = 0; i < dsOperador.Tables[0].Rows.Count; i++)
        {
            l = new System.Web.UI.WebControls.ListItem();
            l.Text = dsOperador.Tables[0].Rows[i]["OPD_NOM"].ToString() + " - " + dsOperador.Tables[0].Rows[i]["OPD_PUO"].ToString();
            l.Value = dsOperador.Tables[0].Rows[i]["OPD_ID"].ToString() + ";" + dsOperador.Tables[0].Rows[i]["OPD_NOM"].ToString() + ";" + dsOperador.Tables[0].Rows[i]["OPD_PUO"].ToString();

            cbo_opd_id_inc.Items.Add(l);
        }

        dsOperador.Dispose();

        lbl_qtd_opd.InnerText = cbo_opd_id_inc.Items.Count.ToString();
    }

    protected void CarregaLancamentoMaquina()
	{
		LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
        LancamentoMaquina.LNC_MAQ_STS = 1;
		DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();

        DateTime dtInicial = Convert.ToDateTime(txt_dat_inc.Text);
        DateTime dtFinal = Convert.ToDateTime(txt_dat_inc.Text);
        if (dsLancamentoMaquina.Tables[0].Rows.Count > 0)
        {
            switch (cbo_tur_inc.SelectedValue)
            {
                case "TURNO 1":
                    dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 05:01");
                    dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 14:59");
                    break;

                case "TURNO 2":
                    dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 13:01");
                    dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 22:59");
                    break;

                case "TURNO 3":
                    dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 21:01");
                    dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 06:59").AddDays(1);
                    break;
            }
        }

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
                    string sCor = "Black";
                    switch (dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_COR"].ToString())
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

                    ItemLancamento il = new ItemLancamento();
                    il.Id = Convert.ToInt16(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_ID"].ToString());
                    il.Maquina = dsLancamentoMaquina.Tables[0].Rows[i]["MAQ_DES"].ToString();
                    il.Data = dtData;
                    il.Cor = sCor;
                    lLancamento.Add(il);

                    bDistribuiu = true;
                }
            }

            iVirada++;
        }
        dsLancamentoMaquina.Dispose();

        cbo_lnc_maq_id_inc.Items.Clear();
        lLancamento = lLancamento.OrderBy(x => x.Data).ThenBy(x => x.Maquina).ToList();
        foreach (ItemLancamento il in lLancamento)
        {
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem();

            li.Text = il.Maquina + " - " + il.Data.ToString("dd/MM/yyyy HH:mm");
            li.Value = il.Id.ToString() + ";" + il.Maquina + ";" + il.Data.ToString("dd/MM/yyyy HH:mm") + ";" + il.Cor;
            li.Attributes.Add("style", "color: " + il.Cor);
            if (il.Maquina.StartsWith("A11"))
            {
                li.Attributes.Add("style", "font-weight: bold");
            }

            cbo_lnc_maq_id_inc.Items.Add(li);
        }

        lbl_qtd_vrd.InnerText = cbo_lnc_maq_id_inc.Items.Count.ToString();
	}

    protected void CarregaResumo()
    {
        string sOperador = "";
        int i = 1;
        int j = 0;

        cbo_rem.Items.Clear();

        foreach (System.Web.UI.WebControls.ListItem li in cbo_dst_inc.Items)
        {
            string[] aDst = li.Text.Split('-');

            if (sOperador == "")
            {
                sOperador = aDst[0].ToString().Trim();
            }

            if ((aDst[0].ToString().Trim() != sOperador) || i == cbo_dst_inc.Items.Count)
            {
                if (i == cbo_dst_inc.Items.Count)
                {
                    j++;
                }

                System.Web.UI.WebControls.ListItem l = new System.Web.UI.WebControls.ListItem();

                l.Text = sOperador + " (" + j + ")";
                l.Value = sOperador;

                cbo_rem.Items.Add(l);

                sOperador = aDst[0].ToString().Trim();
                j = 0;
            }

            i++;
            j++;
        }

        lbl_qtd_rem.InnerText = cbo_rem.Items.Count.ToString();
    }

    protected void txt_dat_inc_OnTextChanged(object sender, EventArgs e)
    {
        CarregaLancamentoMaquina();
    }

    protected void cbo_tur_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        CarregaLancamentoMaquina();
        CarregaOperador();
    }

    protected void btApaOpd_Click(object sender, EventArgs e)
    {
        List<System.Web.UI.WebControls.ListItem> lRemover = new List<System.Web.UI.WebControls.ListItem>();
        foreach (System.Web.UI.WebControls.ListItem li in cbo_opd_id_inc.Items)
        {
            if (li.Selected)
            {
                lRemover.Add(li);
            }
        }
        foreach (System.Web.UI.WebControls.ListItem li in lRemover) cbo_opd_id_inc.Items.Remove(li);

        lbl_qtd_opd.InnerText = cbo_opd_id_inc.Items.Count.ToString();
    }

    protected void btApaLncMaq_Click(object sender, EventArgs e)
    {
        List<System.Web.UI.WebControls.ListItem> lRemover = new List<System.Web.UI.WebControls.ListItem>();
        foreach (System.Web.UI.WebControls.ListItem li in cbo_lnc_maq_id_inc.Items)
        {
            if (li.Selected)
            {
                lRemover.Add(li);
            }
        }
        foreach (System.Web.UI.WebControls.ListItem li in lRemover) cbo_lnc_maq_id_inc.Items.Remove(li);

        lbl_qtd_vrd.InnerText = cbo_lnc_maq_id_inc.Items.Count.ToString();
    }

    protected void btApaDst_Click(object sender, EventArgs e)
    {
        lLancamento.Clear();
        foreach (System.Web.UI.WebControls.ListItem l in cbo_lnc_maq_id_inc.Items)
        {
            string[] aLncMaq = l.Value.Split(';');

            ItemLancamento il = new ItemLancamento();
            il.Id = Convert.ToInt16(aLncMaq[0].ToString());
            il.Maquina = aLncMaq[1].ToString();
            il.Data = Convert.ToDateTime(aLncMaq[2]);
            il.Cor = aLncMaq[3].ToString();
            lLancamento.Add(il);
        }

        List<System.Web.UI.WebControls.ListItem> lRemover = new List<System.Web.UI.WebControls.ListItem>();
        foreach (System.Web.UI.WebControls.ListItem li in cbo_dst_inc.Items)
        {
            if (li.Selected)
            {
                string[] aDst = li.Value.Split(';');

                ItemLancamento il = new ItemLancamento();
                il.Id = Convert.ToInt16(aDst[0].ToString());
                il.Maquina = aDst[3].ToString();
                il.Data = Convert.ToDateTime(aDst[4]);
                il.Cor = aDst[5].ToString();
                lLancamento.Add(il);

                lRemover.Add(li);
            }
        }
        foreach (System.Web.UI.WebControls.ListItem li in lRemover) cbo_dst_inc.Items.Remove(li);

        lbl_qtd_dst.InnerText = cbo_dst_inc.Items.Count.ToString();

        cbo_lnc_maq_id_inc.Items.Clear();
        lLancamento = lLancamento.OrderBy(x => x.Data).ThenBy(x => x.Maquina).ToList();
        foreach (ItemLancamento il in lLancamento)
        {
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem();

            li.Text = il.Maquina + " - " + il.Data.ToString("dd/MM/yyyy HH:mm");
            li.Value = il.Id.ToString() + ";" + il.Maquina + ";" + il.Data.ToString("dd/MM/yyyy HH:mm") + ";" + il.Cor;
            li.Attributes.Add("style", "color: " + il.Cor);
            if (il.Maquina.StartsWith("A11"))
            {
                li.Attributes.Add("style", "font-weight: bold");
            }

            cbo_lnc_maq_id_inc.Items.Add(li);
        }

        lbl_qtd_vrd.InnerText = cbo_lnc_maq_id_inc.Items.Count.ToString();

        CarregaResumo();
    }

    protected void btDistribuir_Click(object sender, EventArgs e)
    {
        bool bTodosOperadores = (cbo_opd_id_inc.SelectedIndex == -1);
        bool bTodosLancamentos = (cbo_lnc_maq_id_inc.SelectedIndex == -1);
        int iIncluidos = 0;
        int iQuantidade = -1;

        if (!string.IsNullOrEmpty(txt_qtd_inc.Text))
        {
            iQuantidade = Convert.ToInt16(txt_qtd_inc.Text);
        }

        lDistribuicao.Clear();
        foreach (System.Web.UI.WebControls.ListItem li in cbo_dst_inc.Items)
        {
            string[] aOpd = li.Text.Split(';');
            string[] aDst = li.Value.Split(';');

            ItemDistribuicao id = new ItemDistribuicao();
            id.Id = Convert.ToInt16(aDst[0].ToString());
            id.IdOperador = Convert.ToInt16(aDst[1].ToString());
            id.Operador = aDst[2].ToString();
            id.Maquina = aDst[3].ToString();
            id.Data = Convert.ToDateTime(aDst[4]);
            id.Cor = aDst[5].ToString();
            lDistribuicao.Add(id);
        }

        for (int i = 0; i < cbo_opd_id_inc.Items.Count; i++)
        {
            if (bTodosOperadores || (cbo_opd_id_inc.Items[i].Selected))
            {
                foreach (System.Web.UI.WebControls.ListItem li in cbo_lnc_maq_id_inc.Items)
                {
                    if (bTodosLancamentos || li.Selected)
                    {
                        string[] aOpd = cbo_opd_id_inc.Items[i].Value.Split(';');
                        string[] aDst = li.Value.Split(';');

                        ItemDistribuicao id = new ItemDistribuicao();
                        id.Id = Convert.ToInt16(aDst[0].ToString());
                        id.IdOperador = Convert.ToInt16(aOpd[0].ToString());
                        id.Operador = aOpd[1].ToString();
                        id.Maquina = aDst[1].ToString();
                        id.Data = Convert.ToDateTime(aDst[2]);
                        id.Cor = aDst[3].ToString();
                        lDistribuicao.Add(id);

                        cbo_lnc_maq_id_inc.Items.Remove(li);

                        iIncluidos++;

                        break;
                    }
                }
            }

            if (iIncluidos == iQuantidade)
            {
                break;
            }

            if (cbo_lnc_maq_id_inc.Items.Count == 0)
            {
                break;
            }

            if (!bTodosLancamentos && (cbo_lnc_maq_id_inc.SelectedIndex == -1))
            {
                break;
            }

            if (i == cbo_opd_id_inc.Items.Count - 1)
            {
                i = -1;
            }
        }

        cbo_dst_inc.Items.Clear();
        lDistribuicao = lDistribuicao.OrderBy(x => x.Operador).ThenBy(x => x.Data).ToList();
        foreach (ItemDistribuicao id in lDistribuicao)
        {
            System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem();

            li.Text = id.Operador + " - " + id.Maquina + " - " + id.Data.ToString("dd/MM/yyyy HH:mm");
            li.Value = id.Id.ToString() + ";" + id.IdOperador.ToString() + ";" + id.Operador + ";" + id.Maquina + ";" + id.Data.ToString("dd/MM/yyyy HH:mm") + ";" + id.Cor;
            li.Attributes.Add("style", "color: " + id.Cor);
            if (id.Maquina.StartsWith("A11"))
            {
                li.Attributes.Add("style", "font-weight: bold");
            }

            cbo_dst_inc.Items.Add(li);
        }

        CarregaAtributos();

        lbl_qtd_vrd.InnerText = cbo_lnc_maq_id_inc.Items.Count.ToString();
        lbl_qtd_dst.InnerText = cbo_dst_inc.Items.Count.ToString();

        CarregaResumo();
    }

    protected void btNovo_Click(object sender, EventArgs e)
    {
        Response.Redirect("DistribuicaoVirada.aspx");
    }

    protected void btSalvar_Click(object sender, EventArgs e)
	{
		string sMsg;
        if (cbo_dst_inc.Items.Count == 0)
        {
            TratamentoErro("A Distribuição é obrigatória.");
            cbo_dst_inc.Focus();
            return;
        }

		if (cbo_sts_inc.Text == "")
		{
			TratamentoErro("O campo Status é obrigatório.");
			cbo_sts_inc.Focus();
			return;
		}

		DistribuicaoVirada DistribuicaoVirada = new DistribuicaoVirada();

        DateTime? dtInicial = null;
        DateTime? dtFinal = null;
        switch (cbo_tur_inc.SelectedValue)
        {
            case "TURNO 1":
                dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 05:01");
                dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 14:59");
                break;

            case "TURNO 2":
                dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 13:01");
                dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 22:59");
                break;

            case "TURNO 3":
                dtInicial = Convert.ToDateTime(txt_dat_inc.Text + " 21:01");
                dtFinal = Convert.ToDateTime(txt_dat_inc.Text + " 06:59").AddDays(1);
                break;
        }
        DistribuicaoVirada.DST_VRD_DAT_INI = dtInicial;
        DistribuicaoVirada.DST_VRD_DAT_FIM = dtFinal;
        DistribuicaoVirada.DST_VRD_TUR = cbo_tur_inc.SelectedValue;

        sMsg = DistribuicaoVirada.Excluir();

        if (sMsg != "")
        {
            TratamentoErro(sMsg);
        }

        foreach (System.Web.UI.WebControls.ListItem li in cbo_dst_inc.Items)
        {
            string[] aDistribuicao = li.Value.Split(';');

		    DistribuicaoVirada.DST_VRD_OPD_ID = Convert.ToInt32(aDistribuicao[1].ToString());
            DistribuicaoVirada.DST_VRD_LNC_MAQ_ID = Convert.ToInt32(aDistribuicao[0].ToString());
            DistribuicaoVirada.DST_VRD_DAT = Convert.ToDateTime(aDistribuicao[4].ToString());
            DistribuicaoVirada.DST_VRD_TUR = cbo_tur_inc.SelectedValue;
            DistribuicaoVirada.DST_VRD_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);

			DistribuicaoVirada.DST_VRD_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
            sMsg = DistribuicaoVirada.Inserir();

            if (sMsg.Substring(0, 1) == "E")
            {
                Response.Redirect("Erro.aspx?Erro=" + HttpUtility.UrlEncode(sMsg));
            }
        }
        Dispose();

        ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Distribuição de Virada inserido com sucesso.');window.location='DistribuicaoVirada.aspx';", true);
    }

    protected void btBlack_Click(object sender, EventArgs e)
    {
        SelecionaLancamentoMaquina("color: Black");
    }

    protected void btBlue_Click(object sender, EventArgs e)
    {
        SelecionaLancamentoMaquina("color: Blue");
    }

    protected void btRed_Click(object sender, EventArgs e)
    {
        SelecionaLancamentoMaquina("color: Red");
    }

    protected void btGreen_Click(object sender, EventArgs e)
    {
        SelecionaLancamentoMaquina("color: rgb(0, 176, 80)");
    }

    protected void btBold_Click(object sender, EventArgs e)
    {
        SelecionaLancamentoMaquina("font-weight: bold");
    }

    protected void SelecionaLancamentoMaquina(string sAtributo)
    {
        foreach (System.Web.UI.WebControls.ListItem li in cbo_lnc_maq_id_inc.Items)
        {
            if (li.Attributes["style"].ToString() == sAtributo)
            {
                li.Selected = true;
            }
        }        
    }
    
    private void TratamentoErro(string erro)
	{
		if (!string.IsNullOrEmpty(erro))
			ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
	}

}

