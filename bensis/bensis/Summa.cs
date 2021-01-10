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
    public partial class Summa : Form
    {

        public static double hinta;
        public static double E98;
        public static double E95;
        public static double Diesel;
        public string hinta95 = "U:/KO/Tietojenkäsittely/8.45/bensis95.txt";
        public string hinta98 = "U:/KO/Tietojenkäsittely/8.45/bensis98.txt";
        public string hintadiesel = "U:/KO/Tietojenkäsittely/8.45/diesel.txt";

        public Summa()
        {
            
            InitializeComponent();
            Luehinta95();
            Luehinta98();
            Luehintadiesel();
            Tulostatiedostoon( DateTime.Now.ToString());

            TulostaKuitti(DateTime.Now.ToString());
            

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

         
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Kirjoita vain numeroita.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            hinta = Convert.ToDouble(textBox1.Text);
            Laatu alaformi = new Laatu();
            Tulostatiedostoon(textBox1.Text + "e");
            TulostaKuitti(textBox1.Text + "e");
            alaformi.Show();
            this.Hide();

           
           

        }

        private void Tulostatiedostoon(string x)
        {
            string Tulostatiedostoon = "U:/KO/Tietojenkäsittely/8.45/Ostokset.txt";
            TextWriter tw = new StreamWriter(Tulostatiedostoon, true);
            tw.WriteLine(x);
            tw.Close();
            this.Hide();

        }
        private void TulostaKuitti(string y)
        {
            string Tulostakuitti = "U:/KO/Tietojenkäsittely/8.45/kuitti.txt";
            TextWriter tw = new StreamWriter(Tulostakuitti, append: true);
            tw.WriteLine(y);
            tw.Close();
            this.Hide();
        }

        private void Summa_Load(object sender, EventArgs e)
        {

        }


        public void Luehinta95()
        {
            StreamReader sr = new StreamReader(hinta95);
            textBox3.Text = sr.ReadLine();
            E95 = Convert.ToDouble(textBox3.Text);
            
        }
        public void Luehinta98()
        {
            StreamReader sr = new StreamReader(hinta98);
            textBox4.Text = sr.ReadLine();
            E98 = Convert.ToDouble(textBox4.Text);
        }
        public void Luehintadiesel()
        {
            StreamReader sr = new StreamReader(hintadiesel);
            textBox5.Text = sr.ReadLine();
            Diesel = Convert.ToDouble(textBox5.Text);
        }
    }
}
