using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace primaincercare2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        string imgLocation = "";
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True;User Instance=True");
        SqlCommand cmd;
        private void Browsebutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;

            }

        }
        Form f7 = new Form7();
        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Streem = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Streem);
            images = brs.ReadBytes((int)Streem.Length);
            con.Open();
            string sqlQuery = "Insert into produse(denumire,pret,descriere,durata,image)Values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',@images) ";
            cmd = new SqlCommand(sqlQuery,con);
            cmd.Parameters.Add(new SqlParameter ("@images", images));
            int N = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(N.ToString()+"Datele au fost salvate cu succes!");

            f7.Show();
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            f7.Show();
            this.Hide();
        }
    }
}
