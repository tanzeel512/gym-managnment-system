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
    public partial class Newstaff : Form
    {
        public Newstaff()
        {
            InitializeComponent();
        }

        private void newstaff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox2 .Text;

            String gender = "";
            bool isChecked = radioButton1.Checked;

            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            String dob = dateTimePicker1 .Text;
            Int64 mobile = Int64.Parse(textBox3.Text);
            String email = textBox4.Text;
            String joindate = dateTimePicker2.Text;
            String state = comboBox1.Text;
            String city = textBox5.Text;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6BDK8C7\SQLEXPRESS;Initial Catalog=vpl.com;Integrated Security=True");
            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into NewStaff values('" + fname + "','" + lname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + joindate + "','" + state + "','" + city + "')";
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
            textBox5.Clear();

          dateTimePicker1.Value = DateTime.Now;
           dateTimePicker2.Value = DateTime.Now;
        }
    }
}
