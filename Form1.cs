using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WeatherProQQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            getXMLdata();
            pb_icon.SizeMode = PictureBoxSizeMode.Zoom;
            pb_tempStats.SizeMode = PictureBoxSizeMode.Zoom;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getXMLdata();
        }
        public void getXMLdata()
        {
            //can be adjusted with additional string variables...
            XDocument xDoc = XDocument.Load("https://api.openweathermap.org/data/2.5/weather?q=eskisehir&appid=3f200d39694920c99e1530f410fa1564&mode=xml&units=metric");
            XElement rootElement = xDoc.Root;

            double temp = Convert.ToDouble(rootElement.Descendants("temperature").ElementAt(0).Attribute("value").Value.Replace('.', ','));
            lbl_temp.Text = Convert.ToInt32(temp).ToString()+ "°C ";
            if (temp>20)
            {
                pb_tempStats.ImageLocation = "../../icons/gonnabehot.png";

                lbl_advice.Text = "The weather will be a little hot today,\nWe wouldn't recommend you to dress\n               too warmly at noon. ";
            }
            else
            {
                pb_tempStats.ImageLocation = "../../icons/gonnabecold.png";

                lbl_advice.Text = "The weather will be a little cold today,\nWe wouldn't recommend you to dress\n                       too thinly. ";
            } 

            string windSpeed = rootElement.Descendants("speed").ElementAt(0).Attribute("value").Value+" m/s";
            lbl_windSpeed.Text = windSpeed;

            string location = rootElement.Descendants("city").ElementAt(0).Attribute("name").Value;

            string country = rootElement.Descendants("country").ElementAt(0).Value;
            lbl_location.Text = location+", "+country;

            DateTime date = DateTime.Now;
            string time = date.ToShortTimeString();
            lbl_time.Text = time;

            double feelslike = Convert.ToDouble(rootElement.Descendants("feels_like").ElementAt(0).Attribute("value").Value.Replace('.',','));
            lbl_feelsLike.Text = "Feels like " + Convert.ToInt32(feelslike).ToString()+ "°C ";

           
            string icon = rootElement.Descendants("weather").ElementAt(0).Attribute("icon").Value;
            pb_icon.ImageLocation = $"../../icons/{icon}@2x.png";

            string weather = rootElement.Descendants("weather").ElementAt(0).Attribute("value").Value;
            lbl_status.Text = weather;

            string humidity = rootElement.Descendants("humidity").ElementAt(0).Attribute("value").Value + "%";
            lbl_humidity.Text = humidity;

            string pressue = rootElement.Descendants("pressure").ElementAt(0).Attribute("value").Value + " hPa";
            lbl_pressure.Text = pressue;

            string visibility = (Convert.ToInt32(rootElement.Descendants("visibility").ElementAt(0).Attribute("value").Value)/1000).ToString() + " km";
            lbl_visibility.Text = visibility;

            string sunset = XmlConvert.ToDateTime(rootElement.Descendants("sun").ElementAt(0).Attribute("set").Value,XmlDateTimeSerializationMode.Local).ToShortTimeString();
            lbl_sunset.Text = sunset;
            pb_sunrise.ImageLocation = "../../icons/sunrise.png";
            pb_sunrise.SizeMode = PictureBoxSizeMode.Zoom;

            string sunrise = XmlConvert.ToDateTime(rootElement.Descendants("sun").ElementAt(0).Attribute("rise").Value, XmlDateTimeSerializationMode.Local).ToShortTimeString();
            lbl_sunrise.Text = sunrise;
            pb_sunset.ImageLocation = "../../icons/sundown.png";
            pb_sunset.SizeMode = PictureBoxSizeMode.Zoom;

            string sunsetorn = XmlConvert.ToDateTime(rootElement.Descendants("sun").ElementAt(0).Attribute("set").Value, XmlDateTimeSerializationMode.Local).ToShortTimeString();
            

            XDocument xmlDocDaily = XDocument.Load("https://api.openweathermap.org/data/2.5/forecast?q=eskisehir&appid=3f200d39694920c99e1530f410fa1564&mode=xml&units=metric");
            XElement rootElementD = xmlDocDaily.Root;
            TimeSpan day1ts = TimeSpan.FromDays(1);
            string day1 = XmlConvert.ToDateTime(rootElementD.Descendants("time").ElementAt(6).Attribute("from").Value, XmlDateTimeSerializationMode.Local).DayOfWeek.ToString();
            lbl_day1.Text = day1;
            string day2 = XmlConvert.ToDateTime(rootElementD.Descendants("time").ElementAt(12).Attribute("from").Value, XmlDateTimeSerializationMode.Local).DayOfWeek.ToString();
            lbl_day2.Text = day2;
            string day3 = XmlConvert.ToDateTime(rootElementD.Descendants("time").ElementAt(20).Attribute("from").Value, XmlDateTimeSerializationMode.Local).DayOfWeek.ToString();
            lbl_day3.Text = day3;
            string day4 = XmlConvert.ToDateTime(rootElementD.Descendants("time").ElementAt(28).Attribute("from").Value, XmlDateTimeSerializationMode.Local).DayOfWeek.ToString();
            lbl_day4.Text = day4;

            string todayIcon = rootElementD.Descendants("symbol").ElementAt(22).Attribute("var").Value;
            pb_today.ImageLocation = $"../../icons/{todayIcon}@2x.png";
            pb_today.SizeMode = PictureBoxSizeMode.Zoom;
            string todaymax = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(0).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_todaymax.Text = todaymax;
            string todaymin = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(4).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_todaymin.Text = todaymin;

            string icon1 = rootElementD.Descendants("symbol").ElementAt(7).Attribute("var").Value;
            pb_day1.ImageLocation=$"../../icons/{icon1}@2x.png";
            pb_day1.SizeMode = PictureBoxSizeMode.Zoom;
            string max1 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(7).Attribute("max").Value.Replace('.',','))).ToString() + " °C ";
            lbl_max1.Text = max1;
            string min1 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(6).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_min1.Text = min1;

            string icon2 = rootElementD.Descendants("symbol").ElementAt(16).Attribute("var").Value;
            pb_day2.ImageLocation = $"../../icons/{icon2}@2x.png";
            pb_day2.SizeMode = PictureBoxSizeMode.Zoom;
            string max2 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(14).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_max2.Text = max2;
            string min2 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(16).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_min2.Text = min2;

            string icon3 = rootElementD.Descendants("symbol").ElementAt(22).Attribute("var").Value;
            pb_day3.ImageLocation = $"../../icons/{icon3}@2x.png";
            pb_day3.SizeMode = PictureBoxSizeMode.Zoom;
            string max3 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(23).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_max3.Text = max3;
            string min3 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(22).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_min3.Text = min3;

            string icon4 = rootElementD.Descendants("symbol").ElementAt(29).Attribute("var").Value;
            pb_day4.ImageLocation = $"../../icons/{icon4}@2x.png";
            pb_day4.SizeMode = PictureBoxSizeMode.Zoom;
            string max4 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(29).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_max4.Text = max4;
            string min4 = Convert.ToInt32(Convert.ToDouble(rootElementD.Descendants("temperature").ElementAt(28).Attribute("max").Value.Replace('.', ','))).ToString() + " °C ";
            lbl_min4.Text = min4;

        }












    }
}
