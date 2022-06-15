using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using FWBDS;

public partial class Finaliza : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Verifica sesso ativa
        if (Session["USR"] != null)
        {
            Acesso LogAcesso = new Acesso();

            LogAcesso.ACS_ID = Convert.ToInt32(Session["ACS_ID"].ToString());
            LogAcesso.ACS_DAT_FNL = DateTime.Now;
            string sMsg = LogAcesso.Alterar();
            if (sMsg != "")
            {
                Response.Write(sMsg);
            }
        }
    }
}
