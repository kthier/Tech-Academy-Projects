using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_4___Papa_Bobs_Pizza
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            
            //pizza size===================================
            double total;

            if (babyRadioButton.Checked)
                total = 10.00;
            else if (mamaRadioButton.Checked)
                total = 13.00;
            else 
                total = 16.00;

            
            
            //crust======================================

            if (thinRadioButton.Checked)
                total = total + 00.00; 
            else 
                total = total + 02.00;

            //toppings======================================


            if (pepperoniCheckBox.Checked == true)
                total = total + 01.50;
            if (onionsCheckBox.Checked == true)
                total = total + 00.75;
            if (greenpeppersCheckBox.Checked == true)
                total = total + 00.50;
            if (redpeppersCheckBox.Checked == true)
                total = total + 00.75;
            if (anchoviesCheckBox.Checked == true)
                total = total + 02.00;
            if (pepperoniCheckBox.Checked && greenpeppersCheckBox.Checked && anchoviesCheckBox.Checked ||pepperoniCheckBox.Checked && onionsCheckBox.Checked && redpeppersCheckBox.Checked)
                total = total - 02.00;
            else
                total = total + 00.00;

            //total============================================

             totalLabel.Text = "$" + (total.ToString("0.00"));

        }
    }
}