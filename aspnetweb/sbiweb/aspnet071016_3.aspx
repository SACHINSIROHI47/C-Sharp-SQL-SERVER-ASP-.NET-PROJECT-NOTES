<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Button_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        btn.Text = (Int32.Parse(btn.Text) + 1).ToString();
    }

    
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        First Counter :
        <asp:Button ID="Button1" runat="server" onclick="Button_Click" Text="0" />
    
        <br />
        <br />
        
        Second Counter :
        <asp:Button ID="Button2" runat="server" onclick="Button_Click" Text="0" />
        
    </div>
    </form>
</body>
</html>
