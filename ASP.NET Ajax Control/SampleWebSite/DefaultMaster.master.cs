// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Permissive License.
// See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx.
// All other rights reserved.


using System;
using System.Collections;
using System.Web.UI;

public partial class DefaultMaster_Default : MasterPage, IContentPlaceHolders
{
    public IList GetContentPlaceHolders()
    {
        return ContentPlaceHolders;
    }
}