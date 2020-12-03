namespace PresentationLayer
{
    partial class Form1
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
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxIndexNumber = new System.Windows.Forms.TextBox();
            this.TextBoxAverageMark = new System.Windows.Forms.TextBox();
            this.buttonInsertStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.Location = new System.Drawing.Point(13, 2);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(669, 251);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj Indeksa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prosecna ocena:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(45, 285);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 5;
            this.TextBoxName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxIndexNumber
            // 
            this.TextBoxIndexNumber.Location = new System.Drawing.Point(254, 285);
            this.TextBoxIndexNumber.Name = "TextBoxIndexNumber";
            this.TextBoxIndexNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBoxIndexNumber.TabIndex = 6;
            // 
            // TextBoxAverageMark
            // 
            this.TextBoxAverageMark.Location = new System.Drawing.Point(496, 285);
            this.TextBoxAverageMark.Name = "TextBoxAverageMark";
            this.TextBoxAverageMark.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAverageMark.TabIndex = 7;
            // 
            // buttonInsertStudent
            // 
            this.buttonInsertStudent.Location = new System.Drawing.Point(18, 328);
            this.buttonInsertStudent.Name = "buttonInsertStudent";
            this.buttonInsertStudent.Size = new System.Drawing.Size(127, 23);
            this.buttonInsertStudent.TabIndex = 8;
            this.buttonInsertStudent.Text = "Kreiraj";
            this.buttonInsertStudent.UseVisualStyleBackColor = true;
            this.buttonInsertStudent.Click += new System.EventHandler(this.buttonInsertStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.buttonInsertStudent);
            this.Controls.Add(this.TextBoxAverageMark);
            this.Controls.Add(this.TextBoxIndexNumber);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "Form1";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxIndexNumber;
        private System.Windows.Forms.TextBox TextBoxAverageMark;
        private System.Windows.Forms.Button buttonInsertStudent;
    }
}

