using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        string apiKey = "bf893fad6de9582fcef2cc8c54f53154";
        

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void search_button_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {

            using (WebClient web = new WebClient()) {

                double kelvin = 273.15;
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", CityTextBox.Text, apiKey);
                var json = web.DownloadString(url);
                ModelWeather.root Info = JsonConvert.DeserializeObject<ModelWeather.root>(json);
                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon +".png";
                condition_label.Text = Info.weather[0].main;
                details_label.Text = "Description: " + Info.weather[0].description + Environment.NewLine +
                     "Temperature: " + Math.Round(Info.main.temp - kelvin).ToString()+ " C" + Environment.NewLine +
                     "Feels Like: " + Math.Round(Info.main.feels_like - kelvin).ToString()+ " C" + Environment.NewLine +
                     "Minimal Temperature: " + Math.Round(Info.main.temp_min - kelvin).ToString()+ " C" + Environment.NewLine +
                     "Maximal Temperature: " + Math.Round(Info.main.temp_max - kelvin).ToString()+ " C";
                sunset_label.Text = convertDateTime(Info.sys.sunset).ToString(); 
                sunrise_label.Text = convertDateTime(Info.sys.sunrise).ToString();
                wind_label.Text=Info.wind.speed.ToString()+ " m/s";
                pressure_label.Text=Info.main.pressure.ToString()+ " hPa";
            }
        }

        DateTime convertDateTime(long miliseconds)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();//Aflam data de la 0 in format utc
            day = day.AddMilliseconds(miliseconds).ToLocalTime(); //adaugam milisecundele primite de la api
            return day;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
