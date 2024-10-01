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
using tp3._2.moi;

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

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceClient sr;
            sr = new ServiceClient();

            textBox4.Text = sr.Meteo_GetTemperature();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            ServiceClient sr;
            sr = new ServiceClient();

            DataSet ds = sr.Meteo_GetTemperatureDay(dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            
            chart1.DataSource = ds.Tables[0];
            #region température
            chart1.Series.Add("Temp");
            chart1.Series["Temp"].XValueMember = "DateReleveVC";
            chart1.Series["Temp"].YValueMembers = "Temp";

            chart1.Series["Temp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series["Temp"].LegendText = "Température";
            #endregion

            #region température ressentie
            chart1.Series.Add("TempR");
            chart1.Series["TempR"].XValueMember = "DateReleveVC";
            chart1.Series["TempR"].YValueMembers = "TempR";

            chart1.Series["TempR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["TempR"].LegendText = "Température ressentie";
            #endregion

            #region température du point rosé
            chart1.Series.Add("TempPR");
            chart1.Series["TempPR"].XValueMember = "DateReleveVC";
            chart1.Series["TempPR"].YValueMembers = "TempPR";

            chart1.Series["TempPR"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series["TempPR"].LegendText = "Température du point de la rosée";
            #endregion

            chart1.DataBind();
            chart1.Visible = true;
        }
    }
}
