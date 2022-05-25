namespace DiplomApp.AdminsPart
{
    partial class AdminRykovodOrg
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
            this.AddRykovod = new System.Windows.Forms.Button();
            this.UpRykovod = new System.Windows.Forms.Button();
            this.DelRykovod = new System.Windows.Forms.Button();
            this.DataRykovod = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Famil = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Doljn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.OrgID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MesketPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataRykovod)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRykovod
            // 
            this.AddRykovod.BackColor = System.Drawing.Color.Black;
            this.AddRykovod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRykovod.ForeColor = System.Drawing.Color.White;
            this.AddRykovod.Location = new System.Drawing.Point(880, 249);
            this.AddRykovod.Name = "AddRykovod";
            this.AddRykovod.Size = new System.Drawing.Size(197, 48);
            this.AddRykovod.TabIndex = 7;
            this.AddRykovod.Text = "Добавить";
            this.AddRykovod.UseVisualStyleBackColor = false;
            this.AddRykovod.Click += new System.EventHandler(this.AddRykovod_Click);
            // 
            // UpRykovod
            // 
            this.UpRykovod.BackColor = System.Drawing.Color.Black;
            this.UpRykovod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpRykovod.ForeColor = System.Drawing.Color.White;
            this.UpRykovod.Location = new System.Drawing.Point(1083, 249);
            this.UpRykovod.Name = "UpRykovod";
            this.UpRykovod.Size = new System.Drawing.Size(197, 48);
            this.UpRykovod.TabIndex = 6;
            this.UpRykovod.Text = "Изменить";
            this.UpRykovod.UseVisualStyleBackColor = false;
            this.UpRykovod.Click += new System.EventHandler(this.UpRykovod_Click);
            // 
            // DelRykovod
            // 
            this.DelRykovod.BackColor = System.Drawing.Color.Black;
            this.DelRykovod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelRykovod.ForeColor = System.Drawing.Color.White;
            this.DelRykovod.Location = new System.Drawing.Point(1286, 249);
            this.DelRykovod.Name = "DelRykovod";
            this.DelRykovod.Size = new System.Drawing.Size(197, 48);
            this.DelRykovod.TabIndex = 5;
            this.DelRykovod.Text = "Удалить";
            this.DelRykovod.UseVisualStyleBackColor = false;
            this.DelRykovod.Click += new System.EventHandler(this.DelRykovod_Click);
            // 
            // DataRykovod
            // 
            this.DataRykovod.AllowUserToAddRows = false;
            this.DataRykovod.AllowUserToDeleteRows = false;
            this.DataRykovod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataRykovod.Location = new System.Drawing.Point(12, 303);
            this.DataRykovod.MultiSelect = false;
            this.DataRykovod.Name = "DataRykovod";
            this.DataRykovod.ReadOnly = true;
            this.DataRykovod.RowHeadersWidth = 51;
            this.DataRykovod.RowTemplate.Height = 29;
            this.DataRykovod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataRykovod.Size = new System.Drawing.Size(1471, 385);
            this.DataRykovod.TabIndex = 4;
            this.DataRykovod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataRykovod_CellContentClick);
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
            this.label4.Location = new System.Drawing.Point(178, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 47);
            this.label4.TabIndex = 25;
            this.label4.Text = "Руководитель Орг.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Фамилия";
            // 
            // Famil
            // 
            this.Famil.Location = new System.Drawing.Point(178, 127);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(302, 27);
            this.Famil.TabIndex = 39;
            // 
            // UserID
            // 
            this.UserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserID.FormattingEnabled = true;
            this.UserID.Location = new System.Drawing.Point(178, 262);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(302, 28);
            this.UserID.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 28);
            this.label2.TabIndex = 37;
            this.label2.Text = "Пользователь";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(101, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Имя";
            // 
            // NameR
            // 
            this.NameR.Location = new System.Drawing.Point(178, 94);
            this.NameR.Name = "NameR";
            this.NameR.Size = new System.Drawing.Size(302, 27);
            this.NameR.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "Должность";
            // 
            // Doljn
            // 
            this.Doljn.Location = new System.Drawing.Point(178, 194);
            this.Doljn.Name = "Doljn";
            this.Doljn.Size = new System.Drawing.Size(302, 27);
            this.Doljn.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(69, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 42;
            this.label6.Text = "Отчество";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Location = new System.Drawing.Point(178, 161);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(302, 27);
            this.Otchestvo.TabIndex = 41;
            // 
            // OrgID
            // 
            this.OrgID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OrgID.FormattingEnabled = true;
            this.OrgID.Location = new System.Drawing.Point(178, 227);
            this.OrgID.Name = "OrgID";
            this.OrgID.Size = new System.Drawing.Size(302, 28);
            this.OrgID.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 28);
            this.label7.TabIndex = 45;
            this.label7.Text = "Организация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(554, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 28);
            this.label8.TabIndex = 48;
            this.label8.Text = "Телефон";
            // 
            // MesketPhone
            // 
            this.MesketPhone.Location = new System.Drawing.Point(651, 94);
            this.MesketPhone.Mask = "(999) 000-0000";
            this.MesketPhone.Name = "MesketPhone";
            this.MesketPhone.Size = new System.Drawing.Size(302, 27);
            this.MesketPhone.TabIndex = 49;
            // 
            // AdminRykovodOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.MesketPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.OrgID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Doljn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddRykovod);
            this.Controls.Add(this.UpRykovod);
            this.Controls.Add(this.DelRykovod);
            this.Controls.Add(this.DataRykovod);
            this.Name = "AdminRykovodOrg";
            this.Text = "AdminRykovodOrg";
            this.Load += new System.EventHandler(this.AdminRykovodOrg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataRykovod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRykovod;
        private System.Windows.Forms.Button UpRykovod;
        private System.Windows.Forms.Button DelRykovod;
        private System.Windows.Forms.DataGridView DataRykovod;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.ComboBox UserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Doljn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.ComboBox OrgID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MesketPhone;
    }
}