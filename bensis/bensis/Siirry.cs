using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bensis
{
    public partial class Siirry : Form
    {
        string tankki95 = "U:/KO/Tietojenkäsittely/8.45/tankki95.txt";
        string tankki98 = "U:/KO/Tietojenkäsittely/8.45/tankki98.txt";
        string tankkidiesel = "U:/KO/Tietojenkäsittely/8.45/tankkidiesel.txt";
        public static string E95;
        public static string E98;
        public static string Diesel;
        public int litrat95;
        public int litrat98;
        public int litratdiesel;
        
        public Siirry()
        {
            InitializeComponent();
        }

        private void Siirry_Load(object sender, EventArgs e)
        {
          
            if(Laatu.bensanlaatu == "95")
            {
                Luetankista95();
                kirjoitatankkiin95();
            }
            if (Laatu.bensanlaatu == "98")
            {
                Luetankista98();
                kirjoitatankkiin98();
               
            }
            if   (Laatu.bensanlaatu== "diesel")
            {
                Luetankistadiesel();
                kirjoitatankkiindiesel();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maksu alaformi = new Maksu();
            alaformi.Show();
            this.Hide();
        }

        public void Luetankista95()
        {
            double litrat = (Summa.hinta / Laatu.laadunhinta);
            StreamReader sr = new StreamReader(tankki95);
            double litrat95t = double.Parse(sr.ReadLine());
            litrat95 = Convert.ToInt32(litrat95t - litrat);
            sr.Close();
        }
        public void Luetankista98()
        {
            double litrat = (Summa.hinta / Laatu.laadunhinta);
            StreamReader sr = new StreamReader(tankki98);
            double litrat98t = double.Parse(sr.ReadLine());
            litrat98 = Convert.ToInt32(litrat98t - litrat);
            sr.Close();
        }
        public void Luetankistadiesel()
        {
            double litrat = (Summa.hinta / Laatu.laadunhinta);
            StreamReader sr = new StreamReader(tankkidiesel);
            double litratdieselt = double.Parse(sr.ReadLine());
            litratdiesel = Convert.ToInt32(litratdieselt - litrat);
            sr.Close();
        }
        public void kirjoitatankkiin95()
        {
            StreamWriter sw = new StreamWriter(tankki95);
            sw.WriteLine(litrat95);
            sw.Close();
        }
        public void kirjoitatankkiin98()
        {
            StreamWriter sw = new StreamWriter(tankki98);
            sw.WriteLine(litrat98);
            sw.Close();
        }
        public void kirjoitatankkiindiesel()
        {
            StreamWriter sw = new StreamWriter(tankkidiesel);
            sw.WriteLine(litratdiesel);
            sw.Close();
        }
    }
}
