namespace Assignment3._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            this.add = new Button();
            this.delete = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            studentid = new Label();
            this.firstName = new Label();
            this.lastName = new Label();
            this.address = new Label();
            this.monthOfAd = new Label();
            grade = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, -12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(527, 751);
            dataGridView1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new Point(822, 66);
            this.add.Name = "add";
            this.add.Size = new Size(162, 79);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new Point(822, 174);
            this.delete.Name = "delete";
            this.delete.Size = new Size(162, 79);
            this.delete.TabIndex = 2;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(562, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(562, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(562, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 23);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(562, 321);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(205, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(562, 404);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(205, 23);
            textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(562, 509);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(205, 23);
            textBox6.TabIndex = 8;
            // 
            // studentid
            // 
            studentid.AutoSize = true;
            studentid.Location = new Point(646, 98);
            studentid.Name = "studentid";
            studentid.Size = new Size(57, 15);
            studentid.TabIndex = 9;
            studentid.Text = "studentid";
            studentid.Click += label1_Click;
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new Point(646, 184);
            this.firstName.Name = "firstName";
            this.firstName.Size = new Size(59, 15);
            this.firstName.TabIndex = 10;
            this.firstName.Text = "firstName";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new Point(646, 268);
            this.lastName.Name = "lastName";
            this.lastName.Size = new Size(57, 15);
            this.lastName.TabIndex = 11;
            this.lastName.Text = "lastName";
            this.lastName.Click += this.label3_Click;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new Point(646, 360);
            this.address.Name = "address";
            this.address.Size = new Size(47, 15);
            this.address.TabIndex = 12;
            this.address.Text = "address";
            // 
            // monthOfAd
            // 
            this.monthOfAd.AutoSize = true;
            this.monthOfAd.Location = new Point(608, 449);
            this.monthOfAd.Name = "monthOfAd";
            this.monthOfAd.Size = new Size(118, 15);
            this.monthOfAd.TabIndex = 13;
            this.monthOfAd.Text = "Month Of Admission";
            // 
            // grade
            // 
            grade.AutoSize = true;
            grade.Location = new Point(646, 557);
            grade.Name = "grade";
            grade.Size = new Size(37, 15);
            grade.TabIndex = 14;
            grade.Text = "grade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 766);
            Controls.Add(grade);
            Controls.Add(this.monthOfAd);
            Controls.Add(this.address);
            Controls.Add(this.lastName);
            Controls.Add(this.firstName);
            Controls.Add(studentid);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(this.delete);
            Controls.Add(this.add);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label studentid;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label grade;
    }
}
