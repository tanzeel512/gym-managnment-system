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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6BDK8C7\SQLEXPRESS;Initial Catalog=vpl.com;Integrated Security=True");
            con.Open();
            int userid = Convert.ToInt16(textBox1.Text);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT COUNT(*) FROM users WHERE userid='" + userid + "' AND Password='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (userid == 1001)
                {
                    this.Hide();
                    new Form2().Show();
                }
                else
                {
                    this.Hide();
                    new Form3().Show();
                }
            }
            else
            {
               
                DialogResult result = MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.RetryCancel);
                if (result == DialogResult.Retry)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.Show();
                }
                else
                {
                    Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
