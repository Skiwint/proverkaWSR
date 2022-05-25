namespace DiplomApp.AdminsPart
{
    partial class AdminResume
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
            this.AddResume = new System.Windows.Forms.Button();
            this.UpResume = new System.Windows.Forms.Button();
            this.DelResume = new System.Windows.Forms.Button();
            this.DataResume = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TemaText = new System.Windows.Forms.TextBox();
            this.RichOpic = new System.Windows.Forms.RichTextBox();
            this.OblstBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataResume)).BeginInit();
            this.SuspendLayout();
            // 
            // AddResume
            // 
            this.AddResume.BackColor = System.Drawing.Color.Black;
            this.AddResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddResume.ForeColor = System.Drawing.Color.White;
            this.AddResume.Location = new System.Drawing.Point(880, 249);
            this.AddResume.Name = "AddResume";
            this.AddResume.Size = new System.Drawing.Size(197, 48);
            this.AddResume.TabIndex = 7;
            this.AddResume.Text = "Добавить";
            this.AddResume.UseVisualStyleBackColor = false;
            this.AddResume.Click += new System.EventHandler(this.AddResume_Click);
            // 
            // UpResume
            // 
            this.UpResume.BackColor = System.Drawing.Color.Black;
            this.UpResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpResume.ForeColor = System.Drawing.Color.White;
            this.UpResume.Location = new System.Drawing.Point(1083, 249);
            this.UpResume.Name = "UpResume";
            this.UpResume.Size = new System.Drawing.Size(197, 48);
            this.UpResume.TabIndex = 6;
            this.UpResume.Text = "Изменить";
            this.UpResume.UseVisualStyleBackColor = false;
            this.UpResume.Click += new System.EventHandler(this.UpResume_Click);
            // 
            // DelResume
            // 
            this.DelResume.BackColor = System.Drawing.Color.Black;
            this.DelResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelResume.ForeColor = System.Drawing.Color.White;
            this.DelResume.Location = new System.Drawing.Point(1286, 249);
            this.DelResume.Name = "DelResume";
            this.DelResume.Size = new System.Drawing.Size(197, 48);
            this.DelResume.TabIndex = 5;
            this.DelResume.Text = "Удалить";
            this.DelResume.UseVisualStyleBackColor = false;
            this.DelResume.Click += new System.EventHandler(this.DelResume_Click);
            // 
            // DataResume
            // 
            this.DataResume.AllowUserToAddRows = false;
            this.DataResume.AllowUserToDeleteRows = false;
            this.DataResume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataResume.Location = new System.Drawing.Point(12, 303);
            this.DataResume.MultiSelect = false;
            this.DataResume.Name = "DataResume";
            this.DataResume.ReadOnly = true;
            this.DataResume.RowHeadersWidth = 51;
            this.DataResume.RowTemplate.Height = 29;
            this.DataResume.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataResume.Size = new System.Drawing.Size(1471, 385);
            this.DataResume.TabIndex = 4;
            this.DataResume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataResume_CellContentClick);
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
            this.label4.Location = new System.Drawing.Point(166, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 47);
            this.label4.TabIndex = 26;
            this.label4.Text = "Резюме";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(482, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 32;
            this.label3.Text = "Описание";
            // 
            // StudentID
            // 
            this.StudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentID.FormattingEnabled = true;
            this.StudentID.Location = new System.Drawing.Point(149, 146);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(302, 28);
            this.StudentID.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Студент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Заголовок";
            // 
            // TemaText
            // 
            this.TemaText.Location = new System.Drawing.Point(149, 96);
            this.TemaText.Name = "TemaText";
            this.TemaText.Size = new System.Drawing.Size(302, 27);
            this.TemaText.TabIndex = 27;
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(592, 87);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(469, 143);
            this.RichOpic.TabIndex = 35;
            this.RichOpic.Text = "";
            // 
            // OblstBox
            // 
            this.OblstBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OblstBox.FormattingEnabled = true;
            this.OblstBox.Location = new System.Drawing.Point(149, 202);
            this.OblstBox.Name = "OblstBox";
            this.OblstBox.Size = new System.Drawing.Size(302, 28);
            this.OblstBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(40, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Область";
            // 
            // AdminResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.OblstBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemaText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddResume);
            this.Controls.Add(this.UpResume);
            this.Controls.Add(this.DelResume);
            this.Controls.Add(this.DataResume);
            this.Name = "AdminResume";
            this.Text = "AdminResume";
            this.Load += new System.EventHandler(this.AdminResume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataResume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddResume;
        private System.Windows.Forms.Button UpResume;
        private System.Windows.Forms.Button DelResume;
        private System.Windows.Forms.DataGridView DataResume;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TemaText;
        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.ComboBox OblstBox;
        private System.Windows.Forms.Label label5;
    }
}