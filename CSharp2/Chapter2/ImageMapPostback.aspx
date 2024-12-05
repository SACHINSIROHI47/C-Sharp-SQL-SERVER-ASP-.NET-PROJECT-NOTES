<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void mapMenu_Click(object sender, ImageMapEventArgs e)
    {
        switch (e.PostBackValue)
        {
            case "ToUpper":
                {
                    txtText.Text = txtText.Text.ToUpper();
                    break;
                }
            case "ToLower":
                {
                    txtText.Text = txtText.Text.ToLower();
                    break;
                }
            case "Erase":
                {
                    txtText.Text = String.Empty;
                    break;
                }
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ImageMap ID="mapMenu" runat="server" Height="164px" HotSpotMode="PostBack" 
            ImageUrl="~/images/eu1.jpg" Width="355px" OnClick="mapMenu_Click">
            <asp:RectangleHotSpot PostBackValue="ToUpper" Left="0" Top="0" Right="100" Bottom="30" AlternateText="To Uppercase" />
             <asp:RectangleHotSpot PostBackValue="ToLower" Left="100" Top="0" Right="200" Bottom="30" AlternateText="To Lowercase" />
              <asp:RectangleHotSpot PostBackValue="Erase" Left="200" Top="0" Right="300" Bottom="30" AlternateText="To Erase Text" />

        </asp:ImageMap>
    
        <br />
        <br />
        <asp:TextBox ID="txtText" runat="server" Columns="40" Rows="5" 
            TextMode="MultiLine"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
