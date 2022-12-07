namespace Login_Form
{
    partial class login
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
            System.Windows.Forms.Button btnlogin;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.mail_txb = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.passlabel = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            btnlogin.BackColor = System.Drawing.Color.Black;
            btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            btnlogin.FlatAppearance.BorderSize = 30;
            btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnlogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnlogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnlogin.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnlogin.Location = new System.Drawing.Point(753, 354);
            btnlogin.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            btnlogin.Name = "btnlogin";
            btnlogin.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            btnlogin.Size = new System.Drawing.Size(171, 48);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Sign In";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(594, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(793, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(696, 179);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(63, 21);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "E-mail";
            this.usernamelabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // mail_txb
            // 
            this.mail_txb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mail_txb.Location = new System.Drawing.Point(701, 220);
            this.mail_txb.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.mail_txb.Name = "mail_txb";
            this.mail_txb.Size = new System.Drawing.Size(287, 22);
            this.mail_txb.TabIndex = 3;
            this.mail_txb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxpass
            // 
            this.textBoxpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxpass.Location = new System.Drawing.Point(701, 300);
            this.textBoxpass.Margin = new System.Windows.Forms.Padding(114, 100, 114, 100);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.PasswordChar = '*';
            this.textBoxpass.Size = new System.Drawing.Size(287, 22);
            this.textBoxpass.TabIndex = 5;
            this.textBoxpass.Tag = "";
            this.textBoxpass.TextChanged += new System.EventHandler(this.textBoxpass_TextChanged);
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlabel.Location = new System.Drawing.Point(696, 262);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(93, 21);
            this.passlabel.TabIndex = 4;
            this.passlabel.Text = "Password";
            this.passlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(807, 456);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(75, 23);
            this.register.TabIndex = 7;
            this.register.Text = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(1118, 599);
            this.Controls.Add(this.register);
            this.Controls.Add(btnlogin);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.mail_txb);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox mail_txb;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Button register;
    }
}

