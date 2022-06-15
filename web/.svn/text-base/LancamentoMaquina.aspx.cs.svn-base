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

using System.Collections.Generic;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    class PlanilhaTubo
    {
        public string Lote { get; set; }
        public string Tubo { get; set; }
        public string Produto { get; set; }
    }
    List<PlanilhaTubo> lPlanilhaTubo = new List<PlanilhaTubo>();
        
    protected void Page_Load(object sender, EventArgs e)
	{
		if (Request["rowId"] != null)		{
			rowId.Value = Request["rowId"].ToString();		}
		if (Request["Origem"] != null)		{
			Origem.Value = Request["Origem"].ToString();		}
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
        txt_vrd_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_hora();");
		txt_vrd_inc.Attributes.Add("onBlur", "javascript:f_valida_hora(this);");
        txt_dat_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data_hora();");
        txt_dat_inc.Attributes.Add("onBlur", "javascript:f_valida_data_hora(this);");

        txt_des_inc.Text = "100% Poliester";
        txt_dat_inc.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
    }

	protected void CarregaControles()
	{
		Maquina Maquina = new Maquina();
		DataSet dsMaquina = Maquina.Consultar();
		FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id);
		FWGNR.VerificaStatus(dsMaquina, "MAQ_ID", "MAQ_DES", "MAQ_STS", cbo_maq_id_inc);
		dsMaquina.Dispose();

        CarregaPlanilhaTubo();
	}


    protected void CarregaPlanilhaTubo()
	{
        string sCaminho = ConfigurationManager.AppSettings["CaminhoPlanilhaTubo"];
        if (!string.IsNullOrEmpty(sCaminho))
        {
            cbo_lot_inc.Items.Clear();

            string sConXLS = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sCaminho + ";Extended Properties='Excel 8.0;HDR=Yes;'";
            using (OleDbConnection connection = new OleDbConnection(sConXLS))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Import$] order by 1", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    System.Web.UI.WebControls.ListItem l = new System.Web.UI.WebControls.ListItem();
                    while (dr.Read())
                    {
                        l = new System.Web.UI.WebControls.ListItem();
                        l.Text = dr[0].ToString();
                        l.Value = dr[0].ToString();
                        cbo_lot_inc.Items.Add(l);

                        PlanilhaTubo iPlanilhaTubo = new PlanilhaTubo();
                        iPlanilhaTubo.Lote = dr[0].ToString();
                        iPlanilhaTubo.Tubo = dr[1].ToString();
                        iPlanilhaTubo.Produto = dr[2].ToString();
                        lPlanilhaTubo.Add(iPlanilhaTubo);
                    }
                    cbo_lot_inc.Items.Insert(0, "");
                }
            }
        }
        Session["PlanilhaTubo"] = lPlanilhaTubo;
    }

    protected void CarregaDados()
	{
		if (!string.IsNullOrEmpty(rowId.Value))
		{
			lbAcao.Text = "Alterar";
			divCadastro.Visible = true;
			dvFiltro.Visible = false;

			cbo_maq_id_inc.Focus();

			LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
			LancamentoMaquina.LNC_MAQ_ID = Convert.ToInt32(rowId.Value);
			DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();
			if (dsLancamentoMaquina.Tables[0].Rows.Count > 0)
			{
				cbo_maq_id_inc.SelectedValue = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_MAQ_ID"].ToString();
                cbo_lad_inc.SelectedValue = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_LAD"].ToString();
				txt_lot_inc.Text = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_LOT"].ToString();
                txt_vrd_inc.Text = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_VRD"].ToString()).ToString("HH:mm");
				txt_tub_inc.Text = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_TUB"].ToString();
				txt_prd_inc.Text = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_PRD"].ToString();
				cbo_cor_inc.SelectedValue = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_COR"].ToString();
				txt_des_inc.Text = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_DES"].ToString();
				txt_dat_inc.Text = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_DAT"].ToString()).ToString("dd/MM/yyyy HH:mm");
                cbo_pos_inc.SelectedValue = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_POS"].ToString();
                cbo_sts_inc.SelectedValue = dsLancamentoMaquina.Tables[0].Rows[0]["LNC_MAQ_STS"].ToString();
			}
			dsLancamentoMaquina.Dispose();
			Dispose();
		}
		else
		{
		    if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
		    {
		        divCadastro.Visible = true;
		        dvFiltro.Visible = false;
		        dvResultado.Visible = false;
		        btVoltar.Enabled = false;

				cbo_maq_id_inc.Focus();
		    }
		    else
		    {
		        divCadastro.Visible = false;
		        dvFiltro.Visible = true;

				cbo_maq_id.Focus();
		    }
		}
	}

	private void LimpaTela()
	{
		cbo_maq_id.Text = "";
        cbo_lad.SelectedIndex = 0;
        cbo_cor.SelectedIndex = 0;
		cbo_sts.Text = "";

		cbo_maq_id_inc.SelectedIndex = 0;
        cbo_lad_inc.SelectedIndex = 0;
        txt_lot_inc.Text = "";
		txt_tub_inc.Text = "";
		txt_prd_inc.Text = "";
        cbo_cor_inc.SelectedIndex = 0;
        txt_vrd_inc.Text = "";
        txt_des_inc.Text = "100% Poliester";
        txt_dat_inc.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        cbo_sts_inc.SelectedIndex = 0;
	}

	protected void btNovo_Click(object sender, EventArgs e)
	{
		dvResultado.Visible = false;
		lbAcao.Text = "Novo";
		rowId.Value = null;
		LimpaTela();
		divCadastro.Visible = true;
		dvFiltro.Visible = false;
		cbo_maq_id_inc.Focus();
	}

	protected void btVoltar_Click(object sender, EventArgs e)
	{
		divCadastro.Visible = false;
		dvResultado.Visible = false;
		dvFiltro.Visible = true;
		cbo_maq_id.Focus();
	}

	protected void btLimpar_Click(object sender, EventArgs e)
	{
		LimpaTela();
	}

	protected void btFiltro_Click(object sender, EventArgs e)
	{
		dvFiltro.Visible = true;
		dvResultado.Visible = false;
		cbo_maq_id.Focus();
	}

	protected string CriaFiltro(LancamentoMaquina LancamentoMaquina)
	{
		string filtro = "";
		if (!String.IsNullOrEmpty(cbo_maq_id.Text))
		{
			LancamentoMaquina.LNC_MAQ_MAQ_ID = Convert.ToInt32(cbo_maq_id.SelectedValue);
			filtro = filtro + "Máquina= " + cbo_maq_id.SelectedItem.Text + "; ";
		}
        if (!String.IsNullOrEmpty(cbo_lad.Text))
        {
            LancamentoMaquina.LNC_MAQ_LAD = cbo_lad.Text;
            filtro = filtro + "Lado= " + cbo_lad.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(txt_lot.Text))
        {
            LancamentoMaquina.LNC_MAQ_LOT = txt_lot.Text;
            filtro = filtro + "Lote= " + txt_lot.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_cor.Text))
		{
			LancamentoMaquina.LNC_MAQ_COR = cbo_cor.SelectedItem.Text;
			filtro = filtro + "Cor= " + cbo_cor.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_sts.Text))
		{
			LancamentoMaquina.LNC_MAQ_STS = Convert.ToInt32(cbo_sts.SelectedValue);
			filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
		}
		return filtro;
	}

	protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
		filtro = CriaFiltro(LancamentoMaquina);
		DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();

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
				e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvLancamentoMaquina.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvLancamentoMaquina.DataKeys[e.Row.RowIndex][0].ToString() + "');");
			else
				e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'LancamentoMaquina.aspx?rowId=" + gvLancamentoMaquina.DataKeys[e.Row.RowIndex][0].ToString() + "'");

            if (gvLancamentoMaquina.DataKeys[e.Row.RowIndex]["LNC_MAQ_STS"].ToString() == "0")
            {
                Label lbLNC_MAQ_STS = (Label)e.Row.FindControl("lbLNC_MAQ_STS");
                lbLNC_MAQ_STS.ForeColor = System.Drawing.Color.Red;
            }

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

	protected void gvLancamentoMaquina_Sorting(Object sender, GridViewSortEventArgs e)
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
		DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();

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

	protected void btSalvar_Click(object sender, EventArgs e)
	{
		string sMsg;
		if (cbo_maq_id_inc.Text == "")
		{
			TratamentoErro("O campo Máquina é obrigatório.");
			cbo_maq_id_inc.Focus();
			return;
		}

        /*
		if (cbo_lad_inc.Text == "")
		{
			TratamentoErro("O campo Lado é obrigatório.");
			cbo_lad_inc.Focus();
			return;
		}
        */

        if (txt_lot_inc.Text == "")
        {
            TratamentoErro("O campo Lote é obrigatório.");
            txt_lot_inc.Focus();
            return;
        }

        if (txt_tub_inc.Text == "")
        {
            TratamentoErro("O campo Tubo é obrigatório.");
            txt_tub_inc.Focus();
            return;
        }

        if (txt_prd_inc.Text == "")
        {
            TratamentoErro("O campo Produto é obrigatório.");
            txt_prd_inc.Focus();
            return;
        }

        if (txt_des_inc.Text == "")
        {
            TratamentoErro("O campo Descrição é obrigatório.");
            txt_des_inc.Focus();
            return;
        }

        if (cbo_cor_inc.Text == "")
		{
			TratamentoErro("O campo Cor é obrigatório.");
			cbo_cor_inc.Focus();
			return;
		}

        if (txt_vrd_inc.Text == "")
        {
            TratamentoErro("O campo Tempo de Virada é obrigatório.");
            txt_vrd_inc.Focus();
            return;
        }

        if (txt_dat_inc.Text == "")
		{
			TratamentoErro("O campo Data é obrigatório.");
			txt_dat_inc.Focus();
			return;
		}

		if (cbo_sts_inc.Text == "")
		{
			TratamentoErro("O campo Status é obrigatório.");
			cbo_sts_inc.Focus();
			return;
		}

		LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
		if (cbo_maq_id_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_MAQ_ID = Convert.ToInt32(cbo_maq_id_inc.SelectedValue);
		}
		if (cbo_lad_inc.Text != "")
		{
            LancamentoMaquina.LNC_MAQ_LAD = cbo_lad_inc.SelectedValue;
		}
		if (txt_lot_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_LOT = txt_lot_inc.Text;
		}
		if (txt_vrd_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_VRD = Convert.ToDateTime(txt_vrd_inc.Text);
		}
		if (txt_tub_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_TUB = txt_tub_inc.Text;
		}
		if (txt_prd_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_PRD = txt_prd_inc.Text;
		}
		if (cbo_cor_inc.Text != "")
		{
            LancamentoMaquina.LNC_MAQ_COR = cbo_cor_inc.SelectedValue;
		}
		if (txt_des_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_DES = txt_des_inc.Text;
		}
		if (txt_dat_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_DAT = Convert.ToDateTime(txt_dat_inc.Text);
		}
        if (cbo_pos_inc.Text != "")
        {
            LancamentoMaquina.LNC_MAQ_POS = cbo_pos_inc.SelectedValue;
        }
        if (cbo_sts_inc.Text != "")
		{
			LancamentoMaquina.LNC_MAQ_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
		}

		if (!string.IsNullOrEmpty(rowId.Value))
		{
			LancamentoMaquina.LNC_MAQ_ID = Convert.ToInt32(rowId.Value);
			LancamentoMaquina.LNC_MAQ_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = LancamentoMaquina.Alterar();
			if (sMsg != "")
			{
				Response.Redirect("Erro.aspx?Erro="+sMsg);
			}
			else
			{
				TratamentoErro("Lançamento de Máquina alterado com sucesso.");
			}
		}
		else
		{
			LancamentoMaquina LNC_MAQ = new LancamentoMaquina();
			//Verificar se já não existe um cadastro consultando o: LNC_MAQ_DES 
            LNC_MAQ.LNC_MAQ_MAQ_ID = Convert.ToInt16(cbo_maq_id_inc.SelectedValue);
            LNC_MAQ.LNC_MAQ_STS = 1;
			DataSet dsLNC_MAQ = LNC_MAQ.Consultar();
			if (dsLNC_MAQ.Tables[0].Rows.Count > 0)
			{
				TratamentoErro("Esse Lançamento de Máquina já está cadastrado.");
				cbo_maq_id_inc.Focus();

				return;
			}
			LancamentoMaquina.LNC_MAQ_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = LancamentoMaquina.Inserir();

			if (sMsg.Substring(0, 1) == "E")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				rowId.Value = sMsg;

				TratamentoErro("Lançamento de Máquina inserido com sucesso.");
				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
			}
			dsLNC_MAQ.Dispose();
		}
		Dispose();
		divCadastro.Visible = false;
		dvFiltro.Visible = true;

		rowId.Value = null;
	}

    protected void txt_lot_inc_OnTextChanged(object sender, EventArgs e)
    {
        lPlanilhaTubo = (List<PlanilhaTubo>)Session["PlanilhaTubo"];
        PlanilhaTubo xTubo = lPlanilhaTubo.Find(x => x.Lote == txt_lot_inc.Text.ToUpper());
        if (xTubo == null)
        {
            txt_tub_inc.Text = "";
            txt_prd_inc.Text = "";

            TratamentoErro("Lote não Localizado.");
            txt_lot_inc.Focus();
        }
        else
        {
            txt_tub_inc.Text = xTubo.Tubo;
            txt_prd_inc.Text = xTubo.Produto;
            txt_des_inc.Focus();
        }
    }

    protected void cbo_lot_inc_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        lPlanilhaTubo = (List <PlanilhaTubo>) Session["PlanilhaTubo"];
        PlanilhaTubo xTubo = lPlanilhaTubo.Find(x => x.Lote == cbo_lot_inc.SelectedValue);
        txt_tub_inc.Text = xTubo.Tubo;
        txt_prd_inc.Text = xTubo.Produto;

        txt_des_inc.Focus();
    }

	private void TratamentoErro(string erro)
	{
		if (!string.IsNullOrEmpty(erro))
			ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
	}

	protected void lkb_pdf_Click(object sender, EventArgs e)
	{
		if (gvLancamentoMaquina.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
			// Sem a opção de Salvar
			// Response.Cache.SetCacheability(HttpCacheability.NoCache);
			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvLancamentoMaquina.AllowSorting = false;
			gvLancamentoMaquina.AllowPaging = false;
			//gvLancamentoMaquina.DataBind();

			// Deixar cabeçalho em branco/preto, sem links e imagens
			for (int i = 0; i < gvLancamentoMaquina.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvLancamentoMaquina.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvLancamentoMaquina.RenderControl(htmlWrite);

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
		if (gvLancamentoMaquina.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/vnd.ms-excel";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
			//Sem a opção de Salvar
			//Response.Cache.SetCacheability(HttpCacheability.NoCache);

			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvLancamentoMaquina.AllowSorting = false;
			gvLancamentoMaquina.AllowPaging = false;

			// Deixar cabeçalho em branco/preto, sem links e imagens

			for (int i = 0; i < gvLancamentoMaquina.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvLancamentoMaquina.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvLancamentoMaquina.RenderControl(htmlWrite);

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

