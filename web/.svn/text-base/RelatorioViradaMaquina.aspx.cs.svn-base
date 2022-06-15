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

using System.Linq;
using System.Collections.Generic;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;

using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    class ItemLancamento
    {
        public string MAQ_DES { get; set; }
        public DateTime DST_VRD_DAT { get; set; }
        public DateTime LNC_MAQ_VRD { get; set; }
        public DateTime LNC_MAQ_DAT { get; set; }
        public string LNC_MAQ_LOT { get; set; }
        public string LNC_MAQ_PRD { get; set; }
        public string LNC_MAQ_TUB { get; set; }
    }
    List<ItemLancamento> lLancamento = new List<ItemLancamento>();

    string sMaquina = "";

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
        txt_dat_ini.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data_hora();");
        txt_dat_ini.Attributes.Add("onBlur", "javascript:f_formata_data_hora(this);");
        txt_dat_fim.Attributes.Add("onKeyPress", "javascript:f_filtra_teclas_data_hora();");
        txt_dat_fim.Attributes.Add("onBlur", "javascript:f_formata_data_hora(this);");

        txt_dat_ini.Text = DateTime.Now.ToString("dd/MM/yyyy") + " 00:00";
        txt_dat_fim.Text = DateTime.Now.ToString("dd/MM/yyyy") + " 23:59";

        txt_dat_ini.Focus();
    }

    protected void CarregaControles()	{
	}

    protected string CriaFiltro(DistribuicaoVirada DistribuicaoVirada)	{		string filtro = "";		if (!String.IsNullOrEmpty(txt_dat_ini.Text))		{			DistribuicaoVirada.DST_VRD_DAT_INI = Convert.ToDateTime(txt_dat_ini.Text);			filtro = filtro + "Data Inicial= " + txt_dat_ini.Text + "; ";		}
        if (!String.IsNullOrEmpty(txt_dat_fim.Text))
        {
            DistribuicaoVirada.DST_VRD_DAT_FIM = Convert.ToDateTime(txt_dat_fim.Text);
            filtro = filtro + "Data Final= " + txt_dat_fim.Text + "; ";
        }
        DistribuicaoVirada.DST_VRD_STS = 1; //Somente Ativos

        return filtro;	}

    protected void btProcurar_Click(object sender, EventArgs e)	{		string filtro = "";		DistribuicaoVirada DistribuicaoVirada = new DistribuicaoVirada();
        filtro = CriaFiltro(DistribuicaoVirada);

        /*
        DataSet dsDistribuicaoVirada = DistribuicaoVirada.RelatorioViradaMaquina();

        gvDistribuicaoVirada.DataSource = dsDistribuicaoVirada;
        gvDistribuicaoVirada.DataBind();		dsDistribuicaoVirada.Dispose();		Dispose();        */

        CarregaLancamentoMaquina();

        gvDistribuicaoVirada.DataSource = lLancamento;
        gvDistribuicaoVirada.DataBind();				if (!String.IsNullOrEmpty(filtro))		{			lb_fil.Text = filtro;		}		else		{			lb_fil.Text = "Não há filtros.";		}		dvFiltro.Visible = false;		dvResultado.Visible = true;	}

    protected void gvDistribuicaoVirada_RowDataBound(object sender, GridViewRowEventArgs e)
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

            if (gvDistribuicaoVirada.DataKeys[e.Row.RowIndex]["MAQ_DES"].ToString() == sMaquina)
            {
                Label lbMAQ_DES = (Label)e.Row.FindControl("lbMAQ_DES");
                lbMAQ_DES.Text = "";

                Label lbLNC_MAQ_VRD = (Label)e.Row.FindControl("lbLNC_MAQ_VRD");
                lbLNC_MAQ_VRD.Text = "";

                Label lbLNC_MAQ_DAT = (Label)e.Row.FindControl("lbLNC_MAQ_DAT");
                lbLNC_MAQ_DAT.Text = "";

                Label lbLNC_MAQ_LOT = (Label)e.Row.FindControl("lbLNC_MAQ_LOT");
                lbLNC_MAQ_LOT.Text = "";

                Label lbLNC_MAQ_PRD = (Label)e.Row.FindControl("lbLNC_MAQ_PRD");
                lbLNC_MAQ_PRD.Text = "";

                Label lbLNC_MAQ_TUB = (Label)e.Row.FindControl("lbLNC_MAQ_TUB");
                lbLNC_MAQ_TUB.Text = "";
            }
            else
            {
                sMaquina = gvDistribuicaoVirada.DataKeys[e.Row.RowIndex]["MAQ_DES"].ToString();
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
        foreach (DataControlField field in gvDistribuicaoVirada.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvDistribuicaoVirada.Columns.IndexOf(field);
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

    protected void gvDistribuicaoVirada_RowCreated(object sender, GridViewRowEventArgs e)
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
    protected void gvDistribuicaoVirada_Sorting(Object sender, GridViewSortEventArgs e)	{		string Ordem = " ASC ";		string sortExpression = e.SortExpression;		ViewState["SortExpression"] = sortExpression;		if (GridViewSortDirection == SortDirection.Ascending)		{			GridViewSortDirection = SortDirection.Descending;			Ordem = " DESC ";		}		else		{			GridViewSortDirection = SortDirection.Ascending;			Ordem = " ASC ";		}		string filtro = "";		DistribuicaoVirada DistribuicaoVirada = new DistribuicaoVirada();		filtro = CriaFiltro(DistribuicaoVirada);
        DataSet dsDistribuicaoVirada = DistribuicaoVirada.RelatorioViradaMaquina();

        DataTable dtDistribuicaoVirada = dsDistribuicaoVirada.Tables[0];
        DataView dvDistribuicaoVirada = new DataView(dtDistribuicaoVirada);
        dvDistribuicaoVirada.Sort = e.SortExpression + Ordem;
        gvDistribuicaoVirada.DataSource = dvDistribuicaoVirada;
        gvDistribuicaoVirada.DataBind();

        dvDistribuicaoVirada.Dispose();
        dtDistribuicaoVirada.Dispose();		dsDistribuicaoVirada.Dispose();		Dispose();	}
    */

    private void TratamentoErro(string erro)
    {
        if (!string.IsNullOrEmpty(erro))
            ScriptManager.RegisterClientScriptBlock(this, GetType(), "AlertErro", "alert('" + erro + "');", true);
    }

    protected void lkb_pdf_Click(object sender, EventArgs e)
    {
        if (gvDistribuicaoVirada.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=ViradaMaquina.pdf");
            // Sem a opção de Salvar
            // Response.Cache.SetCacheability(HttpCacheability.NoCache);
            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDistribuicaoVirada.AllowSorting = false;
            gvDistribuicaoVirada.AllowPaging = false;
            //gvDistribuicaoVirada.DataBind();

            // Deixar cabeçalho em branco/preto, sem links e imagens
            // Não tem Ordenação, sem LinkButton
            for (int i = 0; i < gvDistribuicaoVirada.HeaderRow.Cells.Count; i++)
            {
                gvDistribuicaoVirada.HeaderRow.Cells[i].ForeColor = System.Drawing.Color.Black;
            }

            gvDistribuicaoVirada.RenderControl(htmlWrite);

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
        if (gvDistribuicaoVirada.Rows.Count > 0)
        {
            Response.Clear();
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("ISO-8859-1");
            Response.ContentType = "application/vnd.ms-excel";
            Response.AddHeader("content-disposition", "attachment;filename=ViradaMaquina.xls");
            //Sem a opção de Salvar
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWrite = new StringWriter();
            HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
            gvDistribuicaoVirada.AllowSorting = false;
            gvDistribuicaoVirada.AllowPaging = false;

            // Deixar cabeçalho em branco/preto, sem links e imagens
            // Não tem Ordenação, sem LinkButton
            for (int i = 0; i < gvDistribuicaoVirada.HeaderRow.Cells.Count; i++)
            {
                gvDistribuicaoVirada.HeaderRow.Cells[i].ForeColor = System.Drawing.Color.Black;
            }

            gvDistribuicaoVirada.RenderControl(htmlWrite);

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

    protected void CarregaLancamentoMaquina()
    {
        LancamentoMaquina LancamentoMaquina = new LancamentoMaquina();
        LancamentoMaquina.LNC_MAQ_STS = 1;
        DataSet dsLancamentoMaquina = LancamentoMaquina.Consultar();

        DateTime dtInicial = Convert.ToDateTime(txt_dat_ini.Text);
        DateTime dtFinal = Convert.ToDateTime(txt_dat_fim.Text);

        int iVirada = 0;
        bool bDistribuiu = true;

        while (bDistribuiu)
        {
            bDistribuiu = false;
            for (int i = 0; i < dsLancamentoMaquina.Tables[0].Rows.Count; i++)
            {
                double dViradaHora = Convert.ToDouble(Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString()).ToString("HH"));
                double dViradaMinuto = Convert.ToDouble(Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString()).ToString("mm"));

                DateTime dtData = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_DAT"].ToString());
                if (dtData < dtInicial)
                {
                    //dtData = dtInicial;
                    do
                    {
                        dtData = dtData.AddHours(dViradaHora).AddMinutes(dViradaMinuto);
                    }
                    while (dtData < dtInicial);
                }

                for (int j = 1; j <= iVirada; j++)
                {
                    dtData = dtData.AddHours(dViradaHora).AddMinutes(dViradaMinuto);
                }

                if (dtData <= dtFinal)
                {
                    ItemLancamento il = new ItemLancamento();
                    il.MAQ_DES = dsLancamentoMaquina.Tables[0].Rows[i]["MAQ_DES"].ToString();
                    il.DST_VRD_DAT = dtData;
                    il.LNC_MAQ_VRD = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_VRD"].ToString());
                    il.LNC_MAQ_DAT = Convert.ToDateTime(dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_DAT"].ToString());
                    il.LNC_MAQ_LOT = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_LOT"].ToString();
                    il.LNC_MAQ_PRD = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_PRD"].ToString();
                    il.LNC_MAQ_TUB = dsLancamentoMaquina.Tables[0].Rows[i]["LNC_MAQ_TUB"].ToString();
                    lLancamento.Add(il);

                    bDistribuiu = true;
                }
            }

            iVirada++;
        }
        dsLancamentoMaquina.Dispose();

        lLancamento = lLancamento.OrderBy(x => x.MAQ_DES).ThenBy(x => x.DST_VRD_DAT).ToList();
    }

}