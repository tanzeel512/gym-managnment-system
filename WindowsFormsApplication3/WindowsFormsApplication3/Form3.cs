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
    public partial class Form3 : Form
    {
        public Form3()
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
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
 
            cmd.ExecuteNonQuery();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newmember nm = new Newmember();
            nm.Show();
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Newstaff ns = new Newstaff();
            ns.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchmember sm = new Searchmember();
            sm.Show();
        }

        private void trainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trainer ts = new trainer();
            ts.Show();
        }

        private void atToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.Show();
        }
    }
}
