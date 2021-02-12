using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace primaincercare2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Form5 f5 = new Form5();
        
        private void button3_Click(object sender, EventArgs e)
        {
            f5.Show();
            this.Hide();

        }
        Form6 f6 = new Form6();
        private void button2_Click(object sender, EventArgs e)
        {
            f6.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comanda a fost achitata!");
            this.Hide();
            
            
        }
    }
}
