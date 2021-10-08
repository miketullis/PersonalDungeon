using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number from 1-70 as our dice roll
            Random rand = new Random();
            int diceRoll = rand.Next(1, 70);
            System.Threading.Thread.Sleep(200);

            //compare the dice roll against the Attacker's hitChance to defender's calcBlock(). 
            //If the dice roll is lower, the attacker hits for damage.
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calc the damage
                int damageDealt = attacker.CalcDamage();
                //assign the damage
                defender.Health -= damageDealt;

                //Display Calculation Result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hits {defender.Name}!\n");
                Console.ResetColor();
                System.Threading.Thread.Sleep(600);
            }//end if
            else
            {
                //Attacker Missed
                Console.WriteLine($"{attacker.Name} misses {defender.Name}!\n");
                System.Threading.Thread.Sleep(600);
            }//end else
        }//end DoAttack()

        public static void DoBattle(Player player, Monster monster)
        {
            //Player attacks first
            DoAttack(player, monster);

            //If monster is still alive, monster attacks player
            if (monster.Health > 0)
            {
                DoAttack(monster, player);
            }//end if
        }//end DoBattle()
    }//end class 
}//end namespace

