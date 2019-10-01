using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlmaAPI
{
    class weatherInfo
    {

        public class main { 
        public double temp { get; set; }

        }

        public class sys { 
        public string country { get; set; }
        }

        public class root {
            public string name { get; set; }
            public sys sys { get; set; }
            public main main { get; set; }





        }
    }
}
