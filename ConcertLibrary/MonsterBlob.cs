using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class MonsterBlob : Monster
    {
        //fields

        //props
        public bool IsOozing { get; set; }
        
        //FQ CTOR
        public MonsterBlob (string name, int maxHealth, int Health, int maxDamage, int minDamage, int hitChance, int block, string description, bool isOozing) : base (name, maxHealth, Health, maxDamage, minDamage, hitChance, block, description)
        {
            IsOozing = isOozing;//unique assignment to blob monsters
        }//end FQCTOR


        //methods
        public override string ToString()
        {
            return base.ToString() + (IsOozing ? "Oozing Poisonous Slime" : " ");
        }//end ToString()

        //override: if MonsterBlob is oozing block is doubled
        public override int CalcBlock()
        {
            int calculatedBlock = MinDamage;

            if (IsOozing)
            {
                calculatedBlock += calculatedBlock;
            }//end if

            return calculatedBlock;
        }//end CalcDamage
    }//end class
}//end namespace
