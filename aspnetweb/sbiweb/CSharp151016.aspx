<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

    protected void btnShow_Click(object sender, EventArgs e)
    {
        int num;
        num = Convert.ToInt32(txtMarks.Text);
        if (num >= 40)
        {
            txtResult.Text = "Pass";
            txtAdmission.Text = "Yes";
        }
        else
        {           
           txtResult.Text = "Fail";
           txtAdmission.Text = "No";
           txtMarks.Focus();     
        }
            
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter text to be Searched"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtSearch" runat="server" Columns="20" MaxLength="25"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Marks"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtMarks" runat="server" TabIndex="2"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtResult" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Admission"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtAdmission" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Coments"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtComents" runat="server" Columns="40" Rows="5" TabIndex="1" 
        TextMode="MultiLine" Wrap="False"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Button ID="btnShow" runat="server" onclick="btnShow_Click" Text="Show" />
    <br />
&nbsp;<div>
    
    </div>
    </form>
</body>
</html>
