using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_2___Simple_Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void additionButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstvalueTextBox.Text);
            double second = double.Parse(secondvalueTextBox.Text);
            double result = first + second;
            resultLabel.Text = result.ToString();  
        }

        protected void subtractionButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstvalueTextBox.Text);
            double second = double.Parse(secondvalueTextBox.Text);
            double result = first - second;
            resultLabel.Text = result.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstvalueTextBox.Text);
            double second = double.Parse(secondvalueTextBox.Text);
            double result = first * second;
            resultLabel.Text = result.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(firstvalueTextBox.Text);
            double second = double.Parse(secondvalueTextBox.Text);
            double result = first / second;
            resultLabel.Text = result.ToString();
        }

        protected void calculateButton_Click(object sender, EventArgs e)
        {
            double bill = double.Parse(billTextBox.Text);
            double differentpercentage = double.Parse(differentpercentageTextBox.Text);
            double multiply = 0.01;
            double calculate = bill * differentpercentage * multiply;
            calculateLabel.Text = calculate.ToString();
        }

        protected void totalButton_Click(object sender, EventArgs e)
        {
            double bill = double.Parse(billTextBox.Text);
            double calculate = double.Parse(calculateLabel.Text);
                
            double total = bill + calculate;
            totalLabel.Text = total.ToString();
        }
    }
}


