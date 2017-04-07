namespace Fingerprint_Authentication
{
    partial class Registration_Advance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.chkb_finger_option = new System.Windows.Forms.CheckBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_acc = new System.Windows.Forms.TextBox();
            this.lbl_finger_option = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_enroll = new System.Windows.Forms.Label();
            this.txt_finger = new System.Windows.Forms.TextBox();
            this.btn_enroll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(414, 385);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 23;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(495, 385);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 22;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(331, 386);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 21;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // chkb_finger_option
            // 
            this.chkb_finger_option.AutoSize = true;
            this.chkb_finger_option.Location = new System.Drawing.Point(331, 90);
            this.chkb_finger_option.Name = "chkb_finger_option";
            this.chkb_finger_option.Size = new System.Drawing.Size(195, 17);
            this.chkb_finger_option.TabIndex = 20;
            this.chkb_finger_option.Text = "(Check if you want to add a feature)";
            this.chkb_finger_option.UseVisualStyleBackColor = true;
            this.chkb_finger_option.CheckedChanged += new System.EventHandler(this.chkb_finger_option_CheckedChanged);
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(331, 259);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(240, 20);
            this.txt_pin.TabIndex = 19;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(331, 203);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 20);
            this.txt_name.TabIndex = 18;
            // 
            // txt_acc
            // 
            this.txt_acc.Location = new System.Drawing.Point(331, 143);
            this.txt_acc.Name = "txt_acc";
            this.txt_acc.Size = new System.Drawing.Size(240, 20);
            this.txt_acc.TabIndex = 17;
            // 
            // lbl_finger_option
            // 
            this.lbl_finger_option.AutoSize = true;
            this.lbl_finger_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finger_option.Location = new System.Drawing.Point(45, 90);
            this.lbl_finger_option.Name = "lbl_finger_option";
            this.lbl_finger_option.Size = new System.Drawing.Size(140, 17);
            this.lbl_finger_option.TabIndex = 16;
            this.lbl_finger_option.Text = "Fingerprint Security *";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pin.Location = new System.Drawing.Point(45, 262);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(76, 17);
            this.lbl_pin.TabIndex = 15;
            this.lbl_pin.Text = "PIN Code *";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(45, 206);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 17);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name *";
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acc.Location = new System.Drawing.Point(45, 146);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(122, 17);
            this.lbl_acc.TabIndex = 13;
            this.lbl_acc.Text = "Account Number *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fingerprint Authentication Registration Form";
            // 
            // lbl_enroll
            // 
            this.lbl_enroll.AutoSize = true;
            this.lbl_enroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enroll.Location = new System.Drawing.Point(452, 329);
            this.lbl_enroll.Name = "lbl_enroll";
            this.lbl_enroll.Size = new System.Drawing.Size(118, 17);
            this.lbl_enroll.TabIndex = 24;
            this.lbl_enroll.Text = "Finger is Enrolled";
            // 
            // txt_finger
            // 
            this.txt_finger.Location = new System.Drawing.Point(495, 349);
            this.txt_finger.Name = "txt_finger";
            this.txt_finger.Size = new System.Drawing.Size(76, 20);
            this.txt_finger.TabIndex = 25;
            // 
            // btn_enroll
            // 
            this.btn_enroll.Location = new System.Drawing.Point(48, 329);
            this.btn_enroll.Name = "btn_enroll";
            this.btn_enroll.Size = new System.Drawing.Size(358, 23);
            this.btn_enroll.TabIndex = 26;
            this.btn_enroll.Text = "Enroll Finger";
            this.btn_enroll.UseVisualStyleBackColor = true;
            this.btn_enroll.Click += new System.EventHandler(this.btn_enroll_Click);
            // 
            // Registration_Advance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 433);
            this.Controls.Add(this.btn_enroll);
            this.Controls.Add(this.txt_finger);
            this.Controls.Add(this.lbl_enroll);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.chkb_finger_option);
            this.Controls.Add(this.txt_pin);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_acc);
            this.Controls.Add(this.lbl_finger_option);
            this.Controls.Add(this.lbl_pin);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_acc);
            this.Controls.Add(this.label1);
            this.Name = "Registration_Advance";
            this.Text = "Registration_Advance";
            this.Load += new System.EventHandler(this.Registration_Advance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.CheckBox chkb_finger_option;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_acc;
        private System.Windows.Forms.Label lbl_finger_option;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_enroll;
        private System.Windows.Forms.TextBox txt_finger;
        private System.Windows.Forms.Button btn_enroll;

    }
}