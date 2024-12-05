<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        ltlTitle.Text = DateTime.Now.ToString("D");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        <asp:Literal ID="ltlTitle" runat="server" /> </title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Look in the title bar</h1>
    </div>
    </form>
</body>
</html>
