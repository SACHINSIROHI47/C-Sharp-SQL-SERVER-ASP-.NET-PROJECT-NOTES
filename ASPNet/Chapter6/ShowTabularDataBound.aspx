<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">


</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
    .itemContaine
    {
        background-color:Aqua;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" DataSourceID="srcMovies" RepeatColumns="3">
        <ItemTemplate>
        <%#Eval("Title") %>
        <i>Directed by</i>
        <%#Eval("Director") %>.
        </ItemTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="srcMovies" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Movies %>" 
            ProviderName="<%$ ConnectionStrings:Movies.ProviderName %>" 
            SelectCommand="SELECT TOP 5 TITLE, DIRECTOR FROM MOVIES" 
            InsertCommand="INSERT INTO MOVIES(TITLE, DIRECTOR) VALUES (@titele,@director)">
            <InsertParameters>
                <asp:Parameter Name="@titele" />
                <asp:Parameter Name="@director" />
            </InsertParameters>
        </asp:SqlDataSource>
    </div>
    <div>
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" 
            DataSourceID="srcMovies" Height="50px" Width="125px">
        </asp:DetailsView>
    </div>
    <div>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="srcMovies" 
            AllowPaging="True">
          <ItemTemplate>
        <%#Eval("Title") %>
        <i>Directed by</i>
        <%#Eval("Director") %>.
        </ItemTemplate>
        </asp:FormView>
    </div>
    <div>
    repeater
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="srcMovies">
     <ItemTemplate>
        <%#Eval("Title") %>
        <i>Directed by</i>
        <%#Eval("Director") %>.
        </ItemTemplate>
    </asp:Repeater>
    
    </div>
    <div>
    listview<br />
        <asp:ListView ID="ListView1" runat="server" DataSourceID="srcMovies">
        <LayoutTemplate>
        <div id="itemContaine">
          </div>
          <asp:DataPager ID="pager1" PageSize="3" runat="server">
          <Fields>
          <asp:NumericPagerField />
          </Fields>
          </asp:DataPager>
        </LayoutTemplate>
        <ItemTemplate>
         <%#Eval("Title") %>
        <i>Directed by</i>
        <%#Eval("Director") %>
        
        </ItemTemplate>
       
        </asp:ListView>

    </div>
    </form>
</body>
</html>
