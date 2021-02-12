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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }
        Form2 f2 = new Form2(); 
        private void button10_Click(object sender, EventArgs e)
        {
            f2.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        
        }
        Form4 f4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }
}
