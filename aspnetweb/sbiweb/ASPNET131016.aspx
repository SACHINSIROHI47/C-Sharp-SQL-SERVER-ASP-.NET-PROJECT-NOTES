<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    public void myloop()
    {
        int num;
        for (num = 1; num <= 5; num++)
        {
            lblResult.Text = "number=" + Convert.ToString(num) + "<br />";
        }
    }
    protected void btrnShow_Click(object sender, EventArgs e)
    {
        myloop();
        lblResult.Text = "Bye";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="btrnShow" runat="server" onclick="btrnShow_Click" Text="Show" />
    <br />
    <br />
    <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
