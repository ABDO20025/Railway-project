namespace Login_Form
{
    partial class admin
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
            this.ADDbtn = new System.Windows.Forms.Button();
            this.deletbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ADDbtn
            // 
            this.ADDbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ADDbtn.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ADDbtn.Location = new System.Drawing.Point(122, 477);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(192, 74);
            this.ADDbtn.TabIndex = 0;
            this.ADDbtn.Text = "Add";
            this.ADDbtn.UseVisualStyleBackColor = false;
            // 
            // deletbtn
            // 
            this.deletbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletbtn.Location = new System.Drawing.Point(668, 476);
            this.deletbtn.Name = "deletbtn";
            this.deletbtn.Size = new System.Drawing.Size(192, 74);
            this.deletbtn.TabIndex = 1;
            this.deletbtn.Text = "Delete";
            this.deletbtn.UseVisualStyleBackColor = false;
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Black;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Updatebtn.Location = new System.Drawing.Point(405, 476);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(192, 74);
            this.Updatebtn.TabIndex = 2;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            // 
            // train
            // 
            this.train.AutoSize = true;
            this.train.Location = new System.Drawing.Point(270, 136);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(44, 16);
            this.train.TabIndex = 3;
            this.train.Text = "label1";
            this.train.Click += new System.EventHandler(this.label1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(978, 599);
            this.Controls.Add(this.train);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.deletbtn);
            this.Controls.Add(this.ADDbtn);
            this.Name = "admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_FormClosed);
            this.Load += new System.EventHandler(this.admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.Button deletbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Label train;
    }
}