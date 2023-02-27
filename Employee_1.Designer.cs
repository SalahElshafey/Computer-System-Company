namespace projectFinal
{
    partial class Employee_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_1));
            this.bckbtn = new System.Windows.Forms.Button();
            this.namebtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextId = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bckbtn
            // 
            this.bckbtn.Image = ((System.Drawing.Image)(resources.GetObject("bckbtn.Image")));
            this.bckbtn.Location = new System.Drawing.Point(12, 12);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(75, 59);
            this.bckbtn.TabIndex = 0;
            this.bckbtn.UseVisualStyleBackColor = true;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // namebtn
            // 
            this.namebtn.AutoSize = true;
            this.namebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebtn.Location = new System.Drawing.Point(197, 174);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(98, 20);
            this.namebtn.TabIndex = 1;
            this.namebtn.Text = "UserName:";
            this.namebtn.Click += new System.EventHandler(this.namebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextId
            // 
            this.TextId.Location = new System.Drawing.Point(313, 176);
            this.TextId.Name = "TextId";
            this.TextId.Size = new System.Drawing.Size(320, 20);
            this.TextId.TabIndex = 4;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(313, 247);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(320, 20);
            this.TextPassword.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 78);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signbtn
            // 
            this.signbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signbtn.Location = new System.Drawing.Point(357, 323);
            this.signbtn.Name = "signbtn";
            this.signbtn.Size = new System.Drawing.Size(134, 50);
            this.signbtn.TabIndex = 7;
            this.signbtn.Text = "Sign in";
            this.signbtn.UseVisualStyleBackColor = true;
            this.signbtn.Click += new System.EventHandler(this.signbtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(713, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Employee_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.signbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebtn);
            this.Controls.Add(this.bckbtn);
            this.Name = "Employee_1";
            this.Text = "Employee_1";
            this.Load += new System.EventHandler(this.Employee_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bckbtn;
        private System.Windows.Forms.Label namebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextId;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button signbtn;
        private System.Windows.Forms.Button button1;
    }
}