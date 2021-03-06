<%@ Application Language="C#" %>
<%@ Import Namespace="System.IdentityModel.Services.Configuration" %>
<%@ Import Namespace="System.IdentityModel.Services" %>

<script runat="server">
//<Snippet1>
    void Application_Init()
    {
        // Code that runs on application init.
        FederatedAuthentication.WSFederationAuthenticationModule.RedirectingToIdentityProvider += new EventHandler<RedirectingToIdentityProviderEventArgs>(WSFederationAuthentication_RedirectingToIdentityProvider);
    }  

//</Snippet1>   
      


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
        // Code that runs when an unhandled error occurs

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

    //<Snippet2>
    void WSFederationAuthentication_RedirectingToIdentityProvider(object sender, RedirectingToIdentityProviderEventArgs e)
    {
        string homeRealmSts = HttpContext.Current.Request.QueryString["whr"];
    
        if (!String.IsNullOrEmpty(homeRealmSts))
        {
            e.SignInRequestMessage.Parameters.Add("whr", homeRealmSts);
        }
    }
    //</  Snippet2> 
</script>
