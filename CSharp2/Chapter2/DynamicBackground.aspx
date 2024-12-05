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

                    lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                    
                 lblMessage.ForeColor = System.Drawing.Color.Purple;
                    
                 
                    break;
                 }
                  case 1:
                {
                    lblMessage.BackColor = System.Drawing.Color.Snow;

                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    
                               
                    
                    

                    break;
                 }
                
        }

        }
 </script>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ccccff">
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
    <asp:Label ID="lblMessage" runat="server" Text="Welcome TO SBI" Font-Size="XX-Large" Font-Bold="True" BackColor="#FFFFCC"></asp:Label>
</ContentTemplate>
</asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
