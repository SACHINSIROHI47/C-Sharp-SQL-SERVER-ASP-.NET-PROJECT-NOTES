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
    
        <asp:Menu ID="Menu1" runat="server" 
            Orientation="Horizontal">
            
             <StaticItemTemplate>
                <%# Eval("Text") %>
                 <%# Eval("ChildItems.Count") %>
            </StaticItemTemplate>
            <DynamicItemTemplate>
                <%# Eval("Text") %>
                 <%# Eval("ChildItems.Count") %>
            </DynamicItemTemplate>
            <Items>
                <asp:MenuItem Text="Products" Value="Products">
                    <asp:MenuItem Text="Computer" Value="Computer"></asp:MenuItem>
                    <asp:MenuItem Text="TV" Value="TV"></asp:MenuItem>
                </asp:MenuItem>
                <asp:MenuItem Text="Food" Value="Food">
                    <asp:MenuItem Text="Dessert" Value="Dessert"></asp:MenuItem>
                    <asp:MenuItem Text="Vegeterian" Value="Vegeterian">
                        <asp:MenuItem Text="North India" Value="North India"></asp:MenuItem>
                        <asp:MenuItem Text="South India" Value="South India"></asp:MenuItem>
                    </asp:MenuItem>
                </asp:MenuItem>
            </Items>
           
        </asp:Menu>
    
    </div>
    </form>
</body>
</html>
