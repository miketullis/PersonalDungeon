using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class Monster : Character
    {

        //fields
        private int _minDamage;

        //props
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }

            }
        }

        
        //ctors

        public Monster (string name, int maxHealth, int health, int maxDamage, int minDamage, int hitChance, int block, string description)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = health;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            HitChance = hitChance;
            Block = block;
            Description = description;
           }//end FQ ctor

        //methods
        public override string ToString()
        {
            return string.Format("**** MONSTER STATS ****\n=======================\n" +
                $"Name: {Name}\n" +
                "Health:" + Math.Round((Convert.ToDecimal(Health) / Convert.ToDecimal(MaxHealth)) * 100) + "%\n" +
                $"Damage Risk: {MinDamage} to {MaxDamage}\n" +
                $"Blocking Ability: {Block}%\n" +
                $"{Description}\n");
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage(); returns 0
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1); 
        }//end CalcDamage()

    }//end class
}//end namespace
