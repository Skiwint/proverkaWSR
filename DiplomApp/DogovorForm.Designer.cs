namespace DiplomApp
{
    partial class DogovorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PraktikBox = new System.Windows.Forms.ComboBox();
            this.RykovodBox = new System.Windows.Forms.ComboBox();
            this.StudentBox = new System.Windows.Forms.ComboBox();
            this.DCreate = new System.Windows.Forms.DateTimePicker();
            this.AddDogovor = new System.Windows.Forms.Button();
            this.UpDogovor = new System.Windows.Forms.Button();
            this.DelDogovor = new System.Windows.Forms.Button();
            this.DogovorData = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.DogovorName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DogovorData)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(96, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Студент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Догвор составлен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 48;
            this.label2.Text = "Руководитель Орг.";
            // 
            // PraktikBox
            // 
            this.PraktikBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PraktikBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PraktikBox.FormattingEnabled = true;
            this.PraktikBox.Location = new System.Drawing.Point(183, 55);
            this.PraktikBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PraktikBox.Name = "PraktikBox";
            this.PraktikBox.Size = new System.Drawing.Size(569, 33);
            this.PraktikBox.TabIndex = 46;
            // 
            // RykovodBox
            // 
            this.RykovodBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RykovodBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RykovodBox.FormattingEnabled = true;
            this.RykovodBox.Location = new System.Drawing.Point(183, 88);
            this.RykovodBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RykovodBox.Name = "RykovodBox";
            this.RykovodBox.Size = new System.Drawing.Size(569, 33);
            this.RykovodBox.TabIndex = 45;
            // 
            // StudentBox
            // 
            this.StudentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentBox.FormattingEnabled = true;
            this.StudentBox.Location = new System.Drawing.Point(184, 122);
            this.StudentBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(569, 33);
            this.StudentBox.TabIndex = 44;
            // 
            // DCreate
            // 
            this.DCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DCreate.Location = new System.Drawing.Point(184, 174);
            this.DCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DCreate.Name = "DCreate";
            this.DCreate.Size = new System.Drawing.Size(569, 32);
            this.DCreate.TabIndex = 42;
            // 
            // AddDogovor
            // 
            this.AddDogovor.BackColor = System.Drawing.Color.Black;
            this.AddDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddDogovor.ForeColor = System.Drawing.Color.White;
            this.AddDogovor.Location = new System.Drawing.Point(1048, 219);
            this.AddDogovor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDogovor.Name = "AddDogovor";
            this.AddDogovor.Size = new System.Drawing.Size(172, 36);
            this.AddDogovor.TabIndex = 41;
            this.AddDogovor.Text = "Добавить";
            this.AddDogovor.UseVisualStyleBackColor = false;
            this.AddDogovor.Click += new System.EventHandler(this.AddDogovor_Click);
            // 
            // UpDogovor
            // 
            this.UpDogovor.BackColor = System.Drawing.Color.Black;
            this.UpDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpDogovor.ForeColor = System.Drawing.Color.White;
            this.UpDogovor.Location = new System.Drawing.Point(1226, 219);
            this.UpDogovor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpDogovor.Name = "UpDogovor";
            this.UpDogovor.Size = new System.Drawing.Size(172, 36);
            this.UpDogovor.TabIndex = 40;
            this.UpDogovor.Text = "Изменить";
            this.UpDogovor.UseVisualStyleBackColor = false;
            this.UpDogovor.Click += new System.EventHandler(this.UpDogovor_Click);
            // 
            // DelDogovor
            // 
            this.DelDogovor.BackColor = System.Drawing.Color.Black;
            this.DelDogovor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelDogovor.ForeColor = System.Drawing.Color.White;
            this.DelDogovor.Location = new System.Drawing.Point(1404, 219);
            this.DelDogovor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelDogovor.Name = "DelDogovor";
            this.DelDogovor.Size = new System.Drawing.Size(172, 36);
            this.DelDogovor.TabIndex = 39;
            this.DelDogovor.Text = "Удалить";
            this.DelDogovor.UseVisualStyleBackColor = false;
            this.DelDogovor.Click += new System.EventHandler(this.DelDogovor_Click);
            // 
            // DogovorData
            // 
            this.DogovorData.AllowUserToAddRows = false;
            this.DogovorData.AllowUserToDeleteRows = false;
            this.DogovorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DogovorData.Location = new System.Drawing.Point(10, 260);
            this.DogovorData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DogovorData.MultiSelect = false;
            this.DogovorData.Name = "DogovorData";
            this.DogovorData.ReadOnly = true;
            this.DogovorData.RowHeadersWidth = 51;
            this.DogovorData.RowTemplate.Height = 29;
            this.DogovorData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DogovorData.Size = new System.Drawing.Size(1566, 408);
            this.DogovorData.TabIndex = 38;
            this.DogovorData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DogovorData_CellContentClick);
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
            this.BackForm.TabIndex = 63;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // DogovorName
            // 
            this.DogovorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DogovorName.Location = new System.Drawing.Point(183, 214);
            this.DogovorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DogovorName.Name = "DogovorName";
            this.DogovorName.Size = new System.Drawing.Size(570, 29);
            this.DogovorName.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(81, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Номер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(83, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 66;
            this.label4.Text = "Практика";
            // 
            // DogovorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 676);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DogovorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PraktikBox);
            this.Controls.Add(this.RykovodBox);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.DCreate);
            this.Controls.Add(this.AddDogovor);
            this.Controls.Add(this.UpDogovor);
            this.Controls.Add(this.DelDogovor);
            this.Controls.Add(this.DogovorData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DogovorForm";
            this.Text = "DogovorForm";
            this.Load += new System.EventHandler(this.DogovorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DogovorData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PraktikBox;
        private System.Windows.Forms.ComboBox RykovodBox;
        private System.Windows.Forms.ComboBox StudentBox;
        private System.Windows.Forms.DateTimePicker DCreate;
        private System.Windows.Forms.Button AddDogovor;
        private System.Windows.Forms.Button UpDogovor;
        private System.Windows.Forms.Button DelDogovor;
        private System.Windows.Forms.DataGridView DogovorData;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.TextBox DogovorName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}