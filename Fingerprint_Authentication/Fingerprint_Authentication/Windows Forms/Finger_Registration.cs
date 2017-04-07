using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fingerprint_Authentication
{
    public partial class Finger_Registration : Form
    {
        DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();                          //Declaring the Database Connection Class
        DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();          //Declaring the Database Connection Class

        public Finger_Registration()
        {
            InitializeComponent();
        }

        private void Finger_Registration_Load(object sender, EventArgs e)                       //Event run when the form is loaded or refreshed
        {
            chkb_finger_option.Checked = false;                                     //Use to check the checkbox
        }

        private void chkb_finger_option_CheckedChanged(object sender, EventArgs e)              //Event of checked box when any event is generated
        {
            if (chkb_finger_option.Checked == true)                                 //Checking the checkbox condition.
            {
                Registration_Advance ra = new Registration_Advance();               //Creating object of Registration_Advance form.
                ra.Show();                                                          //Use to run the called form.
                this.Hide();                                                        //Use to hide the current running form.
             }
        }

        private void btn_clear_Click(object sender, EventArgs e)                                //Event of checked box when any event is generated
        {
            //Clearing the fields of all the textboxs.
            txt_acc.Text = "";                                                      //Clear text field by entering NULL value.
            txt_name.Text = "";                                                     //Clear text field by entering NULL value.
            txt_pin.Text = "";                                                      //Clear text field by entering NULL value.
            chkb_finger_option.Checked = false;                                     //Changing the checked value.
        }

        private void btn_del_Click(object sender, EventArgs e)                                  //Event of delete button when any event is generated
        {
            DataSet ds = new DataSet();                                     //Creatind object of predefined class for disconnected mode connection.

            string query_del_data, query_del_finger;                        //Declaring the STRING datatype fields.
            //Entering the query in both datatype fields
            query_del_data = "DELETE FROM tbl_acc_details WHERE Acc_No = '" + txt_acc.Text + "' ";
            query_del_finger = "DELETE FROM tbl_acc_finger WHERE Acc_No = '" + txt_acc.Text + "' ";

            SqlDataAdapter da_data, da_finger;                              //Initializing the disconnected mode connection.

            da_data = new SqlDataAdapter(query_del_data, db_data.Connect_Details());
            da_finger = new SqlDataAdapter(query_del_finger, db_finger.Connect_Fingerprint());

            da_data.Fill(ds);
            da_finger.Fill(ds);

            //Clearing the fields of all the textboxs.
            txt_acc.Text = "";                                              //Clear text field by entering NULL value.
            txt_name.Text = "";                                             //Clear text field by entering NULL value.
            txt_pin.Text = "";                                              //Clear text field by entering NULL value.
            chkb_finger_option.Checked = false;                             //Changing the checked value.
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();                                     //Creatind object of predefined class for disconnected mode connection.
            string option, query;                                           //Declaring the STRING datatype fields.

            if (chkb_finger_option.Checked == true)                         //Checking for the checkbox for gaining the value for database.
            {
                option = "Yes";
            }

            else
            {
                option = "No";
            }

            //Entering the query in fields
            query = "INSERT INTO tbl_acc_details (Acc_No, Name, Password, Fingerprint_Option) VALUES('" + txt_acc.Text.Trim() + "', '" + txt_name.Text.Trim() + "', '" + txt_pin.Text.Trim() + "', '" + option.Trim() + "')";

            //Initializing the disconnected mode connection.
            SqlDataAdapter da = new SqlDataAdapter(query, db_data.Connect_Details());
            da.Fill(ds);

            //Clearing the fields of all the textboxs.
            txt_acc.Text = "";                                              //Clear text field by entering NULL value.
            txt_name.Text = "";                                             //Clear text field by entering NULL value.
            txt_pin.Text = "";                                              //Clear text field by entering NULL value.
            chkb_finger_option.Checked = false;                             //Changing the checked value.
        }

    }
}
