using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6BDK8C7\SQLEXPRESS;Initial Catalog=vpl.com;Integrated Security=True");
            con.Open();
            int userid = Convert.ToInt16(textBox1.Text);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users values ('" + userid + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted succssfully");
            textBox1.Clear();
            textBox2.Clear();
            disp_data();
        }
        public void disp_data()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6BDK8C7\SQLEXPRESS;Initial Catalog=vpl.com;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGEM50J;Persist Security Info=True;User ID=sa;Password=iunc123");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users SET Password = '" + textBox2.Text + "' where userid='" + textBox1.Text + "'";

            cmd.ExecuteNonQuery();
            MessageBox.Show("Password changed sucessfully");
            textBox1.Clear();
            textBox2.Clear();
            disp_data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PGEM50J;Persist Security Info=True;User ID=sa;Password=iunc123");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from users where userid  = '" + textBox1.Text + "'and Password= '" + textBox2.Text + "'";

            cmd.ExecuteNonQuery();
            MessageBox.Show("User deleted sucessfully");
            textBox1.Clear();
            textBox2.Clear();
            disp_data();
        }
    }

}
