using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbMsgErro.Text = Request["MsgErro"].ToString();
        lbURL.Text = Request["URL"].ToString();
        if (!String.IsNullOrEmpty(Request["ErroGravar"].ToString()))
        {
            lbLog.Text = Request["ErroGravar"].ToString();
            lbtitLog.Text = "Erro ao gravar LOG:";
        }
    }
}
