<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body background="../Images/eu1.jpg">
    <form id="form1" runat="server">
      <asp:SiteMapDataSource id="nav1" runat="server" />
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="First Product Details"></asp:Label>
     <asp:Menu ID="Menu11" runat="server" DataSourceId="nav1" />
        <br />
    
    </div>
    </form>
</body>
</html>
