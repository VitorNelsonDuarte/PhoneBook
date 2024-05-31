namespace PhoneBook
{
    partial class Reg_data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_data));
            toolStrip1 = new ToolStrip();
            new_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            save_btn = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            info_gbox = new GroupBox();
            mobile_txt = new TextBox();
            mobile_lbl = new Label();
            comments_txt = new TextBox();
            comments_lbl = new Label();
            address_txt = new TextBox();
            email_txt = new TextBox();
            address_lbl = new Label();
            telephone_lbl = new Label();
            firstName_txt = new TextBox();
            lastName_lbl = new Label();
            telephone_txt = new TextBox();
            email_lbl = new Label();
            lastName_txt = new TextBox();
            first_name_lbl = new Label();
            id_txt = new TextBox();
            id_lbl = new Label();
            toolStrip1.SuspendLayout();
            info_gbox.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, save_btn, toolStripSeparator2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(576, 59);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_btn
            // 
            new_btn.Image = (Image)resources.GetObject("new_btn.Image");
            new_btn.ImageScaling = ToolStripItemImageScaling.None;
            new_btn.ImageTransparentColor = Color.Magenta;
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(111, 56);
            new_btn.Text = "New Data";
            new_btn.Click += new_btn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 59);
            // 
            // save_btn
            // 
            save_btn.Enabled = false;
            save_btn.Image = (Image)resources.GetObject("save_btn.Image");
            save_btn.ImageScaling = ToolStripItemImageScaling.None;
            save_btn.ImageTransparentColor = Color.Magenta;
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(136, 56);
            save_btn.Text = "Save Changes";
            save_btn.Click += save_btn_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 59);
            // 
            // info_gbox
            // 
            info_gbox.Controls.Add(mobile_txt);
            info_gbox.Controls.Add(mobile_lbl);
            info_gbox.Controls.Add(comments_txt);
            info_gbox.Controls.Add(comments_lbl);
            info_gbox.Controls.Add(address_txt);
            info_gbox.Controls.Add(email_txt);
            info_gbox.Controls.Add(address_lbl);
            info_gbox.Controls.Add(telephone_lbl);
            info_gbox.Controls.Add(firstName_txt);
            info_gbox.Controls.Add(lastName_lbl);
            info_gbox.Controls.Add(telephone_txt);
            info_gbox.Controls.Add(email_lbl);
            info_gbox.Controls.Add(lastName_txt);
            info_gbox.Controls.Add(first_name_lbl);
            info_gbox.Controls.Add(id_txt);
            info_gbox.Controls.Add(id_lbl);
            info_gbox.Enabled = false;
            info_gbox.Location = new Point(12, 79);
            info_gbox.Name = "info_gbox";
            info_gbox.Size = new Size(552, 519);
            info_gbox.TabIndex = 1;
            info_gbox.TabStop = false;
            info_gbox.Text = "Information";
            // 
            // mobile_txt
            // 
            mobile_txt.Location = new Point(166, 245);
            mobile_txt.Name = "mobile_txt";
            mobile_txt.Size = new Size(278, 27);
            mobile_txt.TabIndex = 13;
            // 
            // mobile_lbl
            // 
            mobile_lbl.AutoSize = true;
            mobile_lbl.Location = new Point(91, 252);
            mobile_lbl.Name = "mobile_lbl";
            mobile_lbl.Size = new Size(56, 20);
            mobile_lbl.TabIndex = 12;
            mobile_lbl.Text = "Mobile";
            // 
            // comments_txt
            // 
            comments_txt.Location = new Point(166, 371);
            comments_txt.Name = "comments_txt";
            comments_txt.Size = new Size(278, 27);
            comments_txt.TabIndex = 11;
            // 
            // comments_lbl
            // 
            comments_lbl.AutoSize = true;
            comments_lbl.Location = new Point(67, 378);
            comments_lbl.Name = "comments_lbl";
            comments_lbl.Size = new Size(80, 20);
            comments_lbl.TabIndex = 10;
            comments_lbl.Text = "Comments";
            // 
            // address_txt
            // 
            address_txt.Location = new Point(166, 327);
            address_txt.Name = "address_txt";
            address_txt.Size = new Size(278, 27);
            address_txt.TabIndex = 3;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(166, 285);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(278, 27);
            email_txt.TabIndex = 9;
            // 
            // address_lbl
            // 
            address_lbl.AutoSize = true;
            address_lbl.Location = new Point(85, 334);
            address_lbl.Name = "address_lbl";
            address_lbl.Size = new Size(62, 20);
            address_lbl.TabIndex = 2;
            address_lbl.Text = "Address";
            // 
            // telephone_lbl
            // 
            telephone_lbl.AutoSize = true;
            telephone_lbl.Location = new Point(70, 207);
            telephone_lbl.Name = "telephone_lbl";
            telephone_lbl.Size = new Size(78, 20);
            telephone_lbl.TabIndex = 8;
            telephone_lbl.Text = "Telephone";
            // 
            // firstName_txt
            // 
            firstName_txt.Location = new Point(166, 112);
            firstName_txt.Name = "firstName_txt";
            firstName_txt.Size = new Size(278, 27);
            firstName_txt.TabIndex = 7;
            // 
            // lastName_lbl
            // 
            lastName_lbl.AutoSize = true;
            lastName_lbl.Location = new Point(68, 162);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(79, 20);
            lastName_lbl.TabIndex = 6;
            lastName_lbl.Text = "Last Name";
            // 
            // telephone_txt
            // 
            telephone_txt.Location = new Point(166, 200);
            telephone_txt.Name = "telephone_txt";
            telephone_txt.Size = new Size(278, 27);
            telephone_txt.TabIndex = 5;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(101, 292);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(46, 20);
            email_lbl.TabIndex = 4;
            email_lbl.Text = "Email";
            // 
            // lastName_txt
            // 
            lastName_txt.Location = new Point(166, 155);
            lastName_txt.Name = "lastName_txt";
            lastName_txt.Size = new Size(278, 27);
            lastName_txt.TabIndex = 3;
            // 
            // first_name_lbl
            // 
            first_name_lbl.AutoSize = true;
            first_name_lbl.Location = new Point(68, 119);
            first_name_lbl.Name = "first_name_lbl";
            first_name_lbl.Size = new Size(80, 20);
            first_name_lbl.TabIndex = 2;
            first_name_lbl.Text = "First Name";
            // 
            // id_txt
            // 
            id_txt.Location = new Point(166, 66);
            id_txt.Name = "id_txt";
            id_txt.Size = new Size(278, 27);
            id_txt.TabIndex = 1;
            // 
            // id_lbl
            // 
            id_lbl.AutoSize = true;
            id_lbl.Location = new Point(121, 73);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(27, 20);
            id_lbl.TabIndex = 0;
            id_lbl.Text = "ID:";
            // 
            // Reg_data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(576, 625);
            Controls.Add(info_gbox);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "Reg_data";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register Data";
            Load += Reg_data_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            info_gbox.ResumeLayout(false);
            info_gbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton new_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton save_btn;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox info_gbox;
        private TextBox comments_txt;
        private Label comments_lbl;
        private TextBox address_txt;
        private TextBox email_txt;
        private Label address_lbl;
        private Label telephone_lbl;
        private TextBox firstName_txt;
        private Label lastName_lbl;
        private TextBox telephone_txt;
        private Label email_lbl;
        private TextBox lastName_txt;
        private Label first_name_lbl;
        private TextBox id_txt;
        private Label id_lbl;
        private TextBox mobile_txt;
        private Label mobile_lbl;
    }
}