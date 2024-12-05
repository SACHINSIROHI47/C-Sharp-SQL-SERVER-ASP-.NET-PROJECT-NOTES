<%@ Page Language="C#" Trace="False" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Label1.Text = (Int32.Parse(Label1.Text) + 1).ToString();
        Label2.Text = (Int32.Parse(Label2.Text) + 1).ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Label 1:
        <asp:Label ID="Label1" EnableViewState="false" runat="server" Text="0"></asp:Label>
        <br />
        
    Label 1:
        <asp:Label ID="Label2"  runat="server" Text="0"></asp:Label>
        <br /><br />
        
        <asp:Button ID="btnAdd" runat="server" Text="Button" OnClick="btnAdd_Click" />
        
    </div>
    </form>
</body>
</html>
