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

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public partial class _Default : System.Web.UI.Page
{
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
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

        txt_dat_ini.Focus();
    }

    protected void CarregaControles()	{
	}

    protected string CriaFiltro(DistribuicaoVirada DistribuicaoVirada)	{		string filtro = "";

        if (cbo_tur.SelectedValue == "")
        {
            if (!String.IsNullOrEmpty(txt_dat_ini.Text))
            {
                DistribuicaoVirada.DST_VRD_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
                filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
            }
            if (!String.IsNullOrEmpty(txt_dat_fim.Text))
            {
                DistribuicaoVirada.DST_VRD_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text + " 23:59:59");
                filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
            }
        }
        else
        {
            DateTime? dtInicial = null;
            DateTime? dtFinal = null;
            switch (cbo_tur.SelectedValue)
            {
                case "TURNO 1":
                    if (!String.IsNullOrEmpty(txt_dat_ini.Text))
                    {
                        dtInicial = Convert.ToDateTime(txt_dat_ini.Text + " 05:01");
                    }
                    if (!String.IsNullOrEmpty(txt_dat_fim.Text))
                    {
                        dtFinal = Convert.ToDateTime(txt_dat_fim.Text + " 14:59");
                    }
                    break;

                case "TURNO 2":
                    if (!String.IsNullOrEmpty(txt_dat_ini.Text))
                    {
                        dtInicial = Convert.ToDateTime(txt_dat_ini.Text + " 13:01");
                    }
                    if (!String.IsNullOrEmpty(txt_dat_fim.Text))
                    {
                        dtFinal = Convert.ToDateTime(txt_dat_fim.Text + " 22:59");
                    }
                    break;

                case "TURNO 3":
                    if (!String.IsNullOrEmpty(txt_dat_ini.Text))
                    {
                        dtInicial = Convert.ToDateTime(txt_dat_ini.Text + " 21:01");
                    }
                    if (!String.IsNullOrEmpty(txt_dat_fim.Text))
                    {
                        dtFinal = Convert.ToDateTime(txt_dat_fim.Text + " 06:59").AddDays(1);
                    }
                    break;
            }
            DistribuicaoVirada.DST_VRD_DAT_INI = dtInicial;
            filtro = filtro + "Data Inicial= " + dtInicial.ToString() + "; ";
            DistribuicaoVirada.DST_VRD_DAT_FIM = dtFinal;
            filtro = filtro + "Data Final= " + dtFinal.ToString() + "; ";        }        if (!String.IsNullOrEmpty(cbo_tur.Text))
        {
            DistribuicaoVirada.DST_VRD_TUR = cbo_tur.Text;
            filtro = filtro + "Turno= " + cbo_tur.Text + "; ";
        }
        DistribuicaoVirada.DST_VRD_STS = 1; //Somente Ativos

        return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";

        string sOPDNOM = "";
        int i = 0;
        int j = 0;
        int k = 0;
        int p = 0;

        HtmlTableRow tr = new HtmlTableRow();
        HtmlTableCell tc = new HtmlTableCell();

        DistribuicaoVirada DistribuicaoVirada = new DistribuicaoVirada();
        filtro = CriaFiltro(DistribuicaoVirada);
        DataSet dsDistribuicaoVirada = DistribuicaoVirada.RelatorioDistribuicaoVirada();

        if (dsDistribuicaoVirada.Tables[0].Rows.Count == 0)
        {
            Response.Write("Não há dados para esse Período e Turno");
        }

        foreach (DataRow dr in dsDistribuicaoVirada.Tables[0].Rows)
        {
            i++;
            k++;

            if (sOPDNOM != dr["OPD_NOM"].ToString())
            {
                if ((sOPDNOM != "") && (cbo_agu.SelectedValue == "NÃO"))
                {
                    for (int l = i; l <= (45 * (p + 1)); l++)
                    {
                        tc = new HtmlTableCell();
                        tc.InnerHtml = "&nbsp;";
                        tr.Cells.Add(tc);

                        if (j == 0)
                        {
                            tr = new HtmlTableRow();
                            tr.Cells.Add(tc);
                            tDistribuicao.Rows.Add(tr);
                        }
                        else
                        {
                            HtmlTableCell tcb = new HtmlTableCell();
                            tcb.InnerHtml = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                            tDistribuicao.Rows[i - 1].Cells.Add(tcb);
                            tDistribuicao.Rows[i - 1].Cells.Add(tc);
                        }

                        i++;
                    }

                    if (i >= (45 * (p + 1)))
                    {
                        if (j == 2)
                        {
                            tr.Attributes.Add("class", "page-break");
                            j = 0;
                            p++;
                        }
                        else
                        {
                            i = (45 * p);
                            j++;

                            i++;
                        }
                    }
                }

                string sNome = "";

                if (dr["OPD_NOM"].ToString().IndexOf(' ') > 0)
                {
                    sNome = dr["OPD_NOM"].ToString().Substring(0, dr["OPD_NOM"].ToString().IndexOf(' '));
                }
                else
                {
                    sNome = dr["OPD_NOM"].ToString();
                }

                tc = new HtmlTableCell();
                tc.Attributes.Add("class", "td_operador");
                tc.InnerHtml = "<b>" + sNome + " (" + dr["OPD_TUM"].ToString() + ") " + dr["OPD_PUO"].ToString() + "</b>";

                if (j == 0)
                {
                    tr = new HtmlTableRow();
                    tr.Cells.Add(tc);
                    tDistribuicao.Rows.Add(tr);
                }
                else
                {
                    HtmlTableCell tcb = new HtmlTableCell();
                    tcb.InnerHtml = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                    tDistribuicao.Rows[i - 1].Cells.Add(tcb);
                    tDistribuicao.Rows[i - 1].Cells.Add(tc);
                }

                sOPDNOM = dr["OPD_NOM"].ToString();

                k = 1;
                i++;

                //Só se for maior que 45 pois tem que preencher a ultima linha
                if (i > (45 * (p + 1)))
                {
                    if (j == 2)
                    {
                        tr.Attributes.Add("class", "page-break");
                        j = 0;
                        p++;
                    }
                    else
                    {
                        i = (45 * p);
                        j++;

                        i++;
                    }
                }
            }

            tc = new HtmlTableCell();
            tc.Attributes.Add("class", "td_distribuicao");

            string sCor = "Black";
            switch (dr["LNC_MAQ_COR"].ToString())
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
            if (dr["MAQ_DES"].ToString().StartsWith("A11"))
            {
                tc.Attributes.Add("style", "font-weight: bold");
            }
            tc.InnerHtml = k.ToString() + " => " + dr["MAQ_DES"].ToString().PadRight(5, ' ').Replace(" ", "&nbsp;") + " - " + Convert.ToDateTime(dr["DST_VRD_DAT"].ToString()).ToString("dd/MM/yy HH:mm");

            if (j == 0)
            {
                tr = new HtmlTableRow();
                tr.Cells.Add(tc);
                tDistribuicao.Rows.Add(tr);
            }
            else
            {
                HtmlTableCell tcb = new HtmlTableCell();
                tcb.InnerHtml = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                try
                {
                    tDistribuicao.Rows[i - 1].Cells.Add(tcb);
                }
                catch
                {
                    Response.Write("i=[" + i + "], j=[" + j + "], p=[" + p + "] e tc=[" + tc.InnerText + "]");
                    dvFiltro.Visible = false;
                    bdyDST_VRD.Attributes.Add("class", "");
                    ucBarra.Visible = false;
                    dvDistribuicao.Visible = true;
                    return;

                }
                tDistribuicao.Rows[i - 1].Cells.Add(tc);
            }

            if (i >= (45 * (p + 1)))
            {
                if (j == 2)
                {
                    tr.Attributes.Add("class", "page-break");
                    j = 0;
                    p++;
                }
                else
                {
                    i = (45 * p);
                    j++;
                }
            }
        }

        dsDistribuicaoVirada.Dispose();

        dvFiltro.Visible = false;
        bdyDST_VRD.Attributes.Add("class", "");
        ucBarra.Visible = false;
        dvDistribuicao.Visible = true;
    }

}