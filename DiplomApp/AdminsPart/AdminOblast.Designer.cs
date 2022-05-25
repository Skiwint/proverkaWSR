namespace DiplomApp.AdminsPart
{
    partial class AdminOblast
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
            this.AddOblast = new System.Windows.Forms.Button();
            this.UpOblast = new System.Windows.Forms.Button();
            this.DelOblast = new System.Windows.Forms.Button();
            this.DataOblast = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ObName = new System.Windows.Forms.TextBox();
            this.RichOpic = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataOblast)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOblast
            // 
            this.AddOblast.BackColor = System.Drawing.Color.Black;
            this.AddOblast.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddOblast.ForeColor = System.Drawing.Color.White;
            this.AddOblast.Location = new System.Drawing.Point(880, 249);
            this.AddOblast.Name = "AddOblast";
            this.AddOblast.Size = new System.Drawing.Size(197, 48);
            this.AddOblast.TabIndex = 7;
            this.AddOblast.Text = "Добавить";
            this.AddOblast.UseVisualStyleBackColor = false;
            this.AddOblast.Click += new System.EventHandler(this.AddOblast_Click);
            // 
            // UpOblast
            // 
            this.UpOblast.BackColor = System.Drawing.Color.Black;
            this.UpOblast.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpOblast.ForeColor = System.Drawing.Color.White;
            this.UpOblast.Location = new System.Drawing.Point(1083, 249);
            this.UpOblast.Name = "UpOblast";
            this.UpOblast.Size = new System.Drawing.Size(197, 48);
            this.UpOblast.TabIndex = 6;
            this.UpOblast.Text = "Изменить";
            this.UpOblast.UseVisualStyleBackColor = false;
            this.UpOblast.Click += new System.EventHandler(this.UpOblast_Click);
            // 
            // DelOblast
            // 
            this.DelOblast.BackColor = System.Drawing.Color.Black;
            this.DelOblast.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelOblast.ForeColor = System.Drawing.Color.White;
            this.DelOblast.Location = new System.Drawing.Point(1286, 249);
            this.DelOblast.Name = "DelOblast";
            this.DelOblast.Size = new System.Drawing.Size(197, 48);
            this.DelOblast.TabIndex = 5;
            this.DelOblast.Text = "Удалить";
            this.DelOblast.UseVisualStyleBackColor = false;
            this.DelOblast.Click += new System.EventHandler(this.DelOblast_Click);
            // 
            // DataOblast
            // 
            this.DataOblast.AllowUserToAddRows = false;
            this.DataOblast.AllowUserToDeleteRows = false;
            this.DataOblast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOblast.Location = new System.Drawing.Point(12, 303);
            this.DataOblast.MultiSelect = false;
            this.DataOblast.Name = "DataOblast";
            this.DataOblast.ReadOnly = true;
            this.DataOblast.RowHeadersWidth = 51;
            this.DataOblast.RowTemplate.Height = 29;
            this.DataOblast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataOblast.Size = new System.Drawing.Size(1471, 385);
            this.DataOblast.TabIndex = 4;
            this.DataOblast.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataOblast_CellContentClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Название";
            // 
            // ObName
            // 
            this.ObName.Location = new System.Drawing.Point(371, 12);
            this.ObName.Name = "ObName";
            this.ObName.Size = new System.Drawing.Size(210, 27);
            this.ObName.TabIndex = 17;
            // 
            // RichOpic
            // 
            this.RichOpic.Location = new System.Drawing.Point(371, 56);
            this.RichOpic.Name = "RichOpic";
            this.RichOpic.Size = new System.Drawing.Size(503, 241);
            this.RichOpic.TabIndex = 20;
            this.RichOpic.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 47);
            this.label4.TabIndex = 27;
            this.label4.Text = "Область";
            // 
            // AdminOblast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RichOpic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ObName);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddOblast);
            this.Controls.Add(this.UpOblast);
            this.Controls.Add(this.DelOblast);
            this.Controls.Add(this.DataOblast);
            this.Name = "AdminOblast";
            this.Text = "AdminOblast";
            this.Load += new System.EventHandler(this.AdminOblast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataOblast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOblast;
        private System.Windows.Forms.Button UpOblast;
        private System.Windows.Forms.Button DelOblast;
        private System.Windows.Forms.DataGridView DataOblast;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ObName;
        private System.Windows.Forms.RichTextBox RichOpic;
        private System.Windows.Forms.Label label4;
    }
}