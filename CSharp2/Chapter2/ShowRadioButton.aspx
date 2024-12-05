<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (rd1Magazine.Checked == true)
        {
            lblResult.Text = rd1Magazine.Text;
        }
        if (rd1Television.Checked == true)
        {
            lblResult.Text = rd1Television.Text;
        }
        if (rd1Other.Checked == true)
        {
            lblResult.Text = rd1Other.Text;
        }
    }

    protected void rd1Television_CheckedChanged(object sender, EventArgs e)
    {
        if (rd1Television.Checked == true)
        {
            lblResult.Text = rd1Television.Text;
        }
    }

    protected void rd1Magazine_CheckedChanged(object sender, EventArgs e)
    {
        if (rd1Magazine.Checked == true)
        {
            lblResult.Text = rd1Magazine.Text;
        }
    }

    protected void rd1Other_CheckedChanged(object sender, EventArgs e)
    {
        if (rd1Other.Checked == true)
        {
            lblResult.Text = rd1Other.Text;
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
    How did you hear about our website
    <ul>
    <li>
        <asp:RadioButton ID="rd1Magazine" runat="server" GroupName="Source" 
            Text="Magazine Article" Checked="True" 
            OnCheckedChanged="rd1Magazine_CheckedChanged" AutoPostBack="True" />
    </li>
     <li>
        <asp:RadioButton ID="rd1Television" runat="server" GroupName="Source" 
            Text="Television Program" AutoPostBack="True" 
             OnCheckedChanged="rd1Television_CheckedChanged" />
     </li>
     <li>
        <asp:RadioButton ID="rd1Other" runat="server" GroupName="Source" 
            Text="Other Source" OnCheckedChanged="rd1Other_CheckedChanged" 
             AutoPostBack="True" />
      </li>
       </ul>

      <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
           


        <br />
        <hr />
          <br />

        <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>  


    </div>
    </form>
</body>
</html>
