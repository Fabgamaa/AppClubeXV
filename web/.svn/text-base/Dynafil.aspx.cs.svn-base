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
                btNovoFiltro.Visible = false;
                btNovoFiltroGrid.Visible = false;
                Form.Style.Add("width", "550");
                Form.Style.Add("height", "200");
            }

            FormataControles();
            CarregaControles();
            CarregaDados();
        }
    }

    protected void FormataControles()
    {
        txt_dat.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_dat_fia_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
        txt_dat_fia_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
        txt_tit_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_001_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_001_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_002_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_002_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_003_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_003_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_004_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_004_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_005_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_005_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tit_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tit_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_tnc_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_tnc_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_aon_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_aon_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_eve_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_eve_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_qbr_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_qbr_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_foa_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_foa_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
        txt_cvf_006_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_moeda();");
        txt_cvf_006_inc.Attributes.Add("onBlur", "javascript:f_formata_valor(this);");
    }

    protected void CarregaControles()
    {
        Fornecedor Fornecedor = new Fornecedor();
        Fornecedor.FOR_TIP = "P"; //Somente POYs
        DataSet dsFornecedor = Fornecedor.Consultar();
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id);
        FWGNR.VerificaStatus(dsFornecedor, "FOR_ID", "FOR_NOM", "FOR_STS", cbo_for_id_inc);
        dsFornecedor.Dispose();

        Titulo Titulo = new Titulo();
        Titulo.TIT_POY_TIP = "P"; //Somente POYs
        DataSet dsTitulo = Titulo.Consultar();
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id);
        FWGNR.VerificaStatus(dsTitulo, "TIT_POY_ID", "TIT_POY_DES", "TIT_POY_STS", cbo_tit_poy_id_inc);
        dsTitulo.Dispose();
    }

    protected void CarregaDados()	{		if (!string.IsNullOrEmpty(rowId.Value))		{			lbAcao.Text = "Alterar";			divCadastro.Visible = true;			dvFiltro.Visible = false;			txt_mge_inc.Focus();			Dynafil Dynafil  = new Dynafil();			Dynafil.DNF_ID = Convert.ToInt32(rowId.Value);
            DataSet dsDynafil = Dynafil.Consultar();
            if (dsDynafil.Tables[0].Rows.Count > 0)			{				txt_mge_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_MGE"].ToString();				cbo_for_id_inc.SelectedValue = dsDynafil.Tables[0].Rows[0]["DNF_FOR_ID"].ToString();				cbo_tit_poy_id_inc.SelectedValue = dsDynafil.Tables[0].Rows[0]["DNF_TIT_POY_ID"].ToString();
				txt_vlc_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_VLC"].ToString();				txt_dat_inc.Text = Convert.ToDateTime(dsDynafil.Tables[0].Rows[0]["DNF_DAT"].ToString()).ToString("dd/MM/yyyy");
                if (!String.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["DNF_DAT_FIA"].ToString()))
                {
                    txt_dat_fia_inc.Text = Convert.ToDateTime(dsDynafil.Tables[0].Rows[0]["DNF_DAT_FIA"].ToString()).ToString("dd/MM/yyyy");
                }				txt_tit_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_001"].ToString();				txt_tnc_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_001"].ToString();				txt_aon_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_001"].ToString();				txt_eve_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_001"].ToString();				txt_qbr_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_001"].ToString();				txt_foa_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_001"].ToString();				txt_cvf_001_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_001"].ToString();				txt_tit_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_002"].ToString();				txt_tnc_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_002"].ToString();				txt_aon_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_002"].ToString();				txt_eve_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_002"].ToString();				txt_qbr_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_002"].ToString();				txt_foa_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_002"].ToString();				txt_cvf_002_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_002"].ToString();				txt_tit_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_003"].ToString();				txt_tnc_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_003"].ToString();				txt_aon_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_003"].ToString();				txt_eve_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_003"].ToString();				txt_qbr_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_003"].ToString();				txt_foa_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_003"].ToString();				txt_cvf_003_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_003"].ToString();				txt_tit_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_004"].ToString();				txt_tnc_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_004"].ToString();				txt_aon_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_004"].ToString();				txt_eve_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_004"].ToString();				txt_qbr_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_004"].ToString();				txt_foa_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_004"].ToString();				txt_cvf_004_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_004"].ToString();				txt_tit_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_005"].ToString();				txt_tnc_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_005"].ToString();				txt_aon_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_005"].ToString();				txt_eve_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_005"].ToString();				txt_qbr_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_005"].ToString();				txt_foa_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_005"].ToString();				txt_cvf_005_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_005"].ToString();				txt_tit_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TIT_006"].ToString();				txt_tnc_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_TNC_006"].ToString();				txt_aon_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_AON_006"].ToString();				txt_eve_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_EVE_006"].ToString();				txt_qbr_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_QBR_006"].ToString();				txt_foa_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_FOA_006"].ToString();				txt_cvf_006_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_CVF_006"].ToString();				cbo_sts_inc.SelectedValue = dsDynafil.Tables[0].Rows[0]["DNF_STS"].ToString();
                txt_obs_dnf.Text = dsDynafil.Tables[0].Rows[0]["DNF_OBS"].ToString();
			}
            dsDynafil.Dispose();			Dispose();		}		else		{		    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")		    {		        divCadastro.Visible = true;		        dvFiltro.Visible = false;		        dvResultado.Visible = false;		        btVoltar.Enabled = false;			    txt_mge_inc.Focus();		    }		    else		    {		        divCadastro.Visible = false;		        dvFiltro.Visible = true;			    txt_mge.Focus();		    }		}	}

    private void LimpaTela()
    {
        txt_mge.Text = "";
        cbo_for_id.Text = "";
        cbo_tit_poy_id.Text = "";
        txt_vlc.Text = "";
        txt_dat.Text = "";
        cbo_sts.Text = "";
        txt_dat_fia_inc.Text = "";
        txt_mge_inc.Text = "";
        cbo_for_id_inc.SelectedIndex = 0;
        cbo_tit_poy_id_inc.SelectedIndex = 0;
        txt_vlc_inc.Text = "";
        txt_dat_inc.Text = "";
        txt_tit_001_inc.Text = "";
        txt_tnc_001_inc.Text = "";
        txt_aon_001_inc.Text = "";
        txt_eve_001_inc.Text = "";
        txt_qbr_001_inc.Text = "";
        txt_foa_001_inc.Text = "";
        txt_cvf_001_inc.Text = "";
        txt_tit_002_inc.Text = "";
        txt_tnc_002_inc.Text = "";
        txt_aon_002_inc.Text = "";
        txt_eve_002_inc.Text = "";
        txt_qbr_002_inc.Text = "";
        txt_foa_002_inc.Text = "";
        txt_cvf_002_inc.Text = "";
        txt_tit_003_inc.Text = "";
        txt_tnc_003_inc.Text = "";
        txt_aon_003_inc.Text = "";
        txt_eve_003_inc.Text = "";
        txt_qbr_003_inc.Text = "";
        txt_foa_003_inc.Text = "";
        txt_cvf_003_inc.Text = "";
        txt_tit_004_inc.Text = "";
        txt_tnc_004_inc.Text = "";
        txt_aon_004_inc.Text = "";
        txt_eve_004_inc.Text = "";
        txt_qbr_004_inc.Text = "";
        txt_foa_004_inc.Text = "";
        txt_cvf_004_inc.Text = "";
        txt_tit_005_inc.Text = "";
        txt_tnc_005_inc.Text = "";
        txt_aon_005_inc.Text = "";
        txt_eve_005_inc.Text = "";
        txt_qbr_005_inc.Text = "";
        txt_foa_005_inc.Text = "";
        txt_cvf_005_inc.Text = "";
        txt_tit_006_inc.Text = "";
        txt_tnc_006_inc.Text = "";
        txt_aon_006_inc.Text = "";
        txt_eve_006_inc.Text = "";
        txt_qbr_006_inc.Text = "";
        txt_foa_006_inc.Text = "";
        txt_cvf_006_inc.Text = "";
        cbo_sts_inc.SelectedIndex = 0;
        txt_obs_dnf.Text = "";
    }

    protected void btNovoFiltro_Click(object sender, EventArgs e)
    {
        dvResultado.Visible = false;
        lbAcao.Text = "Novo";
        rowId.Value = null;
        LimpaTela();
        divCadastro.Visible = true;
        dvFiltro.Visible = false;
        txt_mge_inc.Focus();
    }

    protected void btVoltar_Click(object sender, EventArgs e)
    {
        divCadastro.Visible = false;
        dvResultado.Visible = false;
        dvFiltro.Visible = true;
        txt_mge.Focus();
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        LimpaTela();
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
        txt_mge.Focus();
    }

    protected string CriaFiltro(Dynafil Dynafil)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_mge.Text))		{			Dynafil.DNF_MGE = txt_mge.Text;			filtro = filtro + "Merge= " + txt_mge.Text + "; ";		}		if (!String.IsNullOrEmpty(cbo_for_id.Text))		{			Dynafil.DNF_FOR_ID = Convert.ToInt32(cbo_for_id.SelectedValue);			filtro = filtro + "Fornecedor= " + cbo_for_id.SelectedItem.Text + "; ";		}		if (!String.IsNullOrEmpty(cbo_tit_poy_id.Text))		{			Dynafil.DNF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id.SelectedValue);			filtro = filtro + "Titulo= " + cbo_tit_poy_id.SelectedItem.Text + "; ";		}		if (!String.IsNullOrEmpty(txt_vlc.Text))		{			Dynafil.DNF_VLC = txt_vlc.Text;			filtro = filtro + "Velocidade= " + txt_vlc.Text + "; ";		}		if (!String.IsNullOrEmpty(txt_dat.Text))		{			Dynafil.DNF_DAT = Convert.ToDateTime(txt_dat.Text);			filtro = filtro + "Data= " + txt_dat.Text + "; ";		}		if (!String.IsNullOrEmpty(cbo_sts.Text))		{			Dynafil.DNF_STS = Convert.ToInt32(cbo_sts.SelectedValue);			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";		}		return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";		Dynafil Dynafil = new Dynafil();
        filtro = CriaFiltro(Dynafil);
        if (filtro == "")
        {
            TratamentoErro("O Filtro deve possuir pelo menos um argumento.");
            txt_mge.Focus();
            return;
        }

        DataSet dsDynafil = Dynafil.Consultar();

        gvDynafil.DataSource = dsDynafil;		gvDynafil.DataBind();
        dsDynafil.Dispose();		Dispose();		if (!String.IsNullOrEmpty(filtro))		{			lb_fil.Text = filtro;		}		else		{			lb_fil.Text = "Não há filtros.";		}		dvFiltro.Visible = false;		dvResultado.Visible = true;	}
 
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
            if (!string.IsNullOrEmpty(Origem.Value))
                e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "');");
            else
                e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'Dynafil.aspx?rowId=" + gvDynafil.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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

    protected void gvDynafil_Sorting(Object sender, GridViewSortEventArgs e)	{		string Ordem = " ASC ";		string sortExpression = e.SortExpression;		ViewState["SortExpression"] = sortExpression;		if (GridViewSortDirection == SortDirection.Ascending)		{			GridViewSortDirection = SortDirection.Descending;			Ordem = " DESC ";		}		else		{			GridViewSortDirection = SortDirection.Ascending;			Ordem = " ASC ";		}		string filtro = "";		Dynafil Dynafil = new Dynafil();
        filtro = CriaFiltro(Dynafil);
        DataSet dsDynafil = Dynafil.Consultar();

        DataTable dtDynafil = dsDynafil.Tables[0];
        DataView dvDynafil = new DataView(dtDynafil);
        dvDynafil.Sort = e.SortExpression + Ordem;
        gvDynafil.DataSource = dvDynafil;		gvDynafil.DataBind();

        dvDynafil.Dispose();
        dtDynafil.Dispose();
        dsDynafil.Dispose();		Dispose();	}

    protected void btSalvar_Click(object sender, EventArgs e)	{		string sMsg;		if (txt_mge_inc.Text == "")		{			TratamentoErro("O campo Merge é obrigatório.");			txt_mge_inc.Focus();			return;		}

        if (cbo_for_id_inc.Text == "")
        {
            TratamentoErro("O campo Fornecedor é obrigatório.");
            cbo_for_id_inc.Focus();
            return;
        }

        if (cbo_tit_poy_id_inc.Text == "")
        {
            TratamentoErro("O campo Titulo é obrigatório.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

		if (txt_dat_inc.Text == "")		{			TratamentoErro("O campo Data é obrigatório.");			txt_dat_inc.Focus();			return;		}		if (cbo_sts_inc.Text == "")		{			TratamentoErro("O campo Status é obrigatório.");			cbo_sts_inc.Focus();			return;		}		Dynafil Dynafil = new Dynafil();		if (txt_mge_inc.Text != "")		{			Dynafil.DNF_MGE = txt_mge_inc.Text;		}		Dynafil.DNF_FOR_ID = Convert.ToInt32(cbo_for_id_inc.SelectedValue);		if (cbo_tit_poy_id_inc.Text != "")		{			Dynafil.DNF_TIT_POY_ID = Convert.ToInt32(cbo_tit_poy_id_inc.SelectedValue);		}		Dynafil.DNF_VLC = txt_vlc_inc.Text;		if (txt_dat_inc.Text != "")		{			Dynafil.DNF_DAT = Convert.ToDateTime(txt_dat_inc.Text);		}
        if (txt_dat_fia_inc.Text != "")
        {
            Dynafil.DNF_DAT_FIA = Convert.ToDateTime(txt_dat_fia_inc.Text);
        }
        if (txt_tit_001_inc.Text != "")
        {
            Dynafil.DNF_TIT_001 = Convert.ToDouble(txt_tit_001_inc.Text);
        }
        if (txt_tnc_001_inc.Text != "")
        {
		    Dynafil.DNF_TNC_001 = Convert.ToDouble(txt_tnc_001_inc.Text);        }
        if (txt_aon_001_inc.Text != "")
        {
		    Dynafil.DNF_AON_001 = Convert.ToDouble(txt_aon_001_inc.Text);        }
        if (txt_eve_001_inc.Text != "")
        {
		    Dynafil.DNF_EVE_001 = Convert.ToDouble(txt_eve_001_inc.Text);        }
        if (txt_qbr_001_inc.Text != "")
        {
		    Dynafil.DNF_QBR_001 = Convert.ToDouble(txt_qbr_001_inc.Text);        }
        if (txt_foa_001_inc.Text != "")
        {
		    Dynafil.DNF_FOA_001 = Convert.ToDouble(txt_foa_001_inc.Text);        }
        if (txt_cvf_001_inc.Text != "")
        {
		    Dynafil.DNF_CVF_001 = Convert.ToDouble(txt_cvf_001_inc.Text);        }
        if (txt_tit_002_inc.Text != "")
        {
		    Dynafil.DNF_TIT_002 = Convert.ToDouble(txt_tit_002_inc.Text);        }
        if (txt_tnc_002_inc.Text != "")
        {
		    Dynafil.DNF_TNC_002 = Convert.ToDouble(txt_tnc_002_inc.Text);        }
        if (txt_aon_002_inc.Text != "")
        {
		    Dynafil.DNF_AON_002 = Convert.ToDouble(txt_aon_002_inc.Text);        }
        if (txt_eve_002_inc.Text != "")
        {
		    Dynafil.DNF_EVE_002 = Convert.ToDouble(txt_eve_002_inc.Text);        }
        if (txt_qbr_002_inc.Text != "")
        {
		    Dynafil.DNF_QBR_002 = Convert.ToDouble(txt_qbr_002_inc.Text);        }
        if (txt_foa_002_inc.Text != "")
        {
		    Dynafil.DNF_FOA_002 = Convert.ToDouble(txt_foa_002_inc.Text);        }
        if (txt_cvf_002_inc.Text != "")
        {
		    Dynafil.DNF_CVF_002 = Convert.ToDouble(txt_cvf_002_inc.Text);        }
        if (txt_tit_003_inc.Text != "")
        {
		    Dynafil.DNF_TIT_003 = Convert.ToDouble(txt_tit_003_inc.Text);        }
        if (txt_tnc_003_inc.Text != "")
        {
		    Dynafil.DNF_TNC_003 = Convert.ToDouble(txt_tnc_003_inc.Text);        }
        if (txt_aon_003_inc.Text != "")
        {
		    Dynafil.DNF_AON_003 = Convert.ToDouble(txt_aon_003_inc.Text);        }
        if (txt_eve_003_inc.Text != "")
        {
		    Dynafil.DNF_EVE_003 = Convert.ToDouble(txt_eve_003_inc.Text);        }
        if (txt_qbr_003_inc.Text != "")
        {
		    Dynafil.DNF_QBR_003 = Convert.ToDouble(txt_qbr_003_inc.Text);        }
        if (txt_foa_003_inc.Text != "")
        {
		    Dynafil.DNF_FOA_003 = Convert.ToDouble(txt_foa_003_inc.Text);        }
        if (txt_cvf_003_inc.Text != "")
        {
		    Dynafil.DNF_CVF_003 = Convert.ToDouble(txt_cvf_003_inc.Text);        }
        if (txt_tit_004_inc.Text != "")
        {
		    Dynafil.DNF_TIT_004 = Convert.ToDouble(txt_tit_004_inc.Text);        }
        if (txt_tnc_004_inc.Text != "")
        {
		    Dynafil.DNF_TNC_004 = Convert.ToDouble(txt_tnc_004_inc.Text);        }
        if (txt_aon_004_inc.Text != "")
        {
		    Dynafil.DNF_AON_004 = Convert.ToDouble(txt_aon_004_inc.Text);        }
        if (txt_eve_004_inc.Text != "")
        {
		    Dynafil.DNF_EVE_004 = Convert.ToDouble(txt_eve_004_inc.Text);        }
        if (txt_qbr_004_inc.Text != "")
        {
		    Dynafil.DNF_QBR_004 = Convert.ToDouble(txt_qbr_004_inc.Text);        }
        if (txt_foa_004_inc.Text != "")
        {
		    Dynafil.DNF_FOA_004 = Convert.ToDouble(txt_foa_004_inc.Text);        }
        if (txt_cvf_004_inc.Text != "")
        {
		    Dynafil.DNF_CVF_004 = Convert.ToDouble(txt_cvf_004_inc.Text);        }
        if (txt_tit_005_inc.Text != "")
        {
		    Dynafil.DNF_TIT_005 = Convert.ToDouble(txt_tit_005_inc.Text);        }
        if (txt_tnc_005_inc.Text != "")
        {
		    Dynafil.DNF_TNC_005 = Convert.ToDouble(txt_tnc_005_inc.Text);        }
        if (txt_aon_005_inc.Text != "")
        {
		    Dynafil.DNF_AON_005 = Convert.ToDouble(txt_aon_005_inc.Text);        }
        if (txt_eve_005_inc.Text != "")
        {
		    Dynafil.DNF_EVE_005 = Convert.ToDouble(txt_eve_005_inc.Text);        }
        if (txt_qbr_005_inc.Text != "")
        {
		    Dynafil.DNF_QBR_005 = Convert.ToDouble(txt_qbr_005_inc.Text);        }
        if (txt_foa_005_inc.Text != "")
        {
		    Dynafil.DNF_FOA_005 = Convert.ToDouble(txt_foa_005_inc.Text);        }
        if (txt_cvf_005_inc.Text != "")
        {
		    Dynafil.DNF_CVF_005 = Convert.ToDouble(txt_cvf_005_inc.Text);        }
        if (txt_tit_006_inc.Text != "")
        {
		    Dynafil.DNF_TIT_006 = Convert.ToDouble(txt_tit_006_inc.Text);        }
        if (txt_tnc_006_inc.Text != "")
        {
		    Dynafil.DNF_TNC_006 = Convert.ToDouble(txt_tnc_006_inc.Text);        }
        if (txt_aon_006_inc.Text != "")
        {
		    Dynafil.DNF_AON_006 = Convert.ToDouble(txt_aon_006_inc.Text);        }
        if (txt_eve_006_inc.Text != "")
        {
		    Dynafil.DNF_EVE_006 = Convert.ToDouble(txt_eve_006_inc.Text);        }
        if (txt_qbr_006_inc.Text != "")
        {
		    Dynafil.DNF_QBR_006 = Convert.ToDouble(txt_qbr_006_inc.Text);        }
        if (txt_foa_006_inc.Text != "")
        {
		    Dynafil.DNF_FOA_006 = Convert.ToDouble(txt_foa_006_inc.Text);        }
        if (txt_cvf_006_inc.Text != "")
        {
		    Dynafil.DNF_CVF_006 = Convert.ToDouble(txt_cvf_006_inc.Text);        }		if (cbo_sts_inc.Text != "")		{			Dynafil.DNF_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);		}
        if (txt_obs_dnf.Text != "")
        {
            Dynafil.DNF_OBS = txt_obs_dnf.Text;
        }        		if (!string.IsNullOrEmpty(rowId.Value))		{			Dynafil.DNF_ID = Convert.ToInt32(rowId.Value);			Dynafil.DNF_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());			sMsg = Dynafil.Alterar();			if (sMsg != "")			{				Response.Redirect("Erro.aspx?Erro="+sMsg);			}			else			{				TratamentoErro("Dynafil alterado com sucesso.");			}		}		else		{            /*            //Não será verificar Dynafil anteriores			Dynafil DNF = new Dynafil();			//Verificar se já não existe um cadastro consultando o: DNF_DES 			DNF.DNF_DES = txt_des_inc.Text;			DataSet dsDNF = DNF.Consultar();			if (dsDNF.Tables[0].Rows.Count > 0)			{				TratamentoErro("Esse  já está cadastrado.");				txt_mge_inc.Focus();				return;			}            */			Dynafil.DNF_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());			sMsg = Dynafil.Inserir();			if (sMsg.Substring(0, 1) == "E")			{				Response.Redirect("Erro.aspx?Erro=" + sMsg.Replace("\r\n", " ").Replace("\n", " ").Replace("\r", " "));			}			else			{				rowId.Value = sMsg;				TratamentoErro("Dynafil inserido com sucesso.");				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);			}			//dsDNF.Dispose();		}		Dispose();		divCadastro.Visible = false;		dvFiltro.Visible = true;		rowId.Value = null;	}

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
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
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
            Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
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

}