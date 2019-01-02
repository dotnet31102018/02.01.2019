namespace Targil5
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
            this.smileyPic = new System.Windows.Forms.PictureBox();
            this.jumpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.smileyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // smileyPic
            // 
            this.smileyPic.Image = global::Targil5.Properties.Resources.ball2;
            this.smileyPic.Location = new System.Drawing.Point(229, 119);
            this.smileyPic.Name = "smileyPic";
            this.smileyPic.Size = new System.Drawing.Size(96, 87);
            this.smileyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.smileyPic.TabIndex = 0;
            this.smileyPic.TabStop = false;
            // 
            // jumpBtn
            // 
            this.jumpBtn.Location = new System.Drawing.Point(432, 119);
            this.jumpBtn.Name = "jumpBtn";
            this.jumpBtn.Size = new System.Drawing.Size(92, 33);
            this.jumpBtn.TabIndex = 1;
            this.jumpBtn.Text = "Jump!";
            this.jumpBtn.UseVisualStyleBackColor = true;
            this.jumpBtn.Click += new System.EventHandler(this.jumpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 461);
            this.Controls.Add(this.jumpBtn);
            this.Controls.Add(this.smileyPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.smileyPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox smileyPic;
        private System.Windows.Forms.Button jumpBtn;
    }
}

