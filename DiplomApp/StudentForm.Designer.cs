namespace DiplomApp
{
    partial class StudentForm
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
            this.ResumeForm = new System.Windows.Forms.Button();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackForm = new System.Windows.Forms.Button();
            this.Famil = new System.Windows.Forms.TextBox();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RykID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.UpStudent = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.TextBox();
            this.OtklokBtn = new System.Windows.Forms.Button();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.TeacherBox = new System.Windows.Forms.TextBox();
            this.NumberPhoneTeh = new System.Windows.Forms.MaskedTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ResumeForm
            // 
            this.ResumeForm.BackColor = System.Drawing.Color.Black;
            this.ResumeForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResumeForm.ForeColor = System.Drawing.Color.Transparent;
            this.ResumeForm.Location = new System.Drawing.Point(225, 9);
            this.ResumeForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResumeForm.Name = "ResumeForm";
            this.ResumeForm.Size = new System.Drawing.Size(238, 37);
            this.ResumeForm.TabIndex = 0;
            this.ResumeForm.Text = "Резюме";
            this.ResumeForm.UseVisualStyleBackColor = false;
            this.ResumeForm.Click += new System.EventHandler(this.ResumeForm_Click);
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name1.Location = new System.Drawing.Point(225, 153);
            this.Name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(416, 31);
            this.Name1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(10, 9);
            this.BackForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(189, 38);
            this.BackForm.TabIndex = 3;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // Famil
            // 
            this.Famil.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Famil.Location = new System.Drawing.Point(225, 195);
            this.Famil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(416, 31);
            this.Famil.TabIndex = 4;
            // 
            // Otchestvo
            // 
            this.Otchestvo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otchestvo.Location = new System.Drawing.Point(225, 241);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(416, 31);
            this.Otchestvo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отчество";
            // 
            // GroupID
            // 
            this.GroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupID.Enabled = false;
            this.GroupID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupID.FormattingEnabled = true;
            this.GroupID.Location = new System.Drawing.Point(225, 293);
            this.GroupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(416, 31);
            this.GroupID.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Группа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "Руководитель\r\nтехникума";
            // 
            // RykID
            // 
            this.RykID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RykID.Enabled = false;
            this.RykID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RykID.FormattingEnabled = true;
            this.RykID.Location = new System.Drawing.Point(225, 340);
            this.RykID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RykID.Name = "RykID";
            this.RykID.Size = new System.Drawing.Size(416, 31);
            this.RykID.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(28, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Пользователь";
            // 
            // UpStudent
            // 
            this.UpStudent.BackColor = System.Drawing.Color.Black;
            this.UpStudent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpStudent.ForeColor = System.Drawing.Color.Transparent;
            this.UpStudent.Location = new System.Drawing.Point(756, 152);
            this.UpStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpStudent.Name = "UpStudent";
            this.UpStudent.Size = new System.Drawing.Size(215, 32);
            this.UpStudent.TabIndex = 14;
            this.UpStudent.Text = "Изменить";
            this.UpStudent.UseVisualStyleBackColor = false;
            this.UpStudent.Click += new System.EventHandler(this.UpStudent_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(478, 10);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 37);
            this.button4.TabIndex = 15;
            this.button4.Text = "Предложения";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserID
            // 
            this.UserID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserID.Location = new System.Drawing.Point(225, 394);
            this.UserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Size = new System.Drawing.Size(416, 31);
            this.UserID.TabIndex = 16;
            // 
            // OtklokBtn
            // 
            this.OtklokBtn.BackColor = System.Drawing.Color.Black;
            this.OtklokBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtklokBtn.ForeColor = System.Drawing.Color.Transparent;
            this.OtklokBtn.Location = new System.Drawing.Point(733, 10);
            this.OtklokBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OtklokBtn.Name = "OtklokBtn";
            this.OtklokBtn.Size = new System.Drawing.Size(238, 37);
            this.OtklokBtn.TabIndex = 17;
            this.OtklokBtn.Text = "Отклик";
            this.OtklokBtn.UseVisualStyleBackColor = false;
            this.OtklokBtn.Click += new System.EventHandler(this.OtklokBtn_Click);
            // 
            // GroupText
            // 
            this.GroupText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupText.Location = new System.Drawing.Point(662, 342);
            this.GroupText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupText.Name = "GroupText";
            this.GroupText.ReadOnly = true;
            this.GroupText.Size = new System.Drawing.Size(59, 31);
            this.GroupText.TabIndex = 18;
            // 
            // TeacherBox
            // 
            this.TeacherBox.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TeacherBox.Location = new System.Drawing.Point(662, 295);
            this.TeacherBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherBox.Name = "TeacherBox";
            this.TeacherBox.ReadOnly = true;
            this.TeacherBox.Size = new System.Drawing.Size(59, 31);
            this.TeacherBox.TabIndex = 19;
            // 
            // NumberPhoneTeh
            // 
            this.NumberPhoneTeh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberPhoneTeh.Location = new System.Drawing.Point(225, 105);
            this.NumberPhoneTeh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberPhoneTeh.Mask = "(999) 000-0000";
            this.NumberPhoneTeh.Name = "NumberPhoneTeh";
            this.NumberPhoneTeh.Size = new System.Drawing.Size(416, 34);
            this.NumberPhoneTeh.TabIndex = 70;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label44.Location = new System.Drawing.Point(28, 105);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 25);
            this.label44.TabIndex = 69;
            this.label44.Text = "Телефон";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 676);
            this.Controls.Add(this.NumberPhoneTeh);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.TeacherBox);
            this.Controls.Add(this.GroupText);
            this.Controls.Add(this.OtklokBtn);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.UpStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RykID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.ResumeForm);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ResumeForm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GroupID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox RykID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpStudent;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Button OtklokBtn;
        private System.Windows.Forms.TextBox GroupText;
        private System.Windows.Forms.TextBox TeacherBox;
        private System.Windows.Forms.MaskedTextBox NumberPhoneTeh;
        private System.Windows.Forms.Label label44;
    }
}