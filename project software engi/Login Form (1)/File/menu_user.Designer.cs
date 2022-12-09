namespace Login_Form
{
    partial class menu_user
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
            this.reservationsbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservationsbtn
            // 
            this.reservationsbtn.Location = new System.Drawing.Point(520, 32);
            this.reservationsbtn.Name = "reservationsbtn";
            this.reservationsbtn.Size = new System.Drawing.Size(102, 57);
            this.reservationsbtn.TabIndex = 0;
            this.reservationsbtn.Text = "Reservations";
            this.reservationsbtn.UseVisualStyleBackColor = true;
            this.reservationsbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(662, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(662, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // menu_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reservationsbtn);
            this.Name = "menu_user";
            this.Text = "menu_user";
            this.Load += new System.EventHandler(this.menu_user_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservationsbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}