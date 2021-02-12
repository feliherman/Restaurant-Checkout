using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primaincercare2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        
        static string cs = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(cs);
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            /*dataGridView1.ForeColor = Color.Gray;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray;
            dataGridView1.EnableHeadersVisualStyles = false;*/
            SqlCommand com = new SqlCommand("select nume, prenume, rol from angajat where rol != 'manager' ", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            BindingSource bs = new BindingSource();
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;
            SqlCommand com1 = new SqlCommand("select denumire, pret, descriere,durata from produse ", con);
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = dt1;
            dataGridView2.DataSource = bs1;
            dt1.Clear();
            da1.Fill(dt1);
            dt.Clear();
            da.Fill(dt);
            con.Close();
        }
        Form8 f8 = new Form8();
        private void button2_Click(object sender, EventArgs e)
        {
            f8.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }
        
    }
}
