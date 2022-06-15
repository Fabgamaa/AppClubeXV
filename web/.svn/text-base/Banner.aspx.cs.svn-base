using System;
using System.Data;
using System.Configuration;
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
        if (Session["USR"] == null)
        {
            Response.Redirect("Default.aspx?Msg=1");
        }
        Session["Banner"] = "True";

        hpage.Value = "BemVindo.aspx";

        Usuario Usuario = new Usuario();
        Usuario.USR_ID = Convert.ToInt32(Session["USR_ID"].ToString());
        DataSet dsUsuario = Usuario.Consultar();
        if (dsUsuario.Tables[0].Rows.Count >0 && !String.IsNullOrEmpty(dsUsuario.Tables[0].Rows[0]["USR_MNU_ID"].ToString()))
        {
            FWBDS.Menu Menu = new FWBDS.Menu();
            Menu.MNU_ID = Convert.ToInt32(dsUsuario.Tables[0].Rows[0]["USR_MNU_ID"]);
            DataSet dsMenu = Menu.Consultar();
            if (dsMenu.Tables[0].Rows.Count >0 && !String.IsNullOrEmpty(dsMenu.Tables[0].Rows[0]["MNU_URL"].ToString()))
            {
                Response.Write("<script  type='text/javascript' language='JavaScript'>window.top.frameprincipal.location = '"  + dsMenu.Tables[0].Rows[0]["MNU_URL"].ToString() + "';</script>");
                hpage.Value = dsMenu.Tables[0].Rows[0]["MNU_URL"].ToString();
            }
        }
    }


    protected string CarregaMenu()
    {
        string sMenu = "";

        PerfilMenu PerfilMenu = new PerfilMenu();

        DataSet dtMenu = PerfilMenu.CarregaMenuTopo(Session["USR_ID"].ToString());
        DataTable tblMenu = dtMenu.Tables[0];

        if (tblMenu.Rows.Count > 0)
        {
            sMenu = "addmenu(menu=['Menu0',60,1,180,1,'center',plain_style,1,'center',effect,,1,,,,,,,,,,";

            foreach (DataRow drCurrent in tblMenu.Rows)
            {
                if (drCurrent["MNU_URL"].ToString() == "")
                {
                    sMenu = sMenu + ",'" + drCurrent["MNU_TIT"] + "','show-menu=Menu" + drCurrent["MNU_ID"] + " target=frameprincipal;sourceframe=frameprincipal;',,'#',1";
                }
                else
                {
                    sMenu = sMenu + ",'" + drCurrent["MNU_TIT"] + "','" + drCurrent["MNU_URL"] + "?MNU_ID=" + drCurrent["MNU_ID"] + " target=frameprincipal;sourceframe=frameprincipal;',,,1";
                }
            }
            sMenu = sMenu + "]);";

        }

        tblMenu.Dispose();
        dtMenu.Dispose();
        Dispose();

        return sMenu;

    }
}
