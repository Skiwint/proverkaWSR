namespace DiplomApp.AdminsPart
{
    partial class AdminRole
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
            this.AddRole = new System.Windows.Forms.Button();
            this.UpRole = new System.Windows.Forms.Button();
            this.DelRole = new System.Windows.Forms.Button();
            this.RoleData = new System.Windows.Forms.DataGridView();
            this.BackForm = new System.Windows.Forms.Button();
            this.TextRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RoleData)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRole
            // 
            this.AddRole.BackColor = System.Drawing.Color.Black;
            this.AddRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddRole.ForeColor = System.Drawing.Color.White;
            this.AddRole.Location = new System.Drawing.Point(880, 249);
            this.AddRole.Name = "AddRole";
            this.AddRole.Size = new System.Drawing.Size(197, 48);
            this.AddRole.TabIndex = 7;
            this.AddRole.Text = "Добавить";
            this.AddRole.UseVisualStyleBackColor = false;
            this.AddRole.Click += new System.EventHandler(this.AddRole_Click);
            // 
            // UpRole
            // 
            this.UpRole.BackColor = System.Drawing.Color.Black;
            this.UpRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpRole.ForeColor = System.Drawing.Color.White;
            this.UpRole.Location = new System.Drawing.Point(1083, 249);
            this.UpRole.Name = "UpRole";
            this.UpRole.Size = new System.Drawing.Size(197, 48);
            this.UpRole.TabIndex = 6;
            this.UpRole.Text = "Изменить";
            this.UpRole.UseVisualStyleBackColor = false;
            this.UpRole.Click += new System.EventHandler(this.UpRole_Click);
            // 
            // DelRole
            // 
            this.DelRole.BackColor = System.Drawing.Color.Black;
            this.DelRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelRole.ForeColor = System.Drawing.Color.White;
            this.DelRole.Location = new System.Drawing.Point(1286, 249);
            this.DelRole.Name = "DelRole";
            this.DelRole.Size = new System.Drawing.Size(197, 48);
            this.DelRole.TabIndex = 5;
            this.DelRole.Text = "Удалить";
            this.DelRole.UseVisualStyleBackColor = false;
            this.DelRole.Click += new System.EventHandler(this.DelRole_Click);
            // 
            // RoleData
            // 
            this.RoleData.AllowUserToAddRows = false;
            this.RoleData.AllowUserToDeleteRows = false;
            this.RoleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleData.Location = new System.Drawing.Point(12, 303);
            this.RoleData.MultiSelect = false;
            this.RoleData.Name = "RoleData";
            this.RoleData.ReadOnly = true;
            this.RoleData.RowHeadersWidth = 51;
            this.RoleData.RowTemplate.Height = 29;
            this.RoleData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RoleData.Size = new System.Drawing.Size(1471, 385);
            this.RoleData.TabIndex = 4;
            this.RoleData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RoleData_CellContentClick);
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
            this.BackForm.Click += new System.EventHandler(this.button4_Click);
            // 
            // TextRole
            // 
            this.TextRole.Location = new System.Drawing.Point(186, 193);
            this.TextRole.Name = "TextRole";
            this.TextRole.Size = new System.Drawing.Size(210, 27);
            this.TextRole.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название роли";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(186, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 47);
            this.label4.TabIndex = 26;
            this.label4.Text = "Роль";
            // 
            // AdminRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextRole);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddRole);
            this.Controls.Add(this.UpRole);
            this.Controls.Add(this.DelRole);
            this.Controls.Add(this.RoleData);
            this.Name = "AdminRole";
            this.Text = "AdminRole";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminRole_FormClosed);
            this.Load += new System.EventHandler(this.AdminRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddRole;
        private System.Windows.Forms.Button UpRole;
        private System.Windows.Forms.Button DelRole;
        private System.Windows.Forms.DataGridView RoleData;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.TextBox TextRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}