using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ImageButtonTarget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnTarget_Click(object sender, ImageClickEventArgs e)
    {
        if ((e.X > 90 && e.X < 110) && (e.Y > 90 && e.Y < 110))
        {
            lblResult.Text = "You hit the Target";
        }
        else
        {
            lblResult.Text = "You missed the Target";
        }



    }
}