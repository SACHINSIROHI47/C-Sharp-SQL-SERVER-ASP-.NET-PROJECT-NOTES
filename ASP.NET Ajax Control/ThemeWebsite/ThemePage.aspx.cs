using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ThemePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Page_PreInit(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Page.Theme = (String)Session["Theme"];
        }
        else
        {
            Session["Theme"] = "Blue";
            Page.Theme = (string)Session["Theme"];
        }
    }
    protected void linkButtonBlue_Click(object sender, EventArgs e)
   
        
{
    if (Session["Theme"] != null)
    {
        Session["Theme"] = "Blue";
        Server.Transfer(Request.Path);
    }

    }
    protected void linkButtonOrange_Click(object sender, EventArgs e)
    {
        if (Session["Theme"] != null)
        {
            Session["Theme"] = "Orange";
            Server.Transfer(Request.Path);
        }
    }
}