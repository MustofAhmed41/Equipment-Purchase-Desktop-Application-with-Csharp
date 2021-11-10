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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string message)
        {
            InitializeComponent();
            displayMessage.Text = message;
        }

        private void dismissBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}
