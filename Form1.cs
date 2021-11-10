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
    public partial class Form1 : Form
    {   
        private int mAmount1, mAmount2,mAmount3,mAmount4,mAmount5;
        private int mUnit1, mUnit2, mUnit3, mUnit4, mUnit5;
        public Form1()
        {
            InitializeComponent();            
        }

        public Form1(String userName, String password)
        {
            InitializeComponent();
            customerName.Text =   userName;
            customerId.Text =  password;
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void onKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
       
            {
                e.Handled = true;
            }

           

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox11_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void bunifuMaterialTextbox12_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click_1(object sender, EventArgs e)
        {

        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalPriceBtn_Click(object sender, EventArgs e)
        {

            bool emptyCheck = checkEmptyInputs();
            if (!emptyCheck)
            {
                return;
            }
            bool amountCheck  = checkAmount(mAmount1, mAmount2, mAmount3, mAmount4, mAmount5);
            bool unitCheck  = checkUnit(mUnit1, mUnit2, mUnit3, mUnit4, mUnit5);
            if (!amountCheck || !unitCheck)
            {
                return;
            }
            
            double totalCalculatedPrice = 0;
            totalCalculatedPrice = mUnit1 * mAmount1 + mUnit2 * mAmount2 +
                mUnit3 * mAmount3 + mUnit4 * mAmount4 + mUnit5 * mAmount5;            

            double multiplier = getMultiplier();
            double price = totalCalculatedPrice * multiplier;

            if (currencyType.selectedIndex == -1)
            {
                totalPriceLabel.Text = price + "  Taka";
            }
            else
            {
                totalPriceLabel.Text = price + "  " +currencyType.selectedValue;
            }

        }

        private double getMultiplier()
        {
            if (currencyType.selectedIndex==-1)
            {
                return 1;
            }
            string currency = currencyType.selectedValue;
            if (currency.Equals("Rupee"))
            {
                return 0.86;
            }else if (currency.Equals("US Dollar"))
            {
                return 0.012;
            }
            else if (currency.Equals("Canadian Dollar"))
            {
                return 0.015;
            }
            else if (currency.Equals("Japanese Yen"))
            {
                return 1.22;
            }
            return 1;
        }

        private bool checkUnit(int unit1, int unit2, int unit3, int unit4, int unit5)
        {
            if (unit1 > 100 || unit2 > 100 || unit3 > 100 || unit4 > 100 || unit5 > 100 )
            {
                Form3 form = new Form3("Unit Price cannot be greater than 100");
                form.ShowDialog();
                return false;
            }
            return true;
        }

        private bool checkAmount(int amount1, int amount2, int amount3, int amount4, int amount5)
        {
            if (amount1 > 10 || amount2 > 10 || amount3 > 10 || amount4 > 10 || amount5 > 10)
            {
                Form3 form = new Form3("Amount cannot be greater than 10");
                form.ShowDialog();
                return false;
            }
            return true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }


        private bool checkEmptyInputs()
        {
            if (product1Amount.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 1 Amount is Empty");
                form.ShowDialog();
                mAmount1 = 0;
                return false;
            }
            else
            {
                mAmount1 = Convert.ToInt32(product1Amount.Text.ToString());
            }
            if (product2Amount.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 2 Amount is Empty");
                form.ShowDialog();
                mAmount2 = 0;
                return false;
            }
            else
            {
                mAmount2 = Convert.ToInt32(product2Amount.Text.ToString());
            }
            if (product3Amount.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 3 Amount is Empty");
                form.ShowDialog();
                mAmount3 = 0;
                return false;
            }
            else
            {
                mAmount3 = Convert.ToInt32(product3Amount.Text.ToString());
            }

            if (product4Amount.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 4 Amount is Empty");
                form.ShowDialog();
                mAmount4 = 0;
                return false;
            }
            else
            {
                
                mAmount4 = Convert.ToInt32(product4Amount.Text.ToString());
            }

            if (product5Amount.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 5 Amount is Empty");
                form.ShowDialog();
                mAmount5 = 0;
                return false;
            }
            else
            {
                mAmount5 = Convert.ToInt32(product5Amount.Text.ToString());
            }


            if (product1UnitPrice.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 1 Unit is Empty");
                form.ShowDialog();
                mUnit1 = 0;
                return false;
            }
            else
            {
                mUnit1 = Convert.ToInt32(product1UnitPrice.Text.ToString());
            }

            if (product2UnitPrice.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 2 Unit is Empty");
                form.ShowDialog();
                mUnit2 = 0;
                return false;
            }
            else
            {
                mUnit2 = Convert.ToInt32(product2UnitPrice.Text.ToString());
            }

            if (product3UnitPrice.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 3 Unit is Empty");
                form.ShowDialog();
                mUnit3 = 0;
                return false;
            }
            else
            {
                mUnit3 = Convert.ToInt32(product3UnitPrice.Text.ToString());
            }


            if (product4UnitPrice.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 4 Unit is Empty");
                form.ShowDialog();
                mUnit4 = 0;
                return false;
            }
            else
            {
                mUnit4 = Convert.ToInt32(product4UnitPrice.Text.ToString());
            }


            if (product5UnitPrice.Text.ToString().Equals(""))
            {
                Form3 form = new Form3("Product 5 Unit is Empty");
                form.ShowDialog();
                mUnit5 = 0;
                return false;
            }
            else
            {
                mUnit5 = Convert.ToInt32(product5UnitPrice.Text.ToString());
            }
            return true;
        }
    }

}
