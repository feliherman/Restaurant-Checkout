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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        static string cs = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True";
        SqlConnection con = new SqlConnection(cs);

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("select max(id) from angajat",con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlCommand com1 = new SqlCommand("insert into angajat (id, nume, prenume, rol, email, parola) values(" + (int.Parse(dt.Rows[0][0].ToString())) + 1 + ",'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", con);
            MessageBox.Show(dt.Rows[0][0].ToString());
            com1.ExecuteNonQuery();
            con.Close();
            dt.Clear();
            da.Fill(dt);
            MessageBox.Show("Adaugarea angajatului efectuata cu succes!");
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
