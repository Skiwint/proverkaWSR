namespace DiplomApp.AdminsPart
{
    partial class AdminUsers
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
            this.DataUser = new System.Windows.Forms.DataGridView();
            this.DelUser = new System.Windows.Forms.Button();
            this.UpUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.BackForm = new System.Windows.Forms.Button();
            this.RoleID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DataUser
            // 
            this.DataUser.AllowUserToAddRows = false;
            this.DataUser.AllowUserToDeleteRows = false;
            this.DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUser.Location = new System.Drawing.Point(12, 303);
            this.DataUser.MultiSelect = false;
            this.DataUser.Name = "DataUser";
            this.DataUser.ReadOnly = true;
            this.DataUser.RowHeadersWidth = 51;
            this.DataUser.RowTemplate.Height = 29;
            this.DataUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataUser.Size = new System.Drawing.Size(1471, 385);
            this.DataUser.TabIndex = 0;
            this.DataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUser_CellContentClick);
            // 
            // DelUser
            // 
            this.DelUser.BackColor = System.Drawing.Color.Black;
            this.DelUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelUser.ForeColor = System.Drawing.Color.White;
            this.DelUser.Location = new System.Drawing.Point(1286, 249);
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(197, 48);
            this.DelUser.TabIndex = 1;
            this.DelUser.Text = "Удалить";
            this.DelUser.UseVisualStyleBackColor = false;
            this.DelUser.Click += new System.EventHandler(this.DelUser_Click);
            // 
            // UpUser
            // 
            this.UpUser.BackColor = System.Drawing.Color.Black;
            this.UpUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpUser.ForeColor = System.Drawing.Color.White;
            this.UpUser.Location = new System.Drawing.Point(1083, 249);
            this.UpUser.Name = "UpUser";
            this.UpUser.Size = new System.Drawing.Size(197, 48);
            this.UpUser.TabIndex = 2;
            this.UpUser.Text = "Изменить";
            this.UpUser.UseVisualStyleBackColor = false;
            this.UpUser.Click += new System.EventHandler(this.UpUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.Black;
            this.AddUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUser.ForeColor = System.Drawing.Color.White;
            this.AddUser.Location = new System.Drawing.Point(880, 249);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(197, 48);
            this.AddUser.TabIndex = 3;
            this.AddUser.Text = "Добавить";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
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
            // RoleID
            // 
            this.RoleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleID.FormattingEnabled = true;
            this.RoleID.Location = new System.Drawing.Point(150, 220);
            this.RoleID.Name = "RoleID";
            this.RoleID.Size = new System.Drawing.Size(284, 28);
            this.RoleID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(46, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Роль*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 18;
            this.label1.Text = "Логин";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(150, 148);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(284, 27);
            this.Login.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Пароль";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(150, 181);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(284, 27);
            this.Password.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(189, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 47);
            this.label4.TabIndex = 23;
            this.label4.Text = "Пользователи";
            // 
            // AdminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1495, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.RoleID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.UpUser);
            this.Controls.Add(this.DelUser);
            this.Controls.Add(this.DataUser);
            this.Name = "AdminUsers";
            this.Text = "AdminUsers";
            this.Load += new System.EventHandler(this.AdminUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataUser;
        private System.Windows.Forms.Button DelUser;
        private System.Windows.Forms.Button UpUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button BackForm;
        private System.Windows.Forms.ComboBox RoleID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label4;
    }
}