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
    public partial class firstttt : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\20102\Clinic_DB.MDF;Integrated Security=True;Connect Timeout=30");
        public firstttt()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }


        private void Firstttt_Load(object sender, EventArgs e)
        {

            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //textBox7.BackColor = Color.Transparent;

        }

        private void AddPatient_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox7.Text == "" || textBox2.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Please Enter All information");
            }

            else
            {

                try
                {
                    con.Open();



                    SqlDataAdapter conad = new SqlDataAdapter("Select Count(*) From patient where idpat= '" + textBox7.Text + "' and iddoc= '" + textBox8.Text + "'", con);

                    DataTable dat = new DataTable();


                    conad.Fill(dat);




                    SqlDataAdapter conadd = new SqlDataAdapter("Select Count(*) From Doctor1 where idDoctor= '" + textBox8.Text + "'", con);

                    DataTable datt = new DataTable();


                    conadd.Fill(datt);

                    if (datt.Rows[0][0].ToString() == "0")
                    {
                        MessageBox.Show(" Doctor is not found");

                    }
                    else
                    {

                         if (dat.Rows[0][0].ToString() == "1")
                         {
                            MessageBox.Show(" Patient is Already existed ");

                         }
                        else
                        {


                            SqlDataAdapter add = new SqlDataAdapter("INSERT INTO patient (idpat,fname,lname,phone,address,iddoc,type_of_disease)VALUES( '" + textBox7.Text + "' , '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox8.Text + "','" + textBox5.Text + "');", con);
                            //SqlDataAdapter ad = new SqlDataAdapter("INSERT INTO Doctor1 (idDoctor,fname,lname,phone,address,day)VALUES( '" + textBox7.Text + "' , '" + textBox1.Text + "' ,'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "');", con);
                            add.SelectCommand.ExecuteNonQuery();
                            MessageBox.Show("Patient is added");
                            //MessageBox.Show("plz add");
                        }

                    }
                    con.Close();

                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";

                }
                catch(Exception eeee)
                {
                    MessageBox.Show("Invalid Input");
                    textBox4.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox5.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
            }


        }
    

        

        private void CanclePatient_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
