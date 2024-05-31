using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            this.new_btn.Enabled = false;
            this.save_btn.Enabled = true;
            //----------------------------
            this.info_gbox.Enabled = true;

            //Clear TextBox
            this.id_txt.ResetText();
            this.firstName_txt.ResetText();
            this.lastName_txt.ResetText();
            this.email_txt.ResetText();
            this.telephone_txt.ResetText();
            this.mobile_txt.ResetText();
            this.comments_txt.ResetText();
            this.address_txt.ResetText();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (this.id_txt.Text == "")
            {
                MessageBox.Show("You Must Enter ID!");
                return;
            }

            this.save_btn.Enabled = false;
            this.new_btn.Enabled = true;
            //----------------------------
            this.info_gbox.Enabled = false;

            //Saving data
            string fileName;
            fileName = "D:\\Phonebook\\";
            string path;
            //First Name
            path = fileName + this.id_txt.Text + "_firstName.txt";
            System.IO.File.WriteAllText(path, this.firstName_txt.Text, Encoding.UTF8);
            //Last Name
            path = fileName + this.id_txt.Text + "_lastName.txt";
            System.IO.File.WriteAllText(path, this.lastName_txt.Text, Encoding.UTF8);
            //Telephone
            path = fileName + this.id_txt.Text + "_telephone.txt";
            System.IO.File.WriteAllText(path, this.telephone_txt.Text, Encoding.UTF8);
            //Mobile
            path = fileName + this.id_txt.Text + "_mobile.txt";
            System.IO.File.WriteAllText(path, this.mobile_txt.Text, Encoding.UTF8);
            //Email
            path = fileName + this.id_txt.Text + "_email.txt";
            System.IO.File.WriteAllText(path, this.email_txt.Text, Encoding.UTF8);
            //Address
            path = fileName + this.id_txt.Text + "_address.txt";
            System.IO.File.WriteAllText(path, this.address_txt.Text, Encoding.UTF8);
            //Comments
            path = fileName + this.id_txt.Text + "_comments.txt";
            System.IO.File.WriteAllText(path, this.comments_txt.Text, Encoding.UTF8);

            MessageBox.Show("Saved!"); 
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.info_gbox.Enabled = false;
        }
    }
}
