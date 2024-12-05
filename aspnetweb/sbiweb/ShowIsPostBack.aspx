<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.SelectedItem.Text;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Create collection of items
            ArrayList items = new ArrayList();
            items.Add("Apple");
            items.Add("Orange");

            //Bind to DropdownList
            DropDownList1.DataSource = items;
            DropDownList1.DataBind();
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" />
        
        <asp:Button ID="Button1" runat="server" Text="Select" onclick="Button1_Click" />

        <br /><br />

        You Selected:<asp:Label ID="Label1" runat="server" />
    </div>
    </form>
</body>
</html>
