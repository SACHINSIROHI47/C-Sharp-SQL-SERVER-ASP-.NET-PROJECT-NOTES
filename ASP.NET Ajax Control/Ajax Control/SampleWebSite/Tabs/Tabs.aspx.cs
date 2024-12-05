// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.

using System;

public partial class Tabs_Tabs : CommonPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CurrentTab.Text = Tabs.ActiveTab.HeaderText;
    }

    public void SaveProfile(object sender, EventArgs e)
    {
    }
}