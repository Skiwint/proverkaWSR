namespace DiplomApp.AdminsPart
{
    partial class AdminPrakt
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DEnd = new System.Windows.Forms.DateTimePicker();
            this.DStart = new System.Windows.Forms.DateTimePicker();
            this.AddPraktik = new System.Windows.Forms.Button();
            this.UpPraktik = new System.Windows.Forms.Button();
            this.DelPraktik = new System.Windows.Forms.Button();
            this.PraktikData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NamePraktik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BackForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PraktikData)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(61, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Дата конца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(53, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 28);
            this.label3.TabIndex = 43;
            this.label3.Text = "Дата начала";
            // 
            // DEnd
            // 
            this.DEnd.Location = new System.Drawing.Point(182, 205);
            this.DEnd.Name = "DEnd";
            this.DEnd.Size = new System.Drawing.Size(288, 27);
            this.DEnd.TabIndex = 42;
            // 
            // DStart
            // 
            this.DStart.Location = new System.Drawing.Point(182, 172);
            this.DStart.Name = "DStart";
            this.DStart.Size = new System.Drawing.Size(288, 27);
            this.DStart.TabIndex = 41;
            // 
            // AddPraktik
            // 
            this.AddPraktik.BackColor = System.Drawing.Color.Black;
            this.AddPraktik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPraktik.ForeColor = System.Drawing.Color.White;
            this.AddPraktik.Location = new System.Drawing.Point(880, 249);
            this.AddPraktik.Name = "AddPraktik";
            this.AddPraktik.Size = new System.Drawing.Size(197, 48);
            this.AddPraktik.TabIndex = 40;
            this.AddPraktik.Text = "Добавить";
            this.AddPraktik.UseVisualStyleBackColor = false;
            this.AddPraktik.Click += new System.EventHandler(this.AddPraktik_Click);
            // 
            // UpPraktik
            // 
            this.UpPraktik.BackColor = System.Drawing.Color.Black;
            this.UpPraktik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpPraktik.ForeColor = System.Drawing.Color.White;
            this.UpPraktik.Location = new System.Drawing.Point(1083, 249);
            this.UpPraktik.Name = "UpPraktik";
            this.UpPraktik.Size = new System.Drawing.Size(197, 48);
            this.UpPraktik.TabIndex = 39;
            this.UpPraktik.Text = "Изменить";
            this.UpPraktik.UseVisualStyleBackColor = false;
            this.UpPraktik.Click += new System.EventHandler(this.UpPraktik_Click);
            // 
            // DelPraktik
            // 
            this.DelPraktik.BackColor = System.Drawing.Color.Black;
            this.DelPraktik.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelPraktik.ForeColor = System.Drawing.Color.White;
            this.DelPraktik.Location = new System.Drawing.Point(1286, 249);
            this.DelPraktik.Name = "DelPraktik";
            this.DelPraktik.Size = new System.Drawing.Size(197, 48);
            this.DelPraktik.TabIndex = 38;
            this.DelPraktik.Text = "Удалить";
            this.DelPraktik.UseVisualStyleBackColor = false;
            this.DelPraktik.Click += new System.EventHandler(this.DelPraktik_Click);
            // 
            // PraktikData
            // 
            this.PraktikData.AllowUserToAddRows = false;
            this.PraktikData.AllowUserToDeleteRows = false;
            this.PraktikData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PraktikData.Location = new System.Drawing.Point(12, 303);
            this.PraktikData.MultiSelect = false;
            this.PraktikData.Name = "PraktikData";
            this.PraktikData.ReadOnly = true;
            this.PraktikData.RowHeadersWidth = 51;
            this.PraktikData.RowTemplate.Height = 29;
            this.PraktikData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PraktikData.Size = new System.Drawing.Size(1471, 385);
            this.PraktikData.TabIndex = 37;
            this.PraktikData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PraktikData_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Название";
            // 
            // NamePraktik
            // 
            this.NamePraktik.Location = new System.Drawing.Point(179, 127);
            this.NamePraktik.Name = "NamePraktik";
            this.NamePraktik.Size = new System.Drawing.Size(302, 27);
            this.NamePraktik.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 47);
            this.label4.TabIndex = 48;
            this.label4.Text = "Практика";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(15, 12);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(148, 54);
            this.BackForm.TabIndex = 47;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // AdminPrakt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NamePraktik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DEnd);
            this.Controls.Add(this.DStart);
            this.Controls.Add(this.AddPraktik);
            this.Controls.Add(this.UpPraktik);
            this.Controls.Add(this.DelPraktik);
            this.Controls.Add(this.PraktikData);
            this.Name = "AdminPrakt";
            this.Text = "AdminPrakt";
            this.Load += new System.EventHandler(this.AdminPrakt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PraktikData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DEnd;
        private System.Windows.Forms.DateTimePicker DStart;
        private System.Windows.Forms.Button AddPraktik;
        private System.Windows.Forms.Button UpPraktik;
        private System.Windows.Forms.Button DelPraktik;
        private System.Windows.Forms.DataGridView PraktikData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamePraktik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackForm;
    }
}