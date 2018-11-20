using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_MailOrder4
{
    public partial class Form1 : Form
    {

        private int quantity;
        private double price,
            weight,
            salesTax,
            totalCharge = 0,
            totalSales = 0,
            handling;
        private string p,
            w,
            q;
        
        public Form1()
        {
            InitializeComponent();
            updateSummary.Enabled = false;
            totalAmountOutput.ReadOnly = true;
            salesTaxOutput.ReadOnly = true;
            amountDueOutput.ReadOnly = true;
            handlingOutput.ReadOnly = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            totalAmountOutput.Clear();
            salesTaxOutput.Clear();
            amountDueOutput.Clear();
            handlingOutput.Clear();
            quantity = 0;
            weight = 0;
            price = 0;
            totalCharge = 0;
            totalSales = 0;
        }

        private void updateSummary_Click(object sender, EventArgs e)
        {
            totalAmountOutput.Text = totalCharge.ToString("C");
            salesTaxOutput.Text = salesTax.ToString("C");
            amountDueOutput.Text = totalSales.ToString("C");
            handlingOutput.Text = handling.ToString("C");
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            try
            {

                q = quantityInput.Text;
                bool quantityResult = int.TryParse(q, out quantity);
                if (quantityResult == true)
                {
                    w = weightInput.Text;
                    bool weightResult = double.TryParse(w, out weight);
                    if (weightResult == true)
                    {
                        p = priceInput.Text;
                        bool priceResult = double.TryParse(p, out price);
                        if (priceResult == true)
                        {
                            weight = quantity * int.Parse(weightInput.Text);
                            if (weight < 10)
                            {
                                handling = 1.00;
                            }
                            else if (weight > 10 || weight < 100)
                            {
                                handling = 3.00;
                            }
                            else if (weight > 100)
                            {
                                handling = 5.00;
                            }
                            if (stateInput.Text == "CA" || stateInput.Text == "ca")
                            {
                                salesTax = 0.08 * (price * quantity) ;
                            }
                            else
                            {
                            salesTax = 0;
                            }
                            totalSales += price * quantity;
                            totalCharge += (price * quantity) + handling + salesTax;
                            updateSummary.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid input", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid input", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid input", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
        }
        
    }
}
