using DiplomApp.Clasess;
using DiplomApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomApp
{
    public partial class RegistrationForm : Form
    {
        AllModel<User> users = new AllModel<User>("Users");
        AllModel<Role> roles = new AllModel<Role>("Roles");
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        private void RegBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleBox.Text == "Администратор")
                    return;

                var user = new User() { Login = Login.Text, Password = GetHash(Password.Text), RoleId = (int)RoleBox.SelectedValue };
                Form? form = (RoleBox.SelectedItem as Role) switch
                {
                    { RoleName: "Руководитель техникума" } => new RegistrationTeacher(user),
                    { RoleName: "Студент" } => new RegistrationStudent(user),
                    { RoleName: "Руководитель Орг." } => new RegistrationRykovod(user),
                    _ => null,
                };
                form?.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            RoleBox.DataSource = roles.Objs;
            RoleBox.ValueMember = "Id";
            RoleBox.DisplayMember = "RoleName";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AutorisationForm autorisation = new AutorisationForm();
            autorisation.Show();
            this.Close();
        }
    }
}
