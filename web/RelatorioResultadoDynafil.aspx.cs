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

        if (!IsPostBack)
        {
            FormataControles();
            CarregaControles();
        }

        
    }

    protected void FormataControles()
    {
        txt_mge.Focus();
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_valida_data(this);");

    }

    protected void CarregaControles()
    {
        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "T"; //Somente Texturizados
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_rel);
        dsFornecedor.Dispose();

        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "P"; //Somente POYs
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel);
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
            filtro = filtro + "Titulo= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
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

        txt_mge_rel.Text = txt_mge.Text;
        cbo_for_id_rel.SelectedValue = cbo_for_id.SelectedValue;
        cbo_tit_poy_id_rel.SelectedValue =cbo_tit_poy_id.SelectedValue;
        txt_vlc_rel.Text = txt_vlc.Text;
        txt_dat_ini_rel.Text = txt_dat_ini_rel.Text;
        txt_dat_fim_rel.Text = txt_dat_fim_rel.Text;

        lbl_qtd_ans.Text = "0";
        lbl_qtd_bob.Text = "0";
        txt_tit_min.Text = "";
        txt_tnc_min.Text = "";
        txt_aon_min.Text = "";
        txt_eve_min.Text = "";
        txt_qbr_min.Text = "";
        txt_foa_min.Text = "";
        txt_cvf_min.Text = "";
        txt_tit_med.Text = "";
        txt_tnc_med.Text = "";
        txt_aon_med.Text = "";
        txt_eve_med.Text = "";
        txt_qbr_med.Text = "";
        txt_foa_med.Text = "";
        txt_cvf_med.Text = "";
        txt_tit_max.Text = "";
        txt_tnc_max.Text = "";
        txt_aon_max.Text = "";
        txt_eve_max.Text = "";
        txt_qbr_max.Text = "";
        txt_foa_max.Text = "";
        txt_cvf_max.Text = "";
        txt_tit_dsv.Text = "";
        txt_tnc_dsv.Text = "";
        txt_aon_dsv.Text = "";
        txt_eve_dsv.Text = "";
        txt_qbr_dsv.Text = "";
        txt_foa_dsv.Text = "";
        txt_cvf_dsv.Text = "";

        Dynafil Dynafil = new Dynafil();
        filtro = CriaFiltro(Dynafil);
        if (filtro == "")
        {
            TratamentoErro("O Filtro deve possuir pelo menos um argumento.");
            txt_mge.Focus();
            return;
        }
        DataSet dsDynafil = Dynafil.ConsultarMediaTotal();

        if (dsDynafil.Tables[0].Rows.Count > 0)
        {
            lbl_qtd_ans.Text = dsDynafil.Tables[0].Rows[0]["QTD_ANS"].ToString();
            lbl_qtd_bob.Text = dsDynafil.Tables[0].Rows[0]["QTD_BOB"].ToString();
            txt_tit_min.Text = dsDynafil.Tables[0].Rows[0]["TIT_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["TIT_MED"].ToString()))
            {
                txt_tit_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_tit_med.Text = "0,00";
            }
            txt_tit_max.Text = dsDynafil.Tables[0].Rows[0]["TIT_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["TIT_DSV"].ToString()))
            {
                txt_tit_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["TIT_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_tit_dsv.Text = "0,00";
            }
            txt_tnc_min.Text = dsDynafil.Tables[0].Rows[0]["TNC_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["TNC_MED"].ToString()))
            {
                txt_tnc_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_tnc_med.Text = "0,00";
            }
            txt_tnc_max.Text = dsDynafil.Tables[0].Rows[0]["TNC_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["TNC_DSV"].ToString()))
            {
                txt_tnc_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["TNC_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_tnc_dsv.Text = "0,00";
            }
            txt_aon_min.Text = dsDynafil.Tables[0].Rows[0]["AON_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["AON_MED"].ToString()))
            {
                txt_aon_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_aon_med.Text = "0,00";
            }
            txt_aon_max.Text = dsDynafil.Tables[0].Rows[0]["AON_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["AON_DSV"].ToString()))
            {
                txt_aon_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["AON_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_aon_dsv.Text = "0,00";
            }
            txt_eve_min.Text = dsDynafil.Tables[0].Rows[0]["EVE_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["EVE_MED"].ToString()))
            {
                txt_eve_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["EVE_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_eve_med.Text = "0,00";
            }
            txt_eve_max.Text = dsDynafil.Tables[0].Rows[0]["EVE_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["EVE_DSV"].ToString()))
            {
                txt_eve_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["EVE_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_eve_dsv.Text = "0,00";
            }
            txt_qbr_min.Text = dsDynafil.Tables[0].Rows[0]["QBR_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["QBR_MED"].ToString()))
            {
                txt_qbr_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["QBR_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_qbr_med.Text = "0,00";
            }
            txt_qbr_max.Text = dsDynafil.Tables[0].Rows[0]["QBR_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["QBR_DSV"].ToString()))
            {
                txt_qbr_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["QBR_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_qbr_dsv.Text = "0,00";
            }
            txt_foa_min.Text = dsDynafil.Tables[0].Rows[0]["FOA_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["FOA_MED"].ToString()))
            {
                txt_foa_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["FOA_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_foa_med.Text = "0,00";
            }
            txt_foa_max.Text = dsDynafil.Tables[0].Rows[0]["FOA_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["FOA_DSV"].ToString()))
            {
                txt_foa_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["FOA_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_foa_dsv.Text = "0,00";
            }
            txt_cvf_min.Text = dsDynafil.Tables[0].Rows[0]["CVF_MIN"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["CVF_MED"].ToString()))
            {
                txt_cvf_med.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["CVF_MED"].ToString()).ToString("0.00");
            }
            else
            {
                txt_cvf_med.Text = "0,00";
            }
            txt_cvf_max.Text = dsDynafil.Tables[0].Rows[0]["CVF_MAX"].ToString();
            if (!string.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["CVF_DSV"].ToString()))
            {
                txt_cvf_dsv.Text = Convert.ToDouble(dsDynafil.Tables[0].Rows[0]["CVF_DSV"].ToString()).ToString("0.00");
            }
            else
            {
                txt_cvf_dsv.Text = "0,00";
            }
        }

        dsDynafil.Dispose();
        Dispose();
        
        Dynafil DynafilDados = new Dynafil();
        filtro = CriaFiltro(DynafilDados);
        DataSet dsDynafilDados = Dynafil.ConsultarMedia();
        gvResultadoDynafil.DataSource = dsDynafilDados;
        gvResultadoDynafil.DataBind();
        dsDynafil.Dispose();
        Dispose();

        dvFiltro.Visible = false;
        dvResultadoDynafil.Visible = true;
    }
    
    protected void gvResultadoDynafil_RowDataBound(object sender, GridViewRowEventArgs e)
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
            e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'RelatorioDynafil.aspx?rowId=" + gvResultadoDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvResultadoDynafil.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvResultadoDynafil.Columns.IndexOf(field);
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

    protected void gvResultadoDynafil_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvResultadoDynafil_Sorting(Object sender, GridViewSortEventArgs e)
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
        DataSet dsDynafil = Dynafil.ConsultarMedia();

        DataTable dtDynafil = dsDynafil.Tables[0];
        DataView dvDynafil = new DataView(dtDynafil);
        dvDynafil.Sort = e.SortExpression + Ordem;
        gvResultadoDynafil.DataSource = dvDynafil;
        gvResultadoDynafil.DataBind();

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

}