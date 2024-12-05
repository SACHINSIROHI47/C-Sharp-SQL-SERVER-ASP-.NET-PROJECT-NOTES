using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace myControls
{
    /// <summary>
    /// enables you to perform custom validation on both the client and server
    /// </summary>
    public class AjaxValidator : BaseValidator, ICallbackEventHandler
    {
        public event ServerValidateEventHandler ServerValidate;
        string _controlToValidateValue;

        protected override void OnPreRender(EventArgs e)
        {
            string eventRef = Page.ClientScript.GetCallbackEventReference(this, "", "", "");

            //Resgister include file
            String includeScript = Page.ResolveClientUrl("~/ClientScripts/AjaxValidator.js");
            Page.ClientScript.RegisterClientScriptInclude("AjaxValidator",includeScript);

            //Register startup script
            String startupScript = String.Format("document.getElementById('{0}').evaluationFunction = 'AjaxValidatorEvaluateIsValid';",this.ClientID);

            Page.ClientScript.RegisterStartupScript(this.GetType(),"AjaxValidator",startupScript,true);

            base.OnPreRender(e);
        }
        /// <summary>
        /// Only do the AJAX on browser that support it
        /// </summary>     
        protected override bool DetermineRenderUplevel()
        {
            return Context.Request.Browser.SupportsCallback;
        }

        /// <summary>
        /// Server method called by client AJAX call
        /// </summary>  
        public string GetCallbackResult()
        {
            return ExecuteValidationFunction(_controlToValidateValue).ToString();
        }

        /// <summary>
        /// Return callback result to Client
        /// </summary> 
        public void RaiseCallbackEvent(string eventArgument)
        {
            _controlToValidateValue = eventArgument;
        }

        /// <summary>
        /// Server-side method for validation
        /// </summary> 
        protected override bool EvaluateIsValid()
        {
            string controlToValidateValue = this.GetControlValidationValue(this.ControlToValidate);
            return ExecuteValidationFunction(controlToValidateValue);
        }

        /// <summary>
        /// Perform the vlaidation for both server and client
        /// </summary> 

        private bool ExecuteValidationFunction(String controlToValidateValue)
        {
            ServerValidateEventArgs args = new ServerValidateEventArgs(controlToValidateValue, this.IsValid);
            if (ServerValidate != null)
                ServerValidate(this, args);
            return args.IsValid;
        }
    }
}
