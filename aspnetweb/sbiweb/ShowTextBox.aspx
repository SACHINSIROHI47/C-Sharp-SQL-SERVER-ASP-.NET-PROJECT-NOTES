<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtUserName" runat="server" AccessKey="u" />
        <br /><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" AccessKey="p"></asp:TextBox>
        <br /><br />
        <asp:TextBox ID="txtComents" runat="server" TextMode="MultiLine" AccessKey="c" 
            Height="167px" Width="394px"></asp:TextBox>
        
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/sbi1.jpg" 
            Width="115px" />
        
    </div>
    </form>
</body>
</html>
