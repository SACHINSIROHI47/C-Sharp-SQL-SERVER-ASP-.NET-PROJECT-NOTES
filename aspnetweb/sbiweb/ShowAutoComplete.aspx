<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtFirstName.Text.Length == 0)
        {
           txtFirstName.BackColor = System.Drawing.Color.Red;
           txtFirstName.Focus();
        }        
        else if (txtLastName.Text.Length == 0)
        {
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
            txtLastName.BackColor = System.Drawing.Color.Red;
            txtLastName.Focus();
        }
        else if (txtPhoneNo.Text.Length == 0)
        {
           txtLastName.BackColor = System.Drawing.Color.Yellow;
           txtPhoneNo.BackColor = System.Drawing.Color.Red;
           txtPhoneNo.Focus();
        }
        else
        {               
            txtPhoneNo.BackColor = System.Drawing.Color.Yellow;
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
        <asp:Label ID="lblFirstName" runat="server" Text="First name" AssociatedControlID="txtFirstName" />
        <br /> 
        <asp:TextBox ID="txtFirstName" runat="server" AutoCompleteType="FirstName"></asp:TextBox> 
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" AssociatedControlID="txtLastName" 
            Text="Last Name"></asp:Label>
        <br />
        <asp:TextBox ID="txtLastName" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPhoneNo" runat="server" AssociatedControlID="txtPhoneNo" 
            Text="Phone No"></asp:Label>
        <br />
        <asp:TextBox ID="txtPhoneNo" runat="server" AutoCompleteType="HomePhone"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
            Text="Submit" />
    </div>
    </form>
</body>
</html>
