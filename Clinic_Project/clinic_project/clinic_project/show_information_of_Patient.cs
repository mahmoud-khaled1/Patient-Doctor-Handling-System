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

   
    public partial class show_information_of_Patient : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public show_information_of_Patient()
        {
            InitializeComponent();
        }

        private void Show_information_of_Patient_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            dataGridView1.Visible = true;

            try
            {
                //string sqlquery = "SELECT Doctor.idDoctor,Doctor.fname,Doctor.lname,Doctor.phone,Doctor.address,patient.idpat,patient.fname,patient.lname,patient.phone,patient.patHour1 FROM Doctor  INNER JOIN patient ON Doctor.idDoctor=patient.iddoc ORDER BY idDoctor ";
                string sqlqueryy = "SELECT patient.idpat,patient.fname,patient.lname,patient.phone,patient.address,patient.iddoc,patient.type_of_disease,patient.patHour1,patient.medicine,Doctor1.fname,Doctor1.lname FROM patient  INNER JOIN Doctor1 ON patient.iddoc=Doctor1.idDoctor  AND  idpat=" + textBox1.Text + "ORDER BY idpat";
                SqlCommand sqlcomm = new SqlCommand(sqlqueryy, con);

                con.Open();
                SqlDataAdapter sqlad = new SqlDataAdapter(sqlcomm);

                DataTable dt = new DataTable();
                sqlad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch(Exception ee)
            {
                MessageBox.Show("Invalid Input");
            }

           




            con.Close();



        }
    }
}
