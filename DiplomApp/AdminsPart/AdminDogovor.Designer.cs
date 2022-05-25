namespace DiplomApp.AdminsPart
{
    partial class AdminDogovor
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
            this.AddDogovor = new System.Windows.Forms.Button();
            this.UpDogovor = new System.Windows.Forms.Button();
            this.DelDogovor = new System.Windows.Forms.Button();
            this.DogovorData = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DCreate = new System.Windows.Forms.DateTimePicker();
            this.StudentBox = new System.Windows.Forms.ComboBox();
            this.RykovodBox = new System.Windows.Forms.ComboBox();
            this.PraktikBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DogovorName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DogovorData)).BeginInit();
            this.SuspendLayout();
            // 
            // AddDogovor
            // 
            this.AddDogovor.BackColor = System.Drawing.Color.Black;
            this.AddDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDogovor.ForeColor = System.Drawing.Color.White;
            this.AddDogovor.Location = new System.Drawing.Point(880, 249);
            this.AddDogovor.Name = "AddDogovor";
            this.AddDogovor.Size = new System.Drawing.Size(197, 48);
            this.AddDogovor.TabIndex = 7;
            this.AddDogovor.Text = "Добавить";
            this.AddDogovor.UseVisualStyleBackColor = false;
            this.AddDogovor.Click += new System.EventHandler(this.AddDogovor_Click);
            // 
            // UpDogovor
            // 
            this.UpDogovor.BackColor = System.Drawing.Color.Black;
            this.UpDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpDogovor.ForeColor = System.Drawing.Color.White;
            this.UpDogovor.Location = new System.Drawing.Point(1083, 249);
            this.UpDogovor.Name = "UpDogovor";
            this.UpDogovor.Size = new System.Drawing.Size(197, 48);
            this.UpDogovor.TabIndex = 6;
            this.UpDogovor.Text = "Изменить";
            this.UpDogovor.UseVisualStyleBackColor = false;
            this.UpDogovor.Click += new System.EventHandler(this.UpDogovor_Click);
            // 
            // DelDogovor
            // 
            this.DelDogovor.BackColor = System.Drawing.Color.Black;
            this.DelDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelDogovor.ForeColor = System.Drawing.Color.White;
            this.DelDogovor.Location = new System.Drawing.Point(1286, 249);
            this.DelDogovor.Name = "DelDogovor";
            this.DelDogovor.Size = new System.Drawing.Size(197, 48);
            this.DelDogovor.TabIndex = 5;
            this.DelDogovor.Text = "Удалить";
            this.DelDogovor.UseVisualStyleBackColor = false;
            this.DelDogovor.Click += new System.EventHandler(this.DelDogovor_Click);
            // 
            // DogovorData
            // 
            this.DogovorData.AllowUserToAddRows = false;
            this.DogovorData.AllowUserToDeleteRows = false;
            this.DogovorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DogovorData.Location = new System.Drawing.Point(12, 303);
            this.DogovorData.MultiSelect = false;
            this.DogovorData.Name = "DogovorData";
            this.DogovorData.ReadOnly = true;
            this.DogovorData.RowHeadersWidth = 51;
            this.DogovorData.RowTemplate.Height = 29;
            this.DogovorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DogovorData.Size = new System.Drawing.Size(1471, 385);
            this.DogovorData.TabIndex = 4;
            this.DogovorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DogovorData_CellContentClick);
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(12, 12);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(148, 54);
            this.BackForm.TabIndex = 8;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(192, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 47);
            this.label4.TabIndex = 27;
            this.label4.Text = "Договор";
            // 
            // DCreate
            // 
            this.DCreate.Location = new System.Drawing.Point(192, 221);
            this.DCreate.Name = "DCreate";
            this.DCreate.Size = new System.Drawing.Size(288, 27);
            this.DCreate.TabIndex = 28;
            // 
            // StudentBox
            // 
            this.StudentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentBox.FormattingEnabled = true;
            this.StudentBox.Location = new System.Drawing.Point(192, 170);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(288, 28);
            this.StudentBox.TabIndex = 30;
            // 
            // RykovodBox
            // 
            this.RykovodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RykovodBox.FormattingEnabled = true;
            this.RykovodBox.Location = new System.Drawing.Point(192, 136);
            this.RykovodBox.Name = "RykovodBox";
            this.RykovodBox.Size = new System.Drawing.Size(288, 28);
            this.RykovodBox.TabIndex = 31;
            // 
            // PraktikBox
            // 
            this.PraktikBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PraktikBox.FormattingEnabled = true;
            this.PraktikBox.Location = new System.Drawing.Point(192, 102);
            this.PraktikBox.Name = "PraktikBox";
            this.PraktikBox.Size = new System.Drawing.Size(288, 28);
            this.PraktikBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "Практика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(2, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Руководитель Орг.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "Догвор составлен";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(86, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Название";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(103, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "Студент";
            // 
            // DogovorName
            // 
            this.DogovorName.Location = new System.Drawing.Point(192, 256);
            this.DogovorName.Name = "DogovorName";
            this.DogovorName.Size = new System.Drawing.Size(288, 27);
            this.DogovorName.TabIndex = 38;
            // 
            // AdminDogovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.DogovorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PraktikBox);
            this.Controls.Add(this.RykovodBox);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.DCreate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddDogovor);
            this.Controls.Add(this.UpDogovor);
            this.Controls.Add(this.DelDogovor);
            this.Controls.Add(this.DogovorData);
            this.Name = "AdminDogovor";
            this.RightToLeftLayout = true;
            this.Text = "AdminDogovor";
            this.Load += new System.EventHandler(this.AdminDogovor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogovorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDogovor;
        private System.Windows.Forms.Button UpDogovor;
        private System.Windows.Forms.Button DelDogovor;
        private System.Windows.Forms.DataGridView DogovorData;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DCreate;
        private System.Windows.Forms.ComboBox StudentBox;
        private System.Windows.Forms.ComboBox RykovodBox;
        private System.Windows.Forms.ComboBox PraktikBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DogovorName;
    }
}