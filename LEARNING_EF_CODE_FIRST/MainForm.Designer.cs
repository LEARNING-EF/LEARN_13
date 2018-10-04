namespace LEARNING_EF_CODE_FIRST
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.createANewCountryButton = new System.Windows.Forms.Button();
			this.createCountryStatesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// createANewCountryButton
			// 
			this.createANewCountryButton.Location = new System.Drawing.Point(12, 12);
			this.createANewCountryButton.Name = "createANewCountryButton";
			this.createANewCountryButton.Size = new System.Drawing.Size(260, 23);
			this.createANewCountryButton.TabIndex = 0;
			this.createANewCountryButton.Text = "Create a New Country";
			this.createANewCountryButton.UseVisualStyleBackColor = true;
			this.createANewCountryButton.Click += new System.EventHandler(this.CreateANewCountryButton_Click);
			// 
			// createCountryStatesButton
			// 
			this.createCountryStatesButton.Location = new System.Drawing.Point(12, 41);
			this.createCountryStatesButton.Name = "createCountryStatesButton";
			this.createCountryStatesButton.Size = new System.Drawing.Size(260, 23);
			this.createCountryStatesButton.TabIndex = 1;
			this.createCountryStatesButton.Text = "Create the Country States";
			this.createCountryStatesButton.UseVisualStyleBackColor = true;
			this.createCountryStatesButton.Click += new System.EventHandler(this.CreateCountryStatesButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.createCountryStatesButton);
			this.Controls.Add(this.createANewCountryButton);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createANewCountryButton;
		private System.Windows.Forms.Button createCountryStatesButton;
	}
}
