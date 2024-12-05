<%@ Page
    Language="C#"
    MasterPageFile="~/DefaultMaster.master"
    Title="Creating a new extender" %>
<asp:Content ContentPlaceHolderID="SampleContent" Runat="Server">
    <div class="walkthrough">
        <div class="heading">Creating a new extender</div>
        <p>The following steps walk you through the process of creating a new ASP.NET AJAX extender from scratch.
        When you've completed this walkthrough, you'll have written a completely new extender control that you can customize and use in your own ASP.NET web pages.</p>
        <br />
        <div class="subheading">Prerequisites</div>
        <ol>
            <li>If you haven't already done so, follow the steps to <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Walkthrough/Setup.aspx" Text="setup your environment" runat="server"></asp:HyperLink></li>
        </ol>
        <div class="subheading">Creating the foundation</div>
        <ol>
            <li>Using Visual Studio 2005, create a new web site from the ASP.NET AJAX web site template by opening the "File" menu,
                clicking "New", "Web Site...", and picking "ASP.NET AJAX Web Site" under "My Templates"</li>
            <li>Open the "File" menu, click "Add", and "New Project..." from the menu</li>
            <li>Chose C# or VB and then select the "ASP.NET AJAX Control Project" item from the
                "My Templates" section.</li>
            <li>Name the new project DisableButton</li>
            <li>This will create you the default template project. Four files are automatically
                created:
                <ul>
                    <li><strong>DisableButtonBehavior.js</strong> - This file is where you will add all
                        of your client script logic.</li>
                    <li><strong>DisableButtonExtender.cs</strong> - This file is the server-side control
                        class that will manage creating your extender and allow you to set the properties
                        at design-time.  It also defines the properties
                        that can be set on your extender. These properties are accessible via code and at
                        design time and match properties defined in the DisableButtonBehavior.js file.</li>
                    <li><strong>DisableButtonDesigner.cs</strong> - This class enables
                        design-time functionality. You should not need to modify it.</li>
                </ul>
            </li>
        </ol>
        <div class="subheading">Ensuring the Client Behavior is Setup Properly</div>
        <ol>
            <li>Open DisableButtonBehavior.js by double-clicking it</li>
            <li>Add the test code
                <code>alert(<span style="color: #663300">"Hello World!"</span>);</code>
                immediately below the line
                <code><span style="color: #0000ff">this</span>._myPropertyValue = <span style="color: #0000ff">null</span>;</code>
            </li>
            <li>Open Default.aspx by double-clicking it in the Solution Explorer</li>
            <li>Switch to design view by clicking the Design tab</li>
            <li>Add a TextBox (TextBox1) by dragging one over from the Toolbox</li>
            <li>Add a Button (Button1) by dragging one over from the Toolbox</li>
            <li>Build your solution by opening the "Build" menu and choosing "Build Solution" from the menu</li>
            <li>At the top of the Toolbox, you'll find a tab called "DisableButton Components".
                Inside will be an item called "DisableButtonExtender". Drag this onto your page.
                <div class="walkthroughNote">
                    <p><strong>Note</strong>: If you do not find the item in the Toolbox, you can
                    add it manually with the following steps:</p>
                    <ol>
                        <li>Switch to Source view</li>
                        <li>Add a reference to the assembly by right clicking the website, choosing "Add Reference...", "Projects", and "DisableButton"
                        </li>
                        <li>Register the reference in your web page by adding the following code at the top of
                            the page:
                            <code>&lt;%<span style="color: #0000ff">@</span> <span style="color: #800000">Register</span> <span style="color: #ff0000">Assembly</span><span style="color: #0000ff">="DisableButton"</span>
        <span style="color: #ff0000">Namespace</span><span style="color: #0000ff">="DisableButton"</span> <span style="color: #ff0000">TagPrefix</span><span style="color: #0000ff">="cc1"</span>%&gt;</code>
                            Note: If you are using Visual Basic, the namespace will be "DisableButton.DisableButton"
                        </li>
                        <li>Add the control to the page:
                            <code>&lt;<span style="color: #800000">cc1</span><span style="color: #0000ff">:</span><span style="color: #800000">DisableButtonExtender</span>
        <span style="color: #ff0000">ID</span><span style="color: #0000ff">="DisableButtonExtender1"</span> <span style="color: #ff0000">runat</span><span style="color: #0000ff">="server"/</span>&gt;</code>
                        </li>
                        <li>You can now switch back to Design view</li>
                    </ol>
                </div>
            </li>
            <li>Hook up the extender by clicking on the DisableButtonExtender, going to the Properties panel, expanding the TargetControlID
                property, choosing "TextBox1"</li>
            <li>Run the page by pressing F5 (enable debugging if prompted) and verify that the page
                brings up a "Hello World!" dialog when it loads</li>
            <li>Close the browser window</li>
        </ol>

        <div class="subheading">Adding functionality</div>
        <ol>
        <li>Remove the test code <code>alert(<span style="color: #666600">"Hello World!"</span>);</code> added to DisableButtonBehavior.js earlier</li>
        <li>Limit the extender to TextBoxes by changing "Control" to "TextBox" in the TargetControlType attribute in DisableButtonExtender.cs:
        <code>[<span style="color:#007777">TargetControlType</span>(<span style="color:#0000ff">typeof</span>(<span style="color:#007777">TextBox</span>))]</code>
        </li>
        <li>Create a better property name by renaming as follows (case is important):
            <ol>
            <li>"MyProperty" to "TargetButtonID" in DisableButtonExtender.cs (3 locations)</li>
            <li>"MyProperty"/"myProperty" to "TargetButtonID" in DisableButtonBehavior.js (5 locations)</li>
            </ol>
        </li>
        <li>Add a new DisabledText property by following the example of the TargetButtonID property just modified (case is important):
            <ol>
            <li>Add a new public string property to DisableButtonExtender.cs:
    <pre>[<span style="color:#007777">ExtenderControlProperty</span>]
    <span style="color: blue">public</span> <span style="color: blue">string </span>DisabledText { 
    <span style="color: blue">    get</span> {
    <span style="color: blue">        return</span> GetPropertyValue(<span style="color: #666600">"DisabledText"</span>, <span style="color: #666600">""</span>); 
        }
    <span style="color: blue">    set</span> { 
            SetPropertyValue(<span style="color: #666600">"DisabledText"</span>, <span style="color: blue">value</span>);
        }
    }</pre>
            </li>
            <li>Add a new member variable to the behavior in DisableButtonBehavior.js below the existing member variable for TargetButtonIDValue:
                <code><span style="color: #0000ff">this</span>._DisabledTextValue = <span style="color: #0000ff">null</span>;</code>
            </li>
            <li>Add property get/set methods to the behavior in DisableButtonBehavior.js *above* the existing get/set methods for TargetButtonID:
    <pre>get_DisabledText : function() {
        <span style="color: blue">return this</span>._DisabledTextValue;
    },
    set_DisabledText : function(value) {
        <span style="color: blue">this</span>._DisabledTextValue = value;
    },</pre>
            </li>
            </ol>
        </li>
        <li>Because TargetButtonID should always refer to a control, add the attribute <code>
            [<span style="color:#007777">IDReferenceProperty</span>(<span style="color: blue">typeof</span>(<span style="color:#007777">Button</span>))]</code> to the property in DisableButtonExtender.cs so the
            framework will know to automatically resolve the control ID at render time</li>
            <li>Add a keyup handler to the behavior by adding the following code *above* the existing property definitions in DisableButtonBehavior.js:
    <pre><span style='color:Black'>_onkeyup : </span><span style='color:Blue'>function</span><span style='color:Black'>() {
        </span><span style='color:Blue'>var</span><span style='color:Black'> e = $get(</span><span style='color:Blue'>this</span><span style='color:Black'>._TargetButtonIDValue);
        </span><span style='color:Blue'>if</span><span style='color:Black'> (e) {
            </span><span style='color:Blue'>var</span><span style='color:Black'> disabled = (</span><span style='color:Maroon'>&quot;&quot;</span><span style='color:Black'> == </span><span style='color:Blue'>this</span><span style='color:Black'>.get_element().value);
            e.disabled = disabled;
            </span><span style='color:Blue'>if</span><span style='color:Black'> (</span><span style='color:Blue'>this</span><span style='color:Black'>._DisabledTextValue) {
                </span><span style='color:Blue'>if</span><span style='color:Black'> (disabled) {
                    </span><span style='color:Blue'>this</span><span style='color:Black'>._oldValue = e.value;
                    e.value = </span><span style='color:Blue'>this</span><span style='color:Black'>._DisabledTextValue;
                } </span><span style='color:Blue'>else</span><span style='color:Black'> {
                    </span><span style='color:Blue'>if</span><span style='color:Black'> (</span><span style='color:Blue'>this</span><span style='color:Black'>._oldValue) {
                        e.value = </span><span style='color:Blue'>this</span><span style='color:Black'>._oldValue;
                    }
                }
            }
        }
    },</span>
    </pre>
        </li>
        <li>Hook up the keyup handler by adding the following code to end of the behavior's initialize function:
    <pre><span style='color:Black'>$addHandler(</span><span style='color:Blue'>this</span><span style='color:Black'>.get_element(), </span><span style='color:Maroon'>'keyup'</span><span style='color:Black'>,
        Function.createDelegate(</span><span style='color:Blue'>this</span><span style='color:Black'>, </span><span style='color:Blue'>this</span><span style='color:Black'>._onkeyup));</span>
    <span style='color:Blue'>this</span><span style='color:Black'>._onkeyup();</span></pre>
        <p>
        (Note: This walkthrough doesn't handle clean up in order to keep things easy understand - refer to any of the samples, and refer to the "dispose" method in the script files for examples of how to properly clean up your controls)</p></li>
        <li>Switch back to Default.aspx by double-clicking it in the Solution Explorer</li>
        <li>Switch to source view by clicking the Source tab</li>
        <li>Remove the old property setting by removing the following code from the DisableButtonExtender:
        <code><span style="color:#ff0000">MyProperty</span>=<span style="color:#0000ff">"property"</span></code></li>
        <li>Rebuild the solution</li>
        <li>Switch to design view by clicking the Design tab</li>
        <li>Modify the extender's properties by clicking the TextBox, going to the Properties panel, expanding the DisableButtonExtender item, and specifying "Button1" for TargetButtonID and "Enter text" for DisabledText</li>
        <li>Run the page by pressing F5, enter text into the TextBox, and note the behavior of the Button control - notice that it is disabled and says "Enter text" whenever the TextBox is empty</li>
        </ol>
        <p> Congratulations, you've written your first ASP.NET AJAX extender!!</p>
        <br />
        <p>Please refer to the individual sample pages (at the left) for examples of other behaviors,
            and how to use them, and to the AjaxControlToolkit project for their source.</p>
    </div>
</asp:Content>