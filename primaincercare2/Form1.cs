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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string cs = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(cs);
        DataTable dt = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form2 f2 = new Form2();
         
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Introduceti toti campii.");
            else
            {
                SqlCommand com = new SqlCommand("select count(*) from angajat where email ='" + textBox1.Text + "' and parola ='" + textBox2.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand com1 = new SqlCommand("select rol from angajat where email ='" + textBox1.Text + "' and parola ='" + textBox2.Text + "'", con);
                    SqlDataAdapter da1 = new SqlDataAdapter(com1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    string a = "manager";
                    string b =dt1.Rows[0][0].ToString().Trim();
                    if (a.Equals(b))
                    {
                        Form7 f7 = new Form7();
                        f7.Show();
                        this.Hide();
                    }
                    else
                    { 
                         con.Close();
                         f2.Show();
                         this.Hide();
                         
                    }
                    textBox1.Clear();
                    textBox2.Clear();

                }
                else
                { 
                     MessageBox.Show("Email sau Parola gresite! Reincercati.");
                     textBox1.Clear();
                     textBox2.Clear();
                }
                    
                con.Close();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
