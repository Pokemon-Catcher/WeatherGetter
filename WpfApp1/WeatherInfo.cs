using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class WeatherInfo
    {
        public string source;
        public string name;
        public string kind;
        public string country;
        public string district;


        public WeatherInfo(string source)
        {
            this.source = source;
        }
    }
}
