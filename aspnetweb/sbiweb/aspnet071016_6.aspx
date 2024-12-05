<%@ Page Language="C#" Trace="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Hello World";
        Calendar1.TodaysDate = DateTime.Now;
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
           Response.Redirect("branch.htm");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Calendar ID="Calendar1" runat="server" 
            onselectionchanged="Calendar1_SelectionChanged">
            <TodayDayStyle BackColor="#FFFF66" />
        </asp:Calendar>
    </div>
    </form>
</body>
</html>
