namespace DiplomApp
{
    partial class ResumeForm
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
            this.RichOpic = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TemaText = new System.Windows.Forms.TextBox();
            this.AddResume = new System.Windows.Forms.Button();
            this.DataResume = new System.Windows.Forms.DataGridView();
            this.UpResume = new System.Windows.Forms.Button();
            this.DelResume = new System.Windows.Forms.Button();
            this.BackForm = new System.Windows.Forms.Button();
            this.OblstBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataResume)).BeginInit();
            this.SuspendLayout();
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(127, 157);
            this.RichOpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(459, 115);
            this.RichOpic.TabIndex = 45;
            this.RichOpic.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Описание";
            // 
            // StudentID
            // 
            this.StudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentID.FormattingEnabled = true;
            this.StudentID.Location = new System.Drawing.Point(127, 124);
            this.StudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(265, 23);
            this.StudentID.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "Студент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Заголовок";
            // 
            // TemaText
            // 
            this.TemaText.Location = new System.Drawing.Point(127, 99);
            this.TemaText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TemaText.Name = "TemaText";
            this.TemaText.Size = new System.Drawing.Size(265, 23);
            this.TemaText.TabIndex = 38;
            // 
            // AddResume
            // 
            this.AddResume.BackColor = System.Drawing.Color.Black;
            this.AddResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddResume.ForeColor = System.Drawing.Color.White;
            this.AddResume.Location = new System.Drawing.Point(1049, 277);
            this.AddResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddResume.Name = "AddResume";
            this.AddResume.Size = new System.Drawing.Size(172, 36);
            this.AddResume.TabIndex = 37;
            this.AddResume.Text = "Добавить";
            this.AddResume.UseVisualStyleBackColor = false;
            this.AddResume.Click += new System.EventHandler(this.AddResume_Click);
            // 
            // DataResume
            // 
            this.DataResume.AllowUserToAddRows = false;
            this.DataResume.AllowUserToDeleteRows = false;
            this.DataResume.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataResume.Location = new System.Drawing.Point(10, 317);
            this.DataResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataResume.MultiSelect = false;
            this.DataResume.Name = "DataResume";
            this.DataResume.ReadOnly = true;
            this.DataResume.RowHeadersWidth = 51;
            this.DataResume.RowTemplate.Height = 29;
            this.DataResume.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataResume.Size = new System.Drawing.Size(1566, 350);
            this.DataResume.TabIndex = 36;
            this.DataResume.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataResume_CellContentClick);
            // 
            // UpResume
            // 
            this.UpResume.BackColor = System.Drawing.Color.Black;
            this.UpResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpResume.ForeColor = System.Drawing.Color.White;
            this.UpResume.Location = new System.Drawing.Point(1227, 277);
            this.UpResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpResume.Name = "UpResume";
            this.UpResume.Size = new System.Drawing.Size(172, 36);
            this.UpResume.TabIndex = 47;
            this.UpResume.Text = "Изменить";
            this.UpResume.UseVisualStyleBackColor = false;
            this.UpResume.Click += new System.EventHandler(this.UpResume_Click);
            // 
            // DelResume
            // 
            this.DelResume.BackColor = System.Drawing.Color.Black;
            this.DelResume.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelResume.ForeColor = System.Drawing.Color.White;
            this.DelResume.Location = new System.Drawing.Point(1404, 277);
            this.DelResume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelResume.Name = "DelResume";
            this.DelResume.Size = new System.Drawing.Size(172, 36);
            this.DelResume.TabIndex = 46;
            this.DelResume.Text = "Удалить";
            this.DelResume.UseVisualStyleBackColor = false;
            this.DelResume.Click += new System.EventHandler(this.DelResume_Click);
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
            this.BackForm.TabIndex = 48;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // OblstBox
            // 
            this.OblstBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OblstBox.FormattingEnabled = true;
            this.OblstBox.Location = new System.Drawing.Point(519, 124);
            this.OblstBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OblstBox.Name = "OblstBox";
            this.OblstBox.Size = new System.Drawing.Size(265, 23);
            this.OblstBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(424, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Область";
            // 
            // ResumeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 676);
            this.Controls.Add(this.OblstBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.UpResume);
            this.Controls.Add(this.DelResume);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TemaText);
            this.Controls.Add(this.AddResume);
            this.Controls.Add(this.DataResume);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResumeForm";
            this.Text = "ResumeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResumeForm_FormClosed);
            this.Load += new System.EventHandler(this.ResumeForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataResume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox StudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TemaText;
        public System.Windows.Forms.Button AddResume;
        private System.Windows.Forms.DataGridView DataResume;
        public System.Windows.Forms.Button UpResume;
        public System.Windows.Forms.Button DelResume;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.ComboBox OblstBox;
        private System.Windows.Forms.Label label5;
    }
}