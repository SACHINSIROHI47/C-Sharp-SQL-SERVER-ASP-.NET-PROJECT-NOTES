<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .floater
        {
            float:left;
            border:solid 1px black;
            padding:5px;
            margin:5px;
         }
         
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="floater">
    <h3>Bulleted List</h3>
        <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="srcMovies" DataTextField="Title">
        </asp:BulletedList>
    </div>
    <div class="floater">
     <h3>CheckBox List</h3>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="srcMovies" DataTextField="Title">
        </asp:CheckBoxList>
    </div>
    <div class="floater">
    <h3>DropDown List</h3>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="srcMovies" DataTextField="Title">
        </asp:DropDownList>
    </div>
    <div class="floater">
    <h3>ListBox</h3>
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="srcMovies" DataTextField="Title"></asp:ListBox>
    </div>
    <div class="floater">
    <h3>RadioButtonLis</h3>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="srcMovies" DataTextField="Title">
        </asp:RadioButtonList>  
    </div>
        <asp:SqlDataSource ID="srcMovies" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\ASPNet\Chapter6\MyDatabase.mdb"
            ProviderName="System.Data.OleDb" SelectCommand="SELECT Title FROM Movies"></asp:SqlDataSource>
    </form>
</body>
</html>
