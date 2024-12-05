<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void txtSearch_TextChanged(object sender, EventArgs e)
    {
        lblSearchResult.Text = "Search for : " + txtSearch.Text;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblSearch" runat="server" Text="Search"></asp:Label>
        <asp:TextBox ID="txtSearch"  runat="server" AutoPostBack="True" 
            OnTextChanged="txtSearch_TextChanged" AutoCompleteType="FirstName" 
            Width="388px"></asp:TextBox>

        <hr />

        <asp:Label ID="lblSearchResult" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
