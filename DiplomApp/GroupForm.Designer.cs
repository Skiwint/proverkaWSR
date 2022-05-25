namespace DiplomApp
{
    partial class GroupForm
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
            this.KyrsBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.AddGroup = new System.Windows.Forms.Button();
            this.UpGroup = new System.Windows.Forms.Button();
            this.DelGroup = new System.Windows.Forms.Button();
            this.DataGroup = new System.Windows.Forms.DataGridView();
            this.BackMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // KyrsBox
            // 
            this.KyrsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KyrsBox.FormattingEnabled = true;
            this.KyrsBox.Location = new System.Drawing.Point(464, 83);
            this.KyrsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.KyrsBox.Name = "KyrsBox";
            this.KyrsBox.Size = new System.Drawing.Size(439, 23);
            this.KyrsBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(371, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Курс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Название";
            // 
            // GroupText
            // 
            this.GroupText.Location = new System.Drawing.Point(464, 51);
            this.GroupText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupText.Name = "GroupText";
            this.GroupText.Size = new System.Drawing.Size(439, 23);
            this.GroupText.TabIndex = 21;
            // 
            // AddGroup
            // 
            this.AddGroup.BackColor = System.Drawing.Color.Black;
            this.AddGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddGroup.ForeColor = System.Drawing.Color.White;
            this.AddGroup.Location = new System.Drawing.Point(1032, 114);
            this.AddGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddGroup.Name = "AddGroup";
            this.AddGroup.Size = new System.Drawing.Size(172, 36);
            this.AddGroup.TabIndex = 20;
            this.AddGroup.Text = "Добавить";
            this.AddGroup.UseVisualStyleBackColor = false;
            this.AddGroup.Click += new System.EventHandler(this.AddGroup_Click);
            // 
            // UpGroup
            // 
            this.UpGroup.BackColor = System.Drawing.Color.Black;
            this.UpGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpGroup.ForeColor = System.Drawing.Color.White;
            this.UpGroup.Location = new System.Drawing.Point(1222, 114);
            this.UpGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpGroup.Name = "UpGroup";
            this.UpGroup.Size = new System.Drawing.Size(172, 36);
            this.UpGroup.TabIndex = 19;
            this.UpGroup.Text = "Изменить";
            this.UpGroup.UseVisualStyleBackColor = false;
            this.UpGroup.Click += new System.EventHandler(this.UpGroup_Click);
            // 
            // DelGroup
            // 
            this.DelGroup.BackColor = System.Drawing.Color.Black;
            this.DelGroup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DelGroup.ForeColor = System.Drawing.Color.White;
            this.DelGroup.Location = new System.Drawing.Point(1400, 114);
            this.DelGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelGroup.Name = "DelGroup";
            this.DelGroup.Size = new System.Drawing.Size(172, 36);
            this.DelGroup.TabIndex = 18;
            this.DelGroup.Text = "Удалить";
            this.DelGroup.UseVisualStyleBackColor = false;
            this.DelGroup.Click += new System.EventHandler(this.DelGroup_Click);
            // 
            // DataGroup
            // 
            this.DataGroup.AllowUserToAddRows = false;
            this.DataGroup.AllowUserToDeleteRows = false;
            this.DataGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGroup.Location = new System.Drawing.Point(10, 154);
            this.DataGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGroup.MultiSelect = false;
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.ReadOnly = true;
            this.DataGroup.RowHeadersWidth = 51;
            this.DataGroup.RowTemplate.Height = 29;
            this.DataGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGroup.Size = new System.Drawing.Size(1566, 514);
            this.DataGroup.TabIndex = 17;
            this.DataGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGroup_CellContentClick);
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.Color.Red;
            this.BackMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackMenu.ForeColor = System.Drawing.Color.White;
            this.BackMenu.Location = new System.Drawing.Point(10, 9);
            this.BackMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(130, 40);
            this.BackMenu.TabIndex = 25;
            this.BackMenu.Text = "Выйти";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 676);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.KyrsBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupText);
            this.Controls.Add(this.AddGroup);
            this.Controls.Add(this.UpGroup);
            this.Controls.Add(this.DelGroup);
            this.Controls.Add(this.DataGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KyrsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GroupText;
        private System.Windows.Forms.Button AddGroup;
        private System.Windows.Forms.Button UpGroup;
        private System.Windows.Forms.Button DelGroup;
        private System.Windows.Forms.DataGridView DataGroup;
        private System.Windows.Forms.Button BackMenu;
    }
}