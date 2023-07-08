using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Kullanımı_ve_Döviz_Ofisi_Uygulamasıı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int key;
            Random tes = new Random();

            key = tes.Next(500, 900);
            label1.Text = "A" + key.ToString();


            textBoxkullanıcıadı.Text = "Kullanıcı Adı";
            textBoxkullanıcıadı.ForeColor = Color.Gray;

            textBoxsifre.Text = "Sifre";
            textBoxsifre.ForeColor = Color.Gray;

            textBoxkeycode.Text = "Key Code";
            textBoxkeycode.ForeColor = Color.Gray;
        }

        private void textBoxkullanıcıadı_Click(object sender, EventArgs e)
        {
            if (textBoxkullanıcıadı.Text == "Kullanıcı Adı")
            {
                textBoxkullanıcıadı.Clear();

                textBoxkullanıcıadı.ForeColor = Color.Black;
            }
        }

        private void textBoxsifre_Click(object sender, EventArgs e)
        {
            if (textBoxsifre.Text == "Sifre")
            {
                textBoxsifre.Clear();

                textBoxsifre.ForeColor = Color.Black;
                textBoxsifre.UseSystemPasswordChar = true;
            }
        }

        private void textBoxkeycode_Click(object sender, EventArgs e)
        {
            if (textBoxkeycode.Text == "Key Code")
            {
                textBoxkeycode.Clear();

                textBoxkeycode.ForeColor = Color.Black;
            }
        }
    }
}
