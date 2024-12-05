<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TreeView ID="TreeView1" runat="server" BackColor="#FFFFC0" LineImagesFolder="~/TreeLineImages"
            ShowCheckBoxes="Leaf" ShowLines="True">
            <HoverNodeStyle BackColor="#FFC0FF" />
            <Nodes>
                <asp:TreeNode ImageToolTip="Display Home Page" ImageUrl="~/images/new1.gif" NavigateUrl="~/FormatLabel.aspx"
                    SelectAction="Expand" Text="Home" ToolTip="Display Home Page" Value="Home">
                    <asp:TreeNode Expanded="False" ImageToolTip="Product Details" Text="Products" Value="Products">
                        <asp:TreeNode Text="First Product" Value="First Product"></asp:TreeNode>
                        <asp:TreeNode Text="Second Product" Value="Second Product"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode ImageToolTip="Services Details" ImageUrl="~/images/Red.gif" Selected="True"
                        ShowCheckBox="True" Text="Services" Value="Services">
                        <asp:TreeNode Text="First Service" Value="First Service"></asp:TreeNode>
                        <asp:TreeNode Text="Second Service" Value="Second Service"></asp:TreeNode>
                    </asp:TreeNode>
                </asp:TreeNode>
            </Nodes>
        </asp:TreeView>
    
    </div>
    </form>
</body>
</html>
