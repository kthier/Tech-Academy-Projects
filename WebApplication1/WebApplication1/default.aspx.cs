using HeroMonster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character();
            hero.Name = "Liam";
            hero.Health = 35;
            hero.AttackBonus = false;
            hero.DamageMaximum = 20;

            Character monster = new Character();
            monster.Name = "the Twins";
            monster.Health = 21;
            monster.AttackBonus = true;
            monster.DamageMaximum = 25;

            Dice dice = new Dice();

            // Bonus
            if (hero.AttackBonus == true)
            {
                monster.Defend(hero.Attack(dice));
            }

            int damage = hero.Attack(dice);
            monster.Defend(damage);

            damage = monster.Attack(dice);
            hero.Defend(damage);

            printStats(hero);
            printStats(monster);

            if (hero.Health > monster.Health)
                resultLabel.Text += String.Format("<br><br>{0} wins!", hero.Name);
            else
                resultLabel.Text += String.Format("<br><br>{0} wins!", monster.Name);
        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("<br><br><br>Name: {0} <br>Health: {1} <br>Damage Maximum: {2} <br>Attack Bonus: {3}", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }
    }
}