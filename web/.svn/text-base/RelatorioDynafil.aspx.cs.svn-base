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
            FormataControles();
            CarregaControles();
            CarregaDados();
        }
    }

    protected void FormataControles()
    {
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

        txt_mge.Focus();
    }

    protected void CarregaControles()
    {
        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "P"; //Somente POYs
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        dsFornecedor.Dispose();

        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "P"; //Somente POYs
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        dsTitulo.Dispose();

    }

    protected string CriaFiltro(Dynafil Dynafil)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_mge.Text))
        {
            Dynafil.DNF_MGE = txt_mge.Text;
            filtro = filtro + "Merge= " + txt_mge.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id.Text))
        {
            Dynafil.DNF_FOR_ID = Convert.ToInt32(cbo_for_id.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Dynafil.DNF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_vlc.Text))
        {
            Dynafil.DNF_VLC = txt_vlc.Text;
            filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_ini.Text))
        {
            Dynafil.DNF_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);
            filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            Dynafil.DNF_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Dynafil.DNF_STS = Convert.ToInt32(cbo_sts.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }

        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Dynafil Dynafil = new Dynafil();
        filtro = CriaFiltro(Dynafil);
        DataSet dsDynafil = Dynafil.Consultar();

        gvDynafil.DataSource = dsDynafil;
        gvDynafil.DataBind();
        dsDynafil.Dispose();
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

    protected void CarregaDados()
    {
        if (!string.IsNullOrEmpty(rowId.Value))
        {
            Dynafil Dynafil = new Dynafil();
            Dynafil.DNF_ID = Convert.ToInt32(rowId.Value);
            DataSet dsDynafil = Dynafil.Consultar();
            if (dsDynafil.Tables[0].Rows.Count > 0)
            {
                dv_rel.Visible = true;

                lb_mge_rel.Text = dsDynafil.Tables[0].Rows[0]["DNF_MGE"].ToString();
                lb_for_id_rel.Text = dsDynafil.Tables[0].Rows[0]["FOR_NOM"].ToString();
                lb_tit_poy_id_rel.Text = dsDynafil.Tables[0].Rows[0]["TIT_POY_DES"].ToString();
                lb_vlc_rel.Text = dsDynafil.Tables[0].Rows[0]["DNF_VLC"].ToString();
                lb_dat_rel.Text = Convert.ToDateTime(dsDynafil.Tables[0].Rows[0]["DNF_DAT"].ToString()).ToString("dd/MM/yyyy");

                lb_obs_rel.Text = dsDynafil.Tables[0].Rows[0]["DNF_OBS"].ToString();

                CarregaEspecificacaoDynafil();

                //Apenas 6 posições
                for (int i = 0; i < 6; i++)
                {
                    CarregaItem(i, "tit", dsDynafil);
                    CarregaItem(i, "tnc", dsDynafil);
                    CarregaItem(i, "aon", dsDynafil);
                    CarregaItem(i, "eve", dsDynafil);
                    CarregaItem(i, "qbr", dsDynafil);
                    CarregaItem(i, "foa", dsDynafil);
                    CarregaItem(i, "cvf", dsDynafil);
                }

                Dynafil DynafilDados = new Dynafil();
                DynafilDados.DNF_ID = Convert.ToInt32(rowId.Value);
                DataSet dsDynafilDados = DynafilDados.ConsultarMedia();
                if (dsDynafilDados.Tables[0].Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["TIT_MED"].ToString()))
                    {
                        lb_tit_med.Text = dsDynafilDados.Tables[0].Rows[0]["TIT_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["TNC_MED"].ToString()))
                    {
                        lb_tnc_med.Text = dsDynafilDados.Tables[0].Rows[0]["TNC_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["AON_MED"].ToString()))
                    {
                        lb_aon_med.Text = dsDynafilDados.Tables[0].Rows[0]["AON_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["EVE_MED"].ToString()))
                    {
                        lb_eve_med.Text = dsDynafilDados.Tables[0].Rows[0]["EVE_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["QBR_MED"].ToString()))
                    {
                        lb_qbr_med.Text = dsDynafilDados.Tables[0].Rows[0]["QBR_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["FOA_MED"].ToString()))
                    {
                        lb_foa_med.Text = dsDynafilDados.Tables[0].Rows[0]["FOA_MED"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["CVF_MED"].ToString()))
                    {
                        lb_cvf_med.Text = dsDynafilDados.Tables[0].Rows[0]["CVF_MED"].ToString();
                    }

                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["TIT_DSV"].ToString()))
                    {
                        lb_tit_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["TIT_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["TNC_DSV"].ToString()))
                    {
                        lb_tnc_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["TNC_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["AON_DSV"].ToString()))
                    {
                        lb_aon_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["AON_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["EVE_DSV"].ToString()))
                    {
                        lb_eve_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["EVE_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["QBR_DSV"].ToString()))
                    {
                        lb_qbr_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["QBR_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["FOA_DSV"].ToString()))
                    {
                        lb_foa_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["FOA_DSV"].ToString();
                    }
                    if (!string.IsNullOrEmpty(dsDynafilDados.Tables[0].Rows[0]["CVF_DSV"].ToString()))
                    {
                        lb_cvf_dsv.Text = dsDynafilDados.Tables[0].Rows[0]["CVF_DSV"].ToString();
                    }
                }
                dsDynafilDados.Dispose();

                ConfereLimites();
            }
            else
            {
                lb_filtro.Text = "Não foram encontrados registros de acordo com o filtro.";
            }

            dsDynafil.Dispose();
            Dispose();

            dvFiltro.Visible = false;
            dvResultado.Visible = false;
            dvRelatorio.Visible = true;
        }
    }

    protected void CarregaEspecificacaoDynafil()
    {
        if (!string.IsNullOrEmpty(lb_mge_rel.Text))
        {
            EspecificacaoDynafil EspecificacaoDynafil = new EspecificacaoDynafil();
            EspecificacaoDynafil.EDF_MGE = lb_mge_rel.Text;
            DataSet dsEspecificacaoDynafil = EspecificacaoDynafil.Consultar();

            if (dsEspecificacaoDynafil.Tables[0].Rows.Count > 0)
            {
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MED"].ToString()))
                {
                    lb_tit_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MIN"].ToString()))
                {
                    lb_tit_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MAX"].ToString()))
                {
                    lb_tit_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TIT_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MED"].ToString()))
                {
                    lb_tnc_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MIN"].ToString()))
                {
                    lb_tnc_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MAX"].ToString()))
                {
                    lb_tnc_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_TNC_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MED"].ToString()))
                {
                    lb_aon_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MIN"].ToString()))
                {
                    lb_aon_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MAX"].ToString()))
                {
                    lb_aon_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_AON_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MED"].ToString()))
                {
                    lb_eve_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MIN"].ToString()))
                {
                    lb_eve_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MAX"].ToString()))
                {
                    lb_eve_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_EVE_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MED"].ToString()))
                {
                    lb_qbr_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MIN"].ToString()))
                {
                    lb_qbr_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MAX"].ToString()))
                {
                    lb_qbr_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_QBR_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MED"].ToString()))
                {
                    lb_foa_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MIN"].ToString()))
                {
                    lb_foa_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MAX"].ToString()))
                {
                    lb_foa_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_FOA_MAX"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MED"].ToString()))
                {
                    lb_cvf_med_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MED"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MIN"].ToString()))
                {
                    lb_cvf_min_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MIN"].ToString();
                }
                if (!string.IsNullOrEmpty(dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MAX"].ToString()))
                {
                    lb_cvf_max_esp.Text = dsEspecificacaoDynafil.Tables[0].Rows[0]["EDF_CVF_MAX"].ToString();
                }
            }

            dsEspecificacaoDynafil.Dispose();
            Dispose();
        }
    }

    private void CarregaItem(int i, string sItem, DataSet dsDynafil)
    {
        if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["DNF_" + sItem.ToUpper() + "_" + (i + 1).ToString("000")].ToString()))
        {
            Label lb_item = (Label)dvResultado.FindControl("lb_" + sItem + "_" + (i + 1).ToString("000"));
            lb_item.Text = dsDynafil.Tables[0].Rows[0]["DNF_" + sItem.ToUpper() + "_" + (i + 1).ToString("000")].ToString();

            Label lb_item_min = (Label)dvResultado.FindControl("lb_" + sItem + "_min_esp");
            Label lb_item_max = (Label)dvResultado.FindControl("lb_" + sItem + "_max_esp");
        }
    }

    protected void ConfereLimites()
    {
        ConfereItem("tit");
        ConfereItem("tnc");
        ConfereItem("aon");
        ConfereItem("eve");
        ConfereItem("qbr");
        ConfereItem("foa");
        ConfereItem("cvf");
    }

    private void ConfereItem(string sItem)
    {
        double n;

        Label lb_item_med = (Label)FindControl("lb_" + sItem + "_med_esp");
        Label lb_item_min = (Label)FindControl("lb_" + sItem + "_min_esp");
        Label lb_item_max = (Label)FindControl("lb_" + sItem + "_max_esp");

        if (Double.TryParse(lb_item_min.Text, out n) && Double.TryParse(lb_item_max.Text, out n))
        {
            /*
            for (int i = 0; i < 6; i++)
            {
                Label lb_item = (Label)FindControl("lb_" + sItem + "_" + (i + 1).ToString("000"));

                if (Double.TryParse(lb_item.Text, out n))
                {
                    //Response.Write(lb_item.ID + ";" + lb_item.Text + ";" + lb_item_min.Text + ";" + lb_item_max.Text + ";<br/>");
                    Label lb_status = (Label)FindControl("lb_" + sItem + "_sts" + "_" + (i + 1).ToString("000"));

                    if ((Convert.ToDouble(lb_item.Text) < Convert.ToDouble(lb_item_med.Text)) || (Convert.ToDouble(lb_item.Text) > Convert.ToDouble(lb_item_med.Text)))
                    {
                        lb_status.Text = "Alerta";
                    }

                    if ((Convert.ToDouble(lb_item.Text) < Convert.ToDouble(lb_item_min.Text)) || (Convert.ToDouble(lb_item.Text) > Convert.ToDouble(lb_item_max.Text)))
                    {
                        lb_status.ForeColor = System.Drawing.Color.Red;
                        lb_status.Text = "Fora";
                    }
                }
            }
            */

            Label lb_med = (Label)FindControl("lb_" + sItem + "_med");
            Label lb_sts_med = (Label)FindControl("lb_" + sItem + "_sts_med");
            Label lb_dsv = (Label)FindControl("lb_" + sItem + "_dsv");
            Label lb_sts_dsv = (Label)FindControl("lb_" + sItem + "_sts_dsv");

            Label lb_med_esp = (Label)FindControl("lb_" + sItem + "_med_esp");

            //Response.Write("lb_" + sItem + "_med;" + lb_med.Text + ";" + "lb_" + sItem + "_sts_med;" + lb_sts_med.Text + ";" + lb_item_min.Text + ";" + lb_item_max.Text + ";<br/>");
            if (Double.TryParse(lb_med.Text, out n))
            {
                if ((Convert.ToDouble(lb_med.Text) < Convert.ToDouble(lb_item_min.Text)) || (Convert.ToDouble(lb_med.Text) > Convert.ToDouble(lb_item_max.Text)))
                {
                    lb_sts_med.Text = "Alerta";
                }
            }
        }
    }

    protected void gvDynafil_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.className='selecionado';");
            if ((e.Row.RowIndex % 2) == 0)
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_par';");
            }
            else
            {
                e.Row.Attributes.Add("onMouseOut", "this.className='linha_impar';");
            }
            e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'RelatorioDynafil.aspx?rowId=" + gvDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvDynafil.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvDynafil.Columns.IndexOf(field);
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

    protected void gvDynafil_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvDynafil_Sorting(Object sender, GridViewSortEventArgs e)
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

        Dynafil Dynafil = new Dynafil();
        filtro = CriaFiltro(Dynafil);
        DataSet dsDynafil = Dynafil.Consultar();

        DataTable dtDynafil = dsDynafil.Tables[0];
        DataView dvDynafil = new DataView(dtDynafil);
        dvDynafil.Sort = e.SortExpression + Ordem;
        gvDynafil.DataSource = dvDynafil;
        gvDynafil.DataBind();

        dvDynafil.Dispose();
        dtDynafil.Dispose();
        dsDynafil.Dispose();
        Dispose();
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }


    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvDynafil.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=Lista.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDynafil.AllowSorting = false;
            gvDynafil.AllowPaging = false;
            //gvDynafil.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            for (int i = 0; i < gvDynafil.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvDynafil.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvDynafil.RenderControl(htmlWrite);

            StringReader stringReader = new StringReader(stringWrite.ToString());
            Document pdfDocument = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            HTMLWorker htmlParser = new HTMLWorker(pdfDocument);
            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);
            pdfDocument.Open();
            htmlParser.Parse(stringReader);
            pdfDocument.Close();
            Response.Write(pdfDocument);
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }

    protected void lkb_xls_Click(object sender, EventArgs e)
    {
        if (gvDynafil.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=Lista.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDynafil.AllowSorting = false;
            gvDynafil.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens

            for (int i = 0; i < gvDynafil.HeaderRow.Cells.Count; i++)
            {
                LinkButton lnk = (LinkButton)gvDynafil.HeaderRow.Cells[i].Controls[0];
                lnk.Enabled = false;
                lnk.BackColor = System.Drawing.Color.White;
                lnk.ForeColor = System.Drawing.Color.Black;
            }

            gvDynafil.RenderControl(htmlWrite);

            Response.Write(stringWrite.ToString());
            Response.End();
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('Não há registros para exportação !');", true);
        }
    }

    public override void VerifyRenderingInServerForm(Control control)
    {

    }

}