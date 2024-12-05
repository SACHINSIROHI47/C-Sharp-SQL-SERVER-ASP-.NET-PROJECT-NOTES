<%@ Page
    Language="C#"
    MasterPageFile="~/DefaultMaster.master"
    Title="Using a sample extender" %>
<asp:Content ContentPlaceHolderID="SampleContent" Runat="Server">
    <div class="walkthrough">

        <div class="heading">Using a sample extender</div>
            <p>
            The following steps walk you through the process of using one of the sample ASP.NET AJAX
            extenders on an ASP.NET web page. As you'll see, it takes less work to hook up the
            extender than it does to create the page in the first place - and doesn't require
            writing any code!</p>
            <br />

        <div class="subheading">Prerequisites</div>
        <ol>
            <li>If you haven't already done so, follow the steps to
                <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Walkthrough/Setup.aspx" Text="setup your environment"
                    runat="server" /></li>
        </ol>

        <div class="subheading">Create a normal ASP.NET page to build on</div>
        <ol>
            <li>Using Visual Studio 2005 or Visual Web Developer, create a new web site from the
                ASP.NET AJAX web site template by opening the "File" menu,
                clicking "New", "Web Site...", and picking "ASP.NET AJAX Web Site" under "My Templates"</li>
            <li>Open Default.aspx by double-clicking it in the Solution Explorer</li>
            <li>Switch to design view by clicking the Design tab at the bottom of the window</li>
            <li>Add a Label (Label1) by dragging one over from the Toolbox</li>
            <li>Add a Button (Button1) by dragging one over from the Toolbox</li>
            <li>Create a Click handler for the Button by double-clicking it</li>
            <li>Default.aspx.cs will open automatically and the cursor will be in the Button1_Click
                method</li>
            <li>Add the code <code>Label1.Text = "Button click was processed.";</code></li>
            <li>Run the page by pressing F5 (enable debugging if prompted) and verify that clicking
                the Button in the browser changes the Label text</li>
            <li>Close the browser window</li>
        </ol>

        <div class="subheading">Add the AJAX Toolkit extender</div>
        <ol>
            <li>Add a ConfirmButtonExtender by dragging one over from the Toolbox</li>
            <li>Hook up the extender by clicking it, going to the Properties panel,
                expanding the TargetControlID property drop-down, and choosing "Button1"</li>
            <li>Configure the extender by clicking the Button, expanding the ConfirmButtonExtender property,
                and typing "Are you sure?" for the ConfirmText</li>
            <li>Run the page by pressing F5 and notice that clicking the button now brings up a
                confirmation dialog that can be used to cancel the processing of the button press</li>
        </ol>

        <p>That's all there is to it! You're now using an AJAX Control Toolkit extender!</p>
        <br />
        <p>Please refer to the individual sample pages (see the links on the left) for examples of
        how to use the other samples.</p>

    </div>
</asp:Content>