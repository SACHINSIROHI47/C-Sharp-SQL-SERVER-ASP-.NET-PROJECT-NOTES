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
        <asp:Literal ID="ltlFirst" Mode="PassThrough" Text="<hr />" runat="server"></asp:Literal>
        <br />  <br />

        <asp:Literal ID="ltlSecond" Mode="Encode" Text="<hr />" runat="server"></asp:Literal>
        <br />  <br />

        <asp:Literal ID="ltlThird Mode="TransForm" Text="<hr />" runat="server"></asp:Literal>
        <br />  <br />
       
        <asp:Label ID="Label1" runat="server" Text="Welcome To SBI"></asp:Label>
        <br />  <br />

         <asp:Literal ID="Literal1" Text="Welcome To HDFC" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
