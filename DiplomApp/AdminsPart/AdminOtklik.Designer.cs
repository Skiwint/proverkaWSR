namespace DiplomApp.AdminsPart
{
    partial class AdminOtklik
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
            this.AddOtkl = new System.Windows.Forms.Button();
            this.UpOtkl = new System.Windows.Forms.Button();
            this.DelOtkl = new System.Windows.Forms.Button();
            this.DataOtkl = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StudentID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOtkl = new System.Windows.Forms.TextBox();
            this.PredlID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RichOpic = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataOtkl)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOtkl
            // 
            this.AddOtkl.BackColor = System.Drawing.Color.Black;
            this.AddOtkl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOtkl.ForeColor = System.Drawing.Color.White;
            this.AddOtkl.Location = new System.Drawing.Point(880, 249);
            this.AddOtkl.Name = "AddOtkl";
            this.AddOtkl.Size = new System.Drawing.Size(197, 48);
            this.AddOtkl.TabIndex = 7;
            this.AddOtkl.Text = "Добавить";
            this.AddOtkl.UseVisualStyleBackColor = false;
            this.AddOtkl.Click += new System.EventHandler(this.AddOtkl_Click);
            // 
            // UpOtkl
            // 
            this.UpOtkl.BackColor = System.Drawing.Color.Black;
            this.UpOtkl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpOtkl.ForeColor = System.Drawing.Color.White;
            this.UpOtkl.Location = new System.Drawing.Point(1083, 249);
            this.UpOtkl.Name = "UpOtkl";
            this.UpOtkl.Size = new System.Drawing.Size(197, 48);
            this.UpOtkl.TabIndex = 6;
            this.UpOtkl.Text = "Изменить";
            this.UpOtkl.UseVisualStyleBackColor = false;
            this.UpOtkl.Click += new System.EventHandler(this.UpOtkl_Click);
            // 
            // DelOtkl
            // 
            this.DelOtkl.BackColor = System.Drawing.Color.Black;
            this.DelOtkl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelOtkl.ForeColor = System.Drawing.Color.White;
            this.DelOtkl.Location = new System.Drawing.Point(1286, 249);
            this.DelOtkl.Name = "DelOtkl";
            this.DelOtkl.Size = new System.Drawing.Size(197, 48);
            this.DelOtkl.TabIndex = 5;
            this.DelOtkl.Text = "Удалить";
            this.DelOtkl.UseVisualStyleBackColor = false;
            this.DelOtkl.Click += new System.EventHandler(this.DelOtkl_Click);
            // 
            // DataOtkl
            // 
            this.DataOtkl.AllowUserToAddRows = false;
            this.DataOtkl.AllowUserToDeleteRows = false;
            this.DataOtkl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOtkl.Location = new System.Drawing.Point(12, 303);
            this.DataOtkl.MultiSelect = false;
            this.DataOtkl.Name = "DataOtkl";
            this.DataOtkl.ReadOnly = true;
            this.DataOtkl.RowHeadersWidth = 51;
            this.DataOtkl.RowTemplate.Height = 29;
            this.DataOtkl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataOtkl.Size = new System.Drawing.Size(1471, 385);
            this.DataOtkl.TabIndex = 4;
            this.DataOtkl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOtkl_CellContentClick);
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
            this.label4.Size = new System.Drawing.Size(132, 47);
            this.label4.TabIndex = 27;
            this.label4.Text = "Отклик";
            // 
            // StudentID
            // 
            this.StudentID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentID.FormattingEnabled = true;
            this.StudentID.Location = new System.Drawing.Point(211, 171);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(302, 28);
            this.StudentID.TabIndex = 31;
            this.StudentID.SelectedIndexChanged += new System.EventHandler(this.StudentID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Студент";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NameOtkl
            // 
            this.NameOtkl.Location = new System.Drawing.Point(211, 85);
            this.NameOtkl.Name = "NameOtkl";
            this.NameOtkl.Size = new System.Drawing.Size(302, 27);
            this.NameOtkl.TabIndex = 28;
            this.NameOtkl.TextChanged += new System.EventHandler(this.NameOtkl_TextChanged);
            // 
            // PredlID
            // 
            this.PredlID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PredlID.FormattingEnabled = true;
            this.PredlID.Location = new System.Drawing.Point(211, 215);
            this.PredlID.Name = "PredlID";
            this.PredlID.Size = new System.Drawing.Size(302, 28);
            this.PredlID.TabIndex = 32;
            this.PredlID.SelectedIndexChanged += new System.EventHandler(this.PredlID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Предложение";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(654, 125);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(302, 74);
            this.RichOpic.TabIndex = 35;
            this.RichOpic.Text = "";
            this.RichOpic.TextChanged += new System.EventHandler(this.RichOpic_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(528, 125);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 28);
            this.label.TabIndex = 34;
            this.label.Text = "Описание";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // StatusBox
            // 
            this.StatusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(211, 129);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(302, 28);
            this.StatusBox.TabIndex = 37;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.StatusBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(136, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 28);
            this.label5.TabIndex = 36;
            this.label5.Text = "Статус";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AdminOtklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PredlID);
            this.Controls.Add(this.StudentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOtkl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddOtkl);
            this.Controls.Add(this.UpOtkl);
            this.Controls.Add(this.DelOtkl);
            this.Controls.Add(this.DataOtkl);
            this.Name = "AdminOtklik";
            this.Text = "AdminOtklik";
            this.Load += new System.EventHandler(this.AdminOtklik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOtkl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOtkl;
        private System.Windows.Forms.Button UpOtkl;
        private System.Windows.Forms.Button DelOtkl;
        private System.Windows.Forms.DataGridView DataOtkl;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StudentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameOtkl;
        private System.Windows.Forms.ComboBox PredlID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.Label label5;
    }
}