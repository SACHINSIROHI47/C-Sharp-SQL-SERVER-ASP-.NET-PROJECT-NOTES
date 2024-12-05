<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    div
    {
        padding:50px;
    }
    .labelStyle
    {
        color:Red;
        background-color:Yellow;
        border:Solid 4px Red;
    }
     .textStyle2
    {
        color:Purple;
        background-color:Pink;
        border:Dotted 6px Yellow;
    }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFirst"
         runat="server"
         Text="First Label"
         ForeColor="Red"
         BorderStyle="Solid" BorderWidth="2px"
         BorderColor="#FF9900" />

        <asp:Label ID="lblSecond" runat="server" Text="Second Label" CssClass="labelStyle" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" CssClass="labelStyle" Text="Label"></asp:Label>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="textStyle2"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" CssClass="labelStyle" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" CssClass="textStyle2"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" CssClass="textStyle2" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" CssClass="labelStyle"></asp:TextBox>
        <br /><br />
        <asp:Label ID="Label4" runat="server" Text="Label">Customer Address</asp:Label>

        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Visit Again" 
            ToolTip="You are Welcome to Our Branch"></asp:Label>

    </div>
    </form>
</body>
</html>
