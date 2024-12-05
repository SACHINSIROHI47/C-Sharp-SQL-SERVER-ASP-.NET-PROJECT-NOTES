<%@ Page Language="C#" MasterPageFile="~/DefaultMaster.master" Title="Setup" %>

<asp:Content ContentPlaceHolderID="SampleContent" runat="Server">
    <div class="walkthrough">
        <div class="heading">
            Setup your environment</div>
        <div class="subheading">
            Install binaries</div>
        <ol>
            <li>Install the latest <a href="http://ajax.asp.net/">ASP.NET AJAX Extensions 1.0</a>
                package</li>
            <li>Unpack the AJAX Control Toolkit into a folder on your computer</li>
        </ol>
        <div class="subheading">
            Configure Visual Studio 2005 and Visual Web Developer</div>
        <ol>
            <li>Create a new web site from the ASP.NET AJAX web site template by opening the "File"
                menu, clicking "New", "Web Site...", and picking "ASP.NET AJAX Web Site" under "My
                Templates"</li>
            <li>Right-click on the Toolbox and select "Add Tab", and add a tab called "AJAX Control
                Toolkit"</li>
            <li>Inside that tab, right-click on the Toolbox and select "Choose Items..."</li>
            <li>When the "Choose Toolbox Items" dialog appears, click the "Browse..." button. Navigate
                to the folder where you installed the ASP.NET AJAX Control Toolkit package. You
                will find a folder called "SampleWebSite", and under that another folder called
                "bin". Inside that folder, select "AjaxControlToolkit.dll" and click OK. Click OK
                again to close the Choose Items Dialog.</li>
            <li>You can now use the included sample controls in your web sites!</li>
        </ol>
        <div class="subheading">
            Installing AJAX Control Toolkit Templates</div>
        <ol>
            <li>In the folder where you installed the AJAX Control Toolkit package, you will find
                a folder called "AjaxControlExtender" with a file called "AjaxControlExtender.vsi"
                inside it - double-click AjaxControlExtender.vsi to install it</li>
            <li>Choose which templates you would like to install, then click "Next", then "Yes"
                to allow the unsigned content (note: as a public project, this content can't be
                signed by Microsoft), then "Finish"</li>
            <li>You have now installed the templates are ready to create your own Toolkit-based
                web site or ASP.NET AJAX Extenders!</li>
        </ol>
        <em>Note:</em> The AJAX Control Toolkit Extender Templates are for building extenders
        and controls and need Visual Studio C#/VB Express. The Toolkit Website Templates
        work with Visual Web Developer Express. If you have Visual Studio then all templates
        can be installed.<br /><br />
        <p>
            <strong>The TemplateVSI project </strong>has a dependency on vjslib.dll which is
            a part of the Visual J# Redistributable Package. If you would like to build that
            project successfully then please install the package from <a href="http://www.microsoft.com/downloads/details.aspx?familyid=f72c74b3-ed0e-4af8-ae63-2f0e42501be1&displaylang=en">
                here</a>.</p>
        <div class="subheading">
            Upgrading to a newer Toolkit release
        </div>
        <br />
        If you were using an older release of the Toolkit and now need to move to a later
        version here are the recommended steps:
        <ul>
            <li><strong>Binaries: </strong>Overwrite all old instances of the Toolkit binary "AjaxControlToolkit.dll"
                on your machine with the new one.</li>
            <li><strong>Toolbox items: </strong>Delete the old tab that listed Toolkit controls
                and recreate it using the new Toolkit DLL.</li>
            <li><strong>Toolkit templates: </strong>Reinstall the new "AjaxControlExtender.vsi"
                and check to overwrite the old templates in the "Add Templates" wizard.</li>
        </ul>
    </div>
</asp:Content>
