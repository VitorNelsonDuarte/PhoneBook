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
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (this.search_txt.Text == "")
            {
                MessageBox.Show("You Must Enter a ID value!");
                return;
            }

            string fileName;
            fileName = "D:\\Phonebook\\";
            string path;
            string read;

            // First Name
            path = fileName + this.search_txt.Text + "_firstName.txt";

            //Check if file exist
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.firstName_txt.Text = read;
            }

            //Last Name
            path = fileName + this.search_txt.Text + "_lastName.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.lastName_txt.Text = read;
            }

            // Telephone
            path = fileName + this.search_txt.Text + "_telephone.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.telephone_txt.Text = read;
            }

            //Mobile
            path = fileName + this.search_txt.Text + "_mobile.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.mobile_txt.Text = read;
            }

            // Email
            path = fileName + this.search_txt.Text + "_email.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.email_txt.Text = read;
            }

            //Address
            path = fileName + this.search_txt.Text + "_address.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.address_txt.Text = read;
            }

            //Comments
            path = fileName + this.search_txt.Text + "_comments.txt";
            if (System.IO.File.Exists(path) == true)
            {
                read = System.IO.File.ReadAllText(path, Encoding.UTF8);
                this.comments_txt.Text = read;
            }

            this.id_txt.Text = this.id_txt.Text;
        }
    }
}
