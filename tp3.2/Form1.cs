using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp3._2.WCFMeteo;

using System.Net;
using System.IO;

namespace tp3._2
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WSMeteo.meteo3ilSoapClient service = new WSMeteo.meteo3ilSoapClient("meteo3ilSoap");
            string Date, Desc;
            service.Get_Value(1, out Date, out Desc);

            textBox1.Text =
                $"Date : {Date} \r\n" +
                $"temp : {Desc}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client sr = new Service1Client();

            MeteoData toto = sr.Get_MeteoData();
            
            textBox2.Text =
                $"Temp : {toto.d_Temp} \r\n" +
                $"Pres : {toto.d_Pres} \r\n" +
                $"preci : {toto.d_PrecJour} \r\n" +
                $"relevé a  : {toto.dt_Releve} \r\n" +
                $"Hum : {toto.i_Hum}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string url = "http://www.meteorestservice.lab3il.fr/ServiceRest.svc/meteo/1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = WebRequestMethods.Http.Get;
            WebResponse response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            string str = streamReader.ReadLine();

            str = str.Substring(str.IndexOf(">") + 1, str.Length - str.IndexOf(">") - 1);
            str = str.Substring(0, str.IndexOf("<"));

            textBox3.Text = $"Température : {str}°";
        }
    }
}
