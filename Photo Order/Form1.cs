using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Order
{
    // This program calculates the total price for photo print order
    // of different sizes
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding four different sizes to the ComboBox

            cbxSize.Items.Add("Small");
            cbxSize.Items.Add("Medium");
            cbxSize.Items.Add("Large");
            cbxSize.Items.Add("Extra Large");

            cbxSize.SelectedIndex = 0;  // Select the first size
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Writing the code for the Calculate button, which
            // uses the sizes from the ComboBox and the quantity from the NumericUpDown control
            
            decimal quantity;
            quantity = numQuantity.Value;
           
            
            string size = cbxSize.SelectedItem.ToString();

            decimal price;


            switch (size)
            {
                case "Small":
                    price = 0.20m;
                    break;
                case "Medium":
                    price = 0.30m;
                    break;
                case "Large":
                    price = 0.40m;
                    break;
                case "Extra Large":
                    price = 0.50m;
                    break;
                default:
                    MessageBox.Show("Unknown size");
                    return;        //Stop processing this event

            }
            decimal total = price * quantity;    // Calculate the total price
            txtPrice.Text = total.ToString("c");  //Format as currency and display the result
        }

        private void cbxSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
