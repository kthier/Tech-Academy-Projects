using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_5____Days_Between_Dates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            var firstDate = firstCalendar.SelectedDate;
            var secondDate = secondCalendar.SelectedDate;
            
            resultLabel.Text = "";

            if (firstDate < secondDate)
            {
                TimeSpan daysTimeSpan = (secondDate - firstDate);
                    resultLabel.Text = daysTimeSpan.TotalDays.ToString();
            }

            else if (firstDate > secondDate)
            {
                TimeSpan daysTimeSpan = (firstDate - secondDate);
                    resultLabel.Text = daysTimeSpan.TotalDays.ToString();
            }

            else

                resultLabel.Text = "Please select two different dates.";
        }
    }
}