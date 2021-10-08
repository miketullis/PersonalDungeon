using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public abstract class Character
    {
        //fields
        private int _Health;

        //props
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxHealth { get; set; }
        public int Health
        {
            get { return _Health; }
            set
            {
                //biz rule - Health not more than MaxHealth
                if (value <= MaxHealth)
                {
                      _Health = value;
                }//end if
                else
                {
                    _Health = MaxHealth;
                }//end else
            }//end set
        }//end int Health

        //ctors
        
        //methods
        
        //VIRTUAL keyword used to make methods below overrideable in child classes.
        public virtual int CalcBlock()
        {
            return Block;
        }//end CalcBlock()

        public virtual int CalcHitChance()
        {
            return HitChance;
        }//end CalcHitChance()

        public virtual int CalcDamage()
        {
            return 0;
        }//end CalcDamage()
    }//end class
}//end namespace
