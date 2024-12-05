using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Threading;

namespace Chapter7_E1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label SalaryLabel;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label TaxLabel;
		private System.Windows.Forms.Label TaxValueLabel;
		private System.Windows.Forms.Button CalcButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			// Sets the UI culture to French (France)
			Thread.CurrentThread.CurrentUICulture = new CultureInfo ("fr-FR");
			Thread.CurrentThread.CurrentCulture = new CultureInfo ("fr-FR");
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.NameLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SalaryLabel = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.TaxLabel = new System.Windows.Forms.Label();
			this.CalcButton = new System.Windows.Forms.Button();
			this.TaxValueLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// NameLabel
			// 
			this.NameLabel.AccessibleDescription = ((string)(resources.GetObject("NameLabel.AccessibleDescription")));
			this.NameLabel.AccessibleName = ((string)(resources.GetObject("NameLabel.AccessibleName")));
			this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("NameLabel.Anchor")));
			this.NameLabel.AutoSize = ((bool)(resources.GetObject("NameLabel.AutoSize")));
			this.NameLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("NameLabel.Dock")));
			this.NameLabel.Enabled = ((bool)(resources.GetObject("NameLabel.Enabled")));
			this.NameLabel.Font = ((System.Drawing.Font)(resources.GetObject("NameLabel.Font")));
			this.NameLabel.Image = ((System.Drawing.Image)(resources.GetObject("NameLabel.Image")));
			this.NameLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("NameLabel.ImageAlign")));
			this.NameLabel.ImageIndex = ((int)(resources.GetObject("NameLabel.ImageIndex")));
			this.NameLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("NameLabel.ImeMode")));
			this.NameLabel.Location = ((System.Drawing.Point)(resources.GetObject("NameLabel.Location")));
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("NameLabel.RightToLeft")));
			this.NameLabel.Size = ((System.Drawing.Size)(resources.GetObject("NameLabel.Size")));
			this.NameLabel.TabIndex = ((int)(resources.GetObject("NameLabel.TabIndex")));
			this.NameLabel.Text = resources.GetString("NameLabel.Text");
			this.NameLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("NameLabel.TextAlign")));
			this.NameLabel.Visible = ((bool)(resources.GetObject("NameLabel.Visible")));
			// 
			// textBox1
			// 
			this.textBox1.AccessibleDescription = ((string)(resources.GetObject("textBox1.AccessibleDescription")));
			this.textBox1.AccessibleName = ((string)(resources.GetObject("textBox1.AccessibleName")));
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox1.Anchor")));
			this.textBox1.AutoSize = ((bool)(resources.GetObject("textBox1.AutoSize")));
			this.textBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox1.BackgroundImage")));
			this.textBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox1.Dock")));
			this.textBox1.Enabled = ((bool)(resources.GetObject("textBox1.Enabled")));
			this.textBox1.Font = ((System.Drawing.Font)(resources.GetObject("textBox1.Font")));
			this.textBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox1.ImeMode")));
			this.textBox1.Location = ((System.Drawing.Point)(resources.GetObject("textBox1.Location")));
			this.textBox1.MaxLength = ((int)(resources.GetObject("textBox1.MaxLength")));
			this.textBox1.Multiline = ((bool)(resources.GetObject("textBox1.Multiline")));
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = ((char)(resources.GetObject("textBox1.PasswordChar")));
			this.textBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox1.RightToLeft")));
			this.textBox1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox1.ScrollBars")));
			this.textBox1.Size = ((System.Drawing.Size)(resources.GetObject("textBox1.Size")));
			this.textBox1.TabIndex = ((int)(resources.GetObject("textBox1.TabIndex")));
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox1.TextAlign")));
			this.textBox1.Visible = ((bool)(resources.GetObject("textBox1.Visible")));
			this.textBox1.WordWrap = ((bool)(resources.GetObject("textBox1.WordWrap")));
			// 
			// SalaryLabel
			// 
			this.SalaryLabel.AccessibleDescription = ((string)(resources.GetObject("SalaryLabel.AccessibleDescription")));
			this.SalaryLabel.AccessibleName = ((string)(resources.GetObject("SalaryLabel.AccessibleName")));
			this.SalaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("SalaryLabel.Anchor")));
			this.SalaryLabel.AutoSize = ((bool)(resources.GetObject("SalaryLabel.AutoSize")));
			this.SalaryLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("SalaryLabel.Dock")));
			this.SalaryLabel.Enabled = ((bool)(resources.GetObject("SalaryLabel.Enabled")));
			this.SalaryLabel.Font = ((System.Drawing.Font)(resources.GetObject("SalaryLabel.Font")));
			this.SalaryLabel.Image = ((System.Drawing.Image)(resources.GetObject("SalaryLabel.Image")));
			this.SalaryLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("SalaryLabel.ImageAlign")));
			this.SalaryLabel.ImageIndex = ((int)(resources.GetObject("SalaryLabel.ImageIndex")));
			this.SalaryLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("SalaryLabel.ImeMode")));
			this.SalaryLabel.Location = ((System.Drawing.Point)(resources.GetObject("SalaryLabel.Location")));
			this.SalaryLabel.Name = "SalaryLabel";
			this.SalaryLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("SalaryLabel.RightToLeft")));
			this.SalaryLabel.Size = ((System.Drawing.Size)(resources.GetObject("SalaryLabel.Size")));
			this.SalaryLabel.TabIndex = ((int)(resources.GetObject("SalaryLabel.TabIndex")));
			this.SalaryLabel.Text = resources.GetString("SalaryLabel.Text");
			this.SalaryLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("SalaryLabel.TextAlign")));
			this.SalaryLabel.Visible = ((bool)(resources.GetObject("SalaryLabel.Visible")));
			// 
			// textBox2
			// 
			this.textBox2.AccessibleDescription = ((string)(resources.GetObject("textBox2.AccessibleDescription")));
			this.textBox2.AccessibleName = ((string)(resources.GetObject("textBox2.AccessibleName")));
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("textBox2.Anchor")));
			this.textBox2.AutoSize = ((bool)(resources.GetObject("textBox2.AutoSize")));
			this.textBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBox2.BackgroundImage")));
			this.textBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("textBox2.Dock")));
			this.textBox2.Enabled = ((bool)(resources.GetObject("textBox2.Enabled")));
			this.textBox2.Font = ((System.Drawing.Font)(resources.GetObject("textBox2.Font")));
			this.textBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("textBox2.ImeMode")));
			this.textBox2.Location = ((System.Drawing.Point)(resources.GetObject("textBox2.Location")));
			this.textBox2.MaxLength = ((int)(resources.GetObject("textBox2.MaxLength")));
			this.textBox2.Multiline = ((bool)(resources.GetObject("textBox2.Multiline")));
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = ((char)(resources.GetObject("textBox2.PasswordChar")));
			this.textBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("textBox2.RightToLeft")));
			this.textBox2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("textBox2.ScrollBars")));
			this.textBox2.Size = ((System.Drawing.Size)(resources.GetObject("textBox2.Size")));
			this.textBox2.TabIndex = ((int)(resources.GetObject("textBox2.TabIndex")));
			this.textBox2.Text = resources.GetString("textBox2.Text");
			this.textBox2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("textBox2.TextAlign")));
			this.textBox2.Visible = ((bool)(resources.GetObject("textBox2.Visible")));
			this.textBox2.WordWrap = ((bool)(resources.GetObject("textBox2.WordWrap")));
			// 
			// TaxLabel
			// 
			this.TaxLabel.AccessibleDescription = ((string)(resources.GetObject("TaxLabel.AccessibleDescription")));
			this.TaxLabel.AccessibleName = ((string)(resources.GetObject("TaxLabel.AccessibleName")));
			this.TaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TaxLabel.Anchor")));
			this.TaxLabel.AutoSize = ((bool)(resources.GetObject("TaxLabel.AutoSize")));
			this.TaxLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TaxLabel.Dock")));
			this.TaxLabel.Enabled = ((bool)(resources.GetObject("TaxLabel.Enabled")));
			this.TaxLabel.Font = ((System.Drawing.Font)(resources.GetObject("TaxLabel.Font")));
			this.TaxLabel.Image = ((System.Drawing.Image)(resources.GetObject("TaxLabel.Image")));
			this.TaxLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("TaxLabel.ImageAlign")));
			this.TaxLabel.ImageIndex = ((int)(resources.GetObject("TaxLabel.ImageIndex")));
			this.TaxLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TaxLabel.ImeMode")));
			this.TaxLabel.Location = ((System.Drawing.Point)(resources.GetObject("TaxLabel.Location")));
			this.TaxLabel.Name = "TaxLabel";
			this.TaxLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TaxLabel.RightToLeft")));
			this.TaxLabel.Size = ((System.Drawing.Size)(resources.GetObject("TaxLabel.Size")));
			this.TaxLabel.TabIndex = ((int)(resources.GetObject("TaxLabel.TabIndex")));
			this.TaxLabel.Text = resources.GetString("TaxLabel.Text");
			this.TaxLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("TaxLabel.TextAlign")));
			this.TaxLabel.Visible = ((bool)(resources.GetObject("TaxLabel.Visible")));
			// 
			// CalcButton
			// 
			this.CalcButton.AccessibleDescription = ((string)(resources.GetObject("CalcButton.AccessibleDescription")));
			this.CalcButton.AccessibleName = ((string)(resources.GetObject("CalcButton.AccessibleName")));
			this.CalcButton.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CalcButton.Anchor")));
			this.CalcButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CalcButton.BackgroundImage")));
			this.CalcButton.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CalcButton.Dock")));
			this.CalcButton.Enabled = ((bool)(resources.GetObject("CalcButton.Enabled")));
			this.CalcButton.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("CalcButton.FlatStyle")));
			this.CalcButton.Font = ((System.Drawing.Font)(resources.GetObject("CalcButton.Font")));
			this.CalcButton.Image = ((System.Drawing.Image)(resources.GetObject("CalcButton.Image")));
			this.CalcButton.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CalcButton.ImageAlign")));
			this.CalcButton.ImageIndex = ((int)(resources.GetObject("CalcButton.ImageIndex")));
			this.CalcButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CalcButton.ImeMode")));
			this.CalcButton.Location = ((System.Drawing.Point)(resources.GetObject("CalcButton.Location")));
			this.CalcButton.Name = "CalcButton";
			this.CalcButton.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CalcButton.RightToLeft")));
			this.CalcButton.Size = ((System.Drawing.Size)(resources.GetObject("CalcButton.Size")));
			this.CalcButton.TabIndex = ((int)(resources.GetObject("CalcButton.TabIndex")));
			this.CalcButton.Text = resources.GetString("CalcButton.Text");
			this.CalcButton.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("CalcButton.TextAlign")));
			this.CalcButton.Visible = ((bool)(resources.GetObject("CalcButton.Visible")));
			this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
			// 
			// TaxValueLabel
			// 
			this.TaxValueLabel.AccessibleDescription = ((string)(resources.GetObject("TaxValueLabel.AccessibleDescription")));
			this.TaxValueLabel.AccessibleName = ((string)(resources.GetObject("TaxValueLabel.AccessibleName")));
			this.TaxValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TaxValueLabel.Anchor")));
			this.TaxValueLabel.AutoSize = ((bool)(resources.GetObject("TaxValueLabel.AutoSize")));
			this.TaxValueLabel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TaxValueLabel.Dock")));
			this.TaxValueLabel.Enabled = ((bool)(resources.GetObject("TaxValueLabel.Enabled")));
			this.TaxValueLabel.Font = ((System.Drawing.Font)(resources.GetObject("TaxValueLabel.Font")));
			this.TaxValueLabel.Image = ((System.Drawing.Image)(resources.GetObject("TaxValueLabel.Image")));
			this.TaxValueLabel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("TaxValueLabel.ImageAlign")));
			this.TaxValueLabel.ImageIndex = ((int)(resources.GetObject("TaxValueLabel.ImageIndex")));
			this.TaxValueLabel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TaxValueLabel.ImeMode")));
			this.TaxValueLabel.Location = ((System.Drawing.Point)(resources.GetObject("TaxValueLabel.Location")));
			this.TaxValueLabel.Name = "TaxValueLabel";
			this.TaxValueLabel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TaxValueLabel.RightToLeft")));
			this.TaxValueLabel.Size = ((System.Drawing.Size)(resources.GetObject("TaxValueLabel.Size")));
			this.TaxValueLabel.TabIndex = ((int)(resources.GetObject("TaxValueLabel.TabIndex")));
			this.TaxValueLabel.Text = resources.GetString("TaxValueLabel.Text");
			this.TaxValueLabel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("TaxValueLabel.TextAlign")));
			this.TaxValueLabel.Visible = ((bool)(resources.GetObject("TaxValueLabel.Visible")));
			// 
			// Form1
			// 
			this.AccessibleDescription = ((string)(resources.GetObject("$this.AccessibleDescription")));
			this.AccessibleName = ((string)(resources.GetObject("$this.AccessibleName")));
			this.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("$this.Anchor")));
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.TaxValueLabel,
																		  this.CalcButton,
																		  this.TaxLabel,
																		  this.textBox2,
																		  this.SalaryLabel,
																		  this.textBox1,
																		  this.NameLabel});
			this.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("$this.Dock")));
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Form1";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Visible = ((bool)(resources.GetObject("$this.Visible")));
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

	
		private void CalcButton_Click(object sender, System.EventArgs e)
		{
			float tax;  
			//Calculate tax  
			tax = (float)0.2 * Convert.ToSingle(textBox2.Text);  
			//Display the tax amount  
			TaxValueLabel.Text = "$" + tax.ToString();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
