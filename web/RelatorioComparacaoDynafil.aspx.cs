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

using System.Drawing;

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
        txt_mge_001.Focus();
    }

    protected void CarregaControles()
    {
        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "P"; //Somente POYs
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_001);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_rel_001);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_002);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_rel_002);
        dsFornecedor.Dispose();

        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "P"; //Somente POYs
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_001);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel_001);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_002);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_rel_002);
        dsTitulo.Dispose();
    }

    protected string CriaFiltro001(Dynafil Dynafil)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_mge_001.Text))
        {
            Dynafil.DNF_MGE = txt_mge_001.Text;
            filtro = filtro + "Merge= " + txt_mge_001.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id_001.Text))
        {
            Dynafil.DNF_FOR_ID = Convert.ToInt32(cbo_for_id_001.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id_001.Text))
        {
            Dynafil.DNF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_001.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id_001.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts_001.Text))
        {
            Dynafil.DNF_STS = Convert.ToInt32(cbo_sts_001.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts_001.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected string CriaFiltro002(Dynafil Dynafil)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_mge_002.Text))
        {
            Dynafil.DNF_MGE = txt_mge_002.Text;
            filtro = filtro + "Merge= " + txt_mge_002.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_for_id_002.Text))
        {
            Dynafil.DNF_FOR_ID = Convert.ToInt32(cbo_for_id_002.SelectedValue);
            filtro = filtro + "Fornecedor= " + cbo_for_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id_002.Text))
        {
            Dynafil.DNF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_002.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id_002.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts_002.Text))
        {
            Dynafil.DNF_STS = Convert.ToInt32(cbo_sts_002.SelectedValue);
            filtro = filtro + "Status= " + cbo_sts_002.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Dynafil DynafilMedia001 = new Dynafil();
        filtro = CriaFiltro001(DynafilMedia001);
        DataSet dsDynafilMedia001 = DynafilMedia001.ConsultarMediaTotal();

        if (dsDynafilMedia001.Tables[0].Rows.Count > 0)
        {
            txt_mge_rel_001.Text = txt_mge_001.Text;
            cbo_for_id_rel_001.SelectedValue = cbo_for_id_001.SelectedValue;
            cbo_tit_poy_id_rel_001.SelectedValue = cbo_tit_poy_id_001.SelectedValue;

            lbl_num_001.Text = dsDynafilMedia001.Tables[0].Rows[0]["QTD_ANS"].ToString();

            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MED"].ToString()))
            {
                txt_tit_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MED"].ToString()))
            {
                txt_tnc_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["AON_MED"].ToString()))
            {
                txt_aon_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MED"].ToString()))
            {
                txt_eve_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MED"].ToString()))
            {
                txt_qbr_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MED"].ToString()))
            {
                txt_foa_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MED"].ToString()))
            {
                txt_cvf_med_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MED"].ToString()).ToString("0.0000");
            }

 
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MIN"].ToString()))
            {
                txt_tit_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MIN"].ToString()))
            {
                txt_tnc_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["AON_MIN"].ToString()))
            {
                txt_aon_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["AON_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MIN"].ToString()))
            {
                txt_eve_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MIN"].ToString()))
            {
                txt_qbr_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MIN"].ToString()))
            {
                txt_foa_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MIN"].ToString()))
            {
                txt_cvf_min_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MIN"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MAX"].ToString()))
            {
                txt_tit_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TIT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MAX"].ToString()))
            {
                txt_tnc_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TNC_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["AON_MAX"].ToString()))
            {
                txt_aon_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["AON_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MAX"].ToString()))
            {
                txt_eve_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["EVE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MAX"].ToString()))
            {
                txt_qbr_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["QBR_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MAX"].ToString()))
            {
                txt_foa_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["FOA_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MAX"].ToString()))
            {
                txt_cvf_max_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["CVF_MAX"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TIT_DSV"].ToString()))
            {
                txt_tit_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TIT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["TNC_DSV"].ToString()))
            {
                txt_tnc_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["TNC_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["AON_DSV"].ToString()))
            {
                txt_aon_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["AON_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["EVE_DSV"].ToString()))
            {
                txt_eve_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["EVE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["QBR_DSV"].ToString()))
            {
                txt_qbr_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["QBR_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["FOA_DSV"].ToString()))
            {
                txt_foa_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["FOA_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia001.Tables[0].Rows[0]["CVF_DSV"].ToString()))
            {
                txt_cvf_dsv_001.Text = Convert.ToDouble(dsDynafilMedia001.Tables[0].Rows[0]["CVF_DSV"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_001.Text) && !string.IsNullOrEmpty(txt_tit_dsv_001.Text))
            {
                txt_tit_int_inf_001.Text = (Convert.ToDouble(txt_tit_med_001.Text) - (1.96 * (Convert.ToDouble(txt_tit_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_001.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_001.Text))
            {
                txt_tnc_int_inf_001.Text = (Convert.ToDouble(txt_tnc_med_001.Text) - (1.96 * (Convert.ToDouble(txt_tnc_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_001.Text) && !string.IsNullOrEmpty(txt_aon_dsv_001.Text))
            {
                txt_aon_int_inf_001.Text = (Convert.ToDouble(txt_aon_med_001.Text) - (1.96 * (Convert.ToDouble(txt_aon_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eve_med_001.Text) && !string.IsNullOrEmpty(txt_eve_dsv_001.Text))
            {
                txt_eve_int_inf_001.Text = (Convert.ToDouble(txt_eve_med_001.Text) - (1.96 * (Convert.ToDouble(txt_eve_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_qbr_med_001.Text) && !string.IsNullOrEmpty(txt_qbr_dsv_001.Text))
            {
                txt_qbr_int_inf_001.Text = (Convert.ToDouble(txt_qbr_med_001.Text) - (1.96 * (Convert.ToDouble(txt_qbr_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_foa_med_001.Text) && !string.IsNullOrEmpty(txt_foa_dsv_001.Text))
            {
                txt_foa_int_inf_001.Text = (Convert.ToDouble(txt_foa_med_001.Text) - (1.96 * (Convert.ToDouble(txt_foa_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_cvf_med_001.Text) && !string.IsNullOrEmpty(txt_cvf_dsv_001.Text))
            {
                txt_cvf_int_inf_001.Text = (Convert.ToDouble(txt_cvf_med_001.Text) - (1.96 * (Convert.ToDouble(txt_cvf_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_001.Text) && !string.IsNullOrEmpty(txt_tit_dsv_001.Text))
            {
                txt_tit_int_sup_001.Text = (Convert.ToDouble(txt_tit_med_001.Text) + (1.96 * (Convert.ToDouble(txt_tit_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_001.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_001.Text))
            {
                txt_tnc_int_sup_001.Text = (Convert.ToDouble(txt_tnc_med_001.Text) + (1.96 * (Convert.ToDouble(txt_tnc_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_001.Text) && !string.IsNullOrEmpty(txt_aon_dsv_001.Text))
            {
                txt_aon_int_sup_001.Text = (Convert.ToDouble(txt_aon_med_001.Text) + (1.96 * (Convert.ToDouble(txt_aon_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eve_med_001.Text) && !string.IsNullOrEmpty(txt_eve_dsv_001.Text))
            {
                txt_eve_int_sup_001.Text = (Convert.ToDouble(txt_eve_med_001.Text) + (1.96 * (Convert.ToDouble(txt_eve_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_qbr_med_001.Text) && !string.IsNullOrEmpty(txt_qbr_dsv_001.Text))
            {
                txt_qbr_int_sup_001.Text = (Convert.ToDouble(txt_qbr_med_001.Text) + (1.96 * (Convert.ToDouble(txt_qbr_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_foa_med_001.Text) && !string.IsNullOrEmpty(txt_foa_dsv_001.Text))
            {
                txt_foa_int_sup_001.Text = (Convert.ToDouble(txt_foa_med_001.Text) + (1.96 * (Convert.ToDouble(txt_foa_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_cvf_med_001.Text) && !string.IsNullOrEmpty(txt_cvf_dsv_001.Text))
            {
                txt_cvf_int_sup_001.Text = (Convert.ToDouble(txt_cvf_med_001.Text) + (1.96 * (Convert.ToDouble(txt_cvf_dsv_001.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_001.Text))))).ToString("0.00");
            }
        }
        dsDynafilMedia001.Dispose();

        Dynafil DynafilMedia002 = new Dynafil();
        filtro = CriaFiltro002(DynafilMedia002);
        DataSet dsDynafilMedia002 = DynafilMedia002.ConsultarMediaTotal();

        if (dsDynafilMedia002.Tables[0].Rows.Count > 0)
        {
            txt_mge_rel_002.Text = txt_mge_002.Text;
            cbo_for_id_rel_002.SelectedValue = cbo_for_id_002.SelectedValue;
            cbo_tit_poy_id_rel_002.SelectedValue = cbo_tit_poy_id_002.SelectedValue;

            lbl_num_002.Text = dsDynafilMedia002.Tables[0].Rows[0]["QTD_ANS"].ToString();

            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MED"].ToString()))
            {
                txt_tit_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MED"].ToString()))
            {
                txt_tnc_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["AON_MED"].ToString()))
            {
                txt_aon_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["AON_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MED"].ToString()))
            {
                txt_eve_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MED"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MED"].ToString()))
            {
                txt_qbr_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MED"].ToString()))
            {
                txt_foa_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MED"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MED"].ToString()))
            {
                txt_cvf_med_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MED"].ToString()).ToString("0.0000");
            }


            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MIN"].ToString()))
            {
                txt_tit_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MIN"].ToString()))
            {
                txt_tnc_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["AON_MIN"].ToString()))
            {
                txt_aon_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["AON_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MIN"].ToString()))
            {
                txt_eve_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MIN"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MIN"].ToString()))
            {
                txt_qbr_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MIN"].ToString()))
            {
                txt_foa_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MIN"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MIN"].ToString()))
            {
                txt_cvf_min_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MIN"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MAX"].ToString()))
            {
                txt_tit_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TIT_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MAX"].ToString()))
            {
                txt_tnc_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TNC_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["AON_MAX"].ToString()))
            {
                txt_aon_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["AON_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MAX"].ToString()))
            {
                txt_eve_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["EVE_MAX"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MAX"].ToString()))
            {
                txt_qbr_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["QBR_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MAX"].ToString()))
            {
                txt_foa_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["FOA_MAX"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MAX"].ToString()))
            {
                txt_cvf_max_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["CVF_MAX"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TIT_DSV"].ToString()))
            {
                txt_tit_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TIT_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["TNC_DSV"].ToString()))
            {
                txt_tnc_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["TNC_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["AON_DSV"].ToString()))
            {
                txt_aon_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["AON_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["EVE_DSV"].ToString()))
            {
                txt_eve_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["EVE_DSV"].ToString()).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["QBR_DSV"].ToString()))
            {
                txt_qbr_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["QBR_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["FOA_DSV"].ToString()))
            {
                txt_foa_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["FOA_DSV"].ToString()).ToString("0.0000");
            }
            if (!string.IsNullOrEmpty(dsDynafilMedia002.Tables[0].Rows[0]["CVF_DSV"].ToString()))
            {
                txt_cvf_dsv_002.Text = Convert.ToDouble(dsDynafilMedia002.Tables[0].Rows[0]["CVF_DSV"].ToString()).ToString("0.0000");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_002.Text) && !string.IsNullOrEmpty(txt_tit_dsv_002.Text))
            {
                txt_tit_int_inf_002.Text = (Convert.ToDouble(txt_tit_med_002.Text) - (1.96 * (Convert.ToDouble(txt_tit_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_002.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_002.Text))
            {
                txt_tnc_int_inf_002.Text = (Convert.ToDouble(txt_tnc_med_002.Text) - (1.96 * (Convert.ToDouble(txt_tnc_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_002.Text) && !string.IsNullOrEmpty(txt_aon_dsv_002.Text))
            {
                txt_aon_int_inf_002.Text = (Convert.ToDouble(txt_aon_med_002.Text) - (1.96 * (Convert.ToDouble(txt_aon_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eve_med_002.Text) && !string.IsNullOrEmpty(txt_eve_dsv_002.Text))
            {
                txt_eve_int_inf_002.Text = (Convert.ToDouble(txt_eve_med_002.Text) - (1.96 * (Convert.ToDouble(txt_eve_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_qbr_med_002.Text) && !string.IsNullOrEmpty(txt_qbr_dsv_002.Text))
            {
                txt_qbr_int_inf_002.Text = (Convert.ToDouble(txt_qbr_med_002.Text) - (1.96 * (Convert.ToDouble(txt_qbr_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_foa_med_002.Text) && !string.IsNullOrEmpty(txt_foa_dsv_002.Text))
            {
                txt_foa_int_inf_002.Text = (Convert.ToDouble(txt_foa_med_002.Text) - (1.96 * (Convert.ToDouble(txt_foa_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_cvf_med_002.Text) && !string.IsNullOrEmpty(txt_cvf_dsv_002.Text))
            {
                txt_cvf_int_inf_002.Text = (Convert.ToDouble(txt_cvf_med_002.Text) - (1.96 * (Convert.ToDouble(txt_cvf_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }

            if (!string.IsNullOrEmpty(txt_tit_med_002.Text) && !string.IsNullOrEmpty(txt_tit_dsv_002.Text))
            {
                txt_tit_int_sup_002.Text = (Convert.ToDouble(txt_tit_med_002.Text) + (1.96 * (Convert.ToDouble(txt_tit_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_tnc_med_002.Text) && !string.IsNullOrEmpty(txt_tnc_dsv_002.Text))
            {
                txt_tnc_int_sup_002.Text = (Convert.ToDouble(txt_tnc_med_002.Text) + (1.96 * (Convert.ToDouble(txt_tnc_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_aon_med_002.Text) && !string.IsNullOrEmpty(txt_aon_dsv_002.Text))
            {
                txt_aon_int_sup_002.Text = (Convert.ToDouble(txt_aon_med_002.Text) + (1.96 * (Convert.ToDouble(txt_aon_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_eve_med_002.Text) && !string.IsNullOrEmpty(txt_eve_dsv_002.Text))
            {
                txt_eve_int_sup_002.Text = (Convert.ToDouble(txt_eve_med_002.Text) + (1.96 * (Convert.ToDouble(txt_eve_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_qbr_med_002.Text) && !string.IsNullOrEmpty(txt_qbr_dsv_002.Text))
            {
                txt_qbr_int_sup_002.Text = (Convert.ToDouble(txt_qbr_med_002.Text) + (1.96 * (Convert.ToDouble(txt_qbr_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_foa_med_002.Text) && !string.IsNullOrEmpty(txt_foa_dsv_002.Text))
            {
                txt_foa_int_sup_002.Text = (Convert.ToDouble(txt_foa_med_002.Text) + (1.96 * (Convert.ToDouble(txt_foa_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
            if (!string.IsNullOrEmpty(txt_cvf_med_002.Text) && !string.IsNullOrEmpty(txt_cvf_dsv_002.Text))
            {
                txt_cvf_int_sup_002.Text = (Convert.ToDouble(txt_cvf_med_002.Text) + (1.96 * (Convert.ToDouble(txt_cvf_dsv_002.Text) / Math.Sqrt(Convert.ToInt32(lbl_num_002.Text))))).ToString("0.00");
            }
        }
        dsDynafilMedia002.Dispose();

        if (!string.IsNullOrEmpty(txt_tit_int_inf_001.Text) && !string.IsNullOrEmpty(txt_tit_int_sup_001.Text) && !string.IsNullOrEmpty(txt_tit_int_inf_002.Text) && !string.IsNullOrEmpty(txt_tit_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_tit_int_inf_001.Text) >= Convert.ToDouble(txt_tit_int_inf_002.Text) && Convert.ToDouble(txt_tit_int_inf_001.Text) <= Convert.ToDouble(txt_tit_int_sup_002.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_sup_001.Text) >= Convert.ToDouble(txt_tit_int_inf_002.Text) && Convert.ToDouble(txt_tit_int_sup_001.Text) <= Convert.ToDouble(txt_tit_int_sup_002.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_inf_002.Text) >= Convert.ToDouble(txt_tit_int_inf_001.Text) && Convert.ToDouble(txt_tit_int_inf_002.Text) <= Convert.ToDouble(txt_tit_int_sup_001.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tit_int_sup_002.Text) >= Convert.ToDouble(txt_tit_int_inf_001.Text) && Convert.ToDouble(txt_tit_int_sup_002.Text) <= Convert.ToDouble(txt_tit_int_sup_001.Text))
            {
                txt_tit_com.ForeColor = Color.Green;
                txt_tit_com.Text = "=";
            }
            else
            {
                txt_tit_com.ForeColor = Color.Red;
                txt_tit_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_tnc_int_inf_001.Text) && !string.IsNullOrEmpty(txt_tnc_int_sup_001.Text) && !string.IsNullOrEmpty(txt_tnc_int_inf_002.Text) && !string.IsNullOrEmpty(txt_tnc_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_tnc_int_inf_001.Text) >= Convert.ToDouble(txt_tnc_int_inf_002.Text) && Convert.ToDouble(txt_tnc_int_inf_001.Text) <= Convert.ToDouble(txt_tnc_int_sup_002.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_sup_001.Text) >= Convert.ToDouble(txt_tnc_int_inf_002.Text) && Convert.ToDouble(txt_tnc_int_sup_001.Text) <= Convert.ToDouble(txt_tnc_int_sup_002.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_inf_002.Text) >= Convert.ToDouble(txt_tnc_int_inf_001.Text) && Convert.ToDouble(txt_tnc_int_inf_002.Text) <= Convert.ToDouble(txt_tnc_int_sup_001.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_tnc_int_sup_002.Text) >= Convert.ToDouble(txt_tnc_int_inf_001.Text) && Convert.ToDouble(txt_tnc_int_sup_002.Text) <= Convert.ToDouble(txt_tnc_int_sup_001.Text))
            {
                txt_tnc_com.ForeColor = Color.Green;
                txt_tnc_com.Text = "=";
            }
            else
            {
                txt_tnc_com.ForeColor = Color.Red;
                txt_tnc_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_aon_int_inf_001.Text) && !string.IsNullOrEmpty(txt_aon_int_sup_001.Text) && !string.IsNullOrEmpty(txt_aon_int_inf_002.Text) && !string.IsNullOrEmpty(txt_aon_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_aon_int_inf_001.Text) >= Convert.ToDouble(txt_aon_int_inf_002.Text) && Convert.ToDouble(txt_aon_int_inf_001.Text) <= Convert.ToDouble(txt_aon_int_sup_002.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_sup_001.Text) >= Convert.ToDouble(txt_aon_int_inf_002.Text) && Convert.ToDouble(txt_aon_int_sup_001.Text) <= Convert.ToDouble(txt_aon_int_sup_002.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_inf_002.Text) >= Convert.ToDouble(txt_aon_int_inf_001.Text) && Convert.ToDouble(txt_aon_int_inf_002.Text) <= Convert.ToDouble(txt_aon_int_sup_001.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_aon_int_sup_002.Text) >= Convert.ToDouble(txt_aon_int_inf_001.Text) && Convert.ToDouble(txt_aon_int_sup_002.Text) <= Convert.ToDouble(txt_aon_int_sup_001.Text))
            {
                txt_aon_com.ForeColor = Color.Green;
                txt_aon_com.Text = "=";
            }
            else
            {
                txt_aon_com.ForeColor = Color.Red;
                txt_aon_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_eve_int_inf_001.Text) && !string.IsNullOrEmpty(txt_eve_int_sup_001.Text) && !string.IsNullOrEmpty(txt_eve_int_inf_002.Text) && !string.IsNullOrEmpty(txt_eve_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_eve_int_inf_001.Text) >= Convert.ToDouble(txt_eve_int_inf_002.Text) && Convert.ToDouble(txt_eve_int_inf_001.Text) <= Convert.ToDouble(txt_eve_int_sup_002.Text))
            {
                txt_eve_com.ForeColor = Color.Green;
                txt_eve_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eve_int_sup_001.Text) >= Convert.ToDouble(txt_eve_int_inf_002.Text) && Convert.ToDouble(txt_eve_int_sup_001.Text) <= Convert.ToDouble(txt_eve_int_sup_002.Text))
            {
                txt_eve_com.ForeColor = Color.Green;
                txt_eve_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eve_int_inf_002.Text) >= Convert.ToDouble(txt_eve_int_inf_001.Text) && Convert.ToDouble(txt_eve_int_inf_002.Text) <= Convert.ToDouble(txt_eve_int_sup_001.Text))
            {
                txt_eve_com.ForeColor = Color.Green;
                txt_eve_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_eve_int_sup_002.Text) >= Convert.ToDouble(txt_eve_int_inf_001.Text) && Convert.ToDouble(txt_eve_int_sup_002.Text) <= Convert.ToDouble(txt_eve_int_sup_001.Text))
            {
                txt_eve_com.ForeColor = Color.Green;
                txt_eve_com.Text = "=";
            }
            else
            {
                txt_eve_com.ForeColor = Color.Red;
                txt_eve_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_qbr_int_inf_001.Text) && !string.IsNullOrEmpty(txt_qbr_int_sup_001.Text) && !string.IsNullOrEmpty(txt_qbr_int_inf_002.Text) && !string.IsNullOrEmpty(txt_qbr_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_qbr_int_inf_001.Text) >= Convert.ToDouble(txt_qbr_int_inf_002.Text) && Convert.ToDouble(txt_qbr_int_inf_001.Text) <= Convert.ToDouble(txt_qbr_int_sup_002.Text))
            {
                txt_qbr_com.ForeColor = Color.Green;
                txt_qbr_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_qbr_int_sup_001.Text) >= Convert.ToDouble(txt_qbr_int_inf_002.Text) && Convert.ToDouble(txt_qbr_int_sup_001.Text) <= Convert.ToDouble(txt_qbr_int_sup_002.Text))
            {
                txt_qbr_com.ForeColor = Color.Green;
                txt_qbr_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_qbr_int_inf_002.Text) >= Convert.ToDouble(txt_qbr_int_inf_001.Text) && Convert.ToDouble(txt_qbr_int_inf_002.Text) <= Convert.ToDouble(txt_qbr_int_sup_001.Text))
            {
                txt_qbr_com.ForeColor = Color.Green;
                txt_qbr_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_qbr_int_sup_002.Text) >= Convert.ToDouble(txt_qbr_int_inf_001.Text) && Convert.ToDouble(txt_qbr_int_sup_002.Text) <= Convert.ToDouble(txt_qbr_int_sup_001.Text))
            {
                txt_qbr_com.ForeColor = Color.Green;
                txt_qbr_com.Text = "=";
            }
            else
            {
                txt_qbr_com.ForeColor = Color.Red;
                txt_qbr_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_foa_int_inf_001.Text) && !string.IsNullOrEmpty(txt_foa_int_sup_001.Text) && !string.IsNullOrEmpty(txt_foa_int_inf_002.Text) && !string.IsNullOrEmpty(txt_foa_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_foa_int_inf_001.Text) >= Convert.ToDouble(txt_foa_int_inf_002.Text) && Convert.ToDouble(txt_foa_int_inf_001.Text) <= Convert.ToDouble(txt_foa_int_sup_002.Text))
            {
                txt_foa_com.ForeColor = Color.Green;
                txt_foa_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_foa_int_sup_001.Text) >= Convert.ToDouble(txt_foa_int_inf_002.Text) && Convert.ToDouble(txt_foa_int_sup_001.Text) <= Convert.ToDouble(txt_foa_int_sup_002.Text))
            {
                txt_foa_com.ForeColor = Color.Green;
                txt_foa_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_foa_int_inf_002.Text) >= Convert.ToDouble(txt_foa_int_inf_001.Text) && Convert.ToDouble(txt_foa_int_inf_002.Text) <= Convert.ToDouble(txt_foa_int_sup_001.Text))
            {
                txt_foa_com.ForeColor = Color.Green;
                txt_foa_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_foa_int_sup_002.Text) >= Convert.ToDouble(txt_foa_int_inf_001.Text) && Convert.ToDouble(txt_foa_int_sup_002.Text) <= Convert.ToDouble(txt_foa_int_sup_001.Text))
            {
                txt_foa_com.ForeColor = Color.Green;
                txt_foa_com.Text = "=";
            }
            else
            {
                txt_foa_com.ForeColor = Color.Red;
                txt_foa_com.Text = "<>";
            }
        }
        if (!string.IsNullOrEmpty(txt_cvf_int_inf_001.Text) && !string.IsNullOrEmpty(txt_cvf_int_sup_001.Text) && !string.IsNullOrEmpty(txt_cvf_int_inf_002.Text) && !string.IsNullOrEmpty(txt_cvf_int_sup_002.Text))
        {
            if (Convert.ToDouble(txt_cvf_int_inf_001.Text) >= Convert.ToDouble(txt_cvf_int_inf_002.Text) && Convert.ToDouble(txt_cvf_int_inf_001.Text) <= Convert.ToDouble(txt_cvf_int_sup_002.Text))
            {
                txt_cvf_com.ForeColor = Color.Green;
                txt_cvf_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_cvf_int_sup_001.Text) >= Convert.ToDouble(txt_cvf_int_inf_002.Text) && Convert.ToDouble(txt_cvf_int_sup_001.Text) <= Convert.ToDouble(txt_cvf_int_sup_002.Text))
            {
                txt_cvf_com.ForeColor = Color.Green;
                txt_cvf_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_cvf_int_inf_002.Text) >= Convert.ToDouble(txt_cvf_int_inf_001.Text) && Convert.ToDouble(txt_cvf_int_inf_002.Text) <= Convert.ToDouble(txt_cvf_int_sup_001.Text))
            {
                txt_cvf_com.ForeColor = Color.Green;
                txt_cvf_com.Text = "=";
            }
            else if (Convert.ToDouble(txt_cvf_int_sup_002.Text) >= Convert.ToDouble(txt_cvf_int_inf_001.Text) && Convert.ToDouble(txt_cvf_int_sup_002.Text) <= Convert.ToDouble(txt_cvf_int_sup_001.Text))
            {
                txt_cvf_com.ForeColor = Color.Green;
                txt_cvf_com.Text = "=";
            }
            else
            {
                txt_cvf_com.ForeColor = Color.Red;
                txt_cvf_com.Text = "<>";
            }
        }

        if ((txt_tit_med_001.Text != txt_tit_med_002.Text) && (!string.IsNullOrEmpty(txt_tit_med_002.Text)) && (!string.IsNullOrEmpty(txt_tit_med_001.Text)))
        {
            txt_tit_dif.Text = ((Convert.ToDouble(txt_tit_med_002.Text) - Convert.ToDouble(txt_tit_med_001.Text)) / Convert.ToDouble(txt_tit_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_tnc_med_001.Text != txt_tnc_med_002.Text) && (!string.IsNullOrEmpty(txt_tnc_med_002.Text)) && (!string.IsNullOrEmpty(txt_tnc_med_001.Text)))
        {
            txt_tnc_dif.Text = ((Convert.ToDouble(txt_tnc_med_002.Text) - Convert.ToDouble(txt_tnc_med_001.Text)) / Convert.ToDouble(txt_tnc_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_aon_med_001.Text != txt_aon_med_002.Text) && (!string.IsNullOrEmpty(txt_aon_med_002.Text)) && (!string.IsNullOrEmpty(txt_aon_med_001.Text)))
        {
            txt_aon_dif.Text = ((Convert.ToDouble(txt_aon_med_002.Text) - Convert.ToDouble(txt_aon_med_001.Text)) / Convert.ToDouble(txt_aon_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_eve_med_001.Text != txt_eve_med_002.Text) && (!string.IsNullOrEmpty(txt_eve_med_002.Text)) && (!string.IsNullOrEmpty(txt_eve_med_001.Text)))
        {
            txt_eve_dif.Text = ((Convert.ToDouble(txt_eve_med_002.Text) - Convert.ToDouble(txt_eve_med_001.Text)) / Convert.ToDouble(txt_eve_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_qbr_med_001.Text != txt_qbr_med_002.Text) && (!string.IsNullOrEmpty(txt_qbr_med_002.Text)) && (!string.IsNullOrEmpty(txt_qbr_med_001.Text)))
        {
            txt_qbr_dif.Text = ((Convert.ToDouble(txt_qbr_med_002.Text) - Convert.ToDouble(txt_qbr_med_001.Text)) / Convert.ToDouble(txt_qbr_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_foa_med_001.Text != txt_foa_med_002.Text) && (!string.IsNullOrEmpty(txt_foa_med_002.Text)) && (!string.IsNullOrEmpty(txt_foa_med_001.Text)))
        {
            txt_foa_dif.Text = ((Convert.ToDouble(txt_foa_med_002.Text) - Convert.ToDouble(txt_foa_med_001.Text)) / Convert.ToDouble(txt_foa_med_002.Text)).ToString("0.00 %");
        }
        if ((txt_cvf_med_001.Text != txt_cvf_med_002.Text) && (!string.IsNullOrEmpty(txt_cvf_med_002.Text)) && (!string.IsNullOrEmpty(txt_cvf_med_001.Text)))
        {
            txt_cvf_dif.Text = ((Convert.ToDouble(txt_cvf_med_002.Text) - Convert.ToDouble(txt_cvf_med_001.Text)) / Convert.ToDouble(txt_cvf_med_002.Text)).ToString("0.00 %");
        }

        Dispose();

        ///* Não apresentar filtros e barra de identificação 
        // * pois o relatório é impresso e enviado ao cliente

        /*        
        if (!String.IsNullOrEmpty(filtro))
        {
            lb_fil.Text = filtro;
        }
        else
        {
            lb_fil.Text = "Não há filtros.";
        }      
        */

        Body.Attributes.Remove("class");

        ucBarra.Visible = false;

        dvFiltro.Visible = false;
        dvComparacaoDynafil.Visible = true;
    }
    

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }
}