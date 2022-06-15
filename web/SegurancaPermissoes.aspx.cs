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
            CarregaMenu();
        }

    }

    protected void btLimpar_Click(object sender, EventArgs e)
    {
        cbo_pfl.Text = "";
        cbo_mnu.Text = "";
    }

    protected void btFiltro_Click(object sender, EventArgs e)
    {
        dvFiltro.Visible = true;
        dvResultado.Visible = false;
    }

    protected string CriaFiltro(PerfilMenu PerfilMenu)
    {
        string filtro = "";
        if (!String.IsNullOrEmpty(cbo_pfl.Text))
        {
            PerfilMenu.PFL_MNU_PFL_ID = Convert.ToInt16(cbo_pfl.Text);
            filtro = filtro + "Perfil= " + cbo_pfl.SelectedItem.Text + "; ";
        }
        if (!String.IsNullOrEmpty(cbo_mnu.Text))
        {
            PerfilMenu.PFL_MNU_MNU_ID = Convert.ToInt16(cbo_mnu.Text);
            filtro = filtro + "Menu= " + cbo_mnu.SelectedItem.Text + "; ";
        }
        return filtro;
    }

    protected void btProcurar_Click(object sender, EventArgs e)
    {
        string filtro = "";

        PerfilMenu PerfilMenu = new PerfilMenu();
        filtro = CriaFiltro(PerfilMenu);
        DataSet dtPFL = PerfilMenu.ConsultarPerfil();

        gvPerfilMenu.DataSource = dtPFL;
        gvPerfilMenu.DataBind();

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

    protected void gvPerfilMenu_RowDataBound(object sender, GridViewRowEventArgs e)
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
            e.Row.Attributes.Add("onClick", "JavaScript:window.top.frameprincipal.location = 'CadastroPermissoes.aspx?PFL_ID=" + gvPerfilMenu.DataKeys[e.Row.RowIndex][0].ToString() + "'");

            PerfilMenu PerfilMenu = new PerfilMenu();
            PerfilMenu.PFL_MNU_PFL_ID = System.Convert.ToInt16(gvPerfilMenu.DataKeys[e.Row.RowIndex][0].ToString());
            DataSet dtPFL = PerfilMenu.Consultar();
            DataTable tblPFL = dtPFL.Tables[0];

            string sMenu = String.Empty;
            if (tblPFL.Rows.Count > 0)
            {
                foreach (DataRow drPFL in tblPFL.Rows)
                {
                    for (int i = 1; i <= Convert.ToInt16(drPFL["MNU_NVL"].ToString()); i++)
                    {
                        sMenu = sMenu + "&nbsp;&nbsp;";
                    }
                    sMenu = sMenu + drPFL["MNU_TIT"].ToString() + "<br/>";
                    
                }
            }
            e.Row.Cells[1].Text = sMenu;

            tblPFL.Dispose();
            dtPFL.Dispose();
            Dispose();
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
        foreach (DataControlField field in gvPerfilMenu.Columns)
        {
            if (field.SortExpression == (string)ViewState["SortExpression"])
            {
                return gvPerfilMenu.Columns.IndexOf(field);
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

    protected void gvPerfilMenu_RowCreated(object sender, GridViewRowEventArgs e)
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

    protected void gvPerfilMenu_Sorting(Object sender, GridViewSortEventArgs e)
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

        PerfilMenu PerfilMenu = new PerfilMenu();
        filtro = CriaFiltro(PerfilMenu);
        DataSet dtPerfilMenu = PerfilMenu.Consultar();

        DataTable tblPerfilMenu = dtPerfilMenu.Tables[0];
        DataView dvPerfilMenu = new DataView(tblPerfilMenu);
        dvPerfilMenu.Sort = e.SortExpression + Ordem;
        gvPerfilMenu.DataSource = dvPerfilMenu;
        gvPerfilMenu.DataBind();
    
        dvPerfilMenu.Dispose();
        tblPerfilMenu.Dispose();
        dtPerfilMenu.Dispose();
        Dispose();
    }

    protected void CarregaPerfil()
    {
        cbo_pfl.Items.Clear();
        cbo_pfl.AppendDataBoundItems = true;
        cbo_pfl.Items.Insert(0, "");

        Perfil Perfil = new Perfil();
        DataSet dtPerfil = Perfil.Consultar();

        cbo_pfl.DataTextField = "pfl_DES";
        cbo_pfl.DataValueField = "pfl_ID";

        cbo_pfl.DataSource = dtPerfil;
        cbo_pfl.DataBind();

        dtPerfil.Dispose();
        Dispose();

    }

    protected void CarregaMenu()
    {
        cbo_mnu.Items.Clear();
        cbo_mnu.Items.Add(new ListItem("", ""));
        FWBDS.Menu Menu = new FWBDS.Menu();
        DataSet dtMenu = Menu.Consultar();

        DataTable tblMenu = dtMenu.Tables[0];
        if (tblMenu.Rows.Count > 0)
        {
            int iCount = 1;
            foreach (DataRow drCurrent in tblMenu.Rows)
            {
                string sMenu = String.Empty;
                for (int i = 1; i <= Convert.ToInt16(drCurrent["MNU_NVL"].ToString()); i++)
                {
                    sMenu = sMenu + "\xa0\xa0";
                }
                sMenu = sMenu + drCurrent["MNU_TIT"].ToString();
                cbo_mnu.Items.Add(new ListItem(sMenu, drCurrent["MNU_ID"].ToString()));
                if (String.IsNullOrEmpty(drCurrent["MNU_URL"].ToString()))
                {
                    cbo_mnu.Items[iCount].Attributes.Add("disabled", "true");
                }

                iCount = iCount + 1;
            }
        }

        tblMenu.Dispose();
        dtMenu.Dispose();
        Dispose();
    }
}
