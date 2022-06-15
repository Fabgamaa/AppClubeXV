using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Security;
using System.Data;
using System.Configuration;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
	{
		if (Request["rowId"] != null)
		{
			rowId.Value = Request["rowId"].ToString();
		}
		if (Request["Origem"] != null)
		{
			Origem.Value = Request["Origem"].ToString();
		}
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
		//txt_tms_alt.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
		//txt_tms_alt.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
		//txt_tms_alt_inc.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data();");
		//txt_tms_alt_inc.Attributes.Add("onBlur", "javascript:f_valida_data(this);");
	}
	protected void CarregaControles()
    {
		Patrimonio patrimonio = new Patrimonio();
		DataSet dsPatrimonio = patrimonio.Consultar();
		//FWGNR.VerificaStatus(dsPatrimonio, "PTR_USR_ID", "PTR_ETQ", "PTR_STS", cbo_usr_id);
		//FWGNR.VerificaStatus(dsPatrimonio, "PTR_USR_ID", "PTR_ETQ", "PTR_STS", cbo_usr_id_inc);

		dsPatrimonio.Dispose();
	}
	protected void CarregaDados()
    {
		if (!string.IsNullOrEmpty(rowId.Value))
		{
			lbAcao.Text = "Alterar";
			divCadastro.Visible = true;
			dvFiltro.Visible = false;

			txt_und_inc.Focus();

			Patrimonio patrimonio = new Patrimonio();
			patrimonio.PTR_ID = Convert.ToInt32(rowId.Value);
			DataSet dsPatrimonio = patrimonio.Consultar();
			if (dsPatrimonio.Tables[0].Rows.Count > 0)
			{
				//cbo_usr_id_inc.SelectedValue = dsPatrimonio.Tables[0].Rows[0]["PTR_USR_ID"].ToString();
				txt_und_inc.Text = dsPatrimonio.Tables[0].Rows[0]["PTR_UND"].ToString();
				txt_loc_inc.Text = dsPatrimonio.Tables[0].Rows[0]["PTR_LOC"].ToString();
				txt_bem_inc.Text = dsPatrimonio.Tables[0].Rows[0]["PTR_BEM"].ToString();
				txt_etq_inc.Text = dsPatrimonio.Tables[0].Rows[0]["PTR_ETQ"].ToString();
				cbo_sts_inc.SelectedValue = dsPatrimonio.Tables[0].Rows[0]["PTR_STS"].ToString();
				//txt_tms_alt_inc.Text = dsPatrimonio.Tables[0].Rows[0]["PTR_TMS_ALT"].ToString();
			}
			dsPatrimonio.Dispose();
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

				txt_und_inc.Focus();
			}
			else
			{
				divCadastro.Visible = false;
				dvFiltro.Visible = true;

				txt_und_inc.Focus();
			}
		}


	}

	private void LimpaTela()
	{
		txt_und_inc.Text = "";
		txt_und.Text = "";
		txt_loc.Text = "";
		txt_bem.Text = "";
		txt_etq.Text = "";
		cbo_sts.Text = "";
		//txt_tms_alt.Text = "";

		txt_und_inc.SelectedIndex = 0;
		txt_und_inc.Text = "";
		txt_loc_inc.Text = "";
		txt_bem_inc.Text = "";
		txt_etq_inc.Text = "";
		cbo_sts_inc.SelectedIndex = 0;
		//txt_tms_alt_inc.Text = "";
	}

	protected void btNovo_Click(object sender, EventArgs e)
	{
		dvResultado.Visible = false;
		lbAcao.Text = "Novo";
		rowId.Value = null;
		LimpaTela();
		divCadastro.Visible = true;
		dvFiltro.Visible = false;
		txt_und_inc.Focus();
	}

	protected void btVoltar_Click(object sender, EventArgs e)
	{
		divCadastro.Visible = false;
		dvResultado.Visible = false;
		dvFiltro.Visible = true;
		txt_und_inc.Focus();
	}

	protected void btLimpar_Click(object sender, EventArgs e)
	{
		LimpaTela();
	}

	protected void btFiltro_Click(object sender, EventArgs e)
	{
		dvFiltro.Visible = true;
		dvResultado.Visible = false;
		txt_und_inc.Focus();
	}
	protected string CriaFiltro(Patrimonio patrimonio)
	{
		//Patrimonio patrimonio = new Patrimonio();
		string filtro = "";
		//if (!String.IsNullOrEmpty(txt_und_inc.Text))
		//{
		//	patrimonio.PTR_USR_ID = Convert.ToInt32(cbo_usr_id.SelectedValue);
		//	filtro = filtro + "= " + cbo_usr_id.SelectedItem.Text + "; ";
		//}
		if (!String.IsNullOrEmpty(txt_und.Text))
		{
			patrimonio.PTR_UND = txt_und.Text;
			filtro = filtro + "= " + txt_und.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_loc.Text))
		{
			patrimonio.PTR_LOC = txt_loc.Text;
			filtro = filtro + "= " + txt_loc.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_bem.Text))
		{
			patrimonio.PTR_BEM = txt_bem.Text;
			filtro = filtro + "= " + txt_bem.Text + "; ";
		}
		if (!String.IsNullOrEmpty(txt_etq.Text))
		{
			patrimonio.PTR_ETQ = txt_etq.Text;
			filtro = filtro + "= " + txt_etq.Text + "; ";
		}
		if (!String.IsNullOrEmpty(cbo_sts.Text))
		{
			patrimonio.PTR_STS = Convert.ToInt32(cbo_sts.SelectedValue);
			filtro = filtro + "= " + cbo_sts.SelectedItem.Text + "; ";
		}
		//if (!String.IsNullOrEmpty(txt_tms_alt.Text))
		//{
		//	patrimonio.PTR_TMS_ALT = Convert.ToDateTime(txt_tms_alt.Text);
		//	filtro = filtro + "= " + txt_tms_alt.Text + "; ";
		//}
		return filtro;
	}
	protected void btProcurar_Click(object sender, EventArgs e)
	{
		string filtro = "";

		Patrimonio patrimonio = new Patrimonio();
		filtro = CriaFiltro(patrimonio);
		DataSet dsPatrimonio = patrimonio.Consultar();

		gvPatrimonio.DataSource = dsPatrimonio;
		gvPatrimonio.DataBind();
		dsPatrimonio.Dispose();
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
	protected void gvPatrimonio_RowDataBound(object sender, GridViewRowEventArgs e)
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
				e.Row.Attributes.Add("onClick", "JavaScript:retornaSelecao('" + gvPatrimonio.DataKeys[e.Row.RowIndex][0].ToString() + "', '" + gvPatrimonio.DataKeys[e.Row.RowIndex][0].ToString() + "');");
			else
				e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = '.aspx?rowId=" + gvPatrimonio.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
		foreach (DataControlField field in gvPatrimonio.Columns)
		{
			if (field.SortExpression == (string)ViewState["SortExpression"])
			{
				return gvPatrimonio.Columns.IndexOf(field);
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

	protected void gvPatrimonio_RowCreated(object sender, GridViewRowEventArgs e)
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
	protected void gvPatrimonio_Sorting(Object sender, GridViewSortEventArgs e)
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

		Patrimonio patrimonio = new Patrimonio();
		filtro = CriaFiltro(patrimonio);
		DataSet dsPatrimonio = patrimonio.Consultar();

		DataTable dt = dsPatrimonio.Tables[0];
		DataView dv = new DataView(dt);
		dv.Sort = e.SortExpression + Ordem;
		gvPatrimonio.DataSource = dv;
		gvPatrimonio.DataBind();

		dv.Dispose();
		dt.Dispose();
		dsPatrimonio.Dispose();
		Dispose();
	}

	protected void btSalvar_Click(object sender, EventArgs e)
	{
		string sMsg;
		//if (cbo_usr_id_inc.Text == "")
		//{
		//	TratamentoErro("O campo  é obrigatório.");
		//	cbo_usr_id_inc.Focus();
		//	return;
		//}
		Usuario usuario = new Usuario();
		usuario.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());

		Patrimonio patrimonio = new Patrimonio();
  //      if (cbo_usr_id_inc.Text != "")
  //      {
  //          //patrimonio.PTR_USR_ID = Convert.ToInt32(cbo_usr_id_inc.SelectedValue);
		//	patrimonio.PTR_USR_ID = 124;
		//}
		patrimonio.PTR_USR_ID = usuario.USR_ID;
		patrimonio.PTR_UND = txt_und_inc.Text;
		patrimonio.PTR_LOC = txt_loc_inc.Text;
		patrimonio.PTR_BEM = txt_bem_inc.Text;
		patrimonio.PTR_ETQ = txt_etq_inc.Text;
		patrimonio.PTR_STS = Convert.ToInt32(cbo_sts_inc.SelectedValue);
		//patrimonio.PTR_TMS_ALT = Convert.ToDateTime(txt_tms_alt_inc.Text);

		if (!string.IsNullOrEmpty(rowId.Value))
		{
			patrimonio.PTR_ID = Convert.ToInt32(rowId.Value);
			//patrimonio.PTR_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = patrimonio.Alterar();
			if (sMsg != "")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				TratamentoErro(" alterado com sucesso.");
			}
		}
		else
		{
			Patrimonio ptr = new Patrimonio();
			//Verificar se já não existe um cadastro consultando o: PTR_ETQ
			ptr.PTR_ETQ = txt_etq.Text;
			DataSet dsPatrimonio = patrimonio.Consultar();
			if (dsPatrimonio.Tables[0].Rows.Count > 0)
			{
				TratamentoErro("Registro já está cadastrado.");
				txt_und_inc.Focus();
				return;
			}
			//ptr.PTR_USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
			sMsg = patrimonio.Inserir();

			if (sMsg.Substring(0, 1) == "E")
			{
				Response.Redirect("Erro.aspx?Erro=" + sMsg);
			}
			else
			{
				rowId.Value = sMsg;

				TratamentoErro("Registro inserido com sucesso.");
				if (!string.IsNullOrEmpty(Origem.Value) && Origem.Value == "Novo")
					ScriptManager.RegisterClientScriptBlock(this, GetType(), "alertaOrigem", "window.close();", true);
			}
			dsPatrimonio.Dispose();
		}
		Dispose();
		divCadastro.Visible = false;
		dvFiltro.Visible = true;

		rowId.Value = null;
	}
	private void TratamentoErro(string erro)
	{
		if (!string.IsNullOrEmpty(erro))
			ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
	}
	protected void lkb_pdf_Click(object sender, EventArgs e)
	{
		if (gvPatrimonio.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/pdf";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.pdf");
			// Sem a opção de Salvar
			// Response.Cache.SetCacheability(HttpCacheability.NoCache);
			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvPatrimonio.AllowSorting = false;
			gvPatrimonio.AllowPaging = false;
			//gvPatrimonio.DataBind();

			// Deixar cabeçalho em branco/preto, sem links e imagens
			for (int i = 0; i < gvPatrimonio.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvPatrimonio.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvPatrimonio.RenderControl(htmlWrite);

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
		if (gvPatrimonio.Rows.Count > 0)
		{
			Response.Clear();
			Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
			Response.ContentType = "application/vnd.ms-excel";
			Response.AddHeader("content-disposition", "attachment;filename=Historico.xls");
			//Sem a opção de Salvar
			//Response.Cache.SetCacheability(HttpCacheability.NoCache);

			StringWriter stringWrite = new StringWriter();
			HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
			gvPatrimonio.AllowSorting = false;
			gvPatrimonio.AllowPaging = false;

			// Deixar cabeçalho em branco/preto, sem links e imagens

			for (int i = 0; i < gvPatrimonio.HeaderRow.Cells.Count; i++)
			{
				LinkButton lnk = (LinkButton)gvPatrimonio.HeaderRow.Cells[i].Controls[0];
				lnk.Enabled = false;
				lnk.BackColor = System.Drawing.Color.White;
				lnk.ForeColor = System.Drawing.Color.Black;
			}

			gvPatrimonio.RenderControl(htmlWrite);

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