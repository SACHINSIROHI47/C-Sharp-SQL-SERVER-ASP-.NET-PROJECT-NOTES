<%@ Page Language="C#" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            if (txtTo.Text.Length == 0)
            {
                lblMessage.Text = "Please enter To Address";
            }
            else if (txtFrom.Text.Length == 0)
            {
                lblMessage.Text = "Please enter From Address";
            }
            else if (txtSubject.Text.Length == 0)
            {
                lblMessage.Text = "Please enter Subject";
            }
            else if (txtMessage.Text.Length == 0)
            {
                lblMessage.Text = "Please enter Message";
            }
            else
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(txtFrom.Text);
                mail.To.Add(txtTo.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = txtMessage.Text;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("margoob3009@gmail.com", "rfchpabf@60");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                lblMessage.Text = "mail Send";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text=ex.ToString();
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#ffefdf">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="To"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTo" runat="server" Width="223px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="From"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtFrom" runat="server" Width="218px"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Subject"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSubject" runat="server" Width="340px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Message"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtMessage" runat="server" Height="112px" Width="411px"></asp:TextBox>
        <br />
    
    </div>
    <asp:Button ID="btnSend" runat="server" onclick="btnSend_Click" Text="Send" />
    <br />
    <br />
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
    </form>
</body>
</html>
