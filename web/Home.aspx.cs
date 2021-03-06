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
        if (Session["USR"]==null || Session["USR"].Equals(""))
        {
            Response.Redirect("Default.aspx?Msg=1");
        }

        Usuario Usuario = new Usuario();
        Usuario.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        DataSet dsUsuario = Usuario.Consultar();
        if (dsUsuario.Tables[0].Rows.Count > 0 && !String.IsNullOrEmpty(dsUsuario.Tables[0].Rows[0]["USR_MNU_ID"].ToString()))
        {
            FWBDS.Menu Menu = new FWBDS.Menu();
            Menu.MNU_ID = Convert.ToInt32(dsUsuario.Tables[0].Rows[0]["USR_MNU_ID"]);
            DataSet dsMenu = Menu.Consultar();
            if (dsMenu.Tables[0].Rows.Count > 0 && !String.IsNullOrEmpty(dsMenu.Tables[0].Rows[0]["MNU_URL"].ToString()))
            {
                Response.Write("<script  type='text/javascript' language='JavaScript'>window.top.frameprincipal.location = '" + dsMenu.Tables[0].Rows[0]["MNU_URL"].ToString() + "';</script>");
            }
        }

    }
}
