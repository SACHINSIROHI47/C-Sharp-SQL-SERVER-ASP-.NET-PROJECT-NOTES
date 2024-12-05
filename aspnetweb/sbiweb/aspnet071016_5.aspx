<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        lblCounter.Text = (Int32.Parse(lblCounter.Text) + 1).ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="True">
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" />
        &nbsp;&nbsp;
        <asp:Label ID="lblCounter" runat="server" Text="0"></asp:Label>
    </div>
    </form>
</body>
</html>
