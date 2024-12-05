<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text += "<br /> Button Click";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Page Load";
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        Label1.Text += "<br /> Page PreRender";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="Click Here" 
            onclick="Button1_Click" />

            <br /><br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
