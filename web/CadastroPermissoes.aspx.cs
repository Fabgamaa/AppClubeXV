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

        if (PFL_ID.Value.Length == 0)
        {
            PFL_ID.Value = Convert.ToString(Request["PFL_ID"]);
        }
        if (MNU_ID.Value.Length == 0)
        {
            MNU_ID.Value = Convert.ToString(Request["MNU_ID"]);
        }

        if (PFL_ID.Value.Length > 0)
        {
            lbAcao.Text = "Alterar ";
        }
        else
        {
            lbAcao.Text = "Nova ";
        }

        if (!IsPostBack)
        {
            CarregaDados();
        }
    }

    protected void CarregaDados()
    {
        if (!String.IsNullOrEmpty(PFL_ID.Value))
        {
            PerfilMenu PerfilMenu = new PerfilMenu();
            PerfilMenu.PFL_MNU_PFL_ID = Convert.ToInt32(PFL_ID.Value);
            DataSet dtPerfilMenu = PerfilMenu.Consultar();

            DataTable tblPerfilMenu = dtPerfilMenu.Tables[0];
            if (tblPerfilMenu.Rows.Count > 0)
            {
                DataRow drCurrent = tblPerfilMenu.Rows[0];
                txt_pfl.Text = drCurrent["PFL_DES"].ToString();

            }
            gvPerfilMenu.DataSource = tblPerfilMenu;
            gvPerfilMenu.DataBind();

            tblPerfilMenu.Dispose();
            dtPerfilMenu.Dispose();
            Dispose();
        }
    }

    protected void btSalvar_Click(object sender, EventArgs e)
    {
        string sMsg = "";
        Msg.Text = "";

        foreach (GridViewRow Row in gvPerfilMenu.Rows)
        {
            PerfilMenu PerfilMenu = new PerfilMenu();
            PerfilMenu.PFL_MNU_ID = Convert.ToInt16(gvPerfilMenu.DataKeys[Row.RowIndex][0].ToString());
            PerfilMenu.PFL_MNU_PFL_ID = Convert.ToInt16(PFL_ID.Value);

            CheckBox cbo_csu = (CheckBox)Row.FindControl("ckPFL_MNU_CSU");
            PerfilMenu.PFL_MNU_CSU = cbo_csu.Checked;

            CheckBox cbo_alt = (CheckBox)Row.FindControl("ckPFL_MNU_ALT");
            PerfilMenu.PFL_MNU_ALT = cbo_alt.Checked;

            CheckBox cbo_noo = (CheckBox)Row.FindControl("ckPFL_MNU_NOO");
            PerfilMenu.PFL_MNU_NOO = cbo_noo.Checked;

            CheckBox cbo_exl = (CheckBox)Row.FindControl("ckPFL_MNU_EXL");
            PerfilMenu.PFL_MNU_EXL = cbo_exl.Checked;

            PerfilMenu.PFL_USR_ALT_ID = Convert.ToInt32(Session["USR_ID"].ToString());

            sMsg = PerfilMenu.Alterar();
            if (sMsg != "")
            {
                Msg.Text = "<br>" + sMsg;
                return;
            }

            Dispose();
        }

        if (sMsg == "")
        {
            Response.Write("<script language=\"javascript\">alert('Permissões de Perfil alterados com sucesso.')</script>");
        }
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

            if (((CheckBox)e.Row.Cells[1].FindControl("ckPFL_MNU_CSU")).Checked == false) 
            {
                ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).Enabled = false;
                ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).Enabled = false;
                ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).Enabled = false;
            }

            string strScript = "";
            strScript = "if(" + ((CheckBox)e.Row.Cells[1].FindControl("ckPFL_MNU_CSU")).ClientID + ".checked == true) ";
            strScript = strScript + " { " + ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).ClientID + ".checked = true; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).ClientID + ".disabled = false; ";
            // Ao executar Enbled = false no C# no HTML ficamos com o checkbox e o span como disabled, sendo assim precisamos do disable = false no SPAN também
            strScript = strScript + ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).ClientID + ".parentNode.disabled = false; "; 
            strScript = strScript + ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).ClientID + ".checked = true; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).ClientID + ".disabled = false; ";
            // Ao executar Enbled = false no C# no HTML ficamos com o checkbox e o span como disabled, sendo assim precisamos do disable = false no SPAN também
            strScript = strScript + ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).ClientID + ".parentNode.disabled = false; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).ClientID + ".checked = true; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).ClientID + ".disabled = false; ";
            // Ao executar Enbled = false no C# no HTML ficamos com o checkbox e o span como disabled, sendo assim precisamos do disable = false no SPAN também
            strScript = strScript + ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).ClientID + ".parentNode.disabled = false; }";
            strScript = strScript + " else ";
            strScript = strScript + " { " + ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).ClientID + ".checked = false; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[2].FindControl("ckPFL_MNU_ALT")).ClientID + ".disabled = true; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).ClientID + ".checked = false; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[3].FindControl("ckPFL_MNU_NOO")).ClientID + ".disabled = true; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).ClientID + ".checked = false; ";
            strScript = strScript + ((CheckBox)e.Row.Cells[4].FindControl("ckPFL_MNU_EXL")).ClientID + ".disabled = true; }";
            ((CheckBox)e.Row.Cells[1].FindControl("ckPFL_MNU_CSU")).Attributes.Add("onclick", strScript);

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

        PerfilMenu PerfilMenu = new PerfilMenu();
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

}
