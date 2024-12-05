<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        if(PreviousPage != null)
        {
            TextBox txtSearch = (TextBox)PreviousPage.FindControl("txtSearch");
            lblSearch.Text = String.Format("Search for: {0}",txtSearch.Text);
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblSearch" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
