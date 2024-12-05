 <%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void menuTabs_MenuItemClick(object sender, MenuEventArgs e)
    {
        multiTabs.ActiveViewIndex = Int32.Parse(menuTabs.SelectedValue);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    html
    {
        background-color:Silver;
    }
    .menuTabs
    {
        position:relative;
        top:1px;
        left:10px;
    }
    .tab
    {
        border:Solid 1px black;
        border-bottom:none;
        padding:0px 10px;
        background-color:eeeeee;
    }
     .selectedTab
    {
        border:Solid 1px black;
        border-bottom:Solid 1px white;
        padding:0px 10px;
        background-color:white;
    }
    .tabBody
    {
        border:Solid 1px black;
        padding:0px 10px;
        background-color:white;
            height: 210px;
        }
    </style>
</head>
<body alink="  ">
    <form id="form1" runat="server">
    <div>
        <asp:Menu ID="menuTabs" StaticMenuItemStyle-CssClass="tab" 
            StaticSelectedStyle-CssClass="selectedTab"  Orientation="Horizontal"  
            runat="server" onmenuitemclick="menuTabs_MenuItemClick">
        <Items>
            <asp:MenuItem Text="Colthes" Value="0" Selected="true" />
            <asp:MenuItem Text="Mobile" Value="1" />
            <asp:MenuItem Text="Furniture" Value="2" />
        </Items>
        </asp:Menu>
 </div>
       
        <div class="tabBody">
        <asp:MultiView ID="multiTabs" ActiveViewIndex="0" runat="server">
            <asp:View id="View1" runat="server">
            Readymade Colthes
            <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                &nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View2" runat="server">
            Latest Mobile
                <br />
                <br />
                <asp:Image ID="Image1" runat="server" Height="60px" 
                    ImageUrl="~/images/dancer.gif" Width="131px" />
            <br />
            </asp:View>
            <asp:View ID="View3" runat="server">
            Branded Furniture
                <br />
                <br />
                <asp:Image ID="Image2" runat="server" Height="67px" 
                    ImageUrl="~/images/diya-aur-baati-hum-wallpapers-8.jpg" Width="156px" />
            <br />
            </asp:View>
        
        </asp:MultiView>

        
    </div>
    </form>
</body>
</html>
