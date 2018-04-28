using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeroMonster;

namespace CS_ASP_041_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                resultLabel.Text += String.Format("\r\n\r\n{0} wins!", hero.Name);
            else
                resultLabel.Text += String.Format("\r\n\r\n{0} wins!", monster.Name);
        }

        private void printStats(Character character)
        {
            resultLabel.Text += String.Format("\r\n\r\n\r\nName: {0} \r\nHealth: {1} \r\nDamage Maximum: {2} \r\nAttack Bonus: {3}", character.Name, character.Health, character.DamageMaximum, character.AttackBonus);
        }
    }
}
