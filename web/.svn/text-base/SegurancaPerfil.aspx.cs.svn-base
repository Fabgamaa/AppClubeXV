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
            CarregaPerfil();
        }
    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        txt_des.Text = "";
        cbo_pfl_rsp.Text = "";
        cbo_sts.Text = "";
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
    }

    protected string CriaFiltro(Perfil Perfil)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(txt_des.Text))
        {
            Perfil.PFL_DES = txt_des.Text;
            filtro = filtro + "Descrição= " + txt_des.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_pfl_rsp.Text))
        {
            Perfil.PFL_PFL_RSP_ID = Convert.ToInt16(cbo_pfl_rsp.Text);
            filtro = filtro + "Perfil Responsável= " + cbo_pfl_rsp.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_sts.Text))
        {
            Perfil.PFL_STS = Convert.ToInt16(cbo_sts.Text);
            filtro = filtro + "Status= " + cbo_sts.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        Perfil Perfil = new Perfil();
        filtro = CriaFiltro(Perfil);
        DataSet dtPFL = Perfil.Consultar();

        gvPerfil.DataSource = dtPFL;
        gvPerfil.DataBind();

        dtPFL.Dispose();
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

    protected void gvPerfil_RowDataBound(object sender, GridViewRowEventArgs e)
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
            e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'CadastroPerfil.aspx?PFL_ID=" + gvPerfil.DataKeys[e.Row.RowIndex][0].ToString() + "'");
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
        foreach (DataControlField field in gvPerfil.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvPerfil.Columns.IndexOf(field);
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

    protected void gvPerfil_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvPerfil_Sorting(Object sender, GridViewSortEventArgs e)
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

        Perfil Perfil = new Perfil();
        filtro = CriaFiltro(Perfil);
        DataSet dtPerfil = Perfil.Consultar();

        DataTable tblPerfil = dtPerfil.Tables[0];
        DataView dvPerfil = new DataView(tblPerfil);
        dvPerfil.Sort = e.SortExpression + Ordem;
        gvPerfil.DataSource = dvPerfil;
        gvPerfil.DataBind();

        dvPerfil.Dispose();
        tblPerfil.Dispose();
        dtPerfil.Dispose();
        Dispose();
    }

    protected void CarregaPerfil()
    {
        cbo_pfl_rsp.Items.Clear();
        cbo_pfl_rsp.AppendDataBoundItems = true;
        cbo_pfl_rsp.Items.Insert(0, "");

        Perfil Perfil = new Perfil();
        DataSet dtPerfil = Perfil.Consultar();

        cbo_pfl_rsp.DataTextField = "PFL_DES";
        cbo_pfl_rsp.DataValueField = "PFL_ID";

        cbo_pfl_rsp.DataSource = dtPerfil;
        cbo_pfl_rsp.DataBind();

        dtPerfil.Dispose();
        Dispose();

    }
}
