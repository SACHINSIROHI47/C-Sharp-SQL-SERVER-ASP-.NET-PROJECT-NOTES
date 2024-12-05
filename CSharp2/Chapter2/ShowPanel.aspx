<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (rdOther.Checked)
              pnlOther.Visible = true;
       
        else
            pnlOther.Visible = false;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select your favorite programming language:<br />
        <br />
        <asp:RadioButton ID="rdVisualBasic" runat="server" GroupName="language" 
            Text="Visual Basic" />
        <br />
        <asp:RadioButton ID="rdCSharp" runat="server" GroupName="language" 
            Text="C Sharp" />
        <br />
        <asp:RadioButton ID="rdOther" runat="server" GroupName="language" 
            Text="Other" />

         <br />
    
        <br />
        <asp:Panel ID="pnlOther" runat="server" BackColor="#FFE8C4" Height="66px" 
            Width="350px" Visible="False" HorizontalAlign="Center" ScrollBars="Auto">
            <br />
           &nbsp;&nbsp; <asp:Label ID="lblOther" runat="server" Text="Other language" 
                AssociatedControlID="txtOther"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtOther" runat="server"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;
            </asp:Panel>
        <br />
        <asp:Button ID="btnSubmit" runat="server" onclick="btnSubmit_Click" 
            Text="Submit" />
        <br />
    
    </div>
    </form>
</body>
</html>
