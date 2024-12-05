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
        <asp:TreeView ID="TreeView1" runat="server" CollapseImageUrl="~/TreeLineImages/lplus.gif"
            ExpandImageToolTip="Expand Node" ExpandImageUrl="~/images/new1.gif" CollapseImageToolTip="Collapse Node">
            <Nodes>
                <asp:TreeNode Text="Home" Value="Home">
                    <asp:TreeNode Text="Products" Value="Products">
                        <asp:TreeNode Text="Firsrt Product" Value="Firsrt Product">
                            <asp:TreeNode Text="Electrcals" Value="Electrcals"></asp:TreeNode>
                            <asp:TreeNode Text="Electronics" Value="Electronics"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Second Product" Value="Second Product"></asp:TreeNode>
                    </asp:TreeNode>
                    <asp:TreeNode Text="Services" Value="Services">
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
