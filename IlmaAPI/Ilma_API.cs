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

namespace IlmaAPI
{
    public partial class Ilma_API : Form
    {
        const string APPID = "cc34b74e92ab9aed1fb3daaa9ae68977";
        string linnaNimi = "Tallinn";

        public Ilma_API()
        {
            InitializeComponent();
            getWeather();
        }

        void getWeather()

        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Tallinn&appid=cc34b74e92ab9aed1fb3daaa9ae68977&units=metric&cnt=6");

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<weatherInfo.root>(json);

                weatherInfo.root outPut = result;

                peaLinn.Text = string.Format("{0}", outPut.name);
                riik.Text = string.Format("{0}", outPut.sys.country);
                temper.Text = string.Format("{0} \u00B0 C", outPut.main.temp);
            }
           

          
            }
        void getCondition() 
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=Tallinn&appid=cc34b74e92ab9aed1fb3daaa9ae68977&units=metric&cnt=6");
            using (WebClient web = new WebClient()) {

                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<weatherCond>(json);

                weatherCond cond = Object;

                kirj.Text = string.Format("{0}", cond.list[1].weather[0].main);
                tps.Text = string.Format("{0}", cond.list[1].weather[0].description);

                int ikoon = cond.list[0].weather[0].id;

                   if (ikoon >= 200 && ikoon <= 299)  
               {
                   pilt.Image = Properties.Resources._200;

                    }
               if (ikoon >= 300 && ikoon <= 499)
               {
                   pilt.Image = Properties.Resources._300;

               }
               if (ikoon >= 500 && ikoon <= 599)
               {
                   pilt.Image = Properties.Resources._500;

               }
               if (ikoon >= 600 && ikoon <= 699)
               {
                   pilt.Image = Properties.Resources._600;

               }
               if (ikoon >= 700 && ikoon <= 799)
               {
                   pilt.Image = Properties.Resources._700;

               }
               if (ikoon == 800)
               {
                   pilt.Image = Properties.Resources._800;

               }
               if (ikoon >= 801 && ikoon <= 804)
               {
                   pilt.Image = Properties.Resources._801;

               }
               else {
                   pilt.Image = Properties.Resources._800;
               }
            }
        }




        }
    }


