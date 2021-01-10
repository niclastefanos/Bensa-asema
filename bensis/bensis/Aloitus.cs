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
    public partial class Aloitus : Form
    {
        public static string laatu;
        public static string summa;
        
        
        public Aloitus()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Summa alaformi = new Summa();
            alaformi.Show();
            this.Hide();
        }

        private void Aloitus_Load(object sender, EventArgs e)
        {

        }
    }
}
