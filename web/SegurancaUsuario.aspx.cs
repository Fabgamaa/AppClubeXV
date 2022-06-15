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
using FWBDS;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        txt_cod.Text = "";
        txt_nom.Text = "";
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Usuario Usuario = new Usuario();
        filtro = CriaFiltro(Usuario);
        DataSet dtUSR = Usuario.Consultar();

        gvUsuario.DataSource = dtUSR;
        gvUsuario.DataBind();

        dtUSR.Dispose();
        Dispose();

        if (!String.IsNullOrEmpty(filtro))
        {
            lb_fil.Text = filtro;
        }
        else
        {
            lb_fil.Text = "NÃO HÁ FILTROS.";
        }

        dvFiltro.Visible = false;
        dvResultado.Visible = true;
    }

    protected string CriaFiltro(Usuario Usuario)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_cod.Text))
        {
            Usuario.USR_COD = txt_cod.Text;
            filtro = filtro + "Login= " + txt_cod.Text.ToUpper() + "; ";
        }
        if (!String.IsNullOrEmpty(txt_nom.Text))
        {
            Usuario.USR_NOM = txt_nom.Text;
            filtro = filtro + "Nome= " + txt_nom.Text.ToUpper() + "; ";
        }
        return filtro;
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {

        dvFiltro.Visible = true;
        dvResultado.Visible = false;
    }

    protected void gvUsuario_RowDataBound(object sender, GridViewRowEventArgs e)
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
            e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'CadastroUsuario.aspx?USR_ID=" + gvUsuario.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvUsuario.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvUsuario.Columns.IndexOf(field);
            }
        }
        return -1;
    }

    private void AddSortImage(int columnIndex, GridViewRow headerRow)
    {
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
        headerRow.Cells[columnIndex].Controls.Add(sortImage);
    }

    protected void gvUsuario_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvUsuario_Sorting(Object sender, GridViewSortEventArgs e)
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

        Usuario Usuario = new Usuario();
        filtro = CriaFiltro(Usuario);
        DataSet dtUsuario = Usuario.Consultar();

        DataTable tblUsuario = dtUsuario.Tables[0];
        DataView dvUsuario = new DataView(tblUsuario);
        dvUsuario.Sort = e.SortExpression + Ordem;
        gvUsuario.DataSource = dvUsuario;
        gvUsuario.DataBind();

        dvUsuario.Dispose();
        tblUsuario.Dispose();
        dtUsuario.Dispose();
        Dispose();
    }
}
