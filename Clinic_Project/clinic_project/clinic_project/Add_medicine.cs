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
    public partial class Add_medicine : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public Add_medicine()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {





            try
            {
                con.Open();





                SqlDataAdapter checkpat = new SqlDataAdapter("Select Count(*) From patient where idpat= '" + textBox1.Text + "' and iddoc= '" + textBox3.Text + "'", con);
                
                DataTable checkdpatt = new DataTable();



                checkpat.Fill(checkdpatt);


                if (checkdpatt.Rows[0][0].ToString() == "0")
                {
                    MessageBox.Show("Patient or Doctor is not Found ");

                    con.Close();
                    
                }
                else
                {

                    //Retrive Date from database ! 

                    SqlCommand Retrive = new SqlCommand("SELECT medicine FROM patient WHERE idpat='" + textBox1.Text + "' and iddoc= '" + textBox3.Text + "'", con);

                    SqlDataReader re = Retrive.ExecuteReader();
                    string str1 = "";

                    if (re.Read())
                    {

                        str1 = re["medicine"].ToString();
                        str1 += (Environment.NewLine + '/' + textBox2.Text);

                    }



                    con.Close();




                    con.Open();

                    SqlDataAdapter update_Medicine = new SqlDataAdapter("UPDATE  patient  SET medicine='" + str1.ToString() + "' WHERE idpat='" + textBox1.Text + "' and iddoc= '" + textBox3.Text + "'", con);

                    //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                    update_Medicine.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Done");

                }
            }
            catch(Exception eee)
            {
                MessageBox.Show("invalid input");
            }


           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            this.Hide(); 

        }

        private void Add_medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
