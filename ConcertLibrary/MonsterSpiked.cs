using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class MonsterSpiked : Monster
    {
        //fields

        //props
        public bool IsPoisonous { get; set; }
        
        //FQ CTOR
        public MonsterSpiked (string name, int maxHealth, int Health, int maxDamage, int minDamage, int hitChance, int block, string description, bool isPoisonous) : base (name, maxHealth, Health, maxDamage, minDamage, hitChance, block, description)
        {
            IsPoisonous = isPoisonous;//unique assignment to spiked monsters
        }//end FQCTOR


        //methods
        public override string ToString()
        {
            return base.ToString() + (IsPoisonous ? "Extremely Poisonous!!!" : "Not Poisonous");
        }//end ToString()

        //override: if MonsterSpiked is Poisonous damage is doubled
        public override int CalcDamage()
        {
            int calculatedDamage = MinDamage;

            if (IsPoisonous)
            {
                calculatedDamage += calculatedDamage;
            }//end if

            return calculatedDamage;
        }//end CalcDamage
    }//end class
}//end namespace
