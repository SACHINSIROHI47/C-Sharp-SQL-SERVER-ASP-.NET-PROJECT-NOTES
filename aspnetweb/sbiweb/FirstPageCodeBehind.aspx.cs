using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FirstPageCodeBehind : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "Click The Button";
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "Thanks!";
    }
}