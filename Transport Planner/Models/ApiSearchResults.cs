using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Planner.Models
{
    public class ApiSearchResults
    {
        public List<Journey> Journeys { get; set; }
        public List<Line> Lines { get; set; }
        public List<object> StopMessages { get; set; }
        //public int RecommendedMaxAgeMinutes { get; set; }
        //public SearchCriteria SearchCriteria { get; set; }
        //public JourneyVector JourneyVector { get; set; }
    }
}
