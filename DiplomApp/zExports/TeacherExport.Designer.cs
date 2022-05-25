namespace DiplomApp.zExports
{
    partial class TeacherExport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.exportBox = new System.Windows.Forms.ComboBox();
            this.selectFiltr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.selectTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TeacherFilterText = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.DataFilter = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFilter)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1155, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.exportBox);
            this.tabPage3.Controls.Add(this.selectFiltr);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.selectTable);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.TeacherFilterText);
            this.tabPage3.Controls.Add(this.btnExport);
            this.tabPage3.Controls.Add(this.DataFilter);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1147, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Фильтр";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(805, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 30);
            this.label10.TabIndex = 31;
            this.label10.Text = "Выберете способ\r\nэкспорта";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exportBox
            // 
            this.exportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exportBox.FormattingEnabled = true;
            this.exportBox.Location = new System.Drawing.Point(925, 50);
            this.exportBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportBox.Name = "exportBox";
            this.exportBox.Size = new System.Drawing.Size(143, 23);
            this.exportBox.TabIndex = 30;
            // 
            // selectFiltr
            // 
            this.selectFiltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectFiltr.FormattingEnabled = true;
            this.selectFiltr.Location = new System.Drawing.Point(122, 90);
            this.selectFiltr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectFiltr.Name = "selectFiltr";
            this.selectFiltr.Size = new System.Drawing.Size(201, 23);
            this.selectFiltr.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Выберите фильтр";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Выберете таблицу";
            // 
            // selectTable
            // 
            this.selectTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTable.FormattingEnabled = true;
            this.selectTable.Location = new System.Drawing.Point(122, 29);
            this.selectTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTable.Name = "selectTable";
            this.selectTable.Size = new System.Drawing.Size(201, 23);
            this.selectTable.TabIndex = 26;
            this.selectTable.SelectedValueChanged += new System.EventHandler(this.selectTable_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Введите ";
            // 
            // TeacherFilterText
            // 
            this.TeacherFilterText.Location = new System.Drawing.Point(122, 136);
            this.TeacherFilterText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TeacherFilterText.Name = "TeacherFilterText";
            this.TeacherFilterText.Size = new System.Drawing.Size(201, 23);
            this.TeacherFilterText.TabIndex = 24;
            this.TeacherFilterText.Text = "Введите";
            this.TeacherFilterText.Click += new System.EventHandler(this.TeacherFilterText_Click);
            this.TeacherFilterText.TextChanged += new System.EventHandler(this.TeacherFilterText_TextChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Black;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(976, 131);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(165, 35);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "Экспортировать";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // DataFilter
            // 
            this.DataFilter.AllowUserToAddRows = false;
            this.DataFilter.AllowUserToDeleteRows = false;
            this.DataFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFilter.Location = new System.Drawing.Point(7, 171);
            this.DataFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataFilter.Name = "DataFilter";
            this.DataFilter.ReadOnly = true;
            this.DataFilter.RowHeadersWidth = 51;
            this.DataFilter.RowTemplate.Height = 29;
            this.DataFilter.Size = new System.Drawing.Size(1287, 301);
            this.DataFilter.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1155, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // TeacherExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 525);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherExport";
            this.Text = "TeacherExport";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFilter)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView DataFilter;
        private System.Windows.Forms.TextBox TeacherFilterText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectFiltr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox selectTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox exportBox;
    }
}