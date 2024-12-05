<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSubmit_Click(object sender, ImageClickEventArgs e)
    {
        lblResult.Text = "First Name: " + txtFirstName.Text;
        lblResult.Text += "<br /> Last Name: " + txtLastName.Text;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblFirstName" runat="server" Text="First Name" AccessKey="F" 
            AssociatedControlID="txtFirstName"></asp:Label>
    &nbsp;
        <asp:TextBox ID="txtFirstName" runat="server" AutoCompleteType="FirstName"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" AccessKey="L" 
            AssociatedControlID="txtLastName" Text="Last Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtLastName" runat="server" AutoCompleteType="LastName"></asp:TextBox>
        <br />
        <br />
        <asp:ImageButton ID="btnSubmit" runat="server" AlternateText="Submit Form" 
            ImageUrl="~/images/indiagate.jpg" onclick="btnSubmit_Click" />
        <br />
        <br />
         <asp:Label ID="lblResult" runat="server"></asp:Label>
        <br />
    </div>
    </form>
</body>
</html>
