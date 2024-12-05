<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnElephant_Click(object sender, ImageClickEventArgs e)
    {
        lblX.Text = e.X.ToString();
        lblY.Text = e.Y.ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="btnElephant" runat="server" ImageUrl="~/images/sbi2.jpg" 
            onclick="btnElephant_Click" />
        <br />
        X Corodiantes:
        <asp:Label ID="lblX" runat="server"></asp:Label>
        <br />
        Y Coordnates:
        <asp:Label ID="lblY" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
