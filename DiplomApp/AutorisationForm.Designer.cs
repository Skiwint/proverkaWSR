namespace DiplomApp
{
    partial class AutorisationForm
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
            this.RegFrm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(839, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 46);
            this.label3.TabIndex = 20;
            this.label3.Text = "АВТОРИЗАЦИЯ";
            // 
            // RegFrm
            // 
            this.RegFrm.BackColor = System.Drawing.Color.Black;
            this.RegFrm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegFrm.ForeColor = System.Drawing.Color.White;
            this.RegFrm.Location = new System.Drawing.Point(855, 615);
            this.RegFrm.Name = "RegFrm";
            this.RegFrm.Size = new System.Drawing.Size(248, 42);
            this.RegFrm.TabIndex = 19;
            this.RegFrm.Text = "Регистрация";
            this.RegFrm.UseVisualStyleBackColor = false;
            this.RegFrm.Click += new System.EventHandler(this.RegFrm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(580, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordText.Location = new System.Drawing.Point(682, 494);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(556, 36);
            this.PasswordText.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(580, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Логин";
            // 
            // LoginText
            // 
            this.LoginText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginText.Location = new System.Drawing.Point(682, 429);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(556, 36);
            this.LoginText.TabIndex = 15;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Black;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(773, 557);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(417, 52);
            this.SignIn.TabIndex = 14;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegFrm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.SignIn);
            this.Name = "AutorisationForm";
            this.Text = "AutorisationForm";
            this.Load += new System.EventHandler(this.AutorisationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegFrm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Button SignIn;
    }
}