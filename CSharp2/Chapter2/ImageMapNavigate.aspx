<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
   
   
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="mapNavigate" runat="server" Height="266px" 
            ImageUrl="~/images/eu1.jpg" Width="397px">
            <asp:RectangleHotSpot NavigateUrl="~/ShowTextBox.aspx" Left="0" Top="0" Right="100" Bottom="50" AlternateText="Navigate to Home" Target="_blank"/>
            <asp:RectangleHotSpot NavigateUrl="~/ShowLabel.aspx" Left="100" Top="0" Right="200" Bottom="50" AlternateText="Navigate to product" Target="_blank" />
            <asp:RectangleHotSpot NavigateUrl="~/ShowCheckBox.aspx" Left="200" Top="0" Right="300" Bottom="50" AlternateText="Navigate to Home" />
        </asp:ImageMap>
    
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
