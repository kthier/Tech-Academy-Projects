using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_7___Epic_Spies_Asset_Tracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Elections Rigged
                double[] electionsRigged = new double[0];
                ViewState.Add("Elections Rigged", electionsRigged);

                //Acts of Subterfuge
                double[] actsOfSubterfuge = new double[0];
                ViewState.Add("Acts of Subterfuge", actsOfSubterfuge);

                //Last Asset Name Added
                string[] lastAssetAdded = new string[0];
                ViewState.Add("Last Asset Added", lastAssetAdded);
            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            //Elections Rigged
            double[] electionsRigged = (double[])ViewState["Elections Rigged"];     
            Array.Resize(ref electionsRigged, electionsRigged.Length + 1);
            int newestRiggedElection = electionsRigged.GetUpperBound(0);
            electionsRigged[newestRiggedElection] = double.Parse(electionsRiggedTextBox.Text);
            ViewState["Elections Rigged"] = electionsRigged;

            //Acts of Subterfuge
            double[] actsOfSubterfuge = (double[])ViewState["Acts of Subterfuge"];
            Array.Resize(ref actsOfSubterfuge, actsOfSubterfuge.Length + 1);
            int newestSubterfuge = actsOfSubterfuge.GetUpperBound(0);
            actsOfSubterfuge[newestSubterfuge] = double.Parse(actsOfSubterfugeTextBox.Text);
            ViewState["Acts of Subterfuge"] = actsOfSubterfuge;

            //Last Asset Name Added
            string[] lastAssetAdded = (string[])ViewState["Last Asset Added"];
            Array.Resize(ref lastAssetAdded, lastAssetAdded.Length + 1);
            int newestLastAssetAdded = lastAssetAdded.GetUpperBound(0);
            lastAssetAdded[newestLastAssetAdded] = assetNameTextBox.Text;
            ViewState["Last Asset Added"] = lastAssetAdded;

            //Result Lable
            resultLabel.Text = String.Format("<br />Total Elections Rigged: {0}<br />Average Acts of Subterfuge per Asset: {1:N2} <br />(Last Asset you added: {2}<br />", electionsRigged.Sum(), actsOfSubterfuge.Average(), lastAssetAdded[newestLastAssetAdded]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            actsOfSubterfugeTextBox.Text = "";
        }

       //Total Ecections Rigged: 3
       //Average Acts of Subterfuge per Asset: 3.00
       //(Last Asset you added: random name) 
    }
}