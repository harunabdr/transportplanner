using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Transport_Planner.Models
{
    public class ApiResponse
    {
        public string Query { get; set; }
        public int Total { get; set; }

        public List<Geolocation> Matches { get; set; }
    }
}
