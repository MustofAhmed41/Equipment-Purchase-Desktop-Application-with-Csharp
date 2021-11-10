using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _180104005_Assignment2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            bool check = checkInput();
            if (!check)
            {
                return;
            }

            Form1 form = new Form1(username.Text, password.Text);
            this.Hide();
            form.ShowDialog();

        }

        private bool checkInput()
        {
            if (username.Text == "" || password.Text == "" )
            {
                Form3 form = new Form3("Input Field Cannot be Empty!");                
                form.ShowDialog();
                return false;
            }
            if (password.Text!="180104005")
            {
                Form3 form = new Form3("Incorrect Credentials");
                form.ShowDialog();
                return false;
            }
            if(username.Text!="Mustofa Ahmed")
            {
                Form3 form = new Form3("Incorrect Credentials");
                form.ShowDialog();
                return false;
            }
            return true;
        }

    }

}
