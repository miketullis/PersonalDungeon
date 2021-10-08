using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class Food
    {

        //fields

        //props
        public string Description { get; set; }
        public int HealthRepair { get; set; }

        //ctors
 
        public Food (string description, int healthRepair)
        {
            HealthRepair = healthRepair;
            Description = description;
        }//end FQ ctor

        //methods


    }//end class
}//end namespace