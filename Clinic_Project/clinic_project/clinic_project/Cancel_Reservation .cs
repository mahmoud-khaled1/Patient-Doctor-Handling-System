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
    public partial class Cancel_Reservation : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public Cancel_Reservation()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("nvalid Input");

            }
            else
            {

                try
                {
                    con.Open();


                    SqlDataAdapter checkdel = new SqlDataAdapter("Select Count(*) From patient where idpat= '" + textBox1.Text + "' and iddoc= '" + textBox2.Text + "'", con);
                    DataTable checkdoct = new DataTable();



                    checkdel.Fill(checkdoct);


                    if (checkdoct.Rows[0][0].ToString() == "1")
                    {

                        SqlCommand RetrivepatHour = new SqlCommand("SELECT patHour1 FROM patient WHERE idpat='" + textBox1.Text + "' and iddoc= '" + textBox2.Text + "'", con);

                        SqlDataReader re = RetrivepatHour.ExecuteReader();
                        string str1 = "";

                        if (re.Read())
                        {

                            str1 = re["patHour1"].ToString();
                            

                        }
                        con.Close();
                        con.Open();
                    

                        SqlDataAdapter update_patHour = new SqlDataAdapter("UPDATE  patient  SET patHour1='"+0+ "' WHERE idpat='" + textBox1.Text + "' and iddoc= '" + textBox2.Text + "'", con);
                        update_patHour.SelectCommand.ExecuteNonQuery();


                    string kk = "0";
                        if (str1=="1")
                        {

                            SqlDataAdapter update_doctorhour1 = new SqlDataAdapter("UPDATE  Doctor1  SET h1='"+ kk + "' WHERE idDoctor='" + textBox2.Text +  "'", con);

                            update_doctorhour1.SelectCommand.ExecuteNonQuery();
                        }
                        else if(str1=="2")
                        {
                            SqlDataAdapter update_doctorhour2 = new SqlDataAdapter("UPDATE  Doctor1  SET h2='"+ kk + "' WHERE idDoctor='" + textBox2.Text +  "'", con);

                            update_doctorhour2.SelectCommand.ExecuteNonQuery();
                        }
                        else if (str1 == "3")
                        {
                            SqlDataAdapter update_doctorhour3 = new SqlDataAdapter("UPDATE  Doctor1  SET h3='" + kk+ "' WHERE idDoctor='" + textBox2.Text +  "'", con);

                            update_doctorhour3.SelectCommand.ExecuteNonQuery();
                        }
                        else if (str1 == "4")
                        {
                            SqlDataAdapter update_doctorhour4 = new SqlDataAdapter("UPDATE  Doctor1  SET h4='" + kk + "' WHERE idDoctor='" + textBox2.Text + "'", con);

                            update_doctorhour4.SelectCommand.ExecuteNonQuery();
                        }
                        else if (str1 == "5")
                        {
                            SqlDataAdapter update_doctorhour5 = new SqlDataAdapter("UPDATE  Doctor1  SET h5='" + kk + "' WHERE idDoctor='" + textBox2.Text +  "'", con);

                            update_doctorhour5.SelectCommand.ExecuteNonQuery();
                        }

                        else if (str1 == "6")
                        {
                            SqlDataAdapter update_doctorhour6 = new SqlDataAdapter("UPDATE  Doctor1  SET h6='" + kk+ "' WHERE idDoctor='" + textBox2.Text +"'", con);

                            update_doctorhour6.SelectCommand.ExecuteNonQuery();
                        }

                        else if (str1 == "7")
                        {
                            SqlDataAdapter update_doctorhour7 = new SqlDataAdapter("UPDATE  Doctor1 SET h7='" +kk + "' WHERE idDoctor='" + textBox2.Text + "'", con);

                            update_doctorhour7.SelectCommand.ExecuteNonQuery();
                        }

                        else if (str1 == "8")
                        {
                            SqlDataAdapter update_doctorhour8 = new SqlDataAdapter("UPDATE  Doctor1  SET h8='" + kk+ "' WHERE idDoctor='" + textBox2.Text +  "'", con);
                            
                            update_doctorhour8.SelectCommand.ExecuteNonQuery();
                           
                        }

                        

                        MessageBox.Show("Done");
                    con.Close();
                    }
                    else
                    {
                        
                        MessageBox.Show("Patient or Doctor is not Found");
                    }



                    con.Close();

                }
                catch (Exception ee)
                {
                    MessageBox.Show("Invalid Input");
                    con.Close();
                }
            }





        }
    }
}
