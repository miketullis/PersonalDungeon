using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    // no inheritance can happen from player, sealed
    public sealed class Player : Character
    {
        //props
        public Rocker CharacterRocker { get; set; }
        public Instrument EquippedInstrument { get; set; }

        //FQ CTOR
        public Player(string name, int maxHealth, int health, int hitChance, int block, Rocker characterRocker, Instrument equippedInstrument)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = health;
            HitChance = hitChance;
            Block = block;
            CharacterRocker = characterRocker;
            EquippedInstrument = equippedInstrument;
        }//end FQ CTOR

        
        //methods
        public override string ToString()
        {
            return string.Format("-=-= ROCKER BIO =-=-\n" +
                "====================\n" +
                $"Name: {Name}\n" +
                $"Type: {CharacterRocker}\n" +
                "Health: " + Math.Round((Convert.ToDecimal(Health) / Convert.ToDecimal(MaxHealth)) * 100) + "%\n" +
                $"Instrument: {EquippedInstrument}\n" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"Blocking Ability: {Block}%");
        }// end ToString()

        //Method inherited from character class. Override done to create custom funtionality.
        public override int CalcDamage()
        {
            return new Random().Next(EquippedInstrument.MinDamage, EquippedInstrument.MaxDamage + 1);
        }// end calcDamage()

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedInstrument.BonusRockstarPower;
        }//end CalcHitChance
    }//end class
}//end namespace
