using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge___Epic_Spies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousAssignmentCalendar.SelectedDate = DateTime.Now.Date;
                startDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endDateCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
             
            }
        }

        protected void AssignSpybutton_Click(object sender, EventArgs e)
        {
            //spies cost $500 per day
            TimeSpan assignmentduration = endDateCalendar.SelectedDate.Subtract(startDateCalendar.SelectedDate);

            double totalCost = assignmentduration.TotalDays * 500.00;

            //if > 21 days then add $1000
            if (assignmentduration.TotalDays > 21)
            {
                totalCost = totalCost + 1000.00;
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", codeNameTextBox.Text, assignmentNameTextBox.Text, totalCost);

            TimeSpan timeBetweenAssignments = startDateCalendar.SelectedDate.Subtract(previousAssignmentCalendar.SelectedDate);
            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least 2 weeks in between the end date of the previous assignment and the start date of the new assignment.";
                DateTime earliestNewAssignmentDate = previousAssignmentCalendar.SelectedDate.AddDays(14);
                startDateCalendar.SelectedDate = earliestNewAssignmentDate;
                startDateCalendar.VisibleDate = earliestNewAssignmentDate;


            }
        }
    }
}