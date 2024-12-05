// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.


using System;
using System.Web.UI.WebControls;

public partial class DropDown_DropDown : CommonPage
{
    protected void OnSelect(object sender, EventArgs e)
    {
        lblSelection.Text = "You selected <b>" + ((LinkButton) sender).Text + "</b>.";
    }
}