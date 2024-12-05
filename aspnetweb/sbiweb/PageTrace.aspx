<%@ Page Language="C#" trace="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        for(int counter = 0; counter < 4;counter++)
        {
            ListBox1.Items.Add("item " +counter.ToString());
            Trace.Warn("counter=" + counter.ToString());
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
        <asp:ListBox ID="ListBox1" runat="server" />
    </div>
    </form>
</body>
</html>
