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
            weather.TemperatureCurrent = obj.query.results.channel.item.condition.temp;
            weather.Code = obj.query.results.channel.item.forecast[0].code;
            weather.Date = DateTime.Parse(obj.query.created.ToString("dd-MM-yyyy  HH:mm:ss"));

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
            labelTemperature.Text = weather.TemperatureCurrent.ToString() + "'C";
            labelTodayTempDay.Text = weather.Forecast[0].TemperatureDay.ToString() + "'C";
            labelTodayTempNight.Text = weather.Forecast[0].TemperatureNight.ToString() + "'C";
            labelTomorrowTempDay.Text = weather.Forecast[1].TemperatureDay.ToString() + "'C";
            labelTomorrowTempNight.Text = weather.Forecast[1].TemperatureNight.ToString() + "'C";
            label2DaysTempDay.Text = weather.Forecast[2].TemperatureDay.ToString() + "'C";
            label2DaysTempNight.Text = weather.Forecast[2].TemperatureNight.ToString() + "'C";
            label3DaysTempDay.Text = weather.Forecast[3].TemperatureDay.ToString() + "'C";
            label3DaysTempNight.Text = weather.Forecast[3].TemperatureNight.ToString() + "'C";
            labelDate.Text = "Last Update: " + weather.Date.ToString();
        }

        private void SetWeatherIcon(PictureBox pictureBox, int code)
        {
            int[] sun = {31,32,32,33,34,36 };
            int[] snow = {7,8,10,13,14,15,16,25,41,43,46 };
            int[] rain = {0,1,2,5,6,9,11,12,17,18,19,20,21,22,23,24,35,40,42 };
            int[] flash = {3,4,37,38,39,45,47 };
            int[] cloud = {26,27,28,29,30,44 };
            List<int[]> list = new List<int[]>() { sun, snow, rain, flash, cloud };

            foreach (var type in list)
            {
                foreach (var item in type)
                {
                    if (item == code)
                    {
                        //pictureBox.Image = Properties.Resources.ResourceManager.GetString(nameof(type));
                    }
                }
            }
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            SetInterface(textBox1.Text);
        }
    }
}
