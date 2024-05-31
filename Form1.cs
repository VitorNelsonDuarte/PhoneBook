namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripSplitButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "\"C:\\Windows\\System32\\calc.exe\"";
            this.process1.Start();
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            Reg_data rg = new Reg_data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripSplitButton2_Click(object sender, EventArgs e)
        {
            Search_Form rg = new Search_Form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripSplitButton4_Click(object sender, EventArgs e)
        {
            AboutUs_form rg = new AboutUs_form()
            {
                MdiParent = this
            };
            rg.Show();
        }

        private void toolStripSplitButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                toolStripSplitButton1_Click(sender, e);
            }

            if (e.KeyCode == Keys.F3)
            {
                toolStripSplitButton2_Click(sender, e);
            }

            if (e.KeyCode == Keys.F4)
            {
                toolStripSplitButton3_Click(sender, e);
            }

            if (e.KeyCode == Keys.F5)
            {
                toolStripSplitButton4_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                toolStripSplitButton5_Click(sender, e);
            }
        }
    }
}