<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    protected void gettickvalue(object sender, EventArgs e)
    {
        Random RandomNumber = new Random();
        switch(RandomNumber.Next(2))
        {
            case 0:
                {
                    imgBanner.ImageUrl = "~/images/sbi.jpg";
                    break;
                 }
                  case 1:
                {
                    imgBanner.ImageUrl = "~/images/life.jpg";
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
        <asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:Timer ID="Timer1" runat="server" OnTick="gettickvalue" Interval="1000">
</asp:Timer>
<asp:UpdatePanel ID="BannerPanel" runat="server" UpdateMode="Conditional">
<Triggers >
<asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
</Triggers>
<ContentTemplate>
<asp:Image ID="imgBanner" ImageUrl="~/images/life.jpg" runat="server" 
        Height="153px" Width="228px" />
</ContentTemplate>
</asp:UpdatePanel>
    </div>
    </form>
</body>
</html>


