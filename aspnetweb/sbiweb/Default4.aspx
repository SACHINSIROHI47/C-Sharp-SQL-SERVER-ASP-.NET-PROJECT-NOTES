<%@ Page Language="C#"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
      
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (txtUser.Text == "")
        {
            lblMessage.Text = "Please Enter User Name";
            txtUser.Focus();
        }
        else if (txtPassword.Text == "")
        {
            lblMessage.Text = "Please Enter Password";
            txtPassword.Focus();
        }
        else
        {
             String strUser, strPassword;
                strUser = txtUser.Text;
                strUser = strUser.ToLower();
                strPassword = txtPassword.Text;
               
                    if (strUser.Equals("admin") && strPassword.Equals("rgpg007"))
                    {
                        Response.Redirect("index.htm");
                        return;
                    }
                    else
                    {
                        lblMessage.Text = "Invalid User Name or Password";
                        txtUser.Text = "";
                        txtPassword.Text = "";
                        txtUser.Focus();
                    }
          
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 365px;
        }
        .style2
        {
            height: 143px;
        }
        .style3
        {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .style4
        {
            width: 230px;
        }
    </style>
</head>
<body bgcolor="#ff9900" style="height: 367px">
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td align="left" class="style2" valign="top">
                    <table class="style3">
                        <tr>
                            <td bgcolor="#FF3300" class="style4">
                                <asp:Label ID="Label1" runat="server" Text="User Id"></asp:Label>
                            </td>
                            <td bgcolor="#FF3300">
                                <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#FF3300" class="style4">
                                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                            </td>
                            <td bgcolor="#FF3300">
                                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td bgcolor="#FF3300" class="style4">
                                <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="OK" />
                            </td>
                            <td bgcolor="#FF3300">
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="left" valign="top">
                    <asp:Label ID="lblMessage" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
