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
    public partial class tankkaus : Form
    {
        public tankkaus()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                System.Diagnostics.Process.Start("U:/KO/Tietojenkäsittely/8.45/kuitti.txt");
                Application.Exit();
                
            }
            else
            {
                Application.Exit();
            }
            
        }
        
    }
}
