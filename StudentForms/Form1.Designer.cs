namespace StudentForms
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
            add = new Button();
            delete = new Button();
            studentId = new TextBox();
            firstName = new TextBox();
            lastName = new TextBox();
            address = new TextBox();
            this.cmoa = new ComboBox();
            cgrade = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(323, 734);
            dataGridView1.TabIndex = 0;
            // 
            // add
            // 
            add.Location = new Point(731, 66);
            add.Name = "add";
            add.Size = new Size(75, 23);
            add.TabIndex = 1;
            add.Text = "add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click_1;
            // 
            // delete
            // 
            delete.Location = new Point(731, 336);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // studentId
            // 
            studentId.Location = new Point(427, 67);
            studentId.Name = "studentId";
            studentId.Size = new Size(100, 23);
            studentId.TabIndex = 3;
            studentId.Text = "studentId";
            studentId.TextChanged += studentId_TextChanged;
            // 
            // firstName
            // 
            firstName.Location = new Point(427, 135);
            firstName.Name = "firstName";
            firstName.Size = new Size(100, 23);
            firstName.TabIndex = 4;
            firstName.Text = "firstName";
            // 
            // lastName
            // 
            lastName.Location = new Point(427, 216);
            lastName.Name = "lastName";
            lastName.Size = new Size(100, 23);
            lastName.TabIndex = 5;
            lastName.Text = "lastName";
            // 
            // address
            // 
            address.Location = new Point(427, 297);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 6;
            address.Text = "address";
            // 
            // cmoa
            // 
            this.cmoa.FormattingEnabled = true;
            this.cmoa.Location = new Point(427, 409);
            this.cmoa.Name = "cmoa";
            this.cmoa.Size = new Size(121, 23);
            this.cmoa.TabIndex = 7;
            this.cmoa.Text = "Month of Admission";
            this.cmoa.SelectedIndexChanged += this.moa_SelectedIndexChanged;
            // 
            // cgrade
            // 
            cgrade.FormattingEnabled = true;
            cgrade.Location = new Point(427, 568);
            cgrade.Name = "cgrade";
            cgrade.Size = new Size(121, 23);
            cgrade.TabIndex = 8;
            cgrade.Text = "Grade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 786);
            Controls.Add(cgrade);
            Controls.Add(this.cmoa);
            Controls.Add(address);
            Controls.Add(lastName);
            Controls.Add(firstName);
            Controls.Add(studentId);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button add;
        private Button delete;
        private TextBox studentId;
        private TextBox firstName;
        private TextBox lastName;
        private TextBox address;
        private ComboBox moa;
        private ComboBox cgrade;
    }
}
