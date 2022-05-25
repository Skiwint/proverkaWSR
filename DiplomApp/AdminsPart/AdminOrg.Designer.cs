namespace DiplomApp.AdminsPart
{
    partial class AdminOrg
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
            this.AddOrg = new System.Windows.Forms.Button();
            this.UpOrg = new System.Windows.Forms.Button();
            this.DellOrg = new System.Windows.Forms.Button();
            this.DataOrg = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.IpOblBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.RichOpic = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrg
            // 
            this.AddOrg.BackColor = System.Drawing.Color.Black;
            this.AddOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOrg.ForeColor = System.Drawing.Color.White;
            this.AddOrg.Location = new System.Drawing.Point(880, 249);
            this.AddOrg.Name = "AddOrg";
            this.AddOrg.Size = new System.Drawing.Size(197, 48);
            this.AddOrg.TabIndex = 7;
            this.AddOrg.Text = "Добавить";
            this.AddOrg.UseVisualStyleBackColor = false;
            this.AddOrg.Click += new System.EventHandler(this.AddOrg_Click);
            // 
            // UpOrg
            // 
            this.UpOrg.BackColor = System.Drawing.Color.Black;
            this.UpOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpOrg.ForeColor = System.Drawing.Color.White;
            this.UpOrg.Location = new System.Drawing.Point(1083, 249);
            this.UpOrg.Name = "UpOrg";
            this.UpOrg.Size = new System.Drawing.Size(197, 48);
            this.UpOrg.TabIndex = 6;
            this.UpOrg.Text = "Изменить";
            this.UpOrg.UseVisualStyleBackColor = false;
            this.UpOrg.Click += new System.EventHandler(this.UpOrg_Click);
            // 
            // DellOrg
            // 
            this.DellOrg.BackColor = System.Drawing.Color.Black;
            this.DellOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DellOrg.ForeColor = System.Drawing.Color.White;
            this.DellOrg.Location = new System.Drawing.Point(1286, 249);
            this.DellOrg.Name = "DellOrg";
            this.DellOrg.Size = new System.Drawing.Size(197, 48);
            this.DellOrg.TabIndex = 5;
            this.DellOrg.Text = "Удалить";
            this.DellOrg.UseVisualStyleBackColor = false;
            this.DellOrg.Click += new System.EventHandler(this.DellOrg_Click);
            // 
            // DataOrg
            // 
            this.DataOrg.AllowUserToAddRows = false;
            this.DataOrg.AllowUserToDeleteRows = false;
            this.DataOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOrg.Location = new System.Drawing.Point(12, 303);
            this.DataOrg.MultiSelect = false;
            this.DataOrg.Name = "DataOrg";
            this.DataOrg.ReadOnly = true;
            this.DataOrg.RowHeadersWidth = 51;
            this.DataOrg.RowTemplate.Height = 29;
            this.DataOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataOrg.Size = new System.Drawing.Size(1471, 385);
            this.DataOrg.TabIndex = 4;
            this.DataOrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOrg_CellContentClick);
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
            // IpOblBox
            // 
            this.IpOblBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IpOblBox.FormattingEnabled = true;
            this.IpOblBox.Location = new System.Drawing.Point(186, 249);
            this.IpOblBox.Name = "IpOblBox";
            this.IpOblBox.Size = new System.Drawing.Size(302, 28);
            this.IpOblBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Номер области";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название";
            // 
            // NameOrg
            // 
            this.NameOrg.Location = new System.Drawing.Point(186, 96);
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.Size = new System.Drawing.Size(302, 27);
            this.NameOrg.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(93, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Адрес";
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(186, 129);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(302, 27);
            this.Adress.TabIndex = 21;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(60, 169);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 28);
            this.label.TabIndex = 24;
            this.label.Text = "Описание";
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(186, 169);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(302, 74);
            this.RichOpic.TabIndex = 25;
            this.RichOpic.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(166, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 47);
            this.label5.TabIndex = 27;
            this.label5.Text = "Организация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(535, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "ИНН";
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(596, 96);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(302, 27);
            this.INN.TabIndex = 28;
            // 
            // AdminOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.IpOblBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOrg);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddOrg);
            this.Controls.Add(this.UpOrg);
            this.Controls.Add(this.DellOrg);
            this.Controls.Add(this.DataOrg);
            this.Name = "AdminOrg";
            this.Text = "AdminOrg";
            this.Load += new System.EventHandler(this.AdminOrg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrg;
        private System.Windows.Forms.Button UpOrg;
        private System.Windows.Forms.Button DellOrg;
        private System.Windows.Forms.DataGridView DataOrg;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.ComboBox IpOblBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox INN;
    }
}