namespace WindowsFormsApp8
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
			this.nameLbl = new System.Windows.Forms.Label();
			this.adressLbl = new System.Windows.Forms.Label();
			this.mailLbl = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(56, 82);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(72, 13);
			this.nameLbl.TabIndex = 0;
			this.nameLbl.Text = "John Bonham";
			this.nameLbl.Click += new System.EventHandler(this.label1_Click);
			// 
			// adressLbl
			// 
			this.adressLbl.AutoSize = true;
			this.adressLbl.Location = new System.Drawing.Point(56, 154);
			this.adressLbl.Name = "adressLbl";
			this.adressLbl.Size = new System.Drawing.Size(64, 13);
			this.adressLbl.TabIndex = 1;
			this.adressLbl.Text = "London, UK";
			// 
			// mailLbl
			// 
			this.mailLbl.AutoSize = true;
			this.mailLbl.Location = new System.Drawing.Point(56, 230);
			this.mailLbl.Name = "mailLbl";
			this.mailLbl.Size = new System.Drawing.Size(123, 13);
			this.mailLbl.TabIndex = 2;
			this.mailLbl.Text = "johnbonham@gmail.com";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::WindowsFormsApp8.Properties.Resources._1;
			this.pictureBox1.Location = new System.Drawing.Point(245, 82);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(203, 176);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 391);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.mailLbl);
			this.Controls.Add(this.adressLbl);
			this.Controls.Add(this.nameLbl);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.Label adressLbl;
		private System.Windows.Forms.Label mailLbl;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

