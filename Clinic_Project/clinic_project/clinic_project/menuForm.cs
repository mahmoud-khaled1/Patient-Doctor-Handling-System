using clinic_project.Properties;
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
    public partial class menuForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public menuForm()
        {
            InitializeComponent();
            //stripstutus.Text = DateTime.Now.ToString();
            //panel3.Visible = false;



        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            second2.Visible = true;
            delPatient1.Hide();
            deldoctor1.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mininizee_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 
        }

        private void Maxmize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            maxmize.Visible = false;
            Restarter.Visible = true; 

        }

        private void Restarter_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restarter.Visible = false;
            maxmize.Visible = true;
        }

        private void Menusidebar_Click(object sender, EventArgs e)
        {
            //if(linesilder.Width==270)
            //{
            //    linesilder.Width = 68;
            //    sidebarwrapper.Width = 90; 
            //}
            //else
            //{
            //    linesilder.Width = 270;
            //    sidebarwrapper.Width = 300;
            //}
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            deldoctor1.Hide();
            delPatient1.Hide();
            firstttt1.Hide();
            reserv1.Hide();
            second2.Visible = true;
            update1.Hide();
            firstttt1.Visible = false;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            deldoctor1.Hide();
            delPatient1.Hide();
            reserv1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Hide();
            second2.Visible = false;
            firstttt1.Visible = true;
        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            second2.Visible = false;
            firstttt1.Visible = false;

            this.Hide();
            loginForm newform = new loginForm();
            newform.Show();
            

        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {
            deldoctor1.Show();
            reserv1.Hide();
            delPatient1.Hide();
            firstttt1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Hide();
        }



        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            delPatient1.Show();
            reserv1.Hide();
            deldoctor1.Hide();
            firstttt1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Hide();
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {

            reserv1.Show();
            delPatient1.Hide();
            deldoctor1.Hide();
            firstttt1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Hide();


        }

        private void Reserv1_Load(object sender, EventArgs e)
        {


        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {



            //Update Patient 
            reserv1.Hide();
            delPatient1.Hide();
            deldoctor1.Hide();
            firstttt1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Show();
        }

        private void BunifuSeparator6_Load(object sender, EventArgs e)
        {

        }

        private void Update1_Load(object sender, EventArgs e)
        {

        }

        private void BunifuSeparator4_Load(object sender, EventArgs e)
        {

        }

        private void Linesilder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            deldoctor1.Hide();
            delPatient1.Hide();
            reserv1.Hide();
            second1.Hide();
            second2.Hide();
            update1.Hide();
            second2.Visible = false;
            firstttt1.Visible = true;
        }
    }
}
