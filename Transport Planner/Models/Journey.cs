using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Transport_Planner.Models
{
    public class Journey
    {
        public DateTime StartDateTime { get; set; }
        public int Duration { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public List<Leg> Legs { get; set; }
        public Fare Fare { get; set; }

    }

}
