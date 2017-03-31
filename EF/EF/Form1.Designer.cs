namespace EF
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
			this.components = new System.ComponentModel.Container();
			this.courseLabel = new System.Windows.Forms.Label();
			this.offeringsLabel = new System.Windows.Forms.Label();
			this.courseDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.newCourseButton = new System.Windows.Forms.Button();
			this.courseNumberTextBox = new System.Windows.Forms.TextBox();
			this.courseDescriptionTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.multiLineTextBox = new System.Windows.Forms.TextBox();
			this.courseOfferingBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.courseOfferingBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// courseLabel
			// 
			this.courseLabel.AutoSize = true;
			this.courseLabel.Location = new System.Drawing.Point(186, 142);
			this.courseLabel.Name = "courseLabel";
			this.courseLabel.Size = new System.Drawing.Size(0, 25);
			this.courseLabel.TabIndex = 0;
			// 
			// offeringsLabel
			// 
			this.offeringsLabel.AutoSize = true;
			this.offeringsLabel.Location = new System.Drawing.Point(477, 97);
			this.offeringsLabel.Name = "offeringsLabel";
			this.offeringsLabel.Size = new System.Drawing.Size(0, 25);
			this.offeringsLabel.TabIndex = 1;
			// 
			// courseDepartmentTextBox
			// 
			this.courseDepartmentTextBox.Location = new System.Drawing.Point(522, 465);
			this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
			this.courseDepartmentTextBox.Size = new System.Drawing.Size(100, 31);
			this.courseDepartmentTextBox.TabIndex = 2;
			// 
			// newCourseButton
			// 
			this.newCourseButton.Location = new System.Drawing.Point(1036, 465);
			this.newCourseButton.Name = "newCourseButton";
			this.newCourseButton.Size = new System.Drawing.Size(244, 56);
			this.newCourseButton.TabIndex = 3;
			this.newCourseButton.Text = "Add New Course";
			this.newCourseButton.UseVisualStyleBackColor = true;
			this.newCourseButton.Click += new System.EventHandler(this.newCourseButton_Click);
			// 
			// courseNumberTextBox
			// 
			this.courseNumberTextBox.Location = new System.Drawing.Point(674, 465);
			this.courseNumberTextBox.Name = "courseNumberTextBox";
			this.courseNumberTextBox.Size = new System.Drawing.Size(100, 31);
			this.courseNumberTextBox.TabIndex = 4;
			// 
			// courseDescriptionTextBox
			// 
			this.courseDescriptionTextBox.Location = new System.Drawing.Point(847, 465);
			this.courseDescriptionTextBox.Name = "courseDescriptionTextBox";
			this.courseDescriptionTextBox.Size = new System.Drawing.Size(100, 31);
			this.courseDescriptionTextBox.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1049, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(274, 49);
			this.button1.TabIndex = 6;
			this.button1.Text = "Show Current Courses";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// multiLineTextBox
			// 
			this.multiLineTextBox.Enabled = false;
			this.multiLineTextBox.Location = new System.Drawing.Point(112, 114);
			this.multiLineTextBox.Multiline = true;
			this.multiLineTextBox.Name = "multiLineTextBox";
			this.multiLineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.multiLineTextBox.Size = new System.Drawing.Size(341, 255);
			this.multiLineTextBox.TabIndex = 7;
			
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1568, 812);
			this.Controls.Add(this.multiLineTextBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.courseDescriptionTextBox);
			this.Controls.Add(this.courseNumberTextBox);
			this.Controls.Add(this.newCourseButton);
			this.Controls.Add(this.courseDepartmentTextBox);
			this.Controls.Add(this.offeringsLabel);
			this.Controls.Add(this.courseLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.courseOfferingBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label courseLabel;
		private System.Windows.Forms.Label offeringsLabel;
		private System.Windows.Forms.TextBox courseDepartmentTextBox;
		private System.Windows.Forms.Button newCourseButton;
		private System.Windows.Forms.TextBox courseNumberTextBox;
		private System.Windows.Forms.TextBox courseDescriptionTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource courseOfferingBindingSource;
		private System.Windows.Forms.TextBox multiLineTextBox;
		private System.Windows.Forms.BindingSource courseBindingSource;
		private System.Windows.Forms.BindingSource courseBindingSource1;
	}
}