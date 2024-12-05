<%@ Page Language="C#" StylesheetTheme="DynamicSkin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        grdMovies.CssClass = ddlCSSClass.SelectedItem.Text;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <asp:GridView ID="grdMovies" runat="server" DataSourceID="srcMovies" Font-Size="Larger" HeaderStyle-CssClass="Header" AlternatingRowStyle-CssClass="Alternating" >
           
        </asp:GridView>
        <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="<%$ ConnectionStrings:Movies %>"
         SelectCommand="SELECT id,Title,Director FROM Movies" />
         <hr />
    </div>
        <asp:Label ID="lblCSSClass" runat="server" Text="Select Style"></asp:Label>&nbsp;
        <asp:DropDownList ID="ddlCSSClass" runat="server">
            <asp:ListItem>Professional</asp:ListItem>
            <asp:ListItem>Colorful</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Select" />
    </form>
</body>
</html>
