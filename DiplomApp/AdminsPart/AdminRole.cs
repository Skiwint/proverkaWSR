using DiplomApp.Clasess;
using DiplomApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomApp.AdminsPart
{
    public partial class AdminRole : Form
    {
        AllModel<Role> roles = new AllModel<Role>("Roles");
        public AdminRole()
        {
            InitializeComponent();
        }

        private async void AddRole_Click(object sender, EventArgs e)
        {
            try
            {
                Role role = new Role();
                role.RoleName = TextRole.Text;
                await role.Add();
                TextRole.Text = "";
                RoleData.DataSource = roles.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AdminRole_Load(object sender, EventArgs e)
        {
            RoleData.DataSource = roles.Objs;
        }

        private async void UpRole_Click(object sender, EventArgs e)
        {
            try
            {
                if (RoleData.SelectedRows[0].DataBoundItem is Role role)
                {
                    role.RoleName = TextRole.Text;
                    await role.Update();
                }
                TextRole.Text = "";
                RoleData.DataSource = roles.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelRole_Click(object sender, EventArgs e)
        {
            await(RoleData.SelectedRows[0].DataBoundItem as Role)!.Delete();
            RoleData.DataSource = roles.Objs;
        }

        private void AdminRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RoleData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextRole.Text = RoleData.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
