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
        txt_lot.Focus();
    }

    protected void CarregaControles()
    {
        Titulo Titulo = new Titulo();
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        dsTitulo.Dispose();

        Apresentacao Apresentacao = new Apresentacao();
        DataSet dsApresentacao = Apresentacao.Consultar();
        FWGNR.VerificaStatus(dsApresentacao, "APS_ID", "APS_DES", "APS_STS", cbo_aps_id);
        dsApresentacao.Dispose();

        Entrelacamento Entrelacamento = new Entrelacamento();
        DataSet dsEntrelacamento = Entrelacamento.Consultar();
        FWGNR.VerificaStatus(dsEntrelacamento, "ERT_ID", "ERT_DES", "ERT_STS", cbo_ert_id);
        dsEntrelacamento.Dispose();
    }

    protected string CriaFiltro(Especificacao Especificacao)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            Especificacao.ANE_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))
        {
            Especificacao.ANE_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);
            filtro = filtro + "Título= " + cbo_tit_poy_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_aps_id.Text))
        {
            Especificacao.ANE_APS_ID = Convert.ToInt32(cbo_aps_id.SelectedValue);
            filtro = filtro + "Apresentação= " + cbo_aps_id.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_ert_id.Text))
        {
            Especificacao.ANE_ERT_ID = Convert.ToInt32(cbo_ert_id.SelectedValue);
            filtro = filtro + "Entrelaçamento= " + cbo_ert_id.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        /*
        if (txt_lot.Text == "")
        {
            TratamentoErro("O campo Lote é obrigatório.");
            txt_lot.Focus();
            return;
        }
        */

        if (cbo_tit_poy_id.Text == "")
        {
            TratamentoErro("O campo Título é obrigatório.");
            cbo_tit_poy_id.Focus();
            return;
        }

        if (cbo_aps_id.Text == "")
        {
            TratamentoErro("O campo Apresentação é obrigatório.");
            cbo_aps_id.Focus();
            return;
        }

        if (cbo_ert_id.Text == "")
        {
            TratamentoErro("O campo Entrelaçamento é obrigatório.");
            cbo_ert_id.Focus();
            return;
        }
        
        Especificacao Especificacao = new Especificacao();
        filtro = CriaFiltro(Especificacao);
        DataSet dsEspecificacao = Especificacao.Consultar();
        if (dsEspecificacao.Tables[0].Rows.Count > 0)
        {
            txt_lot_rel.Text = txt_lot.Text;
            txt_tit_poy_id_rel.Text = cbo_tit_poy_id.SelectedItem.Text;
            txt_aps_id_rel.Text = cbo_aps_id.SelectedItem.Text;
            txt_ert_id_rel.Text = cbo_ert_id.SelectedItem.Text;

            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MED"].ToString()))
            {
                txt_tit_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MED"].ToString()))
            {
                txt_tnc_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MED"].ToString()))
            {
                txt_aon_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MED"].ToString()))
            {
                txt_enm_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MED"].ToString()))
            {
                txt_ole_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString()))
            {
                txt_trq_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MED"].ToString()))
            {
                txt_ert_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MED"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MED"].ToString()))
            {
                txt_dnd_med_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MED"].ToString()).ToString("N3");
            }


            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString()))
            {
                txt_tit_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString()))
            {
                txt_tnc_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MIN"].ToString()))
            {
                txt_aon_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString()))
            {
                txt_enm_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString()))
            {
                txt_ole_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString()))
            {
                txt_trq_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString()))
            {
                txt_ert_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MIN"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MIN"].ToString()))
            {
                txt_dnd_min_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MIN"].ToString()).ToString("N3");
            }


            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString()))
            {
                txt_tit_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TIT_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString()))
            {
                txt_tnc_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TNC_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MAX"].ToString()))
            {
                txt_aon_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_AON_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString()))
            {
                txt_enm_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ENM_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString()))
            {
                txt_ole_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_OLE_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString()))
            {
                txt_trq_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_TRQ_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString()))
            {
                txt_ert_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_ERT_MAX"].ToString()).ToString("N2");
            }
            if (!string.IsNullOrEmpty(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MAX"].ToString()))
            {
                txt_dnd_max_rel.Text = Convert.ToDouble(dsEspecificacao.Tables[0].Rows[0]["ANE_DND_MAX"].ToString()).ToString("N3");
            }
        }
        dsEspecificacao.Dispose();
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
        dvResultado.Visible = true;
    }

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void txt_lot_OnTextChanged(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(txt_lot.Text))
        {
            Analise Analise = new Analise();
            Analise.ANS_LOT = txt_lot.Text;
            DataSet dsAnalise = Analise.Consultar();
            if (dsAnalise.Tables[0].Rows.Count > 0)
            {
                txt_lot.Text = dsAnalise.Tables[0].Rows[0]["ANS_LOT"].ToString();
                cbo_tit_poy_id.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_TIT_POY_ID"].ToString();
                cbo_aps_id.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_APS_ID"].ToString();
                cbo_ert_id.SelectedValue = dsAnalise.Tables[0].Rows[0]["ANS_ERT_ID"].ToString();
            }
        }
    }
    
    protected void lkb_xls_Click(object sender, EventArgs e)
    {
        Response.Clear();
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
        Response.ContentType = "application/vnd.ms-excel";
        Response.AddHeader("content-disposition", "attachment;filename=EspecificacaoProduto.xls");
        //Sem a opção de Salvar
        //Response.Cache.SetCacheability(HttpCacheability.NoCache);

        StringWriter stringWrite = new StringWriter();
        HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);

        ucBarra.Visible = false;
        lkb_xls.Visible = false;

        frmEspecificacaoLote.RenderControl(htmlWrite);

        Response.Write(stringWrite.ToString());
        Response.End();
    }

}