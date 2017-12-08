using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_11___Phun_with_Strings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            // In my case, the result would be:
            // robaT boB

            string result = "";
            string name = "kaori thier";
            char[] nameReversed = name.ToCharArray();
            Array.Reverse(nameReversed);
            for (int i = 0; i < nameReversed.Length; i++)
            {
                result += nameReversed[i];
            }
            resultLabel.Text += "<br>My name reversed:  " + result + "<br>";


            // 2.  Reverse this sequence: "Luke,Leia,Han,Chewbacca";
            //When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string result2 = "";
            string names = "Luke,Leia,Han,Chewbacca";
            string[] values = names.Split(',');
            Array.Reverse(values);
            for (int i = 0; i < values.Length; i++)
            {
                result2 += values[i] + ", ";
            }
            resultLabel.Text += "<br>Reverse the sequence: Luke,Leia,Han,Chewbacca:  " + result2.Replace("Luke,", "Luke") + "<br>";


            // 3. Use the sequence to create ascii art: total size 14 characters
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            string result3 = "";
            string names2 = "Luke,Leia,Han,Chewbacca";
            string[] value = names2.Split(',');
            for (int i = 0; i < value.Length; i++)
            {
                int padding = (14 - value[i].Length) / 2;
                string leftpadding = value[i].PadLeft(value[i].Length + padding, '*');
                result3 += "<br/>" + leftpadding.PadRight(14, '*');
            }
            resultLabel.Text += "<br>ASCII Art:" + result3 + "<br>";


            // 4. Solve this puzzle:  string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            string result4 = "";
            string puzzle = "\"NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.\"";
            puzzle = puzzle.Replace("remove-me", "");
            puzzle = puzzle.Replace("Z", "T");
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace("now", "Now");
            result4 += puzzle;
            resultLabel.Text += "<br>Solve this puzzle:<br><br>\"NOW IS ZHEremove - me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.\"<br>" + result4 + "<br>";

        }
    }
}