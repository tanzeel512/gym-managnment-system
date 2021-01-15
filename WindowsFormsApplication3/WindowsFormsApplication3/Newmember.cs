using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Newmember : Form
    {
        public Newmember()
        {
            InitializeComponent();
        }

        private void Newmember_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String fname = textBox1.Text;
            String lname = textBox2.Text;

            String gender = "";

            bool isChacked = radioButton1.Checked;

            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            String dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox3.Text);
            String email = textBox4.Text;
            String joindate = dateTimePicker2.Text;
            String gymTime = comboBox1.Text;
            String address = richTextBox1.Text;
            String membership = comboBox2.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6BDK8C7\SQLEXPRESS;Initial Catalog=vpl.com;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into NewMember values('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + gymTime + "','" + address + "','" + membership + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been saved in database");
            
            con.Close();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            radioButton1.Checked = false;
            radioButton2.Checked = false;

            textBox3.Clear();
            textBox4.Clear();

            comboBox1.ResetText();
            comboBox2.ResetText();
            richTextBox1.Clear();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
