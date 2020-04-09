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
    public partial class second : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");

        public second()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter All information");
            }
            else
            {

                try

                {

                    con.Open();
                    SqlDataAdapter checkdoc = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox7.Text + "'", con);
                    DataTable checkdoct = new DataTable();



                    checkdoc.Fill(checkdoct);


                    if (checkdoct.Rows[0][0].ToString() == "1")
                    {
                        MessageBox.Show("Doctor is already Existed");
                    
                    }
                    
                    else
                    {
                        SqlDataAdapter ad = new SqlDataAdapter("INSERT INTO Doctor1 (idDoctor,fname,lname,phone,address,day)VALUES( '" + textBox7.Text + "' , '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "');", con);
                        ad.SelectCommand.ExecuteNonQuery();
                        MessageBox.Show("Doctor is added");
                     
                    }
                    textBox7.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox6.Text = "";
                
            }
                catch (Exception ex)
            {
                MessageBox.Show("invalid input");
                con.Close();
                textBox7.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
            }
            con.Close();
        }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //private void AddPatient_Click(object sender, EventArgs e)
        //{
        //    if (textBox7.Text == "" || textBox1.Text == "" || textBox2.Text == "")
        //    {
        //        MessageBox.Show("Please Enter All information");
        //    }
        //    else
        //    {

        //        try
        //        {
        //            con.Open();
        //            SqlDataAdapter ad = new SqlDataAdapter("INSERT INTO Doctor1 (idDoctor,fname,lname,phone,address,day)VALUES( '" + textBox7.Text + "' , '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "');", con);
        //            ad.SelectCommand.ExecuteNonQuery();
        //            MessageBox.Show("Done");
        //            con.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Missing data or data already found ");
        //            con.Close();
        //        }
        //    }
        //}

        //private void CanclePatient_Click(object sender, EventArgs e)
        //{
        //    this.Visible = false;
        //}
    }
}
