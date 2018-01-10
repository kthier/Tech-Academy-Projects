using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_10___Casino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Display the reel values
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                displayImages(reels);
                ViewState.Add("PlayersMoney", 1000);
                displayPlayersMoney();
            }
        }

        protected void pullButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet)) return;
            int winnings = pullLever(bet);
            displayResult(bet, winnings);
            adjustPlayersMoney(bet, winnings);
            displayPlayersMoney();
        }

        private void adjustPlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }

        private int pullLever(int bet)
        {
            string [] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);

            int multiplier = evaluateSpin(reels);
            return bet * multiplier;
        }

        private int evaluateSpin(string[] reels)
        {
            //if there's even one bar, then return 0.
            if (isBar(reels)) return 0;

            //if there's three 7's, then return 100.
            if (isJackpot(reels)) return 100;
            
            //if there's  one or more cherries, return 2, 3, or 4.
            int multiplier = 0;
            if (isWinner(reels, out multiplier)) return multiplier;

            return 0;
        }

        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;
        }

        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }

        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
            if (multiplier > 0) return true;
            return false;
        }

        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }


        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return cherryCount;
        }

        private string spinReel()
        {
            //string[] images = new string[] { "Bar.png", "Bell.png", "Cherry.png", "Clover.png", "Diamond.png", "HorseShoe.png", "Lemon.png", "Orange.png", "Plum.png", "Seven.png", "Strawberry.png", "Watermelon.png" };
            //return images[random.Next(12)];

              string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermelon" };
           return images[random.Next(12)];
        }

        private void displayImages(string[] reels)
        {
            //reel1Image.ImageUrl = "/Images/" + spinReel();
            //reel2Image.ImageUrl = "/Images/" + spinReel();
            //reel3Image.ImageUrl = "/Images/" + spinReel();

            reel1Image.ImageUrl = "/Images/" + reels[0] + ".png";
            reel2Image.ImageUrl = "/Images/" + reels[1] + ".png";
            reel3Image.ImageUrl = "/Images/" + reels[2] + ".png";
        }

        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!  ", bet, winnings);
            else
                resultLabel.Text = String.Format ("Sorry, you lost {0:C}. Better luck next time.", bet);
        }

        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]);
        }
    }
}

//at pageload, you have a certain amount of money.

//when push the button the pictures need to appear randomly. get one picture working randonly, then all three.

//then assign monetary values to certain pictures.

//then add the values and subtract or add from the money you started out with.

//persist it to viewstate

//reel1Image.ImageUrl = spinReel();
//reel2Image.ImageUrl = spinReel();
//reel3Image.ImageUrl = spinReel();