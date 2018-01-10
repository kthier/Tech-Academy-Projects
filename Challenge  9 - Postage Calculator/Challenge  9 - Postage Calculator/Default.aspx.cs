using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge__9___Postage_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void handleChange(object sender, EventArgs e)
        {
            calculateShipping(1, 1);
        }

        private void calculateShipping(double width, double height, double length = 1)
        {
            if (widthTextBox.Text.Trim().Length == 0)
                return;
            if (heightTextBox.Text.Trim().Length == 0)
                return;

            width = 0;
            if (!Double.TryParse(widthTextBox.Text, out width))
            {
                resultLabel.Text = "Re-enter the width.";
                return;
            }

            height = 0;
            if (!Double.TryParse(heightTextBox.Text, out height))
            {
                resultLabel.Text = "Re-enter the height.";
                return;
            }
                

            length = 0; //my optional parameter
            if (!Double.TryParse(lengthTextBox.Text, out length))
            { length = 1; }

            double shipping = 0.00;
            double whl = width * height * length;

            if (groundRadioButton.Checked) shipping = whl * .15;
            if (airRadioButton.Checked) shipping = whl * .25;
            if (nextDayRadioButton.Checked) shipping = whl * .45;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", shipping);
        }
    }
}