namespace DiplomApp
{
    partial class OrganizationMainForm
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
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adress = new System.Windows.Forms.TextBox();
            this.IpOblBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOrg = new System.Windows.Forms.TextBox();
            this.AddOrg = new System.Windows.Forms.Button();
            this.UpOrg = new System.Windows.Forms.Button();
            this.DellOrg = new System.Windows.Forms.Button();
            this.DataOrg = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // RichOpic
            // 
            this.RichOpic.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichOpic.Location = new System.Drawing.Point(419, 170);
            this.RichOpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(728, 120);
            this.RichOpic.TabIndex = 37;
            this.RichOpic.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(326, 170);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 21);
            this.label.TabIndex = 36;
            this.label.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(355, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Адрес";
            // 
            // Adress
            // 
            this.Adress.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Adress.Location = new System.Drawing.Point(419, 134);
            this.Adress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(359, 34);
            this.Adress.TabIndex = 34;
            // 
            // IpOblBox
            // 
            this.IpOblBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IpOblBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IpOblBox.FormattingEnabled = true;
            this.IpOblBox.Location = new System.Drawing.Point(862, 64);
            this.IpOblBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IpOblBox.Name = "IpOblBox";
            this.IpOblBox.Size = new System.Drawing.Size(285, 36);
            this.IpOblBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(862, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Область";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(326, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Название";
            // 
            // NameOrg
            // 
            this.NameOrg.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameOrg.Location = new System.Drawing.Point(419, 67);
            this.NameOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.Size = new System.Drawing.Size(359, 34);
            this.NameOrg.TabIndex = 30;
            // 
            // AddOrg
            // 
            this.AddOrg.BackColor = System.Drawing.Color.Black;
            this.AddOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOrg.ForeColor = System.Drawing.Color.White;
            this.AddOrg.Location = new System.Drawing.Point(10, 117);
            this.AddOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOrg.Name = "AddOrg";
            this.AddOrg.Size = new System.Drawing.Size(172, 36);
            this.AddOrg.TabIndex = 29;
            this.AddOrg.Text = "Добавить";
            this.AddOrg.UseVisualStyleBackColor = false;
            this.AddOrg.Click += new System.EventHandler(this.AddOrg_Click);
            // 
            // UpOrg
            // 
            this.UpOrg.BackColor = System.Drawing.Color.Black;
            this.UpOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpOrg.ForeColor = System.Drawing.Color.White;
            this.UpOrg.Location = new System.Drawing.Point(10, 178);
            this.UpOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpOrg.Name = "UpOrg";
            this.UpOrg.Size = new System.Drawing.Size(172, 36);
            this.UpOrg.TabIndex = 28;
            this.UpOrg.Text = "Изменить";
            this.UpOrg.UseVisualStyleBackColor = false;
            this.UpOrg.Click += new System.EventHandler(this.UpOrg_Click);
            // 
            // DellOrg
            // 
            this.DellOrg.BackColor = System.Drawing.Color.Black;
            this.DellOrg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DellOrg.ForeColor = System.Drawing.Color.White;
            this.DellOrg.Location = new System.Drawing.Point(10, 238);
            this.DellOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DellOrg.Name = "DellOrg";
            this.DellOrg.Size = new System.Drawing.Size(172, 36);
            this.DellOrg.TabIndex = 27;
            this.DellOrg.Text = "Удалить";
            this.DellOrg.UseVisualStyleBackColor = false;
            this.DellOrg.Click += new System.EventHandler(this.DellOrg_Click);
            // 
            // DataOrg
            // 
            this.DataOrg.AllowUserToAddRows = false;
            this.DataOrg.AllowUserToDeleteRows = false;
            this.DataOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOrg.Location = new System.Drawing.Point(10, 311);
            this.DataOrg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataOrg.MultiSelect = false;
            this.DataOrg.Name = "DataOrg";
            this.DataOrg.ReadOnly = true;
            this.DataOrg.RowHeadersWidth = 51;
            this.DataOrg.RowTemplate.Height = 29;
            this.DataOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataOrg.Size = new System.Drawing.Size(1644, 356);
            this.DataOrg.TabIndex = 26;
            this.DataOrg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOrg_CellContentClick);
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
            this.BackForm.TabIndex = 49;
            this.BackForm.Text = "Назад";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(808, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "ИНН";
            // 
            // INN
            // 
            this.INN.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.INN.Location = new System.Drawing.Point(862, 132);
            this.INN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(285, 34);
            this.INN.TabIndex = 50;
            // 
            // OrganizationMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1665, 676);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.IpOblBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameOrg);
            this.Controls.Add(this.AddOrg);
            this.Controls.Add(this.UpOrg);
            this.Controls.Add(this.DellOrg);
            this.Controls.Add(this.DataOrg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrganizationMainForm";
            this.Text = "OrganizationMainForm";
            this.Load += new System.EventHandler(this.OrganizationMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOrg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.ComboBox IpOblBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameOrg;
        private System.Windows.Forms.Button AddOrg;
        private System.Windows.Forms.Button UpOrg;
        private System.Windows.Forms.Button DellOrg;
        private System.Windows.Forms.DataGridView DataOrg;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox INN;
    }
}