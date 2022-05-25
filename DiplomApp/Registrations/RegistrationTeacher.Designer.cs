namespace DiplomApp
{
    partial class RegistrationTeacher
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Otchestvo = new System.Windows.Forms.TextBox();
            this.Famil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.RegistrBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(58, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // Otchestvo
            // 
            this.Otchestvo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Otchestvo.Location = new System.Drawing.Point(255, 232);
            this.Otchestvo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Otchestvo.Name = "Otchestvo";
            this.Otchestvo.Size = new System.Drawing.Size(416, 31);
            this.Otchestvo.TabIndex = 13;
            // 
            // Famil
            // 
            this.Famil.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Famil.Location = new System.Drawing.Point(255, 189);
            this.Famil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Famil.Name = "Famil";
            this.Famil.Size = new System.Drawing.Size(416, 31);
            this.Famil.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя";
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name1.Location = new System.Drawing.Point(255, 145);
            this.Name1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(416, 31);
            this.Name1.TabIndex = 10;
            // 
            // RegistrBtn
            // 
            this.RegistrBtn.BackColor = System.Drawing.Color.Black;
            this.RegistrBtn.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistrBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RegistrBtn.Location = new System.Drawing.Point(255, 382);
            this.RegistrBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrBtn.Name = "RegistrBtn";
            this.RegistrBtn.Size = new System.Drawing.Size(370, 70);
            this.RegistrBtn.TabIndex = 18;
            this.RegistrBtn.Text = "Зарегестрироваться";
            this.RegistrBtn.UseVisualStyleBackColor = false;
            this.RegistrBtn.Click += new System.EventHandler(this.RegistrBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(300, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "Руководитель техникума";
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
            this.BackForm.TabIndex = 47;
            this.BackForm.Text = "Выйти";
            this.BackForm.UseVisualStyleBackColor = false;
            this.BackForm.Click += new System.EventHandler(this.BackForm_Click);
            // 
            // RegistrationTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 664);
            this.Controls.Add(this.BackForm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegistrBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Otchestvo);
            this.Controls.Add(this.Famil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrationTeacher";
            this.Text = "RegistrationTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Otchestvo;
        private System.Windows.Forms.TextBox Famil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Button RegistrBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackForm;
    }
}