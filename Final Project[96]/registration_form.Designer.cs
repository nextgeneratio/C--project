namespace Employee_Management_System
{
    partial class registration_form
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
            this.logout_link = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.registration = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.employee_type = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.deparment_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.home_no = new System.Windows.Forms.TextBox();
            this.mobile_no = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_link = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Employee";
            // 
            // logout_link
            // 
            this.logout_link.AutoSize = true;
            this.logout_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_link.Location = new System.Drawing.Point(12, 41);
            this.logout_link.Name = "logout_link";
            this.logout_link.Size = new System.Drawing.Size(54, 16);
            this.logout_link.TabIndex = 1;
            this.logout_link.TabStop = true;
            this.logout_link.Text = "Logout";
            this.logout_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_link_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.clear);
            this.groupBox1.Controls.Add(this.update);
            this.groupBox1.Controls.Add(this.registration);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 639);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Registration";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(393, 599);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 34);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(312, 599);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 34);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(117, 599);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 34);
            this.update.TabIndex = 7;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // registration
            // 
            this.registration.Location = new System.Drawing.Point(9, 599);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(100, 34);
            this.registration.TabIndex = 6;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = true;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.employee_type);
            this.groupBox4.Controls.Add(this.designation);
            this.groupBox4.Controls.Add(this.deparment_name);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 492);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 101);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Department Detail";
            // 
            // employee_type
            // 
            this.employee_type.Location = new System.Drawing.Point(192, 73);
            this.employee_type.Name = "employee_type";
            this.employee_type.Size = new System.Drawing.Size(131, 22);
            this.employee_type.TabIndex = 5;
            this.employee_type.TextChanged += new System.EventHandler(this.employee_type_TextChanged);
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(192, 49);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(131, 22);
            this.designation.TabIndex = 4;
            this.designation.TextChanged += new System.EventHandler(this.designation_TextChanged);
            // 
            // deparment_name
            // 
            this.deparment_name.Location = new System.Drawing.Point(192, 21);
            this.deparment_name.Name = "deparment_name";
            this.deparment_name.Size = new System.Drawing.Size(258, 22);
            this.deparment_name.TabIndex = 3;
            this.deparment_name.TextChanged += new System.EventHandler(this.deparment_name_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Employee Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Designation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Deparment Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.home_no);
            this.groupBox3.Controls.Add(this.mobile_no);
            this.groupBox3.Controls.Add(this.email);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.address);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(6, 280);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // home_no
            // 
            this.home_no.Location = new System.Drawing.Point(329, 170);
            this.home_no.Name = "home_no";
            this.home_no.Size = new System.Drawing.Size(121, 22);
            this.home_no.TabIndex = 9;
            // 
            // mobile_no
            // 
            this.mobile_no.Location = new System.Drawing.Point(111, 167);
            this.mobile_no.Name = "mobile_no";
            this.mobile_no.Size = new System.Drawing.Size(100, 22);
            this.mobile_no.TabIndex = 8;
            this.mobile_no.TextChanged += new System.EventHandler(this.mobile_no_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(192, 118);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(258, 22);
            this.email.TabIndex = 7;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Home phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Mobile Phone";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(192, 21);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(258, 64);
            this.address.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.last_name);
            this.groupBox2.Controls.Add(this.first_name);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 197);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(373, 162);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(77, 20);
            this.female.TabIndex = 8;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(192, 166);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(59, 20);
            this.male.TabIndex = 7;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(192, 74);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(258, 22);
            this.last_name.TabIndex = 5;
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(192, 31);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(258, 22);
            this.first_name.TabIndex = 4;
            this.first_name.TextChanged += new System.EventHandler(this.first_name_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date of Birth";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee No";
            // 
            // exit_link
            // 
            this.exit_link.AutoSize = true;
            this.exit_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_link.Location = new System.Drawing.Point(451, 724);
            this.exit_link.Name = "exit_link";
            this.exit_link.Size = new System.Drawing.Size(32, 16);
            this.exit_link.TabIndex = 3;
            this.exit_link.TabStop = true;
            this.exit_link.Text = "Exit";
            this.exit_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.exit_link_LinkClicked);
            // 
            // registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 749);
            this.Controls.Add(this.exit_link);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logout_link);
            this.Controls.Add(this.label1);
            this.Name = "registration_form";
            this.Text = "ABC Cooperation";
            this.Load += new System.EventHandler(this.registration_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel logout_link;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button registration;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox employee_type;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox deparment_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox home_no;
        private System.Windows.Forms.TextBox mobile_no;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.LinkLabel exit_link;
    }
}