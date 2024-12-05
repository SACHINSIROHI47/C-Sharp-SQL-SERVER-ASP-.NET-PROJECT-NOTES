<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnShow_Click(object sender, EventArgs e)
    {
        if (txtName.Text.Length == 0)
        {
            lblMessage.Text = "Please Enter your Name";
        }
        else
        {
            lblMessage.Text = "Welcome : " + txtName.Text;
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to State Bank of India</title>
</head>
<body bgcolor="#cbe2f8">
    <form id="form1" runat="server">
    <div>
    
        <marquee>State Bank of India</marquee><br />
        <br />
        Started in 1942<br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter Your Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Message"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnShow" runat="server" Text="Show" onclick="btnShow_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
