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

    }

    protected string CarregaSubMenu(string Usuario)
    {

        string sMenu = "";
        int MenuPai = 0;
        int nMenu = 0;

        PerfilMenu PerfilMenu = new PerfilMenu();

        DataSet dtMenuSub = PerfilMenu.CarregaSubMenu(Session["USR_ID"].ToString());
        DataTable tblMenuSub = dtMenuSub.Tables[0];

        string iTop = "", iLeft = "", iWidth = "";
        if (tblMenuSub.Rows.Count > 0)
        {
            foreach (DataRow drCurrent in tblMenuSub.Rows)
            {
                if (MenuPai != Convert.ToInt16(drCurrent["MNU_REG_ID"].ToString()))
                {
                    if (nMenu != 0)
                    {
                        if (MenuPai != Convert.ToInt16(drCurrent["MNU_REG_ID"].ToString()))
                        {
                            sMenu = sMenu + "]);    ";
                        }
                    }
                    iWidth = drCurrent["MNU_LAR"].ToString();
                    if (Convert.ToInt16(drCurrent["MNU_NVL"].ToString()) == 1)
                    {
                        iTop = "100";
                        iLeft = "100";
                    }
                    if (Convert.ToInt16(drCurrent["MNU_NVL"].ToString()) == 2)
                    {
                        iTop = "";
                        iLeft = "";
                    }
                    sMenu = sMenu + "addmenu(menu=[";
                    sMenu = sMenu + "'Menu" + drCurrent["MNU_REG_ID"].ToString() + "',";		// Menu items Name
                    sMenu = sMenu + iTop + ",";                                                 // Top
                    sMenu = sMenu + iLeft + ",";				                                // left
                    sMenu = sMenu + iWidth + ",";						                        // Width
                    sMenu = sMenu + "1,";							                            // Border Width
                    sMenu = sMenu + ",";							                            // Screen Position - here you can use "center;left;right;middle;top;bottom"
                    sMenu = sMenu + "plain_style,";				                                // Properties Array - this is set higher up, as above
                    sMenu = sMenu + "0,";							                            // Always Visible - allows the menu item to be visible at all time
                    sMenu = sMenu + "'left',";						                            // Alignment - sets the menu elements alignment, HTML values are valid here for example: left, right or center
                    sMenu = sMenu + "effect,";					                                // Filter - Text variable for setting transitional effects on menu activation
                    sMenu = sMenu + ",";						                                // Follow Scrolling - Tells the menu item to follow the user down the screen
                    sMenu = sMenu + "0,";							                            // Horizontal Menu - Tells the menu to be horizontal instead of top to bottom style
                    sMenu = sMenu + ",";							                            // Keep Alive - Keeps the menu visible until the user moves over another menu or clicks elsewhere on the page (1=on/0=off)
                    sMenu = sMenu + ",";							                            // Position of TOP sub image left:center:right
                    sMenu = sMenu + ",";							                            // Set the Overall Width of Horizontal Menu to 100% and height to the specified amount (Leave blank to disable)
                    sMenu = sMenu + ",";							                            // Right To Left - Used in Hebrew for example. (1=on/0=off)
                    sMenu = sMenu + ",";							                            // Open the Menus OnClick - leave blank for OnMouseover (1=on/0=off)
                    sMenu = sMenu + ",";							                            // ID of the div you want to hide on MouseOver (useful for hiding form elements)
                    sMenu = sMenu + ",";							                            // Background image for menu when BGColor set to transparent.
                    sMenu = sMenu + ",";							                            // Scrollable Menu
                    sMenu = sMenu + ",";							                            // Reserved for future use

                }
                if (drCurrent["MNU_URL"].ToString() == "")
                {
                    sMenu = sMenu + ",'" + drCurrent["MNU_TIT"].ToString() + "','show-menu=Menu" + drCurrent["MNU_ID"].ToString() + "',,'#',1";
                }
                else
                {
                    if (drCurrent["MNU_URL"].ToString().IndexOf("&") >= 0)
                    {
                        sMenu = sMenu + ",'" + drCurrent["MNU_TIT"].ToString() + "','" + drCurrent["MNU_URL"].ToString() + "',,,1"; // "Description Text", "URL", "Alternate URL", "Status", "Separator Bar"
                    }
                    else
                    {
                        sMenu = sMenu + ",'" + drCurrent["MNU_TIT"].ToString() + "','" + drCurrent["MNU_URL"].ToString() + "',,,1"; // "Description Text", "URL", "Alternate URL", "Status", "Separator Bar"
                    }
                }
                MenuPai = Convert.ToInt16(drCurrent["MNU_REG_ID"].ToString());
                nMenu = nMenu + 1;
            }
            sMenu = sMenu + "]);\n";
        }
        tblMenuSub.Dispose();
        dtMenuSub.Dispose();

        return sMenu;
    }
}