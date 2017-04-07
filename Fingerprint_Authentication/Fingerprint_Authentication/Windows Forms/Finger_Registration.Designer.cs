namespace Fingerprint_Authentication
{
    partial class Finger_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_acc = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pin = new System.Windows.Forms.Label();
            this.lbl_finger_option = new System.Windows.Forms.Label();
            this.txt_acc = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pin = new System.Windows.Forms.TextBox();
            this.chkb_finger_option = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fingerprint Authentication Registration Form";
            // 
            // lbl_acc
            // 
            this.lbl_acc.AutoSize = true;
            this.lbl_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_acc.Location = new System.Drawing.Point(48, 146);
            this.lbl_acc.Name = "lbl_acc";
            this.lbl_acc.Size = new System.Drawing.Size(122, 17);
            this.lbl_acc.TabIndex = 1;
            this.lbl_acc.Text = "Account Number *";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(48, 206);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 17);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Name *";
            // 
            // lbl_pin
            // 
            this.lbl_pin.AutoSize = true;
            this.lbl_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pin.Location = new System.Drawing.Point(48, 262);
            this.lbl_pin.Name = "lbl_pin";
            this.lbl_pin.Size = new System.Drawing.Size(76, 17);
            this.lbl_pin.TabIndex = 3;
            this.lbl_pin.Text = "PIN Code *";
            // 
            // lbl_finger_option
            // 
            this.lbl_finger_option.AutoSize = true;
            this.lbl_finger_option.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_finger_option.Location = new System.Drawing.Point(48, 90);
            this.lbl_finger_option.Name = "lbl_finger_option";
            this.lbl_finger_option.Size = new System.Drawing.Size(140, 17);
            this.lbl_finger_option.TabIndex = 4;
            this.lbl_finger_option.Text = "Fingerprint Security *";
            // 
            // txt_acc
            // 
            this.txt_acc.Location = new System.Drawing.Point(334, 143);
            this.txt_acc.Name = "txt_acc";
            this.txt_acc.Size = new System.Drawing.Size(240, 20);
            this.txt_acc.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(334, 203);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(240, 20);
            this.txt_name.TabIndex = 6;
            // 
            // txt_pin
            // 
            this.txt_pin.Location = new System.Drawing.Point(334, 259);
            this.txt_pin.Name = "txt_pin";
            this.txt_pin.Size = new System.Drawing.Size(240, 20);
            this.txt_pin.TabIndex = 7;
            // 
            // chkb_finger_option
            // 
            this.chkb_finger_option.AutoSize = true;
            this.chkb_finger_option.Location = new System.Drawing.Point(334, 90);
            this.chkb_finger_option.Name = "chkb_finger_option";
            this.chkb_finger_option.Size = new System.Drawing.Size(195, 17);
            this.chkb_finger_option.TabIndex = 8;
            this.chkb_finger_option.Text = "(Check if you want to add a feature)";
            this.chkb_finger_option.UseVisualStyleBackColor = true;
            this.chkb_finger_option.CheckedChanged += new System.EventHandler(this.chkb_finger_option_CheckedChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(334, 310);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 9;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(498, 309);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(417, 309);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 11;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // Finger_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 355);
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
            this.Name = "Finger_Registration";
            this.Text = "Finger_Registration";
            this.Load += new System.EventHandler(this.Finger_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_acc;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pin;
        private System.Windows.Forms.Label lbl_finger_option;
        private System.Windows.Forms.TextBox txt_acc;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pin;
        private System.Windows.Forms.CheckBox chkb_finger_option;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_del;
    }
}