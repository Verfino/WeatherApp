using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeatherApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetInterface("Wroclaw");
        }

        private Weather GetWeatherFromApi(string city)
        {
            var weather = new Weather();
            var client = new WebClient();
            string url = "https://query.yahooapis.com/v1/public/yql?q=select%20*%20from%20weather.forecast%20where%20woeid%20in%20(select%20woeid%20from%20geo.places(1)%20where%20text%3D%22" + city +"%22)%20and%20u%20=%20%27c%27%20&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys";
            var obj = JsonConvert.DeserializeObject<dynamic>(client.DownloadString(url));

            weather.City = obj.query.results.channel.location.city;
            weather.TemperatureDay = obj.query.results.channel.item.forecast[0].high;
            weather.TemperatureNight = obj.query.results.channel.item.forecast[0].low;
            weather.Code = obj.query.results.channel.item.forecast[0].code;

            foreach (var item in obj.query.results.channel.item.forecast)
            {
                var temp = new Forecast();
                temp.TemperatureDay = item.high;
                temp.TemperatureNight = item.low;
                temp.Code = item.code;
                weather.Forecast.Add(temp);
            }

            return weather;
        }

        private void SetInterface(string city)
        {
            var weather = GetWeatherFromApi(city);
            labelCity.Text = weather.City;
            labelTemperature.Text = weather.TemperatureDay.ToString() + "'C";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetInterface(textBox1.Text);
        }
    }
}
