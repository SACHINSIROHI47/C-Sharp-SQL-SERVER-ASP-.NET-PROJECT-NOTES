<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
  <title>ListBox AutoPostBack Example</title>
<script runat="server">

      void Page_Load(Object sender, EventArgs e)
      {
          if (ListBox1.AutoPostBack == true)
          {
              if (ListBox1.SelectedItem != null)
              {
                  lblItem.Text = "You selected: " + ListBox1.SelectedItem.Value;
              }
              else
              {
                  lblItem.Text = "";
              }
          }
          if (TextBox1.AutoPostBack == true)
          {
              lblSearch.Text = TextBox1.Text;
          }
      }

   </script>

</head>

<body>

   <form id="form1" runat="server">

      <h3>ListBox AutoPostBack Example</h3>

      Select an item from the list box: <br /><br />

      <asp:ListBox id="ListBox1" 
           Rows="4" 
           SelectionMode="Single"  
           runat="server">

         <asp:ListItem>Pen</asp:ListItem>
         <asp:ListItem>Eraser</asp:ListItem>
         <asp:ListItem>Marker</asp:ListItem>
         <asp:ListItem>Scale</asp:ListItem>
         <asp:ListItem>Pencil</asp:ListItem>
         <asp:ListItem>Sharpner</asp:ListItem>

      </asp:ListBox>

      <br />
      <br />
      <br />

      <asp:Label id="lblItem"
           runat="server"/>

      <br />
      <br />
      <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
      <br />
      <br />
      <asp:Label ID="lblSearch" runat="server" Text="Label"></asp:Label>
      <br />

   </form>

</body>
</html>