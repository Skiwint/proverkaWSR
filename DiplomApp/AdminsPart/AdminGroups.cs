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
    public partial class AdminGroups : Form
    {
        AllModel<Group> groups = new AllModel<Group>("Groups");
        public string[] kyrs =
        {
            "3 Курс",
            "4 курс"
        };
        public AdminGroups()
        {
            InitializeComponent();
            GetKyrsForGroup();
        }
        private void GetKyrsForGroup()
        {
            KyrsBox.Items.Add(kyrs[0]);
            KyrsBox.Items.Add(kyrs[1]);
            KyrsBox.SelectedIndex = 1;
        }
        private async void AddGroup_Click(object sender, EventArgs e)
        {
            
            try
            {
                await new Group
                {
                    Id = 0,
                    Name = GroupText.Text,
                    Kyrs = KyrsBox.SelectedItem.ToString()!,
                }.Add();
                GroupText.Text = "";
                DataGroup.DataSource = groups.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGroup.SelectedRows[0].DataBoundItem is Group group)
                {
                    group.Name = GroupText.Text;
                    group.Kyrs = KyrsBox.SelectedItem.ToString();
                    await group.Update();
                }
                DataGroup.DataSource = groups.Objs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DelGroup_Click(object sender, EventArgs e)
        {
            await(DataGroup.SelectedRows[0].DataBoundItem as Group)!.Delete();
            DataGroup.DataSource = groups.Objs;
        }

        private void DataGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GroupText.Text = DataGroup.Rows[e.RowIndex].Cells[1].Value.ToString();
            KyrsBox.Text = DataGroup.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void AdminGroups_Load(object sender, EventArgs e)
        {
            DataGroup.DataSource = groups.Objs;
        }

        private void AdminGroups_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }   
}
