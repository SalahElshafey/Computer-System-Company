namespace projectFinal
{
    partial class Employee_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bckbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.namebtn = new System.Windows.Forms.Label();
            this.Pricebtn = new System.Windows.Forms.Label();
            this.Itemname = new System.Windows.Forms.TextBox();
            this.itemprice = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.searchbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bckbtn
            // 
            this.bckbtn.Image = ((System.Drawing.Image)(resources.GetObject("bckbtn.Image")));
            this.bckbtn.Location = new System.Drawing.Point(1, 1);
            this.bckbtn.Name = "bckbtn";
            this.bckbtn.Size = new System.Drawing.Size(75, 59);
            this.bckbtn.TabIndex = 1;
            this.bckbtn.UseVisualStyleBackColor = true;
            this.bckbtn.Click += new System.EventHandler(this.bckbtn_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(726, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namebtn
            // 
            this.namebtn.AutoSize = true;
            this.namebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebtn.Location = new System.Drawing.Point(24, 164);
            this.namebtn.Name = "namebtn";
            this.namebtn.Size = new System.Drawing.Size(101, 20);
            this.namebtn.TabIndex = 10;
            this.namebtn.Text = "ItemName: ";
            // 
            // Pricebtn
            // 
            this.Pricebtn.AutoSize = true;
            this.Pricebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricebtn.Location = new System.Drawing.Point(71, 245);
            this.Pricebtn.Name = "Pricebtn";
            this.Pricebtn.Size = new System.Drawing.Size(54, 20);
            this.Pricebtn.TabIndex = 11;
            this.Pricebtn.Text = "Price:";
            this.Pricebtn.Click += new System.EventHandler(this.Pricebtn_Click);
            // 
            // Itemname
            // 
            this.Itemname.Location = new System.Drawing.Point(131, 166);
            this.Itemname.Name = "Itemname";
            this.Itemname.Size = new System.Drawing.Size(134, 20);
            this.Itemname.TabIndex = 12;
            this.Itemname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // itemprice
            // 
            this.itemprice.Location = new System.Drawing.Point(131, 245);
            this.itemprice.Name = "itemprice";
            this.itemprice.Size = new System.Drawing.Size(134, 20);
            this.itemprice.TabIndex = 13;
            this.itemprice.TextChanged += new System.EventHandler(this.itemprice_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(493, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 14;
            // 
            // searchbt
            // 
            this.searchbt.Image = ((System.Drawing.Image)(resources.GetObject("searchbt.Image")));
            this.searchbt.Location = new System.Drawing.Point(742, 136);
            this.searchbt.Name = "searchbt";
            this.searchbt.Size = new System.Drawing.Size(46, 23);
            this.searchbt.TabIndex = 15;
            this.searchbt.UseVisualStyleBackColor = true;
            this.searchbt.Click += new System.EventHandler(this.searchbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Remove Item";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(228, 310);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 49);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(343, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 49);
            this.button4.TabIndex = 20;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Salah: 1500",
            "Meligi ",
            "Ahmed Amr"});
            this.listBox1.Location = new System.Drawing.Point(493, 166);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 238);
            this.listBox1.TabIndex = 21;
            // 
            // Employee_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.itemprice);
            this.Controls.Add(this.Itemname);
            this.Controls.Add(this.Pricebtn);
            this.Controls.Add(this.namebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bckbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Employee_2";
            this.Text = "Employee_2";
            this.Load += new System.EventHandler(this.Employee_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bckbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label namebtn;
        private System.Windows.Forms.Label Pricebtn;
        private System.Windows.Forms.TextBox Itemname;
        private System.Windows.Forms.TextBox itemprice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button searchbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listBox1;
    }
}