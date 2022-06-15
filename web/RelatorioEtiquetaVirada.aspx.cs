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
    }

    protected void CarregaControles()
    {
        Maquina Maquina = new Maquina();
        DataSet dsMaquina = Maquina.Consultar();
        FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id);
        dsMaquina.Dispose();
    }

    protected string CriaFiltro(LancamentoMaquina LancamentoMaquina)	{		string filtro = "";

        if (!string.IsNullOrEmpty(cbo_maq_id.SelectedValue))
        {
            LancamentoMaquina.LNC_MAQ_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
            filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
        }
        if (!string.IsNullOrEmpty(cbo_sts.SelectedValue))
        {
            LancamentoMaquina.LNC_MAQ_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }

        return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";

        LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
        filtro = CriaFiltro(LancamentoMaquina);
        DataSet dsLancamentoMaquina = LancamentoMaquina.RelatorioEtiqueta();

        gvLancamentoMaquina.DataSource = dsLancamentoMaquina;
        gvLancamentoMaquina.DataBind();
        dsLancamentoMaquina.Dispose();
        Dispose();

        if (!String.IsNullOrEmpty(filtro))
        {
            lb_fil.Text = filtro;
        }
        else
        {
            lb_fil.Text = "Não há filtros.";
        }

        dvFiltro.Visible = false;
        dvResultado.Visible = true;
    }

    protected void gvLancamentoMaquina_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["style"] = "cursor:pointer"; 
            e.Row.Attributes.Add("onMouseOver", "this.className='selecionado';");

            if ((e.Row.RowIndex % 2) == 0)
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_par';");
            }
            else
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_impar';");
            }

            TextBox txt_vrd_ini = (TextBox)e.Row.FindControl("txt_vrd_ini");
            txt_vrd_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");
            TextBox txt_vrd_fim = (TextBox)e.Row.FindControl("txt_vrd_fim");
            txt_vrd_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_numero();");

            DropDownList ddl_pos = (DropDownList)e.Row.FindControl("ddl_pos");
            ddl_pos.SelectedValue = gvLancamentoMaquina.DataKeys[e.Row.RowIndex]["LNC_MAQ_POS"].ToString();
        }
    }

    private SortDirection GridViewSortDirection
    {
        get
        {
            if (ViewState["sortDirection"] == null)
                ViewState["sortDirection"] = SortDirection.Ascending;
            return (SortDirection)ViewState["sortDirection"];
        }
        set { ViewState["sortDirection"] = value; }
    }

    private int GetSortColumnIndex()
    {
        foreach (DataControlField field in gvLancamentoMaquina.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvLancamentoMaquina.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddSortImage(int columnIndex, GridViewRow headerRow)
    {
        System.Web.UI.WebControls.Image sortImage = new System.Web.UI.WebControls.Image();
        if (GridViewSortDirection == SortDirection.Ascending)
        {
            sortImage.ImageUrl = "img/arrow_down.gif";
            sortImage.AlternateText = "Ordem Ascendente";
        }
        else
        {
            sortImage.ImageUrl = "img/arrow_up.gif";
            sortImage.AlternateText = "Ordem Descendente";
        }
        headerRow.Cells[columnIndex].Controls.Add(sortImage);
    }

    protected void gvLancamentoMaquina_RowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            int sortColumnIndex = GetSortColumnIndex();
            if (sortColumnIndex != -1)
            {
                AddSortImage(sortColumnIndex, e.Row);
            }
        }
    }

    /*
    protected void gvLancamentoMaquina_Sorting(object sender, GridViewSortEventArgs e)
    {
        string Ordem = " ASC ";
        string sortExpression = e.SortExpression;
        ViewState["SortExpression"] = sortExpression;
        if (GridViewSortDirection == SortDirection.Ascending)
        {
            GridViewSortDirection = SortDirection.Descending;
            Ordem = " DESC ";
        }
        else
        {
            GridViewSortDirection = SortDirection.Ascending;
            Ordem = " ASC ";
        }

        string filtro = "";

        LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
        filtro = CriaFiltro(LancamentoMaquina);
        DataSet dsLancamentoMaquina = LancamentoMaquina.RelatorioEtiquetaVirada();

        DataTable dtLancamentoMaquina = dsLancamentoMaquina.Tables[0];
        DataView dvLancamentoMaquina = new DataView(dtLancamentoMaquina);
        dvLancamentoMaquina.Sort = e.SortExpression + Ordem;
        gvLancamentoMaquina.DataSource = dvLancamentoMaquina;
        gvLancamentoMaquina.DataBind();

        dvLancamentoMaquina.Dispose();
        dtLancamentoMaquina.Dispose();
        dsLancamentoMaquina.Dispose();
        Dispose();
    }
    */

    protected void geraEtiqueta(string sMAQ_DES, string sLNC_MAQ_LOT, string sLNC_MAQ_PRD, string sLNC_MAQ_DES, int iVrdIni, int iVrdFim, string sPosicao)
    {
        int iPosIni = 0;
        int iPosFim = 0;

        switch (sPosicao)
        {
            case "Máquina Inteira - 1 a 216":
                iPosIni = 1;
                iPosFim = 216;
                break;
            case "Lado A - 1 a 110":
                iPosIni = 1;
                iPosFim = 110;
                break;
            case "Lado B - 109 a 216":
                iPosIni = 109;
                iPosFim = 216;
                break;
            case "Máquina Inteira 2 Cabos - 1 a 110":
                iPosIni = 1;
                iPosFim = 110;
                break;
            case "Máquina Inteira 3 Cabos - 1 a 80":
                iPosIni = 1;
                iPosFim = 80;
                break;
            case "Máquina Inteira 4 Cabos - 1 a 60":
                iPosIni = 1;
                iPosFim = 60;
                break;
            case "Lado A 2 Cabos - 1 a 60":
                iPosIni = 1;
                iPosFim = 60;
                break;
            case "Lado B 2 Cabos - 55 a 109":
                iPosIni = 55;
                iPosFim = 109;
                break;
            case "Lado A 3 Cabos - 1 a 40":
                iPosIni = 1;
                iPosFim = 40;
                break;
            case "Lado B 3 Cabos - 37 a 72":
                iPosIni = 37;
                iPosFim = 72;
                break;
            case "Lado A 4 Cabos - 1 a 30":
                iPosIni = 1;
                iPosFim = 30;
                break;
            case "Lado B 4 Cabos - 28 a 54":
                iPosIni = 28;
                iPosFim = 54;
                break;
            case "Etiqueta de Quebra - 1 a 60":
                iPosIni = 1;
                iPosFim = 60;
                break;
            case "Murata - 121 a 240":
                iPosIni = 121;
                iPosFim = 240;
                break;
            case "Murata - 1 a 120":
                iPosIni = 1;
                iPosFim = 120;
                break;
        }

        int v = iVrdFim;

        do
        {
            int j = 0;
            int k = 0;

            HtmlTable ht = new HtmlTable();
            ht.CellPadding = 0;
            ht.CellSpacing = 0;

            HtmlTableRow tr = new HtmlTableRow();
            HtmlTableCell tc = new HtmlTableCell();

            if ((v == 0) && ((iVrdIni != 0) && (iVrdFim != 0)))
            {
                v = 999;
            }

            for (int i = iPosFim; i >= iPosIni; i--)
            {
                j++;

                tc = new HtmlTableCell();
                tc.InnerHtml = "<font style='font-size:5pt'>" + "Industria Brasileira" + "</font>" + "<br />";
                tc.InnerHtml += "<font style='font-size:5pt'>" + sLNC_MAQ_DES + "</font>" + "<br />";
                tc.InnerHtml += "<font style='font-size:7pt'>" + sLNC_MAQ_PRD.PadRight(28, ' ').Substring(0, 28).Trim() + "</font>" + "<br />";
                tc.InnerHtml += "<b>" + sLNC_MAQ_LOT + " " + "<font style='font-size:8pt'>" + sMAQ_DES + " &nbsp;" + v.ToString() + " &nbsp;" + i.ToString() + "</font>" + "</b>";
                tc.Attributes.Add("class", "td_etiqueta");

                tr.Controls.AddAt(0, tc);

                if (j == 4)
                {
                    k++;

                    ht.Rows.Add(tr);

                    if (k == 15)
                    {
                        HtmlTableRow ht_tr = new HtmlTableRow();
                        HtmlTableCell ht_tc = new HtmlTableCell();
                        ht_tc.Controls.Add(ht);
                        ht_tr.Controls.Add(ht_tc);
                        ht_tr.Attributes.Add("class", "page-break");

                        tEtiqueta.Controls.AddAt(0, ht_tr);

                        ht = new HtmlTable();
                        ht.CellPadding = 0;
                        ht.CellSpacing = 0;

                        k = 0;
                    }

                    tr = new HtmlTableRow();

                    j = 0;
                }

                if ((i == iPosIni) && (k != 0))
                {
                    do
                    {
                        for (int c = j + 1; c <= 4; c++)
                        {
                            tc = new HtmlTableCell();
                            tc.InnerHtml = "<font style='font-size:5pt'>&nbsp;</font>" + "<br />";
                            tc.InnerHtml += "<font style='font-size:5pt'>&nbsp;</font>" + "<br />";
                            tc.InnerHtml += "<font style='font-size:7pt'>&nbsp;</font>" + "<br />";
                            tc.InnerHtml += "<b>" + "<font style='font-size:8pt'>&nbsp;</font>" + "</b>";
                            tc.Attributes.Add("class", "td_etiqueta");

                            tr.Controls.AddAt(0, tc);
                        }

                        k++;

                        ht.Rows.Add(tr);

                        if (k == 15)
                        {
                            HtmlTableRow ht_tr = new HtmlTableRow();
                            HtmlTableCell ht_tc = new HtmlTableCell();
                            ht_tc.Controls.Add(ht);
                            ht_tr.Controls.Add(ht_tc);
                            ht_tr.Attributes.Add("class", "page-break");

                            tEtiqueta.Controls.AddAt(0, ht_tr);
                        }

                        tr = new HtmlTableRow();

                        j = 0;

                    } while (k < 15);

                    k = 0;
                }
            }

            v--;

        } while (v != (iVrdIni - 1));
    }

    protected void chk_sel_tdo_CheckedChanged(object sender, EventArgs e)
    {
        CheckBox cbseltdo = (CheckBox)gvLancamentoMaquina.HeaderRow.FindControl("chk_sel_tdo");

        foreach (GridViewRow gvrLancamentoMaquina in gvLancamentoMaquina.Rows)
        {
            CheckBox cbsel = (CheckBox)gvrLancamentoMaquina.FindControl("chk_sel");
            if (cbsel.Enabled)
                cbsel.Checked = cbseltdo.Checked;
        }
    }

    protected void btImprimir_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow gvrLancamentoMaquina in gvLancamentoMaquina.Rows)
        {
            CheckBox cbsel = (CheckBox)gvrLancamentoMaquina.FindControl("chk_sel");
            if (cbsel.Checked)
            {
                int iTeste;

                TextBox txt_vrd_ini = (TextBox)gvrLancamentoMaquina.FindControl("txt_vrd_ini");
                if (txt_vrd_ini.Text == "")
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Distribuição de Virada é obrigatório.');", true);
                    txt_vrd_ini.Focus();
                    return;
                }

                if (!int.TryParse(txt_vrd_ini.Text, out iTeste))
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Distribuição de Virada é inválido.');", true);
                    txt_vrd_ini.Focus();
                    return;
                }

                TextBox txt_vrd_fim = (TextBox)gvrLancamentoMaquina.FindControl("txt_vrd_fim");
                if (txt_vrd_fim.Text == "")
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Distribuição de Virada é obrigatório.');", true);
                    txt_vrd_fim.Focus();
                    return;
                }

                if (!int.TryParse(txt_vrd_fim.Text, out iTeste))
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Distribuição de Virada é inválido.');", true);
                    txt_vrd_fim.Focus();
                    return;
                }

                DropDownList ddl_pos = (DropDownList)gvrLancamentoMaquina.FindControl("ddl_pos");
                if (ddl_pos.Text == "")
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Posição é obrigatório.');", true);
                    ddl_pos.Focus();
                    return;
                }

                if (ddl_pos.SelectedValue.StartsWith("Murata"))
                {
                    ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Verifique o número de posições da Murata.');", true);
                }
            }
        }

        int i = 0;

        foreach (GridViewRow gvrLancamentoMaquina in gvLancamentoMaquina.Rows)
        {
            CheckBox cbsel = (CheckBox)gvrLancamentoMaquina.FindControl("chk_sel");
            if (cbsel.Checked)
            {
                Label lbMAQ_DES = (Label)gvrLancamentoMaquina.FindControl("lbMAQ_DES");
                Label lbLNC_MAQ_LOT = (Label)gvrLancamentoMaquina.FindControl("lbLNC_MAQ_LOT");
                Label lbLNC_MAQ_PRD = (Label)gvrLancamentoMaquina.FindControl("lbLNC_MAQ_PRD");
                Label lbLNC_MAQ_DES = (Label)gvrLancamentoMaquina.FindControl("lbLNC_MAQ_DES");
                TextBox txt_vrd_ini = (TextBox)gvrLancamentoMaquina.FindControl("txt_vrd_ini");
                TextBox txt_vrd_fim = (TextBox)gvrLancamentoMaquina.FindControl("txt_vrd_fim");
                DropDownList ddl_pos = (DropDownList)gvrLancamentoMaquina.FindControl("ddl_pos");

                geraEtiqueta(lbMAQ_DES.Text, lbLNC_MAQ_LOT.Text, lbLNC_MAQ_PRD.Text, lbLNC_MAQ_DES.Text, Convert.ToInt32(txt_vrd_ini.Text), Convert.ToInt32(txt_vrd_fim.Text), ddl_pos.SelectedValue);

                i++;
            }
        }

        if (i == 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "alert('Selecione Linhas para Impressão.');", true);
        }
        else
        {
            bdyDST_VRD.Attributes.Add("class", "");
            ucBarra.Visible = false;
            dvResultado.Visible = false;
            dvEtiqueta.Visible = true;
            dvEtiqueta.Focus();
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "Alerta", "window.top.frameprincipal.print(); alert('Etiquetas Geradas.');", true);
        }
    }


}