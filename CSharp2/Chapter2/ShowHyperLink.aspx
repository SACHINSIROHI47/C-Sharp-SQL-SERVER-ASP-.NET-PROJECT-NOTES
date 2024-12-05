<%@ Page Language="C#" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        lnkRandom.NavigateUrl = GetRandomFile();
    }
    String GetRandomFile()
    {
        string[] files = Directory.GetFiles(MapPath(Request.ApplicationPath), "*.aspx");
        Random rnd = new Random();
        string rndFile = files[rnd.Next(files.Length)];
        return Path.GetFileName(rndFile);

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:HyperLink ID="lnkRandom" runat="server">Random Link</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="lnkShooping" runat="server" 
            NavigateUrl="~/ButtonExpando.aspx">Shopping</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
