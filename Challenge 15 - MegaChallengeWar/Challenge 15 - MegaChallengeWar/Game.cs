using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Challenge_15___MegaChallengeWar
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        public Game(string player1Name, string player2Name)
        {
           _player1 = new Player() { Name = player1Name };
           _player2 = new Player() { Name = player2Name };          
        }

        public string Play()
        {
            Deck deck = new Deck();
            string result = "<h1>Dealing Cards...</h1>";
            result += deck.Deal(_player1, _player2);

            result += "<h2>Begin Battle...</h2>";

            int round = 0;
            while (_player1.Cards.Count !=0 && _player2.Cards.Count !=0)
            {
                Battle battle = new Battle();
                result += battle.PerformBattle(_player1, _player2);

                round++;
                if (round > 20)
                break;
            }
            result += determineWinner();
            return result;
        }
        
        private string determineWinner()
        {
            string result = "";
            if (_player1.Cards.Count > _player2.Cards.Count)
                result+= "<br><br><span>Player One Wins! </span>";
            else result+= "<br><br><span>Player Two Wins! </span>";

            result += "<br><br>Player One scored " + _player1.Cards.Count + " and Player Two scored " + _player2.Cards.Count + "!";
            return result;
        }
        
    }
}