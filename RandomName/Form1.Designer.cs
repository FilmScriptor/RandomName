
namespace RandomName
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.nameAvailable = new System.Windows.Forms.ListBox();
			this.random = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// nameAvailable
			// 
			this.nameAvailable.FormattingEnabled = true;
			this.nameAvailable.ItemHeight = 15;
			this.nameAvailable.Items.AddRange(new object[] {
            "Jay",
            "Austin",
            "Nguyen",
            "Daniel",
            "Dennis",
            "Erick",
            "Joe",
            "Joshua",
            "Lumiere",
            "Michael",
            "Scott",
            "Torrie",
            "Yohan",
            "Billy"});
			this.nameAvailable.Location = new System.Drawing.Point(31, 28);
			this.nameAvailable.Name = "nameAvailable";
			this.nameAvailable.Size = new System.Drawing.Size(146, 304);
			this.nameAvailable.TabIndex = 0;
			// 
			// random
			// 
			this.random.Location = new System.Drawing.Point(191, 358);
			this.random.Name = "random";
			this.random.Size = new System.Drawing.Size(114, 40);
			this.random.TabIndex = 1;
			this.random.Text = "Random";
			this.random.UseVisualStyleBackColor = true;
			this.random.Click += new System.EventHandler(this.random_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(248, 28);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(411, 23);
			this.textBox1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.random);
			this.Controls.Add(this.nameAvailable);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox nameAvailable;
		private System.Windows.Forms.Button random;
		private System.Windows.Forms.TextBox textBox1;
	}
}

