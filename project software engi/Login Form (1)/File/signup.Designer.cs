namespace Login_Form
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.signup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.address = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.SSn = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.cpass = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.maillbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.genderlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cPasslbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.idlbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DOBlbl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.Black;
            this.signup.ForeColor = System.Drawing.Color.Transparent;
            this.signup.Location = new System.Drawing.Point(678, 538);
            this.signup.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(119, 44);
            this.signup.TabIndex = 0;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(499, 605);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Location = new System.Drawing.Point(751, 255);
            this.address.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(211, 32);
            this.address.TabIndex = 9;
            this.address.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // gender
            // 
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gender.Location = new System.Drawing.Point(518, 256);
            this.gender.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.gender.Multiline = true;
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(211, 31);
            this.gender.TabIndex = 10;
            this.gender.TextChanged += new System.EventHandler(this.gender_TextChanged);
            // 
            // SSn
            // 
            this.SSn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SSn.Location = new System.Drawing.Point(518, 396);
            this.SSn.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.SSn.Multiline = true;
            this.SSn.Name = "SSn";
            this.SSn.Size = new System.Drawing.Size(211, 31);
            this.SSn.TabIndex = 12;
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Location = new System.Drawing.Point(518, 327);
            this.phone.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(211, 31);
            this.phone.TabIndex = 14;
            // 
            // mail
            // 
            this.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail.Location = new System.Drawing.Point(751, 326);
            this.mail.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.mail.Multiline = true;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(211, 32);
            this.mail.TabIndex = 13;
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Location = new System.Drawing.Point(518, 469);
            this.password.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(211, 31);
            this.password.TabIndex = 16;
            // 
            // cpass
            // 
            this.cpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpass.Location = new System.Drawing.Point(751, 468);
            this.cpass.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.cpass.Multiline = true;
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(211, 32);
            this.cpass.TabIndex = 15;
            // 
            // fname
            // 
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname.Location = new System.Drawing.Point(518, 190);
            this.fname.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(211, 31);
            this.fname.TabIndex = 18;
            this.fname.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // lname
            // 
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lname.Location = new System.Drawing.Point(751, 189);
            this.lname.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.lname.Multiline = true;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(211, 32);
            this.lname.TabIndex = 17;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(514, 162);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(0, 21);
            this.usernamelabel.TabIndex = 19;
            this.usernamelabel.Click += new System.EventHandler(this.usernamelabel_Click);
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.Location = new System.Drawing.Point(514, 299);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(137, 21);
            this.phonelbl.TabIndex = 20;
            this.phonelbl.Text = "Phone Number";
            // 
            // maillbl
            // 
            this.maillbl.AutoSize = true;
            this.maillbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maillbl.Location = new System.Drawing.Point(747, 299);
            this.maillbl.Name = "maillbl";
            this.maillbl.Size = new System.Drawing.Size(63, 21);
            this.maillbl.TabIndex = 21;
            this.maillbl.Text = "E-mail";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(747, 231);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(77, 21);
            this.addresslbl.TabIndex = 22;
            this.addresslbl.Text = "address";
            this.addresslbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(514, 231);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(72, 21);
            this.genderlabel.TabIndex = 23;
            this.genderlabel.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "First Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(747, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Last Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cPasslbl
            // 
            this.cPasslbl.AutoSize = true;
            this.cPasslbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPasslbl.Location = new System.Drawing.Point(747, 439);
            this.cPasslbl.Name = "cPasslbl";
            this.cPasslbl.Size = new System.Drawing.Size(166, 21);
            this.cPasslbl.TabIndex = 27;
            this.cPasslbl.Text = "Confirm Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 21);
            this.label8.TabIndex = 26;
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.Location = new System.Drawing.Point(514, 439);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(93, 21);
            this.Passlbl.TabIndex = 29;
            this.Passlbl.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 21);
            this.label10.TabIndex = 28;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.Location = new System.Drawing.Point(514, 367);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(108, 21);
            this.idlbl.TabIndex = 31;
            this.idlbl.Text = "National ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(454, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 30;
            // 
            // DOBlbl
            // 
            this.DOBlbl.AutoSize = true;
            this.DOBlbl.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBlbl.Location = new System.Drawing.Point(747, 367);
            this.DOBlbl.Name = "DOBlbl";
            this.DOBlbl.Size = new System.Drawing.Size(122, 21);
            this.DOBlbl.TabIndex = 33;
            this.DOBlbl.Text = "Date Of Birth";
            this.DOBlbl.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(747, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 32;
            // 
            // dateTimePickerdob
            // 
            this.dateTimePickerdob.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerdob.CalendarTitleForeColor = System.Drawing.Color.Aqua;
            this.dateTimePickerdob.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerdob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerdob.Location = new System.Drawing.Point(751, 401);
            this.dateTimePickerdob.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerdob.TabIndex = 34;
            this.dateTimePickerdob.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdob.ValueChanged += new System.EventHandler(this.dateTimePickerdob_ValueChanged);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(978, 599);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.DOBlbl);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.idlbl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cPasslbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genderlabel);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.maillbl);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.SSn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup);
            this.Name = "register";
            this.Text = "register";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.register_FormClosed);
            this.Load += new System.EventHandler(this.sig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox SSn;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label maillbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cPasslbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DOBlbl;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dateTimePickerdob;
    }
}