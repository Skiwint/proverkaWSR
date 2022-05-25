namespace DiplomApp.AdminsPart
{
    partial class AdminStudent
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
            this.AddStudent = new System.Windows.Forms.Button();
            this.UpStudent = new System.Windows.Forms.Button();
            this.DelStudent = new System.Windows.Forms.Button();
            this.DataStudent = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.RykID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Famil = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameS = new System.Windows.Forms.TextBox();
            this.GroupID = new System.Windows.Forms.ComboBox();
            this.MesketPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.BackColor = System.Drawing.Color.Black;
            this.AddStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStudent.ForeColor = System.Drawing.Color.White;
            this.AddStudent.Location = new System.Drawing.Point(770, 187);
            this.AddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(172, 36);
            this.AddStudent.TabIndex = 7;
            this.AddStudent.Text = "Добавить";
            this.AddStudent.UseVisualStyleBackColor = false;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // UpStudent
            // 
            this.UpStudent.BackColor = System.Drawing.Color.Black;
            this.UpStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpStudent.ForeColor = System.Drawing.Color.White;
            this.UpStudent.Location = new System.Drawing.Point(948, 187);
            this.UpStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpStudent.Name = "UpStudent";
            this.UpStudent.Size = new System.Drawing.Size(172, 36);
            this.UpStudent.TabIndex = 6;
            this.UpStudent.Text = "Изменить";
            this.UpStudent.UseVisualStyleBackColor = false;
            this.UpStudent.Click += new System.EventHandler(this.UpStudent_Click);
            // 
            // DelStudent
            // 
            this.DelStudent.BackColor = System.Drawing.Color.Black;
            this.DelStudent.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelStudent.ForeColor = System.Drawing.Color.White;
            this.DelStudent.Location = new System.Drawing.Point(1125, 187);
            this.DelStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelStudent.Name = "DelStudent";
            this.DelStudent.Size = new System.Drawing.Size(172, 36);
            this.DelStudent.TabIndex = 5;
            this.DelStudent.Text = "Удалить";
            this.DelStudent.UseVisualStyleBackColor = false;
            this.DelStudent.Click += new System.EventHandler(this.DelStudent_Click);
            // 
            // DataStudent
            // 
            this.DataStudent.AllowUserToAddRows = false;
            this.DataStudent.AllowUserToDeleteRows = false;
            this.DataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataStudent.Location = new System.Drawing.Point(10, 227);
            this.DataStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataStudent.MultiSelect = false;
            this.DataStudent.Name = "DataStudent";
            this.DataStudent.ReadOnly = true;
            this.DataStudent.RowHeadersWidth = 51;
            this.DataStudent.RowTemplate.Height = 29;
            this.DataStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataStudent.Size = new System.Drawing.Size(1287, 289);
            this.DataStudent.TabIndex = 4;
            this.DataStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataStudent_CellContentClick);
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(10, 9);
            this.BackForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(130, 40);
            this.BackForm.TabIndex = 9;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(158, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 38);
            this.label4.TabIndex = 25;
            this.label4.Text = "Студент";
            // 
            // RykID
            // 
            this.RykID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RykID.FormattingEnabled = true;
            this.RykID.Location = new System.Drawing.Point(178, 170);
            this.RykID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RykID.Name = "RykID";
            this.RykID.Size = new System.Drawing.Size(265, 23);
            this.RykID.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 21);
            this.label7.TabIndex = 57;
            this.label7.Text = "Руководитель У/З";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(99, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Группа";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(82, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 54;
            this.label6.Text = "Отчество";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(178, 121);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(265, 23);
            this.Otchestvo.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(82, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Фамилия";
            // 
            // Famil
            // 
            this.Famil.Location = new System.Drawing.Point(178, 95);
            this.Famil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(265, 23);
            this.Famil.TabIndex = 51;
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(178, 196);
            this.UserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(265, 23);
            this.UserID.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Имя";
            // 
            // NameS
            // 
            this.NameS.Location = new System.Drawing.Point(178, 70);
            this.NameS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameS.Name = "NameS";
            this.NameS.Size = new System.Drawing.Size(265, 23);
            this.NameS.TabIndex = 47;
            // 
            // GroupID
            // 
            this.GroupID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupID.FormattingEnabled = true;
            this.GroupID.Location = new System.Drawing.Point(178, 145);
            this.GroupID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(265, 23);
            this.GroupID.TabIndex = 59;
            // 
            // MesketPhone
            // 
            this.MesketPhone.Location = new System.Drawing.Point(581, 74);
            this.MesketPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MesketPhone.Mask = "(999) 000-0000";
            this.MesketPhone.Name = "MesketPhone";
            this.MesketPhone.Size = new System.Drawing.Size(265, 23);
            this.MesketPhone.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(496, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 60;
            this.label8.Text = "Телефон";
            // 
            // AdminStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1308, 525);
            this.Controls.Add(this.MesketPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GroupID);
            this.Controls.Add(this.RykID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.UpStudent);
            this.Controls.Add(this.DelStudent);
            this.Controls.Add(this.DataStudent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminStudent";
            this.Text = "AdminStudent";
            this.Load += new System.EventHandler(this.AdminStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button UpStudent;
        private System.Windows.Forms.Button DelStudent;
        private System.Windows.Forms.DataGridView DataStudent;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RykID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameS;
        private System.Windows.Forms.ComboBox GroupID;
        private System.Windows.Forms.MaskedTextBox MesketPhone;
        private System.Windows.Forms.Label label8;
    }
}