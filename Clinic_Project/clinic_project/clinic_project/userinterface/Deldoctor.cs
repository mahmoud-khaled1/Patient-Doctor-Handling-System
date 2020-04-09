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
    public partial class Deldoctor : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");

        public Deldoctor()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (textBox7.Text == "")
            {
                MessageBox.Show("Please Enter Doctor's ID");
            }
            else
            {

                try
                {
                    con.Open();

                    SqlDataAdapter checkdel = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox7.Text + "'", con);
                    DataTable checkdoct = new DataTable();



                    checkdel.Fill(checkdoct);


                    if (checkdoct.Rows[0][0].ToString() == "1")
                    {


                        SqlDataAdapter ad = new SqlDataAdapter("DELETE FROM Doctor1 WHERE idDoctor= '" + textBox7.Text + "' ", con);
                        ad.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("DELETED");

                    }
                    else
                    {
                        MessageBox.Show("Doctor is not found");
                    }




                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid input");
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
