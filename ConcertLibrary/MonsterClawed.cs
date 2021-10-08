using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class MonsterClawed : Monster
    {
        //fields

        //props
        public bool IsAggressive { get; set; }
        
        //FQ CTOR
        public MonsterClawed (string name, int maxHealth, int Health, int maxDamage, int minDamage, int hitChance, int block, string description, bool isAggressive) : base (name, maxHealth, Health, maxDamage, minDamage, hitChance, block, description)
        {
            IsAggressive = isAggressive;//unique assignment to clawed monsters
        }//end FQCTOR


        //methods
        public override string ToString()
        {
            return base.ToString() + (IsAggressive ? "Extremely Aggressive!!!" : "Mildly Agressive");
        }//end ToString()

        //override: if Monsterclawedd is aggressive, hit chance increases by 50%
        public override int CalcHitChance()
        {
            int calculatedHitChance = HitChance;

            if (IsAggressive)
            {
                calculatedHitChance += calculatedHitChance / 2;
            }//end if

            return calculatedHitChance;
        }//end CalcDamage
    }//end class
}//end namespace
