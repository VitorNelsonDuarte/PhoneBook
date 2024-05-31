namespace PhoneBook
{
    partial class AboutUs_form
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 60);
            label1.Name = "label1";
            label1.Size = new Size(229, 31);
            label1.TabIndex = 0;
            label1.Text = "Vitor Nelson Duarte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 114);
            label2.Name = "label2";
            label2.Size = new Size(336, 28);
            label2.TabIndex = 1;
            label2.Text = "Product Name: C# Forms Phonebook";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 1);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 163);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 3;
            label3.Text = "Version: 2023.09.20.1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 315);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 4;
            label4.Text = "All Rights Reserved";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 273);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "2020-2023";
            // 
            // AboutUs_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(438, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutUs_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}