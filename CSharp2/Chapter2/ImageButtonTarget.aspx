<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageButtonTarget.aspx.cs" Inherits="ImageButtonTarget" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="btnTarget" runat="server" AlternateText="India Gate" 
            DescriptionUrl="~/imageDelete.htm" ImageUrl="~/images/indiagate.jpg" 
            onclick="btnTarget_Click" />
        l<br />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
