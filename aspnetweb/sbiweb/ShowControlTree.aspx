<%@ Page Language="C#" Trace="True" %>

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
         <asp:DropDownList ID="DropDownList1" runat="server">
         <asp:ListItem Text="Oranges" />
         <asp:ListItem Text="Apples" />
         </asp:DropDownList>
         <br />
         <asp:ListItem Text="Oranges" /><br />

         <asp:Button id="Button1" Text="Submit" runat="server" />
    </div>
   
    </form>
</body>
</html>
