using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_project
{
    public partial class Update : UserControl
    {
        public Update()
        {
            InitializeComponent();

        }

        

        private void Button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Update Medicine for patient")
            {

                Add_medicine addMed = new Add_medicine();
                addMed.Show();

            }
            else if (comboBox1.Text == "Show Today Status")
            {

                show_today_status sho = new show_today_status();

                sho.Show();
            }
            else if (comboBox1.Text == "show information of Patient")
            {
                show_information_of_Patient sp = new show_information_of_Patient();

                sp.Show();

            }
            else if (comboBox1.Text == "Cancel Reservation ") 
            {
                Cancel_Reservation cr = new Cancel_Reservation();

                cr.Show(); 


                
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {
           
        }
    }
}
