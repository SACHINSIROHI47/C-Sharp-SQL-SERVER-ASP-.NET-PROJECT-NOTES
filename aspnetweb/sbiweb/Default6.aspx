<%@ Page Language="C#" %>
<%@ Import Namespace="MyFunctions" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnTotal_Click(object sender, EventArgs e)
    {
        if (txtNumber1.Text.Length == 0)
        {
            lblMessage.Text = "Enter Number1";
        }
        else if (txtNumber2.Text.Length == 0)
        {
            lblMessage.Text = "Enter Number2";
        }
        else
        {
            int var1, var2, var3;
            var1 = Convert.ToInt32(txtNumber1.Text);
            var2 = Convert.ToInt32(txtNumber2.Text);

            MyCalculation obj = new MyCalculation();
            var3 = obj.sum(var1, var2);

            lblMessage.Text = Convert.ToString(var3);
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
    
        <asp:Label ID="Label1" runat="server" Text="Number1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Number2"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnTotal" runat="server" onclick="btnTotal_Click" 
            Text="Total" />
    
    </div>
    </form>
</body>
</html>
