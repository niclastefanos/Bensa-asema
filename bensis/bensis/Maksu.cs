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
    public partial class Maksu : Form
    {
        public static string bensanlaaatu;
        public static string hinta;
        public static string litrat;
        public static double tankki95;
        public static double tankki98;
        public static double tankkidiesel;
        public static string vahennys;
        

        public Maksu()
        {
            InitializeComponent();
            pinkoodi.PasswordChar = '*';
            pinkoodi.MaxLength = 4;
            
        }

        string[] pinit = { "1234", "3421", "2341", "3142" };
        
        

        public void hinta_TextChanged(object sender, EventArgs e)
        {
           

            
        }
        
        
            

        public void lopolaatu_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maksa_Click(object sender, EventArgs e)
        {
            
            if (pinit.Contains(pinkoodi.Text))
            {
                tankkaus alaformi = new tankkaus();
                
                alaformi.Show();
                this.Hide();

            }
            else if (pinkoodi.Text=="")
            {
                MessageBox.Show("Syötä pinkoodi");
            }
            else
            {
                MessageBox.Show("väärä pin");
                pinkoodi.Clear();
            }
            
        }

        private void Maksu_Load(object sender, EventArgs e)
        {
            
            label3.Text = Laatu.bensanlaatu;
            label4.Text = Convert.ToString(Summa.hinta);
            label7.Text = Convert.ToString(Convert.ToInt32(Summa.hinta / Laatu.laadunhinta) + (" litraa"));
            litrat = Convert.ToString(Convert.ToInt32(Summa.hinta / Laatu.laadunhinta));
            Tulostatiedostoon(litrat+" litraa");
            
            
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Tulostatiedostoon(string x)
        {
            string Tulostatiedostoon = "U:/KO/Tietojenkäsittely/8.45/Ostokset.txt";
            TextWriter tw = new StreamWriter(Tulostatiedostoon, true);
            tw.WriteLine(x);
            tw.Close();

        }

        private void Pinkoodi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(pinkoodi.Text, "[^0-9]"))
            {
                MessageBox.Show("Kirjoita vain numeroita.");
                pinkoodi.Text = pinkoodi.Text.Remove(pinkoodi.Text.Length - 1);
            }
        }
    }
}
