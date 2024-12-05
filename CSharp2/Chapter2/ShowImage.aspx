<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {
        Random rnd = new Random();
        switch (rnd.Next(3))
        {
            case 0:
                {
                    imgRandom.ImageUrl = "~/images/cat.jpg";
                    imgRandom.AlternateText = "Cat.jpg";
                    break;
                }
            case 1:
                {
                    imgRandom.ImageUrl = "~/images/JACK.jpg";
                    imgRandom.AlternateText = "JACK.jpg";
                    break;
                }
            case 2:
                {
                    imgRandom.ImageUrl = "~/images/life.jpg";
                    imgRandom.AlternateText = "life.jpg";
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
    
        <asp:Image ID="imgRandom" runat="server" Height="229px" Width="332px" />
    
    </div>
    </form>
</body>
</html>
