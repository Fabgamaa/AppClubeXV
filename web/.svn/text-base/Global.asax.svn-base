<%@ Application Language="C#" %>

<script runat="server">
    //Variavel que recebe o caminho do erro
    private string CaminhoArquivoErro = String.Empty;
    
    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        
    }
        
    void Application_Error(object sender, EventArgs e) 
    {
        /*
        CaminhoArquivoErro = Server.MapPath(".").ToString() + ConfigurationManager.AppSettings["FWLocalLogErro"].ToString();

        FWERR Erro = new FWERR();

        Erro.Data = DateTime.Now;
        Erro.MsgErro = Server.GetLastError().Message.ToString();
        Erro.Trace = Server.GetLastError().StackTrace.ToString();
        Erro.URL = Request.Url.ToString();

        Erro.SalvarLogErro(CaminhoArquivoErro);

        Response.Redirect("ErroGenerico.aspx?MsgErro=" + Erro.MsgErro + "&URL=" + Erro.URL + "&ErroGravar=" + Erro.ErroGravar);
        */
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started
    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
