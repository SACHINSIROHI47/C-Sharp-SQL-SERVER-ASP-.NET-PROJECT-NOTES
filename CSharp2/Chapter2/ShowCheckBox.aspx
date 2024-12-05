<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void chkNewLetteter_CheckedChanged(object sender, EventArgs e)
    {
        lblResult.Text = chkNewLetteter.Checked.ToString();
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox ID="chkNewLetteter" runat="server" Text="Receive New Letteter" 
            OnCheckedChanged="chkNewLetteter_CheckedChanged" AutoPostBack="True" 
            Checked="True" TextAlign="Left" />
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
        <br />
        <hr />
        <br />
        
        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>


    </div>
    </form>
</body>
</html>
