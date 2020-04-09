using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace clinic_project.userinterface
{
    public partial class DelPatient : UserControl
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public DelPatient()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter Id patient");

            }
            else
            {


                try
                {
                    con.Open();


                    SqlDataAdapter checkdel = new SqlDataAdapter("Select Count(*) From patient where idpat= '" + textBox7.Text + "'", con);
                    DataTable checkdoct = new DataTable();



                    checkdel.Fill(checkdoct);


                    if (checkdoct.Rows[0][0].ToString() == "1")
                    {

                        SqlDataAdapter ad = new SqlDataAdapter("DELETE FROM patient WHERE idpat= '" + textBox7.Text + "' ", con);
                        ad.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("DELETED");

                    }
                    else
                    {
                        MessageBox.Show("Patient is not Found");
                    }





                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("invalid input");
                    con.Close();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
