using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Diagnostics;

public partial class Erro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        innerException.Visible = false;
        this.pagina.InnerHtml = this.Request["aspxerrorpath"];

        this.lblErro.Text = this.Request["Erro"];

        this.detalhes.Visible = Boolean.Parse(ConfigurationManager.AppSettings["ShowErrorDetails"].ToString());
        this.innerException.Visible = Boolean.Parse(ConfigurationManager.AppSettings["ShowErrorDetails"].ToString());
      
    }

}
