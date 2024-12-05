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
        <asp:TextBox ID="txtUserName" runat="server" TextMode="SingleLine" Width="411px"></asp:TextBox>
        <br /><br />
        <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" Width="357px"></asp:TextBox>
        <br /><br />
        <asp:TextBox ID="txtComments" TextMode="MultiLine" runat="server" 
            Height="124px" Width="366px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Address "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" AccessKey="L"></asp:TextBox>
        <br />
    </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
