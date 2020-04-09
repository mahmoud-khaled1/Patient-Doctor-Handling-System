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
namespace clinic_project
{
    public partial class loginForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public loginForm()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="username")
            {
                textBox1.Text = "";
            }

            textBox1.ForeColor = Color.Black;

        }
        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "username";
            }

            textBox1.ForeColor = Color.Silver;

        }


        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text=="password")
            {
                textBox2.Text = "";
            }

            textBox2.ForeColor = Color.Black; 
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "password";
            }

            textBox2.ForeColor = Color.Silver;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter conad = new SqlDataAdapter("Select Count(*) From login where username= '" + textBox1.Text + "' and password= '" + textBox2.Text + "'", con);

            DataTable dat = new DataTable();

            
            conad.Fill(dat);

            if (dat.Rows[0][0].ToString() == "1")
            {
                this.Hide();

                menuForm f2 = new menuForm();
                f2.Show();
                
            }
            else
            {
                MessageBox.Show(" incorrect username or password .", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            con.Close();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Maximized;

            maxmize.Visible = false;
            Restarter.Visible = true;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restarter.Visible = false;
            maxmize.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
