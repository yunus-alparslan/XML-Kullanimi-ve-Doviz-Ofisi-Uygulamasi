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
namespace XML_Kullanımı_ve_Döviz_Ofisi_Uygulamasıı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dolar = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldosyya = new XmlDocument();
            xmldosyya.Load(dolar);

            string dolaalıs = xmldosyya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            labeldolarlıs.Text = dolaalıs;

            string dolarsat = xmldosyya.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            labeldolarsatıs.Text = dolarsat;


            /// avro
            /// 
            string avroall = xmldosyya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            labelavroalıs.Text = avroall;

            string avrosat = xmldosyya.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            labelavrosatıs.Text = avrosat;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxkur.Text = labeldolarlıs.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxkur.Text = labeldolarsatıs.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxkur.Text = labelavroalıs.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxkur.Text = labelavrosatıs.Text;
        }

        double kur;
        int miktar,tutar;
        private void button6_Click(object sender, EventArgs e)
        {


            kur = Convert.ToDouble(textBoxkur.Text);
            miktar = Convert.ToInt32(textBoxmiktar.Text);

            tutar = Convert.ToInt32(kur / miktar);
            textBoxtutar.Text = tutar.ToString();
            double kalan;
            kalan = miktar % tutar;
            textBoxkalan.Text = kalan.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxkur.Text = textBoxkur.Text.Replace(".", ",");
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            kur = Convert.ToDouble(textBoxkur.Text);
            double miktar = Convert.ToDouble(textBoxmiktar.Text);

            double tutar = (kur * miktar);

            textBoxtutar.Text = tutar.ToString();

        //    label13.Text = kur.ToString();
        }
    }
}
