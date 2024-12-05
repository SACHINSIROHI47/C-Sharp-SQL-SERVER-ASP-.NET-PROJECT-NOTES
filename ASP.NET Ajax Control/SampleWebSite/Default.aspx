<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" AutoEventWireup="true"
    Inherits="CommonPage" Title="ASP.NET AJAX Control Toolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="SampleContent" runat="Server">
    <p>
        Welcome to the ASP.NET AJAX Control Toolkit sample website. Please choose from any
        of the samples on the left.
    </p>
    <br />
    <p>
        <strong><u>Installation Files</u></strong></p>
    <br />
    <p>
        Please visit the
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="http://www.codeplex.com/Wiki/View.aspx?ProjectName=AtlasControlToolkit">AJAX Control Toolkit Project Page</asp:HyperLink>
        on CodePlex</p>
    <br />
    <p>
        <strong><u>Release Notes</u></strong></p>
    <br />
    <strong><u>Major Fixes</u></strong>
    <ul class="releaseList">
        <li><strong>ValidatorCallout</strong> supports styling the popup using CSS and server-side validation.</li>
        <li><strong>ListSearch</strong> has enabled the options of searching for sub-strings
            in the list items and clearing the search query if no match is found.</li>
        <li><strong>AutoComplete</strong> only queries for matches when the user types a character.</li>
    </ul>
    <br />
    <strong><u>Community effort</u></strong>
    <p>
        This release includes over 10 <a href="http://www.codeplex.com/AtlasControlToolkit/Wiki/View.aspx?title=PatchUtility">
            patch fixes</a> provided by members of the Toolkit community. We would like
        to specially thank all the patch contributors for their effort which helped make
        this release possible. We recognize their names on the <a href="http://www.codeplex.com/AtlasControlToolkit/Wiki/View.aspx?title=PatchHallOfFame">
            Toolkit Patch Hall of Fame</a>.
    </p>
    <br />
    <strong><u>Setting up the environment to use the Toolkit</u></strong>: This Toolkit
    release targets two different versions of the .NET Framework:<br />
    <ul class="releaseList">
        <li><strong><u>Version 3.5.20229</u></strong> for .NET Framework 3.5 and Visual Studio
            2008:<br />
            <p>
                Download the <u>AjaxControlToolkit-Framework3.5.zip</u> or <u>AjaxControlToolkit-Framework3.5-NoSource.zip</u>.
            </p>
        </li>
        <li><strong><u>Version 1.0.20229</u></strong> for ASP.NET AJAX version 1.0 and .NET
            Framework 2.0:
            <br />
            <p>
                Download the <u>AjaxControlToolkit.zip</u> or <u>AjaxControlToolkit-NoSource.zip</u>.
            </p>
        </li>
    </ul>
    <br />
    <p>
        <strong><u>Note: </u></strong><strong>Toolkit version 3.5.20229</strong> is <em>only</em>
        for users who are building on top of .NET Framework 3.5 using Visual Studio 2008.
        If you are using .NET Framework 2.0 and Visual Studio 2005 then you should use <strong>
            Toolkit version 1.0.20229</strong>.</p>
    <br />
    Link to Toolkit Release <a href="ArchivedReleases.aspx">archive</a>.</asp:Content>
