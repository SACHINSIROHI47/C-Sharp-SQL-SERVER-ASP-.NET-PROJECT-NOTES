<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    html
    {
       background-color:Orange;
    }
    .navigation
    {
        float:left;
        width:280px;
        height:500px;
        padding:20px;
        background-color:Lime;
    }
    .content
    {
        float:left;
        width:550px;
        height:500px;
        padding:20px;
        background-color:White;
    }
    .menuItem
    {
        border:Outset 1px black;
        background-color:Green;
        font:14px Arial;
        color:Yellow;
        padding:8px;
    }       
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <asp:SiteMapDataSource id="srcSiteMap"  runat="server" />
    <div>
        <asp:Menu ID="Menu1" runat="server" DataSourceId="srcSiteMap" 
            StaticMenuItemStyle-CssClass="menuItem" 
            DynamicMenuItemStyle-CssClass="menuItem" Orientation="Horizontal" >
            <DynamicMenuItemStyle CssClass="menuItem" />
            <StaticMenuItemStyle CssClass="menuItem" />
        </asp:Menu>
        </asp:Menu>
    </div>
    </form>
</body>
</html>
