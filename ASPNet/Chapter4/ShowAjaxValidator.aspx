<%@ Page Language="C#" %>
<%@ Register TagPrefix="custom" Namespace="myControls" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Web.Configuration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server" charset="ts">

    private bool UserNameExists(string userName)
    {
        string conString = WebConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
        SqlConnection con = new SqlConnection(conString);
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName = @UserName", con);
        cmd.Parameters.AddWithValue("@UserName",userName);
        bool result = false;
        using (con)
        {
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            if(count > 0)
                return true;
        }
        return result;        
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
       /* if (UserNameExists(txtUserName.Text) == true)
        {
            txtUserName.Text = "User Name Exists";
            txtFavoriteColor.Text = String.Empty;
        }
        else
        {*/
            string conString = WebConfigurationManager.ConnectionStrings["UserDB"].ConnectionString;
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("INSERT Users(UserName,FavoriteColor) VALUES(@UserName,@FavoriteColor)", con);
            cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("@FavoriteColor", txtFavoriteColor.Text);
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            txtUserName.Text = String.Empty;
            txtFavoriteColor.Text = String.Empty;
        //}
    }
    /// <summary>
    /// validation function called that is called on both the client and server
    /// </summary>
    protected void AjaxValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        //lblError.Text = args.Value;
        if(UserNameExists(args.Value)==true)
            args.IsValid = false;
        else
            args.IsValid = true;
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblUserName" runat="server" AssociatedControlID="txtUserName" Text="User Name"></asp:Label>&nbsp;
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <custom:AjaxValidator ID="AjaxValidator1" ControlToValidate="txtUserName" Text="User name already taken" runat="server" OnServerValidate="AjaxValidator1_ServerValidate" />
        <br />
        <br />
        <asp:Label ID="lblFavoriteColor" runat="server" AssociatedControlID="txtFavoriteColor"
            Text="Favorite Color"></asp:Label>
        <asp:TextBox ID="txtFavoriteColor" runat="server"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
