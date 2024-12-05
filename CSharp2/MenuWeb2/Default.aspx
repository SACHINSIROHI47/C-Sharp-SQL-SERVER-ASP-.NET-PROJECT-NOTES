<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffffcc">
    <form id="form1" runat="server">
    <div>
    
        <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
            <Items>
                <asp:MenuItem NavigateUrl="~/Products.aspx" Text="Products" Value="Products">
                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Services.aspx" Text="Services" Value="Services">
                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Training.aspx" Text="Training" Value="Training">
                </asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Consulting.aspx" Text="Consulting" 
                    Value="Consulting"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        
        Welcome To SBI</div>
    </form>
</body>
</html>
