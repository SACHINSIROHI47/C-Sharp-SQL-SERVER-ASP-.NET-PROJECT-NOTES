<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 0; i < 3; i++)
            bltList.Items.Add("Item " + i.ToString());
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    html
    {
       background-color:Silver;   
    }
    .contents
    {
        background-color:White;
        width:200px;
        height:200px;
    }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="pnlContent" runat="server" Height="176px" Width="310px" 
            CssClass="contents" ScrollBars="Auto">
            <asp:BulletedList ID="bltList" runat="server">
            </asp:BulletedList>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
