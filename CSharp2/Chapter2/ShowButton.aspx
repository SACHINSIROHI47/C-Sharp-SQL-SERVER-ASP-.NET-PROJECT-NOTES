﻿<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        lblTime.Text = DateTime.Now.ToString("T");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
            Text="Submit" Enabled="False" />
        <br />
        <br />
        <asp:Label ID="lblTime" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>