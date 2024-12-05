<%@ Page Language="C#" %>
<%@ Import Namespace="System.Collections.Generic" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    private List<String> groceries = new List<String>();
    protected void Sort_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "Sort")
        {
            switch (e.CommandArgument.ToString())
            {
                case "ASC":
                    groceries.Sort(SortASC);
                    break;
                case "DESC":
                    groceries.Sort(SortDESC);
                    break;
            }
        }                        
       
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        groceries.Add("Milk");
        groceries.Add("Steak");
        groceries.Add("Fish");
    }

    protected void Page_PreRender(object sender, EventArgs e)
    {
        bltGroceries.DataSource = groceries;
        bltGroceries.DataBind();
    }
    int SortASC(string x, string y)
    {
        return String.Compare(x, y);
    }
    int SortDESC(string x, string y)
    {
        return String.Compare(x, y) * -1;
    }
    
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnSortAsc" runat="server" CommandArgument="ASC" 
            CommandName="Sort" Text="Sort ASC" OnCommand="Sort_Command" />
&nbsp;&nbsp;
        <asp:Button ID="btnSortDESC" runat="server" Text="Sort DESC" 
            CommandArgument="DESC" CommandName="Sort" OnCommand="Sort_Command" />
        <br />
        <br />
        <asp:BulletedList ID="bltGroceries" runat="server">
        </asp:BulletedList>
    
    </div>
    </form>
</body>
</html>
