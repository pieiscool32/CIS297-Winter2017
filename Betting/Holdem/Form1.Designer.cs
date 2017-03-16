namespace Holdem
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
			this.shared1Label = new System.Windows.Forms.Label();
			this.shared2Label = new System.Windows.Forms.Label();
			this.shared3Label = new System.Windows.Forms.Label();
			this.shared4Label = new System.Windows.Forms.Label();
			this.shared5Label = new System.Windows.Forms.Label();
			this.mine1 = new System.Windows.Forms.Label();
			this.mine2 = new System.Windows.Forms.Label();
			this.computer1 = new System.Windows.Forms.Label();
			this.computer2 = new System.Windows.Forms.Label();
			this.dealButton = new System.Windows.Forms.Button();
			this.computerBest = new System.Windows.Forms.Label();
			this.playerBest = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// shared1Label
			// 
			this.shared1Label.AutoSize = true;
			this.shared1Label.Location = new System.Drawing.Point(116, 307);
			this.shared1Label.Name = "shared1Label";
			this.shared1Label.Size = new System.Drawing.Size(0, 13);
			this.shared1Label.TabIndex = 0;
			// 
			// shared2Label
			// 
			this.shared2Label.AutoSize = true;
			this.shared2Label.Location = new System.Drawing.Point(260, 307);
			this.shared2Label.Name = "shared2Label";
			this.shared2Label.Size = new System.Drawing.Size(0, 13);
			this.shared2Label.TabIndex = 1;
			// 
			// shared3Label
			// 
			this.shared3Label.AutoSize = true;
			this.shared3Label.Location = new System.Drawing.Point(382, 307);
			this.shared3Label.Name = "shared3Label";
			this.shared3Label.Size = new System.Drawing.Size(0, 13);
			this.shared3Label.TabIndex = 2;
			// 
			// shared4Label
			// 
			this.shared4Label.AutoSize = true;
			this.shared4Label.Location = new System.Drawing.Point(509, 307);
			this.shared4Label.Name = "shared4Label";
			this.shared4Label.Size = new System.Drawing.Size(0, 13);
			this.shared4Label.TabIndex = 3;
			// 
			// shared5Label
			// 
			this.shared5Label.AutoSize = true;
			this.shared5Label.Location = new System.Drawing.Point(639, 307);
			this.shared5Label.Name = "shared5Label";
			this.shared5Label.Size = new System.Drawing.Size(0, 13);
			this.shared5Label.TabIndex = 4;
			// 
			// mine1
			// 
			this.mine1.AutoSize = true;
			this.mine1.Location = new System.Drawing.Point(260, 483);
			this.mine1.Name = "mine1";
			this.mine1.Size = new System.Drawing.Size(0, 13);
			this.mine1.TabIndex = 5;
			// 
			// mine2
			// 
			this.mine2.AutoSize = true;
			this.mine2.Location = new System.Drawing.Point(420, 482);
			this.mine2.Name = "mine2";
			this.mine2.Size = new System.Drawing.Size(0, 13);
			this.mine2.TabIndex = 6;
			// 
			// computer1
			// 
			this.computer1.AutoSize = true;
			this.computer1.Location = new System.Drawing.Point(237, 114);
			this.computer1.Name = "computer1";
			this.computer1.Size = new System.Drawing.Size(0, 13);
			this.computer1.TabIndex = 7;
			// 
			// computer2
			// 
			this.computer2.AutoSize = true;
			this.computer2.Location = new System.Drawing.Point(487, 114);
			this.computer2.Name = "computer2";
			this.computer2.Size = new System.Drawing.Size(0, 13);
			this.computer2.TabIndex = 8;
			// 
			// dealButton
			// 
			this.dealButton.Location = new System.Drawing.Point(1156, 307);
			this.dealButton.Name = "dealButton";
			this.dealButton.Size = new System.Drawing.Size(75, 23);
			this.dealButton.TabIndex = 9;
			this.dealButton.Text = "Deal";
			this.dealButton.UseVisualStyleBackColor = true;
			this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
			// 
			// computerBest
			// 
			this.computerBest.AutoSize = true;
			this.computerBest.Location = new System.Drawing.Point(308, 40);
			this.computerBest.Name = "computerBest";
			this.computerBest.Size = new System.Drawing.Size(0, 13);
			this.computerBest.TabIndex = 10;
			// 
			// playerBest
			// 
			this.playerBest.AutoSize = true;
			this.playerBest.Location = new System.Drawing.Point(311, 556);
			this.playerBest.Name = "playerBest";
			this.playerBest.Size = new System.Drawing.Size(0, 13);
			this.playerBest.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1384, 709);
			this.Controls.Add(this.playerBest);
			this.Controls.Add(this.computerBest);
			this.Controls.Add(this.dealButton);
			this.Controls.Add(this.computer2);
			this.Controls.Add(this.computer1);
			this.Controls.Add(this.mine2);
			this.Controls.Add(this.mine1);
			this.Controls.Add(this.shared5Label);
			this.Controls.Add(this.shared4Label);
			this.Controls.Add(this.shared3Label);
			this.Controls.Add(this.shared2Label);
			this.Controls.Add(this.shared1Label);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label shared1Label;
		private System.Windows.Forms.Label shared2Label;
		private System.Windows.Forms.Label shared3Label;
		private System.Windows.Forms.Label shared4Label;
		private System.Windows.Forms.Label shared5Label;
		private System.Windows.Forms.Label mine1;
		private System.Windows.Forms.Label mine2;
		private System.Windows.Forms.Label computer1;
		private System.Windows.Forms.Label computer2;
		private System.Windows.Forms.Button dealButton;
		private System.Windows.Forms.Label computerBest;
		private System.Windows.Forms.Label playerBest;
	}
}

