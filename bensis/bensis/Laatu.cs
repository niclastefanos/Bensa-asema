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
    public partial class Laatu : Form
    {
        
        
        public Laatu()
        {
            InitializeComponent();
            Maksu alaformi = new Maksu();
        }
        string tankki95 = "U:/KO/Tietojenkäsittely/8.45/tankki95.txt";
        string tankki98= "U:/KO/Tietojenkäsittely/8.45/tankki98.txt";
        string tankkidiesel = "U:/KO/Tietojenkäsittely/8.45/tankkidiesel.txt";
        public static string bensanlaatu;
        public static double laadunhinta;
        public static string Diesel;
        private void ysivitonen_Click(object sender, EventArgs e)
        {
           bensanlaatu = "95";
           laadunhinta = Summa.E95;
           Siirry alaformi = new Siirry();
           alaformi.Show();
           Tulostatiedostoon(bensanlaatu);
           Tulostakuittiin(bensanlaatu);
           

        }

        private void ysikasi_Click(object sender, EventArgs e)
        {
            
            bensanlaatu = "98";
            laadunhinta = Summa.E98;
            Siirry alaformi = new Siirry();
            alaformi.Show();
            Tulostatiedostoon(bensanlaatu);
            Tulostakuittiin(bensanlaatu);
           

        }

        private void diesel_Click(object sender, EventArgs e)
        {
            
            bensanlaatu = "diesel";
            laadunhinta = Summa.Diesel;
            Siirry alaformi = new Siirry();
            Tulostatiedostoon(bensanlaatu);
            Tulostakuittiin(bensanlaatu);
            alaformi.Show();
            this.Hide();

           

        }

        private void Tulostatiedostoon(string y)
        {
            string Tulostatiedostoon = "U:/KO/Tietojenkäsittely/8.45/Ostokset.txt";
            TextWriter tw = new StreamWriter(Tulostatiedostoon, true);
            tw.WriteLine();
            tw.Close();
            
        }
        private void Tulostakuittiin(string x)
        {
            string Tulostakuittiin = "U:/KO/Tietojenkäsittely/8.45/kuitti.txt";
            TextWriter tw = new StreamWriter(Tulostakuittiin,true);
            tw.WriteLine(x);
            tw.Close();
            
        }

        private void Laatu_Load(object sender, EventArgs e)
        {
            

        }
       
    }
}
