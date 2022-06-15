<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Frameset//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title><% Response.Write(ConfigurationManager.AppSettings["Titulo"]); %></title>
</head>
    <frameset rows="80,*" frameborder="NO" border="0" framespacing="0">		
        <frame src="banner.aspx" name="framemenu" id="framemenu" target="frameprincipal" scrolling="no">	
        <%if (Convert.ToString(Session["USR"]).ToString().ToUpper().Equals("RODRIGOM"))
          {
              if (!Convert.ToString(Session["PFL_URL_INI"]).Equals(""))
              {%>		
                    <frame src="<%=Convert.ToString(Session["PFL_URL_INI"])%>" name="frameprincipal" id="frameprincipal">
             <%
            }
              else
              {
                  %><frame src="BemVindo.aspx" name="frameprincipal" id="frameprincipal">	<%
                  
              }
              
          }
          else
          {%>
            <frame src="BemVindo.aspx" name="frameprincipal" id="frameprincipal">		
        <%} %>
    </frameset>
</html>
