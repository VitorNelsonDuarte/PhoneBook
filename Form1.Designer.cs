namespace PhoneBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStrip1 = new ToolStrip();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSplitButton1 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSplitButton2 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripSplitButton3 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSplitButton4 = new ToolStripButton();
            toolStripSplitButton5 = new ToolStripButton();
            process1 = new System.Diagnostics.Process();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 86);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 86);
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator3, toolStripSplitButton1, toolStripSeparator4, toolStripSplitButton2, toolStripSeparator6, toolStripSplitButton3, toolStripSeparator5, toolStripSplitButton4, toolStripSplitButton5, toolStripSeparator1, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1235, 86);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 86);
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(167, 83);
            toolStripSplitButton1.Text = "Register Data F2";
            toolStripSplitButton1.Click += toolStripSplitButton1_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 86);
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(128, 83);
            toolStripSplitButton2.Text = "Search  F3";
            toolStripSplitButton2.Click += toolStripSplitButton2_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 86);
            // 
            // toolStripSplitButton3
            // 
            toolStripSplitButton3.Image = (Image)resources.GetObject("toolStripSplitButton3.Image");
            toolStripSplitButton3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSplitButton3.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton3.Name = "toolStripSplitButton3";
            toolStripSplitButton3.Size = new Size(151, 83);
            toolStripSplitButton3.Text = "Calculator  F4";
            toolStripSplitButton3.Click += toolStripSplitButton3_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 86);
            // 
            // toolStripSplitButton4
            // 
            toolStripSplitButton4.Image = (Image)resources.GetObject("toolStripSplitButton4.Image");
            toolStripSplitButton4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSplitButton4.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton4.Name = "toolStripSplitButton4";
            toolStripSplitButton4.Size = new Size(145, 83);
            toolStripSplitButton4.Text = "About Us  F5";
            toolStripSplitButton4.Click += toolStripSplitButton4_Click;
            // 
            // toolStripSplitButton5
            // 
            toolStripSplitButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripSplitButton5.Image = (Image)resources.GetObject("toolStripSplitButton5.Image");
            toolStripSplitButton5.ImageScaling = ToolStripItemImageScaling.None;
            toolStripSplitButton5.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton5.Name = "toolStripSplitButton5";
            toolStripSplitButton5.Size = new Size(124, 83);
            toolStripSplitButton5.Text = "Exit  (Esc)";
            toolStripSplitButton5.Click += toolStripSplitButton5_Click;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bulldog-2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1235, 727);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phone Book";
            KeyDown += Form1_KeyDown;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripSplitButton1;
        private ToolStripButton toolStripSplitButton2;
        private ToolStripButton toolStripSplitButton3;
        private ToolStripButton toolStripSplitButton4;
        private ToolStripButton toolStripSplitButton5;
        private System.Diagnostics.Process process1;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
    }
}