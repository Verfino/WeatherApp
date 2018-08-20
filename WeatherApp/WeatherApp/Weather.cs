using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Weather
    {
        public string City { get; set; }

        public int TemperatureCurrent { get; set; }

        public int Code { get; set; }

        public DateTime Date { get; set; }

        public List<Forecast> Forecast;

        public Weather()
        {
            Forecast = new List<Forecast>();
        }
    }
}
