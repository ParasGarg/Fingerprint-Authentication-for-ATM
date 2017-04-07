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
    public partial class ATM_Machine : Form
    {
        public ATM_Machine()
        {
            InitializeComponent();
        }

        int flag = 1, click = 0, count = 1;

        DB_ATM_Data_Connection db_data = new DB_ATM_Data_Connection();
        DB_ATM_Fingerprint_Connection db_finger = new DB_ATM_Fingerprint_Connection();

        private void ATM_Machine_Load(object sender, EventArgs e)
        {
            //Hiding unnecessary fields.
            txtb_input.Visible = false;
            pic_swipe.Visible = false;

            lbl_middle.Text = "WELCOME TO ATM MACHINE";
        }

        private void btn_key_1_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 1;
        }

        private void btn_key_2_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 2;
        }

        private void btn_key_3_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 3;
        }

        private void btn_key_4_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 4;
        }

        private void btn_key_5_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 5;
        }

        private void btn_key_6_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 6;
        }

        private void btn_key_7_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 7;
        }

        private void btn_key_8_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 8;
        }

        private void btn_key_9_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 9;
        }

        private void btn_key_0_Click(object sender, EventArgs e)
        {
            txtb_input.Text += 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_upper.Visible = false;
            lbl_lower.Visible = false;
            txtb_input.Visible = false;
            lbl_name.Visible = false;
            lbl_acc.Visible = false;

            lbl_middle.Text = "THANKS TO VISIT TO ATM MACHINE";
        }

        private void btn_correction_Click(object sender, EventArgs e)
        {
            txtb_input.Text = "";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            click = 1;

            if (click == 1)
            {
                lbl_middle.Text = "ENTER YOUR CARD NUMBER";
                txtb_input.Visible = true;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (click == 1)
            {
                if (flag == 1)
                {
                    DataSet ds = new DataSet();

                    string query = "SELECT * FROM tbl_acc_details WHERE Acc_No='" + txtb_input.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(query, db_data.Connect_Details());
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //lbl_upper.Text = "Welcome" + "  " + ds.Tables[0].Rows[0][1].ToString();
                        lbl_upper.Text = "PIN REQUEST MENU";
                        lbl_middle.Text = "ENTER YOUR PIN-CODE";

                        lbl_acc.Text = txtb_input.Text;

                        txtb_input.Text = "";
                        lbl_name.Text = ds.Tables[0].Rows[0][1].ToString();

                        flag = 2;
                    }

                    else
                    {
                        if (count <= 3)
                        {
                            lbl_upper.Text = "SORRY YOU HAD DONE A WRONG ATTEMPT";
                            lbl_middle.Text = "Please Re-Insert The Card";
                            txtb_input.Text = "";
                            count++;
                        }

                        else
                        {
                            flag = 4;
                        }
                    }
                }

                else if (flag == 2)
                {
                    DataSet ds = new DataSet();

                    string query1 = "SELECT * FROM tbl_acc_details WHERE Name= '" + lbl_name.Text + "' AND Password='" + txtb_input.Text + "'";
                    SqlDataAdapter da1 = new SqlDataAdapter(query1, db_data.Connect_Details());
                    da1.Fill(ds);

                    count = 1;

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        //lbl_upper.Text = "Congrats" + "  " + ds.Tables[0].Rows[0][1].ToString();
                        lbl_upper.Text = "FINGERPRINT SECURITY MENU";
                        lbl_middle.Text = "SWIPE YOUR FINGER";
                        pic_swipe.Visible = true;
                        txtb_input.Visible = false;
                        flag = 3;
                    }

                    else
                    {
                        if (count <= 3)
                        {
                            lbl_upper.Text = "SORRY YOU HAD DONE A WRONG ATTEMPT";
                            lbl_middle.Text = "Please Re-Insert The PIN-CODE";
                            txtb_input.Text = "";
                            count++;
                        }

                        else
                        {
                            flag = 4;
                        }
                    }
                }

                else if (flag == 3)
                {
                    pic_swipe.Visible = false;
                    lbl_lower.Visible = true;
                    lbl_upper.Text = "Thanks to visiting here";
                    lbl_middle.Text = "Now you are ready for your further \n Transaction with Details \n";
                    lbl_lower.Text = "Name:" + " " + lbl_name.Text + "\n" + "accont no:" + lbl_acc.Text;
                }

                else if (flag == 4)
                {
                    pic_swipe.Visible = false;
                    lbl_lower.Visible = true;
                    lbl_upper.Text = "You HAVE ENTERED WRONG AUTHENTICATION \nMORE THAN THRICE";
                }
            }
        }
    }
}
