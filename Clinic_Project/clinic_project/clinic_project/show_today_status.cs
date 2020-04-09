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
using System.Configuration;
namespace clinic_project
{
    public partial class show_today_status : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public show_today_status()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = true;
            Doc_Day.Text = DateTime.Now.ToString();
            try
            {
                //con.Open();

                //SqlDataAdapter checkdel = new SqlDataAdapter("Select Count(*) From Doctor where idDoctor= '" + textBox1.Text + "'", con);
                //DataTable checkdoct = new DataTable();



                //checkdel.Fill(checkdoct);




                //if (checkdoct.Rows[0][0].ToString() == "1")
                //{




                //Retrive Doctor name ;
                //SqlCommand Retrivename = new SqlCommand("SELECT fname FROM Doctor WHERE idDoctor='" + textBox1.Text + "'", con);
                //SqlDataReader rename = Retrivename.ExecuteReader();
                //string str1 = "";
                //if (rename.Read())
                //{

                //    str1 = rename["fname"].ToString();


                //}


                //SqlCommand Retrivename = new SqlCommand("SELECT username FROM login WHERE password='" + textBox1.Text + "'", con);
                //SqlDataReader rename = Retrivename.ExecuteReader();
                //string s = ""; 

                //if(rename.Read())
                //{
                //    s = rename["password"].ToString();
                //}

                //if(s=="textbox.text")
                //{

                //}


                //else if(s==)
                //{

                //}
                //else
                //{

                //}

                con.Close();

                    con.Open();

                    //Retrive Doctor Day ;
                    //SqlCommand RetriveDay = new SqlCommand("SELECT day FROM Doctor WHERE idDoctor='" + textBox1.Text + "'", con);
                    //SqlDataReader reday = RetriveDay.ExecuteReader();
                    //string str2 = "";

                    
                    //if (reday.Read())
                    //{

                    //    str2 = reday["day"].ToString();


                    //}


                    //Doc_Day.Text = str2;
                    //Doc_Day.ForeColor = Color.Red;
                    con.Close();


                   



                    string sqlquery = "SELECT Doctor1.idDoctor,Doctor1.fname,Doctor1.lname,Doctor1.phone,Doctor1.address,patient.idpat,patient.fname,patient.lname,patient.phone,patient.patHour1 FROM Doctor1  INNER JOIN patient ON Doctor1.idDoctor=patient.iddoc ORDER BY idDoctor ";
                    SqlCommand sqlcom = new SqlCommand(sqlquery, con);

                    con.Open();
                    SqlDataAdapter sqlad = new SqlDataAdapter(sqlcom);

                    DataTable dt = new DataTable();
                    sqlad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();


                //}
                //else
                //{
                //    MessageBox.Show("Doctor Not Found");
                //}




                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !");
                con.Close();
            }


            //checkkkkkkkkkkkkkkkkkkkkkkkkkkkkkk;


          








        }

        private void Show_today_status_Load(object sender, EventArgs e)
        {



        }

        private void Doc_Day_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 

        }
    }
}
