using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Planner.Models
{
    public class Line
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ModeName { get; set; }
        public List<object> Disruptions { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        //public List<LineStatus> LineStatuses { get; set; }
        public List<object> RouteSections { get; set; }
        //public List<ServiceType> ServiceTypes { get; set; }
        //public Crowding Crowding { get; set; }
    }
}
