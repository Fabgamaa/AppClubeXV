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

public partial class ApresentaAnexo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string sANX = Request.QueryString["ANX"].ToString();
        string sDES = Request.QueryString["DES"].ToString();
        
        int posicaoPonto = sANX.LastIndexOf(".");
        string tipoExtensao = sANX.Substring(posicaoPonto);

        Response.Clear();
        Response.ContentType = "application/octet-stream";
        Response.AddHeader("content-disposition", "attachment;filename=" + sDES + tipoExtensao);
        Response.WriteFile(sANX);
        Response.End();
        
    }
}
