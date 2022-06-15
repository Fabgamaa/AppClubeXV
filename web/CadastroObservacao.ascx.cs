using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using FWBDS;

public partial class CadastroObservacao : System.Web.UI.UserControl
{
    private string _TAB_PAI;
    private int? _PAI_ID;

    public string TAB_PAI
    {
        get { return _TAB_PAI; }
        set { _TAB_PAI = value; }
    }
    public int? PAI_ID
    {
        get { return _PAI_ID; }
        set { _PAI_ID = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregaDados();
        }

    }

    protected void btIncluir_Click(object sender, EventArgs e)
    {
        if (txt_des.Text == "")
        {
            Response.Write("<script language=\"JavaScript\">alert('O campo Descrição é obrigatório!');</script>");
            txt_des.Focus();
            return;
        }

        Observacao Observacao = new Observacao();
        if (!String.IsNullOrEmpty(TAB_PAI.ToString()))
        {
            Observacao.OBS_TAB_PAI = TAB_PAI.ToString();
        }
        if (!String.IsNullOrEmpty(PAI_ID.ToString()))
        {
            Observacao.OBS_PAI_ID = PAI_ID.Value;
        }
        Observacao.OBS_DES = txt_des.Text;
        Observacao.OBS_STS = 1; //Somente Ativos
        
        Observacao.OBS_USR_INC_ID = Convert.ToInt32(Session["USR_ID"].ToString());

        string sRetorno = "";
        sRetorno = Observacao.Inserir();

        if (sRetorno.Substring(0, 1) == "E")
        {
            throw new Exception("Erro ao inserir OBS. Code Behind: CadastroObservacao.ascx.cs " + sRetorno);
        }

        Observacao.OBS_ID = Convert.ToInt16(sRetorno);

        CarregaDados();

        txt_des.Text = "";

    }

    protected void imgInativar_Click(object sender, EventArgs e)
    {
        string sCommandArgument = ((ImageButton)sender).CommandArgument;
        char[] delimiterChars = { ',' };
        string[] aInativar = sCommandArgument.Split(delimiterChars);
        
        Observacao Observacao = new Observacao();
        Observacao.OBS_ID = Convert.ToInt16(aInativar[0]); //Contem OBS_ID
        Observacao.Inativar();

        CarregaDados();
    }

    protected void gvObservacao_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onMouseOver", "this.className = 'selecionado'");
            if ((e.Row.RowIndex % 2) == 0)
            {
                e.Row.Attributes.Add("onMouseOut", "this.className = 'linha_par'");
            }
            else
            {
                e.Row.Attributes.Add("onMouseOut", "this.className = 'linha_impar'");
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
        foreach (DataControlField field in gvObservacao.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvObservacao.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddSortImage(int columnIndex, GridViewRow headerRow)
    {
        // Create the sorting image based on the sort direction.
        Image sortImage = new Image();
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
        // Add the image to the appropriate header cell.
        headerRow.Cells[columnIndex].Controls.Add(sortImage);
    }

    protected void gvObservacao_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvObservacao_Sorting(Object sender, GridViewSortEventArgs e)
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

        Observacao Observacao = new Observacao();
        Observacao.OBS_TAB_PAI = TAB_PAI.ToString();
        Observacao.OBS_PAI_ID = PAI_ID.Value;
        Observacao.OBS_STS = 1; //Somente Ativos
        DataSet dtObservacao = Observacao.Consultar();

        DataTable tblObservacao = dtObservacao.Tables[0];
        DataView dvObservacao = new DataView(tblObservacao);
        dvObservacao.Sort = e.SortExpression + Ordem;
        gvObservacao.DataSource = dvObservacao;
        gvObservacao.DataBind();

        dvObservacao.Dispose();
        tblObservacao.Dispose();
        dtObservacao.Dispose();
        Dispose();
    }

    protected void CarregaDados()
    {
        //Se não informado TAB_PAI não carrega
        if (TAB_PAI != null)
        {
            Observacao Observacao = new Observacao();
            Observacao.OBS_TAB_PAI = TAB_PAI.ToString();
            Observacao.OBS_PAI_ID = PAI_ID.Value;
            Observacao.OBS_STS = 1; //Somente Ativos
            DataSet dtObservacao = Observacao.Consultar();

            gvObservacao.DataSource = dtObservacao;
            gvObservacao.DataBind();

            dtObservacao.Dispose();
            Dispose();
        }
    }
    
}
