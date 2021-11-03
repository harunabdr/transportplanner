using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Planner.Models
{
    public class Fare
    {
        public int TotalCost { get; set; }
        public List<Fare> Fares { get; set; }
        //public List<Caveat> Caveats { get; set; }
    }
}
