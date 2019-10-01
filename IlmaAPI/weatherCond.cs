using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlmaAPI
{
    public class weatherCond
    {
        public city city { get; set; }
        public List<list> list { get; set; }

    }
    public class temp
    {
        public double day { get; set; }
    }
        public class weather
    {

        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }

    }
    public class city { 
        public string name { get; set; }
    }
    public class list
    {
        public double dt { get; set; }
        public double pressure {get; set;}
    public double humitity { get; set; }
        public double speed { get; set; }
        public temp temp { get; set; }

        public List<weather> weather { get; set; }
    }
}
