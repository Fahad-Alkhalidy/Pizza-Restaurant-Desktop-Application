using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class PizzaMenu : Form
    {
        private double size = 0;
        private double crust = 0;
        private int linesCounter = 0;


        public PizzaMenu()
        {
            InitializeComponent();
        }


        private void rbSmallPizza_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeSummary.Text = "Small";
            size = 5;
            lblSumSummary.Text = $"{Convert.ToString(crust+size)}";
        }

        private void rbMediumPizza_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeSummary.Text = "Medium";
            size = 10;
            lblSumSummary.Text = $"{Convert.ToString(crust + size)}";
        }

        private void rbLargePizza_CheckedChanged(object sender, EventArgs e)
        {
            lblSizeSummary.Text = "Large";
            size = 15;
            lblSumSummary.Text = $"{Convert.ToString(crust + size)}";
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeSummary.Text = "Thin";
            crust = 5;
            lblSumSummary.Text = $"{Convert.ToString(crust + size)}";
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            lblCrustTypeSummary.Text = "Thick";
            crust = 10;
            lblSumSummary.Text = $"{Convert.ToString(crust + size)}";
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtraCheese.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Extra Cheese, \n";
                } else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Extra Cheese, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('E');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index+14);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkHotDogs_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHotDogs.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Hot Dogs, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Hot Dogs, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('H');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 10);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChicken.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Chicken, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Chicken, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('C');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 9);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkLibnah_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLibnah.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Libnah, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Libnah, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('L');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 8);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkMeat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMeat.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Meat, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Meat, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('M');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 6);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBBQ.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "BBQ, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "BBQ, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('B');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 5);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkPapperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPapperoni.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Papperoni, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Papperoni, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('P');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 11);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                linesCounter++;
                if (linesCounter != 0 && linesCounter % 2 == 0)
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Olives, \n";
                }
                else
                {
                    lblToppingsSummary.Text = lblToppingsSummary.Text + "Olives, ";
                }
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation + 5)}";
            }
            else
            {
                linesCounter--;
                int index = lblToppingsSummary.Text.IndexOf('O');
                lblToppingsSummary.Text = lblToppingsSummary.Text.Substring(0, index) + lblToppingsSummary.Text.Substring(index + 8);
                double summation = Convert.ToDouble(lblSumSummary.Text);
                lblSumSummary.Text = $"{Convert.ToString(summation - 5)}";
            }
        }

        private void rbInside_CheckedChanged(object sender, EventArgs e)
        {
            lblPlaceSummary.Text = "Inside Restaurant";
        }

        private void rbOutSide_CheckedChanged(object sender, EventArgs e)
        {
            lblPlaceSummary.Text = "Outsize Restaurant";
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            { 
            gbSize.Enabled = false;
            gbCrustType.Enabled = false;
            gbToppings.Enabled = false;
            gbPlaceOfEating.Enabled = false;
             }
            
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbPlaceOfEating.Enabled = true;
            chkExtraCheese.Checked = false;
            chkBBQ.Checked = false;
            chkChicken.Checked = false;
            chkHotDogs.Checked = false;
            chkLibnah.Checked = false;
            chkMeat.Checked = false;
            chkPapperoni.Checked = false;
            chkOlives.Checked = false;
            rbSmallPizza.Checked = true;
            rbThin.Checked = false;
            rbThick.Checked = false;
            rbInside.Checked = false;
            rbOutSide.Checked = false;
            lblToppingsSummary.Text = "";
            lblCrustTypeSummary.Text = "";
            lblSizeSummary.Text = "";
            lblPlaceSummary.Text = "";
            lblCrustTypeSummary.Text = "";
            lblSumSummary.Text = "5";
          
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void gbCrustType_Enter(object sender, EventArgs e)
        {

        }

        private void gbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void gbPlaceOfEating_Enter(object sender, EventArgs e)
        {

        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void lblPizzaMenu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Interface();
            form.ShowDialog();
        }

        private void PizzaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
