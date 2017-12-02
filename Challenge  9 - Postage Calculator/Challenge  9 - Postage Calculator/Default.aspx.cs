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

        protected void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping(1, 1);
        }

        protected void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping(1, 1);
        }

        protected void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            calculateShipping(1, 1);
        }

        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateShipping(1,1);
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            calculateShipping(1, 1);
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
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
                return;

            height = 0;
            if (!Double.TryParse(heightTextBox.Text, out height))
                return;

            length = 0; //my optional
            if (!Double.TryParse(lengthTextBox.Text, out length))
            { length = 1; }

            double shipping = 0.00;

            if (groundRadioButton.Checked) shipping = width * height * length * .15;
            if (airRadioButton.Checked) shipping = width * height * length * .25;
            if (nextDayRadioButton.Checked) shipping = width * height * length * .45;

            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship.", shipping);
        }
    }
}