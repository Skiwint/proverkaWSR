namespace DiplomApp.AdminsPart
{
    partial class AdminTeacher
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
            this.AddTeacher = new System.Windows.Forms.Button();
            this.UpTeacher = new System.Windows.Forms.Button();
            this.DelTeacher = new System.Windows.Forms.Button();
            this.DataTeacher = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Famil = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameT = new System.Windows.Forms.TextBox();
            this.MesketPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTeacher
            // 
            this.AddTeacher.BackColor = System.Drawing.Color.Black;
            this.AddTeacher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddTeacher.ForeColor = System.Drawing.Color.White;
            this.AddTeacher.Location = new System.Drawing.Point(880, 249);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(197, 48);
            this.AddTeacher.TabIndex = 7;
            this.AddTeacher.Text = "Добавить";
            this.AddTeacher.UseVisualStyleBackColor = false;
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // UpTeacher
            // 
            this.UpTeacher.BackColor = System.Drawing.Color.Black;
            this.UpTeacher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpTeacher.ForeColor = System.Drawing.Color.White;
            this.UpTeacher.Location = new System.Drawing.Point(1083, 249);
            this.UpTeacher.Name = "UpTeacher";
            this.UpTeacher.Size = new System.Drawing.Size(197, 48);
            this.UpTeacher.TabIndex = 6;
            this.UpTeacher.Text = "Изменить";
            this.UpTeacher.UseVisualStyleBackColor = false;
            this.UpTeacher.Click += new System.EventHandler(this.UpTeacher_Click);
            // 
            // DelTeacher
            // 
            this.DelTeacher.BackColor = System.Drawing.Color.Black;
            this.DelTeacher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelTeacher.ForeColor = System.Drawing.Color.White;
            this.DelTeacher.Location = new System.Drawing.Point(1286, 249);
            this.DelTeacher.Name = "DelTeacher";
            this.DelTeacher.Size = new System.Drawing.Size(197, 48);
            this.DelTeacher.TabIndex = 5;
            this.DelTeacher.Text = "Удалить";
            this.DelTeacher.UseVisualStyleBackColor = false;
            this.DelTeacher.Click += new System.EventHandler(this.DelTeacher_Click);
            // 
            // DataTeacher
            // 
            this.DataTeacher.AllowUserToAddRows = false;
            this.DataTeacher.AllowUserToDeleteRows = false;
            this.DataTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTeacher.Location = new System.Drawing.Point(12, 303);
            this.DataTeacher.MultiSelect = false;
            this.DataTeacher.Name = "DataTeacher";
            this.DataTeacher.ReadOnly = true;
            this.DataTeacher.RowHeadersWidth = 51;
            this.DataTeacher.RowTemplate.Height = 29;
            this.DataTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTeacher.Size = new System.Drawing.Size(1471, 385);
            this.DataTeacher.TabIndex = 4;
            this.DataTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTeacher_CellContentClick);
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(12, 12);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(148, 54);
            this.BackForm.TabIndex = 9;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(176, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(417, 47);
            this.label4.TabIndex = 24;
            this.label4.Text = "Руководитель техникума";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(67, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 50;
            this.label6.Text = "Отчество";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(176, 152);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(302, 27);
            this.Otchestvo.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(62, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 48;
            this.label5.Text = "Фамилия";
            // 
            // Famil
            // 
            this.Famil.Location = new System.Drawing.Point(176, 118);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(302, 27);
            this.Famil.TabIndex = 47;
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(176, 219);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(302, 28);
            this.UserID.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(18, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 45;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(99, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Имя";
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(176, 85);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(302, 27);
            this.NameT.TabIndex = 43;
            // 
            // MesketPhone
            // 
            this.MesketPhone.Location = new System.Drawing.Point(656, 85);
            this.MesketPhone.Mask = "(999) 000-0000";
            this.MesketPhone.Name = "MesketPhone";
            this.MesketPhone.Size = new System.Drawing.Size(302, 27);
            this.MesketPhone.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(559, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 51;
            this.label8.Text = "Телефон";
            // 
            // AdminTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.MesketPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddTeacher);
            this.Controls.Add(this.UpTeacher);
            this.Controls.Add(this.DelTeacher);
            this.Controls.Add(this.DataTeacher);
            this.Name = "AdminTeacher";
            this.Text = "AdminTeacher";
            this.Load += new System.EventHandler(this.AdminTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTeacher;
        private System.Windows.Forms.Button UpTeacher;
        private System.Windows.Forms.Button DelTeacher;
        private System.Windows.Forms.DataGridView DataTeacher;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.MaskedTextBox MesketPhone;
        private System.Windows.Forms.Label label8;
    }
}