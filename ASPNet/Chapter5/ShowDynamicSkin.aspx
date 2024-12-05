<%@ Page Language="C#" Theme="DynamicSkin" %>
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Request["skin"] != null)
        {
            switch (Request["skin"])
            {
                case "professional":
                    grdMovies.SkinID = "Professional";
                    break;
                case "colorful":
                    grdMovies.SkinID = "Colorful";
                    break;
            }
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
    table
  
      
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdMovies" runat="server" DataSourceID="srcMovies" Font-Size="Larger">
           
        </asp:GridView>
        <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:Movies %>"
         SelectCommand="SELECT id,Title,Director FROM Movies" />
         <hr />
        <a href="ShowDynamicSkin.aspx?skin=professional">Professional</a>
        &nbsp;| &nbsp;
        <a href="ShowDynamicSkin.aspx?skin=colorful">Colorful</a> 
    </div>
    </form>
</body>
</html>
