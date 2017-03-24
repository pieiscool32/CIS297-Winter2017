namespace Linq
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
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
			this.evensLabel = new System.Windows.Forms.Label();
			this.generateEvens = new System.Windows.Forms.Button();
			this.oddsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// evensLabel
			// 
			this.evensLabel.AutoSize = true;
			this.evensLabel.Location = new System.Drawing.Point(88, 100);
			this.evensLabel.Name = "evensLabel";
			this.evensLabel.Size = new System.Drawing.Size(0, 25);
			this.evensLabel.TabIndex = 0;
			// 
			// generateEvens
			// 
			this.generateEvens.Location = new System.Drawing.Point(648, 164);
			this.generateEvens.Name = "generateEvens";
			this.generateEvens.Size = new System.Drawing.Size(261, 119);
			this.generateEvens.TabIndex = 1;
			this.generateEvens.Text = "Show me the numbers!";
			this.generateEvens.UseVisualStyleBackColor = true;
			this.generateEvens.Click += new System.EventHandler(this.generateEvens_Click);
			// 
			// oddsLabel
			// 
			this.oddsLabel.AutoSize = true;
			this.oddsLabel.Location = new System.Drawing.Point(317, 100);
			this.oddsLabel.Name = "oddsLabel";
			this.oddsLabel.Size = new System.Drawing.Size(0, 25);
			this.oddsLabel.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1340, 608);
			this.Controls.Add(this.oddsLabel);
			this.Controls.Add(this.generateEvens);
			this.Controls.Add(this.evensLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label evensLabel;
		private System.Windows.Forms.Button generateEvens;
		private System.Windows.Forms.Label oddsLabel;
	}
}

