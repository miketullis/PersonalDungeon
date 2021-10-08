using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class Instrument
    {
            //fields
            private int _minDamage;

            //props
            public int MaxDamage { get; set; }
            public string Name { get; set; }
            public int BonusRockstarPower { get; set; }
            public bool BandRole { get; set; }
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
                    }//end else
                }//end set
            }//end minDamage

            //ctors
            public Instrument(string name, int minDamage, int maxDamage, int bonusRockstarPower, bool bandRole)
            {
                Name = name;
                MinDamage = minDamage;
                MaxDamage = maxDamage;
                BonusRockstarPower = bonusRockstarPower;
                BandRole = bandRole;
            }// end FQ CTOR

            //methods
            public override string ToString()
            {
                return string.Format(
                    $"{Name}\n" +
                    $"Damage: {MinDamage} to {MaxDamage} db\n" +
                    $"Rockstar Power Bonus: {BonusRockstarPower}%\n" +
                    $"Role: {(BandRole ? "Lead Player" : "Rhythm Section")}");
            }
        }//end class
    }//end namespace
