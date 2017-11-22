using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles
            
            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Phoenix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };
            string result = "";


            int largest = 0;
            int smallest = 0;
            
            for (int i = 0; i < names.Length; i++)
            {
                //is this the largest count so far?
                if (numbers[i] > numbers[largest])
                {
                    largest = i;
                }

                //is this the smallest count so far?
                if (numbers[i] < numbers[smallest])
                {
                    smallest = i;
                }

            }

            result = string.Format("<br/>Most battles belong to: {0} (Value:  {1})<br/>" + "<br/>Least battles belong to: {2} (Value:  {3})<br/>", names[largest], numbers[largest], names[smallest], numbers[smallest]);

            resultLabel.Text = result;
        }
    }
}