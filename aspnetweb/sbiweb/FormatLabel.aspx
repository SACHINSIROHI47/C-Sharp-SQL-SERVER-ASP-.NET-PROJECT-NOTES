<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
div
{
    padding:10px;
}
.lablelStyle
{
    color:Red;
    background-color:Yellow;
    border:Groove 3px Red;
}
</style>
    <title>Format Label</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblFirst" runat="server" Text="First Label" BackColor="#FFFF66" 
            BorderColor="#FF3300" BorderStyle="Solid" BorderWidth="2px" ForeColor="#FF3300"></asp:Label>
        <br />
        <br />

        <asp:Label ID="lblSecond" runat="server" Text="Second Label" 
            CssClass="lablelStyle"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblThird" runat="server" CssClass="lablelStyle" Text="Third Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFourth" runat="server" BackColor="#E1FBFB" 
            BorderColor="#009900" BorderStyle="Dotted" BorderWidth="4px" Font-Bold="True" 
            Font-Names="Aldhabi" Font-Overline="False" Font-Size="Larger" 
            ForeColor="#FF3300" Text="Fourth Label" ToolTip="RG(PG) Colege Meerut"></asp:Label>
    </div>
    </form>
</body>
</html>
