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

namespace DiplomApp.AdminsPart
{
    public partial class AdminUsers : Form
    {
        AllModel<Role> roles = new AllModel<Role>("Roles");
        AllModel<User> users = new AllModel<User>("Users");

        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            
            RoleID.DataSource = roles.Objs;
            RoleID.DisplayMember = "RoleName";
            RoleID.ValueMember = "Id";

            DataUser.DataSource = users.Objs;
            DataUser.Columns[3].Visible = false;

        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private async void AddUser_Click(object sender, EventArgs e)
        {
            var Pass = GetHash(Password.Text);
            await new User
            {
                Id = 0,
                Login = Login.Text,
                Password = Pass,
                RoleId = RoleID.SelectedValue as int?,
            }.Add();
            DataUser.DataSource = users.Objs;
        }

        private async void UpUser_Click(object sender, EventArgs e)
        {
            if (DataUser.SelectedRows[0].DataBoundItem is User user)
            {
                user.Login = Login.Text;
                user.Password = GetHash(Password.Text);
                user.RoleId = RoleID.SelectedValue as int?;
                await user.Update();
            }
            DataUser.DataSource = users.Objs;
        }

        private async void DelUser_Click(object sender, EventArgs e)
        {
            await(DataUser.SelectedRows[0].DataBoundItem as User)!.Delete();
            DataUser.DataSource = users.Objs;
        }

        private void DataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Login.Text = DataUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            Password.Text = DataUser.Rows[e.RowIndex].Cells[2].Value.ToString();
            RoleID.Text = DataUser.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BackForm_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
