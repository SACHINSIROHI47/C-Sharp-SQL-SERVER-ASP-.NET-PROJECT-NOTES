// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.

using System;

public partial class ValidatorCallout_ValidatorCallout : CommonPage
{
    protected void Button1_OnClick(object sender, EventArgs e)
    {
        lblMessage.Text = string.Format("Thanks {0}, we'll give you a call at {1}.", NameTextBox.Text, PhoneNumberTextBox.Text);
    }
}