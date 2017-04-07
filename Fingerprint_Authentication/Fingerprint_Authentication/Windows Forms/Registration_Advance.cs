using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Fingerprint_Authentication
{
    public partial class Registration_Advance : Form
    {
        DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();                      //Declaring the Database Connection Class
        DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();      //Declaring the Database Connection Class
        
        public Registration_Advance()
        {
            InitializeComponent();
        }

        private void Registration_Advance_Load(object sender, EventArgs e)                  //Event run when the form is loaded or refreshed
        {
            //Page Load of the Registration_Advance Page
            chkb_finger_option.Checked = true;                              //Use to check the checkbox
            lbl_enroll.Visible = false;                                     //Hiding the label so user can't view
            txt_finger.Visible = false;                                     //Hiding the text field so value can be use to save.
        }

        private void chkb_finger_option_CheckedChanged(object sender, EventArgs e)          //Event of checked box when any event is generated
        {         
            if (chkb_finger_option.Checked == false)                        //Checking the checkbox condition.
            {
                Finger_Registration fr = new Finger_Registration();         //Creating object of Finger_Registration form.
                fr.Show();                                                  //Use to run the called form.
                this.Hide();                                                //Use to hide the current running form.
            }
        }       

        private void btn_enroll_Click(object sender, EventArgs e)                           //Event of enroll button when any event is generated
        {
            Process.Start("C:\\Windows\\sgdx.exe");                         //Use to run any file by giving the path. Use by importing System.Diagnostics.

            lbl_enroll.Visible = true;                                      //Showing label for giving message.
        }

        private void btn_clear_Click(object sender, EventArgs e)                            //Event of clear button when any event is generated
        {
            //Clearing the fields of all the textboxs.
            txt_acc.Text = "";                                              //Clear text field by entering NULL value.
            txt_name.Text = "";                                             //Clear text field by entering NULL value.
            txt_pin.Text = "";                                              //Clear text field by entering NULL value.
            txt_finger.Text = "";                                           //Clear text field by entering NULL value.
            chkb_finger_option.Checked = true;                              //Changing the checked value.
        }

        private void btn_del_Click(object sender, EventArgs e)                              //Event of delete button when any event is generated
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
            txt_finger.Text = "";                                           //Clear text field by entering NULL value.
            chkb_finger_option.Checked = false;                             //Changing the checked value.
        }

        private void btn_submit_Click(object sender, EventArgs e)                           //Event of submit button when any event is generated
        {
            DataSet ds = new DataSet();                                     //Creatind object of predefined class for disconnected mode connection.
            string option, query_data, query_finger;                        //Declaring the STRING datatype fields.

            if (chkb_finger_option.Checked == true)                         //Checking for the checkbox for gaining the value for database.
            {
                option = "Yes";
            }

            else
            {
                option = "No";
            }

            txt_finger.Text = "~Images/Original/" + txt_acc.Text + ".bmp";

            //Entering the query in fields
            query_data = "INSERT INTO tbl_acc_details (Acc_No, Name, Password, Fingerprint_Option) VALUES('" + txt_acc.Text.Trim() + "', '" + txt_name.Text.Trim() + "', '" + txt_pin.Text.Trim() + "', '" + option.Trim() + "')";
            query_finger = "INSERT INTO tbl_acc_finger (Acc_No, Original_Finger) VALUES ('" + txt_acc.Text.Trim() + "', '" + txt_finger.Text.Trim() + "')";

            //Initializing the disconnected mode connection.
            SqlDataAdapter da_data = new SqlDataAdapter(query_data, db_data.Connect_Details());
            SqlDataAdapter da_finger = new SqlDataAdapter(query_finger, db_finger.Connect_Fingerprint());
            da_data.Fill(ds);
            da_finger.Fill(ds);

            //Clearing the fields of all the textboxs.
            txt_acc.Text = "";                                              //Clear text field by entering NULL value.
            txt_name.Text = "";                                             //Clear text field by entering NULL value.
            txt_pin.Text = "";                                              //Clear text field by entering NULL value.
            txt_finger.Text = "";                                           //Clear text field by entering NULL value.
            chkb_finger_option.Checked = true;                              //Changing the checked value.
        }
    }
}
