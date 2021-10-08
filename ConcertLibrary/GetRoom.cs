using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertLibrary
{
    public class GetRoom
    {
        //fields

        //props
        public string Description { get; set; }
        public string Description2 { get; set; }

        //ctors
        public GetRoom(string description, string description2)
        {
            Description = description;
            Description2 = description2;
        }//end FQ ctor

        //methods

    }
}
