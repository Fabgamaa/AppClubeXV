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

    protected void CarregaDados()
            DataSet dsDynafil = Dynafil.Consultar();
            if (dsDynafil.Tables[0].Rows.Count > 0)
				txt_vlc_inc.Text = dsDynafil.Tables[0].Rows[0]["DNF_VLC"].ToString();
                if (!String.IsNullOrEmpty(dsDynafil.Tables[0].Rows[0]["DNF_DAT_FIA"].ToString()))
                {
                    txt_dat_fia_inc.Text = Convert.ToDateTime(dsDynafil.Tables[0].Rows[0]["DNF_DAT_FIA"].ToString()).ToString("dd/MM/yyyy");
                }
                txt_obs_dnf.Text = dsDynafil.Tables[0].Rows[0]["DNF_OBS"].ToString();
			}
            dsDynafil.Dispose();

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

    protected string CriaFiltro(Dynafil Dynafil)

    protected void btProcurar_Click(object sender, EventArgs e)
        filtro = CriaFiltro(Dynafil);
        if (filtro == "")
        {
            TratamentoErro("O Filtro deve possuir pelo menos um argumento.");
            txt_mge.Focus();
            return;
        }

        DataSet dsDynafil = Dynafil.Consultar();

        gvDynafil.DataSource = dsDynafil;
        dsDynafil.Dispose();
 
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

    protected void gvDynafil_Sorting(Object sender, GridViewSortEventArgs e)
        filtro = CriaFiltro(Dynafil);
        DataSet dsDynafil = Dynafil.Consultar();

        DataTable dtDynafil = dsDynafil.Tables[0];
        DataView dvDynafil = new DataView(dtDynafil);
        dvDynafil.Sort = e.SortExpression + Ordem;
        gvDynafil.DataSource = dvDynafil;

        dvDynafil.Dispose();
        dtDynafil.Dispose();
        dsDynafil.Dispose();

    protected void btSalvar_Click(object sender, EventArgs e)

        if (cbo_for_id_inc.Text == "")
        {
            TratamentoErro("O campo Fornecedor � obrigat�rio.");
            cbo_for_id_inc.Focus();
            return;
        }

        if (cbo_tit_poy_id_inc.Text == "")
        {
            TratamentoErro("O campo Titulo � obrigat�rio.");
            cbo_tit_poy_id_inc.Focus();
            return;
        }

		if (txt_dat_inc.Text == "")
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
		    Dynafil.DNF_TNC_001 = Convert.ToDouble(txt_tnc_001_inc.Text);
        if (txt_aon_001_inc.Text != "")
        {
		    Dynafil.DNF_AON_001 = Convert.ToDouble(txt_aon_001_inc.Text);
        if (txt_eve_001_inc.Text != "")
        {
		    Dynafil.DNF_EVE_001 = Convert.ToDouble(txt_eve_001_inc.Text);
        if (txt_qbr_001_inc.Text != "")
        {
		    Dynafil.DNF_QBR_001 = Convert.ToDouble(txt_qbr_001_inc.Text);
        if (txt_foa_001_inc.Text != "")
        {
		    Dynafil.DNF_FOA_001 = Convert.ToDouble(txt_foa_001_inc.Text);
        if (txt_cvf_001_inc.Text != "")
        {
		    Dynafil.DNF_CVF_001 = Convert.ToDouble(txt_cvf_001_inc.Text);
        if (txt_tit_002_inc.Text != "")
        {
		    Dynafil.DNF_TIT_002 = Convert.ToDouble(txt_tit_002_inc.Text);
        if (txt_tnc_002_inc.Text != "")
        {
		    Dynafil.DNF_TNC_002 = Convert.ToDouble(txt_tnc_002_inc.Text);
        if (txt_aon_002_inc.Text != "")
        {
		    Dynafil.DNF_AON_002 = Convert.ToDouble(txt_aon_002_inc.Text);
        if (txt_eve_002_inc.Text != "")
        {
		    Dynafil.DNF_EVE_002 = Convert.ToDouble(txt_eve_002_inc.Text);
        if (txt_qbr_002_inc.Text != "")
        {
		    Dynafil.DNF_QBR_002 = Convert.ToDouble(txt_qbr_002_inc.Text);
        if (txt_foa_002_inc.Text != "")
        {
		    Dynafil.DNF_FOA_002 = Convert.ToDouble(txt_foa_002_inc.Text);
        if (txt_cvf_002_inc.Text != "")
        {
		    Dynafil.DNF_CVF_002 = Convert.ToDouble(txt_cvf_002_inc.Text);
        if (txt_tit_003_inc.Text != "")
        {
		    Dynafil.DNF_TIT_003 = Convert.ToDouble(txt_tit_003_inc.Text);
        if (txt_tnc_003_inc.Text != "")
        {
		    Dynafil.DNF_TNC_003 = Convert.ToDouble(txt_tnc_003_inc.Text);
        if (txt_aon_003_inc.Text != "")
        {
		    Dynafil.DNF_AON_003 = Convert.ToDouble(txt_aon_003_inc.Text);
        if (txt_eve_003_inc.Text != "")
        {
		    Dynafil.DNF_EVE_003 = Convert.ToDouble(txt_eve_003_inc.Text);
        if (txt_qbr_003_inc.Text != "")
        {
		    Dynafil.DNF_QBR_003 = Convert.ToDouble(txt_qbr_003_inc.Text);
        if (txt_foa_003_inc.Text != "")
        {
		    Dynafil.DNF_FOA_003 = Convert.ToDouble(txt_foa_003_inc.Text);
        if (txt_cvf_003_inc.Text != "")
        {
		    Dynafil.DNF_CVF_003 = Convert.ToDouble(txt_cvf_003_inc.Text);
        if (txt_tit_004_inc.Text != "")
        {
		    Dynafil.DNF_TIT_004 = Convert.ToDouble(txt_tit_004_inc.Text);
        if (txt_tnc_004_inc.Text != "")
        {
		    Dynafil.DNF_TNC_004 = Convert.ToDouble(txt_tnc_004_inc.Text);
        if (txt_aon_004_inc.Text != "")
        {
		    Dynafil.DNF_AON_004 = Convert.ToDouble(txt_aon_004_inc.Text);
        if (txt_eve_004_inc.Text != "")
        {
		    Dynafil.DNF_EVE_004 = Convert.ToDouble(txt_eve_004_inc.Text);
        if (txt_qbr_004_inc.Text != "")
        {
		    Dynafil.DNF_QBR_004 = Convert.ToDouble(txt_qbr_004_inc.Text);
        if (txt_foa_004_inc.Text != "")
        {
		    Dynafil.DNF_FOA_004 = Convert.ToDouble(txt_foa_004_inc.Text);
        if (txt_cvf_004_inc.Text != "")
        {
		    Dynafil.DNF_CVF_004 = Convert.ToDouble(txt_cvf_004_inc.Text);
        if (txt_tit_005_inc.Text != "")
        {
		    Dynafil.DNF_TIT_005 = Convert.ToDouble(txt_tit_005_inc.Text);
        if (txt_tnc_005_inc.Text != "")
        {
		    Dynafil.DNF_TNC_005 = Convert.ToDouble(txt_tnc_005_inc.Text);
        if (txt_aon_005_inc.Text != "")
        {
		    Dynafil.DNF_AON_005 = Convert.ToDouble(txt_aon_005_inc.Text);
        if (txt_eve_005_inc.Text != "")
        {
		    Dynafil.DNF_EVE_005 = Convert.ToDouble(txt_eve_005_inc.Text);
        if (txt_qbr_005_inc.Text != "")
        {
		    Dynafil.DNF_QBR_005 = Convert.ToDouble(txt_qbr_005_inc.Text);
        if (txt_foa_005_inc.Text != "")
        {
		    Dynafil.DNF_FOA_005 = Convert.ToDouble(txt_foa_005_inc.Text);
        if (txt_cvf_005_inc.Text != "")
        {
		    Dynafil.DNF_CVF_005 = Convert.ToDouble(txt_cvf_005_inc.Text);
        if (txt_tit_006_inc.Text != "")
        {
		    Dynafil.DNF_TIT_006 = Convert.ToDouble(txt_tit_006_inc.Text);
        if (txt_tnc_006_inc.Text != "")
        {
		    Dynafil.DNF_TNC_006 = Convert.ToDouble(txt_tnc_006_inc.Text);
        if (txt_aon_006_inc.Text != "")
        {
		    Dynafil.DNF_AON_006 = Convert.ToDouble(txt_aon_006_inc.Text);
        if (txt_eve_006_inc.Text != "")
        {
		    Dynafil.DNF_EVE_006 = Convert.ToDouble(txt_eve_006_inc.Text);
        if (txt_qbr_006_inc.Text != "")
        {
		    Dynafil.DNF_QBR_006 = Convert.ToDouble(txt_qbr_006_inc.Text);
        if (txt_foa_006_inc.Text != "")
        {
		    Dynafil.DNF_FOA_006 = Convert.ToDouble(txt_foa_006_inc.Text);
        if (txt_cvf_006_inc.Text != "")
        {
		    Dynafil.DNF_CVF_006 = Convert.ToDouble(txt_cvf_006_inc.Text);
        if (txt_obs_dnf.Text != "")
        {
            Dynafil.DNF_OBS = txt_obs_dnf.Text;
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
            Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
            // Sem a op��o de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDynafil.AllowSorting = false;
            gvDynafil.AllowPaging = false;
            //gvDynafil.DataBind();

            // Deixar cabe�alho em branco/preto, sem links e imagens
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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N�o h� registros para exporta��o !');", true);
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
            //Sem a op��o de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDynafil.AllowSorting = false;
            gvDynafil.AllowPaging = false;

            // Deixar cabe�alho em branco/preto, sem links e imagens

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
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "alerta", "alert('N�o h� registros para exporta��o !');", true);
        }
    }

}