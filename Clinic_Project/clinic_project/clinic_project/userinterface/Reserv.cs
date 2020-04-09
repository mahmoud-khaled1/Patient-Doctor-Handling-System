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
    public partial class Reserv : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public Reserv()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (textBox7.Text == "" || textBox8.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Invalid Input ");
            }
            else
            {

                try
                {

                    con.Open();
                    SqlDataAdapter conad = new SqlDataAdapter("Select Count(*) From patient where idpat= '" + textBox7.Text + "' and iddoc= '" + textBox8.Text + "'", con);

                    DataTable dat1 = new DataTable();



                    conad.Fill(dat1);


                    if (dat1.Rows[0][0].ToString() == "1")
                    {
                        ////////////////////////////////////////////


                        SqlDataAdapter conadd = new SqlDataAdapter("Select Count(*) From Doctor where idDoctor= '" + textBox8.Text + "'", con);

                        DataTable dat11 = new DataTable();



                        conad.Fill(dat11);


                        if (dat11.Rows[0][0].ToString() == "1")
                        {





                            //////////////////////////////////////////////
                            string Hour = textBox1.Text;
                            if (textBox1.Text == "1")
                            {


                                // SqlDataAdapter cc= new SqlDataAdapter("INSERT INTO PATIENT (patHour1) VALUES('" + textBox1.Text + "');", con);
                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=1 WHERE idpat='" + textBox7.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                updatehourpat.SelectCommand.ExecuteNonQuery();

                            }
                            else if (textBox1.Text == "2")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=2 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }
                            else if (textBox1.Text == "3")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=3 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }
                            else if (textBox1.Text == "4")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=4 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }
                            else if (textBox1.Text == "5")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=5 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }
                            else if (textBox1.Text == "6")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=6 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }
                            else if (textBox1.Text == "7")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=7 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }

                            else if (textBox1.Text == "8")
                            {

                                SqlDataAdapter updatehourpat = new SqlDataAdapter("UPDATE  patient  SET patHour1=8 WHERE idpat='" + textBox7.Text + "'", con);

                                updatehourpat.SelectCommand.ExecuteNonQuery();
                            }



                            string k = "0";
                            // SqlDataAdapter conad1 = new SqlDataAdapter("Select Count(*) From Doctor where idDoctor= '" + textBox8.Text  +"'"+"'AND  Doctor.h1='"+ k + "'", con);
                            SqlDataAdapter conad1 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h1= '" + k + "'", con);
                            DataTable d1 = new DataTable();
                            conad1.Fill(d1);




                            SqlDataAdapter conad2 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h2= '" + k + "'", con);
                            DataTable d2 = new DataTable();
                            conad2.Fill(d2);


                            SqlDataAdapter conad3 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h3= '" + k + "'", con);
                            DataTable d3 = new DataTable();
                            conad3.Fill(d3);



                            SqlDataAdapter conad4 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h4= '" + k + "'", con);
                            DataTable d4 = new DataTable();
                            conad4.Fill(d4);




                            SqlDataAdapter conad5 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h5= '" + k + "'", con);
                            DataTable d5 = new DataTable();
                            conad5.Fill(d5);



                            SqlDataAdapter conad6 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h6= '" + k + "'", con);
                            DataTable d6 = new DataTable();
                            conad6.Fill(d6);



                            SqlDataAdapter conad7 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h7= '" + k + "'", con);
                            DataTable d7 = new DataTable();
                            conad7.Fill(d7);



                            SqlDataAdapter conad8 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h8= '" + k + "'", con);
                            DataTable d8 = new DataTable();
                            conad8.Fill(d8);


                            if (d1.Rows[0][0].ToString() == "1" && Hour == "1")
                            {
                                SqlDataAdapter conad80 = new SqlDataAdapter("UPDATE  Doctor1  SET h1=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                conad80.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }



                            else if (d2.Rows[0][0].ToString() == "1" && Hour == "2")
                            {
                                SqlDataAdapter hour1 = new SqlDataAdapter("UPDATE  Doctor1  SET h2=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour1.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }
                            else if (d3.Rows[0][0].ToString() == "1" && Hour == "3")
                            {
                                SqlDataAdapter hour2 = new SqlDataAdapter("UPDATE  Doctor1  SET h3=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour2.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }

                            else if (d4.Rows[0][0].ToString() == "1" && Hour == "4")
                            {
                                SqlDataAdapter hour3 = new SqlDataAdapter("UPDATE  Doctor1  SET h4=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour3.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }

                            else if (d5.Rows[0][0].ToString() == "1" && Hour == "5")
                            {
                                SqlDataAdapter hour4 = new SqlDataAdapter("UPDATE  Doctor1  SET h5=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour4.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }

                            else if (d6.Rows[0][0].ToString() == "1" && Hour == "6")
                            {
                                SqlDataAdapter hour5 = new SqlDataAdapter("UPDATE  Doctor1  SET h6=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour5.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }

                            else if (d7.Rows[0][0].ToString() == "1" && Hour == "7")
                            {
                                SqlDataAdapter hour6 = new SqlDataAdapter("UPDATE  Doctor1  SET h7=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour6.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }

                            else if (d8.Rows[0][0].ToString() == "1" && Hour == "8")
                            {
                                SqlDataAdapter hour7 = new SqlDataAdapter("UPDATE  Doctor1  SET h8=1 WHERE idDoctor='" + textBox8.Text + "'", con);
                                //SqlDataAdapter up = new SqlDataAdapter("UPDATE Doctor SET h1=1 WHERE idDoctor= ", con);
                                hour7.SelectCommand.ExecuteNonQuery();
                                MessageBox.Show("Done");


                            }
                            else
                            {
                                MessageBox.Show("This Hour is token");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Doctor Not Found ");
                        }



                        con.Close();
                    }
                    else
                    {


                        MessageBox.Show("patient or Doctor is not Found Add patient now?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
                catch (Exception eee)
                {
                    MessageBox.Show("invalid input");
                    con.Close();
                }
                con.Close();
            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {

           
       
           
            con.Open();
            SqlDataAdapter conad = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "'", con);
           
            DataTable dat1 = new DataTable();



            conad.Fill(dat1);


            if (dat1.Rows[0][0].ToString() == "1")
            {

                //SqlDataAdapter conad1 = new SqlDataAdapter("Select  Count(*)  From Doctor where idDoctor= '" + textBox8.Text + "'"+"' and h1= '"'" , con);
                SqlDataAdapter conad1 = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "' and h1= '" + "1" + "'", con);
                DataTable d1 = new DataTable();
                conad1.Fill(d1);


                SqlDataAdapter conad2 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h2= '" + "1" + "'", con);
                DataTable d2 = new DataTable();
                conad2.Fill(d2);


                SqlDataAdapter conad3 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h3= '" + "1" + "'", con);
                DataTable d3 = new DataTable();
                conad3.Fill(d3);



                SqlDataAdapter conad4 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h4= '" + "1" + "'", con);
                DataTable d4 = new DataTable();
                conad4.Fill(d4);



                SqlDataAdapter conad5 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h5= '" + "1" + "'", con);
                DataTable d5 = new DataTable();
                conad5.Fill(d5);



                SqlDataAdapter conad6 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h6= '" + "1" + "'", con);
                DataTable d6 = new DataTable();
                conad6.Fill(d6);



                SqlDataAdapter conad7 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h7= '" + "1" + "'", con);
                DataTable d7 = new DataTable();
                conad7.Fill(d7);



                SqlDataAdapter conad8 = new SqlDataAdapter("Select  Count(*)  From Doctor1 where idDoctor= '" + textBox8.Text + "' and h8= '" + "1" + "'", con);
                DataTable d8 = new DataTable();
                conad8.Fill(d8);

                string str = "";
                string str2 = "";

                
                if (d1.Rows[0][0].ToString() == "0")
                {


                    str += "10 - 10:30 Free"+Environment.NewLine;


                }
                else
                {
                    str2 += "10 - 10:5 occupied" + Environment.NewLine;
                }

                if (d2.Rows[0][0].ToString() == "0")
                {
                    str += "10:30 - 11 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "10:5 - 11 occupied" + Environment.NewLine;
                }


                if (d3.Rows[0][0].ToString() == "0")
                {
                    str += "11 - 11:30 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "11 - 11:5 occupied" + Environment.NewLine;
                }

                if (d4.Rows[0][0].ToString() == "0")
                {
                    str += "11:30 - 12 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "11:5 - 12 occupied" + Environment.NewLine;
                }

                if (d5.Rows[0][0].ToString() == "0")
                {
                    str += "12 - 12:30 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "12 - 12:30 occupied" + Environment.NewLine;
                }
                if (d6.Rows[0][0].ToString() == "0")
                {
                    str += "12:30 - 1 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "12:30 - 1 occupied" + Environment.NewLine;
                }
                if (d7.Rows[0][0].ToString() == "0")
                {
                    str += "1 - 1:30 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "1 - 1.30 occupied" + Environment.NewLine;
                }
                if (d8.Rows[0][0].ToString() == "0")
                {
                    str += "1:30 - 2 Free" + Environment.NewLine;


                }
                else
                {
                    str2 += "1:30 - 2 occupied" + Environment.NewLine;
                }

                
                

                //MessageBox.Show(str);


                label3.Text = (" Avaliable Times")+Environment.NewLine+Environment.NewLine+ str+"--------------------"+Environment.NewLine+Environment.NewLine+ " Not Avaliable Times" + Environment.NewLine + Environment.NewLine + str2;













                //MessageBox.Show("ok");
                //this.Hide();

                //menuForm f2 = new menuForm();
                //f2.Show();


            }
            else
            {


                DialogResult result = MessageBox.Show("Doctor is not Found ","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            con.Close();




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            this.Hide();
        }

       

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
