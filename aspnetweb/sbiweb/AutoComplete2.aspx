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
    Category:<br/>   
      <asp:textbox id="CategoryTextBox"
        autocompletetype="None" 
        runat="server"/>
        <br />
        <br />
        Education<br />
        <asp:TextBox ID="txtEducation" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="SEND" />
    </div>
    </form>
</body>
</html>
