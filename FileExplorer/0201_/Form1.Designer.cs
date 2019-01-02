namespace _0201_
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.colorLabel = new System.Windows.Forms.Label();
            this.frontColor = new System.Windows.Forms.Button();
            this.backColor = new System.Windows.Forms.Button();
            this.myColorDialog = new System.Windows.Forms.ColorDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadImageBtn = new System.Windows.Forms.Button();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadTxtFileBtn = new System.Windows.Forms.Button();
            this.fileLines = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.myTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // myTabs
            // 
            this.myTabs.Controls.Add(this.tabPage1);
            this.myTabs.Controls.Add(this.tabPage2);
            this.myTabs.Controls.Add(this.tabPage3);
            this.myTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabs.Location = new System.Drawing.Point(0, 24);
            this.myTabs.Name = "myTabs";
            this.myTabs.SelectedIndex = 0;
            this.myTabs.Size = new System.Drawing.Size(484, 421);
            this.myTabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.backColor);
            this.tabPage1.Controls.Add(this.frontColor);
            this.tabPage1.Controls.Add(this.colorLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(476, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Colors";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loadImageBtn);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(476, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fileLines);
            this.tabPage3.Controls.Add(this.loadTxtFileBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(476, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Text File";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(92, 86);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(277, 55);
            this.colorLabel.TabIndex = 0;
            this.colorLabel.Text = "I Love .NET";
            // 
            // frontColor
            // 
            this.frontColor.Location = new System.Drawing.Point(67, 249);
            this.frontColor.Name = "frontColor";
            this.frontColor.Size = new System.Drawing.Size(129, 32);
            this.frontColor.TabIndex = 1;
            this.frontColor.Text = "Foreground Color";
            this.frontColor.UseVisualStyleBackColor = true;
            this.frontColor.Click += new System.EventHandler(this.frontColor_Click);
            // 
            // backColor
            // 
            this.backColor.Location = new System.Drawing.Point(266, 249);
            this.backColor.Name = "backColor";
            this.backColor.Size = new System.Drawing.Size(129, 32);
            this.backColor.TabIndex = 2;
            this.backColor.Text = "Background Color";
            this.backColor.UseVisualStyleBackColor = true;
            this.backColor.Click += new System.EventHandler(this.backColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(470, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadImageBtn
            // 
            this.loadImageBtn.Location = new System.Drawing.Point(187, 328);
            this.loadImageBtn.Name = "loadImageBtn";
            this.loadImageBtn.Size = new System.Drawing.Size(129, 32);
            this.loadImageBtn.TabIndex = 2;
            this.loadImageBtn.Text = "Load &Image";
            this.loadImageBtn.UseVisualStyleBackColor = true;
            this.loadImageBtn.Click += new System.EventHandler(this.loadImageBtn_Click);
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // loadTxtFileBtn
            // 
            this.loadTxtFileBtn.Location = new System.Drawing.Point(182, 317);
            this.loadTxtFileBtn.Name = "loadTxtFileBtn";
            this.loadTxtFileBtn.Size = new System.Drawing.Size(129, 32);
            this.loadTxtFileBtn.TabIndex = 3;
            this.loadTxtFileBtn.Text = "Load &Text File";
            this.loadTxtFileBtn.UseVisualStyleBackColor = true;
            this.loadTxtFileBtn.Click += new System.EventHandler(this.loadTxtFileBtn_Click);
            // 
            // fileLines
            // 
            this.fileLines.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileLines.FormattingEnabled = true;
            this.fileLines.Location = new System.Drawing.Point(0, 0);
            this.fileLines.Name = "fileLines";
            this.fileLines.Size = new System.Drawing.Size(476, 264);
            this.fileLines.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 445);
            this.Controls.Add(this.myTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.myTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl myTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button backColor;
        private System.Windows.Forms.Button frontColor;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog myColorDialog;
        private System.Windows.Forms.Button loadImageBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.ListBox fileLines;
        private System.Windows.Forms.Button loadTxtFileBtn;
    }
}

