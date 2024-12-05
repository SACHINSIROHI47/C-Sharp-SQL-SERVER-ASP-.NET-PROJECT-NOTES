using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSum_Click(object sender, EventArgs e)
    {
        if (txtNumber1.Text.Length == 0)
        {
            lblMessage.Text = "Please Enter Number1";
        }
        else if (txtNumber2.Text.Length == 0)
        {
            lblMessage.Text = "Please Enter Number2";
        }
        else
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtNumber1.Text);
            num2 = Convert.ToInt32(txtNumber2.Text);
            num3 = num1 + num2;
            txtSum.Text = Convert.ToString(num3);
        }
    }
}