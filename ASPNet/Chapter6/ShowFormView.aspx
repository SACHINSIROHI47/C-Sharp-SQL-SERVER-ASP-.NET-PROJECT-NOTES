<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowFormView.aspx.cs" Inherits="ShowFormView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FormView ID="FormView1" runat="server" AllowPaging="True" 
            DataKeyNames="Id" DataSourceID="srcMovies" DefaultMode="Edit">
        <EditItemTemplate>
         <asp:Label ID="lblTitle" runat="server" AssociatedControlID="txtTitle" 
            Text="Title"></asp:Label>
&nbsp;<asp:TextBox ID="txtTitle" runat="server" Text='<%#Bind("Title")%>'></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDirector" runat="server" AssociatedControlID="txtDirector" 
            Text="Director"></asp:Label>
&nbsp;<asp:TextBox ID="txtDirector" runat="server" Text='<%#Bind("Director")%>'></asp:TextBox>
<br /><br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CommandName="Update" />   
        <asp:Button ID="btnInsert" runat="server" Text="Insert" CommandName="Insert" />   
        </EditItemTemplate>
       
</asp:FormView>
        <asp:SqlDataSource ID="srcMovies" runat="server" 
            ConnectionString="<%$ ConnectionStrings:Movies %>" 
            InsertCommand="INSERT INTO MOVIES(TITLE, DIRECTOR) VALUES (@TITLE,@DIRECTOR)" 
            ProviderName="<%$ ConnectionStrings:Movies.ProviderName %>" 
            SelectCommand="SELECT ID, TITLE, DIRECTOR FROM MOVIES" 
            UpdateCommand="UPDATE MOVIES SET TITLE =@TITLE, DIRECTOR = @DIRECTOR WHERE ID=@ID">
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
