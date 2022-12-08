using System.Windows.Forms;
using System;

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
            this.pintxb = new System.Windows.Forms.TextBox();
            this.citytxb = new System.Windows.Forms.TextBox();
            this.mobiletxb = new System.Windows.Forms.TextBox();
            this.statetxb = new System.Windows.Forms.TextBox();
            this.u_passtxb = new System.Windows.Forms.TextBox();
            this.cpasstxb = new System.Windows.Forms.TextBox();
            this.nametxb = new System.Windows.Forms.TextBox();
            this.user_idtxb = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.mobile_noL = new System.Windows.Forms.Label();
            this.stateL = new System.Windows.Forms.Label();
            this.pinL = new System.Windows.Forms.Label();
            this.genderL = new System.Windows.Forms.Label();
            this.nameL = new System.Windows.Forms.Label();
            this.iser_idL = new System.Windows.Forms.Label();
            this.cPassL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PassL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cityL = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DOBL = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerdob = new System.Windows.Forms.DateTimePicker();
            this.gendercmb = new System.Windows.Forms.ComboBox();
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
            // pintxb
            // 
            this.pintxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pintxb.Location = new System.Drawing.Point(751, 395);
            this.pintxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.pintxb.Multiline = true;
            this.pintxb.Name = "pintxb";
            this.pintxb.Size = new System.Drawing.Size(211, 32);
            this.pintxb.TabIndex = 9;
            this.pintxb.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // citytxb
            // 
            this.citytxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.citytxb.Location = new System.Drawing.Point(518, 396);
            this.citytxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.citytxb.Multiline = true;
            this.citytxb.Name = "citytxb";
            this.citytxb.Size = new System.Drawing.Size(211, 31);
            this.citytxb.TabIndex = 12;
            // 
            // mobiletxb
            // 
            this.mobiletxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobiletxb.Location = new System.Drawing.Point(518, 327);
            this.mobiletxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.mobiletxb.Multiline = true;
            this.mobiletxb.Name = "mobiletxb";
            this.mobiletxb.Size = new System.Drawing.Size(211, 31);
            this.mobiletxb.TabIndex = 14;
            // 
            // statetxb
            // 
            this.statetxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statetxb.Location = new System.Drawing.Point(751, 326);
            this.statetxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.statetxb.Multiline = true;
            this.statetxb.Name = "statetxb";
            this.statetxb.Size = new System.Drawing.Size(211, 32);
            this.statetxb.TabIndex = 13;
            // 
            // u_passtxb
            // 
            this.u_passtxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.u_passtxb.Location = new System.Drawing.Point(518, 469);
            this.u_passtxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.u_passtxb.Multiline = true;
            this.u_passtxb.Name = "u_passtxb";
            this.u_passtxb.Size = new System.Drawing.Size(211, 31);
            this.u_passtxb.TabIndex = 16;
            // 
            // cpasstxb
            // 
            this.cpasstxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpasstxb.Location = new System.Drawing.Point(751, 468);
            this.cpasstxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.cpasstxb.Multiline = true;
            this.cpasstxb.Name = "cpasstxb";
            this.cpasstxb.Size = new System.Drawing.Size(211, 32);
            this.cpasstxb.TabIndex = 15;
            // 
            // nametxb
            // 
            this.nametxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxb.Location = new System.Drawing.Point(518, 190);
            this.nametxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.nametxb.Multiline = true;
            this.nametxb.Name = "nametxb";
            this.nametxb.Size = new System.Drawing.Size(211, 31);
            this.nametxb.TabIndex = 18;
            this.nametxb.TextChanged += new System.EventHandler(this.fname_TextChanged);
            // 
            // user_idtxb
            // 
            this.user_idtxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_idtxb.Location = new System.Drawing.Point(751, 189);
            this.user_idtxb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.user_idtxb.Multiline = true;
            this.user_idtxb.Name = "user_idtxb";
            this.user_idtxb.Size = new System.Drawing.Size(211, 32);
            this.user_idtxb.TabIndex = 17;
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
            // mobile_noL
            // 
            this.mobile_noL.AutoSize = true;
            this.mobile_noL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile_noL.Location = new System.Drawing.Point(514, 299);
            this.mobile_noL.Name = "mobile_noL";
            this.mobile_noL.Size = new System.Drawing.Size(137, 21);
            this.mobile_noL.TabIndex = 20;
            this.mobile_noL.Text = "Phone Number";
            // 
            // stateL
            // 
            this.stateL.AutoSize = true;
            this.stateL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateL.Location = new System.Drawing.Point(747, 299);
            this.stateL.Name = "stateL";
            this.stateL.Size = new System.Drawing.Size(55, 21);
            this.stateL.TabIndex = 21;
            this.stateL.Text = "State";
            // 
            // pinL
            // 
            this.pinL.AutoSize = true;
            this.pinL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinL.Location = new System.Drawing.Point(747, 367);
            this.pinL.Name = "pinL";
            this.pinL.Size = new System.Drawing.Size(37, 21);
            this.pinL.TabIndex = 22;
            this.pinL.Text = "Pin";
            this.pinL.Click += new System.EventHandler(this.label3_Click);
            // 
            // genderL
            // 
            this.genderL.AutoSize = true;
            this.genderL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderL.Location = new System.Drawing.Point(514, 231);
            this.genderL.Name = "genderL";
            this.genderL.Size = new System.Drawing.Size(72, 21);
            this.genderL.TabIndex = 23;
            this.genderL.Text = "Gender";
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameL.Location = new System.Drawing.Point(514, 162);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(59, 21);
            this.nameL.TabIndex = 24;
            this.nameL.Text = "Name";
            this.nameL.Click += new System.EventHandler(this.label5_Click);
            // 
            // iser_idL
            // 
            this.iser_idL.AutoSize = true;
            this.iser_idL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iser_idL.Location = new System.Drawing.Point(747, 162);
            this.iser_idL.Name = "iser_idL";
            this.iser_idL.Size = new System.Drawing.Size(103, 21);
            this.iser_idL.TabIndex = 25;
            this.iser_idL.Text = "User Name";
            this.iser_idL.Click += new System.EventHandler(this.label6_Click);
            // 
            // cPassL
            // 
            this.cPassL.AutoSize = true;
            this.cPassL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cPassL.Location = new System.Drawing.Point(747, 439);
            this.cPassL.Name = "cPassL";
            this.cPassL.Size = new System.Drawing.Size(166, 21);
            this.cPassL.TabIndex = 27;
            this.cPassL.Text = "Confirm Password";
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
            // PassL
            // 
            this.PassL.AutoSize = true;
            this.PassL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassL.Location = new System.Drawing.Point(514, 439);
            this.PassL.Name = "PassL";
            this.PassL.Size = new System.Drawing.Size(93, 21);
            this.PassL.TabIndex = 29;
            this.PassL.Text = "Password";
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
            // cityL
            // 
            this.cityL.AutoSize = true;
            this.cityL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityL.Location = new System.Drawing.Point(514, 367);
            this.cityL.Name = "cityL";
            this.cityL.Size = new System.Drawing.Size(43, 21);
            this.cityL.TabIndex = 31;
            this.cityL.Text = "City";
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
            // DOBL
            // 
            this.DOBL.AutoSize = true;
            this.DOBL.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBL.Location = new System.Drawing.Point(747, 231);
            this.DOBL.Name = "DOBL";
            this.DOBL.Size = new System.Drawing.Size(122, 21);
            this.DOBL.TabIndex = 33;
            this.DOBL.Text = "Date Of Birth";
            this.DOBL.Click += new System.EventHandler(this.label13_Click);
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
            this.dateTimePickerdob.Location = new System.Drawing.Point(751, 265);
            this.dateTimePickerdob.MaxDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdob.Name = "dateTimePickerdob";
            this.dateTimePickerdob.Size = new System.Drawing.Size(211, 22);
            this.dateTimePickerdob.TabIndex = 34;
            this.dateTimePickerdob.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // gendercmb
            // 
            this.gendercmb.FormattingEnabled = true;
            this.gendercmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercmb.Location = new System.Drawing.Point(518, 265);
            this.gendercmb.Name = "gendercmb";
            this.gendercmb.Size = new System.Drawing.Size(211, 24);
            this.gendercmb.TabIndex = 35;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(978, 599);
            this.Controls.Add(this.gendercmb);
            this.Controls.Add(this.dateTimePickerdob);
            this.Controls.Add(this.DOBL);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cityL);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PassL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cPassL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.iser_idL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.genderL);
            this.Controls.Add(this.pinL);
            this.Controls.Add(this.stateL);
            this.Controls.Add(this.mobile_noL);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.nametxb);
            this.Controls.Add(this.user_idtxb);
            this.Controls.Add(this.u_passtxb);
            this.Controls.Add(this.cpasstxb);
            this.Controls.Add(this.mobiletxb);
            this.Controls.Add(this.statetxb);
            this.Controls.Add(this.citytxb);
            this.Controls.Add(this.pintxb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup);
            this.MaximizeBox = false;
            this.Name = "register";
            this.Text = "register";
            this.TransparencyKey = System.Drawing.Color.DarkMagenta;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.register_FormClosed);
            this.Load += new System.EventHandler(this.sig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.TextBox pintxb;
        private System.Windows.Forms.TextBox citytxb;
        private System.Windows.Forms.TextBox mobiletxb;
        private System.Windows.Forms.TextBox statetxb;
        private System.Windows.Forms.TextBox u_passtxb;
        private System.Windows.Forms.TextBox cpasstxb;
        private System.Windows.Forms.TextBox nametxb;
        private System.Windows.Forms.TextBox user_idtxb;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label mobile_noL;
        private System.Windows.Forms.Label stateL;
        private System.Windows.Forms.Label pinL;
        private System.Windows.Forms.Label genderL;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label iser_idL;
        private System.Windows.Forms.Label cPassL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PassL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cityL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label DOBL;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dateTimePickerdob;
        private ComboBox gendercmb;
    }
}