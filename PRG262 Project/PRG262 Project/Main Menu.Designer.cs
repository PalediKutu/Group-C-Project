namespace PRG262_Project
{
    partial class Main_Menu
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stdNumber = new System.Windows.Forms.TextBox();
            this.stdName = new System.Windows.Forms.TextBox();
            this.stdSurname = new System.Windows.Forms.TextBox();
            this.phoneNo = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.genderbox = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stdImage = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.crsName = new System.Windows.Forms.TextBox();
            this.crsDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(666, 556);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add student ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSD
            // 
            this.btnSD.Location = new System.Drawing.Point(778, 591);
            this.btnSD.Name = "btnSD";
            this.btnSD.Size = new System.Drawing.Size(105, 37);
            this.btnSD.TabIndex = 1;
            this.btnSD.Text = "Delete/Search";
            this.btnSD.UseVisualStyleBackColor = true;
            this.btnSD.Click += new System.EventHandler(this.btnSD_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Display";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Birth ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Course Code";
            // 
            // stdNumber
            // 
            this.stdNumber.Location = new System.Drawing.Point(156, 26);
            this.stdNumber.Name = "stdNumber";
            this.stdNumber.Size = new System.Drawing.Size(232, 22);
            this.stdNumber.TabIndex = 12;
            // 
            // stdName
            // 
            this.stdName.Location = new System.Drawing.Point(156, 54);
            this.stdName.Name = "stdName";
            this.stdName.Size = new System.Drawing.Size(232, 22);
            this.stdName.TabIndex = 13;
            // 
            // stdSurname
            // 
            this.stdSurname.Location = new System.Drawing.Point(156, 82);
            this.stdSurname.Name = "stdSurname";
            this.stdSurname.Size = new System.Drawing.Size(232, 22);
            this.stdSurname.TabIndex = 14;
            // 
            // phoneNo
            // 
            this.phoneNo.Location = new System.Drawing.Point(147, 331);
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.Size = new System.Drawing.Size(232, 22);
            this.phoneNo.TabIndex = 15;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(147, 364);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(232, 22);
            this.addressBox.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 263);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // genderbox
            // 
            this.genderbox.FormattingEnabled = true;
            this.genderbox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderbox.Location = new System.Drawing.Point(147, 294);
            this.genderbox.Name = "genderbox";
            this.genderbox.Size = new System.Drawing.Size(159, 24);
            this.genderbox.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(889, 556);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 37);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(513, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 513);
            this.dataGridView1.TabIndex = 20;
            // 
            // stdImage
            // 
            this.stdImage.Location = new System.Drawing.Point(156, 127);
            this.stdImage.Name = "stdImage";
            this.stdImage.Size = new System.Drawing.Size(232, 107);
            this.stdImage.TabIndex = 22;
            this.stdImage.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Course Nmae";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Course Description";
            // 
            // crsName
            // 
            this.crsName.Location = new System.Drawing.Point(156, 63);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(232, 22);
            this.crsName.TabIndex = 25;
            // 
            // crsDescription
            // 
            this.crsDescription.Location = new System.Drawing.Point(156, 94);
            this.crsDescription.Name = "crsDescription";
            this.crsDescription.Size = new System.Drawing.Size(232, 22);
            this.crsDescription.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.courseBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.crsDescription);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.crsName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(21, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 135);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Info";
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Items.AddRange(new object[] {
            "BIT",
            "Bcom",
            "Dip"});
            this.courseBox.Location = new System.Drawing.Point(156, 27);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(159, 24);
            this.courseBox.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.stdImage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addressBox);
            this.groupBox2.Controls.Add(this.genderbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.phoneNo);
            this.groupBox2.Controls.Add(this.stdNumber);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.stdName);
            this.groupBox2.Controls.Add(this.stdSurname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 430);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Info";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSD);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox stdNumber;
        private System.Windows.Forms.TextBox stdName;
        private System.Windows.Forms.TextBox stdSurname;
        private System.Windows.Forms.TextBox phoneNo;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox genderbox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox stdImage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox crsName;
        private System.Windows.Forms.TextBox crsDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}