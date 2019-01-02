namespace HW0201
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
            this.labelWithColor = new System.Windows.Forms.Label();
            this.redPanel = new System.Windows.Forms.Panel();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.bluePanel = new System.Windows.Forms.Panel();
            this.purplePanel = new System.Windows.Forms.Panel();
            this.olivePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelWithColor
            // 
            this.labelWithColor.AutoSize = true;
            this.labelWithColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWithColor.Location = new System.Drawing.Point(77, 59);
            this.labelWithColor.Name = "labelWithColor";
            this.labelWithColor.Size = new System.Drawing.Size(491, 55);
            this.labelWithColor.TabIndex = 0;
            this.labelWithColor.Text = "I am A windows Label";
            // 
            // redPanel
            // 
            this.redPanel.BackColor = System.Drawing.Color.Red;
            this.redPanel.Location = new System.Drawing.Point(90, 145);
            this.redPanel.Name = "redPanel";
            this.redPanel.Size = new System.Drawing.Size(90, 60);
            this.redPanel.TabIndex = 1;
            this.redPanel.Click += new System.EventHandler(this.redPanel_Click);
            // 
            // yellowPanel
            // 
            this.yellowPanel.BackColor = System.Drawing.Color.Yellow;
            this.yellowPanel.Location = new System.Drawing.Point(267, 145);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(90, 60);
            this.yellowPanel.TabIndex = 2;
            this.yellowPanel.Click += new System.EventHandler(this.yellowPanel_Click);
            // 
            // bluePanel
            // 
            this.bluePanel.BackColor = System.Drawing.Color.Blue;
            this.bluePanel.Location = new System.Drawing.Point(449, 145);
            this.bluePanel.Name = "bluePanel";
            this.bluePanel.Size = new System.Drawing.Size(90, 60);
            this.bluePanel.TabIndex = 2;
            this.bluePanel.Click += new System.EventHandler(this.bluePanel_Click);
            // 
            // purplePanel
            // 
            this.purplePanel.BackColor = System.Drawing.Color.Fuchsia;
            this.purplePanel.Location = new System.Drawing.Point(178, 145);
            this.purplePanel.Name = "purplePanel";
            this.purplePanel.Size = new System.Drawing.Size(90, 60);
            this.purplePanel.TabIndex = 2;
            this.purplePanel.Click += new System.EventHandler(this.purplePanel_Click_1);
            // 
            // olivePanel
            // 
            this.olivePanel.BackColor = System.Drawing.Color.Olive;
            this.olivePanel.Location = new System.Drawing.Point(357, 145);
            this.olivePanel.Name = "olivePanel";
            this.olivePanel.Size = new System.Drawing.Size(90, 60);
            this.olivePanel.TabIndex = 2;
            this.olivePanel.Click += new System.EventHandler(this.olivePanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 254);
            this.Controls.Add(this.olivePanel);
            this.Controls.Add(this.purplePanel);
            this.Controls.Add(this.bluePanel);
            this.Controls.Add(this.yellowPanel);
            this.Controls.Add(this.redPanel);
            this.Controls.Add(this.labelWithColor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWithColor;
        private System.Windows.Forms.Panel redPanel;
        private System.Windows.Forms.Panel yellowPanel;
        private System.Windows.Forms.Panel bluePanel;
        private System.Windows.Forms.Panel purplePanel;
        private System.Windows.Forms.Panel olivePanel;
    }
}

