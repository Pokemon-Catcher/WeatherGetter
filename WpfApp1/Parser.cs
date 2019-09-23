using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace WpfApp1
{
    class Parser
    {
        static Parser instance;
        Parser()
        {
            instance = this;
        }
        public static Parser getInstance()
        {
            if(instance is null)
            {
                instance = new Parser();
            }
            return instance;
        }
        public WeatherInfo ParseGismetio()
        {
            WeatherInfo weather=new WeatherInfo("Gismetio");
            return weather;
        }
    }
}
