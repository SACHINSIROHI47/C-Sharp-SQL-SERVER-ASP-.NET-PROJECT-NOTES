<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal" 
            onmenuitemclick="Menu1_MenuItemClick">
            <Items>
                <asp:MenuItem  Text="Products" Value="Products">
                </asp:MenuItem>
                <asp:MenuItem Text="Services" Value="Services">
                </asp:MenuItem>
                <asp:MenuItem  Text="Training" Value="Training">
                </asp:MenuItem>
                <asp:MenuItem  Text="Consulting" 
                    Value="Consulting"></asp:MenuItem>
            </Items>
        </asp:Menu>
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
