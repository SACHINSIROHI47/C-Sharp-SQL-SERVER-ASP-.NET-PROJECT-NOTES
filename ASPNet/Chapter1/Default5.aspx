<%@ Page Language="C#" %>
<!-- We will use ASP.NET AdRotator control to create an Image Slider in ASP.NET -->
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>How to make an Image Slider in ASP.NET</title>
    <style type="text/css">
        .button
        {
            border-radius: 4px 4px 4px 4px;
            height: 30px;
            padding: 5px;
            font-size: 14px;
            background-color: #6ca21e;
            color: #FFFFFF;
        }
        body
        {
            background-color: #32373a;
color: #FFFFFF;
        }
        #mainBody
        {
            background-color: #FFFFFF;
            height: 100%;
            color: #32373a;
        }
        .UCHelp
        {
            height: 150px;
            margin-top: 20px;
            font-weight: bold;
        }
        .UserControlDiv
        {
width: 400px;
            margin: 10px;
            padding: 10px;
            border: 1px solid Gray;
            background-color: #fdd136;
        }
        #AdRotator1 img
        {
          height:100px !important;
          width:100px !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="mainBody">
        <h1>
                How to make an Image Slider in ASP.NET</h1>
        <br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <div class="UserControlDiv">
            <asp:UpdatePanel ID="up1" runat="server">
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnPrevious" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="btnNext" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                </Triggers>
                <ContentTemplate>
                    <asp:Timer ID="Timer1" Interval="1000" runat="server" />
                    <table>
                        <tr>
                            <td>
                                <asp:Button ID="btnPrevious" CssClass="button" runat="server" Text="Previous Random" />
                            </td>
                            <td>
                                <!-- We will use AdRotator control for creating an image slider in asp.net
                                ASP AdRotator control has an AdvertisementFile which contains the information related to different
                                //images that will be displayed randomly either using the timer1 or the previous next button click
                                 -->
                                <asp:AdRotator ID="AdRotator1" AdvertisementFile="App_Data/Ads.xml" KeywordFilter="small"
                                    runat="server" />
                            </td>
                            <td>
                                <asp:Button ID="btnNext" CssClass="button" runat="server" Text="Next Random" />
                            </td>
                        </tr>
                    </table>
</ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
    </form>
</body>
</html>
