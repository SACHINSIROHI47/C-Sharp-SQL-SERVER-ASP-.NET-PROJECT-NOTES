<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        lblResult.Text = "All Page deleted";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnDelete" runat="server" Text="Delete Website" 
            onclick="btnDelete_Click" 
            onclientclick="return confirm('Are you sure?')" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
