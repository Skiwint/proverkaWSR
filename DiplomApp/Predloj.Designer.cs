namespace DiplomApp
{
    partial class Predloj
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
            this.NamePredl = new System.Windows.Forms.TextBox();
            this.RykovodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPredl = new System.Windows.Forms.Button();
            this.UpPredl = new System.Windows.Forms.Button();
            this.DelPredl = new System.Windows.Forms.Button();
            this.DataPredl = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataPredl)).BeginInit();
            this.SuspendLayout();
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(310, 28);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(610, 285);
            this.RichOpic.TabIndex = 48;
            this.RichOpic.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1068, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 28);
            this.label3.TabIndex = 47;
            this.label3.Text = "Тема";
            // 
            // NamePredl
            // 
            this.NamePredl.Location = new System.Drawing.Point(1139, 39);
            this.NamePredl.Name = "NamePredl";
            this.NamePredl.Size = new System.Drawing.Size(302, 27);
            this.NamePredl.TabIndex = 46;
            // 
            // RykovodID
            // 
            this.RykovodID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RykovodID.FormattingEnabled = true;
            this.RykovodID.Location = new System.Drawing.Point(1139, 72);
            this.RykovodID.Name = "RykovodID";
            this.RykovodID.Size = new System.Drawing.Size(302, 28);
            this.RykovodID.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(940, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Руководитель Орг.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(183, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Описание";
            // 
            // AddPredl
            // 
            this.AddPredl.BackColor = System.Drawing.Color.Black;
            this.AddPredl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPredl.ForeColor = System.Drawing.Color.White;
            this.AddPredl.Location = new System.Drawing.Point(1199, 279);
            this.AddPredl.Name = "AddPredl";
            this.AddPredl.Size = new System.Drawing.Size(197, 48);
            this.AddPredl.TabIndex = 42;
            this.AddPredl.Text = "Добавить";
            this.AddPredl.UseVisualStyleBackColor = false;
            this.AddPredl.Click += new System.EventHandler(this.AddPredl_Click);
            // 
            // UpPredl
            // 
            this.UpPredl.BackColor = System.Drawing.Color.Black;
            this.UpPredl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpPredl.ForeColor = System.Drawing.Color.White;
            this.UpPredl.Location = new System.Drawing.Point(1402, 279);
            this.UpPredl.Name = "UpPredl";
            this.UpPredl.Size = new System.Drawing.Size(197, 48);
            this.UpPredl.TabIndex = 41;
            this.UpPredl.Text = "Изменить";
            this.UpPredl.UseVisualStyleBackColor = false;
            this.UpPredl.Click += new System.EventHandler(this.UpPredl_Click);
            // 
            // DelPredl
            // 
            this.DelPredl.BackColor = System.Drawing.Color.Black;
            this.DelPredl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelPredl.ForeColor = System.Drawing.Color.White;
            this.DelPredl.Location = new System.Drawing.Point(1605, 279);
            this.DelPredl.Name = "DelPredl";
            this.DelPredl.Size = new System.Drawing.Size(197, 48);
            this.DelPredl.TabIndex = 40;
            this.DelPredl.Text = "Удалить";
            this.DelPredl.UseVisualStyleBackColor = false;
            this.DelPredl.Click += new System.EventHandler(this.DelPredl_Click);
            // 
            // DataPredl
            // 
            this.DataPredl.AllowUserToAddRows = false;
            this.DataPredl.AllowUserToDeleteRows = false;
            this.DataPredl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPredl.Location = new System.Drawing.Point(12, 333);
            this.DataPredl.MultiSelect = false;
            this.DataPredl.Name = "DataPredl";
            this.DataPredl.ReadOnly = true;
            this.DataPredl.RowHeadersWidth = 51;
            this.DataPredl.RowTemplate.Height = 29;
            this.DataPredl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataPredl.Size = new System.Drawing.Size(1790, 557);
            this.DataPredl.TabIndex = 39;
            this.DataPredl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataPredl_CellContentClick);
            // 
            // BackForm
            // 
            this.BackForm.BackColor = System.Drawing.Color.Red;
            this.BackForm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackForm.ForeColor = System.Drawing.Color.White;
            this.BackForm.Location = new System.Drawing.Point(12, 9);
            this.BackForm.Name = "BackForm";
            this.BackForm.Size = new System.Drawing.Size(148, 54);
            this.BackForm.TabIndex = 49;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // Predloj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1814, 902);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NamePredl);
            this.Controls.Add(this.RykovodID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPredl);
            this.Controls.Add(this.UpPredl);
            this.Controls.Add(this.DelPredl);
            this.Controls.Add(this.DataPredl);
            this.Name = "Predloj";
            this.Text = "Predloj";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Predloj_FormClosed);
            this.Load += new System.EventHandler(this.Predloj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPredl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox NamePredl;
        public System.Windows.Forms.ComboBox RykovodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button AddPredl;
        public System.Windows.Forms.Button UpPredl;
        public System.Windows.Forms.Button DelPredl;
        public System.Windows.Forms.DataGridView DataPredl;
        private System.Windows.Forms.Button BackForm;
    }
}