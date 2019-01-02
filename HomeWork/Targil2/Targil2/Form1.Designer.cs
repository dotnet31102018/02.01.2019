namespace Targil2
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
            this.numberLbl = new System.Windows.Forms.Label();
            this.nextNumberBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(120, 82);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(51, 55);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "?";
            // 
            // nextNumberBtn
            // 
            this.nextNumberBtn.Location = new System.Drawing.Point(95, 190);
            this.nextNumberBtn.Name = "nextNumberBtn";
            this.nextNumberBtn.Size = new System.Drawing.Size(108, 23);
            this.nextNumberBtn.TabIndex = 1;
            this.nextNumberBtn.Text = "Next Number";
            this.nextNumberBtn.UseVisualStyleBackColor = true;
            this.nextNumberBtn.Click += new System.EventHandler(this.nextNumberBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.nextNumberBtn);
            this.Controls.Add(this.numberLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.Button nextNumberBtn;
    }
}

