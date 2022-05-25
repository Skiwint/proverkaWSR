namespace DiplomApp
{
    partial class TeacherForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Famil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.UpStudent = new System.Windows.Forms.Button();
            this.GroupFrm = new System.Windows.Forms.Button();
            this.BackForm = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberPhoneTeh = new System.Windows.Forms.MaskedTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 58;
            this.label6.Text = "Отчество";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otchestvo.Location = new System.Drawing.Point(228, 302);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(540, 31);
            this.Otchestvo.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Фамилия";
            // 
            // Famil
            // 
            this.Famil.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Famil.Location = new System.Drawing.Point(228, 267);
            this.Famil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(540, 31);
            this.Famil.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(156, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Имя";
            // 
            // NameT
            // 
            this.NameT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameT.Location = new System.Drawing.Point(228, 233);
            this.NameT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(540, 31);
            this.NameT.TabIndex = 51;
            // 
            // UpStudent
            // 
            this.UpStudent.BackColor = System.Drawing.Color.Black;
            this.UpStudent.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpStudent.ForeColor = System.Drawing.Color.Transparent;
            this.UpStudent.Location = new System.Drawing.Point(800, 233);
            this.UpStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpStudent.Name = "UpStudent";
            this.UpStudent.Size = new System.Drawing.Size(215, 32);
            this.UpStudent.TabIndex = 59;
            this.UpStudent.Text = "Изменить";
            this.UpStudent.UseVisualStyleBackColor = false;
            this.UpStudent.Click += new System.EventHandler(this.UpStudent_Click);
            // 
            // GroupFrm
            // 
            this.GroupFrm.BackColor = System.Drawing.Color.Black;
            this.GroupFrm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GroupFrm.ForeColor = System.Drawing.Color.Transparent;
            this.GroupFrm.Location = new System.Drawing.Point(206, 9);
            this.GroupFrm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupFrm.Name = "GroupFrm";
            this.GroupFrm.Size = new System.Drawing.Size(215, 32);
            this.GroupFrm.TabIndex = 60;
            this.GroupFrm.Text = "Экспорт";
            this.GroupFrm.UseVisualStyleBackColor = false;
            this.GroupFrm.Click += new System.EventHandler(this.GroupFrm_Click);
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
            this.BackForm.TabIndex = 62;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // UserID
            // 
            this.UserID.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserID.Location = new System.Drawing.Point(228, 346);
            this.UserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Size = new System.Drawing.Size(540, 31);
            this.UserID.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 64;
            this.label3.Text = "Пользователь";
            // 
            // NumberPhoneTeh
            // 
            this.NumberPhoneTeh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberPhoneTeh.Location = new System.Drawing.Point(228, 396);
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
            this.label44.Location = new System.Drawing.Point(31, 396);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 25);
            this.label44.TabIndex = 69;
            this.label44.Text = "Телефон";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 676);
            this.Controls.Add(this.NumberPhoneTeh);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.GroupFrm);
            this.Controls.Add(this.UpStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Button UpStudent;
        private System.Windows.Forms.Button GroupFrm;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox NumberPhoneTeh;
        private System.Windows.Forms.Label label44;
    }
}